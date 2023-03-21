using Microsoft.Extensions.DependencyInjection;
using NeuroPlayClient.Models;
using System;
using System.Windows.Forms;

namespace NeuroPlayClient.Forms {
    public partial class MainForm : Form {
        public User UserData { get; set; }
       

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e) {
            var setting = new Settings1Experiment() {
                TimeInSecondsOrCountIteration = int.Parse(nudTimeOrCountIteration.Value.ToString()),
                DelayInSeconds = int.Parse(nudDelay.Value.ToString()),
                IsTime = rbtnTimeExperiment.Checked
            };

            var formExperiment = Program.ServiceProvider.GetRequiredService<Experiment1Form>();
            formExperiment.Settings = setting;
            formExperiment.Show();
        }
    }
}
