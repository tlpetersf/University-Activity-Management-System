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
    public partial class ManageLocationsForm : Form
    {
        Form prevForm;
        int UserID;
        ControllerAdmin controller = new ControllerAdmin();
        public ManageLocationsForm(Form pf, int userID)
        {
            prevForm = pf;
            InitializeComponent();
            this.FormClosed += (s, e) => prevForm.Show();
            UserID = userID;
            dgvEvents.DataSource = controller.AllLocations();
        }

        private void buttEditLoc_Click(object sender, EventArgs e)
        {
            if (txtLocID.Text == "")
            {
                MessageBox.Show("Enter A Location ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!controller.DoesLocationExist(Convert.ToInt32(txtLocID.Text)))
            {
                MessageBox.Show("Location does not exist.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EditLocationsForm EditLocation = new EditLocationsForm(this, int.Parse(txtLocID.Text));
                EditLocation.Show();
                this.Hide();
            }
        }

        private void txtLocID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttDeleteEvent_Click(object sender, EventArgs e)
        {
            if (txtLocID.Text == "")
            {
                MessageBox.Show("Enter A Location ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!controller.DoesLocationExist(Convert.ToInt32(txtLocID.Text)))
            {
                MessageBox.Show("Location does not exist.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                controller.DeleteLocation(Convert.ToInt32(txtLocID.Text));
                MessageBox.Show("Location Deleted Successfully");
                dgvEvents.DataSource = controller.AllLocations();
            }
        }

        private void ManageLocationsForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvEvents.DataSource = controller.AllLocations();
        }
    }
}
