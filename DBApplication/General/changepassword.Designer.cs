namespace DBapplication
{
    partial class changepassword
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
            this.label2 = new System.Windows.Forms.Label();
            this.changepassbut = new System.Windows.Forms.Button();
            this.confnewtxt = new System.Windows.Forms.TextBox();
            this.newpasstxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.oldpasstxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "New password";
            // 
            // changepassbut
            // 
            this.changepassbut.Location = new System.Drawing.Point(229, 256);
            this.changepassbut.Name = "changepassbut";
            this.changepassbut.Size = new System.Drawing.Size(150, 35);
            this.changepassbut.TabIndex = 3;
            this.changepassbut.Text = "Update Password";
            this.changepassbut.UseVisualStyleBackColor = true;
            this.changepassbut.Click += new System.EventHandler(this.changepassbut_Click);
            // 
            // confnewtxt
            // 
            this.confnewtxt.Location = new System.Drawing.Point(215, 214);
            this.confnewtxt.Name = "confnewtxt";
            this.confnewtxt.Size = new System.Drawing.Size(100, 22);
            this.confnewtxt.TabIndex = 4;
            // 
            // newpasstxt
            // 
            this.newpasstxt.Location = new System.Drawing.Point(215, 160);
            this.newpasstxt.Name = "newpasstxt";
            this.newpasstxt.Size = new System.Drawing.Size(100, 22);
            this.newpasstxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirm new password";
            // 
            // oldpasstxt
            // 
            this.oldpasstxt.Location = new System.Drawing.Point(215, 99);
            this.oldpasstxt.Name = "oldpasstxt";
            this.oldpasstxt.Size = new System.Drawing.Size(100, 22);
            this.oldpasstxt.TabIndex = 7;
            this.oldpasstxt.TextChanged += new System.EventHandler(this.oldpasstxt_TextChanged);
            // 
            // changepassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 342);
            this.Controls.Add(this.oldpasstxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newpasstxt);
            this.Controls.Add(this.confnewtxt);
            this.Controls.Add(this.changepassbut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "changepassword";
            this.Text = "changepassword";
            this.Load += new System.EventHandler(this.changepassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button changepassbut;
        private System.Windows.Forms.TextBox confnewtxt;
        private System.Windows.Forms.TextBox newpasstxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oldpasstxt;
    }
}