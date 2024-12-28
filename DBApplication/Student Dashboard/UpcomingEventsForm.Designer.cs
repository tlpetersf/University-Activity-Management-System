using System;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class UpcomingEventsForm : Form
    {
       

        private void InitializeComponent()
        {
            this.lblUpcomingEvents = new System.Windows.Forms.Label();
            this.grpUpcomingEvents = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvUpcomingEvents = new System.Windows.Forms.DataGridView();
            this.grpUpcomingEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUpcomingEvents
            // 
            this.lblUpcomingEvents.AutoSize = true;
            this.lblUpcomingEvents.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblUpcomingEvents.Location = new System.Drawing.Point(20, 20);
            this.lblUpcomingEvents.Name = "lblUpcomingEvents";
            this.lblUpcomingEvents.Size = new System.Drawing.Size(176, 24);
            this.lblUpcomingEvents.TabIndex = 0;
            this.lblUpcomingEvents.Text = "Upcoming Events";
            // 
            // grpUpcomingEvents
            // 
            this.grpUpcomingEvents.Controls.Add(this.button1);
            this.grpUpcomingEvents.Controls.Add(this.dgvUpcomingEvents);
            this.grpUpcomingEvents.Location = new System.Drawing.Point(20, 60);
            this.grpUpcomingEvents.Name = "grpUpcomingEvents";
            this.grpUpcomingEvents.Size = new System.Drawing.Size(600, 300);
            this.grpUpcomingEvents.TabIndex = 1;
            this.grpUpcomingEvents.TabStop = false;
            this.grpUpcomingEvents.Text = "Event List";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvUpcomingEvents
            // 
            this.dgvUpcomingEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpcomingEvents.Location = new System.Drawing.Point(20, 30);
            this.dgvUpcomingEvents.Name = "dgvUpcomingEvents";
            this.dgvUpcomingEvents.RowHeadersWidth = 51;
            this.dgvUpcomingEvents.Size = new System.Drawing.Size(550, 200);
            this.dgvUpcomingEvents.TabIndex = 0;
            // 
            // UpcomingEventsForm
            // 
            this.ClientSize = new System.Drawing.Size(640, 380);
            this.Controls.Add(this.grpUpcomingEvents);
            this.Controls.Add(this.lblUpcomingEvents);
            this.Name = "UpcomingEventsForm";
            this.Text = "Upcoming Events";
            this.grpUpcomingEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Declare controls as private members
        private Label lblUpcomingEvents;
        private GroupBox grpUpcomingEvents;
        private DataGridView dgvUpcomingEvents;
        private Button button1;
    }
}
