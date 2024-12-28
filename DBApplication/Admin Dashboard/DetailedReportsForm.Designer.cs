using System;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class DetailedReportsForm : Form
    {
        private Label lblDetailedReports;
        private Button btnGenerateDetailedReport;

        private void InitializeComponent()
        {
            this.lblDetailedReports = new System.Windows.Forms.Label();
            this.btnGenerateDetailedReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDetailedReports
            // 
            this.lblDetailedReports.AutoSize = true;
            this.lblDetailedReports.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDetailedReports.Location = new System.Drawing.Point(20, 20);
            this.lblDetailedReports.Name = "lblDetailedReports";
            this.lblDetailedReports.Size = new System.Drawing.Size(167, 24);
            this.lblDetailedReports.TabIndex = 0;
            this.lblDetailedReports.Text = "Detailed Reports";
            // 
            // btnGenerateDetailedReport
            // 
            this.btnGenerateDetailedReport.Location = new System.Drawing.Point(20, 60);
            this.btnGenerateDetailedReport.Name = "btnGenerateDetailedReport";
            this.btnGenerateDetailedReport.Size = new System.Drawing.Size(188, 66);
            this.btnGenerateDetailedReport.TabIndex = 1;
            this.btnGenerateDetailedReport.Text = "Generate Detailed Report";
            this.btnGenerateDetailedReport.UseVisualStyleBackColor = true;
            // 
            // DetailedReportsForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.btnGenerateDetailedReport);
            this.Controls.Add(this.lblDetailedReports);
            this.Name = "DetailedReportsForm";
            this.Text = "Detailed Reports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
