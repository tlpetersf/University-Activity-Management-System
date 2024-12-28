using System;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class ReportsController
    {
        private DBManager dbMan;

        public ReportsController()
        {
            dbMan = new DBManager();
        }

        // Function to get the number of events attended by each user
        public DataTable GetEventsAttendedByEachUser()
        {
            string query = "SELECT CONCAT(U.FName, ' ', U.LName) AS FullName, COUNT(A.EventID) AS EventsAttended " +
                           "FROM Users U " +
                           "INNER JOIN Attendance A ON U.UserID = A.UserID " +
                           "GROUP BY U.FName, U.LName";
            return dbMan.ExecuteReader(query);
        }



        // Function to get the number of club memberships for each user
        public DataTable GetClubMembershipsForEachUser()
        {
            string query = "SELECT CONCAT(U.FName, ' ', U.LName) AS FullName, COUNT(CM.ClubID) AS ClubsJoined " +
                           "FROM Users U " +
                           "INNER JOIN Club_Membership CM ON U.UserID = CM.UserID " +
                           "GROUP BY U.FName, U.LName";
            return dbMan.ExecuteReader(query);
        }


        // Function to get the total number of users, events, and clubs
        public DataTable GetTotalUsersEventsAndClubs()
        {
            string query = "SELECT (SELECT COUNT(*) FROM Users) AS TotalUsers, " +
                           "(SELECT COUNT(*) FROM Event) AS TotalEvents, " +
                           "(SELECT COUNT(*) FROM Club) AS TotalClubs";
            return dbMan.ExecuteReader(query);
        }


        // Function to get the status of active, rejected, and pending members in clubs
        public DataTable GetMemberStatusInClubs()
        {
            string query = "SELECT CM.Mem_Status AS Status, COUNT(*) AS TotalMembers " +
                           "FROM Club_Membership CM " +
                           "GROUP BY CM.Mem_Status";
            return dbMan.ExecuteReader(query);
        }


        // Function to get the average, minimum, and maximum number of events attended by users
        public DataTable GetEventStats()
        {
            string query = "SELECT AVG(EventsAttended) AS AvgEvents, MIN(EventsAttended) AS MinEvents, MAX(EventsAttended) AS MaxEvents " +
                           "FROM (SELECT COUNT(A.EventID) AS EventsAttended " +
                                 "FROM Attendance A " +
                                 "GROUP BY A.UserID) AS UserEventCounts";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetActiveUsersAndEventParticipation()
        {
            string query = "SELECT U.UserID, CONCAT(U.FName, ' ', U.LName) AS FullName, " +
                           "COUNT(A.EventID) AS EventsAttended " +
                           "FROM Users U " +
                           "INNER JOIN Attendance A ON U.UserID = A.UserID " +
                           "WHERE A.Status = 'Active' " +
                           "GROUP BY U.UserID, U.FName, U.LName " +
                           "ORDER BY EventsAttended DESC";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetEventFeedbackByUser()
        {
            string query = "SELECT CONCAT(U.FName, ' ', U.LName) AS FullName, E.Title AS EventTitle, " +
                           "F.Ratings, F.Comments " +
                           "FROM Feedback F " +
                           "INNER JOIN Users U ON F.UserID = U.UserID " +
                           "INNER JOIN Event E ON F.EventID = E.EventID " +
                           "ORDER BY E.Title, U.LName";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetClubMembershipTrends()
        {
            string query = "SELECT C.Name AS ClubName, COUNT(CM.MembershipID) AS TotalMembers, " +
                           "YEAR(CM.JoinDate) AS Year " +
                           "FROM Club_Membership CM " +
                           "INNER JOIN Club C ON CM.ClubID = C.ClubID " +
                           "GROUP BY C.Name, YEAR(CM.JoinDate) " +
                           "ORDER BY C.Name, Year";
            return dbMan.ExecuteReader(query);
        }





        // Function to terminate the connection
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
