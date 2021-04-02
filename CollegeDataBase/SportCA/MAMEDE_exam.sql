--Ex2
CREATE DATABASE Sports_CA_MAMEDE;
GO

USE Sports_CA_MAMEDE;
GO
--Ex3
CREATE SCHEMA SportsCA;
GO
--Ex4
CREATE TABLE SportsCA.Participant
(
participantId INT IDENTITY(1,1) PRIMARY KEY,
pFirstName NVARCHAR(200) NOT NULL,
pLastName NVARCHAR(200) NOT NULL,
pBirthDate DATE NOT NULL,
pEmail NVARCHAR(100) UNIQUE NOT NULL,
pPassword NVARCHAR(50) NOT NULL,
);
GO


--DROP TABLE SportsCA.Participant;
--GO


CREATE TABLE SportsCA.SportEvent
(
eventId INT IDENTITY(1,1) PRIMARY KEY,
eName NVARCHAR(200) NOT NULL,
eDescription NVARCHAR(1000) NOT NULL,
eLocation NVARCHAR(200) NOT NULL,
eDate DATETIME NOT NULL,
eRegistrationCost SMALLMONEY NOT NULL,
eSportType NVARCHAR(100) NOT NULL,
eRegistrationCloseDate DATETIME NOT NULL,

);
GO



CREATE TABLE SportsCA.Registration
(
registrationId INT IDENTITY(1,1) PRIMARY KEY,
rAmountPaid SMALLMONEY NOT NULL,
rPaymentDate DATETIME NOT NULL,
rEventId INT NOT NULL,

FOREIGN KEY (rEventId) REFERENCES SportsCA.SportEvent(eventId),
rParticipantId INT  NOT NULL,
FOREIGN KEY (rParticipantId) REFERENCES SportsCA.Participant(participantId),
regDate DATETIME,
);
GO




CREATE TRIGGER SportsCA.trg_insert_at
ON SportsCA.Registration
AFTER INSERT
AS
BEGIN
SET NOCOUNT ON;
SET ROWCOUNT 0;
BEGIN TRY
INSERT INTO SportsCA.Registration([rAmountPaid],[rPaymentDate],[rEventId],[rParticipantId],[regDate])
SELECT 
[rAmountPaid],[rPaymentDate],[rEventId],[rParticipantId],SYSDATETIME()
FROM inserted;
END TRY
BEGIN CATCH
	IF XACT_STATE() <> 0
			ROLLBACK TRANSACTION;
		THROW;
	END CATCH
	END
GO




--Ex5_a

CREATE NONCLUSTERED INDEX IX_EventName
ON SportsCA.SportEvent (eName ASC);
GO
CREATE NONCLUSTERED INDEX IX_SportType
ON SportsCA.SportEvent (eSportType ASC);
GO
--Ex5_b
CREATE NONCLUSTERED INDEX IX_LastName
ON SportsCA.Participant (pLastName ASC);
GO

CREATE NONCLUSTERED INDEX IX_Email
ON SportsCA.Participant (pEmail ASC);
GO


--Ex6

insert into SportsCA.Participant(pFirstName,pLastName,pBirthDate,pEmail,pPassword) values ('Andre','Mamede','1986-04-01','mamede@email.com','1234');

--Ex7

insert into SportsCA.SportEvent(eName,eDescription,eLocation,eDate,  eRegistrationCost, eSportType,eRegistrationCloseDate ) values ('Toronto FC Children´s Day Cup','´Family friendly event!','170 Princes Blvd, Toronto, ON, M6K 3C3','2021-05-30',15.50,'Soccer', '2021-05-25');


--Ex8

UPDATE SportsCA.SportEvent
SET eDescription = 'All ages welcome. Family friendly event!', eRegistrationCost= '12.50'
WHERE eventId = 1;

--Ex9


CREATE PROCEDURE SportsCA.Participant_Insert
@pFirstName NVARCHAR(200),
@pLastName NVARCHAR(200),
@pBirthDate DATE,
@pEmail NVARCHAR(100),
@pPassword NVARCHAR(50)
AS
INSERT INTO SportsCA.Participant (pFirstName, pLastName, pBirthDate, pEmail, pPassword) VALUES (@pFirstName,@pLastName,@pBirthDate,@pEmail,@pPassword);
GO

EXEC SportsCA.Participant_Insert @pFirstName = 'Isabel',@pLastName = 'Amorim',@pBirthDate = '1994-11-04',@pEmail = 'bel@email.com',@pPassword = '1234';

--SELECT * FROM SportsCA.Participant;

--Ex10
CREATE PROCEDURE SportsCA.Participant_Update
@participantId INT,
@pFirstName NVARCHAR(200),
@pLastName NVARCHAR(200),
@pBirthDate DATE,
@pEmail NVARCHAR(100),
@pPassword NVARCHAR(50)
AS
UPDATE SportsCA.Participant
SET 
pFirstName=@pFirstName, 
pLastName=@pLastName,
pBirthDate=@pBirthDate,
pEmail=@pEmail, 
pPassword=@pPassword

WHERE participantId= @participantId;
GO

EXEC SportsCA.Participant_Update @participantId=2, @pFirstName = 'Isabela',@pLastName = 'Amorim',@pBirthDate = '1994-11-04',@pEmail = 'bel@email.com',@pPassword = '4321';


--Ex11
CREATE PROCEDURE SportsCA.Participant_Delete
	@participantId INT
AS
	DELETE FROM SportsCA.Participant
	WHERE participantId= @participantId;
GO

EXEC SportsCA.Participant_Delete @participantId=2;


--Ex12

CREATE PROCEDURE SportsCA.SportEvent_Insert
@eName NVARCHAR(200) ,
@eDescription NVARCHAR(1000) ,
@eLocation NVARCHAR(200),
@eDate DATETIME ,
@eRegistrationCost SMALLMONEY ,
@eSportType NVARCHAR(100),
@eRegistrationCloseDate DATETIME
AS
INSERT INTO  SportsCA.SportEvent (eName, eDescription, eLocation, eDate, eRegistrationCost,eSportType,eRegistrationCloseDate) VALUES (@eName,@eDescription,@eLocation,@eDate,@eRegistrationCost,@eSportType,@eRegistrationCloseDate);
GO

--Ex13
CREATE PROCEDURE SportsCA.SportEvent_Update
@eventId INT,
@eName NVARCHAR(200) ,
@eDescription NVARCHAR(1000) ,
@eLocation NVARCHAR(200),
@eDate DATETIME ,
@eRegistrationCost SMALLMONEY ,
@eSportType NVARCHAR(100),
@eRegistrationCloseDate DATETIME
AS
UPDATE SportsCA.SportEvent
SET 

eName=@eName,
eDescription=@eDescription,
eLocation=@eLocation,
eDate=@eDate, 
eRegistrationCost=@eRegistrationCost,
eSportType=@eSportType,
eRegistrationCloseDate=@eRegistrationCloseDate

WHERE eventId= @eventId;
GO


--Ex14
CREATE PROCEDURE SportsCA.SportEvent_Delete
	@eventId INT
AS
	DELETE FROM SportsCA.SportEvent
	WHERE eventId= @eventId;
GO


--Ex15
insert into SportsCA.Registration(rAmountPaid,rPaymentDate,rEventId,rParticipantId) values (12.5,'2021-04-01',1,1);

CREATE VIEW SportsCA.RegistrationOrderedDate
AS
SELECT * FROM SportsCA.Registration
ORDER BY regDate;

