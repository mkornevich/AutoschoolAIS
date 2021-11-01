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