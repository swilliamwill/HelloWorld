Public Class Control_RoundSplitButtonForPictureBox
    Property ParentBox As PictureBox
    Property CenterPoint As Point
    Property Diameter As Integer
    Property Text As String
    Property TextSize As Integer = 25
    Property PB_Image As Bitmap

    Property ButtonSet As Boolean = False

    Private DefaultBackgroundColor As Color = Color.White
    Private TopColor As Color
    Private BottomColor As Color

    Public Sub New(_ParentBox As PictureBox, _PB_Image As Bitmap, _text As String, _CenterPoint As Point, _Diameter As Integer, Optional _DrawButton As Boolean = True, Optional _DBGC As Color = Nothing)
        ParentBox = _ParentBox
        CenterPoint = _CenterPoint
        Diameter = _Diameter
        Text = _text
        PB_Image = _PB_Image

        If _DBGC <> Nothing Then DefaultBackgroundColor = _DBGC

        TopColor = DefaultBackgroundColor
        BottomColor = DefaultBackgroundColor

        If _DrawButton Then DrawButton()
    End Sub

    Public Sub SetButton(_TopColor As Color, Optional _BottomColor As Color = Nothing)
        ButtonSet = True

        TopColor = _TopColor

        If _BottomColor = Nothing Then
            BottomColor = TopColor
        Else
            BottomColor = _BottomColor
        End If

        DrawButton()
    End Sub

    Public Sub ClearButton(Optional _DBGC As Color = Nothing)
        ButtonSet = False

        If _DBGC <> Nothing Then DefaultBackgroundColor = _DBGC

        TopColor = DefaultBackgroundColor
        BottomColor = DefaultBackgroundColor

        DrawButton()
    End Sub

    Private Sub DrawButton()
        'Using g As Graphics = ParentBox.CreateGraphics
        Using g As Graphics = Graphics.FromImage(PB_Image)
            If TopColor = Nothing Then TopColor = BottomColor


            Dim rect As Rectangle = New Rectangle(CenterPoint.X - Diameter / 2, CenterPoint.Y - Diameter / 2, Diameter, Diameter)
            Dim pen1 As New System.Drawing.Pen(Color.Black, 3)

            g.FillPie(New SolidBrush(BottomColor), rect, 0, 180) 'Draw bottom half of button
            g.FillPie(New SolidBrush(TopColor), rect, 180, 180) 'Draw top half of button
            g.DrawEllipse(pen1, rect.X, rect.Y, Diameter, Diameter) 'Draw button border

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias

            Dim sf As StringFormat = New StringFormat
            sf.Alignment = StringAlignment.Center
            sf.LineAlignment = StringAlignment.Center

            Using gp As New System.Drawing.Drawing2D.GraphicsPath, f As New Font(FontFamily.GenericSansSerif, TextSize, FontStyle.Bold), p As New Pen(Brushes.White, 2)
                gp.AddString(Text, f.FontFamily, f.Style, f.Size + 3, CenterPoint, sf)

                g.DrawPath(p, gp)
                g.FillPath(Brushes.Black, gp)
                p.Dispose()
                gp.Dispose()
            End Using

            ParentBox.Image = PB_Image

            sf.Dispose()
            g.Dispose()
            pen1.Dispose()
        End Using
    End Sub
End Class
