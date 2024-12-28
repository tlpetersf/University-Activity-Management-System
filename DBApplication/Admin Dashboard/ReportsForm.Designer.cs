using System;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class ReportsForm : Form
    {
      

        private void InitializeComponent()
        {
            this.comboBoxReports = new System.Windows.Forms.ComboBox();
            this.dataGridViewEventsAttended = new System.Windows.Forms.DataGridView();
            this.dataGridViewClubMemberships = new System.Windows.Forms.DataGridView();
            this.dataGridViewTotalUsers = new System.Windows.Forms.DataGridView();
            this.dataGridViewMemberStatus = new System.Windows.Forms.DataGridView();
            this.dataGridViewEventStats = new System.Windows.Forms.DataGridView();
            this.labelEventsAttended = new System.Windows.Forms.Label();
            this.labelClubMemberships = new System.Windows.Forms.Label();
            this.labelTotalUsers = new System.Windows.Forms.Label();
            this.labelMemberStatus = new System.Windows.Forms.Label();
            this.labelEventStats = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventsAttended)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClubMemberships)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotalUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMemberStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventStats)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxReports
            // 
            this.comboBoxReports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReports.FormattingEnabled = true;
            this.comboBoxReports.Items.AddRange(new object[] {
            "Number of Events Attended by Each User",
            "Number of Club Memberships for Each User",
            "Total Users, Events, and Clubs",
            "Total Active, Rejected, and Pending Members in Clubs",
            "Average, Minimum, and Maximum Number of Events Attended by Users"});
            this.comboBoxReports.Location = new System.Drawing.Point(20, 20);
            this.comboBoxReports.Name = "comboBoxReports";
            this.comboBoxReports.Size = new System.Drawing.Size(400, 24);
            this.comboBoxReports.TabIndex = 0;
            // 
            // dataGridViewEventsAttended
            // 
            this.dataGridViewEventsAttended.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEventsAttended.Location = new System.Drawing.Point(20, 80);
            this.dataGridViewEventsAttended.Name = "dataGridViewEventsAttended";
            this.dataGridViewEventsAttended.Size = new System.Drawing.Size(1100, 200);
            this.dataGridViewEventsAttended.TabIndex = 1;
            // 
            // dataGridViewClubMemberships
            // 
            this.dataGridViewClubMemberships.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClubMemberships.Location = new System.Drawing.Point(20, 80);
            this.dataGridViewClubMemberships.Name = "dataGridViewClubMemberships";
            this.dataGridViewClubMemberships.Size = new System.Drawing.Size(1100, 200);
            this.dataGridViewClubMemberships.TabIndex = 2;
            this.dataGridViewClubMemberships.Visible = false;
            // 
            // dataGridViewTotalUsers
            // 
            this.dataGridViewTotalUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTotalUsers.Location = new System.Drawing.Point(20, 80);
            this.dataGridViewTotalUsers.Name = "dataGridViewTotalUsers";
            this.dataGridViewTotalUsers.Size = new System.Drawing.Size(1100, 200);
            this.dataGridViewTotalUsers.TabIndex = 3;
            this.dataGridViewTotalUsers.Visible = false;
            // 
            // dataGridViewMemberStatus
            // 
            this.dataGridViewMemberStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMemberStatus.Location = new System.Drawing.Point(20, 80);
            this.dataGridViewMemberStatus.Name = "dataGridViewMemberStatus";
            this.dataGridViewMemberStatus.Size = new System.Drawing.Size(1100, 200);
            this.dataGridViewMemberStatus.TabIndex = 4;
            this.dataGridViewMemberStatus.Visible = false;
            // 
            // dataGridViewEventStats
            // 
            this.dataGridViewEventStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEventStats.Location = new System.Drawing.Point(20, 80);
            this.dataGridViewEventStats.Name = "dataGridViewEventStats";
            this.dataGridViewEventStats.Size = new System.Drawing.Size(1100, 200);
            this.dataGridViewEventStats.TabIndex = 5;
            this.dataGridViewEventStats.Visible = false;
            // 
            // labelEventsAttended
            // 
            this.labelEventsAttended.AutoSize = true;
            this.labelEventsAttended.Location = new System.Drawing.Point(20, 60);
            this.labelEventsAttended.Name = "labelEventsAttended";
            this.labelEventsAttended.Size = new System.Drawing.Size(169, 17);
            this.labelEventsAttended.TabIndex = 6;
            this.labelEventsAttended.Text = "Number of Events Attended by Each User";
            // 
            // labelClubMemberships
            // 
            this.labelClubMemberships.AutoSize = true;
            this.labelClubMemberships.Location = new System.Drawing.Point(20, 60);
            this.labelClubMemberships.Name = "labelClubMemberships";
            this.labelClubMemberships.Size = new System.Drawing.Size(206, 17);
            this.labelClubMemberships.TabIndex = 7;
            this.labelClubMemberships.Text = "Number of Club Memberships for Each User";
            this.labelClubMemberships.Visible = false;
            // 
            // labelTotalUsers
            // 
            this.labelTotalUsers.AutoSize = true;
            this.labelTotalUsers.Location = new System.Drawing.Point(20, 60);
            this.labelTotalUsers.Name = "labelTotalUsers";
            this.labelTotalUsers.Size = new System.Drawing.Size(151, 17);
            this.labelTotalUsers.TabIndex = 8;
            this.labelTotalUsers.Text = "Total Users, Events, and Clubs";
            this.labelTotalUsers.Visible = false;
            // 
            // labelMemberStatus
            // 
            this.labelMemberStatus.AutoSize = true;
            this.labelMemberStatus.Location = new System.Drawing.Point(20, 60);
            this.labelMemberStatus.Name = "labelMemberStatus";
            this.labelMemberStatus.Size = new System.Drawing.Size(278, 17);
            this.labelMemberStatus.TabIndex = 9;
            this.labelMemberStatus.Text = "Total Active, Rejected, and Pending Members in Clubs";
            this.labelMemberStatus.Visible = false;
            // 
            // labelEventStats
            // 
            this.labelEventStats.AutoSize = true;
            this.labelEventStats.Location = new System.Drawing.Point(20, 60);
            this.labelEventStats.Name = "labelEventStats";
            this.labelEventStats.Size = new System.Drawing.Size(306, 17);
            this.labelEventStats.TabIndex = 10;
            this.labelEventStats.Text = "Average, Minimum, and Maximum Number of Events Attended by Users";
            this.labelEventStats.Visible = false;
            // 
            // ReportsForm
            // 
            this.ClientSize = new System.Drawing.Size(1140, 600);
            this.Controls.Add(this.comboBoxReports);
            this.Controls.Add(this.dataGridViewEventsAttended);
            this.Controls.Add(this.dataGridViewClubMemberships);
            this.Controls.Add(this.dataGridViewTotalUsers);
            this.Controls.Add(this.dataGridViewMemberStatus);
            this.Controls.Add(this.dataGridViewEventStats);
            this.Controls.Add(this.labelEventsAttended);
            this.Controls.Add(this.labelClubMemberships);
            this.Controls.Add(this.labelTotalUsers);
            this.Controls.Add(this.labelMemberStatus);
            this.Controls.Add(this.labelEventStats);
            this.Name = "ReportsForm";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventsAttended)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClubMemberships)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotalUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMemberStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Declare components
        private System.Windows.Forms.ComboBox comboBoxReports;
        private System.Windows.Forms.DataGridView dataGridViewEventsAttended;
        private System.Windows.Forms.DataGridView dataGridViewClubMemberships;
        private System.Windows.Forms.DataGridView dataGridViewTotalUsers;
        private System.Windows.Forms.DataGridView dataGridViewMemberStatus;
        private System.Windows.Forms.DataGridView dataGridViewEventStats;
        private System.Windows.Forms.Label labelEventsAttended;
        private System.Windows.Forms.Label labelClubMemberships;
        private System.Windows.Forms.Label labelTotalUsers;
        private System.Windows.Forms.Label labelMemberStatus;
        private System.Windows.Forms.Label labelEventStats;
    }
}
