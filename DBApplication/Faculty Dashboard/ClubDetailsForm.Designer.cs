using System.Windows.Forms;

namespace DBapplication
{
    partial class ClubDetailsForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblClubName;
        private Label lblClubDescription;
        private Label lblTotalMembers;
        private DataGridView dgvClubMembers;
        private Button btnEditClubDetails;
        private Button btnRemoveMember;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblClubName = new System.Windows.Forms.Label();
            this.lblClubDescription = new System.Windows.Forms.Label();
            this.lblTotalMembers = new System.Windows.Forms.Label();
            this.dgvClubMembers = new System.Windows.Forms.DataGridView();
            this.btnEditClubDetails = new System.Windows.Forms.Button();
            this.btnRemoveMember = new System.Windows.Forms.Button();
            this.txtTotalMembers = new System.Windows.Forms.TextBox();
            this.txtClubDescription = new System.Windows.Forms.TextBox();
            this.txtClubName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClubMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(152, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Club Details";
            // 
            // lblClubName
            // 
            this.lblClubName.AutoSize = true;
            this.lblClubName.Location = new System.Drawing.Point(20, 60);
            this.lblClubName.Name = "lblClubName";
            this.lblClubName.Size = new System.Drawing.Size(77, 16);
            this.lblClubName.TabIndex = 1;
            this.lblClubName.Text = "Club Name:";
            // 
            // lblClubDescription
            // 
            this.lblClubDescription.AutoSize = true;
            this.lblClubDescription.Location = new System.Drawing.Point(20, 100);
            this.lblClubDescription.Name = "lblClubDescription";
            this.lblClubDescription.Size = new System.Drawing.Size(108, 16);
            this.lblClubDescription.TabIndex = 3;
            this.lblClubDescription.Text = "Club Description:";
            // 
            // lblTotalMembers
            // 
            this.lblTotalMembers.AutoSize = true;
            this.lblTotalMembers.Location = new System.Drawing.Point(20, 220);
            this.lblTotalMembers.Name = "lblTotalMembers";
            this.lblTotalMembers.Size = new System.Drawing.Size(101, 16);
            this.lblTotalMembers.TabIndex = 7;
            this.lblTotalMembers.Text = "Total Members:";
            // 
            // dgvClubMembers
            // 
            this.dgvClubMembers.AllowUserToAddRows = false;
            this.dgvClubMembers.AllowUserToDeleteRows = false;
            this.dgvClubMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClubMembers.Location = new System.Drawing.Point(20, 260);
            this.dgvClubMembers.Name = "dgvClubMembers";
            this.dgvClubMembers.RowHeadersWidth = 51;
            this.dgvClubMembers.Size = new System.Drawing.Size(300, 200);
            this.dgvClubMembers.TabIndex = 9;
            // 
            // btnEditClubDetails
            // 
            this.btnEditClubDetails.Location = new System.Drawing.Point(24, 533);
            this.btnEditClubDetails.Name = "btnEditClubDetails";
            this.btnEditClubDetails.Size = new System.Drawing.Size(150, 30);
            this.btnEditClubDetails.TabIndex = 10;
            this.btnEditClubDetails.Text = "Edit Club Details";
            this.btnEditClubDetails.UseVisualStyleBackColor = true;
            this.btnEditClubDetails.Click += new System.EventHandler(this.btnEditClubDetails_Click);
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.Location = new System.Drawing.Point(184, 533);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(150, 30);
            this.btnRemoveMember.TabIndex = 11;
            this.btnRemoveMember.Text = "Remove Member";
            this.btnRemoveMember.UseVisualStyleBackColor = true;
            this.btnRemoveMember.Click += new System.EventHandler(this.btnRemoveMember_Click);
            // 
            // txtTotalMembers
            // 
            this.txtTotalMembers.Location = new System.Drawing.Point(120, 220);
            this.txtTotalMembers.Name = "txtTotalMembers";
            this.txtTotalMembers.ReadOnly = true;
            this.txtTotalMembers.Size = new System.Drawing.Size(200, 22);
            this.txtTotalMembers.TabIndex = 8;
            // 
            // txtClubDescription
            // 
            this.txtClubDescription.Location = new System.Drawing.Point(134, 100);
            this.txtClubDescription.Multiline = true;
            this.txtClubDescription.Name = "txtClubDescription";
            this.txtClubDescription.ReadOnly = true;
            this.txtClubDescription.Size = new System.Drawing.Size(200, 60);
            this.txtClubDescription.TabIndex = 4;
            // 
            // txtClubName
            // 
            this.txtClubName.HideSelection = false;
            this.txtClubName.Location = new System.Drawing.Point(100, 60);
            this.txtClubName.Name = "txtClubName";
            this.txtClubName.ReadOnly = true;
            this.txtClubName.Size = new System.Drawing.Size(200, 22);
            this.txtClubName.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 490);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 22);
            this.textBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Member ID";
            // 
            // ClubDetailsForm
            // 
            this.ClientSize = new System.Drawing.Size(512, 599);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRemoveMember);
            this.Controls.Add(this.btnEditClubDetails);
            this.Controls.Add(this.dgvClubMembers);
            this.Controls.Add(this.txtTotalMembers);
            this.Controls.Add(this.lblTotalMembers);
            this.Controls.Add(this.txtClubDescription);
            this.Controls.Add(this.lblClubDescription);
            this.Controls.Add(this.txtClubName);
            this.Controls.Add(this.lblClubName);
            this.Controls.Add(this.lblTitle);
            this.Name = "ClubDetailsForm";
            this.Text = "Club Details";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClubMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox txtTotalMembers;
        private TextBox txtClubDescription;
        private TextBox txtClubName;
        private TextBox textBox1;
        private Label label1;
    }
}