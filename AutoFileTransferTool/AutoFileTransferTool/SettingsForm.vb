Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class SettingsForm

    Dim Settings_Changed As Boolean = False

    ''' <summary>
    ''' iniファイル書き込み関数
    ''' </summary>
    ''' <param name="lpAppName">セクション名</param>
    ''' <param name="lpKeyName">キー名</param>
    ''' <param name="lpString">書き込む文字列</param>
    ''' <param name="lpFileName">iniファイル名</param>
    ''' <returns></returns>
    <DllImport("Kernel32.dll")>
    Private Shared Function WritePrivateProfileString(
                    ByVal lpAppName As String,
                    ByVal lpKeyName As String,
                    ByVal lpString As String,
                    ByVal lpFileName As String) As Integer
    End Function

    'フォームの表示時
    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'リストの1番目を選択した状態にする
        SettingsList.SelectedIndex = 0
        WatcherSettings_Panel.Visible = True

        ConnectionCheck_Enable_CheckBox.Enabled = True
        ConnectionCheck_RetryCount_TextBox.Enabled = True
        ConnectionCheck_RetryInterval_TextBox.Enabled = True
        IncludeSubFolders_CheckBox.Checked = True
    End Sub

    Private Sub Apply_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Apply_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        '


        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SettingsList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SettingsList.SelectedIndexChanged
        If SettingsList.SelectedIndex = 1 Then
            MsgBox("2")
        End If
    End Sub

    Private Sub Enabled_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ConnectionCheck_Enable_CheckBox.CheckedChanged
        ConnectionCheck_RetryCount_TextBox.Enabled = Not ConnectionCheck_RetryCount_TextBox.Enabled
        ConnectionCheck_RetryInterval_TextBox.Enabled = Not ConnectionCheck_RetryInterval_TextBox.Enabled
    End Sub

    Private Sub RetryCount_TextBox_TextChanged(sender As Object, e As EventArgs) Handles ConnectionCheck_RetryCount_TextBox.TextChanged
        Settings_Changed = True
    End Sub

    Private Sub RetryInterval_TextBox_TextChanged(sender As Object, e As EventArgs) Handles ConnectionCheck_RetryInterval_TextBox.TextChanged
        Settings_Changed = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles MDTMode_RadioButton.CheckedChanged
        MsgBox("変更")
    End Sub

End Class
