use [1272937]
go

EXECUTE TRYING_TABLES_FOR_FIRST_TIME

INSERT INTO dbo.major VALUES
('Network Engineering','Focus: Networking and ICT infrastructure','Network Technology'),
('Security','Focus: ICT systems and network security','Network Technology'),
('Systems Administration','Focus: System administration, server and database administration','Network Technology'),
('Data Management and Analytics','Focus: Data analytics, data warehousing, database development, business intelligence','Information Management'),
('Business and Systems Analysis','Focus: Business and systems analysis, requirements elicitation, process modelling','Information Management'),
('Project Management','Focus: IT project management, agile projects','Information Management'),
('Software Engineering','Focus: Software engineering, programming, and development','Software Development'),
('Web and Mobile Development','Focus: Web and mobile platform development','Software Development')

INSERT INTO dbo.student VALUES
('John Smith','johnsmith@email.com','FY','Year 2')

INSERT INTO dbo.semester VALUES
('Semester 1'),
('Semester 2')

--INSERT INTO dbo.prerequisite VALUES
--(1),
--(2),
--(3),
--(4),
--(5),
--(6),
--(7),
--(8),

INSERT INTO dbo.paper VALUES
('D111','Database Fundamentals','Gain a broad operational knowledge of database design and administration. During your studies you''ll design a relational database to meet organisational requirements; apply interaction design concepts to a user interface; and store and retrieve organisational data using query and reporting tools.','5','true','15','Software Development',NULL),
('I121','Systems Analysis Fundamentals','Learn the principles of systems analysis and systems requirements elicitation techniques. During your studies you''ll analyse situations requiring problem solving; elicit and model user requirements using a variety of techniques; and construct accurate systems analysis documentation reflecting requirements.','5','true','15','Information Management',NULL),
('T111','Computer Hardware Fundamentals','Gain an understanding of computer hardware, operating systems and troubleshooting techniques.','5','true','15','Network Technology',NULL),
('I101','Information System Fundamentals','Gain an understanding of business systems and essential components of the ICT profession.','5','true','15','Information Management',NULL),
('D101','Programming Fundamentals','Learn the fundamentals of programming to develop quality software. During your studies you''ll develop an application using an industry standard language, and debug, test and document a software application.','5','true','15','Software Development',NULL),
('T101','Network Fundamentals','Learn the fundamentals of computer networks as they currently exist in industry, so that you can configure, test and troubleshoot local area networks.','5','true','15','Network Technology',NULL),
('I111','Web Fundamentals','Learn the fundamentals of web development and how to produce a quality website. You will employ UX design principles that meet organisational requirements and apply an industry standard approach.','5','true','15','Information Management',NULL),
('I102','Technical Support Fundamentals','Learn how to deliver organisational technical support based on best practice in IT service management. During your studies you''ll apply a user needs analysis to identify organisational requirements; create, deliver and evaluate a training session; and develop technical documentation to a professional standard.','5','true','15','Information Management',NULL),

('D211','Database Development','Learn how to effectively design an information system for a complex business application.','6','false','15','Software Development',1),
('I203','Digital Multimedia','Learn to apply principles and techniques relating to the application of digital multimedia technologies. During your studies you''ll learn about digital images, video and audio; create and manipulate digital image, video and audio files according to a technical specification for distribution across the ICT infrastructure; and optimise digital multimedia for commonly used ICT mediums.','6','false','15','Information Management',4),
('I212','Enterprise Data Management','Learn to design and implement enterprise data management systems.','6','false','15','Information Management',7),
('D201','Advanced Programming','Learn standard algorithms required for business application programming. During your studies you''ll design and construct small applications using a variety of algorithms; devise test plans to ensure quality software; and create system maintenance documentation.','6','false','15','Software Development',5),
('T201','Network Services','Learn to implement key network services as used in modern LANs and to explain the network protocols that these services use. During your studies you''ll implement and explain the operation of name resolution; implement automatic network configuration; implement and explain the operation of directory services; implement and explain the operation of a web proxy; implement automatic browser configuration when a web proxy is used; implement file sharing; and implement and explain the operation of a basic firewall.','6','false','15','Network Technology',6),
('T206','Networks - Cisco RSE','Gain practical and technical networking knowledge that will allow you to configure and troubleshoot routers, switches and resolve common issues with RIPv1, RIPng, single-area and multi-area OSPF, virtual LANs, and inter-VLAN routing in both IPv4 and IPv6 networks.','6','false','15','Network Technology',6),
('I263','Introduction to Finance','Learn to apply financial management knowledge and skills to a small or medium size business for decision-making purposes.','6','false','15','Information Management',19),
('I209','Industry Placement(for those already employed in an IT role)','Industry placements are very useful for undergraduates looking to gain professional development while working at the same time.They are an extended period of work experience, which can be either paid or unpaid, that many major firms offer to undergraduate students.','6','false','15','Information Management',NULL),

('I202','IT Project Management','Gain an understanding of project management theory and practice as it relates to the ICT industry.','6','true','15','Information Management',8),
('I221','Analysis & Design','Create quality analysis and design documentation for a moderately complex system.','6','false','15','Information Management',2),
('I213','Dynamic Web Solutions','Learn to create a dynamic web application utilising a variety of open-source technologies. During your studies you''ll design and document a web application; secure critical business data within the web application; interface with a web-based database management system; and implement user security and session management.','6','false','15','Information Management',7),
('D202','Software Process and Planning','Learn to create quality software applications utilising a modern development approach. During your studies you''ll work as a team on an iterative development project; manage an individual development task; implement processes to ensure quality; and compare and select an appropriate development method for a given problem.','6','false','15','Software Development',5),
--('T206','Networks - Cisco RSE','Gain practical and technical networking knowledge that will allow you to configure and troubleshoot routers, switches and resolve common issues with RIPv1, RIPng, single-area and multi-area OSPF, virtual LANs, and inter-VLAN routing in both IPv4 and IPv6 networks.','6','false','15','Network Technology',6),
('T211','Systems Security','Learn to analyse and implement computer systems security, including operating systems, server applications and networks; and explain the fundamentals of computer forensics.','6','false','15','Network Technology',3),
--('I209','Industry Placement(for those already employed in an IT role)','Industry placements are very useful for undergraduates looking to gain professional development while working at the same time.They are an extended period of work experience, which can be either paid or unpaid, that many major firms offer to undergraduate students.','6','false','15','Information Management',NULL),

('I301','Professional Practice','Prepare for transition into the ICT profession. Source an industry project and produce appropriate documentation.','7','true','15','Information Management',NULL),
('I302','Industry Project','Undertake an industry-based project of a complex nature. During this experience you''ll manage an ICT project for industry; produce original work and project deliverables; consider and apply professional work ethics; meet project timelines and goals; record and evaluate project work and progress; and present project outcomes to sponsors and academic supervisors.','7','true','45','Information Management',22),
('I321','Advanced Systems Analysis','Learn to introduce tools and techniques used to assess feasibility and present a business case; to complete an analysis of a complex information system based on the recommendation from the feasibility phase.','7','false','15','Information Management',18),
('D301','Software Engineering','Learn to design and construct quality software ready for distribution. During your studies you''ll perform object-oriented design and programming with a high level of proficiency; secure applications so that they are ready for distribution; conduct effective and efficient inspections; evaluate software user interfaces for accessibility and usability; and design and implement comprehenstive test plans.','7','false','15','Software Development',12),
('D311','Advanced Database Concepts','Learn to successfully design, create and administer a data warehouse using a server-based database management system.','7','false','15','Software Development',9),
('T301','Network Design','Learn how to recommend uses for thin and thick client architectures, and to design a thin client architecture.','7','false','15','Network Technology',13),
('T302','Networks Cisco Scaling and Connecting','Gain practical and technical networking knowledge that will assist in designing, building and analysing networks and their protocols using advanced technologies.','7','false','15','Network Technology',14),
('I367','Advanced Project Management','Learn advanced principles of the project management body of knowledge and cover the content of the Project Management Institute and its application and evaluation to the workplace.','7','false','15','Information Management',17),
('T311','Systems Administration','Learn to design and construct a complex multi-user client/server network. You''ll gain skills needed to configure and integrate complex systems.','7','false','15','Network Technology',22),
('I311','Advanced Web Solutions','Learn to investigate, implement, and critique influentual, new, and emerging web technology solutions.','7','false','15','Information Management',19),

--('I301','Professional Practice','Prepare for transition into the ICT profession. Source an industry project and produce appropriate documentation.','7','true','15','Information Management',NULL),
--('I302','Industry Project','Undertake an industry-based project of a complex nature. During this experience you''ll manage an ICT project for industry; produce original work and project deliverables; consider and apply professional work ethics; meet project timelines and goals; record and evaluate project work and progress; and present project outcomes to sponsors and academic supervisors.','7','true','45','Information Management',24),
('T312','Network Security(CCNA Security)','Learn to configure the components and operation of Virtual Private Networks, firewalls and network security.','7','false','15','Network Technology',14),
--('T311','Systems Administration','Learn to design and construct a complex multi-user client/server network. You''ll gain skills needed to configure and integrate complex systems.','7','false','15','Network Technology',22),
('I303','Managerial Practice','Learn to analyse and evaluate management practices as they relate to the ICT industry. During your studies you''ll discuss and analyse key issues associated with managing and structuring the ICT capability within an organisation; recommend and design a quality management programme for an organisation; apply best practice human resource management techniques; and commentate on the relevant legislation and social responsibility issues as they relate to the ICT industry.','7','false','15','Information Management',17),
('I304','Data Analytics & Intelligence','Learn to use data analytics and business intelligence tools and techniques in order to provide decision support within an organisational context.','7','false','15','Information Management',9),
--('I311','Advanced Web Solutions','Learn to investigate, implement, and critique influentual, new, and emerging web technology solutions.','7','false','15','Information Management',19),
('D303','Java Mobile & Web','Learn to develop mobile applications for current and emerging mobile computing devices.','7','false','15','Software Development',5)
--('I367','Advanced Project Management','Learn advanced principles of the project management body of knowledge and cover the content of the Project Management Institute and its application and evaluation to the workplace.','7','false','15','Information Management',17)

INSERT INTO dbo.semester_paper VALUES
(1,1),(1,2),(1,3),(1,4),(2,5),(2,6),(2,7),(2,8),
(1,9),(1,10),(1,11),(1,12),(1,13),(1,14),(1,15),(1,16),(2,17),(2,18),(2,19),(2,20),(2,14),(2,21),(2,16),
(1,22),(1,23),(1,24),(1,25),(1,26),(1,27),(1,28),(1,29),(1,30),(1,31),(2,22),(2,23),(2,32),(2,30),(2,33),(2,34),(2,31),(2,35),(2,29)

--INSERT INTO dbo.summary VALUES
--(1,1,'FY','2','Year 2',2,1)


--SELECT * FROM dbo.major
--SELECT * FROM dbo.major_selected
--SELECT * FROM dbo.student
--SELECT * FROM dbo.semester
SELECT * FROM dbo.paper
--SELECT * FROM dbo.summary
SELECT * FROM dbo.semester_paper