-- Ver instructor de cada curso
SELECT i.FirstMidName, c.Title
FROM Instructor i,
     Course c,
     CourseAssignment ca
WHERE i.ID = ca.InstructorID
  AND ca.CourseId = c.CourseID;

-- Ver curso en el que un estudiante esta inscrito
SELECT s.FirstMidName, c.Title
FROM Student s,
     Course c,
     Enrollment e
WHERE s.ID = e.StudentID
  AND c.CourseID = e.CourseID;

-- instructor de cada oficina con su ubicacion
SELECT o.Location, i.FirstMidName
FROM OfficeAssignment o,
     Instructor i
WHERE o.InstructorID = i.ID;

-- Courses of a student
SELECT c.Title, c.Credits, i.FirstMidName, e.Grade
FROM Student s,
     Course c,
     Enrollment e,
     CourseAssignment ca,
     Instructor i
WHERE s.ID = e.StudentID
  AND e.CourseID = c.CourseID
  AND c.CourseID = ca.CourseId
  AND ca.InstructorID = i.ID
  AND s.ID = 1;


-- Indexes
CREATE INDEX idx_student
    ON Student (LastName, EnrollmentDate);

EXEC sp_helpindex 'Student';

DROP INDEX Student.idx_student;

--

CREATE INDEX idx_instructor
    ON Instructor (LastName, HireDate);

EXEC sp_helpindex 'Instructor';

DROP INDEX Instructor.idx_instructor;

-- With view
CREATE VIEW StudentInfoView AS
SELECT c.Title, c.Credits, i.FirstMidName, e.Grade
FROM Student s,
     Course c,
     Enrollment e,
     CourseAssignment ca,
     Instructor i
WHERE s.ID = e.StudentID
  AND e.CourseID = c.CourseID
  AND c.CourseID = ca.CourseId
  AND ca.InstructorID = i.ID;

SELECT *
FROM StudentInfoView;
