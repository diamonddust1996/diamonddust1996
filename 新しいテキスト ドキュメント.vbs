Dim objFSO
Dim objFile
Dim strText,aryFile,ShukuSen,Trimto
Dim oWshShell,objExcel
Dim regX
Dim i

ShukuSen = """C:\Downloads\dest\Shukusen\ShukuSen.exe"""
Trimto = """C:\Downloads\Trimto.exe"""

With CreateObject("Scripting.FileSystemObject")

Set regX = CreateObject("VBScript.RegExp")
regX.Pattern = "[LCR]_ch...png|[LCR]_S0[12].png"
regX.IgnoreCase = True 
regX.Global = True
For Each objFile In .GetFolder(".").Files
           If regX.Test(objFile.Name) Then
              strText = strText & " " & objFile.Name
           End If
Next
Set regX=Nothing

If strText = "" Then WScript.Quit

Set oWshShell = CreateObject("WScript.Shell")
Set objExcel = WScript.CreateObject("Excel.Application")

aryFile = Split(strText," ")
For i = 1 to Ubound(aryFile)
aryFile(i) = """" & .GetFolder(".") & "\" & aryFile(i) & """"
Next

If InStr(strText, "S01") > 0 Then
For i = 2 to Ubound(aryFile) Step 3
aryFile(i) = aryFile(i-1)
msgbox aryFile(i)
Next
End If

oWshShell.Run(ShukuSen & strText),7,False
For i = 2 to Ubound(aryFile) Step 3
oWshShell.Run Trimto & " " & aryFile(i),1,True
Next

Set objExcel = WScript.CreateObject("Excel.Application")

objExcel.Application.Visible = True
objExcel.Workbooks.Open .GetFolder(".") & "\Book1.xls"
objExcel.Application.Run "Macro1"

Set objExcel = Nothing

oWshShell.Run """C:\Program Files\Google\Chrome\Application\chrome.exe"" URL",1,False 

'.DeleteFile(Wscript.ScriptFullName)
End With

WScript.Quit

Sub Macro1()
'
' Macro1 Macro
Dim Address, ary() As String
Dim i As Integer

'Address = Replace(ThisWorkbook.Path, "\\", "")
'ary = Split(Address, "\")
'For i = 0 To UBound(ary)
'Cells(i + 1, 1).Value = ary(i)
'Next
'
'End Sub