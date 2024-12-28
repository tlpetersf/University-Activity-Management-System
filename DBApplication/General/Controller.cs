using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }
         public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }

        public int CheckEmailAndPassword(string email, string password)
        {

            string query = $@"SELECT UserID FROM Users WHERE Email = '{email}' AND Password = '{password}';";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }
        public string GetType(int id)
        {

            string query = $@"SELECT Type FROM Users WHERE UserID = '{id}';";
            return Convert.ToString(dbMan.ExecuteScalar(query));
        }

        private bool IsPasswordCorrect(int id, string password)
        {
            string query = $@"SELECT COUNT(*) FROM Users WHERE UserID = '{id}' AND Password = '{password}'";

            DataTable dt = dbMan.ExecuteReader(query);
            return dt != null && dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0;
        }
        public string AddUser(string firstname, string lastname, string email, int department, string password, string userType, int year)
        {
            if (IsEmailRegistered(email))
                return "Email is already registered.";

            string insertUserQuery = $@"INSERT INTO Users (FName, LName, Email, Departmentid, Password, Type)
                        VALUES ('{firstname}', '{lastname}', '{email}', '{department}', '{password}', '{userType}')";
            int userInsertResult = dbMan.ExecuteNonQuery(insertUserQuery);

            if (userInsertResult > 0)
            {
                string getUserIdQuery = $@"SELECT UserID FROM Users WHERE Email = '{email}'";
                DataTable userIdTable = dbMan.ExecuteReader(getUserIdQuery);

                if (userIdTable.Rows.Count > 0)
                {
                    int userId = Convert.ToInt32(userIdTable.Rows[0]["UserID"]);

                    if (userType == "Student")
                    {
                        string insertStudentQuery = $@"INSERT INTO Student (UserID, Year) VALUES ({userId}, {year})";
                        int studentInsertResult = dbMan.ExecuteNonQuery(insertStudentQuery);

                        return studentInsertResult > 0
                            ? "User successfully registered."
                            : "Error during student registration.";
                    }

                    return "User successfully registered.";
                }
                else
                {
                    return "Error retrieving User ID.";
                }
            }
            return "Error during registration.";
        }
        public DataTable department()
        {
            string query = "SELECT DISTINCT *  FROM Department;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable usertype()
        {
            string query = "SELECT DISTINCT Type FROM Users;";
            return dbMan.ExecuteReader(query);
        }

        public string ChangePassword(int userID, string oldPassword, string newPassword)
        {
            // Validate old password (assuming `IsPasswordCorrect` can now work with userID)
            if (!IsPasswordCorrect(userID, oldPassword))
                return "Old password is incorrect.";

            // Hash the new password if needed (optional depending on your security needs)
            // string newPasswordHash = HashPassword(newPassword);

            // Update the password in the database
            string query = $@"UPDATE Users SET Password = '{newPassword}' WHERE UserID = {userID}";

            int result = dbMan.ExecuteNonQuery(query);

            return result > 0 ? "Password successfully updated." : "Error updating password.";
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        private bool IsValidPassword(string password)
        {
            if (password.Length < 8) return false;
            bool hasUpperCase = false, hasNumber = false, hasSpecialChar = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpperCase = true;
                else if (char.IsDigit(c)) hasNumber = true;
                else if (!char.IsLetterOrDigit(c)) hasSpecialChar = true;
            }

            return hasUpperCase && hasNumber && hasSpecialChar;
        }

        private bool IsEmailRegistered(string email)
        {
            string query = $@"SELECT COUNT(*) FROM Users WHERE Email = '{email}'";
            DataTable dt = dbMan.ExecuteReader(query);
            return dt != null && dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0;
        }
        public DataTable GetUserById(int userId)
        {
            string query = $@"SELECT U.FName, U.LName, U.Email, U.DepartmentID, U.Type, S.Year 
                      FROM Users U 
                      LEFT JOIN Student S ON U.UserID = S.UserID 
                      WHERE U.UserID = '{userId}'";

            return dbMan.ExecuteReader(query);
        }



        public int GetStudentYear(int userId)
        {
            string query = $@"SELECT Year FROM Student WHERE UserID = '{userId}'";

            DataTable result = dbMan.ExecuteReader(query);
            return result.Rows.Count > 0 ? Convert.ToInt32(result.Rows[0]["Year"]) : 0;
        }

        public DataTable GetActivityHistory(int userId)
        {
            string query = $@"
        SELECT c.Name AS ClubName, cm.JoinDate, cm.Mem_Status
        FROM Club_Membership cm
        INNER JOIN Club c ON cm.ClubID = c.ClubID
        WHERE cm.UserID = '{userId}'
        UNION
        SELECT e.Title AS EventTitle, a.CheckInTime, a.Status
        FROM Attendance a
        INNER JOIN Event e ON a.EventID = e.EventID
        WHERE a.UserID = '{userId}'";

            return dbMan.ExecuteReader(query);
        }


        public bool UpdateUserProfile(int userId, string firstName, string lastName, string email, string department)
        {
            string query = $@"
        UPDATE Users
        SET FName = '{firstName}',
            LName = '{lastName}',
            Email = '{email}',
            Departmentid = '{department}'
        WHERE UserID = '{userId}'";
            int rowsAffected = dbMan.ExecuteNonQuery(query);
            return rowsAffected > 0;
        }

    }

}
// Hash the password using SHA256
//private string HashPassword(string password)
//{
//    using (SHA256 sha256 = SHA256.Create())
//    {
//        byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
//        StringBuilder builder = new StringBuilder();
//        foreach (byte b in bytes)
//            builder.Append(b.ToString("x2"));
//        return builder.ToString();
//    }
//}