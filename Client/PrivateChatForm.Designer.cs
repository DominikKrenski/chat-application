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
            this.SuspendLayout();
            // 
            // PrivateChatLabel
            // 
            this.PrivateChatLabel.AutoSize = true;
            this.PrivateChatLabel.Location = new System.Drawing.Point(12, 9);
            this.PrivateChatLabel.Name = "PrivateChatLabel";
            this.PrivateChatLabel.Size = new System.Drawing.Size(62, 13);
            this.PrivateChatLabel.TabIndex = 0;
            this.PrivateChatLabel.Text = "PrivateChat";
            // 
            // PrivateChatTextBox
            // 
            this.PrivateChatTextBox.Location = new System.Drawing.Point(15, 25);
            this.PrivateChatTextBox.Name = "PrivateChatTextBox";
            this.PrivateChatTextBox.Size = new System.Drawing.Size(588, 172);
            this.PrivateChatTextBox.TabIndex = 1;
            this.PrivateChatTextBox.Text = "";
            // 
            // PrivateMessageLabel
            // 
            this.PrivateMessageLabel.AutoSize = true;
            this.PrivateMessageLabel.Location = new System.Drawing.Point(12, 211);
            this.PrivateMessageLabel.Name = "PrivateMessageLabel";
            this.PrivateMessageLabel.Size = new System.Drawing.Size(86, 13);
            this.PrivateMessageLabel.TabIndex = 2;
            this.PrivateMessageLabel.Text = "Private Message";
            // 
            // PrivateMessageTextBox
            // 
            this.PrivateMessageTextBox.Location = new System.Drawing.Point(15, 227);
            this.PrivateMessageTextBox.Name = "PrivateMessageTextBox";
            this.PrivateMessageTextBox.Size = new System.Drawing.Size(588, 103);
            this.PrivateMessageTextBox.TabIndex = 3;
            this.PrivateMessageTextBox.Text = "";
            // 
            // SendPrivateMessageButton
            // 
            this.SendPrivateMessageButton.Location = new System.Drawing.Point(274, 353);
            this.SendPrivateMessageButton.Name = "SendPrivateMessageButton";
            this.SendPrivateMessageButton.Size = new System.Drawing.Size(75, 23);
            this.SendPrivateMessageButton.TabIndex = 4;
            this.SendPrivateMessageButton.Text = "Send";
            this.SendPrivateMessageButton.UseVisualStyleBackColor = true;
            this.SendPrivateMessageButton.Click += new System.EventHandler(this.SendPrivateMessageButton_Click);
            // 
            // PrivateChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 388);
            this.Controls.Add(this.SendPrivateMessageButton);
            this.Controls.Add(this.PrivateMessageTextBox);
            this.Controls.Add(this.PrivateMessageLabel);
            this.Controls.Add(this.PrivateChatTextBox);
            this.Controls.Add(this.PrivateChatLabel);
            this.Name = "PrivateChatForm";
            this.Text = "PrivateChatForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PrivateChatLabel;
        public System.Windows.Forms.RichTextBox PrivateChatTextBox;
        private System.Windows.Forms.Label PrivateMessageLabel;
        public System.Windows.Forms.RichTextBox PrivateMessageTextBox;
        private System.Windows.Forms.Button SendPrivateMessageButton;
    }
}