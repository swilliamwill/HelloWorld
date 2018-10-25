Public Class objCvE_Transmission
    'Public Shared CurrentMessageID As UInt32 = 0

    Property Write As Boolean = False
    Property MessageID As UInt32
    Property DataLength As UInt32 = 4
    Property Acknowledge As Byte
    Property ObjectIndex As UInt16
    Property ObjectSubIndex As Byte

    Property DataType As Byte

    Private _Data(0) As Byte

    Public Sub New(Optional newMessageID As UInt32 = 0)
        MessageID = newMessageID
    End Sub

    Private Sub UINT32_ToLE_ByteArray(ByRef barr As Byte(), index As Integer, num As UInt32)
        barr(index) = num Mod 256
        barr(index + 1) = (num >> 8) Mod 256
        barr(index + 2) = (num >> 16) Mod 256
        barr(index + 3) = (num >> 24) Mod 256
    End Sub

    Private Sub UINT16_ToLE_ByteArray(ByRef barr As Byte(), index As Integer, num As UInt16)
        barr(index) = num Mod 256
        barr(index + 1) = (num >> 8) Mod 256
    End Sub

    ' Public Sub New(_write As Boolean, mID As UInt32, objind As UInt16)
    Public Property DataByteString As Byte()
        Get
            Return _Data
        End Get
        Set(value As Byte())
            ReDim _Data(UBound(value))

            _Data = value
        End Set
    End Property

    Public Function GetByteString() As Byte()
        'Dim len As Integer = 17 'Keep it easy for now
        Dim len As Integer = 18

        If Write Then
            len += _Data.Length
            DataLength = 4 + _Data.Length
        End If

        Dim barr(len - 1) As Byte

        barr(0) = If(Write, &H11, &H10) 'Assign write/read character
        UINT32_ToLE_ByteArray(barr, 1, MessageID)
        UINT32_ToLE_ByteArray(barr, 5, DataLength)
        UINT16_ToLE_ByteArray(barr, 14, ObjectIndex)
        barr(&H10) = ObjectSubIndex
        barr(&H11) = 0

        If Write Then
            barr(&H11) = DataType

            For i = 0 To UBound(_Data)
                barr(&H12 + i) = _Data(i)
            Next
        End If

        Return barr
    End Function

    Public Sub ResponseToCvE(barr As Byte())
        If (barr(&H0) <> &H10) AndAlso (barr(&H0) <> &H11) Then Throw New Exception

        Write = (barr(&H0) = &H11)
        MessageID = BitConverter.ToUInt32(barr, &H1)
        DataLength = BitConverter.ToUInt32(barr, &H5)
        ObjectIndex = BitConverter.ToUInt16(barr, &HE)
        ObjectSubIndex = barr(&H10)

        If Not Write Then
            DataType = barr(&H11)

            'If we have a data packet redim the array and populate it
            If DataLength > 4 Then
                ReDim _Data(DataLength - 5)

                For i As Integer = 0 To DataLength - 5
                    _Data(i) = barr(&H12 + i)
                Next
            End If
        End If
    End Sub
End Class
