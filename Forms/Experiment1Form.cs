using NeuroPlayClient.Models;
using NeuroPlayClient.Services;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuroPlayClient.Forms {
    public partial class Experiment1Form : Form {
        public Settings1Experiment Settings { get; set; }
        private Random _rnd;
        private readonly INeuroPlayService _neuroPlayService;
        private int _currentTimeInMs;

        public Experiment1Form(INeuroPlayService neuroPlayService) {
            InitializeComponent();
            _rnd = new Random(DateTime.UtcNow.Millisecond);
            _neuroPlayService = neuroPlayService;
            _currentTimeInMs = 0;
        }

        private async Task Experiment1WithLimetedTime() {
            int countShowPicture = Settings.TimeInSecondsOrCountIteration / (int)Settings.DelayInSeconds;

            timer.Interval = (int)(Settings.DelayInSeconds * 1000);
            timer.Start();
            timerCurrentTime.Start();
        }

        private async Task Experiment1WithCountIteration() {

        }

        private async void Experiment1Form_Load(object sender, EventArgs e) {
            if (Settings.IsTime) {
                await Experiment1WithLimetedTime();
            }
            else {
                await Experiment1WithCountIteration();
            }
        }

        private void timer_Tick(object sender, EventArgs e) {
            bool isGreen = _rnd.Next() % 2 == 0;

            if (isGreen) {
                pbImage.Image = Image.FromFile("../../Images/green-circle.png");
            }
            else {
                pbImage.Image = Image.FromFile("../../Images/red-circle.png");
            }
        }

        private void timerCurrentTime_Tick(object sender, EventArgs e) {
            _currentTimeInMs += timerCurrentTime.Interval;
            tbCurrentTime.Text = $" {_currentTimeInMs/1000}:{(_currentTimeInMs % 1000)/100} мс";

            if (_currentTimeInMs >= Settings.TimeInSecondsOrCountIteration*1000) {
                timer.Stop();
                timerCurrentTime.Stop();
                MessageBox.Show("Эксперимент закончен");
            }
        }
    }
}
