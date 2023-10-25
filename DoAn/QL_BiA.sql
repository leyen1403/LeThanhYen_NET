﻿USE MASTER
GO
CREATE DATABASE QLPHONGBIA
GO
USE QLPHONGBIA


CREATE TABLE KHACHHANG
(
	MAKH NCHAR(10) NOT NULL,
	TENKH NVARCHAR(50),
	SDT NVARCHAR(12),
	GIOVAO TIME,
	GIARA TIME	
)
GO
ALTER TABLE KHACHHANG
ADD CONSTRAINT PK_KH PRIMARY KEY(MAKH)

GO
CREATE TABLE NHANVIEN
(
	MANV NCHAR(10) NOT NULL,
	TENNV NVARCHAR(50),
	TUOI INT,
	DIACHI NVARCHAR(50),
	SDT NCHAR(10),
	GIOITINH NCHAR(10)
)

GO
ALTER TABLE NHANVIEN
ADD CONSTRAINT PK_NHANVIEN PRIMARY KEY(MANV)

GO
CREATE TABLE BANBIA
(
	MABAN NCHAR(10) NOT NULL,
	TENBAN NVARCHAR(50),
	LOAIBAN NVARCHAR(50),
	GIATIEN INT,
	TINHTRANG NVARCHAR(30),
)

GO
ALTER TABLE BANBIA
ADD CONSTRAINT PK_BANBIA PRIMARY KEY(MABAN)

GO
CREATE TABLE DICHVU
(
	MADV NCHAR(10) NOT NULL,
	TENDV NVARCHAR(100),
	GIA INT,
	SOLUONG INT
)
ALTER TABLE DICHVU
ADD CONSTRAINT PK_DV PRIMARY KEY(MADV)

GO
CREATE TABLE DANGKY
(
	MADON NCHAR(10) NOT NULL,
	MAKH NCHAR(10),
	MANV NCHAR(10),
	MADV NCHAR(10),
	MABAN NCHAR(10),
)


GO
ALTER TABLE DANGKY
ADD CONSTRAINT PK_DANGKY PRIMARY KEY(MADON)

GO
ALTER TABLE DANGKY
ADD CONSTRAINT FK_DANGKY_KHACHHANG FOREIGN KEY(MAKH) REFERENCES KHACHHANG(MAKH)

GO
ALTER TABLE DANGKY
ADD CONSTRAINT FK_DANGKY_NHANVIEN FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV)

GO
ALTER TABLE DANGKY
ADD CONSTRAINT FK_DANGKY_DICHVU FOREIGN KEY(MADV) REFERENCES DICHVU(MADV)

GO
ALTER TABLE DANGKY
ADD CONSTRAINT FK_DANGKY_BANBIA FOREIGN KEY(MABAN) REFERENCES BANBIA(MABAN)
GO
CREATE TABLE HOADON
(
	MAHD NCHAR(10) NOT NULL,
	MADON NCHAR(10),
	TONGTIEN INT,
	TINHTRANGTT INT,
)

GO
ALTER TABLE HOADON
ADD CONSTRAINT PK_HOADON PRIMARY KEY(MAHD)

ALTER TABLE HOADON
ADD CONSTRAINT FK_HD_DK FOREIGN KEY(MADON) REFERENCES DANGKY(MADON)
CREATE TABLE GAYBIA
(
	MAGAY NCHAR(10) NOT NULL,
	TENGAY NVARCHAR(100),
	DODAI INT ,
	SOLUONG  INT ,
)
ALTER TABLE GAYBIA
ADD CONSTRAINT PK_GAY PRIMARY KEY(MAGAY)

GO
CREATE TABLE BIA
(
	MABI NCHAR(10) NOT NULL,
	TENBIA NVARCHAR(50) ,
	SOLUONG INT
)
ALTER TABLE BIA
ADD CONSTRAINT PK_BIA PRIMARY KEY(MABI)

GO
CREATE TABLE AUTHENTION
(
	USERNAME NCHAR(10) NOT NULL,
	PASS NVARCHAR(20),
)
ALTER TABLE AUTHENTION
ADD CONSTRAINT PK_AUTHENTION PRIMARY KEY(USERNAME)

-- Thêm 10 dòng dữ liệu vào bảng KHACHHANG với giá trị cho GIOVAO và GIARA
INSERT INTO KHACHHANG (MAKH, TENKH, SDT, GIOVAO, GIARA) VALUES
    ('KH01', N'Nguyễn Văn A', '0123456789', '08:00:00', '16:00:00'),
    ('KH02', N'Trần Thị B', '0987654321', '09:15:00', '17:30:00'),
    ('KH03', N'Lê Văn C', '0369847201', '10:30:00', '18:45:00'),
    ('KH04', N'Phạm Thị D', '0765432198', '11:45:00', '20:00:00'),
    ('KH05', N'Hoàng Văn E', '0897654321', '08:30:00', '17:00:00'),
    ('KH06', N'Nguyễn Thị F', '0765432987', '09:00:00', '18:30:00'),
    ('KH07', N'Trần Văn G', '0123456789', '10:15:00', '20:45:00'),
    ('KH08', N'Lê Thị H', '0987654321', '08:45:00', '16:15:00'),
    ('KH09', N'Phạm Văn I', '0369847201', '09:30:00', '17:45:00'),
    ('KH10', N'Hoàng Thị K', '0765432198', '11:00:00', '19:30:00');
SELECT*FROM KHACHHANG


-- Thêm 10 dòng dữ liệu vào bảng NHANVIEN
INSERT INTO NHANVIEN (MANV, TENNV, TUOI, DIACHI, SDT, GIOITINH) VALUES
    ('NV01', 'Nguyễn Văn An', 28, 'Hà Nội', '0123456789', 'Nam'),
    ('NV02', 'Trần Thị Bình', 35, 'Hồ Chí Minh', '0987654321', 'Nữ'),
    ('NV03', 'Lê Minh Cường', 30, 'Đà Nẵng', '0369847201', 'Nam'),
    ('NV04', 'Phạm Thanh Duy', 24, 'Hải Phòng', '0765432198', 'Nam'),
    ('NV05', 'Hoàng Thị Ngọc', 29, 'Cần Thơ', '0897654321', 'Nữ'),
    ('NV06', 'Nguyễn Văn Đức', 26, 'Hà Tĩnh', '0765432987', 'Nam'),
    ('NV07', 'Trần Thị Lan', 32, 'Nghệ An', '0123456789', 'Nữ'),
    ('NV08', 'Lê Minh Hà', 40, 'Quảng Ninh', '0987654321', 'Nữ'),
    ('NV09', 'Phạm Văn Tùng', 27, 'Quảng Bình', '0369847201', 'Nam'),
    ('NV10', 'Hoàng Thị Hương', 33, 'Bắc Giang', '0765432198', 'Nữ');
SELECT*FROM NHANVIEN

-- Thêm dữ liệu vào bảng BANBIA cho các loại bàn bi-a
INSERT INTO BANBIA (MABAN, TENBAN, LOAIBAN, GIATIEN, TINHTRANG) VALUES
    ('BB01', 'Bàn pool', 'Bi-a không lỗ', 10000, 'Trống'),
    ('BB02', 'Bàn Carom', 'Bi-a không lỗ', 12000, 'Trống'),
    ('BB03', 'Bàn Snooker', 'Bi-a không lỗ', 15000, 'Trống'),
    ('BB04', 'Bàn pool', 'Bi-a lỗ', 20000, 'Trống'),
    ('BB05', 'Bàn Carom', 'Bi-a lỗ', 22000, 'Trống'),
    ('BB06', 'Bàn Snooker', 'Bi-a lỗ', 25000, 'Trống'),
	('BB07', 'Bàn Carom 2', 'Bi-a không lỗ', 12000, 'Trống'),
    ('BB08', 'Bàn pool 2', 'Bi-a lỗ', 20000, 'Đang sử dụng'),
    ('BB09', 'Bàn Snooker 2', 'Bi-a lỗ', 25000, 'Trống'),
    ('BB10', 'Bàn pool 3', 'Bi-a lỗ', 20000, 'Trống'),
    ('BB11', 'Bàn Snooker 3', 'Bi-a không lỗ', 15000, 'Đang sử dụng'),
    ('BB12', 'Bàn pool 4', 'Bi-a lỗ', 20000, 'Trống'),
    ('BB13', 'Bàn Snooker 4', 'Bi-a không lỗ', 15000, 'Trống'),
    ('BB14', 'Bàn pool 5', 'Bi-a lỗ', 20000, 'Trống'),
    ('BB15', 'Bàn Carom 3', 'Bi-a không lỗ', 12000, 'Trống'),
    ('BB16', 'Bàn pool 6', 'Bi-a lỗ', 20000, 'Đang sử dụng');
SELECT*FROM BANBIA

-- Thêm các dịch vụ nước ngọt vào bảng DICHVU
INSERT INTO DICHVU (MADV, TENDV, GIA, SOLUONG) VALUES
    ('DV01', N'Nước ngọt Coca-Cola', 20000, 100),
    ('DV02', N'Nước ngọt Pepsi', 18000, 120),
    ('DV03', N'Nước ngọt 7Up', 16000, 80),
    ('DV04', N'Nước ngọt Fanta', 17000, 90),
    ('DV05', N'Nước ngọt Mirinda', 19000, 110),
    ('DV06', N'Nước ngọt Sprite', 15000, 70);
SELECT*FROM DICHVU



-- Thêm dữ liệu vào bảng DANGKY
INSERT INTO DANGKY (MADON, MAKH, MANV, MADV, MABAN) VALUES
    ('DK01', 'KH01', 'NV01', 'DV01', 'BB01'),
    ('DK02', 'KH02', 'NV02', 'DV02', 'BB02'),
    ('DK03', 'KH03', 'NV03', 'DV03', 'BB03'),
    ('DK04', 'KH04', 'NV04', 'DV04', 'BB04'),
    ('DK05', 'KH05', 'NV05', 'DV03', 'BB05'),
    ('DK06', 'KH06', 'NV06', 'DV06', 'BB06'),
    ('DK07', 'KH07', 'NV05', 'DV01', 'BB07'),
    ('DK08', 'KH08', 'NV02', 'DV03', 'BB08'),
    ('DK09', 'KH09', 'NV02', 'DV05', 'BB09'),
    ('DK10', 'KH10', 'NV01', 'DV05', 'BB10');

SELECT*FROM DANGKY

-- Thêm dữ liệu vào bảng HOADON TINHTRANGTT LÀ TÌNH TRẠNG THANH TOÁN TRẢ VỀ KẾT QUẢ ĐÃ THANH TOÁN LÀ 1 VÀ CHƯA THANH TOÁN LÀ 0
INSERT INTO HOADON (MAHD, MADON, TONGTIEN, TINHTRANGTT) VALUES
    ('HD01',  'DK01', 50000, 1),
    ('HD02',  'DK02', 60000, 1),
    ('HD03',  'DK03', 70000, 0),
    ('HD04', 'DK04', 80000, 1),
    ('HD05',  'DK05', 90000, 0),
    ('HD06',  'DK06', 100000, 1),
    ('HD07',  'DK07', 110000, 0),
    ('HD08', 'DK08', 120000, 1),
    ('HD09',  'DK09', 130000, 0),
    ('HD10', 'DK10', 140000, 1);

SELECT*FROM HOADON

-- Thêm dữ liệu vào bảng GAYBIA
INSERT INTO GAYBIA (MAGAY, TENGAY, DODAI, SOLUONG) VALUES
    ('G01', 'Gay 1', 150, 10),
    ('G02', 'Gay 2', 180, 15),
    ('G03', 'Gay 3', 160, 12),
    ('G04', 'Gay 4', 170, 9);
SELECT*FROM GAYBIA 
-- Thêm dữ liệu vào bảng BIA
INSERT INTO BIA (MABI, TENBIA, SOLUONG) VALUES
    ('B01', 'Bia 3', 100),
    ('B02', 'Bia 4', 120),
    ('B03', 'Bia 9', 110),
    ('B04', 'Bia 18', 90);
SELECT*FROM BIA

-- Thêm dữ liệu vào bảng AUTHENTICATION
INSERT INTO AUTHENTION(USERNAME, PASS) VALUES
    ('User01', 'Pass01'),
    ('User02', 'Pass02'),
    ('User03', 'Pass03'),
    ('User04', 'Pass04');

SELECT*FROM AUTHENTION