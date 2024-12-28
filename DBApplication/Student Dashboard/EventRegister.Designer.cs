using System;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class EventRegister : Form
    {
      

        private void InitializeComponent()
        {
            this.lblSelectEvent = new System.Windows.Forms.Label();
            this.cmbEvents = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblRegistrationStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSelectEvent
            // 
            this.lblSelectEvent.AutoSize = true;
            this.lblSelectEvent.Location = new System.Drawing.Point(12, 40);
            this.lblSelectEvent.Name = "lblSelectEvent";
            this.lblSelectEvent.Size = new System.Drawing.Size(85, 16);
            this.lblSelectEvent.TabIndex = 4;
            this.lblSelectEvent.Text = "Select Event:";
            // 
            // cmbEvents
            // 
            this.cmbEvents.FormattingEnabled = true;
            this.cmbEvents.Location = new System.Drawing.Point(114, 37);
            this.cmbEvents.Name = "cmbEvents";
            this.cmbEvents.Size = new System.Drawing.Size(200, 24);
            this.cmbEvents.TabIndex = 5;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(100, 150);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(117, 37);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblRegistrationStatus
            // 
            this.lblRegistrationStatus.AutoSize = true;
            this.lblRegistrationStatus.Location = new System.Drawing.Point(100, 190);
            this.lblRegistrationStatus.Name = "lblRegistrationStatus";
            this.lblRegistrationStatus.Size = new System.Drawing.Size(0, 16);
            this.lblRegistrationStatus.TabIndex = 7;
            // 
            // EventRegister
            // 
            this.ClientSize = new System.Drawing.Size(350, 220);
            this.Controls.Add(this.lblRegistrationStatus);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cmbEvents);
            this.Controls.Add(this.lblSelectEvent);
            this.Name = "EventRegister";
            this.Text = "Student Event Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Label lblSelectEvent;
        private ComboBox cmbEvents;
        private Button btnRegister;
        private Label lblRegistrationStatus;
    }
}
