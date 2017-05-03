using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class RegisterForm : Form, Proxy.IServerCallback
    {
        private enum Sex { Mężczyzna, Kobieta };

        public RegisterForm()
        {
            InitializeComponent();

            SexComboBox.Items.Add(Sex.Mężczyzna);
            SexComboBox.Items.Add(Sex.Kobieta);
            SexComboBox.SelectedIndex = 0;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            MainForm form = (MainForm)Application.OpenForms[0];

            int age;

            if (!Int32.TryParse(AgeTextBox.Text, out age)){
                throw new NotImplementedException();
            }

            Proxy.RegisterUser user = new Proxy.RegisterUser
            {
                Login = LoginTextBox.Text,
                Password = PasswordTextBox.Text,
                PasswordConfirm = PasswordConfirmTextBox.Text,
                Name = NameTextBox.Text,
                Surname = SurnameTextBox.Text,
                Sex = SexComboBox.Text,
                Age = age
            };

            form.Client.Register(user);
        }

        public void RegisterNotify(string message)
        {
            return;
        }

        public void LoginErrorCallback(string message)
        {
            return;
        }

        public void UpdateUsersList(string[] users)
        {
            return;
        }

        public void UpdatePublicChatTextBox(string login, string message)
        {
            return;
        }

        public void DisplayReceivePrivateMessageForm(string login, string message)
        {
            return;
        }
    }
}
