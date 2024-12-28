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
    public partial class ManageMembershipRequestsForm : Form
    {
        private FacultyMemberControler facultyController= new FacultyMemberControler();
        private Controller c = new Controller();
        int UserID;
        public ManageMembershipRequestsForm(Form parentForm, int id)
        {
            InitializeComponent();

            // Store the parent form
            Form ParentForm = parentForm;
            UserID = id;
            // Hide the parent form when the sub-form opens
            ParentForm.Hide();

            // Add event handler to show the parent form when the sub-form is closed
            this.FormClosed += (sender, e) => { ParentForm.Show(); };
            if (c.GetType(UserID) == "Admin")
            {
                dgvEvents.DataSource = facultyController.GetPendingMemberships();
            }
            else if (c.GetType(UserID) == "Faculty Member")
            {
                dgvEvents.DataSource = facultyController.GetPendingMembershipsSupervised(UserID);
            }
        }

        private void txtEventID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttRejectReq_Click(object sender, EventArgs e)
        {
            FacultyMemberControler controller = new FacultyMemberControler();

            // Get the MembershipID from the text box
            int membershipId;
            if (int.TryParse(txtEventID.Text, out membershipId))  // Ensure it's a valid integer
            {
                // Call the AcceptMembership function
                bool isSuccess = controller.RejectMembership(membershipId);

                if (isSuccess)
                {
                    MessageBox.Show("Membership status updated to Rejected.");

                    // Refresh the DataGridView to show the updated pending list
                    if (c.GetType(UserID) == "Admin")
                    {
                        dgvEvents.DataSource = facultyController.GetPendingMemberships();
                    }
                    else if (c.GetType(UserID) == "Faculty Member")
                    {
                        dgvEvents.DataSource = facultyController.GetPendingMembershipsSupervised(UserID);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to update membership status. Please check the Membership ID.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Membership ID.");
            }
        }

        private void buttAcceptReq_Click(object sender, EventArgs e)
        {
            FacultyMemberControler controller = new FacultyMemberControler();

            // Get the MembershipID from the text box
            int membershipId;
            if (int.TryParse(txtEventID.Text, out membershipId))  // Ensure it's a valid integer
            {
                // Call the AcceptMembership function
                bool isSuccess = controller.AcceptMembership(membershipId);

                if (isSuccess)
                {
                    MessageBox.Show("Membership status updated to Accepted.");

                    // Refresh the DataGridView to show the updated pending list
                    if (c.GetType(UserID) == "Admin")
                    {
                        dgvEvents.DataSource = facultyController.GetPendingMemberships();
                    }
                    else if (c.GetType(UserID) == "Faculty Member")
                    {
                        dgvEvents.DataSource = facultyController.GetPendingMembershipsSupervised(UserID);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to update membership status. Please check the Membership ID.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Membership ID.");
            }
        }

        private void dgvEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageMembershipRequestsForm_Load(object sender, EventArgs e)
        {

        }
    }
}