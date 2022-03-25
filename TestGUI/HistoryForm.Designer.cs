namespace TestGUI
{
    partial class HistoryForm
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
            this.lstTickets = new System.Windows.Forms.ListBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.Tickets = new System.Windows.Forms.GroupBox();
            this.Tickets.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTickets
            // 
            this.lstTickets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstTickets.FormattingEnabled = true;
            this.lstTickets.ItemHeight = 21;
            this.lstTickets.Location = new System.Drawing.Point(26, 37);
            this.lstTickets.Name = "lstTickets";
            this.lstTickets.Size = new System.Drawing.Size(510, 298);
            this.lstTickets.TabIndex = 0;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.MistyRose;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDone.Location = new System.Drawing.Point(26, 356);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(510, 50);
            this.btnDone.TabIndex = 1;
            this.btnDone.Text = "Close";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // Tickets
            // 
            this.Tickets.BackColor = System.Drawing.Color.Gainsboro;
            this.Tickets.Controls.Add(this.lstTickets);
            this.Tickets.Controls.Add(this.btnDone);
            this.Tickets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tickets.Location = new System.Drawing.Point(22, 24);
            this.Tickets.Name = "Tickets";
            this.Tickets.Size = new System.Drawing.Size(566, 431);
            this.Tickets.TabIndex = 2;
            this.Tickets.TabStop = false;
            this.Tickets.Text = "Tickets";
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(625, 486);
            this.Controls.Add(this.Tickets);
            this.Name = "HistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoryForm";
            this.Tickets.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstTickets;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.GroupBox Tickets;
    }
}