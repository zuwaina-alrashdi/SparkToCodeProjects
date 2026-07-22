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



