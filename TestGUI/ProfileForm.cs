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
    public partial class ProfileForm : Form
    {
        User user = new User();
        public ProfileForm(User user)
        {
            InitializeComponent();

            this.user = user;

            FillControls();
        }

        private void FillControls()
        {
            UserProfile userProfile = user.Profile;

            lblName.Text = $"{userProfile.FirstName} {userProfile.LastName}";
            lblOccupation.Text = $"{userProfile.Occupation}";
            lblBirthDate.Text = $"{userProfile.Birthday.ToString("yyyy-MM-dd")}";
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
