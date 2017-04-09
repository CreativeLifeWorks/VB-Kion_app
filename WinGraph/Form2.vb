Public Class Form2
    Dim fName As String
    Private Sub 開くToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 開くToolStripMenuItem.Click
        Dim buf As String
        With OpenFileDialog1
            .FileName = ""
            .Filter = "テキストファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*"
            .FilterIndex = 1
            .ShowDialog()
            If .FileName = "" Then
                Exit Sub
            Else
                fName = .FileName
            End If

        End With
        TextBox1.Text = ""
        FileOpen(1, fName, OpenMode.Input)
        Do Until EOF(1)
            buf = LineInput(1)
            TextBox1.Text = TextBox1.Text & buf & vbCrLf
        Loop
    End Sub

    Private Sub 上書き保存ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 上書き保存ToolStripMenuItem.Click
        FileOpen(1, fName, OpenMode.Input)
        Print(1, TextBox1.Text)
        FileClose()
    End Sub

    Private Sub 名前を付けて保存ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 名前を付けて保存ToolStripMenuItem.Click
        With SaveFileDialog1
            .FileName = ""
            .Filter = "テキストファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*"
            .FilterIndex = 1
            .OverwritePrompt = True
            .ShowDialog()
            fName = .FileName
        End With
        If fName = "" Then
            Exit Sub
        End If
        FileOpen(1, fName, OpenMode.Output)
        Print(1, TextBox1.Text)
        FileClose()
    End Sub

    Private Sub 終了ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 終了ToolStripMenuItem.Click
        End
    End Sub

    Private Sub 元に戻すToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 元に戻すToolStripMenuItem.Click
        TextBox1.Undo()
    End Sub

    Private Sub 切り取りToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 切り取りToolStripMenuItem.Click
        TextBox1.Copy()
        TextBox1.SelectedText = ""
    End Sub

    Private Sub コピーToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles コピーToolStripMenuItem.Click
        TextBox1.Copy()
    End Sub

    Private Sub 貼り付けToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 貼り付けToolStripMenuItem.Click
        TextBox1.Paste()
    End Sub

    Private Sub すべて選択ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles すべて選択ToolStripMenuItem.Click
        TextBox1.SelectAll()
    End Sub

   
End Class