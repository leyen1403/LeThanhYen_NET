use master
go
create database QLSinhVien
go
use QLSinhVIen
create table KHOA
(
	MaKhoa nCHAR(10) NOT NULL,
	TenKhoa NVARCHAR(50),
)
alter table KHOA
add constraint PK_KHOA primary key (MaKhoa)

go

create table LOP
(
	MaLop nchar(10) not null,
	TenLop nvarchar(50),
	MaKhoa nchar(10)
)
alter table LOP 
add constraint PK_LOP primary key(MaLop)
go
alter table LOP
add constraint FK_KHOA_LOP foreign key(MaKhoa) references KHOA(MaKhoa)

go

create table SinhVien
(
	MaSinhVien nchar(10) not null,
	HoTen nvarchar(50),
	NgaySinh datetime,
	MaLop nchar(10)
)
alter table SinhVien
add constraint PK_SinhVien primary key(MaSinhVien)
go
alter table SinhVien
add constraint FK_Lop_SinhVien foreign key(MaLop) references Lop(MaLop)