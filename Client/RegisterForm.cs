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
            InstanceContext context = new InstanceContext(this);
            Proxy.ServerClient client = new Proxy.ServerClient(context);

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

            client.Register(user);
        }

        public void RegisterNotify(string message)
        {
            DialogResult result;

            if (message.Equals("OK"))
            {
                result = MessageBox.Show("User registered successfuly", "Registration completed", MessageBoxButtons.OK);
            }
            else
            {
                result = MessageBox.Show($"{message}", "Registration Error", MessageBoxButtons.OK);
            }
        }

        public void LoginCallback(string[] users)
        {
            throw new NotImplementedException();
        }

        public void LoginErrorCallback(string message)
        {
            throw new NotImplementedException();
        }
    }
}
