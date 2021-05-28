USE [QLMT]
GO
/****** Object:  Table [dbo].[ChiTietDG]    Script Date: 5/28/2021 3:58:46 PM ******/
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
/****** Object:  Table [dbo].[ChiTietHD]    Script Date: 5/28/2021 3:58:46 PM ******/
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
/****** Object:  Table [dbo].[Hang]    Script Date: 5/28/2021 3:58:46 PM ******/
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
/****** Object:  Table [dbo].[HoaDon]    Script Date: 5/28/2021 3:58:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[IDHD] [varchar](50) NOT NULL,
	[IDKH] [int] NOT NULL,
	[NgayDat] [date] NOT NULL,
	[TrangThai] [nvarchar](50) NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[IDHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 5/28/2021 3:58:46 PM ******/
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
/****** Object:  Table [dbo].[KhuyenMai]    Script Date: 5/28/2021 3:58:46 PM ******/
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
/****** Object:  Table [dbo].[LoaiXe]    Script Date: 5/28/2021 3:58:46 PM ******/
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
/****** Object:  Table [dbo].[MauXe]    Script Date: 5/28/2021 3:58:46 PM ******/
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
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_MauXe] PRIMARY KEY CLUSTERED 
(
	[IDMau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 5/28/2021 3:58:46 PM ******/
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
/****** Object:  Table [dbo].[TypeAcc]    Script Date: 5/28/2021 3:58:46 PM ******/
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
/****** Object:  Table [dbo].[Xe]    Script Date: 5/28/2021 3:58:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xe](
	[IDXe] [varchar](50) NOT NULL,
	[IDMau] [varchar](50) NOT NULL,
	[TrangThai] [bit] NOT NULL,
	[TenXe] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Xe] PRIMARY KEY CLUSTERED 
(
	[IDXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[ChiTietHD] ([IDHD], [IDXe], [KhuyenMai], [GiaBan]) VALUES (N'HD1', N'R9T-RACER01', 0, 659000000.0000)
INSERT [dbo].[ChiTietHD] ([IDHD], [IDXe], [KhuyenMai], [GiaBan]) VALUES (N'HD1', N'S1000RR01', 0, 349000000.0000)
INSERT [dbo].[ChiTietHD] ([IDHD], [IDXe], [KhuyenMai], [GiaBan]) VALUES (N'HD2', N'R9T-RACER02', 0, 659000000.0000)
GO
INSERT [dbo].[Hang] ([IDHang], [TenHang], [TrangThai]) VALUES (N'BMW', N'BMW', 1)
INSERT [dbo].[Hang] ([IDHang], [TenHang], [TrangThai]) VALUES (N'DCT', N'Ducati', 1)
INSERT [dbo].[Hang] ([IDHang], [TenHang], [TrangThai]) VALUES (N'HD', N'Honda', 1)
INSERT [dbo].[Hang] ([IDHang], [TenHang], [TrangThai]) VALUES (N'KTM', N'KTM', 1)
INSERT [dbo].[Hang] ([IDHang], [TenHang], [TrangThai]) VALUES (N'KW', N'Kawasaki', 1)
INSERT [dbo].[Hang] ([IDHang], [TenHang], [TrangThai]) VALUES (N'SZ', N'Suzuki', 1)
INSERT [dbo].[Hang] ([IDHang], [TenHang], [TrangThai]) VALUES (N'YM', N'Yamaha', 1)
GO
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [NgayDat], [TrangThai]) VALUES (N'HD1', 1, CAST(N'2021-05-20' AS Date), N'true')
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [NgayDat], [TrangThai]) VALUES (N'HD2', 3, CAST(N'2021-05-28' AS Date), N'false')
GO
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (1, N'type03', N'cus.huflit1@gmail.com', N'customer', N'Khách hàng 1', N'123 Trịnh Đình Thảo', N'0335000000', N'/img/Avatar/avt-default.png')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (2, N'type03', N'cus.huflit2@gmail.com', N'customer', N'Customer2', N'abc', N'123', N'/img/Avatar/avt-default.png')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (3, N'type03', N'fkelk2@wunderground.com', N'CNai5saz533', N'Freida Kelk', N'0 Warner Street', N'543-961-8733', N'https://robohash.org/optioautemiusto.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (4, N'type03', N'lmclaren3@e-recht24.de', N'NuxGHm7KI', N'Loella McLaren', N'7971 Jay Center', N'720-219-9148', N'https://robohash.org/nemovoluptasfacere.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (5, N'type03', N'eshilvock4@yelp.com', N'H9gZfH', N'Etty Shilvock', N'3 Michigan Point', N'377-465-7703', N'https://robohash.org/quasofficiisid.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (6, N'type03', N'fpaulich5@themeforest.net', N'3rZ2FMgSr4Ni', N'Fields Paulich', N'524 Grayhawk Lane', N'637-688-3910', N'https://robohash.org/invelat.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (7, N'type03', N'eberlin6@apple.com', N'tr77l3p24', N'Evania Berlin', N'640 Stephen Road', N'152-749-2776', N'https://robohash.org/etundemaiores.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (8, N'type03', N'wcathee7@aboutads.info', N'p4c6miy8', N'Wendie Cathee', N'53 Hintze Hill', N'957-568-0587', N'https://robohash.org/consequaturdeserunttempore.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (9, N'type03', N'hallston8@usnews.com', N'mVOFZ5Adib', N'Harlan Allston', N'49994 Annamark Point', N'868-108-4405', N'https://robohash.org/atquequasiet.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (10, N'type03', N'qstockbridge9@phoca.cz', N'zC7hrVXZGU', N'Quint Stockbridge', N'075 Springview Trail', N'615-404-9795', N'https://robohash.org/commodiofficiisnecessitatibus.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (11, N'type03', N'stownbya@vimeo.com', N'quNz0Ss0Rn4F', N'Sela Townby', N'5 Daystar Crossing', N'912-275-5773', N'https://robohash.org/voluptaseadolor.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (12, N'type03', N'adudingb@barnesandnoble.com', N'bShSHEVCjb', N'Ariel Duding', N'89544 Amoth Place', N'646-583-8527', N'https://robohash.org/quiaofficiaet.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (13, N'type03', N'cwhitcombc@vk.com', N'LW7YzxX06TFM', N'Candis Whitcomb', N'7217 Rowland Point', N'115-672-7198', N'https://robohash.org/essevoluptasvoluptas.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (14, N'type03', N'jdutchd@weather.com', N'wWTK2sXQkjd', N'Jim Dutch', N'842 Golf Way', N'551-232-9577', N'https://robohash.org/teneturexercitationemofficia.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (15, N'type03', N'mdonnersberge@businesswire.com', N'cr0O57B5imo', N'Mommy Donnersberg', N'26 East Trail', N'836-545-3334', N'https://robohash.org/harumhicvoluptatum.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (16, N'type03', N'msimmsf@goodreads.com', N'ZXFKWqiClmHO', N'Merola Simms', N'85377 Bay Junction', N'454-441-0859', N'https://robohash.org/officiasintiusto.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (17, N'type03', N'agrimsdykeg@bizjournals.com', N'ZbCNNAsx2541', N'Arv Grimsdyke', N'06857 Sullivan Alley', N'702-959-9845', N'https://robohash.org/maximeutomnis.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (18, N'type03', N'hseldonh@newyorker.com', N'sIykAyW', N'Hermine Seldon', N'1568 North Street', N'923-417-4214', N'https://robohash.org/numquamasperioresvoluptatem.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (19, N'type03', N'abirchneri@gov.uk', N'xEYsWmX', N'Alasdair Birchner', N'224 Bashford Hill', N'827-522-3523', N'https://robohash.org/illumaliquidprovident.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (20, N'type03', N'gklimekj@marriott.com', N'xM6IYpRlXxPS', N'Gasper Klimek', N'482 Bunker Hill Court', N'442-135-5850', N'https://robohash.org/adipiscinequeodit.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (21, N'type03', N'edunridgek@1688.com', N'ZkQcQKrA', N'Elysee Dunridge', N'6732 Cody Point', N'341-106-6320', N'https://robohash.org/officiaquibusdamet.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (22, N'type03', N'rbuttingl@purevolume.com', N'HSYjUzF', N'Rodge Butting', N'7 Mosinee Junction', N'245-141-8993', N'https://robohash.org/quoexporro.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (23, N'type03', N'ccorlettm@artisteer.com', N'YI50XE', N'Corrie Corlett', N'92574 Leroy Lane', N'748-339-3672', N'https://robohash.org/verononnulla.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (24, N'type03', N'lwallagen@oakley.com', N'ktqAUk1tM', N'Laurice Wallage', N'16674 Esch Point', N'379-989-6637', N'https://robohash.org/recusandaenihilquam.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (25, N'type03', N'emulvihillo@ustream.tv', N'ODNO4vR6f', N'Ellis Mulvihill', N'53534 Becker Drive', N'578-431-7842', N'https://robohash.org/sequiliberoullam.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (26, N'type03', N'khoffp@elpais.com', N'KlTESy', N'Kaylil Hoff', N'9851 Continental Plaza', N'251-656-7410', N'https://robohash.org/ipsametdistinctio.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (27, N'type03', N'crealphq@va.gov', N'OO3hAEZQ52', N'Casie Realph', N'09 Blackbird Plaza', N'680-371-0139', N'https://robohash.org/voluptasquiomnis.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (28, N'type03', N'lwathallr@blog.com', N'3ola6n', N'Linc Wathall', N'3849 Hanson Lane', N'822-648-5651', N'https://robohash.org/repellatametvoluptatem.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (29, N'type03', N'ekoberas@wufoo.com', N'ZSbHgakv', N'Emmanuel Kobera', N'8875 Welch Place', N'697-283-6551', N'https://robohash.org/easintest.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (30, N'type03', N'obeglint@google.cn', N'TOlOJ4bQg', N'Olivier Beglin', N'9 Becker Circle', N'557-855-8667', N'https://robohash.org/aperiamautsoluta.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (31, N'type03', N'hjanseyu@arstechnica.com', N'H3U4MdNf', N'Hughie Jansey', N'4029 Clarendon Street', N'311-866-6820', N'https://robohash.org/velvoluptatemsaepe.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (32, N'type03', N'zbingallv@amazon.co.jp', N'udDZIB34dh', N'Zia Bingall', N'94444 Spohn Crossing', N'856-299-3767', N'https://robohash.org/hicnecessitatibussit.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (33, N'type03', N'kcettellw@answers.com', N'ejWvgRkU', N'Kizzie Cettell', N'42322 Jenna Junction', N'277-118-7236', N'https://robohash.org/repellendusundeanimi.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (34, N'type03', N'bbrookerx@unicef.org', N'020F5JNiq', N'Bear Brooker', N'5 West Junction', N'156-625-7927', N'https://robohash.org/commodihicvel.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (35, N'type03', N'sbohlensy@seattletimes.com', N'2jw6eFw', N'Shel Bohlens', N'0475 Toban Trail', N'481-453-5346', N'https://robohash.org/porroquibusdamvoluptatem.png?size=50x50&set=set1')
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
INSERT [dbo].[LoaiXe] ([IDLoaiXe], [TenLoaiXe]) VALUES (N'CF', N'CafeRacer')
INSERT [dbo].[LoaiXe] ([IDLoaiXe], [TenLoaiXe]) VALUES (N'CL', N'Classic')
INSERT [dbo].[LoaiXe] ([IDLoaiXe], [TenLoaiXe]) VALUES (N'HP', N'HyperNaked')
INSERT [dbo].[LoaiXe] ([IDLoaiXe], [TenLoaiXe]) VALUES (N'NJ', N'NinJa')
INSERT [dbo].[LoaiXe] ([IDLoaiXe], [TenLoaiXe]) VALUES (N'NK', N'Naked')
INSERT [dbo].[LoaiXe] ([IDLoaiXe], [TenLoaiXe]) VALUES (N'SP', N'Sport')
INSERT [dbo].[LoaiXe] ([IDLoaiXe], [TenLoaiXe]) VALUES (N'SPCT', N'SportCity')
INSERT [dbo].[LoaiXe] ([IDLoaiXe], [TenLoaiXe]) VALUES (N'SPSP', N'SuperSport')
INSERT [dbo].[LoaiXe] ([IDLoaiXe], [TenLoaiXe]) VALUES (N'SPT', N'SportTouring')
INSERT [dbo].[LoaiXe] ([IDLoaiXe], [TenLoaiXe]) VALUES (N'XSR', N'XSR')
INSERT [dbo].[LoaiXe] ([IDLoaiXe], [TenLoaiXe]) VALUES (N'Z', N'KawaZ')
GO
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'BMW-HP4', N'KM0', N'BMW', N'SP', N'BMW HP4', 2800000000.0000, N'/img/Products/BMW-HP4-01.png', N'/img/Products/BMW-HP4-02.png', N'/img/Products/BMW-HP4-03.png', 2, N'đây là mô tả', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'BMW01', N'KM0', N'BMW', N'SP', N'S1000RR', 949000000.0000, N'/img/Products/BMW-S1000RR-01.png', N'/img/Products/BMW-S1000RR-02.png', N'/img/Products/BMW-S1000RR-03.png', 12, N'BMW S1000RR', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'BMW02', N'KM0', N'BMW', N'SP', N'R9T-RACER', 549000000.0000, N'/img/Products/BMW-R9T-RACER-01.png', N'/img/Products/BMW-R9T-RACER-02.png', N'/img/Products/BMW-R9T-RACER-03.png', 12, N'BMW R9T Racer 719', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'BMW03', N'KM0', N'BMW', N'SP', N'R1200-GSA', 659000000.0000, N'/img/Products/BMW-R1200-GSA-01.png', N'/img/Products/BMW-R1200-GSA-02.png', N'/img/Products/BMW-R1200-GSA-03.png', 12, N'BMW R1200 GSA', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'DCT01', N'KM0', N'DCT', N'SP', N'SUPER-SPORT', 513900000.0000, N'/img/Products/DUCATI-SUPER-SPORT-01.png', N'/img/Products/DUCATI-SUPER-SPORT-02.png', N'/img/Products/DUCATI-SUPER-SPORT-03.png', 12, N'Ducati Super Sport', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'DCT02', N'KM0', N'DCT', N'SP', N'MONSTER-1200S', 877000000.0000, N'/img/Products/DUCATI-MONSTER-1200S-01.png', N'/img/Products/DUCATI-MONSTER-1200S-02.png', N'/img/Products/DUCATI-MONSTER-1200S-03.png', 12, N'Ducati Monster 1200S', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'DCT03', N'KM0', N'DCT', N'SP', N'MULTISTRADA-1260S', 580000000.0000, N'/img/Products/DUCATI-MULTISTRADA-1260S-01.png', N'/img/Products/DUCATI-MULTISTRADA-1260S-02.png', N'/img/Products/DUCATI-MULTISTRADA-1260S-03.png', 12, N'Ducati Multistrada 1260S', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'HD01', N'KM0', N'HD', N'SP', N'CBR-1000RR', 560000000.0000, N'/img/Products/HONDA-CBR-1000RR-01.png', N'/img/Products/HONDA-CBR-1000RR-02.png', N'/img/Products/HONDA-CBR-1000RR-03.png', 12, N'Honda CBR1000RR', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'HD02', N'KM0', N'HD', N'SP', N'CB1000R', 468000000.0000, N'/img/Products/HONDA-CB1000R-01.png', N'/img/Products/HONDA-CB1000R-02.png', N'/img/Products/HONDA-CB1000R-03.png', 12, N'Honda CB1000R', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'HD03', N'KM0', N'HD', N'SP', N'REBEL-500', 180000000.0000, N'/img/Products/HONDA-REBEL-500-01.png', N'/img/Products/HONDA-REBEL-500-02.png', N'/img/Products/HONDA-REBEL-500-03.png', 12, N'Honda Rebel 500', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'KTM01', N'KM0', N'KTM', N'SP', N'SUPER-DUKE', 750000000.0000, N'/img/Products/KTM-SUPER-DUKE-01.png', N'/img/Products/KTM-SUPER-DUKE-02.png', N'/img/Products/KTM-SUPER-DUKE-03.png', 12, N'KTM Super Duke 1290', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'KTM02', N'KM0', N'KTM', N'SP', N'SUPER-ADVENTURE', 690000000.0000, N'/img/Products/KTM-SUPER-ADVENTURE-01.png', N'/img/Products/KTM-SUPER-ADVENTURE-02.png', N'/img/Products/KTM-SUPER-ADVENTURE-03.png', 12, N'KTM Super Adventure 1290', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'KTM03', N'KM0', N'KTM', N'SP', N'RC8-R', 590000000.0000, N'/img/Products/KTM-RC8-R-01.png', N'/img/Products/KTM-RC8-R-02.png', N'/img/Products/KTM-RC8-R-03.png', 12, N'KTM 1190 RC8R', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'KW01', N'KM0', N'KW', N'SP', N'H2-SX', 899000000.0000, N'/img/Products/KAWASAKI-H2-SX-01.png', N'/img/Products/KAWASAKI-H2-SX-02.png', N'/img/Products/KAWASAKI-H2-SX-03.png', 12, N'Kawasaki H2 SX', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'KW02', N'KM0', N'KW', N'SP', N'VERSYS-1000', 420000000.0000, N'/img/Products/KAWASAKI-VERSYS-1000-01.png', N'/img/Products/KAWASAKI-VERSYS-1000-02.png', N'/img/Products/KAWASAKI-VERSYS-1000-03.png', 12, N'Kawasaki Versys 1000', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'KW03', N'KM0', N'KW', N'SP', N'Z-1000R', 459000000.0000, N'/img/Products/KAWASAKI-Z-1000R-01.png', N'/img/Products/KAWASAKI-Z-1000R-02.png', N'/img/Products/KAWASAKI-Z-1000R-03.png', 12, N'Kawasaki Z1000R', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'SZ01', N'KM0', N'SZ', N'SP', N'GSX-S1000', 402000000.0000, N'/img/Products/SUZUKI-GSX-S1000-01.png', N'/img/Products/SUZUKI-GSX-S1000-02.png', N'/img/Products/SUZUKI-GSX-S1000-03.png', 12, N'Suzuki GSX-S1000', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'SZ02', N'KM0', N'SZ', N'SP', N'GSX-R1000', 436000000.0000, N'/img/Products/SUZUKI-GSX-R1000-01.png', N'/img/Products/SUZUKI-GSX-R1000-02.png', N'/img/Products/SUZUKI-GSX-R1000-03.png', 12, N'Suzuki GSX-R1000', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'SZ03', N'KM0', N'SZ', N'SP', N'V-STROM1000', 369000000.0000, N'/img/Products/SUZUKI-V-STROM1000-01.png', N'/img/Products/SUZUKI-V-STROM1000-02.png', N'/img/Products/SUZUKI-V-STROM1000-03.png', 12, N'Suzuki V-STROM 1000', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'YM01', N'KM0', N'YM', N'SP', N'MT-10', 557000000.0000, N'/img/Products/YAMAHA-MT-10-01.png', N'/img/Products/YAMAHA-MT-10-02.png', N'/img/Products/YAMAHA-MT-10-03.png', 12, N'Yamaha MT-10', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'YM02', N'KM0', N'YM', N'SP', N'XSR900', 320000000.0000, N'/img/Products/YAMAHA-XSR900-01.png', N'/img/Products/YAMAHA-XSR900-02.png', N'/img/Products/YAMAHA-XSR900-03.png', 12, N'Yamaha XSR900', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [IDLoaiXe], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'YM03', N'KM0', N'YM', N'SP', N'XZF-R1', 790000000.0000, N'/img/Products/YAMAHA-XZF-R1-01.png', N'/img/Products/YAMAHA-XZF-R1-02.png', N'/img/Products/YAMAHA-XZF-R1-03.png', 12, N'Yamaha XZF-R1', 1)
GO
INSERT [dbo].[NhanVien] ([IDNV], [IDType], [Email], [Pass], [TenNV], [DienThoai], [DiaChi], [CMND], [Avatar]) VALUES (1, N'type01', N'ad.ngoctruc@gmail.com', N'ngoctruc', N'Ngọc Trúc', N'0335488465', N'Địa chỉ', N'CMND', N'/img/Avatar/avt-user1.jpg')
INSERT [dbo].[NhanVien] ([IDNV], [IDType], [Email], [Pass], [TenNV], [DienThoai], [DiaChi], [CMND], [Avatar]) VALUES (2, N'type02', N'st.minhtam@gmail.com', N'minhtam', N'Minh Tam', N'1111111111', N'Địa chỉ', N'CMND', N'/img/Avatar/avt-user2.png')
INSERT [dbo].[NhanVien] ([IDNV], [IDType], [Email], [Pass], [TenNV], [DienThoai], [DiaChi], [CMND], [Avatar]) VALUES (3, N'type02', N'st.minhtri@gmail.com', N'minhtri', N'Minh Trí', N'1111111111', N'Địa chỉ', N'CMND', N'/img/Avatar/avt-default.png')
INSERT [dbo].[NhanVien] ([IDNV], [IDType], [Email], [Pass], [TenNV], [DienThoai], [DiaChi], [CMND], [Avatar]) VALUES (4, N'type02', N'st.giahuy@gmail.com', N'giahuy', N'Gia Huy ', N'1111111111', N'Dịa chỉ ', N'23123233', N'/img/Avatar/avt-user3.png')
GO
INSERT [dbo].[TypeAcc] ([IDType], [Name]) VALUES (N'type01', N'admin')
INSERT [dbo].[TypeAcc] ([IDType], [Name]) VALUES (N'type02', N'staff')
INSERT [dbo].[TypeAcc] ([IDType], [Name]) VALUES (N'type03', N'customer')
GO
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'R9T-RACER01', N'BMW02', 1, N'R9T-RACER')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'R9T-RACER02', N'BMW02', 1, N'R9T-RACER')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'S1000RR01', N'BMW01', 1, N'S1000RR')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'S1000RR02', N'BMW01', 1, N'S1000RR')
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
