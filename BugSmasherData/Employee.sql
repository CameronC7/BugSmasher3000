CREATE TABLE [dbo].[Employee]
(
   EmpID         INT             NOT NULL,   
   FirstName     NVARCHAR(20)    NOT NULL,   
   LastName      NVARCHAR(20)    NOT NULL,   
   Email         VARCHAR(30)     NOT NULL,   
   PositionID    INT             NOT NULL,   
   PRIMARY KEY (EmpID),   
   FOREIGN KEY (PositionID) REFERENCES Position(PositionID)
)
