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
    public partial class MainForm : Form, Proxy.IServerCallback
    {
        private InstanceContext Context;
        public Proxy.ServerClient Client;
        public string Login;

        public MainForm()
        {
            InitializeComponent();

            Context = new InstanceContext(this);
            Client = new Proxy.ServerClient(Context);
        }

        private void RegisterMenuItem_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void LoginMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

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

        public void LoginErrorCallback(string message)
        {
            DialogResult result;

            result = MessageBox.Show(message, "LOGIN ERROR", MessageBoxButtons.OK);
        }

        public void UpdateUsersList(string[] users)
        {
            //ActiveUsersTextBox.Text = "";
            ActiveUsersTextBox.Items.Clear();

            foreach (var item in users)
            {
                //ActiveUsersTextBox.Text += $"{item}{Environment.NewLine}";
                ActiveUsersTextBox.Items.Add(item);
            }
        }

        public void UpdatePublicChatTextBox(string login, string message)
        {
            PublicChatTextBox.Text += $"{login}: {message}{Environment.NewLine}";
        }

        private void PublicMessageButton_Click(object sender, EventArgs e)
        {
            string text = PublicMessageTextBox.Text;
            PublicMessageTextBox.Text = "";

            Client.SendPublicMessage(text);
        }

        public void UpdateLogoutUsersList()
        {
            //ActiveUsersTextBox.Text = "";
            ActiveUsersTextBox.Items.Clear();
        }

        public void UpdateLoginPublicChatTextBox()
        {
            PublicChatTextBox.Text = "";
        }

        private void LogoutMenuItem_Click(object sender, EventArgs e)
        {
            Client.Logout();
        }

        private void PublicChatTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ActiveUsersTextBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ActiveUsersTextBox.SelectedItem != null)
            {
                PrivateChatForm form = new PrivateChatForm(ActiveUsersTextBox.SelectedItem.ToString());
                form.Show();
                ActiveUsersTextBox.ClearSelected();
            }
        }

        public void OpenPrivateChatForm(string sender, string message)
        {
            Console.WriteLine("Otwieram okno prywatnego czatu");
            PrivateChatForm form = new PrivateChatForm();
            form.PrivateChatTextBox.Text += $"{sender}: {message}{Environment.NewLine}";
            form.Show();
        }

        public void UpdatePrivateChatForm(string sender, string message)
        {
            throw new NotImplementedException();
        }

        public void OpenPrivateChatForm(string sender, string receiver, string message)
        {
            Console.WriteLine("Otwieram okno prywatnego czatu");
            PrivateChatForm form = new PrivateChatForm(receiver, sender);
            form.PrivateChatTextBox.Text += $"{sender}: {message}{Environment.NewLine}";
            form.Show();
        }
    }
}
