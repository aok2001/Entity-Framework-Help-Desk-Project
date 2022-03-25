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
            User user = (User)lstAdmins.SelectedItem;

            ProfileForm profileForm = new ProfileForm(user);
            this.Hide();
            profileForm.ShowDialog();
            this.Show();
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            InboxForm inboxForm = new InboxForm();
            inboxForm.ShowDialog();
        }

        private void btnTicketHistory_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            historyForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
