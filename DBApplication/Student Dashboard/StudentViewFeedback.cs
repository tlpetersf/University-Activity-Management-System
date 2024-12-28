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
    public partial class StudentViewFeedback : Form
    {
        StudentController studentController = new StudentController();
        int userid ;

        public StudentViewFeedback(Form parentForm,int uid)
        {
            userid = uid;
            Form ParentForm = parentForm;
            ParentForm.Hide();
            this.FormClosed += (sender, e) => { ParentForm.Show(); };
            InitializeComponent();
            dgvFeedbacks.DataSource = studentController.GetFeedbackByUserId(userid);
        }

        private void btnDeleteFeedback_Click(object sender, EventArgs e)
        {
            int feedId;
            if (int.TryParse(tbFeedbackID.Text, out feedId))
            {
                try
                {
                    bool success = studentController.DeleteFeedbackById(feedId, userid);
                    if (success)
                    {
                        MessageBox.Show("Successfully Deleted the Feedback!",
                                      "Success",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                        dgvFeedbacks.DataSource = studentController.GetFeedbackByUserId(userid);


                    }
                    else
                    {
                        MessageBox.Show("Feedback ID Not Found!",
                                      "Operation failed",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Deleting Feedback: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Feedback ID!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}