using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBapplication
{
    public class FacultyMemberControler
    {
        DBManager dbMan;
        public FacultyMemberControler()
        {
            dbMan = new DBManager();
        }
        public DataTable GetPendingMembershipsSupervised(int userID)
        {
            // SQL query to fetch pending memberships where the user is the supervisor
            string query = $@"
    SELECT cm.MembershipID, cm.UserID, cm.ClubID, cm.JoinDate, cm.Mem_Status
    FROM Club_Membership cm
    INNER JOIN Club c ON cm.ClubID = c.ClubID
    WHERE cm.Mem_Status = 'Pending' AND c.SupervisorID = {userID};
";

            // Execute the query and return the result as a DataTable
            DataTable pendingMemberships = dbMan.ExecuteReader(query);

            return pendingMemberships;
        }
        public int GetUpcomingEventCount(int userId)
        {
            // SQL query to count upcoming events for clubs where the supervisor is the given user
            string query = $@"
    SELECT COUNT(*) 
    FROM Event e
    WHERE e.CreatedBy = {userId} AND e.StartDate > GETDATE();
";

            // Execute the query and return the result as a count
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }
        public int GetTotalEventCount(int userId)
        {
            // SQL query to count total events created by clubs where the supervisor is the given user
            string query = $@"
        SELECT COUNT(*) 
        FROM Event e
        WHERE e.CreatedBy = {userId};
    ";

            // Execute the query and return the result as a count
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }
        public int PendingCount(int userid)
        {
            string query = $@"
SELECT COUNT(*) 
FROM Club_Membership cm
INNER JOIN Club c ON cm.ClubID = c.ClubID
WHERE cm.Mem_Status = 'Pending'
AND c.SupervisorID = {userid};";

            // Execute the query and return the result
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }
        public DataTable GetFeedBacks(int eventId)
        {
            DataTable feedbackTable = new DataTable();

            // Open connection
            using (SqlConnection conn = new SqlConnection("Data Source=Ali\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;Encrypt=False"))
            {
                conn.Open();

                // Create command
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Feedback WHERE EventID = @EventID", conn))
                {
                    cmd.Parameters.AddWithValue("@EventID", eventId);

                    // Execute reader inside a using statement to ensure it gets disposed of
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Ensure we completely read all the results before moving on
                        feedbackTable.Load(reader);  // Load data directly into DataTable
                    }  // The reader is closed here automatically
                }  // The command is disposed of here
            }  // The connection is closed here

            return feedbackTable;
        }

        //public DataTable GetFeedbacks()
        //{
        //    string query = "SELECT FeedbackID FROM Feedback";  // Get only the Feedback IDs or other relevant columns
        //    DataTable feedbacks = dbMan.ExecuteReader(query);  // Use your dbMan.ExecuteReader or other database methods
        //    return feedbacks;
        //}

        public bool RecordAttendance(int studentId, int eventId, string checkInTime)
        {
            string checkQuery = $@"
        SELECT COUNT(*) 
        FROM Attendance 
        WHERE EVENTID= '{eventId}' AND USERID='{studentId}' ";

            int existingRegistrations = Convert.ToInt32(dbMan.ExecuteScalar(checkQuery));

            if (existingRegistrations > 0)
            {
                return false;
            }
            string query = $@"
        INSERT INTO Attendance (UserID, EventID, CheckInTime,Status)
        VALUES ('{studentId}', '{eventId}', '{checkInTime}','Checked IN')
    ";

            // Execute the query and check if a row was inserted
            int rowsAffected = dbMan.ExecuteNonQuery(query);

            // Return true if the attendance was successfully recorded
            return rowsAffected > 0;
        }
        public DataTable GetEventData(int uid, string userType)
        {
            string query = "";

            switch (userType)
            {
                case "Admin":
                    // Admin: Get all events
                    query = @"SELECT EventID, Title FROM Event";
                    break;

                case "Faculty Member":
                    // Faculty: Get events created by this faculty member
                    query = $@"SELECT EventID, Title FROM Event WHERE CreatedBy = {uid}";
                    break;

                case "Student":
                    // Student: Get events attended by this student
                    query = $@"
                SELECT e.EventID, e.Title 
                FROM Event e 
                INNER JOIN Attendance a ON e.EventID = a.EventID 
                WHERE a.StudentID = {uid}";
                    break;

                default:
                    throw new ArgumentException("Invalid user type provided.");
            }

            try
            {
                return dbMan.ExecuteReader(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving event data: " + ex.Message);
            }
        }



        public bool DeleteFeedback(int feedbackId)
        {
            // Check if the feedback with the given FeedbackID exists
            string checkQuery = $@"
 SELECT COUNT(*) 
 FROM Feedback
 WHERE FeedbackID = {feedbackId}";

            // Execute the query to check if the FeedbackID exists
            int count = Convert.ToInt32(dbMan.ExecuteScalar(checkQuery));

            // If the FeedbackID exists, proceed with the deletion
            if (count > 0)
            {
                string deleteQuery = $@"
     DELETE FROM Feedback
     WHERE FeedbackID = {feedbackId}";

                // Execute the delete query and check if the deletion was successful
                int rowsAffected = dbMan.ExecuteNonQuery(deleteQuery);
                return rowsAffected > 0; // Return true if at least one row was affected
            }
            else
            {
                // If the FeedbackID doesn't exist, return false
                return false;
            }
        }
        public int GetEventIDByName(int id)
        {
            string query = $@"
        SELECT EventID
        FROM Event
        WHERE EventID = '{id}'
    ";

            // Execute the query and retrieve the first result (EventID) directly
            object result = dbMan.ExecuteScalar(query);

            // Check if the result is not null and convert it to integer
            if (result != null)
            {
                return Convert.ToInt32(result);
            }

            // If no result was found, return -1 or any other default value indicating failure
            return -1;

        }
        public DataTable TrackAttendance(int eid)
        {
            DataTable Attendance = new DataTable();

            // Open connection
            using (SqlConnection conn = new SqlConnection("Data Source=Ali\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;Encrypt=False"))
            {
                conn.Open();

                // Create command with parameterized query to prevent SQL injection
                using (SqlCommand cmd = new SqlCommand(@"
            SELECT 
                a.AttendanceID,
                e.Title AS EventName,
                u.FName + ' ' + u.LName AS UserName,
                a.CheckInTime,
                a.Status
            FROM Attendance a
            INNER JOIN Event e ON a.EventID = e.EventID
            INNER JOIN Users u ON a.UserID = u.UserID
            WHERE e.Eventid = @EventID
            ORDER BY a.AttendanceID DESC;
        ", conn))
                {
                    // Add parameter to the command
                    cmd.Parameters.AddWithValue("@EventID", eid);

                    // Execute reader inside a using statement to ensure it gets disposed of
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Load data directly into the DataTable
                        Attendance.Load(reader);
                    }  // The reader is closed here automatically
                }  // The command is disposed of here
            }  // The connection is closed here

            return Attendance;
        }



        public DataTable GetPendingMemberships()
        {
            // SQL query to fetch membership IDs with "Pending" status
            string query = @"
        SELECT MembershipID, UserID, ClubID, JoinDate , mem_status
        FROM Club_Membership
        WHERE mem_status = 'Pending'
    ";

            // Execute the query and return the result as a DataTable
            DataTable pendingMemberships = dbMan.ExecuteReader(query);
            return pendingMemberships;
        }
        public bool AcceptMembership(int membershipId)
        {
            // SQL query to update the mem_status
            string query = $@"
        UPDATE Club_Membership
        SET mem_status = 'Accepted'
        WHERE MembershipID = {membershipId} AND mem_status='Pending'" ;

            // Execute the query and check if the update was successful
            int rowsAffected = dbMan.ExecuteNonQuery(query);
            return rowsAffected > 0; // Return true if at least one row was affected
        }
        public bool RejectMembership(int membershipId)
        {
        
            string query = $@"
        UPDATE Club_Membership
        SET mem_status = 'Rejected'
        WHERE MembershipID = {membershipId} AND mem_Status='Pending' " ;

            // Execute the query and check if the update was successful
            int rowsAffected = dbMan.ExecuteNonQuery(query);
            return rowsAffected > 0; // Return true if at least one row was affected
        }
        public bool DeleteAttendance(int studentId)
        {
            // First, check if the attendance exists for this student
            string checkQuery = $@"
        SELECT COUNT(*) 
        FROM Attendance 
        WHERE AttendanceId = {studentId}";

            // Execute the check query to see if the attendance exists
            int count = Convert.ToInt32(dbMan.ExecuteScalar(checkQuery));

            if (count > 0)
            {
                // If attendance exists, delete it
                string deleteQuery = $@"
            DELETE FROM Attendance 
            WHERE AttendanceId = {studentId}";

                int rowsAffected = dbMan.ExecuteNonQuery(deleteQuery);

                // Return true if at least one row was affected (meaning the deletion was successful)
                return rowsAffected > 0;
            }
            else
            {
                // If attendance doesn't exist, return false
                return false;
            }
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

    }
}
