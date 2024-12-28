namespace DBapplication
{
    partial class Signup
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
            this.firstnamebox = new System.Windows.Forms.TextBox();
            this.emailbox = new System.Windows.Forms.TextBox();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.confirmpassbox = new System.Windows.Forms.TextBox();
            this.departmentcombo = new System.Windows.Forms.ComboBox();
            this.usertypebox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lastnamebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yeartxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstnamebox
            // 
            this.firstnamebox.Location = new System.Drawing.Point(217, 50);
            this.firstnamebox.Name = "firstnamebox";
            this.firstnamebox.Size = new System.Drawing.Size(121, 22);
            this.firstnamebox.TabIndex = 0;
            this.firstnamebox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // emailbox
            // 
            this.emailbox.Location = new System.Drawing.Point(217, 117);
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(121, 22);
            this.emailbox.TabIndex = 1;
            // 
            // passwordbox
            // 
            this.passwordbox.Location = new System.Drawing.Point(217, 187);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(121, 22);
            this.passwordbox.TabIndex = 3;
            // 
            // confirmpassbox
            // 
            this.confirmpassbox.Location = new System.Drawing.Point(217, 226);
            this.confirmpassbox.Name = "confirmpassbox";
            this.confirmpassbox.Size = new System.Drawing.Size(121, 22);
            this.confirmpassbox.TabIndex = 4;
            // 
            // departmentcombo
            // 
            this.departmentcombo.FormattingEnabled = true;
            this.departmentcombo.Location = new System.Drawing.Point(217, 149);
            this.departmentcombo.Name = "departmentcombo";
            this.departmentcombo.Size = new System.Drawing.Size(121, 24);
            this.departmentcombo.TabIndex = 5;
            // 
            // usertypebox
            // 
            this.usertypebox.FormattingEnabled = true;
            this.usertypebox.Location = new System.Drawing.Point(217, 267);
            this.usertypebox.Name = "usertypebox";
            this.usertypebox.Size = new System.Drawing.Size(121, 24);
            this.usertypebox.TabIndex = 6;
            this.usertypebox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Create an Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Firstname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Confirm Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "User Type";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Department";
            // 
            // lastnamebox
            // 
            this.lastnamebox.Location = new System.Drawing.Point(217, 84);
            this.lastnamebox.Name = "lastnamebox";
            this.lastnamebox.Size = new System.Drawing.Size(121, 22);
            this.lastnamebox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Last name";
            // 
            // yeartxt
            // 
            this.yeartxt.Location = new System.Drawing.Point(217, 306);
            this.yeartxt.Name = "yeartxt";
            this.yeartxt.Size = new System.Drawing.Size(121, 22);
            this.yeartxt.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Year";
            this.label8.Click += new System.EventHandler(this.label6_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 393);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastnamebox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usertypebox);
            this.Controls.Add(this.departmentcombo);
            this.Controls.Add(this.confirmpassbox);
            this.Controls.Add(this.yeartxt);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.emailbox);
            this.Controls.Add(this.firstnamebox);
            this.Name = "Signup";
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstnamebox;
        private System.Windows.Forms.TextBox emailbox;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.TextBox confirmpassbox;
        private System.Windows.Forms.ComboBox departmentcombo;
        private System.Windows.Forms.ComboBox usertypebox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lastnamebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yeartxt;
        private System.Windows.Forms.Label label8;
    }
}