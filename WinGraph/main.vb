Public Class main
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
        Label1.Text = ""
        FileOpen(1, fName, OpenMode.Input)
        Do Until EOF(1)
            buf = LineInput(1)
            Label1.Text = buf
        Loop
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim buf As String
        Dim Data() = {}
        Dim i As Integer
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
        '   Label1.Text = ""
        'FileOpen(1, fName, OpenMode.Input)
        'Do Until EOF(1)
        '  buf = LineInput(i)
        '   i = i + 1
        '  Loop

        '      Label1.Text = buf
    End Sub
End Class