use master
go
create database QLSinhVien
go
use QLSinhVien
create table Khoa(
	MaKhoa nchar(10) primary key,
	TenKhoa nvarchar(50)
)
create table Lop(
	MaLop nchar(10) primary key,
	TenLop nvarchar(50),
	MaKhoa nchar(10)
)
alter table Lop
add constraint FK_Lop_Khoa foreign key(MaKhoa) references Khoa(MaKhoa)
create table SinhVien(
	MaSinhVien nchar(10) primary key,
	HoTen nvarchar(50),
	NgaySinh datetime,
	MaLop nchar(10)
)
alter table SinhVien
add constraint FK_SinhVien_Lop foreign key(MaLop) references Lop(MaLop)
create table MonHoc(
	MaMonHoc nchar(10) primary key,
	TenMonHoc nvarchar(50)
)
create table Diem(
	MaSinhVien nchar(10) not null,
	MaMonHoc nchar(10) not null,
	Diem float
)
alter table Diem
add constraint PK_Diem primary key(MaSinhVien, MaMonHoc)
alter table Diem
add constraint FK_Diem_SinhVien foreign key(MaSinhVien) references SinhVien(MaSinhVien)
alter table Diem
add constraint FK_Diem_MonHoc foreign key(MaMonHoc) references MonHoc(MaMonHoc)

insert into Khoa values ('CNTT', N'Công nghệ thông tin')
insert into Khoa values ('CNTP', N'Công nghệ thực phẩm')
insert into Khoa values ('QTKD', N'Quản trị kinh doanh')

set dateformat dmy