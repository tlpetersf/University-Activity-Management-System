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
    public partial class ReservationHistoryForm : Form
    {
        StudentController studentController = new StudentController();
        int userid ;


        // Flag to track if the DataGridView needs refreshing

        public ReservationHistoryForm(Form parentForm, int uid)
        {
            userid = uid;  
            InitializeComponent();
            Form ParentForm = parentForm;
            ParentForm.Hide();
            this.FormClosed += (sender, e) => { ParentForm.Show(); };

            LoadReservationHistory();

        }

        private void LoadReservationHistory()
        {
            dgvReservationHistory.DataSource = null;
            dgvReservationHistory.DataSource = studentController.GetReservationHistoryForStudent(userid);
        }

        private void btCancelRes_Click(object sender, EventArgs e)
        {
            int resId;
            if (int.TryParse(tbResID.Text, out resId))
            {
                try
                {
                    bool success = studentController.CancelReservation(resId, userid);
                    if (success)
                    {
                        MessageBox.Show("Successfully Cancelled the Reservation!",
                                      "Success",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                        dgvReservationHistory.DataSource = studentController.GetReservationHistoryForStudent(userid);


                    }
                    else
                    {
                        MessageBox.Show("Reservation Not Found!",
                                      "Operation failed",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Cancelling Reservation: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Reservation ID!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
