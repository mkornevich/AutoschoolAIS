CREATE TABLE [User] (
	[Id] INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(64),
	[Email] NVARCHAR(64) UNIQUE,
	[Password] NVARCHAR(128),
	[Role] NVARCHAR(64),
)

CREATE TABLE [Group] (
	[Id] INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(64),
	[Comment] NTEXT,
	[StartAt] DATE,
	[EndAt] DATE,
)

CREATE TABLE [Student] (
	[Id] INT PRIMARY KEY IDENTITY,
	[UserId] INT,
	[GroupId] INT,
	CONSTRAINT FK_Student_To_User FOREIGN KEY (UserId)  REFERENCES [User] (Id) ON DELETE CASCADE,
	CONSTRAINT FK_Student_To_Group FOREIGN KEY (GroupId)  REFERENCES [Group] (Id) ON DELETE CASCADE,
)

CREATE TABLE [Subject] (
	[Id] INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(64),
	[Comment] NTEXT,
	[CreatedAt] DATETIME,
)

CREATE TABLE GroupSubjectHours (
	Id INT PRIMARY KEY IDENTITY,
	GroupId INT,
	SubjectId INT,
	[Hours] INT,
	UNIQUE (GroupId, SubjectId),
	CONSTRAINT FK_GroupSubjectHours_To_Group FOREIGN KEY (GroupId) REFERENCES [Group] (Id) ON DELETE CASCADE,
	CONSTRAINT FK_GroupSubjectHours_To_Subject FOREIGN KEY (SubjectId) REFERENCES [Subject] (Id) ON DELETE CASCADE,
)

CREATE TABLE [Car] (
	[Id] INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(64),
	[Number] NVARCHAR(32),
	[Comment] NTEXT,
)

CREATE TABLE [Teacher] (
	[Id] INT PRIMARY KEY IDENTITY,
	[UserId] INT,
	[SubjectId] INT,
	[PinnedCarId] INT,
	[IsWorked] BIT,
	[CreatedAt] DATETIME,
	CONSTRAINT FK_Teacher_To_User FOREIGN KEY (UserId)  REFERENCES [User] (Id) ON DELETE CASCADE,
	CONSTRAINT FK_Teacher_To_Subject FOREIGN KEY (SubjectId)  REFERENCES [Subject] (Id) ON DELETE CASCADE,
)

CREATE TABLE [Lesson] (
	[Id] INT PRIMARY KEY IDENTITY,
	[StudentId] INT,
	[TeacherId] INT,
	[IsPassed] BIT,
	[Hours] INT,
	[StartAt] DATETIME,
	CONSTRAINT FK_Lesson_To_Student FOREIGN KEY (StudentId)  REFERENCES [Student] (Id) ON DELETE CASCADE,
	CONSTRAINT FK_Lesson_To_Teacher FOREIGN KEY (TeacherId)  REFERENCES [Teacher] (Id) ON DELETE NO ACTION,
)

CREATE TABLE [Event] (
	[Id] INT PRIMARY KEY IDENTITY,
	[UserId] INT,
	[ObjectId] INT,
	[ObjectType] NVARCHAR(64),
	[EventType] NVARCHAR(64),
	[Description] NTEXT,
	[CreatedAt] DATETIME,
	CONSTRAINT FK_Event_To_User FOREIGN KEY (UserId) REFERENCES [User] (Id) ON DELETE CASCADE,
)

GO


CREATE VIEW HoursStatistic AS

SELECT 
	T1.GroupId AS GroupId,
	[Group].[Name] AS GroupName,

	T1.StudentId AS StudentId,
	[StudentUser].[Name] AS StudentName,

	T1.SubjectId AS SubjectId, 
	[Subject].[Name] AS SubjectName,

	GroupSubjectHours.[Hours] AS PlanHours,
	T1.PassedHours AS PassedHours, 
	GroupSubjectHours.[Hours] - T1.PassedHours AS LeftHours
FROM (
	SELECT
		Student.GroupId AS GroupId,
		Lesson.StudentId AS StudentId,
		Teacher.SubjectId AS SubjectId,
		SUM(Lesson.[Hours]) AS PassedHours
	FROM Lesson
	LEFT JOIN Student ON Student.Id = Lesson.StudentId
	LEFT JOIN Teacher ON Teacher.Id = Lesson.TeacherId
	GROUP BY Student.GroupId, Lesson.StudentId, Teacher.SubjectId) AS T1

LEFT JOIN GroupSubjectHours ON GroupSubjectHours.GroupId = T1.GroupId AND GroupSubjectHours.SubjectId = T1.SubjectId

LEFT JOIN [Group] ON [Group].Id = T1.GroupId
LEFT JOIN [Subject] ON [Subject].Id = T1.SubjectId

LEFT JOIN Student ON Student.Id = T1.StudentId
LEFT JOIN [User] AS StudentUser ON StudentUser.Id = Student.UserId

--ORDER BY GroupId, StudentName, SubjectName