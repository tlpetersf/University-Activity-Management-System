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
    public partial class CreateClubForm : Form
    {
        Form prevForm;
        int UserID;
        ControllerAdmin controller = new ControllerAdmin();
        public CreateClubForm(Form pf, int userID)
        {
            prevForm = pf;
            InitializeComponent();
            this.FormClosed += (s, e) => prevForm.Show();
            UserID = userID;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "UserID";
            comboBox1.DataSource = controller.FacultyMembers();
        }

        private void txtClubTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClubDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSupervisor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtClubTitle.Text == "")
            {
                errorMessage += "Club Title cannot be empty.\n";
            }

            if (txtClubDescription.Text == "")
            {
                errorMessage += "Club Description cannot be empty.\n";
            }

            if (!(errorMessage == ""))
            {
                MessageBox.Show(errorMessage, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                controller.AddClub(txtClubTitle.Text, txtClubDescription.Text, Convert.ToInt32(comboBox1.SelectedValue));
                MessageBox.Show("Event Created Successfully");
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateClubForm_Load(object sender, EventArgs e)
        {

        }
    }
}
