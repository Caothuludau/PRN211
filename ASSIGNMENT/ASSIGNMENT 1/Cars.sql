USE [master]
GO
/****** Object:  Database [Cars]    Script Date: 01/18/2022 17:41:35 ******/
CREATE DATABASE [Cars] 
GO
USE [Cars]
GO
/****** Object:  StoredProcedure [dbo].[GetPetName]    Script Date: 01/18/2022 17:41:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPetName]
@carID int,
@petName char(20) output

AS

SELECT @petName = PetName from Inventory where CarID = @carID
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 01/18/2022 17:41:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customers](
	[FirstName] [char](20) NULL,
	[LastName] [char](20) NULL,
	[CustID] [int] IDENTITY(0,1) NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON
INSERT [dbo].[Customers] ([FirstName], [LastName], [CustID]) VALUES (N'Mike                ', N'Larson              ', 0)
INSERT [dbo].[Customers] ([FirstName], [LastName], [CustID]) VALUES (N'Amy                 ', N'Smith               ', 1)
INSERT [dbo].[Customers] ([FirstName], [LastName], [CustID]) VALUES (N'Kandi               ', N'Nash                ', 2)
SET IDENTITY_INSERT [dbo].[Customers] OFF
/****** Object:  Table [dbo].[Cars]    Script Date: 01/18/2022 17:41:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cars](
	[CarID] [int] IDENTITY(1,1) NOT NULL,
	[Make] [char](20) NULL,
	[Color] [char](20) NULL,
	[PetName] [char](20) NULL,
 CONSTRAINT [PK_Inventory] PRIMARY KEY CLUSTERED 
(
	[CarID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Cars] ON
INSERT [dbo].[Cars] ([CarID], [Make], [Color], [PetName]) VALUES (0, N'BMW                 ', N'blue                ', N'Chucky              ')
INSERT [dbo].[Cars] ([CarID], [Make], [Color], [PetName]) VALUES (1, N'BMW                 ', N'Green               ', N'Snake               ')
INSERT [dbo].[Cars] ([CarID], [Make], [Color], [PetName]) VALUES (2, N'Viper               ', N'Red                 ', N'Zippy               ')
INSERT [dbo].[Cars] ([CarID], [Make], [Color], [PetName]) VALUES (3, N'BMW                 ', N'Pink                ', N'Buddha              ')
INSERT [dbo].[Cars] ([CarID], [Make], [Color], [PetName]) VALUES (4, N'Colt                ', N'Rust                ', N'Rusty     1         ')
SET IDENTITY_INSERT [dbo].[Cars] OFF
/****** Object:  Table [dbo].[Orders]    Script Date: 01/18/2022 17:41:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(0,1) NOT NULL,
	[CarID] [int] NULL,
	[CustID] [int] NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Orders] ON
INSERT [dbo].[Orders] ([OrderID], [CarID], [CustID]) VALUES (0, 0, 0)
INSERT [dbo].[Orders] ([OrderID], [CarID], [CustID]) VALUES (1, 4, 1)
SET IDENTITY_INSERT [dbo].[Orders] OFF
/****** Object:  ForeignKey [FK_Orders_Customers]    Script Date: 01/18/2022 17:41:36 ******/
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CustID])
REFERENCES [dbo].[Customers] ([CustID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
/****** Object:  ForeignKey [FK_Orders_Inventory]    Script Date: 01/18/2022 17:41:36 ******/
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Inventory] FOREIGN KEY([CarID])
REFERENCES [dbo].[Cars] ([CarID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Inventory]
GO
