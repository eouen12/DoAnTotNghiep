﻿--KHOI TAO DATABASE
GO
CREATE DATABASE QuanLyCuaHangNoiThat;

--DIEU HUONG DEN DATABASE QUANLYCUAHANGNOITHAT
GO
USE QuanLyCuaHangNoiThat;

--TAO BANG
GO
CREATE TABLE KHACHHANG (
	MAKH	VARCHAR(10) PRIMARY KEY NOT NULL,
	TENKH	NVARCHAR(MAX),
	SDT		VARCHAR(10),
	DIACHI	NVARCHAR(MAX),
	CMND	VARCHAR(10),
	TRANGTHAI	BIT DEFAULT 1 NOT NULL
);

GO
CREATE TABLE CONGNO (
	MACONGNO		VARCHAR(10) PRIMARY KEY NOT NULL,
	TONGTIEN		MONEY,
	DATRA			MONEY,
	TIENCONNO		MONEY,
	NGAYTRA			DATETIME,
	TRANGTHAI	BIT DEFAULT 1 NOT NULL
);

GO
CREATE TABLE LICHSUTRANO (
	MACONGNO		VARCHAR(10) NOT NULL,
	MAKH			VARCHAR(10) NOT NULL,
	NGAYTRA_THEODOI	DATETIME NOT NULL,
	TIENTRA_THEODOI	MONEY,
	TRANGTHAI		BIT DEFAULT 1 NOT NULL,
	CONSTRAINT PK_LICHSUTRANO PRIMARY KEY (MACONGNO, MAKH,NGAYTRA_THEODOI),
);

GO
CREATE TABLE NHANVIEN (
	MANV		VARCHAR(50) PRIMARY KEY NOT NULL,
	MATKHAU		VARCHAR(50),
	TENNV		NVARCHAR(MAX),
	SDT			VARCHAR(10),
	CMND		INT,
	EMAIL		VARCHAR(MAX),
	DIACHI		NVARCHAR(MAX),
	LUONGCB		INT,
	CHUCVU		VARCHAR(3),--(ADMIN)
	ANHDAIDIEN	NVARCHAR(MAX),
	TRANGTHAI	BIT DEFAULT 1 NOT NULL
);

GO
CREATE TABLE HOADONBANHANG (
	MAHD		VARCHAR(10) PRIMARY KEY NOT NULL,
	MAKH		VARCHAR(10) NOT NULL,
	NV_LAP_HD	VARCHAR(50) NOT NULL,
	NGAYLAP		DATETIME,
	TONGTIEN	INT,
	NGAYGIAO	DATETIME,
	TRANGTHAI	BIT DEFAULT 1 NOT NULL
);

GO
CREATE TABLE CTHOADONBANHANG (
	MAHD	VARCHAR(10) NOT NULL,
	MASP	VARCHAR(10) NOT NULL,
	SOLUONG INT,
	DONGIA	INT,
	TRANGTHAI	BIT DEFAULT 1 NOT NULL,
	CONSTRAINT PK_CTHOADONBANHANG PRIMARY KEY (MAHD, MASP),
);

GO
CREATE TABLE SANPHAM (
	MASP		VARCHAR(10) PRIMARY KEY NOT NULL,
	TENSP		NVARCHAR(MAX),
	GIABAN		INT,
	SL_TON		INT,
	MANPP	VARCHAR(10),
	MAANH	VARCHAR(50),
	MALOAI		VARCHAR(10) NOT NULL,
	TRANGTHAI	BIT DEFAULT 1 NOT NULL
);

GO
CREATE TABLE ANHMINHHOASP (
	MAANH			VARCHAR(50) PRIMARY KEY NOT NULL,
	TENANHMINHHOA	VARCHAR(MAX),
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
	DONGIA			INT,
	SL_NHAPHANG		INT,
	TONGGIATRI		INT,
	NGAYNHAPHANG	DATETIME,
	TRANGTHAI	BIT DEFAULT 1 NOT NULL,
	CONSTRAINT PK_CHITIETNHAPHANG PRIMARY KEY (MASP, MANPP)
);

GO
CREATE TABLE HOADONNHAPHANG (
	MAHDNH			VARCHAR(10) PRIMARY KEY NOT NULL,
	NGAY_NHAPHANG	DATETIME,
	NV_NHANHANG		VARCHAR(50) NOT NULL,
	TRANGTHAI		BIT DEFAULT 1 NOT NULL
);

GO
CREATE TABLE CTNHAPHANGTUNPP (
	MAHDNH			VARCHAR(10) NOT NULL,
	MANPP			VARCHAR(10) NOT NULL,
	TONGGIATRI		MONEY,
	TRANGTHAI	BIT DEFAULT 1 NOT NULL,
	CONSTRAINT PK_CTNHAPHANGTUNPP PRIMARY KEY (MAHDNH, MANPP)
);

GO
CREATE TABLE LOAISANPHAM (
	MALOAI	VARCHAR(10) PRIMARY KEY NOT NULL,
	TENLOAI	NVARCHAR(MAX),
	TRANGTHAI	BIT DEFAULT 1 NOT NULL
);

GO
CREATE TABLE LICHSUHETHONG (
	ID		INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	GHICHU	NVARCHAR(MAX)
);

GO
CREATE TABLE QUYENHAN (
	MACHUCVU		VARCHAR(3) PRIMARY KEY NOT NULL,
	TENCHUCVU		NVARCHAR(MAX),
	CHUCNANG_SUDUNG	NVARCHAR(MAX)
);

-------- THIET LAP KHOA NGOAI --------
--ALTER TABLE CONGNO
--ADD FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH)
GO
ALTER TABLE LICHSUTRANO
ADD FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH)

GO
ALTER TABLE LICHSUTRANO
ADD FOREIGN KEY (MACONGNO) REFERENCES CONGNO(MACONGNO)

GO
ALTER TABLE HOADONBANHANG
ADD FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH)

GO
ALTER TABLE HOADONBANHANG
ADD FOREIGN KEY (NV_LAP_HD) REFERENCES NHANVIEN(MANV)

GO
ALTER TABLE HOADONNHAPHANG
ADD FOREIGN KEY (NV_NHANHANG) REFERENCES NHANVIEN(MANV)

GO
ALTER TABLE CTNHAPHANGTUNPP
ADD FOREIGN KEY (MAHDNH) REFERENCES HOADONNHAPHANG(MAHDNH)

GO
ALTER TABLE CTNHAPHANGTUNPP
ADD FOREIGN KEY (MANPP) REFERENCES NHAPHANPHOI(MANPP)

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
ALTER TABLE SANPHAM
ADD FOREIGN KEY (MAANH) REFERENCES ANHMINHHOASP(MAANH)

---- NHAP DU LIEU MAU ----
-- BANG KHACH HANG --
INSERT INTO KHACHHANG VALUES ('KH0001', N'Trần Triển Chí', '0123456789', N'Quận Bình Tân, Thành phố Hồ Chí Minh',301244877,1)
INSERT INTO KHACHHANG VALUES ('KH0002',N'Trần Minh Nhựt','0123456789',N'Quận 1, Thành phố Hồ Chí Minh',301244877,1)
INSERT INTO KHACHHANG VALUES ('KH0003',N'Nguyễn Văn A','0123456789',N'Quận Bình Tân, Thành phố Hồ Chí Minh',301244877,1)
INSERT INTO KHACHHANG VALUES ('KH0004',N'Trần Thị B','0123456789',N'Quận Bình Tân, Thành phố Hồ Chí Minh',301244877,1)
INSERT INTO KHACHHANG VALUES ('KH0005',N'Nguyễn Văn C','0123456789',N'Quận Bình Tân, Thành phố Hồ Chí Minh',301244877,1)
--BANG QUYEN HAN --
INSERT INTO QUYENHAN VALUES ('QL', N'Quản lý', 'Lập tài khoản nhân viên, quản lý đơn hàng từ nhà phân phối,quản lý sản phẩm,...')
INSERT INTO QUYENHAN VALUES ('NV', N'Nhân viên', 'Quản lý khách hàng,lập hóa đơn,...')
-- BANG NHAN VIEN --
INSERT INTO NHANVIEN VALUES ('NV_TRIENCHI', 'NV_TRIENCHI', N'Trần Triển Chí', '0123456789', '0123456789', 'TRANTRIENCHI@GMAIL.COM', N'Quận Bình Tân, Thành phố Hồ Chí Minh', 5000000, 'NV', 'trienchi.png', 1)
INSERT INTO NHANVIEN VALUES ('NV_MINHNHUT', 'NV_MINHNHUT', N'Trần Minh Nhựt', '0123456789', '0123456789', 'TRANMINHNHUT@GMAIL.COM', N'Quận Bình Tân, Thành phố Hồ Chí Minh', 5000000, 'QL', 'trienchi.png', 1)
-- BANG LOAI SAN PHAM --
INSERT INTO LOAISANPHAM VALUES ('GM0001', 'Gạch men',1)
INSERT INTO LOAISANPHAM VALUES ('GM0002', 'Gạch bóng kiếng',1)
INSERT INTO LOAISANPHAM VALUES ('GM0003', 'Chậu rửa mặt',1)
-- BANG NHA PHAN PHOI --
INSERT INTO NHAPHANPHOI VALUES ('PP0001', N'Trang Hoàng Phương', '0123456789','tranghoangphuong@gmail.com', 'Long An', 'ABC.COM',1)
INSERT INTO NHAPHANPHOI VALUES ('PP0002', N'Hoa Phát Đạt', '0123456789','hoaphatdat@gmail.com', 'TP HCM','abc.com',1)
INSERT INTO NHAPHANPHOI VALUES ('PP0003', N'Hòa Bình Minh', '0123456789','tranghoangphuong@gmail.com', 'Đồng Nai', 'ABC.COM',1)
-- BANG ANH MINH HOA SAN PHAM --
INSERT INTO ANHMINHHOASP VALUES ('SP0001_ANHGACH1', 'ANHGACH1.png',1)
INSERT INTO ANHMINHHOASP VALUES ('SP0001_ANHGACH2', 'ANHGACH2.png',1)
INSERT INTO ANHMINHHOASP VALUES ('SP0002_ANHGACH3', 'ANHGACH3.png',1)
INSERT INTO ANHMINHHOASP VALUES ('SP0002_ANHGACH4', 'ANHGACH4.png',1)
INSERT INTO ANHMINHHOASP VALUES ('SP0003_ANHGACH5', 'ANHGACH5.png',1)
INSERT INTO ANHMINHHOASP VALUES ('SP0004_ANHGACH6', 'ANHGACH6.png',1)
-- BANG SAN PHAM --
INSERT INTO SANPHAM VALUES ('SP0001', N'Gạch men', 120000, 100, 'PP0001', 'SP0001_ANHGACH1', 'GM0001',1)
INSERT INTO SANPHAM VALUES ('SP0002', N'Gạch men Ấn Độ', 150000, 100, 'PP0002', 'SP0002_ANHGACH3', 'GM0001',1)
INSERT INTO SANPHAM VALUES ('SP0003', N'Gạch bóng kiếng', 175000, 100, 'PP0001', 'SP0003_ANHGACH5', 'GM0002',1)
INSERT INTO SANPHAM VALUES ('SP0004', N'Gạch bóng kiếng Ấn Độ', 190000, 100, 'PP0002', 'SP0004_ANHGACH6', 'GM0002',1)

-- BANG CHI TIET NHAP HANG --
INSERT INTO CHITIETNHAPHANG VALUES ('SP0001', 'PP0001',120000 ,100, 10000000 ,'05/25/2020',1)
INSERT INTO CHITIETNHAPHANG VALUES ('SP0002', 'PP0002',150000, 1000, 100000000 ,'05/25/2020',1)
INSERT INTO CHITIETNHAPHANG VALUES ('SP0003', 'PP0001', 175000,1000, 100000000 ,'05/25/2020',1)
-- BANG HOA DON --
INSERT INTO HOADONBANHANG VALUES ('HD0001','KH0001','NV_TRIENCHI','05/25/2020',1350000,'05/29/2020',1)
INSERT INTO HOADONBANHANG VALUES ('HD0002','KH0002','NV_MINHNHUT','05/25/2020',1350000,'05/30/2020',1)
INSERT INTO HOADONBANHANG VALUES ('HD0003','KH0002','NV_MINHNHUT','05/25/2020',1350000,'05/30/2020',1)
-- BANG CHI TIET HOA DON --
INSERT INTO CTHOADONBANHANG VALUES ('HD0001', 'SP0001', 10, 120000,1)
INSERT INTO CTHOADONBANHANG VALUES ('HD0002', 'SP0002', 10, 150000,1)
-- BANG CONG NO --
INSERT INTO CONGNO VALUES ('CN0001', 10000000 ,10000000 ,0,'05/29/2020',1)
INSERT INTO CONGNO VALUES ('CN0002', 5000000 ,5000000 ,2000000,'05/29/2020',1)
-- BANG LICH SU TRA NO --
INSERT INTO LICHSUTRANO VALUES ('CN0001', 'KH0001', '05/20/2020', 2000000, 1)
INSERT INTO LICHSUTRANO VALUES ('CN0001', 'KH0001', '05/21/2020', 2000000, 1)
INSERT INTO LICHSUTRANO VALUES ('CN0001', 'KH0001', '05/22/2020', 2000000, 1)
INSERT INTO LICHSUTRANO VALUES ('CN0001', 'KH0001', '05/23/2020', 2000000, 1)
INSERT INTO LICHSUTRANO VALUES ('CN0001', 'KH0001', '05/24/2020', 2000000, 1)
INSERT INTO LICHSUTRANO VALUES ('CN0002', 'KH0002', '05/29/2020', 2000000, 1)