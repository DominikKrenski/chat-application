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
    public partial class LoginForm : Form, Proxy.IServerCallback
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public void LoginCallback(string[] users)
        {
            MainForm form = (MainForm) Application.OpenForms[0];

            foreach (var item in users)
            {
                form.ActiveUsersTextBox.Text += $"{item}{Environment.NewLine}";
            }
        }

        public void LoginErrorCallback(string message)
        {
            DialogResult result;

            result = MessageBox.Show(message, "LOGIN ERROR", MessageBoxButtons.OK);
        }

        public void RegisterNotify(string message)
        {
            return;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            InstanceContext context = new InstanceContext(this);
            Proxy.ServerClient client = new Proxy.ServerClient(context);

            Proxy.LoginUser user = new Proxy.LoginUser
            {
                Login = LoginTextBox.Text,
                Password = PasswordTextBox.Text
            };

            client.Login(user);
        }
    }
}
