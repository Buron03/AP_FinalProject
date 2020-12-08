--
-- File generated with SQLiteStudio v3.2.1 on vie. nov. 27 23:16:41 2020
--
-- Text encoding used: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

--Table: GroupSubjects
DROP TABLE IF EXISTS GroupSubjects;

CREATE TABLE GroupSubjects (
    IdGroupSubject INTEGER PRIMARY KEY AUTOINCREMENT,
    IdGroup        INTEGER REFERENCES SchoolGroups (IdGroup),
    IdSubject        INTEGER REFERENCES Subjects (IdSubject) 
);

-- Table: Assignatures
DROP TABLE IF EXISTS Assignatures;

CREATE TABLE Assignatures (
    IdAssignature INTEGER PRIMARY KEY AUTOINCREMENT,
    IdTeacher     INTEGER REFERENCES Teachers (IdTeacher),
    IdSubject     INTEGER REFERENCES Subject (IdSubject),
    IdGroup       INTEGER REFERENCES SchoolGroup (IdGroup) 
);

INSERT INTO Assignatures (
                             IdAssignature,
                             IdTeacher,
                             IdSubject,
                             IdGroup
                         )
                         VALUES (
                             1,
                             1,
                             1,
                             1
                         );

INSERT INTO Assignatures (
                             IdAssignature,
                             IdTeacher,
                             IdSubject,
                             IdGroup
                         )
                         VALUES (
                             2,
                             1,
                             4,
                             2
                         );

INSERT INTO Assignatures (
                             IdAssignature,
                             IdTeacher,
                             IdSubject,
                             IdGroup
                         )
                         VALUES (
                             3,
                             1,
                             3,
                             3
                         );

INSERT INTO Assignatures (
                             IdAssignature,
                             IdTeacher,
                             IdSubject,
                             IdGroup
                         )
                         VALUES (
                             4,
                             1,
                             1,
                             4
                         );

INSERT INTO Assignatures (
                             IdAssignature,
                             IdTeacher,
                             IdSubject,
                             IdGroup
                         )
                         VALUES (
                             5,
                             2,
                             2,
                             1
                         );

INSERT INTO Assignatures (
                             IdAssignature,
                             IdTeacher,
                             IdSubject,
                             IdGroup
                         )
                         VALUES (
                             6,
                             2,
                             1,
                             2
                         );

INSERT INTO Assignatures (
                             IdAssignature,
                             IdTeacher,
                             IdSubject,
                             IdGroup
                         )
                         VALUES (
                             7,
                             2,
                             1,
                             3
                         );

INSERT INTO Assignatures (
                             IdAssignature,
                             IdTeacher,
                             IdSubject,
                             IdGroup
                         )
                         VALUES (
                             8,
                             2,
                             2,
                             3
                         );

INSERT INTO Assignatures (
                             IdAssignature,
                             IdTeacher,
                             IdSubject,
                             IdGroup
                         )
                         VALUES (
                             9,
                             2,
                             2,
                             4
                         );

INSERT INTO Assignatures (
                             IdAssignature,
                             IdTeacher,
                             IdSubject,
                             IdGroup
                         )
                         VALUES (
                             10,
                             3,
                             3,
                             1
                         );

INSERT INTO Assignatures (
                             IdAssignature,
                             IdTeacher,
                             IdSubject,
                             IdGroup
                         )
                         VALUES (
                             11,
                             3,
                             2,
                             2
                         );

INSERT INTO Assignatures (
                             IdAssignature,
                             IdTeacher,
                             IdSubject,
                             IdGroup
                         )
                         VALUES (
                             12,
                             3,
                             4,
                             3
                         );

INSERT INTO Assignatures (
                             IdAssignature,
                             IdTeacher,
                             IdSubject,
                             IdGroup
                         )
                         VALUES (
                             13,
                             3,
                             3,
                             4
                         );

INSERT INTO Assignatures (
                             IdAssignature,
                             IdTeacher,
                             IdSubject,
                             IdGroup
                         )
                         VALUES (
                             14,
                             4,
                             4,
                             1
                         );

INSERT INTO Assignatures (
                             IdAssignature,
                             IdTeacher,
                             IdSubject,
                             IdGroup
                         )
                         VALUES (
                             15,
                             4,
                             3,
                             2
                         );

INSERT INTO Assignatures (
                             IdAssignature,
                             IdTeacher,
                             IdSubject,
                             IdGroup
                         )
                         VALUES (
                             16,
                             4,
                             5,
                             3
                         );

INSERT INTO Assignatures (
                             IdAssignature,
                             IdTeacher,
                             IdSubject,
                             IdGroup
                         )
                         VALUES (
                             17,
                             4,
                             4,
                             4
                         );

INSERT INTO Assignatures (
                             IdAssignature,
                             IdTeacher,
                             IdSubject,
                             IdGroup
                         )
                         VALUES (
                             18,
                             5,
                             5,
                             1
                         );

INSERT INTO Assignatures (
                             IdAssignature,
                             IdTeacher,
                             IdSubject,
                             IdGroup
                         )
                         VALUES (
                             19,
                             5,
                             5,
                             2
                         );

INSERT INTO Assignatures (
                             IdAssignature,
                             IdTeacher,
                             IdSubject,
                             IdGroup
                         )
                         VALUES (
                             20,
                             5,
                             5,
                             4
                         );


-- Table: PeriodKinds
DROP TABLE IF EXISTS PeriodKinds;

CREATE TABLE PeriodKinds (
    IdPeriodKind INTEGER       PRIMARY KEY AUTOINCREMENT,
    Name         VARCHAR (100),
    Months       INT
);

INSERT INTO PeriodKinds (
                            IdPeriodKind,
                            Name,
                            Months
                        )
                        VALUES (
                            1,
                            'SEMESTER',
                            6
                        );

INSERT INTO PeriodKinds (
                            IdPeriodKind,
                            Name,
                            Months
                        )
                        VALUES (
                            2,
                            'QUARTER',
                            4
                        );


-- Table: SchoolGroups
DROP TABLE IF EXISTS SchoolGroups;

CREATE TABLE SchoolGroups (
    IdGroup      INTEGER       PRIMARY KEY AUTOINCREMENT,
    IdPeriodKind VARCHAR (100) REFERENCES PeriodKinds (IdPeriodKind),
    Name         VARCHAR (10),
    StartDate    DATE,
    CloseDate    DATE
);

INSERT INTO SchoolGroups (
                             IdGroup,
                             IdPeriodKind,
                             Name,
                             StartDate,
                             CloseDate
                         )
                         VALUES (
                             1,
                             '1',
                             'A1',
                             '2020-11-30',
                             '2021-05-31'
                         );

INSERT INTO SchoolGroups (
                             IdGroup,
                             IdPeriodKind,
                             Name,
                             StartDate,
                             CloseDate
                         )
                         VALUES (
                             2,
                             '1',
                             'B1',
                             '2020-11-30',
                             '2021-05-31'
                         );

INSERT INTO SchoolGroups (
                             IdGroup,
                             IdPeriodKind,
                             Name,
                             StartDate,
                             CloseDate
                         )
                         VALUES (
                             3,
                             '2',
                             'C1',
                             '2020-11-30',
                             '2021-03-02'
                         );

INSERT INTO SchoolGroups (
                             IdGroup,
                             IdPeriodKind,
                             Name,
                             StartDate,
                             CloseDate
                         )
                         VALUES (
                             4,
                             '2',
                             'D1',
                             '2020-11-30',
                             '2021-05-31'
                         );


-- Table: Subjects
DROP TABLE IF EXISTS Subjects;

CREATE TABLE Subjects (
    IdSubject        INTEGER       PRIMARY KEY AUTOINCREMENT,
    Name             VARCHAR (100),
    TheoreticalHours INT (10),
    PracticalHours   INT (10) 
);

INSERT INTO Subjects (
                         IdSubject,
                         Name,
                         TheoreticalHours,
                         PracticalHours
                     )
                     VALUES (
                         1,
                         'Maths',
                         5,
                         0
                     );

INSERT INTO Subjects (
                         IdSubject,
                         Name,
                         TheoreticalHours,
                         PracticalHours
                     )
                     VALUES (
                         2,
                         'Physics',
                         4,
                         1
                     );

INSERT INTO Subjects (
                         IdSubject,
                         Name,
                         TheoreticalHours,
                         PracticalHours
                     )
                     VALUES (
                         3,
                         'Chemistry',
                         2,
                         2
                     );

INSERT INTO Subjects (
                         IdSubject,
                         Name,
                         TheoreticalHours,
                         PracticalHours
                     )
                     VALUES (
                         4,
                         'Numerical Analysis',
                         4,
                         2
                     );

INSERT INTO Subjects (
                         IdSubject,
                         Name,
                         TheoreticalHours,
                         PracticalHours
                     )
                     VALUES (
                         5,
                         'Programming',
                         3,
                         0
                     );


-- Table: TeacherKind
DROP TABLE IF EXISTS TeacherKind;

CREATE TABLE TeacherKind (
    IdTeacherKind INTEGER       PRIMARY KEY AUTOINCREMENT,
    Name          VARCHAR (100),
    MinHours      INT,
    MaxHours      INT
);

INSERT INTO TeacherKind (
                            IdTeacherKind,
                            Name,
                            MinHours,
                            MaxHours
                        )
                        VALUES (
                            1,
                            'COORDINATOR',
                            5,
                            10
                        );

INSERT INTO TeacherKind (
                            IdTeacherKind,
                            Name,
                            MinHours,
                            MaxHours
                        )
                        VALUES (
                            2,
                            'BASE',
                            15,
                            30
                        );

INSERT INTO TeacherKind (
                            IdTeacherKind,
                            Name,
                            MinHours,
                            MaxHours
                        )
                        VALUES (
                            3,
                            'SUBJECT',
                            12,
                            24
                        );


-- Table: Teachers
DROP TABLE IF EXISTS Teachers;

CREATE TABLE Teachers (
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

INSERT INTO Teachers (
                         IdTeacher,
                         IdTeacherKind,
                         FirstName,
                         SecondName,
                         FirstSurname,
                         SecondSurname,
                         DateOfBirth,
                         Rfc,
                         Curp,
                         PayrollNumber,
                         Password
                     )
                     VALUES (
                         1,
                         2,
                         'David',
                         'Alejandro',
                         'Lopez',
                         'Torres',
                         '2003-01-12',
                         'LOTD030112PJ7',
                         'LOTD030112HJCPRVA5',
                         155,
                         'BuronSuave03'
                     );

INSERT INTO Teachers (
                         IdTeacher,
                         IdTeacherKind,
                         FirstName,
                         SecondName,
                         FirstSurname,
                         SecondSurname,
                         DateOfBirth,
                         Rfc,
                         Curp,
                         PayrollNumber,
                         Password
                     )
                     VALUES (
                         2,
                         2,
                         'Daniel',
                         NULL,
                         'Tejeda',
                         'Saavedra',
                         '2001-11-25',
                         'TESD011125DH2',
                         'TESD011125HJCJVN02',
                         288,
                         'BuronSuave03'
                     );

INSERT INTO Teachers (
                         IdTeacher,
                         IdTeacherKind,
                         FirstName,
                         SecondName,
                         FirstSurname,
                         SecondSurname,
                         DateOfBirth,
                         Rfc,
                         Curp,
                         PayrollNumber,
                         Password
                     )
                     VALUES (
                         3,
                         3,
                         'Ana',
                         'Paulina',
                         'Corona',
                         'Garcia',
                         '2002-05-19',
                         'COGA020519J55',
                         'COGA020519MJCRRN011',
                         64,
                         'BuronSuave03'
                     );

INSERT INTO Teachers (
                         IdTeacher,
                         IdTeacherKind,
                         FirstName,
                         SecondName,
                         FirstSurname,
                         SecondSurname,
                         DateOfBirth,
                         Rfc,
                         Curp,
                         PayrollNumber,
                         Password
                     )
                     VALUES (
                         4,
                         3,
                         'Marco',
                         'Antonio',
                         'Galindo',
                         'Torres',
                         '2002-06-14',
                         'GATM020614TK8',
                         'GATM020614HJCLRR08',
                         92,
                         'BuronSuave03'
                     );

INSERT INTO Teachers (
                         IdTeacher,
                         IdTeacherKind,
                         FirstName,
                         SecondName,
                         FirstSurname,
                         SecondSurname,
                         DateOfBirth,
                         Rfc,
                         Curp,
                         PayrollNumber,
                         Password
                     )
                     VALUES (
                         5,
                         1,
                         'Andrea',
                         'Daniela',
                         'Barrera',
                         'Flores',
                         '1999-11-21',
                         'BAFA991125CY6',
                         'BAFA991125MJCRLN03',
                         123,
                         'BuronSuave03'
                     );


-- Table: TeacherSubjects
DROP TABLE IF EXISTS TeacherSubjects;

CREATE TABLE TeacherSubjects (
    IdTeacherSubject INTEGER PRIMARY KEY AUTOINCREMENT,
    IdTeacher        INTEGER REFERENCES Teachers (IdTeacher),
    IdSubject        INTEGER REFERENCES Subjects (IdSubject) 
);


COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
