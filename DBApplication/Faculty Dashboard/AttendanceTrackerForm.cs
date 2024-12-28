using System;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class AttendanceTrackerForm : Form
    {
        private FacultyMemberControler facultyController = new FacultyMemberControler();
        private Controller c = new Controller();
        Form prevForm;
        int UserID;
        string userType;

        public AttendanceTrackerForm(Form pf, int id)
        {
            UserID = id;
            prevForm = pf;
            InitializeComponent();

            this.FormClosed += (s, e) => prevForm.Show();

            btnExport.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;

            facultyController = new FacultyMemberControler();

            // Set data source for combo box
            cbEventFilter.DataSource = facultyController.GetEventData(UserID, c.GetType(UserID));
            cbEventFilter.DisplayMember = "Title";
            cbEventFilter.ValueMember = "EventID";

            // Set data source for DataGridView if an event is selected
            if (cbEventFilter.SelectedValue != null)
            {
                DataTable Attendance = facultyController.TrackAttendance((int)cbEventFilter.SelectedValue);
                dgvEventDetails.DataSource = Attendance;
            }

            // Handle visibility based on user type
            if (c.GetType(UserID) == "Admin")
            {
                userType = "Admin";
                btnExport.Visible = true;
                label2.Visible = true;
                textBox1.Visible = true;
            }
            else if (c.GetType(UserID) == "Faculty Member")
            {
                userType = "Faculty Member";
            }
            else if (userType == "Student")
            {
                userType = "Student";
            }
        }

        private void dgvEventDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Handle cell clicks if needed
        }

        private void cbEventFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ensure the SelectedValue is valid
            if (cbEventFilter.SelectedValue != null)
            {
                // Get the DataRowView from the selected value
                DataRowView selectedRow = (DataRowView)cbEventFilter.SelectedItem;

                // Ensure that the value you want (EventID) exists in the selected row
                if (selectedRow != null)
                {
                    int eventId = Convert.ToInt32(selectedRow["EventID"]);  // Access EventID directly from DataRowView
                    DataTable Attendance = facultyController.TrackAttendance(eventId);

                    // Check if TrackAttendance returned a valid DataTable
                    if (Attendance != null)
                    {
                        dgvEventDetails.DataSource = Attendance;
                    }
                    else
                    {
                        MessageBox.Show("No attendance data found for the selected event.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an event.");
            }
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            int studentId;
            if (int.TryParse(textBox1.Text.Trim(), out studentId))
            {
                bool studentExistsInGrid = false;

                // Check if the student ID exists in the DataGridView
                foreach (DataGridViewRow row in dgvEventDetails.Rows)
                {
                    if (row.Cells["AttendanceID"].Value != null &&
                        Convert.ToInt32(row.Cells["AttendanceID"].Value) == studentId)
                    {
                        studentExistsInGrid = true; // Matching StudentID found
                        break;
                    }
                }

                if (studentExistsInGrid)
                {
                    // Get the event ID based on the selected event
                    int eventId = facultyController.GetEventIDByName(Convert.ToInt16(cbEventFilter.SelectedValue));

                    // Call the method to delete the attendance
                    bool isDeleted = facultyController.DeleteAttendance(studentId);
                    if (isDeleted)
                    {
                        MessageBox.Show("Student attendance deleted successfully.");

                        // Reload the data for the selected event
                        if (cbEventFilter.SelectedValue != null && int.TryParse(cbEventFilter.SelectedValue.ToString(), out int selectedEventId))
                        {
                            // Fetch updated attendance details after deletion
                            DataTable updatedAttendance = facultyController.TrackAttendance(selectedEventId);

                            // Check if the event still has attendance records and update DataGridView
                            if (updatedAttendance.Rows.Count > 0)
                            {
                                dgvEventDetails.DataSource = updatedAttendance;
                            }
                            else
                            {
                                dgvEventDetails.DataSource = null;
                                MessageBox.Show("No attendance records found for this event.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete student attendance.");
                    }
                }
                else
                {
                    MessageBox.Show("Student ID not found in the current list.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Student ID.");
            }
        }


        private void AttendanceTrackerForm_Load(object sender, EventArgs e)
        {
            // Optional: Perform additional initialization when the form loads
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Optional: Handle label click event if needed
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Optional: Handle text changes in the response textbox if needed
        }
    }
}
