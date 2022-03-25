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
            this.lstPending = new System.Windows.Forms.ListBox();
            this.btnAcceptTicket = new System.Windows.Forms.Button();
            this.lstActive = new System.Windows.Forms.ListBox();
            this.lstClosed = new System.Windows.Forms.ListBox();
            this.btnReopen = new System.Windows.Forms.Button();
            this.btnCloseTicket = new System.Windows.Forms.Button();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.btnMessages = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.gbTickets = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMoreInfo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbUsers = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.gbTickets.SuspendLayout();
            this.gbUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPending
            // 
            this.lstPending.FormattingEnabled = true;
            this.lstPending.ItemHeight = 15;
            this.lstPending.Location = new System.Drawing.Point(6, 22);
            this.lstPending.Name = "lstPending";
            this.lstPending.Size = new System.Drawing.Size(109, 259);
            this.lstPending.TabIndex = 0;
            // 
            // btnAcceptTicket
            // 
            this.btnAcceptTicket.Location = new System.Drawing.Point(6, 287);
            this.btnAcceptTicket.Name = "btnAcceptTicket";
            this.btnAcceptTicket.Size = new System.Drawing.Size(109, 23);
            this.btnAcceptTicket.TabIndex = 1;
            this.btnAcceptTicket.Text = "Accept Ticket";
            this.btnAcceptTicket.UseVisualStyleBackColor = true;
            this.btnAcceptTicket.Click += new System.EventHandler(this.btnAcceptTicket_Click);
            // 
            // lstActive
            // 
            this.lstActive.FormattingEnabled = true;
            this.lstActive.ItemHeight = 15;
            this.lstActive.Location = new System.Drawing.Point(121, 22);
            this.lstActive.Name = "lstActive";
            this.lstActive.Size = new System.Drawing.Size(109, 259);
            this.lstActive.TabIndex = 2;
            // 
            // lstClosed
            // 
            this.lstClosed.FormattingEnabled = true;
            this.lstClosed.ItemHeight = 15;
            this.lstClosed.Location = new System.Drawing.Point(236, 22);
            this.lstClosed.Name = "lstClosed";
            this.lstClosed.Size = new System.Drawing.Size(109, 259);
            this.lstClosed.TabIndex = 3;
            // 
            // btnReopen
            // 
            this.btnReopen.Location = new System.Drawing.Point(236, 287);
            this.btnReopen.Name = "btnReopen";
            this.btnReopen.Size = new System.Drawing.Size(109, 23);
            this.btnReopen.TabIndex = 4;
            this.btnReopen.Text = "Reopen Ticket";
            this.btnReopen.UseVisualStyleBackColor = true;
            this.btnReopen.Click += new System.EventHandler(this.btnReopen_Click);
            // 
            // btnCloseTicket
            // 
            this.btnCloseTicket.Location = new System.Drawing.Point(121, 287);
            this.btnCloseTicket.Name = "btnCloseTicket";
            this.btnCloseTicket.Size = new System.Drawing.Size(109, 23);
            this.btnCloseTicket.TabIndex = 5;
            this.btnCloseTicket.Text = "Close Ticket";
            this.btnCloseTicket.UseVisualStyleBackColor = true;
            this.btnCloseTicket.Click += new System.EventHandler(this.btnCloseTicket_Click);
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 15;
            this.lstUsers.Location = new System.Drawing.Point(0, 22);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(109, 259);
            this.lstUsers.TabIndex = 6;
            // 
            // btnMessages
            // 
            this.btnMessages.Location = new System.Drawing.Point(495, 34);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.Size = new System.Drawing.Size(109, 23);
            this.btnMessages.TabIndex = 7;
            this.btnMessages.Text = "View Inbox";
            this.btnMessages.UseVisualStyleBackColor = true;
            this.btnMessages.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(0, 287);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(109, 23);
            this.btnProfile.TabIndex = 8;
            this.btnProfile.Text = "View Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // gbTickets
            // 
            this.gbTickets.Controls.Add(this.button2);
            this.gbTickets.Controls.Add(this.btnMoreInfo);
            this.gbTickets.Controls.Add(this.button1);
            this.gbTickets.Controls.Add(this.lstPending);
            this.gbTickets.Controls.Add(this.btnAcceptTicket);
            this.gbTickets.Controls.Add(this.lstActive);
            this.gbTickets.Controls.Add(this.lstClosed);
            this.gbTickets.Controls.Add(this.btnCloseTicket);
            this.gbTickets.Controls.Add(this.btnReopen);
            this.gbTickets.Location = new System.Drawing.Point(12, 12);
            this.gbTickets.Name = "gbTickets";
            this.gbTickets.Size = new System.Drawing.Size(351, 346);
            this.gbTickets.TabIndex = 10;
            this.gbTickets.TabStop = false;
            this.gbTickets.Text = "Tickets";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "More Ticket Info";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMoreInfo
            // 
            this.btnMoreInfo.Location = new System.Drawing.Point(6, 316);
            this.btnMoreInfo.Name = "btnMoreInfo";
            this.btnMoreInfo.Size = new System.Drawing.Size(109, 23);
            this.btnMoreInfo.TabIndex = 11;
            this.btnMoreInfo.Text = "More Ticket Info";
            this.btnMoreInfo.UseVisualStyleBackColor = true;
            this.btnMoreInfo.Click += new System.EventHandler(this.btnMoreInfo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "More Ticket Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbUsers
            // 
            this.gbUsers.Controls.Add(this.lstUsers);
            this.gbUsers.Controls.Add(this.btnProfile);
            this.gbUsers.Location = new System.Drawing.Point(369, 12);
            this.gbUsers.Name = "gbUsers";
            this.gbUsers.Size = new System.Drawing.Size(120, 317);
            this.gbUsers.TabIndex = 6;
            this.gbUsers.TabStop = false;
            this.gbUsers.Text = "Users";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(495, 63);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(109, 23);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 368);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.gbUsers);
            this.Controls.Add(this.gbTickets);
            this.Controls.Add(this.btnMessages);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.gbTickets.ResumeLayout(false);
            this.gbUsers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPending;
        private System.Windows.Forms.Button btnAcceptTicket;
        private System.Windows.Forms.ListBox lstActive;
        private System.Windows.Forms.ListBox lstClosed;
        private System.Windows.Forms.Button btnReopen;
        private System.Windows.Forms.Button btnCloseTicket;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Button btnMessages;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.GroupBox gbTickets;
        private System.Windows.Forms.GroupBox gbUsers;
        private System.Windows.Forms.Button btnMoreInfo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLogout;
    }
}