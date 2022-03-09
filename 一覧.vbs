Option Explicit

 

Dim fso,sFolder,dFolder,objRegExp,FileDLM,sDayFolder,sDay

 

'FileSystemObjectオブジェクトの生成
Set fso = CreateObject("Scripting.FileSystemObject")

'カレントフォルダのオブジェクトをセット
Set sFolder = fso.GetFolder("C:\Downloads\new\")
Set dFolder = fso.GetFolder("C:\Users\鈴木 俊也\Desktop\dest\")
Set objRegExp = New RegExp
objRegExp.Pattern = "^J5-TMDx....-...-CND-......\(10\).dmp$"
objRegExp.Global = True
objRegExp.IgnoreCase = True


'ファイル名の一覧を表示
Do Until Date = Now+365
GetSubFolder(sFolder)
'MsgBox "5秒待つ"
WScript.Sleep 5000
Loop

'ファイル名の一覧を取得
Function GetSubFolder(sFolder)
    Dim file,filePath

    'フォルダ内のファイル名を表示
    For Each file In sFolder.Files
	If objRegExp.Test(file.Name) Then
	    FileDLM = file.DateLastModified
	    sDay = mid(FileDLM,1,4) & mid(FileDLM,6,2) & mid(FileDLM,9,2)
	    sDayFolder = dFolder & "\" & sDay
	    If Not fso.FolderExists(sDayFolder) Then fso.CreateFolder(sDayFolder)
	    If Not fso.FileExists(sDayFolder & "\" & file.Name) Then file.Copy (sDayFolder & "\")
	End If
    Next

    'サブフォルダ内のファイルを再帰的に取得
    For Each file In sFolder.subFolders
        GetSubFolder(file)
    Next

End Function