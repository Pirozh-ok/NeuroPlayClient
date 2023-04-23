using NeuroPlayClient.Forms.SettingsForms;
using NeuroPlayClient.Models;
using NeuroPlayClient.Services.Interfaces;
using NeuroPlayClient.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NeuroPlayClient.Models.JsonResponseModels;
using System.IO;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using NeuroPlayClient.Resources;
using System.Linq;

namespace NeuroPlayClient.Forms.Settings {
    public partial class SoundsExperimentSettings : BaseExperimentSettingsForm {
        private SpeechSynthesizer _speech;
        private TimesMarker[] _markers;
        private int _currentImage = 0;
        private DateTime _startTime;
        private List<string> words = new List<string>();

        public SoundsExperimentSettings(INeuroPlayService neuroPlayService, IFileSystemService fileSystemService, ISettingsService settingsService)
            : base(neuroPlayService, fileSystemService, settingsService) {
            InitializeComponent();
            _speech = new SpeechSynthesizer();
            _speech.Volume = 100;  // 0...100
            _speech.Rate = 0;
        }

        private async void btnStart_Click(object sender, EventArgs e) {
            btnStart.Enabled = false;
            using (var sr = new StreamReader("../../words1.txt")) {
                while (!sr.EndOfStream) {
                    words.Add(sr.ReadLine());
                }
            }

            await StartExperiment();
            btnStart.Enabled = true;
        }

        private async Task StartExperiment() {
            int countIteration = (int)nudCountIterations.Value;
            double durationPause = (double)nudPauseDuration.Value;
            var parametersExperiment = new List<SettingsSound>();
            var listPauseValues = GetListPossibleValues(durationPause);

            for (int i = 0; i < countIteration; i++) {
                parametersExperiment.Add(new SettingsSound {
                    DurationPause = listPauseValues[_rnd.Next(0, listPauseValues.Count)],
                    Word = words[_rnd.Next(0, words.Count)]
                });
            }

            _currentImage = 0;
            if (_markers != null)
                Array.Clear(_markers, 0, _markers.Length);
            _markers = new TimesMarker[parametersExperiment.Count];

            for (int i = 0; i < _markers.Length; i++) {
                _markers[i] = new TimesMarker();
            }

            await Task.Delay(1000);
            _startTime = DateTime.Now;
            await _neuroPlayService.StartRecordAsync();

            //play sounds
            for (int i = 0; i < parametersExperiment.Count; i++) {
                _markers[i].TimeShowImages = DateTime.Now;
                _speech.SpeakAsync(parametersExperiment[i].Word);
                await Task.Delay((int)(parametersExperiment[i].DurationPause * 1000));
                _currentImage++;
            }

            await AddMarkers(parametersExperiment.Select(x => x.Word).ToList());
            await Task.Delay(2000);
            await _neuroPlayService.StopRecordAsync();
            await _fileSystemService.SaveUserExperimentToFile(_settingsService.GetSettingsToString().Data);
            _settingsService.IncrementIdExperiment();

            var dialogResult = MessageBox.Show(Messages.FinishedExperiment, Messages.FinishedExperimentTitle, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                await StartExperiment();
                return;
            }
        }

        private async Task AddMarkers(List<string> words) {
            _fileSystemService.OpenLoggerConnection();

            for (int i = 0; i < _markers.Length; i++) {
                if (_markers[i].TimeShowImages != default) {
                    string timeShowInMs = Math.Round((_markers[i].TimeShowImages - _startTime).TotalMilliseconds).ToString();
                    // CC:"speaked word"
                    string text = $"{Messages.ShowMarkers}:{words[i]}";
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

        private void SoundsExperimentSettings_FormClosed(object sender, FormClosedEventArgs e) {
            _fileSystemService.SaveUserSettingsToFile(_settingsService.GetSettings().Data);
            Application.Exit();
        }

        private void SoundsExperimentSettings_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space) {
                _markers[_currentImage].TimePressKey = DateTime.Now;
            }
        }
    }
}
