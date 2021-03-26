CREATE DATABASE CollegeDataBase;
GO

USE CollegeDataBase;
GO

CREATE SCHEMA College;
GO

CREATE TABLE College.Student
(
studentId INT IDENTITY(1,1) PRIMARY KEY,
firstName NVARCHAR(100) NOT NULL,
lastName NVARCHAR(100) NOT NULL,
section NVARCHAR(50) NOT NULL,
--courseId INT NOT NULL,
feeInfo NVARCHAR(100) NOT NULL,
phone NVARCHAR(20) NOT NULL,
email NVARCHAR(100) NOT NULL,

);
GO


ALTER TABLE College.Student
	ADD CONSTRAINT df_feeInfo
	DEFAULT 'no info' FOR feeInfo;
GO

CREATE TABLE College.Staff
(
staffId INT IDENTITY(1,1) PRIMARY KEY,
firstName NVARCHAR(100) NOT NULL,
lastName NVARCHAR(100) NOT NULL,
--position INT  NOT NULL,
--department INT  NOT NULL,
salary NVARCHAR(100) NOT NULL,
);
GO



CREATE TABLE College.Course
(
courseId INT IDENTITY(1,1) PRIMARY KEY,
courseName NVARCHAR(100) NOT NULL,
--instructorId INT  NOT NULL,
);
GO




--DROP TABLE College.Course;
--GO
CREATE TABLE College.Booking
(
bookingId INT IDENTITY(1,1) PRIMARY KEY,
--roomId INT NOT NULL ,
bDate DATETIME NOT NULL,
courseId INT NOT NULL,
FOREIGN KEY (courseId) REFERENCES College.Course(courseId),
section NVARCHAR(50) NOT NULL,
);
GO

CREATE NONCLUSTERED INDEX IX_date
ON College.Booking (bDate);
GO

CREATE TABLE College.Room
(
roomId INT IDENTITY(1,1) PRIMARY KEY,
rName NVARCHAR(200) NOT NULL,
occupation int not null,
rDescription NVARCHAR(500) NOT NULL,
);
GO


--DROP TABLE College.Booking;
--GO


CREATE NONCLUSTERED INDEX index_date
ON College.Booking(bdate);
GO

CREATE TABLE College.Position
(
positionId INT IDENTITY(1,1) PRIMARY KEY,
pName NVARCHAR(200) NOT NULL,
atribures NVARCHAR(500) NOT NULL,
);
GO

CREATE TABLE College.Department
(
departmentId INT IDENTITY(1,1) PRIMARY KEY,
dName NVARCHAR(200) NOT NULL,
headId INT  NOT NULL,
FOREIGN KEY (headId) REFERENCES College.Staff(staffId),
);
GO
--DROP TABLE College.Departments;
--GO


--FOREIGN KEYS
ALTER TABLE College.Student
ADD courseId INT NOT NULL,
FOREIGN KEY (courseId) REFERENCES College.Course(courseId);
GO


ALTER TABLE College.Staff
ADD positionId INT NOT NULL,
FOREIGN KEY (positionId) REFERENCES College.Position(positionId);
GO

ALTER TABLE College.Staff
ADD departmentId INT NOT NULL,
FOREIGN KEY (departmentId) REFERENCES College.Department(departmentId);
GO

ALTER TABLE College.Course
ADD instructorId INT NOT NULL,
FOREIGN KEY (instructorId) REFERENCES College.Staff(staffId);
GO

ALTER TABLE College.Booking
ADD roomId INT NOT NULL,
FOREIGN KEY (roomId) REFERENCES College.Room(roomId);
GO

ALTER TABLE College.Booking
ADD  updateAt DATETIME;
GO

CREATE VIEW College.BookingWeek
AS
SELECT bookingId, roomId, bDate, courseId, section
FROM College.Booking
WHERE bDate BETWEEN  
CAST(DATEADD(WEEK,DATEDIFF(WEEK,0,GETDATE())-1,0) AS DATE)
    AND 
    CAST(DATEADD(WEEK,DATEDIFF(WEEK,0,GETDATE())-1,4) AS DATE);
GO
--DROP VIEW College.BookingWeek;
--GO

SELECT * FROM College.BookingWeek;
GO




--PROCEDURES
CREATE PROCEDURE College.SelectTodayBooking
AS
SELECT * FROM College.Booking WHERE bDate = GETDATE();
GO




EXEC  College.SelectTodayBooking;
GO

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
--DROP TRIGGER College.trg_update_at;

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