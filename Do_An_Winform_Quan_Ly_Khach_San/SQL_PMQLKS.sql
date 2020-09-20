CREATE TABLE Khachhang(
	MaKH nvarchar (10) NOT NULL PRIMARY KEY,
	TenKH nvarchar (50) NULL,
	QuocTich nvarchar (50) NULL,
)
INSERT INTO Khachhang
VALUES  ('KH01', N'Quang Nhật', N'Vietnam'),
		('KH02', N'Tuấn Phú', N'Vietnam'),
		('KH03', N'Sĩ Thành', N'Vietnam'),
		('KH04', N'Thanh Sơn', N'Vietnam'),
		('KH05', N'Kì Long', N'Vietnam'),
		('KH06', N'Trần Đức Bo', N'Vietnam'),
		('KH07', N'Bùi Xuân Huấn',N'Vietnam'),
		('KH08', N'Trần Dần',N'Vietnam'),
		('KH09', N'Trần Thanh Tâm',N'Vietnam'),
		('KH010', N'Nguyễn Quang Hải',N'Vietnam')
---------------------------------------------------------------------------------------------------
CREATE TABLE NhanVien(
	MaNV nvarchar (10) NOT NULL PRIMARY KEY,
	TenNV nvarchar (50) NULL
)
INSERT INTO NhanVien
VALUES  ('NV01', N'Quang Nhật'),
		('NV02', N'Tuấn Phú'),
		('NV03', N'Sĩ Thành'),
		('NV04', N'Thanh Sơn'),
		('NV05', N'Kì Long'),
		('NV06', N'Trần Đức Bo'),
		('NV07', N'Bùi Xuân Huấn'),
		('NV08', N'Trần Dần'),
		('NV09', N'Trần Thanh Tâm'),
		('NV010', N'Nguyễn Quang Hải')
		--select TenNV from NhanVien
---------------------------------------------------------------------------------------------------
CREATE TABLE TaiKhoan(
	Username nvarchar(50) NOT NULL PRIMARY KEY,
	Password nvarchar(50) NULL
)

INSERT INTO TaiKhoan
VALUES  ('1','1'),
		('quangduc', 'quangduc'),
		('quanglinh', 'quanglinh'),
		('quocqui', 'quocqui'),
		('quangnhat','quangnhat'),
		('tuanphu','tuanphu'),
		
---------------------------------------------------------------------------------------------------
CREATE TABLE DichVu(
	MaDV nvarchar (10) NOT NULL PRIMARY KEY,
	TenDV nvarchar (50) NULL,
	GiaDV int NULL,
)
INSERT INTO DichVu
VALUES  ('DV01', N'Fanta', 15000),
		('DV02', N'Trà xanh', 10000),
		('DV03', N'Bò cụng', 20000),
		('DV04', N'Tour củ chi', 485000),
		('DV05', N'Tiễn sân bay', 600000)
---------------------------------------------------------------------------------------------------
CREATE TABLE LoaiPhong (
	MaLoaiPhong nvarchar (10) NOT NULL PRIMARY KEY,
	TenLoai nvarchar (15) NULL
)
INSERT INTO LoaiPhong
VALUES  ('LP01', N'Standard'),
		('LP02', N'Deluxe'),
		('LP03', N'Superior')
--select TenNguonDatPhong from NguonDatPhong
---------------------------------------------------------------------------------------------------
CREATE TABLE NguonDatPhong(
	MaNguonDatPhong nvarchar (10) NOT NULL PRIMARY KEY,
	TenNguonDatPhong nvarchar (50) NULL
)
INSERT INTO NguonDatPhong
VALUES	('NDP01', N'Agoda'),
		('NDP02', N'Travel Loka'),
		('NDP03', N'Booking.com'),
		('NDP04', N'Expedia'),
		('NDP05', N'AirBnB'),
		('NDP06', N'Khách Tự Đến'),
		('NDP07', N'Khách Đối Tác')
---------------------------------------------------------------------------------------------------
CREATE TABLE ThietBi(
	MaThietBi nvarchar (10) NOT NULL PRIMARY KEY,
	TenThietBi nvarchar(50) NULL
)
INSERT INTO ThietBi
VALUES  ('TB01', N'Bàn Ủi'),
		('TB02', N'Dép'),
		('TB03', N'Bàn Gỗ'),
		('TB04', N'Thùng Rác'),
		('TB05', N'Bàn Ủi'),
		('TB06', N'Tivi'),
		('TB07', N'tủ lạnh'),
		('TB08', N'Tách Trà')
		-- or 1=1--
		select count(*) from TaiKhoan where Username = 'ddd' and Password = ' or 1 = -1 '
---------------------------------------------------------------------------------------------------
CREATE TABLE Phong (
	MaPhong nvarchar (10) NOT NULL PRIMARY KEY,
	MaLoaiPhong nvarchar (10) NULL,
	GiaPhong int NULL
	CONSTRAINT FK_Phong_MaLoaiPhong1 FOREIGN KEY (MaLoaiPhong) REFERENCES LoaiPhong (MaLoaiPhong)
)
INSERT INTO Phong
VALUES  ('P01','LP01', 500000),
		('P02','LP01', 500000),
		('P03','LP01', 500000),
		('P04','LP02', 700000),
		('P05','LP02', 700000),
		('P06','LP03', 1000000),
		('P07','LP03', 1000000),
		('P08','LP03', 1000000)
		--UPDATE Phong
		--SET MaLoaiPhong = 'LP03', GiaPhong = 1000000 where MaPhong = 'P06' OR MaPhong = 'P07' OR MaPhong = 'P08'
		--500000),
		--('P02','LP02', 700000),
		--('P03','LP03', 1000000),
		--select MaPhong from Phong p, LoaiPhong lp where p.MaLoaiPhong=lp.MaLoaiPhong and TenLoai = 'Standard'
---------------------------------------------------------------------------------------------------
CREATE TABLE LichLamViec(
	MaLichLamViec nvarchar (10) NOT NULL PRIMARY KEY,
	MaNV nvarchar (10) NULL,
	Ca nvarchar (10) NULL,
	Ngay nvarchar (50) NULL,
	CONSTRAINT FK_LichLamViec_MaNV FOREIGN KEY (MaNV) REFERENCES NhanVien (MaNV)
)
INSERT INTO LichLamViec
VALUES	('LLV01', 'NV01', N'Sáng', N'10/10/2020'),
		('LLV02', 'NV02', N'Trưa', N'10/10/2020'),
		('LLV03', 'NV03', N'Tối', N'10/10/2020'),
		('LLV04', 'NV04', N'Sáng', N'11/10/2020'),
		('LLV05', 'NV05', N'Trưa', N'11/10/2020'),
		('LLV06', 'NV06', N'Sáng', N'12/10/2020'),
		('LLV07', 'NV07', N'Sáng', N'12/10/2020'),
		('LLV08', 'NV08', N'Sáng', N'12/10/2020'),
		('LLV09', 'NV09', N'Sáng', N'12/10/2020'),
		('LLV010', 'NV010', N'Sáng', N'12/10/2020')
---------------------------------------------------------------------------------------------------
CREATE TABLE HoaDon (
	MaHD nvarchar (10) NOT NULL PRIMARY KEY,
	MaNV nvarchar (10) NULL,
	MaKH nvarchar (10) NULL,
	MaPhong nvarchar (10) NULL,
	TenLoai nvarchar(15) NULL,
	SoDem int NULL,
	SoKhach int NULL,
	NgayHD nvarchar(15) NULL,
	TongTien int NULL,
	MaNguonDatPhong nvarchar (10) NULL
	CONSTRAINT FK_HoaDon_MaNhanVien FOREIGN KEY (MaNV) REFERENCES NhanVien (MaNV),
	CONSTRAINT FK_HoaDon_MaKhachHang FOREIGN KEY (MaKH) REFERENCES KhachHang (MaKH),
	CONSTRAINT FK_HoaDon_MaPhong FOREIGN KEY (MaPhong) REFERENCES Phong (MaPhong)
)
INSERT INTO HoaDon
VALUES  ('HD01', 'NV01', 'KH01', 'P01', N'Deluxe', 2, 10, N'15/10/2020', 1460000, 'NDP01'),
		('HD02', 'NV02', 'KH02', 'P02', N'Standard', 2, 1, N'15/10/2020', 1030000, 'NDP02'),
		('HD03', 'NV03', 'KH03', 'P03', N'Deluxe', 2, 1, N'23/10/2020', 2060000, 'NDP03'),
		('HD04', 'NV04', 'KH04', 'P04', N'Standard', 3, 3, N'15/10/2020', 1575000, 'NDP04'),
		('HD05', 'NV05', 'KH05', 'P05', N'Standard', 1, 2, N'15/10/2020', 530000, 'NDP05'),
		('HD06', 'NV06', 'KH06', 'P06', N'Standard', 2, 2, N'15/10/2020', 1030000, 'NDP06'),
		('HD07', 'NV07', 'KH07', 'P07', N'Standard', 1, 2, N'17/10/2020', 515000, 'NDP07'),
		('HD08', 'NV08', 'KH08', 'P08', N'Standard', 2, 2, N'17/10/2020', 1200000, 'NDP01')
---------------------------------------------------------------------------------------------------
CREATE TABLE ChiTietHoaDon (
	MaCTHD nvarchar (10) NOT NULL PRIMARY KEY,
	MaHD nvarchar (10) NULL,
	MaDV nvarchar (10) NULL,
	GiaDV int NULL,
	SoLuong int NULL,
	ThanhTien int NULL
	CONSTRAINT FK_ChiTietHoaDon_MaHoaDon FOREIGN KEY (MaHD) REFERENCES HoaDon (MaHD),
	CONSTRAINT FK_ChiTietHoaDon_MaDichVu FOREIGN KEY (MaDV) REFERENCES DichVu (MaDV)
)
INSERT INTO ChiTietHoaDon
VALUES  ('CTHD01', 'HD01', 'DV01', 30000, 2, 60000),
		('CTHD02', 'HD01', 'DV02', 15000, 1, 15000),
		('CTHD03', 'HD01', 'DV03', 15000, 1, 15000),
		('CTHD04', 'HD01', 'DV04', 485000, 1, 485000),
		('CTHD05', 'HD01', 'DV05', 200000, 3, 600000),
		('CTHD06', 'HD01', 'DV01', 30000, 2, 60000),
		('CTHD07', 'HD01', 'DV02', 15000, 1, 15000),
		('CTHD08', 'HD01', 'DV03', 15000, 1, 15000),
		('CTHD09', 'HD01', 'DV04', 485000, 1, 485000),
		('CTHD010', 'HD01','DV05',  200000, 1, 200000),
		('CTHD011', 'HD01','DV01',  30000, 1, 30000),
		('CTHD012', 'HD01','DV02',  15000, 1, 15000),
		('CTHD013', 'HD01','DV03',  15000, 1, 15000)


--('sithanh','sithanh'),
--('thanhson','thanhson'),
--('kylong','kylong')