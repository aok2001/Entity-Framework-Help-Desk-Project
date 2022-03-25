namespace TestGUI
{
    partial class TicketInfoForm
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
            this.btnDone = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.lblOS = new System.Windows.Forms.Label();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.lblCoreCount = new System.Windows.Forms.Label();
            this.lblLogicalDrives = new System.Windows.Forms.Label();
            this.lblDotNetVersion = new System.Windows.Forms.Label();
            this.lblDomainName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.MistyRose;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDone.Location = new System.Drawing.Point(28, 30);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(168, 48);
            this.btnDone.TabIndex = 7;
            this.btnDone.Text = "Exit";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Honeydew;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser.Location = new System.Drawing.Point(448, 34);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(42, 21);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "User";
            // 
            // txtDesc
            // 
            this.txtDesc.Enabled = false;
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDesc.Location = new System.Drawing.Point(26, 164);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(951, 195);
            this.txtDesc.TabIndex = 8;
            this.txtDesc.Text = "";
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.BackColor = System.Drawing.Color.Azure;
            this.lblOS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOS.Location = new System.Drawing.Point(26, 118);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(31, 21);
            this.lblOS.TabIndex = 9;
            this.lblOS.Text = "OS";
            // 
            // lblMachineName
            // 
            this.lblMachineName.AutoSize = true;
            this.lblMachineName.BackColor = System.Drawing.Color.MistyRose;
            this.lblMachineName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMachineName.Location = new System.Drawing.Point(110, 118);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(111, 21);
            this.lblMachineName.TabIndex = 10;
            this.lblMachineName.Text = "MachineName";
            // 
            // lblCoreCount
            // 
            this.lblCoreCount.AutoSize = true;
            this.lblCoreCount.BackColor = System.Drawing.Color.LightYellow;
            this.lblCoreCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCoreCount.Location = new System.Drawing.Point(274, 118);
            this.lblCoreCount.Name = "lblCoreCount";
            this.lblCoreCount.Size = new System.Drawing.Size(85, 21);
            this.lblCoreCount.TabIndex = 11;
            this.lblCoreCount.Text = "CoreCount";
            // 
            // lblLogicalDrives
            // 
            this.lblLogicalDrives.AutoSize = true;
            this.lblLogicalDrives.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblLogicalDrives.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogicalDrives.Location = new System.Drawing.Point(412, 118);
            this.lblLogicalDrives.Name = "lblLogicalDrives";
            this.lblLogicalDrives.Size = new System.Drawing.Size(103, 21);
            this.lblLogicalDrives.TabIndex = 12;
            this.lblLogicalDrives.Text = "LogicalDrives";
            // 
            // lblDotNetVersion
            // 
            this.lblDotNetVersion.AutoSize = true;
            this.lblDotNetVersion.BackColor = System.Drawing.Color.GhostWhite;
            this.lblDotNetVersion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDotNetVersion.Location = new System.Drawing.Point(568, 118);
            this.lblDotNetVersion.Name = "lblDotNetVersion";
            this.lblDotNetVersion.Size = new System.Drawing.Size(112, 21);
            this.lblDotNetVersion.TabIndex = 13;
            this.lblDotNetVersion.Text = "DotNetVersion";
            // 
            // lblDomainName
            // 
            this.lblDomainName.AutoSize = true;
            this.lblDomainName.BackColor = System.Drawing.Color.AliceBlue;
            this.lblDomainName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDomainName.Location = new System.Drawing.Point(870, 118);
            this.lblDomainName.Name = "lblDomainName";
            this.lblDomainName.Size = new System.Drawing.Size(107, 21);
            this.lblDomainName.TabIndex = 14;
            this.lblDomainName.Text = "DomainName";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Cornsilk;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.Location = new System.Drawing.Point(733, 118);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(84, 21);
            this.lblUserName.TabIndex = 15;
            this.lblUserName.Text = "UserName";
            // 
            // txtCategory
            // 
            this.txtCategory.Enabled = false;
            this.txtCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCategory.Location = new System.Drawing.Point(26, 392);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(951, 29);
            this.txtCategory.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.lblDomainName);
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.txtCategory);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Controls.Add(this.lblOS);
            this.groupBox1.Controls.Add(this.lblMachineName);
            this.groupBox1.Controls.Add(this.lblDotNetVersion);
            this.groupBox1.Controls.Add(this.lblCoreCount);
            this.groupBox1.Controls.Add(this.lblLogicalDrives);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(28, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1036, 458);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ticket Info";
            // 
            // TicketInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1105, 604);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.groupBox1);
            this.Name = "TicketInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketInfoForm";
            this.Load += new System.EventHandler(this.TicketInfoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.RichTextBox txtDesc;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.Label lblCoreCount;
        private System.Windows.Forms.Label lblLogicalDrives;
        private System.Windows.Forms.Label lblDotNetVersion;
        private System.Windows.Forms.Label lblDomainName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}