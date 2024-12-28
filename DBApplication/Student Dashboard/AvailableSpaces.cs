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
    public partial class AvailableSpaces : Form
    {
        StudentController studentController = new StudentController();
        int userid ;

        public AvailableSpaces(Form parentForm,int uid)
        {
            userid = uid;
            InitializeComponent();
            DataTable dt = studentController.GetAvailableSpacesForReservation();
            dgvAvailableSpaces.Rows.Clear();
            dgvAvailableSpaces.DataSource = dt;
            Form ParentForm = parentForm;
            ParentForm.Hide();
            this.FormClosed += (sender, e) => { ParentForm.Show(); };
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ReserveLocationForm frm = new ReserveLocationForm(this, userid);
            frm.Show();
        }
    }
}
