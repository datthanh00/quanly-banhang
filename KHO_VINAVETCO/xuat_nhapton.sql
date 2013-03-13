-- phpMyAdmin SQL Dump
-- version 3.4.5
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Dec 11, 2012 at 09:59 PM
-- Server version: 5.5.16
-- PHP Version: 5.3.8

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `xuat_nhapton`
--

-- --------------------------------------------------------

--
-- Table structure for table `bophan`
--

CREATE TABLE IF NOT EXISTS `bophan` (
  `MABP` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `TENBOPHAN` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `TINHTRANG` bit(1) DEFAULT NULL,
  PRIMARY KEY (`MABP`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `bophan`
--

INSERT INTO `bophan` (`MABP`, `TENBOPHAN`, `TINHTRANG`) VALUES
('MABP00001', 'Mua Hàng', '1'),
('MABP00002', 'Bán hàng', '1'),
('MABP00003', 'Mua bán hàng', '1'),
('MABP00004', 'Quản lý hệ thống', '1');

-- --------------------------------------------------------

--
-- Table structure for table `chitiethdn`
--

CREATE TABLE IF NOT EXISTS `chitiethdn` (
  `ID` int(11) NOT NULL,
  `MAHDN` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `MAMH` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `SOLUONGNHAP` int(11) DEFAULT NULL,
  `GIANHAP` bigint(20) DEFAULT NULL,
  `TINHTRANG` bit(1) DEFAULT NULL,
  PRIMARY KEY (`ID`,`MAHDN`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `chitiethdn`
--

INSERT INTO `chitiethdn` (`ID`, `MAHDN`, `MAMH`, `SOLUONGNHAP`, `GIANHAP`, `TINHTRANG`) VALUES
(0, 'MAHDN00001', 'MH00001', 25, 25000, '0'),
(0, 'MAHDN00002', 'MH00002', 30, 30000, '1');

-- --------------------------------------------------------

--
-- Table structure for table `chitiethdx`
--

CREATE TABLE IF NOT EXISTS `chitiethdx` (
  `ID` int(11) NOT NULL,
  `MAHDX` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `MAMH` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `SOLUONGXUAT` int(11) DEFAULT NULL,
  `GIATIEN` bigint(20) DEFAULT NULL,
  `TINHTRANG` bit(1) DEFAULT NULL,
  PRIMARY KEY (`ID`,`MAHDX`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `chitiethdx`
--

INSERT INTO `chitiethdx` (`ID`, `MAHDX`, `MAMH`, `SOLUONGXUAT`, `GIATIEN`, `TINHTRANG`) VALUES
(0, 'MAHDX00001', 'MH00001', 10, 150000, '1'),
(0, 'MAHDX00002', 'MH00002', 15, 10000, '0');

-- --------------------------------------------------------

--
-- Table structure for table `chitiethoadontra`
--

CREATE TABLE IF NOT EXISTS `chitiethoadontra` (
  `MAHDT` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `MAMH` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `SOLUONGTRA` int(11) DEFAULT NULL,
  `TINHTRANG` bit(1) DEFAULT NULL,
  PRIMARY KEY (`MAHDT`,`MAMH`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `congnokh`
--

CREATE TABLE IF NOT EXISTS `congnokh` (
  `MAKH` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `TONGTIENTRA` bigint(20) DEFAULT NULL,
  `TONGTIENDATRA` bigint(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `congnoncc`
--

CREATE TABLE IF NOT EXISTS `congnoncc` (
  `MANCC` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `TONGTIENTRA` bigint(20) DEFAULT NULL,
  `TONGTIENDATRA` bigint(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `donvitinh`
--

CREATE TABLE IF NOT EXISTS `donvitinh` (
  `MADVT` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `DONVITINH` varchar(30) CHARACTER SET utf8 DEFAULT NULL,
  PRIMARY KEY (`MADVT`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `donvitinh`
--

INSERT INTO `donvitinh` (`MADVT`, `DONVITINH`) VALUES
('DVT00001', 'Chai'),
('DVT00002', 'Kg'),
('DVT00003', 'Cái'),
('DVT00004', 'Lọ'),
('DVT00005', 'Hũ');

-- --------------------------------------------------------

--
-- Table structure for table `hoadonnhap`
--

CREATE TABLE IF NOT EXISTS `hoadonnhap` (
  `MAHDN` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `MANCC` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `MANV` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `NGAYNHAP` datetime DEFAULT NULL,
  `TIENPHAITRA` bigint(20) DEFAULT NULL,
  `TIENDATRA` bigint(20) DEFAULT NULL,
  `GHICHU` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  `TINHTRANG` bit(1) DEFAULT NULL,
  PRIMARY KEY (`MAHDN`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `hoadonnhap`
--

INSERT INTO `hoadonnhap` (`MAHDN`, `MANCC`, `MANV`, `NGAYNHAP`, `TIENPHAITRA`, `TIENDATRA`, `GHICHU`, `TINHTRANG`) VALUES
('MAHDN00001', 'MANCC00001', 'MANV00001', '2010-12-21 00:00:00', 100000, 15000, 'Tesst', '0'),
('MAHDN00002', 'MANCC00002', 'MANV00002', '2010-12-21 00:00:00', 150000, 10000, 'Trả hết', '1');

-- --------------------------------------------------------

--
-- Table structure for table `hoadontra`
--

CREATE TABLE IF NOT EXISTS `hoadontra` (
  `MAHDT` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `MANCC` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `MAHDN` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `NGAYTRA` datetime DEFAULT NULL,
  `GHICHU` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  `TINHTRANG` bit(1) DEFAULT NULL,
  PRIMARY KEY (`MAHDT`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `hoadonxuat`
--

CREATE TABLE IF NOT EXISTS `hoadonxuat` (
  `MAHDX` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `MAKH` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `MANV` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `NGAYXUAT` datetime DEFAULT NULL,
  `TIENPHAITRA` bigint(20) DEFAULT NULL,
  `TIENDATRA` bigint(20) DEFAULT NULL,
  `GHICHU` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  `TINHTRANG` bit(1) DEFAULT NULL,
  PRIMARY KEY (`MAHDX`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `hoadonxuat`
--

INSERT INTO `hoadonxuat` (`MAHDX`, `MAKH`, `MANV`, `NGAYXUAT`, `TIENPHAITRA`, `TIENDATRA`, `GHICHU`, `TINHTRANG`) VALUES
('MAHDX00001', 'KH00001', 'MANV00001', '2010-12-21 00:00:00', 1500000, 10000, 'Còn Nợ', '0'),
('MAHDX00002', 'KH00002', 'MANV00002', '2010-12-21 00:00:00', 100000, 100000, 'Hết', '1');

-- --------------------------------------------------------

--
-- Table structure for table `khachhang`
--

CREATE TABLE IF NOT EXISTS `khachhang` (
  `MAKH` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `MAKV` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `TENKH` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `SOTAIKHOAN` varchar(30) COLLATE utf8_unicode_ci DEFAULT NULL,
  `NGANHANG` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `MASOTHUE` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `DIACHI` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `SDT` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `FAX` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `WEBSITE` varchar(30) COLLATE utf8_unicode_ci DEFAULT NULL,
  `YAHOO` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `SKYPE` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `TINHTRANG` bit(1) DEFAULT NULL,
  PRIMARY KEY (`MAKH`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `khachhang`
--

INSERT INTO `khachhang` (`MAKH`, `MAKV`, `TENKH`, `SOTAIKHOAN`, `NGANHANG`, `MASOTHUE`, `DIACHI`, `SDT`, `FAX`, `WEBSITE`, `YAHOO`, `SKYPE`, `TINHTRANG`) VALUES
('KH00001', 'MAKV00004', 'Phạm Duy Tiên', NULL, NULL, NULL, 'Vung tàu', '0935199144', NULL, NULL, NULL, NULL, NULL),
('KH00002', 'MAKV00001', 'Ngọc Anh', NULL, NULL, NULL, 'Bình chánh,TPHCM', '0909999999', NULL, NULL, NULL, NULL, NULL),
('KH00003', 'MAKV00001', 'Tuấn Dũng', NULL, NULL, NULL, 'Q3,TPHCM', '0935199144', NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `kho`
--

CREATE TABLE IF NOT EXISTS `kho` (
  `MAKHO` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `MANV` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `TENKHO` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `DIACHI` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `SDTB` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `DTDD` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `NGUOILH` varchar(30) CHARACTER SET utf8 DEFAULT NULL,
  `FAX` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `GHICHU` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  `TINHTRANG` bit(1) DEFAULT NULL,
  PRIMARY KEY (`MAKHO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `kho`
--

INSERT INTO `kho` (`MAKHO`, `MANV`, `TENKHO`, `DIACHI`, `SDTB`, `DTDD`, `NGUOILH`, `FAX`, `GHICHU`, `TINHTRANG`) VALUES
('MAKHO00001', 'MANV00001', 'Kho hàng 1', '32/144Nguyễn Trãi,Q5,TPHCM', '08-3123456', '0908888888', NULL, NULL, NULL, '1'),
('MAKHO00002', 'MANV00003', 'Kho hàng 2', '32/144Nguyễn Trãi,THANH XUAN,Hà nội', '04-3123456', '0906666666', NULL, NULL, NULL, '1');

-- --------------------------------------------------------

--
-- Table structure for table `khuvuc`
--

CREATE TABLE IF NOT EXISTS `khuvuc` (
  `MAKV` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `TENKV` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `GHICHU` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  `TINHTRANG` bit(1) DEFAULT NULL,
  PRIMARY KEY (`MAKV`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `khuvuc`
--

INSERT INTO `khuvuc` (`MAKV`, `TENKV`, `GHICHU`, `TINHTRANG`) VALUES
('MAKV00001', 'TPHCM', NULL, '1'),
('MAKV00002', 'Hà Nội', NULL, '1'),
('MAKV00003', 'Huế', NULL, '1'),
('MAKV00004', 'Vung tàu', NULL, '1');

-- --------------------------------------------------------

--
-- Table structure for table `mathang`
--

CREATE TABLE IF NOT EXISTS `mathang` (
  `MAMH` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `MATH` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `MANH` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `MAKHO` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `TENMH` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `MADVT` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `SOLUONGMH` int(11) DEFAULT NULL,
  `HANSUDUNG` datetime DEFAULT NULL,
  `GIAMUA` bigint(20) DEFAULT NULL,
  `GIABAN` bigint(20) DEFAULT NULL,
  `MOTA` text COLLATE utf8_unicode_ci,
  `TINHTRANG` bit(1) DEFAULT NULL,
  PRIMARY KEY (`MAMH`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `mathang`
--

INSERT INTO `mathang` (`MAMH`, `MATH`, `MANH`, `MAKHO`, `TENMH`, `MADVT`, `SOLUONGMH`, `HANSUDUNG`, `GIAMUA`, `GIABAN`, `MOTA`, `TINHTRANG`) VALUES
('MH00001', 'TH00001', 'NH00001', 'MAKHO00001', 'BOSS', 'DVT00001', 10, NULL, 100000, 105000, NULL, '1'),
('MH00002', 'TH00001', 'NH00002', 'MAKHO00001', 'VASILE', 'DVT00001', 10, NULL, 100000, 105000, NULL, '1'),
('MH00003', 'TH00003', 'NH00003', 'MAKHO00002', 'BIOREFORMEN', 'DVT00001', 10, NULL, 100000, 115000, NULL, '1');

-- --------------------------------------------------------

--
-- Table structure for table `nhacungcap`
--

CREATE TABLE IF NOT EXISTS `nhacungcap` (
  `MANCC` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `MAKV` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `TENNCC` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `DIACHI` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `MASOTHUE` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `SOTAIKHOAN` varchar(30) COLLATE utf8_unicode_ci DEFAULT NULL,
  `NGANHANG` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `SDT` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `EMAIL` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `FAX` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `WEBSITE` varchar(30) COLLATE utf8_unicode_ci DEFAULT NULL,
  `TINHTRANG` bit(1) DEFAULT NULL,
  PRIMARY KEY (`MANCC`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `nhacungcap`
--

INSERT INTO `nhacungcap` (`MANCC`, `MAKV`, `TENNCC`, `DIACHI`, `MASOTHUE`, `SOTAIKHOAN`, `NGANHANG`, `SDT`, `EMAIL`, `FAX`, `WEBSITE`, `TINHTRANG`) VALUES
('MANCC00001', 'MAKV00001', 'BDT', '43 Nguyễn thông,TPHCM', '123456', '19001789', 'ACB', '0935399144', 'phamduytien@yahoo.com', '08-345678', 'www.bdt.com', '1'),
('MANCC00002', 'MAKV00002', 'TDB', '43 Nguyễn thông,Hà Nội', '123456', '19001789', 'DongABank', '0935399144', 'phamtien@yahoo.com', '04-345678', 'www.tdb.com', '1');

-- --------------------------------------------------------

--
-- Table structure for table `nhanvien`
--

CREATE TABLE IF NOT EXISTS `nhanvien` (
  `MANV` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `MABP` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `USERNAME` varchar(30) CHARACTER SET utf8 DEFAULT NULL,
  `PASSWORD` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `CHUCVU` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `TENNV` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `DIACHI` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `NGAYSINH` datetime DEFAULT NULL,
  `SCMND` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `SDT` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `TINHTRANG` bit(1) DEFAULT NULL,
  PRIMARY KEY (`MANV`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `nhanvien`
--

INSERT INTO `nhanvien` (`MANV`, `MABP`, `USERNAME`, `PASSWORD`, `CHUCVU`, `TENNV`, `DIACHI`, `NGAYSINH`, `SCMND`, `SDT`, `TINHTRANG`) VALUES
('MANV00001', 'MABP00004', 'admin', '123456', NULL, 'Ðoàn Ngọc Anh', 'Hoàn Kiếm,Hà nội', NULL, NULL, '0906666666', '1'),
('MANV00002', 'MABP00001', 'manhcuong', '123456', NULL, ' Nguyễn Mạnh Cường ', 'Hoàn Kiếm,Hà nội', NULL, NULL, '0907777777', '1'),
('MANV00003', 'MABP00001', 'tuandung', '123456', NULL, ' Trần Tuấn Dũng', 'Hoàn Kiếm,Hà nội', NULL, NULL, '0906666666', '1'),
('MANV00004', 'MABP00001', 'duytien', '123456', NULL, 'Phạm Duy Tiên', 'Hoàn Kiếm,Hà nội', NULL, NULL, '0906666666', '1'),
('MANV00005', 'MABP00001', 'tunglam', '123456', NULL, 'Tùng Lâm', 'Q11,TPHCM', NULL, NULL, '0908888888', '1');

-- --------------------------------------------------------

--
-- Table structure for table `nhomhang`
--

CREATE TABLE IF NOT EXISTS `nhomhang` (
  `MANH` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `TENNHOMHANG` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `GHICHU` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  PRIMARY KEY (`MANH`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `nhomhang`
--

INSERT INTO `nhomhang` (`MANH`, `TENNHOMHANG`, `GHICHU`) VALUES
('NH00001', 'Nước Hoa', 'Thom nhu múi mít'),
('NH00002', 'Sữa duỡng thể', 'Da mịn nhu lụa'),
('NH00003', 'Sữa rửa mặt', 'Da mịn và hết mụn nhanh chóng');

-- --------------------------------------------------------

--
-- Table structure for table `phieuchi`
--

CREATE TABLE IF NOT EXISTS `phieuchi` (
  `MaPC` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `MaNV` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `MaHDN` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `NgayChi` datetime DEFAULT NULL,
  `SoTienDaTra_PC` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`MaPC`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `phieuthu`
--

CREATE TABLE IF NOT EXISTS `phieuthu` (
  `MaPT` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `MaNV` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `mahdx` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `NgayThu` datetime DEFAULT NULL,
  `SoTienTra_PT` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`MaPT`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `thongtinct`
--

CREATE TABLE IF NOT EXISTS `thongtinct` (
  `MACT` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `TENCT` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `DIACHI` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `SDT` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `MOBILE` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `EMAIL` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `FAX` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `LOGO` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  `MASOTHUE` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `WEBSITE` varchar(30) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`MACT`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `thongtinct`
--

INSERT INTO `thongtinct` (`MACT`, `TENCT`, `DIACHI`, `SDT`, `MOBILE`, `EMAIL`, `FAX`, `LOGO`, `MASOTHUE`, `WEBSITE`) VALUES
('1', 'ProManager', 'HCM', '09230293', '02392093', '', '39283923', '', '', 'www.Infoworldschool.com');

-- --------------------------------------------------------

--
-- Table structure for table `thue`
--

CREATE TABLE IF NOT EXISTS `thue` (
  `MATH` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `SOTHUE` smallint(6) DEFAULT NULL,
  PRIMARY KEY (`MATH`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `thue`
--

INSERT INTO `thue` (`MATH`, `SOTHUE`) VALUES
('TH00001', 5),
('TH00002', 10),
('TH00003', 15);

-- --------------------------------------------------------

--
-- Table structure for table `tonkho`
--

CREATE TABLE IF NOT EXISTS `tonkho` (
  `NGAYTHANG` datetime NOT NULL,
  `MAMH` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `SOLUONGDAU` int(11) DEFAULT '0',
  `SOLUONGNHAP` int(11) DEFAULT '0',
  `SOLUONGXUAT` int(11) DEFAULT '0',
  `SOLUONGTON` int(11) DEFAULT '0',
  PRIMARY KEY (`NGAYTHANG`,`MAMH`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
