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
