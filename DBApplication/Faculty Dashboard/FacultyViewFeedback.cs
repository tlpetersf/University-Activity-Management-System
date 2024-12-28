using System;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class FacultyViewFeedback : Form
    {
        private FacultyMemberControler facultyController = new FacultyMemberControler();
        private Controller c = new Controller();
        private int userId;
        private string UserType;
        private Form prevForm;

        public FacultyViewFeedback(Form pf, int uid)
        {
            userId = uid;
            prevForm = pf;
            InitializeComponent();

            // Ensure previous form is shown when this form is closed
            this.FormClosed += (s, e) => prevForm.Show();

            // Set default visibility of admin-specific controls
            btnExportFeedback.Visible = false;
            label1.Visible = false;
            txtResponse.Visible = false;

            // Determine user type
            UserType = c.GetType(userId);
            if (UserType == "Admin")
            {
                btnExportFeedback.Visible = true;
                label1.Visible = true;
                txtResponse.Visible = true;
            }

            // Populate combo box with event data
            cbEventFilter.DataSource = facultyController.GetEventData(userId, UserType);
            cbEventFilter.DisplayMember = "Title";
            cbEventFilter.ValueMember = "EventID";

            // Set up combo box event handler
            cbEventFilter.SelectedIndexChanged += cbEventFilter_SelectedIndexChanged;

            // Trigger default event selection if items exist
            if (cbEventFilter.Items.Count > 0)
            {
                cbEventFilter.SelectedIndex = 0; // Trigger population of DataGridView
            }
            dgvFeedback.DataSource = facultyController.GetFeedBacks(Convert.ToInt16(cbEventFilter.SelectedValue));
            dgvFeedback.Refresh(); 

        }

        private void cbEventFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Populate DataGridView when a new event is selected
            if (cbEventFilter.SelectedValue != null && int.TryParse(cbEventFilter.SelectedValue.ToString(), out int eventId))
            {
                // Avoid executing another query while iterating over the previous query's results
                dgvFeedback.DataSource = facultyController.GetFeedBacks(eventId); // Ensure GetFeedBacks handles DataReader properly
            }
        }


        private void btnExportFeedback_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtResponse.Text))
            {
                MessageBox.Show("Please enter a Feedback ID.");
                return;
            }

            if (int.TryParse(txtResponse.Text.Trim(), out int feedbackId))
            {
                // Check if the FeedbackID exists in the current DataGridView
                bool feedbackExistsInGrid = false;
                foreach (DataGridViewRow row in dgvFeedback.Rows)
                {
                    if (row.Cells["FeedbackID"].Value != null &&
                        int.TryParse(row.Cells["FeedbackID"].Value.ToString(), out int gridFeedbackId) &&
                        gridFeedbackId == feedbackId)
                    {
                        feedbackExistsInGrid = true;
                        break;
                    }
                }

                if (!feedbackExistsInGrid)
                {
                    MessageBox.Show("Feedback ID not found in the current list.");
                    return;
                }

                // Delete the feedback and refresh the DataGridView
                bool isDeleted = facultyController.DeleteFeedback(feedbackId);
                if (isDeleted)
                {
                    MessageBox.Show("Feedback deleted successfully.");
                    if (cbEventFilter.SelectedValue != null && int.TryParse(cbEventFilter.SelectedValue.ToString(), out int eventId))
                    {
                        dgvFeedback.DataSource = facultyController.GetFeedBacks(eventId);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to delete feedback.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric Feedback ID.");
            }
        }

        private void FacultyViewFeedback_Load(object sender, EventArgs e)
        {
            // Optional: Perform additional initialization when the form loads
        }

        private void dgvFeedback_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Handle cell clicks if additional actions are needed
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Optional: Handle label click event if needed
        }

        private void txtResponse_TextChanged(object sender, EventArgs e)
        {
            // Optional: Handle text changes in the response textbox if needed
        }
    }
}
