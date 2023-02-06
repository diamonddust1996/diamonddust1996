Imports System.Management
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Text
Imports System.Security.Cryptography
Imports System.IO

Public Class NormalMode_Form
    ''' <summary>
    ''' iniファイル読み込み関数
    ''' </summary>
    ''' <param name="lpAppName">セクション名</param>
    ''' <param name="lpKeyName">キー名</param>
    ''' <param name="lpDefault">キーが見つからなかった場合に取得するデフォルト値</param>
    ''' <param name="lpReturnedString">取得した文字列が入るバッファ</param>
    ''' <param name="nSize">取得した文字列のバッファサイズ</param>
    ''' <param name="lpFileName">iniファイル名</param>
    ''' <returns></returns>
    <DllImport("Kernel32.dll", CharSet:=CharSet.Ansi)>
    Private Shared Function GetPrivateProfileString(
                    ByVal lpAppName As String,
                    ByVal lpKeyName As String,
                    ByVal lpDefault As String,
                    ByVal lpReturnedString As StringBuilder,
                    ByVal nSize As Integer,
                    ByVal lpFileName As String) As Integer
    End Function

    ''' <summary>
    ''' iniファイル読み込み関数(整数値用)
    ''' </summary>
    ''' <param name="lpAppName">セクション名</param>
    ''' <param name="lpKeyName">キー名</param>
    ''' <param name="nDefault">キーが見つからなかった場合に取得するデフォルト値</param>
    ''' <param name="lpFileName">iniファイル名</param>
    ''' <returns></returns>
    <DllImport("Kernel32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function GetPrivateProfileInt(
                    ByVal lpAppName As String,
                    ByVal lpKeyName As String,
                    ByVal nDefault As Integer,
                    ByVal lpFileName As String) As Integer
    End Function



    '共有変数の定義
    Public iniFileName As String = System.IO.Path.GetFullPath(".\ini\Settings.ini")
    Public CheckOn, ConnectionCheckResult As String
    Public ExistsResult As Boolean = False
    Public MaxRetriesCount, RetryIntervalSec As Integer

    'MainForm読み込み時(起動時)の処理
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'iniファイルから設定値を読み込む
        Dim tmpSB As New StringBuilder

        Call GetPrivateProfileString("ConnectionCheck", "CheckOn", "True", tmpSB, tmpSB.Capacity, iniFileName)
        CheckOn = tmpSB.ToString

        MaxRetriesCount = GetPrivateProfileInt("ConnectionCheck", "MaxRetriesCount", 60, iniFileName)
        RetryIntervalSec = GetPrivateProfileInt("ConnectionCheck", "RetryIntervalSec", 30, iniFileName)

        Me.ClientSize = My.Settings.MainForm_WindowSize
        'SourcePath_TextBox.Text = Config.SourcePath


    End Sub


    Private Sub SourcePath_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SourcePath_Button.Click
        If Not SourcePath_TextBox.Text = "" Then SelectFolderDialog.RootFolder = SourcePath_TextBox.Text

        If SelectFolderDialog.ShowDialog() = DialogResult.OK Then
            SourcePath_TextBox.Text = SelectFolderDialog.SelectedFolder
            'Config.SourcePath = SelectFolderDialog.SelectedFolder
        End If
    End Sub


    Private Sub DestPath_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DestPath_Button.Click
        If Not DestPath_TextBox.Text = "" Then SelectFolderDialog.RootFolder = DestPath_TextBox.Text

        If SelectFolderDialog.ShowDialog() = DialogResult.OK Then
            DestPath_TextBox.Text = SelectFolderDialog.SelectedFolder
            'Config.DestPath = SelectFolderDialog.SelectedFolder
        End If
    End Sub


    Function FolderSearch(ByRef Path As String) As String()
        Dim tmpAry As String()
        tmpAry = System.IO.Directory.GetDirectories(Path, "*", System.IO.SearchOption.TopDirectoryOnly)
        For i As Integer = 0 To tmpAry.Length - 1
            'FolderList.Add(tmpAry(i))
        Next

        For Each Folder In tmpAry
            If InStr(Folder, "済み", CompareMethod.Text) <= 0 Then
                FolderSearch(Folder)
            End If
        Next

        'FolderSearch = FolderList.ToArray

    End Function


    Sub Start_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Start_ToolStripMenuItem.Click
        Dim SearchFolderPath As String = SourcePath_TextBox.Text



        If Not SourcePath_TextBox.Text = "" Then
            'Dim t As New ThreadClass(TextBox1.Text, TextBox2.Text, "", "", TextBox1.Text)
            't = New Thread(New ParameterizedThreadStart(AddressOf ConnectionCheck))

            't.IsBackground = True
            't.Start(TextBox1.Text, "監視対象フォルダー")

        End If

        Dim ProcessTime As DateTime
        For i = 0 To 2
            ProcessTime = Now
            DestPath_TextBox.Text = DestPath_TextBox.Text &
                            ProcessTime & vbCrLf &
                            "[Copy completed.] 202211111111111111111111111.prn >> 202211111111111111111111111.prn" & vbCrLf &
                            vbCrLf
        Next


    End Sub


    Private Sub Stop_ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Stop_ToolStripMenuItem.Click
        Start_ToolStripMenuItem.Text = "監視開始"
        Start_ToolStripMenuItem.Enabled = True
        Start_ToolStripMenuItem.Checked = False

        Stop_ToolStripMenuItem.Enabled = False
        Stop_ToolStripMenuItem.Checked = True
        StatusText.Text = "監視停止中"
    End Sub


    Private Sub MainForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        My.Settings.MainForm_WindowSize = Me.ClientSize

        'If Not IsNothing(t) Then
        '    t.Abort()
        '    t.Join()
        'End If
    End Sub


    Private Function SHA1CheckSum(ByVal FilePath As String) As Byte()
        Using CheckSum As SHA1 = SHA1.Create(),
                FStream As FileStream = File.Open(FilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite + FileShare.Delete)
            SHA1CheckSum = CheckSum.ComputeHash(FStream)
        End Using
    End Function

    Private Function MD5CheckSum(ByVal FilePath As String) As Byte()
        Using CheckSum As MD5 = MD5.Create(),
                FStream As FileStream = File.Open(FilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite + FileShare.Delete)
            MD5CheckSum = CheckSum.ComputeHash(FStream)
        End Using
    End Function


    Private Sub Exit_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Exit_ToolStripMenuItem.Click
        'Call SHA1CheckSum("C:\Users\鈴木 俊也\Downloads\Use_2022_As-PSw0rd-NewFinaI-C9 (1).rar")
        'Call MD5CheckSum("C:\Users\鈴木 俊也\Downloads\Use_2022_As-PSw0rd-NewFinaI-C9.rar")
        SettingsForm.ShowDialog(Me)
        SettingsForm.Dispose()
    End Sub

    Private Sub SplitContainer_Horizontal1_3_Click(sender As Object, e As EventArgs) Handles SplitContainer_Horizontal1_4.Click
        Me.ActiveControl = Nothing
    End Sub

    Private Sub SplitContainer_Horizontal2_4_Click(sender As Object, e As EventArgs) Handles SplitContainer_Horizontal2_4.Click
        Me.ActiveControl = Nothing
    End Sub

    Private Sub SplitContainer_Horizontal3_4_Click(sender As Object, e As EventArgs) Handles SplitContainer_Horizontal3_4.Click
        Me.ActiveControl = Nothing
    End Sub

    Private Sub SplitContainer_Horizontal1_3_SplitterMoving(sender As Object, e As SplitterCancelEventArgs) Handles SplitContainer_Horizontal1_4.SplitterMoving
        Me.ActiveControl = Nothing
    End Sub

    Private Sub SplitContainer_Horizontal2_4_SplitterMoving(sender As Object, e As SplitterCancelEventArgs) Handles SplitContainer_Horizontal2_4.SplitterMoving
        Me.ActiveControl = Nothing
    End Sub

    Private Sub SplitContainer_Horizontal3_4_SplitterMoving(sender As Object, e As SplitterCancelEventArgs) Handles SplitContainer_Horizontal3_4.SplitterMoving
        Me.ActiveControl = Nothing
    End Sub


End Class







Class ThreadClass
    Private SourcePath, DestPath, Text, Type As String

    Sub New(ByVal tmpSourcePath As String, ByVal tmpDestPath As String,
            ByVal tmpText As String, ByVal tmpType As String)
        SourcePath = tmpSourcePath
        DestPath = tmpDestPath
        Text = tmpType
    End Sub

    'デリゲーター
    Delegate Sub Delegate_ControlText(ByVal Text As String, ByVal Type As String)

    '変更用
    Public Sub Change_TextBox2(ByVal Text As String, Optional ByVal Type As String = "")
        NormalMode_Form.DestPath_TextBox.Text = Text
    End Sub

    '変更用
    Public Sub Change_StatusText(ByVal Text As String, Optional ByVal Type As String = "")
        NormalMode_Form.StatusText.Text = Text
    End Sub

    '変更用
    Public Sub Change_MenuItem(ByVal Text As String)
        NormalMode_Form.Start_ToolStripMenuItem.Text = Text
        NormalMode_Form.Start_ToolStripMenuItem.Enabled = False
        NormalMode_Form.Start_ToolStripMenuItem.Checked = True

        NormalMode_Form.Stop_ToolStripMenuItem.Enabled = True
        NormalMode_Form.Stop_ToolStripMenuItem.Checked = False
        NormalMode_Form.StatusText.Text = Text
    End Sub

    'スレッド処理
    Private Sub ConnectionCheck(ByVal Path As String, ByVal Type As String)
        Try
            'デリゲーターを指定する
            Dim callback As Delegate_ControlText =
                New Delegate_ControlText(AddressOf Change_StatusText)

            'ステータス更新
            NormalMode_Form.Invoke(callback, "接続確認中...")

            Dim IPAddress As String = ""

            Try
                'Uriオブジェクトを作成 
                Dim u As New Uri(Path)

                'DestPathがUNCパスのとき
                If u.IsUnc = True Then
                    IPAddress = u.Host
                Else
                    'ネットワークドライブの win32_logicaldisk をクエリする
                    Dim Query As New SelectQuery("SELECT * FROM Win32_NetworkConnection")
                    'WMIを使用してクエリを実行する
                    Dim Searcher As New ManagementObjectSearcher(Query)
                    '見つかった各ネットワークドライブをループする
                    For Each Drive As ManagementObject In Searcher.Get()
                        If Strings.Left(Path, 2).ToUpper = Drive("LocalName") Then
                            Dim u2 As New Uri(Drive("RemoteName"))
                            IPAddress = u2.Host
                        End If
                    Next
                End If

                'ネットワークフォルダーが指定されている場合は、Pingを送信して接続を確認する
                If Not IPAddress = "" Then

                    Dim p As New System.Net.NetworkInformation.Ping()
                    'Pingを送信する
                    Dim RetriesCount As Integer = 0
                    Dim Reply As System.Net.NetworkInformation.PingReply = p.Send(IPAddress)

                    '成功するか再試行回数の上限に達するまで繰り返す
                    Do Until Reply.Status = System.Net.NetworkInformation.IPStatus.Success

                        If RetriesCount >= NormalMode_Form.MaxRetriesCount Then
                            NormalMode_Form.ConnectionCheckResult = "FAIL"
                            'ステータス更新
                            NormalMode_Form.Invoke(callback, "接続が確認できませんでした！")
                            GoTo Finish
                        End If

                        'ステータス更新
                        NormalMode_Form.Invoke(callback, "接続確認の再試行中...(" & RetriesCount & "/" & NormalMode_Form.MaxRetriesCount & ")")

                        'iniファイルで指定した時間待機する(ミリ秒)
                        Thread.Sleep(NormalMode_Form.RetryIntervalSec * 1000)

                        Reply = p.Send(IPAddress)
                        RetriesCount = RetriesCount + 1

                    Loop
                    NormalMode_Form.ConnectionCheckResult = "PASS"
                Else
                    NormalMode_Form.ConnectionCheckResult = "LOCAL"
                End If

            Catch ex As Exception
                NormalMode_Form.ConnectionCheckResult = "ERROR"
                Exit Sub
            End Try
Finish:
            If Not NormalMode_Form.ConnectionCheckResult = "FAIL" Then
                'ステータス更新
                NormalMode_Form.Invoke(callback, "接続確認完了！")
            ElseIf NormalMode_Form.ConnectionCheckResult = "ERROR" Then
                'ステータス更新
                NormalMode_Form.Invoke(callback, "接続確認でエラーが発生しました！")
            End If

            If NormalMode_Form.ConnectionCheckResult = "PASS" Or NormalMode_Form.ConnectionCheckResult = "LOCAL" Then
                If System.IO.Directory.Exists(Path) Then
                    NormalMode_Form.ExistsResult = True
                Else
                    MsgBox("監視対象フォルダーが見つからなかったため、開始できませんでした。" _
                   & vbCrLf & "確認してください。", MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal, "エラー")
                    NormalMode_Form.Invoke(callback, "停止中(がありません！)")
                    Exit Sub
                End If
            End If

            'デリゲーターを変更する
            callback = New Delegate_ControlText(AddressOf Change_TextBox2)
            'テキストボックスを更新
            NormalMode_Form.Invoke(callback, NormalMode_Form.ConnectionCheckResult & vbCrLf & vbCrLf, "")

        Catch ex As ThreadAbortException
            'Console.WriteLine("スレッド強制終了！")
        End Try

    End Sub


    Private Sub Process_Start(ByVal SourcePath, ByVal DestPath)

    End Sub
End Class
