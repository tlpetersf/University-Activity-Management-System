using System;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class ReportsForm : Form
    {
        // Initialize the ReportsController instance
        private ReportsController controller;

        public ReportsForm(Form parentForm)
        {
            InitializeComponent();
            controller = new ReportsController();
            Form ParentForm = parentForm;
            ParentForm.Hide();
            this.FormClosed += (sender, e) => { ParentForm.Show(); };
            DataTable data = null;
            data = controller.GetEventsAttendedByEachUser();
            dataGridViewEventsAttended.DataSource = data;
            dataGridViewEventsAttended.Visible = true;
            labelEventsAttended.Visible = true;
            comboBoxReports.SelectedIndex = 0; 
            comboBoxReports.SelectedIndexChanged += ComboBoxReports_SelectedIndexChanged;
        }

        // Event handler for ComboBox selection change
        private void ComboBoxReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hide all DataGrids and Labels first
            dataGridViewEventsAttended.Visible = false;
            dataGridViewClubMemberships.Visible = false;
            dataGridViewTotalUsers.Visible = false;
            dataGridViewMemberStatus.Visible = false;
            dataGridViewEventStats.Visible = false;

            labelEventsAttended.Visible = false;
            labelClubMemberships.Visible = false;
            labelTotalUsers.Visible = false;
            labelMemberStatus.Visible = false;
            labelEventStats.Visible = false;

            // Get selected report from ComboBox
            string selectedReport = comboBoxReports.SelectedItem.ToString();

            // Call the appropriate method based on the selected report and populate the DataGridView
            DataTable data = null;

            switch (selectedReport)
            {
                case "Number of Events Attended by Each User":
                    data = controller.GetEventsAttendedByEachUser();
                    dataGridViewEventsAttended.DataSource = data;
                    dataGridViewEventsAttended.Visible = true;
                    labelEventsAttended.Visible = true;
                    break;
                case "Number of Club Memberships for Each User":
                    data = controller.GetClubMembershipsForEachUser();
                    dataGridViewClubMemberships.DataSource = data;
                    dataGridViewClubMemberships.Visible = true;
                    labelClubMemberships.Visible = true;
                    break;
                case "Total Users, Events, and Clubs":
                    data = controller.GetTotalUsersEventsAndClubs();
                    dataGridViewTotalUsers.DataSource = data;
                    dataGridViewTotalUsers.Visible = true;
                    labelTotalUsers.Visible = true;
                    break;
                case "Total Active, Rejected, and Pending Members in Clubs":
                    data = controller.GetMemberStatusInClubs();
                    dataGridViewMemberStatus.DataSource = data;
                    dataGridViewMemberStatus.Visible = true;
                    labelMemberStatus.Visible = true;
                    break;
                case "Average, Minimum, and Maximum Number of Events Attended by Users":
                    data = controller.GetEventStats();
                    dataGridViewEventStats.DataSource = data;
                    dataGridViewEventStats.Visible = true;
                    labelEventStats.Visible = true;
                    break;
            }
        }
    }
}
