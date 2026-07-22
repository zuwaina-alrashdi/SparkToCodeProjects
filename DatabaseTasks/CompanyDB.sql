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

