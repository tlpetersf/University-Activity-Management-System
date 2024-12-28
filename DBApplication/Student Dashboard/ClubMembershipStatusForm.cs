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
    public partial class ClubMembershipStatusForm : Form
    {
        StudentController studentController=new  StudentController();
        int userid ;

        public ClubMembershipStatusForm(Form parentForm, int uid)
        {
            userid = uid;      
            InitializeComponent();
            Form ParentForm = parentForm;
            ParentForm.Hide();
            this.FormClosed += (sender, e) => { ParentForm.Show(); };
            dgvClubMemberships.DataSource = studentController.GetMemberships(userid);
        }

        private void btnLeaveClub_Click(object sender, EventArgs e)
        {
            int memId = Convert.ToInt32(tbMemId.Text);
            try
            {
                bool success = studentController.LeaveClub(memId, userid);
                if (success)
                {
                    MessageBox.Show("Successfully Leaved the club!",
                                  "Success",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                    dgvClubMemberships.DataSource = studentController.GetMemberships(userid);

                }
                else
                {
                    MessageBox.Show("Membership ID Not Found!",
                                  "Operation failed",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Leaving Club: " + ex.Message);
            }
        }
    }
}
