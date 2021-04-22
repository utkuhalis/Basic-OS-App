Public Class BlackScreen

    Private Sub BlackScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Loading1.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Text = "101" Then
            Timer1.Stop()
            OS.ShowDialog()
        End If
    End Sub
End Class