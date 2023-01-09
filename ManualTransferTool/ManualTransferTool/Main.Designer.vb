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

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.StartButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.DropFileBox = New System.Windows.Forms.Label()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.CheckBox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FilePath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Measurement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Format = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotRoll = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView_ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectAll_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectNone_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Label_ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Status_ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Spring_ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataGridView_ContextMenuStrip.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StartButton
        '
        Me.StartButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartButton.Location = New System.Drawing.Point(593, 15)
        Me.StartButton.Margin = New System.Windows.Forms.Padding(4)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(131, 50)
        Me.StartButton.TabIndex = 1
        Me.StartButton.Text = "開始"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearButton.Location = New System.Drawing.Point(731, 15)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(132, 50)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "クリア"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'DropFileBox
        '
        Me.DropFileBox.AllowDrop = True
        Me.DropFileBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DropFileBox.BackColor = System.Drawing.Color.Black
        Me.DropFileBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DropFileBox.Font = New System.Drawing.Font("MS UI Gothic", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DropFileBox.ForeColor = System.Drawing.Color.White
        Me.DropFileBox.Location = New System.Drawing.Point(16, 16)
        Me.DropFileBox.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DropFileBox.Name = "DropFileBox"
        Me.DropFileBox.Size = New System.Drawing.Size(569, 50)
        Me.DropFileBox.TabIndex = 3
        Me.DropFileBox.Text = "Please Drop ExcelFile or Folder"
        Me.DropFileBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.AllowUserToResizeRows = False
        Me.DataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CheckBox, Me.FilePath, Me.Measurement, Me.Format, Me.Gen, Me.Type, Me.LotRoll, Me.Status, Me.TransPath})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView.Location = New System.Drawing.Point(16, 85)
        Me.DataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView.MultiSelect = False
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.RowHeadersVisible = False
        Me.DataGridView.RowTemplate.Height = 21
        Me.DataGridView.ShowCellToolTips = False
        Me.DataGridView.ShowEditingIcon = False
        Me.DataGridView.Size = New System.Drawing.Size(849, 194)
        Me.DataGridView.TabIndex = 4
        '
        'CheckBox
        '
        Me.CheckBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CheckBox.Frozen = True
        Me.CheckBox.HeaderText = ""
        Me.CheckBox.MinimumWidth = 24
        Me.CheckBox.Name = "CheckBox"
        Me.CheckBox.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CheckBox.Width = 24
        '
        'FilePath
        '
        Me.FilePath.Frozen = True
        Me.FilePath.HeaderText = "ファイルのフルパス"
        Me.FilePath.Name = "FilePath"
        Me.FilePath.ReadOnly = True
        Me.FilePath.Visible = False
        Me.FilePath.Width = 92
        '
        'Measurement
        '
        Me.Measurement.HeaderText = "測定項目"
        Me.Measurement.Name = "Measurement"
        Me.Measurement.ReadOnly = True
        Me.Measurement.Width = 96
        '
        'Format
        '
        Me.Format.HeaderText = "フォーマット"
        Me.Format.Name = "Format"
        Me.Format.ReadOnly = True
        Me.Format.Width = 99
        '
        'Gen
        '
        Me.Gen.HeaderText = "Gen"
        Me.Gen.Name = "Gen"
        Me.Gen.ReadOnly = True
        Me.Gen.Width = 62
        '
        'Type
        '
        Me.Type.HeaderText = "品種"
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        Me.Type.Width = 66
        '
        'LotRoll
        '
        Me.LotRoll.HeaderText = "ロットロール"
        Me.LotRoll.Name = "LotRoll"
        Me.LotRoll.ReadOnly = True
        Me.LotRoll.Width = 102
        '
        'Status
        '
        Me.Status.HeaderText = "ステータス"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Width = 91
        '
        'TransPath
        '
        Me.TransPath.HeaderText = "転送先"
        Me.TransPath.MinimumWidth = 190
        Me.TransPath.Name = "TransPath"
        Me.TransPath.ReadOnly = True
        Me.TransPath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TransPath.Width = 190
        '
        'DataGridView_ContextMenuStrip
        '
        Me.DataGridView_ContextMenuStrip.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DataGridView_ContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.DataGridView_ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectAll_ToolStripMenuItem, Me.SelectNone_ToolStripMenuItem})
        Me.DataGridView_ContextMenuStrip.Name = "ContextMenuStrip"
        Me.DataGridView_ContextMenuStrip.ShowCheckMargin = True
        Me.DataGridView_ContextMenuStrip.ShowImageMargin = False
        Me.DataGridView_ContextMenuStrip.Size = New System.Drawing.Size(150, 48)
        '
        'SelectAll_ToolStripMenuItem
        '
        Me.SelectAll_ToolStripMenuItem.Name = "SelectAll_ToolStripMenuItem"
        Me.SelectAll_ToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.SelectAll_ToolStripMenuItem.Text = "全選択"
        '
        'SelectNone_ToolStripMenuItem
        '
        Me.SelectNone_ToolStripMenuItem.Name = "SelectNone_ToolStripMenuItem"
        Me.SelectNone_ToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.SelectNone_ToolStripMenuItem.Text = "全選択解除"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Label_ToolStripStatusLabel, Me.Status_ToolStripStatusLabel, Me.Spring_ToolStripStatusLabel, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 287)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(882, 26)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Label_ToolStripStatusLabel
        '
        Me.Label_ToolStripStatusLabel.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_ToolStripStatusLabel.Name = "Label_ToolStripStatusLabel"
        Me.Label_ToolStripStatusLabel.Size = New System.Drawing.Size(70, 21)
        Me.Label_ToolStripStatusLabel.Text = "ステータス："
        Me.Label_ToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Status_ToolStripStatusLabel
        '
        Me.Status_ToolStripStatusLabel.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Status_ToolStripStatusLabel.Name = "Status_ToolStripStatusLabel"
        Me.Status_ToolStripStatusLabel.Size = New System.Drawing.Size(67, 21)
        Me.Status_ToolStripStatusLabel.Text = "起動完了"
        Me.Status_ToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Spring_ToolStripStatusLabel
        '
        Me.Spring_ToolStripStatusLabel.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Spring_ToolStripStatusLabel.Name = "Spring_ToolStripStatusLabel"
        Me.Spring_ToolStripStatusLabel.Size = New System.Drawing.Size(590, 21)
        Me.Spring_ToolStripStatusLabel.Spring = True
        Me.Spring_ToolStripStatusLabel.Text = "0/0"
        Me.Spring_ToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(133, 20)
        Me.ToolStripProgressBar1.Step = 1
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 313)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.DropFileBox)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.StartButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(900, 360)
        Me.Name = "Main"
        Me.Text = "Form1"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataGridView_ContextMenuStrip.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents DropFileBox As System.Windows.Forms.Label
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView_ContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SelectAll_ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectNone_ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckBox As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FilePath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Measurement As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Format As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Gen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LotRoll As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransPath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Label_ToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents Status_ToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents Spring_ToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
End Class
