/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
INSERT INTO Position (PositionID, PosTitle)
VALUES (1, 'Admin');

INSERT INTO Employee (EmpID, FirstName, LastName, Email, PositionID)
VALUES (1, 'Cameron', 'Cox', 'cameroncox007@yahoo.com', 1);

INSERT INTO LoginInfo (UserName, UserPassword, EmpID, PositionID)
VALUES ('CameronC7', 'Password123', 1, 1);

INSERT INTO BugTicket (BugID, Title, BugDesc, Severity, EmpID, StartDate, CompDate)
VALUES (1, 'First Bug!', 'This is the worst of bugs', 1, 1, '2020-02-16', '2020-02-16')