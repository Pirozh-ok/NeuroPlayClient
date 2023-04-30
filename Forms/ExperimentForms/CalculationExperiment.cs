using NeuroPlayClient.Models;
using NeuroPlayClient.Services.Interfaces;
using NeuroPlayClient.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NeuroPlayClient.Resources;
using System.Threading.Tasks;
using NeuroPlayClient.Services.Implementations;

namespace NeuroPlayClient.Forms.ExperimentForms {
    public partial class CalculationExperiment : Form {
        private readonly INeuroPlayService _neuroPlayService;
        private readonly IFileSystemService _fileSystemService;
        private readonly List<SettingsCalculation> _settings;
        private readonly ISettingsService _settingsService;
        private DateTime _startTime;
        private Form _authForm;

        public CalculationExperiment(
            INeuroPlayService neuroPlayService, 
            IFileSystemService fileSystemService, 
            List<SettingsCalculation> settings, 
            ISettingsService settingsService,
            Form authForm) {
            InitializeComponent();
            _neuroPlayService = neuroPlayService;
            _fileSystemService = fileSystemService;
            _settings = settings;
            _settingsService = settingsService;
            _authForm = authForm;
        }

        private async Task StartExperiment() {
            await _fileSystemService.SaveUserExperimentToFile(_settingsService.GetSettingsToString().Data);
            _settingsService.IncrementIdExperiment();
            await _fileSystemService.SaveUserSettingsToFile(_settingsService.GetSettings().Data);

            _startTime = DateTime.Now;
            await _neuroPlayService.StartRecordAsync();
            await _neuroPlayService.AddMarkerAsync("0", $"id:{_settingsService.GetExperimentId().Data}");
            await Task.Delay(1000);

            for (int i = 0; i < _settings.Count; i++) {
                lblCalculationTask.Text = $"{_settings[i].CalculationTask} = ?";

                string timeShowInMs = Math.Round((DateTime.Now - _startTime).TotalMilliseconds).ToString();
                string text = $"{Messages.ShowMarkers}:{_settings[i].CalculationTask}";
                await _neuroPlayService.AddMarkerAsync(timeShowInMs, text);

                await Task.Delay((int)(_settings[i].DurationShow * 1000));
                lblCalculationTask.Text = string.Empty;
                await Task.Delay((int)(_settings[i].DurationPause * 1000));
            }

            Hide();

            await Task.Delay(2000);
            await _neuroPlayService.StopRecordAsync();

            var dialogResult = MessageBox.Show(Messages.FinishedExperiment, Messages.FinishedExperimentTitle, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                _authForm.Show();
                Close();
                return;
            }
            else {
                Close();
            }
        }

        private async void CalculationExperiment_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space) {
                string timePressKeyInMs = Math.Round((DateTime.Now - _startTime).TotalMilliseconds).ToString();
                // User pressed space - НП
                await _neuroPlayService.AddMarkerAsync(timePressKeyInMs, Messages.UserPressedButton);
            }
        }

        private async void CalculationExperiment_Load(object sender, EventArgs e) {
            await StartExperiment();
        }

        private async void CalculationExperiment_FormClosing(object sender, FormClosingEventArgs e) {
            await _neuroPlayService.StopRecordAsync();

            if (!_authForm.Visible) {
                Application.Exit();
            }
        }
    }
}
