Public Class objTray
    Property TrayProgramName As String = ""

    Property Units As String

    Property SizeX As Decimal 'Size of connector X/Y
    Property SizeY As Decimal
    Property CenterX As Decimal 'The reference point for pin1 from bottom left corner of connector space
    Property CenterY As Decimal

    Property Connectors As New List(Of objConnector)

    Public Sub ClearAllData()
        TrayProgramName = ""
        Units = ""
        SizeX = 0
        SizeY = 0
        CenterX = 0
        CenterY = 0

        Connectors.Clear()
    End Sub
End Class
