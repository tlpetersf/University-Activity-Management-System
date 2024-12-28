namespace DBapplication
{
    partial class ManageClubsForm
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
            this.buttEditEvent = new System.Windows.Forms.Button();
            this.txtClubID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // buttDeleteEvent
            // 
            this.buttDeleteEvent.Location = new System.Drawing.Point(591, 384);
            this.buttDeleteEvent.Name = "buttDeleteEvent";
            this.buttDeleteEvent.Size = new System.Drawing.Size(138, 27);
            this.buttDeleteEvent.TabIndex = 13;
            this.buttDeleteEvent.Text = "Delete Club";
            this.buttDeleteEvent.UseVisualStyleBackColor = true;
            this.buttDeleteEvent.Click += new System.EventHandler(this.buttDeleteEvent_Click);
            // 
            // buttEditEvent
            // 
            this.buttEditEvent.Location = new System.Drawing.Point(417, 384);
            this.buttEditEvent.Name = "buttEditEvent";
            this.buttEditEvent.Size = new System.Drawing.Size(138, 27);
            this.buttEditEvent.TabIndex = 12;
            this.buttEditEvent.Text = "Club Details";
            this.buttEditEvent.UseVisualStyleBackColor = true;
            this.buttEditEvent.Click += new System.EventHandler(this.buttEditEvent_Click);
            // 
            // txtClubID
            // 
            this.txtClubID.Location = new System.Drawing.Point(187, 320);
            this.txtClubID.Name = "txtClubID";
            this.txtClubID.Size = new System.Drawing.Size(179, 22);
            this.txtClubID.TabIndex = 11;
            this.txtClubID.TextChanged += new System.EventHandler(this.txtEventID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Club ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select A Club";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvEvents
            // 
            this.dgvEvents.AllowUserToAddRows = false;
            this.dgvEvents.AllowUserToDeleteRows = false;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Location = new System.Drawing.Point(71, 39);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.RowHeadersWidth = 51;
            this.dgvEvents.RowTemplate.Height = 24;
            this.dgvEvents.Size = new System.Drawing.Size(658, 193);
            this.dgvEvents.TabIndex = 8;
            this.dgvEvents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvents_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(659, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 37);
            this.button3.TabIndex = 14;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ManageClubsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttDeleteEvent);
            this.Controls.Add(this.buttEditEvent);
            this.Controls.Add(this.txtClubID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEvents);
            this.Name = "ManageClubsForm";
            this.Text = "ManageClubsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttDeleteEvent;
        private System.Windows.Forms.Button buttEditEvent;
        private System.Windows.Forms.TextBox txtClubID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.Button button3;
    }
}