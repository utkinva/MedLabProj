USE [master]
GO
CREATE DATABASE [MedLabDB]
GO
USE [MedLabDB]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointments](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PriceListID] [int] NOT NULL,
	[TimeOf] [time](7) NOT NULL,
	[DateOf] [date] NOT NULL,
	[PatientID] [int] NOT NULL,
	[MedicalWorkerID] [int] NOT NULL,
 CONSTRAINT [PK_Appointments] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedicalWorker](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
	[SpecializationID] [int] NOT NULL,
	[WorkingDays] [nvarchar](100) NULL,
 CONSTRAINT [PK_MedicalWorker] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[InsurancePolicy] [nvarchar](50) NOT NULL,
	[DateOfBirth] [date] NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PriceList](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NOT NULL,
	[Cost] [decimal](18, 0) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_PriceList] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Specializations]    Script Date: 10.06.2022 1:17:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Specializations](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](150) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Specializations] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[UserTypeID] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTypes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserTypes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Appointments] ON 
GO
INSERT [dbo].[Appointments] ([ID], [PriceListID], [TimeOf], [DateOf], [PatientID], [MedicalWorkerID]) VALUES (4, 5, CAST(N'12:15:00' AS Time), CAST(N'2022-06-18' AS Date), 1, 5)
GO
INSERT [dbo].[Appointments] ([ID], [PriceListID], [TimeOf], [DateOf], [PatientID], [MedicalWorkerID]) VALUES (5, 7, CAST(N'15:15:00' AS Time), CAST(N'2022-06-19' AS Date), 1, 1)
GO
SET IDENTITY_INSERT [dbo].[Appointments] OFF
GO
SET IDENTITY_INSERT [dbo].[MedicalWorker] ON 
GO
INSERT [dbo].[MedicalWorker] ([ID], [Name], [SpecializationID], [WorkingDays]) VALUES (1, N'Иванов И. А.', 1, N'Понедельник, вторник, среда')
GO
INSERT [dbo].[MedicalWorker] ([ID], [Name], [SpecializationID], [WorkingDays]) VALUES (5, N'Сергеев С.С.', 1, N'Вторник, среда, пятница')
GO
INSERT [dbo].[MedicalWorker] ([ID], [Name], [SpecializationID], [WorkingDays]) VALUES (8, N'Маслов И. С.', 1, N'Понедельник, вторник, пятница')
GO
SET IDENTITY_INSERT [dbo].[MedicalWorker] OFF
GO
SET IDENTITY_INSERT [dbo].[Patient] ON 
GO
INSERT [dbo].[Patient] ([ID], [Name], [Address], [Phone], [InsurancePolicy], [DateOfBirth]) VALUES (1, N'Николаева Н. П.', N'ул. Пушкина д. 33', N'+7 (119) 191-59-41', N'123-443-111 95', CAST(N'1999-02-15' AS Date))
GO
INSERT [dbo].[Patient] ([ID], [Name], [Address], [Phone], [InsurancePolicy], [DateOfBirth]) VALUES (2, N'Рожкова А. П.', N'ул. Измайлова 23', N'+7 (951) 955-61-64', N'561-546-546 54', CAST(N'1994-05-18' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Patient] OFF
GO
SET IDENTITY_INSERT [dbo].[PriceList] ON 
GO
INSERT [dbo].[PriceList] ([ID], [Title], [Cost], [Description]) VALUES (5, N'Клинический анализ крови', CAST(1140 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[PriceList] ([ID], [Title], [Cost], [Description]) VALUES (6, N'С-реактивный белок', CAST(630 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[PriceList] ([ID], [Title], [Cost], [Description]) VALUES (7, N'Аллергочип ImmunoCAP ISAC', CAST(33990 AS Decimal(18, 0)), NULL)
GO
INSERT [dbo].[PriceList] ([ID], [Title], [Cost], [Description]) VALUES (8, N'ПЦР-тест на РНК коронавируса SARS-CoV-2', CAST(2090 AS Decimal(18, 0)), NULL)
GO
SET IDENTITY_INSERT [dbo].[PriceList] OFF
GO
SET IDENTITY_INSERT [dbo].[Specializations] ON 
GO
INSERT [dbo].[Specializations] ([ID], [Title], [Description]) VALUES (1, N'Лаборант', NULL)
GO
SET IDENTITY_INSERT [dbo].[Specializations] OFF
GO
INSERT [dbo].[Users] ([Login], [Password], [UserTypeID]) VALUES (N'admin', N'admin', 1)
GO
INSERT [dbo].[Users] ([Login], [Password], [UserTypeID]) VALUES (N'alex', N'alex', 2)
GO
SET IDENTITY_INSERT [dbo].[UserTypes] ON 
GO
INSERT [dbo].[UserTypes] ([ID], [Title], [Description]) VALUES (1, N'SuperUser', NULL)
GO
INSERT [dbo].[UserTypes] ([ID], [Title], [Description]) VALUES (2, N'Administrator', NULL)
GO
SET IDENTITY_INSERT [dbo].[UserTypes] OFF
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK_Appointments_MedicalWorker] FOREIGN KEY([MedicalWorkerID])
REFERENCES [dbo].[MedicalWorker] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Appointments] CHECK CONSTRAINT [FK_Appointments_MedicalWorker]
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK_Appointments_Patient] FOREIGN KEY([PatientID])
REFERENCES [dbo].[Patient] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Appointments] CHECK CONSTRAINT [FK_Appointments_Patient]
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK_Appointments_PriceList] FOREIGN KEY([PriceListID])
REFERENCES [dbo].[PriceList] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Appointments] CHECK CONSTRAINT [FK_Appointments_PriceList]
GO
ALTER TABLE [dbo].[MedicalWorker]  WITH CHECK ADD  CONSTRAINT [FK_MedicalWorker_Specializations] FOREIGN KEY([SpecializationID])
REFERENCES [dbo].[Specializations] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MedicalWorker] CHECK CONSTRAINT [FK_MedicalWorker_Specializations]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_UserTypes] FOREIGN KEY([UserTypeID])
REFERENCES [dbo].[UserTypes] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_UserTypes]
GO
USE [master]
GO
ALTER DATABASE [MedLabDB] SET  READ_WRITE 
GO
