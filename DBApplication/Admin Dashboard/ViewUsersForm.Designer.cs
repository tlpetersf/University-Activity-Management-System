namespace DBapplication
{
    partial class ViewUsersForm
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttResetPass = new System.Windows.Forms.Button();
            this.buttDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(37, 23);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(652, 193);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select User";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(125, 299);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(208, 22);
            this.txtUserID.TabIndex = 2;
            this.txtUserID.TextChanged += new System.EventHandler(this.txtUserID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "User ID";
            // 
            // buttResetPass
            // 
            this.buttResetPass.Location = new System.Drawing.Point(377, 356);
            this.buttResetPass.Name = "buttResetPass";
            this.buttResetPass.Size = new System.Drawing.Size(138, 27);
            this.buttResetPass.TabIndex = 4;
            this.buttResetPass.Text = "Reset Password";
            this.buttResetPass.UseVisualStyleBackColor = true;
            this.buttResetPass.Click += new System.EventHandler(this.buttResetPass_Click);
            // 
            // buttDelete
            // 
            this.buttDelete.Location = new System.Drawing.Point(551, 356);
            this.buttDelete.Name = "buttDelete";
            this.buttDelete.Size = new System.Drawing.Size(138, 27);
            this.buttDelete.TabIndex = 5;
            this.buttDelete.Text = "Delete";
            this.buttDelete.UseVisualStyleBackColor = true;
            this.buttDelete.Click += new System.EventHandler(this.buttDelete_Click);
            // 
            // ViewUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.buttDelete);
            this.Controls.Add(this.buttResetPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUsers);
            this.Name = "ViewUsersForm";
            this.Text = "ViewUsersForm";
            this.Load += new System.EventHandler(this.ViewUsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttResetPass;
        private System.Windows.Forms.Button buttDelete;
    }
}