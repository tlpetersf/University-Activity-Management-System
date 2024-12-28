using System;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class ReserveLocationForm : Form
    {
        private Label lblSelectLocation;
        private ComboBox cmbLocation;
        private Label lblStartTime;
        private DateTimePicker dtpStartTime;
        private Label lblEndTime;
        private DateTimePicker dtpEndTime;
        private Button btnReserve;
        private Label lblMessage;

      

        private void InitializeComponent()
        {
            this.lblSelectLocation = new System.Windows.Forms.Label();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.btnReserve = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSelectLocation
            // 
            this.lblSelectLocation.AutoSize = true;
            this.lblSelectLocation.Location = new System.Drawing.Point(29, 36);
            this.lblSelectLocation.Name = "lblSelectLocation";
            this.lblSelectLocation.Size = new System.Drawing.Size(102, 16);
            this.lblSelectLocation.TabIndex = 0;
            this.lblSelectLocation.Text = "Select Location:";
            // 
            // cmbLocation
            // 
            this.cmbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(129, 33);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(200, 24);
            this.cmbLocation.TabIndex = 1;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(29, 80);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(71, 16);
            this.lblStartTime.TabIndex = 2;
            this.lblStartTime.Text = "Start Time:";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTime.Location = new System.Drawing.Point(129, 75);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(200, 22);
            this.dtpStartTime.TabIndex = 3;
            this.dtpStartTime.ValueChanged += new System.EventHandler(this.dtpStartTime_ValueChanged);
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(29, 120);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(68, 16);
            this.lblEndTime.TabIndex = 4;
            this.lblEndTime.Text = "End Time:";
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndTime.Location = new System.Drawing.Point(129, 115);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(200, 22);
            this.dtpEndTime.TabIndex = 5;
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(129, 160);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(100, 30);
            this.btnReserve.TabIndex = 6;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(129, 205);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 16);
            this.lblMessage.TabIndex = 7;
            // 
            // ReserveLocationForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.cmbLocation);
            this.Controls.Add(this.lblSelectLocation);
            this.Name = "ReserveLocationForm";
            this.Text = "Reserve Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
