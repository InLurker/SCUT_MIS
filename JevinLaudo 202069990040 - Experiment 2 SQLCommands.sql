--Database Table Setup

CREATE TABLE students(
    sid VARCHAR(10) NOT NULL PRIMARY KEY,	-- Student ID
    sname NVARCHAR(20) NOT NULL,   		-- Student Name    
    sex VARCHAR(6) CHECK(sex = 'male' or sex = 'female') NOT NULL, -- Student Sex
    entrance_age INT CHECK(entrance_age >= 10 and entrance_age <= 50) NOT NULL, -- Student Entrance Age
    entrance_year INT NOT NULL, 		    -- Student Entrance Year
    class VARCHAR(20) NOT NULL  		    -- Student Class
);
 
CREATE TABLE teachers(
    tid VARCHAR(5) NOT NULL PRIMARY KEY,	-- Teacher ID
    tname NVARCHAR(20) NOT NULL,		-- Teacher Name
    course NVARCHAR(20) NOT NULL    	-- Teacher Course
);
 
CREATE TABLE courses (
    cid VARCHAR(7) NOT NULL PRIMARY KEY,	-- Course ID
    cname NVARCHAR(20) NOT NULL,    	-- Course Name
    tid VARCHAR(5) FOREIGN KEY REFERENCES teachers(tid) ON DELETE SET NULL,    -- Teacher ID 
    credit DECIMAL(4,2) NOT NULL,   	-- Course Credit
    grade VARCHAR(20) NOT NULL,     	-- Course Grade
    cancel_year INT     			-- Course Cancel Year
);
 
CREATE TABLE choose (
    sid VARCHAR(10) NOT NULL FOREIGN KEY REFERENCES students(sid) ON DELETE CASCADE,  -- Student ID
    cid VARCHAR(7) FOREIGN KEY REFERENCES courses(cid) ON DELETE SET NULL,            -- Course ID
    tid VARCHAR(5) FOREIGN KEY REFERENCES teachers(tid) ON DELETE SET NULL,           -- Teacher ID
    score FLOAT,		-- Score
    chosen_year INT NOT NULL    	-- Chosen Year
);



--Authority Level Creation

CREATE TABLE account_students (
	username VARCHAR(15) NOT NULL,
	password VARCHAR(15) NOT NULL
);
 
CREATE TABLE account_teachers (
	username VARCHAR(15) NOT NULL,
	password VARCHAR(15) NOT NULL
);
 
CREATE TABLE account_admins (
	username VARCHAR(15) NOT NULL,
	password VARCHAR(15) NOT NULL
);



--Sample Data Insertion

INSERT INTO students 
	(sid, sname, sex, entrance_age, entrance_year, class)
	VALUES ('1000000001', 'Tom Scott', 'male', 19, 2020, 'CST2020');
INSERT INTO students 
	(sid, sname, sex, entrance_age, entrance_year, class)
	VALUES ('1000000002', 'Sheila Clives', 'female', 21, 2020, 'CST2020');
INSERT INTO students 
	(sid, sname, sex, entrance_age, entrance_year, class)
	VALUES ('1000000003', 'Mary Jane', 'female', 20, 2021, 'CST2021');
INSERT INTO students 
	(sid, sname, sex, entrance_age, entrance_year, class)
	VALUES ('1000000004', 'Thomas Zhang', 'male', 18, 2021, 'CST2021');
INSERT INTO students 
	(sid, sname, sex, entrance_age, entrance_year, class)
	VALUES ('1000000005', 'Jeffrey Ho', 'male', 19, 2021, 'CST2022');
INSERT INTO students 
	(sid, sname, sex, entrance_age, entrance_year, class)
	VALUES ('1000000006', 'Clay Moore', 'male', 23, 2021, 'CST2022');
INSERT INTO students 
	(sid, sname, sex, entrance_age, entrance_year, class)
	VALUES ('1000000007', 'Danny Flemmings', 'male', 18, 2021, 'CST2022');
 
INSERT INTO teachers
	(tid, tname, course)
	VALUES ('T0001', 'Jefferson Logatto','Linear Algebra');
INSERT INTO teachers
	(tid, tname, course)
	VALUES ('T0002', 'Matt Rockald', 'Intro to CS');
INSERT INTO teachers
	(tid, tname, course)
	VALUES ('T0003', 'Miles Hughes', 'C++ Programming');
INSERT INTO teachers
	(tid, tname, course)
	VALUES ('T0004', 'Scarlet Rosalia', 'Java Programming');
INSERT INTO teachers
	(tid, tname, course)
	VALUES ('T0005', 'Ben Owen', 'Data Structures');
INSERT INTO teachers
	(tid, tname, course)
	VALUES ('T0006', 'Richard Higgings', 'Algorithms');
 
INSERT INTO courses
	(cid, cname, tid, credit, grade)
	VALUES ('C000001', 'Linear Algebra', 'T0001', 3.0, '1');
INSERT INTO courses
	(cid, cname, tid, credit, grade)
	VALUES ('C000002', 'Intro to CS', 'T0002', 2.0, '1');
INSERT INTO courses
	(cid, cname, tid, credit, grade)
	VALUES ('C000003', 'C++ Programming', 'T0003', 4.0, '1');
INSERT INTO courses
	(cid, cname, tid, credit, grade)
	VALUES ('C000004', 'Java Programming', 'T0004', 4.0, '2');
INSERT INTO courses
	(cid, cname, tid, credit, grade)
	VALUES ('C000005', 'Data Structures', 'T0005', 3.0, '3');
INSERT INTO courses
	(cid, cname, tid, credit, grade)
	VALUES ('C000006', 'Algorithms', 'T0006', 3.5, '3');

INSERT INTO choose
	(sid, cid, tid, score, chosen_year)
	VALUES ('1000000001', 'C000001','T0001', 98, 2020);
INSERT INTO choose
	(sid, cid, tid, score, chosen_year)
	VALUES ('1000000001', 'C000002','T0002', 91, 2020);
INSERT INTO choose
	(sid, cid, tid, score, chosen_year)
	VALUES ('1000000001', 'C000003','T0003', 93, 2020);
INSERT INTO choose
	(sid, cid, tid, score, chosen_year)
	VALUES ('1000000001', 'C000004','T0004', 87.9, 2021);
INSERT INTO choose
	(sid, cid, tid, score, chosen_year)
	VALUES ('1000000001', 'C000005','T0005', 92, 2022);
INSERT INTO choose
	(sid, cid, tid, score, chosen_year)
	VALUES ('1000000001', 'C000006','T0006', 86.67, 2022);
INSERT INTO choose
	(sid, cid, tid, score, chosen_year)
	VALUES ('1000000002', 'C000001','T0001', 92.1, 2020);
INSERT INTO choose
	(sid, cid, tid, score, chosen_year)
	VALUES ('1000000002', 'C000002','T0002', 87.6, 2020);
INSERT INTO choose
	(sid, cid, tid, score, chosen_year)
	VALUES ('1000000002', 'C000003','T0003', 77.9, 2020);
INSERT INTO choose
	(sid, cid, tid, score, chosen_year)
	VALUES ('1000000002', 'C000004','T0004', 93, 2021);
INSERT INTO choose
	(sid, cid, tid, score, chosen_year)
	VALUES ('1000000002', 'C000005','T0005', 88, 2022);
INSERT INTO choose
	(sid, cid, tid, score, chosen_year)
	VALUES ('1000000002', 'C000006','T0006', 85.3, 2022);
INSERT INTO choose
	(sid, cid, tid, score, chosen_year)
	VALUES ('1000000003', 'C000001','T0001', 77.9, 2021);
INSERT INTO choose
	(sid, cid, tid, score, chosen_year)
	VALUES ('1000000003', 'C000002','T0002', 82.1, 2021);
INSERT INTO choose
	(sid, cid, tid, score, chosen_year)
	VALUES ('1000000003', 'C000003','T0003', 73, 2021);
INSERT INTO choose
	(sid, cid, tid, score, chosen_year)
	VALUES ('1000000003', 'C000004','T0004', 84, 2022);
INSERT INTO choose
	(sid, cid, tid, score, chosen_year)
	VALUES ('1000000004', 'C000001','T0001', 83.6, 2021);
INSERT INTO choose
	(sid, cid, tid, score, chosen_year)
	VALUES ('1000000004', 'C000002','T0002', 91.2, 2021);
INSERT INTO choose
	(sid, cid, tid, score, chosen_year)
	VALUES ('1000000004', 'C000003','T0003', 70.1, 2021);
INSERT INTO choose
	(sid, cid, tid, score, chosen_year)
	VALUES ('1000000004', 'C000004','T0004', 66.6, 2022);
INSERT INTO choose
	(sid, cid, tid, score, chosen_year)
	VALUES ('1000000005', 'C000001','T0001', 91, 2021);
INSERT INTO choose
	(sid, cid, tid, score, chosen_year)
	VALUES ('1000000005', 'C000002','T0002', 93.5, 2021);
INSERT INTO choose
	(sid, cid, tid, score, chosen_year)
	VALUES ('1000000005', 'C000003','T0003', 81.2, 2021);
INSERT INTO choose
	(sid, cid, tid, score, chosen_year)
	VALUES ('1000000006', 'C000001','T0001', 77.1, 2021);
INSERT INTO choose
	(sid, cid, tid, score, chosen_year)
	VALUES ('1000000006', 'C000002','T0002', 90.1, 2021);
INSERT INTO choose
	(sid, cid, tid, score, chosen_year)
	VALUES ('1000000006', 'C000003','T0003', 91.2, 2021);

