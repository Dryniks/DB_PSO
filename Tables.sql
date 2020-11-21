USE [PSO]
GO
/****** Object:  Table [dbo].[coordinator]    Script Date: 22.11.2020 0:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[coordinator](
	[idTeam] [int] NOT NULL,
	[idRegion] [int] NULL,
 CONSTRAINT [PK_coordinator] PRIMARY KEY CLUSTERED 
(
	[idTeam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[department]    Script Date: 22.11.2020 0:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[department](
	[idDepartment] [int] NOT NULL,
	[address] [nvarchar](150) NULL,
	[idMainDepartment] [int] NULL,
 CONSTRAINT [PK_department] PRIMARY KEY CLUSTERED 
(
	[idDepartment] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[disaster]    Script Date: 22.11.2020 0:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[disaster](
	[idDisaster] [int] NOT NULL,
	[date] [date] NULL,
	[country] [nvarchar](50) NULL,
	[city] [nvarchar](50) NULL,
 CONSTRAINT [PK_Disaster] PRIMARY KEY CLUSTERED 
(
	[idDisaster] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[equipment]    Script Date: 22.11.2020 0:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[equipment](
	[idEquipment] [int] NOT NULL,
	[idProfession] [int] NULL,
	[equipmentName] [nvarchar](100) NULL,
	[type] [nvarchar](50) NULL,
	[description] [nvarchar](200) NULL,
 CONSTRAINT [PK_equipment] PRIMARY KEY CLUSTERED 
(
	[idEquipment] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mainDepartment]    Script Date: 22.11.2020 0:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mainDepartment](
	[idMainDepartment] [int] NOT NULL,
	[address] [nvarchar](150) NULL,
 CONSTRAINT [PK_mainDepartment] PRIMARY KEY CLUSTERED 
(
	[idMainDepartment] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[missingPeople]    Script Date: 22.11.2020 0:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[missingPeople](
	[idPeople] [int] NOT NULL,
	[dateOfLoss] [date] NULL,
	[lastLocation] [nvarchar](200) NULL,
	[specialSign] [nvarchar](200) NULL,
 CONSTRAINT [PK_missingPeople] PRIMARY KEY CLUSTERED 
(
	[idPeople] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[people]    Script Date: 22.11.2020 0:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[people](
	[idPeople] [int] NOT NULL,
	[family] [nvarchar](50) NULL,
	[name] [nvarchar](50) NULL,
	[middleName] [nvarchar](50) NULL,
	[dateOfBirth] [date] NULL,
 CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED 
(
	[idPeople] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[profession]    Script Date: 22.11.2020 0:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[profession](
	[idProfession] [int] NOT NULL,
	[position] [nvarchar](50) NULL,
 CONSTRAINT [PK_profession] PRIMARY KEY CLUSTERED 
(
	[idProfession] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reason]    Script Date: 22.11.2020 0:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reason](
	[idReason] [int] NOT NULL,
	[typeReason] [nvarchar](50) NULL,
	[reason] [nvarchar](50) NULL,
	[idDisaster] [int] NULL,
 CONSTRAINT [PK_Reason] PRIMARY KEY CLUSTERED 
(
	[idReason] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[region]    Script Date: 22.11.2020 0:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[region](
	[idRegion] [int] NOT NULL,
	[address] [nvarchar](150) NULL,
	[idDepartment] [int] NULL,
 CONSTRAINT [PK_region] PRIMARY KEY CLUSTERED 
(
	[idRegion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[team]    Script Date: 22.11.2020 0:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[team](
	[idTeam] [int] NOT NULL,
	[teamName] [nvarchar](50) NULL,
	[idDisaster] [int] NULL,
	[idPeople] [int] NULL,
 CONSTRAINT [PK_team] PRIMARY KEY CLUSTERED 
(
	[idTeam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[teamPosition]    Script Date: 22.11.2020 0:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[teamPosition](
	[idTeam] [int] NOT NULL,
	[seniorLifeguard] [int] NULL,
	[doctor] [int] NULL,
	[paramedic] [int] NULL,
	[driver] [int] NULL,
	[pyrotechnist] [int] NULL,
	[gasWelder] [int] NULL,
	[craneOperator] [int] NULL,
	[scubaDriver] [int] NULL,
	[hydraulicEquipmentTechnician] [int] NULL,
	[scout] [int] NULL,
	[electrician] [int] NULL,
	[rescuer] [int] NULL,
 CONSTRAINT [PK_TeamPosition] PRIMARY KEY CLUSTERED 
(
	[idTeam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user]    Script Date: 22.11.2020 0:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[idUser] [int] NOT NULL,
	[login] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[family] [nvarchar](50) NULL,
	[name] [nvarchar](50) NULL,
	[middleName] [nvarchar](50) NULL,
	[idProfession] [int] NULL,
	[idTeam] [int] NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[coordinator]  WITH CHECK ADD  CONSTRAINT [FK_coordinator_region] FOREIGN KEY([idRegion])
REFERENCES [dbo].[region] ([idRegion])
GO
ALTER TABLE [dbo].[coordinator] CHECK CONSTRAINT [FK_coordinator_region]
GO
ALTER TABLE [dbo].[department]  WITH CHECK ADD  CONSTRAINT [FK_department_mainDepartment] FOREIGN KEY([idMainDepartment])
REFERENCES [dbo].[mainDepartment] ([idMainDepartment])
GO
ALTER TABLE [dbo].[department] CHECK CONSTRAINT [FK_department_mainDepartment]
GO
ALTER TABLE [dbo].[equipment]  WITH CHECK ADD  CONSTRAINT [FK_equipment_profession] FOREIGN KEY([idProfession])
REFERENCES [dbo].[profession] ([idProfession])
GO
ALTER TABLE [dbo].[equipment] CHECK CONSTRAINT [FK_equipment_profession]
GO
ALTER TABLE [dbo].[people]  WITH CHECK ADD  CONSTRAINT [FK_People_missingPeople] FOREIGN KEY([idPeople])
REFERENCES [dbo].[missingPeople] ([idPeople])
GO
ALTER TABLE [dbo].[people] CHECK CONSTRAINT [FK_People_missingPeople]
GO
ALTER TABLE [dbo].[reason]  WITH CHECK ADD  CONSTRAINT [FK_Reason_Disaster] FOREIGN KEY([idDisaster])
REFERENCES [dbo].[disaster] ([idDisaster])
GO
ALTER TABLE [dbo].[reason] CHECK CONSTRAINT [FK_Reason_Disaster]
GO
ALTER TABLE [dbo].[region]  WITH CHECK ADD  CONSTRAINT [FK_region_department] FOREIGN KEY([idDepartment])
REFERENCES [dbo].[department] ([idDepartment])
GO
ALTER TABLE [dbo].[region] CHECK CONSTRAINT [FK_region_department]
GO
ALTER TABLE [dbo].[team]  WITH CHECK ADD  CONSTRAINT [FK_team_Disaster] FOREIGN KEY([idDisaster])
REFERENCES [dbo].[disaster] ([idDisaster])
GO
ALTER TABLE [dbo].[team] CHECK CONSTRAINT [FK_team_Disaster]
GO
ALTER TABLE [dbo].[team]  WITH CHECK ADD  CONSTRAINT [FK_team_missingPeople] FOREIGN KEY([idPeople])
REFERENCES [dbo].[missingPeople] ([idPeople])
GO
ALTER TABLE [dbo].[team] CHECK CONSTRAINT [FK_team_missingPeople]
GO
ALTER TABLE [dbo].[teamPosition]  WITH CHECK ADD  CONSTRAINT [FK_TeamPosition_coordinator] FOREIGN KEY([idTeam])
REFERENCES [dbo].[coordinator] ([idTeam])
GO
ALTER TABLE [dbo].[teamPosition] CHECK CONSTRAINT [FK_TeamPosition_coordinator]
GO
ALTER TABLE [dbo].[teamPosition]  WITH CHECK ADD  CONSTRAINT [FK_TeamPosition_team] FOREIGN KEY([idTeam])
REFERENCES [dbo].[team] ([idTeam])
GO
ALTER TABLE [dbo].[teamPosition] CHECK CONSTRAINT [FK_TeamPosition_team]
GO
ALTER TABLE [dbo].[user]  WITH CHECK ADD  CONSTRAINT [FK_user_profession] FOREIGN KEY([idProfession])
REFERENCES [dbo].[profession] ([idProfession])
GO
ALTER TABLE [dbo].[user] CHECK CONSTRAINT [FK_user_profession]
GO
ALTER TABLE [dbo].[user]  WITH CHECK ADD  CONSTRAINT [FK_user_TeamPosition] FOREIGN KEY([idTeam])
REFERENCES [dbo].[teamPosition] ([idTeam])
GO
ALTER TABLE [dbo].[user] CHECK CONSTRAINT [FK_user_TeamPosition]
GO
