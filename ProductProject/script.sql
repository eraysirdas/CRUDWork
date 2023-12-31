USE [ProductStore]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 7 Eyl 2023 05:01:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL,
	[Color] [nvarchar](50) NULL,
	[Category] [nvarchar](50) NULL,
	[Price] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
