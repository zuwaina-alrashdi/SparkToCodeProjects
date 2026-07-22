CREATE DATABASE CompanyDB;
GO

USE CompanyDB;
GO

CREATE TABLE Department
(
    Department_Number INT PRIMARY KEY,

    Department_Name VARCHAR(50) NOT NULL UNIQUE,

    Manager_SSN CHAR(9) NULL,

    ManagerStartDate DATE
);
GO

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

ALTER TABLE Department
ADD CONSTRAINT FK_Department_Manager
FOREIGN KEY (Manager_SSN)
REFERENCES Employee(SSN);
GO

INSERT INTO Department
(Department_Number, Department_Name, Manager_SSN, ManagerStartDate)
VALUES
(1,'IT',NULL,NULL),
(2,'HR',NULL,NULL);
GO

INSERT INTO Employee
(SSN,Fname,Minit,Lname,Address,Sex,Bdate,Salary,Department_Number,Supervisor_SSN)
VALUES
('111111111','Ahmed','A','Ali','Muscat','M','1990-05-10',2500,1,NULL),

('222222222','Sara','M','Salim','Muscat','F','1995-07-15',1800,1,'111111111'),

('333333333','Omar','K','Hassan','Sohar','M','1993-09-20',1700,2,NULL);
GO