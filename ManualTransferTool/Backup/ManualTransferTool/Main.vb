Imports System
Imports System.IO
Imports System.Text
Imports System.Runtime.InteropServices

Public Class Main
    '共有できる配列変数を宣言
    Friend GenList As New List(Of String)
    Friend PathList As New List(Of String)
    Dim strExcelFile() As String

    '品種設定用iniファイル名を指定
    Dim TypeIniFileName As String = ".\ini\Type_Settings.ini"
    'For文カウント用変数
    Dim Counter As Integer

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

    'INIファイルのキーを行単位で取得
    Function GetKeyList(ByVal Section As String) As Object

        Dim buf As String = New String(vbNullChar, 1024)

        IniFileHandler.GetPrivateProfileSection(Section, buf, Len(buf), TypeIniFileName)

        '文末のNULL文字を削除
        Dim Key As String
        Key = Strings.Left(buf, InStr(1, buf, vbNullChar & vbNullChar))

        '配列形式で返す：Array(i) = 「キー = 値」
        GetKeyList = Split(Key, vbNullChar)

    End Function


    Private Sub Main_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        'フォームの読み込み時(起動時)にiniファイルを読み込む

        Dim tmpStr As String

        'iniファイルの存在チェック
        Dim ExistCheck As MsgBoxResult
        Do Until (System.IO.File.Exists(TypeIniFileName))
            ExistCheck = MsgBox("""" & TypeIniFileName & """が見つかりませんでした。" & vbCrLf & vbCrLf & _
            "再読み込みする場合は「再試行」を、終了する場合は「キャンセル」を押してください。" _
            , MsgBoxStyle.SystemModal + MsgBoxStyle.Question + MsgBoxStyle.RetryCancel, "iniファイルチェック")
            If ExistCheck = MsgBoxResult.Cancel Then
                Application.Exit()
                Exit Do
            End If
        Loop

        'iniファイルのセクション名をすべて取得
        Dim SectionList As New List(Of String)

        Dim Ptr As IntPtr = Marshal.StringToHGlobalAnsi(New String(vbNullChar, 1024))
        Dim Len As Integer = IniFileHandler.GetPrivateProfileSectionNames(Ptr, 1024, TypeIniFileName)
        Dim Buffer As String = Marshal.PtrToStringAnsi(Ptr, Len)
        Marshal.FreeHGlobal(Ptr)
        Dim SB As New StringBuilder

        For ii As Integer = 0 To Len - 1
            Dim C As Char = Buffer.Chars(ii)
            If C = vbNullChar Then
                SectionList.Add(SB.ToString)
                SB.Length = 0
            Else
                SB.Append(C)
            End If
        Next


        '各セクションのキーをリストへ格納
        For Me.Counter = 0 To SectionList.Count - 1
            For i As Integer = 0 To UBound(GetKeyList(SectionList.Item(Counter))) - 1
                tmpStr = SectionList(Counter) & "@" & GetKeyList(SectionList(Counter))(i)
                GenList.Add(tmpStr)
                'ListBox1.Items.Add(tmpStr)
            Next
        Next

        DataGridView.Rows.Add(True, "C:\temp", "電特", "LTO", "Gen9", "VGA", "123001--1", "準備完了", "QA04")
        DataGridView.Rows.Add(False, "C:\temp", "MP", "CHOU6", "Gen6", "VGG", "123456--1", "準備完了", "QA04")
        'DataGridView.Rows(0).Visible = False
        DataGridView.CurrentCell = Nothing

    End Sub

    Private Sub DropFileBox_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs) Handles DropFileBox.DragEnter
        'コントロール内にドラッグされたとき実行される
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            'ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
            e.Effect = DragDropEffects.Copy
        Else
            'ファイル以外は受け付けない
            e.Effect = DragDropEffects.None
        End If

    End Sub

    Private Sub DropFileBox_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles DropFileBox.DragDrop

        Dim strFileName As String() = CType(e.Data.GetData(DataFormats.FileDrop, False), String())
        Dim i As Integer

        i = 0

        ReDim strExcelFile(strFileName.Length - 1)
        'ファイルの情報取得
        While strFileName.Length > i
            ''ファイル名を表示する(複数ファイルの時は最後のファイルを表示)
            'DropFileBox.Text = strFileName(i).ToString
            'フルパス情報を取得
            strExcelFile(i) = strFileName(i).ToString
            i = i + 1

        End While

    End Sub

    Private Sub ExitButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ClearButton.Click
        MsgBox(DataGridView.Rows(0).Cells(0).Value)
    End Sub

    Private Sub StartButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StartButton.Click
        Dim Judgment As String = ""
        Dim i As Integer
        Dim strBuffer As New System.Text.StringBuilder
        strBuffer.Capacity = 256   ''バッファーのサイズを指定
        Dim ret As Integer
        Dim iniFileName As String
        Dim sFormat, sGen, sType, TransPath, sData, tmpStr As String

        If InStr(DropFileBox.Text, "Please") > 0 Then
            'ファイルが存在しない時に表示する
            DropFileBox.Text = vbCrLf & vbCrLf & vbCrLf & "No Excel File"
            Exit Sub

        Else
            'ファイルが存在している時
            For i = 0 To strExcelFile.Length - 1

                Dim tmpFormat, tmpGen, TmpType, TypeAry() As String
                Dim FormatGenCounter, TypeCounter As Integer
                Dim tmpJudge As Boolean

                sFormat = ""
                sGen = ""
                sType = ""
                TransPath = ""
                tmpJudge = True
                For FormatGenCounter = 0 To GenList.Count - 1
                    If tmpJudge = True Then
                        tmpStr = GenList.Item(FormatGenCounter)
                        tmpFormat = Trim(Strings.Left(tmpStr, InStr(tmpStr, "@") - 1))
                        tmpGen = Strings.Left(tmpStr, InStr(tmpStr, "=") - 1)
                        tmpGen = Trim(Strings.Mid(tmpGen, tmpFormat.Length + 2, tmpGen.Length - (tmpFormat.Length + 1)))
                        TmpType = Trim(Strings.Right(tmpStr, tmpStr.Length - InStr(tmpStr, "=")))

                        If Not InStr(tmpStr, ",") > 0 Then
                            If InStr(strExcelFile(i), TmpType) > 0 Then
                                sFormat = tmpFormat
                                sGen = tmpGen
                                sType = TmpType
                                tmpJudge = False
                                Exit For
                            End If
                        Else
                            TypeAry = Split(TmpType, ",")
                            For TypeCounter = 0 To UBound(TypeAry)
                                TmpType = Trim(TypeAry(TypeCounter))
                                If InStr(strExcelFile(i), TmpType) > 0 Then
                                    sFormat = tmpFormat
                                    sGen = tmpGen
                                    sType = TmpType
                                    tmpJudge = False
                                    Exit For
                                End If
                            Next
                        End If
                    Else
                        Exit For
                    End If
                Next


        'ファイルがMPか電特のどちらか確認する
        If InStr(strExcelFile(i), "MP") > 0 Then
            Judgment = "MP"
        ElseIf InStr(strExcelFile(i), "電特") > 0 Then
            Judgment = "電特"
        End If


        If sFormat = "" Or sGen = "" Or sType = "" Then
            MsgBox("品種もしくは転送先を認識出来ない為、処理を中止します", vbCritical, "Error")
            Exit Sub
        Else
            'MsgBox(sFormat & vbCrLf & sGen & vbCrLf & Trim(sType) & vbCrLf & TransPath)
        End If

        Dim path As String = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase
        'URIを通常のパス形式に変換する
        Dim u As New Uri(path)
        path = u.LocalPath + Uri.UnescapeDataString(u.Fragment)
        path = System.IO.Path.GetDirectoryName(path)

        '関数でExcel参照
        If Judgment = "MP" Then
            'MPデータの時
            iniFileName = path & "\ini\MP.ini"
            'iniファイルより規格を取得
            ret = GetPrivateProfileString(sFormat, sType, "", strBuffer, strBuffer.Capacity, iniFileName)
            sData = strBuffer.ToString
            'If sData = "" Then
            '    MsgBox("iniファイルに規格が登録されていないため、処理できませんでした！", vbCritical, "Error")
            If sFormat = "LTO" Then
                'LTOのMPデータ
                'Call LTO_MP_Trans(strExcelFile(i), sType, sData)
                MsgBox("フォーマット：" & sFormat & vbCrLf & _
                       "世代：" & sGen & vbCrLf & _
                       "品種：" & sType & vbCrLf & _
                       "測定項目：" & Judgment, vbInformation)
                MsgBox("処理が終了しました", vbInformation)
            ElseIf sFormat = "CHOU" Then
                'CHOUのMPデータ
                'Call CHOU_MP_Trans(strExcelFile(i), sType, sData)
                MsgBox("フォーマット：" & sFormat & vbCrLf & _
                       "世代：" & sGen & vbCrLf & _
                       "品種：" & sType & vbCrLf & _
                       "測定項目：" & Judgment, vbInformation)
                MsgBox("処理が終了しました", vbInformation)
            Else
                MsgBox("フォーマットが認識できないか、処理方法が登録されていないため、処理できませんでした！", vbCritical, "Error")
            End If

        ElseIf Judgment = "電特" Then
            '電特データの時
            iniFileName = path & "\ini\DEN.ini"
            'iniファイルより規格を取得
            ret = GetPrivateProfileString(sFormat, sType, "", strBuffer, strBuffer.Capacity, iniFileName)
            sData = strBuffer.ToString

            'If sData = "" Then
            '    MsgBox("iniファイルに規格が登録されていないため、処理できませんでした！", vbCritical, "Error")
            'Else
            'Call Den_Trans(strExcelFile(i), sType, sData)
            MsgBox("フォーマット：" & sFormat & vbCrLf & _
                       "世代：" & sGen & vbCrLf & _
                       "品種：" & sType & vbCrLf & _
                       "測定項目：" & Judgment, vbInformation)
            MsgBox("処理が終了しました", vbInformation)
            'End If
        End If
            Next
        End If

    End Sub

    Private Sub SelectAll_ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAll_ToolStripMenuItem.Click
        For i As Integer = 0 To DataGridView.RowCount - 1
            DataGridView.Rows(i).Cells(0).Value = True
        Next
    End Sub

    Private Sub SelectNone_ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectNone_ToolStripMenuItem.Click
        For i As Integer = 0 To DataGridView.RowCount - 1
            DataGridView.Rows(i).Cells(0).Value = False
        Next
    End Sub

    Private Sub Item1_ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles DataGridView_ContextMenuStrip.ItemClicked

        If Not TypeOf (e.ClickedItem) Is Windows.Forms.ToolStripSeparator Then

        End If


    End Sub

    Private Sub DataGridView_ContextMenuStrip_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DataGridView_ContextMenuStrip.Opening
        'Dim tmpList As New List(Of String)
        Dim SelectAll As ToolStripMenuItem = SelectAll_ToolStripMenuItem
        Dim SelectNone As ToolStripMenuItem = SelectNone_ToolStripMenuItem
        Dim MenuSeparator As New ToolStripSeparator

        DataGridView_ContextMenuStrip.Items.Clear()
        DataGridView_ContextMenuStrip.Items.Add(SelectAll)
        DataGridView_ContextMenuStrip.Items.Add(SelectNone)
        DataGridView_ContextMenuStrip.Items.Add(MenuSeparator)
        For i As Integer = 0 To DataGridView.Rows.Count - 1
            'tmpList.Add()
            DataGridView_ContextMenuStrip.Items.Add(DataGridView.Rows(i).Cells(2).Value)
        Next

    End Sub
End Class