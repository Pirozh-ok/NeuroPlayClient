using NeuroPlayClient.Models;
using NeuroPlayClient.Resources;
using NeuroPlayClient.Services;
using NeuroPlayClient.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuroPlayClient.Forms {
    public partial class FiguresExperiment : Form {
        private readonly INeuroPlayService _neuroPlayService;
        private readonly IFileSystemService _fileSystemService;
        private readonly ISettingsService _settingsService;
        private readonly List<SettingFigures> _settings;
        private DateTime _startTime;
        private readonly Form _authForm;

        public FiguresExperiment(INeuroPlayService neuroPlayService, IFileSystemService fileSystemService, 
            List<SettingFigures> settings, ISettingsService settingsService, Form authForm) {
            InitializeComponent();
            _neuroPlayService = neuroPlayService;
            _fileSystemService = fileSystemService;
            _settingsService = settingsService;
            _settings = settings;
            _authForm = authForm;
        }

        private async Task StartExperiment() {

            _startTime = DateTime.Now;
            await _neuroPlayService.StartRecordAsync();
            await _neuroPlayService.AddMarkerAsync("0", $"id:{_settingsService.GetExperimentId().Data}");
            await Task.Delay(1000);

            for (int i = 0; i < _settings.Count; i++) {
                pbImage.Image = _settings[i].IsGreenImage ? Image.FromFile(Messages.GreenImagePath) : Image.FromFile(Messages.RedImagePath);

                string text = _settings[i].IsGreenImage ? Messages.ShowGreenImage : Messages.ShowRedImage;
                var result = await _neuroPlayService.AddMarkerAsync((_startTime - DateTime.Now).Milliseconds.ToString(), text);

                await Task.Delay((int)(_settings[i].DurationShow * 1000));
                pbImage.Image = null;
                await Task.Delay((int)(_settings[i].DurationPause * 1000));
            }

            Hide();

            await Task.Delay(2000);
            await _neuroPlayService.StopRecordAsync();
                await _fileSystemService.SaveUserExperimentToFile(_settingsService.GetSettingsToString().Data);
            _settingsService.IncrementIdExperiment();

            var dialogResult = MessageBox.Show(Messages.FinishedExperiment, Messages.FinishedExperimentTitle, MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes) {
                Close();
                _authForm.Show();
                return;
            }
            else {
                Application.Exit();
            }
        }

        private async void Experiment1Form_Load(object sender, EventArgs e) {
            await StartExperiment();
        }

        private async void Experiment1Form_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space) {
                await _neuroPlayService.AddMarkerAsync((_startTime - DateTime.Now).Milliseconds.ToString(), Messages.UserPressedButton);
            }
        }

        private async void FiguresExperiment_FormClosing(object sender, FormClosingEventArgs e) {
            await _neuroPlayService.StopRecordAsync();
        }
    }
}
