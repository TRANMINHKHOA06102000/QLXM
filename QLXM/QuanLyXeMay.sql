--Tạo bảng KhachHang
create table KhachHang(
	MaKH char(6) not null primary key,
	TenKH nvarchar(50) not null,
	CMND char(10) not null,
	DiaChi nvarchar(40)  null,
	DienThoai char(10) null ,
	Email varchar(30) null 
)
--Chèn dữ liệu cho bảng KhachHang
go
insert into KhachHang
values
('MKH001',N'Võ Thành Luân',212123235,N'Đà Nẵng','0347789021','luan124@gmail.com'),
('MKH002',N'Võ Văn Nhất',212464345,N'Quảng Nam','0343459029','nhat234@gmail.com'),
('MKH003',N'Thái Duy Đoan',212464567,N'HCM','0343659111','doanthai123@gmail.com'),
('MKH004',N'Trần Minh Khoa',212464568,N'Đà Nẵng','0397776789','khoapro@gmail.com'),
('MKH005',N'Huỳnh Thanh Xuyến',212464654,N'Đà Nẵng','0391234561','xuyencute@gmail.com'),
('MKH006',N'Nguyễn Duy Quang',212464444,N'HCM','0393345617','quangga@gmail.com'),
('MKH007',N'Huỳnh Thị Như Ý',212464232,N'Đà Nẵng','0383456098','nhuycutedt@gmail.com'),
('MKH008',N'Nguyễn Thị Thảo',212464111,N'Quảng Nam','0383487088','thaoxg@gmail.com'),
('MKH009',N'Nguyễn Thị Lan Vy',212464342,N'Quảng Nam','0373656777','lanvy323@gmail.com'),
('MKH010',N'Nguyễn Ái Nam',212464233,N'Đà Nẵng','0383654675','namgg328@gmail.com');
-- tạo bảng MatHang
create table MatHang(
	MaHang char(6) not null primary key,
	TenHang nvarchar(50) not null,
	NhaSx nvarchar(50) not null,
	SoLuong int not null,
	ThongTinBaoHanh nvarchar(100) not null,
	DonViTinh nvarchar(50) not null,
)
--Chèn dữ liệu cho bảng KhachHang
go
insert into MatHang
values
('MH0001',N'Sirius FI',N'Yamaha',50,N'Bảo hành 2 năm',N'VNĐ'),
('MH0002',N'Sirius RC',N'Yamaha',55,N'Bảo hành 2 năm',N'VNĐ'),
('MH0003',N'Sirius FC',N'Yamaha',80,N'Bảo hành 12 tháng',N'VNĐ'),
('MH0004',N'Blade 110',N'HonDa',90,N'Bảo hành 2 năm',N'VNĐ'),
('MH0005',N'Sh Mode 125',N'HonDa',100,N'Bảo hành 12 tháng',N'VNĐ'),
('MH0006',N'Exciter FC',N'Yamaha',40,N'Bảo hành 2 năm',N'VNĐ');
--tạo bảng NhaCungCap
create table NhaCungCap(
	MaNCC char(6) not null primary key,
	TenNCC nvarchar(50) not null,
	DiaChi nvarchar(50) not null,
	DienThoai char(10),
	Email varchar(50)
)
--chèn dữ liệu cho bảng nhà cung cấp
go
insert into NhaCungCap
values
('NCC001',N'Khải Minh',N'Đà Nẵng','0347785521','l124@gmail.com'),
('NCC002',N'Duy Toàn',N'Hà Nội','0347789044','lun124@gmail.com'),
('NCC003',N'Duy Toàn',N'Đà Nẵng','0377785521','l1124@gmail.com'),
('NCC004',N'Minh Khoa',N'Hà Nội','0847785521','l2124@gmail.com'),
('NCC005',N'Minh Khoa',N'Đà Nẵng','0947785521','rl124@gmail.com'),
('NCC006',N'Thế Toàn',N'TPHCM','0757785521','l1524@gmail.com'),
('NCC007',N'Kim Anh',N'Đà Nẵng','0307785521','l6124@gmail.com'),
('NCC008',N'Kim Anh',N'TP HCM','0348785521','lui124@gmail.com'),
('NCC009',N'Đan Nguyên',N'Đà Nẵng','0347789521','l1624@gmail.com'),
('NCC010',N'Văn Tài',N'Hà Nội','0347005521','l1924@gmail.com');
--tạo bảng NhanVien
create table NhanVien(
	MaNV char(6) not null primary key,
	TenNV nvarchar(50) not null,
	NamSinh int not null,
	GioiTinh char(10) not null,
	Diachi nvarchar(50) not null,
	DienThoai char(10),
	ChucVu nvarchar(30),
	LuongCoBan money
)
-- chèn dữ liệu cho bảng nhân viên
go
insert into NhanVien
values
('MNV001',N'Nguyễn Duy Minh',1995,'male',N'Đà Nẵng','0347785521',N'Tổ Trưởng',3000),
('MNV002',N'Nguyễn Duy Toàn',2000,'male',N'Đà Nẵng','0347785441',N'Nhân Viên',1000),
('MNV003',N'Nguyễn Thị Ánh',2000,'female',N'Quảng Nam','0347783321',N'Nhân Viên',1000),
('MNV004',N'Trần Duy Long',2000,'male',N'Quảng Ngãi','0347756521',N'Nhân Viên',1000),
('MNV005',N'Nguyễn Ánh Tuyết',2000,'female',N'Đà Nẵng','0347789521',N'Nhân Viên',1000),
('MNV006',N'Nguyễn Duy Khánh',1995,'male',N'Đà Nẵng','0347985521',N'Tổ Trưởng',3000),
('MNV007',N'Nguyễn Duy Tài',2000,'male',N'Đà Nẵng','0347780441',N'Nhân Viên',1000),
('MNV008',N'Nguyễn Thị Mai',2000,'female',N'Quảng Nam','0397783321',N'Nhân Viên',1000),
('MNV009',N'Trần Nhật Long',2000,'male',N'Quảng Ngãi','0346756521',N'Nhân Viên',1000),
('MNV010',N'Nguyễn Minh Tuyết',2000,'female',N'Đà Nẵng','0847789521',N'Nhân Viên',1000);
--Tạo Bảng PhieuNhap
Create table PhieuNhap(
	MaPN char(6) not null primary key,
	NgayNhap DateTime not null,
	MaNV char(6) not null foreign key references NhanVien(MaNV),
	MaNCC char(6) not null foreign key references NhaCungCap(MaNCC)
)
--Chèn dữ liệu cho bảng PhieuNhap
go
set dateformat dmy
insert into PhieuNhap
values
('MPN001','05/06/2020','MNV001','NCC001'),
('MPN002','06/06/2020','MNV002','NCC002'),
('MPN003','07/06/2020','MNV003','NCC003'),
('MPN004','08/06/2020','MNV004','NCC004'),
('MPN005','09/06/2020','MNV005','NCC005'),
('MPN006','05/06/2020','MNV006','NCC006'),
('MPN007','06/06/2020','MNV007','NCC007'),
('MPN008','07/06/2020','MNV008','NCC008'),
('MPN009','08/06/2020','MNV009','NCC009'),
('MPN010','09/06/2020','MNV010','NCC010');
--Tạo Bảng Phieuxuat
Create table PhieuXuat(
	MaPX char(6) not null primary key,
	NgayXuat DateTime not null,
	MaNV char(6) not null foreign key references NhanVien(MaNV),
	MaKH char(6) not null foreign key references KhachHang(MaKH)
)
--Chèn dữ liệu cho bảng PhieuXuat
go
set dateformat dmy
insert into PhieuXuat
values
('MPX001','06/06/2020','MNV001','MKH001'),
('MPX002','07/06/2020','MNV002','MKH002'),
('MPX003','08/06/2020','MNV003','MKH003'),
('MPX004','09/06/2020','MNV004','MKH004'),
('MPX005','10/06/2020','MNV005','MKH005'),
('MPX006','06/06/2020','MNV006','MKH006'),
('MPX007','07/06/2020','MNV007','MKH007'),
('MPX008','08/06/2020','MNV008','MKH008'),
('MPX009','09/06/2020','MNV009','MKH009'),
('MPX010','10/06/2020','MNV010','MKH010');
--Tao bang ChiTietPhieuNhap
create table ChiTietPhieuNhap(
	MaPN char(6) not null foreign key references PhieuNhap(MaPN),
	MaHang char(6) not null foreign key references MatHang(MaHang),
	primary key(MaPN,MaHang),
	SoLuongNhap int not null,
	DonGiaNhap money not null,
	Thue int not null,
	TongTien int
)
--chèn dữ liệu cho bảng ChiTietPhieuNhap
go
insert into ChiTietPhieuNhap
values
('MPN001','MH0001',100,500,1,50500),
('MPN002','MH0002',200,300,1,60500),
('MPN003','MH0003',200,300,2,61000),
('MPN004','MH0004',400,200,3,81500),
('MPN005','MH0005',400,500,1,90000),
('MPN006','MH0006',100,500,1,50500),
('MPN007','MH0005',200,300,1,60500),
('MPN008','MH0005',200,300,2,61000),
('MPN009','MH0006',400,200,3,81500),
('MPN010','MH0006',400,500,1,90000);
--Tao bang ChiTietPhieuNhap
create table ChiTietPhieuXuat(
	MaPX char(6) not null foreign key references PhieuXuat(MaPX),
	MaHang char(6) not null foreign key references MatHang(MaHang),
	primary key(MaPX,MaHang),
	SoLuongXuat int not null,
	DonGiaXuat money not null,
	Thue int not null,
	Tong int
)
--chèn dữ liệu cho bảng ChiTietPhieuXuat
go
insert into ChiTietPhieuXuat
values
('MPX001','MH0001',90,100,1,90000),
('MPX002','MH0002',100,100,2,100000),
('MPX003','MH0003',100,200,3,200000),
('MPX004','MH0004',300,200,3,600000),
('MPX005','MH0005',350,300,2,700000),
('MPX006','MH0006',90,100,1,9000),
('MPX007','MH0005',100,100,2,100000),
('MPX008','MH0005',100,200,3,200000),
('MPX009','MH0006',300,200,3,1000000),
('MPX010','MH0006',350,300,2,950000);
--Tao bang TaiKhoan
create table TaiKhoan(
	TaiKhoan char(6) not null primary key,
	MatKhau varchar(10) not null,
	Quyen nvarchar(10) null
)
--chèn dữ liệu cho bảng TaiKhoan
go
insert into TaiKhoan
values
('khoa','12345',N'Nhân Viên'),
('luan','12345',N'Nhân Viên'),
('xuyen','12345',N'Nhân Viên'),
('admin','12345',N'Admin'),
('khach','12345',N'Nhân Viên');
create table ChamCong(
	id char(3) not null primary key,
	TaiKhoan char(6) not null foreign key references TaiKhoan(TaiKhoan),
	Ngay int not null,
	Thang int not null,
	Nam int not null
)
go
insert into ChamCong
values
('001','khoa',01,01,2021),
('002','luan',01,01,2021),
('003','xuyen',01,01,2021),
('004','admin',02,01,2021),
('005','khach',02,01,2021);