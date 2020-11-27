    --
-- File generated with SQLiteStudio v3.2.1 on vie. nov. 27 14:15:33 2020
--
-- Text encoding used: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: Assignature
DROP TABLE IF EXISTS Assignature;

CREATE TABLE Assignature (
    IdAssignature INTEGER PRIMARY KEY AUTOINCREMENT,
    IdTeacher     INTEGER REFERENCES Teacher (IdTeacher),
    IdSubject     INTEGER REFERENCES Subject (IdSubject),
    IdGroup       INTEGER REFERENCES [Group] (IdGroup) 
);


-- Table: Group
DROP TABLE IF EXISTS [Group];

CREATE TABLE [Group] (
    IdGroup      INTEGER       PRIMARY KEY AUTOINCREMENT,
    IdPeriodKind VARCHAR (100) REFERENCES PeriodKind (IdPeriodKind),
    Name         VARCHAR (10),
    StartDate    DATE,
    CloseDate    DATE
);


-- Table: PeriodKind
DROP TABLE IF EXISTS PeriodKind;

CREATE TABLE PeriodKind (
    IdPeriodKind INTEGER       PRIMARY KEY AUTOINCREMENT,
    Name         VARCHAR (100) 
);


-- Table: Subject
DROP TABLE IF EXISTS Subject;

CREATE TABLE Subject (
    IdSubject        INTEGER       PRIMARY KEY AUTOINCREMENT,
    Name             VARCHAR (100),
    TheoreticalHours INT (10),
    PracticalHours   INT (10) 
);


-- Table: Teacher
DROP TABLE IF EXISTS Teacher;

CREATE TABLE Teacher (
    IdTeacher     INTEGER       PRIMARY KEY AUTOINCREMENT,
    IdTeacherKind INT           REFERENCES TeacherKind (IdTeacherKind),
    FirstName     VARCHAR (100),
    SecondName    VARCHAR (100),
    FirstSurname  VARCHAR (100),
    SecondSurname VARCHAR (100),
    DateOfBirth   DATE,
    Rfc           VARCHAR (100),
    Curp          VARCHAR (100),
    PayrollNumber INT (50),
    Password      VARCHAR (100) 
);


-- Table: TeacherKind
DROP TABLE IF EXISTS TeacherKind;

CREATE TABLE TeacherKind (
    IdTeacherKind INTEGER       PRIMARY KEY AUTOINCREMENT,
    Name          VARCHAR (100),
    MinHours      INT,
    MaxHours      INT
);


-- Table: TeacherSubject
DROP TABLE IF EXISTS TeacherSubject;

CREATE TABLE TeacherSubject (
    IdTeacherSubject INTEGER PRIMARY KEY AUTOINCREMENT,
    IdTeacher        INTEGER REFERENCES Teacher (IdTeacher),
    IdSubject        INTEGER REFERENCES Subject (IdSubject) 
);


COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
