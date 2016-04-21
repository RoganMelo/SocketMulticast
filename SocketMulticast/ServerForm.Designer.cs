namespace SocketMulticast
{
    partial class ServerForm
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
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnSendMessage = new System.Windows.Forms.Button();
            this.ListBoxServerInformations = new System.Windows.Forms.ListBox();
            this.TextBoxMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(13, 13);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(160, 72);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Enabled = false;
            this.BtnStop.Location = new System.Drawing.Point(177, 13);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(160, 72);
            this.BtnStop.TabIndex = 1;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnSendMessage
            // 
            this.BtnSendMessage.Enabled = false;
            this.BtnSendMessage.Location = new System.Drawing.Point(13, 180);
            this.BtnSendMessage.Name = "BtnSendMessage";
            this.BtnSendMessage.Size = new System.Drawing.Size(324, 23);
            this.BtnSendMessage.TabIndex = 2;
            this.BtnSendMessage.Text = "Send Message";
            this.BtnSendMessage.UseVisualStyleBackColor = true;
            this.BtnSendMessage.Click += new System.EventHandler(this.BtnSendMessage_Click);
            // 
            // ListBoxServerInformations
            // 
            this.ListBoxServerInformations.FormattingEnabled = true;
            this.ListBoxServerInformations.Location = new System.Drawing.Point(13, 209);
            this.ListBoxServerInformations.Name = "ListBoxServerInformations";
            this.ListBoxServerInformations.Size = new System.Drawing.Size(324, 108);
            this.ListBoxServerInformations.TabIndex = 3;
            // 
            // TextBoxMessage
            // 
            this.TextBoxMessage.Enabled = false;
            this.TextBoxMessage.Location = new System.Drawing.Point(13, 92);
            this.TextBoxMessage.Multiline = true;
            this.TextBoxMessage.Name = "TextBoxMessage";
            this.TextBoxMessage.Size = new System.Drawing.Size(324, 82);
            this.TextBoxMessage.TabIndex = 4;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 324);
            this.Controls.Add(this.TextBoxMessage);
            this.Controls.Add(this.ListBoxServerInformations);
            this.Controls.Add(this.BtnSendMessage);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnStart);
            this.Name = "ServerForm";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.ServerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnSendMessage;
        private System.Windows.Forms.ListBox ListBoxServerInformations;
        private System.Windows.Forms.TextBox TextBoxMessage;
    }
}

