namespace Client
{
    partial class PrivateMessageSendForm
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
            this.ReceiverLabel = new System.Windows.Forms.Label();
            this.PrivateLoginTextBox = new System.Windows.Forms.TextBox();
            this.PrivateMessageLabel = new System.Windows.Forms.Label();
            this.PrivateMessageTextBox = new System.Windows.Forms.RichTextBox();
            this.SendPrivateMessageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReceiverLabel
            // 
            this.ReceiverLabel.AutoSize = true;
            this.ReceiverLabel.Location = new System.Drawing.Point(12, 9);
            this.ReceiverLabel.Name = "ReceiverLabel";
            this.ReceiverLabel.Size = new System.Drawing.Size(20, 13);
            this.ReceiverLabel.TabIndex = 0;
            this.ReceiverLabel.Text = "To";
            // 
            // PrivateLoginTextBox
            // 
            this.PrivateLoginTextBox.Location = new System.Drawing.Point(15, 25);
            this.PrivateLoginTextBox.Name = "PrivateLoginTextBox";
            this.PrivateLoginTextBox.Size = new System.Drawing.Size(374, 20);
            this.PrivateLoginTextBox.TabIndex = 1;
            // 
            // PrivateMessageLabel
            // 
            this.PrivateMessageLabel.AutoSize = true;
            this.PrivateMessageLabel.Location = new System.Drawing.Point(12, 58);
            this.PrivateMessageLabel.Name = "PrivateMessageLabel";
            this.PrivateMessageLabel.Size = new System.Drawing.Size(86, 13);
            this.PrivateMessageLabel.TabIndex = 2;
            this.PrivateMessageLabel.Text = "Private Message";
            // 
            // PrivateMessageTextBox
            // 
            this.PrivateMessageTextBox.Location = new System.Drawing.Point(15, 74);
            this.PrivateMessageTextBox.Name = "PrivateMessageTextBox";
            this.PrivateMessageTextBox.Size = new System.Drawing.Size(374, 220);
            this.PrivateMessageTextBox.TabIndex = 3;
            this.PrivateMessageTextBox.Text = "";
            // 
            // SendPrivateMessageButton
            // 
            this.SendPrivateMessageButton.Location = new System.Drawing.Point(165, 311);
            this.SendPrivateMessageButton.Name = "SendPrivateMessageButton";
            this.SendPrivateMessageButton.Size = new System.Drawing.Size(75, 23);
            this.SendPrivateMessageButton.TabIndex = 4;
            this.SendPrivateMessageButton.Text = "Send";
            this.SendPrivateMessageButton.UseVisualStyleBackColor = true;
            this.SendPrivateMessageButton.Click += new System.EventHandler(this.SendPrivateMessageButton_Click);
            // 
            // PrivateMessageSendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 346);
            this.Controls.Add(this.SendPrivateMessageButton);
            this.Controls.Add(this.PrivateMessageTextBox);
            this.Controls.Add(this.PrivateMessageLabel);
            this.Controls.Add(this.PrivateLoginTextBox);
            this.Controls.Add(this.ReceiverLabel);
            this.Name = "PrivateMessageSendForm";
            this.Text = "PrivateMessageSendForm";
            this.Load += new System.EventHandler(this.PrivateMessageSendForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReceiverLabel;
        private System.Windows.Forms.TextBox PrivateLoginTextBox;
        private System.Windows.Forms.Label PrivateMessageLabel;
        private System.Windows.Forms.RichTextBox PrivateMessageTextBox;
        private System.Windows.Forms.Button SendPrivateMessageButton;
    }
}