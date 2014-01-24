use kho_vinavetco


select tenmh, soluongmh from (select sum(tonkho) as tonkho,mamh from khohang group by mamh) as khohang, mathang where khohang.mamh=mathang.mamh and tonkho-soluongmh<0