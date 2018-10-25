Module CvE_Transmissions
    'Public Function SendCvE_wResponse(Tx As objCvE_Transmission, GetResponse As Boolean) As Byte()
    '    ' Send the data through the socket.  
    '    Dim bytesSent As Integer = TF.TCPsender.Send(Tx.GetByteString())

    '    ' Receive the response from the remote device.  
    '    Dim bytes(1024) As Byte
    '    Dim bytesRec As Integer = TF.TCPsender.Receive(bytes)

    '    If GetResponse Then
    '        Dim Rx As New objCvE_Transmission
    '        Rx.ResponseToCvE(bytes)

    '        Return Rx.DataByteString
    '    End If

    '    Return Nothing 'Don't need the response
    'End Function

    'Public Sub CvE_GetCCON_CPOS()
    '    Dim Tx As New objCvE_Transmission
    '    Tx.ObjectIndex = 240
    '    Tx.ObjectSubIndex = 0

    '    Dim test As Byte() = Tx.GetByteString()

    '    If Online Then
    '        Dim rarr() As Byte = SendCvE_wResponse(Tx, True)
    '        CCON = rarr(0)
    '        CPOS = rarr(1)
    '    End If
    'End Sub

    'Public Sub CvE_GetSCON_SPOS()
    '    Dim Tx As New objCvE_Transmission
    '    Tx.ObjectIndex = 239
    '    Tx.ObjectSubIndex = 0

    '    Dim test As Byte() = Tx.GetByteString()

    '    If Online Then
    '        Dim rarr() As Byte = SendCvE_wResponse(Tx, True)
    '        SCON = rarr(0)
    '        SPOS = rarr(1)
    '    End If
    'End Sub

    'Public Sub CvE_SetCvE_Control()
    '    Dim Tx As New objCvE_Transmission
    '    Tx.Write = True
    '    Tx.ObjectIndex = 3
    '    Tx.ObjectSubIndex = 0

    '    Tx.DataType = CvE_UINT8
    '    Dim barr() As Byte = {2}
    '    Tx.DataByteString = barr

    '    Dim test As Byte() = Tx.GetByteString()

    '    If Online Then SendCvE_wResponse(Tx, False)
    'End Sub

    'Public Sub CvE_EnableDirectDrive()
    '    Dim Tx As New objCvE_Transmission
    '    Tx.Write = True
    '    Tx.ObjectIndex = 240
    '    Tx.ObjectSubIndex = 0

    '    Tx.DataType = CvE_UINT16
    '    Dim barr() As Byte = {67, 0}
    '    Tx.DataByteString = barr

    '    Dim test As Byte() = Tx.GetByteString()

    '    If Online Then SendCvE_wResponse(Tx, False)
    'End Sub

    'Public Sub CvE_EnableDrive()
    '    Dim Tx As New objCvE_Transmission
    '    Tx.Write = True
    '    Tx.ObjectIndex = 240
    '    Tx.ObjectSubIndex = 0

    '    Tx.DataType = CvE_UINT16
    '    Dim barr() As Byte = {1, 0}
    '    Tx.DataByteString = barr

    '    Dim test As Byte() = Tx.GetByteString()

    '    If Online Then SendCvE_wResponse(Tx, False)
    'End Sub

    'Public Sub CvE_EnableOperation()
    '    Dim Tx As New objCvE_Transmission
    '    Tx.Write = True
    '    Tx.ObjectIndex = 240
    '    Tx.ObjectSubIndex = 0

    '    Tx.DataType = CvE_UINT16
    '    Dim barr() As Byte = {3, 0}
    '    Tx.DataByteString = barr

    '    Dim test As Byte() = Tx.GetByteString()

    '    If Online Then SendCvE_wResponse(Tx, False)
    'End Sub

    'Public Function CvE_GetActualX_Position() As Decimal
    '    Dim Tx As New objCvE_Transmission
    '    Tx.ObjectIndex = 303
    '    Tx.ObjectSubIndex = 0

    '    Dim Pos_Dec As Decimal = 0

    '    If Online Then
    '        Pos_Dec = BitConverter.ToInt32(SendCvE_wResponse(Tx, True), 0) / 1000
    '    End If

    '    Return Pos_Dec
    'End Function

    'Public Function CvE_GetActualY_Position() As Decimal
    '    Dim Tx As New objCvE_Transmission
    '    Tx.ObjectIndex = 303
    '    Tx.ObjectSubIndex = 1

    '    Dim Pos_Dec As Decimal = 0

    '    If Online Then
    '        Pos_Dec = BitConverter.ToInt32(SendCvE_wResponse(Tx, True), 0) / 1000
    '    End If

    '    Return Pos_Dec
    'End Function

    'Public Sub CvE_SetX_Position(pos As Decimal)
    '    Dim Tx As New objCvE_Transmission
    '    Tx.Write = True
    '    Tx.ObjectIndex = 305
    '    Tx.ObjectSubIndex = 0
    '    Tx.DataType = CvE_SINT32

    '    Dim posint As Int32 = pos * 1000 'Convert from thousands of mm
    '    Tx.DataByteString = BitConverter.GetBytes(posint)

    '    'Dim test As Byte() = Tx.GetByteString()
    '    SendCvE_wResponse(Tx, False)
    'End Sub

    'Public Sub CvE_SetY_Position(pos As Decimal)
    '    Dim Tx As New objCvE_Transmission
    '    Tx.Write = True
    '    Tx.ObjectIndex = 305
    '    Tx.ObjectSubIndex = 1
    '    Tx.DataType = CvE_SINT32

    '    Dim posint As Int32 = pos * 1000 'Convert from thousands of mm
    '    Tx.DataByteString = BitConverter.GetBytes(posint)

    '    'Dim test As Byte() = Tx.GetByteString()
    '    SendCvE_wResponse(Tx, False)
    'End Sub

    'Public Sub CvE_SetSpeed(val As UInt16)
    '    Dim Tx As New objCvE_Transmission
    '    Tx.Write = True
    '    Tx.ObjectIndex = 240
    '    Tx.ObjectSubIndex = 1

    '    Tx.DataType = CvE_UINT16
    '    Dim barr() As Byte = {val Mod 256, val \ 256}
    '    Tx.DataByteString = barr

    '    Dim test As Byte() = Tx.GetByteString()
    '    SendCvE_wResponse(Tx, False)
    'End Sub

    'Public Sub CvE_StartMotion()
    '    Dim Tx As New objCvE_Transmission
    '    Tx.Write = True
    '    Tx.ObjectIndex = 240
    '    Tx.ObjectSubIndex = 0

    '    Tx.DataType = CvE_UINT16
    '    Dim barr() As Byte = {67, 2}
    '    Tx.DataByteString = barr

    '    Dim test As Byte() = Tx.GetByteString()

    '    'Dim test As Byte() = Tx.GetByteString()
    '    SendCvE_wResponse(Tx, False)
    'End Sub

    'Public Sub CvE_ResetMotion()
    '    Dim Tx As New objCvE_Transmission
    '    Tx.Write = True
    '    Tx.ObjectIndex = 240
    '    Tx.ObjectSubIndex = 0

    '    Tx.DataType = CvE_UINT16
    '    Dim barr() As Byte = {67, 0}
    '    Tx.DataByteString = barr

    '    Dim test As Byte() = Tx.GetByteString()

    '    'Dim test As Byte() = Tx.GetByteString()
    '    SendCvE_wResponse(Tx, False)
    'End Sub

    'Public Sub CvE_HomeGantryStart()
    '    ' Dim Tx As New objCvE_Transmission
    '    'Tx.Write = True
    '    'Tx.ObjectIndex = 240
    '    'Tx.ObjectSubIndex = 0

    '    '        Tx.DataType = CvE_UINT16
    '    '       Dim barr() As Byte = {67, 0}
    '    '      Tx.DataByteString = barr

    '    ' Dim test As Byte() = Tx.GetByteString()

    '    'Dim test As Byte() = Tx.GetByteString()
    '    ' SendCvE_wResponse(Tx, False)

    '    Dim Tx As New objCvE_Transmission
    '    Tx.Write = True
    '    Tx.ObjectIndex = 240
    '    Tx.ObjectSubIndex = 0

    '    Tx.DataType = CvE_UINT16
    '    Dim barr() As Byte = {67, 4}
    '    Tx.DataByteString = barr

    '    Dim test As Byte() = Tx.GetByteString()

    '    SendCvE_wResponse(Tx, False)
    'End Sub

    'Public Sub CvE_HomeGantryComplete()
    '    Dim Tx As New objCvE_Transmission
    '    Tx.Write = True
    '    Tx.ObjectIndex = 240
    '    Tx.ObjectSubIndex = 0

    '    Tx.DataType = CvE_UINT16
    '    Dim barr() As Byte = {67, 0}
    '    Tx.DataByteString = barr

    '    Dim test As Byte() = Tx.GetByteString()

    '    SendCvE_wResponse(Tx, False)
    'End Sub
End Module
