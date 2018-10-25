Imports System.ComponentModel

Public Class objConnector
    Property Name As String
    Property Manufacturer As String
    Property PartNumber As String
    Property TrayIndex 'What connector definition are we on the tray? 1,2,3, etc. Used for loading/saving tray

    Property Units As String
    Property BackFacing As Boolean

    Property SizeX As Decimal 'Size of connector X/Y
    Property SizeY As Decimal
    Property PinRefZeroX As Decimal 'The reference point for pin1 from bottom left corner of connector space
    Property PinRefZeroY As Decimal

    Property TrayPositionX As Decimal 'The X/Y location of the center of the connector on the tray (from carriage center)
    Property TrayPositionY As Decimal

    Property OutlineShapes As New List(Of objOutline)

    Property Pins As New BindingList(Of objConnector_Pin)

    Function GetPinNumberByName(pinname As String)
        For i As Integer = 0 To Pins.Count - 1
            If Pins(i).Name = pinname Then Return i
        Next

        Return -1
    End Function

    Sub ChangePinInserts(pinname As String, inserts As String)
        Pins(GetPinNumberByName(pinname)).InsertOrder = inserts
    End Sub

    Function PinIsSetForInsert(pinname As String) As Boolean
        For Each p As objConnector_Pin In Pins
            If p.Name = pinname Then Return p.Used
        Next

        Return False
    End Function

    Public Sub ShowConnector(PB_Connector As PictureBox, Optional Manuf_Label As Label = Nothing, Optional PartNo_Label As Label = Nothing)
        Dim SetImage As New Bitmap(PB_Connector.Height, PB_Connector.Width) 'Variable to hold the image

        'This function displays the assigned pins/etc for the selected tray connector
        pinbuttlist.Clear()

        Dim PixelsPerUnit As Decimal = PB_Connector.Width / Math.Max(Me.SizeX, Me.SizeY)
        Dim pinnum As Integer = 0 'pointer to keep link between pin button and pin object

        For Each outline As objOutline In Me.OutlineShapes 'ConnTray.Connectors(CurrentConnector).OutlineShapes
            With outline
                Dim LocP1 As Point = New Point(.point1.X * PixelsPerUnit + PB_Connector.Width / 2, - .point1.Y * PixelsPerUnit + PB_Connector.Height / 2)
                Dim LocP2 As Point = New Point(.point2.X * PixelsPerUnit + PB_Connector.Width / 2, - .point2.Y * PixelsPerUnit + PB_Connector.Height / 2)

                Select Case .Shape.ToLower
                    'Remember here that all X/Y co-ords are from the center of the connector

                    Case "circle"
                        Dim test As objOutline = outline

                        'Dim LocP1 As Point = New Point(.point1.X * PixelsPerUnit + PB_Connector.Width / 2, - .point1.Y * PixelsPerUnit + PB_Connector.Height / 2)
                        Dim DrawDiameter = .Diameter * PixelsPerUnit - .LineThickness

                        Using g As Graphics = Graphics.FromImage(SetImage)
                            Dim pen1 As New System.Drawing.Pen(Color.Black, .LineThickness)
                            g.DrawEllipse(pen1, LocP1.X - DrawDiameter / 2, LocP1.Y - DrawDiameter / 2, DrawDiameter - .LineThickness, DrawDiameter - .LineThickness) 'Draw button border

                            'PB_Connector.Image = SetImage
                            pen1.Dispose()
                            g.Dispose()
                        End Using

                    Case "rectangle"
                        Using g As Graphics = Graphics.FromImage(SetImage)

                            Dim rect As Rectangle
                            rect.Width = Math.Abs(LocP1.X - LocP2.X) - .LineThickness
                            rect.Height = Math.Abs(LocP1.Y - LocP2.Y) - .LineThickness

                            If LocP1.X < LocP2.X Then
                                rect.X = LocP1.X ' + .LineThickness
                            Else
                                rect.X = LocP2.X '+ .LineThickness
                            End If

                            If LocP1.Y < LocP2.Y Then
                                rect.Y = LocP1.Y ' - .LineThickness
                            Else
                                rect.Y = LocP2.Y '- .LineThickness
                            End If

                            Dim pen1 As New System.Drawing.Pen(Color.Black, .LineThickness)
                            g.DrawRectangle(pen1, rect)

                            'PB_Connector.Image = SetImage
                            pen1.Dispose()
                            g.Dispose()
                        End Using

                End Select
            End With
        Next

        'Locating the pin is an N step process due to the fact that we may have to scale the connector in the box.
        'We start by getting the pin ref location in the picture box.

        Dim RefP As Point = New Point(PB_Connector.Width / 2, PB_Connector.Height / 2) 'First get the center of the picture box
        RefP += New Point(-SizeX / 2 * PixelsPerUnit, SizeY / 2 * PixelsPerUnit) 'Go now to the lower left corner of the connector, where the pin reference is made from
        RefP += New Point(PinRefZeroX * PixelsPerUnit, -PinRefZeroY * PixelsPerUnit)  'Add in the pin reference and this will be where everything pin starts from

        For Each pin As objConnector_Pin In Me.Pins
            'Dim LocP As Point = New Point((Me.PinRefZeroX + pin.X) * PixelsPerUnit, (Me.PinRefZeroY - pin.Y) * PixelsPerUnit)
            Dim LocP As Point = RefP + (New Point(pin.X * PixelsPerUnit, pin.Y * PixelsPerUnit))

            With Me.Pins(pinnum).InsertOrder
                Select Case .Length
                    Case 0 'There's no insert
                        pinbuttlist.Add(New Control_RoundSplitButtonForPictureBox(PB_Connector, SetImage, pin.Name, LocP, pin.Diameter * PixelsPerUnit))
                    Case 1 'We're inserting one item
                        pinbuttlist.Add(New Control_RoundSplitButtonForPictureBox(PB_Connector, SetImage, pin.Name, LocP, pin.Diameter * PixelsPerUnit, False))
                        pinbuttlist(pinnum).SetButton(InserterColors(.Substring(0, 1)))
                    Case Else 'We're inserting two items
                        pinbuttlist.Add(New Control_RoundSplitButtonForPictureBox(PB_Connector, SetImage, pin.Name, LocP, pin.Diameter * PixelsPerUnit, False))
                        pinbuttlist(pinnum).SetButton(InserterColors(.Substring(1, 1)), InserterColors(.Substring(0, 1)))
                End Select
            End With

            pinnum += 1
        Next

        PB_Connector.Image = SetImage

        If Manuf_Label IsNot Nothing Then Manuf_Label.Text = "Manufacturer: " & Me.Manufacturer
        If PartNo_Label IsNot Nothing Then PartNo_Label.Text = "Part Number: " & Me.PartNumber
    End Sub

    Public Sub ShowConnectorOnTray(PB_Tray As PictureBox, Tray As objTray, ConnCenter As Point)
        Dim SetImage As New Bitmap(PB_Tray.Height, PB_Tray.Width) 'Variable to hold the image

        'This function displays the assigned pins/etc for the selected tray connector
        pinbuttlist.Clear()

        Dim PixelsPerUnit As Decimal = PB_Tray.Width / Math.Max(Tray.SizeX, Tray.SizeY)
        Dim pinnum As Integer = 0 'pointer to keep link between pin button and pin object

        For Each outline As objOutline In Me.OutlineShapes 'ConnTray.Connectors(CurrentConnector).OutlineShapes
            With outline
                Dim LocP1 As Point = New Point(.point1.X * PixelsPerUnit + PB_Tray.Width / 2, - .point1.Y * PixelsPerUnit + PB_Tray.Height / 2)
                Dim LocP2 As Point = New Point(.point2.X * PixelsPerUnit + PB_Tray.Width / 2, - .point2.Y * PixelsPerUnit + PB_Tray.Height / 2)

                Select Case .Shape.ToLower
                    'Remember here that all X/Y co-ords are from the center of the connector

                    Case "circle"
                        Dim test As objOutline = outline

                        'Dim LocP1 As Point = New Point(.point1.X * PixelsPerUnit + PB_Connector.Width / 2, - .point1.Y * PixelsPerUnit + PB_Connector.Height / 2)
                        Dim DrawDiameter = .Diameter * PixelsPerUnit - .LineThickness

                        Using g As Graphics = Graphics.FromImage(SetImage)
                            Dim pen1 As New System.Drawing.Pen(Color.Black, .LineThickness)
                            g.DrawEllipse(pen1, LocP1.X - DrawDiameter / 2, LocP1.Y - DrawDiameter / 2, DrawDiameter - .LineThickness, DrawDiameter - .LineThickness) 'Draw button border

                            'PB_Connector.Image = SetImage
                            pen1.Dispose()
                            g.Dispose()
                        End Using

                    Case "rectangle"
                        Using g As Graphics = Graphics.FromImage(SetImage)

                            Dim rect As Rectangle
                            rect.Width = Math.Abs(LocP1.X - LocP2.X) - .LineThickness
                            rect.Height = Math.Abs(LocP1.Y - LocP2.Y) - .LineThickness

                            If LocP1.X < LocP2.X Then
                                rect.X = LocP1.X ' + .LineThickness
                            Else
                                rect.X = LocP2.X '+ .LineThickness
                            End If

                            If LocP1.Y < LocP2.Y Then
                                rect.Y = LocP1.Y ' - .LineThickness
                            Else
                                rect.Y = LocP2.Y '- .LineThickness
                            End If

                            Dim pen1 As New System.Drawing.Pen(Color.Black, .LineThickness)
                            g.DrawRectangle(pen1, rect)

                            'PB_Connector.Image = SetImage
                            pen1.Dispose()
                            g.Dispose()
                        End Using

                End Select
            End With
        Next

        'ADD LABEL


        PB_Tray.Image = SetImage
    End Sub
End Class
