using System.Windows.Forms;

namespace DBapplication
{
    partial class FacultyViewFeedback
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private ComboBox cbEventFilter;
        private DataGridView dgvFeedback;
        private Button btnExportFeedback;
        private TextBox txtResponse;
        private Label lblResponse;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbEventFilter = new System.Windows.Forms.ComboBox();
            this.dgvFeedback = new System.Windows.Forms.DataGridView();
            this.btnExportFeedback = new System.Windows.Forms.Button();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.lblResponse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(262, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Event Feedback Form";
            // 
            // cbEventFilter
            // 
            this.cbEventFilter.FormattingEnabled = true;
            this.cbEventFilter.Location = new System.Drawing.Point(20, 60);
            this.cbEventFilter.Name = "cbEventFilter";
            this.cbEventFilter.Size = new System.Drawing.Size(200, 24);
            this.cbEventFilter.TabIndex = 1;
            this.cbEventFilter.SelectedIndexChanged += new System.EventHandler(this.cbEventFilter_SelectedIndexChanged);
            // 
            // dgvFeedback
            // 
            this.dgvFeedback.AllowUserToAddRows = false;
            this.dgvFeedback.AllowUserToDeleteRows = false;
            this.dgvFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedback.Location = new System.Drawing.Point(12, 87);
            this.dgvFeedback.Name = "dgvFeedback";
            this.dgvFeedback.RowHeadersWidth = 51;
            this.dgvFeedback.Size = new System.Drawing.Size(760, 300);
            this.dgvFeedback.TabIndex = 3;
            this.dgvFeedback.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFeedback_CellContentClick);
            // 
            // btnExportFeedback
            // 
            this.btnExportFeedback.Location = new System.Drawing.Point(555, 420);
            this.btnExportFeedback.Name = "btnExportFeedback";
            this.btnExportFeedback.Size = new System.Drawing.Size(225, 30);
            this.btnExportFeedback.TabIndex = 4;
            this.btnExportFeedback.Text = "DELETE FEEDBACK";
            this.btnExportFeedback.UseVisualStyleBackColor = true;
            this.btnExportFeedback.Click += new System.EventHandler(this.btnExportFeedback_Click);
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(297, 426);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(220, 22);
            this.txtResponse.TabIndex = 7;
            this.txtResponse.TextChanged += new System.EventHandler(this.txtResponse_TextChanged);
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(20, 470);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(0, 16);
            this.lblResponse.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "FEEDBACK ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FacultyViewFeedback
            // 
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.btnExportFeedback);
            this.Controls.Add(this.dgvFeedback);
            this.Controls.Add(this.cbEventFilter);
            this.Controls.Add(this.lblTitle);
            this.Name = "FacultyViewFeedback";
            this.Text = "Event Feedback Form";
            this.Load += new System.EventHandler(this.FacultyViewFeedback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
    }
}
