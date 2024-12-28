using System;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class ReservationHistoryForm : Form
    {


        private void InitializeComponent()
        {
            this.lblReservationHistory = new System.Windows.Forms.Label();
            this.dgvReservationHistory = new System.Windows.Forms.DataGridView();
            this.tbResID = new System.Windows.Forms.TextBox();
            this.btCancelRes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReservationHistory
            // 
            this.lblReservationHistory.AutoSize = true;
            this.lblReservationHistory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblReservationHistory.Location = new System.Drawing.Point(20, 20);
            this.lblReservationHistory.Name = "lblReservationHistory";
            this.lblReservationHistory.Size = new System.Drawing.Size(197, 24);
            this.lblReservationHistory.TabIndex = 0;
            this.lblReservationHistory.Text = "Reservation History";
            // 
            // dgvReservationHistory
            // 
            this.dgvReservationHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservationHistory.Location = new System.Drawing.Point(20, 60);
            this.dgvReservationHistory.Name = "dgvReservationHistory";
            this.dgvReservationHistory.RowHeadersWidth = 51;
            this.dgvReservationHistory.Size = new System.Drawing.Size(540, 200);
            this.dgvReservationHistory.TabIndex = 1;
            // 
            // tbResID
            // 
            this.tbResID.Location = new System.Drawing.Point(91, 311);
            this.tbResID.Name = "tbResID";
            this.tbResID.Size = new System.Drawing.Size(145, 22);
            this.tbResID.TabIndex = 2;
            // 
            // btCancelRes
            // 
            this.btCancelRes.Location = new System.Drawing.Point(317, 304);
            this.btCancelRes.Name = "btCancelRes";
            this.btCancelRes.Size = new System.Drawing.Size(148, 36);
            this.btCancelRes.TabIndex = 3;
            this.btCancelRes.Text = "Cancel Reservation";
            this.btCancelRes.UseVisualStyleBackColor = true;
            this.btCancelRes.Click += new System.EventHandler(this.btCancelRes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Reservation ID";
            // 
            // ReservationHistoryForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCancelRes);
            this.Controls.Add(this.tbResID);
            this.Controls.Add(this.dgvReservationHistory);
            this.Controls.Add(this.lblReservationHistory);
            this.Name = "ReservationHistoryForm";
            this.Text = "Reservation History";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Declare controls as private members
        private Label lblReservationHistory;
        private DataGridView dgvReservationHistory;
        private TextBox tbResID;
        private Button btCancelRes;
        private Label label1;
    }
}