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
    public partial class CreateEventForm : Form
    {
        ControllerAdmin controller = new ControllerAdmin();
        Form prevForm;
        int UserID;
        public CreateEventForm(Form pf, int userID)
        {
            prevForm = pf;
            UserID = userID;
            InitializeComponent();
            this.FormClosed += (s, e) => prevForm.Show();
            comboBoxEventCat.DisplayMember = "CategoryType";
            comboBoxEventCat.ValueMember = "CategoryID";
            comboBoxEventCat.DataSource = controller.EventCategory();
            comboBoxLocation.DisplayMember = "LocName";
            comboBoxLocation.ValueMember = "LocationID";
            comboBoxLocation.DataSource = controller.Locations();
        }

        private void CreateEventForm_Load(object sender, EventArgs e)
        {

        }

        private void txtEventTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEventDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartdateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EnddateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEventCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtEventTitle.Text =="")
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
            }else if(errorMessage == "")
                {
                    controller.AddEvent(txtEventTitle.Text,txtEventDescription.Text,Convert.ToDateTime(StartdateTimePicker.Text), Convert.ToDateTime(EnddateTimePicker2.Text), Convert.ToInt32(comboBoxEventCat.SelectedValue), Convert.ToInt32(comboBoxLocation.SelectedValue),UserID);
                    MessageBox.Show("Event Created Successfully");
                this.Close();
            }

        }

        }
    }
