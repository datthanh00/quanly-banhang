B2: =DATEVALUE(MID(A2,4,2)&"/"&RIGHT(A2,2)&"/"&LEFT(A2,2))


tdrDate = dateString.Substring(0,4) + '-' + 
    dateString.Substring(4,2) + '-' + 
    dateString.Substring(6,2);