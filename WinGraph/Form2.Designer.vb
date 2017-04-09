<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ファイルToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.開くToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.上書き保存ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.名前を付けて保存ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.終了ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.編集ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.元に戻すToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.切り取りToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.コピーToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.貼り付けToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.すべて選択ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルToolStripMenuItem, Me.編集ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(575, 26)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ファイルToolStripMenuItem
        '
        Me.ファイルToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.開くToolStripMenuItem, Me.上書き保存ToolStripMenuItem, Me.名前を付けて保存ToolStripMenuItem, Me.ToolStripSeparator1, Me.終了ToolStripMenuItem})
        Me.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem"
        Me.ファイルToolStripMenuItem.Size = New System.Drawing.Size(68, 22)
        Me.ファイルToolStripMenuItem.Text = "ファイル"
        '
        '開くToolStripMenuItem
        '
        Me.開くToolStripMenuItem.Name = "開くToolStripMenuItem"
        Me.開くToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.開くToolStripMenuItem.Text = "開く"
        '
        '上書き保存ToolStripMenuItem
        '
        Me.上書き保存ToolStripMenuItem.Name = "上書き保存ToolStripMenuItem"
        Me.上書き保存ToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.上書き保存ToolStripMenuItem.Text = "上書き保存"
        '
        '名前を付けて保存ToolStripMenuItem
        '
        Me.名前を付けて保存ToolStripMenuItem.Name = "名前を付けて保存ToolStripMenuItem"
        Me.名前を付けて保存ToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.名前を付けて保存ToolStripMenuItem.Text = "名前を付けて保存"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(169, 6)
        '
        '終了ToolStripMenuItem
        '
        Me.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem"
        Me.終了ToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.終了ToolStripMenuItem.Text = "終了"
        '
        '編集ToolStripMenuItem
        '
        Me.編集ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.元に戻すToolStripMenuItem, Me.ToolStripSeparator2, Me.切り取りToolStripMenuItem, Me.コピーToolStripMenuItem, Me.貼り付けToolStripMenuItem, Me.ToolStripSeparator3, Me.すべて選択ToolStripMenuItem})
        Me.編集ToolStripMenuItem.Name = "編集ToolStripMenuItem"
        Me.編集ToolStripMenuItem.Size = New System.Drawing.Size(44, 22)
        Me.編集ToolStripMenuItem.Text = "編集"
        '
        '元に戻すToolStripMenuItem
        '
        Me.元に戻すToolStripMenuItem.Name = "元に戻すToolStripMenuItem"
        Me.元に戻すToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.元に戻すToolStripMenuItem.Text = "元に戻す"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        '切り取りToolStripMenuItem
        '
        Me.切り取りToolStripMenuItem.Name = "切り取りToolStripMenuItem"
        Me.切り取りToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.切り取りToolStripMenuItem.Text = "切り取り"
        '
        'コピーToolStripMenuItem
        '
        Me.コピーToolStripMenuItem.Name = "コピーToolStripMenuItem"
        Me.コピーToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.コピーToolStripMenuItem.Text = "コピー"
        '
        '貼り付けToolStripMenuItem
        '
        Me.貼り付けToolStripMenuItem.Name = "貼り付けToolStripMenuItem"
        Me.貼り付けToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.貼り付けToolStripMenuItem.Text = "貼り付け"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        'すべて選択ToolStripMenuItem
        '
        Me.すべて選択ToolStripMenuItem.Name = "すべて選択ToolStripMenuItem"
        Me.すべて選択ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.すべて選択ToolStripMenuItem.Text = "すべて選択"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 29)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(551, 343)
        Me.TextBox1.TabIndex = 1
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 388)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "エディタ"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ファイルToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 開くToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 上書き保存ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 名前を付けて保存ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 終了ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 編集ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 元に戻すToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 切り取りToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents コピーToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 貼り付けToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents すべて選択ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
