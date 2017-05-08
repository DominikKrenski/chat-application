namespace Client
{
    partial class PrivateChatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PrivateChatLabel = new System.Windows.Forms.Label();
            this.PrivateChatTextBox = new System.Windows.Forms.RichTextBox();
            this.PrivateMessageLabel = new System.Windows.Forms.Label();
            this.PrivateMessageTextBox = new System.Windows.Forms.RichTextBox();
            this.SendPrivateMessageButton = new System.Windows.Forms.Button();
            this.PrivateUsersListBox = new System.Windows.Forms.ListBox();
            this.PrivateUsersLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EndConversationFileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrivateChatLabel
            // 
            this.PrivateChatLabel.AutoSize = true;
            this.PrivateChatLabel.Location = new System.Drawing.Point(187, 29);
            this.PrivateChatLabel.Name = "PrivateChatLabel";
            this.PrivateChatLabel.Size = new System.Drawing.Size(62, 13);
            this.PrivateChatLabel.TabIndex = 0;
            this.PrivateChatLabel.Text = "PrivateChat";
            // 
            // PrivateChatTextBox
            // 
            this.PrivateChatTextBox.Location = new System.Drawing.Point(187, 45);
            this.PrivateChatTextBox.Name = "PrivateChatTextBox";
            this.PrivateChatTextBox.Size = new System.Drawing.Size(588, 200);
            this.PrivateChatTextBox.TabIndex = 1;
            this.PrivateChatTextBox.Text = "";
            // 
            // PrivateMessageLabel
            // 
            this.PrivateMessageLabel.AutoSize = true;
            this.PrivateMessageLabel.Location = new System.Drawing.Point(187, 248);
            this.PrivateMessageLabel.Name = "PrivateMessageLabel";
            this.PrivateMessageLabel.Size = new System.Drawing.Size(86, 13);
            this.PrivateMessageLabel.TabIndex = 2;
            this.PrivateMessageLabel.Text = "Private Message";
            // 
            // PrivateMessageTextBox
            // 
            this.PrivateMessageTextBox.Location = new System.Drawing.Point(190, 273);
            this.PrivateMessageTextBox.Name = "PrivateMessageTextBox";
            this.PrivateMessageTextBox.Size = new System.Drawing.Size(588, 103);
            this.PrivateMessageTextBox.TabIndex = 3;
            this.PrivateMessageTextBox.Text = "";
            // 
            // SendPrivateMessageButton
            // 
            this.SendPrivateMessageButton.Location = new System.Drawing.Point(348, 401);
            this.SendPrivateMessageButton.Name = "SendPrivateMessageButton";
            this.SendPrivateMessageButton.Size = new System.Drawing.Size(75, 23);
            this.SendPrivateMessageButton.TabIndex = 4;
            this.SendPrivateMessageButton.Text = "Send";
            this.SendPrivateMessageButton.UseVisualStyleBackColor = true;
            this.SendPrivateMessageButton.Click += new System.EventHandler(this.SendPrivateMessageButton_Click);
            // 
            // PrivateUsersListBox
            // 
            this.PrivateUsersListBox.FormattingEnabled = true;
            this.PrivateUsersListBox.Location = new System.Drawing.Point(12, 47);
            this.PrivateUsersListBox.Name = "PrivateUsersListBox";
            this.PrivateUsersListBox.Size = new System.Drawing.Size(169, 329);
            this.PrivateUsersListBox.TabIndex = 5;
            this.PrivateUsersListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PrivateUsersListBox_MouseDoubleClick);
            // 
            // PrivateUsersLabel
            // 
            this.PrivateUsersLabel.AutoSize = true;
            this.PrivateUsersLabel.Location = new System.Drawing.Point(9, 29);
            this.PrivateUsersLabel.Name = "PrivateUsersLabel";
            this.PrivateUsersLabel.Size = new System.Drawing.Size(70, 13);
            this.PrivateUsersLabel.TabIndex = 6;
            this.PrivateUsersLabel.Text = "Private Users";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EndConversationFileItem});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "File";
            // 
            // EndConversationFileItem
            // 
            this.EndConversationFileItem.Name = "EndConversationFileItem";
            this.EndConversationFileItem.Size = new System.Drawing.Size(167, 22);
            this.EndConversationFileItem.Text = "End Conversation";
            this.EndConversationFileItem.Click += new System.EventHandler(this.EndConversationFileItem_Click);
            // 
            // PrivateChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 436);
            this.Controls.Add(this.PrivateUsersLabel);
            this.Controls.Add(this.PrivateUsersListBox);
            this.Controls.Add(this.SendPrivateMessageButton);
            this.Controls.Add(this.PrivateMessageTextBox);
            this.Controls.Add(this.PrivateMessageLabel);
            this.Controls.Add(this.PrivateChatTextBox);
            this.Controls.Add(this.PrivateChatLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrivateChatForm";
            this.Text = "PrivateChatForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PrivateChatLabel;
        public System.Windows.Forms.RichTextBox PrivateChatTextBox;
        private System.Windows.Forms.Label PrivateMessageLabel;
        public System.Windows.Forms.RichTextBox PrivateMessageTextBox;
        private System.Windows.Forms.Button SendPrivateMessageButton;
        public System.Windows.Forms.ListBox PrivateUsersListBox;
        private System.Windows.Forms.Label PrivateUsersLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem EndConversationFileItem;
    }
}