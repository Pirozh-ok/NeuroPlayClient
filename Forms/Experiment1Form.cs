using NeuroPlayClient.Models;
using NeuroPlayClient.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuroPlayClient.Forms {
    public partial class Experiment1Form : Form {
        public Settings1Experiment Settings { get; set; }
        private Random _rnd;
        private readonly INeuroPlayService _neuroPlayService;
        private int _currentTimeInMs;
        private int _durationExperiment;
        private int _cleanDelayInMs = 200;
        private DateTime _startTime;
        private List<bool> flagsImages = new List<bool>();
        private List<DateTime> timesShowImages = new List<DateTime>();
        private List<DateTime> timesPressButton = new List<DateTime>();
        private List<int> times1 = new List<int>();
        private int _currentElement = 0; 

        public Experiment1Form(INeuroPlayService neuroPlayService) {
            InitializeComponent();
            _rnd = new Random(DateTime.UtcNow.Millisecond);
            _neuroPlayService = neuroPlayService;
        }

        private async Task Experiment1WithLimetedTime() {
            _currentTimeInMs = 0;
            _currentElement = 0;
            _durationExperiment = Settings.TimeInSeconds * 1000;
            _startTime = DateTime.Now;
            int countShowPicture = Settings.CountIteration;

            for(int i = 0; i < countShowPicture+1000; i++) {
                flagsImages.Add(_rnd.Next() % 2 == 0);
            }

            timerCurrentTime.Interval = 100;
            timer.Interval = (int)(Settings.DelayInSeconds * 1000 - _cleanDelayInMs);
            timer.Start();
            timerCurrentTime.Start();
            await _neuroPlayService.StartRecordAsync();
        }

        private async void Experiment1Form_Load(object sender, EventArgs e) {
            await Experiment1WithLimetedTime();
        }

        private async void timer_Tick(object sender, EventArgs e) {
            pbImage.Image = null;
            await Task.Delay(_cleanDelayInMs);

            if (flagsImages[_currentElement]) {
                pbImage.Image = Image.FromFile("../../Images/green-circle.png");
                await _neuroPlayService.AddMarkerAsync((DateTime.Now - _startTime).Milliseconds.ToString(), "Show green circle");
            }
            else {
                pbImage.Image = Image.FromFile("../../Images/red-circle.png");
                await _neuroPlayService.AddMarkerAsync((DateTime.Now - _startTime).Milliseconds.ToString(), "Show red circle");
            }
            timesShowImages.Add(DateTime.Now);
            _currentElement++;
        }

        private async void timerCurrentTime_Tick(object sender, EventArgs e) {
            _currentTimeInMs += timerCurrentTime.Interval;
            tbCurrentTime.Text = $" {_currentTimeInMs/1000}:{(_currentTimeInMs % 1000)} с";
            times1.Add(_currentTimeInMs);

            if (_currentTimeInMs >= _durationExperiment) {
                timer.Stop();
                timerCurrentTime.Stop();
                await _neuroPlayService.StopRecordAsync();
                MessageBox.Show("Эксперимент закончен");

                //AddMarks();
            }
        }

        //private void AddMarks() {
        //    for(int i = 0; i < timesShowImages.Count; i++) {
        //        long timeShowInMs = (timesShowImages[i] - _startTime).Milliseconds;
        //        long timePressSpaceInMs = (timesPressButton[i] - _startTime).Milliseconds;
        //    }
        //}

        private async void Experiment1Form_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Space) {
                await _neuroPlayService.AddMarkerAsync((DateTime.Now - _startTime).Milliseconds.ToString(), "User pressed space");
                timesPressButton.Add(DateTime.Now);
            }
        }
    }
}
