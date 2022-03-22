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
            Ticket ticket = new Ticket()
            {
                Category = cbCategory.Text,
                Description = txtDesc.Text,
                Status = "Pending",
                TicketSenderUsername = BusinessLayer.LoggedInUser.Username
            };

            BusinessLayer.SubmitTicket(ticket);
            MessageBox.Show("Ticket successfully created");
        }
    }
}
