go
use QuanLyRapChieuPhim
go
------1. Thể loại phim ----- TLP001
insert into THE_LOAI_PHIM (TenTheLoaiPhim) values (N'Hài');
insert into THE_LOAI_PHIM (TenTheLoaiPhim) values (N'Cổ trang');
insert into THE_LOAI_PHIM (TenTheLoaiPhim) values (N'Tình cảm');
insert into THE_LOAI_PHIM (TenTheLoaiPhim) values (N'Kinh dị');
insert into THE_LOAI_PHIM (TenTheLoaiPhim) values (N'Phiêu lưu mạo hiểm');
insert into THE_LOAI_PHIM (TenTheLoaiPhim) values (N'Khoa học viễn tưởng');
-- Đã xong
------2. Loại nhà cung cấp ----- LNCC01
insert into LOAI_NHA_CUNG_CAP(TenLoaiNCC) values (N'Phim');
insert into LOAI_NHA_CUNG_CAP(TenLoaiNCC) values (N'Vật tư');
insert into LOAI_NHA_CUNG_CAP(TenLoaiNCC) values (N'Thức ăn nhanh');
-- Đã xong
-------3.Diễn viên, đạo diễn ------ DVDD00001
insert into DIEN_VIEN_DAO_DIEN(TenDienVienDaoDien,Link)
values(N'Lee Ji eun','https://vi.wikipedia.org/wiki/IU_(ca_s%C4%A9)');
insert into DIEN_VIEN_DAO_DIEN(TenDienVienDaoDien,Link)
values(N'Trấn Thành','https://vi.wikipedia.org/wiki/Tr%E1%BA%A5n_Th%C3%A0nh');
insert into DIEN_VIEN_DAO_DIEN(TenDienVienDaoDien,Link)
values(N'Nhã Phương','https://vi.wikipedia.org/wiki/Nh%C3%A3_Ph%C6%B0%C6%A1ng_(di%E1%BB%85n_vi%C3%AAn)');
insert into DIEN_VIEN_DAO_DIEN(TenDienVienDaoDien,Link)
values(N'Hồng Đăng','https://vi.wikipedia.org/wiki/H%E1%BB%93ng_%C4%90%C4%83ng_(di%E1%BB%85n_vi%C3%AAn)');
insert into DIEN_VIEN_DAO_DIEN(TenDienVienDaoDien,Link)
values(N'Ốc Thanh Vân','https://vi.wikipedia.org/wiki/%E1%BB%90c_Thanh_V%C3%A2n');
insert into DIEN_VIEN_DAO_DIEN(TenDienVienDaoDien,Link)
values(N'Tuấn Trần','https://vi.wikipedia.org/wiki/Tu%E1%BA%A5n_Tr%E1%BA%A7n');
insert into DIEN_VIEN_DAO_DIEN(TenDienVienDaoDien,Link)
values(N'Benedict Cumberbatch','https://vi.wikipedia.org/wiki/Benedict_Cumberbatch');
insert into DIEN_VIEN_DAO_DIEN(TenDienVienDaoDien,Link)
values(N'Rowan Atkinson','https://vi.wikipedia.org/wiki/Rowan_Atkinson');
------ Đã Xong
------4. Nhà cung cấp ------- NCC001 
insert into NHA_CUNG_CAP(TenNhaCungCap,MaSoThue,DiaChi,Email,SoDienThoai,TenGiamDoc,MaLoaiNCC)
values (N'Tân Quang Dũng','0109990228',N'Đông Hà','tanquangdung@gmail.com','0973977821',N'Trần Trung Hiếu','LNCC01');
insert into NHA_CUNG_CAP(TenNhaCungCap,MaSoThue,DiaChi,Email,SoDienThoai,TenGiamDoc,MaLoaiNCC)
values (N'Hoàng Hải','0202159730',N'Huế','hoanghai@gmail.com','0943923821',N'Trần Đình Trọng','LNCC01');
insert into NHA_CUNG_CAP(TenNhaCungCap,MaSoThue,DiaChi,Email,SoDienThoai,TenGiamDoc,MaLoaiNCC)
values (N'Hà Vân','0109991006',N'Quảng Ngãi','havan@gmail.com','0973000218',N'Trần Hà Vân','LNCC01');
insert into NHA_CUNG_CAP(TenNhaCungCap,MaSoThue,DiaChi,Email,SoDienThoai,TenGiamDoc,MaLoaiNCC)
values (N'Hải Tùng','0109991479',N'Bình Phước','haitung@gmail.com','0973232219',N'Nguyễn Hải Tùng','LNCC01');
insert into NHA_CUNG_CAP(TenNhaCungCap, MaSoThue,DiaChi,Email,SoDienThoai,TenGiamDoc,MaLoaiNCC)
values (N'Minh Mập','0109990242',N'Đà Nẵng','minhmap@gmail.com','0943286932',N'Lê Văn Hào','LNCC02');
insert into NHA_CUNG_CAP(TenNhaCungCap, MaSoThue,DiaChi,Email,SoDienThoai,TenGiamDoc,MaLoaiNCC)
values (N'Phước Bửu','0317281409',N'Đà Nẵng','phuocbuu@gmail.com','0992023921',N'Trần Văn hữu','LNCC02');
insert into NHA_CUNG_CAP(TenNhaCungCap, MaSoThue,DiaChi,Email,SoDienThoai,TenGiamDoc,MaLoaiNCC)
values (N'Đình Tâm','1201661756',N'Huế','dinhtam@gmail.com','0903627023',N'Trần Đình Tâm','LNCC02');
insert into NHA_CUNG_CAP(TenNhaCungCap, MaSoThue,DiaChi,Email,SoDienThoai,TenGiamDoc,MaLoaiNCC)
values (N'Văn Hào','0109990362',N'Quảng Trị','vanhao@gmail.com','0913222888',N'Lê Văn Hào','LNCC02');
insert into NHA_CUNG_CAP(TenNhaCungCap, MaSoThue,DiaChi,Email,SoDienThoai,TenGiamDoc,MaLoaiNCC)
values (N'Trọng Nguyên','0317284914',N'Hà Nội','trongnguyen@gmail.com','0913282012',N'Lê Trọng Nguyên','LNCC02');
insert into NHA_CUNG_CAP(TenNhaCungCap,MaSoThue,DiaChi,Email,SoDienThoai,TenGiamDoc,MaLoaiNCC)
values (N'Hải Quỳnh','0402147404',N'Quảng Nam','haiquynh@gmail.com','0992737521',N'Phạm Phú Trung','LNCC03');
insert into NHA_CUNG_CAP(TenNhaCungCap,MaSoThue,DiaChi,Email,SoDienThoai,TenGiamDoc,MaLoaiNCC)
values (N'Nguyễn Cường','3002255111',N'Quảng Bình','nguyencuong@gmail.com','0903222891',N'Nguyễn Cường','LNCC03');
insert into NHA_CUNG_CAP(TenNhaCungCap,MaSoThue,DiaChi,Email,SoDienThoai,TenGiamDoc,MaLoaiNCC)
values (N'Nhật Minh','4900887293',N'Đà Nẵng','nhatminh@gmail.com','0913999821',N'Nhật Minh','LNCC03');
insert into NHA_CUNG_CAP(TenNhaCungCap,MaSoThue,DiaChi,Email,SoDienThoai,TenGiamDoc,MaLoaiNCC)
values (N'Văn Dũng','0109990355',N'Đà Nẵng','vandung@gmail.com','0888291333',N'Văn Dũng','LNCC03');
insert into NHA_CUNG_CAP(TenNhaCungCap,MaSoThue,DiaChi,Email,SoDienThoai,TenGiamDoc,MaLoaiNCC)
values (N'Tân Quang Dũng','0109991292',N'Đông Hà','fptdung@gmail.com','0973989821',N'Trần Trung Hiếu','LNCC01');
---- Đã xong
------5.HÃNG SẢN XUẤT PHIM --------- HSXO00001
insert into HANG_SAN_XUAT_PHIM(TenHangSanXuatPhim,Link)
values(N'Thắng Việt','http://trangvangtructuyen.vn/cong-ty-tnhh-thang-viet.html');
insert into HANG_SAN_XUAT_PHIM(TenHangSanXuatPhim,Link)
values(N'Thanh Ngân','http://trangvangtructuyen.vn/cong-ty-co-phan-quang-cao-va-to-chuc-su-kien-thanh-ngan.html');
insert into HANG_SAN_XUAT_PHIM(TenHangSanXuatPhim,Link)
values(N'Ánh Tuyết','http://trangvangtructuyen.vn/cong-ty-cp-thuong-mai-san-xuat-truyen-thong-va-giai-tri-anh-tuyet.html');
insert into HANG_SAN_XUAT_PHIM(TenHangSanXuatPhim,Link)
values(N'Đông Nam','http://trangvangtructuyen.vn/cong-ty-tnhh-dien-anh-dong-nam.html');
insert into HANG_SAN_XUAT_PHIM(TenHangSanXuatPhim,Link)
values(N'Nguyễn Duy','http://trangvangtructuyen.vn/cong-ty-tnhh-am-nhac-phim-anh-nguyen-duy.html');
----- Đã xong
-----6. Thức ăn ----- TA0001
insert into THUC_AN(TenThucAn) values (N'Bỏng ngô');
insert into THUC_AN(TenThucAn) values (N'Cocacola');
insert into THUC_AN(TenThucAn) values (N'Kẹo');
insert into THUC_AN(TenThucAn) values (N'Pepsi');
insert into THUC_AN(TenThucAn) values (N'Nước lọc');
insert into THUC_AN(TenThucAn) values (N'Oshi');
--- Đã xong
-----7. Vật tư ---- VT0001
insert into VAT_TU(TenVatTu) values (N'Đèn sáng');
insert into VAT_TU(TenVatTu) values (N'Ghế đơn');
insert into VAT_TU(TenVatTu) values (N'Điều hòa');
insert into VAT_TU(TenVatTu) values (N'Máy chiếu');
insert into VAT_TU(TenVatTu) values (N'Loa');
insert into VAT_TU(TenVatTu) values (N'Ghế đôi');
insert into VAT_TU(TenVatTu) values (N'Màn chiếu 2D');
insert into VAT_TU(TenVatTu) values (N'Màn chiếu 3D');
--- Đã xong
-----8. Phim------ P00001
insert into PHIM (TenPhim,AnhPhim,ThoiLuong,QuocGia,NamSanXuat,MaHangSanXuatPhim ,DoTuoiXem,MaTheLoai ,NoiDung)
values (N'Gia đình đức hạnh',null,'90',N'Thái Lan','2020-12-22','HSXP00001',18,'TLP001',N'Noi dung1');
insert into PHIM (TenPhim,AnhPhim,ThoiLuong,QuocGia,NamSanXuat,MaHangSanXuatPhim ,DoTuoiXem,MaTheLoai ,NoiDung)
values(N'Mắt Biếc',null,'97',N'Việt Nam','2020-12-22','HSXP00001',18,'TLP003',N'Kể về câu chuyện giữa Ngạn và Hà Lan');
insert into PHIM (TenPhim,AnhPhim,ThoiLuong,QuocGia,NamSanXuat,MaHangSanXuatPhim ,DoTuoiXem,MaTheLoai ,NoiDung)
values(N'Nhà có khách',null,'90',N'Việt Nam','2021-12-22','HSXP00001',18,'TLP001',N'Noi dung 2');
insert into PHIM (TenPhim,AnhPhim,ThoiLuong,QuocGia,NamSanXuat,MaHangSanXuatPhim ,DoTuoiXem,MaTheLoai ,NoiDung)
values(N'Em chưa 18',null,'90',N'Việt Nam','2019-12-20','HSXP00002',18,'TLP003',N'Noi dung1');
insert into PHIM (TenPhim,AnhPhim,ThoiLuong,QuocGia,NamSanXuat,MaHangSanXuatPhim ,DoTuoiXem,MaTheLoai ,NoiDung)
values(N'Bố già',null,'90',N'Việt Nam','2020-12-22','HSXP00002',18,'TLP001',N'Noi dung1');
insert into PHIM (TenPhim,AnhPhim,ThoiLuong,QuocGia,NamSanXuat,MaHangSanXuatPhim ,DoTuoiXem,MaTheLoai ,NoiDung)
values(N'Bẫy ngọt ngào',null,'90',N'Thái Lan','2020-09-22','HSXP00003',18,'TLP003',N'Noi dung1');
insert into PHIM (TenPhim,AnhPhim,ThoiLuong,QuocGia,NamSanXuat,MaHangSanXuatPhim ,DoTuoiXem,MaTheLoai ,NoiDung) 
values(N'Em và Trịnh',null,'90',N'Việt Nam','2020-09-22','HSXP00003',18,'TLP003',N'Kí ức Trịnh Công Sơn');
insert into PHIM (TenPhim,AnhPhim,ThoiLuong,QuocGia,NamSanXuat,MaHangSanXuatPhim ,DoTuoiXem,MaTheLoai ,NoiDung)
values(N'Chung Cực Bút Ký',null,'95',N'Trung Quốc','2020-09-22','HSXP00003',13,'TLP005',N'Đạo mộ bút ký - Chung cực bút ký');
insert into PHIM (TenPhim,AnhPhim,ThoiLuong,QuocGia,NamSanXuat,MaHangSanXuatPhim ,DoTuoiXem,MaTheLoai ,NoiDung)
values(N'Sa Hải',null,'90',N'Trung Quốc','2020-09-22','HSXP00004',18,'TLP005',N'Đạo mộ bút ký - Sa Hải');
insert into PHIM (TenPhim,AnhPhim,ThoiLuong,QuocGia,NamSanXuat,MaHangSanXuatPhim ,DoTuoiXem,MaTheLoai ,NoiDung)
values(N'Nộ Hải Tiềm Sa',null,'90',N'Việt Nam','2020-09-22','HSXP00004',18,'TLP003',N'Kí ức Trịnh Công Sơn');
insert into PHIM (TenPhim,AnhPhim,ThoiLuong,QuocGia,NamSanXuat,MaHangSanXuatPhim ,DoTuoiXem,MaTheLoai ,NoiDung)
values(N'Vân Đỉnh Thiên Cung',null,'90',N'Trung Quốc','2020-09-22','HSXP00005',18,'TLP003',N'Kí ức Trịnh Công Sơn');
insert into PHIM (TenPhim,AnhPhim,ThoiLuong,QuocGia,NamSanXuat,MaHangSanXuatPhim ,DoTuoiXem,MaTheLoai ,NoiDung) 
values(N'Lão Cữu Môn',null,'90',N'Trung Quốc','2020-09-22','HSXP00005',18,'TLP003',N'Kí ức Trịnh Công Sơn');
---- Đã xong
--9.Loai Hop Dong  -------- LHD001
insert into LOAI_HOP_DONG(TenLoaiHopDong) values (N'Hợp đồng phim');
insert into LOAI_HOP_DONG(TenLoaiHopDong) values (N'Hợp đồng vật tư');
insert into LOAI_HOP_DONG(TenLoaiHopDong) values (N'Hợp đồng thức ăn');
---- Đã xong
--10.Hop dong  ------------ HD0001
insert into HOP_DONG(TenHopDong ,MaNhaCungCap ,NgayKiKetHD , MaLoaiHopDong)
values (N'Hợp đồng 1', 'NCC001', '2020-09-30', 'LHD001' );
insert into HOP_DONG(TenHopDong ,MaNhaCungCap ,NgayKiKetHD , MaLoaiHopDong)
values (N'Hợp đồng 2', 'NCC002', '2020-08-30', 'LHD001' );
insert into HOP_DONG(TenHopDong ,MaNhaCungCap ,NgayKiKetHD , MaLoaiHopDong)
values (N'Hợp đồng 3', 'NCC005', '2020-12-30', 'LHD002' );
insert into HOP_DONG(TenHopDong ,MaNhaCungCap ,NgayKiKetHD , MaLoaiHopDong)
values (N'Hợp đồng 4', 'NCC006', '2020-12-30', 'LHD002' );
insert into HOP_DONG(TenHopDong ,MaNhaCungCap ,NgayKiKetHD , MaLoaiHopDong)
values (N'Hợp đồng 5', 'NCC010', '2020-11-30', 'LHD003' );
insert into HOP_DONG(TenHopDong ,MaNhaCungCap ,NgayKiKetHD , MaLoaiHopDong)
values (N'Hợp đồng 6', 'NCC011', '2020-12-30', 'LHD003' );
---- Đã xong
--Loai phong chieu LPC001
insert into LOAI_PHONG_CHIEU(TenLoaiPhongChieu) values (N'Thông thường' );
insert into LOAI_PHONG_CHIEU(TenLoaiPhongChieu) values (N'Dolby Atmos' );
insert into LOAI_PHONG_CHIEU(TenLoaiPhongChieu) values (N'4Dx' );
insert into LOAI_PHONG_CHIEU(TenLoaiPhongChieu) values (N'ScreenX' );
-- tinh trang phong chieu
insert into TINH_TRANG_PHONG_CHIEU(TenTinhTrang) values (N'Tốt');
insert into TINH_TRANG_PHONG_CHIEU(TenTinhTrang) values (N'Hỏng');
insert into TINH_TRANG_PHONG_CHIEU(TenTinhTrang) values (N'Bảo trì');
-----11. Phòng chiếu PC0001
insert into PHONG_CHIEU(TenPhong,MaTinhTrang, MaLoaiPhongChieu) values (N'Phòng số 1','3','LPC001');
insert into PHONG_CHIEU(TenPhong,MaTinhTrang, MaLoaiPhongChieu) values (N'Phòng số 2','1','LPC001');
insert into PHONG_CHIEU(TenPhong,MaTinhTrang, MaLoaiPhongChieu) values (N'Phòng số 3','1','LPC002');
insert into PHONG_CHIEU(TenPhong,MaTinhTrang, MaLoaiPhongChieu) values (N'Phòng số 4','2','LPC002');
insert into PHONG_CHIEU(TenPhong,MaTinhTrang, MaLoaiPhongChieu) values (N'Phòng số 5','1','LPC003');
insert into PHONG_CHIEU(TenPhong,MaTinhTrang, MaLoaiPhongChieu) values (N'Phòng số 6','2','LPC004');
insert into PHONG_CHIEU(TenPhong,MaTinhTrang, MaLoaiPhongChieu) values (N'Phòng số 7','1','LPC004');
insert into PHONG_CHIEU(TenPhong,MaTinhTrang, MaLoaiPhongChieu) values (N'Phòng số 8','2','LPC001');
insert into PHONG_CHIEU(TenPhong,MaTinhTrang, MaLoaiPhongChieu) values (N'Phòng số 9','1','LPC003');
insert into PHONG_CHIEU(TenPhong,MaTinhTrang, MaLoaiPhongChieu) values (N'Phòng số 10','1','LPC002');
---- Đã xong
------12. Khung giờ chiếu -----------KGC00001  
insert into KHUNG_GIO_CHIEU(TenKhungGio,TGBatDau,TGKetThuc) values(N'Khung giờ số 1','08:00:00.0000000','11:00:00.0000000');
insert into KHUNG_GIO_CHIEU(TenKhungGio,TGBatDau,TGKetThuc) values(N'Khung giờ số 2','11:00:00.0000000','14:00:00.0000000');
insert into KHUNG_GIO_CHIEU(TenKhungGio,TGBatDau,TGKetThuc) values(N'Khung giờ số 3','14:00:00.0000000','17:00:00.0000000');
insert into KHUNG_GIO_CHIEU(TenKhungGio,TGBatDau,TGKetThuc) values(N'Khung giờ số 4','17:00:00.0000000','20:00:00.0000000');
insert into KHUNG_GIO_CHIEU(TenKhungGio,TGBatDau,TGKetThuc) values(N'Khung giờ số 5','20:00:00.0000000','23:00:00.0000000');
----Đã xong
------13.Lịch chiếu
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00001','PC0002','KGC00001','2022-09-06','1');
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00002','PC0003','KGC00002','2022-09-07','0');
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00003','PC0005','KGC00001','2022-09-06','1');
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00004','PC0005','KGC00002','2022-09-08','1');
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00005','PC0005','KGC00003','2022-09-10','1');
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00006','PC0005','KGC00004','2022-09-11','0');
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00007','PC0005','KGC00005','2022-09-12','0');
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00008','PC0007','KGC00002','2022-09-13','0');
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00009','PC0007','KGC00003','2022-09-06','1');
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00010','PC0009','KGC00004','2022-09-09','1');
----- Đã xong
----- Đã xong
------14.Ca làm việc ----- CLV001
insert into CA_LAM_VIEC(TenCa,GioBatDau,GioKetThuc) values(N'Ca Sáng','08:00:00.0000000','11:00:00.0000000');
insert into CA_LAM_VIEC(TenCa,GioBatDau,GioKetThuc) values(N'Ca chiều','11:00:00.0000000','14:00:00.0000000');
insert into CA_LAM_VIEC(TenCa,GioBatDau,GioKetThuc) values(N'Ca tối','14:00:00.0000000','17:00:00.0000000');
insert into CA_LAM_VIEC(TenCa,GioBatDau,GioKetThuc) values(N'Ca tối','17:00:00.0000000','20:00:00.0000000');
insert into CA_LAM_VIEC(TenCa,GioBatDau,GioKetThuc) values(N'Ca tối','20:00:00.0000000','23:00:00.0000000');
----Đã xong
------15 Ngay Lam Viec -------- NLV001
insert into NGAY_LAM_VIEC(NgayLamViec,MaCa) values('2022-01-29','CLV001');
insert into NGAY_LAM_VIEC(NgayLamViec,MaCa) values('2022-02-28','CLV002');
insert into NGAY_LAM_VIEC(NgayLamViec,MaCa) values('2022-03-25','CLV003');
insert into NGAY_LAM_VIEC(NgayLamViec,MaCa) values('2022-04-25','CLV004');
insert into NGAY_LAM_VIEC(NgayLamViec,MaCa) values('2022-05-25','CLV005');
---- Đã xong
------16. Chính sách ------- CS0001
insert into CHINH_SACH(TenChinhSach,HeSoLuong,BHXH,TienThuong) values ('Kha','1','6 thang','200000');
insert into CHINH_SACH(TenChinhSach,HeSoLuong,BHXH,TienThuong) values ('XuatSac','2','2 nam','300000');
insert into CHINH_SACH(TenChinhSach,HeSoLuong,BHXH,TienThuong) values ('Gioi','3','1 nam','400000');
----- Đã xong
-----17.Chức vụ ------ CV0001
insert into CHUC_VU(TenChucVu) values (N'Quản lý phim');
insert into CHUC_VU(TenChucVu) values (N'Quản lý vật tư');
insert into CHUC_VU(TenChucVu) values (N'Quản trị viên');
----- Đã xong
------18.Nhân viên ----- NV0001
insert into NHAN_VIEN(TenNhanVien,NgaySinh,GioiTinh,DiaChi,SoDienThoai,CCCD,TenTaiKhoan,MatKhau,MaChinhSach,MaChucVu)--123456789
Values (N'Phạm Khắc Luận','2002-04-20','0',N'Huế','0982792837','9280009918892','luanqlp','25f9e794323b453885f5181f1b624d0b','CS0002','CV0001');
insert into NHAN_VIEN(TenNhanVien,NgaySinh,GioiTinh,DiaChi,SoDienThoai,CCCD,TenTaiKhoan,MatKhau,MaChinhSach,MaChucVu)--987654321
Values (N'Trần Trung Hiếu','2002-03-01','0',N'Quảng Trị','0982782647','9283920102392','hieuqlvt','6ebe76c9fb411be97b3b0d48b791a7c9','CS0002','CV0002');
insert into NHAN_VIEN(TenNhanVien,NgaySinh,GioiTinh,DiaChi,SoDienThoai,CCCD,TenTaiKhoan,MatKhau,MaChinhSach,MaChucVu)--123456
Values (N'Lê Văn Hào','2002-02-22','0',N'Huế','0827582932','9280000002392','admin','e10adc3949ba59abbe56e057f20f883e','CS0003','CV0003');
-----Đã xong
------19. Chi tiết ca làm việc
insert into CHI_TIET_CA_LAM_VIEC(MaNhanVien,MaCa,TrangThai) values ('NV0001','CLV001','1');
insert into CHI_TIET_CA_LAM_VIEC(MaNhanVien,MaCa,TrangThai) values ('NV0001','CLV002','0');
insert into CHI_TIET_CA_LAM_VIEC(MaNhanVien,MaCa,TrangThai) values ('NV0001','CLV003','1');
insert into CHI_TIET_CA_LAM_VIEC(MaNhanVien,MaCa,TrangThai) values ('NV0002','CLV001','1');
insert into CHI_TIET_CA_LAM_VIEC(MaNhanVien,MaCa,TrangThai) values ('NV0002','CLV002','1');
insert into CHI_TIET_CA_LAM_VIEC(MaNhanVien,MaCa,TrangThai) values ('NV0003','CLV002','1');
insert into CHI_TIET_CA_LAM_VIEC(MaNhanVien,MaCa,TrangThai) values ('NV0003','CLV003','1');
insert into CHI_TIET_CA_LAM_VIEC(MaNhanVien,MaCa,TrangThai) values ('NV0003','CLV004','1');
insert into CHI_TIET_CA_LAM_VIEC(MaNhanVien,MaCa,TrangThai) values ('NV0003','CLV005','1');
------ Đã xong
------20. Loại kho -------- LK001
insert into LOAI_KHO(TenLoaiKho) values (N'Phim');
insert into LOAI_KHO(TenLoaiKho) values (N'Vật tư');
insert into LOAI_KHO(TenLoaiKho) values (N'Thức ăn nhanh');
----- Đã xong
------21. Kho -------- K0001
insert into KHO(MaLoaiKho,TenKho) values ('LK001',N'Kho số 1');
insert into KHO(MaLoaiKho,TenKho) values ('LK002',N'Kho số 2');
insert into KHO(MaLoaiKho,TenKho) values ('LK003',N'Kho số 3');
----- Đã xong
-----22. Chi tiết kho phim
insert into CHI_TIET_KHO_PHIM(MaKho,MaPhim,DonViTinh,SoLuongSP) values ('K0001','P00001',N'Đĩa','1');
insert into CHI_TIET_KHO_PHIM(MaKho,MaPhim,DonViTinh,SoLuongSP) values ('K0001','P00002',N'Đĩa','2');
insert into CHI_TIET_KHO_PHIM(MaKho,MaPhim,DonViTinh,SoLuongSP) values ('K0001','P00003',N'Đĩa','1');
insert into CHI_TIET_KHO_PHIM(MaKho,MaPhim,DonViTinh,SoLuongSP) values ('K0001','P00004',N'Đĩa','1');
insert into CHI_TIET_KHO_PHIM(MaKho,MaPhim,DonViTinh,SoLuongSP) values ('K0001','P00005',N'Đĩa','2');
insert into CHI_TIET_KHO_PHIM(MaKho,MaPhim,DonViTinh,SoLuongSP) values ('K0001','P00006',N'Đĩa','1');
insert into CHI_TIET_KHO_PHIM(MaKho,MaPhim,DonViTinh,SoLuongSP) values ('K0001','P00007',N'Đĩa','2');
insert into CHI_TIET_KHO_PHIM(MaKho,MaPhim,DonViTinh,SoLuongSP) values ('K0001','P00008',N'Đĩa','1');
insert into CHI_TIET_KHO_PHIM(MaKho,MaPhim,DonViTinh,SoLuongSP) values ('K0001','P00009',N'Đĩa','2');
insert into CHI_TIET_KHO_PHIM(MaKho,MaPhim,DonViTinh,SoLuongSP) values ('K0001','P00010',N'Đĩa','1');
insert into CHI_TIET_KHO_PHIM(MaKho,MaPhim,DonViTinh,SoLuongSP) values ('K0001','P00011',N'Đĩa','3');
insert into CHI_TIET_KHO_PHIM(MaKho,MaPhim,DonViTinh,SoLuongSP) values ('K0001','P00012',N'Đĩa','5');
-----Đã xong
----23. Chi tiết kho vật tư
insert into CHI_TIET_KHO_VT(MaKho,MaVatTu,DonViTinh,SoLuongSP) values('K0002','VT0001',N'Cái','12');
insert into CHI_TIET_KHO_VT(MaKho,MaVatTu,DonViTinh,SoLuongSP) values('K0002','VT0002',N'Cái','10');
insert into CHI_TIET_KHO_VT(MaKho,MaVatTu,DonViTinh,SoLuongSP) values('K0002','VT0003',N'Cái','5');
insert into CHI_TIET_KHO_VT(MaKho,MaVatTu,DonViTinh,SoLuongSP) values('K0002','VT0004',N'Cái','6');
insert into CHI_TIET_KHO_VT(MaKho,MaVatTu,DonViTinh,SoLuongSP) values('K0002','VT0005',N'Cái','7');
insert into CHI_TIET_KHO_VT(MaKho,MaVatTu,DonViTinh,SoLuongSP) values('K0002','VT0006',N'Cái','2');
insert into CHI_TIET_KHO_VT(MaKho,MaVatTu,DonViTinh,SoLuongSP) values('K0002','VT0007',N'Cái','1');
insert into CHI_TIET_KHO_VT(MaKho,MaVatTu,DonViTinh,SoLuongSP) values('K0002','VT0008',N'Cái','1');
---- Đã xong
----24. Chi tiết kho thức ăn
insert into CHI_TIET_KHO_THUC_AN(MaKho,MaThucAn,DonViTinh,SoLuongSP) values('K0003','TA0001',N'Gói','100');
insert into CHI_TIET_KHO_THUC_AN(MaKho,MaThucAn,DonViTinh,SoLuongSP) values('K0003','TA0002',N'Thùng','20');
insert into CHI_TIET_KHO_THUC_AN(MaKho,MaThucAn,DonViTinh,SoLuongSP) values('K0003','TA0003',N'Gói','200');
insert into CHI_TIET_KHO_THUC_AN(MaKho,MaThucAn,DonViTinh,SoLuongSP) values('K0003','TA0004',N'Thùng','200');
insert into CHI_TIET_KHO_THUC_AN(MaKho,MaThucAn,DonViTinh,SoLuongSP) values('K0003','TA0005',N'Thùng','200');
insert into CHI_TIET_KHO_THUC_AN(MaKho,MaThucAn,DonViTinh,SoLuongSP) values('K0003','TA0006',N'Gói','200');
----- Đã xong
---25. Loại đề xuất------LDX01
insert into LOAI_DE_XUAT(TenLoaiDeXuat) values (N'Đề xuất phim');
insert into LOAI_DE_XUAT(TenLoaiDeXuat) values (N'Đề xuất vật tư');
insert into LOAI_DE_XUAT(TenLoaiDeXuat) values (N'Đề xuất thức ăn nhanh');
---- Đã xong
---26. Đề xuất----DX0001
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0002','2022-01-02','LDX02');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0002','2022-01-02','LDX02');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0002','2022-01-02','LDX02');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0002','2022-02-02','LDX02');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0002','2022-03-02','LDX02');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0002','2022-03-02','LDX02');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0002','2022-01-02','LDX02');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0001','2022-01-02','LDX01');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0001','2022-01-02','LDX01');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0001','2022-01-02','LDX01');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0001','2022-02-02','LDX01');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0001','2022-04-02','LDX01');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0001','2022-05-02','LDX01');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0001','2022-06-02','LDX01');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0002','2022-06-02','LDX03');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0002','2022-06-02','LDX03');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0002','2022-07-02','LDX03');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0002','2022-08-02','LDX03');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0002','2022-09-02','LDX03');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0002','2022-06-02','LDX03');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0002','2022-06-02','LDX03');
---- Đã xong
----27. Chi tiết đề xuất phim
insert into CHI_TIET_DE_XUAT_PHIM(MaDeXuat,MaPhim,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0008','P00001',N'Đề nghị thêm bộ phim này','5',N'Đĩa','0');
insert into CHI_TIET_DE_XUAT_PHIM(MaDeXuat,MaPhim,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0009','P00008',N'Đề nghị thêm bộ phim này','8',N'Đĩa','1');
insert into CHI_TIET_DE_XUAT_PHIM(MaDeXuat,MaPhim,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0010','P00004',N'Đề nghị thêm bộ phim này','2',N'Đĩa','1');
insert into CHI_TIET_DE_XUAT_PHIM(MaDeXuat,MaPhim,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0011','P00009',N'Đề nghị thêm bộ phim này','5',N'Đĩa','3');
insert into CHI_TIET_DE_XUAT_PHIM(MaDeXuat,MaPhim,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0012','P00007',N'Đề nghị thêm bộ phim này','2',N'Đĩa','2');
insert into CHI_TIET_DE_XUAT_PHIM(MaDeXuat,MaPhim,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0013','P00002',N'Đề nghị thêm bộ phim này','2',N'Đĩa','2');
insert into CHI_TIET_DE_XUAT_PHIM(MaDeXuat,MaPhim,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0014','P00006',N'Đề nghị thêm bộ phim này','2',N'Đĩa','2');
-----Đã xong
----28. Chi tiết đề xuất thức ăn
insert into CHI_TIET_DE_XUAT_TA(MaDeXuat,MaThucAn,Noidung,DonViTinh,SoLuong,TinhTrang)
values ('DX0015','TA0001',N'Đề nghị mua thêm',N'Gói', '100','0');
insert into CHI_TIET_DE_XUAT_TA(MaDeXuat,MaThucAn,Noidung,DonViTinh,SoLuong,TinhTrang)
values ('DX0016','TA0002',N'Đề nghị mua thêm',N'Thùng', '10','1');
insert into CHI_TIET_DE_XUAT_TA(MaDeXuat,MaThucAn,Noidung,DonViTinh,SoLuong,TinhTrang)
values ('DX0017','TA0003',N'Đề nghị mua thêm',N'Gói', '105','0');
insert into CHI_TIET_DE_XUAT_TA(MaDeXuat,MaThucAn,Noidung,DonViTinh,SoLuong,TinhTrang)
values ('DX0018','TA0004',N'Đề nghị mua thêm',N'Thùng', '20','3');
insert into CHI_TIET_DE_XUAT_TA(MaDeXuat,MaThucAn,Noidung,DonViTinh,SoLuong,TinhTrang)
values ('DX0019','TA0005',N'Đề nghị mua thêm',N'Thùng', '20','2');
insert into CHI_TIET_DE_XUAT_TA(MaDeXuat,MaThucAn,Noidung,DonViTinh,SoLuong,TinhTrang)
values ('DX0020','TA0006',N'Đề nghị mua thêm',N'Gói', '200','2');
insert into CHI_TIET_DE_XUAT_TA(MaDeXuat,MaThucAn,Noidung,DonViTinh,SoLuong,TinhTrang)
values ('DX0021','TA0002',N'Đề nghị mua thêm',N'Thùng', '25','2');
----- Đã xong
----29. Chi tiết đề xuất vật tư
insert into CHI_TIET_DE_XUAT_VT(MaDeXuat,MaVatTu,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0001','VT0001',N'Đề nghị mua thêm','2',N'Cái','1');
insert into CHI_TIET_DE_XUAT_VT(MaDeXuat,MaVatTu,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0002','VT0002',N'Đề nghị mua thêm','3',N'Cái','1');
insert into CHI_TIET_DE_XUAT_VT(MaDeXuat,MaVatTu,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0003','VT0003',N'Đề nghị mua thêm','4',N'Cái','0');
insert into CHI_TIET_DE_XUAT_VT(MaDeXuat,MaVatTu,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0004','VT0004',N'Đề nghị mua thêm','2',N'Cái','1');
insert into CHI_TIET_DE_XUAT_VT(MaDeXuat,MaVatTu,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0005','VT0004',N'Đề nghị mua thêm','5',N'Cái','0');
insert into CHI_TIET_DE_XUAT_VT(MaDeXuat,MaVatTu,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0006','VT0002',N'Đề nghị mua thêm','2',N'Cái','1');
insert into CHI_TIET_DE_XUAT_VT(MaDeXuat,MaVatTu,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0007','VT0004',N'Đề nghị mua thêm','6',N'Cái','1');
insert into CHI_TIET_DE_XUAT_VT(MaDeXuat,MaVatTu,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0007','VT0001',N'Đề nghị mua thêm','5',N'Cái','2');
insert into CHI_TIET_DE_XUAT_VT(MaDeXuat,MaVatTu,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0007','VT0003',N'Đề nghị mua thêm','10',N'Cái','2');
----- Đã xong
-----30. Loại phiếu--------LP0001
insert into LOAI_PHIEU(TenLoaiPhieu) values (N'Phiếu nhập');
insert into LOAI_PHIEU(TenLoaiPhieu) values (N'Phiếu xuất');
----- Đã xong
-----31. Phiếu--------PH0001
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)
values ('LP001','2022-01-02','K0003','NV0002');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)
values ('LP002','2022-01-02','K0003','NV0002');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)
values ('LP002','2022-01-03','K0003','NV0002');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)
values ('LP002','2022-01-04','K0003','NV0002');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)
values ('LP002','2022-01-05','K0003','NV0002');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)
values ('LP001','2022-01-03','K0003','NV0002');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)
values ('LP001','2022-01-04','K0002','NV0002');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)
values ('LP001','2022-01-05','K0001','NV0001');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)
values ('LP002','2022-01-06','K0001','NV0001');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)
values ('LP001','2022-01-07','K0001','NV0001');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)
values ('LP001','2022-01-08','K0001','NV0001');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)
values ('LP001','2022-01-09','K0001','NV0001');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu, MaKho,MaNhanVien)
values ('LP001','2022-01-07','K0003','NV0002');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)
values ('LP001','2022-01-08','K0001','NV0001');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)
values ('LP001','2022-01-09','K0001','NV0001');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)
values ('LP001','2022-01-10','K0001','NV0001');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)
values ('LP001','2022-01-11','K0001','NV0001');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)
values ('LP002','2022-01-08','K0001','NV0001');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)
values ('LP002','2022-01-09','K0001','NV0001');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)
values ('LP002','2022-01-10','K0001','NV0001');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)
values ('LP002','2022-01-11','K0001','NV0001');
---- Đã xong
-----32. Chi tiết phiếu phim
insert into CHI_TIET_PHIEU_PHIM(MaPhieu,MaPhim,DonViTinh,SoLuong) values('PH0014','P00001',N'Bộ','1');
insert into CHI_TIET_PHIEU_PHIM(MaPhieu,MaPhim,DonViTinh,SoLuong) values('PH0015','P00002',N'Bộ','1');
insert into CHI_TIET_PHIEU_PHIM(MaPhieu,MaPhim,DonViTinh,SoLuong) values('PH0016','P00003',N'Bộ','1');
insert into CHI_TIET_PHIEU_PHIM(MaPhieu,MaPhim,DonViTinh,SoLuong) values('PH0017','P00004',N'Bộ','1');
insert into CHI_TIET_PHIEU_PHIM(MaPhieu,MaPhim,DonViTinh,SoLuong) values('PH0018','P00005',N'Bộ','1');
insert into CHI_TIET_PHIEU_PHIM(MaPhieu,MaPhim,DonViTinh,SoLuong) values('PH0019','P00006',N'Bộ','1');
insert into CHI_TIET_PHIEU_PHIM(MaPhieu,MaPhim,DonViTinh,SoLuong) values('PH0020','P00007',N'Bộ','1');
insert into CHI_TIET_PHIEU_PHIM(MaPhieu,MaPhim,DonViTinh,SoLuong) values('PH0021','P00008',N'Bộ','1');
----- Đã xong
-----33. Chi tiết phiếu vật tư
insert into CHI_TIET_PHIEU_VT(MaPhieu,MaVatTu,DonViTinh,SoLuong) values('PH0007','VT0001',N'Cái','4');
insert into CHI_TIET_PHIEU_VT(MaPhieu,MaVatTu,DonViTinh,SoLuong) values('PH0007','VT0002',N'Cái','5');
insert into CHI_TIET_PHIEU_VT(MaPhieu,MaVatTu,DonViTinh,SoLuong) values('PH0007','VT0003',N'Cái','6');
insert into CHI_TIET_PHIEU_VT(MaPhieu,MaVatTu,DonViTinh,SoLuong) values('PH0007','VT0004',N'Cái','7');
insert into CHI_TIET_PHIEU_VT(MaPhieu,MaVatTu,DonViTinh,SoLuong) values('PH0022','VT0001',N'Cái','4');
insert into CHI_TIET_PHIEU_VT(MaPhieu,MaVatTu,DonViTinh,SoLuong) values('PH0022','VT0002',N'Cái','5');
insert into CHI_TIET_PHIEU_VT(MaPhieu,MaVatTu,DonViTinh,SoLuong) values('PH0022','VT0003',N'Cái','6');
insert into CHI_TIET_PHIEU_VT(MaPhieu,MaVatTu,DonViTinh,SoLuong) values('PH0022','VT0004',N'Cái','7');
insert into CHI_TIET_PHIEU_VT(MaPhieu,MaVatTu,DonViTinh,SoLuong) values('PH0023','VT0001',N'Cái','4');
insert into CHI_TIET_PHIEU_VT(MaPhieu,MaVatTu,DonViTinh,SoLuong) values('PH0023','VT0002',N'Cái','5');
insert into CHI_TIET_PHIEU_VT(MaPhieu,MaVatTu,DonViTinh,SoLuong) values('PH0023','VT0003',N'Cái','6');
insert into CHI_TIET_PHIEU_VT(MaPhieu,MaVatTu,DonViTinh,SoLuong) values('PH0023','VT0004',N'Cái','7');

---- Đã xong
-----34. Chi tiết phiếu thức ăn
insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong,NgayHetHang)
values('PH0001','TA0001',N'Gói','10','2022-04-12');
insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong,NgayHetHang)
values('PH0002','TA0001',N'Gói','1','2022-04-13');
insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong,NgayHetHang)
values('PH0003','TA0002',N'Thùng','5','2022-04-14');
insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong,NgayHetHang)
values('PH0004','TA0003',N'Gói','5','2022-04-12');
insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong,NgayHetHang)
values('PH0005','TA0003',N'Gói','5','2022-04-12');
insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong,NgayHetHang)
values('PH0006','TA0003',N'Gói','20','2022-04-12');
insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong,NgayHetHang)
values('PH0008','TA0003',N'Gói','5','2022-04-12');
insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong,NgayHetHang)
values('PH0009','TA0002',N'Thùng','5','2022-04-12');
insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong,NgayHetHang)
values('PH0010','TA0004',N'Thùng','5','2022-04-12');
insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong,NgayHetHang)
values('PH0011','TA0005',N'Thùng','5','2022-04-12');
insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong,NgayHetHang)
values('PH0012','TA0006',N'Gói','20','2022-04-12');
----- Đã xong
-----35. Hop dong cung cấp vật tư
insert into HOP_DONG_VAT_TU(MaHopDong,MaVatTu,GiaTien,DonViTinh,SoLuong)
values ('HD0003','VT0001','200000',N'Cái','50');
insert into HOP_DONG_VAT_TU(MaHopDong,MaVatTu,GiaTien,DonViTinh,SoLuong)
values ('HD0004','VT0002','200000',N'Cái','50');
insert into HOP_DONG_VAT_TU(MaHopDong,MaVatTu,GiaTien,DonViTinh,SoLuong)
values ('HD0004','VT0005','400000',N'Cái','20');
insert into HOP_DONG_VAT_TU(MaHopDong,MaVatTu,GiaTien,DonViTinh,SoLuong)
values ('HD0004','VT0003','400000',N'Cái','20');
insert into HOP_DONG_VAT_TU(MaHopDong,MaVatTu,GiaTien,DonViTinh,SoLuong)
values ('HD0004','VT0004','300000',N'Cái','20');
---- Đã xong
------36. Hợp đồng phim
insert into HOP_DONG_PHIM(MaHopDong,MaPhim,PhienBan,NgayBatDauBanQuyen,NgayKetThucBanQuyen,Donvitinh,SoLuong,GiaTien)
values ('HD0001','P00001','1','2020-05-04','2020-06-20',N'Đĩa','10','50000');
insert into HOP_DONG_PHIM(MaHopDong,MaPhim,PhienBan,NgayBatDauBanQuyen,NgayKetThucBanQuyen,Donvitinh,SoLuong,GiaTien)
values ('HD0001','P00001','0','2020-06-21','2020-06-30',N'Đĩa','10','20000');
insert into HOP_DONG_PHIM(MaHopDong,MaPhim,PhienBan,NgayBatDauBanQuyen,NgayKetThucBanQuyen,Donvitinh,SoLuong,GiaTien)
values ('HD0001','P00002','0','2020-08-30','2022-11-30',N'Đĩa','10','30000');
insert into HOP_DONG_PHIM(MaHopDong,MaPhim,PhienBan,NgayBatDauBanQuyen,NgayKetThucBanQuyen,Donvitinh,SoLuong,GiaTien)
values ('HD0001','P00003','0','2020-12-30','2022-12-30',N'Đĩa','10','50000');
insert into HOP_DONG_PHIM(MaHopDong,MaPhim,PhienBan,NgayBatDauBanQuyen,NgayKetThucBanQuyen,Donvitinh,SoLuong,GiaTien)
values ('HD0002','P00004','0','2020-12-30','2022-12-30',N'Đĩa','10','45000');
insert into HOP_DONG_PHIM(MaHopDong,MaPhim,PhienBan,NgayBatDauBanQuyen,NgayKetThucBanQuyen,Donvitinh,SoLuong,GiaTien)
values ('HD0002','P00005','0','2020-12-30','2022-12-30',N'Đĩa','10','45000');
----- Đã xong
-----37. Hợp đồng cung cấp thức ăn
insert into HOP_DONG_THUC_AN(MaHopDong,MaThucAn,GiaTien,DonViTinh,SoLuong)
values ('HD0005','TA0001','50000',N'Gói','200');
insert into HOP_DONG_THUC_AN(MaHopDong,MaThucAn,GiaTien,DonViTinh,SoLuong)
values ('HD0005','TA0002','50000',N'Thùng','20');
insert into HOP_DONG_THUC_AN(MaHopDong,MaThucAn,GiaTien,DonViTinh,SoLuong)
values ('HD0006','TA0004','55000',N'Thùng','40');
insert into HOP_DONG_THUC_AN(MaHopDong,MaThucAn,GiaTien,DonViTinh,SoLuong)
values ('HD0006','TA0003','65000',N'Gói','150');
insert into HOP_DONG_THUC_AN(MaHopDong,MaThucAn,GiaTien,DonViTinh,SoLuong)
values ('HD0006','TA0006','56000',N'Gói','200');
insert into HOP_DONG_THUC_AN(MaHopDong,MaThucAn,GiaTien,DonViTinh,SoLuong)
values ('HD0005','TA0005','56000',N'Thùng','200');
----- Đã xong
-----38. Vật tư trong phòng chiếu ----PC0001
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
values ('PC0004','VT0001',N'Cái','12');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0004','VT0002',N'Cái','28');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0004','VT0003',N'Cái','10');
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
values ('PC0005','VT0005',N'Cái','8');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0006','VT0001',N'Cái','8');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0006','VT0002',N'Cái','60');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0006','VT0003',N'Cái','8');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0006','VT0004',N'Cái','1');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0006','VT0005',N'Cái','4');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0007','VT0001',N'Cái','8');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0007','VT0002',N'Cái','85');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0007','VT0003',N'Cái','8');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0007','VT0004',N'Cái','1');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0007','VT0005',N'Cái','4');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0008','VT0001',N'Cái','8');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0008','VT0002',N'Cái','60');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0008','VT0003',N'Cái','8');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0008','VT0004',N'Cái','1');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0008','VT0005',N'Cái','4');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0009','VT0001',N'Cái','3');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0009','VT0002',N'Cái','60');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0009','VT0003',N'Cái','8');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0009','VT0004',N'Cái','1');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0009','VT0005',N'Cái','4');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0010','VT0001',N'Cái','4');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0010','VT0002',N'Cái','60');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0010','VT0003',N'Cái','8');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0010','VT0004',N'Cái','1');
insert into CHI_TIET_PHONG_CHIEU(MaPhongChieu,MaVatTu,DonViTinh,SoLuongSP)
values ('PC0010','VT0005',N'Cái','4');
----- Đã xong
--39. Chi tiết diễn viên, đạo diễn
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00001','P00001','C');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00002','P00001','P');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00003','P00002','C');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00001','P00002','P');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00007','P00003','C');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00008','P00003','P');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00005','P00004','C');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00002','P00004','P');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00006','P00005','C');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00001','P00005','P');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00008','P00006','C');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00001','P00006','P');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00003','P00007','C');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00005','P00007','P');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00002','P00008','C');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00004','P00008','P');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00001','P00009','C');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00007','P00009','P');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00007','P00010','C');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00001','P00010','P');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00004','P00011','C');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00007','P00011','P');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00005','P00012','C');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00004','P00012','P');
---Đã xong

