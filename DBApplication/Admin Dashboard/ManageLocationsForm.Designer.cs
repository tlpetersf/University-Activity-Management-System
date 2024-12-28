namespace DBapplication
{
    partial class ManageLocationsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttDeleteEvent = new System.Windows.Forms.Button();
            this.buttEditLoc = new System.Windows.Forms.Button();
            this.txtLocID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // buttDeleteEvent
            // 
            this.buttDeleteEvent.Location = new System.Drawing.Point(662, 384);
            this.buttDeleteEvent.Name = "buttDeleteEvent";
            this.buttDeleteEvent.Size = new System.Drawing.Size(138, 27);
            this.buttDeleteEvent.TabIndex = 13;
            this.buttDeleteEvent.Text = "Delete Location";
            this.buttDeleteEvent.UseVisualStyleBackColor = true;
            this.buttDeleteEvent.Click += new System.EventHandler(this.buttDeleteEvent_Click);
            // 
            // buttEditLoc
            // 
            this.buttEditLoc.Location = new System.Drawing.Point(488, 384);
            this.buttEditLoc.Name = "buttEditLoc";
            this.buttEditLoc.Size = new System.Drawing.Size(138, 27);
            this.buttEditLoc.TabIndex = 12;
            this.buttEditLoc.Text = "Edit Location";
            this.buttEditLoc.UseVisualStyleBackColor = true;
            this.buttEditLoc.Click += new System.EventHandler(this.buttEditLoc_Click);
            // 
            // txtLocID
            // 
            this.txtLocID.Location = new System.Drawing.Point(150, 320);
            this.txtLocID.Name = "txtLocID";
            this.txtLocID.Size = new System.Drawing.Size(179, 22);
            this.txtLocID.TabIndex = 11;
            this.txtLocID.TextChanged += new System.EventHandler(this.txtLocID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Location ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select An Location";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvEvents
            // 
            this.dgvEvents.AllowUserToAddRows = false;
            this.dgvEvents.AllowUserToDeleteRows = false;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Location = new System.Drawing.Point(34, 39);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.RowHeadersWidth = 51;
            this.dgvEvents.RowTemplate.Height = 24;
            this.dgvEvents.Size = new System.Drawing.Size(732, 193);
            this.dgvEvents.TabIndex = 8;
            this.dgvEvents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvents_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(730, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 37);
            this.button3.TabIndex = 14;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ManageLocationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttDeleteEvent);
            this.Controls.Add(this.buttEditLoc);
            this.Controls.Add(this.txtLocID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEvents);
            this.Name = "ManageLocationsForm";
            this.Text = "ManageLocationsForm";
            this.Load += new System.EventHandler(this.ManageLocationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttDeleteEvent;
        private System.Windows.Forms.Button buttEditLoc;
        private System.Windows.Forms.TextBox txtLocID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.Button button3;
    }
}