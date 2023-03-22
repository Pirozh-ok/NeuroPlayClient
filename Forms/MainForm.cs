using Microsoft.Extensions.DependencyInjection;
using NeuroPlayClient.Models;
using System;
using System.Windows.Forms;

namespace NeuroPlayClient.Forms {
    public partial class MainForm : Form {
        public User UserData { get; set; }
       

        public MainForm() {
            InitializeComponent();
            tbCountIteration.Text = ((int)Math.Floor((double)nudTime.Value / (double)nudDelay.Value)).ToString();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e) {
            var setting = new Settings1Experiment() {
                TimeInSeconds = int.Parse(nudTime.Value.ToString()),
                DelayInSeconds = double.Parse(nudDelay.Value.ToString()),
            };

            var formExperiment = Program.ServiceProvider.GetRequiredService<Experiment1Form>();
            formExperiment.Settings = setting;
            formExperiment.Show();
        }

        private void nudTimeOrCountIteration_ValueChanged(object sender, EventArgs e) {
            tbCountIteration.Text = ((int)Math.Floor((double)nudTime.Value / (double)nudDelay.Value)).ToString();
        }

        private void nudDelay_ValueChanged(object sender, EventArgs e) {
            tbCountIteration.Text = ((int)Math.Floor((double)nudTime.Value / (double)nudDelay.Value)).ToString();
        }
    }
}
