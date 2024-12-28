using System;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class GiveFeedbackForm : Form
    {
        StudentController studentController = new StudentController();
        int userid ;


        public GiveFeedbackForm(Form parentForm,int uid)
        {
            userid = uid;
            InitializeComponent();

            Form ParentForm = parentForm;
            ParentForm.Hide();
            this.FormClosed += (sender, e) => { ParentForm.Show(); };

            cboEventSelection.DataSource = studentController.LoadAttendedEvents(userid);
            cboEventSelection.DisplayMember = "Title";
            cboEventSelection.ValueMember = "EventID";
        }

        private void btnSubmitFeedback_Click(object sender, EventArgs e)
        {
           
            // Validate the comments (must be empty or at least 10 characters)
            if (string.IsNullOrWhiteSpace(txtComments.Text))
            {
                MessageBox.Show("Please enter your comments.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtComments.Text.Length < 10)
            {
                MessageBox.Show("Comments should be at least 10 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Submit feedback if all validations are passed
            studentController.ProvideFeedback(userid, (int)cboEventSelection.SelectedValue, (int)numRating.Value, txtComments.Text);
            MessageBox.Show("Feedback submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
