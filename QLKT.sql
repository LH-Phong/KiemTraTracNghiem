USE [QLKT2]
GO
/****** Object:  Table [dbo].[DeThi]    Script Date: 12/27/2021 9:03:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeThi](
	[MaDeThi] [nvarchar](10) NOT NULL,
	[TenDeThi] [nvarchar](50) NOT NULL,
	[MatKhauDeThi] [nvarchar](50) NULL,
	[SoCau] [int] NOT NULL,
	[ThoiGian] [int] NOT NULL,
	[MaGV] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_DeThi1] PRIMARY KEY CLUSTERED 
(
	[MaDeThi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 12/27/2021 9:03:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[MaGV] [nvarchar](10) NOT NULL,
	[TenGV] [nvarchar](50) NOT NULL,
	[SoDienThoai] [nvarchar](15) NOT NULL,
	[NamSinh] [smallint] NOT NULL,
	[GioiTinh] [tinyint] NOT NULL,
	[BoMon] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_GiaoVien1] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HocSinh]    Script Date: 12/27/2021 9:03:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocSinh](
	[MaHS] [nvarchar](10) NOT NULL,
	[TenHS] [nvarchar](50) NOT NULL,
	[GioiTinh] [tinyint] NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[Lop] [nvarchar](10) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_HocSinh1] PRIMARY KEY CLUSTERED 
(
	[MaHS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KetQua]    Script Date: 12/27/2021 9:03:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KetQua](
	[MaHS] [nvarchar](10) NULL,
	[MaDeThi] [nvarchar](10) NULL,
	[TenHS] [nvarchar](50) NULL,
	[Lop] [nvarchar](10) NULL,
	[SoCauDung] [int] NULL,
	[SoCauSai] [int] NULL,
	[ThoiGianLamBai] [nvarchar](20) NULL,
	[NgayKT] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NoiDung]    Script Date: 12/27/2021 9:03:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NoiDung](
	[ID] [nvarchar](20) NOT NULL,
	[MaDeThi] [nvarchar](10) NOT NULL,
	[CauSo] [int] NOT NULL,
	[CauHoi] [nvarchar](max) NOT NULL,
	[DapAn1] [nvarchar](max) NOT NULL,
	[DapAn2] [nvarchar](max) NOT NULL,
	[DapAn3] [nvarchar](max) NOT NULL,
	[DapAn4] [nvarchar](max) NOT NULL,
	[DapAnDung] [int] NOT NULL,
	[DapAnDaChon] [int] NULL,
 CONSTRAINT [PK_NoiDung] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 12/27/2021 9:03:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaTaiKhoan] [nvarchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](100) NOT NULL,
	[QuyenHan] [nvarchar](10) NOT NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_TaiKhoan1] PRIMARY KEY CLUSTERED 
(
	[MaTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[DeThi]  WITH CHECK ADD  CONSTRAINT [FK_DeThi_GiaoVien] FOREIGN KEY([MaGV])
REFERENCES [dbo].[GiaoVien] ([MaGV])
GO
ALTER TABLE [dbo].[DeThi] CHECK CONSTRAINT [FK_DeThi_GiaoVien]
GO
ALTER TABLE [dbo].[KetQua]  WITH CHECK ADD  CONSTRAINT [FK_KetQua_DeThi] FOREIGN KEY([MaDeThi])
REFERENCES [dbo].[DeThi] ([MaDeThi])
GO
ALTER TABLE [dbo].[KetQua] CHECK CONSTRAINT [FK_KetQua_DeThi]
GO
ALTER TABLE [dbo].[KetQua]  WITH CHECK ADD  CONSTRAINT [FK_KetQua_HocSinh] FOREIGN KEY([MaHS])
REFERENCES [dbo].[HocSinh] ([MaHS])
GO
ALTER TABLE [dbo].[KetQua] CHECK CONSTRAINT [FK_KetQua_HocSinh]
GO
ALTER TABLE [dbo].[NoiDung]  WITH CHECK ADD  CONSTRAINT [FK_NoiDung_DeThi] FOREIGN KEY([MaDeThi])
REFERENCES [dbo].[DeThi] ([MaDeThi])
GO
ALTER TABLE [dbo].[NoiDung] CHECK CONSTRAINT [FK_NoiDung_DeThi]
GO

--Dữ liệu Bảng TaiKhoan
INSERT INTO TaiKhoan VALUES('TK01',N'Admin Demo','Admin','123456','Admin','DEMO')
INSERT INTO TaiKhoan VALUES('TK02',N'GiaoVien Demo','GiaoVien','123456','GiaoVien','DEMO')
INSERT INTO TaiKhoan VALUES('TK03',N'HocSinh Demo','HocSinh','123456','HocSinh','DEMO')
INSERT INTO TaiKhoan VALUES('TK04',N'Lê Hoàng Phong','lhphong','123456','HocSinh','HS01')
INSERT INTO TaiKhoan VALUES('TK05',N'Võ Tấn Khôi','vtkhoi','123456','HocSinh','HS02')
INSERT INTO TaiKhoan VALUES('TK06',N'Trần Thanh Nhàng','ttnhang','123456','HocSinh','HS03')
INSERT INTO TaiKhoan VALUES('TK07',N'Lê Văn A','lva','123456','GiaoVien','GV01')
INSERT INTO TaiKhoan VALUES('TK08',N'Nguyễn Thị B','ntb','123456','GiaoVien','GV02')
INSERT INTO TaiKhoan VALUES('TK09',N'Trần Văn C','tvc','123456','Admin','')

--Dữ liệu bảng HocSinh
INSERT INTO HocSinh VALUES('HS01',N'Lê Hoàng Phong','0','2001-05-25','A',N'An Giang')
INSERT INTO HocSinh VALUES('HS02',N'Võ Tấn Khôi','0','2001-01-01','A',N'Đồng Tháp')
INSERT INTO HocSinh VALUES('HS03',N'Trần Thanh Nhàng','0','2001-01-1','B',N'An Giang')

--Dữ liệu bảng GiaoVien
INSERT INTO GiaoVien VALUES('GV01',N'Lê Văn A','0123456789','1990','0',N'CNTT')
INSERT INTO GiaoVien VALUES('GV02',N'Nguyễn Thị B','0123456789','1992','1',N'Toán')

--Dữ liệu bảng DeThi
INSERT INTO DeThi VALUES('COS01',N'Lập trình căn bản','123','10','15','GV01')
INSERT INTO DeThi VALUES('DEMO',N'Kiểm tra DEMO','123','5','10','GV01')
INSERT INTO DeThi VALUES('TOAN01',N'Toán-15p','123','10','15','GV02')

--Dữ liệu bảng NoiDung
INSERT INTO NoiDung VALUES('COS01_1','COS01','1',N'Kiểu dữ liệu nào dưới đây được coi là kiểu dữ liệu cơ bản của lập trình C',N'Kiểu Doule',N'Kiểu con trỏ',N'Kiểu hợp',N'Kiểu mảng','1','0')
INSERT INTO NoiDung VALUES('COS01_2','COS01','2',N'Giả sử a,b là số thực. Biểu thức nào không đúng',N'a+=b',N'a==b',N'a=b',N'a&=b','4','0')
INSERT INTO NoiDung VALUES('COS01_3','COS01','3',N'Xâu định dạng nào in ra 1 ký tự',N'"%f"',N'"%x"',N'"%c"',N'"%s"','3','0')
INSERT INTO NoiDung VALUES('COS01_4','COS01','4',N'Kiểu dữ liệu "int" có thể xử lí số nguyên nằm trong khoảng nào',N'0...255',N'-32768...32768',N'-128...127',N'0...65535','2','0')
INSERT INTO NoiDung VALUES('COS01_5','COS01','5',N'Cho biết giá trị của biểu thức   5>1 ',N'-1',N'0',N'1',N'Tất cả đều sai','3','0')
INSERT INTO NoiDung VALUES('COS01_6','COS01','6',N'Dữ liệu kí tự bao gồm',N'Ký tự Chữ số',N'Ký tự chữ cái',N'Ký tự đặc biệt',N'Cả 3 câu trên','4','0')
INSERT INTO NoiDung VALUES('COS01_7','COS01','7',N'Tên biến nào là đúng ',N'kiem tra',N'1kiemtra',N'_kiemtra',N'-kiemtra','3','0')
INSERT INTO NoiDung VALUES('COS01_8','COS01','8',N'Biến toàn cục được khai báo như thế nào',N'Khai báo ngoài tất cả các hàm kể cả hàm Main()',N'Tất cả các hàm, ngoại trừ hàm Main()',N'Khai báo bên ngoài hàm Main()',N'Khai báo bên trong hàm Main()','1','0')
INSERT INTO NoiDung VALUES('COS01_9','COS01','9',N'Định dạng nào in ra xâu kí tự',N'"%f"',N'"%x"',N'"%c"',N'"%s"','4','0')
INSERT INTO NoiDung VALUES('COS01_10','COS01','10',N'Biểu thức nào là sai cú pháp của ngôn ngữ lập trình C',N'a/=b',N'a-=b',N'a>>=b',N'a!=b','3','0')


