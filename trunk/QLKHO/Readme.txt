B2: =DATEVALUE(MID(A2,4,2)&"/"&RIGHT(A2,2)&"/"&LEFT(A2,2))


tdrDate = dateString.Substring(0,4) + '-' + 
    dateString.Substring(4,2) + '-' + 
    dateString.Substring(6,2);
	
	
	
	
	
	sluongdau= abc;
UPDATE tonkho
SET soluongdau= (
    SELECT country_code
    FROM ipinfo.ip_group_country
    WHERE ipinfo.ip_start <= INET_ATON(logs.REMOTE_ADDR)
    LIMIT 1
)
WHERE COUNTRY_CODE IS NULL mamh =? and date <=currentdate <= currentdate 