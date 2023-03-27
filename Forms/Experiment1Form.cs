using NeuroPlayClient.Models;
using NeuroPlayClient.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuroPlayClient.Forms {
    public class TimesMarker {
        public DateTime TimeShowImages { get; set; }
        public DateTime? TimePressKey { get; set; }
    }

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
            _markers = new TimesMarker[countShowPicture+10];
            //переделать, когда разберусь с точным количеством картинок
            for (int i = 0; i < countShowPicture+10; i++) {
                flagsImages.Add(_rnd.Next() % 2 == 0);
                _markers[i] = new TimesMarker();
            }

            timerCurrentTime.Interval = 100;
            timer.Interval = (int)(Settings.DelayInSeconds * 1000 - _cleanDelayInMs);
            timer.Start();
            timerCurrentTime.Start();
            sw = new StreamWriter("C:\\Users\\Ivan\\source\\repos\\NeuroPlayClient\\logs.txt", false);
            await _neuroPlayService.StartRecordAsync();
        }

        private async void Experiment1Form_Load(object sender, EventArgs e) {
            await Experiment1WithLimetedTime();
        }

        private async void timer_Tick(object sender, EventArgs e) {
            pbImage.Image = null;
            await Task.Delay(_cleanDelayInMs);

            if (flagsImages[_currentImages]) {
                pbImage.Image = Image.FromFile("../../Images/green-circle.png");
                _markers[_currentImages].TimeShowImages = DateTime.Now;
            }
            else {
                pbImage.Image = Image.FromFile("../../Images/red-circle.png");
                _markers[_currentImages].TimeShowImages = DateTime.Now;
            }
            _currentImages++;
        }

        private async void timerCurrentTime_Tick(object sender, EventArgs e) {
            _currentTimeInMs += timerCurrentTime.Interval;
            tbCurrentTime.Text = $" {_currentTimeInMs/1000}:{(_currentTimeInMs % 1000)} с";
            times1.Add(_currentTimeInMs);

            if (_currentTimeInMs >= _durationExperiment) {
                timer.Stop();
                timerCurrentTime.Stop();

                if(await AddMarkers()) {
                    await _neuroPlayService.StopRecordAsync();
                }

                sw.Close();
                //await AddMarkers();
                //await _neuroPlayService.StopRecordAsync();
            }
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
                _markers[_currentImages].TimePressKey = DateTime.Now;
            }
        }
    }
}
