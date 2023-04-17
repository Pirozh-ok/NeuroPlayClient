﻿using NeuroPlayClient.Forms.SettingsForms;
using NeuroPlayClient.Models;
using NeuroPlayClient.Services;
using NeuroPlayClient.Services.Interfaces;
using System.Collections.Generic;

namespace NeuroPlayClient.Forms {
    public partial class FiguresExperimentSettings : BaseExperimentSettingsForm {
        public FiguresExperimentSettings(INeuroPlayService neuroPlayService, IFileSystemService fileSystemService, User userData)
            : base(neuroPlayService, fileSystemService, userData) {
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
                }) ;
            }

            var experimentForm = new FiguresExperiment(_neuroPlayService, _fileSystemService, parametersExperiment);
            experimentForm.Show();
        }
    }
}
