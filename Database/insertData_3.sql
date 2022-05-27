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

--
insert into PHIM (TenPhim,AnhPhim,ThoiLuong,QuocGia,NamSanXuat,MaHangSanXuatPhim ,DoTuoiXem,MaTheLoai ,NoiDung) 
values(N'30 Chưa Phải Là Tết',null,'137',N'Việt Nam','2022-01-22','HSXP00004',13,'TLP004',N'Cuộc về Tết bất ngờ');
insert into PHIM (TenPhim,AnhPhim,ThoiLuong,QuocGia,NamSanXuat,MaHangSanXuatPhim ,DoTuoiXem,MaTheLoai ,NoiDung) 
values(N'Tàng Hải Hoa',null,'120',N'Trung Quốc','2021-12-22','HSXP00005',16,'TLP005',N'Đạo mộ cùng Ngô Tà');
insert into PHIM (TenPhim,AnhPhim,ThoiLuong,QuocGia,NamSanXuat,MaHangSanXuatPhim ,DoTuoiXem,MaTheLoai ,NoiDung) 
values(N'Đại Hồng Thủy',null,'125',N'Anh','2020-09-22','HSXP00003',16,'TLP004',N'Đại hồng thủy trong lịch sử nhân loại');

---- Đã xong
--9.Loai Hop Dong  -------- LHD001
insert into LOAI_HOP_DONG(TenLoaiHopDong) values (N'Hợp đồng phim');
insert into LOAI_HOP_DONG(TenLoaiHopDong) values (N'Hợp đồng vật tư');
insert into LOAI_HOP_DONG(TenLoaiHopDong) values (N'Hợp đồng thức ăn');
---- Đã xong
--10.Hop dong  ------------ HD0001
insert into HOP_DONG(TenHopDong ,MaNhaCungCap ,NgayKiKetHD , MaLoaiHopDong)
values (N'Hợp đồng 1', 'NCC001', '2022-04-30', 'LHD001' );
insert into HOP_DONG(TenHopDong ,MaNhaCungCap ,NgayKiKetHD , MaLoaiHopDong)
values (N'Hợp đồng 2', 'NCC002', '2022-04-30', 'LHD001' );
insert into HOP_DONG(TenHopDong ,MaNhaCungCap ,NgayKiKetHD , MaLoaiHopDong)
values (N'Hợp đồng 3', 'NCC005', '2022-04-30', 'LHD002' );
insert into HOP_DONG(TenHopDong ,MaNhaCungCap ,NgayKiKetHD , MaLoaiHopDong)
values (N'Hợp đồng 4', 'NCC006', '2022-04-30', 'LHD002' );
insert into HOP_DONG(TenHopDong ,MaNhaCungCap ,NgayKiKetHD , MaLoaiHopDong)
values (N'Hợp đồng 5', 'NCC010', '2022-05-18', 'LHD003' );
insert into HOP_DONG(TenHopDong ,MaNhaCungCap ,NgayKiKetHD , MaLoaiHopDong)
values (N'Hợp đồng 6', 'NCC011', '2022-05-20', 'LHD003' );
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
insert into PHONG_CHIEU(TenPhong,MaTinhTrang, MaLoaiPhongChieu) values (N'Phòng số 6','1','LPC004');
---- Đã xong
------12. Khung giờ chiếu -----------KGC00001  
insert into KHUNG_GIO_CHIEU(TenKhungGio,TGBatDau,TGKetThuc) values(N'Khung giờ số 1','08:00:00.0000000','11:00:00.0000000');
insert into KHUNG_GIO_CHIEU(TenKhungGio,TGBatDau,TGKetThuc) values(N'Khung giờ số 2','11:00:00.0000000','14:00:00.0000000');
insert into KHUNG_GIO_CHIEU(TenKhungGio,TGBatDau,TGKetThuc) values(N'Khung giờ số 3','14:00:00.0000000','17:00:00.0000000');
insert into KHUNG_GIO_CHIEU(TenKhungGio,TGBatDau,TGKetThuc) values(N'Khung giờ số 4','17:00:00.0000000','20:00:00.0000000');
insert into KHUNG_GIO_CHIEU(TenKhungGio,TGBatDau,TGKetThuc) values(N'Khung giờ số 5','20:00:00.0000000','23:00:00.0000000');
----Đã xong
------13.Lịch chiếu
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00001','PC0002','KGC00001','2022-05-20','1');
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00001','PC0002','KGC00002','2022-05-20','1');
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00001','PC0002','KGC00004','2022-05-20','2');
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00001','PC0002','KGC00003','2022-05-20','0');
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00001','PC0003','KGC00001','2022-05-20','2');
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00001','PC0003','KGC00002','2022-05-20','2');
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00001','PC0003','KGC00004','2022-05-20','1');
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00002','PC0003','KGC00003','2022-05-20','0');

insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00002','PC0002','KGC00001','2022-05-21','0');
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00003','PC0002','KGC00002','2022-05-21','1');
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00001','PC0002','KGC00004','2022-05-21','2');
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00001','PC0002','KGC00003','2022-05-21','0');
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00001','PC0003','KGC00001','2022-05-21','1');
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00001','PC0003','KGC00002','2022-05-21','2');
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00001','PC0003','KGC00004','2022-05-21','1');
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00002','PC0003','KGC00003','2022-05-21','0');

insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00004','PC0005','KGC00001','2022-05-21','0');
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00005','PC0005','KGC00002','2022-05-21','1');
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00005','PC0005','KGC00004','2022-05-21','1');
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00005','PC0005','KGC00003','2022-05-21','2');

insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00001','PC0006','KGC00001','2022-05-21','1');
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00001','PC0006','KGC00002','2022-05-21','2');
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00001','PC0006','KGC00004','2022-05-21','1');
insert into LICH_CHIEU(MaPhim,MaPhongChieu,MaKhungGioChieu,NgayChieu,TrangThai) VALUES('P00002','PC0006','KGC00003','2022-05-21','0');
----- Đã xong
----- Đã xong
------14.Ca làm việc ----- CLV001
insert into CA_LAM_VIEC(TenCa,GioBatDau,GioKetThuc) values(N'Ca 1','08:00:00.0000000','12:00:00.0000000');
insert into CA_LAM_VIEC(TenCa,GioBatDau,GioKetThuc) values(N'Ca 2','12:00:00.0000000','16:00:00.0000000');
insert into CA_LAM_VIEC(TenCa,GioBatDau,GioKetThuc) values(N'Ca 3','16:00:00.0000000','20:00:00.0000000');
insert into CA_LAM_VIEC(TenCa,GioBatDau,GioKetThuc) values(N'Ca 4','20:00:00.0000000','23:59:59.0000000');
----Đã xong

---- Đã xong
------16. Chính sách ------- CS0001
insert into CHINH_SACH(TenChinhSach,HeSoLuong,BHXH,TienThuong) values ('Khá','1','6 thang','200000');
insert into CHINH_SACH(TenChinhSach,HeSoLuong,BHXH,TienThuong) values ('Xuất Sắc','2','2 nam','300000');
insert into CHINH_SACH(TenChinhSach,HeSoLuong,BHXH,TienThuong) values ('Giỏi','3','1 nam','400000');
----- Đã xong
-----17.Chức vụ ------ CV0001
insert into CHUC_VU(TenChucVu) values (N'Quản lý phim');
insert into CHUC_VU(TenChucVu) values (N'Quản lý vật tư');
insert into CHUC_VU(TenChucVu) values (N'Quản trị viên');
----- Đã xong
------18.Nhân viên ----- NV0001 (10 NV), 4P, 4VT, 2admin
insert into NHAN_VIEN(TenNhanVien,NgaySinh,GioiTinh,DiaChi,SoDienThoai,CCCD,TenTaiKhoan,MatKhau,MaChinhSach,MaChucVu)--123456789
Values (N'Phạm Khắc Luận','2002-04-20','0',N'Huế','0982756449','046205010716','luanqlp','e10adc3949ba59abbe56e057f20f883e','CS0002','CV0001');
insert into NHAN_VIEN(TenNhanVien,NgaySinh,GioiTinh,DiaChi,SoDienThoai,CCCD,TenTaiKhoan,MatKhau,MaChinhSach,MaChucVu)--123456789
Values (N'Phạm Chính Hải','2002-08-20','0',N'Huế','0982758887','046202010716','haiqlp','e10adc3949ba59abbe56e057f20f883e','CS0002','CV0001');
insert into NHAN_VIEN(TenNhanVien,NgaySinh,GioiTinh,DiaChi,SoDienThoai,CCCD,TenTaiKhoan,MatKhau,MaChinhSach,MaChucVu)--123456789
Values (N'Lê Duy Quý','2001-04-20','0',N'Quảng Nam','0988752737','046202019128','quyqlp','e10adc3949ba59abbe56e057f20f883e','CS0002','CV0001');
insert into NHAN_VIEN(TenNhanVien,NgaySinh,GioiTinh,DiaChi,SoDienThoai,CCCD,TenTaiKhoan,MatKhau,MaChinhSach,MaChucVu)--123456
Values (N'Trương Khởi Linh','2002-09-12','1',N'Hà Nội','0356285861','046201910842','linhqlp','e10adc3949ba59abbe56e057f20f883e','CS0002','CV0001');
insert into NHAN_VIEN(TenNhanVien,NgaySinh,GioiTinh,DiaChi,SoDienThoai,CCCD,TenTaiKhoan,MatKhau,MaChinhSach,MaChucVu)--987654321
Values (N'Trần Trung Hiếu','2002-03-01','0',N'Quảng Trị','0982782647','046202011112','hieuqlvt','e10adc3949ba59abbe56e057f20f883e','CS0002','CV0002');
insert into NHAN_VIEN(TenNhanVien,NgaySinh,GioiTinh,DiaChi,SoDienThoai,CCCD,TenTaiKhoan,MatKhau,MaChinhSach,MaChucVu)--123456
Values (N'Trần Hải Phong','2002-03-12','1',N'Đà Nẵng','0359235856','046202510866','phongqlvt','e10adc3949ba59abbe56e057f20f883e','CS0002','CV0002');
insert into NHAN_VIEN(TenNhanVien,NgaySinh,GioiTinh,DiaChi,SoDienThoai,CCCD,TenTaiKhoan,MatKhau,MaChinhSach,MaChucVu)--123456
Values (N'Trương Hải Khách','2002-03-12','1',N'Đà Nẵng','0359237152','04619253039','khachqlvt','e10adc3949ba59abbe56e057f20f883e','CS0002','CV0002');
insert into NHAN_VIEN(TenNhanVien,NgaySinh,GioiTinh,DiaChi,SoDienThoai,CCCD,TenTaiKhoan,MatKhau,MaChinhSach,MaChucVu)--123456
Values (N'Huỳnh Thế Anh','2002-12-12','1',N'Đà Nẵng','0359235856','046202510856','anhqlvt','e10adc3949ba59abbe56e057f20f883e','CS0002','CV0002');
insert into NHAN_VIEN(TenNhanVien,NgaySinh,GioiTinh,DiaChi,SoDienThoai,CCCD,TenTaiKhoan,MatKhau,MaChinhSach,MaChucVu)--123456
Values (N'Lê Văn Hào','2002-02-22','1',N'Huế','0827582932','046202010711','haoadmin','e10adc3949ba59abbe56e057f20f883e','CS0003','CV0003');
insert into NHAN_VIEN(TenNhanVien,NgaySinh,GioiTinh,DiaChi,SoDienThoai,CCCD,TenTaiKhoan,MatKhau,MaChinhSach,MaChucVu)--123456
Values (N'Trần Văn Hữu','2002-02-12','1',N'Huế','0359235204','046202010816','huuadmin','e10adc3949ba59abbe56e057f20f883e','CS0003','CV0003');

-----Đã xong
------19. lịch làm việc
insert into LICH_LAM_VIEC(MaNhanVien,MaCa,NgayLamViec) values ('NV0001','CLV001','2022-01-27');
insert into LICH_LAM_VIEC(MaNhanVien,MaCa,NgayLamViec) values ('NV0005','CLV001','2022-01-27');
insert into LICH_LAM_VIEC(MaNhanVien,MaCa,NgayLamViec) values ('NV0006','CLV001','2022-01-27');
insert into LICH_LAM_VIEC(MaNhanVien,MaCa,NgayLamViec) values ('NV0009','CLV001','2022-01-27');
insert into LICH_LAM_VIEC(MaNhanVien,MaCa,NgayLamViec) values ('NV0002','CLV002','2022-01-27');
insert into LICH_LAM_VIEC(MaNhanVien,MaCa,NgayLamViec) values ('NV0003','CLV002','2022-01-27');
insert into LICH_LAM_VIEC(MaNhanVien,MaCa,NgayLamViec) values ('NV0007','CLV002','2022-01-27');
insert into LICH_LAM_VIEC(MaNhanVien,MaCa,NgayLamViec) values ('NV0009','CLV002','2022-01-27');
insert into LICH_LAM_VIEC(MaNhanVien,MaCa,NgayLamViec) values ('NV0001','CLV003','2022-01-27');
insert into LICH_LAM_VIEC(MaNhanVien,MaCa,NgayLamViec) values ('NV0004','CLV003','2022-01-27');
insert into LICH_LAM_VIEC(MaNhanVien,MaCa,NgayLamViec) values ('NV0003','CLV003','2022-01-27');
insert into LICH_LAM_VIEC(MaNhanVien,MaCa,NgayLamViec) values ('NV0002','CLV003','2022-01-27');
insert into LICH_LAM_VIEC(MaNhanVien,MaCa,NgayLamViec) values ('NV0008','CLV003','2022-01-27');
insert into LICH_LAM_VIEC(MaNhanVien,MaCa,NgayLamViec) values ('NV0010','CLV001','2022-01-27');

insert into LICH_LAM_VIEC(MaNhanVien,MaCa,NgayLamViec) values ('NV0003','CLV001','2022-01-28');
insert into LICH_LAM_VIEC(MaNhanVien,MaCa,NgayLamViec) values ('NV0005','CLV001','2022-01-28');
insert into LICH_LAM_VIEC(MaNhanVien,MaCa,NgayLamViec) values ('NV0008','CLV001','2022-01-28');
insert into LICH_LAM_VIEC(MaNhanVien,MaCa,NgayLamViec) values ('NV0010','CLV001','2022-01-28');
insert into LICH_LAM_VIEC(MaNhanVien,MaCa,NgayLamViec) values ('NV0004','CLV002','2022-01-28');
insert into LICH_LAM_VIEC(MaNhanVien,MaCa,NgayLamViec) values ('NV0001','CLV002','2022-01-28');
insert into LICH_LAM_VIEC(MaNhanVien,MaCa,NgayLamViec) values ('NV0007','CLV002','2022-01-28');
insert into LICH_LAM_VIEC(MaNhanVien,MaCa,NgayLamViec) values ('NV0009','CLV002','2022-01-28');
insert into LICH_LAM_VIEC(MaNhanVien,MaCa,NgayLamViec) values ('NV0001','CLV003','2022-01-28');
insert into LICH_LAM_VIEC(MaNhanVien,MaCa,NgayLamViec) values ('NV0002','CLV003','2022-01-28');
insert into LICH_LAM_VIEC(MaNhanVien,MaCa,NgayLamViec) values ('NV0003','CLV003','2022-01-28');
insert into LICH_LAM_VIEC(MaNhanVien,MaCa,NgayLamViec) values ('NV0006','CLV003','2022-01-28');
insert into LICH_LAM_VIEC(MaNhanVien,MaCa,NgayLamViec) values ('NV0009','CLV001','2022-01-28');
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
insert into KHO(MaLoaiKho,TenKho) values ('LK002',N'Kho số 4');
insert into KHO(MaLoaiKho,TenKho) values ('LK003',N'Kho số 5');
----- Đã xong
-----22. Chi tiết kho phim
insert into CHI_TIET_KHO_PHIM(MaKho,MaPhim,DonViTinh,SoLuongSP) values ('K0001','P00001',N'Đĩa','10');
insert into CHI_TIET_KHO_PHIM(MaKho,MaPhim,DonViTinh,SoLuongSP) values ('K0001','P00002',N'Đĩa','10');
insert into CHI_TIET_KHO_PHIM(MaKho,MaPhim,DonViTinh,SoLuongSP) values ('K0001','P00003',N'Đĩa','10');
insert into CHI_TIET_KHO_PHIM(MaKho,MaPhim,DonViTinh,SoLuongSP) values ('K0001','P00004',N'Đĩa','10');
insert into CHI_TIET_KHO_PHIM(MaKho,MaPhim,DonViTinh,SoLuongSP) values ('K0001','P00005',N'Đĩa','10');

-----Đã xong
----23. Chi tiết kho vật tư
insert into CHI_TIET_KHO_VT(MaKho,MaVatTu,DonViTinh,SoLuongSP) values('K0002','VT0001',N'Cái','12');
insert into CHI_TIET_KHO_VT(MaKho,MaVatTu,DonViTinh,SoLuongSP) values('K0002','VT0002',N'Cái','10');
insert into CHI_TIET_KHO_VT(MaKho,MaVatTu,DonViTinh,SoLuongSP) values('K0002','VT0003',N'Cái','5');
insert into CHI_TIET_KHO_VT(MaKho,MaVatTu,DonViTinh,SoLuongSP) values('K0002','VT0004',N'Cái','6');
insert into CHI_TIET_KHO_VT(MaKho,MaVatTu,DonViTinh,SoLuongSP) values('K0002','VT0005',N'Cái','7');
insert into CHI_TIET_KHO_VT(MaKho,MaVatTu,DonViTinh,SoLuongSP) values('K0002','VT0006',N'Cái','2');

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
values ('NV0001','2022-05-02','LDX01');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0001','2022-05-08','LDX01');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0003','2022-05-02','LDX01');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0002','2022-05-02','LDX01');


insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0005','2022-05-02','LDX02');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0006','2022-05-16','LDX02');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0007','2022-05-24','LDX02');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0005','2022-05-10','LDX02');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0008','2022-05-12','LDX03');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0006','2022-05-22','LDX03');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0007','2022-05-02','LDX03');
insert into DE_XUAT(MaNhanVien,NgayDeXuat,MaLoaiDeXuat)
values ('NV0005','2022-05-23','LDX03');

---- Đã xong
----27. Chi tiết đề xuất phim
insert into CHI_TIET_DE_XUAT_PHIM(MaDeXuat,MaPhim,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0001','P00001',N'Đề nghị thêm Đĩa phim này','5',N'Đĩa','0');
insert into CHI_TIET_DE_XUAT_PHIM(MaDeXuat,MaPhim,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0001','P00008',N'Đề nghị thêm Đĩa phim này','8',N'Đĩa','1');
insert into CHI_TIET_DE_XUAT_PHIM(MaDeXuat,MaPhim,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0002','P00004',N'Đề nghị thêm Đĩa phim này','2',N'Đĩa','1');

insert into CHI_TIET_DE_XUAT_PHIM(MaDeXuat,MaPhim,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0003','P00009',N'Đề nghị thêm Đĩa phim này','5',N'Đĩa','3');
insert into CHI_TIET_DE_XUAT_PHIM(MaDeXuat,MaPhim,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0004','P00007',N'Đề nghị thêm Đĩa phim này','2',N'Đĩa','2');
insert into CHI_TIET_DE_XUAT_PHIM(MaDeXuat,MaPhim,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0004','P00002',N'Đề nghị thêm Đĩa phim này','2',N'Đĩa','2');
insert into CHI_TIET_DE_XUAT_PHIM(MaDeXuat,MaPhim,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0003','P00006',N'Đề nghị thêm Đĩa phim này','2',N'Đĩa','2');
-----Đã xong
----28. Chi tiết đề xuất thức ăn
insert into CHI_TIET_DE_XUAT_TA(MaDeXuat,MaThucAn,Noidung,DonViTinh,SoLuong,TinhTrang)
values ('DX0009','TA0001',N'Đề nghị mua thêm',N'Gói', '100','0');
insert into CHI_TIET_DE_XUAT_TA(MaDeXuat,MaThucAn,Noidung,DonViTinh,SoLuong,TinhTrang)
values ('DX0009','TA0002',N'Đề nghị mua thêm',N'Thùng', '10','1');
insert into CHI_TIET_DE_XUAT_TA(MaDeXuat,MaThucAn,Noidung,DonViTinh,SoLuong,TinhTrang)
values ('DX0010','TA0003',N'Đề nghị mua thêm',N'Gói', '105','0');
insert into CHI_TIET_DE_XUAT_TA(MaDeXuat,MaThucAn,Noidung,DonViTinh,SoLuong,TinhTrang)
values ('DX0011','TA0004',N'Đề nghị mua thêm',N'Thùng', '20','3');
insert into CHI_TIET_DE_XUAT_TA(MaDeXuat,MaThucAn,Noidung,DonViTinh,SoLuong,TinhTrang)
values ('DX0011','TA0005',N'Đề nghị mua thêm',N'Thùng', '20','2');
insert into CHI_TIET_DE_XUAT_TA(MaDeXuat,MaThucAn,Noidung,DonViTinh,SoLuong,TinhTrang)
values ('DX0012','TA0006',N'Đề nghị mua thêm',N'Gói', '200','2');
insert into CHI_TIET_DE_XUAT_TA(MaDeXuat,MaThucAn,Noidung,DonViTinh,SoLuong,TinhTrang)
values ('DX0012','TA0002',N'Đề nghị mua thêm',N'Thùng', '25','2');
----- Đã xong
----29. Chi tiết đề xuất vật tư
insert into CHI_TIET_DE_XUAT_VT(MaDeXuat,MaVatTu,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0005','VT0001',N'Đề nghị mua thêm','2',N'Cái','1');
insert into CHI_TIET_DE_XUAT_VT(MaDeXuat,MaVatTu,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0005','VT0002',N'Đề nghị mua thêm','3',N'Cái','1');
insert into CHI_TIET_DE_XUAT_VT(MaDeXuat,MaVatTu,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0006','VT0003',N'Đề nghị mua thêm','4',N'Cái','0');
insert into CHI_TIET_DE_XUAT_VT(MaDeXuat,MaVatTu,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0006','VT0004',N'Đề nghị mua thêm','2',N'Cái','1');
insert into CHI_TIET_DE_XUAT_VT(MaDeXuat,MaVatTu,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0006','VT0005',N'Đề nghị mua thêm','5',N'Cái','0');
insert into CHI_TIET_DE_XUAT_VT(MaDeXuat,MaVatTu,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0007','VT0002',N'Đề nghị mua thêm','2',N'Cái','1');
insert into CHI_TIET_DE_XUAT_VT(MaDeXuat,MaVatTu,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0007','VT0004',N'Đề nghị mua thêm','6',N'Cái','1');
insert into CHI_TIET_DE_XUAT_VT(MaDeXuat,MaVatTu,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0008','VT0001',N'Đề nghị mua thêm','5',N'Cái','2');
insert into CHI_TIET_DE_XUAT_VT(MaDeXuat,MaVatTu,Noidung,SoLuong,DonViTinh,TinhTrang)
values ('DX0008','VT0003',N'Đề nghị mua thêm','10',N'Cái','2');
----- Đã xong
-----30. Loại phiếu--------LP0001
insert into LOAI_PHIEU(TenLoaiPhieu) values (N'Phiếu nhập');
insert into LOAI_PHIEU(TenLoaiPhieu) values (N'Phiếu xuất');
----- Đã xong
-----31. Phiếu--------PH0001	12phieu

insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)	-- xuat TA 001
values ('LP002','2022-04-04','K0003','NV0005');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)	-- xuat  TA 002
values ('LP002','2022-01-05','K0003','NV0005');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)	--nhap thuc an 0003
values ('LP001','2022-04-03','K0003','NV0005');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)	--nhap thuc an 0004
values ('LP001','2022-05-03','K0003','NV0006');

insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)	--nhap phim 0005
values ('LP001','2022-01-05','K0001','NV0001');					
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)	--nhap phim 006
values ('LP001','2022-01-07','K0001','NV0001');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)	-- nhap phim 007
values ('LP001','2022-01-08','K0001','NV0002');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)	-- nhap phim 008
values ('LP001','2022-01-09','K0001','NV0001');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)	-- xuat phim 09
values ('LP002','2022-01-08','K0001','NV0003');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)	-- xuat phim 010
values ('LP002','2022-01-06','K0001','NV0002');		

insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)	--nhap vt 00011
values ('LP001','2022-01-04','K0002','NV0006');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)	--nhap vt 00012
values ('LP001','2022-01-04','K0002','NV0007');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)	--xuat vt 00013
values ('LP002','2022-01-04','K0002','NV0008');
insert into PHIEU(MaLoaiPhieu,NgayLapPhieu,MaKho,MaNhanVien)	--xuat vt 00014
values ('LP002','2022-01-04','K0002','NV0006');

---- Đã xong
-----32. Chi tiết phiếu phim
insert into CHI_TIET_PHIEU_PHIM(MaPhieu,MaPhim,DonViTinh,SoLuong) values('PH0005','P00001',N'Đĩa','3');
insert into CHI_TIET_PHIEU_PHIM(MaPhieu,MaPhim,DonViTinh,SoLuong) values('PH0005','P00002',N'Đĩa','3');
insert into CHI_TIET_PHIEU_PHIM(MaPhieu,MaPhim,DonViTinh,SoLuong) values('PH0005','P00003',N'Đĩa','10');

insert into CHI_TIET_PHIEU_PHIM(MaPhieu,MaPhim,DonViTinh,SoLuong) values('PH0006','P00001',N'Đĩa','3');
insert into CHI_TIET_PHIEU_PHIM(MaPhieu,MaPhim,DonViTinh,SoLuong) values('PH0006','P00002',N'Đĩa','3');
insert into CHI_TIET_PHIEU_PHIM(MaPhieu,MaPhim,DonViTinh,SoLuong) values('PH0006','P00004',N'Đĩa','5');

insert into CHI_TIET_PHIEU_PHIM(MaPhieu,MaPhim,DonViTinh,SoLuong) values('PH0007','P00001',N'Đĩa','2');
insert into CHI_TIET_PHIEU_PHIM(MaPhieu,MaPhim,DonViTinh,SoLuong) values('PH0007','P00002',N'Đĩa','2');
insert into CHI_TIET_PHIEU_PHIM(MaPhieu,MaPhim,DonViTinh,SoLuong) values('PH0007','P00004',N'Đĩa','5');

insert into CHI_TIET_PHIEU_PHIM(MaPhieu,MaPhim,DonViTinh,SoLuong) values('PH0008','P00001',N'Đĩa','2');
insert into CHI_TIET_PHIEU_PHIM(MaPhieu,MaPhim,DonViTinh,SoLuong) values('PH0008','P00002',N'Đĩa','2');
insert into CHI_TIET_PHIEU_PHIM(MaPhieu,MaPhim,DonViTinh,SoLuong) values('PH0008','P00005',N'Đĩa','10');

insert into CHI_TIET_PHIEU_PHIM(MaPhieu,MaPhim,DonViTinh,SoLuong) values('PH0009','P00005',N'Đĩa','2');
insert into CHI_TIET_PHIEU_PHIM(MaPhieu,MaPhim,DonViTinh,SoLuong) values('PH0009','P00003',N'Đĩa','1');

insert into CHI_TIET_PHIEU_PHIM(MaPhieu,MaPhim,DonViTinh,SoLuong) values('PH0010','P00004',N'Đĩa','1');
insert into CHI_TIET_PHIEU_PHIM(MaPhieu,MaPhim,DonViTinh,SoLuong) values('PH0010','P00003',N'Đĩa','1');
----- Đã xong
-----33. Chi tiết phiếu vật tư
insert into CHI_TIET_PHIEU_VT(MaPhieu,MaVatTu,DonViTinh,SoLuong) values('PH0011','VT0001',N'Cái','4');
insert into CHI_TIET_PHIEU_VT(MaPhieu,MaVatTu,DonViTinh,SoLuong) values('PH0011','VT0002',N'Cái','20');
insert into CHI_TIET_PHIEU_VT(MaPhieu,MaVatTu,DonViTinh,SoLuong) values('PH0011','VT0003',N'Cái','15');
insert into CHI_TIET_PHIEU_VT(MaPhieu,MaVatTu,DonViTinh,SoLuong) values('PH0011','VT0004',N'Cái','10')

insert into CHI_TIET_PHIEU_VT(MaPhieu,MaVatTu,DonViTinh,SoLuong) values('PH0012','VT0001',N'Cái','10');
insert into CHI_TIET_PHIEU_VT(MaPhieu,MaVatTu,DonViTinh,SoLuong) values('PH0012','VT0002',N'Cái','12');
insert into CHI_TIET_PHIEU_VT(MaPhieu,MaVatTu,DonViTinh,SoLuong) values('PH0012','VT0005',N'Cái','10');
insert into CHI_TIET_PHIEU_VT(MaPhieu,MaVatTu,DonViTinh,SoLuong) values('PH0012','VT0006',N'Cái','7')

insert into CHI_TIET_PHIEU_VT(MaPhieu,MaVatTu,DonViTinh,SoLuong) values('PH0013','VT0001',N'Cái','3');
insert into CHI_TIET_PHIEU_VT(MaPhieu,MaVatTu,DonViTinh,SoLuong) values('PH0013','VT0002',N'Cái','2');
insert into CHI_TIET_PHIEU_VT(MaPhieu,MaVatTu,DonViTinh,SoLuong) values('PH0013','VT0005',N'Cái','2');
insert into CHI_TIET_PHIEU_VT(MaPhieu,MaVatTu,DonViTinh,SoLuong) values('PH0013','VT0006',N'Cái','2')

insert into CHI_TIET_PHIEU_VT(MaPhieu,MaVatTu,DonViTinh,SoLuong) values('PH0014','VT0001',N'Cái','1');
insert into CHI_TIET_PHIEU_VT(MaPhieu,MaVatTu,DonViTinh,SoLuong) values('PH0014','VT0002',N'Cái','2');
insert into CHI_TIET_PHIEU_VT(MaPhieu,MaVatTu,DonViTinh,SoLuong) values('PH0014','VT0003',N'Cái','2');
insert into CHI_TIET_PHIEU_VT(MaPhieu,MaVatTu,DonViTinh,SoLuong) values('PH0014','VT0004',N'Cái','2')

---- Đã xong
-----34. Chi tiết phiếu thức ăn
insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong)
values('PH0001','TA0001',N'Gói','10');
insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong)
values('PH0001','TA0002',N'Thùng','5');
insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong)
values('PH0001','TA0003',N'Gói','10');
insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong)
values('PH0001','TA0004',N'Thùng','5');

insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong)
values('PH0002','TA0001',N'Gói','10');
insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong)
values('PH0002','TA0005',N'Thùng','5');
insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong)
values('PH0002','TA0003',N'Gói','10');
insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong)
values('PH0002','TA0006',N'Thùng','5');

insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong)
values('PH0003','TA0001',N'Gói','10');
insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong)
values('PH0003','TA0002',N'Thùng','7');
insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong)
values('PH0003','TA0003',N'Gói','15');
insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong)
values('PH0003','TA0004',N'Thùng','5');
insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong)
values('PH0003','TA0005',N'Thùng','15');

insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong)
values('PH0004','TA0001',N'Gói','10');
insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong)
values('PH0004','TA0002',N'Thùng','7');
insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong)
values('PH0004','TA0003',N'Gói','3');
insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong)
values('PH0004','TA0004',N'Thùng','10');
insert into CHI_TIET_PHIEU_THUC_AN(MaPhieu,MaThucAn,DonViTinh,SoLuong)
values('PH0004','TA0006',N'Thùng','15');
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


----- Đã xong
--39. Chi tiết diễn viên, đạo diễn
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00001','P00001','C');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00002','P00001','P');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00002','P00001','D');

insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00003','P00002','C');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00001','P00002','P');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00006','P00002','D');

insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00007','P00003','C');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00008','P00003','P');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00002','P00003','D');

insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00005','P00004','C');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00002','P00004','P');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00003','P00004','D');


insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00006','P00005','C');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00001','P00005','P');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00003','P00005','D'); 

insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00008','P00006','C');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00001','P00006','P');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00001','P00006','D');

insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00003','P00007','C');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00005','P00007','P');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00004','P00007','C');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00006','P00007','D');

insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00002','P00008','C');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00004','P00008','P');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00004','P00008','D');

insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00001','P00009','C');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00007','P00009','P');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00007','P00009','D');

insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00007','P00010','C');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00001','P00010','P');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00003','P00010','D');

insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00004','P00011','C');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00007','P00011','P');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00003','P00011','D');

insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00005','P00012','C');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00004','P00012','D');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00004','P00012','P');

insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00001','P00013','P');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00004','P00013','P');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00003','P00013','C');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00007','P00013','D');

insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00001','P00014','P');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00004','P00014','D');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00003','P00014','C');

insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00008','P00015','C');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00002','P00015','P');
insert into CHI_TIET_DIEN_VIEN_DAO_DIEN_PHIM (MaDienVienDaoDien,MaPhim,VaiTro)
values ('DVDD00001','P00015','D');
---Đã xong

