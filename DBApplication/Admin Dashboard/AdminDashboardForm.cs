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
    public partial class AdminDashboardForm : Form
    {
        ControllerAdmin controller = new ControllerAdmin();
        int UserID;
        public AdminDashboardForm(int userID)
        {
            InitializeComponent();
            UserID = userID;
            Login Log = new Login();
            this.FormClosed += (s, e) => Log.Show();
            lblTotalUsers.Text = controller.GetTotalUsers();
            lblTotalAdmins.Text = controller.GetTotalAdmins();
            lblTotalFaculty.Text = controller.GetTotalFacultyMembers();
            lblTotalStudents.Text = controller.GetTotalStudents();
            lblTotalClubs.Text = controller.GetTotalClubs();
            lblTotalEvents.Text = controller.GetTotalEvents();
            lblTotalLocations.Text = controller.GetTotalLocations();
        }

        private void pnlQuickStats_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateAdminForm NewAdmin = new CreateAdminForm(this,UserID);
            NewAdmin.Show();
            this.Hide();
        }

        private void buttViewUsers_Click(object sender, EventArgs e)
        {
            ViewUsersForm AllUsers = new ViewUsersForm(this,UserID);
            AllUsers.Show();
            this.Hide();
        }

        private void buttNewEvent_Click(object sender, EventArgs e)
        {
            CreateEventForm NewEvent = new CreateEventForm(this,UserID);
            NewEvent.Show();
            this.Hide();
        }

        private void buttManageEvent_Click(object sender, EventArgs e)
        {
            ManageEventsForm ManageEvents = new ManageEventsForm(this,UserID);
            ManageEvents.Show();
            this.Hide();
        }

        private void buttNewClub_Click(object sender, EventArgs e)
        {
            CreateClubForm NewClub = new CreateClubForm(this,UserID);
            NewClub.Show();
            this.Hide();
        }

        private void buttManageMembership_Click(object sender, EventArgs e)
        {
            ManageClubsForm ManageClubs = new ManageClubsForm(this, UserID);
            ManageClubs.Show();
            this.Hide();
        }

        private void buttAddLoc_Click(object sender, EventArgs e)
        {
            AddLocationForm NewLoc = new AddLocationForm(this, UserID);
            NewLoc.Show();
            this.Hide();
        }

        private void buttManageLoc_Click(object sender, EventArgs e)
        {
            ManageLocationsForm ManageLoc = new ManageLocationsForm(this, UserID);
            ManageLoc.Show();
            this.Hide();
        }

        private void lblTotalUsers_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalAdmins_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblTotalUsers.Text = controller.GetTotalUsers();
            lblTotalAdmins.Text = controller.GetTotalAdmins();
            lblTotalFaculty.Text = controller.GetTotalFacultyMembers();
            lblTotalStudents.Text = controller.GetTotalStudents();
            lblTotalClubs.Text = controller.GetTotalClubs();
            lblTotalEvents.Text = controller.GetTotalEvents();
            lblTotalLocations.Text = controller.GetTotalLocations();
        }

        private void ButtLogout_Click(object sender, EventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FacultyViewFeedback FviewFeedback = new FacultyViewFeedback(this, UserID);
            FviewFeedback.Show();
            this.Hide();
        }

        private void buttGenerateReports_Click(object sender, EventArgs e)
        {
            Taking_Attendance AddAtt = new Taking_Attendance(this, UserID);
            AddAtt.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AttendanceTrackerForm TrackAtt = new AttendanceTrackerForm(this, UserID);
            TrackAtt.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportsForm reports = new ReportsForm(this);
            reports.Show();
        }
    }
}
