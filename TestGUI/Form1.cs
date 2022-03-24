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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Height = 210;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (cbType.Text == "Standard")
            {
                User u = new User()
                {
                    AccountType = 0,
                    DateJoined = DateTime.Now,
                    Password = txtPassword.Text,
                    Username = txtUsername.Text,
                    Profile = new UserProfile()
                    {
                        Birthday = dtBirthdate.Value,
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Occupation = txtOccupation.Text
                    }
                };

                BusinessLayer.Register(u);
                MessageBox.Show("Account was created successfully.");
            }
            else if (cbType.Text == "Admin")
            {
                Admin u = new Admin()
                {
                    AccountType = 1,
                    DateJoined = DateTime.Now,
                    Password = txtPassword.Text,
                    Username = txtUsername.Text,
                    Profile = new UserProfile()
                    {
                        Birthday = dtBirthdate.Value,
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Occupation = txtOccupation.Text
                    }
                };

                BusinessLayer.Register(u);
                MessageBox.Show("Account was created successfully.");
            }
            else
            {
                MessageBox.Show("Invalid account type selected.");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool success = BusinessLayer.Login(txtLU.Text, txtLP.Text);

            if (success)
            {
                User tmp = BusinessLayer.GetUser(txtLU.Text, txtLP.Text);

                switch (tmp.AccountType)
                {
                    case 0:
                        StandardForm standardForm = new StandardForm();
                        this.Hide();


                        if (standardForm.ShowDialog() == DialogResult.OK)
                        {
                            standardForm.ShowDialog();
                        }
                        else
                        {
                            this.Show();
                        }
                        break;
                    case 1:
                        AdminForm adminForm = new AdminForm();
                        this.Hide();

                        if (adminForm.ShowDialog() == DialogResult.OK)
                        {
                            adminForm.ShowDialog();
                        }
                        else
                        {
                            this.Show();
                        }
                        break;
                }                             
            }
            else
            {
                MessageBox.Show("Login failed.");
            }
        }

        private bool register_load = false;

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            if (register_load == false)
            {
                this.Height = 480;
                register_load = true;
            }
            else if (register_load == true)
            {
                this.Height = 210;
                register_load = false;
            }
            
        }
    }
}
