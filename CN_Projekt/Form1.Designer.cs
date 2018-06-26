namespace CN_Projekt
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.localgroupBox = new System.Windows.Forms.GroupBox();
            this.FriendsgroupBox = new System.Windows.Forms.GroupBox();
            this.textLocalIP = new System.Windows.Forms.TextBox();
            this.textLocalPort = new System.Windows.Forms.TextBox();
            this.textFriendsIP = new System.Windows.Forms.TextBox();
            this.textFriendsPort = new System.Windows.Forms.TextBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.localgroupBox.SuspendLayout();
            this.FriendsgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // localgroupBox
            // 
            this.localgroupBox.Controls.Add(this.label2);
            this.localgroupBox.Controls.Add(this.label1);
            this.localgroupBox.Controls.Add(this.textLocalPort);
            this.localgroupBox.Controls.Add(this.textLocalIP);
            this.localgroupBox.Location = new System.Drawing.Point(12, 48);
            this.localgroupBox.Name = "localgroupBox";
            this.localgroupBox.Size = new System.Drawing.Size(212, 100);
            this.localgroupBox.TabIndex = 0;
            this.localgroupBox.TabStop = false;
            this.localgroupBox.Text = "Client Info";
            // 
            // FriendsgroupBox
            // 
            this.FriendsgroupBox.Controls.Add(this.label4);
            this.FriendsgroupBox.Controls.Add(this.label3);
            this.FriendsgroupBox.Controls.Add(this.textFriendsPort);
            this.FriendsgroupBox.Controls.Add(this.textFriendsIP);
            this.FriendsgroupBox.Location = new System.Drawing.Point(352, 48);
            this.FriendsgroupBox.Name = "FriendsgroupBox";
            this.FriendsgroupBox.Size = new System.Drawing.Size(200, 100);
            this.FriendsgroupBox.TabIndex = 1;
            this.FriendsgroupBox.TabStop = false;
            this.FriendsgroupBox.Text = "Server Info";
            // 
            // textLocalIP
            // 
            this.textLocalIP.Location = new System.Drawing.Point(94, 19);
            this.textLocalIP.Name = "textLocalIP";
            this.textLocalIP.Size = new System.Drawing.Size(100, 20);
            this.textLocalIP.TabIndex = 0;
            // 
            // textLocalPort
            // 
            this.textLocalPort.Location = new System.Drawing.Point(94, 45);
            this.textLocalPort.Name = "textLocalPort";
            this.textLocalPort.Size = new System.Drawing.Size(100, 20);
            this.textLocalPort.TabIndex = 1;
            // 
            // textFriendsIP
            // 
            this.textFriendsIP.Location = new System.Drawing.Point(94, 18);
            this.textFriendsIP.Name = "textFriendsIP";
            this.textFriendsIP.Size = new System.Drawing.Size(100, 20);
            this.textFriendsIP.TabIndex = 0;
            // 
            // textFriendsPort
            // 
            this.textFriendsPort.Location = new System.Drawing.Point(94, 44);
            this.textFriendsPort.Name = "textFriendsPort";
            this.textFriendsPort.Size = new System.Drawing.Size(100, 20);
            this.textFriendsPort.TabIndex = 1;
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(18, 418);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(534, 20);
            this.textMessage.TabIndex = 2;
            // 
            // listMessage
            // 
            this.listMessage.FormattingEnabled = true;
            this.listMessage.Location = new System.Drawing.Point(18, 154);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(534, 251);
            this.listMessage.TabIndex = 3;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(652, 63);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonStart.TabIndex = 4;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonSend
            // 
            this.ButtonSend.Location = new System.Drawing.Point(652, 125);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(75, 23);
            this.ButtonSend.TabIndex = 5;
            this.ButtonSend.Text = "Send";
            this.ButtonSend.UseVisualStyleBackColor = true;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "PORT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonSend);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.FriendsgroupBox);
            this.Controls.Add(this.localgroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.localgroupBox.ResumeLayout(false);
            this.localgroupBox.PerformLayout();
            this.FriendsgroupBox.ResumeLayout(false);
            this.FriendsgroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox localgroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textLocalPort;
        private System.Windows.Forms.TextBox textLocalIP;
        private System.Windows.Forms.GroupBox FriendsgroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textFriendsPort;
        private System.Windows.Forms.TextBox textFriendsIP;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonSend;
    }
}

