using System;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class AvailableClubsForm : Form
    {
      

        private void InitializeComponent()
        {
            this.lblAvailableClubs = new System.Windows.Forms.Label();
            this.grpAvailableClubs = new System.Windows.Forms.GroupBox();
            this.dgvClubsList = new System.Windows.Forms.DataGridView();
            this.btnJoinClub = new System.Windows.Forms.Button();
            this.tbClubID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAvailableClubs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClubsList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAvailableClubs
            // 
            this.lblAvailableClubs.AutoSize = true;
            this.lblAvailableClubs.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblAvailableClubs.Location = new System.Drawing.Point(20, 20);
            this.lblAvailableClubs.Name = "lblAvailableClubs";
            this.lblAvailableClubs.Size = new System.Drawing.Size(153, 24);
            this.lblAvailableClubs.TabIndex = 0;
            this.lblAvailableClubs.Text = "Available Clubs";
            // 
            // grpAvailableClubs
            // 
            this.grpAvailableClubs.Controls.Add(this.dgvClubsList);
            this.grpAvailableClubs.Location = new System.Drawing.Point(20, 58);
            this.grpAvailableClubs.Name = "grpAvailableClubs";
            this.grpAvailableClubs.Size = new System.Drawing.Size(842, 404);
            this.grpAvailableClubs.TabIndex = 1;
            this.grpAvailableClubs.TabStop = false;
            this.grpAvailableClubs.Text = "Clubs List";
            // 
            // dgvClubsList
            // 
            this.dgvClubsList.AllowUserToAddRows = false;
            this.dgvClubsList.AllowUserToDeleteRows = false;
            this.dgvClubsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClubsList.Location = new System.Drawing.Point(20, 45);
            this.dgvClubsList.Name = "dgvClubsList";
            this.dgvClubsList.ReadOnly = true;
            this.dgvClubsList.RowHeadersWidth = 51;
            this.dgvClubsList.RowTemplate.Height = 24;
            this.dgvClubsList.Size = new System.Drawing.Size(793, 333);
            this.dgvClubsList.TabIndex = 0;
            // 
            // btnJoinClub
            // 
            this.btnJoinClub.Location = new System.Drawing.Point(1000, 303);
            this.btnJoinClub.Name = "btnJoinClub";
            this.btnJoinClub.Size = new System.Drawing.Size(120, 30);
            this.btnJoinClub.TabIndex = 2;
            this.btnJoinClub.Text = "Join Club";
            this.btnJoinClub.UseVisualStyleBackColor = true;
            this.btnJoinClub.Click += new System.EventHandler(this.btnJoinClub_Click);
            // 
            // tbClubID
            // 
            this.tbClubID.Location = new System.Drawing.Point(979, 262);
            this.tbClubID.Name = "tbClubID";
            this.tbClubID.Size = new System.Drawing.Size(160, 22);
            this.tbClubID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(976, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Club ID";
            // 
            // AvailableClubsForm
            // 
            this.ClientSize = new System.Drawing.Size(1259, 536);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbClubID);
            this.Controls.Add(this.btnJoinClub);
            this.Controls.Add(this.grpAvailableClubs);
            this.Controls.Add(this.lblAvailableClubs);
            this.Name = "AvailableClubsForm";
            this.Text = "Available Clubs";
            this.grpAvailableClubs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClubsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Declare controls as private members
        private Label lblAvailableClubs;
        private GroupBox grpAvailableClubs;
        private DataGridView dgvClubsList;
        private Button btnJoinClub;
        private TextBox tbClubID;
        private Label label1;
    }
}
