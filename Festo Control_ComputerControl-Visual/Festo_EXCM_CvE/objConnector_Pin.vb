Imports System.ComponentModel

Public Class objConnector_Pin
    Property Name As String
    Property X As Decimal
    Property Y As Decimal
    Property Diameter As Decimal
    <Browsable(False)> Property DisplayLabel As Boolean = True

    'Property Used As Boolean = False
    'Property InserterNumber As Integer
    <Browsable(False)> Property InsertOrder As String = "" 'This is a string of numbers,the inserts will be done in order of the string

    Function Used() As Boolean
        Return InsertOrder <> ""
    End Function
End Class
