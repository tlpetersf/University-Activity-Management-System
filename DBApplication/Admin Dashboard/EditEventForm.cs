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
    public partial class EditEventForm : Form
    {
        Form prevForm;
        int EventID;
        ControllerAdmin controller = new ControllerAdmin();
        public EditEventForm(Form pf,int eventid)
        {
            prevForm = pf;
            EventID = eventid;
            InitializeComponent();
            this.FormClosed += (s, e) => prevForm.Show();
            LoadEventDetails();
        }
        private void LoadEventDetails()
        {
            DataTable eventDetails = controller.GetEventDetails(EventID);

            DataRow row = eventDetails.Rows[0];
            txtEventTitle.Text = row["Title"].ToString();
            txtEventDescription.Text = row["Description"].ToString();
            StartdateTimePicker.Value = Convert.ToDateTime(row["StartDate"]);
            EnddateTimePicker2.Value = Convert.ToDateTime(row["EndDate"]);

            comboBoxEventCat.DisplayMember = "CategoryType";
            comboBoxEventCat.ValueMember = "CategoryID";
            comboBoxEventCat.DataSource = controller.EventCategory();
            comboBoxEventCat.SelectedValue = Convert.ToInt32(row["EventCategory"]);

            comboBoxLocation.DisplayMember = "LocName";
            comboBoxLocation.ValueMember = "LocationID";
            comboBoxLocation.DataSource = controller.Locations();
            comboBoxLocation.SelectedValue = Convert.ToInt32(row["LocationID"]);
        }

        private void EditEventForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtEventTitle.Text == "")
            {
                errorMessage += "Event Title cannot be empty.\n";
            }

            if (txtEventDescription.Text == "")
            {
                errorMessage += "Event Description cannot be empty.\n";
            }

            if (!(errorMessage == ""))
            {
                MessageBox.Show(errorMessage, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToDateTime(StartdateTimePicker.Text) > Convert.ToDateTime(EnddateTimePicker2.Text))
            {
                MessageBox.Show("Start Date cannot be after End Date.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (errorMessage == "")
            {
                controller.EditEvent(EventID,txtEventTitle.Text, txtEventDescription.Text, Convert.ToDateTime(StartdateTimePicker.Text), Convert.ToDateTime(EnddateTimePicker2.Text), Convert.ToInt32(comboBoxEventCat.SelectedValue), Convert.ToInt32(comboBoxLocation.SelectedValue));
                MessageBox.Show("Event Edited Successfully");
                this.Close();
            }
        }

        private void ComboboxCreatedBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEventCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
