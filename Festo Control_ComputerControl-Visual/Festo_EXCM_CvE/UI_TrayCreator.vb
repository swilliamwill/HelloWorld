Public Class UI_TrayCreator

    Private SetImage As Bitmap
    Private tr As objTray

    Private Sub UI_TrayCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Public Sub LoadTray(_tray As objTray)
        Me.Show()

        tr = _tray

        NUD_Width.Value = tr.SizeX
        NUD_Height.Value = tr.SizeY
        NUD_TrayCenterX.Value = tr.CenterX
        NUD_TrayCenterY.Value = tr.CenterY

        DrawTray()

    End Sub

    Private Sub DrawTray()
        SetImage = New Bitmap(PB_Tray.Height, PB_Tray.Width)

        'Assume rectangular tray
        Dim PixelsPerUnit As Decimal = Math.Min(PB_Tray.Width / tr.SizeX, PB_Tray.Height / tr.SizeY)

        DrawConnector(tr.Connectors(0))

        'For Each con As objConnector In tr.Connectors
        ' DrawConnector(con)
        ' Next
    End Sub

    Private Sub DrawConnector(con As objConnector)
        ' Using g As Graphics = Graphics.FromImage(SetImage) 'Put image object into memory
        Dim PixelsPerUnit As Decimal = PB_Tray.Width / Math.Max(tr.SizeX, tr.SizeY)
        Dim pinnum As Integer = 0 'pointer to keep link between pin button and pin object

        'Draw each outline shape
        For Each outline As objOutline In con.OutlineShapes
            With outline
                Select Case .Shape
                    'Remember here that all X/Y co-ords are from the bottom left of the tray

                    Case "circle"
                        Dim test As objOutline = outline

                        'Dim CenterPoint

                        'Get point from center of carriage
                        Dim LocP1 As New Point((.point1.X + con.TrayPositionX + tr.CenterX) * PixelsPerUnit, (tr.SizeY - .point1.Y - con.TrayPositionY - tr.CenterY) * PixelsPerUnit)
                        'Dim PixLocP1 As New Point(LocP1.X * PixelsPerUnit, (tr.SizeY - LocP1.Y) * PixelsPerUnit) 'Get point from picturebox corner

                        ' Dim LocP1 As Point = New Point(.point1.X + con.TrayPositionX + tr.CenterX, - .point1.Y + con.TrayPositionY + tr.CenterY) 'Get point from center of carriage
                        ' LocP1.X += tr.CenterX 'Add the offset for the t

                        'Translate to pixel position

                        Dim DrawDiameter = .Diameter * PixelsPerUnit - .LineThickness

                        Using g As Graphics = Graphics.FromImage(SetImage)
                            Dim pen1 As New System.Drawing.Pen(Color.Black, .LineThickness)
                            g.DrawEllipse(pen1, LocP1.X - DrawDiameter / 2, LocP1.Y - DrawDiameter / 2, DrawDiameter - .LineThickness, DrawDiameter - .LineThickness) 'Draw button border

                            PB_Tray.Image = SetImage
                            pen1.Dispose()
                            g.Dispose()
                        End Using
                End Select
            End With
        Next
        ' End Using
    End Sub

    Private Sub DrawTray()

    End Sub
End Class