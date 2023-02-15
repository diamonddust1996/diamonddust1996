<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDTMode_Form
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SelectFolderDialog = New WK.Libraries.BetterFolderBrowserNS.BetterFolderBrowser(Me.components)
        Me.Watcher = New System.IO.FileSystemWatcher()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Menu_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Start_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Stop_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Exit_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SourceSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ネットワーク接続確認を有効ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.サブフォルダーも含めるToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransferSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.転送動作ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.一時フォルダにコピーしてから転送ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.直接転送ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MD5方式ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SHA1方式ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SHA1方式でベリファイToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.元のファイルを削除するToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.指定したフォルダに移動するToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusTextLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusText = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer_Flame = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer_Horizontal1_3 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer_Vertical1 = New System.Windows.Forms.SplitContainer()
        Me.SourcePath_Button = New System.Windows.Forms.Button()
        Me.SourcePath_TextBox = New System.Windows.Forms.TextBox()
        Me.SplitContainer_Horizontal2_3 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer_Vertical2 = New System.Windows.Forms.SplitContainer()
        Me.DestPath_Button = New System.Windows.Forms.Button()
        Me.DestPath_TextBox = New System.Windows.Forms.TextBox()
        Me.SplitContainer_Vertical3 = New System.Windows.Forms.SplitContainer()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        CType(Me.Watcher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SplitContainer_Flame.Panel2.SuspendLayout()
        Me.SplitContainer_Flame.SuspendLayout()
        Me.SplitContainer_Horizontal1_3.Panel1.SuspendLayout()
        Me.SplitContainer_Horizontal1_3.Panel2.SuspendLayout()
        Me.SplitContainer_Horizontal1_3.SuspendLayout()
        Me.SplitContainer_Vertical1.Panel1.SuspendLayout()
        Me.SplitContainer_Vertical1.Panel2.SuspendLayout()
        Me.SplitContainer_Vertical1.SuspendLayout()
        Me.SplitContainer_Horizontal2_3.Panel1.SuspendLayout()
        Me.SplitContainer_Horizontal2_3.Panel2.SuspendLayout()
        Me.SplitContainer_Horizontal2_3.SuspendLayout()
        Me.SplitContainer_Vertical2.Panel1.SuspendLayout()
        Me.SplitContainer_Vertical2.Panel2.SuspendLayout()
        Me.SplitContainer_Vertical2.SuspendLayout()
        Me.SplitContainer_Vertical3.Panel2.SuspendLayout()
        Me.SplitContainer_Vertical3.SuspendLayout()
        Me.SuspendLayout()
        '
        'SelectFolderDialog
        '
        Me.SelectFolderDialog.Multiselect = False
        Me.SelectFolderDialog.RootFolder = "System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)"
        Me.SelectFolderDialog.Title = "Please select a folder..."
        '
        'Watcher
        '
        Me.Watcher.EnableRaisingEvents = True
        Me.Watcher.SynchronizingObject = Me
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStrip1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_ToolStripMenuItem, Me.SourceSettingsToolStripMenuItem, Me.TransferSettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(782, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Menu_ToolStripMenuItem
        '
        Me.Menu_ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Start_ToolStripMenuItem, Me.Stop_ToolStripMenuItem, Me.ToolStripSeparator1, Me.Exit_ToolStripMenuItem})
        Me.Menu_ToolStripMenuItem.Name = "Menu_ToolStripMenuItem"
        Me.Menu_ToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.Menu_ToolStripMenuItem.Text = "メニュー"
        '
        'Start_ToolStripMenuItem
        '
        Me.Start_ToolStripMenuItem.Name = "Start_ToolStripMenuItem"
        Me.Start_ToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.Start_ToolStripMenuItem.Text = "監視開始"
        '
        'Stop_ToolStripMenuItem
        '
        Me.Stop_ToolStripMenuItem.Enabled = False
        Me.Stop_ToolStripMenuItem.Name = "Stop_ToolStripMenuItem"
        Me.Stop_ToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.Stop_ToolStripMenuItem.Text = "監視停止"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(137, 6)
        '
        'Exit_ToolStripMenuItem
        '
        Me.Exit_ToolStripMenuItem.Name = "Exit_ToolStripMenuItem"
        Me.Exit_ToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.Exit_ToolStripMenuItem.Text = "終了"
        '
        'SourceSettingsToolStripMenuItem
        '
        Me.SourceSettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ネットワーク接続確認を有効ToolStripMenuItem, Me.サブフォルダーも含めるToolStripMenuItem})
        Me.SourceSettingsToolStripMenuItem.Name = "SourceSettingsToolStripMenuItem"
        Me.SourceSettingsToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.SourceSettingsToolStripMenuItem.Text = "監視設定"
        '
        'ネットワーク接続確認を有効ToolStripMenuItem
        '
        Me.ネットワーク接続確認を有効ToolStripMenuItem.Checked = True
        Me.ネットワーク接続確認を有効ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ネットワーク接続確認を有効ToolStripMenuItem.Name = "ネットワーク接続確認を有効ToolStripMenuItem"
        Me.ネットワーク接続確認を有効ToolStripMenuItem.Size = New System.Drawing.Size(240, 26)
        Me.ネットワーク接続確認を有効ToolStripMenuItem.Text = "ネットワーク接続確認を行う"
        '
        'サブフォルダーも含めるToolStripMenuItem
        '
        Me.サブフォルダーも含めるToolStripMenuItem.Checked = True
        Me.サブフォルダーも含めるToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.サブフォルダーも含めるToolStripMenuItem.Name = "サブフォルダーも含めるToolStripMenuItem"
        Me.サブフォルダーも含めるToolStripMenuItem.Size = New System.Drawing.Size(240, 26)
        Me.サブフォルダーも含めるToolStripMenuItem.Text = "サブフォルダーも含める"
        '
        'TransferSettingsToolStripMenuItem
        '
        Me.TransferSettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.転送動作ToolStripMenuItem, Me.ToolStripMenuItem1, Me.SHA1方式でベリファイToolStripMenuItem})
        Me.TransferSettingsToolStripMenuItem.Name = "TransferSettingsToolStripMenuItem"
        Me.TransferSettingsToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.TransferSettingsToolStripMenuItem.Text = "転送設定"
        '
        '転送動作ToolStripMenuItem
        '
        Me.転送動作ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.一時フォルダにコピーしてから転送ToolStripMenuItem, Me.直接転送ToolStripMenuItem})
        Me.転送動作ToolStripMenuItem.Name = "転送動作ToolStripMenuItem"
        Me.転送動作ToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.転送動作ToolStripMenuItem.Text = "転送動作"
        '
        '一時フォルダにコピーしてから転送ToolStripMenuItem
        '
        Me.一時フォルダにコピーしてから転送ToolStripMenuItem.Checked = True
        Me.一時フォルダにコピーしてから転送ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.一時フォルダにコピーしてから転送ToolStripMenuItem.Name = "一時フォルダにコピーしてから転送ToolStripMenuItem"
        Me.一時フォルダにコピーしてから転送ToolStripMenuItem.Size = New System.Drawing.Size(285, 26)
        Me.一時フォルダにコピーしてから転送ToolStripMenuItem.Text = "一時フォルダーにコピーしてから転送"
        '
        '直接転送ToolStripMenuItem
        '
        Me.直接転送ToolStripMenuItem.Name = "直接転送ToolStripMenuItem"
        Me.直接転送ToolStripMenuItem.Size = New System.Drawing.Size(285, 26)
        Me.直接転送ToolStripMenuItem.Text = "直接転送"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MD5方式ToolStripMenuItem, Me.SHA1方式ToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(181, 26)
        Me.ToolStripMenuItem1.Text = "ベリファイ"
        '
        'MD5方式ToolStripMenuItem
        '
        Me.MD5方式ToolStripMenuItem.Checked = True
        Me.MD5方式ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MD5方式ToolStripMenuItem.Name = "MD5方式ToolStripMenuItem"
        Me.MD5方式ToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.MD5方式ToolStripMenuItem.Text = "MD5方式"
        '
        'SHA1方式ToolStripMenuItem
        '
        Me.SHA1方式ToolStripMenuItem.Checked = True
        Me.SHA1方式ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SHA1方式ToolStripMenuItem.Name = "SHA1方式ToolStripMenuItem"
        Me.SHA1方式ToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.SHA1方式ToolStripMenuItem.Text = "SHA-1方式"
        '
        'SHA1方式でベリファイToolStripMenuItem
        '
        Me.SHA1方式でベリファイToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.元のファイルを削除するToolStripMenuItem, Me.指定したフォルダに移動するToolStripMenuItem})
        Me.SHA1方式でベリファイToolStripMenuItem.Name = "SHA1方式でベリファイToolStripMenuItem"
        Me.SHA1方式でベリファイToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.SHA1方式でベリファイToolStripMenuItem.Text = "元ファイルの処理"
        '
        '元のファイルを削除するToolStripMenuItem
        '
        Me.元のファイルを削除するToolStripMenuItem.Name = "元のファイルを削除するToolStripMenuItem"
        Me.元のファイルを削除するToolStripMenuItem.Size = New System.Drawing.Size(254, 26)
        Me.元のファイルを削除するToolStripMenuItem.Text = "削除する"
        '
        '指定したフォルダに移動するToolStripMenuItem
        '
        Me.指定したフォルダに移動するToolStripMenuItem.Checked = True
        Me.指定したフォルダに移動するToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.指定したフォルダに移動するToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1})
        Me.指定したフォルダに移動するToolStripMenuItem.Name = "指定したフォルダに移動するToolStripMenuItem"
        Me.指定したフォルダに移動するToolStripMenuItem.Size = New System.Drawing.Size(254, 26)
        Me.指定したフォルダに移動するToolStripMenuItem.Text = "指定したフォルダーに移動する"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 27)
        Me.ToolStripTextBox1.Text = ".\済み"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Snow
        Me.StatusStrip1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusTextLabel, Me.StatusText})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 379)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 33, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(782, 24)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusTextLabel
        '
        Me.StatusTextLabel.Name = "StatusTextLabel"
        Me.StatusTextLabel.Size = New System.Drawing.Size(70, 17)
        Me.StatusTextLabel.Text = "ステータス："
        '
        'StatusText
        '
        Me.StatusText.Name = "StatusText"
        Me.StatusText.Size = New System.Drawing.Size(67, 17)
        Me.StatusText.Text = "起動完了"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.SplitContainer_Flame)
        Me.Panel1.Location = New System.Drawing.Point(12, 40)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(755, 326)
        Me.Panel1.TabIndex = 3
        '
        'SplitContainer_Flame
        '
        Me.SplitContainer_Flame.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_Flame.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer_Flame.IsSplitterFixed = True
        Me.SplitContainer_Flame.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer_Flame.Margin = New System.Windows.Forms.Padding(0)
        Me.SplitContainer_Flame.Name = "SplitContainer_Flame"
        Me.SplitContainer_Flame.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.SplitContainer_Flame.Panel1Collapsed = True
        Me.SplitContainer_Flame.Panel1MinSize = 0
        '
        'SplitContainer_Flame.Panel2
        '
        Me.SplitContainer_Flame.Panel2.Controls.Add(Me.SplitContainer_Horizontal1_3)
        Me.SplitContainer_Flame.Panel2MinSize = 18
        Me.SplitContainer_Flame.Size = New System.Drawing.Size(755, 326)
        Me.SplitContainer_Flame.SplitterDistance = 0
        Me.SplitContainer_Flame.SplitterWidth = 10
        Me.SplitContainer_Flame.TabIndex = 2
        '
        'SplitContainer_Horizontal1_3
        '
        Me.SplitContainer_Horizontal1_3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_Horizontal1_3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer_Horizontal1_3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer_Horizontal1_3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SplitContainer_Horizontal1_3.Name = "SplitContainer_Horizontal1_3"
        Me.SplitContainer_Horizontal1_3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer_Horizontal1_3.Panel1
        '
        Me.SplitContainer_Horizontal1_3.Panel1.Controls.Add(Me.SplitContainer_Vertical1)
        Me.SplitContainer_Horizontal1_3.Panel1MinSize = 18
        '
        'SplitContainer_Horizontal1_3.Panel2
        '
        Me.SplitContainer_Horizontal1_3.Panel2.Controls.Add(Me.SplitContainer_Horizontal2_3)
        Me.SplitContainer_Horizontal1_3.Panel2MinSize = 18
        Me.SplitContainer_Horizontal1_3.Size = New System.Drawing.Size(755, 326)
        Me.SplitContainer_Horizontal1_3.SplitterDistance = 18
        Me.SplitContainer_Horizontal1_3.SplitterWidth = 10
        Me.SplitContainer_Horizontal1_3.TabIndex = 0
        '
        'SplitContainer_Vertical1
        '
        Me.SplitContainer_Vertical1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_Vertical1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer_Vertical1.IsSplitterFixed = True
        Me.SplitContainer_Vertical1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer_Vertical1.Margin = New System.Windows.Forms.Padding(0)
        Me.SplitContainer_Vertical1.Name = "SplitContainer_Vertical1"
        '
        'SplitContainer_Vertical1.Panel1
        '
        Me.SplitContainer_Vertical1.Panel1.Controls.Add(Me.SourcePath_Button)
        Me.SplitContainer_Vertical1.Panel1MinSize = 108
        '
        'SplitContainer_Vertical1.Panel2
        '
        Me.SplitContainer_Vertical1.Panel2.Controls.Add(Me.SourcePath_TextBox)
        Me.SplitContainer_Vertical1.Panel2MinSize = 0
        Me.SplitContainer_Vertical1.Size = New System.Drawing.Size(755, 18)
        Me.SplitContainer_Vertical1.SplitterDistance = 108
        Me.SplitContainer_Vertical1.SplitterWidth = 11
        Me.SplitContainer_Vertical1.TabIndex = 0
        '
        'SourcePath_Button
        '
        Me.SourcePath_Button.Location = New System.Drawing.Point(0, -1)
        Me.SourcePath_Button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SourcePath_Button.Name = "SourcePath_Button"
        Me.SourcePath_Button.Size = New System.Drawing.Size(144, 25)
        Me.SourcePath_Button.TabIndex = 0
        Me.SourcePath_Button.Text = "監視対象フォルダー"
        Me.SourcePath_Button.UseCompatibleTextRendering = True
        Me.SourcePath_Button.UseVisualStyleBackColor = True
        '
        'SourcePath_TextBox
        '
        Me.SourcePath_TextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SourcePath_TextBox.Location = New System.Drawing.Point(0, 0)
        Me.SourcePath_TextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SourcePath_TextBox.Multiline = True
        Me.SourcePath_TextBox.Name = "SourcePath_TextBox"
        Me.SourcePath_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.SourcePath_TextBox.Size = New System.Drawing.Size(636, 18)
        Me.SourcePath_TextBox.TabIndex = 0
        '
        'SplitContainer_Horizontal2_3
        '
        Me.SplitContainer_Horizontal2_3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_Horizontal2_3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer_Horizontal2_3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer_Horizontal2_3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SplitContainer_Horizontal2_3.Name = "SplitContainer_Horizontal2_3"
        Me.SplitContainer_Horizontal2_3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer_Horizontal2_3.Panel1
        '
        Me.SplitContainer_Horizontal2_3.Panel1.Controls.Add(Me.SplitContainer_Vertical2)
        Me.SplitContainer_Horizontal2_3.Panel1MinSize = 18
        '
        'SplitContainer_Horizontal2_3.Panel2
        '
        Me.SplitContainer_Horizontal2_3.Panel2.Controls.Add(Me.SplitContainer_Vertical3)
        Me.SplitContainer_Horizontal2_3.Panel2MinSize = 0
        Me.SplitContainer_Horizontal2_3.Size = New System.Drawing.Size(755, 298)
        Me.SplitContainer_Horizontal2_3.SplitterDistance = 18
        Me.SplitContainer_Horizontal2_3.SplitterWidth = 10
        Me.SplitContainer_Horizontal2_3.TabIndex = 0
        '
        'SplitContainer_Vertical2
        '
        Me.SplitContainer_Vertical2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_Vertical2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer_Vertical2.IsSplitterFixed = True
        Me.SplitContainer_Vertical2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer_Vertical2.Margin = New System.Windows.Forms.Padding(0)
        Me.SplitContainer_Vertical2.Name = "SplitContainer_Vertical2"
        '
        'SplitContainer_Vertical2.Panel1
        '
        Me.SplitContainer_Vertical2.Panel1.Controls.Add(Me.DestPath_Button)
        Me.SplitContainer_Vertical2.Panel1MinSize = 108
        '
        'SplitContainer_Vertical2.Panel2
        '
        Me.SplitContainer_Vertical2.Panel2.Controls.Add(Me.DestPath_TextBox)
        Me.SplitContainer_Vertical2.Panel2MinSize = 0
        Me.SplitContainer_Vertical2.Size = New System.Drawing.Size(755, 18)
        Me.SplitContainer_Vertical2.SplitterDistance = 108
        Me.SplitContainer_Vertical2.SplitterWidth = 11
        Me.SplitContainer_Vertical2.TabIndex = 0
        '
        'DestPath_Button
        '
        Me.DestPath_Button.Location = New System.Drawing.Point(0, -1)
        Me.DestPath_Button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DestPath_Button.Name = "DestPath_Button"
        Me.DestPath_Button.Size = New System.Drawing.Size(144, 25)
        Me.DestPath_Button.TabIndex = 1
        Me.DestPath_Button.Text = "転送先フォルダー"
        Me.DestPath_Button.UseCompatibleTextRendering = True
        Me.DestPath_Button.UseVisualStyleBackColor = True
        '
        'DestPath_TextBox
        '
        Me.DestPath_TextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DestPath_TextBox.Location = New System.Drawing.Point(0, 0)
        Me.DestPath_TextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DestPath_TextBox.Multiline = True
        Me.DestPath_TextBox.Name = "DestPath_TextBox"
        Me.DestPath_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.DestPath_TextBox.Size = New System.Drawing.Size(636, 18)
        Me.DestPath_TextBox.TabIndex = 1
        '
        'SplitContainer_Vertical3
        '
        Me.SplitContainer_Vertical3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_Vertical3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer_Vertical3.IsSplitterFixed = True
        Me.SplitContainer_Vertical3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer_Vertical3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SplitContainer_Vertical3.Name = "SplitContainer_Vertical3"
        Me.SplitContainer_Vertical3.Panel1MinSize = 108
        '
        'SplitContainer_Vertical3.Panel2
        '
        Me.SplitContainer_Vertical3.Panel2.Controls.Add(Me.TextBox3)
        Me.SplitContainer_Vertical3.Panel2MinSize = 0
        Me.SplitContainer_Vertical3.Size = New System.Drawing.Size(755, 270)
        Me.SplitContainer_Vertical3.SplitterDistance = 108
        Me.SplitContainer_Vertical3.SplitterWidth = 11
        Me.SplitContainer_Vertical3.TabIndex = 0
        '
        'TextBox3
        '
        Me.TextBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox3.Location = New System.Drawing.Point(0, 0)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox3.Size = New System.Drawing.Size(636, 270)
        Me.TextBox3.TabIndex = 2
        '
        'MDTMode_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(782, 403)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "MDTMode_Form"
        Me.Text = "MDTMode_Form"
        CType(Me.Watcher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer_Flame.Panel2.ResumeLayout(False)
        Me.SplitContainer_Flame.ResumeLayout(False)
        Me.SplitContainer_Horizontal1_3.Panel1.ResumeLayout(False)
        Me.SplitContainer_Horizontal1_3.Panel2.ResumeLayout(False)
        Me.SplitContainer_Horizontal1_3.ResumeLayout(False)
        Me.SplitContainer_Vertical1.Panel1.ResumeLayout(False)
        Me.SplitContainer_Vertical1.Panel2.ResumeLayout(False)
        Me.SplitContainer_Vertical1.Panel2.PerformLayout()
        Me.SplitContainer_Vertical1.ResumeLayout(False)
        Me.SplitContainer_Horizontal2_3.Panel1.ResumeLayout(False)
        Me.SplitContainer_Horizontal2_3.Panel2.ResumeLayout(False)
        Me.SplitContainer_Horizontal2_3.ResumeLayout(False)
        Me.SplitContainer_Vertical2.Panel1.ResumeLayout(False)
        Me.SplitContainer_Vertical2.Panel2.ResumeLayout(False)
        Me.SplitContainer_Vertical2.Panel2.PerformLayout()
        Me.SplitContainer_Vertical2.ResumeLayout(False)
        Me.SplitContainer_Vertical3.Panel2.ResumeLayout(False)
        Me.SplitContainer_Vertical3.Panel2.PerformLayout()
        Me.SplitContainer_Vertical3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SelectFolderDialog As WK.Libraries.BetterFolderBrowserNS.BetterFolderBrowser
    Friend WithEvents Watcher As IO.FileSystemWatcher
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Menu_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Start_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Stop_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Exit_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SourceSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ネットワーク接続確認を有効ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents サブフォルダーも含めるToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransferSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 転送動作ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 一時フォルダにコピーしてから転送ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 直接転送ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MD5方式ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SHA1方式ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SHA1方式でベリファイToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 元のファイルを削除するToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 指定したフォルダに移動するToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatusTextLabel As ToolStripStatusLabel
    Friend WithEvents StatusText As ToolStripStatusLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer_Flame As SplitContainer
    Friend WithEvents SplitContainer_Horizontal1_3 As SplitContainer
    Friend WithEvents SplitContainer_Vertical1 As SplitContainer
    Friend WithEvents SourcePath_Button As Button
    Friend WithEvents SourcePath_TextBox As TextBox
    Friend WithEvents SplitContainer_Horizontal2_3 As SplitContainer
    Friend WithEvents SplitContainer_Vertical2 As SplitContainer
    Friend WithEvents DestPath_Button As Button
    Friend WithEvents DestPath_TextBox As TextBox
    Friend WithEvents SplitContainer_Vertical3 As SplitContainer
    Friend WithEvents TextBox3 As TextBox
End Class
