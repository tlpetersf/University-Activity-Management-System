using System;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class RegisteredEventsForm : Form
    {


        private void InitializeComponent()
        {
            this.lblRegisteredEvents = new System.Windows.Forms.Label();
            this.grpRegisteredEvents = new System.Windows.Forms.GroupBox();
            this.dgvRegisteredEvents = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btCanReg = new System.Windows.Forms.Button();
            this.tbRegId = new System.Windows.Forms.TextBox();
            this.grpRegisteredEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisteredEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegisteredEvents
            // 
            this.lblRegisteredEvents.AutoSize = true;
            this.lblRegisteredEvents.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblRegisteredEvents.Location = new System.Drawing.Point(20, 20);
            this.lblRegisteredEvents.Name = "lblRegisteredEvents";
            this.lblRegisteredEvents.Size = new System.Drawing.Size(183, 24);
            this.lblRegisteredEvents.TabIndex = 0;
            this.lblRegisteredEvents.Text = "Registered Events";
            // 
            // grpRegisteredEvents
            // 
            this.grpRegisteredEvents.Controls.Add(this.dgvRegisteredEvents);
            this.grpRegisteredEvents.Location = new System.Drawing.Point(20, 60);
            this.grpRegisteredEvents.Name = "grpRegisteredEvents";
            this.grpRegisteredEvents.Size = new System.Drawing.Size(617, 304);
            this.grpRegisteredEvents.TabIndex = 1;
            this.grpRegisteredEvents.TabStop = false;
            this.grpRegisteredEvents.Text = "Event List";
            // 
            // dgvRegisteredEvents
            // 
            this.dgvRegisteredEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegisteredEvents.Location = new System.Drawing.Point(20, 30);
            this.dgvRegisteredEvents.Name = "dgvRegisteredEvents";
            this.dgvRegisteredEvents.RowHeadersWidth = 51;
            this.dgvRegisteredEvents.Size = new System.Drawing.Size(574, 255);
            this.dgvRegisteredEvents.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(661, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registeration ID";
            // 
            // btCanReg
            // 
            this.btCanReg.Location = new System.Drawing.Point(678, 226);
            this.btCanReg.Name = "btCanReg";
            this.btCanReg.Size = new System.Drawing.Size(163, 39);
            this.btCanReg.TabIndex = 3;
            this.btCanReg.Text = "Cancel Registeration";
            this.btCanReg.UseVisualStyleBackColor = true;
            this.btCanReg.Click += new System.EventHandler(this.btCanReg_Click);
            // 
            // tbRegId
            // 
            this.tbRegId.Location = new System.Drawing.Point(678, 181);
            this.tbRegId.Name = "tbRegId";
            this.tbRegId.Size = new System.Drawing.Size(53, 22);
            this.tbRegId.TabIndex = 4;
            // 
            // RegisteredEventsForm
            // 
            this.ClientSize = new System.Drawing.Size(869, 376);
            this.Controls.Add(this.tbRegId);
            this.Controls.Add(this.btCanReg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpRegisteredEvents);
            this.Controls.Add(this.lblRegisteredEvents);
            this.Name = "RegisteredEventsForm";
            this.Text = "Registered Events";
            this.grpRegisteredEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisteredEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Declare controls as private members
        private Label lblRegisteredEvents;
        private GroupBox grpRegisteredEvents;
        private DataGridView dgvRegisteredEvents;
        private Label label1;
        private Button btCanReg;
        private TextBox tbRegId;
    }
}