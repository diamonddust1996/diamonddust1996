Option Explicit

'�ϐ���錾
Dim FSO, FSOText
Dim LineStr,LineCount
Dim RegKey, ControlScriptFile

'�t�@�C���V�X�e���I�u�W�F�N�g�𐶐�
Set FSO = CreateObject("Scripting.FileSystemObject")

Dim objWShell
Set objWShell = CreateObject("WScript.Shell")

RegKey = "HKEY_CURRENT_USER\Environment\test"

ControlScriptFile = isNull(objWShell.RegRead(RegKey))


Set FSOText = FSO.OpenTextFile("C:\WE\3row.txt", 1)

Do Until(FSOText.AtEndOfStream)
  LineStr = FSOText.ReadLine
  If LineStr <> "" Then LineCount = LineCount + 1
Loop

FSOText.Close

Set FSOText = Nothing

MsgBox(ControlScriptFile)