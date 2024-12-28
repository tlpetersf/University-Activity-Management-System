namespace DBapplication
{
    partial class EditEventForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxEventCat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EnddateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.StartdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEventDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEventTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(621, 411);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 32);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Location = new System.Drawing.Point(189, 330);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(176, 24);
            this.comboBoxLocation.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Location";
            // 
            // comboBoxEventCat
            // 
            this.comboBoxEventCat.FormattingEnabled = true;
            this.comboBoxEventCat.Location = new System.Drawing.Point(189, 275);
            this.comboBoxEventCat.Name = "comboBoxEventCat";
            this.comboBoxEventCat.Size = new System.Drawing.Size(176, 24);
            this.comboBoxEventCat.TabIndex = 23;
            this.comboBoxEventCat.SelectedIndexChanged += new System.EventHandler(this.comboBoxEventCat_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Event Category";
            // 
            // EnddateTimePicker2
            // 
            this.EnddateTimePicker2.Location = new System.Drawing.Point(459, 213);
            this.EnddateTimePicker2.Name = "EnddateTimePicker2";
            this.EnddateTimePicker2.Size = new System.Drawing.Size(226, 22);
            this.EnddateTimePicker2.TabIndex = 21;
            // 
            // StartdateTimePicker
            // 
            this.StartdateTimePicker.Location = new System.Drawing.Point(139, 213);
            this.StartdateTimePicker.Name = "StartdateTimePicker";
            this.StartdateTimePicker.Size = new System.Drawing.Size(226, 22);
            this.StartdateTimePicker.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "End Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Start Date";
            // 
            // txtEventDescription
            // 
            this.txtEventDescription.Location = new System.Drawing.Point(182, 95);
            this.txtEventDescription.Multiline = true;
            this.txtEventDescription.Name = "txtEventDescription";
            this.txtEventDescription.Size = new System.Drawing.Size(317, 74);
            this.txtEventDescription.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Event Description";
            // 
            // txtEventTitle
            // 
            this.txtEventTitle.Location = new System.Drawing.Point(182, 40);
            this.txtEventTitle.Name = "txtEventTitle";
            this.txtEventTitle.Size = new System.Drawing.Size(183, 22);
            this.txtEventTitle.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Event Title";
            // 
            // EditEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 488);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboBoxLocation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxEventCat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EnddateTimePicker2);
            this.Controls.Add(this.StartdateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEventDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEventTitle);
            this.Controls.Add(this.label1);
            this.Name = "EditEventForm";
            this.Text = "EditEventForm";
            this.Load += new System.EventHandler(this.EditEventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxEventCat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker EnddateTimePicker2;
        private System.Windows.Forms.DateTimePicker StartdateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEventDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEventTitle;
        private System.Windows.Forms.Label label1;
    }
}