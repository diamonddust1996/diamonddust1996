Imports System.Text
Imports Microsoft.Office.Interop



Public Class Main
    Friend Gen As String
    Friend iniFolder As String = ".\ini"
    Friend iniFileName As String = iniFolder & "\" & Gen & "_Settings.ini"
    Private Delegate Sub ButtonOnDelegate()

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ButtonOff()
        'DoSomethingメソッドを別のスレッドで実行する
        'Threadオブジェクトを作成する
        Dim t As New System.Threading.Thread(New System.Threading.ThreadStart( _
        AddressOf DoSomething))
        t.IsBackground = True
        'スレッドを開始する
        t.Start()
    End Sub

    '別スレッドで実行するメソッド
    Private Sub DoSomething()
        Dim ButtonOnDlg As New ButtonOnDelegate(AddressOf ButtonOn)
        Me.Invoke(ButtonOnDlg)
    End Sub

    Private Sub ButtonOn()
        dmp2tmf_Btn.Enabled = True
    End Sub

    Private Sub ButtonOff()
        dmp2tmf_Btn.Enabled = False
    End Sub

    Private Declare Function GetPrivateProfileString Lib "kernel32" _
 Alias "GetPrivateProfileStringA" ( _
                              ByVal lpAppName As String, _
                              ByVal lpKeyName As String, _
                              ByVal lpDefault As String, _
                              ByVal lpReturnedString As StringBuilder, _
                              ByVal nSize As Integer, _
                              ByVal lpFileName As String) As Integer

    Private Declare Function WritePrivateProfileString Lib "kernel32" _
Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, _
                                    ByVal lpKeyName As String, _
                                    ByVal lpString As String, _
                                    ByVal lpFileName As StringBuilder) As Integer

    Private Sub Read_ini()
        If Gen = "Temp" Then Exit Sub
        iniFileName = iniFolder & "\" & Gen & "_Settings.ini"

        Dim Default_TempFolder, Default_dmp2tmf, Default_tmf2xlsm, Default_WEdataExtract, Default_Disable, _
Default_Macro1, Default_Macro2, Default_Macro3 As String
        Default_TempFolder = "" : Default_dmp2tmf = "" : Default_tmf2xlsm = "" : Default_WEdataExtract = "" : Default_Disable = ""
        Default_Macro1 = "" : Default_Macro2 = "" : Default_Macro3 = ""

        If Gen = "Temp" Then
            Exit Sub
        ElseIf Gen = "G7" Then
            Default_TempFolder = "C:\WE\DumpTOTmf"
            Default_dmp2tmf = "C:\WE\DumpTOTmf\tmf_80D.exe"
            Default_tmf2xlsm = "C:\WE\WE計算マクロフォルダ\G7\DS&CWIデータ抽出マクロ_G7(84RGN)v2.xlsm"
            Default_WEdataExtract = "C:\WE\WE計算マクロフォルダ\G7\WEデータ抽出マクロ_L7v3.xlsm"
            Default_Disable = ""
            Default_Macro1 = "G7_data読み出し"
            Default_Macro2 = "G7_WE_data読み出し"
            Default_Macro3 = ""
        ElseIf Gen = "G8" Then
            Default_TempFolder = "C:\WE\DumpTOTmf"
            Default_dmp2tmf = "C:\WE\DumpTOTmf\tmf_80D.exe"
            Default_tmf2xlsm = "C:\WE\WE計算マクロフォルダ\G8\DS&CWIデータ抽出マクロ_G8v2.xlsm"
            Default_WEdataExtract = "C:\WE\WE計算マクロフォルダ\G8\WEデータ抽出マクロ_L8v3.xlsm"
            Default_Disable = ""
            Default_Macro1 = "G8_data読み出し"
            Default_Macro2 = "G8_WE_data読み出し"
            Default_Macro3 = ""
        ElseIf Gen = "G9" Then
            Default_TempFolder = "C:\WE\DumpTOTmf_forL9"
            Default_dmp2tmf = "C:\WE\DumpTOTmf_forL9\tmf_80q.exe"
            Default_tmf2xlsm = "C:\WE\WE計算マクロフォルダ\G9\DS&CWIデータ抽出マクロ_G9(81RGN用)v3.xlsm"""
            Default_WEdataExtract = "C:\WE\WE計算マクロフォルダ\G9\WEデータ抽出マクロ_L9v4.xlsm"""
            Default_Disable = ""
            Default_Macro1 = "G9_data読み出し"
            Default_Macro2 = "G9_WE_data読み出し"
            Default_Macro3 = ""
        End If


        Dim SB1_1 As StringBuilder = New StringBuilder(512)
        Dim SB1_2 As StringBuilder = New StringBuilder(512)
        Dim SB1_3 As StringBuilder = New StringBuilder(512)
        Dim SB1_4 As StringBuilder = New StringBuilder(512)
        Dim SB1_5 As StringBuilder = New StringBuilder(512)
        Dim SB2_1 As StringBuilder = New StringBuilder(512)
        Dim SB2_2 As StringBuilder = New StringBuilder(512)
        Dim SB2_3 As StringBuilder = New StringBuilder(512)

        GetPrivateProfileString("Address", "TempFolder", Default_TempFolder, SB1_1, 512, iniFileName)
        GetPrivateProfileString("Address", "dmp2tmf", Default_dmp2tmf, SB1_2, 512, iniFileName)
        GetPrivateProfileString("Address", "tmf2xlsm", Default_tmf2xlsm, SB1_3, 512, iniFileName)
        GetPrivateProfileString("Address", "WEdataExtract", Default_WEdataExtract, SB1_4, 512, iniFileName)
        GetPrivateProfileString("Address", "Disable", Default_Disable, SB1_5, 512, iniFileName)
        GetPrivateProfileString("MacroName", "Macro1", Default_Macro1, SB2_1, 512, iniFileName)
        GetPrivateProfileString("MacroName", "Macro2", Default_Macro2, SB2_2, 512, iniFileName)
        GetPrivateProfileString("MacroName", "Macro3", Default_Macro3, SB2_3, 512, iniFileName)

        dmp2tmf_Address.Text = SB1_2.ToString
        Label2_Address.Text = SB1_3.ToString
        Label3_Address.Text = SB1_4.ToString
        Label4_Address.Text = SB1_5.ToString
    End Sub

    Private Sub Main_Load() Handles MyBase.Load
        Dim Today, Tomorrow As DateTime
        Dim str As String
        Today = Now
        str = "20220422090501"
        Tomorrow = DateTime.ParseExact(str, "yyyyMMddHHmmss", System.Globalization.DateTimeFormatInfo.InvariantInfo, System.Globalization.DateTimeStyles.None)
        If Today < Tomorrow Then MsgBox(Today & "To" & Tomorrow & "今は前")
        If Today > Tomorrow Then MsgBox(Today & "To" & Tomorrow & "今はあと")
        'MsgBox(Today & vbCrLf & Tomorrow & vbCrLf & Today.Date.CompareTo(Tomorrow)) '同じ=0,()内が後=-1

        'Dim CheckMsg As Integer
        'Gen = Gen_Select.Gen_ComboBox.Text
        'If Gen = "" Then
        '    Gen = "Temp"
        'Else
        '    iniFileName = iniFolder & "\" & Gen & "_Settings.ini"
        '    MsgBox(iniFileName)
        '    If Not System.IO.File.Exists(iniFileName) Then
        '        CheckMsg = MsgBox(IO.Path.GetFileName(iniFileName) + "が見つかりません。" + vbCrLf + "デフォルトの値を読み込みますか？", CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel, MsgBoxStyle))
        '        If CheckMsg = vbNo Then
        '            Exit Sub
        '        ElseIf CheckMsg = vbCancel Then
        '            Application.Exit()
        '        End If
        '    End If
        '    Read_ini()
        'End If
        'Gen_DropDownButton.Text = Gen
        Application.Exit()
    End Sub

    Private Sub Main_Activated() Handles MyBase.Activated
        StatusStrip.BackColor = Color.FromArgb(185, 209, 234)
    End Sub

    Private Sub Main_Deactivate() Handles MyBase.Deactivate
        StatusStrip.BackColor = Color.FromArgb(215, 228, 242)
    End Sub


    Private Sub Settings_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Settings_Btn.Click
        Dim f As New Settings()
        f.StartPosition = FormStartPosition.CenterParent
        f.ShowDialog(Me)
        f.Dispose()
    End Sub
    'objWShell.AppActivate "ファイルを開く"
    'objWShell.SendKeys "%{N}"
    'WScript.Sleep 50
    'objWShell.SendKeys strText

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DumpLabel.Click

    End Sub

    Private Sub Gen_DropDownButton_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gen_DropDownButton.DropDownOpening
        Gen_DropDownButton.DropDownItems.Clear()
        Gen_DropDownButton.DropDownItems.Add("Temp")
        Dim FSO As Object
        FSO = CreateObject("Scripting.FileSystemObject")
        For Each f In System.IO.Directory.GetFiles(iniFolder)
            Dim FileName() As String = Split(IO.Path.GetFileName(f), "_")
            If FileName(1) = "Settings.ini" Then
                Gen_DropDownButton.DropDownItems.Add(FileName(0))
            End If
        Next
    End Sub

    Private Sub Gen_DropDownButton_Select(ByVal sender As System.Object, ByVal e As ToolStripItemClickedEventArgs) Handles Gen_DropDownButton.DropDownItemClicked
        Gen_DropDownButton.Text = e.ClickedItem.Text
        Gen = Gen_DropDownButton.Text
        Settings.GenSelect_ComboBox.Text = Gen
        iniFileName = iniFolder & "\" & Gen & "_Settings.ini"
    End Sub
End Class
