namespace TestGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLU = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.dtBirthdate = new System.Windows.Forms.DateTimePicker();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.txtOccupation = new System.Windows.Forms.TextBox();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnNewAccount = new System.Windows.Forms.Button();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.gbRegister = new System.Windows.Forms.GroupBox();
            this.gbLogin.SuspendLayout();
            this.gbRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Honeydew;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Location = new System.Drawing.Point(93, 133);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(275, 44);
            this.btnLogin.TabIndex = 35;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLP
            // 
            this.txtLP.Location = new System.Drawing.Point(93, 87);
            this.txtLP.Name = "txtLP";
            this.txtLP.Size = new System.Drawing.Size(275, 29);
            this.txtLP.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "Password";
            // 
            // txtLU
            // 
            this.txtLU.Location = new System.Drawing.Point(93, 41);
            this.txtLU.Name = "txtLU";
            this.txtLU.Size = new System.Drawing.Size(275, 29);
            this.txtLU.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Username";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Honeydew;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.Location = new System.Drawing.Point(109, 413);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(271, 44);
            this.btnRegister.TabIndex = 30;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // dtBirthdate
            // 
            this.dtBirthdate.Location = new System.Drawing.Point(109, 361);
            this.dtBirthdate.Name = "dtBirthdate";
            this.dtBirthdate.Size = new System.Drawing.Size(271, 29);
            this.dtBirthdate.TabIndex = 29;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(19, 367);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(79, 21);
            this.lblBirthDate.TabIndex = 28;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // txtOccupation
            // 
            this.txtOccupation.Location = new System.Drawing.Point(109, 269);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.Size = new System.Drawing.Size(271, 29);
            this.txtOccupation.TabIndex = 27;
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Location = new System.Drawing.Point(14, 272);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(89, 21);
            this.lblOccupation.TabIndex = 26;
            this.lblOccupation.Text = "Occupation";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(109, 222);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(271, 29);
            this.txtLastName.TabIndex = 25;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(16, 225);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(84, 21);
            this.lblLastName.TabIndex = 24;
            this.lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(109, 175);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(271, 29);
            this.txtFirstName.TabIndex = 23;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(16, 178);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(86, 21);
            this.lblFirstName.TabIndex = 22;
            this.lblFirstName.Text = "First Name";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(109, 101);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(271, 29);
            this.txtPassword.TabIndex = 21;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(19, 104);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(76, 21);
            this.lblPassword.TabIndex = 20;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(109, 53);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(271, 29);
            this.txtUsername.TabIndex = 19;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Gainsboro;
            this.lblUsername.Location = new System.Drawing.Point(16, 56);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(81, 21);
            this.lblUsername.TabIndex = 18;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "Acct Type";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Standard",
            "Admin"});
            this.cbType.Location = new System.Drawing.Point(109, 317);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(271, 29);
            this.cbType.TabIndex = 37;
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.BackColor = System.Drawing.Color.Azure;
            this.btnNewAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewAccount.Location = new System.Drawing.Point(93, 186);
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.Size = new System.Drawing.Size(275, 44);
            this.btnNewAccount.TabIndex = 38;
            this.btnNewAccount.Text = "Create Account";
            this.btnNewAccount.UseVisualStyleBackColor = false;
            this.btnNewAccount.Click += new System.EventHandler(this.btnNewAccount_Click);
            // 
            // gbLogin
            // 
            this.gbLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.gbLogin.Controls.Add(this.btnLogin);
            this.gbLogin.Controls.Add(this.label1);
            this.gbLogin.Controls.Add(this.btnNewAccount);
            this.gbLogin.Controls.Add(this.txtLU);
            this.gbLogin.Controls.Add(this.label2);
            this.gbLogin.Controls.Add(this.txtLP);
            this.gbLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbLogin.Location = new System.Drawing.Point(21, 22);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(411, 243);
            this.gbLogin.TabIndex = 39;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Log In";
            // 
            // gbRegister
            // 
            this.gbRegister.BackColor = System.Drawing.Color.Gainsboro;
            this.gbRegister.Controls.Add(this.lblUsername);
            this.gbRegister.Controls.Add(this.txtUsername);
            this.gbRegister.Controls.Add(this.btnRegister);
            this.gbRegister.Controls.Add(this.lblPassword);
            this.gbRegister.Controls.Add(this.cbType);
            this.gbRegister.Controls.Add(this.txtPassword);
            this.gbRegister.Controls.Add(this.label3);
            this.gbRegister.Controls.Add(this.lblFirstName);
            this.gbRegister.Controls.Add(this.txtFirstName);
            this.gbRegister.Controls.Add(this.dtBirthdate);
            this.gbRegister.Controls.Add(this.lblLastName);
            this.gbRegister.Controls.Add(this.lblBirthDate);
            this.gbRegister.Controls.Add(this.txtLastName);
            this.gbRegister.Controls.Add(this.txtOccupation);
            this.gbRegister.Controls.Add(this.lblOccupation);
            this.gbRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbRegister.Location = new System.Drawing.Point(21, 295);
            this.gbRegister.Name = "gbRegister";
            this.gbRegister.Size = new System.Drawing.Size(411, 488);
            this.gbRegister.TabIndex = 40;
            this.gbRegister.TabStop = false;
            this.gbRegister.Text = "Register";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(454, 806);
            this.Controls.Add(this.gbRegister);
            this.Controls.Add(this.gbLogin);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbRegister.ResumeLayout(false);
            this.gbRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.DateTimePicker dtBirthdate;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.TextBox txtOccupation;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnNewAccount;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.GroupBox gbRegister;
    }
}
