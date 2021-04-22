Public Class OS

#Region "SÜRÜKLEME"
    Public Class DragInfo
        Public Property Farenin_ilk_Konumu As Point
        Public Property Baslama_Yeri As Point

        Public Sub New(ByVal MouseCoords As Point, ByVal Location As Point)
            Farenin_ilk_Konumu = MouseCoords
            Baslama_Yeri = Location
        End Sub

        Public Function NewLocation(ByVal MouseCoords As Point) As Point
            Dim yer As New Point(Baslama_Yeri.X + (MouseCoords.X - Farenin_ilk_Konumu.X), Baslama_Yeri.Y + (MouseCoords.Y - Farenin_ilk_Konumu.Y))
            Return yer
        End Function
    End Class
    Private Sub Sürükle(ByVal Control As Control)
        AddHandler Control.MouseDown, Sub(sender As Object, e As MouseEventArgs) StartDrag(Control)
        AddHandler Control.MouseMove, Sub(sender As Object, e As MouseEventArgs) Drag(Control)
        AddHandler Control.MouseUp, Sub(sender As Object, e As MouseEventArgs) StopDrag(Control)
    End Sub

    Private Sub StartDrag(ByVal Control As Control)
        Control.Tag = New DragInfo(Form.MousePosition, Control.Location)
    End Sub

    Private Sub Drag(ByVal Control As Control)
        If Control.Tag IsNot Nothing AndAlso TypeOf Control.Tag Is DragInfo Then
            Dim Bilgi As DragInfo = CType(Control.Tag, DragInfo)
            Dim Yeni_Yer As Point = Bilgi.NewLocation(Form.MousePosition)
            If Me.ClientRectangle.Contains(New Rectangle(Yeni_Yer, Control.Size)) Then Control.Location = Yeni_Yer
        End If
    End Sub

    Private Sub StopDrag(ByVal Control As Control)
        Control.Tag = Nothing
    End Sub
#End Region

    Dim tıklandı1 As Integer = 0

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If Panel1.Visible = False Then
            Panel1.Visible = True
        Else
            Panel1.Visible = False
        End If
    End Sub

    Private Sub saat_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saat.Tick
        Dim h As Integer
        Dim m As Integer
        Dim d As Integer
        Dim m2 As Integer
        Dim y As Integer

        h = Now.Hour
        m = Now.Minute
        d = Now.Day
        m2 = Now.Month
        y = Now.Year

        ToolStripLabel1.Text = h & ":" & m & vbNewLine & d & "." & m2 & "." & y
    End Sub

    Private Sub ToolStripLabel1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.MouseEnter
        ToolStripLabel1.ToolTipText = ToolStripLabel1.Text
    End Sub

    Private Sub OS_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Panel1.Visible = False
        tıklandı1 = 0
        PictureBox6.BackgroundImage = Nothing
    End Sub

    Private Sub OS_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Return
    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Size = New Size(70, 70)
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Size = New Size(50, 50)
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.Size = New Size(70, 70)
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Size = New Size(50, 50)
    End Sub

    Private Sub PictureBox3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Size = New Size(70, 70)
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Size = New Size(50, 50)
    End Sub

    Private Sub PictureBox4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.Size = New Size(70, 70)
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Size = New Size(50, 50)
    End Sub

    Private Sub cpuandmemory_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cpuandmemory.Tick
        Dim cpu As Integer = cpuinfo.NextValue
        Dim ram As Integer = raminfo.NextValue

        ProgressBar1.Value = cpu
        ProgressBar2.Value = ram
    End Sub

    Private Sub ProgressBar1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProgressBar1.MouseEnter
        Dim göster As New ToolTip

        göster.SetToolTip(ProgressBar1, ProgressBar1.Value & "%")
    End Sub

    Private Sub ProgressBar2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProgressBar2.MouseEnter
        Dim göster As New ToolTip

        göster.SetToolTip(ProgressBar2, ProgressBar2.Value & "%")
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Calculator.TopMost = True
        Calculator.Show()
    End Sub

    Private Sub OS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Sürükle(PictureBox6)
        Label1.Text = My.Settings.username
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Computer.Show()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        MsgBox("eklenmedi")
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        MsgBox("eklenmedi")
    End Sub

    Private Sub ResmiDeğiştirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResmiDeğiştirToolStripMenuItem.Click
        MsgBox("eklenmedi")
    End Sub

    Private Sub HesapAyarlarıToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HesapAyarlarıToolStripMenuItem.Click
        MsgBox("eklenmedi")
    End Sub

    Private Sub DenetimMasasıToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DenetimMasasıToolStripMenuItem.Click
        MsgBox("eklenmedi")
    End Sub

    Private Sub YenileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YenileToolStripMenuItem.Click
        Me.Refresh()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        tıklandı1 = 1
        PictureBox6.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox6.BackgroundImage = My.Resources.tıklandı
    End Sub

    Private Sub PictureBox6_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox6.DoubleClick
        MsgBox("eklenmedi")
    End Sub

    Private Sub PictureBox6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseEnter
        If tıklandı1 = 0 Then
            PictureBox6.BackgroundImageLayout = ImageLayout.Stretch
            PictureBox6.BackgroundImage = My.Resources.normal
        Else
            PictureBox6.BackgroundImageLayout = ImageLayout.Stretch
            PictureBox6.BackgroundImage = My.Resources.tıklandı
        End If
    End Sub

    Private Sub PictureBox6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseLeave
        If tıklandı1 = 0 Then
            PictureBox6.BackgroundImageLayout = ImageLayout.Stretch
            PictureBox6.BackgroundImage = My.Resources.normal
        Else
            PictureBox6.BackgroundImageLayout = ImageLayout.Stretch
            PictureBox6.BackgroundImage = My.Resources.tıklandı
        End If
    End Sub

    Private Sub OS_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        If tıklandı1 = 0 Then
            PictureBox6.BackgroundImage = Nothing
        Else
            PictureBox6.BackgroundImage = My.Resources.tıklandı
        End If
    End Sub
End Class