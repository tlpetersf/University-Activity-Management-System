using System;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class ClubDetailsForm : Form
    {
        int ClubID;
        ControllerAdmin controller = new ControllerAdmin();
        public ClubDetailsForm(Form parentForm, int id)
        {
            InitializeComponent();
            ClubID = id;

            Form ParentForm = parentForm;
            ParentForm.Hide();
            this.FormClosed += (sender, e) => { ParentForm.Show(); };
            LoadClubDetails();
        }


       

        private void LoadClubDetails()
        {
            DataTable clubDetails = controller.GetClubDetails(ClubID);
            if (clubDetails.Rows.Count > 0)
            {
                DataRow row = clubDetails.Rows[0];
                txtClubName.Text = row["Name"].ToString();
                txtClubDescription.Text = row["Description"].ToString();

                int totalMembers = controller.GetTotalMembers(ClubID);
                txtTotalMembers.Text = totalMembers.ToString();

                DataTable clubMembers = controller.GetClubMembers(ClubID);
                dgvClubMembers.DataSource = clubMembers;
                dgvClubMembers.Columns["UserID"].Visible = false; 
                dgvClubMembers.AutoResizeColumns(); 
            }
            else
            {
                MessageBox.Show("Club details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btnEditClubDetails_Click(object sender, EventArgs e)
        {
            EditClubForm editClubForm = new EditClubForm(this, ClubID);
            editClubForm.Show();
            this.Hide();
        }

        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            
            {
                int memberID = Convert.ToInt32(textBox1.Text);

                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to remove this member?",
                    "Confirm Remove",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    bool success = controller.RemoveMemberFromClub(ClubID, memberID);
                    if (success)
                    {
                        MessageBox.Show("Member removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadClubDetails(); // Refresh the club details
                    }
                    else
                    {
                        MessageBox.Show("Error removing member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
       
    }
}