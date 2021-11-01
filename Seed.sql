SET IDENTITY_INSERT [User] ON;
DELETE FROM [User];
INSERT INTO [User](Id, [Name], Email, [Password], [Role]) VALUES
(1, N'admin', N'admin@gmail.ru', N'a', N'admin'),
(2, N'viewer', N'viewer@gmail.ru', N'v', N'viewer'),
(3, N'guest', N'guest@gmail.ru', N'g', N'guest'),
(14, N'Учитель вождения', N'd1@gmail.ru', N'g', N'guest'),
(15, N'Учитель вождения', N'd2@gmail.ru', N'g', N'guest'),
(16, N'Учитель вождения', N'd3@gmail.ru', N'g', N'guest'),
(17, N'Учитель вождения', N'd4@gmail.ru', N'g', N'guest'),
(18, N'Учитель вождения', N'd5@gmail.ru', N'g', N'guest'),
(19, N'Учитель по медицине', N't1@gmail.ru', N'g', N'guest'),
(20, N'Учитель теории', N't2@gmail.ru', N'g', N'guest'),
(21, N'Учитель теории 2', N't3@gmail.ru', N'g', N'guest'),
(4, N'Пользователь 1', N'u1@gmail.com', N'g', N'guest'),
(5, N'Пользователь 2', N'u2@gmail.com', N'g', N'guest'),
(6, N'Пользователь 3', N'u3@gmail.com', N'g', N'guest'),
(7, N'Пользователь 4', N'u4@gmail.com', N'g', N'guest'),
(8, N'Пользователь 5', N'u5@gmail.com', N'g', N'guest'),
(9, N'Пользователь 6', N'u6@gmail.com', N'g', N'guest'),
(10, N'Пользователь 7', N'u7@gmail.com', N'g', N'guest'),
(11, N'Пользователь 8', N'u8@gmail.com', N'g', N'guest'),
(12, N'Пользователь 9', N'u9@gmail.com', N'g', N'guest'),
(13, N'Пользователь 10', N'u10@gmail.com', N'g', N'guest');
SET IDENTITY_INSERT [User] OFF;

SET IDENTITY_INSERT [Group] ON;
DELETE FROM [Group];
INSERT INTO [Group](Id, [Name], [Comment], StartAt, EndAt) VALUES
(1, N'Группа А', N'Категория А', '2021-05-13', '2021-06-13'),
(2, N'Группа Б', N'Категория Б', '2021-05-13', '2021-06-13'),
(3, N'Группа А 2', N'Категория А', '2021-07-13', '2021-08-13'),
(4, N'Группа Б 2', N'Категория Б', '2021-07-13', '2021-08-13');
SET IDENTITY_INSERT [Group] OFF;

SET IDENTITY_INSERT [Student] ON;
DELETE FROM [Student];
INSERT INTO [Student](Id, UserId, GroupId) VALUES
(1, 4, 1),
(2, 5, 1),
(3, 6, 1),
(4, 7, 1),
(5, 8, 1),
(6, 9, 2),
(7, 10, 2),
(8, 11, 2),
(9, 12, 2),
(10, 13, 2);
SET IDENTITY_INSERT [Student] OFF;

SET IDENTITY_INSERT [Subject] ON;
DELETE FROM [Subject];
INSERT INTO [Subject](Id, [Name], Comment, CreatedAt) VALUES
(1, N'Вождение', N'А', '2021-10-14 12:00:00'),
(2, N'Медицина', N'А', '2021-10-14 12:00:00'),
(3, N'Теория', N'А', '2021-10-14 12:00:00');
SET IDENTITY_INSERT [Subject] OFF;

SET IDENTITY_INSERT [GroupSubjectHours] ON;
DELETE FROM [GroupSubjectHours];
INSERT INTO GroupSubjectHours(Id, GroupId, SubjectId, [Hours]) VALUES
(1, 1, 1, 20),
(2, 1, 2, 7),
(3, 1, 3, 20),
(4, 2, 1, 20),
(5, 2, 2, 6),
(6, 2, 3, 19);
SET IDENTITY_INSERT [GroupSubjectHours] OFF;

SET IDENTITY_INSERT [Car] ON;
DELETE FROM [Car];
INSERT INTO Car(Id, [Name], Number, Comment) VALUES
(1, N'Машина 1', N'1111-AD', N''),
(2, N'Машина 2', N'1112-AD', N'Плохо работают тормоза'),
(3, N'Машина 3', N'1113-AD', N''),
(4, N'Машина 4', N'1114-AD', N''),
(5, N'Машина 5', N'1115-AD', N''),
(6, N'Машина 6', N'1116-AD', N'На ремонте');
SET IDENTITY_INSERT [Car] OFF;

SET IDENTITY_INSERT [Teacher] ON;
DELETE FROM [Teacher];
INSERT INTO Teacher(Id, UserId, SubjectId, PinnedCarId, IsWorked, CreatedAt) VALUES
(1, 14, 1, 1, 1, '2021-10-14 12:00:00'),
(2, 15, 1, 2, 1, '2021-10-14 12:00:00'),
(3, 16, 1, 3, 1, '2021-10-14 12:00:00'),
(4, 17, 1, 4, 1, '2021-10-14 12:00:00'),
(5, 18, 1, 5, 1, '2021-10-14 12:00:00'),
(6, 19, 2, NULL, 1, '2021-10-14 12:00:00'),
(7, 20, 3, NULL, 1, '2021-10-14 12:00:00'),
(8, 21, 3, NULL, 0, '2021-10-14 12:00:00'),
(9, 21, 2, NULL, 1, '2021-10-14 12:00:00');
SET IDENTITY_INSERT [Teacher] OFF;

SET IDENTITY_INSERT [Lesson] ON;
DELETE FROM [Lesson];
INSERT INTO Lesson(Id, StudentId, TeacherId, IsPassed, [Hours], StartAt) VALUES

-- ГРУППА 1 ---

-- ВОЖДЕНИЕ
(1, 1, 1, 1, 1, '2021-10-14 12:00:00'),
(2, 1, 2, 1, 1, '2021-10-14 12:00:00'),
(3, 2, 3, 1, 1, '2021-10-14 12:00:00'),

-- ОБЫЧНИЕ ПРЕДМЕТЫ
(4, 3, 6, 1, 1, '2021-10-14 12:00:00'),
(5, 4, 7, 1, 1, '2021-10-14 12:00:00'),
(6, 5, 7, 1, 1, '2021-10-14 12:00:00');
SET IDENTITY_INSERT [Lesson] OFF;