﻿--KHOI TAO DATABASE
GO
CREATE DATABASE QuanLyCuaHangNoiThat;

--DIEU HUONG DEN DATABASE QUANLYCUAHANGNOITHAT
GO
USE QuanLyCuaHangNoiThat;

--TAO BANG
GO
CREATE TABLE KHACHHANG (
	MAKH	VARCHAR(10)  PRIMARY KEY NOT NULL,
	TENKH	NVARCHAR(MAX),
	SDT		VARCHAR(10),
	DIACHI	NVARCHAR(MAX),
	TRANGTHAI	BIT DEFAULT 1 NOT NULL
);

GO
CREATE TABLE CONGNO (
	MACONGNO		VARCHAR(10) PRIMARY KEY NOT NULL,
	MAKH			VARCHAR(10) NOT NULL,
	MAHD			VARCHAR(10) NOT NULL,
	NV_LAPCN		VARCHAR(10) NOT NULL,
	NGAYLAP			DATETIME,
	TONGTIEN		MONEY,
	TIENCONNO		MONEY,
	NGAYTRA			DATETIME, -- hạn trả --
	TRANGTHAI	BIT DEFAULT 1 NOT NULL
);

GO
CREATE TABLE LICHSUTRANO (
	ID	int IDENTITY(1,1)  PRIMARY KEY NOT NULL,
	MACONGNO		VARCHAR(10) NOT NULL,
	NGAYTRA_THEODOI	DATETIME NOT NULL,
	TIENTRA_THEODOI	MONEY,
	TRANGTHAI		BIT DEFAULT 1 NOT NULL,
);

GO
CREATE TABLE NHANVIEN (
	MANV		VARCHAR(10) PRIMARY KEY NOT NULL,
	MATKHAU		VARCHAR(MAX),
	TENNV		NVARCHAR(MAX),
	SDT			VARCHAR(10),
	CMND		VARCHAR(12),
	EMAIL		VARCHAR(MAX),
	DIACHI		NVARCHAR(MAX),
	LUONGCB		MONEY,
	CHUCVU		VARCHAR(3),--(ADMIN)
	ANHDAIDIEN	NVARCHAR(MAX),
	TRANGTHAI	BIT DEFAULT 1 NOT NULL
);

GO
CREATE TABLE HOADONBANHANG (
	MAHD		VARCHAR(10) PRIMARY KEY NOT NULL,
	MAKH		VARCHAR(10) NOT NULL,
	NV_LAP_HD	VARCHAR(10) NOT NULL,
	NGAYLAP		DATETIME,
	TONGTIEN	MONEY,
	NGAYGIAO	DATETIME,
	TRANGTHAI	BIT DEFAULT 1 NOT NULL
);

GO
CREATE TABLE CTHOADONBANHANG (
	MAHD	VARCHAR(10) NOT NULL,
	MASP	VARCHAR(10) NOT NULL,
	SOLUONG INT,
	DONGIA	MONEY,
	DVT		NVARCHAR(MAX),
	TRANGTHAI	BIT DEFAULT 1 NOT NULL,
	CONSTRAINT PK_CTHOADONBANHANG PRIMARY KEY (MAHD, MASP),
);

GO
CREATE TABLE SANPHAM (
	MASP		VARCHAR(10) PRIMARY KEY NOT NULL,
	TENSP		NVARCHAR(MAX),
	GIABAN		MONEY,
	SL_TON		INT,
	DVT			NVARCHAR(MAX),
	MANPP		VARCHAR(10),
	MALOAI		VARCHAR(10) NOT NULL,
	TRANGTHAI	BIT DEFAULT 1 NOT NULL
);

GO
CREATE TABLE ANHMINHHOASP (
	MAANH			VARCHAR(50) PRIMARY KEY NOT NULL,
	TENANHMINHHOA	VARCHAR(MAX),
	MASP			VARCHAR(10) NOT NULL,
	TRANGTHAI	BIT DEFAULT 1 NOT NULL
);

GO
CREATE TABLE NHAPHANPHOI (
	MANPP	VARCHAR(10) PRIMARY KEY NOT NULL,
	TENNPP	NVARCHAR(MAX),
	SDT		VARCHAR(10),
	EMAIL	VARCHAR(MAX),
	DIACHI	NVARCHAR(MAX),
	WEBSITE	NVARCHAR(MAX),
	TRANGTHAI	BIT DEFAULT 1 NOT NULL
);

GO
CREATE TABLE CHITIETNHAPHANG (
	MASP			VARCHAR(10) NOT NULL,
	MANPP			VARCHAR(10) NOT NULL,
	DONGIA			MONEY,
	SL_NHAPHANG		INT,
	TONGGIATRI		MONEY,
	NGAYNHAPHANG	DATETIME,
	TRANGTHAI	BIT DEFAULT 1 NOT NULL,
	CONSTRAINT PK_CHITIETNHAPHANG PRIMARY KEY (MASP, MANPP)
);

GO
CREATE TABLE LOAISANPHAM (
	MALOAI	VARCHAR(10) PRIMARY KEY NOT NULL,
	TENLOAI	NVARCHAR(MAX),
	TRANGTHAI	BIT DEFAULT 1 NOT NULL
);

GO
CREATE TABLE LICHSUHETHONG (
	ID				INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	NGAYTAO			DATETIME,
	NV_THAOTAC		VARCHAR(10) NOT NULL,
	VITRI_THAOTAC	NVARCHAR(MAX),
	GHICHU			NVARCHAR(MAX),
	TRANGTHAI BIT DEFAULT 1 NOT NULL
);

GO
CREATE TABLE QUYENHAN (
	MACHUCVU		VARCHAR(3) PRIMARY KEY NOT NULL,
	TENCHUCVU		NVARCHAR(MAX),
	CHUCNANG_SUDUNG	NVARCHAR(MAX)
);

GO
CREATE TABLE DOIDONVITUONG (
	ID	int IDENTITY(1,1)  PRIMARY KEY NOT NULL,
	TENGACHTUONG		NVARCHAR(MAX) NOT NULL,
	SOMETTOI			VARCHAR(10),
	TRANGTHAI		BIT DEFAULT 1 NOT NULL
);

GO
CREATE TABLE DOIDONVINEN (
	ID	int IDENTITY(1,1)  PRIMARY KEY NOT NULL,
	TENGACH		NVARCHAR(MAX) NOT NULL,
	SOMETNEN			VARCHAR(10),
	TRANGTHAI		BIT DEFAULT 1 NOT NULL
);
-------- THIET LAP KHOA NGOAI --------
--ALTER TABLE CONGNO
--ADD FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH)
GO
ALTER TABLE LICHSUTRANO
ADD FOREIGN KEY (MACONGNO) REFERENCES CONGNO(MACONGNO)

GO
ALTER TABLE CONGNO
ADD FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH)

GO
ALTER TABLE CONGNO
ADD FOREIGN KEY (MAHD) REFERENCES HOADONBANHANG(MAHD)

GO
ALTER TABLE CONGNO
ADD FOREIGN KEY (NV_LAPCN) REFERENCES NHANVIEN(MANV)

GO
ALTER TABLE HOADONBANHANG
ADD FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH)

GO
ALTER TABLE HOADONBANHANG
ADD FOREIGN KEY (NV_LAP_HD) REFERENCES NHANVIEN(MANV)

GO
ALTER TABLE CTHOADONBANHANG
ADD FOREIGN KEY (MAHD) REFERENCES HOADONBANHANG(MAHD)

GO
ALTER TABLE CTHOADONBANHANG
ADD FOREIGN KEY (MASP) REFERENCES SANPHAM(MASP)

GO
ALTER TABLE CHITIETNHAPHANG
ADD FOREIGN KEY (MANPP) REFERENCES NHAPHANPHOI(MANPP)

GO
ALTER TABLE CHITIETNHAPHANG
ADD FOREIGN KEY (MASP) REFERENCES SANPHAM(MASP)

GO
ALTER TABLE NHANVIEN
ADD FOREIGN KEY (CHUCVU) REFERENCES QUYENHAN(MACHUCVU)

GO
ALTER TABLE SANPHAM
ADD FOREIGN KEY (MALOAI) REFERENCES LOAISANPHAM(MALOAI)

GO
ALTER TABLE SANPHAM
ADD FOREIGN KEY (MANPP) REFERENCES NHAPHANPHOI(MANPP)

GO
ALTER TABLE ANHMINHHOASP
ADD FOREIGN KEY (MASP) REFERENCES SANPHAM(MASP)

GO
ALTER TABLE LICHSUHETHONG
ADD FOREIGN KEY (NV_THAOTAC) REFERENCES NHANVIEN(MANV)

---- NHAP DU LIEU MAU ----
-- BANG KHACH HANG --
INSERT INTO KHACHHANG VALUES ('KH1', N'Trần Triển Chí', '0355430542', N'Quận Bình Tân, Thành phố Hồ Chí Minh',1)
INSERT INTO KHACHHANG VALUES ('KH2', N'Trần Minh Nhựt','0372256123',N'Quận 1, Thành phố Hồ Chí Minh',1)
INSERT INTO KHACHHANG VALUES ('KH3', N'Nguyễn Văn Anh','0937190238',N'Quận Bình Thạnh, Thành phố Hồ Chí Minh',1)
INSERT INTO KHACHHANG VALUES ('KH4', N'Trần Thị Bích','0979489670',N'Quận 6, Thành phố Hồ Chí Minh',1)
INSERT INTO KHACHHANG VALUES ('KH5', N'Nguyễn Văn Chánh','093279552',N'Quận 4, Thành phố Hồ Chí Minh',1)
--BANG QUYEN HAN --
INSERT INTO QUYENHAN VALUES ('QL', N'Quản lý', N'Được quyền sử dụng các chức năng của nhân viên, lập tài khoản nhân viên, lịch sử hệ thống, thống kê doanh thu, thống kê công nợ')
INSERT INTO QUYENHAN VALUES ('NV', N'Nhân viên', N'Quản lý hóa đơn,lập hóa đơn, quản lý khách hàng, quản lý sản phẩm, quản lý loại sản phẩm, quản lý nhà phân phối, quản lý nhập hàng, chức năng đổi mật khẩu, chức năng quy đổi số lượng gạch')
-- BANG NHAN VIEN --
--INSERT INTO NHANVIEN VALUES ('NV1', 'NV_TRIENCHI', N'Trần Triển Chí', '0123456789', '0123456789', 'TRANTRIENCHI@GMAIL.COM', N'Quận Bình Tân, Thành phố Hồ Chí Minh', 5000000, 'NV', 'trienchi.png', 1)
INSERT INTO NHANVIEN VALUES ('QL_ADMIN', 'QL_ADMIN', N'Trần Minh Nhựt', '0372256123', '301700607', 'tranminhnhut@gmail.com', N'Quận 1, Thành phố Hồ Chí Minh', 5000000, 'QL', 'img_default.jpg', 1)
-- BANG LOAI SAN PHAM --
INSERT INTO LOAISANPHAM VALUES ('GM', N'Gạch men',1)
INSERT INTO LOAISANPHAM VALUES ('GBK', N'Gạch bóng kiếng',1)
INSERT INTO LOAISANPHAM VALUES ('GAD', N'Gạch ấn độ',1)
INSERT INTO LOAISANPHAM VALUES ('GTQ', N'Gạch trung quốc',1)
INSERT INTO LOAISANPHAM VALUES ('GGR', N'Gạch giá rẻ',1)
INSERT INTO LOAISANPHAM VALUES ('BTr', N'Bột trét',1)
INSERT INTO LOAISANPHAM VALUES ('CRM', N'Chậu rửa mặt',1)
INSERT INTO LOAISANPHAM VALUES ('BRC', N'Bồn rửa chén',1)
INSERT INTO LOAISANPHAM VALUES ('VS', N'Vòi sen',1)
INSERT INTO LOAISANPHAM VALUES ('VRC', N'Vòi rửa chén',1)
INSERT INTO LOAISANPHAM VALUES ('BC', N'Bồn cầu',1)
INSERT INTO LOAISANPHAM VALUES ('VXVS', N'Vòi xịt vệ sinh',1)
-- BANG NHA PHAN PHOI --
INSERT INTO NHAPHANPHOI VALUES ('NPP1', N'Trang Hoàng Phương', '0123456789','tranghoangphuong@gmail.com', N'Long An', 'www.gachgiare.com',1)
INSERT INTO NHAPHANPHOI VALUES ('NPP2', N'Hoa Phát Đạt', '0123456789','hoaphatdat@gmail.com', N'TP HCM','www.hoaphatdat.com',1)
INSERT INTO NHAPHANPHOI VALUES ('NPP3', N'Hòa Bình Minh', '0123456789','hoabinhminh@gmail.com', N'Đồng Nai', 'www.gachmenre.com',1)
-- BANG SAN PHAM --
INSERT INTO SANPHAM VALUES ('SP1', N'Gạch men',					125000, 100, 'Thùng', 'NPP1', 'GM',1)
INSERT INTO SANPHAM VALUES ('SP2', N'Gạch men Ấn Độ',			155000, 100, 'Thùng', 'NPP2', 'GAD',1)
INSERT INTO SANPHAM VALUES ('SP3', N'Gạch bóng kiếng',			180000, 100, 'Thùng', 'NPP1', 'GBK',1)
INSERT INTO SANPHAM VALUES ('SP4', N'Gạch bóng kiếng Ấn Độ',	195000, 100, 'Thùng', 'NPP3', 'GAD',1)
INSERT INTO SANPHAM VALUES ('SP5', N'Gạch trung quốc',			120000, 100, 'Thùng', 'NPP1', 'GTQ',1)
INSERT INTO SANPHAM VALUES ('SP6', N'Chậu rửa mặt',				150000, 20, 'Cái', 'NPP2', 'CRM',1)
INSERT INTO SANPHAM VALUES ('SP7', N'Bồn rửa chén',				175000, 10, 'Cái', 'NPP3', 'BRC',1)
INSERT INTO SANPHAM VALUES ('SP8', N'Vòi sen',					300000, 50, 'Cái', 'NPP3', 'VS',1)
INSERT INTO SANPHAM VALUES ('SP9', N'Vòi rửa chén',				175000, 30, 'Cái', 'NPP1', 'VRC',1)
INSERT INTO SANPHAM VALUES ('SP10', N'Bồn cầu',					300000, 50, 'Cái', 'NPP2', 'BC',1)
INSERT INTO SANPHAM VALUES ('SP11', N'Vòi xịt vệ sinh',			130000, 50, 'Cái', 'NPP3', 'VXVS',1)

-- BANG CHI TIET NHAP HANG --
INSERT INTO CHITIETNHAPHANG VALUES ('SP1', 'NPP1', 120000, 100, 12000000 ,'05/25/2020',1)
INSERT INTO CHITIETNHAPHANG VALUES ('SP2', 'NPP2', 150000, 100, 15000000 ,'03/10/2020',1)
INSERT INTO CHITIETNHAPHANG VALUES ('SP3', 'NPP1', 175000, 100, 17500000 ,'06/15/2020',1)
INSERT INTO CHITIETNHAPHANG VALUES ('SP4', 'NPP3', 190000, 100, 19000000 ,'01/20/2020',1)
INSERT INTO CHITIETNHAPHANG VALUES ('SP5', 'NPP1', 120000, 100, 12000000 ,'4/25/2020',1)
INSERT INTO CHITIETNHAPHANG VALUES ('SP6', 'NPP2', 150000, 20, 3000000 ,'05/10/2020',1)
INSERT INTO CHITIETNHAPHANG VALUES ('SP7', 'NPP3', 175000, 10, 1750000 ,'06/25/2020',1)
INSERT INTO CHITIETNHAPHANG VALUES ('SP8', 'NPP3', 300000, 50, 15000000 ,'07/10/2020',1)
INSERT INTO CHITIETNHAPHANG VALUES ('SP9', 'NPP1', 175000, 30, 5250000 ,'02/25/2020',1)
INSERT INTO CHITIETNHAPHANG VALUES ('SP10', 'NPP2', 300000, 50, 15000000 ,'04/20/2020',1)
INSERT INTO CHITIETNHAPHANG VALUES ('SP11', 'NPP3', 130000, 50, 6500000 ,'05/25/2020',1)
---- BANG ANH MINH HOA SAN PHAM --
--INSERT INTO ANHMINHHOASP VALUES ('SP1_ANHGACH1', 'ANHGACH1.jpg', 'SP1',1)
--INSERT INTO ANHMINHHOASP VALUES ('SP1_ANHGACH2', 'ANHGACH2.jpg', 'SP1',1)
--INSERT INTO ANHMINHHOASP VALUES ('SP2_ANHGACH3', 'ANHGACH3.jpg', 'SP2',1)
--INSERT INTO ANHMINHHOASP VALUES ('SP2_ANHGACH4', 'ANHGACH4.jpg', 'SP2',1)
--INSERT INTO ANHMINHHOASP VALUES ('SP3_ANHGACH5', 'ANHGACH5.jpg', 'SP3',1)
--INSERT INTO ANHMINHHOASP VALUES ('SP4_ANHGACH6', 'ANHGACH6.jpg', 'SP4',1)
---- BANG HOA DON --
--INSERT INTO HOADONBANHANG VALUES ('HD1','KH1','NV_TRIENCHI','05/25/2020',1350000,'05/29/2020',1)
--INSERT INTO HOADONBANHANG VALUES ('HD2','KH2','NV_MINHNHUT','05/25/2020',1350000,'05/30/2020',1)
--INSERT INTO HOADONBANHANG VALUES ('HD3','KH2','NV_MINHNHUT','05/25/2020',1350000,'05/30/2020',1)
---- BANG CHI TIET HOA DON --
--INSERT INTO CTHOADONBANHANG VALUES ('HD1', 'SP1', 10, 120000,1)
--INSERT INTO CTHOADONBANHANG VALUES ('HD2', 'SP2', 10, 150000,1)
---- BANG CONG NO --
--INSERT INTO CONGNO VALUES ('CN1','KH1', 10000000 ,0,'05/29/2020',1)
--INSERT INTO CONGNO VALUES ('CN2','KH2', 5000000 ,2000000,'05/29/2020',1)
---- BANG LICH SU TRA NO --
--INSERT INTO LICHSUTRANO VALUES ('CN1',  '05/20/2020', 2000000, 1)
--INSERT INTO LICHSUTRANO VALUES ('CN1',  '05/21/2020', 2000000, 1)
--INSERT INTO LICHSUTRANO VALUES ('CN1',  '05/22/2020', 2000000, 1)
--INSERT INTO LICHSUTRANO VALUES ('CN1',  '05/23/2020', 2000000, 1)
--INSERT INTO LICHSUTRANO VALUES ('CN1',  '05/24/2020', 2000000, 1)
--INSERT INTO LICHSUTRANO VALUES ('CN2',  '05/29/2020', 2000000, 1)

---- BANG DOI DON VI TUONG --
INSERT INTO DOIDONVITUONG VALUES ( N'Gạch 25x40 - 10 tấm/thùng', '1', 1)
INSERT INTO DOIDONVITUONG VALUES ( N'Gạch 25x40 - 12 tấm/thùng', '1,2', 1)
INSERT INTO DOIDONVITUONG VALUES ( N'Gạch 30x45 - 7 tấm/thùng', '0,945', 1)
INSERT INTO DOIDONVITUONG VALUES ( N'Gạch 30x60 - 6 tấm/thùng', '1,08', 1)
INSERT INTO DOIDONVITUONG VALUES ( N'Gạch 30x60 - 8 tấm/thùng', '1,44', 1)
INSERT INTO DOIDONVITUONG VALUES ( N'Gạch 40x80 - 6 tấm/thùng', '1,92', 1)


---- BANG DOI DON VI NEN --
INSERT INTO DOIDONVINEN VALUES (  N'Gạch 30x30 - 11 tấm/thùng', '1', 1)
INSERT INTO DOIDONVINEN VALUES (  N'Gạch 40x40 - 6 tấm/thùng', '0,96', 1)
INSERT INTO DOIDONVINEN VALUES (  N'Gạch 50x50 - 4 tấm/thùng', '1', 1)
INSERT INTO DOIDONVINEN VALUES (  N'Gạch 60x60 - 4 tấm/thùng', '1,44', 1)
INSERT INTO DOIDONVINEN VALUES (  N'Gạch 80x80 - 3 tấm/thùng', '1,92',1)
