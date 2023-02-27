-- PART I

USE master

CREATE DATABASE challenge_W3

USE challenge_W3;

CREATE TABLE OfficeAssignment
(
    InstructorID INT,
    Location     VARCHAR(250) NOT NULL,
);

CREATE TABLE Instructor
(
    ID           INT PRIMARY KEY IDENTITY,
    LastName     VARCHAR(50) NOT NULL,
    FirstMidName VARCHAR(50) NOT NULL,
    HireDate     DATE,
);

CREATE TABLE Department
(
    DepartmentID INT PRIMARY KEY IDENTITY,
    Name         VARCHAR(50) NOT NULL,
    Budget       MONEY,
    StartDate    DATE        NOT NULL,
    InstructorID INT,
);

CREATE TABLE Course
(
    CourseID     INT PRIMARY KEY IDENTITY,
    Title        VARCHAR(50) NOT NULL,
    Credits      VARCHAR(50) NOT NULL,
    DepartmentID INT         NOT NULL,
);

CREATE TABLE CourseAssignment
(
    CourseId     INT NOT NULL,
    InstructorID INT NOT NULL
);

CREATE TABLE Enrollment
(
    EnrollmentID INT PRIMARY KEY IDENTITY,
    CourseID     INT NOT NULL,
    StudentID    INT NOT NULL,
    Grade        VARCHAR(20),
);

CREATE TABLE Student
(
    ID             INT PRIMARY KEY IDENTITY,
    LastName       VARCHAR(50) NOT NULL,
    FirstMidName   VARCHAR(50) NOT NULL,
    EnrollmentDate DATE,
);

ALTER TABLE OfficeAssignment
    ADD CONSTRAINT FK_OfficeAssignmentXInstructor
        FOREIGN KEY (InstructorID)
            REFERENCES Instructor (ID);

ALTER TABLE Department
    ADD CONSTRAINT FK_InstructorXDepartment
        FOREIGN KEY (InstructorID)
            REFERENCES Instructor (ID);

ALTER TABLE Enrollment
    ADD CONSTRAINT FK_EnrollmentXCourse
        FOREIGN KEY (CourseID)
            REFERENCES Course (CourseID);

ALTER TABLE Enrollment
    ADD CONSTRAINT FK_EnrollmentXStudent
        FOREIGN KEY (StudentID)
            REFERENCES Student (ID);

ALTER TABLE CourseAssignment
    ADD CONSTRAINT FK_CourseAssignmentXCourse
        FOREIGN KEY (CourseId)
            REFERENCES Course (CourseId);

ALTER TABLE CourseAssignment
    ADD CONSTRAINT FK_CourseAssignmentXInstructor
        FOREIGN KEY (InstructorID)
            REFERENCES Instructor (ID);
