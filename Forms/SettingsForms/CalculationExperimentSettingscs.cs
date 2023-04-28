using NeuroPlayClient.Forms.SettingsForms;
using NeuroPlayClient.Models;
using NeuroPlayClient.Services.Interfaces;
using NeuroPlayClient.Services;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections.Generic;
using NeuroPlayClient.Forms.ExperimentForms;

namespace NeuroPlayClient.Forms.Settings {
    public partial class CalculationExperimentSettings : BaseExperimentSettingsForm {
        public CalculationExperimentSettings(INeuroPlayService neuroPlayService, IFileSystemService fileSystemService, ISettingsService settingsService)
            : base(neuroPlayService, fileSystemService, settingsService) {
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

            var experimentForm = new CalculationExperiment(_neuroPlayService, _fileSystemService, parametersExperiment, _settingsService);
            experimentForm.Show();
        }

        private string GenerateCalculationTask() {
            int maxValue;
            string symbol;

            switch (_rnd.Next(0, 2)) {
                case 0:
                    maxValue = 10;
                    symbol = "*";
                    break;
                case 1:
                    maxValue = 100;
                    symbol = "-";
                    break;
                default:
                    maxValue = 50;
                    symbol = "+";
                    break;
            }

            return symbol == "-" ? $"{_rnd.Next(1, maxValue)} {symbol} {_rnd.Next(1, maxValue / 2)}" :
                $"{_rnd.Next(1, maxValue)} {symbol} {_rnd.Next(1, maxValue)}";
        }

        private void CalculationExperimentSettings_FormClosed(object sender, FormClosedEventArgs e) {
            _fileSystemService.SaveUserSettingsToFile(_settingsService.GetSettings().Data);
            Application.Exit();
        }
    }
}
