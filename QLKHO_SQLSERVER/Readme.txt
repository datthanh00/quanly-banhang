﻿
{0:0.##}

{0:0,0}

CTL ctlNgay = new CTL();
string SQLNGAY = "SELECT convert(varchar,getDate(),103) AS CurrentDateTime ";
                      DataTable dtn = ctlNgay.GETDATA(SQLNGAY);
                      dtn.Rows[0][0].ToString();



					  
					  
ton kho theo ngay bi nham gua kh tra va tra hang cty

them mat hang moi thi chua update tonkhott

			




nguyen thi loan  


Dao thi huyen ----- vac xin














USE XUAT_NHAPTON
SELECT T2.MAMH, TENMH, TENNCC, DONVITINH,KLDVT,SOLUONGMH AS TONCUOI, NHAP, XUAT,TRANHAP,TRAXUAT,SOLUONGMH-(NHAP+TRAXUAT-XUAT-TRANHAP) AS TONDAU,GIAMUA,GIABAN FROM 

(SELECT MATHANG.TENMH,MANCC,MADVT,KLDVT,SOLUONGMH,GIAMUA,GIABAN,T2.* FROM MATHANG
LEFT JOIN 
(select mamh, SUM(NHAP) AS NHAP,SUM(XUAT) AS XUAT,SUM(TRANHAP) AS TRANHAP,SUM(TRAXUAT) AS TRAXUAT 
from tonkho  group by mamh) AS T2 
ON MATHANG.MAMH=T2.MAMH WHERE MATHANG.MAKHO='MAKHO00001') T2, NHACUNGCAP,DONVITINH WHERE T2.MANCC=NHACUNGCAP.MANCC AND T2.MADVT=DONVITINH.MADVT









convert(varchar,T3.NGAYNHAP,103)AS NGAYNHAP












alt + F11 -> insert module


Function ExtractNumber(rCell As Range)
Dim lCount As Long
Dim sText As String
Dim lNum As String
sText = rCell
For lCount = Len(sText) To 1 Step -1
If IsNumeric(Mid(sText, lCount, 1)) Then
lNum = Mid(sText, lCount, 1) & lNum
End If
Next lCount
If lNum = "" Then
lNum = "0"
End If
ExtractNumber = CLng(lNum)
End Function

Function Extractchar(rCell As Range)
Dim lCount As Long
Dim sText As String
Dim lNum As String
sText = rCell
For lCount = Len(sText) To 1 Step -1
If IsNumeric(Mid(sText, lCount, 1)) Then
lCount = lCount
Else
lNum = Mid(sText, lCount, 1) & lNum
End If
Next lCount

Extractchar = lNum
End Function
Function Extractcode(rCell As Range)
Dim lNum As String

If rCell = "g" Then
lNum = "DVT00001"
End If
If rCell = "kg" Then
lNum = "DVT00002"
End If
If rCell = "c" Then
lNum = "DVT00003"
End If
If rCell = "cc" Then
lNum = "DVT00003"
End If
If rCell = "ml" Then
lNum = "DVT00003"
End If
If rCell = "lit" Then
lNum = "DVT00004"
End If
If rCell = "chai" Then
lNum = "DVT00005"
End If
If rCell = "lo" Then
lNum = "DVT00005"
End If
If rCell = "lon" Then
lNum = "DVT00005"
End If
If rCell = "bao" Then
lNum = "DVT00006"
End If
If rCell = "goi" Then
lNum = "DVT00006"
End If
If rCell = "ong" Then
lNum = "DVT00007"
End If
If rCell = "vien" Then
lNum = "DVT00008"
End If

If rCell = "cai" Then
lNum = "DVT00008"
End If
Extractcode = lNum
End Function
















SELECT MAMH, TENMH,TENNCC,KLDVT,  DONVITINH, CASE WHEN MAMH2<>'' THEN NHAP2 ELSE NHAP END AS NHAP,
CASE WHEN MAMH2<>'' THEN XUAT2 ELSE XUAT END AS XUAT,
CASE WHEN MAMH2<>'' THEN TONDAU2 ELSE TONDAU END AS TONDAU,
CASE WHEN MAMH2<>'' THEN TONCUOI2 ELSE TONCUOI END AS TONCUOI


FROM
(SELECT MATHANG.MAMH, TENMH,TENNCC,KLDVT, DONVITINH,0 AS NHAP, 0 AS XUAT, SOLUONGMH AS TONDAU, SOLUONGMH AS TONCUOI
FROM MATHANG, DONVITINH,NHACUNGCAP WHERE MATHANG.MADVT=DONVITINH.MADVT AND MATHANG.MANCC=NHACUNGCAP.MANCC AND  MATHANG.MAKHO='MAKHO00001') AS T3

LEFT JOIN

(SELECT *, TONDAU2+NHAP2-XUAT2 AS TONCUOI2 FROM (SELECT T1.MAMH AS MAMH2, NHAP AS NHAP2 ,XUAT AS XUAT2, CASE WHEN TONDAU>=0 THEN TONDAU ELSE (SELECT TONCUOI FROM (SELECT TOP 1 TONCUOI,STT FROM TONKHO WHERE MAMH=T1.MAMH AND NGAY < '2013/01/01' ORDER BY STT DESC ) AS TH) END AS TONDAU2 FROM (SELECT MATHANG.MAMH, SUM(NHAP) AS NHAP, SUM(XUAT) AS XUAT,TONDAU=(SELECT TOP 1 TONDAU FROM TONKHO WHERE NGAY BETWEEN '2013/01/01' AND '2013/01/31' AND MATHANG.MAMH=TONKHO.MAMH ) FROM ( SELECT * FROM MATHANG WHERE MAKHO='MAKHO00001') AS MATHANG, (SELECT * FROM TONKHO WHERE NGAY BETWEEN '2013/01/01' AND '2013/01/31')AS TONKHO WHERE MATHANG.MAMH = TONKHO.MAMH GROUP BY MATHANG.MAMH ) AS T1) AS T2) AS T

ON T3.MAMH=T.MAMH2
