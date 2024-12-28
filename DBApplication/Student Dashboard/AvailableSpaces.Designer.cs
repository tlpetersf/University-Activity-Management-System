using System;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class AvailableSpaces : Form
    {
  

        private void InitializeComponent()
        {
            this.lblAvailableSpaces = new System.Windows.Forms.Label();
            this.dgvAvailableSpaces = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableSpaces)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAvailableSpaces
            // 
            this.lblAvailableSpaces.AutoSize = true;
            this.lblAvailableSpaces.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblAvailableSpaces.Location = new System.Drawing.Point(20, 20);
            this.lblAvailableSpaces.Name = "lblAvailableSpaces";
            this.lblAvailableSpaces.Size = new System.Drawing.Size(145, 19);
            this.lblAvailableSpaces.TabIndex = 0;
            this.lblAvailableSpaces.Text = "Available Spaces:";
            // 
            // dgvAvailableSpaces
            // 
            this.dgvAvailableSpaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableSpaces.Location = new System.Drawing.Point(20, 50);
            this.dgvAvailableSpaces.Name = "dgvAvailableSpaces";
            this.dgvAvailableSpaces.RowHeadersWidth = 51;
            this.dgvAvailableSpaces.Size = new System.Drawing.Size(600, 250);
            this.dgvAvailableSpaces.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Reserve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AvailableSpaces
            // 
            this.ClientSize = new System.Drawing.Size(650, 370);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvAvailableSpaces);
            this.Controls.Add(this.lblAvailableSpaces);
            this.Name = "AvailableSpaces";
            this.Text = "Available Spaces";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableSpaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label lblAvailableSpaces;
        private DataGridView dgvAvailableSpaces;
        private Button button1;
    }
}
