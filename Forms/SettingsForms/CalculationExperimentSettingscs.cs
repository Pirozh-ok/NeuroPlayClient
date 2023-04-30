using NeuroPlayClient.Forms.SettingsForms;
using NeuroPlayClient.Models;
using NeuroPlayClient.Services.Interfaces;
using NeuroPlayClient.Services;
using System.Windows.Forms;
using System.Collections.Generic;
using NeuroPlayClient.Forms.ExperimentForms;

namespace NeuroPlayClient.Forms.Settings {
    public partial class CalculationExperimentSettings : BaseExperimentSettingsForm {
        public CalculationExperimentSettings(
            INeuroPlayService neuroPlayService, 
            IFileSystemService fileSystemService, 
            ISettingsService settingsService,
            Form authForm) : base(neuroPlayService, fileSystemService, settingsService, authForm) {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, System.EventArgs e) {
            int countIteration = (int)nudCoundIteration.Value;
            double durationShow = (double)nudDurationShow.Value;
            double durationPause = (double)nudDurationPause.Value;

            var parametersExperiment = new List<SettingsCalculation>();
            var listShowValues = GetListPossibleValues(durationShow);
            var listPauseValues = GetListPossibleValues(durationPause);

            for (int i = 0; i < countIteration; i++) {
                parametersExperiment.Add(new SettingsCalculation {
                    DurationShow = listShowValues[_rnd.Next(0, listShowValues.Count)],
                    DurationPause = listPauseValues[_rnd.Next(0, listPauseValues.Count)],
                    CalculationTask = GenerateCalculationTask()
                });
            }

            parametersExperiment[countIteration - 1].DurationPause = 0;

            var experimentForm = new CalculationExperiment(_neuroPlayService, _fileSystemService, parametersExperiment, _settingsService, _authForm);
            experimentForm.Show();
            isStarted = true;
            Close();
        }

        private string GenerateCalculationTask() {
            switch (_rnd.Next(0, 2)) {
                case 0:
                    return $"{_rnd.Next(1, 10)} * {_rnd.Next(1, 10)}";
                case 1:
                    return $"{_rnd.Next(50, 100)} - {_rnd.Next(1, 50)}";
                default:
                   return $"{_rnd.Next(1, 50)} + {_rnd.Next(1, 50)}";
            }
        }

        private void CalculationExperimentSettings_FormClosed(object sender, FormClosedEventArgs e) {
           if (!isStarted)
                Application.Exit();
        }
    }
}
