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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.StartButton = New System.Windows.Forms.Button
        Me.ClearButton = New System.Windows.Forms.Button
        Me.DropFileBox = New System.Windows.Forms.Label
        Me.DataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridView_ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectAll_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SelectNone_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CheckBox = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.FilePath = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Measurement = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Format = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Gen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LotRoll = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TransPath = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataGridView_ContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(549, 12)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(98, 40)
        Me.StartButton.TabIndex = 1
        Me.StartButton.Text = "開始"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(653, 12)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(99, 40)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "クリア"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'DropFileBox
        '
        Me.DropFileBox.AllowDrop = True
        Me.DropFileBox.BackColor = System.Drawing.Color.Black
        Me.DropFileBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DropFileBox.Font = New System.Drawing.Font("MS UI Gothic", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DropFileBox.ForeColor = System.Drawing.Color.White
        Me.DropFileBox.Location = New System.Drawing.Point(12, 13)
        Me.DropFileBox.Name = "DropFileBox"
        Me.DropFileBox.Size = New System.Drawing.Size(531, 40)
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
        Me.DataGridView.ContextMenuStrip = Me.DataGridView_ContextMenuStrip
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView.Location = New System.Drawing.Point(12, 68)
        Me.DataGridView.MultiSelect = False
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.RowHeadersVisible = False
        Me.DataGridView.RowTemplate.Height = 21
        Me.DataGridView.ShowCellToolTips = False
        Me.DataGridView.ShowEditingIcon = False
        Me.DataGridView.Size = New System.Drawing.Size(740, 181)
        Me.DataGridView.TabIndex = 4
        '
        'DataGridView_ContextMenuStrip
        '
        Me.DataGridView_ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectAll_ToolStripMenuItem, Me.SelectNone_ToolStripMenuItem})
        Me.DataGridView_ContextMenuStrip.Name = "ContextMenuStrip"
        Me.DataGridView_ContextMenuStrip.ShowCheckMargin = True
        Me.DataGridView_ContextMenuStrip.ShowImageMargin = False
        Me.DataGridView_ContextMenuStrip.Size = New System.Drawing.Size(135, 48)
        '
        'SelectAll_ToolStripMenuItem
        '
        Me.SelectAll_ToolStripMenuItem.Name = "SelectAll_ToolStripMenuItem"
        Me.SelectAll_ToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.SelectAll_ToolStripMenuItem.Text = "全選択"
        '
        'SelectNone_ToolStripMenuItem
        '
        Me.SelectNone_ToolStripMenuItem.Name = "SelectNone_ToolStripMenuItem"
        Me.SelectNone_ToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.SelectNone_ToolStripMenuItem.Text = "全選択解除"
        '
        'CheckBox
        '
        Me.CheckBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CheckBox.ContextMenuStrip = Me.DataGridView_ContextMenuStrip
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
        Me.Measurement.ContextMenuStrip = Me.DataGridView_ContextMenuStrip
        Me.Measurement.HeaderText = "測定項目"
        Me.Measurement.Name = "Measurement"
        Me.Measurement.ReadOnly = True
        Me.Measurement.Width = 78
        '
        'Format
        '
        Me.Format.ContextMenuStrip = Me.DataGridView_ContextMenuStrip
        Me.Format.HeaderText = "フォーマット"
        Me.Format.Name = "Format"
        Me.Format.ReadOnly = True
        Me.Format.Width = 80
        '
        'Gen
        '
        Me.Gen.ContextMenuStrip = Me.DataGridView_ContextMenuStrip
        Me.Gen.HeaderText = "Gen"
        Me.Gen.Name = "Gen"
        Me.Gen.ReadOnly = True
        Me.Gen.Width = 50
        '
        'Type
        '
        Me.Type.ContextMenuStrip = Me.DataGridView_ContextMenuStrip
        Me.Type.HeaderText = "品種"
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        Me.Type.Width = 54
        '
        'LotRoll
        '
        Me.LotRoll.ContextMenuStrip = Me.DataGridView_ContextMenuStrip
        Me.LotRoll.HeaderText = "ロットロール"
        Me.LotRoll.Name = "LotRoll"
        Me.LotRoll.ReadOnly = True
        Me.LotRoll.Width = 83
        '
        'Status
        '
        Me.Status.ContextMenuStrip = Me.DataGridView_ContextMenuStrip
        Me.Status.HeaderText = "ステータス"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Width = 75
        '
        'TransPath
        '
        Me.TransPath.ContextMenuStrip = Me.DataGridView_ContextMenuStrip
        Me.TransPath.HeaderText = "転送先"
        Me.TransPath.Name = "TransPath"
        Me.TransPath.ReadOnly = True
        Me.TransPath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TransPath.Width = 47
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 261)
        Me.Controls.Add(Me.DropFileBox)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.StartButton)
        Me.MinimumSize = New System.Drawing.Size(574, 300)
        Me.Name = "Main"
        Me.Text = "Form1"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataGridView_ContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)

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

End Class
