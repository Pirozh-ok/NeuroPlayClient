using System;
using NeuroPlayClient.Models;
using NeuroPlayClient.Resources;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using NeuroPlayClient.Forms;
using NeuroPlayClient.Services;
using System.Threading.Tasks;
using NeuroPlayClient.Services.Interfaces;
using NeuroPlayClient.Forms.Settings;
using System.Configuration;

namespace NeuroPlayClient {
    public partial class AuthForm : Form {
        private Form _casesForm;
        private readonly INeuroPlayService _neuroPlayService;
        private readonly IFileSystemService _fileSystemService;
        private readonly ISettingsService _settingsService;

        private const string FiguresExperiment = "Геометрическая фигура";
        private const string CalculationExperiment = "Арифметические вычисления";
        private const string SoundExperiment = "Род существительного";

        public AuthForm(INeuroPlayService neuroPlayService, IFileSystemService fileSystemService, ISettingsService settingsService) {
            InitializeComponent();
            _neuroPlayService = neuroPlayService;
            _fileSystemService = fileSystemService;
            _settingsService = settingsService;
            cbCase.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUserType.DropDownStyle = ComboBoxStyle.DropDownList;
            ReadUserData();
        }

        private async void btnStart_Click(object sender, EventArgs e) {
            if (await NeuroPlayIsConected() && CheckUserData()) {
                Enum.TryParse(cbUserType.Text, out UserType userType);
                var userData = new User(tbUserId.Text, tbUserName.Text, (uint)numAge.Value, userType);

                var userSettings = new UserSettings() {
                    ExperimentId = userData.ExperimentId,
                    Name = userData.Name,
                    Age = userData.Age,
                    UserType = cbUserType.Text,
                    Case = cbCase.Text
                };

                _settingsService.SetUserSettings(userSettings);

                if (chbRememberMe.Checked) {
                    userSettings.RememberMe = true;
                    SaveUserData(userSettings);
                }

                this.Hide();
                switch (cbCase.Text) {
                    case CalculationExperiment: {
                            _casesForm = new CalculationExperimentSettings(_neuroPlayService, _fileSystemService, _settingsService);
                            _casesForm.Show();
                            break;
                        }
                    case SoundExperiment: {
                            _casesForm = new SoundsExperimentSettings(_neuroPlayService, _fileSystemService, _settingsService);
                            _casesForm.Show();
                            break;
                        }
                    default: {
                            _casesForm = new FiguresExperimentSettings(_neuroPlayService, _fileSystemService, _settingsService);
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

        private async void ReadUserData() {
            var result = await _fileSystemService.ReadUserSettingsFromFile();
            if(result.Success) {
                var user = ((ServiceResult<UserSettings>)result).Data;
                tbUserId.Text = (int.Parse(user.ExperimentId)+1).ToString();
                tbUserName.Text = user.Name;
                cbUserType.Text = user.UserType.ToString();
                cbCase.Text = user.Case.ToString();
                numAge.Value = user.Age;
                chbRememberMe.Checked = user.RememberMe;
            }
            else {
                MessageBox.Show(Messages.CantReadSettings);
                tbUserId.Text = "1";
                tbUserName.Text = string.Empty;
                cbUserType.Text = UserType.Elementary.ToString();
                cbCase.Text = FiguresExperiment;
                numAge.Value = numAge.Minimum;
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

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void AuthForm_MouseDown(object sender, MouseEventArgs e) {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void AuthForm_Load(object sender, EventArgs e) {
            ActiveControl = null;
        }
    }
}