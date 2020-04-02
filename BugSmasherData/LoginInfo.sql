CREATE TABLE [dbo].[LoginInfo]
(
   UserName      VARCHAR(20)     NOT NULL,   
   UserPassword  VARCHAR(20)     NOT NULL,   
   EmpID         INT             NOT NULL,   
   PositionID    INT             NOT NULL   
   PRIMARY KEY (UserName),   
   FOREIGN KEY (EmpID) REFERENCES Employee(EmpID),  
   FOREIGN KEY (PositionID) REFERENCES Position(PositionID)
)
