using NeuroPlayClient.Models;
using NeuroPlayClient.Properties;
using NeuroPlayClient.Resources;
using NeuroPlayClient.Services;
using NeuroPlayClient.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuroPlayClient.Forms {
    public partial class FiguresExperiment : Form {
        private readonly INeuroPlayService _neuroPlayService;
        private readonly IFileSystemService _fileSystemService;
        private readonly List<SettingFigures> _settings;
        private TimesMarker[] _markers;
        private int _currentImage = 0;
        private DateTime _startTime;

        public FiguresExperiment(INeuroPlayService neuroPlayService, IFileSystemService fileSystemService, List<SettingFigures> settings) {
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
                pbImage.Image = _settings[i].IsGreenImage ? Image.FromFile(Messages.GreenImagePath) : Image.FromFile(Messages.RedImagePath);
                _markers[i].TimeShowImages = DateTime.Now;
                await Task.Delay((int)(_settings[i].DurationShow * 1000));
                pbImage.Image = null;
                await Task.Delay((int)(_settings[i].DurationPause * 1000));
                _currentImage++;
            }

            await AddMarkers();
            await Task.Delay(2000);
            await _neuroPlayService.StopRecordAsync();

            var dialogResult =  MessageBox.Show(Messages.FinishedExperiment, "Эксперимент окончен", MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.Yes) {
                await StartExperiment();
                return;
            }
            else {
                Close();
            }
        }

        private async void Experiment1Form_Load(object sender, EventArgs e) {
            await StartExperiment();
        }

        private async Task AddMarkers() {
            _fileSystemService.OpenLoggerConnection();

            for (int i = 0; i < _markers.Length; i++) {
                if (_markers[i].TimeShowImages != default) {
                    string timeShowInMs = Math.Round((_markers[i].TimeShowImages - _startTime).TotalMilliseconds).ToString();
                    // Show green circle - ПЗ, Show red circle - ПК
                    string text = _settings[i].IsGreenImage ? Messages.ShowGreenImage : Messages.ShowRedImage;
                    var result = await _neuroPlayService.AddMarkerAsync(timeShowInMs, text);
                    await _fileSystemService.WriteLogAsync($"position - {timeShowInMs}; text - {text}; result - {result}");

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

        private void Experiment1Form_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space) {
                _markers[_currentImage].TimePressKey = DateTime.Now;
            }
        }
    }
}
