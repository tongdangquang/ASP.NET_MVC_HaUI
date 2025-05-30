USE master;
GO

-- Tạo cơ sở dữ liệu
CREATE DATABASE TrangSucDB;
GO

-- Sử dụng cơ sở dữ liệu
USE TrangSucDB;
GO

-- Tạo bảng Danhmuc
CREATE TABLE Danhmuc (
    MaDanhmuc INT PRIMARY KEY,
    TenDanhmuc NVARCHAR(100)
);

-- Tạo bảng TrangSuc
CREATE TABLE TrangSuc (
    MaTrangsuc INT PRIMARY KEY,
    TenTrangsuc NVARCHAR(100),
    Mota NVARCHAR(255),
    Giatien DECIMAL(18, 2),
    Hinhanh NVARCHAR(255),
    MaDanhmuc INT FOREIGN KEY REFERENCES Danhmuc(MaDanhmuc)
);

-- Chèn 3 danh mục
INSERT INTO Danhmuc (MaDanhmuc, TenDanhmuc)
VALUES 
(1, N'Vàng'),
(2, N'Bạc'),
(3, N'Kim cương');

-- Chèn 3 trang sức cho mỗi danh mục
INSERT INTO TrangSuc (MaTrangsuc, TenTrangsuc, Mota, Giatien, Hinhanh, MaDanhmuc)
VALUES
-- Danh mục 1: Vàng
(101, N'Nhẫn Vàng 24K', N'Nhẫn vàng tinh xảo', 5000000, N'nhanvang.jpg', 1),
(102, N'Dây Chuyền Vàng', N'Dây chuyền cao cấp', 7000000, N'vongvang.jpg', 1),
(103, N'Bông Tai Vàng', N'Bông tai thời trang', 3000000, N'bongtaivang.jpg', 1),

-- Danh mục 2: Bạc
(201, N'Nhẫn Bạc', N'Nhẫn bạc nữ', 800000, N'nhanbac.jpg', 2),
(202, N'Dây Chuyền Bạc', N'Dây chuyền bạc nam', 1200000, N'vongbac.jpg', 2),
(203, N'Lắc Tay Bạc', N'Lắc tay thanh lịch', 1000000, N'lactaybac.jpg', 2),

-- Danh mục 3: Kim cương
(301, N'Nhẫn Kim Cương', N'Nhẫn đính kim cương', 20000000, N'nhankimcuong.jpg', 3),
(302, N'Dây Chuyền Kim Cương', N'Dây chuyền sang trọng', 25000000, N'dckimcuong.jpg', 3),
(303, N'Bông Tai Kim Cương', N'Bông tai lấp lánh', 15000000, N'btkimcuong.jpg', 3);
