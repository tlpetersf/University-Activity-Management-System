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
    public partial class ManageClubsForm : Form
    {
        Form prevForm;
        int UserID;
        ControllerAdmin controller = new ControllerAdmin();
        public ManageClubsForm(Form pf, int userID)
        {
            prevForm = pf;
            InitializeComponent();
            this.FormClosed += (s, e) => prevForm.Show();
            UserID = userID;
            dgvEvents.DataSource = controller.Clubs();
        }

        private void buttEditEvent_Click(object sender, EventArgs e)
        {
            if (txtClubID.Text == "")
            {
                MessageBox.Show("Enter A Club ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!controller.DoesClubExist(Convert.ToInt32(txtClubID.Text)))
            {
                MessageBox.Show("Club does not exist.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ClubDetailsForm ClubDetails = new ClubDetailsForm(this, int.Parse(txtClubID.Text));
                ClubDetails.Show();
                this.Hide();
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
            if (txtClubID.Text == "")
            {
                MessageBox.Show("Enter A Club ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!controller.DoesClubExist(Convert.ToInt32(txtClubID.Text)))
            {
                MessageBox.Show("Club does not exist.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                controller.DeleteClub(Convert.ToInt32(txtClubID.Text));
                MessageBox.Show("Club Deleted Successfully");
                dgvEvents.DataSource = controller.Clubs();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvEvents.DataSource = controller.Clubs();
        }
    }
}
