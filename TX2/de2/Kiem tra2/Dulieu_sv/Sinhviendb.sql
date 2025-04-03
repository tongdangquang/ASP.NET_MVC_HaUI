use master
go
if DB_ID('sinhviendb') is not null
	drop database sinhviendb
go
create database sinhviendb
go
use sinhviendb
go
--DROP TABLE IF EXISTS Quequan
--go
create table Quequan(
maquequan int primary key identity,
tenquequan nvarchar(25)
)
insert into Quequan values(N'Hà Nội')
insert into Quequan values(N'Hải phòng')
go
--DROP TABLE IF EXISTS Sinhvien
go
create table sinhvien(
masv int primary key identity,
maquequan int foreign key references Quequan(maquequan),
hoten nvarchar(30),
hinhanh nvarchar(50),
email nvarchar(50),
hocphi int
)
go
insert into sinhvien(maquequan,hoten,email,hinhanh,hocphi) values(1,N'Nguyễn Lan Anh','anhnguyen@gmail.com', 'hinh1.jpg',400);
insert into sinhvien(maquequan,hoten,email,hinhanh,hocphi) values(1,N'Phạm Văn Tuấn','tuanpham@gmail.com', 'hinh6.jpg',300);
insert into sinhvien(maquequan,hoten,email,hinhanh,hocphi) values(1,N'Lê Văn Tùng','tungle@gmail.com', 'hinh7.jpg',800);
insert into sinhvien(maquequan,hoten,email,hinhanh,hocphi) values(1,N'Trần Bích Hợp','bichhop@gmail.com', 'hinh4.jpg',300);
insert into sinhvien(maquequan,hoten,email,hinhanh,hocphi) values(2,N'Chu Hải Yến','haiyen@gmail.com', 'hinh2.jpg',700);
insert into sinhvien(maquequan,hoten,email,hinhanh,hocphi) values(2,N'Chu Trần Tiến','tientran@gmail.com', 'hinh8.jpg',500);
insert into sinhvien(maquequan,hoten,email,hinhanh,hocphi) values(2,N'Lê Minh','leminh@gmail.com', 'hinh9.jpg',400);
go



select * from sinhvien
