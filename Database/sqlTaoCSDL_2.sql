go
use QuanLyRapChieuPhim
go
--Bang The Loai Phim
Create table THE_LOAI_PHIM
(
	MaTheLoaiPhim varchar(6) primary key not null constraint IDTLP default dbo.AUTO_IDTLP(),
	TenTheLoaiPhim nvarchar(20)
)

--Bang Loai Nha Cung Cap
go
Create table LOAI_NHA_CUNG_CAP(
	MaLoaiNCC varchar(6) primary key not null constraint IDLNCC default dbo.AUTO_IDLOAINCC(),
	TenLoaiNCC nvarchar(40)
)
go
-- Bang Nha Cung Cap

Create table NHA_CUNG_CAP(
	MaNhaCungCap varchar(6) primary key not null constraint IDNCC default dbo.AUTO_IDNCC(),
	TenNhaCungCap nvarchar(40),
	MaSoThue varchar(10),
	DiaChi nvarchar(50),
	Email varchar(50),
	SoDienThoai varchar(15),
	TenGiamDoc nvarchar(30),
	MaLoaiNCC varchar(6) foreign key(MaLoaiNCC) references LOAI_NHA_CUNG_CAP
)
go
--Bang Hang san xuat phim

Create table HANG_SAN_XUAT_PHIM(
	MaHangSanXuatPhim varchar(9) primary key not null constraint IDHSXP default dbo.AUTO_IDHSXP(),
	TenHangSanXuatPhim nvarchar(30),
	Link text
)
go
--Bang Phim

Create table PHIM(
	MaPhim varchar(6) primary key not null constraint IDP default dbo.AUTO_IDP(),
	TenPhim nvarchar(50),
	AnhPhim image,
	ThoiLuong int,
	QuocGia nvarchar(20),
	NamSanXuat date,
	DoTuoiXem int,
	MaTheLoai varchar(6) foreign key(MaTheLoai) references THE_LOAI_PHIM,
	NoiDung ntext,
	MaHangSanXuatPhim varchar(9) foreign key(MaHangSanXuatPhim) references HANG_SAN_XUAT_PHIM
)
go

--Bang Dien Vien,Dao dien
Create table DIEN_VIEN_DAO_DIEN(
	MaDienVienDaoDien varchar(9) primary key not null constraint IDDVDD default dbo.AUTO_IDDVDD(),
	TenDienVienDaoDien nvarchar(30),
	Link text
)
go
--Bang Chi Tiet Dien Vien, Dao Dien Phim

Create table CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM
(
	MaPhim varchar(6) foreign key(MaPhim) references PHIM,
	MaDienVienDaoDien varchar(9) foreign key(MaDienVienDaoDien) references DIEN_VIEN_DAO_DIEN,
	VaiTro varchar(1) --(1) dien vien chinh (2) dien vien phu (3) dao dien
	constraint pk_CTDienVienDaoDien primary key(MaPhim,MaDienVienDaoDien)
)
go
create table LOAI_PHONG_CHIEU
(
	MaLoaiPhongChieu  varchar(6) primary key not null constraint IDLPC default dbo.AUTO_IDLOAIPHONGCHIEU(),
	TenLoaiPhongChieu nvarchar(40) 
)
-- Bang Phong Chieu
create table TINH_TRANG_PHONG_CHIEU
(
	MaTinhTrang  int identity(1,1) primary key not null,
	TenTinhTrang nvarchar(40) 
)
Create table PHONG_CHIEU(
	MaPhongChieu varchar(6) primary key not null constraint IDPC default dbo.AUTO_IDPC(),
	TenPhong nvarchar(20),
	MaTinhTrang int foreign key(MaTinhTrang) references TINH_TRANG_PHONG_CHIEU,
	MaLoaiPhongChieu  varchar(6) foreign key(MaLoaiPhongChieu) references LOAI_PHONG_CHIEU
)
go
--Bang Khung Gio Chieu

Create table KHUNG_GIO_CHIEU(
	MaKhungGioChieu varchar(8) primary key not null constraint IDKGC default dbo.AUTO_IDKGC(),
	TenKhungGio nvarchar(30),
	TGBatDau time,
	TGKetThuc time
)
go
--Bang Lich Chieu
Create table LICH_CHIEU(
	MaPhim varchar(6) foreign key(MaPhim) references PHIM,
	MaPhongChieu varchar(6) foreign key(MaPhongChieu) references PHONG_CHIEU,
	MaKhungGioChieu varchar(8) foreign key(MaKhungGioChieu) references KHUNG_GIO_CHIEU,
	NgayChieu date,
	TrangThai bit,
	constraint pk_LichChieu primary key(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu)
)
go
--Bang Ca Lam Viec

Create table CA_LAM_VIEC(
	MaCa varchar(6) primary key not null constraint IDCLV default dbo.AUTO_IDCLV(),
	TenCa nvarchar(40),
	GioBatDau time,
	GioKetThuc time
)
go
-- Bang Ngay Lam Viec
create table NGAY_LAM_VIEC
(
	MaNgayLamViec varchar(6) primary key not null constraint IDNLV default dbo.AUTO_IDNLV(),
	NgayLamViec date,
	MaCa varchar(6) foreign key (MaCa)references CA_LAM_VIEC
)
go
--Bang Chinh Sach
Create table CHINH_SACH(
	MaChinhSach varchar(6) primary key not null constraint IDCS default dbo.AUTO_IDCS(),
	HeSoLuong Float(4),
	BHXH varchar(20),
	TienThuong int
)
go
-- Bang Chuc Vu

Create table CHUC_VU(
	MaChucVu varchar(6) primary key not null constraint IDCV default dbo.AUTO_IDCV(),
	TenChucVu nvarchar(20)
)
go
--Bang Nhan Vien

Create table NHAN_VIEN(
	MaNhanVien varchar(6) primary key not null constraint IDNV default dbo.AUTO_IDNV(),
	TenNhanVien nvarchar(30),
	NgaySinh datetime,
	GioiTinh bit,
	DiaChi nvarchar(50),
	SoDienThoai varchar(15),
	CCCD varchar(20),
	TenTaiKhoan varchar(30),
	MatKhau varchar(32),
	Anh image,
	MaChinhSach varchar(6) foreign key(MaChinhSach) references CHINH_SACH,
	MaChucVu varchar(6) foreign key(MaChucVu) references CHUC_VU
)
go
--Bang Chi Tiet Ca Lam

Create table CHI_TIET_CA_LAM_VIEC(
	MaNhanVien varchar(6) foreign key(MaNhanVien) references NHAN_VIEN,
	MaCa varchar(6) foreign key(MaCa) references CA_LAM_VIEC,
	TrangThai bit,
	constraint pk_CTCaLamViec primary key(MaNhanVien,MaCa)
)
go
--Bang Loai Kho

Create table LOAI_KHO(
	MaLoaiKho varchar(5) primary key not null constraint IDLK default dbo.AUTO_IDLK(),
	TenLoaiKho nvarchar(15)
)
go
--Bang Kho

Create table KHO(
	MaKho varchar(5) primary key not null  constraint IDK default dbo.AUTO_IDK(),
	MaLoaiKho varchar(5) foreign key(MaLoaiKho) references LOAI_KHO,
	TenKho nvarchar(30)
)
go
--Bang Chi Tiet Kho Phim

Create table CHI_TIET_KHO_PHIM(
	MaKho varchar(5) foreign key (MaKho) references KHO,
	MaPhim varchar(6) foreign key(MaPhim) references PHIM,
	DonViTinh nvarchar(20),
	SoLuongSP int,
	constraint pk_CTKhoPhim primary key(MaKho,MaPhim)
)
go
--Bang Thuc An

Create table THUC_AN(
	MaThucAn varchar(6) primary key not null constraint IDTA default dbo.AUTO_IDTA(),
	TenThucAn nvarchar(30),
)
go
--Bang Vat Tu

Create table VAT_TU(
	MaVatTu varchar(6) primary key not null constraint IDVT default dbo.AUTO_IDVT(),
	TenVatTu nvarchar(30)
)
go
--Bang Chi Tiet Kho Vat Tu

Create table CHI_TIET_KHO_VT(
	MaKho varchar(5) foreign key (MaKho) references KHO,
	MaVatTu varchar(6) foreign key(MaVatTu) references VAT_TU,
	DonViTinh nvarchar(20),
	SoLuongSP int,
	constraint pk_CTKhoVatTu primary key(MaKho,MaVatTu)
)
go
--Bang Chi Tiet Kho Thuc An

Create table CHI_TIET_KHO_THUC_AN(
	MaKho varchar(5) foreign key (MaKho) references KHO,
	MaThucAn varchar(6) foreign key(MaThucAn) references THUC_AN,
	DonViTinh nvarchar(20),
	SoLuongSP int,
	constraint pk_CTKhoThucAn primary key(MaKho,MaThucAn)
)
go
--Bang Loai De Xuat

Create table LOAI_DE_XUAT(
	MaLoaiDeXuat varchar(5) primary key constraint IDLDX default dbo.AUTO_IDLDX(),
	TenLoaiDeXuat nvarchar(30)
)
go
--Bang De Xuat

Create table DE_XUAT(
	MaDeXuat varchar(6) primary key not null constraint IDDX default dbo.AUTO_IDDX(),
	MaNhanVien varchar(6) foreign key(MaNhanVien) references NHAN_VIEN,
	NgayDeXuat Date,
	MaLoaiDeXuat varchar(5) foreign key(MaLoaiDeXuat) references LOAI_DE_XUAT,
)
go
--Bang Chi Tiet De Xuat Phim

Create table CHI_TIET_DE_XUAT_PHIM(
	MaDeXuat varchar(6) foreign key(MaDeXuat) references DE_XUAT,
	MaPhim varchar(6) foreign key(MaPhim) references PHIM,
	Noidung ntext,
	SoLuong int,
	DonViTinh nvarchar(20),
	TinhTrang varchar(1),
	constraint pk_CTDeXuatPhim primary key(MaDeXuat,MaPhim)
)
go
--Bang Chi Tiet De Xuat Thuc An

Create table CHI_TIET_DE_XUAT_TA(
	MaDeXuat varchar(6) foreign key(MaDeXuat) references DE_XUAT,
	MaThucAn varchar(6) foreign key(MaThucAn) references THUC_AN,
	Noidung ntext,
	SoLuong int,
	DonViTinh nvarchar(20),
	TinhTrang varchar(1),
	constraint pk_CTDeXuatTA primary key(MaDeXuat,MaThucAn)
)
go
--Bang Chi Tiet De Xuat Vat Tu

Create table CHI_TIET_DE_XUAT_VT(
	MaDeXuat varchar(6) foreign key(MaDeXuat) references DE_XUAT,
	MaVatTu varchar(6) foreign key(MaVatTu) references VAT_TU,
	Noidung ntext,
	SoLuong int,
	DonViTinh nvarchar(20),
	TinhTrang varchar(1),
	constraint pk_CTDeXuatVT primary key(MaDeXuat,MaVatTu)
)
go
-- Bang Loai Phieu

Create table LOAI_PHIEU(
	MaLoaiPhieu varchar(5) primary key not null constraint IDLP default dbo.AUTO_IDLP(),
	TenLoaiPhieu nvarchar(30)
)
go
--Bang Phieu

Create table PHIEU(
	MaPhieu varchar(6) primary key not null constraint IDPH default dbo.AUTO_IDPH(), 
	MaLoaiPhieu varchar(5) foreign key(MaLoaiPhieu) references LOAI_PHIEU,
	MaKho varchar(5) foreign key(MaKho) references KHO,
	MaNhanVien varchar(6) foreign key(MaNhanVien) references NHAN_VIEN,
	NgayLapPhieu date
)
go
--Bang Chi Tiet Phieu Phim
Create table CHI_TIET_PHIEU_PHIM(
	MaPhieu varchar(6) foreign key(MaPhieu) references PHIEU,
	MaPhim varchar(6) foreign key(MaPhim) references PHIM,
	DonViTinh nvarchar(20),
	SoLuong int,
	constraint pk_CTPhieuPhim primary key(MaPhieu,MaPhim)
)
go
--Bang Chi Tiet Phieu Vat Tu

Create table CHI_TIET_PHIEU_VT(
	MaPhieu varchar(6) foreign key(MaPhieu) references PHIEU,
	MaVatTu varchar(6) foreign key(MaVatTu) references VAT_TU,
	DonViTinh nvarchar(20),
	SoLuong int,
	constraint pk_CTPhieuVatTu primary key(MaPhieu,MaVatTu)
)
go
--Bang Chi Tiet Phieu Thuc An

Create table CHI_TIET_PHIEU_THUC_AN(
	MaPhieu varchar(6) foreign key(MaPhieu) references PHIEU,
	MaThucAn varchar(6) foreign key(MaThucAn) references THUC_AN,
	DonViTinh nvarchar(20),
	SoLuong int,
	NgayHetHang date,
	constraint pk_CTPhieuThucAn primary key(MaPhieu,MaThucAn)
)
go
-- Bảng loại Hợp đồng

create table LOAI_HOP_DONG
(
	MaLoaiHopDong varchar(6) primary key not null constraint IDLHD default dbo.AUTO_IDLOAIHOPDONG(), 
	TenLoaiHopDong nvarchar(50) not null
)
go
--- Bảng Hợp đồng
create table HOP_DONG
(
	MaHopDong varchar(6) primary key not null  constraint IDHD default dbo.AUTO_IDHOPDONG(), 
	TenHopDong nvarchar(50),
	MaNhaCungCap varchar(6) foreign key(MaNhaCungCap) references NHA_CUNG_CAP,
	NgayKiKetHD date,
	MaLoaiHopDong varchar(6) foreign key (MaLoaiHopDong) references LOAI_HOP_DONG
)
go

--Bang Chi Tiet Cung Cap Vat Tu

Create table HOP_DONG_VAT_TU(
	MaHopDong varchar(6) foreign key(MaHopDong) references HOP_DONG,
	MaVatTu varchar(6) foreign key(MaVatTu) references VAT_TU,
	GiaTien money,
	DonViTinh nvarchar(30),
	SoLuong int,
	constraint pk_HopDongVatTu primary key(MaVatTu,MaHopDong)
)
go
--Bang Chi Tiet Cung Cap Thuc An

Create table HOP_DONG_THUC_AN(
	MaHopDong varchar(6) foreign key(MaHopDong) references HOP_DONG,
	MaThucAn varchar(6) foreign key(MaThucAn) references THUC_AN,
	GiaTien money,
	DonViTinh nvarchar(30),
	SoLuong int,
	constraint pk_HopDongThucAn primary key(MaThucAn,MaHopDong)
)
go
-- Bang Hop Dong Phim
Create table HOP_DONG_PHIM(
	MaHopDong varchar(6) foreign key(MaHopDong) references HOP_DONG,
	MaPhim varchar(6) foreign key(MaPhim) references PHIM,
	PhienBan varchar(1),			-- 0:Phiên bản mới nhất, 1: Phiên bản cũ .....
	NgayBatDauBanQuyen date,
	NgayKetThucBanQuyen date,
	Donvitinh nvarchar(15),
	SoLuong int,
	GiaTien money,
	constraint pk_HopDongPhim primary key(MaHopDong,MaPhim, PhienBan)
)

go
--Bang Chi Tiet Vat tu trong  Phong Chieu

Create table CHI_TIET_PHONG_CHIEU(
	MaPhongChieu varchar(6) foreign key(MaPhongChieu) references PHONG_CHIEU,
	MaVatTu varchar(6) foreign key(MaVatTu) references VAT_TU,
	DonViTinh nvarchar(30),
	SoLuongSP int,
	constraint pk_CTPhongChieu primary key(MaPhongChieu,MaVatTu)
)
go

create table PHIEU_NHAP_VAT_TU_VAO_PHONG_CHIEU
(
	MaPhieuNhap varchar(6) primary key not null
	MaPhongChieu varchar(6) foreign key(MaPhongChieu) references PHONG_CHIEU,
	MaNhanVien varchar(6) foreign key(MaNhanVien) references NHAN_VIEN,
	NgayLapPhieu date
)
create table CHI_TIET_PHIEU_NHAP_VT_VAO_PC
(
	MaPhongChieu varchar(6) foreign key(MaPhongChieu) references PHONG_CHIEU,
	MaVatTu varchar(6) foreign key(MaVatTu) references VAT_TU,
	DonViTinh nvarchar(30),
	SoLuongSP int,
	constraint pk_CTNhapVTVaoPhongChieu primary key(MaPhongChieu,MaVatTu)
)
