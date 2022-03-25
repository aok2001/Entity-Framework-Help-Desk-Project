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
//using System

namespace TestGUI.StandardUserForms
{
    public partial class SubmitTicketForm : Form
    {
        public SubmitTicketForm()
        {
            InitializeComponent();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            //List<string> SystemInfo = new List<string>()
            //{
            //    $"Operating System: {Environment.OSVersion}",
            //    $"PC Name: {Environment.MachineName}",
            //    $"CPU Count: {Environment.ProcessorCount}",
            //    $"Logical Drives: {Environment.GetLogicalDrives()}",
            //    $".NET Version: {Environment.Version}",
            //    $"Domain: {Environment.UserDomainName}",
            //    $"Windows Username: {Environment.UserName}"
            //};



            Ticket ticket = new Ticket()
            {
                Category = cbCategory.Text,
                Description = txtDesc.Text,
                Status = "Pending",
                TicketSenderUsername = BusinessLayer.LoggedInUser.Username,
                SystemInfo = new SystemInfo()
                {
                    OS = Environment.OSVersion.ToString(),
                    MachineName = Environment.MachineName.ToString(),
                    CoreCount = Environment.ProcessorCount.ToString(),
                    LogicalDrives = Environment.GetLogicalDrives().Length.ToString(),
                    DotNetVersion = Environment.Version.ToString(),
                    DomainName = Environment.UserDomainName.ToString(),
                    UserName = Environment.UserName.ToString()
                }
            };

            BusinessLayer.SubmitTicket(ticket);
            MessageBox.Show("Ticket successfully created");
        }
    }
}
