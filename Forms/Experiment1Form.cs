using NeuroPlayClient.Models;
using NeuroPlayClient.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        private TimesMarker [] _markers;
        private List<int> times1 = new List<int>();
        private int _currentImages = 0;
        private List<string> list = new List<string>();
        private StreamWriter sw;

        public Experiment1Form(INeuroPlayService neuroPlayService) {
            InitializeComponent();
            _rnd = new Random(DateTime.UtcNow.Millisecond);
            _neuroPlayService = neuroPlayService;
        }

        private async Task Experiment1WithLimetedTime() {
            _currentTimeInMs = 0;
            _currentImages = 0;
            _durationExperiment = Settings.TimeInSeconds * 1000;
            _startTime = DateTime.Now;
            int countShowPicture = Settings.CountIteration;
            //переделать, когда разберусь с точным количеством картинок
            _markers = new TimesMarker[countShowPicture];
            //переделать, когда разберусь с точным количеством картинок
            for (int i = 0; i < countShowPicture; i++) {
                flagsImages.Add(_rnd.Next() % 2 == 0);
                _markers[i] = new TimesMarker();
            }

            timerCurrentTime.Interval = 10;
            timer.Interval = (int)(Settings.DelayInSeconds * 1000);
            timerStopExperiment.Interval = Settings.TimeInSeconds * 1000 + 400;
            timer.Start();
            timerCurrentTime.Start();
            timerStopExperiment.Start();
            sw = new StreamWriter("C:\\Users\\Ivan\\source\\repos\\NeuroPlayClient\\logs.txt", false);
            await _neuroPlayService.StartRecordAsync();

            pbImage.Image = flagsImages[0] ? Image.FromFile("../../Images/green-circle.png") : Image.FromFile("../../Images/red-circle.png");
            _markers[_currentImages].TimeShowImages = DateTime.Now;
        }

        private async void Experiment1Form_Load(object sender, EventArgs e) {
            await Experiment1WithLimetedTime();
        }

        private async void timer_Tick(object sender, EventArgs e) {
            pbImage.Image = null;
            await Task.Delay(_cleanDelayInMs);

            pbImage.Image = flagsImages[_currentImages] ? Image.FromFile("../../Images/green-circle.png") :
                                                          Image.FromFile("../../Images/red-circle.png");

            if (_currentImages < Settings.CountIteration-1) {
                _currentImages++;
                _markers[_currentImages].TimeShowImages = DateTime.Now;
            }
        }

        private void timerCurrentTime_Tick(object sender, EventArgs e) {
            _currentTimeInMs += timerCurrentTime.Interval;
            tbCurrentTime.Text = $" {_currentTimeInMs/1000}:{(_currentTimeInMs % 1000)} с";
        }

        private async Task<bool> AddMarkers() {
            for (int i = 0; i < _currentImages; i++) {
                if (_markers[i].TimeShowImages != default) {
                    string timeShowInMs = Math.Round((_markers[i].TimeShowImages - _startTime).TotalMilliseconds).ToString();
                    // Show green circle - 1, Show red circle - 0
                    string text = flagsImages[i] ? "1" : "0";
                    var result = await _neuroPlayService.AddMarkerAsync(timeShowInMs, text);
                    sw.WriteLine($"position - {timeShowInMs}; text - {text}; result - {result}");

                    if (_markers[i].TimePressKey != null) {
                        string timePressKeyInMs = Math.Round(((DateTime)_markers[i].TimePressKey - _startTime).TotalMilliseconds).ToString();
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
                //_neuroPlayService.AddMarkerAsync(Math.Round((DateTime.Now - _startTime).TotalMilliseconds).ToString(), "2");
                _markers[_currentImages].TimePressKey = DateTime.Now;
            }
        }

        private async void timerStopExperiment_Tick(object sender, EventArgs e) {
            timer.Stop();
            timerCurrentTime.Stop();
            timerStopExperiment.Stop();
            //await _neuroPlayService.StopRecordAsync();

            if (await AddMarkers()) {
               await _neuroPlayService.StopRecordAsync();
            }
            sw.Close();
        }
    }
}
