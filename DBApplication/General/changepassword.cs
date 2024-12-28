using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DBapplication
{
    public partial class changepassword : Form
    {
        Controller c;
        ControllerAdmin controller = new ControllerAdmin();

        private int currentid;
        Form prevForm;
        public changepassword(int X, Form pf)
        {
            prevForm = pf;
            InitializeComponent();
            this.FormClosed += (s, e) => prevForm.Show();
            c = new Controller();
            currentid = X;
            newpasstxt.PasswordChar = '*';
            confnewtxt.PasswordChar = '*';
        }


        private void changepassword_Load(object sender, EventArgs e)
        {

        }

        private void changepassbut_Click(object sender, EventArgs e)
        {
            string oldPassword = oldpasstxt.Text;
            string newPassword = newpasstxt.Text;
            string confirmNewPassword = confnewtxt.Text;
            string errorMessages = "";

            // Validate inputs
            if (string.IsNullOrEmpty(oldPassword))
            {
                errorMessages += "Enter your Old Password\n";
            }

            if (string.IsNullOrEmpty(newPassword))
            {
                errorMessages += "Enter a New Password\n";
            }

            if (string.IsNullOrEmpty(confirmNewPassword))
            {
                errorMessages += "Confirm your New Password\n";
            }

            if (newPassword != confirmNewPassword)
            {
                errorMessages += "New password and Confirm password do not match\n";
            }else if (!controller.IsValidPassword(newPassword) && !string.IsNullOrEmpty(newPassword) && !string.IsNullOrEmpty(confirmNewPassword))
            {
                errorMessages += "Password must be at least 8 characters long and include an uppercase letter, a number, and a digit\n";
            }

            // If there are validation errors, show them and return
            if (!string.IsNullOrEmpty(errorMessages))
            {
                MessageBox.Show(errorMessages, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string hashedNewPassword = c.HashPassword(newPassword);
            string hashedOldPassword = c.HashPassword(oldPassword);

            // Call the method to change the password
            string result = c.ChangePassword(currentid, hashedOldPassword, hashedNewPassword);

            // Show the result of the password change operation
            MessageBox.Show(result);
            this.Close();
        }
        private void oldpasstxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}