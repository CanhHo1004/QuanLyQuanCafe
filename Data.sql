create database QuanlyQuanCafe
go

use QuanlyQuanCafe
go

--Thức uống
--Bàn
--Loại
--Tài khoản
--Hóa đơn
--Chi tiết hóa đơn
--Nhân viên		
--Ca làm ?

create table Ban(
	id INT IDENTITY PRIMARY KEY,
	Ten NVARCHAR(100) NOT NULL DEFAULT N'Bàn không xác định',
	TrangThai NVARCHAR(100) NOT NULL DEFAULT N'Trống'
)
GO

create table TaiKhoan(
	TenDN NVARCHAR(100) PRIMARY KEY,
	TenHienThi NVARCHAR(100) NOT NULL DEFAULT N'Người dùng chưa xác định',
	MatKhau NVARCHAR(100) NOT NULL DEFAULT 1,
	LoaiTK INT NOT NULL DEFAULT 0	---Tk Admin(1) hay Tk nhân viên(0)
	
)
GO
alter table dbo.TaiKhoan add idNhanVien int
alter table dbo.TaiKhoan add foreign key (idNhanVien) references dbo.NhanVien(id)





create table NhanVien(
	id INT IDENTITY PRIMARY KEY,
	TenNV NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	DiaChi NVARCHAR(100) NOT NULL,
	CMND VARCHAR(15),
	NgayVaoLam Date
)
GO
alter table dbo.NhanVien add  idCaLam int
alter table dbo.NhanVien add foreign key (idCaLam) references dbo.CaLam(id)

create table CaLam(
	id INT IDENTITY PRIMARY KEY,
	TenCa NVARCHAR (100) NOT NULL DEFAULT N'Chưa đặt tên',
	Luong MONEY	
	)
GO


create table Loai(
	id INT IDENTITY PRiMARY KEY,
	Ten NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

create table ThucUong(
	id INT IDENTITY PRiMARY KEY,
	Ten NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idLoai INT  NOT NULL,
	Gia FLOAT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idLoai) REFERENCES dbo.Loai(id)
)
GO

create table HoaDon(
	id INT IDENTITY PRiMARY KEY,
	NgayVao DATE NOT NULL DEFAULT GETDATE(),
	NgayRa DATE,
	idBan INT NOT NULL,
	TrangThai INT NOT NULL DEFAULT 0  --Mặc định chưa thanh toán
	
	FOREIGN KEY (idBan) REFERENCES dbo.Ban(id)
)
GO

create table ChiTietHD(
	id INT IDENTITY PRiMARY KEY,
	idHoaDon INT NOT NULL,
	idThucUong INT NOT NULL,
	Count INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idHoaDon) REFERENCES dbo.HoaDon(id),
	FOREIGN KEY (idThucUong) REFERENCES dbo.ThucUong(id)
)
GO

insert into dbo.TaiKhoan(TenDN, TenHienThi, MatKhau, LoaiTK)
values (N'root', N'TKRoot', N'1', 1)

insert into dbo.TaiKhoan(TenDN, TenHienThi, MatKhau, LoaiTK)
values (N'staff', N'NhanVien', N'1', 0)

select * from dbo.TaiKhoan
GO

CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.TaiKhoan WHERE TenDN = @userName
END
GO
EXEC dbo.USP_GetAccountByUserName @userName = N'root'
GO

create proc USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
as
begin
	select * from dbo.TaiKhoan where TenDN = @userName and MatKhau = @passWord
end 
go

insert dbo.Ban( Ten, TrangThai) values ( N'Bàn 1', N'Trống' )
insert dbo.Ban( Ten, TrangThai) values ( N'Bàn 2', N'Trống' )
insert dbo.Ban( Ten, TrangThai) values ( N'Bàn 3', N'Trống' )
insert dbo.Ban( Ten, TrangThai) values ( N'Bàn 4', N'Trống' )
insert dbo.Ban( Ten, TrangThai) values ( N'Bàn 5', N'Trống' )
insert dbo.Ban( Ten, TrangThai) values ( N'Bàn 6', N'Trống' )
insert dbo.Ban( Ten, TrangThai) values ( N'Bàn 7', N'Trống' )
insert dbo.Ban( Ten, TrangThai) values ( N'Bàn 8', N'Trống' )
insert dbo.Ban( Ten, TrangThai) values ( N'Bàn 9', N'Trống' )
insert dbo.Ban( Ten, TrangThai) values ( N'Bàn 10', N'Trống' )

select * from dbo.Ban
GO


create proc USP_GetTableList
as select * from dbo.Ban
GO

--thêm loại
insert dbo.Loai(Ten) values (N'Chai')
insert dbo.Loai(Ten) values (N'Ly')
insert dbo.Loai(Ten) values (N'Trái')

--thêm Thức uống
insert dbo.ThucUong(Ten, idLoai, Gia) values(N'Sting', 1, 15000)
insert dbo.ThucUong(Ten, idLoai, Gia) values(N'Number One', 1, 15000)
insert dbo.ThucUong(Ten, idLoai, Gia) values(N'Pepsi', 1, 13000)
insert dbo.ThucUong(Ten, idLoai, Gia) values(N'Coca', 1, 13000)
insert dbo.ThucUong(Ten, idLoai, Gia) values(N'Cà phê', 2, 10000)
insert dbo.ThucUong(Ten, idLoai, Gia) values(N'Cà phê sữa', 2, 15000)
insert dbo.ThucUong(Ten, idLoai, Gia) values(N'Trà lai', 2, 10000)
insert dbo.ThucUong(Ten, idLoai, Gia) values(N'Trà đường', 2, 8000)
insert dbo.ThucUong(Ten, idLoai, Gia) values(N'Dừa', 3, 18000)

--thêm Hóa đơn
insert dbo.HoaDon(NgayVao, NgayRa, idBan, TrangThai) 
	values (GETDATE(), null, 1, 0)
insert dbo.HoaDon(NgayVao, NgayRa, idBan, TrangThai) 
	values (GETDATE(), null, 2, 0)
insert dbo.HoaDon(NgayVao, NgayRa, idBan, TrangThai) 
	values (GETDATE(), GETDATE(), 5, 1)

--thêm Chi tiết hóa đơn
insert dbo.ChiTietHD(idHoaDon, idThucUong, Count)
	values (1, 1, 2)
insert dbo.ChiTietHD(idHoaDon, idThucUong, Count)
	values (1, 4, 1)
insert dbo.ChiTietHD(idHoaDon, idThucUong, Count)
	values (1, 3, 2)
insert dbo.ChiTietHD(idHoaDon, idThucUong, Count)
	values (2, 1, 2)
insert dbo.ChiTietHD(idHoaDon, idThucUong, Count)
	values (2, 5, 1)
insert dbo.ChiTietHD(idHoaDon, idThucUong, Count)
	values (3, 9, 3)

Go


select d.Ten, bi.Count, d.Gia, d.Gia*bi.Count as TongTien from dbo.ChiTietHD as bi, dbo.HoaDon as b, dbo.ThucUong as d
where bi.idHoaDon = b.id and bi.idThucUong = d.id and b.idBan = 2


select * from dbo.HoaDon
select * from dbo.ChiTietHD
select * from dbo.ThucUong
select * from dbo.Loai
select * from dbo.NhanVien
select * from dbo.TaiKhoan
select * from dbo.CaLam

