Option Explicit

 

Dim fso,sFolder,dFolder,objRegExp,FileDLM,sDayFolder,sDay

 

'FileSystemObject�I�u�W�F�N�g�̐���
Set fso = CreateObject("Scripting.FileSystemObject")

'�J�����g�t�H���_�̃I�u�W�F�N�g���Z�b�g
Set sFolder = fso.GetFolder("C:\Downloads\new\")
Set dFolder = fso.GetFolder("C:\Users\��� �r��\Desktop\dest\")
Set objRegExp = New RegExp
objRegExp.Pattern = "^J5-TMDx....-...-CND-......\(10\).dmp$"
objRegExp.Global = True
objRegExp.IgnoreCase = True


'�t�@�C�����̈ꗗ��\��
Do Until Date = Now+365
GetSubFolder(sFolder)
'MsgBox "5�b�҂�"
WScript.Sleep 5000
Loop

'�t�@�C�����̈ꗗ���擾
Function GetSubFolder(sFolder)
    Dim file,filePath

    '�t�H���_���̃t�@�C������\��
    For Each file In sFolder.Files
	If objRegExp.Test(file.Name) Then
	    FileDLM = file.DateLastModified
	    sDay = mid(FileDLM,1,4) & mid(FileDLM,6,2) & mid(FileDLM,9,2)
	    sDayFolder = dFolder & "\" & sDay
	    If Not fso.FolderExists(sDayFolder) Then fso.CreateFolder(sDayFolder)
	    If Not fso.FileExists(sDayFolder & "\" & file.Name) Then file.Copy (sDayFolder & "\")
	End If
    Next

    '�T�u�t�H���_���̃t�@�C�����ċA�I�Ɏ擾
    For Each file In sFolder.subFolders
        GetSubFolder(file)
    Next

End Function