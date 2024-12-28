using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class RegisteredEventsForm : Form
    {
        StudentController studentController = new StudentController();
        int userid ;
        public RegisteredEventsForm(Form parentForm, int uid)
        {
            userid = uid;
            InitializeComponent();

            Form ParentForm = parentForm;
            ParentForm.Hide();
            this.FormClosed += (sender, e) => { ParentForm.Show(); };
            dgvRegisteredEvents.DataSource = studentController.GetRegisteredEvents(userid);
        }

        private void btCanReg_Click(object sender, EventArgs e)
        {
            int regId;
            if (int.TryParse(tbRegId.Text, out regId))
            {
                try
                {
                    bool success = studentController.CancelEventRegisteration(regId,userid);
                    if (success)
                    {
                        MessageBox.Show("Successfully Cancelled the Event Registeration!",
                                      "Success",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                        dgvRegisteredEvents.DataSource = studentController.GetRegisteredEvents(userid);



                    }
                    else
                    {
                        MessageBox.Show("Registeration ID Not Found!",
                                      "Operation failed",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Cancelling Event Registeration: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Registeration ID!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}