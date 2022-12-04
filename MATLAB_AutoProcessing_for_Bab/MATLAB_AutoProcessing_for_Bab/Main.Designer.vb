<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Menu_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Start_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Stop_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Separator_ToolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.Exit_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mode_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Jag4TDS_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DBOffset_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusTextLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_ToolStripMenuItem, Me.Mode_ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Menu_ToolStripMenuItem
        '
        Me.Menu_ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Start_ToolStripMenuItem, Me.Stop_ToolStripMenuItem, Me.Separator_ToolStripSeparator, Me.Exit_ToolStripMenuItem})
        Me.Menu_ToolStripMenuItem.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Menu_ToolStripMenuItem.Name = "Menu_ToolStripMenuItem"
        Me.Menu_ToolStripMenuItem.ShortcutKeyDisplayString = "M"
        Me.Menu_ToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.Menu_ToolStripMenuItem.Text = "メニュー"
        '
        'Start_ToolStripMenuItem
        '
        Me.Start_ToolStripMenuItem.Name = "Start_ToolStripMenuItem"
        Me.Start_ToolStripMenuItem.Size = New System.Drawing.Size(170, 26)
        Me.Start_ToolStripMenuItem.Text = "走行監視開始"
        '
        'Stop_ToolStripMenuItem
        '
        Me.Stop_ToolStripMenuItem.Enabled = False
        Me.Stop_ToolStripMenuItem.Name = "Stop_ToolStripMenuItem"
        Me.Stop_ToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.Stop_ToolStripMenuItem.Text = "走行監視停止"
        '
        'Separator_ToolStripSeparator
        '
        Me.Separator_ToolStripSeparator.Name = "Separator_ToolStripSeparator"
        Me.Separator_ToolStripSeparator.Size = New System.Drawing.Size(167, 6)
        '
        'Exit_ToolStripMenuItem
        '
        Me.Exit_ToolStripMenuItem.Name = "Exit_ToolStripMenuItem"
        Me.Exit_ToolStripMenuItem.Size = New System.Drawing.Size(170, 26)
        Me.Exit_ToolStripMenuItem.Text = "終了"
        '
        'Mode_ToolStripMenuItem
        '
        Me.Mode_ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Jag4TDS_ToolStripMenuItem, Me.DBOffset_ToolStripMenuItem})
        Me.Mode_ToolStripMenuItem.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Mode_ToolStripMenuItem.Name = "Mode_ToolStripMenuItem"
        Me.Mode_ToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.Mode_ToolStripMenuItem.Text = "モード"
        '
        'Jag4TDS_ToolStripMenuItem
        '
        Me.Jag4TDS_ToolStripMenuItem.Name = "Jag4TDS_ToolStripMenuItem"
        Me.Jag4TDS_ToolStripMenuItem.Size = New System.Drawing.Size(141, 26)
        Me.Jag4TDS_ToolStripMenuItem.Text = "Jag4TDS"
        '
        'DBOffset_ToolStripMenuItem
        '
        Me.DBOffset_ToolStripMenuItem.Name = "DBOffset_ToolStripMenuItem"
        Me.DBOffset_ToolStripMenuItem.Size = New System.Drawing.Size(141, 26)
        Me.DBOffset_ToolStripMenuItem.Text = "DBOffset"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.StatusTextLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(78, 20)
        Me.ToolStripStatusLabel1.Text = "ステータス："
        '
        'StatusTextLabel
        '
        Me.StatusTextLabel.Name = "StatusTextLabel"
        Me.StatusTextLabel.Size = New System.Drawing.Size(69, 20)
        Me.StatusTextLabel.Text = "起動完了"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 62)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(695, 22)
        Me.TextBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(713, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "走行監視対象フォルダ"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "SelectFolder"
        Me.SaveFileDialog1.Filter = "フォルダー|."
        Me.SaveFileDialog1.Title = "走行監視対象フォルダの選択"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "MATLAB自動処理ソフト for Bab Ver.1.0"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Menu_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Start_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Stop_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Separator_ToolStripSeparator As ToolStripSeparator
    Friend WithEvents Exit_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Mode_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Jag4TDS_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DBOffset_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents StatusTextLabel As ToolStripStatusLabel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
