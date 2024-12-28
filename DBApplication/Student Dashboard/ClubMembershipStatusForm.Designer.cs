using System;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class ClubMembershipStatusForm : Form
    {
        private void InitializeComponent()
        {
            this.lblClubMembershipStatus = new System.Windows.Forms.Label();
            this.dgvClubMemberships = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMemId = new System.Windows.Forms.TextBox();
            this.btnLeaveClub = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClubMemberships)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClubMembershipStatus
            // 
            this.lblClubMembershipStatus.AutoSize = true;
            this.lblClubMembershipStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblClubMembershipStatus.Location = new System.Drawing.Point(20, 20);
            this.lblClubMembershipStatus.Name = "lblClubMembershipStatus";
            this.lblClubMembershipStatus.Size = new System.Drawing.Size(264, 24);
            this.lblClubMembershipStatus.TabIndex = 0;
            this.lblClubMembershipStatus.Text = "Current Club Memberships";
            // 
            // dgvClubMemberships
            // 
            this.dgvClubMemberships.AllowUserToAddRows = false;
            this.dgvClubMemberships.AllowUserToDeleteRows = false;
            this.dgvClubMemberships.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClubMemberships.Location = new System.Drawing.Point(20, 60);
            this.dgvClubMemberships.Name = "dgvClubMemberships";
            this.dgvClubMemberships.ReadOnly = true;
            this.dgvClubMemberships.RowHeadersWidth = 51;
            this.dgvClubMemberships.RowTemplate.Height = 24;
            this.dgvClubMemberships.Size = new System.Drawing.Size(540, 300);
            this.dgvClubMemberships.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(692, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Membership ID";
            // 
            // tbMemId
            // 
            this.tbMemId.Location = new System.Drawing.Point(695, 223);
            this.tbMemId.Name = "tbMemId";
            this.tbMemId.Size = new System.Drawing.Size(100, 22);
            this.tbMemId.TabIndex = 3;
            // 
            // btnLeaveClub
            // 
            this.btnLeaveClub.Location = new System.Drawing.Point(695, 251);
            this.btnLeaveClub.Name = "btnLeaveClub";
            this.btnLeaveClub.Size = new System.Drawing.Size(155, 38);
            this.btnLeaveClub.TabIndex = 4;
            this.btnLeaveClub.Text = "Leave Club";
            this.btnLeaveClub.UseVisualStyleBackColor = true;
            this.btnLeaveClub.Click += new System.EventHandler(this.btnLeaveClub_Click);
            // 
            // ClubMembershipStatusForm
            // 
            this.ClientSize = new System.Drawing.Size(931, 394);
            this.Controls.Add(this.btnLeaveClub);
            this.Controls.Add(this.tbMemId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClubMemberships);
            this.Controls.Add(this.lblClubMembershipStatus);
            this.Name = "ClubMembershipStatusForm";
            this.Text = "Club Membership Status";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClubMemberships)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Declare controls as private members
        private Label lblClubMembershipStatus;
        private DataGridView dgvClubMemberships;
        private Label label1;
        private TextBox tbMemId;
        private Button btnLeaveClub;
    }
}
