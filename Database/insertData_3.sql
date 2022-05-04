go
use QuanLyRapChieuPhim
go
------1. Thể loại phim
insert into THE_LOAI_PHIM (TenTheLoaiPhim) values (N'Hài');
insert into THE_LOAI_PHIM (TenTheLoaiPhim) values (N'Cổ trang');
insert into THE_LOAI_PHIM (TenTheLoaiPhim) values (N'Tình cảm');
insert into THE_LOAI_PHIM (TenTheLoaiPhim) values (N'Kinh dị');
insert into THE_LOAI_PHIM (TenTheLoaiPhim) values (N'Phiêu lưu mạo hiểm');
insert into THE_LOAI_PHIM (TenTheLoaiPhim) values (N'Khoa học viễn tưởng');
------2. Loại nhà cung cấp
insert into LoaiNhaCungCap(TenLoaiNCC) values (N'Phim');
insert into LoaiNhaCungCap(TenLoaiNCC) values (N'Vật tư');
insert into LoaiNhaCungCap(TenLoaiNCC) values (N'Thức ăn nhanh');
------3. Nhà cung cấp
insert into NHA_CUNG_CAP(TenNhaCungCap,MaSoThue,DiaChi,Email,SoDienThoai,TenGiamDoc,MaLoaiNCC)
values (N'Tân Quang Dũng','CC001',N'Đông Hà','tanquangdung@gmail.com','0973977821',N'Trần Trung Hiếu','LNCC01');
insert into NHA_CUNG_CAP(TenNhaCungCap,MaSoThue,DiaChi,Email,SoDienThoai,TenGiamDoc,MaLoaiNCC)
values (N'Hoàng Hải','CC002',N'Huế','hoanghai@gmail.com','0943923821',N'Trần Đình Trọng','LNCC01');
insert into NHA_CUNG_CAP(TenNhaCungCap, MaSoThue,DiaChi,Email,SoDienThoai,TenGiamDoc,MaLoaiNCC)
values (N'Minh Mập','CC003',N'Đà Nẵng','minhmap@gmail.com','0943286932',N'Lê Văn Hào','LNCC02');
insert into NHA_CUNG_CAP(TenNhaCungCap,MaSoThue,DiaChi,Email,SoDienThoai,TenGiamDoc,MaLoaiNCC)
values (N'Hải Quỳnh','CC004',N'Quảng Nam','haiquynh@gmail.com','0992737521',N'Phạm Phú Trung','LNCC03');
insert into NHA_CUNG_CAP(TenNhaCungCap,MaSoThue,DiaChi,Email,SoDienThoai,TenGiamDoc,MaLoaiNCC)
values (N'Tân Quang Dũng','CC005',N'Đông Hà','fptdung@gmail.com','0973989821',N'Trần Trung Hiếu','LNCC01');
------4. Mô tả phim

-----5. Phim P00001
insert into PHIM (TenPhim,AnhPhim,ThoiLuong,QuocGia,NamSanXuat,TenHangPhim ,DoTuoiXem,MaTheLoai ,NoiDung,DienVienChinh,DienVienPhu,DaoDien) values
(N'Gia đình đức hạnh',null,'90',N'Thái Lan','2020-12-22',N'K Entertainment',18,'TLP001','Noi dung1', N'Lưu Học Nghĩa', N'Tôn Trung Sơn', N'Uông Tàng Hải');
insert into PHIM (TenPhim,AnhPhim,ThoiLuong,QuocGia,NamSanXuat,TenHangPhim ,DoTuoiXem,MaTheLoai ,NoiDung,DienVienChinh,DienVienPhu,DaoDien) values
(N'Mắt Biếc',null,'97',N'Việt Nam','2020-12-22',N'Hao Entertainment',18,'TLP003','Kể về câu chuyện giữa Ngạn và Hà Lan', N'Phạm Khắc Luận', N'Trần Trung Hiếu', N'Nguyễn Ánh');
insert into PHIM (TenPhim,AnhPhim,ThoiLuong,QuocGia,NamSanXuat,TenHangPhim ,DoTuoiXem,MaTheLoai ,NoiDung,DienVienChinh,DienVienPhu,DaoDien) values
(N'Nhà có khách',null,'90',N'Việt Nam','2021-12-22',N'BH Media',18,'TLP001','Noi dung 2', N'Trần Văn Hữu', N'Phạm Khắc Luận', N'Lê Văn Hào');
insert into PHIM (TenPhim,AnhPhim,ThoiLuong,QuocGia,NamSanXuat,TenHangPhim ,DoTuoiXem,MaTheLoai ,NoiDung,DienVienChinh,DienVienPhu,DaoDien) values
(N'Em chưa 18',null,'90',N'Việt Nam','2019-12-20',N'Star Entertainment',18,'TLP003','Noi dung1', N'Lưu Học Nghĩa', N'Tôn Trung Sơn', N'Đặng Tiểu Bình');
insert into PHIM (TenPhim,AnhPhim,ThoiLuong,QuocGia,NamSanXuat,TenHangPhim ,DoTuoiXem,MaTheLoai ,NoiDung,DienVienChinh,DienVienPhu,DaoDien) values
(N'Bố già',null,'90',N'Việt Nam','2020-12-22',N'K Entertainment',18,'TLP001','Noi dung1', N'Trấn Thành', N'Tuấn Trần', N'Trấn Thành');
insert into PHIM (TenPhim,AnhPhim,ThoiLuong,QuocGia,NamSanXuat,TenHangPhim ,DoTuoiXem,MaTheLoai ,NoiDung,DienVienChinh,DienVienPhu,DaoDien) values
(N'Bẫy ngọt ngào',null,'90',N'Thái Lan','2020-09-22',N'K Entertainment',18,'TLP003','Noi dung1', N'Lưu Học Nghĩa', N'Tôn Trung Sơn', N'Uông Tàng Hải');
------6. Hợp đồng phim
insert into HOP_DONG_PHIM(MaNhaCungCap,MaPhim,NgayKiKetHD,NgayBatDauBanQuyen,NgayKetThucBanQuyen,Donvitinh,SoLuong,GiaTien)
values ('NCC001','P00001','2020-12-28','2020-12-30','2022-12-30',N'Đĩa','10','20000');
insert into HOP_DONG_PHIM(MaNhaCungCap,MaPhim,NgayKiKetHD,NgayBatDauBanQuyen,NgayKetThucBanQuyen,Donvitinh,SoLuong,GiaTien)
values ('NCC002','P00002','2020-09-15','2020-09-17','2022-09-17',N'Đĩa','8','15000');
insert into HOP_DONG_PHIM(MaNhaCungCap,MaPhim,NgayKiKetHD,NgayBatDauBanQuyen,NgayKetThucBanQuyen,Donvitinh,SoLuong,GiaTien)
values ('NCC002','P00003','2020-07-20','2020-07-22','2022-07-22',N'Đĩa','10','17000');
-----7. Phòng chiếu PC0001
insert into PHONG_CHIEU(TenPhong,TinhTrangPhong) values (N'Phòng số 1','0');
insert into PHONG_CHIEU(TenPhong,TinhTrangPhong) values (N'Phòng số 2','1');
insert into PHONG_CHIEU(TenPhong,TinhTrangPhong) values (N'Phòng số 3','1');
insert into PHONG_CHIEU(TenPhong,TinhTrangPhong) values (N'Phòng số 4','0');
insert into PHONG_CHIEU(TenPhong,TinhTrangPhong) values (N'Phòng số 5','1');
------8. Khung giờ chiếu KGC00001
insert into KHUNG_GIO_CHIEU(TenKhungGio,TGBatDau,TGKetThuc) values(N'Khung giờ số 1','08:00:00.0000000','11:00:00.0000000');
insert into KHUNG_GIO_CHIEU(TenKhungGio,TGBatDau,TGKetThuc) values(N'Khung giờ số 2','11:00:00.0000000','14:00:00.0000000');
insert into KHUNG_GIO_CHIEU(TenKhungGio,TGBatDau,TGKetThuc) values(N'Khung giờ số 3','14:00:00.0000000','17:00:00.0000000');
------9.Lịch chiếu
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,TrangThai) VALUES('P00001','PC0002','KGC00001','1');
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,TrangThai) VALUES('P00002','PC0003','KGC00002','0');
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,TrangThai) VALUES('P00003','PC0005','KGC00003','1');
------10.Ca làm việc CLV0001
insert into CA_LAM_VIEC(TenCa,GioBatDau,GioKetThuc) values(N'Ca Sáng','08:00:00.0000000','11:00:00.0000000');
insert into CA_LAM_VIEC(TenCa,GioBatDau,GioKetThuc) values(N'Ca chiều','11:00:00.0000000','14:00:00.0000000');
insert into CA_LAM_VIEC(TenCa,GioBatDau,GioKetThuc) values(N'Ca tối','14:00:00.0000000','17:00:00.0000000');
------10.1 Ngay Lam Viec NLV001
insert into NGAY_LAM_VIEC(NgayLamViec,MaCa) values('2022-01-29','CLV001');
insert into NGAY_LAM_VIEC(NgayLamViec,MaCa) values('2022-02-28','CLV002');
insert into NGAY_LAM_VIEC(NgayLamViec,MaCa) values('2022-03-25','CLV003');
------11. Chính sách CS0001
insert into CHINH_SACH(HeSoLuong,BHXH,TienThuong) values ('1','XH001020201','200000');
insert into CHINH_SACH(HeSoLuong,BHXH,TienThuong) values ('2','XH001220311','300000');
insert into CHINH_SACH(HeSoLuong,BHXH,TienThuong) values ('3','XH998820201','100000');
-----12.Chức vụ CV0001
insert into CHUC_VU(TenChucVu) values (N'Quản lý vật tư');
insert into CHUC_VU(TenChucVu) values (N'Quản lý phim');
insert into CHUC_VU(TenChucVu) values (N'Quản trị viên');
------13.Nhân viên NV0001
insert into NHAN_VIEN(TenNhanVien,NgaySinh,GioiTinh,DiaChi,SoDienThoai,CCCD,TenTaiKhoan,MatKhau,MaChinhSach,MaChucVu)
Values (N'Trần Trung Hiếu','2002-03-01','0',N'Quảng Trị','0982782647','9283920102392','trantrunghieu001','987654321','CS0001','CV0001');
insert into NHAN_VIEN(TenNhanVien,NgaySinh,GioiTinh,DiaChi,SoDienThoai,CCCD,TenTaiKhoan,MatKhau,MaChinhSach,MaChucVu)
Values (N'Lê Văn Hào','2002-02-22','0',N'QHuế','0827582932','9280000002392','levanhao002','123456789','CS0002','CV0002');
insert into NHAN_VIEN(TenNhanVien,NgaySinh,GioiTinh,DiaChi,SoDienThoai,CCCD,TenTaiKhoan,MatKhau,MaChinhSach,MaChucVu)
Values (N'Phạm Khắc Luận','2002-04-20','0',N'Huế','0982792837','9280009918892','phamkhacluan003','123456789','CS0003','CV0002');
------14. Chi tiết ca làm việc
insert into CHI_TIET_CA_LAM_VIEC(MaNhanVien,MaCa,TrangThai) values ('NV0001','CLV001','1');
insert into CHI_TIET_CA_LAM_VIEC(MaNhanVien,MaCa,TrangThai) values ('NV0002','CLV002','0');
insert into CHI_TIET_CA_LAM_VIEC(MaNhanVien,MaCa,TrangThai) values ('NV0003','CLV003','1');
------15. Loại kho LK001
insert into LOAI_KHO(TenLoaiKho) values (N'Thức ăn nhanh');
insert into LOAI_KHO(TenLoaiKho) values (N'Vật tư');
insert into LOAI_KHO(TenLoaiKho) values (N'Phim');
------16. Kho K0001
insert into KHO(MaLoaiKho,TenKho) values ('LK001',N'Kho số 1');
insert into KHO(MaLoaiKho,TenKho) values ('LK002',N'Kho số 2');
insert into KHO(MaLoaiKho,TenKho) values ('LK002',N'Kho số 3');
insert into KHO(MaLoaiKho,TenKho) values ('LK003',N'Kho số 4');
-----17. Chi tiết kho phim
insert into CHI_TIET_KHO_PHIM(MaKho,MaPhim,DonViTinh,SoLuongSP) values ('K0004','P00001',N'Bộ','1');
insert into CHI_TIET_KHO_PHIM(MaKho,MaPhim,DonViTinh,SoLuongSP) values ('K0004','P00002',N'Bộ','2');
insert into CHI_TIET_KHO_PHIM(MaKho,MaPhim,DonViTinh,SoLuongSP) values ('K0004','P00003',N'Bộ','1');
insert into CHI_TIET_KHO_PHIM(MaKho,MaPhim,DonViTinh,SoLuongSP) values ('K0001','P00002',N'Bộ','1');
insert into CHI_TIET_KHO_PHIM(MaKho,MaPhim,DonViTinh,SoLuongSP) values ('K0001','P00004',N'Bộ','2');
insert into CHI_TIET_KHO_PHIM(MaKho,MaPhim,DonViTinh,SoLuongSP) values ('K0001','P00005',N'Bộ','1');
-----18. Thức ăn TA0001
insert into THUC_AN(TenThucAn) values (N'Bắp ngô');
insert into THUC_AN(TenThucAn) values (N'Cocacola');
insert into THUC_AN(TenThucAn) values (N'Kẹo');
-----19. Vật tư VT0001
insert into VAT_TU(TenVatTu) values (N'Đèn sáng');
insert into VAT_TU(TenVatTu) values (N'Ghế');
insert into VAT_TU(TenVatTu) values (N'Điều hòa');
insert into VAT_TU(TenVatTu) values (N'Máy chiếu');
insert into VAT_TU(TenVatTu) values (N'Loa');
----20. Chi tiết kho vật tư
insert into CHI_TIET_KHO_VT(MaKho,MaVatTu,DonViTinh,SoLuongSP) values('K0002','VT0001',N'Cái','12');
insert into CHI_TIET_KHO_VT(MaKho,MaVatTu,DonViTinh,SoLuongSP) values('K0002','VT0002',N'Cái','10');
insert into CHI_TIET_KHO_VT(MaKho,MaVatTu,DonViTinh,SoLuongSP) values('K0003','VT0003',N'Cái','5');
----21. Chi tiết kho thức ăn
insert into CHI_TIET_KHO_THUC_AN(MaKho,MaThucAn,DonViTinh,SoLuongSP) values('K0001','TA0001',N'Gói','100');
insert into CHI_TIET_KHO_THUC_AN(MaKho,MaThucAn,DonViTinh,SoLuongSP) values('K0001','TA0002',N'Thùng','20');
insert into CHI_TIET_KHO_THUC_AN(MaKho,MaThucAn,DonViTinh,SoLuongSP) values('K0001','TA0003',N'Gói','200');
---22. Loại đề xuất LDX01
insert into LOAI_DE_XUAT(TenLoaiDeXuat) values (N'Đề xuất phim');
insert into LOAI_DE_XUAT(TenLoaiDeXuat) values (N'Đề xuất vật tư');
insert into LOAI_DE_XUAT(TenLoaiDeXuat) values (N'Đề xuất thức ăn nhanh');
---23. Đề xuất DX0001
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat,MaKho)
values ('NV0001','2022-01-02','LDX02','K0002');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat,MaKho)
values ('NV0001','2022-02-02','LDX02','K0003');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat,MaKho)
values ('NV0002','2022-03-02','LDX01','K0004');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat,MaKho)
values ('NV0003','2022-04-02','LDX01','K0004');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat,MaKho)
values ('NV0001','2022-06-02','LDX03','K0001');
----24. Chi tiết đề xuất phim
insert into CHI_TIET_DE_XUAT_PHIM(MaDeXuat,MaPhim,Noidung,TinhTrang)
values ('DX0003','P00001',N'Đề nghị thêm bộ phim này','0');
insert into CHI_TIET_DE_XUAT_PHIM(MaDeXuat,MaPhim,Noidung,TinhTrang)
values ('DX0004','P00002',N'Đề nghị xóa bộ phim này','0');
----25. Chi tiết đề xuất thức ăn
insert into CHI_TIET_DE_XUAT_TA(MaDeXuat,MaThucAn,Noidung,TinhTrang)
values ('DX0005','TA0001',N'Đề nghị mua thêm, đói đéo chịu được','1');
insert into CHI_TIET_DE_XUAT_TA(MaDeXuat,MaThucAn,Noidung,TinhTrang)
values ('DX0005','TA0002',N'Đề nghị mua thêm, đói đéo chịu được','1');
----26. Chi tiết đề xuất vật tư
insert into CHI_TIET_DE_XUAT_VT(MaDeXuat,MaVatTu,Noidung,TinhTrang)
values ('DX0001','VT0001',N'Đề nghị mua thêm 1 cái','1');
insert into CHI_TIET_DE_XUAT_VT(MaDeXuat,MaVatTu,Noidung,TinhTrang)
values ('DX0002','VT0002',N'Đề nghị bán đi 1 cái','0');
-----27. Loại phiếu LP0001
insert into LOAI_PHIEU(TenLoaiPhieu) values (N'Phiếu nhập');
insert into LOAI_PHIEU(TenLoaiPhieu) values (N'Phiếu xuất');
-----28. Phiếu PH0001
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)
values ('LP001','2022-01-02','K0001','NV0001');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)
values ('LP002','2022-01-03','K0001','NV0001');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)
values ('LP002','2022-01-04','K0001','NV0001');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)
values ('LP001','2022-01-05','K0001','NV0001');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)
values ('LP001','2022-01-06','K0002','NV0001');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu, MaKho,MaNhanVien)
values ('LP001','2022-01-07','K0003','NV0001');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)
values ('LP001','2022-01-08','K0004','NV0003');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)
values ('LP001','2022-01-09','K0004','NV0002');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)
values ('LP001','2022-01-10','K0004','NV0003');
-----29. Chi tiết phiếu phim
insert into CHI_TIET_PHIEU_PHIM(MaPhieu,MaPhim,DonViTinh,SoLuong) values('PH0007','P00001',N'Bộ','1');
insert into CHI_TIET_PHIEU_PHIM(MaPhieu,MaPhim,DonViTinh,SoLuong) values('PH0008','P00002',N'Bộ','1');
insert into CHI_TIET_PHIEU_PHIM(MaPhieu,MaPhim,DonViTinh,SoLuong) values('PH0009','P00003',N'Bộ','1');
-----30. Chi tiết phiếu vật tư
insert into CHI_TIET_PHIEU_VT(MaPhieu,MaVatTu,DonViTinh,SoLuong) values('PH0005','VT0001',N'Cái','4');
insert into CHI_TIET_PHIEU_VT(MaPhieu,MaVatTu,DonViTinh,SoLuong) values('PH0006','VT0002',N'Cái','100');
-----31. Chi tiết phiếu thức ăn
insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong,NgayHetHang)
values('PH0001','TA0001',N'Gói','10','2022-04-12');
insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong,NgayHetHang)
values('PH0002','TA0001',N'Gói','15','2022-04-13');
insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong,NgayHetHang)
values('PH0003','TA0002',N'Chai','5','2022-04-14');
insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong,NgayHetHang)
values('PH0004','TA0003',N'Gói','5','2022-04-12');
-----32. Chi tiết cung cấp vật tư
insert into CHI_TIET_CUNG_CAP_VAT_TU(MaVatTu,MaNhaCungCap,GiaTien,DonViTinh,SoLuong)
values ('VT0001','NCC003','20',N'Cái','20');
insert into CHI_TIET_CUNG_CAP_VAT_TU(MaVatTu,MaNhaCungCap,GiaTien,DonViTinh,SoLuong)
values ('VT0002','NCC003','30',N'Bộ','20');
insert into CHI_TIET_CUNG_CAP_VAT_TU(MaVatTu,MaNhaCungCap,GiaTien,DonViTinh,SoLuong)
values ('VT0003','NCC003','40',N'Cái','25');
insert into CHI_TIET_CUNG_CAP_VAT_TU(MaVatTu,MaNhaCungCap,GiaTien,DonViTinh,SoLuong)
values ('VT0004','NCC003','50',N'Bộ','30');
insert into CHI_TIET_CUNG_CAP_VAT_TU(MaVatTu,MaNhaCungCap,GiaTien,DonViTinh,SoLuong)
values ('VT0005','NCC003','10',N'Cái','15');
-----33. Chi tiết cung cấp thức ăn
insert into CHI_TIET_CUNG_CAP_THUC_AN(MaThucAn,MaNhaCungCap,GiaTien,DonViTinh,SoLuong)
values ('TA0001','NCC004','5',N'Thùng','20');
insert into CHI_TIET_CUNG_CAP_THUC_AN(MaThucAn,MaNhaCungCap,GiaTien,DonViTinh,SoLuong)
values ('TA0002','NCC004','10',N'Thùng','20');
insert into CHI_TIET_CUNG_CAP_THUC_AN(MaThucAn,MaNhaCungCap,GiaTien,DonViTinh,SoLuong)
values ('TA0003','NCC004','10',N'Thùng','25');
-----34. Vật tư trong phòng chiếu PC0001
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0001','VT0001',N'Cái','8');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0001','VT0002',N'Cái','60');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0001','VT0003',N'Cái','8');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0001','VT0004',N'Cái','1');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0001','VT0005',N'Cái','4');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0002','VT0001',N'Cái','8');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0002','VT0002',N'Cái','60');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0002','VT0003',N'Cái','8');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0002','VT0004',N'Cái','1');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0002','VT0005',N'Cái','4');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0003','VT0001',N'Cái','8');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0003','VT0002',N'Cái','60');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0003','VT0003',N'Cái','8');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0003','VT0004',N'Cái','1');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0003','VT0005',N'Cái','4');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0004','VT0001',N'Cái','8');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0004','VT0002',N'Cái','60');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0004','VT0003',N'Cái','8');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0004','VT0004',N'Cái','1');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0004','VT0005',N'Cái','4');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0005','VT0001',N'Cái','8');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0005','VT0002',N'Cái','60');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0005','VT0003',N'Cái','8');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0005','VT0004',N'Cái','1');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0005','VT0005',N'Cái','4');