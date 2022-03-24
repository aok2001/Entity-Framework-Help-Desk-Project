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
            this.SuspendLayout();
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(12, 12);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(118, 23);
            this.btnTicket.TabIndex = 1;
            this.btnTicket.Text = "Submit ticket";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // lstAdmins
            // 
            this.lstAdmins.FormattingEnabled = true;
            this.lstAdmins.ItemHeight = 15;
            this.lstAdmins.Location = new System.Drawing.Point(136, 41);
            this.lstAdmins.Name = "lstAdmins";
            this.lstAdmins.Size = new System.Drawing.Size(120, 94);
            this.lstAdmins.TabIndex = 2;
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Location = new System.Drawing.Point(136, 12);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(118, 23);
            this.btnViewProfile.TabIndex = 3;
            this.btnViewProfile.Text = "View Profile";
            this.btnViewProfile.UseVisualStyleBackColor = true;
            this.btnViewProfile.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // btnInbox
            // 
            this.btnInbox.Location = new System.Drawing.Point(12, 41);
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Size = new System.Drawing.Size(118, 23);
            this.btnInbox.TabIndex = 4;
            this.btnInbox.Text = "View Inbox";
            this.btnInbox.UseVisualStyleBackColor = true;
            this.btnInbox.Click += new System.EventHandler(this.btnInbox_Click);
            // 
            // StandardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInbox);
            this.Controls.Add(this.btnViewProfile);
            this.Controls.Add(this.lstAdmins);
            this.Controls.Add(this.btnTicket);
            this.Name = "StandardForm";
            this.Text = "StandardForm";
            this.Load += new System.EventHandler(this.StandardForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.ListBox lstAdmins;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Button btnInbox;
    }
}