using NeuroPlayClient.Models;
using NeuroPlayClient.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NeuroPlayClient.Forms {
    public partial class FiguresExperimentSettings : Form {
        private readonly INeuroPlayService _neuroPlayService;
        private const double _discretization = 0.5;
        private Random _rnd = new Random(DateTime.Now.Millisecond);

        public FiguresExperimentSettings(INeuroPlayService neuroPlayService) {
            InitializeComponent();
            _neuroPlayService = neuroPlayService;
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


        }

        private List<double> GetListPossibleValues(double value) {
            if(value < _discretization) {
                return new List<double>() { value };
            }
            
            double variance = value / 2;
            double minValue = GetNearestMinValue(value - variance);
            double maxValue = GetNearestMaxValue(value + variance);
            var listPossibleValues = new List<double>();

            while(minValue <= maxValue) {
                listPossibleValues.Add(minValue);
                minValue += _discretization;
            }

            return listPossibleValues;
        }

        private double GetNearestMinValue(double value) {
            double sum = 0;
            while (sum < value)
                sum += _discretization;

            return sum;
        }

        private double GetNearestMaxValue(double value) {
            double sum = 0;
            while (sum <= value)
                sum += _discretization;

            return sum-_discretization;
        }
    }
}
