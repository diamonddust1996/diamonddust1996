Option Explicit

Dim strText
Dim objShell,RetryCount
Dim i,k,seg,movie_id,EndTag,Resolution

With CreateObject("Scripting.FileSystemObject")
  Set objShell = CreateObject("WScript.Shell")
  'objShell.Run """C:\Program Files\Google\Chrome\Application\chrome.exe"" --new-window https://mail.google.com/mail/u/0/",1,True

RetryCount = 0

'MsgBox Month(Date)

Do Until objShell.AppActivate(Month(Date) & "���x") = True
  WScript.Sleep 100
  RetryCount = RetryCount + 1

  If RetryCount >= 10*60*5 Then
    MsgBox("���s")
    WScript.Quit
  End If
Loop

MsgBox("����")

End With
