namespace DBapplication
{
    partial class ManageEventsForm
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
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEventID = new System.Windows.Forms.TextBox();
            this.buttDeleteEvent = new System.Windows.Forms.Button();
            this.buttEditEvent = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEvents
            // 
            this.dgvEvents.AllowUserToAddRows = false;
            this.dgvEvents.AllowUserToDeleteRows = false;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Location = new System.Drawing.Point(25, 25);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.RowHeadersWidth = 51;
            this.dgvEvents.RowTemplate.Height = 24;
            this.dgvEvents.Size = new System.Drawing.Size(658, 193);
            this.dgvEvents.TabIndex = 0;
            this.dgvEvents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvents_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select An Event";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Event ID";
            // 
            // txtEventID
            // 
            this.txtEventID.Location = new System.Drawing.Point(141, 306);
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.Size = new System.Drawing.Size(179, 22);
            this.txtEventID.TabIndex = 3;
            this.txtEventID.TextChanged += new System.EventHandler(this.txtEventID_TextChanged);
            // 
            // buttDeleteEvent
            // 
            this.buttDeleteEvent.Location = new System.Drawing.Point(545, 370);
            this.buttDeleteEvent.Name = "buttDeleteEvent";
            this.buttDeleteEvent.Size = new System.Drawing.Size(138, 27);
            this.buttDeleteEvent.TabIndex = 7;
            this.buttDeleteEvent.Text = "Delete Event";
            this.buttDeleteEvent.UseVisualStyleBackColor = true;
            this.buttDeleteEvent.Click += new System.EventHandler(this.buttDeleteEvent_Click);
            // 
            // buttEditEvent
            // 
            this.buttEditEvent.Location = new System.Drawing.Point(371, 370);
            this.buttEditEvent.Name = "buttEditEvent";
            this.buttEditEvent.Size = new System.Drawing.Size(138, 27);
            this.buttEditEvent.TabIndex = 6;
            this.buttEditEvent.Text = "Edit Event";
            this.buttEditEvent.UseVisualStyleBackColor = true;
            this.buttEditEvent.Click += new System.EventHandler(this.buttEditEvent_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(613, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 37);
            this.button3.TabIndex = 8;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ManageEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttDeleteEvent);
            this.Controls.Add(this.buttEditEvent);
            this.Controls.Add(this.txtEventID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEvents);
            this.Name = "ManageEventsForm";
            this.Text = "ManageEventsForm";
            this.Load += new System.EventHandler(this.ManageEventsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEventID;
        private System.Windows.Forms.Button buttDeleteEvent;
        private System.Windows.Forms.Button buttEditEvent;
        private System.Windows.Forms.Button button3;
    }
}