using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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

        public void UpdateUsersList(string[] users, byte[][] avatars)
        {
            // Lista przechowująca ścieżki do awatarów aktualnie zalogowanych użytkowników
            List<string> tmpAvatarList = new List<string>();


            // Czyszczenie kontrolki ze wszystkich elementów
            ActiveUsersTextBox.Items.Clear();

            // Wyczyszczenie kolekcji zawierającej awatary
            AvatarList.Images.Clear();

            // Sprawdzenie, czy są już katalogi tymczasowe dla użytkowników do przechowywania ikonek
            if(!Directory.Exists($"C:\\Users\\Dominik\\Desktop\\Tmp\\{Login}"))
            {
                Directory.CreateDirectory($"C:\\Users\\Dominik\\Desktop\\Tmp\\{Login}");
            }

            ActiveUsersTextBox.View = View.Details;
            ActiveUsersTextBox.GridLines = true;
            ActiveUsersTextBox.FullRowSelect = true;

            // Dodanie jednej kolumny do ListView
            ActiveUsersTextBox.Columns.Add("", -2, HorizontalAlignment.Left);

            AvatarList.ImageSize = new Size(32, 32);

            // Przekonwertowanie tablicy bajtów na obraz, zapisanie go pod nazwą login.png i dodanie do ImageList
            DirectoryInfo di = new DirectoryInfo($"C:\\Users\\Dominik\\Desktop\\Tmp");
            foreach (var dir in di.EnumerateDirectories())
            {
                for (int i = 0; i < users.Count(); i++)
                {
                    using (Image image = Image.FromStream(new MemoryStream(avatars[i])))
                    {
                        if(!File.Exists($"C:\\Users\\Dominik\\Desktop\\Tmp\\{dir.Name}\\{users[i]}.png"))
                            image.Save($"C:\\Users\\Dominik\\Desktop\\Tmp\\{dir.Name}\\{users[i]}.png", ImageFormat.Png);
                    }
                }
            }

            // Załadowanie katalogu zawierającego awatary dla danego użytkownika
            di = new DirectoryInfo($"C:\\Users\\Dominik\\Desktop\\Tmp\\{Login}");

            // Pobranie wszystkich plików znajdujących się w danym katalogu
            FileInfo[] files = di.GetFiles();

            // Załadowanie aktualnie wykorzystywanych awatarów
            for (int i = 0; i < users.Count(); i++)
            {
                for (int j = 0; j < files.Count(); j++)
                {
                    if($"{users[i]}.png".Equals($"{files[j].Name}"))
                    {
                        tmpAvatarList.Add($"C:\\Users\\Dominik\\Desktop\\Tmp\\{Login}\\{users[i]}.png");
                        break;
                    }
                }
             
            }

            for (int i = 0; i < users.Count(); i++)
            {
                AvatarList.Images.Add(Image.FromFile(tmpAvatarList[i]));
            }

            ActiveUsersTextBox.LargeImageList = AvatarList;
            ActiveUsersTextBox.SmallImageList = AvatarList;

            // Wyświetlenie awatara i nazwy użytkownika
            for (int i = 0; i < users.Count(); i++)
            {
                ListViewItem item = new ListViewItem(users[i], i);
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
            // Pobranie indeksu wybranego elementu
            var index = ActiveUsersTextBox.SelectedIndices[0];

            PrivateChatForm form = new PrivateChatForm(ActiveUsersTextBox.SelectedIndices[0].ToString());
            form.Show();

            /*if (ActiveUsersTextBox.SelectedItem != null)
            {
                PrivateChatForm form = new PrivateChatForm(ActiveUsersTextBox.SelectedItem.ToString());
                form.Show();
                ActiveUsersTextBox.ClearSelected();
            }*/
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

        public void UpdateLogoutPrivateChatForm(string sender, string[] users, string message)
        {
            throw new NotImplementedException();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Client.ExitApplication(Login, $"EXIT APPLICATION AT: {DateTime.Now.ToString()}");

            this.Close();
        }

        public void UpdateExitMainForm(string sender, string message)
        {
            /*foreach(var item in ActiveUsersTextBox.Items)
            {
                if (sender.Equals(item.ToString()))
                {
                    ActiveUsersTextBox.Items.Remove(item);
                    PublicChatTextBox.Text += $"{sender}: {message}{Environment.NewLine}";
                }
            }*/
        }

        private void ActiveUsersTextBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ActiveUsersTextBox.SelectedItems[0].Text);
        }
    }
}
