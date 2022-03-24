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
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();

            GetTickets();
        }

        private void GetTickets()
        {
            List<Ticket> tickets = BusinessLayer.GetUserTickets(BusinessLayer.LoggedInUser);

            string text = "";

            foreach (Ticket ticket in tickets)
            {
                switch (ticket.Status)
                {
                    case "Pending":
                        text = $"Category: {ticket.Category}, Description: {ticket.Description}, Admin: N/A, Status: {ticket.Status}";
                        break;

                    case "Active":
                        text = $"Category: {ticket.Category}, Description: {ticket.Description}, Admin: {ticket.AssignedAdminUsername}, Status: {ticket.Status}";
                        break;

                    case "Closed":
                        text = $"Category: {ticket.Category}, Description: {ticket.Description}, Admin: {ticket.AssignedAdminUsername}, Status: {ticket.Status}";
                        break;
                }

                lstTickets.Items.Add(text);
            }            
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
