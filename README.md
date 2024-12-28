# University Management System Database Project

The University Management System Database Project is a structured and comprehensive solution designed to manage various aspects of university administration. This database schema facilitates efficient data management for users, departments, clubs, events, locations, and feedback, ensuring seamless operations.

---

## Overview

This project implements a relational database using **Microsoft SQL Server**, focusing on handling the following:

- User and department management
- Club and membership tracking
- Event scheduling and attendance management
- Resource reservation and feedback collection

The schema is designed with **referential integrity** and **scalability**, ensuring robust data relationships and controlled actions for updates and deletions.

---

## Key Features

1. **User and Role Management**
   - Centralized user table supporting multiple user roles (students, faculty, and supervisors).
   - Controlled deletions and cascading updates for consistent data handling.

2. **Department Management**
   - Tracks university departments and associates them with users.

3. **Club and Membership Management**
   - Handles university clubs and their memberships with status and join dates.

4. **Event Management**
   - Organizes and categorizes events with location and attendance tracking.

5. **Location and Resource Management**
   - Manages campus resources like halls and classrooms, including availability and reservations.

6. **Feedback and Attendance**
   - Collects user feedback on events and tracks attendance.

---

## Database Schema

### Key Tables and Relationships

1. **Users Table**
   - Manages all user types with attributes such as `FName`, `LName`, `Email`, `Password`, and `DepartmentID`.
   - Foreign key to the `Department` table.

2. **Department Table**
   - Tracks departments within the university.

3. **Club and Club_Membership Tables**
   - Stores details about clubs and their memberships.
   - Maintains the status of memberships and tracks join dates.

4. **Event Table**
   - Organizes university events with details like title, description, location, and category.
   - Links to the `Location` and `EventCategories` tables.

5. **Attendance Table**
   - Tracks user attendance at events, including check-in times and statuses.

6. **Reservation Table**
   - Handles reservations of university locations by users with specific time slots.

7. **Feedback Table**
   - Captures event feedback with user ratings and comments.

---

## SQL Highlights

### Referential Integrity

- **Cascading Updates**: Ensures updates to parent tables propagate to child tables.
- **Controlled Deletes**: Prevents unintended data loss by setting appropriate `ON DELETE` actions.

### Example Relationships

- `Users` ➤ `Department` (Many-to-One)
- `Users` ➤ `Club_Membership` (One-to-Many)
- `Event` ➤ `Attendance` (One-to-Many)
- `Location` ➤ `Event` (One-to-Many)

---

## How to Set Up

1. **Database Creation**
   - Run the provided SQL script to create the database and schema.

2. **Populate Data**
   - Insert sample data into the tables for testing and demonstration purposes.

3. **Integrate with Applications**
   - Use the database as the backend for a C# application or a web-based administrative tool.

---

## Example Queries

1. **Retrieve Events Organized by a Specific User**
   ```sql
   SELECT E.Title, E.StartDate, E.EndDate, U.FName + ' ' + U.LName AS Organizer
   FROM Event E
   JOIN Users U ON E.CreatedBy = U.UserID
   WHERE U.UserID = 1;
   ```

2. **List All Clubs with Supervisors**
   ```sql
   SELECT C.Name AS ClubName, U.FName + ' ' + U.LName AS Supervisor
   FROM Club C
   JOIN Users U ON C.SupervisorID = U.UserID;
   ```

3. **Fetch Feedback for a Specific Event**
   ```sql
   SELECT F.Ratings, F.Comments, U.FName + ' ' + U.LName AS Participant
   FROM Feedback F
   JOIN Users U ON F.UserID = U.UserID
   WHERE F.EventID = 1;
   ```

---

## Future Enhancements

1. **Role-Based Access Control**
   - Implement user roles for fine-grained access permissions.

2. **Event Notification System**
   - Add email or SMS reminders for registered events.

3. **Mobile App Integration**
   - Develop a mobile application to manage events, reservations, and feedback.

4. **Advanced Reporting**
   - Generate detailed analytics for attendance, resource utilization, and feedback trends.

---

## Contributing

We welcome contributions to this project. If you have ideas for new features or improvements, please submit a pull request or open an issue in the repository.

---

