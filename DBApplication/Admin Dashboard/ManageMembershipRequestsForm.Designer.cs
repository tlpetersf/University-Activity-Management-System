namespace DBapplication
{
    partial class ManageMembershipRequestsForm
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
            this.buttAcceptReq = new System.Windows.Forms.Button();
            this.buttRejectReq = new System.Windows.Forms.Button();
            this.txtEventID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // buttAcceptReq
            // 
            this.buttAcceptReq.Location = new System.Drawing.Point(667, 383);
            this.buttAcceptReq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttAcceptReq.Name = "buttAcceptReq";
            this.buttAcceptReq.Size = new System.Drawing.Size(139, 27);
            this.buttAcceptReq.TabIndex = 13;
            this.buttAcceptReq.Text = "Accept Request";
            this.buttAcceptReq.UseVisualStyleBackColor = true;
            this.buttAcceptReq.Click += new System.EventHandler(this.buttAcceptReq_Click);
            // 
            // buttRejectReq
            // 
            this.buttRejectReq.Location = new System.Drawing.Point(493, 383);
            this.buttRejectReq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttRejectReq.Name = "buttRejectReq";
            this.buttRejectReq.Size = new System.Drawing.Size(139, 27);
            this.buttRejectReq.TabIndex = 12;
            this.buttRejectReq.Text = "Reject Request";
            this.buttRejectReq.UseVisualStyleBackColor = true;
            this.buttRejectReq.Click += new System.EventHandler(this.buttRejectReq_Click);
            // 
            // txtEventID
            // 
            this.txtEventID.Location = new System.Drawing.Point(189, 320);
            this.txtEventID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.Size = new System.Drawing.Size(179, 22);
            this.txtEventID.TabIndex = 11;
            this.txtEventID.TextChanged += new System.EventHandler(this.txtEventID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Request ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select An Request";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvEvents
            // 
            this.dgvEvents.AllowUserToAddRows = false;
            this.dgvEvents.AllowUserToDeleteRows = false;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Location = new System.Drawing.Point(73, 39);
            this.dgvEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.RowHeadersWidth = 51;
            this.dgvEvents.RowTemplate.Height = 24;
            this.dgvEvents.Size = new System.Drawing.Size(732, 193);
            this.dgvEvents.TabIndex = 8;
            this.dgvEvents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvents_CellContentClick);
            // 
            // ManageMembershipRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 489);
            this.Controls.Add(this.buttAcceptReq);
            this.Controls.Add(this.buttRejectReq);
            this.Controls.Add(this.txtEventID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEvents);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManageMembershipRequestsForm";
            this.Text = "ManageMembershipRequestsForm";
            this.Load += new System.EventHandler(this.ManageMembershipRequestsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttAcceptReq;
        private System.Windows.Forms.Button buttRejectReq;
        private System.Windows.Forms.TextBox txtEventID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEvents;
    }
}