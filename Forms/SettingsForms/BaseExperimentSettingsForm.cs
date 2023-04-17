using NeuroPlayClient.Models;
using NeuroPlayClient.Services.Interfaces;
using NeuroPlayClient.Services;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace NeuroPlayClient.Forms.SettingsForms {
    public partial class BaseExperimentSettingsForm : Form {
        protected readonly INeuroPlayService _neuroPlayService;
        protected readonly IFileSystemService _fileSystemService;
        protected const double _discretization = 0.5;
        protected Random _rnd = new Random(DateTime.Now.Millisecond);
        protected User UserData { get; set; }

        public BaseExperimentSettingsForm(INeuroPlayService neuroPlayService, IFileSystemService fileSystemService, User userData) {
            InitializeComponent();
            _neuroPlayService = neuroPlayService;
            _fileSystemService = fileSystemService;
        }

        protected List<double> GetListPossibleValues(double value) {
            if (value < _discretization) {
                return new List<double>() { value };
            }

            double variance = value / 2;
            double minValue = GetNearestMinValue(value - variance);
            double maxValue = GetNearestMaxValue(value + variance);
            var listPossibleValues = new List<double>();

            while (minValue <= maxValue) {
                listPossibleValues.Add(minValue);
                minValue += _discretization;
            }

            return listPossibleValues;
        }

        protected double GetNearestMinValue(double value) {
            double sum = 0;
            while (sum < value)
                sum += _discretization;

            return sum;
        }

        protected double GetNearestMaxValue(double value) {
            double sum = 0;
            while (sum <= value)
                sum += _discretization;

            return sum - _discretization;
        }

        private void BaseExperimentSettingsForm_Load(object sender, EventArgs e) {

        }
    }
}
