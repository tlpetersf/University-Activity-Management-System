namespace DBapplication
{
    partial class EditLocationsForm
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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtLocName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboBoxLocType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(144, 259);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(86, 22);
            this.dateTimePicker2.TabIndex = 46;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 206);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(86, 22);
            this.dateTimePicker1.TabIndex = 45;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(182, 145);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(79, 22);
            this.txtCapacity.TabIndex = 44;
            // 
            // txtLocName
            // 
            this.txtLocName.Location = new System.Drawing.Point(182, 52);
            this.txtLocName.Name = "txtLocName";
            this.txtLocName.Size = new System.Drawing.Size(175, 22);
            this.txtLocName.TabIndex = 43;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(284, 297);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(170, 32);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboBoxLocType
            // 
            this.comboBoxLocType.FormattingEnabled = true;
            this.comboBoxLocType.Location = new System.Drawing.Point(182, 94);
            this.comboBoxLocType.Name = "comboBoxLocType";
            this.comboBoxLocType.Size = new System.Drawing.Size(176, 24);
            this.comboBoxLocType.TabIndex = 41;
            this.comboBoxLocType.SelectedIndexChanged += new System.EventHandler(this.comboBoxLocType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Location Capacity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "End Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Start Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Location Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Location Name";
            // 
            // EditLocationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 380);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.txtLocName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboBoxLocType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditLocationsForm";
            this.Text = "EditLocationsForm";
            this.Load += new System.EventHandler(this.EditLocationsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtLocName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboBoxLocType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}