Public Class objUserProgram
    Property Version As Decimal
    Property Name As String = ""
    Property FileName As String = ""

    Property CommandList As List(Of Object)
    Property NeedsPLC_Load As Boolean = True

    Sub New()
        CommandList = New List(Of Object)
    End Sub

    Sub ClearAll()
        Version = 0
        Name = ""
        CommandList.Clear()
    End Sub

    Sub CopyFromUP(oldUP As objUserProgram)
        Version = oldUP.Version
        Name = oldUP.Name
        FileName = oldUP.FileName

        CommandList.Clear()

        For Each c As Object In oldUP.CommandList
            Select Case c.GetType

                Case GetType(objCommand_Move)
                    Dim TC As objCommand_Move = c
                    Dim NewMove As New objCommand_Move

                    NewMove.X = TC.X
                    NewMove.Y = TC.Y
                    NewMove.Speed = TC.Speed
                    NewMove.Relative = TC.Relative

                    CommandList.Add(NewMove)

                Case GetType(objCommand_Insert)
                    Dim TC As objCommand_Insert = c
                    Dim NewInsert As New objCommand_Insert

                    'NewInsert.Side = TC.Side
                    NewInsert.Inserter = TC.Inserter
                    CommandList.Add(NewInsert)
            End Select
        Next
    End Sub
End Class
