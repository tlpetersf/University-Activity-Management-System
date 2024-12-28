using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class AvailableClubsForm : Form
    {
        StudentController studentController  = new StudentController();
        int userid ;
        public AvailableClubsForm(Form parentForm,int uid)
        {
            userid = uid;
            InitializeComponent();
            Form ParentForm = parentForm;
            ParentForm.Hide();
            this.FormClosed += (sender, e) => { ParentForm.Show(); };
            dgvClubsList.DataSource = studentController.GetAllClubs();
        }

        private void btnJoinClub_Click(object sender, EventArgs e)
        {
            int userid = 1;
            int clubid = Convert.ToInt32(tbClubID.Text);
            try
            {
                bool success = studentController.JoinClub(userid, clubid);
                if (success)
                {
                    MessageBox.Show("Successfully registered for the club!",
                                  "Success",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("You are already registered for this club!",
                                  "Registration Failed",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error registering for club: " + ex.Message);
            }
        }

       
    }
}
