
USE CollegeDataBase;
GO

--Position

insert into College.Position(positionName, atributes) values ('Teacher', 'responsible for preparing lesson plans and educating students at all levels. Their duties include assigning homework, grading tests, and documenting progress. Teachers must be able to instruct in the required subject and reach students with engaging lesson plans.');
insert into College.Position(positionName, atributes) values ('Secretary', 'personal assistant is a person whose work consists of supporting management, including executives, using a variety of project management, communication, or organizational skills.');
insert into College.Position(positionName, atributes) values ('Computer lab technician', ' responsible for helping students in problems related to computers, monitoring the work of lab assistants, and troubleshooting hardware and software problems.');

--Departments

insert into College.Department(departmentName) values ('Administration');
insert into College.Department(departmentName) values ('Information technology');
insert into College.Department(departmentName) values ('Business');
insert into College.Department(departmentName) values ('Tourism');

--Staff
insert into College.Staff (firstName, lastName, positionId, departmentId, salary) values ('Cindra', 'Tigner', 1, 4, '$4272.97');
insert into College.Staff (firstName, lastName, positionId, departmentId, salary) values ('Dacie', 'MacGee', 2, 2, '$2021.87');
insert into College.Staff (firstName, lastName, positionId, departmentId, salary) values ('Sheila', 'Elintune', 2, 4, '$4804.71');
insert into College.Staff (firstName, lastName, positionId, departmentId, salary) values ('Hoyt', 'Dragoe', 1, 2, '$5245.33');
insert into College.Staff (firstName, lastName, positionId, departmentId, salary) values ('Tatiana', 'Bowstead', 1, 1, '$4750.85');
insert into College.Staff (firstName, lastName, positionId, departmentId, salary) values ('Mirella', 'Brearley', 1, 1, '$4643.79');
insert into College.Staff (firstName, lastName, positionId, departmentId, salary) values ('Nicoline', 'Coppen', 2, 3, '$3992.99');
insert into College.Staff (firstName, lastName, positionId, departmentId, salary) values ('Winne', 'Beaument', 2, 2, '$2079.12');
insert into College.Staff (firstName, lastName, positionId, departmentId, salary) values ('Matthiew', 'Hacon', 1, 3, '$5975.83');
insert into College.Staff (firstName, lastName, positionId, departmentId, salary) values ('Sydney', 'Jagg', 1, 1, '$3362.34');
insert into College.Staff (firstName, lastName, positionId, departmentId, salary) values ('Carlos', 'Walsh', 1, 1, '$4567.51');
insert into College.Staff (firstName, lastName, positionId, departmentId, salary) values ('Burg', 'Symondson', 3, 3, '$4994.40');
insert into College.Staff (firstName, lastName, positionId, departmentId, salary) values ('Rey', 'Aspell', 3, 4, '$4316.41');
insert into College.Staff (firstName, lastName, positionId, departmentId, salary) values ('Shalna', 'Spanton', 1, 4, '$3403.35');
insert into College.Staff (firstName, lastName, positionId, departmentId, salary) values ('Valentin', 'Rens', 3, 2, '$3537.44');


--Course
insert into College.Course (courseName, instructorId, departmentId) values ('Administrative Assistant Diploma',5,1);
insert into College.Course (courseName, instructorId, departmentId) values ('Business Administration Diploma',7,3);
insert into College.Course (courseName, instructorId, departmentId) values ('Business Management& Entrepreneurship Diploma',12,3);
insert into College.Course (courseName, instructorId, departmentId) values ('Programmer Analyst Diploma',4,2);
insert into College.Course (courseName, instructorId, departmentId) values ('Travel & Tourism Diploma',14,4);
--Room

insert into College.Room (rName, occupation, rDescription) values ('Adam Smith', 15, 'Class room');
insert into College.Room (rName, occupation, rDescription) values ('Colombo', 15, 'Class room');
insert into College.Room (rName, occupation, rDescription) values ('Sam Walton', 15, 'Class room');
insert into College.Room (rName, occupation, rDescription) values ('Alan Turing', 16, 'Labortory, 8 computers');
insert into College.Room (rName, occupation, rDescription) values ('IBT-Conference Room', 30, 'Conference room');
GO

--Section 
insert into College.Section (section, sectionInitialTime, sectionEndTime) values ('Morning', '8:00 AM', '12:00 PM');
insert into College.Section (section, sectionInitialTime, sectionEndTime) values ('Afternoon', '1:00 PM', '5:00 PM');
insert into College.Section (section, sectionInitialTime, sectionEndTime) values ('Evening', '5:00 PM', '9:00 PM');
--Booking

insert into College.Booking (roomId, bDate, courseId, section) values (1, '7/11/2021', 1, 1);
insert into College.Booking (roomId, bDate, courseId, section) values (2, '2/24/2021', 2, 3);
insert into College.Booking (roomId, bDate, courseId, section) values (3, '11/26/2021', 3, 2);
insert into College.Booking (roomId, bDate, courseId, section) values (4, '2/18/2021', 4, 1);
insert into College.Booking (roomId, bDate, courseId, section) values (3, '10/25/2021', 5, 3);
insert into College.Booking (roomId, bDate, courseId, section) values (2, '2/11/2021', 4, 2);
insert into College.Booking (roomId, bDate, courseId, section) values (1, '6/23/2021', 2, 3);
insert into College.Booking (roomId, bDate, courseId, section) values (4, '10/29/2021', 1, 1);
insert into College.Booking (roomId, bDate, courseId, section) values (5, '2/8/2021', 5, 3);
insert into College.Booking (roomId, bDate, courseId, section) values (3, '1/2/2021', 3, 1);

insert into College.Booking (roomId, bDate, courseId, section) values (3, '3/30/2021', 3, 1);
insert into College.Booking (roomId, bDate, courseId, section) values (3, '3/31/2021', 5, 2);
insert into College.Booking (roomId, bDate, courseId, section) values (3, '4/1/2021', 2, 3);
insert into College.Booking (roomId, bDate, courseId, section) values (3, '4/2/2021', 4, 2);


--student
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Carroll', 'Winfield', 1, 4, '$9687.94', '605-356-2103', 'cwinfield0@woothemes.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Ethan', 'Seelbach', 3, 5, '$10561.31', '570-468-7218', 'eseelbach1@seattletimes.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Henryetta', 'Budnik', 3, 2, '$9725.26', '985-974-1067', 'hbudnik2@nasa.gov');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Clarine', 'Coxall', 1, 2, '$10362.46', '439-343-4261', 'ccoxall3@hc360.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Cati', 'Alwin', 3, 5, '$9223.19', '213-889-0834', 'calwin4@prweb.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Robinetta', 'Gartside', 3, 2, '$9831.02', '298-839-9085', 'rgartside5@uol.com.br');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Barnard', 'Whyley', 3, 1, '$9686.02', '713-666-9100', 'bwhyley6@cocolog-nifty.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Lynnell', 'Week', 2, 3, '$10058.17', '169-633-6561', 'lweek7@weebly.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Hew', 'Chaudhry', 1, 5, '$9106.78', '523-921-3039', 'hchaudhry8@shop-pro.jp');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Boniface', 'Jeste', 1, 3, '$9973.84', '844-447-4357', 'bjeste9@prweb.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Abeu', 'Mewton', 2, 2, '$9077.28', '321-955-8017', 'amewtona@squarespace.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Genovera', 'Thew', 2, 1, '$10181.99', '699-940-1054', 'gthewb@liveinternet.ru');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Rafa', 'Turfes', 1, 5, '$10070.12', '334-475-6455', 'rturfesc@lycos.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Nyssa', 'Ollet', 2, 2, '$10514.28', '839-601-4318', 'nolletd@disqus.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Grenville', 'Barthelme', 2, 3, '$9210.49', '688-542-1367', 'gbarthelmee@globo.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Elfrida', 'McWhirter', 3, 3, '$10615.68', '891-834-1309', 'emcwhirterf@nationalgeographic.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Fayina', 'Casazza', 2, 4, '$10115.41', '901-485-8689', 'fcasazzag@si.edu');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Melba', 'Bercher', 3, 1, '$10585.40', '496-242-8910', 'mbercherh@wikimedia.org');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Wolfgang', 'Rozycki', 2, 4, '$9247.11', '542-769-8808', 'wrozyckii@studiopress.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Benson', 'Pietraszek', 1, 2, '$10669.16', '764-519-3805', 'bpietraszekj@zimbio.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Phil', 'Roma', 3, 3, '$10098.10', '462-220-6813', 'promak@e-recht24.de');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Fianna', 'Petrina', 3, 2, '$9629.11', '555-506-7958', 'fpetrinal@ifeng.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Delilah', 'Risbie', 1, 5, '$9446.27', '650-200-9706', 'drisbiem@dyndns.org');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Toddy', 'Dantesia', 3, 3, '$10935.50', '669-737-5936', 'tdantesian@scientificamerican.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Giorgia', 'Gerrish', 2, 5, '$9001.59', '708-311-2675', 'ggerrisho@webnode.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Stacee', 'Ferres', 1, 4, '$9133.52', '545-966-6119', 'sferresp@soup.io');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Claudina', 'Smillie', 3, 3, '$10354.85', '252-665-1391', 'csmillieq@mashable.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Naoma', 'Trimmell', 1, 5, '$9051.89', '692-144-1549', 'ntrimmellr@paypal.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Emile', 'Reuben', 2, 1, '$9493.82', '209-867-4817', 'ereubens@cdbaby.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Clarice', 'Norres', 2, 1, '$10132.05', '622-702-3864', 'cnorrest@com.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Rufe', 'Tartt', 2, 3, '$10355.63', '772-528-6822', 'rtarttu@mapquest.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Roberta', 'Bullock', 1, 1, '$10755.00', '194-249-3410', 'rbullockv@columbia.edu');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Celine', 'Lacroux', 2, 1, '$9575.84', '635-226-2319', 'clacrouxw@smugmug.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Babb', 'Rickerby', 1, 5, '$9569.93', '699-947-9363', 'brickerbyx@bigcartel.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Myles', 'Tamblyn', 2, 5, '$10951.41', '647-899-8974', 'mtamblyny@storify.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Georgia', 'Greenhow', 2, 2, '$10614.32', '750-440-2368', 'ggreenhowz@t.co');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Dory', 'Jeffes', 3, 4, '$10107.04', '359-943-3843', 'djeffes10@nasa.gov');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Davin', 'Kembery', 1, 3, '$10787.65', '978-932-2252', 'dkembery11@java.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Gizela', 'Vanyukov', 3, 1, '$10596.41', '987-152-9394', 'gvanyukov12@netlog.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Finley', 'Duncan', 1, 2, '$9367.15', '127-766-8240', 'fduncan13@dagondesign.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Harriot', 'Moylan', 2, 4, '$9825.86', '198-890-6946', 'hmoylan14@soup.io');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Hugo', 'Signoret', 3, 1, '$10495.29', '938-341-9428', 'hsignoret15@independent.co.uk');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Ozzie', 'Semiraz', 1, 5, '$9590.96', '324-966-5219', 'osemiraz16@ustream.tv');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Ade', 'Raatz', 2, 1, '$9874.73', '428-976-6922', 'araatz17@usnews.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Hally', 'Matskiv', 3, 5, '$10274.16', '950-600-6771', 'hmatskiv18@posterous.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Margaux', 'Shaddock', 2, 5, '$10944.07', '985-296-6280', 'mshaddock19@harvard.edu');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Hughie', 'Leason', 2, 5, '$9648.31', '263-457-4314', 'hleason1a@artisteer.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Grata', 'Gosland', 3, 1, '$10816.82', '649-334-3458', 'ggosland1b@shareasale.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Gabie', 'Clitsome', 3, 3, '$10539.35', '530-542-2735', 'gclitsome1c@barnesandnoble.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Doretta', 'Liddicoat', 1, 2, '$9001.67', '427-372-8110', 'dliddicoat1d@xrea.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Judah', 'Krystek', 1, 1, '$9129.70', '620-972-0803', 'jkrystek1e@bizjournals.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Ciel', 'Stopps', 3, 3, '$9865.67', '837-344-5823', 'cstopps1f@howstuffworks.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Archy', 'Jozefowicz', 1, 1, '$10759.56', '182-291-0115', 'ajozefowicz1g@t-online.de');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Loleta', 'Fanstone', 3, 5, '$9272.17', '356-595-0072', 'lfanstone1h@redcross.org');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Humfrid', 'Burbudge', 2, 3, '$9035.43', '226-700-0025', 'hburbudge1i@artisteer.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Heidie', 'Shuttlewood', 2, 2, '$9103.25', '638-805-2252', 'hshuttlewood1j@microsoft.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Lilia', 'Tiler', 2, 1, '$9292.85', '297-319-5145', 'ltiler1k@theguardian.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Trenna', 'Wardrop', 1, 3, '$10618.22', '907-630-3771', 'twardrop1l@cloudflare.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Gale', 'Suttie', 3, 4, '$9499.20', '202-160-2476', 'gsuttie1m@icq.com');
insert into College.Student (firstName, lastName, section, courseId, feeInfo, phone, email) values ('Berkly', 'Woolaghan', 3, 1, '$9241.55', '186-478-8622', 'bwoolaghan1n@livejournal.com');


