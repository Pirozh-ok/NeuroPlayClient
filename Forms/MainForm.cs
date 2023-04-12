using Microsoft.Extensions.DependencyInjection;
using NeuroPlayClient.Models;
using NeuroPlayClient.Resources;
using NeuroPlayClient.Services;
using System;
using System.Windows.Forms;

namespace NeuroPlayClient.Forms {
    public partial class MainForm : Form {
        public User UserData { get; set; }
       private readonly INeuroPlayService _neuroPlayService;

        public MainForm(INeuroPlayService neuroPlayService) {
            InitializeComponent();
            _neuroPlayService = neuroPlayService;
            tbCountIteration.Text = ((int)Math.Floor((double)nudTime.Value / (double)nudDelay.Value)).ToString();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private async void btnStart_Click(object sender, EventArgs e) {
            //var setting = new Settings1Experiment() {
            //    TimeInSeconds = int.Parse(nudTime.Value.ToString()),
            //    DelayInSeconds = double.Parse(nudDelay.Value.ToString()),
            //};

            //try {
            //    if (await _neuroPlayService.IsConnectedAsync()) {
            //        var formExperiment = Program.ServiceProvider.GetRequiredService<FiguresExperiment>();
            //        formExperiment.Settings = setting;
            //        formExperiment.Show();
            //    }
            //    else {
            //        MessageBox.Show(Messages.IsNotConnected);
            //        return;
            //    }
            //}
            //catch {
            //    MessageBox.Show(Messages.IsNotConnected);
            //}
        }

        private void nudTimeOrCountIteration_ValueChanged(object sender, EventArgs e) {
            tbCountIteration.Text = ((int)Math.Floor((double)nudTime.Value / (double)nudDelay.Value)).ToString();
        }

        private void nudDelay_ValueChanged(object sender, EventArgs e) {
            tbCountIteration.Text = ((int)Math.Floor((double)nudTime.Value / (double)nudDelay.Value)).ToString();
        }
    }
}
