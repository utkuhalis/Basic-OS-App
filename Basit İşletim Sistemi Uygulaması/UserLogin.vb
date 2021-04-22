Public Class UserLogin

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label3.Text = Now.Hour & ":" & Now.Minute & " - " & Now.Day & "." & Now.Month & "." & Now.Year
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Settings.username And TextBox2.Text = My.Settings.userpassword Then
            MsgBox("Hoş Geldiniz, " & My.Settings.username, MsgBoxStyle.Information)
            Me.Close()
            BlackScreen.Text = "101"
        Else
            MsgBox("Yanlış bilgi girildi." & vbNewLine & "Kullanıcı Adı : ÖrnekKullanıcı" & vbNewLine & "Kullanıcı Şifresi: 123456", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub UserLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.BackColor = Color.Transparent
    End Sub
End Class