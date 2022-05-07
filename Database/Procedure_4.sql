USE QuanLyRapChieuPhim
GO

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
		where HOP_DONG_PHIM.MaPhim = PHIM.MaPhim and HOP_DONG.MaHopDong = HOP_DONG_PHIM.MaHopDong and HOP_DONG.MaNhaCungCap =  @MaNhaCungCap
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
