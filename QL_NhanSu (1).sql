CREATE DATABASE QL_NhanSu;
USE QL_NhanSu;

CREATE TABLE PHONGBAN(
    id_Pb NCHAR(10) PRIMARY KEY,
    name_Pb NVARCHAR(50),
    sonv_Pb INT,
    mota_Pb NVARCHAR(100)
);

INSERT INTO PHONGBAN
VALUES ('PB001', N'Phòng Kế Toán', 6, N'Phòng ban kế toán của công ty'),
       ('PB002', N'Phòng Kỹ Thuật', 3, N'Phòng ban kỹ thuật của công ty'),
       ('PB003', N'Phòng Kinh Doanh', 8, N'Phòng ban kinh doanh của công ty'),
       ('PB004', N'Phòng Nhân Sự', 3, N'Phòng ban nhân sự của công ty');

CREATE TABLE DUAN(
    id_Da NCHAR(10) PRIMARY KEY,
    name_Da NVARCHAR(50),
    sonv_Da INT,
    mota_Da NVARCHAR(100)
);

INSERT INTO DUAN(id_Da, name_Da, sonv_Da, mota_Da)
VALUES ('DA001', N'Dự án 1', 8, N'Dự án phát triển phần mềm'),
       ('DA002', N'Dự án 2', 7, N'Dự án phát triển website'),
       ('DA003', N'Dự án 3', 5, N'Dự án phát triển ứng dụng di động');

CREATE TABLE NHANVIEN(
    id_Nv NCHAR(10) PRIMARY KEY,
    name_Nv NVARCHAR(50),
    ngaysinh_Nv DATE,
    diachi_Nv NVARCHAR(100),
    luong_Nv INT,
    id_Pb NCHAR(10) FOREIGN KEY REFERENCES PHONGBAN(id_Pb),
    id_Da NCHAR(10) FOREIGN KEY REFERENCES DUAN(id_Da)
);

INSERT INTO NHANVIEN
VALUES 
	('NV001', N'Nguyễn Văn A1', '1990-06-11', N'Huế', 10000000, 'PB001', 'DA001'),
	('NV002', N'Nguyễn Văn A2', '1980-12-01', N'Hà Nội', 12000000, 'PB001', 'DA001'),
	('NV003', N'Nguyễn Văn A3', '1984-02-19', N'Hải Phòng', 19000000, 'PB001', 'DA001'),
	('NV004', N'Nguyễn Văn A4', '1990-05-17', N'Lào Cai', 13000000, 'PB001', 'DA001'),
	('NV005', N'Nguyễn Văn A5', '1982-04-18', N'Đà Nẵng', 25000000, 'PB001', 'DA001'),
	('NV006', N'Nguyễn Văn A6', '1993-06-21', N'Hồ Chí Minh', 23000000, 'PB001', 'DA001'),
	('NV007', N'Nguyễn Văn A7', '1981-09-01', N'Cần Thơ', 15000000, 'PB002', 'DA001'),
	('NV008', N'Nguyễn Văn A8', '1983-11-02', N'Nha Trang', 10000000, 'PB002', 'DA001'),
	('NV009', N'Nguyễn Văn A9', '1995-10-20', N'Hồ Chí Minh', 23000000, 'PB002', 'DA002'),
	('NV010', N'Nguyễn Văn A10', '1992-12-10', N'Hà Nội', 22000000, 'PB003', 'DA002'),
	('NV011', N'Nguyễn Văn A11', '1992-08-02', N'Hải Phòng', 21000000, 'PB003', 'DA002'),
	('NV012', N'Nguyễn Văn A12', '1981-12-17', N'Hà Nội', 19000000, 'PB003', 'DA002'),
	('NV013', N'Nguyễn Văn A13', '1981-03-10', N'Đà Nẵng', 13000000, 'PB003', 'DA002'),
	('NV014', N'Nguyễn Văn A14', '1986-03-12', N'Cần Thơ', 11000000, 'PB003', 'DA002'),
	('NV015', N'Nguyễn Văn A15', '1993-05-09', N'Hải Phòng', 20000000, 'PB003', 'DA002'),
	('NV016', N'Nguyễn Văn A16', '1992-09-23', N'Hà Nội', 23000000, 'PB003', 'DA003'),
	('NV017', N'Nguyễn Văn A17', '1982-03-30', N'Hà Nội', 18000000, 'PB003', 'DA003'),
	('NV018', N'Nguyễn Văn A18', '1988-04-14', N'Hà Nội', 20000000, 'PB004', 'DA003'),
	('NV019', N'Nguyễn Văn A19', '1989-06-02', N'Hồ Chí Minh', 17000000, 'PB004', 'DA003'),
	('NV020', N'Nguyễn Văn A20', '1994-07-08', N'Hồ Chí Minh', 24000000, 'PB004', 'DA003');


CREATE TABLE DANGNHAP(
    username NVARCHAR(50) PRIMARY KEY,
    password NVARCHAR(20),
	role int ,
    id_Nv NCHAR(10) FOREIGN KEY REFERENCES NHANVIEN(id_Nv)
);

INSERT INTO DANGNHAP
VALUES ('admin', 'admin', 1, 'NV020');

---------Trigger để kiểm tra số nhân viên trong mỗi dự án khi thêm hoặc cập nhật bảng DUAN
CREATE TRIGGER check_sonv_Da
ON DUAN
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @total INT;
    SELECT @total = COUNT(*) FROM NHANVIEN;
    IF (SELECT sonv_Da FROM INSERTED) > @total
    BEGIN
        PRINT N'Số nhân viên trong dự án không được vượt quá tổng số nhân viên.'
        ROLLBACK TRANSACTION;
    END
END;

-----Trigger để cập nhật số nhân viên trong PHONGBAN khi thêm hoặc xóa nhân viên từ NHANVIEN
CREATE TRIGGER update_sonv_Pb
ON NHANVIEN
AFTER INSERT, DELETE
AS
BEGIN
    UPDATE PHONGBAN
    SET sonv_Pb = (SELECT COUNT(*) FROM NHANVIEN WHERE id_Pb = PHONGBAN.id_Pb);
END;

--------Trigger để ngăn không cho xóa PHONGBAN nếu vẫn còn nhân viên trong phòng ban đó
CREATE TRIGGER prevent_delete_Pb
ON PHONGBAN
INSTEAD OF DELETE
AS
BEGIN
    IF EXISTS (SELECT 1 FROM NHANVIEN WHERE id_Pb IN (SELECT id_Pb FROM DELETED))
    BEGIN
        PRINT N'Không thể xóa phòng ban khi vẫn còn nhân viên.'
        ROLLBACK TRANSACTION;
    END
    ELSE
    BEGIN
        DELETE FROM PHONGBAN WHERE id_Pb IN (SELECT id_Pb FROM DELETED);
    END
END;

---------Trigger để cập nhật số nhân viên trong DUAN khi thêm hoặc xóa nhân viên từ NHANVIEN
CREATE TRIGGER update_sonv_Da
ON NHANVIEN
AFTER INSERT, DELETE
AS
BEGIN
    UPDATE DUAN
    SET sonv_Da = (SELECT COUNT(*) FROM NHANVIEN WHERE id_Da = DUAN.id_Da);
END;

--------Trigger để ngăn không cho xóa DUAN nếu vẫn còn nhân viên trong dự án đó
CREATE TRIGGER prevent_delete_Da
ON DUAN
INSTEAD OF DELETE
AS
BEGIN
    IF EXISTS (SELECT 1 FROM NHANVIEN WHERE id_Da IN (SELECT id_Da FROM DELETED))
    BEGIN
        PRINT N'Không thể xóa dự án khi vẫn còn nhân viên.'
        ROLLBACK TRANSACTION;
    END
    ELSE
    BEGIN
        DELETE FROM DUAN WHERE id_Da IN (SELECT id_Da FROM DELETED);
    END
END;

---------Trigger để ngăn không cho thay đổi id_Pb của NHANVIEN nếu nhân viên đó đã có trong bảng DANGNHAP
CREATE TRIGGER prevent_update_id_Pb
ON NHANVIEN
INSTEAD OF UPDATE
AS
BEGIN
    IF EXISTS (SELECT 1 FROM DANGNHAP WHERE id_Nv IN (SELECT id_Nv FROM INSERTED))
    BEGIN
        PRINT N'Không thể thay đổi id_Pb của nhân viên khi nhân viên đó đã có trong bảng DANGNHAP.';
        ROLLBACK TRANSACTION;
    END
    ELSE
    BEGIN
        UPDATE NHANVIEN SET id_Pb = (SELECT id_Pb FROM INSERTED WHERE id_Nv = NHANVIEN.id_Nv) WHERE id_Nv IN (SELECT id_Nv FROM INSERTED);
    END
END;


----------Duy----------
--Lấy danh sách các nhân viên lớn hơn 30 tuổi
CREATE PROCEDURE sp_GetEmployeesOver30
AS
BEGIN
    SELECT id_Nv, name_Nv, ngaysinh_Nv
    FROM NHANVIEN
    WHERE DATEDIFF(YEAR, ngaysinh_Nv, GETDATE()) > 30;
END;

EXEC sp_GetEmployeesOver30;

CREATE FUNCTION fn_GetEmployeesOver30()
RETURNS TABLE
AS
RETURN 
(
    SELECT id_Nv, name_Nv, ngaysinh_Nv
    FROM NHANVIEN
    WHERE DATEDIFF(YEAR, ngaysinh_Nv, GETDATE()) > 30
);

SELECT * FROM fn_GetEmployeesOver30();

DECLARE @id_Nv NCHAR(10), @name_Nv NVARCHAR(50), @ngaysinh_Nv DATE;
DECLARE EmployeeCursor CURSOR FOR 
SELECT id_Nv, name_Nv, ngaysinh_Nv
FROM NHANVIEN
WHERE DATEDIFF(YEAR, ngaysinh_Nv, GETDATE()) > 30;

OPEN EmployeeCursor;
FETCH NEXT FROM EmployeeCursor INTO @id_Nv, @name_Nv, @ngaysinh_Nv;

WHILE @@FETCH_STATUS = 0 
BEGIN 
    PRINT 'ID: ' + @id_Nv + ', Name: ' + @name_Nv + ', Birthdate: ' + CONVERT(NVARCHAR, @ngaysinh_Nv, 101); 
    FETCH NEXT FROM EmployeeCursor INTO @id_Nv, @name_Nv, @ngaysinh_Nv; 
END;

CLOSE EmployeeCursor;
DEALLOCATE EmployeeCursor;

--Xuất mã nhân viên, họ tên và lương của nhân viên có lương cao nhất
CREATE PROCEDURE sp_GetHighestPaidEmployee
AS
BEGIN
    SELECT id_Nv, name_Nv, luong_Nv
    FROM NHANVIEN
    WHERE luong_Nv = (SELECT MAX(luong_Nv) FROM NHANVIEN);
END;

EXEC sp_GetHighestPaidEmployee;

CREATE FUNCTION fn_GetHighestPaidEmployee()
RETURNS TABLE
AS
RETURN 
(
    SELECT id_Nv, name_Nv, luong_Nv
    FROM NHANVIEN
    WHERE luong_Nv = (SELECT MAX(luong_Nv) FROM NHANVIEN)
);

SELECT * FROM fn_GetHighestPaidEmployee();

DECLARE @id_Nv NCHAR(10), @name_Nv NVARCHAR(50), @luong_Nv INT;
DECLARE HighestPaidEmployeeCursor CURSOR FOR 
SELECT id_Nv, name_Nv, luong_Nv
FROM NHANVIEN
WHERE luong_Nv = (SELECT MAX(luong_Nv) FROM NHANVIEN);

OPEN HighestPaidEmployeeCursor;
FETCH NEXT FROM HighestPaidEmployeeCursor INTO @id_Nv, @name_Nv, @luong_Nv;

WHILE @@FETCH_STATUS = 0 
BEGIN 
    PRINT 'ID: ' + @id_Nv + ', Name: ' + @name_Nv + ', Salary: ' + CAST(@luong_Nv AS NVARCHAR); 
    FETCH NEXT FROM HighestPaidEmployeeCursor INTO @id_Nv, @name_Nv, @luong_Nv; 
END;

CLOSE HighestPaidEmployeeCursor;
DEALLOCATE HighestPaidEmployeeCursor;

----------Tú----------
--Cập nhật lương nhân viên
CREATE PROCEDURE CapNhatLuongNhanVien
    @phongban NCHAR(10),
    @luong INT
AS
BEGIN
    UPDATE NHANVIEN
    SET luong_Nv = @luong
    WHERE id_Pb = @phongban;
END;

EXEC CapNhatLuongNhanVien @phongban = 'PB01', @luong = 5000;

--Tăng 20% lương cho tất cả nhân viên
DECLARE @id_Nv NCHAR(10), @luong_Nv INT;
DECLARE cur CURSOR FOR 
SELECT id_Nv, luong_Nv FROM NHANVIEN;
OPEN cur;
FETCH NEXT FROM cur INTO @id_Nv, @luong_Nv;
WHILE @@FETCH_STATUS = 0
BEGIN
    -- Cập nhật lương ở đây. Ví dụ: tăng lương 10%
    SET @luong_Nv = @luong_Nv * 1.2;
    UPDATE NHANVIEN SET luong_Nv = @luong_Nv WHERE id_Nv = @id_Nv;
    FETCH NEXT FROM cur INTO @id_Nv, @luong_Nv;
END;
CLOSE cur;
DEALLOCATE cur;

---Dự án có nhiều nhân viên nhất
CREATE PROCEDURE GetDuAnNhieuNhanVienNhat
AS
BEGIN
    SELECT TOP 1 DUAN.*
    FROM DUAN
    INNER JOIN NHANVIEN ON DUAN.id_Da = NHANVIEN.id_Da
    GROUP BY DUAN.id_Da, DUAN.name_Da, DUAN.sonv_Da, DUAN.mota_Da
    ORDER BY COUNT(NHANVIEN.id_Nv) DESC;
END;

EXEC GetDuAnNhieuNhanVienNhat;

CREATE FUNCTION danhieunv()
RETURNS TABLE
AS
RETURN 
(
    SELECT TOP 1 DUAN.*
    FROM DUAN
    INNER JOIN NHANVIEN ON DUAN.id_Da = NHANVIEN.id_Da
    GROUP BY DUAN.id_Da, DUAN.name_Da, DUAN.sonv_Da, DUAN.mota_Da
    ORDER BY COUNT(NHANVIEN.id_Nv) DESC
);

SELECT * FROM dbo.danhieunv();

DECLARE @id_Da NCHAR(10), @name_Da NVARCHAR(50), @sonv_Da INT, @mota_Da NVARCHAR(100);
-- Tạo bảng tạm thời
CREATE TABLE #tempTable (id_Da NCHAR(10), name_Da NVARCHAR(50), sonv_Da INT, mota_Da NVARCHAR(100));
DECLARE cur CURSOR FOR 
SELECT TOP 1 DUAN.id_Da, name_Da, sonv_Da, mota_Da
FROM DUAN
INNER JOIN NHANVIEN ON DUAN.id_Da = NHANVIEN.id_Da
GROUP BY DUAN.id_Da, DUAN.name_Da, DUAN.sonv_Da, DUAN.mota_Da
ORDER BY COUNT(NHANVIEN.id_Nv) DESC;
OPEN cur;
FETCH NEXT FROM cur INTO @id_Da, @name_Da, @sonv_Da, @mota_Da;

WHILE @@FETCH_STATUS = 0
BEGIN
    -- Chèn dữ liệu vào bảng tạm thời
    INSERT INTO #tempTable VALUES (@id_Da, @name_Da, @sonv_Da, @mota_Da);
    FETCH NEXT FROM cur INTO @id_Da, @name_Da, @sonv_Da, @mota_Da;
END;
CLOSE cur;
DEALLOCATE cur;
-- Trả về dữ liệu từ bảng tạm thời
SELECT * FROM #tempTable;
-- Xóa bảng tạm thời
DROP TABLE #tempTable;


----------Hiếu----------
--XuatNhanVienTheoPhongBan
CREATE PROCEDURE GetNhanVienByIdPb
    @id_Pb NCHAR(10)
AS
BEGIN
    SELECT * FROM NHANVIEN WHERE id_Pb = @id_Pb;
END;

EXEC GetNhanVienByIdPb @id_Pb = 'PB01';

CREATE FUNCTION fn_GetNhanVienByIdPb(@id_Pb NCHAR(10))
RETURNS TABLE
AS
RETURN 
(
    SELECT * FROM NHANVIEN WHERE id_Pb = @id_Pb
);

SELECT * FROM fn_GetNhanVienByIdPb('PB01');

-- Cursor
DECLARE @id_Pb NCHAR(10) = 'PB01';
DECLARE @id_Nv NCHAR(10), @name_Nv NVARCHAR(50), @ngaysinh_Nv DATE, @diachi_Nv NVARCHAR(100), @luong_Nv INT, @id_Da NCHAR(10);
DECLARE cur CURSOR FOR 
SELECT id_Nv, name_Nv, ngaysinh_Nv, diachi_Nv, luong_Nv, id_Da FROM NHANVIEN WHERE id_Pb = @id_Pb;
OPEN cur;
FETCH NEXT FROM cur INTO @id_Nv, @name_Nv, @ngaysinh_Nv, @diachi_Nv, @luong_Nv, @id_Da;
WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT @id_Nv + ' ' + @name_Nv + ' ' + CONVERT(NVARCHAR, @ngaysinh_Nv, 103) + ' ' + @diachi_Nv + ' ' + CONVERT(NVARCHAR, @luong_Nv) + ' ' + @id_Da;
    FETCH NEXT FROM cur INTO @id_Nv, @name_Nv, @ngaysinh_Nv, @diachi_Nv, @luong_Nv, @id_Da;
END;
CLOSE cur;
DEALLOCATE cur;

---Nhân viên lớn tuổi nhất theo phòng ban
CREATE PROCEDURE GetNhanVienLonTuoiNhatByIdPb
    @id_Pb NCHAR(10)
AS
BEGIN
    SELECT TOP 1 * FROM NHANVIEN WHERE id_Pb = @id_Pb ORDER BY ngaysinh_Nv ASC;
END;

EXEC GetNhanVienLonTuoiNhatByIdPb @id_Pb = 'PB01';

CREATE FUNCTION fn_GetNhanVienLonTuoiNhatByIdPb(@id_Pb NCHAR(10))
RETURNS TABLE
AS
RETURN 
(
    SELECT TOP 1 * FROM NHANVIEN WHERE id_Pb = @id_Pb ORDER BY ngaysinh_Nv ASC
);

SELECT * FROM fn_GetNhanVienLonTuoiNhatByIdPb('PB01');

-- Cursor
DECLARE @id_Pb NCHAR(10) = 'PB01'; -- Thay 'PB01' bằng id_Pb thực tế
DECLARE @id_Nv NCHAR(10), @name_Nv NVARCHAR(50), @ngaysinh_Nv DATE, @diachi_Nv NVARCHAR(100), @luong_Nv INT, @id_Da NCHAR(10);
DECLARE cur CURSOR FOR 
SELECT TOP 1 id_Nv, name_Nv, ngaysinh_Nv, diachi_Nv, luong_Nv, id_Da FROM NHANVIEN WHERE id_Pb = @id_Pb ORDER BY ngaysinh_Nv ASC;
OPEN cur;
FETCH NEXT FROM cur INTO @id_Nv, @name_Nv, @ngaysinh_Nv, @diachi_Nv, @luong_Nv, @id_Da;
WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT @id_Nv + ' ' + @name_Nv + ' ' + CONVERT(NVARCHAR, @ngaysinh_Nv, 103) + ' ' + @diachi_Nv + ' ' + CONVERT(NVARCHAR, @luong_Nv) + ' ' + @id_Da;
    FETCH NEXT FROM cur INTO @id_Nv, @name_Nv, @ngaysinh_Nv, @diachi_Nv, @luong_Nv, @id_Da;
END;
CLOSE cur;
DEALLOCATE cur;

----------Bảo----------
--Procedure
CREATE PROCEDURE GetNhanVienTheoIdDuAn
    @id_Da NCHAR(10)
AS
BEGIN
    SELECT * FROM NHANVIEN WHERE id_Da = @id_Da;
END;

EXEC GetNhanVienTheoIdDuAn @id_Da = 'DA01';

CREATE PROCEDURE CapNhatLuongNhanVienTheoId
    @id_Nv NCHAR(10),
    @luongMoi INT
AS
BEGIN
    UPDATE NHANVIEN SET luong_Nv = @luongMoi WHERE id_Nv = @id_Nv;
END;

EXEC CapNhatLuongNhanVienTheoId @id_Nv = 'NV01',
								@luongMoi = 100000;

--function--
CREATE FUNCTION fn_LayNhanVienTheoDiaChi(
    @diaChi NVARCHAR(100)
)
RETURNS TABLE
AS
RETURN 
(
    SELECT id_Nv, name_Nv, ngaysinh_Nv
    FROM NHANVIEN
    WHERE diachi_Nv = @diaChi
);

SELECT * FROM fn_LayNhanVienTheoDiaChi(N'Hồ Chí Minh');

CREATE FUNCTION fn_LayNhanVienTheoIdDuAn
    (@id_Da NCHAR(10))
RETURNS TABLE
AS
RETURN
(
    SELECT * FROM NHANVIEN WHERE id_Da = @id_Da
);

SELECT * FROM fn_LayNhanVienTheoIdDuAn('DA01');

--Cursor--
--In ra thông tin của tất cả nhân viên trong bảng NHANVIEN
DECLARE @id_Nv NCHAR(10), @name_Nv NVARCHAR(50), @ngaysinh_Nv DATE, @diachi_Nv NVARCHAR(100), @luong_Nv INT, @id_Da NCHAR(10);
DECLARE ThongTinNhanVienCursor CURSOR FOR 
SELECT id_Nv, name_Nv, ngaysinh_Nv, diachi_Nv, luong_Nv, id_Da FROM NHANVIEN;
OPEN ThongTinNhanVienCursor;
FETCH NEXT FROM ThongTinNhanVienCursor INTO @id_Nv, @name_Nv, @ngaysinh_Nv, @diachi_Nv, @luong_Nv, @id_Da;
WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT @id_Nv + ' ' + @name_Nv + ' ' + CONVERT(NVARCHAR, @ngaysinh_Nv, 103) + ' ' + @diachi_Nv + ' ' + CONVERT(NVARCHAR, @luong_Nv) + ' ' + @id_Da;
    FETCH NEXT FROM ThongTinNhanVienCursor INTO @id_Nv, @name_Nv, @ngaysinh_Nv, @diachi_Nv, @luong_Nv, @id_Da;
END;
CLOSE ThongTinNhanVienCursor;
DEALLOCATE ThongTinNhanVienCursor;

--in ra thông tin của dự án có nhiều nhân viên nhất
DECLARE @id_Da NCHAR(10), @name_Da NVARCHAR(50), @sonv_Da INT, @mota_Da NVARCHAR(100);
DECLARE DuAnNhieuNhanVienCursor CURSOR FOR 
SELECT TOP 1 DUAN.id_Da, name_Da, sonv_Da, mota_Da
FROM DUAN
INNER JOIN NHANVIEN ON DUAN.id_Da = NHANVIEN.id_Da
GROUP BY DUAN.id_Da, DUAN.name_Da, DUAN.sonv_Da, DUAN.mota_Da
ORDER BY COUNT(NHANVIEN.id_Nv) DESC;
OPEN DuAnNhieuNhanVienCursor;
FETCH NEXT FROM DuAnNhieuNhanVienCursor INTO @id_Da, @name_Da, @sonv_Da, @mota_Da;
WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT @id_Da + ' ' + @name_Da + ' ' + CONVERT(NVARCHAR, @sonv_Da) + ' ' + @mota_Da;
    FETCH NEXT FROM DuAnNhieuNhanVienCursor INTO @id_Da, @name_Da, @sonv_Da, @mota_Da;
END;
CLOSE DuAnNhieuNhanVienCursor;
DEALLOCATE DuAnNhieuNhanVienCursor;