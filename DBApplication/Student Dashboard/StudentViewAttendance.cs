﻿using System;
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
    public partial class StudentViewAttendance : Form
    {
        int userid;
        StudentController studentController=new StudentController();
        public StudentViewAttendance(Form parentForm,int uid)
        {
 
            InitializeComponent();
            Form ParentForm = parentForm;
            ParentForm.Hide();
            this.FormClosed += (sender, e) => { ParentForm.Show(); };
            userid= uid;
            dataGridView1.DataSource = studentController.ViewAttendance(userid);
            dataGridView1.Refresh();
        }
    }
}
