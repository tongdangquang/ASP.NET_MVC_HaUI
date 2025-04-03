use master
go
if DB_ID('Sanphamdb') is not null
	drop database Sanphamdb
go
create database sanphamdb
go
use Sanphamdb
go
create table Hangsanxuat(
mahangsx int primary key identity,
tenhangsx nvarchar(25)
)
insert into Hangsanxuat values('Apple')
insert into Hangsanxuat values('Oppo')

go
create table Sanpham(
masanpham int primary key identity,
tensanpham nvarchar(30),
hinhanh nvarchar(50),
mota nvarchar(100),
giatien float,
mahangsx int foreign key references Hangsanxuat(mahangsx))
go

insert into Sanpham(tensanpham,mota,giatien,hinhanh,mahangsx) values(N'IPhone 10',N'Sản xuất năm  2017 ',900,'i10.jpg',1)
insert into Sanpham(tensanpham,mota,giatien,hinhanh,mahangsx) values(N'IPhone 11',N'Sản xuất năm  2019 ',1200,'i11.png',1)
insert into Sanpham(tensanpham,mota,giatien,hinhanh,mahangsx) values(N'IPhone 12',N'Sản xuất năm  2020 ',1500,'i12.jpg',1)
insert into Sanpham(tensanpham,mota,giatien,hinhanh,mahangsx) values(N'OPPO A58','RAM: 8 GB',400,'a58.jpg',2)
insert into Sanpham(tensanpham,mota,giatien,hinhanh,mahangsx) values(N'OPPO A3x','RAM: 4 GB',300,'a3x.jpg',2)
insert into Sanpham(tensanpham,mota,giatien,hinhanh,mahangsx) values(N'OPPO A18','RAM: 64 GB',2000,'a18.jpg',2)
insert into Sanpham(tensanpham,mota,giatien,hinhanh,mahangsx) values(N'OPPO Reno12 Pro 5G','RAM: 12 GB',600,'reno12.jpg',2)
  
go
 
select * from sanpham
