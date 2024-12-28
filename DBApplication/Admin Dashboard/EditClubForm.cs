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
    public partial class EditClubForm : Form
    {
        Form prevForm;
        int ClubID;
        ControllerAdmin controller = new ControllerAdmin();
        public EditClubForm(Form pf, int id)
        {
            prevForm = pf;
            ClubID = id;
            InitializeComponent();
            this.FormClosed += (s, e) => prevForm.Show();
            LoadClubDetails();
        }
        private void LoadClubDetails()
        {
            DataTable ClubDetails = controller.GetClubDetails(ClubID);

            DataRow row = ClubDetails.Rows[0];
            txtClubTitle.Text = row["Name"].ToString();
            txtClubDescription.Text = row["Description"].ToString();

            comboBox1.DataSource = controller.FacultyMembers();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "UserID";
            comboBox1.SelectedValue = Convert.ToInt32(row["SupervisorID"]);
        }


        private void EditClubForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
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
                controller.EditClub(ClubID, txtClubTitle.Text, txtClubDescription.Text, Convert.ToInt32(comboBox1.SelectedValue));
                MessageBox.Show("Club Edited Successfully");
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
