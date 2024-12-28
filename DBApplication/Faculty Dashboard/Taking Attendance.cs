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
    public partial class Taking_Attendance : Form
    {
        private FacultyMemberControler facultyController = new FacultyMemberControler();
        private Controller c = new Controller();
        Form prevForm;
        int userid;
        string UserType;
        public Taking_Attendance(Form pf, int usid)
        {
            userid=usid;
            prevForm = pf;
            InitializeComponent();

            this.FormClosed += (s, e) => prevForm.Show();

            if (c.GetType(userid) == "Admin")
            {
                UserType = "Admin";
            }
            else if (c.GetType(userid) == "Faculty Member")
            {
                UserType = "Faculty Member";
            }
            else if (UserType == "Student")
            {
                UserType = "Student";
            }
            eventnamebox.DisplayMember = "Title";
            eventnamebox.ValueMember = "EventID";
            eventnamebox.DataSource = facultyController.GetEventData(userid, UserType);
          //  facultyController.PopulateEventNames(eventnamebox,userid);
        }

        private void eventnamebox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int studentId;
            if (int.TryParse(studentidbox.Text, out studentId))
            {
                int eventId = facultyController.GetEventIDByName(Convert.ToInt32(eventnamebox.SelectedValue));

                if (eventId != -1)
                {

                    string checkInTime = textBox1.Text.Trim();

                    DateTime parsedTime;
                    if (DateTime.TryParse(checkInTime, out parsedTime))
                    {

                        bool isSuccess = facultyController.RecordAttendance(studentId, eventId, checkInTime);

                        if (isSuccess)
                        {
                            MessageBox.Show("Attendance marked successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to mark attendance.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid check-in time in the format: HH:mm:ss");
                    }
                }
                else
                {
                    MessageBox.Show("Event not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid student ID.");
            }
        }

        private void Taking_Attendance_Load(object sender, EventArgs e)
        {

        }
    }
}