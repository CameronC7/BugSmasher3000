CREATE TABLE [dbo].[BugTicket]
(
   BugID         INT             NOT NULL,   
   Title         VARCHAR(20)     NOT NULL,   
   BugDesc       VARCHAR(100)    NOT NULL,   
   Severity      INT             NOT NULL,   
   EmpID         INT,   
   StartDate     DATE,   
   CompDate      DATE   
   PRIMARY KEY (BugID),   
   FOREIGN KEY (EmpID) REFERENCES Employee(EmpID)
)
