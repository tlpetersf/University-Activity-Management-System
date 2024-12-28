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
    public partial class UpcomingEventsForm : Form
    {
        StudentController studentController=new StudentController();

        int userid;
        public UpcomingEventsForm(Form parentForm,int uid)
        {
            userid=uid;
            InitializeComponent();

            Form ParentForm = parentForm;
            ParentForm.Hide();
            this.FormClosed += (sender, e) => { ParentForm.Show(); };
            dgvUpcomingEvents.DataSource = studentController.GetUpcomingEvents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EventRegister eventRegister = new EventRegister(this, userid);
            eventRegister.Show();
        }
    }
}
