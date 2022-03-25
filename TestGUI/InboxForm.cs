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
    public partial class InboxForm : Form
    {
        //User current_user = new User();
        User selected_user = new User();

        public InboxForm()
        {
            InitializeComponent();
            //this.current_user = current_user;

            FillUsers();
            //FillMessages();
            
        }

        private void FillUsers()
        {

            if (BusinessLayer.LoggedInUser.AccountType == 0) //standard
            {
                List<Admin> admins = BusinessLayer.GetAdminList();

                lstUsers.DataSource = admins;
                lstUsers.DisplayMember = "Username";
                lstUsers.ValueMember = "Username";
            }
            else if (BusinessLayer.LoggedInUser.AccountType == 1)
            {
                List<User> users = BusinessLayer.GetUserList(BusinessLayer.LoggedInUser);

                lstUsers.DataSource = users;
                lstUsers.DisplayMember = "Username";
                lstUsers.ValueMember = "Username";
            }
        }

        private void FillMessages(User user)
        {
            lstMessages.Items.Clear();

            List<HelpDeskClassLibrary.Message> messages = BusinessLayer.GetMessagesList(BusinessLayer.LoggedInUser, user);

            foreach (HelpDeskClassLibrary.Message message in messages)
            {
                lstMessages.Items.Add($"{message.SenderUsername}: {message.MessageText} {message.SentDate.ToString()}");
            }
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {            
            selected_user = (User)lstUsers.SelectedItem;
            FillMessages(selected_user);
            this.Refresh();
        }

        private void btnReply_Click(object sender, EventArgs e)
        {           

            MessageForm messageForm = new MessageForm(selected_user);
            messageForm.ShowDialog();
            FillMessages(selected_user);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
