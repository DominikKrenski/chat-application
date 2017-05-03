namespace Client
{
    partial class PrivateMessageReceiveForm
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
            this.SenderLabel = new System.Windows.Forms.Label();
            this.SenderTextBox = new System.Windows.Forms.TextBox();
            this.PrivateMessageLabel = new System.Windows.Forms.Label();
            this.PrivateMessageTextBox = new System.Windows.Forms.RichTextBox();
            this.ResponseButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SenderLabel
            // 
            this.SenderLabel.AutoSize = true;
            this.SenderLabel.Location = new System.Drawing.Point(12, 9);
            this.SenderLabel.Name = "SenderLabel";
            this.SenderLabel.Size = new System.Drawing.Size(30, 13);
            this.SenderLabel.TabIndex = 0;
            this.SenderLabel.Text = "From";
            // 
            // SenderTextBox
            // 
            this.SenderTextBox.Location = new System.Drawing.Point(15, 25);
            this.SenderTextBox.Name = "SenderTextBox";
            this.SenderTextBox.Size = new System.Drawing.Size(478, 20);
            this.SenderTextBox.TabIndex = 1;
            // 
            // PrivateMessageLabel
            // 
            this.PrivateMessageLabel.AutoSize = true;
            this.PrivateMessageLabel.Location = new System.Drawing.Point(12, 58);
            this.PrivateMessageLabel.Name = "PrivateMessageLabel";
            this.PrivateMessageLabel.Size = new System.Drawing.Size(50, 13);
            this.PrivateMessageLabel.TabIndex = 2;
            this.PrivateMessageLabel.Text = "Message";
            // 
            // PrivateMessageTextBox
            // 
            this.PrivateMessageTextBox.Location = new System.Drawing.Point(15, 74);
            this.PrivateMessageTextBox.Name = "PrivateMessageTextBox";
            this.PrivateMessageTextBox.Size = new System.Drawing.Size(478, 258);
            this.PrivateMessageTextBox.TabIndex = 3;
            this.PrivateMessageTextBox.Text = "";
            // 
            // ResponseButton
            // 
            this.ResponseButton.Location = new System.Drawing.Point(15, 353);
            this.ResponseButton.Name = "ResponseButton";
            this.ResponseButton.Size = new System.Drawing.Size(75, 23);
            this.ResponseButton.TabIndex = 4;
            this.ResponseButton.Text = "Response";
            this.ResponseButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(418, 353);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "OK";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // PrivateMessageReceiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 388);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ResponseButton);
            this.Controls.Add(this.PrivateMessageTextBox);
            this.Controls.Add(this.PrivateMessageLabel);
            this.Controls.Add(this.SenderTextBox);
            this.Controls.Add(this.SenderLabel);
            this.Name = "PrivateMessageReceiveForm";
            this.Text = "PrivateMessageReceiveForm";
            this.Load += new System.EventHandler(this.PrivateMessageReceiveForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SenderLabel;
        public System.Windows.Forms.TextBox SenderTextBox;
        private System.Windows.Forms.Label PrivateMessageLabel;
        public System.Windows.Forms.RichTextBox PrivateMessageTextBox;
        private System.Windows.Forms.Button ResponseButton;
        private System.Windows.Forms.Button CloseButton;
    }
}