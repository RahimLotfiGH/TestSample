USE [ApSampleDb]
GO

/****** Object:  Table [acc].[AppUserAddressArchive]    Script Date: 1/16/2023 11:10:35 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [acc].[AppUserAddressArchive](
	[Id] [bigint] NOT NULL,
	[Address] [nvarchar](255) NULL,
	[CityId] [int] NULL,
	[AppUserId] [int] NULL,
 CONSTRAINT [PK_Acc.AppUserAddressArchive] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


