using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace DBapplication
{
    public class ControllerAdmin
    {
        DBManager dbMan;
        public ControllerAdmin()
        {
            dbMan = new DBManager();
        }
        public string GetTotalUsers()
        {
            string query = "SELECT COUNT(*) FROM Users";
            return Convert.ToString(dbMan.ExecuteScalar(query));
        }
        public int GetTotalMembers(int clubID)
        {
            string query = $@"SELECT COUNT(*) 
                      FROM Club_Membership 
                      WHERE ClubID = {clubID}";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        public DataTable GetClubMembers(int clubID)
        {
            string query = $@"SELECT U.UserID, CONCAT(U.FName, ' ', U.LName) AS Name, U.Email
                      FROM Club_Membership CM
                      INNER JOIN Users U ON CM.UserID = U.UserID
                      WHERE CM.ClubID = {clubID}";
            return dbMan.ExecuteReader(query);
        }
        public bool RemoveMemberFromClub(int clubID, int userID)
        {
            string query = $@"DELETE FROM Club_Membership 
                      WHERE ClubID = {clubID} AND UserID = {userID}";
            return dbMan.ExecuteNonQuery(query) > 0;
        }

        public bool CheckEvent(int eventid, int userid)
        {


            string checkQuery = $@"
SELECT COUNT(*) 
FROM Event 
WHERE CreatedBy = '{userid}' AND EventId='{eventid}'   ";

            int existingRegistrations = Convert.ToInt32(dbMan.ExecuteScalar(checkQuery));

            if (existingRegistrations > 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
        public string GetTotalAdmins()
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Type = 'Admin'";
            return Convert.ToString(dbMan.ExecuteScalar(query));
        }
        public string GetTotalFacultyMembers()
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Type = 'Faculty Member'";
            return Convert.ToString(dbMan.ExecuteScalar(query));
        }
        public string GetTotalStudents()
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Type = 'Student'";
            return Convert.ToString(dbMan.ExecuteScalar(query));
        }
        public string GetTotalEvents()
        {
            string query = "SELECT COUNT(*) FROM Event";
            return Convert.ToString(dbMan.ExecuteScalar(query));
        }
        public string GetTotalClubs()
        {
            string query = "SELECT COUNT(*) FROM Club";
            return Convert.ToString(dbMan.ExecuteScalar(query));
        }
        public string GetTotalLocations()
        {
            string query = "SELECT COUNT(*) FROM Location";
            return Convert.ToString(dbMan.ExecuteScalar(query));
        }
        public bool IsInvalidName(string Fname)
        {
            foreach (char c in Fname)
            {
                if (char.IsDigit(c) || !char.IsLetter(c))
                {
                    return true;
                }
            }
            return false; 
        }
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public bool IsValidPassword(string password)
        {
            if (password.Length < 8) return false;

            bool hasUpper = false, hasLower = false, hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpper = true;
                if (char.IsLower(c)) hasLower = true;
                if (char.IsDigit(c)) hasDigit = true;
            }

            return hasUpper && hasLower && hasDigit;
        }
        public void AddAdmin(string FName, string LName, string Password, string Email)
        {
            string query = $@"INSERT INTO Users (FName, LName, Password, Email, Department, Type) " +
                           $@"VALUES ('{FName}', '{LName}', '{Password}', '{Email}', 'Adminstration', 'Admin')";
            dbMan.ExecuteNonQuery(query);
        }
        public DataTable AllUsers()
        {
            string query= "SELECT* FROM Users";
            return dbMan.ExecuteReader(query);
        }
        public DataTable EventsCreatedby(int userId)
        {
            string query = $@"SELECT e.Title, e.EventID, e.EventCategory, e.StartDate, e.EndDate  ,e.Description, e.LocationID, e.CreatedBy FROM event e INNER JOIN users u ON e.CreatedBy = u.UserID WHERE e.CreatedBy = '{userId}';";
            return dbMan.ExecuteReader(query);
        }
        public bool DoesUserExist(int userId)
        {
            string query = $"SELECT COUNT(*) FROM Users WHERE UserID = {userId}";
            int count = (int)dbMan.ExecuteScalar(query);
            return count > 0;
        }
        public bool DoesEventExist(int eventId)
        {
            string query = $"SELECT COUNT(*) FROM Event WHERE EventID = {eventId}";
            int count = (int)dbMan.ExecuteScalar(query);
            return count > 0;
        }
        public bool DoesClubExist(int clubId)
        {
            string query = $"SELECT COUNT(*) FROM Club WHERE ClubID = {clubId}";
            int count = (int)dbMan.ExecuteScalar(query);
            return count > 0;
        }
        public bool DoesLocationExist(int LocId)
        {
            string query = $"SELECT COUNT(*) FROM Location WHERE LocationID = {LocId}";
            int count = (int)dbMan.ExecuteScalar(query);
            return count > 0;
        }
        public void DeleteUser(int userId)
        {
            string query = $@"DELETE FROM Users WHERE UserID = {userId}";
            dbMan.ExecuteNonQuery(query);
        }
        public void DeleteEvent(int eventId)
        {
            string query = $@"DELETE FROM Event WHERE EventID = {eventId}";
            dbMan.ExecuteNonQuery(query);
        }
        public void DeleteClub(int clubId)
        {
            string query = $@"DELETE FROM Club WHERE ClubID = {clubId}";
            dbMan.ExecuteNonQuery(query);
        }
        public void DeleteLocation(int LocId)
        {
            string query = $@"DELETE FROM Location WHERE LocationID = {LocId}";
            dbMan.ExecuteNonQuery(query);
        }
        public string GenerateRandomPassword()
        {
            const int passwordLength = 8;
            const string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            const string digits = "0123456789";
            const string specialCharacters = "!@#$%^&*()_+";

            Random random = new Random();

            // Ensure the password contains at least one of each required character type
            char[] password = new char[passwordLength];
            password[0] = upperCase[random.Next(upperCase.Length)]; // At least one uppercase letter
            password[1] = lowerCase[random.Next(lowerCase.Length)]; // At least one lowercase letter
            password[2] = digits[random.Next(digits.Length)]; // At least one digit

            // Fill the rest of the password with random characters from all categories
            string allChars = upperCase + lowerCase + digits + specialCharacters;
            for (int i = 3; i < passwordLength; i++)
            {
                password[i] = allChars[random.Next(allChars.Length)];
            }

            // Shuffle the password to make it more random
            password = password.OrderBy(x => random.Next()).ToArray();

            return new string(password);
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
        public string UpdateUserPassword(int userId)
        {
            string newPassword = GenerateRandomPassword();
            string hashedPassword = HashPassword(newPassword);

            string query = $@"UPDATE Users SET Password = '{hashedPassword}' WHERE UserID = {userId}";

            dbMan.ExecuteNonQuery(query);
            return newPassword;
        }
        public void AddEvent(string title, string description, DateTime startDate, DateTime endDate, int eventCategory, int locationId, int createdBy)
        {
            string query = $@"
        INSERT INTO Event (Title, Description, StartDate, EndDate, EventCategory, LocationID, CreatedBy)
        VALUES ('{title}', '{description}', '{startDate}', '{endDate}', {eventCategory}, {locationId}, {createdBy})";

            dbMan.ExecuteNonQuery(query);
        }
        public void EditEvent(int eventId, string title, string description, DateTime startDate, DateTime endDate, int eventCategory, int locationId)
        {
            string query = $@"
        UPDATE Event
        SET Title='{title}', Description='{description}',StartDate= '{startDate}',EndDate= '{endDate}', EventCategory={eventCategory}, LocationID={locationId}
        WHERE EventID = {eventId}";
            dbMan.ExecuteNonQuery(query);
        }
        public void EditClub(int clubId, string title, string description, int SupervisorID)
        {
            string query = $@"
        UPDATE Club
        SET Name='{title}', Description='{description}',SupervisorID={SupervisorID}
        WHERE ClubID = {clubId}";
            dbMan.ExecuteNonQuery(query);
        }
        public DataTable GetEventDetails(int eventId)
        {
            string query = $@"SELECT Title, Description, StartDate, EndDate, EventCategory, LocationID, CreatedBy, CONCAT(FName, ' ', LName) AS Name  FROM Event E, Users U WHERE EventID = {eventId}";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetClubDetails(int clubId)
        {
            string query = $@"SELECT Name, Description, SupervisorID,CONCAT(FName, ' ', LName) AS SupervisorName  FROM Club , Users WHERE SupervisorID=UserID AND ClubID = {clubId}";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetLocationDetails(int locationID)
        {
            string query = $@"
        SELECT 
            L.LocationID, 
            L.LocName, 
            L.Capacity, 
            L.TypeID, 
            L.StartTime, 
            L.EndTime 
        FROM Location L 
        WHERE L.LocationID = '{locationID}'";
            return dbMan.ExecuteReader(query);
        }

        public void UpdateLocation(int locationID, string locName, int capacity, int typeID, string startTime, string endTime)
        {
            string query = $@"UPDATE Location SET LocName = '{locName}', Capacity = '{capacity}', TypeID = '{typeID}', StartTime = '{startTime}', EndTime = '{endTime}' WHERE LocationID = '{locationID}'";
            dbMan.ExecuteNonQuery(query);
        }

        public DataTable EventCategory()
        {
            string query = $" SELECT * FROM EventCategories";
            return dbMan.ExecuteReader(query);
        }
        public DataTable LocationTypes()
        {
            string query = $" SELECT * FROM LocationTypes";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Locations()
        {
            string query = $" SELECT * FROM Location";
            return dbMan.ExecuteReader(query);
        }
        public DataTable AllLocations()
        {
            string query = @"
        SELECT 
            L.LocationID, 
            L.LocName, 
            L.Capacity, 
            LT.LocationType, 
            L.StartTime, 
            L.EndTime 
        FROM Location L
        INNER JOIN LocationTypes LT ON L.TypeID = LT.TypeID";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Events()
        {
            string query = $" SELECT E.EventID, E.Title, E.Description, E.StartDate, E.EndDate,EC.CategoryType, L.LocName, CONCAT(U.FName, ' ', U.LName) AS Name FROM Event E, EventCategories EC, Location L, Users U WHERE E.EventCategory=EC.CategoryID AND L.LocationID=E.LocationID AND E.CreatedBy=U.UserID";
            return dbMan.ExecuteReader(query);
        }
        public void AddClub(string title, string description,int UserID)
        {
            string query = $@"
        INSERT INTO Club (Name, Description, SupervisorID)
        VALUES ('{title}', '{description}', {UserID})";

            dbMan.ExecuteNonQuery(query);
        }
        public void AddLocation(string name, int capacity, string locType, string start, string end)
        {
            string query = $@"
        INSERT INTO Location (LocName, Capacity, TypeID, StartTime, EndTime)
        VALUES ('{name}', '{capacity}', {locType},'{start}','{end}')";

            dbMan.ExecuteNonQuery(query);
        }
        public DataTable FacultyMembers()
        {
            string query = $" SELECT UserID,CONCAT(FName, ' ', LName) AS Name FROM Users WHERE Type='Faculty Member'";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Clubs()
        {
            string query = $" SELECT C.ClubID, C.Name, C.Description, CONCAT(U.FName, ' ', U.LName) AS Supervisor FROM Club C,Users U WHERE C.SupervisorID=U.UserID";
            return dbMan.ExecuteReader(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
      
    }
}
