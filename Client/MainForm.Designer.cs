namespace Client
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegisterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AuthorsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentUsersLabel = new System.Windows.Forms.Label();
            this.PublicChatLabel = new System.Windows.Forms.Label();
            this.PublicChatTextBox = new System.Windows.Forms.RichTextBox();
            this.PublicMessageLabel = new System.Windows.Forms.Label();
            this.PublicMessageTextBox = new System.Windows.Forms.RichTextBox();
            this.PublicMessageButton = new System.Windows.Forms.Button();
            this.ActiveUsersTextBox = new System.Windows.Forms.ListView();
            this.AvatarList = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.AboutMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(686, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginMenuItem,
            this.RegisterMenuItem,
            this.ExitMenuItem,
            this.LogoutMenuItem});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "File";
            // 
            // LoginMenuItem
            // 
            this.LoginMenuItem.Name = "LoginMenuItem";
            this.LoginMenuItem.Size = new System.Drawing.Size(116, 22);
            this.LoginMenuItem.Text = "Login";
            this.LoginMenuItem.Click += new System.EventHandler(this.LoginMenuItem_Click);
            // 
            // RegisterMenuItem
            // 
            this.RegisterMenuItem.Name = "RegisterMenuItem";
            this.RegisterMenuItem.Size = new System.Drawing.Size(116, 22);
            this.RegisterMenuItem.Text = "Register";
            this.RegisterMenuItem.Click += new System.EventHandler(this.RegisterMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(116, 22);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // LogoutMenuItem
            // 
            this.LogoutMenuItem.Name = "LogoutMenuItem";
            this.LogoutMenuItem.Size = new System.Drawing.Size(116, 22);
            this.LogoutMenuItem.Text = "Logout";
            this.LogoutMenuItem.Click += new System.EventHandler(this.LogoutMenuItem_Click);
            // 
            // AboutMenu
            // 
            this.AboutMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AuthorsMenuItem});
            this.AboutMenu.Name = "AboutMenu";
            this.AboutMenu.Size = new System.Drawing.Size(52, 20);
            this.AboutMenu.Text = "About";
            // 
            // AuthorsMenuItem
            // 
            this.AuthorsMenuItem.Name = "AuthorsMenuItem";
            this.AuthorsMenuItem.Size = new System.Drawing.Size(116, 22);
            this.AuthorsMenuItem.Text = "Authors";
            // 
            // CurrentUsersLabel
            // 
            this.CurrentUsersLabel.AutoSize = true;
            this.CurrentUsersLabel.Location = new System.Drawing.Point(13, 28);
            this.CurrentUsersLabel.Name = "CurrentUsersLabel";
            this.CurrentUsersLabel.Size = new System.Drawing.Size(67, 13);
            this.CurrentUsersLabel.TabIndex = 1;
            this.CurrentUsersLabel.Text = "Active Users";
            // 
            // PublicChatLabel
            // 
            this.PublicChatLabel.AutoSize = true;
            this.PublicChatLabel.Location = new System.Drawing.Point(242, 28);
            this.PublicChatLabel.Name = "PublicChatLabel";
            this.PublicChatLabel.Size = new System.Drawing.Size(61, 13);
            this.PublicChatLabel.TabIndex = 3;
            this.PublicChatLabel.Text = "Public Chat";
            // 
            // PublicChatTextBox
            // 
            this.PublicChatTextBox.Location = new System.Drawing.Point(245, 44);
            this.PublicChatTextBox.Name = "PublicChatTextBox";
            this.PublicChatTextBox.ReadOnly = true;
            this.PublicChatTextBox.Size = new System.Drawing.Size(429, 421);
            this.PublicChatTextBox.TabIndex = 4;
            this.PublicChatTextBox.Text = "";
            this.PublicChatTextBox.TextChanged += new System.EventHandler(this.PublicChatTextBox_TextChanged);
            // 
            // PublicMessageLabel
            // 
            this.PublicMessageLabel.AutoSize = true;
            this.PublicMessageLabel.Location = new System.Drawing.Point(13, 480);
            this.PublicMessageLabel.Name = "PublicMessageLabel";
            this.PublicMessageLabel.Size = new System.Drawing.Size(110, 13);
            this.PublicMessageLabel.TabIndex = 5;
            this.PublicMessageLabel.Text = "Send Public Message";
            // 
            // PublicMessageTextBox
            // 
            this.PublicMessageTextBox.Location = new System.Drawing.Point(16, 496);
            this.PublicMessageTextBox.Name = "PublicMessageTextBox";
            this.PublicMessageTextBox.Size = new System.Drawing.Size(390, 72);
            this.PublicMessageTextBox.TabIndex = 6;
            this.PublicMessageTextBox.Text = "";
            // 
            // PublicMessageButton
            // 
            this.PublicMessageButton.Location = new System.Drawing.Point(502, 518);
            this.PublicMessageButton.Name = "PublicMessageButton";
            this.PublicMessageButton.Size = new System.Drawing.Size(98, 23);
            this.PublicMessageButton.TabIndex = 9;
            this.PublicMessageButton.Text = "Send Message";
            this.PublicMessageButton.UseVisualStyleBackColor = true;
            this.PublicMessageButton.Click += new System.EventHandler(this.PublicMessageButton_Click);
            // 
            // ActiveUsersTextBox
            // 
            this.ActiveUsersTextBox.Location = new System.Drawing.Point(16, 44);
            this.ActiveUsersTextBox.MultiSelect = false;
            this.ActiveUsersTextBox.Name = "ActiveUsersTextBox";
            this.ActiveUsersTextBox.Size = new System.Drawing.Size(223, 421);
            this.ActiveUsersTextBox.TabIndex = 10;
            this.ActiveUsersTextBox.UseCompatibleStateImageBehavior = false;
            // 
            // AvatarList
            // 
            this.AvatarList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.AvatarList.ImageSize = new System.Drawing.Size(64, 64);
            this.AvatarList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 580);
            this.Controls.Add(this.ActiveUsersTextBox);
            this.Controls.Add(this.PublicMessageButton);
            this.Controls.Add(this.PublicMessageTextBox);
            this.Controls.Add(this.PublicMessageLabel);
            this.Controls.Add(this.PublicChatTextBox);
            this.Controls.Add(this.PublicChatLabel);
            this.Controls.Add(this.CurrentUsersLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Chat Application";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem LoginMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegisterMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenu;
        private System.Windows.Forms.ToolStripMenuItem AuthorsMenuItem;
        private System.Windows.Forms.Label CurrentUsersLabel;
        private System.Windows.Forms.Label PublicChatLabel;
        public System.Windows.Forms.RichTextBox PublicChatTextBox;
        private System.Windows.Forms.Label PublicMessageLabel;
        private System.Windows.Forms.RichTextBox PublicMessageTextBox;
        private System.Windows.Forms.Button PublicMessageButton;
        private System.Windows.Forms.ToolStripMenuItem LogoutMenuItem;
        private System.Windows.Forms.ListView ActiveUsersTextBox;
        private System.Windows.Forms.ImageList AvatarList;
    }
}

