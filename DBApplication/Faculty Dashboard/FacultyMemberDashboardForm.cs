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
    public partial class FacultyMemberDashboardForm : Form
    {
        int UserID;
        FacultyMemberControler memberControler = new FacultyMemberControler();
        public FacultyMemberDashboardForm(int userID)
        {
            InitializeComponent();
            Login Log = new Login();
            this.FormClosed += (s, e) => Log.Show();
            UserID = userID;
            label1.Text = memberControler.PendingCount(UserID).ToString();
            label2.Text = memberControler.GetUpcomingEventCount(UserID).ToString();
            label3.Text = memberControler.GetTotalEventCount(UserID).ToString();

        }

        private void FacultyDashboardForm_Load(object sender, EventArgs e)
        {
            // Placeholder for any actions, currently no actions are implemented.
        }

        private void btnViewFeedbackAttendance_Click(object sender, EventArgs e)
        {
            AttendanceTrackerForm attendanceTrackerForm = new AttendanceTrackerForm(this,UserID);
            attendanceTrackerForm.Show();
        }

        private void btnCreateNewEvent_Click(object sender, EventArgs e)
        {
         
            CreateEventForm createEventForm = new CreateEventForm(this, UserID);
            createEventForm.Show();
        }

        private void btnManageEvents_Click(object sender, EventArgs e)
        {
            ManageEventsForm manageEventForm = new ManageEventsForm(this, UserID);
            manageEventForm.Show();

        }

        private void ViewFeedback_Click(object sender, EventArgs e)
        {
            FacultyViewFeedback viewEventFeedbackForm = new FacultyViewFeedback(this,UserID);
            viewEventFeedbackForm.Show();
        }

        private void btnApproveMembershipRequests_Click(object sender, EventArgs e)
        {
            ManageMembershipRequestsForm manageMembershipRequestsForm = new ManageMembershipRequestsForm(this,UserID);
            manageMembershipRequestsForm.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Taking_Attendance taking_Attendance = new Taking_Attendance(this,UserID);
          taking_Attendance.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userprofile profile = new userprofile(UserID, this);
            profile.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            changepassword cpass = new changepassword(UserID, this);
            cpass.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            label1.Text = memberControler.PendingCount(UserID).ToString();
            label2.Text = memberControler.GetUpcomingEventCount(UserID).ToString();
            label3.Text = memberControler.GetTotalEventCount(UserID).ToString();
        }

        private void FacultyMemberDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
