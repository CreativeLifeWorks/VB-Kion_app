Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim grph As Graphics = PictureBox1.CreateGraphics
        Dim mypen As New Pen(Color.Black, 4)
        Dim mybrush As New SolidBrush(Color.Red)

        grph.DrawLine(mypen, 10, 10, 10, 80)
        grph.DrawLine(mypen, 10, 80, 80, 80)
        grph.DrawLine(mypen, 10, 10, 80, 80)

        mypen.Color = Color.Blue
        mypen.Width = 3
        grph.DrawEllipse(mypen, 90, 10, 70, 70)

        mypen.Color = Color.Cyan
        mypen.Width = 2
        grph.DrawEllipse(mypen, 170, 20, 70, 50)

        mypen.Color = Color.Green
        mypen.Width = 1
        grph.DrawEllipse(mypen, 250, 10, 70, 70)

        grph.FillRectangle(mybrush, 330, 10, 70, 70)

    End Sub
End Class
