CREATE DATABASE QLKyTucXa;
GO

USE QLKyTucXa;
GO

CREATE TABLE NhanVien (
   MaNV VARCHAR(10) PRIMARY KEY,
   HoTen NVARCHAR(100),
   Cccd VARCHAR(12),
   GioiTinh NVARCHAR(10),
   NgaySinh DATE,
   Email VARCHAR(100),
   Sdt VARCHAR(15)
);

CREATE TABLE Phong (
   MaPhong VARCHAR(10) PRIMARY KEY,
   TenPhong NVARCHAR(50),
   TinhTrang NVARCHAR(50),
   SoLuongSV INT,
   GiaPhong DECIMAL(10, 2)
);

CREATE TABLE SinhVien (
   MaSV VARCHAR(10) PRIMARY KEY,
   HoTen NVARCHAR(100),
   NgaySinh DATE,
   GioiTinh NVARCHAR(10),
   Cccd VARCHAR(12),
   Sdt VARCHAR(15),
   DiaChi NVARCHAR(200),
   NganhHoc NVARCHAR(100),
   Email VARCHAR(100),
   MaPhong VARCHAR(10),
   FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong)
);

CREATE TABLE DangKyPhong (
   MaDK VARCHAR(10) PRIMARY KEY,
   MaSV VARCHAR(10),
   HoTen NVARCHAR(100),
   MaPhong VARCHAR(10),
   TenPhong NVARCHAR(50),
   NgayDK DATE,
   NgayBD DATE,
   NgayKT DATE,
   FOREIGN KEY (MaSV) REFERENCES SinhVien(MaSV),
   FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong)
);

CREATE TABLE DichVu (
   MaDV VARCHAR(10) PRIMARY KEY,
   TenDV NVARCHAR(50),
   GiaDV DECIMAL(10, 2),
   MoTa NVARCHAR(200)
);

CREATE TABLE HoaDon (
   MaHD VARCHAR(10) PRIMARY KEY,
   MaSV VARCHAR(10),
   NgayLap DATE,
   TongTien DECIMAL(10, 2),
   TrangThai NVARCHAR(20),
   FOREIGN KEY (MaSV) REFERENCES SinhVien(MaSV)
);

CREATE TABLE ChiTietHoaDon (
   MaCTHD VARCHAR(10) PRIMARY KEY,
   MaHD VARCHAR(10),
   MaDV VARCHAR(10),
   SoLuong INT,
   ThanhTien DECIMAL(10, 2),
   FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD),
   FOREIGN KEY (MaDV) REFERENCES DichVu(MaDV)
);

CREATE TABLE HopDong (
   MaHD VARCHAR(10) PRIMARY KEY,
   MaSV VARCHAR(10),
   NgayKy DATE,
   ThoiHan INT,
   TongTien DECIMAL(10, 2),
   FOREIGN KEY (MaSV) REFERENCES SinhVien(MaSV)
);

CREATE TABLE ThanhToan (
   MaTT VARCHAR(10) PRIMARY KEY,
   MaHD VARCHAR(10),
   NgayTT DATE,
   SoTien DECIMAL(10, 2),
   PhuongThuc NVARCHAR(20),
   FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD)
);

CREATE TABLE TaiKhoan (
   TaiKhoan VARCHAR(50) PRIMARY KEY,
   MatKhau VARCHAR(100),
   MaLoai VARCHAR(10),
   TenLoai NVARCHAR(50)
);

CREATE TABLE ThongBao (
   MaTB VARCHAR(10) PRIMARY KEY,
   NoiDung NVARCHAR(500),
   NgayTB DATE,
   LoaiTB NVARCHAR(50)
);

CREATE TABLE DienNuoc (
   MaDN VARCHAR(10) PRIMARY KEY,
   MaPhong VARCHAR(10),
   Thang INT,
   Nam INT,
   ChiSoDien INT,
   ChiSoNuoc INT,
   TongTien DECIMAL(10, 2),
   FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong)
);

INSERT INTO ThongBao (MaTB, NoiDung, NgayTB, LoaiTB) VALUES 
('TB001', N'Lịch thu tiền nhà tháng 10', '2024-10-30', N'Khoản phí'),
('TB002', N'Lịch thu tiền nhà tháng 11', '2024-11-30', N'Khoản phí'),
('TB003', N'Lịch thu tiền nhà tháng 12', '2024-12-30', N'Khoản phí'),
('TB004', N'Không được gây ồn ở trọ', '2024-11-20', N'Quy định'),
('TB005', N'Không được dẫn bạn khác giới về phòng', '2024-12-20', N'Quy định');

INSERT INTO NhanVien (MaNV, HoTen, Cccd, GioiTinh, NgaySinh, Email, Sdt) VALUES 
('NV001', N'Nguyễn Văn An', '123456789012', N'Nam', '1990-01-15', 'an.nguyen@example.com', '0912345678'),
('NV002', N'Trần Thị Bích', '234567890123', N'Nữ', '1992-05-20', 'bich.tran@example.com', '0987654321'),
('NV003', N'Lê Quốc Minh', '345678901234', N'Nam', '1988-03-10', 'minh.le@example.com', '0938765432');

INSERT INTO Phong (MaPhong, TenPhong, TinhTrang, SoLuongSV, GiaPhong) VALUES 
('P101', N'Phòng 101', N'Còn chỗ', 3, 1500000),
('P102', N'Phòng 102', N'Đầy', 4, 1800000), 
('P103', N'Phòng 103', N'Còn chỗ', 2, 1200000);

INSERT INTO SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, Cccd, Sdt, DiaChi, NganhHoc, Email, MaPhong) VALUES
('SV001', N'Lê Văn Cường', '2000-03-10', N'Nam', '456789012345', '0901234567', N'Cần Thơ', N'Công nghệ thông tin', 'cuong.le@student.com', 'P101'),
('SV002', N'Trần Thị Diệu', '2001-07-22', N'Nữ', '567890123456', '0912345678', N'Hậu Giang', N'Kế toán', 'dieu.tran@student.com', 'P102'), 
('SV003', N'Phạm Minh Hoàng', '2002-01-01', N'Nam', '678901234567', '0923456789', N'Sóc Trăng', N'Quản trị kinh doanh', 'hoang.pham@student.com', 'P103');

INSERT INTO TaiKhoan (TaiKhoan, MatKhau, MaLoai, TenLoai) VALUES
('admin', 'admin123', 'ADMIN', N'Quản trị viên'),
('nhanvien', 'nhanvien123', 'NV', N'Nhân viên'),
('sv001', 'password123', 'SV', N'Sinh viên');

INSERT INTO DienNuoc (MaDN, MaPhong, Thang, Nam, ChiSoDien, ChiSoNuoc, TongTien) VALUES 
('DN001', 'P101', 10, 2024, 100, 20, 500000),
('DN002', 'P102', 10, 2024, 120, 30, 600000),
('DN003', 'P103', 10, 2024, 80, 15, 400000);

INSERT INTO DangKyPhong (MaDK, MaSV, HoTen, MaPhong, TenPhong, NgayDK, NgayBD, NgayKT) VALUES
('DK001', 'SV001', N'Lê Văn Cường','P101',  N'Phòng 101','2024-09-01', '2024-09-05', '2025-09-05'),
('DK002', 'SV002',N'Trần Thị Diệu', 'P101',  N'Phòng 101','2024-08-15', '2024-08-20', '2025-08-20'),
('DK003', 'SV003', N'Phạm Minh Hoàng','P103',  N'Phòng 103','2024-10-01', '2024-10-10', '2025-10-10');
-- Thêm dữ liệu vào bảng HopDong
INSERT INTO HopDong (MaHD, MaSV, NgayKy, ThoiHan, TongTien) VALUES
('HD001', 'SV001', '2024-09-05', 12, 18000000), -- Hợp đồng của SV001
('HD002', 'SV002', '2024-08-20', 12, 21600000), -- Hợp đồng của SV002
('HD003', 'SV003', '2024-10-10', 12, 14400000); -- Hợp đồng của SV003



SELECT * FROM NhanVien;
SELECT * FROM Phong;
SELECT * FROM DienNuoc;
SELECT * FROM SinhVien;
SELECT * FROM DangKyPhong; 
SELECT * FROM HopDong;
SELECT Thang,Nam,SUM(ChiSoDien) AS TongChiSoDien,SUM(ChiSoNuoc) AS TongChiSoNuoc,SUM(TongTien) AS TongTienDienNuoc FROM DienNuoc GROUP BY Thang, Nam ORDER BY Nam, Thang;
SELECT MaPhong,TenPhong,TinhTrang,SoLuongSV,GiaPhong , case when TinhTrang =N'Còn chỗ' then 0 else 1 end as SoPhongDay,case when TinhTrang =N'Còn chỗ' then 1 else 0 end as SoPhongTrong From Phong
SELECT SUM(CASE WHEN GioiTinh = N'Nam' THEN 1 ELSE 0 END) AS TongSinhVienNam,SUM(CASE WHEN GioiTinh = N'Nữ' THEN 1 ELSE 0 END) AS TongSinhVienNu,COUNT(*) AS TongSinhVien FROM SinhVien;


drop table DangKyPhong
UPDATE DangKyPhong SET MaSV = 'SV003',HoTen = N'Pham Tuan Bao', MaPhong = 'P103',TenPhong = N'Phòng 103',NgayDK='2024-09-01',NgayBD='2024-09-05',NgayKT='2025-10-10' Where MaDK = 'DK003';




-- 