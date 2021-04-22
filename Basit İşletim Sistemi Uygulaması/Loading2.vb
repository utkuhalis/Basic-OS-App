Public Class Loading2
    Dim say As Integer = 0
    Private Sub ac_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ac.Tick
        Me.Opacity += 0.1

        If Me.Opacity = 1.0 Then
            ac.Stop()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        say += 1

        If say = 10 Then
            Timer1.Stop()
            kapat.Start()
        End If
    End Sub

    Private Sub kapat_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kapat.Tick
        Me.Opacity -= 0.1

        If Me.Opacity = 0 Then
            kapat.Stop()
            Me.Close()
            BlackScreen.BackgroundImage = My.Resources.a6
            UserLogin.ShowDialog()
        End If
    End Sub
End Class