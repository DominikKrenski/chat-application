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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegisterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AuthorsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentUsersLabel = new System.Windows.Forms.Label();
            this.ActiveUsersTextBox = new System.Windows.Forms.RichTextBox();
            this.PublicChatLabel = new System.Windows.Forms.Label();
            this.PublicChatTextBox = new System.Windows.Forms.RichTextBox();
            this.PublicMessageLabel = new System.Windows.Forms.Label();
            this.PublicMessageTextBox = new System.Windows.Forms.RichTextBox();
            this.FontButton = new System.Windows.Forms.Button();
            this.ColorButton = new System.Windows.Forms.Button();
            this.PublicMessageButton = new System.Windows.Forms.Button();
            this.PrivateMessageButton = new System.Windows.Forms.Button();
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
            this.ExitMenuItem});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "File";
            // 
            // LoginMenuItem
            // 
            this.LoginMenuItem.Name = "LoginMenuItem";
            this.LoginMenuItem.Size = new System.Drawing.Size(152, 22);
            this.LoginMenuItem.Text = "Login";
            // 
            // RegisterMenuItem
            // 
            this.RegisterMenuItem.Name = "RegisterMenuItem";
            this.RegisterMenuItem.Size = new System.Drawing.Size(152, 22);
            this.RegisterMenuItem.Text = "Register";
            this.RegisterMenuItem.Click += new System.EventHandler(this.RegisterMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitMenuItem.Text = "Exit";
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
            // ActiveUsersTextBox
            // 
            this.ActiveUsersTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ActiveUsersTextBox.Location = new System.Drawing.Point(16, 44);
            this.ActiveUsersTextBox.Name = "ActiveUsersTextBox";
            this.ActiveUsersTextBox.ReadOnly = true;
            this.ActiveUsersTextBox.Size = new System.Drawing.Size(173, 421);
            this.ActiveUsersTextBox.TabIndex = 2;
            this.ActiveUsersTextBox.Text = "";
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
            // FontButton
            // 
            this.FontButton.Location = new System.Drawing.Point(435, 496);
            this.FontButton.Name = "FontButton";
            this.FontButton.Size = new System.Drawing.Size(98, 23);
            this.FontButton.TabIndex = 7;
            this.FontButton.Text = "Font";
            this.FontButton.UseVisualStyleBackColor = true;
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(569, 496);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(105, 23);
            this.ColorButton.TabIndex = 8;
            this.ColorButton.Text = "Color";
            this.ColorButton.UseVisualStyleBackColor = true;
            // 
            // PublicMessageButton
            // 
            this.PublicMessageButton.Location = new System.Drawing.Point(435, 535);
            this.PublicMessageButton.Name = "PublicMessageButton";
            this.PublicMessageButton.Size = new System.Drawing.Size(98, 23);
            this.PublicMessageButton.TabIndex = 9;
            this.PublicMessageButton.Text = "Send Message";
            this.PublicMessageButton.UseVisualStyleBackColor = true;
            // 
            // PrivateMessageButton
            // 
            this.PrivateMessageButton.Location = new System.Drawing.Point(569, 535);
            this.PrivateMessageButton.Name = "PrivateMessageButton";
            this.PrivateMessageButton.Size = new System.Drawing.Size(105, 23);
            this.PrivateMessageButton.TabIndex = 10;
            this.PrivateMessageButton.Text = "Private Message";
            this.PrivateMessageButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 580);
            this.Controls.Add(this.PrivateMessageButton);
            this.Controls.Add(this.PublicMessageButton);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.FontButton);
            this.Controls.Add(this.PublicMessageTextBox);
            this.Controls.Add(this.PublicMessageLabel);
            this.Controls.Add(this.PublicChatTextBox);
            this.Controls.Add(this.PublicChatLabel);
            this.Controls.Add(this.ActiveUsersTextBox);
            this.Controls.Add(this.CurrentUsersLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Chat Application";
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
        private System.Windows.Forms.RichTextBox ActiveUsersTextBox;
        private System.Windows.Forms.Label PublicChatLabel;
        private System.Windows.Forms.RichTextBox PublicChatTextBox;
        private System.Windows.Forms.Label PublicMessageLabel;
        private System.Windows.Forms.RichTextBox PublicMessageTextBox;
        private System.Windows.Forms.Button FontButton;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Button PublicMessageButton;
        private System.Windows.Forms.Button PrivateMessageButton;
    }
}

