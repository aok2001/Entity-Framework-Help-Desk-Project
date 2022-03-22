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
    public partial class StandardForm : Form
    {
        public StandardForm()
        {
            InitializeComponent();
            LoadAdmins();
        }

        private void LoadAdmins()
        {
            List<Admin> admins = BusinessLayer.GetAdminList();

            lstAdmins.DataSource = admins;
            lstAdmins.DisplayMember = "Username";
            lstAdmins.ValueMember = "Username";
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            StandardUserForms.SubmitTicketForm form = new StandardUserForms.SubmitTicketForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                form.ShowDialog();
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }

        private void StandardForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            //Admin receiver = (Admin)lstAdmins.SelectedItem;

            //MessageForm messageForm = new MessageForm(receiver);
            //messageForm.ShowDialog();
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            InboxForm inboxForm = new InboxForm();
            inboxForm.ShowDialog();
        }
    }
}
