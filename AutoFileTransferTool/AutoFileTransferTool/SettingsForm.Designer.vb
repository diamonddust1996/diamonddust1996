<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel_for_Button = New System.Windows.Forms.TableLayoutPanel()
        Me.Apply_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.SettingsList = New System.Windows.Forms.ListBox()
        Me.ConnectionCheckSettings_GroupBox = New System.Windows.Forms.GroupBox()
        Me.ConnectionCheck_RetryInterval_TextBox = New System.Windows.Forms.TextBox()
        Me.ConnectionCheck_RetryInterval_Label = New System.Windows.Forms.Label()
        Me.ConnectionCheck_RetryCount_TextBox = New System.Windows.Forms.TextBox()
        Me.ConnectionCheck_RetryCount_Label = New System.Windows.Forms.Label()
        Me.ConnectionCheck_Enable_CheckBox = New System.Windows.Forms.CheckBox()
        Me.WatcherSettings_GroupBox = New System.Windows.Forms.GroupBox()
        Me.IncludeSubFolders_CheckBox = New System.Windows.Forms.CheckBox()
        Me.WatcherSettings_Panel = New System.Windows.Forms.Panel()
        Me.DefaultSettings_Panel = New System.Windows.Forms.Panel()
        Me.DefaultSettings_GroupBox = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DestPath_TextBox = New System.Windows.Forms.TextBox()
        Me.DestPath_Label = New System.Windows.Forms.Label()
        Me.SourcePath_TextBox = New System.Windows.Forms.TextBox()
        Me.SourcePath_Label = New System.Windows.Forms.Label()
        Me.MDTMode_RadioButton = New System.Windows.Forms.RadioButton()
        Me.NomalMode_RadioButton = New System.Windows.Forms.RadioButton()
        Me.TransferSettings_Panel = New System.Windows.Forms.Panel()
        Me.TransferSettings_GroupBox = New System.Windows.Forms.GroupBox()
        Me.TempPath_TextBox = New System.Windows.Forms.TextBox()
        Me.TempFolder_Label = New System.Windows.Forms.Label()
        Me.DirectlyTransfer_RadioButton = New System.Windows.Forms.RadioButton()
        Me.ViaTempFolder_RadioButton = New System.Windows.Forms.RadioButton()
        Me.SourceFileSettings_GroupBox = New System.Windows.Forms.GroupBox()
        Me.MoveFilePath = New System.Windows.Forms.TextBox()
        Me.MoveFile_RadioButton = New System.Windows.Forms.RadioButton()
        Me.NoneProcess_RadioButton = New System.Windows.Forms.RadioButton()
        Me.DeleteFile_RadioButton = New System.Windows.Forms.RadioButton()
        Me.MDTModeSettings_Panel = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel_for_Button.SuspendLayout()
        Me.ConnectionCheckSettings_GroupBox.SuspendLayout()
        Me.WatcherSettings_GroupBox.SuspendLayout()
        Me.WatcherSettings_Panel.SuspendLayout()
        Me.DefaultSettings_Panel.SuspendLayout()
        Me.DefaultSettings_GroupBox.SuspendLayout()
        Me.TransferSettings_Panel.SuspendLayout()
        Me.TransferSettings_GroupBox.SuspendLayout()
        Me.SourceFileSettings_GroupBox.SuspendLayout()
        Me.MDTModeSettings_Panel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel_for_Button
        '
        Me.TableLayoutPanel_for_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel_for_Button.ColumnCount = 2
        Me.TableLayoutPanel_for_Button.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel_for_Button.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel_for_Button.Controls.Add(Me.Apply_Button, 0, 0)
        Me.TableLayoutPanel_for_Button.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel_for_Button.Location = New System.Drawing.Point(369, 316)
        Me.TableLayoutPanel_for_Button.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel_for_Button.Name = "TableLayoutPanel_for_Button"
        Me.TableLayoutPanel_for_Button.RowCount = 1
        Me.TableLayoutPanel_for_Button.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel_for_Button.Size = New System.Drawing.Size(195, 33)
        Me.TableLayoutPanel_for_Button.TabIndex = 0
        '
        'Apply_Button
        '
        Me.Apply_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Apply_Button.Location = New System.Drawing.Point(4, 3)
        Me.Apply_Button.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Apply_Button.Name = "Apply_Button"
        Me.Apply_Button.Size = New System.Drawing.Size(89, 27)
        Me.Apply_Button.TabIndex = 0
        Me.Apply_Button.Text = "適用"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(101, 3)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(89, 27)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "キャンセル"
        '
        'SettingsList
        '
        Me.SettingsList.FormattingEnabled = True
        Me.SettingsList.ItemHeight = 15
        Me.SettingsList.Items.AddRange(New Object() {"デフォルト設定", "監視設定", "転送設定", "MDTモード用設定"})
        Me.SettingsList.Location = New System.Drawing.Point(13, 13)
        Me.SettingsList.Name = "SettingsList"
        Me.SettingsList.Size = New System.Drawing.Size(120, 304)
        Me.SettingsList.TabIndex = 1
        '
        'ConnectionCheckSettings_GroupBox
        '
        Me.ConnectionCheckSettings_GroupBox.Controls.Add(Me.ConnectionCheck_RetryInterval_TextBox)
        Me.ConnectionCheckSettings_GroupBox.Controls.Add(Me.ConnectionCheck_RetryInterval_Label)
        Me.ConnectionCheckSettings_GroupBox.Controls.Add(Me.ConnectionCheck_RetryCount_TextBox)
        Me.ConnectionCheckSettings_GroupBox.Controls.Add(Me.ConnectionCheck_RetryCount_Label)
        Me.ConnectionCheckSettings_GroupBox.Controls.Add(Me.ConnectionCheck_Enable_CheckBox)
        Me.ConnectionCheckSettings_GroupBox.Location = New System.Drawing.Point(0, 0)
        Me.ConnectionCheckSettings_GroupBox.Name = "ConnectionCheckSettings_GroupBox"
        Me.ConnectionCheckSettings_GroupBox.Size = New System.Drawing.Size(426, 102)
        Me.ConnectionCheckSettings_GroupBox.TabIndex = 2
        Me.ConnectionCheckSettings_GroupBox.TabStop = False
        Me.ConnectionCheckSettings_GroupBox.Text = "ネットワーク接続確認"
        '
        'ConnectionCheck_RetryInterval_TextBox
        '
        Me.ConnectionCheck_RetryInterval_TextBox.Location = New System.Drawing.Point(233, 72)
        Me.ConnectionCheck_RetryInterval_TextBox.Name = "ConnectionCheck_RetryInterval_TextBox"
        Me.ConnectionCheck_RetryInterval_TextBox.Size = New System.Drawing.Size(100, 22)
        Me.ConnectionCheck_RetryInterval_TextBox.TabIndex = 4
        '
        'ConnectionCheck_RetryInterval_Label
        '
        Me.ConnectionCheck_RetryInterval_Label.AutoSize = True
        Me.ConnectionCheck_RetryInterval_Label.Location = New System.Drawing.Point(7, 75)
        Me.ConnectionCheck_RetryInterval_Label.Name = "ConnectionCheck_RetryInterval_Label"
        Me.ConnectionCheck_RetryInterval_Label.Size = New System.Drawing.Size(119, 15)
        Me.ConnectionCheck_RetryInterval_Label.TabIndex = 3
        Me.ConnectionCheck_RetryInterval_Label.Text = "再試行の間隔(秒)"
        '
        'ConnectionCheck_RetryCount_TextBox
        '
        Me.ConnectionCheck_RetryCount_TextBox.Location = New System.Drawing.Point(233, 45)
        Me.ConnectionCheck_RetryCount_TextBox.Name = "ConnectionCheck_RetryCount_TextBox"
        Me.ConnectionCheck_RetryCount_TextBox.Size = New System.Drawing.Size(100, 22)
        Me.ConnectionCheck_RetryCount_TextBox.TabIndex = 2
        '
        'ConnectionCheck_RetryCount_Label
        '
        Me.ConnectionCheck_RetryCount_Label.AutoSize = True
        Me.ConnectionCheck_RetryCount_Label.Location = New System.Drawing.Point(7, 48)
        Me.ConnectionCheck_RetryCount_Label.Name = "ConnectionCheck_RetryCount_Label"
        Me.ConnectionCheck_RetryCount_Label.Size = New System.Drawing.Size(202, 15)
        Me.ConnectionCheck_RetryCount_Label.TabIndex = 1
        Me.ConnectionCheck_RetryCount_Label.Text = "エラー発生時の最大再試行回数"
        '
        'ConnectionCheck_Enable_CheckBox
        '
        Me.ConnectionCheck_Enable_CheckBox.AutoSize = True
        Me.ConnectionCheck_Enable_CheckBox.Checked = True
        Me.ConnectionCheck_Enable_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ConnectionCheck_Enable_CheckBox.Location = New System.Drawing.Point(7, 22)
        Me.ConnectionCheck_Enable_CheckBox.Name = "ConnectionCheck_Enable_CheckBox"
        Me.ConnectionCheck_Enable_CheckBox.Size = New System.Drawing.Size(95, 19)
        Me.ConnectionCheck_Enable_CheckBox.TabIndex = 0
        Me.ConnectionCheck_Enable_CheckBox.Text = "有効にする"
        Me.ConnectionCheck_Enable_CheckBox.UseVisualStyleBackColor = True
        '
        'WatcherSettings_GroupBox
        '
        Me.WatcherSettings_GroupBox.Controls.Add(Me.IncludeSubFolders_CheckBox)
        Me.WatcherSettings_GroupBox.Location = New System.Drawing.Point(0, 108)
        Me.WatcherSettings_GroupBox.Name = "WatcherSettings_GroupBox"
        Me.WatcherSettings_GroupBox.Size = New System.Drawing.Size(426, 48)
        Me.WatcherSettings_GroupBox.TabIndex = 5
        Me.WatcherSettings_GroupBox.TabStop = False
        Me.WatcherSettings_GroupBox.Text = "監視対象"
        '
        'IncludeSubFolders_CheckBox
        '
        Me.IncludeSubFolders_CheckBox.AutoSize = True
        Me.IncludeSubFolders_CheckBox.Checked = True
        Me.IncludeSubFolders_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.IncludeSubFolders_CheckBox.Location = New System.Drawing.Point(7, 22)
        Me.IncludeSubFolders_CheckBox.Name = "IncludeSubFolders_CheckBox"
        Me.IncludeSubFolders_CheckBox.Size = New System.Drawing.Size(156, 19)
        Me.IncludeSubFolders_CheckBox.TabIndex = 0
        Me.IncludeSubFolders_CheckBox.Text = "サブフォルダーも含める"
        Me.IncludeSubFolders_CheckBox.UseVisualStyleBackColor = True
        '
        'WatcherSettings_Panel
        '
        Me.WatcherSettings_Panel.Controls.Add(Me.WatcherSettings_GroupBox)
        Me.WatcherSettings_Panel.Controls.Add(Me.ConnectionCheckSettings_GroupBox)
        Me.WatcherSettings_Panel.Location = New System.Drawing.Point(143, 14)
        Me.WatcherSettings_Panel.Name = "WatcherSettings_Panel"
        Me.WatcherSettings_Panel.Size = New System.Drawing.Size(426, 295)
        Me.WatcherSettings_Panel.TabIndex = 5
        Me.WatcherSettings_Panel.Visible = False
        '
        'DefaultSettings_Panel
        '
        Me.DefaultSettings_Panel.Controls.Add(Me.DefaultSettings_GroupBox)
        Me.DefaultSettings_Panel.Location = New System.Drawing.Point(143, 14)
        Me.DefaultSettings_Panel.Name = "DefaultSettings_Panel"
        Me.DefaultSettings_Panel.Size = New System.Drawing.Size(426, 295)
        Me.DefaultSettings_Panel.TabIndex = 6
        '
        'DefaultSettings_GroupBox
        '
        Me.DefaultSettings_GroupBox.Controls.Add(Me.TextBox1)
        Me.DefaultSettings_GroupBox.Controls.Add(Me.TextBox2)
        Me.DefaultSettings_GroupBox.Controls.Add(Me.Label1)
        Me.DefaultSettings_GroupBox.Controls.Add(Me.Label2)
        Me.DefaultSettings_GroupBox.Controls.Add(Me.DestPath_TextBox)
        Me.DefaultSettings_GroupBox.Controls.Add(Me.DestPath_Label)
        Me.DefaultSettings_GroupBox.Controls.Add(Me.SourcePath_TextBox)
        Me.DefaultSettings_GroupBox.Controls.Add(Me.SourcePath_Label)
        Me.DefaultSettings_GroupBox.Controls.Add(Me.MDTMode_RadioButton)
        Me.DefaultSettings_GroupBox.Controls.Add(Me.NomalMode_RadioButton)
        Me.DefaultSettings_GroupBox.Location = New System.Drawing.Point(0, 0)
        Me.DefaultSettings_GroupBox.Name = "DefaultSettings_GroupBox"
        Me.DefaultSettings_GroupBox.Size = New System.Drawing.Size(426, 265)
        Me.DefaultSettings_GroupBox.TabIndex = 2
        Me.DefaultSettings_GroupBox.TabStop = False
        Me.DefaultSettings_GroupBox.Text = "メイン画面のデフォルト値"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(233, 236)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(233, 209)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 239)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "再試行の間隔(秒)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = " "
        '
        'DestPath_TextBox
        '
        Me.DestPath_TextBox.Location = New System.Drawing.Point(7, 113)
        Me.DestPath_TextBox.Multiline = True
        Me.DestPath_TextBox.Name = "DestPath_TextBox"
        Me.DestPath_TextBox.Size = New System.Drawing.Size(413, 22)
        Me.DestPath_TextBox.TabIndex = 1
        '
        'DestPath_Label
        '
        Me.DestPath_Label.AutoSize = True
        Me.DestPath_Label.Location = New System.Drawing.Point(6, 95)
        Me.DestPath_Label.Name = "DestPath_Label"
        Me.DestPath_Label.Size = New System.Drawing.Size(107, 15)
        Me.DestPath_Label.TabIndex = 8
        Me.DestPath_Label.Text = "転送先フォルダー"
        '
        'SourcePath_TextBox
        '
        Me.SourcePath_TextBox.Location = New System.Drawing.Point(7, 70)
        Me.SourcePath_TextBox.Multiline = True
        Me.SourcePath_TextBox.Name = "SourcePath_TextBox"
        Me.SourcePath_TextBox.Size = New System.Drawing.Size(413, 22)
        Me.SourcePath_TextBox.TabIndex = 1
        Me.SourcePath_TextBox.Text = "　"
        '
        'SourcePath_Label
        '
        Me.SourcePath_Label.AutoSize = True
        Me.SourcePath_Label.Location = New System.Drawing.Point(6, 52)
        Me.SourcePath_Label.Name = "SourcePath_Label"
        Me.SourcePath_Label.Size = New System.Drawing.Size(122, 15)
        Me.SourcePath_Label.TabIndex = 7
        Me.SourcePath_Label.Text = "監視対象フォルダー"
        '
        'MDTMode_RadioButton
        '
        Me.MDTMode_RadioButton.AutoSize = True
        Me.MDTMode_RadioButton.Location = New System.Drawing.Point(127, 22)
        Me.MDTMode_RadioButton.Name = "MDTMode_RadioButton"
        Me.MDTMode_RadioButton.Size = New System.Drawing.Size(92, 19)
        Me.MDTMode_RadioButton.TabIndex = 6
        Me.MDTMode_RadioButton.Text = "MDTモード"
        Me.MDTMode_RadioButton.UseVisualStyleBackColor = True
        '
        'NomalMode_RadioButton
        '
        Me.NomalMode_RadioButton.AutoSize = True
        Me.NomalMode_RadioButton.Checked = True
        Me.NomalMode_RadioButton.Location = New System.Drawing.Point(7, 22)
        Me.NomalMode_RadioButton.Name = "NomalMode_RadioButton"
        Me.NomalMode_RadioButton.Size = New System.Drawing.Size(107, 19)
        Me.NomalMode_RadioButton.TabIndex = 5
        Me.NomalMode_RadioButton.TabStop = True
        Me.NomalMode_RadioButton.Text = "ノーマルモード"
        Me.NomalMode_RadioButton.UseVisualStyleBackColor = True
        '
        'TransferSettings_Panel
        '
        Me.TransferSettings_Panel.Controls.Add(Me.SourceFileSettings_GroupBox)
        Me.TransferSettings_Panel.Controls.Add(Me.TransferSettings_GroupBox)
        Me.TransferSettings_Panel.Location = New System.Drawing.Point(143, 14)
        Me.TransferSettings_Panel.Name = "TransferSettings_Panel"
        Me.TransferSettings_Panel.Size = New System.Drawing.Size(426, 295)
        Me.TransferSettings_Panel.TabIndex = 7
        '
        'TransferSettings_GroupBox
        '
        Me.TransferSettings_GroupBox.Controls.Add(Me.TempPath_TextBox)
        Me.TransferSettings_GroupBox.Controls.Add(Me.TempFolder_Label)
        Me.TransferSettings_GroupBox.Controls.Add(Me.DirectlyTransfer_RadioButton)
        Me.TransferSettings_GroupBox.Controls.Add(Me.ViaTempFolder_RadioButton)
        Me.TransferSettings_GroupBox.Location = New System.Drawing.Point(0, 0)
        Me.TransferSettings_GroupBox.Name = "TransferSettings_GroupBox"
        Me.TransferSettings_GroupBox.Size = New System.Drawing.Size(426, 124)
        Me.TransferSettings_GroupBox.TabIndex = 2
        Me.TransferSettings_GroupBox.TabStop = False
        Me.TransferSettings_GroupBox.Text = "転送動作"
        '
        'TempPath_TextBox
        '
        Me.TempPath_TextBox.Location = New System.Drawing.Point(6, 88)
        Me.TempPath_TextBox.Multiline = True
        Me.TempPath_TextBox.Name = "TempPath_TextBox"
        Me.TempPath_TextBox.Size = New System.Drawing.Size(413, 22)
        Me.TempPath_TextBox.TabIndex = 1
        Me.TempPath_TextBox.Text = "C:\Transfer_Temp"
        '
        'TempFolder_Label
        '
        Me.TempFolder_Label.AutoSize = True
        Me.TempFolder_Label.Location = New System.Drawing.Point(5, 70)
        Me.TempFolder_Label.Name = "TempFolder_Label"
        Me.TempFolder_Label.Size = New System.Drawing.Size(97, 15)
        Me.TempFolder_Label.TabIndex = 7
        Me.TempFolder_Label.Text = "Tempフォルダー"
        '
        'DirectlyTransfer_RadioButton
        '
        Me.DirectlyTransfer_RadioButton.AutoSize = True
        Me.DirectlyTransfer_RadioButton.Location = New System.Drawing.Point(7, 45)
        Me.DirectlyTransfer_RadioButton.Name = "DirectlyTransfer_RadioButton"
        Me.DirectlyTransfer_RadioButton.Size = New System.Drawing.Size(112, 19)
        Me.DirectlyTransfer_RadioButton.TabIndex = 6
        Me.DirectlyTransfer_RadioButton.Text = "直接転送する"
        Me.DirectlyTransfer_RadioButton.UseVisualStyleBackColor = True
        '
        'ViaTempFolder_RadioButton
        '
        Me.ViaTempFolder_RadioButton.AutoSize = True
        Me.ViaTempFolder_RadioButton.Checked = True
        Me.ViaTempFolder_RadioButton.Location = New System.Drawing.Point(7, 22)
        Me.ViaTempFolder_RadioButton.Name = "ViaTempFolder_RadioButton"
        Me.ViaTempFolder_RadioButton.Size = New System.Drawing.Size(262, 19)
        Me.ViaTempFolder_RadioButton.TabIndex = 5
        Me.ViaTempFolder_RadioButton.TabStop = True
        Me.ViaTempFolder_RadioButton.Text = "Tempフォルダーにコピーしてから転送する"
        Me.ViaTempFolder_RadioButton.UseVisualStyleBackColor = True
        '
        'SourceFileSettings_GroupBox
        '
        Me.SourceFileSettings_GroupBox.Controls.Add(Me.MoveFilePath)
        Me.SourceFileSettings_GroupBox.Controls.Add(Me.MoveFile_RadioButton)
        Me.SourceFileSettings_GroupBox.Controls.Add(Me.DeleteFile_RadioButton)
        Me.SourceFileSettings_GroupBox.Controls.Add(Me.NoneProcess_RadioButton)
        Me.SourceFileSettings_GroupBox.Location = New System.Drawing.Point(0, 126)
        Me.SourceFileSettings_GroupBox.Name = "SourceFileSettings_GroupBox"
        Me.SourceFileSettings_GroupBox.Size = New System.Drawing.Size(426, 128)
        Me.SourceFileSettings_GroupBox.TabIndex = 3
        Me.SourceFileSettings_GroupBox.TabStop = False
        Me.SourceFileSettings_GroupBox.Text = "元のファイルの処理"
        '
        'MoveFilePath
        '
        Me.MoveFilePath.Location = New System.Drawing.Point(6, 91)
        Me.MoveFilePath.Multiline = True
        Me.MoveFilePath.Name = "MoveFilePath"
        Me.MoveFilePath.Size = New System.Drawing.Size(413, 22)
        Me.MoveFilePath.TabIndex = 1
        Me.MoveFilePath.Text = ".\済み"
        '
        'MoveFile_RadioButton
        '
        Me.MoveFile_RadioButton.AutoSize = True
        Me.MoveFile_RadioButton.Location = New System.Drawing.Point(7, 68)
        Me.MoveFile_RadioButton.Name = "MoveFile_RadioButton"
        Me.MoveFile_RadioButton.Size = New System.Drawing.Size(191, 19)
        Me.MoveFile_RadioButton.TabIndex = 6
        Me.MoveFile_RadioButton.Text = "以下のフォルダーに移動する"
        Me.MoveFile_RadioButton.UseVisualStyleBackColor = True
        '
        'NoneProcess_RadioButton
        '
        Me.NoneProcess_RadioButton.AutoSize = True
        Me.NoneProcess_RadioButton.Checked = True
        Me.NoneProcess_RadioButton.Location = New System.Drawing.Point(7, 22)
        Me.NoneProcess_RadioButton.Name = "NoneProcess_RadioButton"
        Me.NoneProcess_RadioButton.Size = New System.Drawing.Size(109, 19)
        Me.NoneProcess_RadioButton.TabIndex = 5
        Me.NoneProcess_RadioButton.TabStop = True
        Me.NoneProcess_RadioButton.Text = "そのままにする"
        Me.NoneProcess_RadioButton.UseVisualStyleBackColor = True
        '
        'DeleteFile_RadioButton
        '
        Me.DeleteFile_RadioButton.AutoSize = True
        Me.DeleteFile_RadioButton.Location = New System.Drawing.Point(7, 45)
        Me.DeleteFile_RadioButton.Name = "DeleteFile_RadioButton"
        Me.DeleteFile_RadioButton.Size = New System.Drawing.Size(82, 19)
        Me.DeleteFile_RadioButton.TabIndex = 8
        Me.DeleteFile_RadioButton.Text = "削除する"
        Me.DeleteFile_RadioButton.UseVisualStyleBackColor = True
        '
        'MDTModeSettings_Panel
        '
        Me.MDTModeSettings_Panel.Controls.Add(Me.GroupBox1)
        Me.MDTModeSettings_Panel.Controls.Add(Me.GroupBox2)
        Me.MDTModeSettings_Panel.Location = New System.Drawing.Point(143, 14)
        Me.MDTModeSettings_Panel.Name = "MDTModeSettings_Panel"
        Me.MDTModeSettings_Panel.Size = New System.Drawing.Size(426, 295)
        Me.MDTModeSettings_Panel.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(426, 159)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "dmpファイル転送時の設定"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(6, 131)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(413, 22)
        Me.TextBox3.TabIndex = 1
        Me.TextBox3.Text = "<Lot><Roll>\<更新日時>_<ドライブID>_<ファイル名>"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(426, 124)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MDT上の指定フォルダー"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(6, 88)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(413, 22)
        Me.TextBox4.TabIndex = 1
        Me.TextBox4.Text = "C:\bin\Inspect_Result"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "結果保存先"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(6, 41)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(413, 22)
        Me.TextBox5.TabIndex = 8
        Me.TextBox5.Text = "C:\bin\dump"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "dmpファイル保存先"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckBox3)
        Me.GroupBox3.Controls.Add(Me.CheckBox2)
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 18)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(417, 45)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "転送対象"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(7, 20)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(95, 19)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Calibration"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(110, 21)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(61, 19)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "Write"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(177, 21)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(72, 19)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "Unload"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "保存名規則"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(391, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "<更新日時>  <ドライブID>  <Lot>  <Roll>  <Slit>  <ファイル名>"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 15)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "指定可能な値"
        '
        'SettingsForm
        '
        Me.AcceptButton = Me.Apply_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(580, 363)
        Me.Controls.Add(Me.MDTModeSettings_Panel)
        Me.Controls.Add(Me.TransferSettings_Panel)
        Me.Controls.Add(Me.DefaultSettings_Panel)
        Me.Controls.Add(Me.WatcherSettings_Panel)
        Me.Controls.Add(Me.SettingsList)
        Me.Controls.Add(Me.TableLayoutPanel_for_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "設定"
        Me.TableLayoutPanel_for_Button.ResumeLayout(False)
        Me.ConnectionCheckSettings_GroupBox.ResumeLayout(False)
        Me.ConnectionCheckSettings_GroupBox.PerformLayout()
        Me.WatcherSettings_GroupBox.ResumeLayout(False)
        Me.WatcherSettings_GroupBox.PerformLayout()
        Me.WatcherSettings_Panel.ResumeLayout(False)
        Me.DefaultSettings_Panel.ResumeLayout(False)
        Me.DefaultSettings_GroupBox.ResumeLayout(False)
        Me.DefaultSettings_GroupBox.PerformLayout()
        Me.TransferSettings_Panel.ResumeLayout(False)
        Me.TransferSettings_GroupBox.ResumeLayout(False)
        Me.TransferSettings_GroupBox.PerformLayout()
        Me.SourceFileSettings_GroupBox.ResumeLayout(False)
        Me.SourceFileSettings_GroupBox.PerformLayout()
        Me.MDTModeSettings_Panel.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel_for_Button As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Apply_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents SettingsList As ListBox
    Friend WithEvents ConnectionCheckSettings_GroupBox As GroupBox
    Friend WithEvents ConnectionCheck_Enable_CheckBox As CheckBox
    Friend WithEvents ConnectionCheck_RetryCount_TextBox As TextBox
    Friend WithEvents ConnectionCheck_RetryCount_Label As Label
    Friend WithEvents ConnectionCheck_RetryInterval_TextBox As TextBox
    Friend WithEvents ConnectionCheck_RetryInterval_Label As Label
    Friend WithEvents WatcherSettings_GroupBox As GroupBox
    Friend WithEvents IncludeSubFolders_CheckBox As CheckBox
    Friend WithEvents WatcherSettings_Panel As Panel
    Friend WithEvents DefaultSettings_Panel As Panel
    Friend WithEvents DefaultSettings_GroupBox As GroupBox
    Friend WithEvents MDTMode_RadioButton As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NomalMode_RadioButton As RadioButton
    Friend WithEvents SourcePath_TextBox As TextBox
    Friend WithEvents DestPath_TextBox As TextBox
    Friend WithEvents DestPath_Label As Label
    Friend WithEvents SourcePath_Label As Label
    Friend WithEvents TransferSettings_Panel As Panel
    Friend WithEvents TransferSettings_GroupBox As GroupBox
    Friend WithEvents TempPath_TextBox As TextBox
    Friend WithEvents TempFolder_Label As Label
    Friend WithEvents DirectlyTransfer_RadioButton As RadioButton
    Friend WithEvents ViaTempFolder_RadioButton As RadioButton
    Friend WithEvents SourceFileSettings_GroupBox As GroupBox
    Friend WithEvents MoveFilePath As TextBox
    Friend WithEvents MoveFile_RadioButton As RadioButton
    Friend WithEvents DeleteFile_RadioButton As RadioButton
    Friend WithEvents NoneProcess_RadioButton As RadioButton
    Friend WithEvents MDTModeSettings_Panel As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
