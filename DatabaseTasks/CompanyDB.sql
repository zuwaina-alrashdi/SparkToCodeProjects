/* CREATE COMPANY DATABASE */

CREATE DATABASE CompanyDB;
GO

USE CompanyDB;
GO

/* Department TABLE */

CREATE TABLE Department
(
    Department_Number INT PRIMARY KEY,

    Department_Name VARCHAR(50) NOT NULL UNIQUE,

    Manager_SSN CHAR(9) NULL,

    ManagerStartDate DATE
);
GO

/* Employee TABLE */

CREATE TABLE Employee
(
    SSN CHAR(9) PRIMARY KEY,

    Fname VARCHAR(30) NOT NULL,

    Minit CHAR(1),

    Lname VARCHAR(30) NOT NULL,

    Address VARCHAR(100),

    Sex CHAR(1) CHECK (Sex IN ('M','F')),

    Bdate DATE,

    Salary DECIMAL(10,2) CHECK (Salary > 0),

    Department_Number INT NOT NULL,

    Supervisor_SSN CHAR(9)
);
GO

/* Employee Foreign Keys */

ALTER TABLE Employee
ADD CONSTRAINT FK_Employee_Department
FOREIGN KEY (Department_Number)
REFERENCES Department(Department_Number);
GO

ALTER TABLE Employee
ADD CONSTRAINT FK_Employee_Supervisor
FOREIGN KEY (Supervisor_SSN)
REFERENCES Employee(SSN);
GO

/* Project Table */ 

CREATE TABLE Project
(
    Project_Number INT PRIMARY KEY,

    Project_Name VARCHAR(50) NOT NULL UNIQUE,

    Location VARCHAR(50) NOT NULL,

    Department_Number INT NOT NULL,

    CONSTRAINT FK_Project_Department
    FOREIGN KEY (Department_Number)
    REFERENCES Department(Department_Number)
);
GO

/* Department Location Table */

CREATE TABLE Department_Location
(
    Department_Number INT NOT NULL,

    Location VARCHAR(50) NOT NULL,

    PRIMARY KEY (Department_Number, Location),

    CONSTRAINT FK_DepartmentLocation_Department
    FOREIGN KEY (Department_Number)
    REFERENCES Department(Department_Number)
);
GO

/* Works_On Table */

CREATE TABLE Works_On
(
    SSN CHAR(9) NOT NULL,

    Project_Number INT NOT NULL,

    Hours DECIMAL(5,2)
        CHECK (Hours >= 0),

    PRIMARY KEY (SSN, Project_Number),

    CONSTRAINT FK_WorksOn_Employee
    FOREIGN KEY (SSN)
    REFERENCES Employee(SSN),

    CONSTRAINT FK_WorksOn_Project
    FOREIGN KEY (Project_Number)
    REFERENCES Project(Project_Number)
);
GO

/* Dependent Table */

CREATE TABLE Dependent
(
    Employee_SSN CHAR(9) NOT NULL,

    Dependent_Name VARCHAR(50) NOT NULL,

    Sex CHAR(1)
        CHECK (Sex IN ('M','F')),

    Birthdate DATE,

    Relationship VARCHAR(30),

    PRIMARY KEY (Employee_SSN, Dependent_Name),

    CONSTRAINT FK_Dependent_Employee
    FOREIGN KEY (Employee_SSN)
    REFERENCES Employee(SSN)
);
GO

/* Department Manager Foreign Key */

ALTER TABLE Department
ADD CONSTRAINT FK_Department_Manager
FOREIGN KEY (Manager_SSN)
REFERENCES Employee(SSN);
GO

/* Insert data into Department table*/

INSERT INTO Department
(Department_Number, Department_Name, Manager_SSN, ManagerStartDate)
VALUES
(1,'IT',NULL,NULL),
(2,'HR',NULL,NULL);
GO

/* Insert data into Employee table*/

INSERT INTO Employee
(SSN,Fname,Minit,Lname,Address,Sex,Bdate,Salary,Department_Number,Supervisor_SSN)
VALUES
('111111111','Ahmed','A','Ali','Muscat','M','1990-05-10',2500,1,NULL),

('222222222','Sara','M','Salim','Muscat','F','1995-07-15',1800,1,'111111111'),

('333333333','Omar','K','Hassan','Sohar','M','1993-09-20',1700,2,NULL);
GO

/* Update Department table*/

UPDATE Department
SET Manager_SSN='111111111',
ManagerStartDate='2024-01-01'
WHERE Department_Number=1;

UPDATE Department
SET Manager_SSN='333333333',
ManagerStartDate='2024-02-01'
WHERE Department_Number=2;
GO

/* Insert data into Department table*/

INSERT INTO Department_Location
VALUES
(1,'Muscat'),
(1,'Nizwa'),
(2,'Sohar');
GO

/* Insert data into project table */

INSERT INTO Project
(Project_Number,Project_Name,Location,Department_Number)
VALUES
(101,'Payroll System','Muscat',1),
(102,'HR Portal','Sohar',2);
GO

/* Insert data into works_on table */

INSERT INTO Works_On
VALUES
('111111111',101,20),

('222222222',101,35),

('333333333',102,30);
GO

/* Insert data into Dependent table */

INSERT INTO Dependent
(Employee_SSN, Dependent_Name, Sex, Birthdate, Relationship)
VALUES
('111111111','Fatima','F','2018-04-10','Daughter'),

('222222222','Ali','M','2020-06-15','Son');
GO

/* Update Employee table*/

UPDATE Employee
SET Salary = Salary + 500
WHERE SSN = '222222222';
GO

/* Update Project table*/

UPDATE Project
SET Location = 'Nizwa'
WHERE Project_Number = 101;
GO

/* Update works_on table*/

UPDATE Works_On
SET Hours = 40
WHERE SSN = '222222222'
AND Project_Number = 101;
GO

/* Delete from works_on table*/

DELETE FROM Works_On
WHERE SSN = '333333333'
AND Project_Number = 102;
GO

/* Delete from Dependent table*/

DELETE FROM Dependent
WHERE Employee_SSN = '222222222'
AND Dependent_Name = 'Ali';
GO

/* Select Statements */

SELECT * FROM Department;

SELECT * FROM Employee;

SELECT * FROM Department_Location;

SELECT * FROM Project;

SELECT * FROM Works_On;

SELECT * FROM Dependent;



