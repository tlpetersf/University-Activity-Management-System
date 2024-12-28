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
    public partial class AddLocationForm : Form
    {
        Form prevForm;
        int UserID;
        ControllerAdmin controller = new ControllerAdmin();
        public AddLocationForm(Form pf, int userID)
        {
            prevForm = pf;
            InitializeComponent();
            this.FormClosed += (s, e) => prevForm.Show();
            UserID = userID;
            SetupTimePickers();
            comboBoxLocType.DisplayMember = "LocationType";
            comboBoxLocType.ValueMember = "TypeID";
            comboBoxLocType.DataSource = controller.LocationTypes();
        }

        private void StartdateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddLocationForm_Load(object sender, EventArgs e)
        {

        }
        private void SetupTimePickers()
        {
            // Set the Format to Time to show only time
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "HH:mm"; // Show only hour and minute

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "HH:mm"; // Show only hour and minute

            // Optional: Enable the ShowUpDown property to display the spinner buttons
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker2.ShowUpDown = true;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtLocName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxLocType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCapacity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtLocName.Text == "")
            {
                errorMessage += "Location Name cannot be empty.\n";
            }

            if (txtCapacity.Text == "")
            {
                errorMessage += "Location Capacity cannot be empty.\n";
            }else if (Convert.ToInt32(txtCapacity.Text)> 1000)
            {
                errorMessage += "Location Capacity is too much.\n";
            }
            if (!(errorMessage == ""))
            {
                MessageBox.Show(errorMessage, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToDateTime(dateTimePicker1.Text) > Convert.ToDateTime(dateTimePicker2.Text))
            {
                MessageBox.Show("Start Time cannot be after End Time.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (errorMessage == "")
            {
                controller.AddLocation(txtLocName.Text, Convert.ToInt32(txtCapacity.Text), Convert.ToString(comboBoxLocType.SelectedValue), dateTimePicker1.Value.ToString("HH:mm:ss"), dateTimePicker2.Value.ToString("HH:mm:ss"));
                MessageBox.Show("Location Created Successfully");
                this.Close();
            }
        }
    }
}
