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
    public partial class ManageEventsForm : Form
    {
        ControllerAdmin controller = new ControllerAdmin();
        private Controller c = new Controller();
        Form prevForm;
        int UserID;
        string UserType;
        public ManageEventsForm(Form pf, int userID)
        {
            prevForm = pf;
            InitializeComponent();
            this.FormClosed += (s, e) => prevForm.Show();
            UserID = userID;
            if(c.GetType(UserID) == "Admin")
            {
                UserType = "Admin";
                dgvEvents.DataSource = controller.Events();
            }
            else if(c.GetType(UserID) =="Faculty Member")
            {
                UserType = "Faculty Member";
                dgvEvents.DataSource = controller.EventsCreatedby(UserID);
            }
        }

        private void buttEditEvent_Click(object sender, EventArgs e)
        {
            if (txtEventID.Text == "")
            {
                MessageBox.Show("Enter A Event ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!controller.DoesEventExist(Convert.ToInt32(txtEventID.Text)))
            {
                MessageBox.Show("Event does not exist.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(UserType=="Admin")
            {
                EditEventForm EditEvent = new EditEventForm(this, int.Parse(txtEventID.Text));
                EditEvent.Show();
                this.Hide();
            }else if(UserType=="Faculty Member")
            {
                if (controller.CheckEvent(Convert.ToInt32(txtEventID.Text),UserID))
                {
                    EditEventForm EditEvent = new EditEventForm(this, int.Parse(txtEventID.Text));
                    EditEvent.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Choose An ID of an Event that you Created", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtEventID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttDeleteEvent_Click(object sender, EventArgs e)
        {
            if (txtEventID.Text == "")
            {
                MessageBox.Show("Enter A Event ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!controller.DoesEventExist(Convert.ToInt32(txtEventID.Text)))
            {
                MessageBox.Show("Event does not exist.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (c.GetType(UserID) == "Admin")
            {
                controller.DeleteEvent(Convert.ToInt32(txtEventID.Text));
                MessageBox.Show("Event Deleted Successfully");
                dgvEvents.DataSource = controller.Events();
            }
            else if(c.GetType(UserID)=="Faculty Member")
            {
                if (controller.CheckEvent(Convert.ToInt32(txtEventID.Text), UserID))
                {
                    controller.DeleteEvent(Convert.ToInt32(txtEventID.Text));
                    MessageBox.Show("Event Deleted Successfully");
                    dgvEvents.DataSource = controller.EventsCreatedby(UserID);
                }
                else
                {
                    MessageBox.Show("Choose An ID of an Event that you Created", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ManageEventsForm_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (UserType == "Admin")
            {
                dgvEvents.DataSource = controller.Events();
            }
            else if (UserType == "Faculty Member")
            {
                dgvEvents.DataSource = controller.EventsCreatedby(UserID);
            }
        }
    }
}
