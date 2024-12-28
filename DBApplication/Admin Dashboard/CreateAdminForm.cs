using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DBapplication
{
    public partial class CreateAdminForm : Form
    {
        ControllerAdmin controller = new ControllerAdmin();
        Controller c = new Controller();
        Form prevForm;
        int UserID;
        public CreateAdminForm(Form pf, int userID)
        {
            prevForm = pf;
            InitializeComponent();
            this.FormClosed += (s, e) => prevForm.Show();
            UserID = userID;
        }

        private void CreateAdminForm_Load(object sender, EventArgs e)
        {

        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool validfirstname = true;
            bool validlastname = true;
            bool validemail = true;
            bool validpass = true;

            string errorMessages = "";

            if (txtFName.Text == "")
            {
                errorMessages += "Enter a First Name\n";
                validfirstname = false;
            }
            else if (controller.IsInvalidName(txtFName.Text))
            {
                errorMessages += "Enter a valid First Name (no digits or special characters)\n";
                validfirstname = false;
            }

            if (txtLName.Text == "")
            {
                errorMessages += "Enter a Last Name\n";
                validlastname = false;
            }
            else if (controller.IsInvalidName(txtLName.Text))
            {
                errorMessages += "Enter a valid Last Name (no digits or special characters)\n";
                validlastname = false;
            }

            if (txtEmail.Text == "")
            {
                errorMessages += "Enter an Email\n";
                validemail = false;
            }
            else if (!controller.IsValidEmail(txtEmail.Text))
            {
                errorMessages += "Enter a valid Email (e.g., example@domain.com)\n";
                validemail = false;
            }

            if (txtPass.Text == "")
            {
                errorMessages += "Enter a Password\n";
                validpass = false;
            }
            else if (!controller.IsValidPassword(txtPass.Text))
            {
                errorMessages += "Password must be at least 8 characters long and contain at least 1 uppercase letter, 1 lowercase letter, and 1 digit.\n";
                validpass = false;
            }

            if (!(validfirstname && validlastname && validemail && validpass))
            {
                MessageBox.Show(errorMessages, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string hashedPassword = c.HashPassword(txtPass.Text);

            controller.AddAdmin(txtFName.Text,txtLName.Text ,hashedPassword ,txtEmail.Text );
            MessageBox.Show("Admin created successfully!");
            this.Close();
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
