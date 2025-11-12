INSERT INTO KHACHHANG (TenTaiKhoan, MatKhau, VaiTro)
VALUES
('admin', '123456', 'Admin'),
('duc123', '123456', 'User'),
('khanhnguyen', '123456', 'User');

INSERT INTO SANPHAM (TenSP, Gia, HinhAnh, MoTa) 
VALUES 
-- Nhóm cà phê
(N'Cà phê đen đá', 22000, 'cfden', N'Cà phê đậm vị, không đường, pha phin truyền thống'), 
(N'Cà phê sữa đá', 25000, 'cfsuada', N'Cà phê pha phin, vị béo ngọt hài hòa'), 
(N'Cà phê nâu', 40000, 'cfnau', N'Cà phê đậm đà, sánh quyện cùng sữa đặc'), 
(N'Cà phê cốt dừa', 22000, 'cfcotdua', N'Cà phê pha cùng nước cốt dừa thơm béo lạ miệng'),
(N'Cà phê trứng', 35000, 'cftrung', N'Cà phê đậm vị kết hợp lớp kem trứng béo mịn'), 
(N'Bạc xỉu', 20000, 'bacxiu', N'Cà phê sữa nhẹ, thơm dịu, phù hợp với mọi lứa tuổi'),

-- Nhóm trà & nước giải khát
(N'Trà đào cam sả', 35000, 'tradao', N'Trà đào kết hợp cam và sả, hương vị tươi mát'), 
(N'Nước cam', 35000, 'cam', N'Nước cam tươi nguyên chất, bổ sung vitamin C'), 
(N'Nước chanh leo', 30000, 'chanhleo', N'Nước chanh leo chua ngọt, thanh mát'), 
(N'Dưa hấu ép', 30000, 'duahau', N'Nước ép dưa hấu tươi, ngọt dịu tự nhiên'),

-- Nhóm bánh & tráng miệng
(N'Bánh cheesecake', 30000, 'cheesecake', N'Bánh mềm mịn, vị phô mai béo nhẹ'), 
(N'Sữa chua hoa quả', 35000, 'suachuahoaqua', N'Sữa chua tươi kết hợp hoa quả, thanh mát bổ dưỡng');


INSERT INTO DONHANG (MaKH, TongTien, TrangThai)
VALUES
(1, 75000, N'Hoàn thành'),
(2, 40000, N'Hoàn thành'),
(3, 65000, N'Đang xử lý');

INSERT INTO CHITIETDONHANG (MaHD, MaSP, SoLuong, DonGiaBan)
VALUES
(1, 1, 1, 35000),
(1, 3, 1, 40000),
(2, 5, 1, 25000),
(3, 2, 1, 42000),
(3, 4, 1, 30000);

INSERT INTO DANHGIA (MaKH, DiemPhucVu, DiemChatLuong, DiemKhongGian, DiemDaDang, GopY)
VALUES
(1, 5, 5, 4, 5, N'Quán ổn, nhân viên thân thiện'),
(2, 4, 4, 4, 4, N'Ổn, nhưng phục vụ hơi chậm'),
(3, 5, 5, 5, 5, N'Tuyệt vời');

