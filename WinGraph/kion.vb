Public Class kion

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim t As Date = Now
        lbdate.Text = Format(t, "yyyy年M月dd日 HH時mm分ss秒")
    End Sub
End Class