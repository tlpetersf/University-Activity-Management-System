using System;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class FacultyMemberDashboardForm : Form
    {
      

        private void InitializeComponent()
        {
            this.lblTotalEvents = new System.Windows.Forms.Label();
            this.lblUpcomingEvents = new System.Windows.Forms.Label();
            this.lblPendingMembershipRequests = new System.Windows.Forms.Label();
            this.grpEventManagement = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ViewFeedback = new System.Windows.Forms.Button();
            this.btnCreateNewEvent = new System.Windows.Forms.Button();
            this.btnManageEvents = new System.Windows.Forms.Button();
            this.btnViewFeedbackAttendance = new System.Windows.Forms.Button();
            this.grpClubManagement = new System.Windows.Forms.GroupBox();
            this.btnApproveMembershipRequests = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpEventManagement.SuspendLayout();
            this.grpClubManagement.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalEvents
            // 
            this.lblTotalEvents.AutoSize = true;
            this.lblTotalEvents.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalEvents.Location = new System.Drawing.Point(20, 20);
            this.lblTotalEvents.Name = "lblTotalEvents";
            this.lblTotalEvents.Size = new System.Drawing.Size(117, 19);
            this.lblTotalEvents.TabIndex = 0;
            this.lblTotalEvents.Text = "Total Events: ";
            // 
            // lblUpcomingEvents
            // 
            this.lblUpcomingEvents.AutoSize = true;
            this.lblUpcomingEvents.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblUpcomingEvents.Location = new System.Drawing.Point(20, 50);
            this.lblUpcomingEvents.Name = "lblUpcomingEvents";
            this.lblUpcomingEvents.Size = new System.Drawing.Size(158, 19);
            this.lblUpcomingEvents.TabIndex = 1;
            this.lblUpcomingEvents.Text = "Upcoming Events: ";
            // 
            // lblPendingMembershipRequests
            // 
            this.lblPendingMembershipRequests.AutoSize = true;
            this.lblPendingMembershipRequests.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblPendingMembershipRequests.Location = new System.Drawing.Point(20, 89);
            this.lblPendingMembershipRequests.Name = "lblPendingMembershipRequests";
            this.lblPendingMembershipRequests.Size = new System.Drawing.Size(304, 19);
            this.lblPendingMembershipRequests.TabIndex = 3;
            this.lblPendingMembershipRequests.Text = "Pending Club Membership Requests: ";
            // 
            // grpEventManagement
            // 
            this.grpEventManagement.Controls.Add(this.button1);
            this.grpEventManagement.Controls.Add(this.ViewFeedback);
            this.grpEventManagement.Controls.Add(this.btnCreateNewEvent);
            this.grpEventManagement.Controls.Add(this.btnManageEvents);
            this.grpEventManagement.Controls.Add(this.btnViewFeedbackAttendance);
            this.grpEventManagement.Location = new System.Drawing.Point(20, 172);
            this.grpEventManagement.Name = "grpEventManagement";
            this.grpEventManagement.Size = new System.Drawing.Size(254, 221);
            this.grpEventManagement.TabIndex = 5;
            this.grpEventManagement.TabStop = false;
            this.grpEventManagement.Text = "Event Management";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Take Attendance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewFeedback
            // 
            this.ViewFeedback.Location = new System.Drawing.Point(20, 185);
            this.ViewFeedback.Name = "ViewFeedback";
            this.ViewFeedback.Size = new System.Drawing.Size(200, 30);
            this.ViewFeedback.TabIndex = 3;
            this.ViewFeedback.Text = "View Feedback";
            this.ViewFeedback.UseVisualStyleBackColor = true;
            this.ViewFeedback.Click += new System.EventHandler(this.ViewFeedback_Click);
            // 
            // btnCreateNewEvent
            // 
            this.btnCreateNewEvent.Location = new System.Drawing.Point(20, 30);
            this.btnCreateNewEvent.Name = "btnCreateNewEvent";
            this.btnCreateNewEvent.Size = new System.Drawing.Size(200, 30);
            this.btnCreateNewEvent.TabIndex = 0;
            this.btnCreateNewEvent.Text = "Create New Event";
            this.btnCreateNewEvent.UseVisualStyleBackColor = true;
            this.btnCreateNewEvent.Click += new System.EventHandler(this.btnCreateNewEvent_Click);
            // 
            // btnManageEvents
            // 
            this.btnManageEvents.Location = new System.Drawing.Point(20, 70);
            this.btnManageEvents.Name = "btnManageEvents";
            this.btnManageEvents.Size = new System.Drawing.Size(200, 30);
            this.btnManageEvents.TabIndex = 1;
            this.btnManageEvents.Text = "Manage Events";
            this.btnManageEvents.UseVisualStyleBackColor = true;
            this.btnManageEvents.Click += new System.EventHandler(this.btnManageEvents_Click);
            // 
            // btnViewFeedbackAttendance
            // 
            this.btnViewFeedbackAttendance.Location = new System.Drawing.Point(20, 149);
            this.btnViewFeedbackAttendance.Name = "btnViewFeedbackAttendance";
            this.btnViewFeedbackAttendance.Size = new System.Drawing.Size(200, 30);
            this.btnViewFeedbackAttendance.TabIndex = 2;
            this.btnViewFeedbackAttendance.Text = "View Attendance";
            this.btnViewFeedbackAttendance.UseVisualStyleBackColor = true;
            this.btnViewFeedbackAttendance.Click += new System.EventHandler(this.btnViewFeedbackAttendance_Click);
            // 
            // grpClubManagement
            // 
            this.grpClubManagement.Controls.Add(this.btnApproveMembershipRequests);
            this.grpClubManagement.Location = new System.Drawing.Point(280, 172);
            this.grpClubManagement.Name = "grpClubManagement";
            this.grpClubManagement.Size = new System.Drawing.Size(250, 117);
            this.grpClubManagement.TabIndex = 6;
            this.grpClubManagement.TabStop = false;
            this.grpClubManagement.Text = "Club Management";
            // 
            // btnApproveMembershipRequests
            // 
            this.btnApproveMembershipRequests.Location = new System.Drawing.Point(19, 39);
            this.btnApproveMembershipRequests.Name = "btnApproveMembershipRequests";
            this.btnApproveMembershipRequests.Size = new System.Drawing.Size(200, 30);
            this.btnApproveMembershipRequests.TabIndex = 1;
            this.btnApproveMembershipRequests.Text = "Approve Membership Requests";
            this.btnApproveMembershipRequests.UseVisualStyleBackColor = true;
            this.btnApproveMembershipRequests.Click += new System.EventHandler(this.btnApproveMembershipRequests_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(430, 442);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 30);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Location = new System.Drawing.Point(384, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 134);
            this.panel2.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(38, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 16);
            this.label15.TabIndex = 2;
            this.label15.Text = "Your Account";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(18, 85);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 35);
            this.button5.TabIndex = 1;
            this.button5.Text = "Change Password";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 35);
            this.button4.TabIndex = 0;
            this.button4.Text = "Profile";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(250, 9);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(128, 30);
            this.btRefresh.TabIndex = 11;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FacultyMemberDashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(577, 500);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.grpClubManagement);
            this.Controls.Add(this.grpEventManagement);
            this.Controls.Add(this.lblPendingMembershipRequests);
            this.Controls.Add(this.lblUpcomingEvents);
            this.Controls.Add(this.lblTotalEvents);
            this.Name = "FacultyMemberDashboardForm";
            this.Text = "Faculty Dashboard";
            this.Load += new System.EventHandler(this.FacultyMemberDashboardForm_Load);
            this.grpEventManagement.ResumeLayout(false);
            this.grpClubManagement.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Declare controls as private members
        private Label lblTotalEvents;
        private Label lblUpcomingEvents;
        private Label lblPendingMembershipRequests;
        private GroupBox grpEventManagement;
        private Button btnCreateNewEvent;
        private Button btnViewFeedbackAttendance;
        private GroupBox grpClubManagement;
        private Button btnLogout;
        private Button btnManageEvents;
        private Button btnApproveMembershipRequests;
        private Button ViewFeedback;
        private Button button1;
        private Panel panel2;
        private Label label15;
        private Button button5;
        private Button button4;
        private Button btRefresh;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
