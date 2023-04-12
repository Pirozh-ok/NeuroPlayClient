using System;
using NeuroPlayClient.Models;
using NeuroPlayClient.Resources;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using NeuroPlayClient.Forms;
using NeuroPlayClient.Services;
using System.Threading.Tasks;

namespace NeuroPlayClient {
    public partial class AuthForm : Form {
        private Form _casesForm;
        private readonly INeuroPlayService _neuroPlayService;

        public AuthForm(INeuroPlayService neuroPlayService) {
            InitializeComponent();
            _neuroPlayService = neuroPlayService;
            cbCase.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUserType.DropDownStyle = ComboBoxStyle.DropDownList;
            ReadUserData();
        }

        private async void btnStart_Click(object sender, EventArgs e) {
            if (await NeuroPlayIsConected() && CheckUserData()) {
                Enum.TryParse(cbUserType.Text, out UserType userType);
                var userData = new User(tbUserId.Text, tbUserName.Text, (uint)numAge.Value, userType);

                if (chbRememberMe.Checked) {
                    SaveUserData(new UserSettings() {
                        ExperimentId = userData.ExperimentId,
                        Name = userData.Name,
                        Age = userData.Age,
                        UserType = userData.UserType,
                        RememberMe = chbRememberMe.Checked,
                    });
                }

                this.Hide();
                Enum.TryParse(cbCase.Text, out Cases choisedCase);
                switch (choisedCase) {
                    case Cases.Calculation: {
                            break;
                        }
                    case Cases.Sounds: {
                            break;
                        }
                    default: {
                            _casesForm = new FiguresExperimentSettings(_neuroPlayService);
                            _casesForm.Show();
                            break;
                        }
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
                    tbUserId.Text = (int.Parse(user.ExperimentId) + 1).ToString();
                    tbUserName.Text = user.Name;
                    cbUserType.Text = user.UserType.ToString();
                    cbCase.Text = user.Case.ToString();
                    numAge.Value = user.Age;
                    chbRememberMe.Checked = user.RememberMe;
                }
            }
            catch (Exception) {
                MessageBox.Show(Messages.CantReadSettings);
                tbUserId.Text = "0";
                tbUserName.Text = string.Empty;
                cbUserType.Text = UserType.Elementary.ToString();
                cbCase.Text = Cases.Figurs.ToString();
                numAge.Value = numAge.Minimum;
                chbRememberMe.Checked = true;
            }
        }

        private async Task<bool> NeuroPlayIsConected() {
            try {
                return await _neuroPlayService.IsConnectedAsync();
            }
            catch {
                MessageBox.Show(Messages.IsNotConnected);
                return false;
            }
        }
    }
}