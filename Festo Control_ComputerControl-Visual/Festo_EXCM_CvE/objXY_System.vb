Public Class objInserterArm
    Property Fault_ArmDownFail As Boolean = False
    Property Fault_ArmRetractFail As Boolean = False
    Property Fault_PartJam As Boolean = False
    Property Fault_PartNotDetected As Boolean = False
End Class

Public Class objXY_Faults
    Public InserterArms(4) As objInserterArm

    'System Faults
    Public InterLockTripped As Boolean = False 'bit 0
    Public AirPressureLow As Boolean = False 'bit 1

    Public BowlFault_NoPart As Boolean() = {False, False, False, False, False}

    Public Sub New()
        For i As Integer = 0 To 4
            InserterArms(i) = New objInserterArm
        Next
    End Sub
End Class

Public Class objXY_System
    Property Running As Boolean = False
    'Property Stopped As Boolean = False
    Property Paused As Boolean = False

    Property ProgramRowRunning As Integer = 0

    Property Faults As New objXY_Faults


    Function HasFault() As Boolean
        If Faults.InterLockTripped Then Return True
        If Faults.AirPressureLow Then Return True

        For Each b As Boolean In Faults.BowlFault_NoPart
            If b = True Then Return True
        Next

        For Each i As objInserterArm In Faults.InserterArms
            If i.Fault_ArmDownFail Then Return True
            If i.Fault_ArmRetractFail Then Return True
            If i.Fault_PartJam Then Return True
            If i.Fault_PartNotDetected Then Return True
        Next

        Return False
    End Function
End Class
