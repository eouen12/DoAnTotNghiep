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
	CMNN	VARCHAR(10),
	TRANGTHAI	BIT DEFAULT 1 NOT NULL
);

GO
CREATE TABLE CONGNO (
	MACONGNO		VARCHAR(10) PRIMARY KEY NOT NULL,
	MAKH	VARCHAR(10) NOT NULL,
	TONGTIEN		MONEY,
	DATRA			MONEY,
	TIENCONNO		MONEY,
	NGAYTRA			DATETIME,
	TRANGTHAI	BIT DEFAULT 1 NOT NULL
);

GO
CREATE TABLE NHANVIEN (
	MANV		VARCHAR(50) PRIMARY KEY NOT NULL,
	MATKHAU		VARCHAR(50),
	TENNV		NVARCHAR(MAX),
	SDT			VARCHAR(10),
	CMND		INT,
	DIACHI		NVARCHAR(MAX),
	LUONGCB		INT,
	QUANLY		BIT DEFAULT 0 NOT NULL,--(ADMIN)
	ANHDAIDIEN	NVARCHAR(MAX),
	TRANGTHAI	BIT DEFAULT 1 NOT NULL
);

GO
CREATE TABLE HOADON (
	MAHD		VARCHAR(10) PRIMARY KEY NOT NULL,
	MAKH		VARCHAR(10) NOT NULL,
	NG_LAP_HD	VARCHAR(50) NOT NULL,
	NGAYLAP		DATETIME,
	TONGTIEN	INT,
	NGAYGIAO	DATETIME,
	TRANGTHAI	BIT DEFAULT 1 NOT NULL
);

GO
CREATE TABLE CHITIETHOADON (
	MAHD	VARCHAR(10) NOT NULL,
	MASP	VARCHAR(10) NOT NULL,
	SOLUONG INT,
	DONGIA	INT,
	TRANGTHAI	BIT DEFAULT 1 NOT NULL,
	CONSTRAINT PK_CHITIETHOADON PRIMARY KEY (MAHD, MASP),
);

GO
CREATE TABLE SANPHAM (
	MASP		VARCHAR(10) PRIMARY KEY NOT NULL,
	TENSP		NVARCHAR(MAX),
	GIANHAP		INT,
	GIABAN		INT,
	SL_TON		INT,
	SL_NHAPHANG	INT,
	MANPP	VARCHAR(10),
	ANHMINHHOA	VARCHAR(MAX),
	MALOAI		VARCHAR(10) NOT NULL,
	TRANGTHAI	BIT DEFAULT 1 NOT NULL
);

GO
CREATE TABLE NHAPHANPHOI (
	MANPP	VARCHAR(10) PRIMARY KEY NOT NULL,
	TENNPP	NVARCHAR(MAX),
	SDT		VARCHAR(10),
	EMAIL	VARCHAR(MAX),
	DIACHI	NVARCHAR(MAX),
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
CREATE TABLE LOAISANPHAM (
	MALOAI	VARCHAR(10) PRIMARY KEY NOT NULL,
	TENLOAI	NVARCHAR(MAX),
	TRANGTHAI	BIT DEFAULT 1 NOT NULL
);

-------- THIET LAP KHOA NGOAI --------
ALTER TABLE CONGNO
ADD FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH)

ALTER TABLE HOADON
ADD FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH)

ALTER TABLE HOADON
ADD FOREIGN KEY (NG_LAP_HD) REFERENCES NHANVIEN(MANV)

ALTER TABLE CHITIETHOADON
ADD FOREIGN KEY (MAHD) REFERENCES HOADON(MAHD)

ALTER TABLE CHITIETHOADON
ADD FOREIGN KEY (MASP) REFERENCES SANPHAM(MASP)

ALTER TABLE CHITIETNHAPHANG
ADD FOREIGN KEY (MANPP) REFERENCES NHAPHANPHOI(MANPP)

ALTER TABLE CHITIETNHAPHANG
ADD FOREIGN KEY (MASP) REFERENCES SANPHAM(MASP)

ALTER TABLE SANPHAM
ADD FOREIGN KEY (MALOAI) REFERENCES LOAISANPHAM(MALOAI)

ALTER TABLE SANPHAM
ADD FOREIGN KEY (MANPP) REFERENCES NHAPHANPHOI(MANPP)

---- NHAP DU LIEU MAU ----
-- BANG KHACH HANG --
INSERT INTO KHACHHANG VALUES ('KH0001', N'Trần Triển Chí', '0123456789', N'Quận Bình Tân, Thành phố Hồ Chí Minh',301244877,1)
INSERT INTO KHACHHANG VALUES ('KH0002',N'Trần Minh Nhựt','0123456789',N'Quận 1, Thành phố Hồ Chí Minh',301244877,1)
INSERT INTO KHACHHANG VALUES ('KH0003',N'Nguyễn Văn A','0123456789',N'Quận Bình Tân, Thành phố Hồ Chí Minh',301244877,1)
INSERT INTO KHACHHANG VALUES ('KH0004',N'Trần Thị B','0123456789',N'Quận Bình Tân, Thành phố Hồ Chí Minh',301244877,1)
INSERT INTO KHACHHANG VALUES ('KH0005',N'Nguyễn Văn C','0123456789',N'Quận Bình Tân, Thành phố Hồ Chí Minh',301244877,1)

-- BANG NHAN VIEN --
INSERT INTO NHANVIEN VALUES ('NV_TRIENCHI', 'NV_TRIENCHI', N'Trần Triển Chí', '0123456789', '0123456789', N'Quận Bình Tân, Thành phố Hồ Chí Minh', 5000000, 1, 'trienchi.png', 1)
INSERT INTO NHANVIEN VALUES ('NV_MINHNHUT', 'NV_MINHNHUT', N'Trần Minh Nhựt', '0123456789', '0123456789', N'Quận Bình Tân, Thành phố Hồ Chí Minh', 5000000, 1, 'trienchi.png', 1)

-- BANG LOAI SAN PHAM --
INSERT INTO LOAISANPHAM VALUES ('GM0001', 'Gạch men',1)
INSERT INTO LOAISANPHAM VALUES ('GM0002', 'Gạch bóng kiếng',1)
INSERT INTO LOAISANPHAM VALUES ('GM0003', 'Chậu rửa mặt',1)
-- BANG SAN PHAM --
INSERT INTO SANPHAM VALUES ('SP0001', N'Gạch men', 120000, 135000, 10, 100, 'PP0001', 'ANHGACH.png', 'GM0001',1)
INSERT INTO SANPHAM VALUES ('SP0002', N'Gạch men Ấn Độ', 150000, 170000, 20, 100, 'PP0002', 'ANHGACH.png', 'GM0001',1)
INSERT INTO SANPHAM VALUES ('SP0003', N'Gạch bóng kiếng', 175000, 190000, 10, 100, 'PP0001', 'ANHGACH.png', 'GM0002',1)
INSERT INTO SANPHAM VALUES ('SP0004', N'Gạch bóng kiếng Ấn Độ', 190000, 210000, 10, 100, 'PP0002', 'ANHGACH.png', 'GM0002',1)
-- BANG NHA PHAN PHOI --
INSERT INTO NHAPHANPHOI VALUES ('PP0001', N'Trang Hoàng Phương', '0123456789','tranghoangphuong@gmail.com', 'Long An',1)
INSERT INTO NHAPHANPHOI VALUES ('PP0002', N'Hoa Phát Đạt', '0123456789','hoaphatdat@gmail.com', 'TP HCM',1)
INSERT INTO NHAPHANPHOI VALUES ('PP0003', N'Hòa Bình Minh', '0123456789','tranghoangphuong@gmail.com', 'Đồng Nai',1)
-- BANG CHI TIET NHAP HANG --
INSERT INTO CHITIETNHAPHANG VALUES ('SP0001', 'PP0001',120000 ,100, 10000000 ,'05/25/2020',1)
INSERT INTO CHITIETNHAPHANG VALUES ('SP0002', 'PP0002',150000, 1000, 100000000 ,'05/25/2020',1)
INSERT INTO CHITIETNHAPHANG VALUES ('SP0003', 'PP0001', 175000,1000, 100000000 ,'05/25/2020',1)
-- BANG HOA DON --
INSERT INTO HOADON VALUES ('HD0001','KH0001','NV_TRIENCHI','05/25/2020',1350000,'05/29/2020',1)
INSERT INTO HOADON VALUES ('HD0002','KH0002','NV_MINHNHUT','05/25/2020',1350000,'05/30/2020',1)
INSERT INTO HOADON VALUES ('HD0003','KH0002','NV_MINHNHUT','05/25/2020',1350000,'05/30/2020',1)
-- BANG CHI TIET HOA DON --
INSERT INTO CHITIETHOADON VALUES ('HD0001', 'SP0001', 10, 120000,1)
INSERT INTO CHITIETHOADON VALUES ('HD0002', 'SP0002', 10, 150000,1)
-- BANG CONG NO --
INSERT INTO CONGNO VALUES ('CN0001', 'KH0001', 10000000 ,5000000 ,5000000,'05/29/2020',1)
INSERT INTO CONGNO VALUES ('CN0002', 'KH0002', 5000000 ,5000000 ,2000000,'05/29/2020',1)