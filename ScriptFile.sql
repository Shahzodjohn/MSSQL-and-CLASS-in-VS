USE [passport]
GO
/****** Object:  Table [dbo].[spisok]    Script Date: 03.02.2021 18:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[spisok](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
	[Middle Name] [nvarchar](50) NULL,
	[Date of Birth] [date] NULL,
	[Job] [nvarchar](50) NULL,
	[Citizenship] [nvarchar](50) NULL,
 CONSTRAINT [PK_spisok] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
