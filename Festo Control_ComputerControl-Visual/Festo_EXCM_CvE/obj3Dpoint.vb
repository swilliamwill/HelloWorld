Public Class obj3Dpoint
    Property X As Decimal = 0
    Property Y As Decimal = 0
    Property Z As Decimal = 0

    Public Sub New()
    End Sub

    Public Sub New(_X As Decimal, _Y As Decimal, Optional _Z As Decimal = 0)
        X = _X
        Y = _Y
        Z = _Z
    End Sub

    Public Shared Operator +(ByVal p1 As obj3Dpoint, p2 As obj3Dpoint) As obj3Dpoint
        Dim NewPoint As New obj3Dpoint

        NewPoint.X = p1.X + p2.X
        NewPoint.Y = p1.Y + p2.Y
        NewPoint.Z = p1.Z + p2.Z

        Return NewPoint
    End Operator

    Public Shared Operator -(ByVal p1 As obj3Dpoint, p2 As obj3Dpoint) As obj3Dpoint
        Dim NewPoint As New obj3Dpoint

        NewPoint.X = p1.X - p2.X
        NewPoint.Y = p1.Y - p2.Y
        NewPoint.Z = p1.Z - p2.Z

        Return NewPoint
    End Operator

    Public Shared Operator *(ByVal p1 As obj3Dpoint, n As Decimal) As obj3Dpoint
        Dim NewPoint As New obj3Dpoint

        NewPoint.X = p1.X * n
        NewPoint.Y = p1.Y * n
        NewPoint.Z = p1.Z * n

        Return NewPoint
    End Operator

    Public Shared Operator /(ByVal p1 As obj3Dpoint, n As Decimal) As obj3Dpoint
        Dim NewPoint As New obj3Dpoint

        NewPoint.X = p1.X / n
        NewPoint.Y = p1.Y / n
        NewPoint.Z = p1.Z / n

        Return NewPoint
    End Operator
End Class