using System;
using NeuroPlayClient.Models;
using NeuroPlayClient.Resources;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace NeuroPlayClient {
    public partial class AuthForm : Form {
        private string[] ListUserType  = new string[] { "Начальный", "Опытный", "Продвинутый" };

        public AuthForm() {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, System.EventArgs e) {
            if (CheckUserData()) {
                Enum.TryParse(cbUserType.Text, out UserType userType);
                var userData = new User(tbUserId.Text, tbUserName.Text, (uint)numAge.Value, userType);

                if (chbRememberMe.Checked) {
                    SaveUserData(userData);
                }
            }
        }

        public bool CheckUserData() {
            if (string.IsNullOrEmpty(tbUserId.Text) || string.IsNullOrWhiteSpace(tbUserId.Text)) {
                ShowError(Messages.IncorrectUserId);
                return false;
            }

            if (string.IsNullOrEmpty(tbUserName.Text) || string.IsNullOrWhiteSpace(tbUserName.Text)) {
                ShowError(Messages.IncorrectUserName);
                return false;
            }

            if (!ListUserType.Contains(cbUserType.Text)){
                ShowError(Messages.IncorrectUserType);
                return false;
            }
            
            return true;
        }

        public void ShowError(string message) {
            MessageBox.Show(message);
        }

        public async void SaveUserData(User userData) {
            var json = JsonConvert.SerializeObject(userData);

            using (var sw = new StreamWriter(Messages.userDataPath)) {
                await sw.WriteAsync(json);
            }
        }
    }
}
