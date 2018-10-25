Imports System.Net
Imports System.Net.Sockets

Public Class classPLC
    Const TCP_Pause As Integer = 25

    'Command constants
    Const CMD_Stop As Byte = 0S
    Const CMD_MoveAbsolute As Byte = 1S
    Const CMD_Insert As Byte = 2S

    'PLC Vars
    Dim DataTableRow As Integer = 0
    Dim CurrentSpeed As Integer = -1

    'IP connect variables
    Property IP_Addr As String = "192.168.178.3"
    Property Port As Integer = 20000
    Property TCPsender As Socket
    Property Online As Boolean = False

    Property RotateXY As Boolean = True 'Are the X and Y values swapped?
    Property XY As New objXY_System

    Public Function TCP_Connect(open As Boolean, Optional ShowMessage As Boolean = True) As Boolean
        If open Then

            'If we were already open try a ping to verify that we're still good
            If Not My.Computer.Network.Ping(IPAddress.Parse(IP_Addr).ToString, 1000) Then
                Online = False
                Throw New Exception
            End If

            If Online Then Return True 'If we were previously online the ping check is enough, just exit

            Try
                Dim remoteEP As New IPEndPoint(IPAddress.Parse(IP_Addr), Port)

                ' Create a TCP/IP socket.  
                TCPsender = New Socket(IPAddress.Parse(IP_Addr).AddressFamily, SocketType.Stream, ProtocolType.Tcp)

                Dim result = TCPsender.BeginConnect(remoteEP, New AsyncCallback(AddressOf TCPsender.EndConnect), TCPsender)
                Dim success = result.AsyncWaitHandle.WaitOne(1000, True)

                If success = False Then 'This doesn't fucking work, but hey
                    'TCPsender.Close()

                    Online = False
                    Throw New Exception
                End If

                Online = True

                Return True

            Catch ex As Exception
                'MessageBox.Show("Could not connect to PLC" & vbCrLf & vbCrLf & ex.Message)
                If ShowMessage Then
                    MessageBox.Show("Could Not connect to PLC" & vbCrLf & vbCrLf & "Please make sure system is powered on and set to correct IP address")
                    End
                    Online = False
                End If
            End Try
        Else
            Try
                If Online Then
                    TCPsender.Shutdown(SocketShutdown.Both)
                    TCPsender.Close()
                End If

                Online = False

                Return True
            Catch ex As Exception
                MessageBox.Show("Could not disconnect from PLC" & vbCrLf & vbCrLf & ex.Message)
            End Try
        End If

        Return False
    End Function


    'Private Function SendTCP_AndGetResponse(Tx As objCvE_Transmission) As objCvE_Transmission
    '    System.Threading.Thread.Sleep(TCP_Pause) 'Sending commands too fast results in them being skipped

    '    ' Send the data through the socket.  
    '    Dim bytesSent As Integer = TCPsender.Send(Tx.GetByteString())

    '    ' Receive the response from the remote device.  
    '    Dim bytes(1024) As Byte
    '    Dim bytesRec As Integer = TCPsender.Receive(bytes)

    '    Dim Rx As New objCvE_Transmission
    '    Rx.ResponseToCvE(bytes)
    '    Return Rx
    'End Function

    Public Function TCP_GetPLC_Name() As String
        TCPsender.Send(System.Text.Encoding.ASCII.GetBytes("FP"))

        Dim bytes(1024) As Byte
        Dim bytesRec As Integer = TCPsender.Receive(bytes)

        Return ""
    End Function

    Public Sub TCP_SendProgram_Name(UP As objUserProgram)
        Dim sendstr = "PN" + UP.Name ' ProgramName

        Dim sbarr = System.Text.Encoding.ASCII.GetBytes(sendstr)
        ReDim Preserve sbarr(8 + 1)

        TCPsender.Send(sbarr)
    End Sub

    Public Sub TCP_ClearDataTable()
        System.Threading.Thread.Sleep(TCP_Pause) 'Sending commands too fast results in them being skipped

        ' Send the data through the socket.  
        TCPsender.Send(System.Text.Encoding.ASCII.GetBytes("DTC")) 'Data Table Clear

        ' Receive the response from the remote device.  
        Dim bytes(100) As Byte
        Dim bytesRec As Integer = TCPsender.Receive(bytes)

        If bytesRec > 0 AndAlso bytes(0) = 6 Then
            DataTableRow = 0
        Else
            Throw New Exception
        End If
    End Sub

    Public Sub TCP_CommandMove(cmd As objCommand_Move)
        System.Threading.Thread.Sleep(TCP_Pause) 'Sending commands too fast results in them being skipped

        Dim var1, var2 As Long

        If RotateXY Then
            var1 = cmd.Y * 1000
            var2 = cmd.X * 1000
        Else
            var1 = cmd.X * 1000
            var2 = cmd.Y * 1000
        End If

        Dim var3 As Integer = cmd.Speed

        Dim barr(11) As Byte

        barr(0) = Asc("M") 'Move
        barr(1) = Asc("A") 'Absolute
        barr(2) = var1 Mod 256
        barr(3) = (var1 >> 8) Mod 256
        barr(4) = (var1 >> 16) Mod 256
        barr(5) = (var1 >> 24) Mod 256
        barr(6) = var2 Mod 256
        barr(7) = (var2 >> 8) Mod 256
        barr(8) = (var2 >> 16) Mod 256
        barr(9) = (var2 >> 24) Mod 256
        barr(10) = var3 Mod 256
        barr(11) = (var3 >> 8) Mod 256

        TCPsender.Send(barr)

        ' Receive the response from the remote device.  
        Dim bytes(100) As Byte
        Dim bytesRec As Integer = TCPsender.Receive(bytes)

        If bytesRec = 0 OrElse bytes(0) <> 6 Then
            Throw New Exception
        End If
    End Sub

    Public Sub TCP_CommandHome()
        System.Threading.Thread.Sleep(TCP_Pause) 'Sending commands too fast results in them being skipped

        ' Send the data through the socket.  
        TCPsender.Send(System.Text.Encoding.ASCII.GetBytes("GH")) 'Go Home

        ' Receive the response from the remote device.  
        Dim bytes(100) As Byte
        Dim bytesRec As Integer = TCPsender.Receive(bytes)

        If bytesRec > 0 AndAlso bytes(0) = 6 Then
            DataTableRow = 0
        Else
            Throw New Exception
        End If
    End Sub

    Public Sub TCP_SystemCommand_Stop()
        System.Threading.Thread.Sleep(TCP_Pause) 'Sending commands too fast results in them being skipped

        Dim barr(2) As Byte

        barr(0) = Asc("S") 'Data
        barr(1) = Asc("C") 'Table
        barr(2) = 1 'Modify

        TCPsender.Send(barr)

        ' Receive the response from the remote device.  
        Dim bytes(100) As Byte
        Dim bytesRec As Integer = TCPsender.Receive(bytes)

        If bytesRec = 0 OrElse bytes(0) <> 6 Then
            Throw New Exception
        End If
    End Sub

    Public Sub TCP_SystemCommand_Run()
        System.Threading.Thread.Sleep(TCP_Pause) 'Sending commands too fast results in them being skipped

        Dim barr(2) As Byte

        barr(0) = Asc("S") 'Data
        barr(1) = Asc("C") 'Table
        barr(2) = 2 'Modify

        TCPsender.Send(barr)

        ' Receive the response from the remote device.  
        Dim bytes(100) As Byte
        Dim bytesRec As Integer = TCPsender.Receive(bytes)

        If bytesRec = 0 OrElse bytes(0) <> 6 Then
            Throw New Exception
        End If
    End Sub

    Public Sub TCP_SystemCommand_Pause()
        System.Threading.Thread.Sleep(TCP_Pause) 'Sending commands too fast results in them being skipped

        Dim barr(2) As Byte

        barr(0) = Asc("S") 'Data
        barr(1) = Asc("C") 'Table
        barr(2) = 3 'Modify

        TCPsender.Send(barr)

        ' Receive the response from the remote device.  
        Dim bytes(100) As Byte
        Dim bytesRec As Integer = TCPsender.Receive(bytes)

        If bytesRec = 0 OrElse bytes(0) <> 6 Then
            Throw New Exception
        End If
    End Sub

    Public Sub TCP_DataTable_ModifyRow(row As Integer, Command As Byte, var1 As Long, var2 As Long, var3 As Integer, var4 As Integer)
        System.Threading.Thread.Sleep(TCP_Pause) 'Sending commands too fast results in them being skipped

        Dim barr(17) As Byte

        barr(0) = Asc("D") 'Data
        barr(1) = Asc("T") 'Table
        barr(2) = Asc("M") 'Modify
        barr(3) = Asc("R") 'Row
        barr(4) = row Mod 256
        barr(5) = (row >> 8) Mod 256
        barr(6) = Command

        If Command = CMD_MoveAbsolute AndAlso RotateXY Then
            'If we have a rotated gantry swap X and Y

            Dim tv As Long = var1
            var1 = var2
            var2 = tv
        End If

        barr(7) = var1 Mod 256
        barr(8) = (var1 >> 8) Mod 256
        barr(9) = (var1 >> 16) Mod 256
        barr(10) = (var1 >> 24) Mod 256
        barr(11) = var2 Mod 256
        barr(12) = (var2 >> 8) Mod 256
        barr(13) = (var2 >> 16) Mod 256
        barr(14) = (var2 >> 24) Mod 256
        barr(15) = var3 Mod 256
        barr(16) = (var3 >> 8) Mod 256
        barr(17) = var4

        TCPsender.Send(barr)

        ' Receive the response from the remote device.  
        Dim bytes(100) As Byte
        Dim bytesRec As Integer = TCPsender.Receive(bytes)

        If bytesRec = 0 OrElse bytes(0) <> 6 Then
            Throw New Exception
        End If
    End Sub

    Public Sub TCP_DataTable_AddCommand(cmd As Object)
        Try
            Select Case cmd.GetType
                Case GetType(objCommand_Insert)
                    Dim tc As objCommand_Insert = cmd

                    TCP_DataTable_ModifyRow(DataTableRow, CMD_Insert, tc.Inserter, 0, 0, 0)

                Case GetType(objCommand_Move)
                    Dim tc As objCommand_Move = cmd

                    If CurrentSpeed = -1 AndAlso tc.Speed = -1 Then
                        MessageBox.Show("Program Must have set speed for first move")
                        Return
                    End If

                    If tc.Speed = -1 Then tc.Speed = CurrentSpeed

                    TCP_DataTable_ModifyRow(DataTableRow, CMD_MoveAbsolute, tc.X * 1000, tc.Y * 1000, tc.Speed, tc.Inserter)
                    CurrentSpeed = tc.Speed

                Case Else
                    MessageBox.Show("Bad Command")
                    Throw New Exception
            End Select

            DataTableRow += 1
        Catch ex As Exception
            MessageBox.Show("Exception: Data Table Command Load")
        End Try
    End Sub

    Public Sub TCP_GetSystemStatus()
        System.Threading.Thread.Sleep(TCP_Pause) 'Sending commands too fast results in them being skipped

        ' Send the data through the socket.  
        TCPsender.Send(System.Text.Encoding.ASCII.GetBytes("SS")) 'System Status

        ' Receive the response from the remote device.  
        Dim bytes(100) As Byte
        Dim bytesRec As Integer = TCPsender.Receive(bytes)

        If bytesRec > 0 Then 'Check for constants that should be there
            If bytes(0) <> Asc("S") AndAlso bytes(1) <> Asc("S") Then Throw New Exception
            If bytes(5) <> Asc("F") Then Throw New Exception
        End If

        Select Case bytes(2)
            Case 0
                PLC.XY.Running = False
                PLC.XY.Paused = False
            Case 1
                PLC.XY.Running = True
                PLC.XY.Paused = False
            Case 2
                PLC.XY.Running = False
                PLC.XY.Paused = True
        End Select

        PLC.XY.ProgramRowRunning = bytes(3) + bytes(4) * 256

        PLC.XY.Faults.InterLockTripped = bytes(6) And (1 << 0)
        PLC.XY.Faults.AirPressureLow = bytes(6) And (1 << 1)

        'Get bowl/inserter faults
        For i As Integer = 1 To 4
            PLC.XY.Faults.BowlFault_NoPart(i) = (bytes(7) And (1 << (i - 1)) > 0)
            PLC.XY.Faults.InserterArms(i).Fault_PartJam = (bytes(8) And (1 << (i - 1))) > 0
            PLC.XY.Faults.InserterArms(i).Fault_PartNotDetected = (bytes(9) And (1 << (i - 1))) > 0
            PLC.XY.Faults.InserterArms(i).Fault_ArmRetractFail = (bytes(10) And (1 << (i - 1))) > 0
            PLC.XY.Faults.InserterArms(i).Fault_ArmDownFail = (bytes(11) And (1 << (i - 1))) > 0
        Next
    End Sub

    Public Sub TCP_BowlStateChange(Bowl1On As Boolean, Bowl2On As Boolean, Bowl3On As Boolean, Bowl4On As Boolean)
        System.Threading.Thread.Sleep(TCP_Pause) 'Sending commands too fast results in them being skipped

        Dim barr() As Byte = {Asc("B"), Asc("S"), Asc("C"), 0}

        barr(3) = 0
        If Bowl1On Then barr(3) = barr(3) Or 1
        If Bowl2On Then barr(3) = barr(3) Or (1 << 1)
        If Bowl3On Then barr(3) = barr(3) Or (1 << 2)
        If Bowl4On Then barr(3) = barr(3) Or (1 << 3)

        TCPsender.Send(barr)

        ' Receive the response from the remote device.  
        Dim bytes(100) As Byte
        Dim bytesRec As Integer = TCPsender.Receive(bytes)

        If bytesRec = 0 OrElse bytes(0) <> 6 Then
            Throw New Exception
        End If
    End Sub
End Class
