﻿using NeuroPlayClient.Forms.SettingsForms;
using NeuroPlayClient.Models;
using NeuroPlayClient.Services;
using NeuroPlayClient.Services.Interfaces;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NeuroPlayClient.Forms {
    public partial class FiguresExperimentSettings : BaseExperimentSettingsForm {
        public FiguresExperimentSettings(INeuroPlayService neuroPlayService, IFileSystemService fileSystemService, ISettingsService settingsService, Form authForm)
            : base(neuroPlayService, fileSystemService, settingsService, authForm) {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, System.EventArgs e) {
            int countIteration = (int)nudCountIterations.Value;
            double durationShow = (double)nudDurationShow.Value;
            double durationPause = (double)numDurationPause.Value;

            var parametersExperiment = new List<SettingFigures>();
            var listShowValues = GetListPossibleValues(durationShow);
            var listPauseValues = GetListPossibleValues(durationPause);

            for (int i = 0; i < countIteration; i++) {
                parametersExperiment.Add(new SettingFigures {
                    DurationShow = listShowValues[_rnd.Next(0, listShowValues.Count)],
                    DurationPause = listPauseValues[_rnd.Next(0, listPauseValues.Count)],
                    IsGreenImage = _rnd.Next() % 2 == 0
                });
            }
            parametersExperiment[countIteration - 1].DurationPause = 0;
            var experimentForm = new FiguresExperiment(_neuroPlayService, _fileSystemService, parametersExperiment, _settingsService, _authForm);
            experimentForm.Show();
            isStarted = true;
            Close();
        }

        private void FiguresExperimentSettings_FormClosed(object sender, FormClosedEventArgs e) {
            _fileSystemService.SaveUserSettingsToFile(_settingsService.GetSettings().Data);

            if (!isStarted)
                Application.Exit();
        }

        private void label6_Click(object sender, System.EventArgs e) {
            Close();
        }
    }
}
 