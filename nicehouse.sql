USE [NiceHouse]
GO
/****** Object:  Table [dbo].[Images]    Script Date: 27/09/2024 8:37:37 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Images](
	[ImagineId] [int] IDENTITY(1,1) NOT NULL,
	[Path] [nvarchar](max) NULL,
	[ProductId] [int] NULL,
 CONSTRAINT [PK_Images] PRIMARY KEY CLUSTERED 
(
	[ImagineId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 27/09/2024 8:37:37 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[Rooms] [int] NULL,
	[Price] [real] NULL,
	[Square] [real] NULL,
	[Rent] [real] NULL,
	[IsSold] [bit] NULL,
	[IsRent] [bit] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Images] ON 

INSERT [dbo].[Images] ([ImagineId], [Path], [ProductId]) VALUES (1, N'https://drive.google.com/file/d/1YpU7N7FpgxXn8Yk_QsjVbQqWJ95PipQD/view?usp=drive_link', 1)
INSERT [dbo].[Images] ([ImagineId], [Path], [ProductId]) VALUES (2, N'https://drive.google.com/file/d/1-PMp-m-2Z6Y5exIVVpugzjThFvag3m6L/view?usp=drive_link', 1)
INSERT [dbo].[Images] ([ImagineId], [Path], [ProductId]) VALUES (3, N'https://drive.google.com/file/d/1HdwaxUD_EC2Xb603OWdESIiUL3ouoami/view?usp=sharing', 1)
INSERT [dbo].[Images] ([ImagineId], [Path], [ProductId]) VALUES (4, N'https://drive.google.com/file/d/1uZIYgp88amOdUS1mtA-v1SCk8to5ReL4/view?usp=drive_link', 1)
INSERT [dbo].[Images] ([ImagineId], [Path], [ProductId]) VALUES (5, N'https://drive.google.com/file/d/17oJq7mG5S55jUB7xZrUL9hBT2DK2BHbb/view?usp=drive_link', 1)
INSERT [dbo].[Images] ([ImagineId], [Path], [ProductId]) VALUES (6, N'https://drive.google.com/file/d/14eSMjNFM4tz0VCm9oHGY8wMNdrMP4UD5/view?usp=sharing', 1)
INSERT [dbo].[Images] ([ImagineId], [Path], [ProductId]) VALUES (7, N'https://drive.google.com/file/d/1FHqi7Kq7qyhY_j5r2x3aPdMv2gBW5rRl/view?usp=sharing', 1)
INSERT [dbo].[Images] ([ImagineId], [Path], [ProductId]) VALUES (8, N'https://drive.google.com/file/d/1U1jQ9A7CRHokpCuRl7mwAOSoZF2u9zU-/view?usp=drive_link', 1)
INSERT [dbo].[Images] ([ImagineId], [Path], [ProductId]) VALUES (9, N'https://drive.google.com/file/d/1I1HD1zBYl6EhhFUr5NFBdvu2fFkhXRRX/view?usp=drive_link', 1)
INSERT [dbo].[Images] ([ImagineId], [Path], [ProductId]) VALUES (10, N'https://drive.google.com/file/d/1dQWxWA8AIyyGb_Uj-gJJPuzVJXkFMcFD/view?usp=drive_link', 1)
INSERT [dbo].[Images] ([ImagineId], [Path], [ProductId]) VALUES (11, N'https://drive.google.com/file/d/1Ne4gffEpxdvljQlpXvNl4UfkD6D6uRm5/view?usp=drive_link', 2)
INSERT [dbo].[Images] ([ImagineId], [Path], [ProductId]) VALUES (12, N'https://drive.google.com/file/d/1egZnvhkQaAV2P3PiGIviDd2HW2ebA3l-/view?usp=drive_link', 2)
INSERT [dbo].[Images] ([ImagineId], [Path], [ProductId]) VALUES (13, N'https://drive.google.com/file/d/1LbXidyOOQvPnybsyFRyMmMOPeTeK1RQH/view?usp=drive_link', 2)
INSERT [dbo].[Images] ([ImagineId], [Path], [ProductId]) VALUES (14, N'https://drive.google.com/file/d/17dlF-zRWeILcKVVLemc9zp8Hr20nrdXZ/view?usp=drive_link', 2)
INSERT [dbo].[Images] ([ImagineId], [Path], [ProductId]) VALUES (15, N'https://drive.google.com/file/d/1qQOkySJaKQAj9iCPUehHcoPXIHrOo6EE/view?usp=drive_link', 2)
INSERT [dbo].[Images] ([ImagineId], [Path], [ProductId]) VALUES (16, N'https://drive.google.com/file/d/117A5-PoFK2O_GvuUOHTPM9Qtv-czaqWq/view?usp=drive_link', 2)
SET IDENTITY_INSERT [dbo].[Images] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Address], [Rooms], [Price], [Square], [Rent], [IsSold], [IsRent]) VALUES (1, N'Chung cư NOXH An Phú Thịnh 01', N'rèm, 2 máy lạnh, máy quạt, bàn làm việc, bộ sofa, tủ lạnh, 1giường nệm, máy lọc nước, 2 tủ quần áo, bàn trang điểm, chén bát,.....', N'Khu đô thị An Phú Thịnh', 2, 4500000, 55, 4500000, 0, 1)
INSERT [dbo].[Products] ([ProductId], [Name], [Description], [Address], [Rooms], [Price], [Square], [Rent], [IsSold], [IsRent]) VALUES (2, N'Chung cư NOXH An Phú Thịnh 02', N'rèm, bàn ăn, sofa, tivi, bàn làm việc, bếp từ, 3 máy lạnh, tủ lạnh,máy giặt, máy nước nóng,1 giường, 2 nệm, 2 tủ quần áo, ...', N'Khu đô thị An Phú Thịnh', 2, NULL, 55, 4500000, 0, 1)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
ALTER TABLE [dbo].[Images]  WITH CHECK ADD  CONSTRAINT [FK_Images_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([ProductId])
GO
ALTER TABLE [dbo].[Images] CHECK CONSTRAINT [FK_Images_Products_ProductId]
GO
