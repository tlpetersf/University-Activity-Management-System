using System;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class userprofile : Form
    {
        private int currentID;
        Controller c = new Controller();
        ControllerAdmin controller = new ControllerAdmin();
        Form prevForm;

        public userprofile(int id, Form pf)
        {
            InitializeComponent();
            prevForm = pf;
            this.FormClosed += (s, e) => prevForm.Show();
            currentID = id;
            if (c.GetType(currentID) == "Student")
            {
                yeartxt.Visible = true;
                yearlbl.Visible = true;
            }
            else
            {
                yeartxt.Visible = false;
                yearlbl.Visible = false;
            }
        }

        private void userprofile_Load(object sender, EventArgs e)
        {
            LoadUserProfile();
        }

        private void LoadUserProfile()
        {
            DataTable userData = c.GetUserById(currentID);

            if (userData.Rows.Count > 0)
            {
                DataRow row = userData.Rows[0];

                if (row["FName"] != DBNull.Value)
                    firstnametxt.Text = row["FName"].ToString();

                if (row["LName"] != DBNull.Value)
                    lastnametxt.Text = row["LName"].ToString();

                if (row["Email"] != DBNull.Value)
                    emailtxt.Text = row["Email"].ToString();

                if (row["DepartmentID"] != DBNull.Value)
                    deptxt.Text = row["DepartmentID"].ToString();


                if (row["Type"].ToString() == "Student")
                {
                    if (row["Year"] != DBNull.Value)
                    {
                        int year = Convert.ToInt32(row["Year"]);
                        yearlbl.Visible = true;
                        yeartxt.Visible = true;
                        yeartxt.Text = year.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Error: User not found.");
            }
        }






        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = firstnametxt.Text;
            string lastName = lastnametxt.Text;
            string email = emailtxt.Text;
            string department = deptxt.Text;

            bool success = c.UpdateUserProfile(currentID, firstName, lastName, email, department);

            if (success)
            {
                MessageBox.Show("Profile updated successfully.");
            }
            else
            {
                MessageBox.Show("Error updating profile.");
            }
        }

        private void firstnametxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lastnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void yeartxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void emailtxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void deptxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void usertypebox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
