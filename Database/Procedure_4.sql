use QuanLyRapChieuPhim
go
-- Chuc nang Quan ly nha cung cap - Admin
CREATE PROCEDURE ThemNhaCungCap
	@TenNhaCungCap nvarchar(40),
	@MaSoThue varchar(15),
	@DiaChi nvarchar(50),
	@Email varchar(50),
	@SoDienThoai varchar(15),
	@TenGiamDoc nvarchar(30),
	@MaLoaiNCC varchar(6) 
AS
BEGIN
	insert into NHA_CUNG_CAP(TenNhaCungCap,MaSoThue,DiaChi,Email,SoDienThoai,TenGiamDoc,MaLoaiNCC)
	VALUES (@TenNhaCungCap, @MaSoThue, @DiaChi,@Email, @SoDienThoai, @TenGiamDoc, @MaLoaiNCC )
END
GO
create proc CapNhatNhaCungCap
	@MaNhaCungCap varchar(6),
	@TenNhaCungCap nvarchar(40),
	@MaSoThue varchar(15),
	@DiaChi nvarchar(50),
	@Email varchar(50),
	@SoDienThoai varchar(15),
	@TenGiamDoc nvarchar(30),
	@MaLoaiNCC varchar(6) 
AS
Begin
	Update NHA_CUNG_CAP 
	set TenNhaCungCap = @TenNhaCungCap,MaSoThue = @MaSoThue,
	DiaChi = @DiaChi,Email = @Email,SoDienThoai = @SoDienThoai,TenGiamDoc = @TenGiamDoc,MaLoaiNCC = @MaLoaiNCC
	where MaNhaCungCap = @MaNhaCungCap
end

go
create Proc LaySanPhamByMaNhaCungCap
	@MaNhaCungCap varchar(6),
	@MaLoaiNhaCungCap varchar(6)
as
begin
	if(@MaLoaiNhaCungCap = 'LNCC01')
	(
		select PHIM.MaPhim, PHIM.TenPhim, HOP_DONG_PHIM.SoLuong, HOP_DONG_PHIM.Donvitinh, HOP_DONG_PHIM.GiaTien
		from HOP_DONG_PHIM, PHIM, HOP_DONG
		where HOP_DONG_PHIM.MaPhim = PHIM.MaPhim and HOP_DONG.MaHopDong = HOP_DONG_PHIM.MaHopDong and HOP_DONG.MaNhaCungCap =  @MaNhaCungCap and HOP_DONG_PHIM.PhienBan='0'
	)
	if(@MaLoaiNhaCungCap = 'LNCC02')
	(
		select VAT_TU.MaVatTu, VAT_TU.TenVatTu, ct.SoLuong, ct.DonViTinh, ct.GiaTien
		from HOP_DONG_VAT_TU ct, VAT_TU, HOP_DONG
		where ct.MaVatTu = VAT_TU.MaVatTu and ct.MaHopDong = HOP_DONG.MaHopDong and HOP_DONG.MaNhaCungCap =  @MaNhaCungCap
	)
	if(@MaLoaiNhaCungCap = 'LNCC03')
	(
		
		select THUC_AN.MaThucAn, THUC_AN.TenThucAn, ct.SoLuong, ct.DonViTinh, ct.GiaTien
		from HOP_DONG_THUC_AN ct, THUC_AN,  HOP_DONG
		where  ct.MaHopDong = HOP_DONG.MaHopDong  and THUC_AN.MaThucAn =ct.MaThucAn and HOP_DONG.MaNhaCungCap =  @MaNhaCungCap
	)
end
-- Chuc nang quan lt hop dong
go
create Proc ThemHopDong
	@TenHopDong nvarchar(50),
	@MaNhaCungCap varchar(6) ,
	@NgayKiKetHD date,
	@MaLoaiHopDong varchar(6) 
as
begin
	insert into HOP_DONG(TenHopDong ,MaNhaCungCap ,NgayKiKetHD , MaLoaiHopDong) values (@TenHopDong ,@MaNhaCungCap ,@NgayKiKetHD , @MaLoaiHopDong);
end
go

---- hd phim
create Proc ThemHopDongPhim
	@MaHopDong varchar(6),
	@MaPhim varchar(6),
	@PhienBan varchar(1),
	@NgayBatDauBanQuyen date,
	@NgayKetThucBanQuyen date,
	@Donvitinh nvarchar(15),
	@SoLuong int,
	@GiaTien money
as
begin
	insert into HOP_DONG_PHIM(MaHopDong,MaPhim,PhienBan,NgayBatDauBanQuyen,NgayKetThucBanQuyen,Donvitinh,SoLuong,GiaTien)
	values (@MaHopDong,@MaPhim,@PhienBan,@NgayBatDauBanQuyen,@NgayKetThucBanQuyen,@Donvitinh,@SoLuong,@GiaTien);
end
go
create Proc CapNhatHopDongPhim
	@MaHopDong varchar(6),
	@MaPhim varchar(6),
	@PhienBan varchar(1),
	@NgayBatDauBanQuyen date,
	@NgayKetThucBanQuyen date,
	@Donvitinh nvarchar(15),
	@SoLuong int,
	@GiaTien money
as
begin
	update HOP_DONG_PHIM
	set PhienBan = @PhienBan
	where MaHopDong = @MaHopDong and MaPhim = @MaPhim and PhienBan = 0

	insert into HOP_DONG_PHIM(MaHopDong,MaPhim,PhienBan,NgayBatDauBanQuyen,NgayKetThucBanQuyen,Donvitinh,SoLuong,GiaTien)
	values (@MaHopDong,@MaPhim,0,@NgayBatDauBanQuyen,@NgayKetThucBanQuyen,@Donvitinh,@SoLuong,@GiaTien);
end
go

create proc LayMaPhienBanHopDongPhimLonNhat
	@MaHopDong varchar(6),
	@MaPhim varchar(6)
as
begin
select COUNT(PhienBan)
from HOP_DONG_PHIM
where MaPhim = @MaPhim and MaHopDong = @MaHopDong
end
-- hp thuc an
go

create Proc ThemHopDongThucAn
	@MaHopDong varchar(6),
	@MaThucAn varchar(6),
	@Donvitinh nvarchar(15),
	@SoLuong int,
	@GiaTien money
as
begin
	insert into HOP_DONG_THUC_AN (MaHopDong,MaThucAn,Donvitinh,SoLuong,GiaTien)
	values (@MaHopDong,@MaThucAn,@Donvitinh,@SoLuong,@GiaTien);
end
go

-- hp vattu
go

create Proc ThemHopDongVatTu
	@MaHopDong varchar(6),
	@MaVatTu varchar(6),
	@Donvitinh nvarchar(15),
	@SoLuong int,
	@GiaTien money
as
begin
	insert into HOP_DONG_VAT_TU(MaHopDong,MaVatTu,Donvitinh,SoLuong,GiaTien)
	values (@MaHopDong,@MaVatTu,@Donvitinh,@SoLuong,@GiaTien);
end
go

--- dang nhap
create proc KiemTraDangNhap
	@TenTaiKhoan varchar(30),
	@MatKhau varchar(32)
as
begin
    if exists (select * from NHAN_VIEN where TenTaiKhoan = @TenTaiKhoan and MatKhau = @MatKhau and MaChucVu = 'CV0003')	-- admin
        select 3 as code
    else if exists (select * from NHAN_VIEN where TenTaiKhoan = @TenTaiKhoan and MatKhau = @MatKhau and MaChucVu = 'CV0002') -- vattu
        select 2 as code
    else if exists (select * from NHAN_VIEN where TenTaiKhoan = @TenTaiKhoan and MatKhau = @MatKhau and MaChucVu = 'CV0001') -- phim
        select 1 as code
	else if exists (select * from NHAN_VIEN where TenTaiKhoan = @TenTaiKhoan and MatKhau != @MatKhau)
        select 0 as code
    else select -1 as code
end
--- them nhan vien
go
create proc themnhanvien

@TenNhanVien nvarchar(30),@NgaySinh datetime,
	@GioiTinh bit,
	@DiaChi nvarchar(50),
	@SoDienThoai varchar(15),
	@CCCD varchar(20),
	@TenTaiKhoan varchar(30),
	@MatKhau varchar(32),
	@MaChinhSach varchar(6) ,
	@MaChucVu varchar(6) 
	as 
	begin 
	insert into NHAN_VIEN(TenNhanVien,NgaySinh,GioiTinh,DiaChi,SoDienThoai,CCCD,TenTaiKhoan,MatKhau,MaChinhSach,MaChucVu)--987654321
Values (@TenNhanVien,@NgaySinh,@GioiTinh,@DiaChi,@SoDienThoai,@CCCD,@TenTaiKhoan,@MatKhau,@MaChinhSach,@MaChucVu);
end
---cap nhat nhan vien
go
create proc CapNhatNhanVien
    @MaNhanVien varchar(6),
    @TenNhanVien nvarchar(30),
    @NgaySinh datetime,
	@GioiTinh bit,
	@DiaChi nvarchar(50),
	@SoDienThoai varchar(15),
	@CCCD varchar(20),
	@TenTaiKhoan varchar(30),
	@MatKhau varchar(32),
	@MaChinhSach varchar(6) ,
	@MaChucVu varchar(6) 
	as 
	begin 
	update  NHAN_VIEN set TenNhanVien=@TenNhanVien,GioiTinh=@GioiTinh,NgaySinh=@NgaySinh,DiaChi=@DiaChi,SoDienThoai=@SoDienThoai,CCCD=@CCCD,TenTaiKhoan=@TenTaiKhoan,MatKhau=@MatKhau,MaChinhSach=@MaChinhSach,MaChucVu=@MaChucVu
where MaNhanVien=@MaNhanVien
end
go
-- Add CHi tiet phong chieu
create proc ThemChiTietPhongChieu
	@MaPhongChieu varchar(6),
	@MaVatTu varchar(6),
	@DonViTinh nvarchar(30),
	@SoLuongSP int
as
begin 
	insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
	values (@MaPhongChieu,@MaVatTu,@DonViTinh,@SoLuongSP)
end
go
-- CapNhat chi tiet phong chieu
create proc CapNhatChiTietPhongChieu
	@MaPhongChieu varchar(6),
	@MaVatTu varchar(6),
	@DonViTinh nvarchar(30),
	@SoLuongSP int
as
begin 
	Update CHI_TIET_PHONG_CHIEU set DonViTinh = @DonViTinh ,SoLuongSP = @SoLuongSP
	where MaVatTu = @MaVatTu and MaPhongChieu = @MaPhongChieu
end

go
-------------------------------
-- them VatTuVaoKho
create proc ThemChiTietKhoVatTu
	@MaKho varchar(5),
	@MaVatTu varchar(6),
	@DonViTinh nvarchar(20),
	@SoLuongSP int
as
begin
	insert into CHI_TIET_KHO_VT(MaKho,MaVatTu,DonViTinh,SoLuongSP) values(@MaKho,@MaVatTu,@DonViTinh,@SoLuongSP)
end
go
--CapNhatChiTietKhoVatTu
create proc CapNhatChiTietKhoVatTu
	@MaKho varchar(5),
	@MaVatTu varchar(6),
	@DonViTinh nvarchar(20),
	@SoLuongSP int
as
begin
	update CHI_TIET_KHO_VT set DonViTinh = @DonViTinh ,SoLuongSP = @SoLuongSP 
	where  MaKho =@MaKho and MaVatTu = @MaVatTu
end
go

-- Them phong chieu
create proc ThemPhongChieu
	@TenPhong nvarchar(20),
	@MaTinhTrang int,
	@MaLoaiPhongChieu  varchar(6)
as
begin
	insert into PHONG_CHIEU(TenPhong,MaTinhTrang, MaLoaiPhongChieu) values (@TenPhong, @MaTinhTrang, @MaLoaiPhongChieu)
end
go
-- CapNhatPhongChieu
create proc CapNhatPhongChieu
	@MaPhongChieu varchar(6),
	@TenPhong nvarchar(20),
	@MaTinhTrang int
as
begin
	Update PHONG_CHIEU set	TenPhong = @TenPhong,	MaTinhTrang = @MaTinhTrang
	where MaPhongChieu = @MaPhongChieu
end
---CapNhatLichChieu
create proc CapNhatLichChieu
	@MaPhim varchar(6), 
	@MaPhongChieu varchar(6),
	@MaKhungGio varchar(8),
	@NgayChieu date,
	@TrangThai varchar(1)
as
begin
	Update LICH_CHIEU set	MaPhongChieu = @MaPhongChieu , MaKhungGioChieu=@MaKhungGio , NgayChieu=@NgayChieu ,	TrangThai = @TrangThai
	where MaPhim = @MaPhim
end