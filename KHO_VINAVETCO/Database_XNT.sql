use master
IF  EXISTS (
	SELECT name 
		FROM sys.databases 
		WHERE name = 'XUAT_NHAPTON'
)
DROP DATABASE XUAT_NHAPTON
go
create database XUAT_NHAPTON
on (name = 'XUAT_NHAPTON_Data',filename = 'c:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\DATA\XUAT_NHAPTON.mdf')
log on(name = 'XUAT_NHAPTON_log',filename = 'c:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\DATA\XUAT_NHAPTON_log.ldf');
go
Use XUAT_NHAPTON
go
create table MATHANG
(
	MAMH VARCHAR(15) NOT NULL,
	MATH VARCHAR(15)NOT NULL,
	MANH VARCHAR(15)NOT NULL,
	MAKHO VARCHAR(15),
	TENMH NVARCHAR(50),
	MADVT varchar(15),
	SOLUONGMH int, 
	HANSUDUNG smalldatetime,
	GIAMUA BIGINT,
	GIABAN BIGINT,
	
	MOTA NTEXT,
	TINHTRANG BIT
)
GO
create table DONVITINH
(
	MADVT varchar(15)NOT NULL,
	DONVITINH nvarchar(30)
)
GO
create table NHOMHANG
(
	MANH VARCHAR(15)NOT NULL,
	TENNHOMHANG NVARCHAR(50),
	GHICHU NVARCHAR(100)
	
)
GO
create TABLE NHACUNGCAP
(
	MANCC VARCHAR(15)NOT NULL,
	MAKV VARCHAR(15)NOT NULL,
	TENNCC NVARCHAR(50),
	DIACHI NVARCHAR(50),
	MASOTHUE VARCHAR(15),
	SOTAIKHOAN VARCHAR(30),
	NGANHANG NVARCHAR(50),
	SDT VARCHAR(15),
	EMAIL VARCHAR(50),
	FAX VARCHAR(15),
	WEBSITE VARCHAR(30),
	TINHTRANG BIT
	
)
GO
create TABLE THONGTINCT
(
	MACT VARCHAR(15)NOT NULL,
	TENCT NVARCHAR(50),
	DIACHI NVARCHAR(50),
	SDT VARCHAR(15),
	MOBILE VARCHAR (15),
	EMAIL VARCHAR(50),
	FAX VARCHAR(15),
	LOGO IMAGE,
	MASOTHUE VARCHAR(15),
	WEBSITE VARCHAR(30)
	
)
GO
create TABLE HOADONNHAP
(
	MAHDN VARCHAR(15)NOT NULL,
	MANCC VARCHAR(15) NOT NULL,
	MANV varchar(15),
	NGAYNHAP SMALLDATETIME,
	
	TIENPHAITRA BIGINT,
	TIENDATRA BIGINT,
	
	GHICHU NVARCHAR(100),
	TINHTRANG BIT
)
GO
create TABLE CHITIETHDN
(
	MAHDN VARCHAR(15)NOT NULL,
	MAMH VARCHAR(15) NOT NULL,
	SOLUONGNHAP INT,
	GIANHAP BIGINT,
	TINHTRANG BIT
)
GO
create TABLE HOADONTRA
(
	
	MAHDT VARCHAR(15) NOT NULL,
	MANCC VARCHAR(15)NOT NULL,
	MAHDN VARCHAR(15)NOT NULL,
	NGAYTRA SMALLDATETIME,
	GHICHU NVARCHAR(100),
	TINHTRANG BIT	
)
GO
create table CHITIETHOADONTRA
(
	MAHDT VARCHAR(15) NOT NULL,
	MAMH VARCHAR(15) NOT NULL,
	SOLUONGTRA INT,
	TINHTRANG BIT
	
)

create TABLE HOADONXUAT
(
	MAHDX VARCHAR(15)NOT NULL,
	MAKH VARCHAR(15)NOT NULL,
	MANV VARCHAR(15)NOT NULL,
	NGAYXUAT SMALLDATETIME,
	
	TIENPHAITRA BIGINT,
	TIENDATRA BIGINT,
	GHICHU NVARCHAR(100),
	TINHTRANG BIT
)
create TABLE CHITIETHDX
(
	MAHDX VARCHAR(15)NOT NULL,
	MAMH VARCHAR(15) NOT NULL,
	SOLUONGXUAT INT,
	GIATIEN BIGINT,
	TINHTRANG BIT
)
create TABLE NHANVIEN
(
	MANV VARCHAR(15)NOT NULL,
	MABP varchar(15),
	USERNAME nvarchar(30),
	PASSWORD NVARCHAR(50),
	CHUCVU NVARCHAR(50),
	TENNV NVARCHAR (50),
	DIACHI NVARCHAR (50),
	NGAYSINH DATETIME,
	SCMND VARCHAR(15),
	SDT VARCHAR(15),
	TINHTRANG BIT
)
create TABLE BOPHAN
(
	MABP varchar(15) NOT NULL,
	TENBOPHAN NVARCHAR(50),
	TINHTRANG BIT
)
create TABLE KHACHHANG
(
	MAKH VARCHAR(15)NOT NULL,
	MAKV VARCHAR(15)NOT NULL,
	TENKH NVARCHAR(50),
	SOTAIKHOAN VARCHAR(30),
	NGANHANG NVARCHAR(50),
	MASOTHUE VARCHAR(15),
	DIACHI NVARCHAR(50),
	SDT VARCHAR(15),
	FAX VARCHAR(15),
	WEBSITE VARCHAR(30),
	YAHOO VARCHAR (50),
	SKYPE VARCHAR(50),
	TINHTRANG BIT
)
create TABLE TONKHO
(
	NGAYTHANG DATETIME NOT NULL,
	MAMH VARCHAR(15)NOT NULL,
	SOLUONGDAU INT default(0),
	SOLUONGNHAP INT default(0),
	SOLUONGXUAT INT default(0),
	SOLUONGTON AS SOLUONGDAU+SOLUONGNHAP-SOLUONGXUAT
	
)

create TABLE CONGNOKH
(
		
	MAKH VARCHAR(15)NOT NULL,
	TONGTIENTRA BIGINT,
	TONGTIENDATRA BIGINT

)
create TABLE CONGNONCC
(
		
	MANCC VARCHAR(15)NOT NULL,
	TONGTIENTRA BIGINT,
	TONGTIENDATRA BIGINT
	
)

create table KHUVUC
(
	MAKV VARCHAR(15)NOT NULL,
	TENKV NVARCHAR(50),
	GHICHU NVARCHAR(100),
	TINHTRANG BIT
)
create table KHO
(
	MAKHO VARCHAR(15)NOT NULL,
	MANV VARCHAR(15)NOT NULL,
	TENKHO NVARCHAR(50),
	DIACHI NVARCHAR(50),
	SDTB VARCHAR(15),
	DTDD VARCHAR(15),
	NGUOILH NVARCHAR(30),
	FAX VARCHAR(15),
	GHICHU NVARCHAR(100),
	TINHTRANG BIT
)
create TABLE THUE
(
	MATH VARCHAR(15)NOT NULL,
	
	SOTHUE SMALLINT
)
create TABLE PHIEUCHI
(
	MaPC varchar(15)NOT NULL,
	MaNV varchar(15),
	MaHDN varchar(15),
	NgayChi smalldatetime,
	SoTienDaTra_PC bigint
)

create table PHIEUTHU
(
	 MaPT varchar(15)NOT NULL,
	 MaNV varchar(15),
	 mahdx  varchar(15),
	 NgayThu smalldatetime,
	 SoTienTra_PT bigint,
)

-----tao khoa------
go

use XUAT_NHAPTON
GO
	alter TABLE MATHANG
	add constraint PK_MATHANG primary key(MAMH)
	
GO

	ALTER TABLE DONVITINH
	add constraint PK_DONVITINH primary key(MADVT)
	
GO
	alter TABLE NHOMHANG
	add constraint PK_NHOMHANG primary key(MANH)
	
GO
	alter TABLE NHACUNGCAP
	add constraint PK_NHACUNGCAP primary key(MANCC)
GO
	alter TABLE THONGTINCT
	add constraint PK_THONGTINCT primary key(MACT)
	
GO
	alter TABLE HOADONNHAP
	add constraint PK_HOADONNHAP primary key(MAHDN)
	
GO
	alter TABLE CHITIETHDN
	add constraint PK_CHITIETHDN primary key(MAHDN,MAMH)
	--CONSTRAINT PK_CHITIETHDN primary key(MANCC)
GO
	alter TABLE HOADONTRA
	ADD CONSTRAINT PK_HOADONTRA PRIMARY KEY(MAHDT)
GO
	alter TABLE CHITIETHOADONTRA 
	ADD CONSTRAINT PK_CHITIETHOADONTRA PRIMARY KEY(MAHDT,MAMH)
	
GO
	alter TABLE HOADONXUAT
	add constraint PK_HOADONXUAT primary key(MAHDX)
	
GO	
		
	alter TABLE CHITIETHDX
	add constraint PK_CHITIETHDX primary key(MAHDX,MAMH)
GO

	alter table PHIEUCHI
	ADD constraint PK_PHIEUCHI Primary key(MaPC)
GO
	ALTER TABLE PHIEUTHU
	ADD constraint PK_PHIEUTHU primary key(MaPT)

	
GO
	alter TABLE NHANVIEN
	add constraint PK_NHANVIEN primary key(MANV)
	
GO
	alter TABLE BOPHAN
	add constraint PK_BOPHAN primary key(MABP)
	
GO
	alter TABLE KHACHHANG
	add constraint PK_KHACHHANG primary key(MAKH)
	
GO
	alter TABLE TONKHO
	add constraint PK_TONKHO primary key(NGAYTHANG,MAMH)
GO
--	alter TABLE TONKHO ADD CONSTRAINT CHK_TONKHO CHECK(SOLUONGDAU>=0 AND SOLUONGNHAP>=0 AND SOLUONGXUAT>=0),
--	CONSTRAINT DEF_TONKHO_SOLUONGDAU DEFAULT(0) FOR SOLUONGDAU,
--		CONSTRAINT DEF_TONKHO_SOLUONGNHAP DEFAULT(0) FOR SOLUONGNHAP,
--	CONSTRAINT DEF_TONKHO_SOLUONGXUAT DEFAULT(0) FOR SOLUONGXUAT


--GO
--	alter TABLE CONGNOKH
--	add constraint CONGNOKH primary key(MAKH)
--GO
--	alter TABLE CONGNONCC
--	add constraint CONGNONCC primary key(MANCC)
GO
	alter TABLE KHUVUC
	add constraint PK_KHUVUC primary key(MAKV)
GO
	alter TABLE KHO
	add constraint PK_KHO primary key(MAKHO)
GO
	alter TABLE THUE
	add constraint PK_THUE primary key(MATH)
	
---KHOAPHU,RANG BUOC---
	
go
	alter TABLE MATHANG
	
	add constraint FK_MATHANG_NHOMHANG foreign key(MANH) 
	references NHOMHANG(MANH)
	On Delete Cascade
	On Update Cascade,	
	constraint FK_MATHANG_THUE foreign key(MATH) 
	references THUE(MATH)
	On Delete Cascade
	On Update Cascade,	
	constraint FK_MATHANG_DONVITINH foreign key(MADVT) 
	references DONVITINH(MADVT)	
	On Delete Cascade
	On Update Cascade,
	constraint FK_MATHANG_KHO foreign key(MAKHO) 
	references KHO(MAKHO)	
	On Delete Cascade
	On Update Cascade
GO
	alter TABLE NHACUNGCAP
	add constraint FK_NHACUNGCAP_KHUVUC foreign key(MAKV)
	REFERENCES KHUVUC(MAKV)
	On Delete Cascade
	On Update Cascade
GO
	alter TABLE KHACHHANG
	add constraint FK_KHACHANG_KHUVUC foreign key(MAKV)
	REFERENCES KHUVUC(MAKV)
	On Delete Cascade
	On Update Cascade
GO
	alter TABLE HOADONNHAP
	add constraint FK_HOADONNHAP_NHACUNGCAP foreign key(MANCC) 
	references NHACUNGCAP(MANCC)
	On Delete Cascade
	On Update Cascade,
	constraint FK_HOADONNHAP_NHANVIEN foreign key(MANV) references NHANVIEN(MANV)
	On Delete Cascade
	On Update Cascade	
GO
	alter TABLE CHITIETHDN-- may ghi khoa chinh cthoadoncho nao
	add constraint FK_CHITIETHDN_HOADONNHAP foreign key (MAHDN) 
	REFERENCES HOADONNHAP(MAHDN)
	On Delete Cascade
	On Update Cascade
GO
	alter TABLE HOADONTRA
	ADD CONSTRAINT FK_HOADONTRA_NHACUNGCAP FOREIGN KEY (MANCC)
	REFERENCES NHACUNGCAP(MANCC),
	CONSTRAINT FK_HOADONTRA_HOADONNHAP FOREIGN KEY(MAHDN)
	REFERENCES HOADONNHAP(MAHDN)
GO
	alter TABLE CHITIETHOADONTRA
	ADD CONSTRAINT FK_CHITIETHOADONTRA_HOADONTRA FOREIGN KEY (MAHDT)
	REFERENCES HOADONTRA(MAHDT)
	
GO
	alter TABLE HOADONXUAT
	add constraint FK_HOADONXUAT_NHANVIEN foreign key (MANV) 
	references NHANVIEN(MANV)
	On Delete Cascade
	On Update Cascade,
	constraint FK_CHITIETHDX_KHACHHANG foreign key (MAKH) 
	REFERENCES KHACHHANG(MAKH)
	On Delete Cascade
	On Update Cascade
GO	
	alter TABLE CHITIETHDX
	add constraint FK_CHITIETHDX_HOADONXUAT foreign key (MAHDX) 
	REFERENCES HOADONXUAT(MAHDX),
--	On Delete Cascade
--	On Update Cascade,
	constraint FK_CHITIETHDX_MATHANG foreign key (MAMH) 
	REFERENCES MATHANG(MAMH)
--	On Delete Cascade
--	On Update Cascade

GO
GO
	ALTER TABLE PHIEUCHI
	ADD constraint FK_PHIEUCHI_NHANVIEN foreign key(MANV) 
	references NHANVIEN(MaNV)
	On Delete Cascade
	On Update Cascade,
	constraint FK_PHIEUCHI_HOADONNHAP foreign key(MAHDN)
	REFERENCES HOADONNHAP(MAHDN)
	
GO
	ALTER TABLE PHIEUTHU
	ADD constraint FK_PHIEUTHU_NHANVIEN foreign key(MANV) 
	references NHANVIEN(MANV)
	On Delete Cascade
	On Update Cascade,
	constraint FK_PHIEUTHU_HOADONXUAT foreign key(MAHDX)
	REFERENCES HOADONXUAT(MAHDX)
--	alter TABLE PHIEUCHI
--	ADD constraint FK_PHIEUCHI_NHANVIEN foreign key(MANV) 
--	references NHANVIEN(MaNV)
--	On Delete Cascade
--	On Update Cascade,
--	constraint FK_PHIEUCHI_NHACUNGCAP foreign key(MANCC) 
--	references NHACUNGCAP(MANCC)
--	On Delete Cascade
--	On Update Cascade
--GO
--	alter TABLE PHIEUTHU
--	ADD constraint FK_PHIEUTHU_NHANVIEN foreign key(MANV) 
--	references NHANVIEN(MANV)
--	On Delete Cascade
--	On Update Cascade,
--	constraint FK_PHIEUTHU_KHACHHANG foreign key(MAKH) 
--	references KHACHHANG(MAKH)
--	On Delete Cascade
--	On Update Cascade
GO
	alter TABLE NHANVIEN
	add constraint FK_NHANVIEN_BOPHAN foreign key (MABP) 
	REFERENCES BOPHAN(MABP)
	On Delete Cascade
	On Update Cascade	
GO
	alter TABLE TONKHO
	add constraint FK_TONKHO_MATHANG foreign key (MAMH) 
	REFERENCES MATHANG(MAMH)
	On Delete Cascade
	On Update Cascade
GO
	alter TABLE CONGNOKH
	add constraint FK_CONGNOKH_MAKH foreign key (MAKH)
	REFERENCES KHACHHANG(MAKH)
	On Delete Cascade
	On Update Cascade
GO
	alter TABLE CONGNONCC
	add constraint FK_CONGNONCC_NHACUNGCAP foreign key(MANCC)
	REFERENCES NHACUNGCAP(MANCC)
	On Delete Cascade
	On Update Cascade
GO
	alter TABLE KHO
	add constraint FK_KHO_NHANVIEN foreign key(MANV)
	REFERENCES NHANVIEN(MANV)
	On Delete Cascade
	On Update Cascade
---insert du lieu---
go

---proc---------------------------------------	
GO
create PROCEDURE [dbo].[BACKUP_DATABASE]
	@TENFILE NVARCHAR(150)
AS
BEGIN
		BACKUP DATABASE XUAT_NHAPTON TO DISK = @TENFILE
END
GO

USE MASTER
Go
if exists (select name from sys.procedures where name = 'RESTORE_DATABASE')
drop proc RESTORE_DATABASE
Go
create PROCEDURE [dbo].[RESTORE_DATABASE]
	@TENFILE NVARCHAR(150)
AS
BEGIN
--create database XUATNHAP_TON set offline
if exists (select name from sys.databases where name = 'XUAT_NHAPTON')
	drop database XUAT_NHAPTON
	RESTORE DATABASE XUAT_NHAPTON FROM DISK = @TENFILE
	--create database XUAT_NHAPTON SET SINGLE_USER With ROLLBACK IMMEDIATE 
--ELSE
--	RESTORE DATABASE XUAT_NHAPTON FROM DISK = @TENFILE
END
--exec RESTORE_DATABASE 'C:\Users\BamBi\Desktop\New folder (2)\s.bak'
GO
USE XUAT_NHAPTON
go


GO
create procedure dbo.[NHOMHANG_getall]

 as 
select 	MANH,
	TENNHOMHANG
 from  dbo.[NHOMHANG]
GO
------------------------------------Get-----------------------
create procedure dbo.[KHO_getall]

 as 
select 	MAKHO,
	MANV,
	TENKHO,
	DIACHI,
	SDTB,
	DTDD,
	NGUOILH,
	FAX,
	GHICHU,
	TINHTRANG
 from  dbo.[KHO]

-----------------------------------KIEM TRA DANG NHAP-------------

GO
create procedure [dbo].[TEST_NHANVIEN]
@PASSWORD as varchar(15),@USERNAME as varchar (30)
 as 
select 	MANV,
	MABP,
	USERNAME,
	PASSWORD,
	CHUCVU,
	TENNV,
	DIACHI,
	NGAYSINH,
	SCMND,
	SDT,
	TINHTRANG
 from  dbo.[NHANVIEN]
 where 	(@PASSWORD=dbo.[NHANVIEN].PASSWORD) and (@USERNAME=dbo.[NHANVIEN].USERNAME)



--------------------------------------Thong Ke-----------------------------------------

GO
create PROCEDURE [dbo].[THONGKE_DOANHTHU]
	@NGAY_BD DATETIME,
	@NGAY_KT DATETIME,
	@LOAI_TG VARCHAR(10)
AS
BEGIN
		IF(@LOAI_TG = 'NGAY')
			BEGIN
				select  NGAYXUAT , TENKH as N'Tên Khách hàng',TENKV ,SUM(TIENPHAITRA) AS  N'TongDoanhThu' FROM HOADONXUAT,KHACHHANG,KHUVUC WHERE KHUVUC.MAKV=KHACHHANG.MAKV AND KHACHHANG.MAKH=HOADONXUAT.MAKH  AND  NGAYXUAT BETWEEN @NGAY_BD AND @NGAY_KT
				group by TENKH,TENKV,ngayxuat
			END
		ELSE IF(@LOAI_TG = 'THANG')
			BEGIN
				select  NGAYXUAT , TENKH as N'Tên Khách hàng',TENKV ,SUM(TIENPHAITRA) AS  N'TongDoanhThu' FROM HOADONXUAT,KHACHHANG,KHUVUC WHERE KHUVUC.MAKV=KHACHHANG.MAKV AND KHACHHANG.MAKH=HOADONXUAT.MAKH  AND  MONTH(NGAYXUAT) between MONTH(@NGAY_BD) and month(@ngay_kt) AND YEAR(NGAYXUAT) = YEAR(@NGAY_BD)
				group by TENKH,TENKV,ngayxuat
			END
		ELSE IF(@LOAI_TG = 'QUI')
			BEGIN
			
				select NGAYXUAT ,TENKH as N'Tên Khách hàng',TENKV ,SUM(TIENPHAITRA) AS  N'TongDoanhThu' FROM HOADONXUAT,KHACHHANG,KHUVUC WHERE KHUVUC.MAKV=KHACHHANG.MAKV AND KHACHHANG.MAKH=HOADONXUAT.MAKH  AND  YEAR(NGAYXUAT) = YEAR(@NGAY_BD) AND MONTH(NGAYXUAT) BETWEEN MONTH(@NGAY_BD) AND MONTH(@NGAY_KT)
				group by TENKH,TENKV,ngayxuat
			END
		ELSE IF(@LOAI_TG='NAM')
			BEGIN
				select NGAYXUAT ,TENKH as N'Tên Khách hàng',TENKV ,SUM(TIENPHAITRA) AS  N'TongDoanhThu' FROM HOADONXUAT,KHACHHANG,KHUVUC WHERE KHUVUC.MAKV=KHACHHANG.MAKV AND KHACHHANG.MAKH=HOADONXUAT.MAKH  AND YEAR(NGAYXUAT) between YEAR(@NGAY_BD) and year(@NGAY_KT)
				group by TENKH,TENKV,ngayxuat
			END
		ELSE
			BEGIN
				select NGAYXUAT , TENKH as N'Tên Khách hàng',TENKV ,SUM(TIENPHAITRA) AS  N'TongDoanhThu' FROM HOADONXUAT,KHACHHANG,KHUVUC WHERE KHUVUC.MAKV=KHACHHANG.MAKV AND KHACHHANG.MAKH=HOADONXUAT.MAKH 
						group by TENKH,TENKV,ngayxuat
			END
		
END
------------------------------Thong Ke End


------------------------------Thong Ke End
go
--------------tONKHO
create trigger [dbo].[THEMCT_HOADONNHAP]
ON [dbo].[CHITIETHDN]
FOR INSERT 
AS

 DECLARE @SOLUONGNHAP INT ,@SOLUONGXUAT INT,@NGAYTHANG smalldatetime,@MAMH VARCHAR(15),@SOTON INT,@@SOLUONGNHAP INT,@@SOLUONGXUAT INT
SET @@SOLUONGXUAT=0
SET @SOTON=0
SET @SOLUONGNHAP=0
SELECT @NGAYTHANG =NGAYNHAP,@SOLUONGNHAP=SOLUONGNHAP,@MAMH=MAMH FROM HOADONNHAP PN,INSERTED I WHERE PN.MAHDN=I.MAHDN
SELECT @@SOLUONGNHAP=SOLUONGNHAP FROM TONKHO WHERE @MAMH=MAMH AND @NGAYTHANG=NGAYTHANG
SELECT @@SOLUONGXUAT=SOLUONGXUAT FROM TONKHO WHERE @NGAYTHANG=NGAYTHANG AND MAMH=@MAMH 

SELECT @SOTON=SUM(SOLUONGNHAP)-SUM(SOLUONGXUAT) FROM TONKHO WHERE MAMH=@MAMH GROUP BY MAMH
IF EXISTS (SELECT NGAYTHANG FROM TONKHO WHERE NGAYTHANG=@NGAYTHANG)
	BEGIN 
		IF EXISTS (SELECT MAMH FROM TONKHO WHERE NGAYTHANG=@NGAYTHANG AND MAMH=@MAMH)
			UPDATE TONKHO SET SOLUONGXUAT=@@SOLUONGXUAT, SOLUONGNHAP=@SOLUONGNHAP+@@SOLUONGNHAP WHERE NGAYTHANG=@NGAYTHANG AND MAMH=@MAMH
		ELSE
			INSERT TONKHO VALUES (@NGAYTHANG,@MAMH,@SOTON,@SOLUONGNHAP,@@SOLUONGXUAT)
	END
ELSE 
	INSERT TONKHO VALUES (@NGAYTHANG,@MAMH,@SOTON,@SOLUONGNHAP,@@SOLUONGXUAT)
--_____________________________TON KHO XUAT
GO
create trigger [dbo].[THEMCT_HOADONXUAT]
ON [dbo].[CHITIETHDX]
FOR INSERT 
AS

 DECLARE @SOLUONGNHAP INT ,@SOLUONGXUAT INT,@NGAYTHANG VARCHAR (101),@MAMH VARCHAR(15),@SOTON INT,@@SOLUONGNHAP INT,@@SOLUONGXUAT INT
SET @@SOLUONGXUAT=0
SET @SOTON=0
SET @SOLUONGNHAP=0
SELECT @NGAYTHANG =CONVERT(VARCHAR(15),NGAYXUAT,101),@SOLUONGXUAT=SOLUONGXUAT,@MAMH=MAMH FROM HOADONXUAT PX,INSERTED I WHERE PX.MAHDX=I.MAHDX
SELECT @@SOLUONGNHAP=SOLUONGNHAP FROM TONKHO WHERE @MAMH=MAMH AND @NGAYTHANG=NGAYTHANG
SELECT @@SOLUONGXUAT=SOLUONGXUAT FROM TONKHO WHERE @NGAYTHANG=NGAYTHANG AND MAMH=@MAMH 
SELECT @SOTON=SUM(SOLUONGNHAP)-SUM(SOLUONGXUAT) FROM TONKHO WHERE MAMH=@MAMH GROUP BY MAMH
IF EXISTS (SELECT NGAYTHANG FROM TONKHO WHERE NGAYTHANG=@NGAYTHANG)
	BEGIN 
		IF EXISTS (SELECT MAMH FROM TONKHO WHERE NGAYTHANG=@NGAYTHANG AND MAMH=@MAMH)
			UPDATE TONKHO SET SOLUONGXUAT=@SOLUONGXUAT+@@SOLUONGXUAT WHERE NGAYTHANG=@NGAYTHANG AND MAMH=@MAMH
		ELSE
			INSERT TONKHO VALUES (@NGAYTHANG,@MAMH,@SOTON,@SOLUONGNHAP,@SOLUONGXUAT)
	END
ELSE 
	INSERT TONKHO VALUES (@NGAYTHANG,@MAMH,@SOTON,@SOLUONGNHAP,@SOLUONGXUAT)
---------------------------------SUA HOA DON----------------TRIGGER----sai
GO
--create Trigger utrg_SuaCTHDN On CHITIETHDN For Update
--As
--DECLARE @NGAYTHANG VARCHAR(15),@MAMH VARCHAR(101),@soluongnhap int,@soluongnhapcu int
--select @soluongnhapcu=soluongnhap from deleted
--SELECT @NGAYTHANG =CONVERT(VARCHAR(15),NGAYNHAP,101),@soluongnhap=soluongnhap,@MAMH=MAMH FROM HOADONNHAP PN,INSERTED I WHERE PN.MAHDN=I.MAHDN
--Update TONKHO Set SOLUONGNHAP = SOLUONGNHAP - @soluongnhapcu+@SOLUONGNHAP  
--Where  NGAYTHANG=@NGAYTHANG AND MAMH=@MAMH

GO
----------------------------------TON KHO
create procedure dbo.[TONKHO_getall]
@MAKHO AS VARCHAR(15),
@NGAYTHANGTU AS DATETIME,
@NGAYTHANGDEN AS DATETIME
 as 
select TENNHOMHANG,TENMH,MATHANG.MAKHO,TONKHO.MAMH,DONVITINH,NGAYTHANG,SOLUONGDAU,GIAMUA*SOLUONGDAU AS TONGTIENDAU,SOLUONGNHAP,SOLUONGNHAP*GIAMUA AS TONGTIENNHAP,SOLUONGXUAT,SOLUONGXUAT*GIABAN AS TONGTIENXUAT,SOLUONGTON,SOLUONGTON*GIAMUA AS TONGTIENTON FROM TONKHO,MATHANG,DONVITINH,NHOMHANG,KHO WHERE  MATHANG.MANH=NHOMHANG.MANH AND DONVITINH.MADVT=MATHANG.MADVT AND MATHANG.MAMH=TONKHO.MAMH 
AND MATHANG.MAKHO=KHO.MAKHO AND MATHANG.MAKHO=@MAKHO AND
 NGAYTHANG BETWEEN @NGAYTHANGTU AND @NGAYTHANGDEN
go

--------------------Mat Hang getall
go
create procedure dbo.[MATHANG_getall]

 as 
select 	MAMH,
	MATH,
	MANH,
	MAKHO,
	TENMH,
	MADVT,
	SOLUONGMH,
	HANSUDUNG,
	GIAMUA,
	GIABAN,
	
	MOTA,
	TINHTRANG
 from  dbo.[MATHANG]
GO
-------------------------add MAT HANG

----------------------------Get All MatHang
create procedure dbo.[MatHang_DayDu]

 as 
SELECT MAMH,
	thue.MATH,sothue,
	mathang.MANH,tennhomhang,
	TENMH,
	donvitinh.MADVT,donvitinh,
	SOLUONGMH,
	HANSUDUNG,
	GIAMUA,
	GIABAN,

	MOTA,
	TINHTRANG

 FROM thue,nhomhang,MATHANG,donvitinh WHERE donvitinh.madvt=mathang.madvt and nhomhang.manh=mathang.manh and thue.math = mathang.math

go
----------------------------get Thong Tin Cong Ty
create procedure dbo.[THONGTINCT_get]
@MACT as varchar(15)
 as 
select 	MACT,
	TENCT,
	DIACHI,
	SDT,
	MOBILE,
	EMAIL,
	FAX,
	LOGO,
	MASOTHUE,
	WEBSITE
	
 from  dbo.[THONGTINCT]
 where 	(@MACT=dbo.[THONGTINCT].MACT)

GO

----------------------update TT Cong TY
create procedure dbo.[THONGTINCT_update]
@MACT as varchar(15),
@TENCT as nvarchar(50),
@DIACHI as nvarchar(50),
@SDT as varchar(15),
@MOBILE as varchar(15),
@EMAIL as varchar(50),
@FAX as varchar(15),
@LOGO as image,
@MASOTHUE as varchar(15),
@WEBSITE as varchar(30)

 as 
update dbo.[THONGTINCT] set 
	MACT= @MACT,
	TENCT= @TENCT,
	DIACHI= @DIACHI,
	SDT= @SDT,
	MOBILE= @MOBILE,
	EMAIL= @EMAIL,
	FAX= @FAX,
	LOGO= @LOGO,
	MASOTHUE= @MASOTHUE,
	WEBSITE= @WEBSITE

 where 	(@MACT=dbo.[THONGTINCT].MACT)



--end--
--------------------------------Proc Tung Lam
go

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[BOPHAN_add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[BOPHAN_add]
GO
--Created:12/17/2010
--Author:
CREATE procedure dbo.[BOPHAN_add]
@MABP as varchar(15),
@TENBOPHAN as nvarchar(50),
@TINHTRANG as bit
 as 
insert into dbo.[BOPHAN](
	MABP,
	TENBOPHAN,
	TINHTRANG)
values(
	@MABP,
	@TENBOPHAN,
	@TINHTRANG)
GO

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[BOPHAN_update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[BOPHAN_update]
GO
--Created:12/17/2010
--Author:
CREATE procedure dbo.[BOPHAN_update]
@MABP as varchar(15),
@TENBOPHAN as nvarchar(50),
@TINHTRANG as bit
 as 
update dbo.[BOPHAN] set 
	MABP= @MABP,
	TENBOPHAN= @TENBOPHAN,
	TINHTRANG= @TINHTRANG
 where 	(@MABP=dbo.[BOPHAN].MABP)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[BOPHAN_delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[BOPHAN_delete]
GO
--Created:12/17/2010
--Author:
CREATE procedure dbo.[BOPHAN_delete]
@MABP as varchar(15)
 as 
delete dbo.[BOPHAN]
 where 	(@MABP=dbo.[BOPHAN].MABP)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[BOPHAN_getall]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[BOPHAN_getall]
GO
--Created:12/17/2010
--Author:
CREATE procedure dbo.[BOPHAN_getall]

 as 
select 	MABP,
	TENBOPHAN,
	TINHTRANG
 from  dbo.[BOPHAN]
GO



-----------------------Ðon V? Tính-----------------
if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[DONVITINH_add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[DONVITINH_add]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[DONVITINH_add]
@MADVT as varchar(15),
@DONVITINH as nvarchar(30)
 as 
insert into dbo.[DONVITINH](
	MADVT,
	DONVITINH)
values(
	@MADVT,
	@DONVITINH)
GO

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[DONVITINH_update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[DONVITINH_update]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[DONVITINH_update]
@MADVT as varchar(15),
@DONVITINH as nvarchar(30)
 as 
update dbo.[DONVITINH] set 
	MADVT= @MADVT,
	DONVITINH= @DONVITINH
 where 	(@MADVT=dbo.[DONVITINH].MADVT)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[DONVITINH_delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[DONVITINH_delete]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[DONVITINH_delete]
@MADVT as varchar(15)
 as 
delete dbo.[DONVITINH]
 where 	(@MADVT=dbo.[DONVITINH].MADVT)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[DONVITINH_getall]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[DONVITINH_getall]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[DONVITINH_getall]

 as 
select 	MADVT,
	DONVITINH
 from  dbo.[DONVITINH]
GO


--
--
--
--
---------------Khách Hàng------------------------
if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[KHACHHANG_add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[KHACHHANG_add]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[KHACHHANG_add]
@MAKH as varchar(15),
@MAKV as varchar(15),
@TENKH as nvarchar(50),
@SOTAIKHOAN as varchar(30),
@NGANHANG as nvarchar(50),
@MASOTHUE as varchar(15),
@DIACHI as nvarchar(50),
@SDT as varchar(15),
@FAX as varchar(15),
@WEBSITE as varchar(30),
@YAHOO as varchar(50),
@SKYPE as varchar(50),
@TINHTRANG as bit
 as 
insert into dbo.[KHACHHANG](
	MAKH,
	MAKV,
	TENKH,
	SOTAIKHOAN,
	NGANHANG,
	MASOTHUE,
	DIACHI,
	SDT,
	FAX,
	WEBSITE,
	YAHOO,
	SKYPE,
	TINHTRANG)
values(
	@MAKH,
	@MAKV,
	@TENKH,
	@SOTAIKHOAN,
	@NGANHANG,
	@MASOTHUE,
	@DIACHI,
	@SDT,
	@FAX,
	@WEBSITE,
	@YAHOO,
	@SKYPE,
	@TINHTRANG)
GO

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[KHACHHANG_update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[KHACHHANG_update]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[KHACHHANG_update]
@MAKH as varchar(15),
@MAKV as varchar(15),
@TENKH as nvarchar(50),
@SOTAIKHOAN as varchar(30),
@NGANHANG as nvarchar(50),
@MASOTHUE as varchar(15),
@DIACHI as nvarchar(50),
@SDT as varchar(15),
@FAX as varchar(15),
@WEBSITE as varchar(30),
@YAHOO as varchar(50),
@SKYPE as varchar(50),
@TINHTRANG as bit
 as 
update dbo.[KHACHHANG] set 
	MAKH= @MAKH,
	MAKV= @MAKV,
	TENKH= @TENKH,
	SOTAIKHOAN= @SOTAIKHOAN,
	NGANHANG= @NGANHANG,
	MASOTHUE= @MASOTHUE,
	DIACHI= @DIACHI,
	SDT= @SDT,
	FAX= @FAX,
	WEBSITE= @WEBSITE,
	YAHOO= @YAHOO,
	SKYPE= @SKYPE,
	TINHTRANG= @TINHTRANG
 where 	(@MAKH=dbo.[KHACHHANG].MAKH)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[KHACHHANG_delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[KHACHHANG_delete]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[KHACHHANG_delete]
@MAKH as varchar(15)
 as 
delete dbo.[KHACHHANG]
 where 	(@MAKH=dbo.[KHACHHANG].MAKH)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[KHACHHANG_getall]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[KHACHHANG_getall]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[KHACHHANG_getall]

 as 
select 	MAKH,
	MAKV,
	TENKH,
	SOTAIKHOAN,
	NGANHANG,
	MASOTHUE,
	DIACHI,
	SDT,
	FAX,
	WEBSITE,
	YAHOO,
	SKYPE,
	TINHTRANG
 from  dbo.[KHACHHANG]
GO

--
--
--
--
---------------Kho-------------------
if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[KHO_add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[KHO_add]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[KHO_add]
@MAKHO as varchar(15),
@MANV as varchar(15),
@TENKHO as nvarchar(50),
@DIACHI as nvarchar(50),
@SDTB as varchar(15),
@DTDD as varchar(15),
@NGUOILH as nvarchar(30),
@FAX as varchar(15),
@GHICHU as nvarchar(100),
@TINHTRANG as bit
 as 
insert into dbo.[KHO](
	MAKHO,
	MANV,
	TENKHO,
	DIACHI,
	SDTB,
	DTDD,
	NGUOILH,
	FAX,
	GHICHU,
	TINHTRANG)
values(
	@MAKHO,
	@MANV,
	@TENKHO,
	@DIACHI,
	@SDTB,
	@DTDD,
	@NGUOILH,
	@FAX,
	@GHICHU,
	@TINHTRANG)
GO

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[KHO_update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[KHO_update]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[KHO_update]
@MAKHO as varchar(15),
@MANV as varchar(15),
@TENKHO as nvarchar(50),
@DIACHI as nvarchar(50),
@SDTB as varchar(15),
@DTDD as varchar(15),
@NGUOILH as nvarchar(30),
@FAX as varchar(15),
@GHICHU as nvarchar(100),
@TINHTRANG as bit
 as 
update dbo.[KHO] set 
	MAKHO= @MAKHO,
	MANV= @MANV,
	TENKHO= @TENKHO,
	DIACHI= @DIACHI,
	SDTB= @SDTB,
	DTDD= @DTDD,
	NGUOILH= @NGUOILH,
	FAX= @FAX,
	GHICHU= @GHICHU,
	TINHTRANG= @TINHTRANG
 where 	(@MAKHO=dbo.[KHO].MAKHO)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[KHO_delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[KHO_delete]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[KHO_delete]
@MAKHO as varchar(15)
 as 
delete dbo.[KHO]
 where 	(@MAKHO=dbo.[KHO].MAKHO)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[KHO_getall]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[KHO_getall]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[KHO_getall]

 as 
select 	MAKHO,
	MANV,
	TENKHO,
	DIACHI,
	SDTB,
	DTDD,
	NGUOILH,
	FAX,
	GHICHU,
	TINHTRANG
 from  dbo.[KHO]
GO

--
--
--
--------------------------------Khu V?c------------------
if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[KHUVUC_add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[KHUVUC_add]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[KHUVUC_add]
@MAKV as varchar(15),
@TENKV as nvarchar(50),
@GHICHU as nvarchar(100),
@TINHTRANG as bit
 as 
insert into dbo.[KHUVUC](
	MAKV,
	TENKV,
	GHICHU,
	TINHTRANG)
values(
	@MAKV,
	@TENKV,
	@GHICHU,
	@TINHTRANG)
GO

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[KHUVUC_update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[KHUVUC_update]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[KHUVUC_update]
@MAKV as varchar(15),
@TENKV as nvarchar(50),
@GHICHU as nvarchar(100),
@TINHTRANG as bit
 as 
update dbo.[KHUVUC] set 
	MAKV= @MAKV,
	TENKV= @TENKV,
	GHICHU= @GHICHU,
	TINHTRANG= @TINHTRANG
 where 	(@MAKV=dbo.[KHUVUC].MAKV)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[KHUVUC_delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[KHUVUC_delete]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[KHUVUC_delete]
@MAKV as varchar(15)
 as 
delete dbo.[KHUVUC]
 where 	(@MAKV=dbo.[KHUVUC].MAKV)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[KHUVUC_getall]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[KHUVUC_getall]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[KHUVUC_getall]

 as 
select 	MAKV,
	TENKV,
	GHICHU,
	TINHTRANG
 from  dbo.[KHUVUC]
GO

--
--
--
--
--
--
---------------M?t Hàng-----------------------
if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[MATHANG_add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[MATHANG_add]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[MATHANG_add]
@MAMH as varchar(15),
@MATH as varchar(15),
@MANH as varchar(15),
@MAKHO as varchar(15),
@TENMH as nvarchar(50),
@MADVT as varchar(15),
@SOLUONGMH as int,
@HANSUDUNG as smalldatetime,
@GIAMUA as bigint,
@GIABAN as bigint,
 
@MOTA as ntext,
@TINHTRANG as bit
 as 
insert into dbo.[MATHANG](
	MAMH,
	MATH,
	MANH,
	MAKHO,
	TENMH,
	MADVT,
	SOLUONGMH,
	HANSUDUNG,
	GIAMUA,
	GIABAN,
	 
	MOTA,
	TINHTRANG)
values(
	@MAMH,
	@MATH,
	@MANH,
	@MAKHO,
	@TENMH,
	@MADVT,
	@SOLUONGMH,
	@HANSUDUNG,
	@GIAMUA,
	@GIABAN,
	 
	@MOTA,
	@TINHTRANG)
GO

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[MATHANG_update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[MATHANG_update]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[MATHANG_update]
@MAMH as varchar(15),
@MATH as varchar(15),
@MANH as varchar(15),
@MAKHO as varchar(15),
@TENMH as nvarchar(50),
@MADVT as varchar(15),
@SOLUONGMH as int,
@HANSUDUNG as smalldatetime,
@GIAMUA as bigint,
@GIABAN as bigint,
 
@MOTA as ntext,
@TINHTRANG as bit
 as 
update dbo.[MATHANG] set 
	MAMH= @MAMH,
	MATH= @MATH,
	MANH= @MANH,
	MAKHO= @MAKHO,
	TENMH= @TENMH,
	MADVT= @MADVT,
	SOLUONGMH= @SOLUONGMH,
	HANSUDUNG= @HANSUDUNG,
	GIAMUA= @GIAMUA,
	GIABAN= @GIABAN,
	 
	MOTA= @MOTA,
	TINHTRANG= @TINHTRANG
 where 	(@MAMH=dbo.[MATHANG].MAMH)

GO


--Created:11/29/2010
--Author:


if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[MATHANG_getall]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[MATHANG_getall]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[MATHANG_getall]

 as 
select 	MAMH,
	MATH,
	MANH,
	MAKHO,
	TENMH,
	MADVT,
	SOLUONGMH,
	HANSUDUNG,
	GIAMUA,
	GIABAN,
	
	MOTA,
	TINHTRANG
 from  dbo.[MATHANG]
GO

--
--
--
--
--
-----------------------Nhà Cung C?p------------------
if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[NHACUNGCAP_add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[NHACUNGCAP_add]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[NHACUNGCAP_add]
@MANCC as varchar(15),
@MAKV as varchar(15),
@TENNCC as nvarchar(50),
@DIACHI as nvarchar(50),
@MASOTHUE as varchar(15),
@SOTAIKHOAN as varchar(30),
@NGANHANG as nvarchar(50),
@SDT as varchar(15),
@EMAIL as varchar(50),
@FAX as varchar(15),
@WEBSITE as varchar(30),
@TINHTRANG as bit
 as 
insert into dbo.[NHACUNGCAP](
	MANCC,
	MAKV,
	TENNCC,
	DIACHI,
	MASOTHUE,
	SOTAIKHOAN,
	NGANHANG,
	SDT,
	EMAIL,
	FAX,
	WEBSITE,
	TINHTRANG)
values(
	@MANCC,
	@MAKV,
	@TENNCC,
	@DIACHI,
	@MASOTHUE,
	@SOTAIKHOAN,
	@NGANHANG,
	@SDT,
	@EMAIL,
	@FAX,
	@WEBSITE,
	@TINHTRANG)
GO

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[NHACUNGCAP_update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[NHACUNGCAP_update]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[NHACUNGCAP_update]
@MANCC as varchar(15),
@MAKV as varchar(15),
@TENNCC as nvarchar(50),
@DIACHI as nvarchar(50),
@MASOTHUE as varchar(15),
@SOTAIKHOAN as varchar(30),
@NGANHANG as nvarchar(50),
@SDT as varchar(15),
@EMAIL as varchar(50),
@FAX as varchar(15),
@WEBSITE as varchar(30),
@TINHTRANG as bit
 as 
update dbo.[NHACUNGCAP] set 
	MANCC= @MANCC,
	MAKV= @MAKV,
	TENNCC= @TENNCC,
	DIACHI= @DIACHI,
	MASOTHUE= @MASOTHUE,
	SOTAIKHOAN= @SOTAIKHOAN,
	NGANHANG= @NGANHANG,
	SDT= @SDT,
	EMAIL= @EMAIL,
	FAX= @FAX,
	WEBSITE= @WEBSITE,
	TINHTRANG= @TINHTRANG
 where 	(@MANCC=dbo.[NHACUNGCAP].MANCC)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[NHACUNGCAP_delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[NHACUNGCAP_delete]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[NHACUNGCAP_delete]
@MANCC as varchar(15)
 as 
delete dbo.[NHACUNGCAP]
 where 	(@MANCC=dbo.[NHACUNGCAP].MANCC)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[NHACUNGCAP_getall]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[NHACUNGCAP_getall]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[NHACUNGCAP_getall]

 as 
select 	MANCC,
	MAKV,
	TENNCC,
	DIACHI,
	MASOTHUE,
	SOTAIKHOAN,
	NGANHANG,
	SDT,
	EMAIL,
	FAX,
	WEBSITE,
	TINHTRANG
 from  dbo.[NHACUNGCAP]
GO

--
--
--
--
--
----------------------Nhân Viên---------------------
if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[NHANVIEN_add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[NHANVIEN_add]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[NHANVIEN_add]
@MANV as varchar(15),


@TENNV as nvarchar(50),
@DIACHI as nvarchar(50),
@NGAYSINH as datetime,
@SCMND as varchar(15),
@SDT as varchar(15),
@TINHTRANG as bit
 as 
insert into dbo.[NHANVIEN](
	MANV,
	
	TENNV,
	DIACHI,
	NGAYSINH,
	SCMND,
	SDT,
	TINHTRANG)
values(
	@MANV,
	
	@TENNV,
	@DIACHI,
	@NGAYSINH,
	@SCMND,
	@SDT,
	@TINHTRANG)
GO

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[NHANVIEN_update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[NHANVIEN_update]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[NHANVIEN_update]
@MANV as varchar(15),

@TENNV as nvarchar(50),
@DIACHI as nvarchar(50),
@NGAYSINH as datetime,
@SCMND as varchar(15),
@SDT as varchar(15),
@TINHTRANG as bit
 as 
update dbo.[NHANVIEN] set 
	MANV= @MANV,
	
	TENNV= @TENNV,
	DIACHI= @DIACHI,
	NGAYSINH= @NGAYSINH,
	SCMND= @SCMND,
	SDT= @SDT,
	TINHTRANG= @TINHTRANG
 where 	(@MANV=dbo.[NHANVIEN].MANV)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[NHANVIEN_delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[NHANVIEN_delete]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[NHANVIEN_delete]
@MANV as varchar(15)
 as 
delete dbo.[NHANVIEN]
 where 	(@MANV=dbo.[NHANVIEN].MANV)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[NHANVIEN_getall]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[NHANVIEN_getall]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[NHANVIEN_getall]

 as 
select 	MANV,
	
	TENNV,
	DIACHI,
	NGAYSINH,
	SCMND,
	SDT,
	TINHTRANG
 from  dbo.[NHANVIEN]
GO
--
--
--
--
--
-----------------Nhóm Hàng------------
if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[NHOMHANG_add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[NHOMHANG_add]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[NHOMHANG_add]
@MANH as varchar(15),
@TENNHOMHANG as nvarchar(50),
@GHICHU as nvarchar(100)
 as 
insert into dbo.[NHOMHANG](
	MANH,
	TENNHOMHANG,
	GHICHU)
values(
	@MANH,
	@TENNHOMHANG,
	@GHICHU)
GO

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[NHOMHANG_update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[NHOMHANG_update]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[NHOMHANG_update]
@MANH as varchar(15),
@TENNHOMHANG as nvarchar(50),
@GHICHU as nvarchar(100)
 as 
update dbo.[NHOMHANG] set 
	MANH= @MANH,
	TENNHOMHANG= @TENNHOMHANG,
	GHICHU= @GHICHU
 where 	(@MANH=dbo.[NHOMHANG].MANH)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[NHOMHANG_delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[NHOMHANG_delete]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[NHOMHANG_delete]
@MANH as varchar(15)
 as 
delete dbo.[NHOMHANG]
 where 	(@MANH=dbo.[NHOMHANG].MANH)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[NHOMHANG_getall]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[NHOMHANG_getall]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[NHOMHANG_getall]

 as 
select 	MANH,
	TENNHOMHANG,
	GHICHU
 from  dbo.[NHOMHANG]
GO

--
--
--
--
----------------Qu?n Lý-------------
if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[QUANLY_add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[QUANLY_add]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[QUANLY_add]
@MAQL as varchar(15),
@USERNAME as nvarchar(30),
@PASSWORD as nvarchar(50),
@TENQL as nvarchar(50),
@DIACHI as nvarchar(50),
@NGAYSINH as datetime,
@SCMND as varchar(15),
@SDT as varchar(15),
@TINHTRANG as bit
 as 
insert into dbo.[QUANLY](
	MAQL,
	USERNAME,
	PASSWORD,
	TENQL,
	DIACHI,
	NGAYSINH,
	SCMND,
	SDT,
	TINHTRANG)
values(
	@MAQL,
	@USERNAME,
	@PASSWORD,
	@TENQL,
	@DIACHI,
	@NGAYSINH,
	@SCMND,
	@SDT,
	@TINHTRANG)
GO

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[QUANLY_update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[QUANLY_update]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[QUANLY_update]
@MAQL as varchar(15),
@USERNAME as nvarchar(30),
@PASSWORD as nvarchar(50),
@TENQL as nvarchar(50),
@DIACHI as nvarchar(50),
@NGAYSINH as datetime,
@SCMND as varchar(15),
@SDT as varchar(15),
@TINHTRANG as bit
 as 
update dbo.[QUANLY] set 
	MAQL= @MAQL,
	USERNAME= @USERNAME,
	PASSWORD= @PASSWORD,
	TENQL= @TENQL,
	DIACHI= @DIACHI,
	NGAYSINH= @NGAYSINH,
	SCMND= @SCMND,
	SDT= @SDT,
	TINHTRANG= @TINHTRANG
 where 	(@MAQL=dbo.[QUANLY].MAQL)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[QUANLY_delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[QUANLY_delete]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[QUANLY_delete]
@MAQL as varchar(15)
 as 
delete dbo.[QUANLY]
 where 	(@MAQL=dbo.[QUANLY].MAQL)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[QUANLY_getall]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[QUANLY_getall]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[QUANLY_getall]

 as 
select 	MAQL,
	USERNAME,
	PASSWORD,
	TENQL,
	DIACHI,
	NGAYSINH,
	SCMND,
	SDT,
	TINHTRANG
 from  dbo.[QUANLY]
GO

--
--
--
--

--
--
--
--
--
-------------------------------Thu?----------------------------------------
 if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[THUE_add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[THUE_add]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[THUE_add]
@MATH as varchar(15),
@SOTHUE as smallint
 as 
insert into dbo.[THUE](
	MATH,
	SOTHUE)
values(
	@MATH,
	@SOTHUE)
GO

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[THUE_update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[THUE_update]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[THUE_update]
@MATH as varchar(15),
@SOTHUE as smallint
 as 
update dbo.[THUE] set 
	MATH= @MATH,
	SOTHUE= @SOTHUE
 where 	(@MATH=dbo.[THUE].MATH)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[THUE_delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[THUE_delete]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[THUE_delete]
@MATH as varchar(15)
 as 
delete dbo.[THUE]
 where 	(@MATH=dbo.[THUE].MATH)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[THUE_getall]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[THUE_getall]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[THUE_getall]

 as 
select 	MATH,
	SOTHUE
 from  dbo.[THUE]
GO

--
--
--
--
--
--


if exists (select * from dbo.sysobjects where id = object_id(N'dbo.[MATHANG_delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.[MATHANG_delete]
GO
--Created:11/29/2010
--Author:
CREATE procedure dbo.[MATHANG_delete]
@MAMH as varchar(15)
 as 
delete dbo.[MATHANG]
 where 	(@MAMH=dbo.[MATHANG].MAMH)

GO

-------------------
GO
CREATE procedure [dbo].[BAOCAOTHEOKHO_getall]

@NGAYTHANGTU AS DATETIME,
@NGAYTHANGDEN AS DATETIME
 as 
select SOLUONGMH,GIABAN,((GIABAN*SOLUONGTON) + (SOTHUE * SOLUONGTON * GIABAN)/100) as thanhtienban, THUE.MATH,SOTHUE,TENNHOMHANG,TENMH,SOLUONGTON,MATHANG.MAKHO,TENKHO,DONVITINH,NGAYTHANG,SOLUONGDAU,GIAMUA*SOLUONGDAU AS TONGTIENDAU,SOLUONGNHAP,SOLUONGNHAP*GIAMUA AS TONGTIENNHAP,SOLUONGXUAT,SOLUONGXUAT*GIABAN AS TONGTIENXUAT,SOLUONGTON,SOLUONGTON*GIAMUA AS TONGTIENTON FROM TONKHO,MATHANG,DONVITINH,NHOMHANG,KHO,THUE
WHERE  MATHANG.MANH=NHOMHANG.MANH AND DONVITINH.MADVT=MATHANG.MADVT AND MATHANG.MAMH=TONKHO.MAMH AND MATHANG.MAKHO=KHO.MAKHO  AND THUE.MATH = MATHANG.MATH AND
 NGAYTHANG BETWEEN @NGAYTHANGTU AND @NGAYTHANGDEN

--
GO
CREATE procedure [dbo].[BAOCAOTHEOMATHANG_getall]

--@NGAYTHANGTU AS DATETIME,
--@NGAYTHANGDEN AS DATETIME,
as
select
      MAMH,
	THUE.MATH,SOTHUE,
	MATHANG.MANH,tennhomhang,
	TENMH,
	DONVITINH.MADVT,DONVITINH,
	SOLUONGMH,
	HANSUDUNG,
	GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,
	GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,

	MOTA,
	TINHTRANG

FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt
-------------------------------------------------------------


GO
CREATE procedure [dbo].[BAOCAOTHONHOMHANG_getall]

@NGAYTHANGTU AS DATETIME,
@NGAYTHANGDEN AS DATETIME
 as 
select GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban, THUE.MATH,SOTHUE,TENNHOMHANG,TENMH,SOLUONGMH,MATHANG.MAKHO,TENKHO,DONVITINH,NGAYTHANG,SOLUONGDAU,GIAMUA*SOLUONGDAU AS TONGTIENDAU,SOLUONGNHAP,SOLUONGNHAP*GIAMUA AS TONGTIENNHAP,SOLUONGXUAT,SOLUONGXUAT*GIABAN AS TONGTIENXUAT,SOLUONGTON,SOLUONGTON*GIAMUA AS TONGTIENTON FROM TONKHO,MATHANG,DONVITINH,NHOMHANG,KHO,THUE
WHERE  MATHANG.MANH=NHOMHANG.MANH AND DONVITINH.MADVT=MATHANG.MADVT AND MATHANG.MAMH=TONKHO.MAMH AND MATHANG.MAKHO=KHO.MAKHO  AND THUE.MATH = MATHANG.MATH AND
 NGAYTHANG BETWEEN @NGAYTHANGTU AND @NGAYTHANGDEN


------------------------------------


-----------Doi mat khau
go
create procedure [dbo].[NHANVIEN_DoiMatKhau] 
@MANV as varchar(15),
@Pass as nvarchar(50)
 as 
update dbo.[NHANVIEN] set 
	PASSWORD=@pass
 where 	(@MANV=dbo.[NHANVIEN].MANV)
GO

create procedure [dbo].[NHANVIEN_KiemTraPass]
@MANV as varchar(15),
@Pass as nvarchar(50)
 as 
select * from NHANVIEN
 where 	(@MANV=dbo.[NHANVIEN].MANV) AND @PASS=PASSWORD
-------------------------------------------------
GO
CREATE procedure [dbo].[LOINHUANKINHDOANH_getall]

@NGAYTHANGTU AS DATETIME,
@NGAYTHANGDEN AS DATETIME
 as 

	SELECT 
    
	HOADONNHAP.MAHDN,NGAYNHAP,
    CHITIETHDN.MAMH,SOLUONGNHAP,
    MATHANG.MAMH,TENMH,
	THUE.MATH,SOTHUE,
	MATHANG.MANH,TENNHOMHANG,
	TENMH,
	DONVITINH.MADVT,DONVITINH,
	SOLUONGMH,
	HANSUDUNG,
	GIAMUA,(GIAMUA*SOLUONGNHAP) + (SOTHUE * SOLUONGNHAP * GIAMUA)/100  as TONGTIENMUA,
	GIABAN,(GIABAN*SOLUONGNHAP) + (SOTHUE * SOLUONGNHAP * GIABAN)/100 as TONGTIENBAN,
    ((GIABAN*SOLUONGNHAP) + (SOTHUE * SOLUONGNHAP * GIABAN)/100) -((GIAMUA*SOLUONGNHAP) + (SOTHUE * SOLUONGNHAP * GIAMUA)/100) AS LOINHUAN



FROM THUE,NHOMHANG,MATHANG,DONVITINH ,CHITIETHDN,HOADONNHAP
WHERE THUE.MATH = MATHANG.MATH  and NHOMHANG.MANH=MATHANG.MANH and DONVITINH.MADVT=MATHANG.MADVT and CHITIETHDN.MAMH = MATHANG.MAMH AND CHITIETHDN.MAHDN = HOADONNHAP.MAHDN AND
NGAYNHAP BETWEEN @NGAYTHANGTU AND @NGAYTHANGDEN
----------------------------------------
---
GO

CREATE PROCEDURE [dbo].[THONGKE_CT_MATHANG]
	@NGAY_BD DATETIME,
	@NGAY_KT DATETIME,
	@LOAI_TG VARCHAR(10),
	@LOAI_HT VARCHAR(10)
--	@MANH varchar(15)
AS
BEGIN
	IF(@LOAI_TG = 'NGAY')
	BEGIN
		IF(@LOAI_HT = '0')
						SELECT MAMH,
	THUE.MATH,SOTHUE,
	MATHANG.MANH,tennhomhang,
	TENMH,
	DONVITINH.MADVT,DONVITINH,
	SOLUONGMH,
	HANSUDUNG,
	GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,
	GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,

	MOTA,
	TINHTRANG

 FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and SOLUONGMH > 0   AND HANSUDUNG > GETDATE() AND MAMH IN (SELECT DISTINCT MAMH FROM CHITIETHDN WHERE MAHDN IN (SELECT MAHDN FROM HOADONNHAP WHERE NGAYNHAP BETWEEN @NGAY_BD AND @NGAY_KT))
		ELSE IF (@LOAI_HT = '1')
						SELECT MAMH,
	THUE.MATH,SOTHUE,
	MATHANG.MANH,tennhomhang,
	TENMH,
	DONVITINH.MADVT,DONVITINH,
	SOLUONGMH,
	HANSUDUNG,
	GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,
	GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,

	MOTA,
	TINHTRANG

 FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and SOLUONGMH > 0  AND HANSUDUNG < GETDATE() OR HANSUDUNG = GETDATE() AND MAMH IN (SELECT DISTINCT MAMH FROM CHITIETHDN WHERE MAHDN IN (SELECT MAHDN FROM HOADONNHAP WHERE NGAYNHAP BETWEEN @NGAY_BD AND @NGAY_KT))
		ELSE
						SELECT MAMH,
	THUE.MATH,SOTHUE,
	MATHANG.MANH,tennhomhang,
	TENMH,
	DONVITINH.MADVT,DONVITINH,
	SOLUONGMH,
	HANSUDUNG,
	GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,
	GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,

	MOTA,
	TINHTRANG

 FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and SOLUONGMH > 0  AND  MAMH IN (SELECT DISTINCT MAMH FROM CHITIETHDN WHERE MAHDN IN (SELECT MAHDN FROM HOADONNHAP WHERE NGAYNHAP BETWEEN @NGAY_BD AND @NGAY_KT))
	END
	ELSE IF(@LOAI_TG = 'THANG')
	BEGIN
		IF(@LOAI_HT = '0')
						SELECT MAMH,
	THUE.MATH,SOTHUE,
	MATHANG.MANH,tennhomhang,
	TENMH,
	DONVITINH.MADVT,DONVITINH,
	SOLUONGMH,
	HANSUDUNG,
	GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,
	GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,

	MOTA,
	TINHTRANG

 FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and SOLUONGMH > 0  AND  HANSUDUNG > GETDATE() AND HANSUDUNG > GETDATE() AND MAMH IN (SELECT DISTINCT MAMH FROM CHITIETHDN WHERE MAHDN IN (SELECT MAHDN FROM HOADONNHAP WHERE (MONTH(NGAYNHAP) BETWEEN MONTH(@NGAY_BD) AND MONTH(@NGAY_KT )) AND YEAR(NGAYNHAP)=YEAR(@NGAY_BD)))
		ELSE IF (@LOAI_HT = '1')
						SELECT MAMH,
	THUE.MATH,SOTHUE,
	MATHANG.MANH,tennhomhang,
	TENMH,
	DONVITINH.MADVT,DONVITINH,
	SOLUONGMH,
	HANSUDUNG,
	GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,
	GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,

	MOTA,
	TINHTRANG

 FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and SOLUONGMH > 0   AND (HANSUDUNG < GETDATE() OR HANSUDUNG = GETDATE()) AND MAMH IN (SELECT DISTINCT MAMH FROM CHITIETHDN WHERE MAHDN IN (SELECT MAHDN FROM HOADONNHAP WHERE (MONTH(NGAYNHAP) BETWEEN MONTH(@NGAY_BD) AND MONTH(@NGAY_KT )) AND YEAR(NGAYNHAP)=YEAR(@NGAY_BD)))
		ELSE
						SELECT MAMH,
	THUE.MATH,SOTHUE,
	MATHANG.MANH,tennhomhang,
	TENMH,
	DONVITINH.MADVT,DONVITINH,
	SOLUONGMH,
	HANSUDUNG,
	GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,
	GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,

	MOTA,
	TINHTRANG

 FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and SOLUONGMH > 0  AND MAMH IN (SELECT DISTINCT MAMH FROM CHITIETHDN WHERE MAHDN IN (SELECT MAHDN FROM HOADONNHAP WHERE (MONTH(NGAYNHAP) BETWEEN MONTH(@NGAY_BD) AND MONTH(@NGAY_KT )) AND YEAR(NGAYNHAP)=YEAR(@NGAY_BD)))
	END
	ELSE IF(@LOAI_TG = 'QUI')
	BEGIN
		IF(@LOAI_HT = '0')
						SELECT MAMH,
	THUE.MATH,SOTHUE,
	MATHANG.MANH,tennhomhang,
	TENMH,
	DONVITINH.MADVT,DONVITINH,
	SOLUONGMH,
	HANSUDUNG,
	GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,
	GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,

	MOTA,
	TINHTRANG

 FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and SOLUONGMH > 0   AND HANSUDUNG > GETDATE() AND MAMH IN (SELECT DISTINCT MAMH FROM CHITIETHDN WHERE MAHDN IN (SELECT MAHDN FROM HOADONNHAP WHERE YEAR(NGAYNHAP) = YEAR(@NGAY_BD) AND MONTH(NGAYNHAP) BETWEEN MONTH(@NGAY_BD) AND MONTH(@NGAY_KT)))
		ELSE IF (@LOAI_HT = '1')
						SELECT MAMH,
	THUE.MATH,SOTHUE,
	MATHANG.MANH,tennhomhang,
	TENMH,
	DONVITINH.MADVT,DONVITINH,
	SOLUONGMH,
	HANSUDUNG,
	GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,
	GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,

	MOTA,
	TINHTRANG

 FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and SOLUONGMH > 0   AND HANSUDUNG < GETDATE() OR HANSUDUNG = GETDATE() AND MAMH IN (SELECT DISTINCT MAMH FROM CHITIETHDN WHERE MAHDN IN (SELECT MAHDN FROM HOADONNHAP WHERE YEAR(NGAYNHAP) = YEAR(@NGAY_BD) AND MONTH(NGAYNHAP) BETWEEN MONTH(@NGAY_BD) AND MONTH(@NGAY_KT)))
		ELSE
						SELECT MAMH,
	THUE.MATH,SOTHUE,
	MATHANG.MANH,tennhomhang,
	TENMH,
	DONVITINH.MADVT,DONVITINH,
	SOLUONGMH,
	HANSUDUNG,
	GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,
	GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,

	MOTA,
	TINHTRANG

 FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and SOLUONGMH > 0  AND   MAMH IN (SELECT DISTINCT MAMH FROM CHITIETHDN WHERE MAHDN IN (SELECT MAHDN FROM HOADONNHAP WHERE YEAR(NGAYNHAP) = YEAR(@NGAY_BD) AND MONTH(NGAYNHAP) BETWEEN MONTH(@NGAY_BD) AND MONTH(@NGAY_KT)))
	END
	ELSE
	BEGIN
		IF(@LOAI_HT = '0')
            			SELECT MAMH,
	THUE.MATH,SOTHUE,
	MATHANG.MANH,tennhomhang,
	TENMH,
	DONVITINH.MADVT,DONVITINH,
	SOLUONGMH,
	HANSUDUNG,
	GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,
	GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,

	MOTA,
	TINHTRANG

 FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and SOLUONGMH > 0 
			
		ELSE IF (@LOAI_HT = '1')
						SELECT MAMH,
	THUE.MATH,SOTHUE,
	MATHANG.MANH,tennhomhang,
	TENMH,
	DONVITINH.MADVT,DONVITINH,
	SOLUONGMH,
	HANSUDUNG,
	GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,
	GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,

	MOTA,
	TINHTRANG

 FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and SOLUONGMH > 0  AND HANSUDUNG < GETDATE() OR HANSUDUNG = GETDATE()
		ELSE
						SELECT MAMH,
	THUE.MATH,SOTHUE,
	MATHANG.MANH,tennhomhang,
	TENMH,
	DONVITINH.MADVT,DONVITINH,
	SOLUONGMH,
	HANSUDUNG,
	GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,
	GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,

	MOTA,
	TINHTRANG

 FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and SOLUONGMH > 0  AND HANSUDUNG > GETDATE()
	END
END



----------------------------------------------------
GO
CREATE PROCEDURE [dbo].[THONGKE_CT_MATHANG2]
--	@NGAY_BD DATETIME,
--	@NGAY_KT DATETIME,n
	@LOAI_TG nVARCHAR(30),
	@LOAI_HT char(1)
AS
BEGIN
	if(@loai_Tg='')
begin 

		if(@loai_ht='0')--load tat ca
					SELECT MAMH,
					THUE.MATH,SOTHUE,
					MATHANG.MANH,tennhomhang,
					TENMH,
					DONVITINH.MADVT,DONVITINH,
					SOLUONGMH,
					HANSUDUNG,
					GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,
					GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,

					CAST(GETDATE()- HANSUDUNG AS INT) AS' SONGAYHETHANH' ,
					CAST (HANSUDUNG -GETDATE() AS INT) as'SONGAYHETHANH',
					MOTA,
					TINHTRANG

				 FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and  SOLUONGMH > 0 
		if(@loai_ht ='1')--con han
SELECT MAMH,
					THUE.MATH,SOTHUE,
					MATHANG.MANH,tennhomhang,
					TENMH,
					DONVITINH.MADVT,DONVITINH,
					SOLUONGMH,
					HANSUDUNG,
					GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,
					GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,

					CAST(GETDATE()- HANSUDUNG AS INT) AS' SONGAYHETHANH' ,
					CAST (HANSUDUNG -GETDATE() AS INT) as'SONGAYHETHANH',
					MOTA,
					TINHTRANG

				 FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and  SOLUONGMH > 0 and  HANSUDUNG - getdate() < 0
if(@loai_ht ='2')---het han
	SELECT MAMH,
					THUE.MATH,SOTHUE,
					MATHANG.MANH,tennhomhang,
					TENMH,
					DONVITINH.MADVT,DONVITINH,
					SOLUONGMH,
					HANSUDUNG,
					GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,
					GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,

					CAST(GETDATE()- HANSUDUNG AS INT) AS' SONGAYHETHANH' ,
					CAST (HANSUDUNG -GETDATE() AS INT) as'SONGAYHETHANH',
					MOTA,
					TINHTRANG

				 FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and  SOLUONGMH > 0 and HANSUDUNG - getdate() >=0 
END
else

begin
if(@loai_ht ='0')
SELECT MAMH,THUE.MATH,SOTHUE,
					MATHANG.MANH,tennhomhang,
					TENMH,
					DONVITINH.MADVT,DONVITINH,
					SOLUONGMH,
					HANSUDUNG,
					GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,
					GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,

					CAST(GETDATE()- HANSUDUNG AS INT) AS' SONGAYHETHANH' ,
					CAST (HANSUDUNG -GETDATE() AS INT) as'SONGAYHETHANH',
					MOTA,
					TINHTRANG

				 FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and  SOLUONGMH > 0 and tennhomhang = @loai_tg
if(@loai_ht ='1')
SELECT MAMH,
					THUE.MATH,SOTHUE,
					MATHANG.MANH,tennhomhang,
					TENMH,
					DONVITINH.MADVT,DONVITINH,
					SOLUONGMH,
					HANSUDUNG,
					GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,
					GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,

					CAST(GETDATE()- HANSUDUNG AS INT) AS' SONGAYHETHANH' ,
					CAST (HANSUDUNG -GETDATE() AS INT) as'SONGAYHETHANH',
					MOTA,
					TINHTRANG

				 FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and  SOLUONGMH > 0 and tennhomhang = @loai_tg and HANSUDUNG- getdate() <0
if(@loai_ht ='2')
SELECT MAMH,
					THUE.MATH,SOTHUE,
					MATHANG.MANH,tennhomhang,
					TENMH,
					DONVITINH.MADVT,DONVITINH,
					SOLUONGMH,
					HANSUDUNG,
					GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as thanhtien,
					GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as thanhtienban,

					CAST(GETDATE()- HANSUDUNG AS INT) AS' SONGAYHETHANH' ,
					CAST (HANSUDUNG -GETDATE() AS INT) as'SONGAYHETHANH',
					MOTA,
					TINHTRANG

				 FROM THUE,nhomhang,MATHANG,DONVITINH WHERE THUE.MATH = MATHANG.MATH  and nhomhang.manh=MATHANG.manh and DONVITINH.madvt=MATHANG.madvt and  SOLUONGMH > 0 and tennhomhang = @loai_tg and HANSUDUNG - getdate()>= 0
END 
END
---------------------------------------------------------------

---------------------------------------------------------------


---------------------------------------------------------------
GO

CREATE PROCEDURE [dbo].[THONGKE_NHOMHANG]
	@NGAY_BD DATETIME,
	@NGAY_KT DATETIME,
	@LOAI_TG VARCHAR(10)
AS
BEGIN
	IF(@LOAI_TG = 'NGAY')
		SELECT * FROM NHOMHANG WHERE MANH IN (SELECT MANH FROM MATHANG WHERE MAMH IN (SELECT DISTINCT MAMH FROM CHITIETHDX WHERE MAHDX IN (SELECT MAHDX FROM HOADONXUAT$ WHERE NGAYXUAT BETWEEN @NGAY_BD AND @NGAY_KT)))
	ELSE IF (@LOAI_TG = 'THANG')
		SELECT * FROM NHOMHANG WHERE MANH IN (SELECT MANH FROM MATHANG WHERE MAMH IN (SELECT DISTINCT MAMH FROM CHITIETHDX WHERE MAHDX IN (SELECT MAHDX FROM HOADONXUAT WHERE MONTH(NGAYXUAT) = MONTH(@NGAY_BD) AND YEAR(NGAYXUAT) = YEAR(@NGAY_BD))))
	ELSE IF (@LOAI_TG = 'QUI')
		SELECT * FROM NHOMHANG WHERE MANH IN (SELECT MANH FROM MATHANG WHERE MAMH IN (SELECT DISTINCT MAMH FROM CHITIETHDX WHERE MAHDX IN (SELECT MAHDX FROM HOADONXUAT WHERE YEAR(NGAYXUAT) = YEAR(@NGAY_BD) AND MONTH(NGAYXUAT) BETWEEN MONTH(@NGAY_BD) AND MONTH(@NGAY_KT))))
	ELSE
		SELECT * FROM NHOMHANG WHERE MANH IN (SELECT MANH FROM MATHANG WHERE MAMH IN (SELECT DISTINCT MAMH FROM CHITIETHDX))
END
------------------------------------------
GO
CREATE procedure [dbo].[THONGKEHIEUQUAKINHDOANH_getall]

--@NGAYTHANGTU AS DATETIME,
--@NGAYTHANGDEN AS DATETIME
 as 
SELECT MAMH,
	THUE.MATH,SOTHUE,
	MATHANG.MANH,TENNHOMHANG,
	TENMH,
	DONVITINH.MADVT,DONVITINH,
	SOLUONGMH,
	HANSUDUNG,
    
    CAST (HANSUDUNG -GETDATE() AS INT) as'SONGAYHETHANH',
	GIAMUA,(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100  as TONGTIENMUA,
	GIABAN,GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 as TONGTIENBAN,
    (GIABAN*SOLUONGMH + (SOTHUE * SOLUONGMH * GIABAN)/100 -(GIAMUA*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIAMUA)/100) AS LOINHUAN



FROM THUE,NHOMHANG,MATHANG,DONVITINH 
WHERE THUE.MATH = MATHANG.MATH  and NHOMHANG.MANH=MATHANG.MANH and DONVITINH.MADVT=MATHANG.MADVT

-------------------------------------------------
GO
CREATE procedure [dbo].[THONGKETHEOKHACHHANG_getall]

@NGAYTHANGTU AS DATETIME,
@NGAYTHANGDEN AS DATETIME
 as 
--select SOLUONGNHAP,GIANHAP,(SOLUONGNHAP * GIANHAP) + (SOTHUE * SOLUONGNHAP * GIANHAP)/100 AS TIENNHAP,SOLUONGXUAT, (SOLUONGXUAT * GIATIEN) + (SOTHUE *SOLUONGXUAT * GIATIEN)/100 AS TIENXUAT,((SOLUONGMH * GIABAN)-(SOLUONGMH * GIAMUA)) + ( SOTHUE *((SOLUONGMH * GIABAN)-(SOLUONGMH * GIAMUA)))/100 AS LOINHUAN, HOADONXUAT.MAKH,TENKH,NGAYXUAT, TENNHOMHANG,TENMH,CHITIETHDX.MAMH,CHITIETHDX.MAHDX,DONVITINH.MADVT,DONVITINH,GIAMUA,GIABAN,SOLUONGMH,(GIABAN*SOLUONGMH) + (SOTHUE * SOLUONGMH * GIABAN)/100 AS TONGTIENBAN ,GIAMUA*SOLUONGMH + (SOTHUE * SOLUONGMH * GIAMUA)/100 AS TONGTIENMUA,THUE.MATH,SOTHUE FROM CHITIETHDX,MATHANG,DONVITINH,NHOMHANG,KHO,HOADONXUAT,KHACHHANG,NHANVIEN,THUE,CHITIETHDN
select KHACHHANG.MAKH,TENKH ,NHOMHANG.MANH,TENNHOMHANG, HOADONXUAT.MAHDX,NGAYXUAT,TIENPHAITRA,TIENDATRA ,TIENPHAITRA-TIENDATRA as TIENNO,CHITIETHDX.MAMH,SOLUONGXUAT,GIATIEN,(SOLUONGXUAT * GIATIEN) + (SOTHUE *SOLUONGXUAT * GIATIEN)/100 AS TIENXUAT ,MATHANG.MAMH,TENMH, DONVITINH.MADVT,DONVITINH,THUE.MATH,SOTHUE FROM CHITIETHDX,MATHANG,DONVITINH,NHOMHANG,HOADONXUAT,KHACHHANG,NHANVIEN,THUE
WHERE MATHANG.MANH=NHOMHANG.MANH AND DONVITINH.MADVT=MATHANG.MADVT AND CHITIETHDX.MAMH = MATHANG.MAMH AND KHACHHANG.MAKH = HOADONXUAT.MAKH AND HOADONXUAT.MANV = NHANVIEN.MANV AND THUE.MATH = MATHANG.MATH AND HOADONXUAT.MAHDX = CHITIETHDX.MAHDX AND
 NGAYXUAT BETWEEN @NGAYTHANGTU AND @NGAYTHANGDEN
----------------------------------------------------
GO
CREATE procedure [dbo].[THONGKEXUATHANGTHEOKHACHHANG_getall]

@NGAYTHANGTU AS DATETIME,
@NGAYTHANGDEN AS DATETIME
 as 

select HOADONXUAT.MANV,USERNAME, HOADONXUAT.MAKH,TENKH,NGAYXUAT, TENNHOMHANG,TENMH,CHITIETHDX.MAMH,CHITIETHDX.MAHDX,DONVITINH,GIAMUA,GIABAN,SOLUONGMH,SOLUONGMH *GIABAN AS TONGTIENBAN ,SOLUONGMH * GIAMUA AS TONGTIENMUA,THUE.MATH,SOTHUE FROM CHITIETHDX,MATHANG,DONVITINH,NHOMHANG,KHO,HOADONXUAT,KHACHHANG,NHANVIEN,THUE
WHERE MATHANG.MANH=NHOMHANG.MANH AND DONVITINH.MADVT=MATHANG.MADVT AND CHITIETHDX.MAMH = MATHANG.MAMH AND KHACHHANG.MAKH = HOADONXUAT.MAKH AND HOADONXUAT.MANV = NHANVIEN.MANV AND THUE.MATH = MATHANG.MATH AND
 NGAYXUAT BETWEEN @NGAYTHANGTU AND @NGAYTHANGDEN
---------------------------------------------
----------------------------------------Them Nguoi DUng
go
create procedure [dbo].[NHANVIEN_SuaNguoiDung]
@MANV as varchar(15),
@MABP as varchar(15)
 as 
update dbo.[NHANVIEN] set 
	
	MABP= @MABP
 where 	(@MANV=dbo.[NHANVIEN].MANV)
go
create procedure [dbo].[NHANVIEN_getoneBOPHAN]
@mabp varchar(15)
 as 
select 	MANV,
	MABP,
	USERNAME,
	PASSWORD,
	CHUCVU,
	TENNV,
	DIACHI,
	NGAYSINH,
	SCMND,
	SDT,
	TINHTRANG
 from  dbo.[NHANVIEN] where mabp=@mabp and TINHTRANG='True'
GO
create procedure [dbo].[NHANVIEN_gettrue]

 as 
select 	MANV,
	MABP,
	USERNAME,
	PASSWORD,
	CHUCVU,
	TENNV,
	DIACHI,
	NGAYSINH,
	SCMND,
	SDT,
	TINHTRANG
 from  dbo.[NHANVIEN] where TINHTRANG='False'
go
create procedure [dbo].[NHANVIEN_XoaPQ]
@MANV as varchar(15)

 as 
update dbo.[NHANVIEN] set 
	MABP=null,
	USERNAME=null,
	PASSWORD=null,
	TINHTRANG= 'False'
 where 	(@MANV=dbo.[NHANVIEN].MANV)

go
create procedure [dbo].[THEMNGUOIDUNG_update]
@MANV as varchar(15),
@MABP as varchar(15),
@USERNAME as nvarchar(30),
@PASSWORD as nvarchar(50),
@TINHTRANG as bit
 as  
update dbo.[NHANVIEN] set 
	
	MABP= @MABP,
	USERNAME= @USERNAME,
	PASSWORD= @PASSWORD,
	TINHTRANG= @TINHTRANG
 where 	(@MANV=dbo.[NHANVIEN].MANV)

go
create procedure [dbo].[KIEMTRA_USER]
@USERNAME as nvarchar(30)
 as  
select * from NHANVIEN
 where 	@USERNAME=USERNAME

---------------------------------------------------------------------------
-------------------------Cong No Cua Duy Tien
GO
create proc [dbo].[LoadGETALLHDX]
AS
SELECT MAHDX as N'Mã hóa đơn xuất',TENKH as N'Tên khách hàng',HOADONXUAT.MAKH as N'Mã khách hàng',TIENPHAITRA AS N'Tiền phải trả',TIENdaTRA as N'Tiền đã trả', tienphaitra-tiendatra as N'Còn lại'
--if(tienphaitra=tiendatra) update hoadonxuat set tinhtrang='True' where
FROM HOADONXUAT,KHACHHANG WHERE HOADONXUAT.MAKH=KHACHHANG.MAKH and hoadonxuat.tinhtrang='false' 
group by hoadonxuat.mahdx,hoadonxuat.tienphaitra,hoadonxuat.tiendatra,khachhang.tenkh,hoadonxuat.makh
go
------Get1HDX_PT--------------------------
create PROC [dbo].[GETONEPT]
@MAHDX VARCHAR (15)
AS
SELECT MAPT as N'Mã phiếu thu',MANV as N'Mã nhân viên',MAhdx as N'Mã hóa đơn xuất',ngaythu as N'Ngày thu',sotientra_pt as N'Tiền đã trả' FROM PHIEUTHU WHERE MAHDX=@MAHDX
--exec GETONEPT 'hdx003'
go
---------updatePT---------------
create PROC [dbo].[UPDATEPT]
@MAPT VARCHAR (15),
@MAHDX VARCHAR (15),
@NGAYTHU SMALLDATETIME,
@MANV VARCHAR(15),
@TIENTHU BIGINT
AS
DECLARE @TIENCANSUA bigint
	SET @TIENCANSUA=0
	select @TIENCANSUA =SOTIENTRA_PT FROM PHIEUTHU WHERE MAHDX=@MAHDX AND MAPT=@MAPT
	UPDATE  PHIEUTHU set NGAYTHU =@NGAYTHU,MAHDX=@MAHDX,MANV=@MANV,SoTienTra_PT=@TIENTHU WHERE MAPT=@MAPT
	UPDATE HOADONXUAT SET TIENDATRA=(tiendatra-@TIENCANSUA)+@tienthu where MAHDX=@MAHDX
go
----------------insert----------------
create PROC [dbo].[INSERTPT]
@MAPT VARCHAR (15),
@MAHDX VARCHAR (15),
@NGAYTHU SMALLDATETIME,
@MANV VARCHAR(15),
@TIENTHU BIGINT
AS
	DECLARE @TIENCANSUA bigint
	SET @TIENCANSUA=0
	INSERT INTO PHIEUTHU (MAPT,MAHDX,NGAYTHU,MANV,SoTienTra_PT)   VALUES(@MAPT, @MAHDX,@NGAYTHU,@MANV,@TIENTHU)
	select @TIENCANSUA =SUM(SOTIENTRA_PT) FROM PHIEUTHU WHERE MAHDX=@MAHDX AND MAPT=@MAPT
	update hoadonxuat set TIENDATRA=tiendatra+@TIENCANSUA WHERE MAHDX=@MAHDX
go
-------------------------------------------------------CHI--------------------------------------------------------------
--------get*HDN--------------
create proc [dbo].[LoadGETALLHDN]
AS
SELECT MAHDN as N'Mã hóa đơn nhập',TENncc as N'Tên nhà cung cấp',HOADONnhap.MAncc as N'Mã nhà cung cấp',TIENPHAITRA AS N'Tiền phải trả',TIENdaTRA as N'Tiền đã trả', tienphaitra-tiendatra as N'Còn lại'
--if(tienphaitra=tiendatra) update hoadonxuat set tinhtrang='True' where
FROM HOADONnhap,nhacungcap WHERE HOADONnhap.MAncc=nhacungcap.mancc and hoadonnhap.tinhtrang='false' 
group by hoadonnhap.mahdn,hoadonnhap.tienphaitra,hoadonnhap.tiendatra,nhacungcap.tenncc,hoadonnhap.mancc
go
-----------------get1pc----------------
create PROC [dbo].[GETONEPC]
@MAHDN VARCHAR (15)
AS
SELECT MAPc as N'Mã phiếu chi',MANV as N'Mã nhân viên',MAhdn as N'Mã hóa đơn nhập',ngaychi as N'Ngày chi',SoTienDaTra_PC as N'Tiền đã trả' FROM PHIEUCHI WHERE MAHDN=@MAHDN
GO
------------------UPDATEPc------------------------
create PROC [dbo].[UPDATEPC]
@MAPC VARCHAR (15),
@MAHDN VARCHAR (15),
@NGAYCHI SMALLDATETIME,
@MANV VARCHAR(15),
@TIENTRA BIGINT
AS
DECLARE @TIENCANSUA bigint
	SET @TIENCANSUA=0
	select @TIENCANSUA =SoTienDaTra_PC FROM PHIEUCHI WHERE MAHDN=@MAHDN AND MAPC=@MAPC
	UPDATE  PHIEUCHI set NGAYCHI =@NGAYCHI,MAHDN=@MAHDN,MANV=@MANV,SoTienDaTra_PC=@TIENTRA WHERE MAPC=@MAPC
	UPDATE HOADONnhap SET TIENDATRA=(tiendatra-@TIENCANSUA)+@tientra where MAHDN=@MAHDN
go
---------------insertpc--------------------
create PROC [dbo].[INSERTPC]
@MAPC VARCHAR (15),
@MAHDN VARCHAR (15),
@NGAYCHI SMALLDATETIME,
@MANV VARCHAR(15),
@TIENTRA BIGINT
AS
	DECLARE @TIENCANSUA bigint
	SET @TIENCANSUA=0
	INSERT INTO PHIEUCHI (MAPC,MAHDN,NGAYCHI,MANV,SoTienDaTra_PC)   VALUES(@MAPC, @MAHDN,@NGAYCHI,@MANV,@TIENTRA)
	select @TIENCANSUA =SUM(SoTienDaTra_PC) FROM PHIEUCHI WHERE MAHDN=@MAHDN AND MAPC=@MAPC
	update hoadonnhap set TIENDATRA=tiendatra+@TIENCANSUA WHERE MAHDN=@MAHDN





--Proc web

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
--Created:11/29/2010
--Author:
CREATE procedure [dbo].[NHANVIEN_getONEallWEB]

@MANV AS VARCHAR(15)
 as 
select 	MANV,
	
	TENNV,
	USERNAME,
	DIACHI,
	NGAYSINH,
	SCMND,
	SDT
 from  dbo.[NHANVIEN] WHERE MANV=@MANV

go
CREATE procedure dbo.[HOADONNHAP_getONENV]
@MANV as varchar(15)
 as 
select 	MAHDN,
	MANCC,
	MANV,
	NGAYNHAP,
	TIENPHAITRA,
	TIENDATRA,
	GHICHU,
	TINHTRANG
 from  dbo.[HOADONNHAP]
 where 	MANV=@MANV
go
CREATE procedure dbo.[HOADONXUAT_getOneNV]
@MANV as varchar(15)
 as 
select 	MAHDX,
	MAKH,
	MANV,
	NGAYXUAT,
	TIENPHAITRA,
	TIENDATRA,
	GHICHU,
	TINHTRANG
 from  dbo.[HOADONXUAT]
WHERE MANV=@MANV
go
----------------------------Manh Cuong
set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go

create procedure [dbo].[HOADONNHAP_add]
@MAHDN as varchar(15),
@MANCC as varchar(15),
@MANV as varchar(15),
@NGAYNHAP as smalldatetime,
--Proc HOADONNHAP
@TIENPHAITRA as bigint,
@TIENDATRA as bigint,
@GHICHU as nvarchar(100),
@TINHTRANG as bit
 as 
insert into dbo.[HOADONNHAP](
	MAHDN,
	MANCC,
	MANV,
	NGAYNHAP,
	TIENPHAITRA,
	TIENDATRA,
	GHICHU,
	TINHTRANG)
values(
	@MAHDN,
	@MANCC,
	@MANV,
	@NGAYNHAP,
	@TIENPHAITRA,
	@TIENDATRA,
	@GHICHU,
	@TINHTRANG)
go
set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go

--Proc HOADONNHAP_get
create procedure [dbo].[HOADONNHAP_get]
@NGAYNHAP as smalldatetime
 as 
select 	MAHDN,
	MANCC,
	MANV,
	NGAYNHAP,
	TIENPHAITRA,
	TIENDATRA,
	GHICHU,
	TINHTRANG
 from  dbo.[HOADONNHAP]
 where 	(@NGAYNHAP=dbo.[HOADONNHAP].NGAYNHAP)

--Proc HOADONXUAT_add
set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go

create procedure [dbo].[HOADONXUAT_add]
@MAHDX as varchar(15),
@MAKH as varchar(15),
@MANV as varchar(15),
@NGAYXUAT as smalldatetime,
@TIENPHAITRA as bigint,
@TIENDATRA as bigint,
@GHICHU as nvarchar(100),
@TINHTRANG as bit
 as 
insert into dbo.[HOADONXUAT](
	MAHDX,
	MAKH,
	MANV,
	NGAYXUAT,
	TIENPHAITRA,
	TIENDATRA,
	GHICHU,
	TINHTRANG)
values(
	@MAHDX,
	@MAKH,
	@MANV,
	@NGAYXUAT,
	@TIENPHAITRA,
	@TIENDATRA,
	@GHICHU,
	@TINHTRANG)

--Proc HOADONXUAT_get
set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go


create procedure [dbo].[HOADONXUAT_get]
@NGAYXUAT as smalldatetime
 as 
select 	MAHDX,
	MAKH,
	MANV,
	NGAYXUAT,
	TIENPHAITRA,
	TIENDATRA,
	GHICHU,
	TINHTRANG
 from  dbo.[HOADONXUAT]
 where 	(@NGAYXUAT=dbo.[HOADONXUAT].NGAYXUAT)


--Proc  CHITIETHDN_add
set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go

create procedure [dbo].[CHITIETHDN_add]
@MAHDN as varchar(15),
@MAMH as varchar(15),
@SOLUONGNHAP as int,
@GIANHAP as bigint,
@TINHTRANG as bit
 as 
insert into dbo.[CHITIETHDN](
	MAHDN,
	MAMH,
	SOLUONGNHAP,
	GIANHAP,
	TINHTRANG)
values(
	@MAHDN,
	@MAMH,
	@SOLUONGNHAP,
	@GIANHAP,
	@TINHTRANG)

--Proc CHITIETHDN_get
set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go

create procedure [dbo].[CHITIETHDN_get]
@MAHDN as varchar(15),
@MAMH as varchar(15)
 as 
select 	MAHDN,
	MAMH,
	SOLUONGNHAP,
	GIANHAP,
	TINHTRANG
 from  dbo.[CHITIETHDN]
 where 	(@MAHDN=dbo.[CHITIETHDN].MAHDN)
 and 
	(@MAMH=dbo.[CHITIETHDN].MAMH)

--Proc CTHOADDONNHAP_getall

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go

create procedure [dbo].[CHITIETHDN_getall]

 as 
select 	MAHDN,
	MAMH,
	SOLUONGNHAP,
	GIANHAP,
	TINHTRANG
 from  dbo.[CHITIETHDN]

--Proc CHITIETHDX_add

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go

create procedure [dbo].[CHITIETHDX_add]
@MAHDX as varchar(15),
@MAMH as varchar(15),
@SOLUONGXUAT as int,
@GIATIEN as bigint,
@TINHTRANG as bit
 as 
insert into dbo.[CHITIETHDX](
	MAHDX,
	MAMH,
	SOLUONGXUAT,
	GIATIEN,
	TINHTRANG)
values(
	@MAHDX,
	@MAMH,
	@SOLUONGXUAT,
	@GIATIEN,
	@TINHTRANG)
--Proc CHITIETHDX_get

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go

create procedure [dbo].[CHITIETHDX_get]
@MAHDX as varchar(15),
@MAMH as varchar(15)
 as 
select 	MAHDX,
	MAMH,
	SOLUONGXUAT,
	GIATIEN,
	TINHTRANG
 from  dbo.[CHITIETHDX]
 where 	(@MAHDX=dbo.[CHITIETHDX].MAHDX)
 and 
	(@MAMH=dbo.[CHITIETHDX].MAMH)


-- Proc CHITIETHDX_getall

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go

create procedure [dbo].[CHITIETHDX_getall]

 as 
select 	MAHDX,
	MAMH,
	SOLUONGXUAT,
	GIATIEN,
	TINHTRANG
 from  dbo.[CHITIETHDX]

-- Proc LAYTIENNO
set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go


create procedure [dbo].[LAYTIENNO]
@MANCC as varchar (15)
as
select sum(TIENPHAITRA) - sum(TIENDATRA)as TIENNO from HOADONNHAP where MANCC =@MANCC


-------------------------------------------------
go
create procedure [dbo].[THONGKEHOADON_getall]

@NGAYTHANGTU AS DATETIME,
@NGAYTHANGDEN AS DATETIME
 as 

	SELECT 
    
	HOADONNHAP.MAHDN,NGAYNHAP,
	NHACUNGCAP.MANCC,TENNCC,
    CHITIETHDN.MAMH,SOLUONGNHAP,
    MATHANG.MAMH,TENMH,
	THUE.MATH,SOTHUE,
	MATHANG.MANH,TENNHOMHANG,
	TENMH,
	DONVITINH.MADVT,DONVITINH,
	SOLUONGMH,
	HANSUDUNG,
	GIAMUA,(GIAMUA*SOLUONGNHAP) + (SOTHUE * SOLUONGNHAP * GIAMUA)/100  as TONGTIENMUA,
	GIABAN,(GIABAN*SOLUONGNHAP) + (SOTHUE * SOLUONGNHAP * GIABAN)/100 as TONGTIENBAN,
    ((GIABAN*SOLUONGNHAP) + (SOTHUE * SOLUONGNHAP * GIABAN)/100) -((GIAMUA*SOLUONGNHAP) + (SOTHUE * SOLUONGNHAP * GIAMUA)/100) AS LOINHUAN



FROM THUE,NHOMHANG,MATHANG,DONVITINH ,CHITIETHDN,HOADONNHAP,NHACUNGCAP
WHERE THUE.MATH = MATHANG.MATH  and NHOMHANG.MANH=MATHANG.MANH and DONVITINH.MADVT=MATHANG.MADVT and CHITIETHDN.MAMH = MATHANG.MAMH AND CHITIETHDN.MAHDN = HOADONNHAP.MAHDN AND NHACUNGCAP.MANCC= HOADONNHAP.MANCC AND
NGAYNHAP BETWEEN @NGAYTHANGTU AND @NGAYTHANGDEN
----------------------------------------
---
-------------------------------------------------
GO
CREATE trigger [dbo].[Them_CTHDN]
on [dbo].[CHITIETHDN]
for INSERT
AS
	DECLARE @MAHDN VARCHAR(15),@MAMH VARCHAR(15), @SOLUONGNHAP INT ,@SLNHAP_CU int ,@SLNHAP_MOI int , @GIATIEN_MOI INT 
 set @SLNHAP_CU = 0
SET @SLNHAP_MOI = 0
	SELECT  @MAHDN=MAHDN,@MAMH=MAMH,@SOLUONGNHAP=SOLUONGNHAP ,@GIATIEN_MOI = GIANHAP
	FROM INSERTED
	

	
	UPDATE MATHANG
	SET 	SOLUONGMH =@SOLUONGNHAP + SOLUONGMH,GIAMUA = @GIATIEN_MOI
	WHERE MAMH=@MAMH

------------------------------------------------------------------
GO
CREATE trigger [dbo].[Them_CHITIETHDX]
on [dbo].[CHITIETHDX]
for INSERT
AS
	DECLARE @MAHDX VARCHAR(15),@MAMH VARCHAR(15), @SOLUONGXUAT INT
	SELECT  @MAHDX=MAHDX,@MAMH=MAMH,@SOLUONGXUAT=SOLUONGXUAT 
	FROM INSERTED
	

	
	UPDATE MATHANG
	SET 	SOLUONGMH =SOLUONGMH-@SOLUONGXUAT
	WHERE MAMH=@MAMH


---------
go



--------------------------------------Insert Du lieu----------------------------------------

-- `dbo.KHUVUC`
INSERT dbo.KHUVUC VALUES ('MAKV00001', N'TPHCM', NULL, -1)
INSERT dbo.KHUVUC VALUES ('MAKV00002', N'Hà Nội', NULL, -1)
INSERT dbo.KHUVUC VALUES ('MAKV00003', N'Huế', NULL, -1)
INSERT dbo.KHUVUC VALUES ('MAKV00004', N'Vung tàu', NULL, -1)
GO

-- `dbo.THUE`
INSERT dbo.THUE VALUES ('TH00001', 5)
INSERT dbo.THUE VALUES ('TH00002', 10)
INSERT dbo.THUE VALUES ('TH00003', 15)
GO

-- `dbo.DONVITINH`

INSERT dbo.DONVITINH (MADVT, DONVITINH) VALUES ('DVT00001', N'Chai')
INSERT dbo.DONVITINH (MADVT, DONVITINH) VALUES ('DVT00002', N'Kg')
INSERT dbo.DONVITINH (MADVT, DONVITINH) VALUES ('DVT00003', N'Cái')
INSERT dbo.DONVITINH (MADVT, DONVITINH) VALUES ('DVT00004', N'Lọ')
INSERT dbo.DONVITINH (MADVT, DONVITINH) VALUES ('DVT00005', N'Hũ')
GO

--Bo Phan
INSERT dbo.BOPHAN (MABP, TENBOPHAN, TINHTRANG) VALUES ('MABP00001', N'Mua Hàng', -1)
INSERT dbo.BOPHAN (MABP, TENBOPHAN, TINHTRANG) VALUES ('MABP00002', N'Bán hàng', -1)
INSERT dbo.BOPHAN (MABP, TENBOPHAN, TINHTRANG) VALUES ('MABP00003', N'Mua bán hàng', -1)
INSERT dbo.BOPHAN (MABP, TENBOPHAN, TINHTRANG) VALUES ('MABP00004', N'Quản lý hệ thống', -1)
go
-- `dbo.NHOMHANG`
INSERT dbo.NHOMHANG VALUES ('NH00001', N'Nước Hoa', N'Thom nhu múi mít')
INSERT dbo.NHOMHANG VALUES ('NH00002', N'Sữa duỡng thể', N'Da mịn nhu lụa')
INSERT dbo.NHOMHANG VALUES ('NH00003', N'Sữa rửa mặt', N'Da mịn và hết mụn nhanh chóng')
GO

-- `dbo.NHACUNGCAP`
INSERT dbo.NHACUNGCAP VALUES ('MANCC00001', 'MAKV00001', N'BDT', N'43 Nguyễn thông,TPHCM', '123456', '19001789', N'ACB', '0935399144', 'phamduytien@yahoo.com', '08-345678', 'www.bdt.com', -1)
INSERT dbo.NHACUNGCAP VALUES ('MANCC00002', 'MAKV00002', N'TDB', N'43 Nguyễn thông,Hà Nội', '123456', '19001789', N'DongABank', '0935399144', 'phamtien@yahoo.com', '04-345678', 'www.tdb.com', -1)
GO

-- `dbo.KHACHHANG`
INSERT dbo.KHACHHANG VALUES ('KH00001', 'MAKV00004', N'Phạm Duy Tiên', NULL, NULL, NULL, N'Vung tàu', '0935199144', NULL, NULL, NULL, NULL, NULL)
INSERT dbo.KHACHHANG VALUES ('KH00002', 'MAKV00001', N'Ngọc Anh', NULL, NULL, NULL, N'Bình chánh,TPHCM', '0909999999', NULL, NULL, NULL, NULL, NULL)
INSERT dbo.KHACHHANG VALUES ('KH00003', 'MAKV00001', N'Tuấn Dũng', NULL, NULL, NULL, N'Q3,TPHCM', '0935199144', NULL, NULL, NULL, NULL, NULL)
GO

-- `dbo.NHANVIEN`
INSERT dbo.NHANVIEN VALUES ('MANV00005', 'MABP00001', N'tunglam', N'123456', NULL, N'Tùng Lâm', N'Q11,TPHCM', NULL, NULL, '0908888888', -1)
INSERT dbo.NHANVIEN VALUES ('MANV00003', 'MABP00001', N'tuandung', N'123456', NULL, N' Trần Tuấn Dũng', N'Hoàn Kiếm,Hà nội', NULL, NULL, '0906666666', -1)

INSERT dbo.NHANVIEN VALUES ('MANV00002', 'MABP00001', N'manhcuong', N'123456', NULL, N' Nguyễn Mạnh Cường ', N'Hoàn Kiếm,Hà nội', NULL, NULL, '0907777777', -1)
INSERT dbo.NHANVIEN VALUES ('MANV00004', 'MABP00001', N'duytien', N'123456', NULL, N'Phạm Duy Tiên', N'Hoàn Kiếm,Hà nội', NULL, NULL, '0906666666', -1)
INSERT dbo.NHANVIEN VALUES ('MANV00001', 'MABP00004', N'admin', N'123456', NULL, N'Ðoàn Ngọc Anh', N'Hoàn Kiếm,Hà nội', NULL, NULL, '0906666666', -1)
GO


INSERT dbo.KHO VALUES ('MAKHO00001', 'MANV00001', N'Kho hàng 1', N'32/144Nguyễn Trãi,Q5,TPHCM', '08-3123456', '0908888888', NULL, NULL, NULL, -1)
INSERT dbo.KHO VALUES ('MAKHO00002', 'MANV00003', N'Kho hàng 2', N'32/144Nguyễn Trãi,THANH XUAN,Hà nội', '04-3123456', '0906666666', NULL, NULL, NULL, -1)
GO


-- `dbo.HOADONNHAP`
INSERT dbo.HOADONNHAP (MAHDN, MANCC, MANV, NGAYNHAP, TIENPHAITRA, TIENDATRA, GHICHU, TINHTRANG) VALUES ('MAHDN00001', 'MANCC00001', 'MANV00001', '2010-12-21 00:00:00.000', 100000, 15000, N'Tesst', 0)
INSERT dbo.HOADONNHAP (MAHDN, MANCC, MANV, NGAYNHAP, TIENPHAITRA, TIENDATRA, GHICHU, TINHTRANG) VALUES ('MAHDN00002', 'MANCC00002', 'MANV00002', '2010-12-21 00:00:00.000', 150000, 10000, N'Trả hết', -1)
GO

-- `dbo.HOADONXUAT`
INSERT dbo.HOADONXUAT (MAHDX, MAKH, MANV, NGAYXUAT, TIENPHAITRA, TIENDATRA, GHICHU, TINHTRANG) VALUES ('MAHDX00001', 'KH00001', 'MANV00001', '2010-12-21 00:00:00.000', 1500000, 10000, N'Còn Nợ', 0)
INSERT dbo.HOADONXUAT (MAHDX, MAKH, MANV, NGAYXUAT, TIENPHAITRA, TIENDATRA, GHICHU, TINHTRANG) VALUES ('MAHDX00002', 'KH00002', 'MANV00002', '2010-12-21 00:00:00.000', 100000, 100000, N'Hết', -1)
GO

-- `dbo.MATHANG`
INSERT dbo.MATHANG VALUES ('MH00001', 'TH00001', 'NH00001', 'MAKHO00001', N'BOSS', 'DVT00001', 10, NULL, 100000, 105000, NULL, -1)
INSERT dbo.MATHANG VALUES ('MH00002', 'TH00001', 'NH00002', 'MAKHO00001', N'VASILE', 'DVT00001', 10, NULL, 100000, 105000, NULL, -1)
INSERT dbo.MATHANG VALUES ('MH00003', 'TH00003', 'NH00003', 'MAKHO00002', N'BIOREFORMEN', 'DVT00001', 10, NULL, 100000, 115000, NULL, -1)
GO


-- `dbo.CHITIETHDN`
INSERT dbo.CHITIETHDN (MAHDN, MAMH, SOLUONGNHAP, GIANHAP, TINHTRANG) VALUES ('MAHDN00001', 'MH00001', 25, 25000, 0)
INSERT dbo.CHITIETHDN (MAHDN, MAMH, SOLUONGNHAP, GIANHAP, TINHTRANG) VALUES ('MAHDN00002', 'MH00002', 30, 30000, -1)
GO

-- `dbo.CHITIETHDX`
INSERT dbo.CHITIETHDX (MAHDX, MAMH, SOLUONGXUAT, GIATIEN, TINHTRANG) VALUES ('MAHDX00001', 'MH00001', 10, 150000, -1)
INSERT dbo.CHITIETHDX (MAHDX, MAMH, SOLUONGXUAT, GIATIEN, TINHTRANG) VALUES ('MAHDX00002', 'MH00002', 15, 10000, 0)
GO


INSERT dbo.THONGTINCT VALUES ('1', N'ProManager', N'HCM', '09230293', '02392093', '', '39283923', 0x89504E470D0A1A0A0000000D494844520000012C0000006408060000003C010DC00000000467414D410000B18E7CFB5193000000206348524D0000870F00008C0F0000FD520000814000007D790000E98B00003CE5000019CC733C857700000A396943435050686F746F73686F70204943432070726F66696C65000048C79D96775454D71687CFBD777AA1CD30025286DEBBC000D27B935E456198196028030E3334B121A2021145449A224850C480D150245644B1101454B007240828311845542C6F46D68BAEACBCF7F2F2FBE3AC6FEDB3F7B9FBECBDCF5A170092A72F9797064B0190CA13F0833C9CE911915174EC0080011E608029004C5646BA5FB07B0810C9CBCD859E2172025F0401F07A58BC0270D3D033804E07FF9FA459E97C81E89800119BB339192C11178838254B902EB6CF8A981A972C66182566BE284111CB893961910D3EFB2CB2A398D9A93CB688C539A7B353D962EE15F1B64C2147C488AF880B33B99C2C11DF12B1468A30952BE237E2D8540E33030014496C1770588922361131891F12E422E2E500E048095F71DC572CE0640BC49772494BCFE173131205741D962EDDD4DA9A41F7E464A5700402C300262B99C967D35DD252D399BC1C0016EFFC5932E2DAD24545B634B5B6B434343332FDAA50FF75F36F4ADCDB457A19F8B96710ADFF8BEDAFFCD21A0060CC896AB3F38B2DAE0A80CE2D00C8DDFB62D3380080A4A86F1DD7BFBA0F4D3C2F890241BA8DB1715656961197C3321217F40FFD4F87BFA1AFBE67243EEE8FF2D05D39F14C618A802EAE1B2B2D254DC8A767A433591CBAE19F87F81F07FE751E06419C780E9FC313458489A68CCB4B10B59BC7E60AB8693C3A97F79F9AF80FC3FEA4C5B91689D2F81150638C80D4752A407EED07280A1120D1FBC55DFFA36FBEF830207E79E12A938B73FFEF37FD67C1A5E225839BF039CE252884CE12F23317F7C4CF12A0010148022A9007CA401DE800436006AC802D70046EC01BF8831010095603164804A9800FB2401ED8040A4131D809F6806A50071A41336805C741273805CE834BE01AB8016E83FB60144C80676016BC060B10046121324481E421154813D287CC2006640FB941BE50101409C54209100F124279D066A8182A83AAA17AA819FA1E3A099D87AE4083D05D680C9A867E87DEC1084C82A9B012AC051BC30CD809F68143E0557002BC06CE850BE01D7025DC001F853BE0F3F035F8363C0A3F83E7108010111AA28A18220CC405F147A29078848FAC478A900AA4016945BA913EE426328ACC206F51181405454719A26C519EA850140BB506B51E5582AA461D4675A07A51375163A859D4473419AD88D647DBA0BDD011E8047416BA105D816E42B7A32FA26FA327D0AF31180C0DA38DB1C2786222314998B59812CC3E4C1BE61C6610338E99C362B1F2587DAC1DD61FCBC40AB085D82AEC51EC59EC107602FB0647C4A9E0CC70EEB8281C0F978FABC01DC19DC10DE126710B7829BC26DE06EF8F67E373F0A5F8467C37FE3A7E02BF4090266813EC08218424C2264225A1957091F080F0924824AA11AD8981442E7123B192788C789938467C4B9221E9915C48D124216907E910E91CE92EE925994CD6223B92A3C802F20E7233F902F911F98D0445C248C24B822DB141A246A2436248E2B9245E5253D24972B564AE6485E409C9EB92335278292D291729A6D47AA91AA99352235273D2146953697FE954E912E923D257A4A764B0325A326E326C99029983321764C62908459DE242615136531A29172913540C559BEA454DA21653BFA30E506765656497C986C966CBD6C89E961DA521342D9A172D85564A3B4E1BA6BD5BA2B4C4690967C9F625AD4B8696CCCB2D957394E3C815C9B5C9DD967B274F9777934F96DF25DF29FF5001A5A0A710A890A5B05FE1A2C2CC52EA52DBA5ACA5454B8F2FBDA7082BEA290629AE553CA8D8AF38A7A4ACE4A194AE54A57441694699A6ECA89CA45CAE7C46795A85A262AFC255295739ABF2942E4B77A2A7D02BE9BDF4595545554F55A16ABDEA80EA829AB65AA85ABE5A9BDA4375823A433D5EBD5CBD477D564345C34F234FA345E39E265E93A199A8B957B34F735E4B5B2B5C6BAB56A7D694B69CB69776AE768BF6031DB28E83CE1A9D069D5BBA185D866EB2EE3EDD1B7AB09E855EA25E8DDE757D58DF529FABBF4F7FD0006D606DC0336830183124193A19661AB6188E19D18C7C8DF28D3A8D9E1B6B184719EF32EE33FE6862619262D26872DF54C6D4DB34DFB4DBF477333D3396598DD92D73B2B9BBF906F32EF317CBF4977196ED5F76C78262E167B1D5A2C7E283A59525DFB2D572DA4AC32AD6AAD66A84416504304A1897ADD1D6CED61BAC4F59BFB5B1B411D81CB7F9CDD6D036D9F688EDD472EDE59CE58DCBC7EDD4EC9876F576A3F674FB58FB03F6A30EAA0E4C870687C78EEA8E6CC726C749275DA724A7A34ECF9D4D9CF9CEEDCEF32E362EEB5CCEB922AE1EAE45AE036E326EA16ED56E8FDCD5DC13DC5BDC673D2C3CD67A9CF3447BFA78EEF21CF152F26279357BCD7A5B79AFF3EEF521F904FB54FB3CF6D5F3E5FB76FBC17EDE7EBBFD1EACD05CC15BD1E90FFCBDFC77FB3F0CD00E5813F06320263020B026F0499069505E505F30253826F848F0EB10E790D290FBA13AA1C2D09E30C9B0E8B0E6B0F970D7F0B2F0D108E3887511D7221522B9915D51D8A8B0A8A6A8B9956E2BF7AC9C88B6882E8C1E5EA5BD2A7BD595D50AAB53569F8E918C61C69C8845C786C71E897DCFF4673630E7E2BCE26AE366592EACBDAC676C4776397B9A63C729E34CC6DBC597C54F25D825EC4E984E7448AC489CE1BA70ABB92F923C93EA92E693FD930F257F4A094F694BC5A5C6A69EE4C9F09279BD69CA69D96983E9FAE985E9A36B6CD6EC5933CBF7E137654019AB32BA0454D1CF54BF5047B8453896699F5993F9262B2CEB44B674362FBB3F472F677BCE64AE7BEEB76B516B596B7BF254F336E58DAD735A57BF1E5A1FB7BE6783FA86820D131B3D361EDE44D894BCE9A77C93FCB2FC579BC337771728156C2C18DFE2B1A5A550A2905F38B2D5766BDD36D436EEB681EDE6DBABB67F2C62175D2D3629AE287E5FC22AB9FA8DE93795DF7CDA11BF63A0D4B274FF4ECC4EDECEE15D0EBB0E974997E5968DEFF6DBDD514E2F2F2A7FB52766CF958A6515757B097B857B472B7D2BBBAA34AA7656BDAF4EACBE5DE35CD356AB58BBBD767E1F7BDFD07EC7FDAD754A75C575EF0E700FDCA9F7A8EF68D06AA83888399879F049635863DFB78C6F9B9B149A8A9B3E1CE21D1A3D1C74B8B7D9AAB9F988E291D216B845D8327D34FAE88DEF5CBFEB6A356CAD6FA3B5151F03C784C79E7E1FFBFDF0719FE33D2718275A7FD0FCA1B69DD25ED40175E474CC7626768E7645760D9EF43ED9D36DDBDDFEA3D18F874EA99EAA392D7BBAF40CE14CC1994F6773CFCE9D4B3F37733EE1FC784F4CCFFD0B11176EF506F60E5CF4B978F992FBA50B7D4E7D672FDB5D3E75C5E6CAC9AB8CAB9DD72CAF75F45BF4B7FF64F153FB80E540C775ABEB5D37AC6F740F2E1F3C33E43074FEA6EBCD4BB7BC6E5DBBBDE2F6E070E8F09D91E891D13BEC3B537753EEBEB897796FE1FEC607E807450FA51E563C527CD4F0B3EECF6DA396A3A7C75CC7FA1F073FBE3FCE1A7FF64BC62FEF270A9E909F544CAA4C364F994D9D9A769FBEF174E5D38967E9CF16660A7F95FEB5F6B9CEF31F7E73FCAD7F366276E205FFC5A7DF4B5ECABF3CF46AD9AB9EB980B947AF535F2FCC17BD917F73F82DE36DDFBBF077930B59EFB1EF2B3FE87EE8FEE8F3F1C1A7D44F9FFE050398F3FCBAC4E8D3000000097048597300000B1000000B1001AD23BD75000024D049444154785EED9D7B7055D5BDC7F7FECBDBDEA24D6F4B8BD5D68B2D820F54C24344B83CC233E49C9CBC082FF181D1D811B1D452BD8A0F4023023E219C8440021815C5B6C89DFEC16D3BB5F74EF10E33E0D432C33869B1B768CB74A246279D3BF923F7FBFDADBD77F63967BF4E0E392721EBCCAC39E7ECBD9EBFF55B9FF55B6BAFBD96D1DBDB6B68A765A07540EBC050D001819551B6E3A811DBD96BC41A2DB70BDFB6B3AFA57CD37F035C31C222FCCB857346E66728085EE7510342EB40F63AA08065185B8D8B46FCD6F8FEFCD346E90B3D46BCA957B964AF7175A2C31875E34971FC3D7D7DA7C08CF762748D078DB29D450583960696B690F52861D8E8800D2C36FB11708B8D6BAB4E19E50051398035E7F12E5C5B0A576C39FEDE2AF02A7DBE47FCD06F6CE7092356204B4B036BD828ABB648B2B7482E3499B981A59AFED8B2CD625D9537F71AB31EFD8B070F78A9D8F8FAD8DF38FEE83FD6585790E1A106960696B6B0868D0E6402ABF88E7A8155026ECEE3677C80C5CB638C497567C51FDD822DB0B276723E2CBF4E036BD828EB85662DE8F2646F3106006B3780F54410B00CE3EAF27D4639FC255A9445166BCC2FAC08470D2C0D2C6D610D1B1DF006560210AA0084C28075FDF27586F8DD0368E13B0E60712E2BD4C112A33516EA8F71D97EDDDFAE3434B0868DB26A8B247B8BE442935926B026DE592FB0AA04844A422CACA96BD60BAC2AF7F6E229219E2EDAC0B2E0C2FFF15D4570750E78E2BB0C4CD4D7C1ADC7F5D1DEE04A095F227EFB5CB58A9369C19F06960696B6B0868D0E78006B75BDC0AA0A102A793278483877F3DB022BBAE93F3A0B900050004979B2C84834D51915BB0F0AFC2A607D952779BD18BF3B247EBA44F3A7021FB715150784CA712DD1B41EF73B8DB2974E1953EF6F17B768FB1F252EC699684E8A3F0DAC61A3AC179AB5A0CB93BDC598012C73E2EA7AB3AAB5D7AC6EEB354B36FA02CB4C34179B809AF8E3F7F8A5870558E5C9A409A898809859857BD5FBF08DF82A5A8A11E63375DD8A9FA09BF754CCB19604764DF477C224D0AE2A7D0F3C02E96469055DD2B862C6FB66BCB147E2803FF81F9DCE2CAD08D92B82969996D950D0016F6011423500CDDCCD9EC00290AA0194CF0446F43BA5FE2CA0B158C06318EBE07E6D5E57D521F76AF62B68259AFF6C8E5F724AEE5D8B7B844EE9B66EE31B63674938BA445391F8238C26ACFAD08993569738897FA63176F17B12375DA2E93DB1E85C9FA120789D470D08AD03D9EB4026B026DD552F805972A0D78CEDF814602A01A0E05A4AF07B3DAC2905221B560A2CEB1CE8D8F08145A4E2794541EB866527C54AA215A6ACA5C370ED7023AC61A4619627F728C0B5F51A5FF9D6DA8C38FBE25E6CCE7EB4D3AC411EE93FB663830656F695AF1B8C96D950D3010F60D5015880C09276C00040E0B08E168FED4A9EF8D89C72EF59E3AA45A7E5751EC3A8F3044BA2D950C0423C884FC1CAB2A432BE01B1C4EED1E2BF0680038C1C90798681FFAB4A0F0BAC08C48A962F34B074E31B6A8D4FE7377B9DF50616A151FB6AAF59F652B7F1ED89278D8B2F3DC6A19CE5B65AC3BEC50A2A9C68F77089DD8600AFF635011F80E4ED4FCD7B1966E9739B046E7453EF7B177353FEFE959536D3AC68EE51F1135A7B4A6C686945C85E11B4CCB4CC86820E64026B322C2C42832098BBE9634080EF118E725B3029BFFD80550160D1FA59FABA584178BAE70FA04493612ED8724C204977F39A43A1C0A20557F2E439C9672DF23B77E38B1A58BAD10D8546A7F3D87F3DF500D6DDF50281A5077BCD05CF9CF105957DA39C169287AB6801B00092656F88D584A508DEFE1896D6D8C2673B244D026EFA8FDAB16CC1DFBF8401B026DEF98EF8B7C35879D20AD17F85D0B2D3B21BCC3AE001AC7BEA0500CBDEEC35176E89002C595F95E92AF71802BEE587C45AC3BA2B6F7F0C4B6B0C69499A04DCEC470FCB10D22B5EFB1A8135FDC1767319210747C86960E935597A11E905AD0399C09A0260110204CDC267730316C1B7E22DB180428135F3A1F7CCE50016D32DDF754659643E30B42137E3C7EDE672008EF99D70DBF31A58DA3A18CCD681CE5BEEFAE901ACFA7A010741B3280AB03039CE09F27457B9D71090ACFC990005ABE1BDFD311C2DACA9F71D115889FF37B0D2BE8DABDD03C260C859BAFD98E493F15F319D4B25E4A3152377C5D032D4321C8C3AE0032C8063C54F01ACAD112C2C3F60B50258B07E56FE5C01A8B2D51F3E9CAFBAF4C6FB957F006B392054B17B83B2B23CE227C8AA107FE59E4E01D6DC4D5C06E13C18188C82D679D200D03A90BB0E6402EBA67BEB050204CDA26DE1C0223CBC1C81424BEDD6C300D09BB098002C3FBFBC0EE09893567F28A064DAB5AF7E6154D3CA02CCD2C37142BFE6956AB1C818F7E8596FB81F0E68C5C85D31B40CB50C07A30E6402ABE4F1CD62E5AC02686ADBFF11FA94D01342804CF5BE2201DFAAB7657889FFF264CF1F5AB837E25B6B31CCEB92F4E96A0EEC11D071498484851358ED2FC2BD8F0458D72FEDB0965E38591D8C82D679D200D03A90BB0E64022BD17442ACA2554714346A5FAB0B84960D121750D4706DEF06B194241E5A4CAFAD57F0C1302F3D8CFD9F0B51BF54D48A45A45D6269D12D3D7814D65431AC2D42906BBBAACDDAD7FF24C347052B67EE4ACF61E5AE10BA5169190E661D50C0AA6AAD83C5D200107488D5B202A012076070A941EDABC78DEAFD0D98387756933B1073C3879650555B1DD65D1D9470021D573CB88EFBD8432B045ADC95615CECB459FA7C97B3D4C15EA3256BAE1EFCC01839EEB817ACF4A4BB6E7083B9C1E9BCE5A69F0A586316ACC5E113CF19DF9DF62BE3B2C92733DC15338EC8FDEFCD8D65585BE9C01AB3702DFCB579C6C3EBD7546C0E0496C407F071F70782EBA28B7FEBC4A520C55784B823C418B1D43C3E5A2972530A2D3F2DBFC1AA03F690708C350F641FE7E5F7EDFF8A4E1F38A2C4153A35E6F2C0E3C7ECFC30EED0CF6015B6CE970681D681DC742073C7D1501C680F5A025A026112D060CA0D4C7EF253C02ADBC13DD7D7E7ECCA7694849F00BD83FBB8E79E16E328435C652F23FFDA69191448077CC8A5813590C09AD770025BC4E0D49B1CDDFC678E861EA65AB2F14175D47D8E2ED6D86BCC585FA31B6A811AAAEE245447A98195D7374B9485356BC319238E23E7737504911CA4EAD788706FD6865FE49C8EE413694DB8BD5E034B03ABA03AA0815508603D0660E1B8F99C1D4012DB19302C04B0166EFF7BEEE930AF484B034B0F870B6DE96960150058B301AC724020670788CC79BCD5D7CA8AED1C2DA0C9391D0DAC825A158586C4604A5F03AB10C0C290B0FC3C816401F6D0E289CE194A856B9CBF3A5FE9680B4B5B5783015C1A580500D6A4BA773181DD89A3E9BB8CF266584039388224B6B3C813587337FD56595739C43F7F4BB731E3279D92DF6B2A57844EF20F06A5D679B870E1AA81550060F1E41BC3D86A7C67EA11014A0240E9AF63F8855BD76458593CDDB9ECE5EE7EC72BF941DCD72D392979556E4CF4A1112C3C5A7EB60B7C3870214C640FB7F216A8CE34B00A022C25F6E23BEAC5FA49E038F87E3B849FFDF82FE4F8798182E5E28DC50A8639C63DF5BE7605C3102760421EC43562EEACB144B95D3C964CFDE675C74F8438C3D28C7A3F256F761EF99D431E064379DD1D422E65892A47B73F276D5B9EE99D530EB20DCA8F1B58B1C622E814F46A67915E873590EBB06CA187016BE6C39D918053FAFCDF538045652A79F2597F18027293EE3EABACAF20A0E17E18B0EC861B6FACC6047F1290ECF01F865A0F1AE2C983023251B8888AED80CE0D1C9FDFB6C267E42D7914737ACAA93C6041AD05D1A88D365FE5F5CA8F1B92EC90E2BB207394C171B82672B2E11141566EB986C9C0F6AB3A222B5D91259CFD5F3A26D46B840E21529DBAF483FEA5DCA2679D4ACF302552B231A681955760B5001CE90E2099F3E4190514AFFBAE6BB4D2E2BBB00ADDAA5C56EC9C8DC77CC39623CE497763381A1637EE4F5D030B2BCD7A633ACA922A82F2AC5790B2E1179257290BE265DAE5C94F247C18B84451099AB0F938799A9974ACB8F82E5A99C77DC12D79A0EC920D9E654CB128F2585E4F585106BB000ABBB1725ED292A3234F5E435D289059328B387FA9E642BD2D69C76A4E4B3BBDB3B3E529326D628740EBC73FCED03A657DB253B1C0CB4E2E5DCFF81F1DBF0656BE80452BA7028D38DD511926AC7A471AB7D77DF735FA59B06593D3ABF1F4E6D8CE6EDF704C735C7C7368DC8CD70656CAF0431ACF7ACC717D121A4794BCC7937F427C69D6817B4E88007E020765449005CBADCE6E04AC929F450A230D1E16578A7592967E5ECB9B361F1647C7C0FC89AE44908180A4F9785675C3B8456F32D2E6E124A8EB88693BF52D79507265FED3E3954E35429DC61BBF405DA2FC80B0575BE1350DAC019BD74A7DF999434201D29E4C474BE4E6FBDB31A10EF078DC4FB906BF25B0A86296C2B1B1FAC5CB70251BBB8C89ABFDD3B6E3661EBC8015C7308A3D9B286758DEA2DC473C848B2FB4502E51EE08E98905D7DC004B03B08AE0DF29AB40CBEACD331A6D9ECBEB1AD2495DA263C8A62CFDA913EA4B0AB0A453022860A152A6FD8953C2B03E90FF8CBA8D58A74CBBECC50DE84C3EF29401F3AD819527604D04B0D86356A262D31D2B9AC09AFEE08746257E7BF9715F13CB422C2BAEBF7A562AD72FDE49779D1060F9A56D87631C5EC0E20114D3D69E8B94AFB07C3BF791566CC7FBBEBD7C098015450E125F047979E54B7A730F6B20DFE5B5AD110223DEF8E77E9727B2EC0996346029ABEE84AF1E651337EB437548D643170099BA1AB94E03EA93F9463BD243C27C0C0927DE0968B032F6663AF64E0456F11D47A577F3F2E3BEC678CA939C0C358CB99B8E295879C50B7FD7D52415B07CD2B6C331DDA9C843C65009501C5F7BD83BBC8745E59797F4FC49199AB89345EAD0C451EE0872089353D07DA6BF683B9688A4A5CFFFF92C2F81C532C71BDF8A54F7B994D9A96B949DBA63A71D7B69FBF94D1B7517DBF98ED3219DAF3A659DA11D6960E5055880061B73556BA6A3221158A3AEBFDFD78F3B1CFDCFDEF0A21CD315DFD5ED1927FDB3B7FBDAE83201965FDA76BC761E6CCBCDFD54E792CB6BA1DC3D46950D452A24FE4F7BE09C716D65478AE335490B7EBDCAEA5CC3FDB2173F702CC5BEA752566F1C250E972CDD0D39305D2B0CFD973C8197C52D4BB550E565BAEC7CC2EAC7A927C865EEA62E7151C3B8EB9861C4C222B0B2489BE158E77C9ACDEFB03AE6FDF2263511EF0656A85E78B40F77D9A1CB1A587903161B715BA6AB442511581C8E2CDA6601C8C39F1316FE4B5FF823E6AEA0E83E71B292A9D43C7C4280E5E7CF4AC7CE835703661C53EEC5BC129470DA0FCF1957CC781FF11E867B0C8E0755B8DD63C6D7AF3A6EC47702704165C03DC6C793A6531E790320A36ED86F5C3AE1A4316F7357681C4C83659B527FD6B8B6AA43BEC3CA2AF9827C166DFB5FA7E1BAF390CFF252DE0BB61CC2D992DEBAE19621CB3566E169C81B4283633D442AAB25A34B8B4F8A5CE9C4AA03B44AB71F0D4D3BDED863A5CB3AE7A2E2C32A0ED6B14FBE599E45885BC0D88F3A4D29373B5F38EA8B06567EE6B04C08DA44EF6256B7653A54BA394D8065C0DF1F4CFEF7F2E7BE463FF39F6EF5F5CBFB93EF3E81272E8CD33F6D3B4E3B0F5EC08AA397BC7CF273A2A40A52331D8547FC4C439C3CB183726295BC79D3BD6742CB4179249AB0D6266D0D1157D963A9AD59F2C45FCCEA1059300E824AED454F70AEE37F5F59BB652856806569B88195CFF2B27ECA93DD91EA7BCA3D6751BEC50EE0510F262CDCC865EDDB0E5BC9BC3C391A07E606EB1AE53BBEE6544ABA9415E31A5BFA5E601DA35C8E7CB3A953A923D43BD32EDDDE6DC26A9772D29ABF72B65E87856DAB06C2CA4C794AA8A0C1C6B72FD3092CD62A6061CEC9D75F465856AC477CBCC69E6FCCA2E70891C0B4EDF0761EBC80A5145420A2E0D434DA4CEC5E6F56B41C85C277E0D8B15E39299AFF793DD15C644EBEE788895ED2377F561ECDA96B6EF31C9631DF251BCFA886EC5346DE83420BA8522DA4A526AC82C0B41927AD930C0BCF82673ECA0B5913D80A387E65B4AEB33E2F9F82FA4C1BC2A2ECFD2A2BD39EFFF483A1BA46EB8AF255F36CA9EEB249AB03C38B7C9BFADE788854A72C2FEAB5CFAA63BB705BF2A306A2B1EA38B1779F6CE0677D041AAC889AFD998ED72D6071CE4994C0CB5F36D7A8E0040C1533286D3B4E3B0F622571DEC1EDACE14302A0AADC73B4AF578572B9F3248D0E65A9DAFB8939BFE19834C2A03CD32F87ABD210D2D20448CCB99B00AC803878EFE6351F28EBCE159E61676F3867D684A44F191158052B2FEA66CE638FFAEA855B76E5028E31997202D8673C783654D6196545B8E90FB686A63DBFE153744425E88432DDEC476A02C3B37E67FE7B8D53BF51EA94654638E3B249BF13ABCEE3A3E192170BEB2E008B0DE840A6E3F5690F888585CF0873D6A39D6635C1E6E137CA3586BD65DD39D51809AC80B4EDF8EC3CD8C33A776F4A45ABD85D078BE4D3E8F98A907FA689BC79F6DEA2DC9B01AC8078181E969C3314B5F31C252CCBCD79127970916639E4ADBC36347CF4C2A96BC860F6634E7DA6E6572CE8A3BEBA65C7915E569671D1D6DF87D627E51F64FD09547DF434BD7EA3D40BD383FE4B67EBF3D1C0CA07B02659D058F24A2F4E584E75ACF45B1C601966F1EDEF8865E2E537CA35869DB41AAFB7A8792533286D3B3E3B0F12C6D580A5F1B6D489D22E816246493FAA1FC689BC650087E933DD794F9D91C6E0175F509EC3C2324EF6E4893460E5B3BC9CBF42BD87D6356580F2D81D506AFD448C23BDAC51E41BB51EFDFCA5D76F943459A7D07F29AB06D680CC55059F9A630F0927D5C1C22284DA331D15D2052C63F4AC877DFD7A854FBF86741887F5DA0A801590B61DD6CE8365953993EA89DD1806EEFD5C41C323EFB95CA33C90376F603559C00A48D733CF845D84B0CC371A941C18EB001AB0CE6779D98005588472906C210301968F3518258EF4B24695518EF58B75802B9CFA8D92A6BB4E35B00A0C2CF61EB550CC7447CBC50D2C3E655BFC42B7590B45F5F21F780D6112496BBE838D97161680E597B61D979D0737B0D8A0E23BF68B65159426EF33FE8AA61E993712FF11F22E962080956ED51120B07CCCF9B0B0084ABFB4BDF21C352CE3445E538095EFF2DAC00A932F65197BF9D30C6BD0B6446FF9617B681D7995955668907C45EEEC3008D47E38B71E46AD17779D6A60151A586CC8AF663A2A0D94CE5D3F9884FF40299387FFA06BEC11A7DED7D71B3BC0F249DB8ECBCE831B58B03E301C0438A9B83EF960B89B7E70568EBD576BB37E6D5C557A1A735E3D81E1181F7BD3506085A44DB9A558856ED8058495F46189BA2DAC7C9797757375F9669143583DD34F450BF61E4B1BB213ECA5CFFD5E2CB4A038D2CB4A5872EA214CC7CA5EEAC693EB0EF3BAEAAC9D3176F17B2975E3744211EB5403AB80C09A0C2B87CAB1F4B54C4720A403EBDACA7DBEFEBDE2B0AFB1479CB0EA0DA5285C8200C50C4ADB0967E5C10987B0152DC5D2B306A587FBC63F8F7C840F0BEC21289FEE600EED0301566058E4157973F2AA765E508EF098FFF41969847E71D872B3F39C4D58C6C9BC57ECB6E454A0F28E1C372B54C6CC2BCBBAF8F94DCACAB264C4BAAD6C191D29BCBBACB65E4CA96F0ED5B1F88ECF655943FFDC6227AFFDA9530DAC4202EB6E008B0DF8F54CC74679CB8F522C2C59DE2080F3F01F740D618CCB26AF1608D0B1579B1C90B61D979D075A1C56585879B7F9E6D90EB7708B5A4D9F021BA479F39A430A3601F9A73C903769846EE870880890980B1A002C02DE270E8F3CA7C22E202CE3A4AC2A5A0A5B5E3E155EF04C576039A5FC284B75DB17984FC48E0EA823CA0C798725FB4E7858BBAC169C055870D093501D2328ABDAB8E58C6B71B0AB63B1E027F555B9773D5CD2D36F7FEA5403AB00C0AAD8CD858125E6BCCD2F8AD22D3B98E9787DDEA65F627D13DF292B418517C9F206C0401AAB5718CF78E057016494287425D6CF20CEC0B4ED78D2F350B11B8B3F013A4221287DDEAF6AED6B44B48C2AF71499E58D7F0CCDBBA409B948B95B506E0B5C2233E47BF18B7F35970594DF9567CAD889837920ECC264C7BC57EF53322F5479D9A15C5B05E884C89975C0F2D41CF80C796E00BCEAF0FBA8AF4EA5D7990367D79B09D01373C68FCF05C78134454E8016E14E8B548009C7DF846655ABCA8B0C49F930A3ADC181962C3446C7D98F3A6518BD0E6B609630783D29143A6225F37F3B968628D11BDE8ECA486BA206BDFE822D3156148676EFAA46E71326FD3AFDDEF48313B632A9B911CBCA084ADB8EC795079379F8DEDC986A4801E92F459954235A8F9EB85A1AD392573E89966FAB114AB9ADE11961E3C82C405EE9794E8983D6D93300565878A6AF645EB0F2B2317FF53BB5260E1109CF2FEBC19299585D61E573D51BAC59654DBA80C5A78EDF9BD3165AC7922687D0ED9D0226B793B933EA982B2FD289B5D52968D1CAEF4F9D220EE8810656BE81B570CB1969F0CBDF8CE6A81893EFA9978ABA72CEC3A22891C34289AF5F0A935CAC2B4314316A58B7BFBE3C8CC2D3A9EEF0FCBB1A12957B7916E5B5D3455E9967195A642BB35CE3286479D57AA311C6F7E7FD97AAEB7EC82E4A1DDBF2B5A70AEC6FBEB3492B4BEA2D828EA6775E9E615006420C1D98D379665BA74C076134B00A022C2AC2A1688E3DA70D2C2E6FA8DAD3A3142942782889F1B52BCBA457ABDC0360B101440897EEC7CE03E1714DC5FF48EFD99F78B209C3BC23CF7DC08A5866771AFD8DA390E5ED03C74CB3F88E0FC5328D5ADFFD916F3AB068657DF9EB0DE6C267BB54C7D40F7DF10AC3B8AADBBA38D49661A3002B8B3AA55F0DACFCCF614111CE8812AC782B9A634F37C5B2B0088C690F203C2A2F2C3CD3287992AF348C708045E50F0BE775DFCE034D7A3EF15BB8B52B521EDC7189125B0A1A250FC8AB0216953B4B99D9F1F7378E4296D70108C081332CCDF1B51D0EB4C2E44619130C8B9F47FD84E8982D9B0C6059165ED115AFE2551D05ADB074C3EEB3DEABF6F66084705CF4B13F75CAF2400FB48595770B8B8D8FB0FA693447859952AF86841CFB17DFFE86F44C61E1E967D26A1E64A1E60D2AF71A62198585F3BA6FE7C19E5CFD5251AB404B7AC80865A1B255B5F6E029D4490C0B6021460883BC32CF7DCA1D214C7ADEFB1B4721CB9B021081D652E31B638FB3F351F3426EAB0432A12C6D50110AA367BF6F4EBCF35DD5A104E898000BF2F502961A968E3258CFFFF6134CC25B167556BA63E58B61A7AE396BFCD325BF409C336575BE03AC2CEA94E5D4C02A80852593BF593CE9E35C833D24E45CD4E55356477A82C47098F352139D9CC3C2909013A2519F30BAFDD979B0E3622F890DE3A4F7078854E3B07AF49568242B7FA61A8BDD90E66EEC342EB9FC3F11A6D8BC61F9A948E5E7A4B06D61652B333BEFFD8DA390E5655DD1B1AEED0E426D6DB3D5B8F8DBC744E637DF7FD6844C1D07A81863CB4EDB50C01C54BBC89EF5E0E95037E5D89996F2B5D3F3FA56F5FC18764A382969D943C4208BCAB6A4A917C827F38C38B837192C7DAB6C0456B675CA368330DAC2CAB385258AC7D5DFD939F5389715CE9E2F7AD8318E92A8E15CB6E9BAFDF39CBF3E056783528B070FB3B1C09AFB50941A0D418034775327AF51D9AD32ABA5152A4CB47CF435D8FEC84CA5D1FF380A535E0758B08CAB5AABE18AE5699EAA3FD6BD6C4A68C99472A1E3FE50DC7A6584744CA5DB8FC930CE0F58BC3767C387EA29A1AB4EFD7EAB9D12FA8049ABCB0D4CFB37410AA05A75CEB71C98CF511969A8B2F4A74E1926E3A3776B181888A51EF3E525F9B06B51942BDF7E1484D858EA2C25E48257C282CAC56BA90D3FDFF93BDFE9E5A3BCF2541743F8EAB68F6438B6A47D3DC02593D58EC59C5E2E590705CBA5E640890C1B57FEDCDFD10ABAF1D6C36ABA2002B06C3F7DC024206D58BABFED5D5E07A6CE7DDA8706D66005960C13B4BBE06540F02C79A54E5949000F87D7CB0E7E82A98024DE772C01BC046832A41387DFD56D45041BFC7D26616E3DECED78AF7A5F8FF1D5EFD63A2BE4DD3A15D6690EC2FB1A581A581A8C05EB1860290148D84EE8E354F0D062E2DC2020460B6AE941AC6A7FDD72F86D4FB207C18A1063F81B56704FF6119EE0F70352D90E6E6D5C0DC70367E11A9370475DAE41AE97ED2836CA5EC611F503E0B48595FF49F79C3AA88235226DD5E5CDAAE3D2959A03D5F2F4EFD6B7FDDD4AC0C719F6D19A0AF06BDFA3FFD2E7BA3011BEDAD3BA52C3DDBE4F6C278EE5229876751AF1248E024B774DB8663BEB5E6C17CF202CD1C01A18AB279FD664EE7358F604B2FEEE7B8276A1C982C3C145DBDE9661E02A4068D591F3E3685DD5ECEFC1916987947565BDFF97FE6DE32A0EEB89802AA70394223BF89FF7D421585AE7DFCAD216D650B3B07C94EC426BB4C3BA3C9808FFCAC847CC590F9F1368D13ACA095A084FCB2AD1D46D7CF39ADFA0CD8FF185957A7AC77303718A3821D5ECE12C78A55B56739EE832E63CD925605BB4FDEF728AF4F91E166A606960052AEFB00647013B077BFDD39558040AD0A8B92C82EB3FA2BB5B619971D8B81CD09BF600166E7EF5CD5058D9C09AF9084E1107AC1238113A61430B205AB0A5DB985477D6B8BAA2C3B8F4C693C688515C63652F51491A93EEC2B997F037E1F63F2860598EBF6D675F737F07DD73FBD3C0D2C0D2C02A2098C23A04AE0C378C76635CECB4BC6E438B4BE6AD7CE6ACEC79AD15989CAF39D023A0BAE4B2BE859B61E9D9C09AF5C82F05563CC27EDADA73C69805A78D1197321E2E59E95BBAC0650E021B1EA9B68B2F36F71A8B5FEC31BEF2CDB50EA0EC7BE5490C311B8BFBAEDB1093B00D7007110F26F65D704BFFAD81A581A5813588812580C11051AD734B0A7CC6C54F6357D60FB1BF7D2776607539FCE7F5EB97751823C7F19DBDBE859B5140D5B7C0D680A574C498F950A7B892273B8C690FB4223E0B4E1E4089EF2AC25C175F6CEE35FE75A67A5FB00F64DCCF4D596AB31E79541D706BC5A1F6754F4AB805CF9C45D8B1FEC092C37B3D3FF99C881E4E69E53EE9EE5B65FAC630910057BABB17E9A62FDEE4425DAE84E7AB3CB97C18873B6EFE579654BA93AD8E9B7E85F560CA1AA35568FB2190A6FF78B30069E6C37C117F71DF3DD9F63A29E1623B7A8C6F5DA71E06F010DB8C3470AD3CC90D1D71545DB23ABD60C30922F92CAB06562E4D48872DBC0432408243792B9AB151E35E1C25BFB3C7F8F2BF606867018707F6269A8AF1B27E8371D1081E48B2D5B9C7C3362A76279D7023C7C9C300F8AF835B8FE161511FD804568619DB794AFCCF792C75EB7004CC67231E4E6969C162C7D5E154E143B1AC8154248C1C47E8E0B87A1C796F56C38D5FA216A3DA478D55B43408606841CD7F2AE69CF5A860858378716C3D0F73BD723676A278FC51F8ED906B0893EA5F4E194F2AFF38326EE116A693F2198A721E0A79D68D55036BD0EB4030B05C2780279A8A00A3CFE4DCC9D97294FC520756952D000CAEF3DEAC47D431F30EC82C58F10CCA329CB5197BE9B8004FCEAFC435428C87AD72EB66A64158CD7CE877D893BF4BCEBA042035B0F2D3F10F7A651D0AD4D7791C58658D042C9ED89CD8FD969C119068EAC1894ECDCEA9E21538E8842778F3DEFCA7BB8C2F7DED65E778B98A963AB362CFE7B20533F7CD2780166DFBABF1ED8927D535FCBF651DE7C1B8568CB03A61FEDB43BFC3FF757859FB5D89B3F4856E0DAC81D501BB8D6960690B6BD0EB4030B0AC732D2BF7E2541C02076EFC520ED14639C7A995274FA9433C9E01AC8A5A659848C0F14CCB8A96CFB9EBA859D9DA2D7E78E02E37091C5FBB4260C430DC9EB9A2A50896D427389B9371AF938D2B6F59D72E7E6E587E52F258DEC493A4E4A33BB181019816AC06D6A0D7814060C959828449DBE7723EC09C27D45090D7F9B490F708151C54E2C08AB0A9C4B1765518EA8DBCFA371806FE5A36A05461D7E145ECCB01A7CF301F86D786AE3F64DEB0F2720C27FF249B4DDEF48323B2650E8F894B34FD4D8086F720F11FF0DB8DD3A014B434B034B0B4120C53B806028BF029DFB5419DBC8D7DBAE28D9FAA3DB5ACB30671149C3A8B10F7CB5EBE55CE92ACDE87F92C0CF5C62FE930676F58E31C0156F6D25F01376C97B3EF0486859FF2B521CC85ADC1FF4F10EEFF64134875CC1DE7C34E9873377F2CD618D327E07076A3586F1A5803D656072C62DDC30C4C0F331CE51A082C5A3A35FBBFB0B6B7C126802B4F3A670DAA7DE08BD5F6DDB2FD8D75B4576B37F7A417CB68C90175A88538FB0061FC16BF72386B1716BE9E3246025E8495F8435CFC5EB4ED8C9C6F59D1FC375A6A488BEBD1F49070003B560DAC0114EE7084CB4094390858586BB5C63993529DC884E1A0753AB73ACDD930275A47931142F4A3E0320656D25B02A6799B3BE5400D6EA7BC685B9780A9045B6B736B657550855AF87A1926E2E33BD561B274D56DFFE07900CE3B91AE8C0E841C749C7818AB85A02DA1C1AE038116D6C4D50D021880C6F8329EFED9879238FBD0CB6E0F756251D1A9D5F263647F2F5A49383149C2A9EB7C27916699BD9D3641D5775085DA47BE5D0EB1C05344FCE6AB46CA4FDA67B0CB74A8E64F034B5B58835E070281C5D76E2EBA98ABD6091AEF1D4BD526807C35486D63C3DD536BF67F24A7F804ED74EAB739A5DA47BED83AC0C4337B431508833DDF835E5907BB0075FE06DE420D049682913FA832A063EF9E0A58711FF9A09D4EA3ECA6EB9339AD1703A3171A58DAC21AF43A100CAC2C77B6E0928492C7933271EE585759C6E1DE6942032BAFFA93D7C474AF3330BDCE852ED7F30D2C63C26DCF9B3370D02BE79FB2D9E6C6CBAF06565E1992D7C42EF486A5CB3730400E99C3EACFED9908C4730C07ECA375618074410B766004ABE5AAE5AA75E0FCEB80B6B0F41C96D601AD03434607864C46756F75FE7B2B2D532DD3A1A6031A58BA77D53AA07560C8E8C090C9E850EB09747EB5F5A275E0FCEB800696EE5DB50E681D18323A306432AA7BABF3DF5B69996A990E351DD0C0D2BDABD601AD03434607864C46875A4FA0F3ABAD17AD03E75F0734B074EFAA7540EBC090D181219351DD5B9DFFDE4ACB54CB74A8E9800696EE5DB50E681D18323AF0FFB65C621F538AA3930000000049454E44AE426082, '', 'www.Infoworldschool.com')
GO

