using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBapplication
{
    public class StudentController
    {
        DBManager dbMan;
        public StudentController()
        {
            dbMan = new DBManager();
        }

        public int ResCount(int userid)
        {
            string query = $@"SELECT Count(*) FROM Reservation WHERE UserID = '{userid}'";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        public int UpEventCount()
        {
            string query = $@"SELECT COUNT(*) FROM Event e WHERE e.STARTDATE > GETDATE()";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        public int AccClubCount(int userid)
        {
            string query = $@"SELECT COUNT(*) FROM Club_Membership cm WHERE cm.UserID = '{userid}' AND cm.mem_status='Accepted';";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }
        public int RejClubCount(int userid)
        {
            string query = $@"SELECT COUNT(*) FROM Club_Membership cm WHERE cm.UserID = '{userid}' AND cm.mem_status='Rejected';";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }
        public int PenClubCount(int userid)
        {
            string query = $@"SELECT COUNT(*) FROM Club_Membership cm WHERE cm.UserID = '{userid}' AND cm.mem_status='Pending';";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }
        public int RegEventCount(int userid)
        {
            string query = $@"SELECT COUNT(*) AS RegisteredEventCount FROM RegisteredEvents WHERE  USERID = '{userid}';";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }
        public int AttEventCount(int userid)
        {
            string query = $@"SELECT COUNT(*) FROM Event e JOIN Attendance a ON e.EventID = a.EventID WHERE a.UserID = '{userid}' AND Status='Checked In';";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }
        public int FeedbackCount(int userid)
        {
            string query = $@"SELECT COUNT(*) AS GivenFeedbackCount FROM feedback WHERE USERID = '{userid}';";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        public DataTable GetAvailableSpacesForReservation()
        {
            DataTable availableSpaces = new DataTable();
            string query = @"
        SELECT 
            l.LocationID, 
            l.LocName, 
            l.Capacity, 
            lt.LocationType AS LocType, 
            l.StartTime, 
            l.EndTime 
        FROM 
            Location l
        INNER JOIN 
            LocationTypes lt ON l.TypeID = lt.TypeID
    ";
            availableSpaces = dbMan.ExecuteReader(query);
            return availableSpaces;
        }
        public DataTable GetFeedbackByUserId(int userId)
        {
            DataTable feedbackData = new DataTable();
            string query = $@"
        SELECT 
            f.FeedbackID, 
            f.UserID, 
            f.EventID, 
            f.Ratings, 
            f.comments
        FROM 
            Feedback f
        WHERE 
            f.UserID ='{userId}'
    ";

            feedbackData = dbMan.ExecuteReader(query);

            return feedbackData;
        }
        public bool DeleteFeedbackById(int feedbackId, int userId)
        {
            bool isDeleted = false;
            string query = $@"
        DELETE FROM 
            Feedback 
        WHERE 
            FeedbackID = '{feedbackId}' 
            AND UserID = '{userId}'
    ";

            // Execute the query using ExecuteNonQuery method
            int rowsAffected = dbMan.ExecuteNonQuery(query);

            // Check if any rows were affected (i.e., the feedback was deleted)
            if (rowsAffected > 0)
            {
                isDeleted = true;
            }

            return isDeleted;
        }

        public DataTable ViewAttendance(int uid)
        {
            string query = $@"SELECT e.EventID,e.Title, e.StartDate,e.EndDate, a.CheckInTime , a.Status FROM Event e INNER JOIN Attendance a ON e.EventID = a.EventID WHERE a.userId = '{uid}';";
            return dbMan.ExecuteReader(query);
        }
        public bool ReserveLocation(int userId, int locationId, string startTime, string endTime)
        {
            string checkQuery = $@"
        SELECT COUNT(*) 
        FROM Reservation 
        WHERE LocationID = '{locationId}'
        AND (
            (StartTime <= '{startTime}' AND EndTime > '{startTime}')
            OR 
            (StartTime < '{endTime}' AND EndTime >= '{endTime}')
            OR
            (StartTime >= '{startTime}' AND EndTime <= '{endTime}')
        )";

            int existingReservations = Convert.ToInt32(dbMan.ExecuteScalar(checkQuery));

            if (existingReservations > 0)
            {
                return false;
            }

            string insertQuery = $@"
        INSERT INTO Reservation (UserID, LocationID, StartTime, EndTime)
        SELECT '{userId}', '{locationId}', '{startTime}', '{endTime}'
        WHERE EXISTS (
            SELECT 1 
            FROM Location 
            WHERE LocationID = '{locationId}'
            AND CAST('{startTime}' AS TIME) >= StartTime 
            AND CAST('{endTime}' AS TIME) <= EndTime
        )";

            int rowsAffected = dbMan.ExecuteNonQuery(insertQuery);
            return rowsAffected > 0;
        }

        public bool CancelReservation(int Resid, int userid)
        {
            string checkQuery = $@"
        SELECT COUNT(*) 
        FROM Reservation 
        WHERE ReservationID = '{Resid}' AND USERID='{userid}' ";

            int existingRegistrations = Convert.ToInt32(dbMan.ExecuteScalar(checkQuery));

            if (existingRegistrations < 0)
            {
                return false;
            }

            string deleteQuery = $@" DELETE FROM Reservation WHERE (ReservationID = '{Resid}' AND USERID='{userid}');";

            int rowsAffected = dbMan.ExecuteNonQuery(deleteQuery);
            return rowsAffected > 0;
        }

        public DataTable LoadAttendedEvents(int userId)
        {
            string query = $@"
        SELECT DISTINCT e.EventID, e.Title 
        FROM Event e
        INNER JOIN Attendance a ON e.EventID = a.EventID
        WHERE a.UserID = {userId}
    ";

            DataTable dt = dbMan.ExecuteReader(query);
            return dt;
        }

        public bool ProvideFeedback(int userId, int eventId, int rating, string comment)
        {
            string query = $@"
        INSERT INTO Feedback (UserID, EventID, Ratings, Comments)
        VALUES ('{userId}', '{eventId}', '{rating}', '{comment}')
    ";

            int rowsAffected = dbMan.ExecuteNonQuery(query);
            return rowsAffected > 0;
        }

        public DataTable GetReservationHistoryForStudent(int userId)
        {
            DataTable reservationHistory = new DataTable();
            string query = $@"
        SELECT 
            r.ReservationID,
            r.UserID,
            u.FName + ' ' + u.LName AS StudentName,
            l.LocName AS Location,
            r.StartTime,
            r.EndTime
        FROM Reservation r
        INNER JOIN Users u ON r.UserID = u.UserID
        INNER JOIN Location l ON r.LocationID = l.LocationID
        WHERE r.UserID = '{userId}'
        ORDER BY r.ReservationID DESC;
    ";

            reservationHistory = dbMan.ExecuteReader(query);
            return reservationHistory;
        }

        public DataTable GetUpcomingEvents()
        {
            DataTable upcomingEvents = new DataTable();
            string query = @"
        SELECT 
            e.EventID,
            e.Title,
            e.Description,
            e.StartDate,
            e.EndDate,
            e.EventCategory,
            l.LocName AS Location,
            u.FName + ' ' + u.LName AS CreatedBy
        FROM Event e
        INNER JOIN Location l ON e.LocationID = l.LocationID
        INNER JOIN Users u ON e.CreatedBy = u.UserID
        WHERE e.StartDate > CAST(GETDATE() AS DATE)
        ORDER BY e.StartDate ASC;
    ";

            upcomingEvents = dbMan.ExecuteReader(query);
            return upcomingEvents;
        }

        public bool RegisterStudentInEvent(int userID, int eventID)
        {
            string locationQuery = $@"
    SELECT LocationID
    FROM Event
    WHERE EventID = {eventID}
    ";

            object locationResult = dbMan.ExecuteScalar(locationQuery);
            if (locationResult == null)
            {
                return false;
            }

            int locationID = Convert.ToInt32(locationResult);

            string checkQuery = $@"
    SELECT COUNT(*) 
    FROM RegisteredEvents 
    WHERE UserID = {userID} 
    AND EventID = {eventID}
    ";

            int existingRegistrations = Convert.ToInt32(dbMan.ExecuteScalar(checkQuery));

            if (existingRegistrations > 0)
            {
                // If the user is already registered for this event, return false
                return false;
            }

            // Insert the registration into the RegisteredEvents table
            string insertQuery = $@"
    INSERT INTO RegisteredEvents (UserID, EventID, RegistrationDate)
    VALUES ({userID}, {eventID}, '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}')
    ";

            int rowsAffected = dbMan.ExecuteNonQuery(insertQuery);

            // Return true if the registration was successfully added
            return rowsAffected > 0;
        }
        public bool CancelEventRegisteration(int Regid,int userid)
        {
            string checkQuery = $@"
        SELECT COUNT(*) 
        FROM RegisteredEvents 
        WHERE RegistrationID = '{Regid}' AND USERID='{userid}' ";

            int existingRegistrations = Convert.ToInt32(dbMan.ExecuteScalar(checkQuery));

            if (existingRegistrations < 0)
            {
                return false;
            }

            string deleteQuery = $@" DELETE FROM RegisteredEvents WHERE RegistrationID = '{Regid}' AND USERID ='{userid}';";

            int rowsAffected = dbMan.ExecuteNonQuery(deleteQuery);
            return rowsAffected > 0;
        }

        public DataTable GetAllClubs()
        {
            string query = @"
        SELECT c.ClubID, c.Name, c.Description,
               u.FName + ' ' + u.LName AS SupervisorName
        FROM Club c
        LEFT JOIN Users u ON c.SupervisorID = u.UserID
        ORDER BY c.ClubID";

            return dbMan.ExecuteReader(query);
        }

        public bool JoinClub(int userID, int clubID)
        {
            string checkQuery = $@"
        SELECT COUNT(*) 
        FROM Club_Membership 
        WHERE UserID = '{userID}' 
        AND ClubID = '{clubID}'";

            int existingRegistrations = Convert.ToInt32(dbMan.ExecuteScalar(checkQuery));

            if (existingRegistrations > 0)
            {
                return false;
            }

            string currentTime = DateTime.Now.ToString("yyyy/MM/dd");
            string insertQuery = $@" 
            INSERT INTO Club_Membership (UserID, ClubID, JoinDate, Mem_Status) 
            VALUES ('{userID}', '{clubID}', '{currentTime}', 'Pending')";

            int rowsAffected = dbMan.ExecuteNonQuery(insertQuery);
            return rowsAffected > 0;
        }

       public bool LeaveClub(int memID,int userid)
        {
            string checkQuery = $@"
        SELECT COUNT(*) 
        FROM Club_Membership 
        WHERE MembershipID = '{memID}'AND USERID='{userid}' ";

            int existingRegistrations = Convert.ToInt32(dbMan.ExecuteScalar(checkQuery));

            if (existingRegistrations < 0)
            {
                return false;
            }

            string deleteQuery = $@" DELETE FROM Club_Membership WHERE MembershipID = '{memID}' AND USERID='{userid}';";

            int rowsAffected = dbMan.ExecuteNonQuery(deleteQuery);
            return rowsAffected > 0;
        }

        public DataTable GetMemberships(int userid)
        {
            string query = $@"Select * From Club_Membership c Where c.UserID='{userid}'";
            DataTable dt = dbMan.ExecuteReader(query);
            return dt;
        }

        public DataTable GetRegisteredEvents(int userid)
        {
            string query = $@"SELECT e.EventID,r.RegistrationID,e.Title,e.Description,e.StartDate,e.EndDate,e.CreatedBy,r.RegistrationDate,r.Status
FROM Event e
INNER JOIN RegisteredEvents r ON e.EventId = r.EventId
WHERE r.UserId = '{userid}';";
            DataTable dt = dbMan.ExecuteReader(query);
            return dt;
        }

        public DataTable GetReservedLocations(int studentId)
        {
            string query = $@"
    SELECT 
        l.LocationID, 
        l.LocName AS Location, 
        r.StartTime AS ReservationStart, 
        r.EndTime AS ReservationEnd
    FROM 
        Location l
    INNER JOIN 
        Reservation r ON r.LocationID = l.LocationID
    WHERE 
        r.UserID = {studentId} 
        AND r.StartTime >= CAST(GETDATE() AS DATE) 
    ORDER BY 
        r.StartTime
";

            DataTable dt = dbMan.ExecuteReader(query);
            return dt;

        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}