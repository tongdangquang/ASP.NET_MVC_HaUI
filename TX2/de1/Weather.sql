USE [master]
GO
CREATE DATABASE [Weather]  
GO
USE [Weather]
GO
/****** Object:  Table [dbo].[City]    Script Date: 13/12/2024 5:49:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[ID] [varchar](10) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ForeCast]    Script Date: 13/12/2024 5:49:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ForeCast](
	[CityID] [varchar](10) NOT NULL,
	[Date] [date] NOT NULL,
	[MinTemperature] [decimal](18, 1) NULL,
	[MaxTemperature] [decimal](18, 1) NULL,
	[Humidity] [int] NULL,
	[Icon] [varchar](10) NULL,
 CONSTRAINT [PK_ForeCast] PRIMARY KEY CLUSTERED 
(
	[CityID] ASC,
	[Date] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[City] ([ID], [Name]) VALUES (N'1', N'Hà Nội')
GO
INSERT [dbo].[City] ([ID], [Name]) VALUES (N'2', N'TP. Hồ Chí Minh')
GO
INSERT [dbo].[City] ([ID], [Name]) VALUES (N'3', N'Hải Phòng')
GO
INSERT [dbo].[ForeCast] ([CityID], [Date], [MinTemperature], [MaxTemperature], [Humidity], [Icon]) VALUES (N'1', CAST(N'2024-12-14' AS Date), CAST(24.0 AS Decimal(18, 1)), CAST(34.0 AS Decimal(18, 1)), 87, N'1.png')
GO
INSERT [dbo].[ForeCast] ([CityID], [Date], [MinTemperature], [MaxTemperature], [Humidity], [Icon]) VALUES (N'1', CAST(N'2024-12-15' AS Date), CAST(20.0 AS Decimal(18, 1)), CAST(27.0 AS Decimal(18, 1)), 68, N'1.png')
GO
INSERT [dbo].[ForeCast] ([CityID], [Date], [MinTemperature], [MaxTemperature], [Humidity], [Icon]) VALUES (N'2', CAST(N'2024-12-14' AS Date), CAST(26.0 AS Decimal(18, 1)), CAST(33.0 AS Decimal(18, 1)), 40, N'2.png')
GO
INSERT [dbo].[ForeCast] ([CityID], [Date], [MinTemperature], [MaxTemperature], [Humidity], [Icon]) VALUES (N'2', CAST(N'2024-12-15' AS Date), CAST(23.0 AS Decimal(18, 1)), CAST(31.0 AS Decimal(18, 1)), 90, N'2.png')
GO
INSERT [dbo].[ForeCast] ([CityID], [Date], [MinTemperature], [MaxTemperature], [Humidity], [Icon]) VALUES (N'3', CAST(N'2024-12-14' AS Date), CAST(20.0 AS Decimal(18, 1)), CAST(32.0 AS Decimal(18, 1)), 98, N'3.png')
GO
INSERT [dbo].[ForeCast] ([CityID], [Date], [MinTemperature], [MaxTemperature], [Humidity], [Icon]) VALUES (N'3', CAST(N'2024-12-15' AS Date), CAST(18.0 AS Decimal(18, 1)), CAST(26.0 AS Decimal(18, 1)), 90, N'3.png')
GO
ALTER TABLE [dbo].[ForeCast]  WITH CHECK ADD  CONSTRAINT [FK_ForeCast_City] FOREIGN KEY([CityID])
REFERENCES [dbo].[City] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ForeCast] CHECK CONSTRAINT [FK_ForeCast_City]
GO
