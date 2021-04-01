CREATE DATABASE CollegeDataBase;
GO
--DROP DATABASE CollegeDataBase;
--GO

USE CollegeDataBase;
GO

CREATE SCHEMA College;
GO


CREATE TABLE College.Position
(
positionId INT IDENTITY(1,1) PRIMARY KEY,
positionName NVARCHAR(100) NOT NULL,
atributes NVARCHAR(500) NOT NULL,
);
GO
SELECT * FROM College.Position;

CREATE TABLE College.Department
(
departmentId INT IDENTITY(1,1) PRIMARY KEY,
departmentName NVARCHAR(200) NOT NULL,

);
GO
SELECT * FROM College.Department;


CREATE TABLE College.Staff
(
staffId INT IDENTITY(1,1) PRIMARY KEY,
firstName NVARCHAR(100) NOT NULL,
lastName NVARCHAR(100) NOT NULL,
positionId INT  NOT NULL,
FOREIGN KEY (positionId) REFERENCES College.Position(positionId),
departmentId INT  NOT NULL,
FOREIGN KEY (departmentId) REFERENCES College.Department(departmentId),
salary NVARCHAR(100) NULL,
head INT  NOT NULL,

);
GO

--DROP TABLE College.Staff;
SELECT * FROM College.Staff;

CREATE TABLE College.Course
(
courseId INT IDENTITY(1,1) PRIMARY KEY,
courseName NVARCHAR(100) NOT NULL,
instructorId INT  NOT NULL,
FOREIGN KEY (instructorId) REFERENCES College.Staff(staffId),
departmentId INT  NOT NULL,
FOREIGN KEY (departmentId) REFERENCES College.Department(departmentId),
);
GO

SELECT * FROM College.Course;

CREATE TABLE College.Room
(
roomId INT IDENTITY(1,1) PRIMARY KEY,
rName NVARCHAR(200) NOT NULL,
occupation int not null,
rDescription NVARCHAR(500) NOT NULL,
);
GO

SELECT * FROM College.Room;


CREATE TABLE College.Booking
(
bookingId INT IDENTITY(1,1) PRIMARY KEY,
roomId INT NULL,
FOREIGN KEY (roomId) REFERENCES College.Room(roomId),
bDate DATE NOT NULL,
CHECK (bdate>= GETDATE()-1),
courseId INT NULL,
FOREIGN KEY (courseId) REFERENCES College.Course(courseId),
section NVARCHAR(50) NOT NULL,
);
GO

SELECT * FROM College.Booking;

--DROP TABLE College.Booking;
--GO
CREATE TABLE College.Student
(
studentId INT IDENTITY(1,1) PRIMARY KEY,
firstName NVARCHAR(100) NOT NULL,
lastName NVARCHAR(100) NOT NULL,
section NVARCHAR(50) NOT NULL,
courseId INT NULL,
FOREIGN KEY (courseId) REFERENCES College.Course(courseId),
feeInfo NVARCHAR(100) NOT NULL,
phone NVARCHAR(20) NOT NULL,
email NVARCHAR(100) NOT NULL,

);
GO

SELECT * FROM College.Student;


CREATE TABLE College.Section
(
sectionId INT IDENTITY(1,1) PRIMARY KEY,
section NVARCHAR(20) NOT NULL,
sectionInitialTime TIME NOT NULL,
sectionEndTime TIME NOT NULL,
);
GO

SELECT * FROM College.Section;



--INDEX

CREATE NONCLUSTERED INDEX IX_date
ON College.Booking (bDate ASC);
GO


--Constraints

ALTER TABLE College.Student
	ADD CONSTRAINT df_feeInfo
	DEFAULT 'no info' FOR feeInfo;
GO



ALTER TABLE College.Booking
ADD  updateAt DATETIME;
GO







--TRIGGER


CREATE TRIGGER College.trg_insert_at
ON College.Booking
AFTER INSERT
AS
BEGIN
SET NOCOUNT ON;
SET ROWCOUNT 0;
BEGIN TRY
INSERT INTO College.Booking([bDate],[courseId],[section],[roomId],[updateAt])
SELECT 
[bDate],[courseId],[section],[roomId],SYSDATETIME()
FROM inserted;
END TRY
BEGIN CATCH
	IF XACT_STATE() <> 0
			ROLLBACK TRANSACTION;
		THROW;
	END CATCH
	END
GO

CREATE TRIGGER College.trg_update_at
ON College.Booking
AFTER UPDATE
AS
BEGIN
SET NOCOUNT ON;
SET ROWCOUNT 0;
BEGIN TRY
UPDATE College.Booking 
SET bDate = inserted.bDate, 
    courseId=inserted.courseId,
	section=inserted.section,
	roomId=inserted.section,
	updateAt=SYSDATETIME()
FROM College.Booking JOIN inserted ON Booking.bookingId=inserted.bookingId;

END TRY

BEGIN CATCH
	IF XACT_STATE() <> 0
			ROLLBACK TRANSACTION;
		THROW;
	END CATCH
	END
GO


--DROP INDEX IX_date ON College.Booking;
--GO



--VIEWS

CREATE VIEW College.BookingWeek
AS
SELECT College.Booking.bookingId, College.Course.courseName, College.Room.rName, College.Section.section
FROM College.Booking
INNER JOIN College.Course ON College.Course.courseId= College.Booking.courseId
INNER JOIN College.Room ON College.Room.roomId = College.Booking.roomId
INNER JOIN College.Section ON College.Section.sectionId=College.Booking.section
WHERE  (bDate >= GETDATE()-1) AND (bDate <= GETDATE()+7);
GO


SELECT * FROM College.BookingWeek;
GO

SELECT * FROM College.Booking;


CREATE VIEW College.BookingAll
AS
SELECT College.Booking.bDate, College.Course.courseName, College.Room.rName, College.Section.section
FROM College.Booking
INNER JOIN College.Course ON College.Course.courseId= College.Booking.courseId
INNER JOIN College.Room ON College.Room.roomId = College.Booking.roomId
INNER JOIN College.Section ON College.Section.sectionId=College.Booking.section;
GO
SELECT * FROM College.BookingAll;
GO
SELECT * FROM College.Booking;


--PROCEDURES

CREATE PROCEDURE SelectScheduledRoom @roomId INT
AS
SELECT College.Booking.bDate, College.Course.courseName, College.Room.rName, College.Section.section 
FROM College.Booking 
INNER JOIN College.Course ON College.Course.courseId= College.Booking.courseId
INNER JOIN College.Room ON College.Room.roomId = College.Booking.roomId
INNER JOIN College.Section ON College.Section.sectionId=College.Booking.section
WHERE College.Booking.roomId=@roomId;
GO



EXEC SelectScheduledRoom @roomId='2';



CREATE PROCEDURE College.SelectTodayBooking
AS
SELECT DISTINCT College.Booking.bDate, College.Course.courseName, College.Room.rName, College.Section.section 
FROM College.Booking 
INNER JOIN College.Course ON College.Course.courseId= College.Booking.courseId
INNER JOIN College.Room ON College.Room.roomId = College.Booking.roomId
INNER JOIN College.Section ON College.Section.sectionId=College.Booking.section
WHERE College.Booking.bDate> GETDATE()-1 AND College.Booking.bDate< GETDATE();
GO

--DROP PROCEDURE College.SelectTodayBooking;
--GO

EXEC  College.SelectTodayBooking;
GO



CREATE PROCEDURE College.DepartmentHead
AS
SELECT DISTINCT College.Department.departmentName, College.Staff.firstName, College.Staff.lastName, College.Position.positionName, College.Staff.head 
FROM College.Staff 
INNER JOIN College.Department ON College.Department.departmentId= College.Staff.departmentId
INNER JOIN College.Position ON College.Position.positionId = College.Staff.positionId
WHERE College.Staff.head = 1;
GO

EXEC College.DepartmentHead;
GO
SELECT * FROM College.Booking;
GO






SELECT * FROM College.Booking;
GO