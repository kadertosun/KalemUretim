USE [Depo]
GO
/****** Object:  Table [dbo].[kalem]    Script Date: 1.12.2021 18:01:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kalem](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[uretim_tarihi] [smalldatetime] NOT NULL,
	[uretilen_miktar] [int] NOT NULL,
	[urun_adi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_kalem] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[kalem] ON 

INSERT [dbo].[kalem] ([id], [uretim_tarihi], [uretilen_miktar], [urun_adi]) VALUES (3, CAST(N'2021-11-27T00:00:00' AS SmallDateTime), 74, N'kalem')
INSERT [dbo].[kalem] ([id], [uretim_tarihi], [uretilen_miktar], [urun_adi]) VALUES (4, CAST(N'2021-11-09T00:00:00' AS SmallDateTime), 500, N'kırmızı kalem')
INSERT [dbo].[kalem] ([id], [uretim_tarihi], [uretilen_miktar], [urun_adi]) VALUES (5, CAST(N'2021-11-09T00:00:00' AS SmallDateTime), 500, N'kırmızı kalem')
SET IDENTITY_INSERT [dbo].[kalem] OFF
GO
