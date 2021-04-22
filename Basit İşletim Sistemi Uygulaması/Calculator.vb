Public Class Calculator
    Public Const HT_CAPTION As Integer = &H2
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1

    Dim ilkislem As Integer
    Dim islem As String
    Dim sonislem As Integer
    Dim sonuc As Integer

    Private Sub GelişmişSistemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GelişmişSistemToolStripMenuItem.Click
        Me.Size = New Size(280, 280)
        TextBox1.Enabled = False
        TextBox1.Clear()
    End Sub

    Private Sub NormalSistemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NormalSistemToolStripMenuItem.Click
        Me.Size = New Size(280, 75)
        TextBox1.Enabled = True
        TextBox1.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ilkislem = TextBox1.Text
        islem = "*"
        TextBox1.Clear()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ilkislem = TextBox1.Text
        islem = "/"
        TextBox1.Clear()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ilkislem = TextBox1.Text
        islem = "+"
        TextBox1.Clear()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ilkislem = TextBox1.Text
        islem = "-"
        TextBox1.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text & "1"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text & "2"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text & "3"
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text & "4"
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text & "5"
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text & "6"
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        TextBox1.Text = TextBox1.Text & "7"
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        TextBox1.Text = TextBox1.Text & "8"
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        TextBox1.Text = TextBox1.Text & "9"
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click

        If islem = "*" Then
            sonislem = TextBox1.Text
            TextBox1.Text = ilkislem * sonislem
        End If


        If islem = "/" Then
            sonislem = TextBox1.Text
            TextBox1.Text = ilkislem / sonislem
        End If

        If islem = "+" Then
            sonislem = TextBox1.Text
            TextBox1.Text = Val(ilkislem) + Val(sonislem)
        End If

        If islem = "-" Then
            sonislem = TextBox1.Text
            TextBox1.Text = Val(ilkislem) - Val(sonislem)
        End If
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        TextBox1.Text = TextBox1.Text & "0"
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim ilk As Integer
        Dim son As Integer

        If Asc(e.KeyChar) = Keys.Enter Then

            If TextBox1.Text.Contains("*") Then

                Dim yazi = TextBox1.Text
                Dim sonuc = yazi.Split("*"c).First()
                Dim sayi As Decimal

                If Decimal.TryParse(yazi, System.Globalization.NumberStyles.Any, New System.Globalization.CultureInfo("tr-Tr"), sayi) Then
                    ilk = CInt(sayi)
                    son = TextBox1.Text.Split("*"c).First()

                    TextBox1.Text = ilk * son
                End If

            End If

            If TextBox1.Text.Contains("/") Then

                Dim yazi = TextBox1.Text
                Dim sonuc = yazi.Split("/"c).First()
                Dim sayi As Decimal

                If Decimal.TryParse(yazi, System.Globalization.NumberStyles.Any, New System.Globalization.CultureInfo("tr-Tr"), sayi) Then
                    ilk = CInt(sayi)
                    son = TextBox1.Text.Split("/"c).First()

                    TextBox1.Text = ilk / son
                End If

            End If

            If TextBox1.Text.Contains("+") Then

                Dim yazi = TextBox1.Text
                Dim sonuc = yazi.Split("+"c).First()
                Dim sayi As Decimal

                If Decimal.TryParse(yazi, System.Globalization.NumberStyles.Any, New System.Globalization.CultureInfo("tr-Tr"), sayi) Then
                    ilk = CInt(sayi)
                    son = TextBox1.Text.Split("+"c).First()

                    TextBox1.Text = ilk + son
                End If

            End If

            If TextBox1.Text.Contains("-") Then

                Dim yazi = TextBox1.Text
                Dim sonuc = yazi.Split("-"c).First()
                Dim sayi As Decimal

                If Decimal.TryParse(yazi, System.Globalization.NumberStyles.Any, New System.Globalization.CultureInfo("tr-Tr"), sayi) Then
                    ilk = CInt(sayi)
                    son = TextBox1.Text.Split("-"c).First()

                    TextBox1.Text = ilk - son
                End If

            End If

        End If
    End Sub

    Private Sub ToolStrip1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStrip1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
        End If

        Me.WndProc(Message.Create(Me.Handle, WM_NCLBUTTONDOWN, CType(HT_CAPTION, IntPtr), IntPtr.Zero))
    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        Me.Close()
    End Sub
End Class