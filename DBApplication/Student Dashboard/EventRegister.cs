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
    public partial class EventRegister : Form
    {
        StudentController studentController=new StudentController();
        int userid ;

        public EventRegister(Form parentForm,int uid)
        {
            userid = uid;
            InitializeComponent();
            Form ParentForm = parentForm;
            ParentForm.Hide();
            this.FormClosed += (sender, e) => { ParentForm.Show(); };
            cmbEvents.DataSource = studentController.GetUpcomingEvents();
            cmbEvents.DisplayMember ="Title";
            cmbEvents.ValueMember = "EventID";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
          int selectedEventID=(int)cmbEvents.SelectedValue;
            try
            {
                bool success = studentController.RegisterStudentInEvent(userid, selectedEventID);
                if (success)
                {
                    MessageBox.Show("Successfully registered for the event!",
                                  "Success",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                   
                }
                else
                {
                    MessageBox.Show("You are already registered for this event!",
                                  "Registration Failed",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error registering for event: " + ex.Message);
            }
        }
    }
}
