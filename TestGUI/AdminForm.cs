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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();

            FillPendingTickets();
            FillAcceptedTickets();
            FillClosedTickets();
            FillUsers();
        }

        private void FillPendingTickets()
        {
            List<Ticket> tickets = BusinessLayer.GetTicketList();

            listBox1.DataSource = tickets;
            listBox1.DisplayMember = "Description";
            listBox1.ValueMember = "Id";
        }

        private void FillAcceptedTickets()
        {
            List<Ticket> tickets = BusinessLayer.GetActiveTicketsList(BusinessLayer.LoggedInUser);

            listBox2.DataSource = tickets;
            listBox2.DisplayMember = "Description";
            listBox2.ValueMember = "Id";
        }

        private void FillClosedTickets()
        {
            List<Ticket> tickets = BusinessLayer.GetClosedTicketsList(BusinessLayer.LoggedInUser);

            listBox3.DataSource = tickets;
            listBox3.DisplayMember = "Description";
            listBox3.ValueMember = "Id";
        }

        private void FillUsers()
        {
            List<User> users = BusinessLayer.GetUserList(BusinessLayer.LoggedInUser);

            lstUsers.DataSource = users;
            lstUsers.DisplayMember = "Username";
            lstUsers.ValueMember = "Username";
        }

        #region "Tickets"

        private void btnAcceptTicket_Click(object sender, EventArgs e)
        {
            Ticket ticket = (Ticket)listBox1.SelectedItem;

            bool success = BusinessLayer.AcceptTicket(ticket, BusinessLayer.LoggedInUser);

            if (success)
            {
                MessageBox.Show("Ticket accepted");
                this.Refresh();
            }
            else
            {
                MessageBox.Show("Error accepting ticket");
            }
        }

        private void btnReopen_Click(object sender, EventArgs e)
        {
            Ticket ticket = (Ticket)listBox3.SelectedItem;

            bool success = BusinessLayer.ReopenTicket(ticket, BusinessLayer.LoggedInUser);

            if (success)
            {
                MessageBox.Show("Ticket now active");
                this.Refresh();
            }
            else
            {
                MessageBox.Show("Error activating ticket");
            }
        }

        private void btnCloseTicket_Click(object sender, EventArgs e)
        {
            Ticket ticket = (Ticket)listBox2.SelectedItem;

            bool success = BusinessLayer.CloseTicket(ticket, BusinessLayer.LoggedInUser);

            if (success)
            {
                MessageBox.Show("Ticket closed");
                this.Refresh();
            }
            else
            {
                MessageBox.Show("Error closing ticket");
            }
        }

        #endregion
               

        private void btnMessage_Click(object sender, EventArgs e)
        {
            InboxForm inboxForm = new InboxForm();
            inboxForm.ShowDialog();
        }
    }
}
