namespace DBapplication
{
    partial class CreateEventForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEventTitle = new System.Windows.Forms.TextBox();
            this.txtEventDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StartdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EnddateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEventCat = new System.Windows.Forms.ComboBox();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Title";
            // 
            // txtEventTitle
            // 
            this.txtEventTitle.Location = new System.Drawing.Point(193, 53);
            this.txtEventTitle.Name = "txtEventTitle";
            this.txtEventTitle.Size = new System.Drawing.Size(183, 22);
            this.txtEventTitle.TabIndex = 1;
            this.txtEventTitle.TextChanged += new System.EventHandler(this.txtEventTitle_TextChanged);
            // 
            // txtEventDescription
            // 
            this.txtEventDescription.Location = new System.Drawing.Point(193, 108);
            this.txtEventDescription.Multiline = true;
            this.txtEventDescription.Name = "txtEventDescription";
            this.txtEventDescription.Size = new System.Drawing.Size(317, 74);
            this.txtEventDescription.TabIndex = 3;
            this.txtEventDescription.TextChanged += new System.EventHandler(this.txtEventDescription_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Event Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "End Date";
            // 
            // StartdateTimePicker
            // 
            this.StartdateTimePicker.Location = new System.Drawing.Point(150, 226);
            this.StartdateTimePicker.Name = "StartdateTimePicker";
            this.StartdateTimePicker.Size = new System.Drawing.Size(226, 22);
            this.StartdateTimePicker.TabIndex = 6;
            this.StartdateTimePicker.ValueChanged += new System.EventHandler(this.StartdateTimePicker_ValueChanged);
            // 
            // EnddateTimePicker2
            // 
            this.EnddateTimePicker2.Location = new System.Drawing.Point(470, 226);
            this.EnddateTimePicker2.Name = "EnddateTimePicker2";
            this.EnddateTimePicker2.Size = new System.Drawing.Size(226, 22);
            this.EnddateTimePicker2.TabIndex = 7;
            this.EnddateTimePicker2.ValueChanged += new System.EventHandler(this.EnddateTimePicker2_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Event Category";
            // 
            // comboBoxEventCat
            // 
            this.comboBoxEventCat.FormattingEnabled = true;
            this.comboBoxEventCat.Location = new System.Drawing.Point(200, 288);
            this.comboBoxEventCat.Name = "comboBoxEventCat";
            this.comboBoxEventCat.Size = new System.Drawing.Size(176, 24);
            this.comboBoxEventCat.TabIndex = 9;
            this.comboBoxEventCat.SelectedIndexChanged += new System.EventHandler(this.comboBoxEventCat_SelectedIndexChanged);
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Location = new System.Drawing.Point(200, 343);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(176, 24);
            this.comboBoxLocation.TabIndex = 11;
            this.comboBoxLocation.SelectedIndexChanged += new System.EventHandler(this.comboBoxLocation_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Location";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(631, 381);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(170, 32);
            this.btnCreate.TabIndex = 13;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // CreateEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 442);
            this.Controls.Add(this.btnCreate);
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
            this.Name = "CreateEventForm";
            this.Text = "CreateEventForm";
            this.Load += new System.EventHandler(this.CreateEventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEventTitle;
        private System.Windows.Forms.TextBox txtEventDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker StartdateTimePicker;
        private System.Windows.Forms.DateTimePicker EnddateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxEventCat;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCreate;
    }
}