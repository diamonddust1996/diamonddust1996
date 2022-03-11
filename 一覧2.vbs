Option Explicit

Dim fso,sFolder,dFolder,objRegExp,FileDLM,sDayFolder,sDay,oExec,ary,i,shell,myFile,myFolder,myFolderName

'FileSystemObject�I�u�W�F�N�g�̐���
Set fso = CreateObject("Scripting.FileSystemObject")
Dim objCMD : Set objCMD = CreateObject("WScript.Shell")
Set shell = Wscript.CreateObject("Shell.Application")

If Wscript.Arguments.Count = 0 then
shell.ShellExecute "wscript.exe", WScript.ScriptFullName & " runas", "", "runas", 1
Wscript.Quit
End if
Set shell = Nothing

'�J�����g�t�H���_�̃I�u�W�F�N�g���Z�b�g
Set sFolder = fso.GetFolder("C:\Downloads\new\")
Set dFolder = fso.GetFolder("C:\Downloads\dest\")
Set objRegExp = New RegExp
'objRegExp.Pattern = "^J5-TMDx....-...-CND-......\(10\).dmp$"
sDay = mid(Date-1,1,4) & mid(Date-1,6,2) & mid(Date-1,9,2)
sDayFolder = dFolder & "\" & sDay

'�t�@�C�����̈ꗗ��\��
'Do Until Date = Now+365
Set oExec = objCMD.Exec ("cmd /c forfiles /s /d +"&Date-100&" /p """&sFolder&""" /m ""J5-TMRx????-GMT-???-CND-??????(1?).dmp"" /c ""cmd /c echo @path")
ary = Split(Replace(oExec.StdOut.ReadAll,"""",""), vbCrLf)
For i = 1 To UBound(ary)-1
Set myFile = fso.GetFile(ary(i))
Set myFolder = myFile.ParentFolder
myFolderName = myFile.ParentFolder.Name
objCMD.Run "cmd /c robocopy """&myFolder&""" "&dFolder&"\"&myFolderName&""""" /s /b /j /dcopy:dat /xo /xx /r:3 /w:60 /lev:1",1,True
        'MsgBox myFolder
Next

'WScript.Sleep 5000
'Loop



'�t�@�C�����̈ꗗ���擾
Function GetSubFolder(sFolder)
    Dim file,filePath

    '�t�H���_���̃t�@�C������\��
    For Each file In sFolder.Files
	If objRegExp.Test(file.Name) Then
	    If Not fso.FolderExists(sDayFolder) Then fso.CreateFolder(sDayFolder)
	    If Not fso.FileExists(sDayFolder & "\" & file.Name) Then file.Copy (sDayFolder & "\")
	End If
    Next

    '�T�u�t�H���_���̃t�@�C�����ċA�I�Ɏ擾
    For Each file In sFolder.subFolders
        GetSubFolder(file)
    Next

End Function