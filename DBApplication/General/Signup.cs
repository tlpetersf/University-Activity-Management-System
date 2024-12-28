using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBapplication
{
    public partial class Signup : Form
    {
        Controller c = new Controller();
        ControllerAdmin controller = new ControllerAdmin();

        public Signup()
        {
            InitializeComponent();

            // Populate the department combo box
            DataTable departmentTable = c.department();
            departmentcombo.DataSource = departmentTable;
            departmentcombo.DisplayMember = "Name";
            departmentcombo.ValueMember = "DepartmentID"; // Optional if you need a value

            // Populate the user type combo box
            DataTable userTypeTable = c.usertype();
            usertypebox.DataSource = userTypeTable;
            usertypebox.DisplayMember = "Type";
            usertypebox.ValueMember = "Type"; // Optional if you need a value


        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool validFirstName = true;
            bool validLastName = true;
            bool validEmail = true;
            bool validPassword = true;
            bool validConfirmPassword = true;

            string errorMessages = "";

            if (departmentcombo.Text == "Administration" || usertypebox.Text == "Admin")
            {
                errorMessages += "Department Administration or Admin are not valid selections.\n";
            }

            if (string.IsNullOrWhiteSpace(firstnamebox.Text))
            {
                errorMessages += "Enter a First Name\n";
                validFirstName = false;
            }
            else if (controller.IsInvalidName(firstnamebox.Text))
            {
                errorMessages += "Enter a valid First Name (no digits or special characters)\n";
                validFirstName = false;
            }

            if (string.IsNullOrWhiteSpace(lastnamebox.Text))
            {
                errorMessages += "Enter a Last Name\n";
                validLastName = false;
            }
            else if (controller.IsInvalidName(lastnamebox.Text))
            {
                errorMessages += "Enter a valid Last Name (no digits or special characters)\n";
                validLastName = false;
            }

            if (string.IsNullOrWhiteSpace(emailbox.Text))
            {
                errorMessages += "Enter an Email\n";
                validEmail = false;
            }
            else if (!controller.IsValidEmail(emailbox.Text))
            {
                errorMessages += "Enter a valid Email (e.g., example@domain.com)\n";
                validEmail = false;
            }

            if (string.IsNullOrWhiteSpace(passwordbox.Text))
            {
                errorMessages += "Enter a Password\n";
                validPassword = false;
            }
            else if (!controller.IsValidPassword(passwordbox.Text))
            {
                errorMessages += "Password must be at least 8 characters long and contain at least 1 uppercase letter, 1 lowercase letter, and 1 digit.\n";
                validPassword = false;
            }

            if (string.IsNullOrWhiteSpace(confirmpassbox.Text))
            {
                errorMessages += "Confirm your Password\n";
                validConfirmPassword = false;
            }
            else if (passwordbox.Text != confirmpassbox.Text)
            {
                errorMessages += "Passwords do not match\n";
                validConfirmPassword = false;
            }

            if (!(validFirstName && validLastName && validEmail && validPassword && validConfirmPassword) || !string.IsNullOrEmpty(errorMessages))
            {
                MessageBox.Show(errorMessages, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(yeartxt.Text, out int year))
            {
                MessageBox.Show("Please enter a valid year.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string hashedPassword = c.HashPassword(passwordbox.Text);
            string result = c.AddUser(
                firstnamebox.Text,
                lastnamebox.Text,
                emailbox.Text,
                Convert.ToInt16(departmentcombo.SelectedValue),
                hashedPassword,
                usertypebox.Text,
                year
            );

            if (result.Contains("successfully registered"))
            {
                MessageBox.Show(result, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login Log = new Login();
                Log.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(result, "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}