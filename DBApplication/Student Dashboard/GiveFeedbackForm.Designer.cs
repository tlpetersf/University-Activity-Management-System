using System;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class GiveFeedbackForm : Form
    {
      

        private void InitializeComponent()
        {
            this.lblEventFeedback = new System.Windows.Forms.Label();
            this.grpEventFeedback = new System.Windows.Forms.GroupBox();
            this.cboEventSelection = new System.Windows.Forms.ComboBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.numRating = new System.Windows.Forms.NumericUpDown();
            this.lblComments = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.RichTextBox();
            this.btnSubmitFeedback = new System.Windows.Forms.Button();
            this.grpEventFeedback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEventFeedback
            // 
            this.lblEventFeedback.AutoSize = true;
            this.lblEventFeedback.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblEventFeedback.Location = new System.Drawing.Point(20, 20);
            this.lblEventFeedback.Name = "lblEventFeedback";
            this.lblEventFeedback.Size = new System.Drawing.Size(161, 24);
            this.lblEventFeedback.TabIndex = 0;
            this.lblEventFeedback.Text = "Event Feedback";
            // 
            // grpEventFeedback
            // 
            this.grpEventFeedback.Controls.Add(this.cboEventSelection);
            this.grpEventFeedback.Controls.Add(this.lblRating);
            this.grpEventFeedback.Controls.Add(this.numRating);
            this.grpEventFeedback.Controls.Add(this.lblComments);
            this.grpEventFeedback.Controls.Add(this.txtComments);
            this.grpEventFeedback.Controls.Add(this.btnSubmitFeedback);
            this.grpEventFeedback.Location = new System.Drawing.Point(20, 60);
            this.grpEventFeedback.Name = "grpEventFeedback";
            this.grpEventFeedback.Size = new System.Drawing.Size(600, 350);
            this.grpEventFeedback.TabIndex = 1;
            this.grpEventFeedback.TabStop = false;
            this.grpEventFeedback.Text = "Provide Feedback";
            // 
            // cboEventSelection
            // 
            this.cboEventSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEventSelection.FormattingEnabled = true;
            this.cboEventSelection.Location = new System.Drawing.Point(150, 30);
            this.cboEventSelection.Name = "cboEventSelection";
            this.cboEventSelection.Size = new System.Drawing.Size(200, 24);
            this.cboEventSelection.TabIndex = 0;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(30, 80);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(49, 16);
            this.lblRating.TabIndex = 1;
            this.lblRating.Text = "Rating:";
            // 
            // numRating
            // 
            this.numRating.Location = new System.Drawing.Point(150, 80);
            this.numRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRating.Name = "numRating";
            this.numRating.Size = new System.Drawing.Size(120, 22);
            this.numRating.TabIndex = 2;
            this.numRating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(30, 130);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(74, 16);
            this.lblComments.TabIndex = 3;
            this.lblComments.Text = "Comments:";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(150, 130);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(400, 150);
            this.txtComments.TabIndex = 4;
            this.txtComments.Text = "";
            // 
            // btnSubmitFeedback
            // 
            this.btnSubmitFeedback.Location = new System.Drawing.Point(150, 300);
            this.btnSubmitFeedback.Name = "btnSubmitFeedback";
            this.btnSubmitFeedback.Size = new System.Drawing.Size(150, 30);
            this.btnSubmitFeedback.TabIndex = 5;
            this.btnSubmitFeedback.Text = "Submit Feedback";
            this.btnSubmitFeedback.UseVisualStyleBackColor = true;
            this.btnSubmitFeedback.Click += new System.EventHandler(this.btnSubmitFeedback_Click);
            // 
            // EventFeedbackForm
            // 
            this.ClientSize = new System.Drawing.Size(640, 420);
            this.Controls.Add(this.grpEventFeedback);
            this.Controls.Add(this.lblEventFeedback);
            this.Name = "EventFeedbackForm";
            this.Text = "Event Feedback";
            this.grpEventFeedback.ResumeLayout(false);
            this.grpEventFeedback.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Declare controls as private members
        private Label lblEventFeedback;
        private GroupBox grpEventFeedback;
        private ComboBox cboEventSelection;
        private Label lblRating;
        private NumericUpDown numRating;
        private Label lblComments;
        private RichTextBox txtComments;
        private Button btnSubmitFeedback;
    }
}
