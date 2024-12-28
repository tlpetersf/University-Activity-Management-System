using System.Windows.Forms;

namespace DBapplication
{
    partial class AttendanceTrackerForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private ComboBox cbEventFilter;
        private DataGridView dgvEventDetails;
        private Button btnExport;

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
            this.dgvEventDetails = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(234, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Attendance Tracker";
            // 
            // cbEventFilter
            // 
            this.cbEventFilter.FormattingEnabled = true;
            this.cbEventFilter.Location = new System.Drawing.Point(127, 65);
            this.cbEventFilter.Name = "cbEventFilter";
            this.cbEventFilter.Size = new System.Drawing.Size(200, 24);
            this.cbEventFilter.TabIndex = 1;
            this.cbEventFilter.SelectedIndexChanged += new System.EventHandler(this.cbEventFilter_SelectedIndexChanged);
            // 
            // dgvEventDetails
            // 
            this.dgvEventDetails.AllowUserToAddRows = false;
            this.dgvEventDetails.AllowUserToDeleteRows = false;
            this.dgvEventDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventDetails.Location = new System.Drawing.Point(20, 100);
            this.dgvEventDetails.Name = "dgvEventDetails";
            this.dgvEventDetails.RowHeadersWidth = 51;
            this.dgvEventDetails.Size = new System.Drawing.Size(760, 300);
            this.dgvEventDetails.TabIndex = 5;
            this.dgvEventDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventDetails_CellContentClick);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(600, 420);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(180, 30);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Delete attendance";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(417, 426);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Event Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Attendance ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AttendanceTrackerForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dgvEventDetails);
            this.Controls.Add(this.cbEventFilter);
            this.Controls.Add(this.lblTitle);
            this.Name = "AttendanceTrackerForm";
            this.Text = "Attendance Tracker";
            this.Load += new System.EventHandler(this.AttendanceTrackerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox textBox1;
        private Label label1;
        private Label label2;
    }
}
