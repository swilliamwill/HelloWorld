Imports System.Net
Imports System.Net.Sockets

Public Class classGantry
    Const TCP_Pause As Integer = 25

    'Integer constants
    Const ConCvE_UINT32 As Byte = 2
    Const ConCvE_UINT16 As Byte = 3
    Const ConCvE_UINT8 As Byte = 4
    Const ConCvE_SINT32 As Byte = 6
    Const ConCvE_SINT16 As Byte = 7
    Const ConCvE_SINT8 As Byte = 8

    'Object (Sub)Indexes

    Const ConCvE_MasterControl_Index As UInt16 = 3
    Const ConCvE_MasterControl_SubIndex As Byte = 0
    Const ConCvE_StatusWord_Index As UInt16 = 239
    Const ConCvE_StatusWord_SubIndex As Byte = 0
    Const ConCvE_ErrorNumber_Index As UInt16 = 239
    Const ConCvE_ErrorNumber_SubIndex As Byte = 1
    Const ConCvE_ControlWord_Index As UInt16 = 240
    Const ConCvE_ControlWord_SubIndex As Byte = 0
    Const ConCvE_Speed_Index As UInt16 = 240
    Const ConCvE_Speed_SubIndex As Byte = 1


    'IP connect variables
    Property IP_Addr As IPAddress = IPAddress.Parse("192.168.178.1")
    'Property Port As Integer = 49700
    Property Port As Integer = 30000
    Property TCPsender As Socket
    Property Online As Boolean = False

    'Gantry Command/Status Variables
    Property CCON As Byte
    Property CPOS As Byte
    Property SCON As Byte
    Property SPOS As Byte

    Private MessageIndex As UInt32

    'Current Settings
    Property Speed As Decimal = -1
    Property Acceleration As Decimal

    Property X_Current As Decimal
    Property Y_Current As Decimal
    Property X_Target As Decimal
    Property Y_Target As Decimal

    ReadOnly Property X_Max As Decimal = 150
    ReadOnly Property Y_Max As Decimal = 110

    Property MotionStarted As Boolean = False

#Region "CvE Commands"
    Private Function SendTCP_AndGetResponse(Tx As objCvE_Transmission) As objCvE_Transmission
        System.Threading.Thread.Sleep(TCP_Pause) 'Sending commands too fast results in them being skipped

        ' Send the data through the socket.  
        Dim bytesSent As Integer = TCPsender.Send(Tx.GetByteString())

        ' Receive the response from the remote device.  
        Dim bytes(1024) As Byte
        Dim bytesRec As Integer = TCPsender.Receive(bytes)

        Dim Rx As New objCvE_Transmission
        Rx.ResponseToCvE(bytes)
        Return Rx
    End Function

    Private Sub CvE_GetCCON_CPOS()
        Dim Tx As New objCvE_Transmission(MessageIndex)
        MessageIndex += 1
        Tx.ObjectIndex = ConCvE_ControlWord_Index
        Tx.ObjectSubIndex = ConCvE_ControlWord_SubIndex

        Dim test As Byte() = Tx.GetByteString()

        Dim Rx As objCvE_Transmission = SendTCP_AndGetResponse(Tx)
        CCON = Rx.DataByteString(0)
        CPOS = Rx.DataByteString(1)
    End Sub

    Private Sub CvE_GetSCON_SPOS()
        Dim Tx As New objCvE_Transmission(MessageIndex)
        MessageIndex += 1
        Tx.ObjectIndex = ConCvE_StatusWord_Index
        Tx.ObjectSubIndex = ConCvE_StatusWord_SubIndex

        Dim test As Byte() = Tx.GetByteString()

        Dim Rx As objCvE_Transmission = SendTCP_AndGetResponse(Tx)
        SCON = Rx.DataByteString(0)
        SPOS = Rx.DataByteString(1)
    End Sub

    Private Sub CvE_SetCCON_CPOS(NewCCON As Byte, NewCPOS As Byte)
        Dim Tx As New objCvE_Transmission(MessageIndex)
        MessageIndex += 1
        Tx.Write = True
        Tx.ObjectIndex = ConCvE_ControlWord_Index
        Tx.ObjectSubIndex = ConCvE_ControlWord_SubIndex

        Tx.DataType = ConCvE_UINT16
        Dim barr() As Byte = {NewCCON, NewCPOS}
        Tx.DataByteString = barr

        Dim test As Byte() = Tx.GetByteString()

        CCON = NewCCON
        CPOS = NewCPOS

        SendTCP_AndGetResponse(Tx)
    End Sub

    Private Sub CvE_SetSCON_SPOS(NewSCON As Byte, NewSPOS As Byte)
        Dim Tx As New objCvE_Transmission(MessageIndex)
        MessageIndex += 1
        Tx.Write = True
        Tx.ObjectIndex = ConCvE_StatusWord_Index
        Tx.ObjectSubIndex = ConCvE_StatusWord_SubIndex

        Tx.DataType = ConCvE_UINT16
        Dim barr() As Byte = {NewSCON, NewSPOS}
        Tx.DataByteString = barr

        Dim test As Byte() = Tx.GetByteString()

        SCON = NewSCON
        SPOS = NewSPOS

        SendTCP_AndGetResponse(Tx)
    End Sub

    Private Sub CvE_SetCvE_Control()
        Dim Tx As New objCvE_Transmission(MessageIndex)
        MessageIndex += 1
        Tx.Write = True
        Tx.ObjectIndex = ConCvE_MasterControl_Index
        Tx.ObjectSubIndex = ConCvE_MasterControl_SubIndex

        Tx.DataType = ConCvE_UINT8
        Dim barr() As Byte = {2}
        Tx.DataByteString = barr

        Dim test As Byte() = Tx.GetByteString()

        SendTCP_AndGetResponse(Tx)
    End Sub

    Private Sub CvE_EnableDirectDriveAbsolute()
        CvE_SetCCON_CPOS(CCON Or &H40, 0)
    End Sub

    Private Sub CvE_EnableDrive()
        CvE_SetCCON_CPOS(CCON Or 1, 0)
    End Sub

    Private Sub CvE_EnableOperation()
        CvE_SetCCON_CPOS(CCON Or 2, 0)
    End Sub

    Private Sub CvE_EnableDrive_All()
        CvE_SetCCON_CPOS(CCON Or &H40 Or 1 Or 2, 0)
    End Sub

    Public Function CvE_GetActualX_Position() As Decimal
        Dim Tx As New objCvE_Transmission(MessageIndex)
        MessageIndex += 1
        Tx.ObjectIndex = 303
        Tx.ObjectSubIndex = 0

        Dim Pos_Dec As Decimal = 0

        If Online Then
            Pos_Dec = BitConverter.ToInt32(SendTCP_AndGetResponse(Tx).DataByteString, 0) / 1000
            X_Current = Pos_Dec
        End If

        Return Pos_Dec
    End Function

    Public Function CvE_GetActualY_Position() As Decimal
        Dim Tx As New objCvE_Transmission(MessageIndex)
        MessageIndex += 1
        Tx.ObjectIndex = 303
        Tx.ObjectSubIndex = 1

        Dim Pos_Dec As Decimal = 0

        If Online Then
            Pos_Dec = BitConverter.ToInt32(SendTCP_AndGetResponse(Tx).DataByteString, 0) / 1000
            Y_Current = Pos_Dec
        End If

        Return Pos_Dec
    End Function

    Public Sub CvE_SetX_Position(pos As Decimal)
        Dim Tx As New objCvE_Transmission(MessageIndex)
        MessageIndex += 1
        Tx.Write = True
        Tx.ObjectIndex = 305
        Tx.ObjectSubIndex = 0
        Tx.DataType = ConCvE_SINT32

        Dim posint As Int32 = pos * 1000 'Convert from thousands of mm
        Tx.DataByteString = BitConverter.GetBytes(posint)

        SendTCP_AndGetResponse(Tx)
        X_Target = pos
    End Sub

    Public Sub CvE_SetY_Position(pos As Decimal)
        Dim Tx As New objCvE_Transmission(MessageIndex)
        MessageIndex += 1
        Tx.Write = True
        Tx.ObjectIndex = 305
        Tx.ObjectSubIndex = 1
        Tx.DataType = ConCvE_SINT32

        Dim posint As Int32 = pos * 1000 'Convert from thousands of mm
        Tx.DataByteString = BitConverter.GetBytes(posint)

        SendTCP_AndGetResponse(Tx)
        Y_Target = pos
    End Sub

    Public Sub CvE_SetSpeed(val As UInt16)
        Dim Tx As New objCvE_Transmission(MessageIndex)
        MessageIndex += 1
        Tx.Write = True
        Tx.ObjectIndex = ConCvE_Speed_Index
        Tx.ObjectSubIndex = ConCvE_Speed_SubIndex

        Tx.DataType = ConCvE_UINT16
        Dim barr() As Byte = {val Mod 256, val \ 256}
        Tx.DataByteString = barr

        Dim test As Byte() = Tx.GetByteString()
        SendTCP_AndGetResponse(Tx)

        Speed = val
    End Sub

    Public Sub CvE_StartMotion()
        Dim Tx As New objCvE_Transmission(MessageIndex)
        MessageIndex += 1
        Tx.Write = True
        Tx.ObjectIndex = ConCvE_ControlWord_Index
        Tx.ObjectSubIndex = ConCvE_ControlWord_SubIndex

        Tx.DataType = ConCvE_UINT16
        Dim barr() As Byte = {67, 2}
        Tx.DataByteString = barr

        SendTCP_AndGetResponse(Tx)
    End Sub

    Public Sub CvE_ResetMotion()
        Dim Tx As New objCvE_Transmission(MessageIndex)
        MessageIndex += 1
        Tx.Write = True
        Tx.ObjectIndex = 240
        Tx.ObjectSubIndex = 0

        Tx.DataType = ConCvE_UINT16
        Dim barr() As Byte = {67, 0}
        Tx.DataByteString = barr

        SendTCP_AndGetResponse(Tx)
    End Sub

    Public Sub CvE_HomeGantryStart()
        X_Target = 0 'Here for UI update
        Y_Target = 0 'Here for UI update

        Dim Tx As New objCvE_Transmission(MessageIndex)
        MessageIndex += 1
        Tx.Write = True
        Tx.ObjectIndex = 240
        Tx.ObjectSubIndex = 0

        Tx.DataType = ConCvE_UINT16
        Dim barr() As Byte = {67, 4}
        Tx.DataByteString = barr

        Dim test As Byte() = Tx.GetByteString()

        SendTCP_AndGetResponse(Tx)
    End Sub
#End Region

#Region "Status Commands"
    Public Function HomingRequired() As Boolean
        CvE_GetSCON_SPOS()

        'Return (SPOS And &B1000_0000) > 0
        Return (SPOS And &H80) = 0
    End Function

    Public Function ReadyToStart() As Boolean
        CvE_GetSCON_SPOS()
        'Return (SPOS And &B0000_0010) > 0
        Return (SPOS And &H2) = 0
    End Function

    Public Function HasWarning() As Boolean
        CvE_GetSCON_SPOS()
        Return (SCON And &H4) > 0
    End Function

    Public Function HasMalfunction() As Boolean
        CvE_GetSCON_SPOS()
        'Return (SCON And &B0000_1000) > 0
        Return (SCON And &H8) > 0
    End Function

    Public Function MotionComplete() As Boolean
        CvE_GetSCON_SPOS()
        Dim Moving As Boolean = False

        If ((SPOS And &H4) = 0) Then Moving = True
        If ((SPOS And &H10) > 0) Then Moving = True
        'Return (SPOS And &B0000_0100) > 0

        'Return (SPOS And &H10) > 0
        Return Not Moving
    End Function

    Public Function ClearError() As Boolean
        CvE_SetCCON_CPOS(CCON Or 8, 0)

        System.Threading.Thread.Sleep(2000)

        Return (Not HasMalfunction())
    End Function
#End Region

#Region "Accessable Comands"

    Public Function TCP_Connect(open As Boolean) As Boolean
        If open Then
            Try
                Dim IP_Addr As IPAddress = IPAddress.Parse("192.168.178.1")
                ' Dim Port As Integer = 30000
                Dim remoteEP As New IPEndPoint(IP_Addr, Port)

                ' Create a TCP/IP socket.  
                TCPsender = New Socket(IP_Addr.AddressFamily, SocketType.Stream, ProtocolType.Tcp)
                TCPsender.Connect(remoteEP) 'Connect the socket to the remote endpoint.  

                Online = True

                'Now that we're connected set the control to CvE
                CvE_SetCvE_Control()
                CvE_GetCCON_CPOS()
                ' CvE_GetSCON_SPOS()

                If HasMalfunction() Then
                    If Not ClearError() Then
                        MessageBox.Show("ERROR: Malfunction on gantry. Look at Error Code LEDs to Resolve")
                    End If
                End If

                Return True
            Catch ex As Exception
                MessageBox.Show("Could not connect to gantry" & vbCrLf & vbCrLf & ex.Message)
            End Try
        Else
            Try
                If Online Then
                    TCPsender.Shutdown(SocketShutdown.Both)
                    TCPsender.Close()
                End If

                Return True
            Catch ex As Exception
                MessageBox.Show("Could not disconnect from gantry" & vbCrLf & vbCrLf & ex.Message)
            End Try
        End If

        Return False
    End Function

    Public Sub EnableDrive(Optional enable As Boolean = True)
        If Not Online Then
            MessageBox.Show("Gantry is not online. Please connect before attempting operation")
            Exit Sub
        End If

        'CvE_EnableDrive()
        'CvE_EnableOperation()
        'CvE_EnableDirectDriveAbsolute()
        CvE_EnableDrive_All()
    End Sub

    'Basic Settings
    Public Sub Setspeed(NewSpeed As Decimal)
        If Not Online Then
            MessageBox.Show("Gantry is not online. Please connect before attempting operation")
            Exit Sub
        End If

        CvE_SetSpeed(NewSpeed)
        Speed = NewSpeed
    End Sub

    Public Sub HomeGantry()
        If Not Online Then
            MessageBox.Show("Gantry is not online. Please connect before attempting operation")
            Exit Sub
        End If

        If Not ReadyToStart() Then CvE_ResetMotion()

        CvE_HomeGantryStart()
        MotionStarted = True

        'Wait for motion to finish
        'CvE_ResetMotion()
    End Sub

    Public Function GetCurrentXY_Position() As Decimal()
        If Not Online Then
            MessageBox.Show("Gantry is not online. Please connect before attempting operation")
            Return Nothing
        End If

        Dim xy(1) As Decimal
        xy(0) = CvE_GetActualX_Position()
        xy(1) = CvE_GetActualY_Position()

        Return xy
    End Function

    Public Sub GoToXY_Position(x As Decimal, y As Decimal)
        If Not Online Then
            MessageBox.Show("Gantry is not online. Please connect before attempting operation")
            Exit Sub
        End If

        If Speed = -1 Then
            MessageBox.Show("Speed has not been set, set speed before operating")
            Exit Sub
        End If

        If x <> X_Target Then CvE_SetX_Position(x)
        If y <> Y_Target Then CvE_SetY_Position(y)

        If Not ReadyToStart() Then CvE_ResetMotion()
        CvE_StartMotion()

        MotionStarted = True
    End Sub

    Public Sub ExecuteCommand(command As objCommand_Move)
        If Not Online Then
            MessageBox.Show("Gantry is not online. Please connect before attempting operation")
            Exit Sub
        End If

        Dim x As Decimal, y As Decimal

        Select Case command.GetType
            Case GetType(objCommand_Move)
                If command.Relative Then
                    x = X_Target + command.X
                    y = Y_Target + command.Y
                Else
                    x = command.X
                    y = command.Y
                End If

                If command.Speed > 0 Then
                    If command.Speed <> Speed Then CvE_SetSpeed(command.Speed)
                End If

                GoToXY_Position(x, y)
            Case Else
                MessageBox.Show("Wha?")
        End Select

    End Sub

#End Region
End Class
