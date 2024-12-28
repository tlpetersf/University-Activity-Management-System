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
    public partial class ViewUsersForm : Form
    {
        ControllerAdmin controller = new ControllerAdmin();
        Controller c=new Controller();
        Form prevForm;
        int UserID;
        public ViewUsersForm(Form pf, int userID)
        {
            prevForm = pf;
            InitializeComponent();
            this.FormClosed += (s, e) => prevForm.Show();
            dgvUsers.DataSource = controller.AllUsers();
            UserID = userID;
        }

        private void ViewUsersForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttDelete_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == "") {
                MessageBox.Show("Enter A User ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!controller.DoesUserExist(Convert.ToInt32(txtUserID.Text))){
                MessageBox.Show("User does not exist.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(Convert.ToInt32(txtUserID.Text) ==UserID)
            {
                MessageBox.Show("You Can't Delete Yourself", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                controller.DeleteUser(Convert.ToInt32(txtUserID.Text));
                MessageBox.Show("User Deleted Successfully");
                dgvUsers.DataSource = controller.AllUsers();
            }

        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttResetPass_Click(object sender, EventArgs e)
        {
            string newpassword;
            if (txtUserID.Text == "")
            {
                MessageBox.Show("Enter A User ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!controller.DoesUserExist(Convert.ToInt32(txtUserID.Text))){
                MessageBox.Show("User does not exist.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                newpassword = controller.UpdateUserPassword(Convert.ToInt32(txtUserID.Text));
                MessageBox.Show("New Password: "+newpassword);
                dgvUsers.DataSource = controller.AllUsers();
            }
        }
    }
}
