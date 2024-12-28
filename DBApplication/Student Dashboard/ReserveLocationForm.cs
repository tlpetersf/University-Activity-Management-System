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
    public partial class ReserveLocationForm : Form
    {

        StudentController studentController=new StudentController();
        int userid ;

        public ReserveLocationForm(Form parentForm,int uid)
        {
            userid = uid;
            InitializeComponent();
            Form ParentForm = parentForm;

            ParentForm.Hide();

            this.FormClosed += (sender, e) => { ParentForm.Show(); };
                DataTable locations = studentController.GetAvailableSpacesForReservation();
            cmbLocation.DisplayMember = "LocName";
            cmbLocation.ValueMember = "LocationID";
            cmbLocation.DataSource = locations;
            cmbLocation.Refresh();
            SetupTimePickers();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = studentController.ReserveLocation(userid, (int)cmbLocation.SelectedValue, dtpStartTime.Value.ToString("HH:mm:ss"), dtpEndTime.Value.ToString("HH:mm:ss"));

                if (success)
                {
                    MessageBox.Show("Space reserved successfully!",
                                  "Success",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                    // Optionally refresh your reservations display here
                }
                else
                {
                    MessageBox.Show("Unable to reserve space. The space is either already reserved for this time or the time is outside location hours.",
                                  "Reservation Failed",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error making reservation: " + ex.Message);
            }

        }
        private void SetupTimePickers()
        {
            // Set the Format to Time to show only time
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.CustomFormat = "HH:mm"; // Show only hour and minute

            dtpEndTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.CustomFormat = "HH:mm"; // Show only hour and minute

            // Optional: Enable the ShowUpDown property to display the spinner buttons
            dtpStartTime.ShowUpDown = true;
            dtpEndTime.ShowUpDown = true;
        }

        private void dtpStartTime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
