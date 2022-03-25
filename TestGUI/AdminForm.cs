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

            lstPending.DataSource = tickets;
            lstPending.DisplayMember = "Description";
            lstPending.ValueMember = "Id";
        }

        private void FillAcceptedTickets()
        {
            List<Ticket> tickets = BusinessLayer.GetActiveTicketsList(BusinessLayer.LoggedInUser);

            lstActive.DataSource = tickets;
            lstActive.DisplayMember = "Description";
            lstActive.ValueMember = "Id";
        }

        private void FillClosedTickets()
        {
            List<Ticket> tickets = BusinessLayer.GetClosedTicketsList(BusinessLayer.LoggedInUser);

            lstClosed.DataSource = tickets;
            lstClosed.DisplayMember = "Description";
            lstClosed.ValueMember = "Id";
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
            Ticket ticket = (Ticket)lstPending.SelectedItem;

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
            Ticket ticket = (Ticket)lstClosed.SelectedItem;

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
            Ticket ticket = (Ticket)lstActive.SelectedItem;

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

        private void btnProfile_Click(object sender, EventArgs e)
        {
            User user = (User)lstUsers.SelectedItem;

            ProfileForm profileForm = new ProfileForm(user);
            this.Hide();
            profileForm.ShowDialog();
            this.Show();
        }

        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
            TicketInfoForm ticketInfoForm = new TicketInfoForm((Ticket)lstPending.SelectedItem);
            ticketInfoForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TicketInfoForm ticketInfoForm = new TicketInfoForm((Ticket)lstActive.SelectedItem);
            ticketInfoForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TicketInfoForm ticketInfoForm = new TicketInfoForm((Ticket)lstClosed.SelectedItem);
            ticketInfoForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
