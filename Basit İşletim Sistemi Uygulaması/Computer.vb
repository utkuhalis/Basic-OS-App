Public Class Computer
    Public Const HT_CAPTION As Integer = &H2
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1

    Private Sub ToolStrip1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStrip1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
        End If

        Me.WndProc(Message.Create(Me.Handle, WM_NCLBUTTONDOWN, CType(HT_CAPTION, IntPtr), IntPtr.Zero))
    End Sub

    Private Sub Computer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Size = New Size(85, 80)
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Size = New Size(85, 75)
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.Size = New Size(85, 80)
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Size = New Size(85, 75)
    End Sub

    Private Sub Label5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label5.MouseEnter
        Label5.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub Label5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label5.MouseLeave
        Label5.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub Label6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label6.MouseEnter
        Label6.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub Label6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label6.MouseLeave
        Label6.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub Label7_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label7.MouseEnter
        Label7.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub Label7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label7.MouseLeave
        Label7.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub Label8_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label8.MouseEnter
        Label8.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub Label8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label8.MouseLeave
        Label8.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        MsgBox("eklenmedi")
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        MsgBox("eklenmedi")
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        MsgBox("eklenmedi")
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        MsgBox("eklenmedi")
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        MsgBox("eklenmedi")
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        MsgBox("eklenmedi")
    End Sub

    Private Sub DiskTemizleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiskTemizleToolStripMenuItem.Click
        MsgBox("eklenmedi")
    End Sub

    Private Sub DiskOnarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiskOnarToolStripMenuItem.Click
        MsgBox("eklenmedi")
    End Sub

    Private Sub DiskYönetimiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiskYönetimiToolStripMenuItem.Click
        MsgBox("eklenmedi")
    End Sub

    Private Sub DenetimMasasıToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DenetimMasasıToolStripMenuItem.Click
        MsgBox("eklenmedi")
    End Sub
End Class