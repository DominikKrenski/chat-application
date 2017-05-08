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

        public void LoginErrorCallback(string message)
        {
            return;
        }

        public void OpenPrivateChatForm(string sender, string receiver, string message)
        {
            throw new NotImplementedException();
        }

        public void RegisterNotify(string message)
        {
            return;
        }

        public void UpdateLoginPublicChatTextBox()
        {
            return;
        }

        public void UpdateLogoutPrivateChatForm(string sender, string[] users, string message)
        {
            throw new NotImplementedException();
        }

        public void UpdateLogoutUsersList()
        {
            return;
        }

        public void UpdatePrivateChatForm(string sender, string message)
        {
            throw new NotImplementedException();
        }

        public void UpdatePublicChatTextBox(string login, string message)
        {
            return;
        }

        public void UpdateUsersList(string[] users)
        {
            return;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            MainForm form = (MainForm)Application.OpenForms[0];

            form.Login = LoginTextBox.Text;

            Proxy.LoginUser user = new Proxy.LoginUser
            {
                Login = LoginTextBox.Text,
                Password = PasswordTextBox.Text
            };

            form.Client.Login(user);

            this.Close();
        }
    }
}
