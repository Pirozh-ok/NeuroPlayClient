using NeuroPlayClient.Models;
using NeuroPlayClient.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuroPlayClient.Forms {
    public partial class FiguresExperiment : Form {
        private readonly INeuroPlayService _neuroPlayService;
        private readonly List<SettingFigures> _settings;
        private TimesMarker [] _markers;
        private StreamWriter sw;
        private int _currentImage = 0;
        private DateTime _startTime;

        public FiguresExperiment(INeuroPlayService neuroPlayService, List<SettingFigures> settings) {
            InitializeComponent();
            _neuroPlayService = neuroPlayService;
            _settings = settings;
            _markers = new TimesMarker[settings.Count];
        }

        private async Task StartExperiment() {
            _startTime = DateTime.Now;

            for(int i = 0; i < _settings.Count; i++) {
                pbImage.Image = _settings[i].IsGreenImage ? Image.FromFile("../../Images/green-circle.png") : Image.FromFile("../../Images/red-circle.png");
                _markers[i].TimeShowImages = DateTime.Now;
                await Task.Delay((int)(_settings[i].DurationShow * 1000));
                pbImage.Image = null;
                await Task.Delay((int)(_settings[i].DurationPause * 1000));
                _currentImage++;
            }

            if (await AddMarkers()) {
                await Task.Delay(2000);
                await _neuroPlayService.StopRecordAsync();
            }
            sw.Close();
        }

        private async void Experiment1Form_Load(object sender, EventArgs e) {
            await StartExperiment();
        }

        private async Task<bool> AddMarkers() {
            for (int i = 0; i < Settings.CountIteration; i++) {
                if (_markers[i].TimeShowImages != default) {
                    string timeShowInMs = Math.Round((_markers[i].TimeShowImages - _startTime).TotalMilliseconds).ToString();
                    // Show green circle - 1, Show red circle - 0
                    string text = flagsImages[i] ? "1" : "0";
                    var result = await _neuroPlayService.AddMarkerAsync(timeShowInMs, text);
                    sw.WriteLine($"position - {timeShowInMs}; text - {text}; result - {result}");

                    if (_markers[i].TimePressKey != null) {
                        string timePressKeyInMs = Math.Round(((DateTime)_markers[i].TimePressKey - _startTime).TotalMilliseconds - _cleanDelayInMs).ToString();
                        // User pressed space - 2
                        var result1 = await _neuroPlayService.AddMarkerAsync(timePressKeyInMs, "2");
                        sw.WriteLine($"position - {timePressKeyInMs}; user pressed space; result - {result1}");
                    }
                }
            }

            return true;
        }

        private void Experiment1Form_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Space) {
                _markers[_currentImage].TimePressKey = DateTime.Now;
            }
        }
    }
}
