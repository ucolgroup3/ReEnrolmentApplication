use [1272937]
go

alter PROCEDURE TRYING_TABLES_FOR_FIRST_TIME
AS
BEGIN

IF OBJECT_ID('dbo.summary','U') IS NOT NULL
DROP TABLE dbo.summary

IF OBJECT_ID('dbo.major_selected','U') IS NOT NULL
DROP TABLE dbo.major_selected 

IF OBJECT_ID('dbo.semester_paper ','U') IS NOT NULL
DROP TABLE dbo.semester_paper 

IF OBJECT_ID('dbo.paper','U') IS NOT NULL
DROP TABLE dbo.paper

--IF OBJECT_ID('dbo.prerequisite','U') IS NOT NULL
--DROP TABLE dbo.prerequisite 

IF OBJECT_ID('dbo.semester','U') IS NOT NULL
DROP TABLE dbo.semester

IF OBJECT_ID('dbo.major','U') IS NOT NULL
DROP TABLE dbo.major

IF OBJECT_ID('dbo.student','U') IS NOT NULL
DROP TABLE dbo.student

create table dbo.major
(
	major_ID int IDENTITY(1,1) PRIMARY KEY,
	major_name varchar(100),
	[description] varchar(1000),
	major_type varchar(50)
	--credits_value varchar(10)
)

create table dbo.student
(
	student_ID int IDENTITY(1,1) PRIMARY KEY,
	name varchar(100),
	email varchar(100),
	intake varchar(50),
	[year] varchar(10)
)

create table dbo.semester 
(
	semester_ID int IDENTITY(1,1) PRIMARY KEY,
	semester varchar(50)
)

--create table dbo.prerequisite
--(
--	prerequisite_ID int IDENTITY(1,1) PRIMARY KEY,
--	paper_ID int UNIQUE NOT NULL

--)


create table dbo.paper
(
	paper_ID int IDENTITY(1,1) PRIMARY KEY,
	paper_code varchar(50),
	name varchar(100),
	[description] varchar(1000),
	--semester_ID int NOT NULL,
	[level] varchar(50),
	compulsory bit,
	credit_value varchar(10),
	paper_type varchar(50),
	prerequisite_ID int NULL REFERENCES paper(paper_ID),

--CONSTRAINT oft_semester_ID_fk FOREIGN KEY (semester_ID) REFERENCES semester(semester_ID),
--CONSTRAINT oft_prerequisite_ID_fk FOREIGN KEY (prerequisite_ID) REFERENCES prerequisite(prerequisite_ID)

)

create table dbo.semester_paper 
(
	semester_ID int NOT NULL,
	paper_ID int Not NULL
	PRIMARY KEY (paper_ID,semester_ID)
	
CONSTRAINT oft_semester_ID_fk FOREIGN KEY (semester_ID) REFERENCES semester(semester_ID),
CONSTRAINT oft_paper_ID_fk FOREIGN KEY (paper_ID) REFERENCES paper(paper_ID)
)



create table dbo.summary
(
	summary_ID int IDENTITY(1,1) PRIMARY KEY, 
	student_ID int NOT NULL,
	major_ID int NOT NULL,
	intake varchar(50),
	[level] varchar(50),
	[year] varchar(10),
	paper_ID int NOT NULL,
	semester_ID int UNIQUE NOT NULL
	--PRIMARY KEY (student_ID,paper_ID,semester_ID)


CONSTRAINT oft_student_ID_fk FOREIGN KEY (student_ID) REFERENCES student(student_ID),
CONSTRAINT oft_major_ID_fk FOREIGN KEY (major_ID) REFERENCES major(major_ID),
CONSTRAINT oftn_paper_ID_fk FOREIGN KEY (paper_ID) REFERENCES paper(paper_ID),
CONSTRAINT oftn_semester_ID_fk FOREIGN KEY (semester_ID) REFERENCES semester(semester_ID)
)





create table dbo.major_selected
(
	major_selected int IDENTITY(1,1) PRIMARY KEY,
	major_ID int NOT NULL,
	paper_ID int NOT NULL
CONSTRAINT oftn_major_fk FOREIGN KEY (major_ID) REFERENCES major(major_ID),
CONSTRAINT oftm_paper_ID_fk FOREIGN KEY (paper_ID) REFERENCES paper(paper_ID)

)




END