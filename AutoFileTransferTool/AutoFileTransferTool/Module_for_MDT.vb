Module Module_for_MDT
    Public Class FileWatcher
        Shared LastWriteTimeSav As Date = Now
        Shared NowTime As Date = Now

        Shared Sub Main(ByVal SourceCSVPath As String, ByVal EnableEvents As Boolean) ', ByVal DestPath As String)
            Dim Watcher As New System.IO.FileSystemWatcher


            With Watcher
                .Path = SourceCSVPath
                .Filter = "*"
                .NotifyFilter = IO.NotifyFilters.LastWrite 'Or IO.NotifyFilters.FileName
                .IncludeSubdirectories = True

                '変更を検知したとき、イベントを発生させる
                AddHandler Watcher.Created, AddressOf Notified
                AddHandler Watcher.Changed, AddressOf Notified
                AddHandler Watcher.Deleted, AddressOf Notified
                AddHandler Watcher.Renamed, AddressOf Notified
                AddHandler Watcher.Error, AddressOf ErrorEventHundler
                '.SynchronizingObject = NormalMode_Form

                .EnableRaisingEvents = EnableEvents
            End With
        End Sub

        Shared Sub Notified(ByVal sender As System.Object, ByVal e As System.IO.FileSystemEventArgs)
            'If Strings.Right(e.FullPath, 3) <> "tmp" Then
            'Dim FileTime As New System.IO.FileInfo(e.FullPath)

            'If Not FileTime.LastWriteTime = LastWriteTimeSav Then
            Console.WriteLine(e.ChangeType.ToString())
                Console.WriteLine(Now)
                Console.WriteLine(e.FullPath)
            'End If
            'End If
            'LastWriteTimeSav = Now

        End Sub

        Shared Sub ErrorEventHundler(ByVal sender As System.Object, ByVal e As System.IO.ErrorEventArgs)
            MsgBox(e.GetType.ToString())
        End Sub

    End Class

    Public Class Form1
        Dim Path_copyfrom As String = ""
        Dim Path_copyto As String = ""
        Dim StartTime As DateTime

        Private _latestCheckTime As DateTime   ''最後にﾌｧｲﾙﾁｪｯｸを行った時刻

        'Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '    Me.SrcPath.Text = Path_copyfrom
        '    Me.DestPath.Text = Path_copyto
        '    Me.StatusLabel.Text = "ステータス："
        '    Me.StopToolStripMenuItem.Enabled = False
        '    Dim FixedDate As String

        '    FixedDate = InputBox("さかのぼりたい日付をYYYYMMDD形式(8桁)で入力してください。", "日付入力", Replace(DateTime.Today.ToShortDateString, "/", ""))

        '    If String.IsNullOrEmpty(FixedDate) Or FixedDate Is Environ(255) Then
        '        MsgBox("キャンセルされました。終了します。")
        '        Application.Exit()
        '        Exit Sub
        '    End If

        '    StartTime = DateTime.ParseExact(Strings.Left(FixedDate, 8) & "000000", "yyyyMMddHHmmss", System.Globalization.DateTimeFormatInfo.InvariantInfo, System.Globalization.DateTimeStyles.None).Date
        '    _latestCheckTime = StartTime
        'End Sub

        'Private Sub EndToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndToolStripMenuItem.Click
        '    Dim Ret As Short
        '    Ret = MessageBox.Show("終了しますか？", "終了", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        '    If Ret = DialogResult.Yes Then
        '        End
        '    End If
        'End Sub

        'Private Sub StartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem.Click
        '    Path_copyfrom = SrcPathTextBox.Text
        '    Path_copyto = DestPathTextBox.Text
        '    If Path_copyfrom = Path_copyto Then
        '        MessageBox.Show("コピー元とコピー先のフォルダが同じです。", "フォルダのコピーエラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Exit Sub
        '    End If

        '    If Dir(Path_copyfrom, FileAttribute.Directory) = "" Then
        '        MessageBox.Show("コピー元のフォルダが存在しません。", "フォルダのコピーエラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Exit Sub
        '    End If

        '    If Dir(Path_copyto, FileAttribute.Directory) = "" Then
        '        MessageBox.Show("コピー先のフォルダが存在しません。", "フォルダのコピーエラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Exit Sub
        '    End If

        '    Me.StartToolStripMenuItem.Enabled = False
        '    Me.StopToolStripMenuItem.Enabled = True
        '    Me.設定ToolStripMenuItem.Enabled = False
        '    Me.nudInterval.Enabled = False

        '    TimeSpan = CInt(Me.nudInterval.Value) * 60 * 1000

        '    _latestCheckTime = Now
        '    Me.StatusLabel.Text = "ステータス：フォルダ監視中"
        '    Me.Timer1.Start()
        'End Sub

        '        Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        '            If Now > DateAdd(DateInterval.Second, TimeSpan, StartTime) Then
        '                If Dir(Path_copyfrom, FileAttribute.Directory) = "" Then
        '                    Me.StatusLabel.Text = "ステータス：コピー先のフォルダが存在しません。"
        '                    GoTo FINISH
        '                End If

        '                If Dir(Path_copyto, FileAttribute.Directory) = "" Then
        '                    Me.StatusLabel.Text = "ステータス：コピー先のフォルダが存在しません。"
        '                    GoTo FINISH
        '                End If

        '                Call CopyFile(Path_copyfrom, Path_copyto)

        '            End If
        'FINISH:
        '        End Sub

        Public Sub test()


        End Sub


        Public Sub CopyDumpFile(ByVal SourceCSVPath As String, ByVal DestPath As String)


        End Sub


        Private Function TimeToString(ByVal TempTime As Date)
            Dim NewTemp As String = ""
            NewTemp = NewTemp & TempTime.Year.ToString("0000")
            NewTemp = NewTemp & TempTime.Month.ToString("00")
            NewTemp = NewTemp & TempTime.Day.ToString("00")
            NewTemp = NewTemp & TempTime.Hour.ToString("00")
            NewTemp = NewTemp & TempTime.Minute.ToString("00")
            NewTemp = NewTemp & TempTime.Second.ToString("00")
            TimeToString = NewTemp
        End Function

        'Private Function CheckFileUsing(ByVal vstrFilePath As String) As Boolean

        '    Dim f As New IO.FileInfo(vstrFilePath)
        '    Dim strFileNameBK As String = f.Name

        '    If Not f.Exists Then
        '        'ファイルが存在しなければ、使用中ではない
        '        Return False
        '    End If

        '    Try
        '        'ファイル名を変更して、使用中かチェックする
        '        f.MoveTo(IO.Path.Combine(f.DirectoryName, f.Name & ".BK"))
        '        Threading.Thread.Sleep(1000)
        '        'ファイル名を元に戻す
        '        f.MoveTo(IO.Path.Combine(f.DirectoryName, strFileNameBK))
        '        Threading.Thread.Sleep(1000)

        '        'ファイル名の変更が成功したので、使用中ではない
        '        Return False
        '    Catch ex As Exception
        '        'ファイル名が変更できないので、使用中とする
        '        Return True
        '    End Try
        'End Function

        'ファイル入力　パス指定で　戻り値はデータの配列
        Private Function TxtFileIO(ByVal _path As String, ByVal _path2 As String) As String()
            Dim Temp As String = ""

            Try
                Using Reader As New System.IO.StreamReader(_path)
                    Temp = Reader.ReadToEnd
                End Using

                If System.IO.File.Exists(_path2) Then
                    Using Reader As New System.IO.StreamReader(_path2)
                        Temp = Temp + Reader.ReadToEnd
                    End Using
                End If
                TxtFileIO = Split(Temp, vbCrLf)

            Catch ex As Exception
                MsgBox("csvファイルの読み込みでエラーが発生しました。")
            End Try
        End Function


        'ファイル出力　txt形式　temp
        Private Sub _txtFileOutput(ByVal _filePath As String, ByVal _data() As String)

            Dim path As String = _filePath

            Dim sw As New System.IO.StreamWriter(path, False, System.Text.Encoding.Default)
            Dim temp As String

            For a = 0 To _data.Length - 1
                temp = _data(a) + vbCrLf
                sw.Write(temp)
            Next

            sw.Close()
        End Sub

    End Class
End Module
