CREATE DATABASE trainticket;

USE trainticket;

CREATE TABLE User;
(
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(100) NOT NULL,
    Password VARCHAR(100) NOT NULL
);