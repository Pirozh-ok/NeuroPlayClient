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
            ReadUserData();
        }

        private void btnStart_Click(object sender, EventArgs e) {
            if (CheckUserData()) {
                Enum.TryParse(cbUserType.Text, out UserType userType);
                var userData = new User(tbUserId.Text, tbUserName.Text, (uint)numAge.Value, userType);

                if (chbRememberMe.Checked) {
                    SaveUserData(new UserSettings() {
                        Id = userData.Id,
                        Name = userData.Name,
                        Age = userData.Age,
                        UserType = userData.UserType,
                        RememberMe = chbRememberMe.Checked
                    });
                }
            }
        }

        private bool CheckUserData() {
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

        private void ShowError(string message) {
            MessageBox.Show(message);
        }

        private async void SaveUserData(UserSettings data) {
            var json = JsonConvert.SerializeObject(data);

            using (var sw = new StreamWriter(Messages.userDataPath)) {
                await sw.WriteAsync(json);
            }
        }

        private void ReadUserData() {
            try {
                using (var sr = new StreamReader(Messages.userDataPath)) {
                    var json = sr.ReadToEnd();
                    var user = JsonConvert.DeserializeObject<UserSettings>(json);
                    tbUserId.Text = user.Id;
                    tbUserName.Text = user.Name;
                    cbUserType.Text = user.UserType.ToString();
                    numAge.Value = user.Age;
                    chbRememberMe.Checked = user.RememberMe;
                }
            }
            catch (Exception) {
                return;
            }
        }
    }
}