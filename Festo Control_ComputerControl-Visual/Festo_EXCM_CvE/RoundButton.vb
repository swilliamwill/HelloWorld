Class RoundButton
    Inherits System.Windows.Forms.Button

    Public BorderColor As Color = Color.LightGray
    Public BorderSize As Integer = 5

    Public Sub New()
        FlatStyle = FlatStyle.Flat

        'BackColor = Color.White
        'BackColor = _BackColor

        FlatAppearance.BorderColor = BorderColor
        FlatAppearance.BorderSize = BorderSize
        'Font = New System.Drawing.Font("VAGRounded-Light", 30.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, (CByte((0))))
        ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((84)))))), (CInt(((CByte((33)))))), (CInt(((CByte((107)))))))

    End Sub

    Private Sub ButtonLastest_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((84)))))), (CInt(((CByte((33)))))), (CInt(((CByte((107)))))))
        BackColor = Color.White
    End Sub

    Private Sub ButtonLastest_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((84)))))), (CInt(((CByte((33)))))), (CInt(((CByte((107)))))))
        ForeColor = System.Drawing.Color.White
    End Sub

    Shadows top As Integer
    Shadows left As Integer
    Shadows right As Integer
    Shadows bottom As Integer

    Protected Overrides Sub OnPaint(ByVal pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)
        Dim CornerRadius As Integer = 18
        Dim DrawPen As Pen = New Pen(BorderColor)
        Dim gfxPath_mod As New Drawing2D.GraphicsPath
        top = 0
        left = 0

        Width = Height

        right = Width
        bottom = Height

        FlatAppearance.BorderSize = 0
        BorderColor = Color.Black
        BorderSize = 5

        gfxPath_mod.AddEllipse(New Rectangle(0, 0, Width, Width))
        gfxPath_mod.CloseAllFigures()
        pevent.Graphics.DrawPath(DrawPen, gfxPath_mod)
        Dim inside As Integer = 1
        Dim newPen As Pen = New Pen(BorderColor, BorderSize)

        Dim gfxPath As New Drawing2D.GraphicsPath

        gfxPath.AddEllipse(New Rectangle(0, 0, Width, Width))
        pevent.Graphics.DrawPath(newPen, gfxPath)
        Me.Region = New System.Drawing.Region(gfxPath_mod)
    End Sub
End Class


