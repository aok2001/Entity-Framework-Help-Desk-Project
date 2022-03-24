namespace TestGUI
{
    partial class AdminForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAcceptTicket = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.btnReopen = new System.Windows.Forms.Button();
            this.btnCloseTicket = new System.Windows.Forms.Button();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.btnMessages = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 259);
            this.listBox1.TabIndex = 0;
            // 
            // btnAcceptTicket
            // 
            this.btnAcceptTicket.Location = new System.Drawing.Point(12, 277);
            this.btnAcceptTicket.Name = "btnAcceptTicket";
            this.btnAcceptTicket.Size = new System.Drawing.Size(215, 23);
            this.btnAcceptTicket.TabIndex = 1;
            this.btnAcceptTicket.Text = "Accept Ticket";
            this.btnAcceptTicket.UseVisualStyleBackColor = true;
            this.btnAcceptTicket.Click += new System.EventHandler(this.btnAcceptTicket_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(233, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(210, 259);
            this.listBox2.TabIndex = 2;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(449, 12);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(210, 259);
            this.listBox3.TabIndex = 3;
            // 
            // btnReopen
            // 
            this.btnReopen.Location = new System.Drawing.Point(449, 277);
            this.btnReopen.Name = "btnReopen";
            this.btnReopen.Size = new System.Drawing.Size(210, 23);
            this.btnReopen.TabIndex = 4;
            this.btnReopen.Text = "Reopen Ticket";
            this.btnReopen.UseVisualStyleBackColor = true;
            this.btnReopen.Click += new System.EventHandler(this.btnReopen_Click);
            // 
            // btnCloseTicket
            // 
            this.btnCloseTicket.Location = new System.Drawing.Point(233, 277);
            this.btnCloseTicket.Name = "btnCloseTicket";
            this.btnCloseTicket.Size = new System.Drawing.Size(210, 23);
            this.btnCloseTicket.TabIndex = 5;
            this.btnCloseTicket.Text = "Close Ticket";
            this.btnCloseTicket.UseVisualStyleBackColor = true;
            this.btnCloseTicket.Click += new System.EventHandler(this.btnCloseTicket_Click);
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 15;
            this.lstUsers.Location = new System.Drawing.Point(665, 12);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(123, 259);
            this.lstUsers.TabIndex = 6;
            // 
            // btnMessages
            // 
            this.btnMessages.Location = new System.Drawing.Point(665, 277);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.Size = new System.Drawing.Size(123, 23);
            this.btnMessages.TabIndex = 7;
            this.btnMessages.Text = "View Inbox";
            this.btnMessages.UseVisualStyleBackColor = true;
            this.btnMessages.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(665, 306);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(123, 23);
            this.btnProfile.TabIndex = 8;
            this.btnProfile.Text = "View Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 15;
            this.listBox4.Location = new System.Drawing.Point(665, 335);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(123, 169);
            this.listBox4.TabIndex = 9;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnMessages);
            this.Controls.Add(this.lstUsers);
            this.Controls.Add(this.btnCloseTicket);
            this.Controls.Add(this.btnReopen);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnAcceptTicket);
            this.Controls.Add(this.listBox1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAcceptTicket;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button btnReopen;
        private System.Windows.Forms.Button btnCloseTicket;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Button btnMessages;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.ListBox listBox4;
    }
}