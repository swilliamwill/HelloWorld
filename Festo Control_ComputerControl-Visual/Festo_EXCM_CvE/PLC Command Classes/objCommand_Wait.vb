Public Class objCommand_Wait
    Private _WaitTime_ms

    Public Property Seconds As Decimal
        Get
            Return _WaitTime_ms / 1000
        End Get
        Set(value As Decimal)
            _WaitTime_ms = value * 1000
        End Set
    End Property

    Public Property ms As Integer
        Get
            Return _WaitTime_ms
        End Get
        Set(value As Integer)
            _WaitTime_ms = value
        End Set
    End Property
End Class
