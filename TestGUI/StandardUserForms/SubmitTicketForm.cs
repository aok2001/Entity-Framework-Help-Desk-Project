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
            if (txtDesc.Text != "" || cbCategory.SelectedIndex != null)
            {
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
            else
            {
                MessageBox.Show("Must fill out al fields");
            }
            
        }
    }
}
