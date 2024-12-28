using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBapplication
{
    public partial class EditLocationsForm : Form
    {
        Form prevForm;
        int LocationID;
        ControllerAdmin controller = new ControllerAdmin();
        public EditLocationsForm(Form pf, int id)
        {
            prevForm = pf;
            LocationID = id;
            InitializeComponent();
            this.FormClosed += (s, e) => prevForm.Show();
            SetupTimePickers();
            LoadLocationDetails();
        }
        private void SetupTimePickers()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "HH:mm"; 
            dateTimePicker1.ShowUpDown = true;

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.ShowUpDown = true;
        }

        private void LoadLocationDetails()
        {
            DataTable locationDetails = controller.GetLocationDetails(LocationID);

            if (locationDetails.Rows.Count > 0)
            {
                DataRow row = locationDetails.Rows[0];

                txtLocName.Text = row["LocName"].ToString();
                txtCapacity.Text = row["Capacity"].ToString();

                comboBoxLocType.DataSource = controller.LocationTypes();
                comboBoxLocType.DisplayMember = "LocationType";
                comboBoxLocType.ValueMember = "TypeID";
                comboBoxLocType.SelectedValue = row["TypeID"];

                dateTimePicker1.Value = DateTime.Parse(row["StartTime"].ToString());
                dateTimePicker2.Value = DateTime.Parse(row["EndTime"].ToString());
            }
        }
        private void EditLocationsForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxLocType_SelectedIndexChanged(object sender, EventArgs e)
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
            }
            else if (Convert.ToInt32(txtCapacity.Text) > 1000)
            {
                errorMessage += "Location Capacity is too much.\n";
            }

            if (!(errorMessage == ""))
            {
                MessageBox.Show(errorMessage, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("Start Time cannot be after End Time.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            controller.UpdateLocation(LocationID, txtLocName.Text, Convert.ToInt32(txtCapacity.Text),
                Convert.ToInt32(comboBoxLocType.SelectedValue), dateTimePicker1.Value.ToString("HH:mm:ss"),
                dateTimePicker2.Value.ToString("HH:mm:ss"));
                MessageBox.Show("Location updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
        }
    }
}
