USE KHO_VINAVETCO

UPDATE NHACUNGCAP SET CONGNO=0
GO
UPDATE KHACHHANG SET CONGNO=0
GO
UPDATE MATHANG SET SOLUONGMH=100
GO
DELETE KHOHANG
GO
INSERT INTO KHOHANG ([MAMH],[LOHANG],[GIAMUA],[TONKHO],[NGAYNHAP],[HSD],[TINHTRANG])

SELECT MAMH,'TONDAU' AS LOHANG, GIAMUA, SOLUONGMH AS TONKHO,'01/01/2013' AS NGAYNHAP, '12/01/2015' AS HSD, 1 AS TINHTRANG FROM MATHANG
GO
DELETE CHITIETHDN
GO
DELETE CHITIETHDX
GO
DELETE CHITIETHDXTAM
GO
DELETE HOADONNHAP 
GO
DELETE HOADONXUAT
GO
DELETE PHIEUCHI
GO
DELETE PHIEUTHU
GO
DELETE [LOG]
GO
DELETE TONKHO
GO
DELETE TONKHOTT
GO
DELETE TRACHITIETHDN
GO
DELETE TRACHITIETHDX
GO
DELETE TRAHOADONNHAP
GO
DELETE TRAHOADONXUAT
GO
DELETE TONDAUMATHANG
GO
INSERT INTO TONDAUMATHANG ([MAMH],[TONDAU])  SELECT MAMH, SOLUONGMH FROM MATHANG
GO
DELETE TONDAUKHOHANG
GO 
INSERT INTO TONDAUKHOHANG ([MAMH],[LOHANG],[GIAMUA],[TONKHO])  SELECT MAMH, LOHANG,GIAMUA,TONKHO FROM KHOHANG


