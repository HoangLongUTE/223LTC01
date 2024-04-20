CREATE DATABASE EntityDB

-- Tạo bảng Khoa
CREATE TABLE Khoa (
    MaKhoa INT PRIMARY KEY,
    TenKhoa VARCHAR(50)
);

-- Tạo bảng Lop
CREATE TABLE Lop (
    MaLop INT PRIMARY KEY,
    TenLop VARCHAR(50),
    MaKhoa INT,
    FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa)
);
-- Tạo bảng SinhVien
CREATE TABLE SinhVien (
    MaSV INT PRIMARY KEY,
    TenSV VARCHAR(50),
    Tuoi INT,
    MaLop INT,
    FOREIGN KEY (MaLop) REFERENCES Lop(MaLop)
);




-- Chèn dữ liệu vào bảng Khoa
INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES
(1, 'CNTT'),
(2, 'Dien'), 
(3, 'Xay dung');

-- Chèn dữ liệu vào bảng Lop
INSERT INTO Lop (MaLop, TenLop, MaKhoa) VALUES
(101, 'Lop CNTT 21T1', 1),
(102, 'Lop CNTT 21T2', 1),
(201, 'Lop Dien 21D1', 2), 
(202, 'Lop Dien 21D2', 2), 
(301, 'Lop Xay dung XD1', 3),
(302, 'Lop Xay dung 2', 3); 

-- Chèn dữ liệu vào bảng SinhVien
INSERT INTO SinhVien (MaSV, TenSV, Tuoi, MaLop) VALUES
(1, 'Nguyen Van An', 19, 101), 
(2, 'Tran Thi Oanh', 20, 102),
(3, 'Le Van Can', 21, 101),
(4, 'Pham Doanh', 18, 101),
(5, 'Hoang Van Thong', 19, 102); 

delete from Khoa