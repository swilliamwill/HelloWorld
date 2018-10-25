Public Class UI_CopyConnector
    Private CopyFromButtons(3) As RoundButton
    Private CopyToButtons(3) As RoundButton

    Public Sub UF_CopyConnector_SetConnector(conn As Integer)
        CopyFromButtons(0) = BUTT_Conn1
        CopyFromButtons(1) = BUTT_Conn2
        CopyFromButtons(2) = BUTT_Conn3
        CopyFromButtons(3) = BUTT_Conn4

        CopyToButtons(0) = BUTT_CopyToConn1
        CopyToButtons(1) = BUTT_CopyToConn2
        CopyToButtons(2) = BUTT_CopyToConn3
        CopyToButtons(3) = BUTT_CopyToConn4

        Select Case conn
            Case 0
                CopyFrom_Click(BUTT_Conn1, Nothing)
            Case 1
                CopyFrom_Click(BUTT_Conn2, Nothing)
            Case 2
                CopyFrom_Click(BUTT_Conn3, Nothing)
            Case 3
                CopyFrom_Click(BUTT_Conn4, Nothing)
        End Select

        Me.ShowDialog()
    End Sub

    Private Sub CopyFrom_Click(sender As Object, e As EventArgs) Handles BUTT_Conn1.Click, BUTT_Conn2.Click, BUTT_Conn3.Click, BUTT_Conn4.Click
        Dim btn = CType(sender, Button)

        BUTT_Conn1.BackColor = Color.White
        BUTT_Conn2.BackColor = Color.White
        BUTT_Conn3.BackColor = Color.White
        BUTT_Conn4.BackColor = Color.White

        btn.BackColor = Color.PaleTurquoise

        Dim SelectedButton = CInt(btn.Text) - 1

        For i As Integer = 0 To 3
            If i = SelectedButton Then
                CopyToButtons(i).Visible = False
                CopyToButtons(i).BackColor = Color.White
            Else
                CopyToButtons(i).Visible = True
            End If
        Next
    End Sub

    Private Sub CopyTo_Click(sender As Object, e As EventArgs) Handles BUTT_CopyToConn1.Click, BUTT_CopyToConn2.Click, BUTT_CopyToConn3.Click, BUTT_CopyToConn4.Click
        Dim btn = CType(sender, Button)

        If btn.BackColor = Color.White Then
            btn.BackColor = Color.PaleTurquoise
        Else
            btn.BackColor = Color.White
        End If
    End Sub

    Private Sub BUTT_Copy_Click(sender As Object, e As EventArgs) Handles BUTT_Copy.Click
        For Each btn As RoundButton In CopyFromButtons
            If btn.BackColor <> Color.White Then 'We've found the selected button
                Dim SelectedButton = CInt(btn.Text) - 1

                For i As Integer = 0 To 3
                    If CopyToButtons(i).BackColor <> Color.White Then
                        Dim j As Integer = 0

                        For Each pin As objConnector_Pin In ConnTray.Connectors(i).Pins
                            pin.InsertOrder = ConnTray.Connectors(SelectedButton).Pins(j).InsertOrder
                            j += 1
                        Next
                    End If
                Next
            End If
        Next

        Me.Close()
    End Sub

    Private Sub BUTT_Cancel_Click(sender As Object, e As EventArgs) Handles BUTT_Cancel.Click
        Me.Close()
    End Sub
End Class