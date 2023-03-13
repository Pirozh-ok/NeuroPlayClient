using NeuroPlayClient.Resources;
using System.Windows.Forms;

namespace NeuroPlayClient {
    public partial class AuthForm : Form {
        public AuthForm() {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, System.EventArgs e) {
            if (CheckUserData()) {
                MessageBox.Show(cbUserType.Text);
            }
        }

        public bool CheckUserData() {
            if (string.IsNullOrEmpty(tbUserId.Text) || string.IsNullOrWhiteSpace(tbUserId.Text)) {
                MessageBox.Show(Messages.IncorrectUserId);
                return false;
            }

            if (string.IsNullOrEmpty(tbUserName.Text) || string.IsNullOrWhiteSpace(tbUserName.Text)) {
                MessageBox.Show(Messages.IncorrectUserId);
                return false;
            }

            return true;
        }
    }
}
