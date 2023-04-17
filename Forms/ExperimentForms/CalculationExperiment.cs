using NeuroPlayClient.Models;
using NeuroPlayClient.Services.Interfaces;
using NeuroPlayClient.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NeuroPlayClient.Resources;
using System.Threading.Tasks;

namespace NeuroPlayClient.Forms.ExperimentForms {
    public partial class CalculationExperiment : Form {
        private readonly INeuroPlayService _neuroPlayService;
        private readonly IFileSystemService _fileSystemService;
        private readonly List<SettingsCalculation> _settings;
        private TimesMarker[] _markers;
        private int _currentImage = 0;
        private DateTime _startTime;

        public CalculationExperiment(INeuroPlayService neuroPlayService, IFileSystemService fileSystemService, List<SettingsCalculation> settings) {
            InitializeComponent();
            _neuroPlayService = neuroPlayService;
            _fileSystemService = fileSystemService;
            _settings = settings;
            _markers = new TimesMarker[settings.Count];
        }

        private async Task StartExperiment() {
            _currentImage = 0;
            Array.Clear(_markers, 0, _markers.Length);
            _markers = new TimesMarker[_settings.Count];

            for (int i = 0; i < _markers.Length; i++) {
                _markers[i] = new TimesMarker();
            }

            _startTime = DateTime.Now;
            await _neuroPlayService.StartRecordAsync();

            for (int i = 0; i < _settings.Count; i++) {
                lblCalculationTask.Text = $"{_settings[i].CalculationTask} = ?";
                _markers[i].TimeShowImages = DateTime.Now;
                await Task.Delay((int)(_settings[i].DurationShow * 1000));
                lblCalculationTask.Text = string.Empty;
                await Task.Delay((int)(_settings[i].DurationPause * 1000));
                _currentImage++;
            }

            var dialogResult = MessageBox.Show(Messages.FinishedExperiment, Messages.FinishedExperimentTitle, MessageBoxButtons.YesNo);

            await AddMarkers();
            await Task.Delay(2000);
            await _neuroPlayService.StopRecordAsync();

            if (dialogResult == DialogResult.Yes) {
                await StartExperiment();
                return;
            }
            else {
                Close();
            }
        }

        private async Task AddMarkers() {
            _fileSystemService.OpenLoggerConnection();

            for (int i = 0; i < _markers.Length; i++) {
                if (_markers[i].TimeShowImages != default) {
                    string timeShowInMs = Math.Round((_markers[i].TimeShowImages - _startTime).TotalMilliseconds).ToString();
                    // Show green circle - ПЗ, Show red circle - ПК
                    string text = $"{Messages.ShowMarkers}:{_settings[i].CalculationTask}";
                    var result = await _neuroPlayService.AddMarkerAsync(timeShowInMs, text);
                    await _fileSystemService.WriteLogAsync($"position - {timeShowInMs}; text - {text}; result - {result}\n");

                    if (_markers[i].TimePressKey != null) {
                        string timePressKeyInMs = Math.Round(((DateTime)_markers[i].TimePressKey - _startTime).TotalMilliseconds).ToString();
                        // User pressed space - НП
                        var result1 = await _neuroPlayService.AddMarkerAsync(timePressKeyInMs, Messages.UserPressedButton);
                        await _fileSystemService.WriteLogAsync($"position - {timePressKeyInMs}; user pressed space; result - {result1}");
                    }
                }
            }

            _fileSystemService.CloseLoggerConnection();
        }

        private void CalculationExperiment_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space) {
                _markers[_currentImage].TimePressKey = DateTime.Now;
            }
        }

        private async void CalculationExperiment_Load(object sender, EventArgs e) {
            await StartExperiment();
        }
    }
}
