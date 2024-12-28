using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DBapplication
{
    public partial class Login : Form
    {
        private Controller C = new Controller();
        ControllerAdmin controller = new ControllerAdmin();
        private int currentid=-1;

        public Login()
        {
            InitializeComponent();
            passwordtxt.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool validemail = true;
            bool validpass = true;

            string errorMessages = "";
            if (usernametxt.Text == "")
            {
                errorMessages += "Enter an Email\n";
                validemail = false;
            }
            else if (!controller.IsValidEmail(usernametxt.Text))
            {
                errorMessages += "Enter a valid Email (e.g., example@domain.com)\n";
                validemail = false;
            }
            if (passwordtxt.Text == "")
            {
                errorMessages += "Enter a Password\n";
                validpass = false;
            }
            else if (!controller.IsValidPassword(passwordtxt.Text))
            {
                errorMessages += "Password must be at least 8 characters long and contain at least 1 uppercase letter, 1 lowercase letter, and 1 digit.\n";
                validpass = false;
            }
            if (!(validemail && validpass))
            {
                MessageBox.Show(errorMessages, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string hashedPassword = C.HashPassword(passwordtxt.Text);
            currentid = C.CheckEmailAndPassword(usernametxt.Text, hashedPassword);

            if (currentid !=-1)
            {
                string UserType=C.GetType(currentid);

                if (UserType == "Admin")
                {
                    AdminDashboardForm admindashboard = new AdminDashboardForm(currentid);
                    admindashboard.Show();
                    this.Hide();
                }
                else if (UserType == "Student")
                {
                    StudentDashboardForm Studentdashboard = new StudentDashboardForm(currentid);
                    Studentdashboard.Show();
                    this.Hide();
                }
                else if (UserType == "Faculty Member")
                {
                    FacultyMemberDashboardForm Facultydashboard = new FacultyMemberDashboardForm(currentid);
                    Facultydashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

    }
    private void button2_Click(object sender, EventArgs e)
        {
            // Open the Signup form
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Perform any initialization tasks here (if necessary)
        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
