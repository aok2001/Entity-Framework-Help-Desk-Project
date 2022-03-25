namespace TestGUI
{
    partial class StandardForm
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
            this.btnTicket = new System.Windows.Forms.Button();
            this.lstAdmins = new System.Windows.Forms.ListBox();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.btnInbox = new System.Windows.Forms.Button();
            this.gbAdmins = new System.Windows.Forms.GroupBox();
            this.btnTicketHistory = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.gbAdmins.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTicket
            // 
            this.btnTicket.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTicket.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTicket.Location = new System.Drawing.Point(265, 147);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(223, 38);
            this.btnTicket.TabIndex = 1;
            this.btnTicket.Text = "Submit ticket";
            this.btnTicket.UseVisualStyleBackColor = false;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // lstAdmins
            // 
            this.lstAdmins.FormattingEnabled = true;
            this.lstAdmins.ItemHeight = 21;
            this.lstAdmins.Location = new System.Drawing.Point(23, 49);
            this.lstAdmins.Name = "lstAdmins";
            this.lstAdmins.Size = new System.Drawing.Size(223, 319);
            this.lstAdmins.TabIndex = 2;
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.BackColor = System.Drawing.Color.Azure;
            this.btnViewProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewProfile.Location = new System.Drawing.Point(23, 377);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(223, 38);
            this.btnViewProfile.TabIndex = 3;
            this.btnViewProfile.Text = "View Profile";
            this.btnViewProfile.UseVisualStyleBackColor = false;
            this.btnViewProfile.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // btnInbox
            // 
            this.btnInbox.BackColor = System.Drawing.Color.Honeydew;
            this.btnInbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInbox.Location = new System.Drawing.Point(265, 49);
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Size = new System.Drawing.Size(223, 38);
            this.btnInbox.TabIndex = 4;
            this.btnInbox.Text = "View Inbox";
            this.btnInbox.UseVisualStyleBackColor = false;
            this.btnInbox.Click += new System.EventHandler(this.btnInbox_Click);
            // 
            // gbAdmins
            // 
            this.gbAdmins.BackColor = System.Drawing.Color.Gainsboro;
            this.gbAdmins.Controls.Add(this.btnLogout);
            this.gbAdmins.Controls.Add(this.lstAdmins);
            this.gbAdmins.Controls.Add(this.btnTicketHistory);
            this.gbAdmins.Controls.Add(this.btnViewProfile);
            this.gbAdmins.Controls.Add(this.btnInbox);
            this.gbAdmins.Controls.Add(this.btnTicket);
            this.gbAdmins.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbAdmins.Location = new System.Drawing.Point(12, 19);
            this.gbAdmins.Name = "gbAdmins";
            this.gbAdmins.Size = new System.Drawing.Size(512, 444);
            this.gbAdmins.TabIndex = 5;
            this.gbAdmins.TabStop = false;
            this.gbAdmins.Text = "Admins";
            // 
            // btnTicketHistory
            // 
            this.btnTicketHistory.BackColor = System.Drawing.Color.LightYellow;
            this.btnTicketHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTicketHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTicketHistory.Location = new System.Drawing.Point(265, 98);
            this.btnTicketHistory.Name = "btnTicketHistory";
            this.btnTicketHistory.Size = new System.Drawing.Size(223, 38);
            this.btnTicketHistory.TabIndex = 6;
            this.btnTicketHistory.Text = "View Ticket History";
            this.btnTicketHistory.UseVisualStyleBackColor = false;
            this.btnTicketHistory.Click += new System.EventHandler(this.btnTicketHistory_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.MistyRose;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(265, 196);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(223, 38);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // StandardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(540, 489);
            this.Controls.Add(this.gbAdmins);
            this.Name = "StandardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StandardForm";
            this.Load += new System.EventHandler(this.StandardForm_Load);
            this.gbAdmins.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.ListBox lstAdmins;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Button btnInbox;
        private System.Windows.Forms.GroupBox gbAdmins;
        private System.Windows.Forms.Button btnTicketHistory;
        private System.Windows.Forms.Button btnLogout;
    }
}