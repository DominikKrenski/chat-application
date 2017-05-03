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
            ActiveUsersTextBox.Text = "";

            foreach (var item in users)
            {
                ActiveUsersTextBox.Text += $"{item}{Environment.NewLine}";
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

        private void PrivateMessageButton_Click(object sender, EventArgs e)
        {
            PrivateMessageSendForm sendForm = new PrivateMessageSendForm();
            sendForm.Show();
        }

        public void DisplayReceivePrivateMessageForm(string login, string message)
        {
            PrivateMessageReceiveForm form = new PrivateMessageReceiveForm();

            form.SenderTextBox.Text = login;
            form.PrivateMessageTextBox.Text = message;

            form.Show();
    
        }
    }
}
