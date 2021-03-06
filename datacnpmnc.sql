USE [QLMT]
GO
/****** Object:  Table [dbo].[ChiTietDG]    Script Date: 6/17/2021 3:09:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDG](
	[IDKH] [int] NOT NULL,
	[IDMau] [varchar](50) NOT NULL,
	[NoiDungDG] [nvarchar](200) NULL,
 CONSTRAINT [PK_ChiTietDanhGia] PRIMARY KEY CLUSTERED 
(
	[IDKH] ASC,
	[IDMau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHD]    Script Date: 6/17/2021 3:09:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHD](
	[IDHD] [varchar](50) NOT NULL,
	[IDXe] [varchar](50) NOT NULL,
	[KhuyenMai] [int] NULL,
	[GiaBan] [money] NOT NULL,
 CONSTRAINT [PK_ChiTietHD] PRIMARY KEY CLUSTERED 
(
	[IDHD] ASC,
	[IDXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hang]    Script Date: 6/17/2021 3:09:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hang](
	[IDHang] [varchar](50) NOT NULL,
	[TenHang] [nvarchar](50) NOT NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_Hang] PRIMARY KEY CLUSTERED 
(
	[IDHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 6/17/2021 3:09:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[IDHD] [varchar](50) NOT NULL,
	[IDKH] [int] NOT NULL,
	[NgayDat] [datetime] NOT NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[IDHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 6/17/2021 3:09:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[IDKH] [int] NOT NULL,
	[IDType] [varchar](50) NULL,
	[Email] [varchar](50) NOT NULL,
	[Pass] [varchar](50) NOT NULL,
	[TenKH] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DienThoai] [varchar](20) NOT NULL,
	[Avatar] [varchar](max) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[IDKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhuyenMai]    Script Date: 6/17/2021 3:09:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuyenMai](
	[IDKM] [varchar](50) NOT NULL,
	[GiaTri] [int] NOT NULL,
 CONSTRAINT [PK_KhuyenMai] PRIMARY KEY CLUSTERED 
(
	[IDKM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiXe]    Script Date: 6/17/2021 3:09:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiXe](
	[IDLoaiXe] [nvarchar](50) NOT NULL,
	[TenLoaiXe] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiXe] PRIMARY KEY CLUSTERED 
(
	[IDLoaiXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MauXe]    Script Date: 6/17/2021 3:09:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MauXe](
	[IDMau] [varchar](50) NOT NULL,
	[IDKM] [varchar](50) NOT NULL,
	[IDHang] [varchar](50) NOT NULL,
	[IDLoaiXe] [nvarchar](50) NULL,
	[TenXe] [nvarchar](50) NOT NULL,
	[GiaBan] [money] NOT NULL,
	[HinhAnh1] [varchar](max) NULL,
	[HinhAnh2] [varchar](max) NULL,
	[HinhAnh3] [varchar](max) NULL,
	[BaoHanh] [int] NOT NULL,
	[MoTa] [nvarchar](max) NOT NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_MauXe] PRIMARY KEY CLUSTERED 
(
	[IDMau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 6/17/2021 3:09:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[IDNV] [int] NOT NULL,
	[IDType] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Pass] [varchar](50) NOT NULL,
	[TenNV] [nvarchar](100) NOT NULL,
	[DienThoai] [varchar](20) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[CMND] [varchar](20) NOT NULL,
	[Avatar] [varchar](max) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[IDNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeAcc]    Script Date: 6/17/2021 3:09:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeAcc](
	[IDType] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[IDType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Xe]    Script Date: 6/17/2021 3:09:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xe](
	[IDXe] [varchar](50) NOT NULL,
	[IDMau] [varchar](50) NOT NULL,
	[TrangThai] [int] NOT NULL,
	[TenXe] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Xe] PRIMARY KEY CLUSTERED 
(
	[IDXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[ChiTietHD] ([IDHD], [IDXe], [KhuyenMai], [GiaBan]) VALUES (N'HD1', N'REBEL-500-1', 0, 180000000.0000)
INSERT [dbo].[ChiTietHD] ([IDHD], [IDXe], [KhuyenMai], [GiaBan]) VALUES (N'HD2', N'S1000RR-1', 5, 949000000.0000)
INSERT [dbo].[ChiTietHD] ([IDHD], [IDXe], [KhuyenMai], [GiaBan]) VALUES (N'HD3', N'XZF-R1-1', 0, 790000000.0000)
INSERT [dbo].[ChiTietHD] ([IDHD], [IDXe], [KhuyenMai], [GiaBan]) VALUES (N'HD4', N'REBEL-500-2', 0, 180000000.0000)
INSERT [dbo].[ChiTietHD] ([IDHD], [IDXe], [KhuyenMai], [GiaBan]) VALUES (N'HD4', N'REBEL-500-3', 0, 180000000.0000)
INSERT [dbo].[ChiTietHD] ([IDHD], [IDXe], [KhuyenMai], [GiaBan]) VALUES (N'HD5', N'CBR-1000RR-1', 0, 560000000.0000)
GO
INSERT [dbo].[Hang] ([IDHang], [TenHang], [TrangThai]) VALUES (N'BMW', N'BMW', 1)
INSERT [dbo].[Hang] ([IDHang], [TenHang], [TrangThai]) VALUES (N'DCT', N'Ducati', 1)
INSERT [dbo].[Hang] ([IDHang], [TenHang], [TrangThai]) VALUES (N'HD', N'Honda', 1)
INSERT [dbo].[Hang] ([IDHang], [TenHang], [TrangThai]) VALUES (N'KTM', N'KTM', 1)
INSERT [dbo].[Hang] ([IDHang], [TenHang], [TrangThai]) VALUES (N'KW', N'Kawasaki', 1)
INSERT [dbo].[Hang] ([IDHang], [TenHang], [TrangThai]) VALUES (N'SZ', N'Suzuki', 1)
INSERT [dbo].[Hang] ([IDHang], [TenHang], [TrangThai]) VALUES (N'YM', N'Yamaha', 1)
GO
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [NgayDat], [TrangThai]) VALUES (N'HD0', 2, CAST(N'2000-01-01T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [NgayDat], [TrangThai]) VALUES (N'HD1', 1, CAST(N'2021-06-07T22:12:00.000' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [NgayDat], [TrangThai]) VALUES (N'HD2', 36, CAST(N'2021-06-09T01:37:02.000' AS DateTime), 0)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [NgayDat], [TrangThai]) VALUES (N'HD3', 36, CAST(N'2021-06-17T13:15:54.317' AS DateTime), 2)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [NgayDat], [TrangThai]) VALUES (N'HD4', 36, CAST(N'2021-06-17T13:37:33.000' AS DateTime), 1)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [NgayDat], [TrangThai]) VALUES (N'HD5', 36, CAST(N'2021-06-17T13:38:38.237' AS DateTime), 2)
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [NgayDat], [TrangThai]) VALUES (N'HD6', 36, CAST(N'2021-06-17T13:44:50.000' AS DateTime), 0)
GO
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (1, N'type3', N'cus.huflit1@gmail.com', N'91ec1f9324753048c0096d036a694f86', N'Khách hàng 1', N'123 Trịnh Đình Thảo', N'0335000000', N'/img/Avatar/avt-default.png')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (2, N'type3', N'cus.huflit2@gmail.com', N'91ec1f9324753048c0096d036a694f86', N'Customer2', N'abc', N'123', N'/img/Avatar/avt-default.png')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (3, N'type3', N'fkelk2@wunderground.com', N'CNai5saz533', N'Freida Kelk', N'0 Warner Street', N'543-961-8733', N'https://robohash.org/optioautemiusto.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (4, N'type3', N'lmclaren3@e-recht24.de', N'NuxGHm7KI', N'Loella McLaren', N'7971 Jay Center', N'720-219-9148', N'https://robohash.org/nemovoluptasfacere.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (5, N'type3', N'eshilvock4@yelp.com', N'H9gZfH', N'Etty Shilvock', N'3 Michigan Point', N'377-465-7703', N'https://robohash.org/quasofficiisid.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (6, N'type3', N'fpaulich5@themeforest.net', N'3rZ2FMgSr4Ni', N'Fields Paulich', N'524 Grayhawk Lane', N'637-688-3910', N'https://robohash.org/invelat.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (7, N'type3', N'eberlin6@apple.com', N'tr77l3p24', N'Evania Berlin', N'640 Stephen Road', N'152-749-2776', N'https://robohash.org/etundemaiores.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (8, N'type3', N'wcathee7@aboutads.info', N'p4c6miy8', N'Wendie Cathee', N'53 Hintze Hill', N'957-568-0587', N'https://robohash.org/consequaturdeserunttempore.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (9, N'type3', N'hallston8@usnews.com', N'mVOFZ5Adib', N'Harlan Allston', N'49994 Annamark Point', N'868-108-4405', N'https://robohash.org/atquequasiet.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (10, N'type3', N'qstockbridge9@phoca.cz', N'zC7hrVXZGU', N'Quint Stockbridge', N'075 Springview Trail', N'615-404-9795', N'https://robohash.org/commodiofficiisnecessitatibus.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (11, N'type3', N'stownbya@vimeo.com', N'quNz0Ss0Rn4F', N'Sela Townby', N'5 Daystar Crossing', N'912-275-5773', N'https://robohash.org/voluptaseadolor.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (12, N'type3', N'adudingb@barnesandnoble.com', N'bShSHEVCjb', N'Ariel Duding', N'89544 Amoth Place', N'646-583-8527', N'https://robohash.org/quiaofficiaet.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (13, N'type3', N'cwhitcombc@vk.com', N'LW7YzxX06TFM', N'Candis Whitcomb', N'7217 Rowland Point', N'115-672-7198', N'https://robohash.org/essevoluptasvoluptas.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (14, N'type3', N'jdutchd@weather.com', N'wWTK2sXQkjd', N'Jim Dutch', N'842 Golf Way', N'551-232-9577', N'https://robohash.org/teneturexercitationemofficia.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (15, N'type3', N'mdonnersberge@businesswire.com', N'cr0O57B5imo', N'Mommy Donnersberg', N'26 East Trail', N'836-545-3334', N'https://robohash.org/harumhicvoluptatum.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (16, N'type3', N'msimmsf@goodreads.com', N'ZXFKWqiClmHO', N'Merola Simms', N'85377 Bay Junction', N'454-441-0859', N'https://robohash.org/officiasintiusto.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (17, N'type3', N'agrimsdykeg@bizjournals.com', N'ZbCNNAsx2541', N'Arv Grimsdyke', N'06857 Sullivan Alley', N'702-959-9845', N'https://robohash.org/maximeutomnis.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (18, N'type3', N'hseldonh@newyorker.com', N'sIykAyW', N'Hermine Seldon', N'1568 North Street', N'923-417-4214', N'https://robohash.org/numquamasperioresvoluptatem.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (19, N'type3', N'abirchneri@gov.uk', N'xEYsWmX', N'Alasdair Birchner', N'224 Bashford Hill', N'827-522-3523', N'https://robohash.org/illumaliquidprovident.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (20, N'type3', N'gklimekj@marriott.com', N'xM6IYpRlXxPS', N'Gasper Klimek', N'482 Bunker Hill Court', N'442-135-5850', N'https://robohash.org/adipiscinequeodit.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (21, N'type3', N'edunridgek@1688.com', N'ZkQcQKrA', N'Elysee Dunridge', N'6732 Cody Point', N'341-106-6320', N'https://robohash.org/officiaquibusdamet.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (22, N'type3', N'rbuttingl@purevolume.com', N'HSYjUzF', N'Rodge Butting', N'7 Mosinee Junction', N'245-141-8993', N'https://robohash.org/quoexporro.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (23, N'type3', N'ccorlettm@artisteer.com', N'YI50XE', N'Corrie Corlett', N'92574 Leroy Lane', N'748-339-3672', N'https://robohash.org/verononnulla.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (24, N'type3', N'lwallagen@oakley.com', N'ktqAUk1tM', N'Laurice Wallage', N'16674 Esch Point', N'379-989-6637', N'https://robohash.org/recusandaenihilquam.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (25, N'type3', N'emulvihillo@ustream.tv', N'ODNO4vR6f', N'Ellis Mulvihill', N'53534 Becker Drive', N'578-431-7842', N'https://robohash.org/sequiliberoullam.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (26, N'type3', N'khoffp@elpais.com', N'KlTESy', N'Kaylil Hoff', N'9851 Continental Plaza', N'251-656-7410', N'https://robohash.org/ipsametdistinctio.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (27, N'type3', N'crealphq@va.gov', N'OO3hAEZQ52', N'Casie Realph', N'09 Blackbird Plaza', N'680-371-0139', N'https://robohash.org/voluptasquiomnis.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (28, N'type3', N'lwathallr@blog.com', N'3ola6n', N'Linc Wathall', N'3849 Hanson Lane', N'822-648-5651', N'https://robohash.org/repellatametvoluptatem.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (29, N'type3', N'ekoberas@wufoo.com', N'ZSbHgakv', N'Emmanuel Kobera', N'8875 Welch Place', N'697-283-6551', N'https://robohash.org/easintest.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (30, N'type3', N'obeglint@google.cn', N'TOlOJ4bQg', N'Olivier Beglin', N'9 Becker Circle', N'557-855-8667', N'https://robohash.org/aperiamautsoluta.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (31, N'type3', N'hjanseyu@arstechnica.com', N'H3U4MdNf', N'Hughie Jansey', N'4029 Clarendon Street', N'311-866-6820', N'https://robohash.org/velvoluptatemsaepe.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (32, N'type3', N'zbingallv@amazon.co.jp', N'udDZIB34dh', N'Zia Bingall', N'94444 Spohn Crossing', N'856-299-3767', N'https://robohash.org/hicnecessitatibussit.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (33, N'type3', N'kcettellw@answers.com', N'ejWvgRkU', N'Kizzie Cettell', N'42322 Jenna Junction', N'277-118-7236', N'https://robohash.org/repellendusundeanimi.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (34, N'type3', N'bbrookerx@unicef.org', N'020F5JNiq', N'Bear Brooker', N'5 West Junction', N'156-625-7927', N'https://robohash.org/commodihicvel.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (35, N'type3', N'sbohlensy@seattletimes.com', N'2jw6eFw', N'Shel Bohlens', N'0475 Toban Trail', N'481-453-5346', N'https://robohash.org/porroquibusdamvoluptatem.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (36, N'type3', N'ngoctruc020100@gmail.com', N'3b3529cc6beb20d79d60f8180db71876', N'Ngọc Trúc', N'123 Trịnh Đình Thảo', N'0335000000', N'/img/Avatar/avt-kh1.jpg')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (37, N'type3', N'cus.huflit3@gmail.com', N'91ec1f9324753048c0096d036a694f86', N'Cập nhật tên', N'Hãy cập nhật địa chỉ của bạn', N'', N'/img/Avatar/avt-default.png')
GO
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM0', 0)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM10', 10)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM100', 100)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM15', 15)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM20', 20)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM25', 25)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM30', 30)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM35', 35)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM40', 40)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM45', 45)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM5', 5)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM50', 50)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM55', 55)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM60', 60)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM65', 65)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM70', 70)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM75', 75)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM80', 80)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM85', 85)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM90', 90)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM95', 95)
GO
INSERT [dbo].[LoaiXe] ([IDLoaiXe], [TenLoaiXe]) VALUES (N'CF', N'Cafe Racer')
INSERT [dbo].[LoaiXe] ([IDLoaiXe], [TenLoaiXe]) VALUES (N'CL', N'Classic')
INSERT [dbo].[LoaiXe] ([IDLoaiXe], [TenLoaiXe]) VALUES (N'HP', N'Hyper Naked')
INSERT [dbo].[LoaiXe] ([IDLoaiXe], [TenLoaiXe]) VALUES (N'NJ', N'NinJa')
INSERT [dbo].[LoaiXe] ([IDLoaiXe], [TenLoaiXe]) VALUES (N'NK', N'Naked')
INSERT [dbo].[LoaiXe] ([IDLoaiXe], [TenLoaiXe]) VALUES (N'SP', N'Sport')
INSERT [dbo].[LoaiXe] ([IDLoaiXe], [TenLoaiXe]) VALUES (N'SPCT', N'Sport City')
INSERT [dbo].[LoaiXe] ([IDLoaiXe], [TenLoaiXe]) VALUES (N'SPSP', N'Super Sport')
INSERT [dbo].[LoaiXe] ([IDLoaiXe], [TenLoaiXe]) VALUES (N'SPT', N'Sport Touring')
INSERT [dbo].[LoaiXe] ([IDLoaiXe], [TenLoaiXe]) VALUES (N'XSR', N'XSR')
INSERT [dbo].[LoaiXe] ([IDLoaiXe], [TenLoaiXe]) VALUES (N'Z', N'KawaZ')
GO
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'BMW1', N'KM5', N'BMW', N'SP', N'S1000RR', 949000000.0000, N'/img/Products/BMW-S1000RR-01.png', N'/img/Products/BMW-S1000RR-02.png', N'/img/Products/BMW-S1000RR-03.png', 12, N'BMW S1000RR 2018 là dòng xe được mệnh danh “cá mập” luôn được các biker săn đón. Với thiết kế tận dụng tối đa khí động học tăng khả năng vận hành, S1000RR mới có sức mạnh 202 mã lực tại vòng tua 13.500 rpm và có trọng lượng ướt (đã lắp bình, nhớt và xăng đầy bình) còn 204 kg. Động cơ mới với chi tiết pô, bình điện nhẹ hơn.', 0)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'BMW2', N'KM5', N'BMW', N'CF', N'R9T-RACER', 549000000.0000, N'/img/Products/BMW-R9T-RACER-01.png', N'/img/Products/BMW-R9T-RACER-02.png', N'/img/Products/BMW-R9T-RACER-03.png', 12, N'BMW R Nine T Classic: Đây là mẫu xe nguyên bản của RNineT Series, đại diện cho hình ảnh Heritage của BMW Motorrad. Mẫu xe BMW RNine T Classic mang nét thiết kế cổ điển nhưng mang trên mình những công nghệ hiện đại bao gồm: Phuộc trước Upside-Down lấy từ mẫu thể thao trứ danh BMW S 1000 RR, có để tinh chỉnh tùy ý; Hệ thống tự động cân bằng điện tử ASC; ống xả tiêu chuẩn EURO4.BMW R Nine T Series với 4 phiên bản, thuộc phân khúc Heritage mang phong cách cổ điển, lịch lãm nhưng vô cùng hiện đại với các công nghệ mới nhất của BMW Motorrad. Đặc biệt, R Nine T Series sở hữu dòng máy Boxer 1170cc trứ danh của BMW với khả năng vận hành ổn định, êm ái nhưng không kém phần mạnh mẽ.', 0)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'BMW3', N'KM5', N'BMW', N'SPT', N'R1200-GSA', 659000000.0000, N'/img/Products/BMW-R1200-GSA-01.png', N'/img/Products/BMW-R1200-GSA-02.png', N'/img/Products/BMW-R1200-GSA-03.png', 12, N'BMW R 1200 GS Adventure nổi trội với khả năng xử lý linh hoạt và nhạy bén. Với những tay lái ưa khám phá và chinh phục những địa hình khó, R1200 GSA là một lựa chọn khá tối ưu. Về thiết kế, BMW R1200 GSA 2018 vẫn giữ thiết kế đặc trưng của dòng Adventure với những đường nét mạnh mẽ, góc cạnh, đầy chất bụi bặm và lôi cuốn. Phần đầu xe được thiết kế dữ dằn, tạo điểm nhấn đặc trưng bởi thiết kế “mỏ chim ưng” nhô về phía trước, tích hợp chắn bùn. Một số tính năng thông minh được trang bị cho xe gồm có hỗ trợ lái chủ động, sưởi tay lái, kiểm soát hành trình, cảnh báo áp suất lốp, kiểm soát độ bám đường – DTC, hệ thống cân bằng điện tử - ASC, hệ thống tự điều chỉnh phuộc tùy thuộc vào địa hình – DDC, chìa khóa thông minh… Tại thị trường Việt Nam, BMW R1200 GSA 2018 được nhập khẩu nguyên chiếc từ Thái Lan và có giá bán chính thức là 659 triệu đồng. Đây sẽ là đối thủ đáng gờm của các mẫu Adventure như KTM 1290 Super Adventure hay Ducati Multistrada 1200 Enduro.', 0)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'BMW4', N'KM5', N'BMW', N'SP', N'BMW-HP4', 2800000000.0000, N'/img/Products/BMW-HP4-01.jpg', N'/img/Products/BMW-HP4-02.png', N'/img/Products/BMW-HP4-03.png', 2, N'Trước tiên, BMW HP4 là phiên bản nâng hiệu suất động cơ tối đa của “cá mập” S1000RR, mục đích của BMW Motorrad là “dằn mặt” các mẫu xe đang thi đấu trong những giải đua mô tô MotoGP và WSBK.  HP4 được BMW nhận định là “chiến binh đường đua” nên số lượng sản xuất rất ít. Đây là lý do khiến mẫu xe này được nhiều anh em chơi mô tô săn lùng trên toàn thế giới. Điểm dễ phân biệt nhất của S1000RR và HP4 là… bộ tem. Trên BMW HP4 sẽ có dòng chữ “HP4”, chảng 3 cũng có khắc “HP4” và số series thứ tự của xe.  So sánh giữa “cá mập thường” và “cá mập chiến”, công suất, công nghệ của HP4 “ăn đứt” S1000RR. Ở thế hệ đầu tiên, động cơ của HP4 có dung tích tương đương S1000RR nhưng công suất lên đến 193 mã lực, tốc độ tối đa hơn 300 km/h. Điểm đặc biệt của HP4 là được trang bị hệ thống DDC (bộ điều khiển giảm xóc điện tử).', 0)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'DCT1', N'KM10', N'DCT', N'SPCT', N'SUPER-SPORT', 513900000.0000, N'/img/Products/DUCATI-SUPER-SPORT-01.png', N'/img/Products/DUCATI-SUPER-SPORT-02.png', N'/img/Products/DUCATI-SUPER-SPORT-03.png', 12, N'Ducati SuperSport lần đầu tiên trình làng trong triển lãm Intermot 2016 diễn ra tại thành phố Cologne, Đức. Ducati SuperSport hướng tới những khách hàng muốn một chiếc sportbike có tư thế ngồi thoải mái và dễ điều khiển. Tại thị trường Thái Lan, Ducati SuperSport 2017 có 3 phiên bản là tiêu chuẩn, S màu đỏ và S màu trắng. Giá bán tương ứng của 3 phiên bản này là 599.000 Baht (382 triệu đồng), 699.000 Baht (477,6 triệu đồng) và 709.000 Baht (484 triệu đồng). Ducati Supersport được đánh giá là mẫu xe mô tô đẹp nhất trong sự kiện sự kiện EICMA diễn ra hồi cuối năm ngoái, Ducati SuperSport là mẫu Sport-tuoring hoàn toàn mới với vẻ ngoài vô cùng ấn tượng mang ngôn ngữ thiết kế đặc trưng của dòng xe Superbike đến từ thương hiệu Ducati. Theo xác nhận của Ducati Việt Nam mới đây, Ducati SuperSport sẽ chính thức ra mắt tại thị trường Việt Nam vào ngày 7/10 sắp tới trong sự chờ đợi mòn mỏi của các tín đồ PKL nói chung cũng như các Fan của nhà Ducati nói riêng.', 0)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'DCT2', N'KM10', N'DCT', N'NK', N'MONSTER-1200S', 877000000.0000, N'/img/Products/DUCATI-MONSTER-1200S-01.png', N'/img/Products/DUCATI-MONSTER-1200S-02.png', N'/img/Products/DUCATI-MONSTER-1200S-03.png', 12, N'Ducati Monster 1200 S và 1200 đều dùng loại khung ống nhôm Trellis, có thêm phần cố định 2 xi-lanh của động cơ mà khi trước đó không có. Xe có chiều dài cơ sở 1511mm, chiều cao yên 810mm trong khi Monster 795 và 796 có trục cơ sở chỉ dài 1450mm, chiều cao yên 800mm. Chính việc kéo dài và nâng cao khung sườn giúp Monster 1200 S có kích thước lớn, hầm hố, kết hợp với bình xăng lớn 17,5 lít (795 chỉ 15 lít) tạo dáng oai vệ và vạm vỡ hơn trước. Điểm khác nhau rõ rệt nhất giữa thế hệ thứ 3 Monster 1200 S và thế hệ thứ 2 Monster 795 chính là hệ thống ống xả. Ở 795 và 796, hai pô xe được đặt nằm cặp hai bên dưới yên xe trong khi đó Monster 1200 S có hai pô xe nằm về một phía. Điểm khác nữa của 1200 S chính là cặp phuộc trước dùng loại Ohlins có hành trình dài 48mm trong khi các mẫu xe còn lại chỉ dài 43mm. Giống như các mẫu xe khác trong nhà Monster, chiếc 1200 S cũng dùng phuộc sau dạng đơn monoshock nhưng được ưu tiên trang bị của hãng Ohlins. Xe cũng chỉ có một càng giống như các mẫu khác.', 0)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'DCT3', N'KM10', N'DCT', N'NK', N'MULTISTRADA-1260S', 580000000.0000, N'/img/Products/DUCATI-MULTISTRADA-1260S-01.png', N'/img/Products/DUCATI-MULTISTRADA-1260S-02.png', N'/img/Products/DUCATI-MULTISTRADA-1260S-03.png', 12, N'Hiện tại, Ducati đã nhận được chứng nhận CARB cho cả ba phiên bản của Ducati Multistrada 1260 2018, bao gồm: Multistrada bản thường, Multistrada S và đắt tiền nhất Pikes Peak, đồng thời Multistrada 1260 không được cung cấp phiên bản Enduro. Trong hình ảnh có được ở bài viết này là Multistrada 1260 S. Trên các phiên bản thường và S, điểm khác biệt duy nhất của xe là bộ mâm 5 cánh kép thiết kế mới. Ở phiên bản 2018 chiều cao yên được nâng cấp từ 825 đến 845 mm. Đuôi xe thiết kế hiện đại với đèn hậu LED, pát biển số và đèn tín hiệu rời. Tất cả các phiên bản đều sử dụng vành mâm đúc (trừ phiên bản Enduro) 17 inch với lốp Pirelli Scorpion Trail cỡ 120/70/17 trước và 190/55/17 sau. Tương tự như trước đây, phiên bản S và Pikes Peak sẽ sử dụng phanh Brembo M50 cao cấp, trong khi Multistrada 1260 bản thường chỉ sử dụng phanh Brembo 4 piston thường và trang bị hệ thống treo trước KYB, hệ thống treo bán tự động Ducati Skyhook Suspension (DSS) dành cho bản S, phiên bản Pikes Peak được trang bị cặp phuộc Ohlins 48 mm/TTX36.', 0)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'HD1', N'KM0', N'HD', N'SPSP', N'CBR-1000RR', 560000000.0000, N'/img/Products/HONDA-CBR-1000RR-01.png', N'/img/Products/HONDA-CBR-1000RR-02.png', N'/img/Products/HONDA-CBR-1000RR-03.png', 12, N'Honda CBR1000RR được coi như một trong những phiên bản mạnh nhất. Max ping, max option của dòng xe Honda CBR tại Việt Nam và trên thế giới. Và Honda CBR1000 giá bao nhiêu sẽ là điều mà anh em tìm kiếm được trong bài viết này. Cũng như chi tiết cấu hình hai phiên bản Honda CBR 1000 FIREBLADE/FIREBLADE SP đang được phân phối tại Honda Big Bike Việt Nam. Được coi là phiên bản giá mềm của Honda CBR1000RR tại Việt Nam. Cấu hình động cơ mà phiên bản CBR1000RR FIREBLADE vẫn là động cơ 999,8 cc. Cấu hình 4 xi lanh, DOHC, làm mát bằng dung dịch. Sản sinh công suất tối đa lên đến 189 mã lực tại vòng tua 13.000 vòng/phút. Sức mạnh này được coi như một sự thừa thãi khi anh em chạy xe cẩn thận tại Việt Nam. Với mức độ vận hành trung bình 70 tới 80 km/h nó nhanh chóng giúp anh em đạt được những gì mình mong muốn. Cũng như muốn thử thách tay lái của mình hơn một chút. Thì hơi khó để anh em khai thác hết sức mạnh này khi mua Honda CBR1000RR FIREBLADE tại Việt Nam. Còn về kích thước, xe mang thông số các chiều D x R x C lần lượt 2,065 mm x 720 mm x 1125 mm. Cùng mức chiều cao yên 832 mm, giúp cho chúng ta có một mẫu PKL. Với kích thước lớn, nhưng vẫn mang một form đáng vô cùng gọn gàng và hợp lý. Trong khi đó, hệ thống treo sau sử dụng phuộc Monoshock Pro-Link 10 nấc cân bằng Balance Free Rear (BFR), hành trình nhún 138.2 mm. Kèm theo đó là lốp sau thông số lớn hơn 190/50 ZR17.', 0)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'HD2', N'KM0', N'HD', N'SP', N'CB1000R', 468000000.0000, N'/img/Products/HONDA-CB1000R-01.png', N'/img/Products/HONDA-CB1000R-02.png', N'/img/Products/HONDA-CB1000R-03.png', 12, N'Tuy không phải chiếc naked bike duy nhất Honda phân phối tại Việt Nam nhưng Honda CB1000R lại rất khác biệt và gây ấn tượng mạnh mẽ với khách hàng nhờ phong cách thiết kế tân hoài cổ ở phân khúc xe cao cấp. Honda CB1000R 2021 là một sản phẩm gây nhiều sự ngạc nhiên của hãng xe mô tô Nhật Bản dành cho các biker, chiếc naked bike này bước ra từ sản phẩm "tương lai" Neo Sports Café được Honda trình làng tại triển lãm Tokyo 2017. Hiện tại, mẫu xe này đang được bán chính hãng tại Việt Nam với mức giá 468 triệu đồng. Honda CB1000R mang trên mình khối động cơ DOHC dung tích 998cc, 4 xi-lanh, CB1000R phiên bản 2021 sản sinh ra công suất 143 mã lực ở 10.500 vòng/phút và mô men xoắn 104Nm ở 8.250 vòng/phút. Sức mạnh động cơ của CB1000R 2021 tăng lên 16% so với chiếc CB1000R đời cũ cụ thể là123 mã lực tại 10.000 vòng/phút và 99Nm tại 7.750 vòng/phút. CB1000R có kích thước dài x rộng x cao lần lượt là 2.120mm x 789mm x 1.090mm và độ cao yên là 830mm, phù hợp với người có vóc dáng cao. CB1000R có 3 màu: đen bạc, đỏ đen bạc và đen.', 0)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'HD3', N'KM0', N'HD', N'CL', N'REBEL-500', 180000000.0000, N'/img/Products/HONDA-REBEL-500-01.png', N'/img/Products/HONDA-REBEL-500-02.png', N'/img/Products/HONDA-REBEL-500-03.png', 12, N'Sau khi khai trương showroom xe mô tô phân khối lớn thứ hai, Honda Việt Nam cũng đồng thời chính thức bán ra mẫu xe Rebel 500 mới với mức giá 180 triệu VNĐ. Đến thời điểm hiện tại, Honda Rebel 500 vẫn được giữ nguyên giá bán là 180 triệu VNĐ. Honda Rebel 500 2021 sử dụng khung xe dạng ống thép có thiết kể để có thể vừa treo vừa đỡ động cơ. Cũng nhờ trang bị động cơ 500cc có kích thước lớn mà khi nhìn ngang, ngoại hình của Honda Rebel 500 rất kín kẽ, không bị trống trải như Honda Rebel 300. Rebel 500 được trang bị khối động cơ 2 xy lanh song song có dung tích xi lanh 471cc, làm mát bằng dung dịch, khối hệ thống phun xăng điện tử PGM-FI. Động cơ sản sinh công suất tối đa 34 kW tại tua máy 8.500 vòng/phút và đạt mô men xoắn cực đại 43.2 Nm tại tua máy 6.500 vòng/phút. Xe Honda Rebel 500 có kích thước dài x rộng x cao lần lượt là 2.190mm x 820mm x 1.090mm, độ cao yên 690mm. Xe Rebel 500 đang được bán với 3 màu: Đen/ Bạc/ Đỏ Động cơ xylanh đôi, dung tích 471cc, sở hữu công suất 45,4 mã lực tại tua máy 8.500 vòng/phút và mômen xoắn cực đại 44,6 Nm tại tua máy 6.000 vòng/phút. Khác với Honda Rebel 300 chỉ được bán tại các HEAD, giá xe Honda Rebel 500 2021 tại Showroom Honda Motor hiện đang ở mức 180 triệu VNĐ.', 0)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'KTM1', N'KM0', N'KTM', N'NK', N'SUPER-DUKE', 750000000.0000, N'/img/Products/KTM-SUPER-DUKE-01.png', N'/img/Products/KTM-SUPER-DUKE-02.png', N'/img/Products/KTM-SUPER-DUKE-03.png', 12, N'Ra mắt tại triển lãm EICMA 2019, KTM 1290 Super Duke R 2020 là phiên bản nâng cấp của thế hệ ra mắt từ năm 2017. Mẫu nakedbike này vừa được đại lý KTM Sapa mang về Việt Nam với mức giá 750 triệu đồng. Ở phía trước, KTM 1290 Super Duke R vẫn sử dụng thiết kế đèn chia 2 mảnh sắc nhọn của đời trước. Từ đời 2017, kiểu đèn này đã được áp dụng cho những mẫu xe đàn em của 1290 Super Duke R như 790 Duke, 390 Duke hay 250 Duke. Bên cạnh thiết kế độc đáo, khe giữa cụm đèn còn có tác dụng khí động học, giúp tối ưu luồng gió cho hệ thống làm mát động cơ. Bảng đồng hồ TFT kích thước 5 inch được cải thiện so với đời cũ. Với cấu trúc menu mới, đồng hồ cho phép người lái truy cập thông tin nhanh hơn. Một lớp kính chống trầy xước được phủ lên bề mặt đồng hồ, giúp tăng tuổi thọ cho bộ phận này. Trên phiên bản 2020, KTM 1290 Super Duke R được trang bị bộ khung mới, cứng hơn gấp 3 lần so với khung xe trên phiên bản cũ. KTM cho biết khung thép mới có đường kính to hơn nhưng thành lại mỏng hơn. Do đó, độ cứng được cải thiện nhưng khối lượng lại giảm đi. Nhờ vậy, bộ khung mới nhẹ hơn 2 kg so với khung cũ. Nhờ sử dụng các vật liệu nhẹ, khối lượng của 1290 Super Duke R 2020 giảm 6 kg so với đời cũ, xuống còn 189 kg. Chiều cao yên vẫn ở mức 835 mm và khoảng sáng gầm 160 mm. Bình xăng của phiên bản 2020 được làm gọn hơn, dung tích được giảm từ 18 lít xuống còn 16 lít. Xe được trang bị bộ mâm 17 inch 5 chấu bằng hợp kim nhẹ, bọc trong bộ lốp Bridgestone S22. Bộ lốp này được Bridgestone làm riêng cho 1290 Super Duke R, phù hợp cho cả đi phố, đường ướt và đường đua.', 0)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'KTM2', N'KM0', N'KTM', N'SPT', N'SUPER-ADVENTURE', 690000000.0000, N'/img/Products/KTM-SUPER-ADVENTURE-01.png', N'/img/Products/KTM-SUPER-ADVENTURE-02.png', N'/img/Products/KTM-SUPER-ADVENTURE-03.png', 12, N'Được thiết kế dựa trên chiếc nakedbike hầm hố KTM 1290 Super Duke R, KTM 1290 Super Adventure R đang được cho là chiếc xe touring mạnh mẽ nhất hiện nay và chưa có đối thủ trên thị trường. Việc ra mắt dòng xe touring mạnh mẽ của KTM đã nhận được đánh giá rất cao từ người hâm mộ và các chuyên gia. Một số công nghệ mới giống như các mẫu BMW cũng xuất hiện trên chiếc KTM 1290 Super Adventure R: đèn LED trợ sáng khi vào cua và hệ thống kiểm soát xe khi dừng ở dốc…. Bên cạnh đó, còn có các trang bị tiêu chuẩn trên xe gồm có bình xăng dung tích 30L, kính chắn gió lớn có khả năng tùy chỉnh độ cao, gác chân, tay lái và yên xe đều có thể điều chỉnh vị trí. Xe được trang bị động cơ KTM LC8 V-Twin đạt tiêu chuẩn Euro 5, cho ra công suất 160 mã lực tại 9.000 vòng/phút và mô-men xoắn 138Nm tại 6.500 vòng/phút. Khối động cơ mới cũng đã nhẹ hơn 1,6kg so với thế hệ trước. Chiều cao yên của xe là 860mm, với dung tích xy-lanh là 1301cc Ngoài ra, theo tiết lộ để phù hợp hơn với dòng xe đường trường, tân binh mới 1290 Super Adventure R sẽ được KTM hiệu chỉnh lại khối động cơ kế thừa từ người anh em 1290 Super Duke R, cụ thể là khối động cơ V-Twin dung tích 1.301 cc, góc nghiêng 75°, tuy nhiên với hiệu chỉnh từ KTM bao gồm các thay đổi như nắp máy mới (qui lát), trục cam và trục khuỷu được thay đổi… đặc biệt hiệu suất hoạt động cũng được giảm xuống, theo đó khối động cơ này sẽ sản sinh công suất tối đa 160 mã lực và mô-men xoắn cực đại 150 Nm. Xe đang được bán thông qua hệ thống cửa hàng bán xe và dịch vụ sửa chữa do KTM Ủy nhiệm tại Việt Nam với chế độ bảo hành chính hãng KTM.', 0)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'KTM3', N'KM0', N'KTM', N'SP', N'RC8-R', 590000000.0000, N'/img/Products/KTM-RC8-R-01.png', N'/img/Products/KTM-RC8-R-02.png', N'/img/Products/KTM-RC8-R-03.png', 12, N'KTM 1190 RC8R là mẫu superbike với động cơ thừa hưởng công nghệ từ xe đua khiến người lái luôn có cảm giác cầm cương một chiến mã thật thụ trên đường đua. RC8 xuất hiện lần đầu 2008 với phiên bản động cơ V-Twin dung tích 1.140 phân khối. Sau đó một năm, phiên bản racing KTM 1190 RC8R với động cơ 1.195 phân khối được giới thiệu. Động cơ 173 mã lực và giảm sóc làm việc hiệu quả là hai yếu tố lôi cuốn. Trong phố hiếm khi chuyển qua tới số 4, nhưng KTM 1190 RC8R hoạt động ổn định. Với chế độ chạy Road, KTM 1190 RC8R không rung giật tại số 2 và dưới 30km/h. Nếu từng cầm lái một chiếc superbike Nhật Bản, sự khác biệt hiện rõ khi ngồi lên RC8R, nhẹ nhàng và dễ điều khiển. KTM 1190 RC8R chỉ có trọng lượng 184 kg, chiều cao yên 805mm giúp cho người cao 1,7 m đã dễ điều khiển. Tay lái cao, yên gắn lên khung bằng bộ khung phụ nhôm. Yên phụ sau cao hơn hẳn so với người lái.', 0)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'KW1', N'KM0', N'KW', N'SPSP', N'H2-SX', 899000000.0000, N'/img/Products/KAWASAKI-H2-SX-01.png', N'/img/Products/KAWASAKI-H2-SX-02.png', N'/img/Products/KAWASAKI-H2-SX-03.png', 12, N'Mẩu xe môtô Kawasaki H2 SX 2021 với phong cách Sport Touring cùng với phiên bản xe H2 SX SE (Special Edition) được coi là phiên bản thế hệ mới nhất dựa trên nguyên bản người đàn anh Kawasaki H2 tiền nhiệm kể từ khi xuất hiện lần đầu EICMA 2014 cho đến nay. Xe môtô H2 SX 2021 của hãng Kawasaki hướng tới các khách hàng thích chinh phục những chuyến hành trình dài với phong cách thiết kế ghi đông cao, dàn để chân thấp, trang bị những công nghệ hiện đại nhất đi cùng khối động cơ siêu nạp (Super Charge) giúp mang lại hiệu suất cao nhất cho người dùng. Ở phiên bản Sport Touring này, Kawasaki H2 SX SE 2021 mới nhất vẫn sử dụng khối động cơ siêu nạp (Super Charge) tương tự như H2 nhưng đã được tinh chỉnh toàn diện nhằm phù hợp hơn cho người dùng. Cụ thể H2 SX SE mới sử dụng động cơ DOHC 4 xy-lanh, 16 van và dung tích 998 phân khối cho công suất tối đa 147 kW tại vòng tua máy 11.000 v/ph và mô-men xoắn cực đại 137 Nm từ 11.000 v/ph. Đi kèm hộp số 6 cấp, tính năng hỗ trợ sang số nhanh Quick-Shift trên bản H2 SX 2021 không được trang bị. Động cơ đạt tiêu chuẩn khí thải Euro 4. Mẫu xe phân khối lớn H2 SX SE được xem là mẫu xe cao cấp nhất của hãng Kawasaki với kiểu dáng thiết kế góc cạnh cực hầm hố cũng như được tích hợp công nghệ hiện đại. Kawasaki H2 SX SE đời 2021 có kích thước Dài x Rộng x Cao lần lượt là 2.135 x 775 x 1.260 mm, chiều dài cơ sở 1.480 mm, chiều cao yên 835 mm, khoảng sáng gầm xe 130 mm, trọng lượng xe ở mức 260 kg và đây là một đối thủ mới của các đồi thủ trong cùng phân khúc Touring như BMW K1600 GTL, hay Ducati Multistrada 1200 S , …', 0)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'KW2', N'KM0', N'KW', N'SPT', N'VERSYS-1000', 420000000.0000, N'/img/Products/KAWASAKI-VERSYS-1000-01.png', N'/img/Products/KAWASAKI-VERSYS-1000-02.png', N'/img/Products/KAWASAKI-VERSYS-1000-03.png', 12, N'Kawasaki Versys 1000 ABS có thể được xem là mẫu adventure touring cao cấp nhất của thương hiệu xe Nhật Bản. Bên cạnh phiên bản tiêu chuẩn, Versys 1000 còn có thêm phiên bản Kawasaki Versys 1000LT, đậm chất adventure với các trang bị bổ sung như thùng chứa đồ ở đuôi xe và đèn trợ sáng. Hiện tại, Kawasaki đã chính thức phân phối mẫu Kawasaki Versys 1000 2021 tại thị trường Việt Nam với giá 419 triệu đồng, sở hữu 2 màu sơn bao gồm bạc và đen. Thiết kế Kawasaki Versys 1000 Được định vị là xe adventure-touring nên Kawasaki Versys 1000 có thiết kế khá đồ sộ với kích thước tổng thể 2.240mm dài, 895mm rộng và 1.400mm cao. Tuy nhiên chiều cao yên xe lại ở mức rất hợp lý là 840mm. Về mặt trang bị, Kawasaki Versys 1000 mới có hệ thống treo gồm cặp phuộc ống lồng kích thước 43mm với kích thước 150mm và giảm xóc lò xo trụ đơn, giảm chấn thủy lực được bố trí lệch tâm với hành trình 150mm. Trang bị này giúp xe có khả năng vượt địa hình tốt, không gây sự khó chịu cho lái xe trên những hành trình dài. Động cơ Versys 1000 mới nhất 2021 là loại xylanh đôi, DOHC, dung tích 1.043cc, làm mát bằng dung dịch, sản sinh công suất 109 mã lực tại 8.000 vòng/phút và mômen xoắn cực đại 94,6Nm tại tua máy 7.080 vòng/phút. Kể từ khi ra mắt thị trường Việt Nam, giá xe Kawasaki Versys 1000 vẫn không có gì thay đổi. Hiện tại xe đang được phân phối chính hãng với giá 419 triệu đồng. Đối thủ của Versys 1000 hiện tại tại Việt Nam bao gồm mẫu Suzuki V-Strom 1000, Ducati Multistrada 1200 và BMW R1200GS.', 0)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'KW3', N'KM0', N'KW', N'NK', N'Z-1000R', 459000000.0000, N'/img/Products/KAWASAKI-Z-1000R-01.png', N'/img/Products/KAWASAKI-Z-1000R-02.jpg', N'/img/Products/KAWASAKI-Z-1000R-03.png', 12, N'Kawasaki Z1000R ABS 2021 là phiên bản đặc biệt mới nhất vừa được hãng Kawasaki công bố và giá chính thức được bán ở Việt Nam có giá 459.000.000 đồng (đã bao gồm VAT, chưa có phí trước bạ và biển số) với thiết kế không thay đổi nhiều so với thế hệ trước đó. Cụm đèn pha full LED vẫn giữ phong cách thiết kế Sugomi dữ dằn của hãng xe máy Kawasaki. Phiên bản đặc biệt Z1000R mới 2021 được tuỳ chọn sơn khói cụm đèn trông ngầu hơn. Về kích thước, Z1000R 2021 không thay đổi so với thế hệ trước chiều dài 2.045 mm, chiều rộng 790 mm, chiều cao 1.055 mm, chiều cao yên 815 mm và trọng lượng không tải 221 kg. Z1000R ABS 2021 vẫn sở hữu nhiều tính năng an toàn tiên tiến, nổi bật như hệ thống chống bó cứng phanh ABS trên cả hai bánh, phanh đĩa đôi, đường kính 310 mm phía trước. "Trái tim" của Kawasaki Z1000R 2021 vẫn là khối động cơ 4 xi-lanh, dung tích 1.043cc, sản sinh công suất tối đa 142 mã lực tại 10.000 vòng/phút và mô-men xoắn cực đại 111 Nm tại 7.300 vòng/phút. Xe sở hữu trọng lượng không tải 221 kg. Ngoài ra, hãng Kawasaki còn hiệu chỉnh hệ thống điều khiển động cơ giúp Z1000R 2021 mới tăng tốc nhanh và đạt tốc độ cao hơn. Bình xăng dung tích 17 lít. So với thế hệ đầu, Z1000R 2021 đã tăng thêm 2 lít dung tích để phục vụ những biker thích đi đường trường. Phiên bản đặc biệt Z1000R ABS 2021 dùng kẹp phanh Brembo phía trước với rãnh tản nhiệt phân ly. Đĩa bằng thép không gỉ thay cho kiểu răng cưa. Phiên bản thường chỉ dùng kẹp phanh Kawasaki. Cả hai đều trang bị chống bó cứng thắng ABS cả trước và sau. Kawasaki Z1000R ABS 2021 đang được bán thông qua hệ thống cửa hàng bán xe và dịch vụ sửa chữa do Kawasaki ủy nhiệm tại Việt Nam trên toàn quốc với chế độ bảo hành 2 năm không giới hạn số km.', 0)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'SZ1', N'KM0', N'SZ', N'NK', N'GSX-S1000', 402000000.0000, N'/img/Products/SUZUKI-GSX-S1000-01.png', N'/img/Products/SUZUKI-GSX-S1000-02.png', N'/img/Products/SUZUKI-GSX-S1000-03.png', 12, N'GSX-S1000 được thiết kế như một chiếc xe với hình ảnh hoang dã, mạnh mẽ nhưng vẫn rất năng động, mượt mà, đáp ứng tốt tiêu chí thoải mái cho người lái. Cặp đèn định vị được thiết kế giống như cặp răng nanh của một mãnh thú. Hệ thống ống xả được thiết kế khác biệt mang lại cái nhìn thông thoáng ở khu vực bánh sau, đặc biệt là âm thanh phát ra từ ống xả đem đến một cảm giác rất phấn khích. Các thông số chủ yếu của Suzuki GSX-S1000 2021 cụ thể như sau: chiều dài x rộng x cao lần lượt là 2.115 x 795 x 1.080 mm, khoảng sáng gầm 140 mm, chiều cao yên 810 mm, trọng lượng 210kg và bình xăng dung tích 17 lít. Thiết kế phần đầu xe Suzuki GSX-S1000 tương đối đơn giản với cụm đèn pha lớn, lấy cảm hứng từ đèn pha của mẫu Suzuki B-King. Ngay ở hai góc dưới đèn pha là hai đèn định vị LED. Tuy nhiên, đuôi xe thon gọn, không thực sự ăn nhập với tổng thể xe. Đèn hậu LED có thiết kế đơn giản, xi nhan sau tích hợp với pát biển số. Mặt đồng hồ của Suzuki GSX-S1000 là màn hình LCD, hiển thị nhiều thông tin như vận tốc, thời gian, hành trình, lượng xăng, vòng tua máy, cấp số và nhiều thông số khác của xe. Tay lái của xe là loại Renthal Fat Bar cứng cáp và có trọng lượng nhẹ. Suzuki GSX S1000 được trang bị động cơ 4 xy-lanh, DOHC, dung tích 999cc, làm mát bằng dung dịch, sản sinh công suất cực đại 146 mã lực tại tua máy 10.000 vòng/phút, momen xoắn cực đại 106 Nm tại tua máy 9.500 vòng/phút, sử dụng hộp số 6 cấp, cùng với đó là hệ thống kiểm soát lực kéo chống trượt, cùng 3 chế độ vận hành khác nhau.', 0)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'SZ2', N'KM0', N'SZ', N'SP', N'GSX-R1000', 436000000.0000, N'/img/Products/SUZUKI-GSX-R1000-01.png', N'/img/Products/SUZUKI-GSX-R1000-02.png', N'/img/Products/SUZUKI-GSX-R1000-03.png', 12, N'Siêu mô tô thể thao Suzuki GSX-R1000 2020 đã chính thức có mặt tại Việt Nam. Lô hàng mới nhất của Suzuki do cửa hàng tư nhân nhập về với ba phiên bản màu Đỏ – Đen – Xanh GP đặc trưng của đội đua Suzuki. Đây là mẫu SuperBike mới nhất, đáng chú ý nhất trong làng xe phân khối lớn hiện nay với công suất 202 mã lực nhờ ứng dụng công nghệ xe đua, GSX-R1000 trở thành siêu môtô thương mại mạnh nhất mà Suzuki từng chế tạo. Trong phân khúc xe đường phố được chuyển sang mẫu xe đua, GSX-R chính là mẫu siêu xe đua đầu tiên có hiệu quả và có thể chạy cả ở đường phố, chiến thắng không biết bao nhiêu danh hiệu trên thế giới và sánh ngang với một loạt huyền thoại khác, kể cả là những mẫu xe có cùng lò của Suzuki và các đối thủ khác. “Trái tim” của Suzuki GSX-R1000 2020 là khối động cơ 4 xy-lanh thẳng hàng, dung tích 999,8 cc, sản sinh công suất tối đa 202 mã lực tại vòng tua máy 13.200 vòng/phút và mô-men xoắn cực đại 117,6 Nm tại vòng tua máy 10.800 vòng/phút. Chiều cao yên của xe là 825mm, dung tích xi lanh là 999.8cc, với bình xăng hơn 17.5L giúp cho các biker an tâm hơn về những chuyến đi đường dài của mình.', 0)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'SZ3', N'KM0', N'SZ', N'SPT', N'V-STROM1000', 369000000.0000, N'/img/Products/SUZUKI-V-STROM1000-01.png', N'/img/Products/SUZUKI-V-STROM1000-02.png', N'/img/Products/SUZUKI-V-STROM1000-03.png', 12, N'Suzuki V-strom 1000 là một trong những mẫu xe cực kỳ phù hợp để bạn có thể gác lại những ngày làm việc vất vả để có thể tự do, thoải mái và phấn kích trên mọi cung đường. Đây cũng là một trong những mục đích mà nhà sản xuất xe Suzuki tạo ra V-strom 1000 để thỏa mãn nhu cầu du lịch của khách hàng. Suzuki V-strom 1000 sở hữu khối động cơ V-TWin 1073 phân khối đầy sức mạnh, thể thao đem tới trải nghiệm lái với những cảm xúc tuyệt vời. Suzuki V-Strom 1000 2021 sử dụng khối động cơ V-Twin DOHC làm mát bằng dung dịch, cho ra 1037cc với công suất tối đa lên đến 90 mã lực tại vòng tua 8.000 V/ph và mô men xoắn cực đại 103 Nm, kết hợp hộp số 6 cấp cho khả năng ra vào số nhịp nhàng cũng như bứt tốc thoải mái. Chiều cao yên xe ở mức 848mm, không quá cao, cũng không quá thấp, khá thoải mái với những người có thể hình vừa phải, không quá nhỏ bé. Bảng đồng hồ của xe mang thiết kế kết hợp truyền thống và hiện đại, gồm đồng hồ analog hiển thị vòng tua và màn hình LCD hiển thị thời gian, hành trình, vận tốc, cấp số và một vài thông số khác. Ngay trên bảng đồng hồ là cổng sạc 12V, cung cấp nguồn sạc cho các thiết bị như GPS hay điện thoại di động. Ngoài ra, Suzuki còn trang bị cho V-Strom 1000 cặp thùng chứa đồ phía sau đậm chất adventure-touring và giá nhôm cho phép người dùng chằng, buộc đồ hoặc lắp thêm thùng đồ thứ ba nếu cần.', 0)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'YM1', N'KM0', N'YM', N'NK', N'MT-10', 557000000.0000, N'/img/Products/YAMAHA-MT-10-01.png', N'/img/Products/YAMAHA-MT-10-02.png', N'/img/Products/YAMAHA-MT-10-03.png', 12, N'Trong lần tổ chức chạy thử mô tô của do Yamaha Việt Nam tổ chức, MT-10 bên cạnh R1, R6 và MT-09 chính là những mẫu xe được chú ý nhất và cũng được Yamaha hé lộ có thể nhập khẩu và phân phối chính hãng tại thị trường Việt Nam. Mức giá bán Yamaha MT-10 2020 hiện nay tại các đại lý nhập khẩu là khoảng 500 triệu hoặc hơn. Theo trang thông tin chính thức của Yamaha Motorcycles, mức giá bán đề xuất của MT-10 phiên bản 2020 là $12,999 với 2 phiên bản màu sắc (xem ảnh chi tiết bên dưới). Yamaha MT-10 2020 sở hữu hàng loạt những công nghệ hỗ trợ hàng đầu bao gồm: ABS, Traction Control, Cruise Control, D-Mode, Assist & Slipper Clutch, Ride-by-Wire. Hệ thống phanh mạnh mẽ và an toàn đi kèm với công nghệ chống bó cứng phanh ABS hiệu năng cao. Phanh trước đĩa đôi 320 mm, đi kèm với cùm phanh 4 pít-tông kết hợp phanh sau đĩa đơn 220 mm cho lực phanh mạnh mẽ. MT-10 được trang bị khối động cơ dung tích 998cc, 4 xy-lanh thẳng hàng sử dụng công nghệ Crossplane Crankshaft tương tự trên mẫu Sportbike YZF-R1. Công nghệ Crossplane giúp giảm thiểu thất thoát công suất của động cơ, giúp truyền sức mạnh trực tiếp từ tay ga đến bánh sau. Tư thế ngồi lái thẳng đứng đặc trưng của những mẫu Hyper-Naked của gia đình MT-series nhờ vào ghi đông đặt cao được làm bằng nhôm, yên lái thoải mái và gác chân được đặt cao. Tất cả hệ thống chiếu sáng trên MT-10 đều sử dụng công nghệ đèn LED. Người lái có thể dễ dàng trang bị thêm những phụ kiện chính hãng như kính chắn gió, bảo vệ khung sườn và những trang bị tiện ích khác. Chiều cao yên của xe là 852mm, không quá cao cũng không quá thấp, giúp biker có tư thế ngồi thoải mái nhất có thể. ', 0)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'YM2', N'KM0', N'YM', N'CL', N'XSR900', 320000000.0000, N'/img/Products/YAMAHA-XSR900-01.png', N'/img/Products/YAMAHA-XSR900-02.png', N'/img/Products/YAMAHA-XSR900-03.png', 12, N'Vào những ngày đầu tháng 12 vừa qua, mẫu xe XSR900 mới 2021 đã được Yamaha chính thức phân phối chính hãng tại thị trường Việt Nam chung với người anh em Nakedbike MT-09 2021 đình đám. Yamaha XSR900 mới nằm trong phân khúc 900cc mang đậm phong cách Neo Retro (cổ điển pha lẫn hiện đại) được coi là lựa chọn lý tưởng cho các tín đồ đam mê thời trang, thích phong cách hoài cổ. Tại thị trường Việt Nam, giá xe XSR900 2021 tại Việt Nam mới nhất hiện nay hiện đang được Yamaha bán chính hãng với mức giá 320.000.000 VNĐ (Đã bao gồm VAT, chưa phí trước bạ và biển số) gồm 2 màu Xám nhám ánh kim và Đen ánh kim. Có thể nói Yamaha XSR900 được bán chính hãng là phiên bản mới nhất trong năm 2021 với những thay đổi về màu sơn, tem xe cũng mức giá tốt đi kèm chế độ bảo hành chính hãng, đồ chơi, phụ kiện, phụ tùng sẵn có sẽ giúp người tiêu dùng có thêm nhiều lựa chọn. Động cơ Yamaha XSR900 2021 – Mạnh mẽ bức phá: Dựa trên khẩu hiệu “Master of Torque” mẫu xe phân khối lớn XSR900 thế hệ mới mang phong cách "Neo Retro" được trang bị khối động cơ CP3 (Crossplane 3 xilanh) quá ấn tượng trong phân khúc 900cc với dung tích 847cc, 4 thì làm mát bằng dung dịch, phun xăng điện tử kết hợp với công nghệ điều khiển bướm ga Y-CCT cho ra công suất đến 115 mã lực tại 10.000 vòng/phút, mô-men xoắn cực đại đạt 87.5 Nm tại 8.500 vòng/phút kết hợp hộp 6 cấp giúp tăng tốc cực kỳ ấn tượng và mạnh mẽ Yamaha XSR900 mới được coi là mẫu xe thể hiện ánh hào quang của thời kỳ Flat-Track trong lịch sử thập niên 1970-1980 với thiết thiết kế phong cách ấn tượng hơn, vừa pha chút cổ điển vừa pha chút bụi bặm, cổ điển Cafe-Racer. XSR900 ABS thế hệ mới là biến thể Neo Retro của MT-09 sở hữu kích thước dài 2.075mm, rộng 815mm và cao 1.135mm, trọng lượng xe ở múc 195 Kg cùng chiều cao yên 830 mm giúp người lái có thể thoải mái hơn khi chống chân.', 0)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'YM3', N'KM0', N'YM', N'SP', N'XZF-R1', 790000000.0000, N'/img/Products/YAMAHA-XZF-R1-01.png', N'/img/Products/YAMAHA-XZF-R1-02.png', N'/img/Products/YAMAHA-XZF-R1-03.png', 12, N'Nhà sản xuất tại Thái Lan đã ”trình làng” 2 màu sắc mới của Yamaha R1 2021 là màu xanh và màu đen. Moto R1 có động cơ bốn xi-lanh thẳng hàng và dung tích xi lanh là 998cc. Khối động cơ này mang lại công suất cực cao và mạnh mẽ. Không chỉ sở hữu động cơ mạnh mẽ mà YZF-R1 còn có kiểu dáng cô cùng ấn tượng. Động cơ trục khuỷu có thanh kết nối nhau bằng titan. Hợp kim titan giúp xe có trọng lượng nhẹ hơn đến 60% so với thép. Chính vì thế, R1 sẽ phát huy được hiệu suất tốt hơn, đảm bảo sự linh hoạt cho người lái khi ở đoạn đường cua. Moto YZF-R1 có trang bị ABS giúp bạn kiểm soát xe, không bị trượt khi thắng gấp. Hộp số 6 cấp rất phù hợp với động cơ có vòng quay cao. Ly hợp được sử dụng để giúp người lái tự tin xuống dốc hơn khi vào các góc mạnh mẽ. Ngoài ra, Yamaha YZF-R1 có 6 chế độ lái, kiểm soát lực kéo và kiểm soát chống trượt và hệ thống sang số nhanh. Tất cả được điều khiển thông qua màn hình TFT-LCD. Đối với YZF-R1M, hệ thống treo điện tử được nâng cấp với phuộc up-side-down Ohlins ERS NPX, trong khi phuộc monoshock phía sau có thể điều chỉnh tải. Thân xe của YZF-R1M có nhiều chi tiết làm từ sợi carbon như phần yếm xe, chắn bùn cho đến phần đuôi. Khung phụ phía sau làm bằng magiê. Chiều cao yên của xe là 1150mm với chiều cao gầm là 130m và dung tích bình xăng là 17L.', 1)
GO
INSERT [dbo].[NhanVien] ([IDNV], [IDType], [Email], [Pass], [TenNV], [DienThoai], [DiaChi], [CMND], [Avatar]) VALUES (1, N'type1', N'ad.ngoctruc@gmail.com', N'6a4efc2dfafa4fe00bd2d7f6f2ff112a', N'Ngọc Trúc', N'0335488465', N'Địa chỉ', N'CMND', N'/img/Avatar/avt-kh1.jpg')
INSERT [dbo].[NhanVien] ([IDNV], [IDType], [Email], [Pass], [TenNV], [DienThoai], [DiaChi], [CMND], [Avatar]) VALUES (2, N'type2', N'st.minhtam@gmail.com', N'25b3ba6ee9a3215d8d2d854ac7f1f8a8', N'Minh Tâm', N'1111111111', N'Địa chỉ', N'CMND', N'/img/Avatar/avt-user2.png')
INSERT [dbo].[NhanVien] ([IDNV], [IDType], [Email], [Pass], [TenNV], [DienThoai], [DiaChi], [CMND], [Avatar]) VALUES (3, N'type2', N'st.minhtri@gmail.com', N'5bbd9309a81809aab0298d3c105d8fce', N'Minh Trí', N'1111111111', N'Địa chỉ', N'CMND', N'/img/Avatar/avt-user1.jpg')
INSERT [dbo].[NhanVien] ([IDNV], [IDType], [Email], [Pass], [TenNV], [DienThoai], [DiaChi], [CMND], [Avatar]) VALUES (4, N'type2', N'st.giahuy@gmail.com', N'f3095b2b30ba70128d247f90246cd7d7', N'Gia Huy', N'1111111111', N'Dịa chỉ ', N'23123233', N'/img/Avatar/avt-user3.png')
GO
INSERT [dbo].[TypeAcc] ([IDType], [Name]) VALUES (N'type1', N'admin')
INSERT [dbo].[TypeAcc] ([IDType], [Name]) VALUES (N'type2', N'staff')
INSERT [dbo].[TypeAcc] ([IDType], [Name]) VALUES (N'type3', N'customer')
GO
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'BMW-HP4-1', N'BMW4', 0, N'BMW-HP4')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'BMW-HP4-2', N'BMW4', 0, N'BMW-P4')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'BMW-HP4-3', N'BMW4', 0, N'BMW-HP4')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'BMW-HP4-4', N'BMW4', 0, N'BMW-HP4')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'BMW-HP4-5', N'BMW4', 0, N'BMW-HP4')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'BMW-HP4-6', N'BMW4', 0, N'BMW-HP4')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'CB1000R-1', N'HD2', 0, N'CB1000R')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'CB1000R-2', N'HD2', 0, N'CB1000R')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'CB1000R-3', N'HD2', 0, N'CB1000R')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'CB1000R-4', N'HD2', 0, N'CB1000R')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'CB1000R-5', N'HD2', 0, N'CB1000R')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'CBR-1000RR-1', N'HD1', 1, N'CBR-1000RR')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'CBR-1000RR-2', N'HD1', 0, N'CBR-1000RR')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'CBR-1000RR-3', N'HD1', 0, N'CBR-1000RR')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'CBR-1000RR-4', N'HD1', 0, N'CBR-1000RR')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'CBR-1000RR-5', N'HD1', 0, N'CBR-1000RR')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'GSX-R1000-1', N'SZ2', 0, N'GSX-R1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'GSX-R1000-2', N'SZ2', 0, N'GSX-R1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'GSX-R1000-3', N'SZ2', 0, N'GSX-R1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'GSX-R1000-4', N'SZ2', 0, N'GSX-R1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'GSX-R1000-5', N'SZ2', 0, N'GSX-R1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'GSX-S1000-1', N'SZ1', 0, N'GSX-S1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'GSX-S1000-2', N'SZ1', 0, N'GSX-S1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'GSX-S1000-3', N'SZ1', 0, N'GSX-S1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'GSX-S1000-4', N'SZ1', 0, N'GSX-S1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'GSX-S1000-5', N'SZ1', 0, N'GSX-S1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'H2-SX-1', N'KW1', 0, N'H2-SX')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'H2-SX-2', N'KW1', 0, N'H2-SX')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'H2-SX-3', N'KW1', 0, N'H2-SX')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'H2-SX-4', N'KW1', 0, N'H2-SX')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'H2-SX-5', N'KW1', 0, N'H2-SX')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'MONSTER-1200S-1', N'DCT2', 0, N'MONSTER-1200S')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'MONSTER-1200S-2', N'DCT2', 0, N'MONSTER-1200S')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'MONSTER-1200S-3', N'DCT2', 0, N'MONSTER-1200S')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'MONSTER-1200S-4', N'DCT2', 0, N'MONSTER-1200S')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'MONSTER-1200S-5', N'DCT2', 0, N'MONSTER-1200S')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'MT-10-1', N'YM1', 0, N'MT-10')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'MT-10-2', N'YM1', 0, N'MT-10')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'MT-10-3', N'YM1', 0, N'MT-10')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'MT-10-4', N'YM1', 0, N'MT-10')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'MT-10-5', N'YM1', 0, N'MT-10')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'MULTISTRADA-1260S-1', N'DCT3', 0, N'MULTISTRADA-1260S')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'MULTISTRADA-1260S-2', N'DCT3', 0, N'MULTISTRADA-1260S')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'MULTISTRADA-1260S-3', N'DCT3', 0, N'MULTISTRADA-1260S')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'MULTISTRADA-1260S-4', N'DCT3', 0, N'MULTISTRADA-1260S')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'MULTISTRADA-1260S-5', N'DCT3', 0, N'MULTISTRADA-1260S')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'R1200-GSA-1', N'BMW3', 0, N'R1200 GSA')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'R1200-GSA-2', N'BMW3', 0, N'R1200 GSA')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'R1200-GSA-3', N'BMW3', 0, N'R1200 GSA')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'R1200-GSA-4', N'BMW3', 0, N'R1200 GSA')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'R1200-GSA-5', N'BMW3', 0, N'R1200 GSA')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'R9T-RACER-1', N'BMW2', 0, N'R9T-RACER')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'R9T-RACER-2', N'BMW2', 0, N'R9T-RACER')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'R9T-RACER-3', N'BMW2', 0, N'R9T RACER')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'R9T-RACER-4', N'BMW2', 0, N'R9T RACER')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'R9T-RACER-5', N'BMW2', 0, N'R9T RACER')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'RC8-R-1', N'KTM3', 0, N'RC8-R')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'RC8-R-2', N'KTM3', 0, N'RC8-R')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'RC8-R-3', N'KTM3', 0, N'RC8-R')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'RC8-R-4', N'KTM3', 0, N'RC8-R')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'RC8-R-5', N'KTM3', 0, N'RC8-R')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'REBEL-500-1', N'HD3', 1, N'REBEL-500')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'REBEL-500-2', N'HD3', 1, N'REBEL-500')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'REBEL-500-3', N'HD3', 1, N'REBEL-500')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'REBEL-500-4', N'HD3', 0, N'REBEL-500')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'REBEL-500-5', N'HD3', 0, N'REBEL-500')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'S1000RR-1', N'BMW1', 1, N'S1000RR')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'S1000RR-2', N'BMW1', 0, N'S1000RR')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'S1000RR-3', N'BMW1', 0, N'S1000RR')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'S1000RR-4', N'BMW1', 0, N'S1000RR')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'S1000RR-5', N'BMW1', 0, N'S1000RR')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'SUPER-ADVENTURE-1', N'KTM2', 0, N'SUPER-ADVENTURE')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'SUPER-ADVENTURE-2', N'KTM2', 0, N'SUPER-ADVENTURE')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'SUPER-ADVENTURE-3', N'KTM2', 0, N'SUPER-ADVENTURE')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'SUPER-ADVENTURE-4', N'KTM2', 0, N'SUPER-ADVENTURE')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'SUPER-ADVENTURE-5', N'KTM2', 0, N'SUPER-ADVENTURE')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'SUPER-DUKE-1', N'KTM1', 0, N'SUPER-DUKE')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'SUPER-DUKE-2', N'KTM1', 0, N'SUPER-DUKE')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'SUPER-DUKE-3', N'KTM1', 0, N'SUPER-DUKE')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'SUPER-DUKE-4', N'KTM1', 0, N'SUPER-DUKE')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'SUPER-DUKE-5', N'KTM1', 0, N'SUPER-DUKE')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'SUPER-SPORT-1', N'DCT1', 0, N'SUPER-SPORT')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'SUPER-SPORT-2', N'DCT1', 0, N'SUPER-SPORT')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'SUPER-SPORT-3', N'DCT1', 0, N'SUPER-SPORT')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'SUPER-SPORT-4', N'DCT1', 0, N'SUPER-SPORT')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'SUPER-SPORT-5', N'DCT1', 0, N'SUPER-SPORT')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'V-STROM1000-1', N'SZ3', 0, N'V-STROM1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'V-STROM1000-2', N'SZ3', 0, N'V-STROM1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'V-STROM1000-3', N'SZ3', 0, N'V-STROM1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'V-STROM1000-4', N'SZ3', 0, N'V-STROM1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'V-STROM1000-5', N'SZ3', 0, N'V-STROM1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'VERSYS-1000-1', N'KW2', 0, N'VERSYS-1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'VERSYS-1000-2', N'KW2', 0, N'VERSYS-1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'VERSYS-1000-3', N'KW2', 0, N'VERSYS-1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'VERSYS-1000-4', N'KW2', 0, N'VERSYS-1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'VERSYS-1000-5', N'KW2', 0, N'VERSYS-1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'XSR900-1', N'YM2', 0, N'XSR900')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'XSR900-2', N'YM2', 0, N'XSR900')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'XSR900-3', N'YM2', 0, N'XSR900')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'XSR900-4', N'YM2', 0, N'XSR900')
GO
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'XSR900-5', N'YM2', 0, N'XSR900')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'XZF-R1-1', N'YM3', 1, N'XZF-R1')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'XZF-R1-2', N'YM3', 0, N'XZF-R1')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'XZF-R1-3', N'YM3', 0, N'XZF-R1')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'XZF-R1-4', N'YM3', 0, N'XZF-R1')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'XZF-R1-5', N'YM3', 0, N'XZF-R1')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'Z-1000R-1', N'KW3', 0, N'Z-1000R')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'Z-1000R-2', N'KW3', 0, N'Z-1000R')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'Z-1000R-3', N'KW3', 0, N'Z-1000R')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'Z-1000R-4', N'KW3', 0, N'Z-1000R')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'Z-1000R-5', N'KW3', 0, N'Z-1000R')
GO
ALTER TABLE [dbo].[ChiTietDG]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDG_KhachHang] FOREIGN KEY([IDKH])
REFERENCES [dbo].[KhachHang] ([IDKH])
GO
ALTER TABLE [dbo].[ChiTietDG] CHECK CONSTRAINT [FK_ChiTietDG_KhachHang]
GO
ALTER TABLE [dbo].[ChiTietDG]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDG_MauXe] FOREIGN KEY([IDMau])
REFERENCES [dbo].[MauXe] ([IDMau])
GO
ALTER TABLE [dbo].[ChiTietDG] CHECK CONSTRAINT [FK_ChiTietDG_MauXe]
GO
ALTER TABLE [dbo].[ChiTietHD]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHD_HoaDon] FOREIGN KEY([IDHD])
REFERENCES [dbo].[HoaDon] ([IDHD])
GO
ALTER TABLE [dbo].[ChiTietHD] CHECK CONSTRAINT [FK_ChiTietHD_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietHD]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHD_Xe] FOREIGN KEY([IDXe])
REFERENCES [dbo].[Xe] ([IDXe])
GO
ALTER TABLE [dbo].[ChiTietHD] CHECK CONSTRAINT [FK_ChiTietHD_Xe]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([IDKH])
REFERENCES [dbo].[KhachHang] ([IDKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_Type] FOREIGN KEY([IDType])
REFERENCES [dbo].[TypeAcc] ([IDType])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_Type]
GO
ALTER TABLE [dbo].[MauXe]  WITH CHECK ADD  CONSTRAINT [FK_MauXe_Hang] FOREIGN KEY([IDHang])
REFERENCES [dbo].[Hang] ([IDHang])
GO
ALTER TABLE [dbo].[MauXe] CHECK CONSTRAINT [FK_MauXe_Hang]
GO
ALTER TABLE [dbo].[MauXe]  WITH CHECK ADD  CONSTRAINT [FK_MauXe_KhuyenMai] FOREIGN KEY([IDKM])
REFERENCES [dbo].[KhuyenMai] ([IDKM])
GO
ALTER TABLE [dbo].[MauXe] CHECK CONSTRAINT [FK_MauXe_KhuyenMai]
GO
ALTER TABLE [dbo].[MauXe]  WITH CHECK ADD  CONSTRAINT [FK_MauXe_LoaiXe] FOREIGN KEY([IDLoaiXe])
REFERENCES [dbo].[LoaiXe] ([IDLoaiXe])
GO
ALTER TABLE [dbo].[MauXe] CHECK CONSTRAINT [FK_MauXe_LoaiXe]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_Type] FOREIGN KEY([IDType])
REFERENCES [dbo].[TypeAcc] ([IDType])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_Type]
GO
ALTER TABLE [dbo].[Xe]  WITH CHECK ADD  CONSTRAINT [FK_Xe_MauXe1] FOREIGN KEY([IDMau])
REFERENCES [dbo].[MauXe] ([IDMau])
GO
ALTER TABLE [dbo].[Xe] CHECK CONSTRAINT [FK_Xe_MauXe1]
GO
