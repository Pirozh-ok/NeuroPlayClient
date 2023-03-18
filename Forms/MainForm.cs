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
    }
}
