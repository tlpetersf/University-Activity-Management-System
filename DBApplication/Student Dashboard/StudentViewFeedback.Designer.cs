using System;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class StudentViewFeedback : Form
    {


        private void InitializeComponent()
        {
            this.lblViewFeedback = new System.Windows.Forms.Label();
            this.grpFeedbackList = new System.Windows.Forms.GroupBox();
            this.dgvFeedbacks = new System.Windows.Forms.DataGridView();
            this.grpDeleteFeedback = new System.Windows.Forms.GroupBox();
            this.tbFeedbackID = new System.Windows.Forms.TextBox();
            this.btnDeleteFeedback = new System.Windows.Forms.Button();
            this.lblFeedbackID = new System.Windows.Forms.Label();
            this.grpFeedbackList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedbacks)).BeginInit();
            this.grpDeleteFeedback.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblViewFeedback
            // 
            this.lblViewFeedback.AutoSize = true;
            this.lblViewFeedback.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblViewFeedback.Location = new System.Drawing.Point(20, 20);
            this.lblViewFeedback.Name = "lblViewFeedback";
            this.lblViewFeedback.Size = new System.Drawing.Size(201, 24);
            this.lblViewFeedback.TabIndex = 0;
            this.lblViewFeedback.Text = "View Your Feedback";
            // 
            // grpFeedbackList
            // 
            this.grpFeedbackList.Controls.Add(this.dgvFeedbacks);
            this.grpFeedbackList.Location = new System.Drawing.Point(20, 60);
            this.grpFeedbackList.Name = "grpFeedbackList";
            this.grpFeedbackList.Size = new System.Drawing.Size(600, 300);
            this.grpFeedbackList.TabIndex = 1;
            this.grpFeedbackList.TabStop = false;
            this.grpFeedbackList.Text = "Your Feedbacks";
            // 
            // dgvFeedbacks
            // 
            this.dgvFeedbacks.AllowUserToAddRows = false;
            this.dgvFeedbacks.AllowUserToDeleteRows = false;
            this.dgvFeedbacks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedbacks.Location = new System.Drawing.Point(20, 30);
            this.dgvFeedbacks.Name = "dgvFeedbacks";
            this.dgvFeedbacks.RowHeadersWidth = 51;
            this.dgvFeedbacks.Size = new System.Drawing.Size(550, 230);
            this.dgvFeedbacks.TabIndex = 0;
            // 
            // grpDeleteFeedback
            // 
            this.grpDeleteFeedback.Controls.Add(this.tbFeedbackID);
            this.grpDeleteFeedback.Controls.Add(this.btnDeleteFeedback);
            this.grpDeleteFeedback.Controls.Add(this.lblFeedbackID);
            this.grpDeleteFeedback.Location = new System.Drawing.Point(20, 380);
            this.grpDeleteFeedback.Name = "grpDeleteFeedback";
            this.grpDeleteFeedback.Size = new System.Drawing.Size(600, 120);
            this.grpDeleteFeedback.TabIndex = 2;
            this.grpDeleteFeedback.TabStop = false;
            this.grpDeleteFeedback.Text = "Delete Feedback";
            // 
            // tbFeedbackID
            // 
            this.tbFeedbackID.Location = new System.Drawing.Point(160, 40);
            this.tbFeedbackID.Name = "tbFeedbackID";
            this.tbFeedbackID.Size = new System.Drawing.Size(200, 22);
            this.tbFeedbackID.TabIndex = 2;
            // 
            // btnDeleteFeedback
            // 
            this.btnDeleteFeedback.Location = new System.Drawing.Point(160, 70);
            this.btnDeleteFeedback.Name = "btnDeleteFeedback";
            this.btnDeleteFeedback.Size = new System.Drawing.Size(120, 30);
            this.btnDeleteFeedback.TabIndex = 1;
            this.btnDeleteFeedback.Text = "Delete Feedback";
            this.btnDeleteFeedback.UseVisualStyleBackColor = true;
            this.btnDeleteFeedback.Click += new System.EventHandler(this.btnDeleteFeedback_Click);
            // 
            // lblFeedbackID
            // 
            this.lblFeedbackID.AutoSize = true;
            this.lblFeedbackID.Location = new System.Drawing.Point(20, 40);
            this.lblFeedbackID.Name = "lblFeedbackID";
            this.lblFeedbackID.Size = new System.Drawing.Size(122, 16);
            this.lblFeedbackID.TabIndex = 0;
            this.lblFeedbackID.Text = "Enter Feedback ID:";
            // 
            // StudentViewFeedback
            // 
            this.ClientSize = new System.Drawing.Size(640, 520);
            this.Controls.Add(this.grpDeleteFeedback);
            this.Controls.Add(this.grpFeedbackList);
            this.Controls.Add(this.lblViewFeedback);
            this.Name = "StudentViewFeedback";
            this.Text = "View and Delete Feedback";
            this.grpFeedbackList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedbacks)).EndInit();
            this.grpDeleteFeedback.ResumeLayout(false);
            this.grpDeleteFeedback.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Declare controls as private members
        private Label lblViewFeedback;
        private GroupBox grpFeedbackList;
        private DataGridView dgvFeedbacks;
        private GroupBox grpDeleteFeedback;
        private TextBox tbFeedbackID;
        private Button btnDeleteFeedback;
        private Label lblFeedbackID;


    }
}