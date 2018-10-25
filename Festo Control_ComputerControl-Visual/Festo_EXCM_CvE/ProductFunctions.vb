Module ProductFunctions
    Public Sub INI_SaveFile(filename As String)
        Dim oWrite As System.IO.StreamWriter = New System.IO.StreamWriter(filename)

        '  Dim oRead As System.IO.StreamReader = New System.IO.StreamReader(filename)

        oWrite.WriteLine("[PLC IP Address]")
        oWrite.WriteLine("IP Address=" & PLC.IP_Addr)
        oWrite.WriteLine("Port=" & PLC.Port)
        oWrite.WriteLine()
        oWrite.WriteLine("[Inserter Definitions]")

        For i As Integer = 1 To 4
            oWrite.WriteLine("Inserter" & i & "-Description=" & InserterDescription(i))
            oWrite.WriteLine("Inserter" & i & "-Location=" & InserterX(i) & "," & InserterY(i))
            oWrite.WriteLine("Inserter" & i & "-Color=" & InserterColors(i).ToArgb)
        Next

        oWrite.WriteLine()
        oWrite.WriteLine("[Gantry Settings]")
        oWrite.WriteLine("Speed=" & GantrySpeed)
        oWrite.WriteLine()

        oWrite.Close()
    End Sub

    Public Sub INI_LoadFile(filename As String)
        Dim oRead As System.IO.StreamReader = New System.IO.StreamReader(filename)

        While (oRead.Peek() <> -1)
            Dim fstr() As String = oRead.ReadLine.Split("=")

            Select Case fstr(0).ToLower
                Case "ip address"
                    PLC.IP_Addr = fstr(1)

                Case "port"
                    PLC.Port = fstr(1)

                Case "inserter1-description"
                    InserterDescription(1) = fstr(1)

                Case "inserter2-description"
                    InserterDescription(2) = fstr(1)

                Case "inserter3-description"
                    InserterDescription(3) = fstr(1)

                Case "inserter4-description"
                    InserterDescription(4) = fstr(1)

                Case "inserter1-location"
                    InserterX(1) = fstr(1).Split(",")(0)
                    InserterY(1) = fstr(1).Split(",")(1)

                Case "inserter2-location"
                    InserterX(2) = fstr(1).Split(",")(0)
                    InserterY(2) = fstr(1).Split(",")(1)

                Case "inserter3-location"
                    InserterX(3) = fstr(1).Split(",")(0)
                    InserterY(3) = fstr(1).Split(",")(1)

                Case "inserter4-location"
                    InserterX(4) = fstr(1).Split(",")(0)
                    InserterY(4) = fstr(1).Split(",")(1)

                Case "inserter1-color"
                    InserterColors(1) = Color.FromArgb(fstr(1))

                Case "inserter2-color"
                    InserterColors(2) = Color.FromArgb(fstr(1))

                Case "inserter3-color"
                    InserterColors(3) = Color.FromArgb(fstr(1))

                Case "inserter4-color"
                    InserterColors(4) = Color.FromArgb(fstr(1))

                Case "gantry-speed"
                    GantrySpeed = fstr(1)

                Case Else
            End Select
        End While

        oRead.Close()
    End Sub

    Public Sub Preview_GoToNextMove()

        Dim IndexToTry As Integer = TF.LB_Commands.SelectedIndex + 1

        While IndexToTry < TF.LB_Commands.Items.Count
            'Look for the next available move command

            If UserProgram.CommandList(IndexToTry).GetType = GetType(objCommand_Move) Then
                'We found a move, select it and send gantry there

                TF.LB_Commands.SelectedIndex = IndexToTry

                PLC.TCP_CommandMove(UserProgram.CommandList(IndexToTry))
                Return
            End If

            IndexToTry += 1
        End While

        'No more move commands, notify user and de-select
        MessageBox.Show("At End of Program")
        TF.LB_Commands.SelectedIndex = -1
    End Sub

    Public Sub Preview_GoToLastMove()

        'If nothing is selected use "Go To Next Move" instead
        If TF.LB_Commands.SelectedIndex < 0 Then
            Preview_GoToNextMove()
            Return
        End If

        Dim IndexToTry As Integer = TF.LB_Commands.SelectedIndex - 1

        While IndexToTry >= 0
            'Look for the next available move command

            If UserProgram.CommandList(IndexToTry).GetType = GetType(objCommand_Move) Then
                'We found a move, select it and send gantry there

                TF.LB_Commands.SelectedIndex = IndexToTry

                PLC.TCP_CommandMove(UserProgram.CommandList(IndexToTry))
                Return
            End If

            IndexToTry -= 1
        End While

        'No more move commands, notify user and de-select
        MessageBox.Show("At Beginning of Program")
        TF.LB_Commands.SelectedIndex = -1
    End Sub

    Function GetX_ForPinInserter(connector As objConnector, PinName As String, inserter As Integer) As Decimal
        'Function to find pin X relative to the center of the carriage head (which may be different than tray center, connectors are always referenced from carriage center)

        'Look through all the pins until we find the right one
        For Each p As objConnector_Pin In connector.Pins
            If p.Name = PinName Then 'found it

                'First we get the offset from the carriage center (remember pinref is from lower left of connector)
                Dim Offset As Decimal = connector.TrayPositionX - connector.SizeX / 2 + connector.PinRefZeroX + p.X
                Dim position As Decimal = InserterX(inserter) - Offset 'Start at the center of the carriage for this inserter then subtract offset (remember we move table, not tool)

                'Position is at lower left of connector box, then connector origin offset by ref X and pin X from ref
                'Dim position As Decimal = connector.TrayCenterX - connector.SizeX / 2 + connector.PinRefZeroX + p.X
                'position += InserterX(inserter)

                Return Decimal.Round(position, 1, MidpointRounding.AwayFromZero) 'We round to .1mm for the position
            End If
        Next

        Return -1 'Error
    End Function

    Function GetY_ForPinInserter(connector As objConnector, PinName As String, inserter As Integer) As Decimal
        'Function to find pin X relative to the center of the carriage head (which may be different than tray center, connectors are always referenced from carriage center)

        'Look through all the pins until we find the right one
        For Each p As objConnector_Pin In connector.Pins
            If p.Name = PinName Then 'found it
                'Position is at lower left of connector box, then connector origin offset by ref X and pin X from ref

                'First we get the offset from the carriage center (remember pinref is from lower left of connector)
                Dim Offset As Decimal = connector.TrayPositionY - connector.SizeY / 2 + connector.PinRefZeroY + p.Y
                Dim position As Decimal = InserterY(inserter) - Offset 'Start at the center of the carriage for this inserter then subtract offset (remember we move table, not tool)

                ' Dim position As Decimal = connector.TrayCenterY - connector.SizeY / 2 + connector.PinRefZeroY + p.Y
                'position += InserterY(inserter) 'Add the inserter position

                Return Decimal.Round(position, 1, MidpointRounding.AwayFromZero) 'We round to .1mm for the position
            End If
        Next

        Return -1 'Error
    End Function

    Function ConnectToPLC(ShowMessage As Boolean)
        Try
            If PLC.TCP_Connect(True, ShowMessage) Then
                TF.TSSL_OnOffline.Text = "Connected to PLC: " & PLC.TCPsender.RemoteEndPoint.ToString()

                Online = True
                Return True
            End If
        Catch
        End Try

        TF.TSSL_OnOffline.Text = "offline"
        Online = False
        Return False
    End Function

    Function ReConnectToPLC()
        Try
            If PLC.TCP_Connect(True, False) Then
                TF.TSSL_OnOffline.Text = "Connected to PLC: " & PLC.TCPsender.RemoteEndPoint.ToString()

                Online = True
                Return True
            End If
        Catch
            MessageBox.Show("Could Not Connect to PLC")
        End Try

        TF.TSSL_OnOffline.Text = "offline"
        Online = False
        Return False
    End Function

    Function LoadProgramToPLC() As Boolean
        Try
            If Not ConnectToPLC(True) Then Return False

            UserProgram.Name = TF.TB_ProgramName.Text

            'PLC.TCP_SendProgram_Name(UserProgram)
            PLC.TCP_ClearDataTable()

            For Each cmd As Object In UserProgram.CommandList
                PLC.TCP_DataTable_AddCommand(cmd)
            Next

            UserProgram.NeedsPLC_Load = False
            Return True
        Catch
            MessageBox.Show("Error Loading Program to PLC")

            Return False
        End Try
    End Function
End Module
