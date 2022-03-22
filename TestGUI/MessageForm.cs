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
    public partial class MessageForm : Form
    {
        //User sender = new User();
        User receiver = new User();
        public MessageForm(User receiver)
        {
            InitializeComponent();

            //this.sender = sender;
            this.receiver = receiver;
            lblReceiver.Text = $"Sending to: {receiver.Username}";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //HelpDeskClassLibrary.Message message = new HelpDeskClassLibrary.Message()
            //{
            //    Sender = BusinessLayer.LoggedInUser,
            //    Receiver = 
            //}

            bool success = BusinessLayer.SendMessage(BusinessLayer.LoggedInUser, receiver, txtMessage.Text);

            if (success)
            {
                MessageBox.Show("Message sent");
            }
            else
            {
                MessageBox.Show("Error sending Message");
            }

            this.Close();
        }
    }
}
