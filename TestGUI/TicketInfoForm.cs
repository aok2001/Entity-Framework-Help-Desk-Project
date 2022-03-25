using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HelpDeskClassLibrary;

namespace TestGUI
{
    public partial class TicketInfoForm : Form
    {
        Ticket ticket = null;
        public TicketInfoForm(Ticket ticket)
        {
            InitializeComponent();

            this.ticket = ticket;
            FillControls();
        }

        private void FillControls()
        {
            Ticket ticket_with_info = BusinessLayer.GetTicketWithSystemInfo(ticket);
            SystemInfo systemInfo = ticket_with_info.SystemInfo;

            lblUser.Text = ticket_with_info.TicketSenderUsername;

            txtCategory.Text = ticket_with_info.Category;
            txtDesc.Text = ticket_with_info.Description;

            label1.Text = systemInfo.OS;
            label2.Text = systemInfo.MachineName;
            label3.Text = systemInfo.CoreCount;
            label4.Text = systemInfo.LogicalDrives;
            label5.Text = systemInfo.DotNetVersion;
            label6.Text = systemInfo.DomainName;
            label7.Text = systemInfo.UserName;

        }

        private void TicketInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
