namespace DBapplication
{
    partial class CreateClubForm
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
            this.txtClubDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClubTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtClubDescription
            // 
            this.txtClubDescription.Location = new System.Drawing.Point(188, 119);
            this.txtClubDescription.Multiline = true;
            this.txtClubDescription.Name = "txtClubDescription";
            this.txtClubDescription.Size = new System.Drawing.Size(317, 74);
            this.txtClubDescription.TabIndex = 21;
            this.txtClubDescription.TextChanged += new System.EventHandler(this.txtClubDescription_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Club Description";
            // 
            // txtClubTitle
            // 
            this.txtClubTitle.Location = new System.Drawing.Point(188, 64);
            this.txtClubTitle.Name = "txtClubTitle";
            this.txtClubTitle.Size = new System.Drawing.Size(183, 22);
            this.txtClubTitle.TabIndex = 19;
            this.txtClubTitle.TextChanged += new System.EventHandler(this.txtClubTitle_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Club Title";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(544, 259);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(170, 32);
            this.btnCreate.TabIndex = 29;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Faculty Supervisor";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(188, 214);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 24);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CreateClubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 326);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtClubDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClubTitle);
            this.Controls.Add(this.label1);
            this.Name = "CreateClubForm";
            this.Text = "CreateClubForm";
            this.Load += new System.EventHandler(this.CreateClubForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClubDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClubTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}