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
        private DateTime _startTime;
        private List<string> words = new List<string>();

        public SoundsExperimentSettings(
            INeuroPlayService neuroPlayService, 
            IFileSystemService fileSystemService, 
            ISettingsService settingsService
            , Form authForm) : base(neuroPlayService, fileSystemService, settingsService, authForm) {
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
            ActiveControl = null;

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

            parametersExperiment[countIteration - 1].DurationPause = 0;

            await Task.Delay(1000);
            _startTime = DateTime.Now;
            await _neuroPlayService.StartRecordAsync();
            await _neuroPlayService.AddMarkerAsync("0", $"id:{_settingsService.GetExperimentId().Data}");
            await Task.Delay(1000);

            //play sounds
            for (int i = 0; i < parametersExperiment.Count; i++) {
                _speech.SpeakAsync(parametersExperiment[i].Word);

                string timeShowInMs = Math.Round((DateTime.Now - _startTime).TotalMilliseconds).ToString();
                // CC:"speaked word"
                string text = $"{Messages.ShowMarkers}:{parametersExperiment[i].Word}";
                await _neuroPlayService.AddMarkerAsync(timeShowInMs, text);

                await Task.Delay((int)(parametersExperiment[i].DurationPause * 1000));
            }

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

        private void SoundsExperimentSettings_FormClosed(object sender, FormClosedEventArgs e) {
            _fileSystemService.SaveUserSettingsToFile(_settingsService.GetSettings().Data);

            if (!_authForm.Visible)
                Application.Exit();
        }

        private async void SoundsExperimentSettings_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space) {
                //_markers[_currentImage].TimePressKey = DateTime.Now;
                string timePressKeyInMs = Math.Round((DateTime.Now - _startTime).TotalMilliseconds).ToString();
                // User pressed space - НП
                await _neuroPlayService.AddMarkerAsync(timePressKeyInMs, Messages.UserPressedButton);
            }
        }
    }
}
