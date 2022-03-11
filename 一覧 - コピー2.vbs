Option Explicit

Dim BeforeCount,AfterCount,fso,sFolder,dFolder,objRegExp,FileDLM,sDayFolder,sDay,oExec,i,ext,sFindPath,namePattern

'FileSystemObject�I�u�W�F�N�g�̐���
Set fso = CreateObject("Scripting.FileSystemObject")
Dim objCMD : Set objCMD = CreateObject("WScript.Shell")

'�J�����g�t�H���_�̃I�u�W�F�N�g���Z�b�g
Set sFolder = fso.GetFolder("C:\Downloads\new\")
Set dFolder = fso.GetFolder("C:\Downloads\dest\")
Set objRegExp = New RegExp
ext = "J5-TMRx....-GMT-...-CND-...........dmp"
sDay = mid(Date-1,1,4) & mid(Date-1,6,2) & mid(Date-1,9,2)
sDayFolder = dFolder & "\" & sDay

'�t�@�C�����̈ꗗ��\��
'Do Until Date = Now+365
sFindPath = sDayFolder & "\" & ext
namePattern = sFindPath & "$"
If fso.FolderExists(sDayFolder) Then BeforeCount = VBSDir(namePattern,3)
objCMD.Run "cmd /c forfiles /s /d "&Date-2&" /p """&sFolder&""" /m ""J5-TMRx????-GMT-???-CND-??????(1?).dmp"" /c ""cmd /c echo d | xcopy /d /i /y @path """&sDayFolder&"""",0,True
'ext = ".*dmp"
'MsgBox namePattern

If fso.FolderExists(sDayFolder) Then AfterCount = VBSDir(namePattern,3)
MsgBox AfterCount-BeforeCount

'MsgBox oExec.StdOut.ReadAll
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

'// �t�@�C�����ɐ��K�\���̎g�p���\
'//�mopt:0�n���������ŏ��̃t�@�C������Ԃ��i�����ꍇ�� "" ��Ԃ��j
'//�mopt:1�n���������t�@�C�����̔z���Ԃ�
'//�mopt:2�n���������t�@�C�����̃��X�g�����s��؂�ŕԂ�
'//�mopt:3�n���������t�@�C���̐���Ԃ�

Function VBSDir(ByVal name_pattern, ByVal opt)

    Dim regx, namesAry, fl, getNames, i: getNames = ""

    Set regx = CreateObject("VBScript.RegExp")

    '// �啶���E����������ʂ��Ȃ�
    regx.IgnoreCase = True
    i = 0

    With CreateObject("Scripting.FileSystemObject")
        regx.Pattern = .GetFileName(name_pattern)
        For Each fl In .GetFolder(.GetParentFolderName(name_pattern)).Files
            If regx.Test(fl.Name) Then
		getNames = getNames & fl.Name & vbCrLf
		i = i+1
	    End If
        Next
    End With

    If getNames = "" Then
        namesAry = Array("")
    Else
        namesAry = Split(getNames, vbCrLf)
    End If

    Select Case opt
        Case 0
            VBSDir = namesAry(0)
        Case 1
            VBSDir = namesAry
        Case 2
            VBSDir = getNames
	Case 3
	    VBSDir = i
        Case Else
            VBSDir = namesAry(0)
    End Select

End Function