Imports System.Runtime.InteropServices
Imports System.Text

Public Class Main
    '指定のINIファイルから文字列を取得する
    <DllImport("KERNEL32.DLL", CharSet:=CharSet.Auto)> _
    Public Shared Function GetPrivateProfileString( _
            ByVal lpAppName As String, _
            ByVal lpKeyName As String, _
            ByVal lpDefault As String, _
            ByVal lpReturnedString As StringBuilder, _
            ByVal nSize As Integer, _
            ByVal lpFileName As String) As Integer
    End Function

    <DllImport("KERNEL32.DLL", CharSet:=CharSet.Auto)> _
    Public Shared Function GetPrivateProfileInt( _
        ByVal lpAppName As String, _
        ByVal lpKeyName As String, _
        ByVal nDefault As Integer, _
        ByVal lpFileName As String) As Integer
    End Function

    'プログラム起動時のINIファイル読み込み用設定
    Public Class IniFileHandler
        Declare Function GetPrivateProfileString Lib "KERNEL32.DLL" Alias "GetPrivateProfileStringA" ( _
         ByVal lpAppName As String, _
         ByVal lpKeyName As String, _
         ByVal lpDefault As String, _
         ByVal lpReturnedString As StringBuilder, _
         ByVal nSize As Integer, _
         ByVal lpFileName As String) As Integer

        Declare Function GetPrivateProfileSectionNames Lib "KERNEL32.DLL" Alias "GetPrivateProfileSectionNamesA" ( _
         ByVal lpszReturnBuffer As IntPtr, _
         ByVal nSize As Integer, _
         ByVal lpFileName As String) As Integer

        Declare Function GetPrivateProfileSection Lib "KERNEL32.DLL" Alias "GetPrivateProfileSectionA" ( _
         ByVal lpAppName As String, _
         ByVal lpReturnedString As String, _
         ByVal nSize As Integer, _
         ByVal lpFileName As String) As Integer
    End Class

    Sub Main()

    End Sub

    Private Sub Main_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        Dim Processes() As System.Diagnostics.Process = Process.GetProcesses
        Dim ThisProcessName As String = System.Diagnostics.Process.GetCurrentProcess.ProcessName
        Dim BootedFlag As Boolean = False
        For Each Process In Processes
            Dim Name = Process.ProcessName
            If InStr(Name, "MATLAB", CompareMethod.Text) And Not Name = ThisProcessName Then
                BootedFlag = True
                MsgBox(Name)
            End If
        Next

        If BootedFlag = False Then
            'MsgBox(System.IO.Directory.Exists(System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\MATLAB"))
        End If



    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim SFD = SaveFileDialog1
        If SFD.ShowDialog() = DialogResult.OK Then
            TextBox1.Text = System.IO.Path.GetDirectoryName(SFD.FileName)
        End If
    End Sub

    Private Sub Start_ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Start_ToolStripMenuItem.Click
        Start_ToolStripMenuItem.Text = "走行監視中"
        Start_ToolStripMenuItem.Enabled = False
        Start_ToolStripMenuItem.Checked = True

        Stop_ToolStripMenuItem.Enabled = True
        Stop_ToolStripMenuItem.Checked = False
        StatusTextLabel.Text = "走行監視中"

    End Sub

    Private Sub Stop_ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Stop_ToolStripMenuItem.Click
        Start_ToolStripMenuItem.Text = "走行監視開始"
        Start_ToolStripMenuItem.Enabled = True
        Start_ToolStripMenuItem.Checked = False

        Stop_ToolStripMenuItem.Enabled = False
        Stop_ToolStripMenuItem.Checked = True
        StatusTextLabel.Text = "走行監視停止中"
    End Sub

    Private Sub Exit_ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Exit_ToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
