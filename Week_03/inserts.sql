-- INSERT DATA
USE challenge_W3;

INSERT INTO Student(lastname, firstmidname, enrollmentdate)
VALUES ('Benjamin', 'Geraldo', '1995-01-30')

INSERT INTO Student(lastname, firstmidname, enrollmentdate)
VALUES ('Gloria', 'Maria', '2004-07-16')

INSERT INTO Student(lastname, firstmidname, enrollmentdate)
VALUES ('Ale', 'Bautista', '2005-08-02')

INSERT INTO Student(lastname, firstmidname, enrollmentdate)
VALUES ('Nereo', 'Elvira', '2006-01-24')

INSERT INTO Student(lastname, firstmidname, enrollmentdate)
VALUES ('Juan', 'Sixto', '2017-09-15')

--

INSERT INTO Instructor(lastname, firstmidname, hiredate)
VALUES ('Leonardo', 'Valero', '2008-01-21')

INSERT INTO Instructor(lastname, firstmidname, hiredate)
VALUES ('Claudia', 'Antonia', '2019-04-08')

INSERT INTO Instructor(lastname, firstmidname, hiredate)
VALUES ('Denisse', 'Patricio', '2023-02-23')

INSERT INTO Instructor(lastname, firstmidname, hiredate)
VALUES ('Rolando', 'Orfeo', '2011-11-30')

INSERT INTO Instructor(lastname, firstmidname, hiredate)
VALUES ('Romulo', 'Maricruz', '2019-09-20')

--

INSERT INTO Department(Name, Budget, StartDate, InstructorID)
VALUES ('D1', '3455', '2011-08-24', 2)

INSERT INTO Department(Name, Budget, StartDate, InstructorID)
VALUES ('D2', '6846', '2014-05-01', 2)

INSERT INTO Department(Name, Budget, StartDate, InstructorID)
VALUES ('D3', '45636', '2015-01-28', 1)

INSERT INTO Department(Name, Budget, StartDate, InstructorID)
VALUES ('D4', '67986', '2016-02-16', 5)

INSERT INTO Department(Name, Budget, StartDate, InstructorID)
VALUES ('D5', '6345', '2022-02-24', 4)

--

INSERT INTO OfficeAssignment(instructorid, location)
VALUES (1, '1192 Lakeland Park Drive')

INSERT INTO OfficeAssignment(instructorid, location)
VALUES (2, '2217 Rosewood Court')

INSERT INTO OfficeAssignment(instructorid, location)
VALUES (3, '103 Railroad Street')

INSERT INTO OfficeAssignment(instructorid, location)
VALUES (4, '365 Parrish Avenue')

INSERT INTO OfficeAssignment(instructorid, location)
VALUES (5, '996 Maxwell Farm Road')

--

INSERT INTO Course(title, credits, departmentid)
VALUES ('Course 1', 'C1', 1)

INSERT INTO Course(title, credits, departmentid)
VALUES ('Course 2', 'C2', 5)

INSERT INTO Course(title, credits, departmentid)
VALUES ('Course 3', 'C3', 4)

INSERT INTO Course(title, credits, departmentid)
VALUES ('Course 4', 'C4', 3)

INSERT INTO Course(title, credits, departmentid)
VALUES ('Course 5', 'C5', 2)

--

INSERT INTO CourseAssignment(courseid, instructorid)
VALUES (1, 5)

INSERT INTO CourseAssignment(courseid, instructorid)
VALUES (2, 4)

INSERT INTO CourseAssignment(courseid, instructorid)
VALUES (3, 3)

INSERT INTO CourseAssignment(courseid, instructorid)
VALUES (4, 2)

INSERT INTO CourseAssignment(courseid, instructorid)
VALUES (5, 1)

--

INSERT INTO Enrollment(courseid, studentid, grade)
VALUES (1, 5, 'G1')

INSERT INTO Enrollment(courseid, studentid, grade)
VALUES (2, 4, 'G2')

INSERT INTO Enrollment(courseid, studentid, grade)
VALUES (3, 3, 'G3')

INSERT INTO Enrollment(courseid, studentid, grade)
VALUES (4, 2, 'G4')

INSERT INTO Enrollment(courseid, studentid, grade)
VALUES (5, 1, 'G5')
