USE KHO_VINAVETCO

GO
DELETE KHOHANG WHERE TONKHO=0 AND LOHANG<>"TONDAU"
go
UPDATE KHOHANG SET LOHANG ='_'+LOHANG
go
DELETE TONDAUKHOHANG
GO
INSERT INTO TONDAUKHOHANG ([MAMH],[LOHANG],[GIAMUA],[TONKHO]) SELECT MAMH,LOHANG,GIAMUA,TONKHO FROM KHOHANG 
GO
DELETE TONDAUMATHANG
GO 
INSERT INTO TONDAUMATHANG ([MAMH],[TONDAU]) SELECT MAMH, SOLUONGMH AS TONDAU FROM MATHANG
GO
DELETE TONDAUCONGNOKH
GO
INSERT INTO TONDAUCONGNOKH ([MAKH],[CONGNO]) SELECT MAKH, CONGNO FROM KHACHHANG
GO
DELETE TONDAUCONGNONCC
GO
INSERT INTO TONDAUCONGNONCC ([MANCC],[CONGNO]) SELECT MANCC, CONGNO FROM NHACUNGCAP
GO
DELETE HOADONNHAP
GO
DELETE CHITIETHDN
GO
DELETE HOADONXUAT
GO
DELETE CHITIETHDX
GO
DELETE TRAHOADONNHAP
GO
DELETE TRACHITIETHDN
GO
DELETE TRAHOADONXUAT
GO
DELETE TRACHITIETHDX
GO
DELETE [LOG]
GO
DELETE PHIEUCHI
GO
DELETE PHIEUTHU
GO
DELETE TONKHO
GO
DELETE TONKHOTT
GO
DELETE TONKIEMKHO