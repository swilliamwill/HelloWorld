Public Class UI_Error
    Private Sub UI_Error_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TB_Errors.Text = "The System has Encountered the Following Error(s):" & vbCrLf & vbCrLf

        If PLC.XY.Faults.AirPressureLow Then TB_Errors.Text &= "Air Pressure Low-Check Supply Switch" & vbCrLf
        If PLC.XY.Faults.InterLockTripped Then TB_Errors.Text &= "Safety Interlock Tripped-Close Cover" & vbCrLf

        For i As Integer = 1 To 4
            If PLC.XY.Faults.InserterArms(i).Fault_ArmDownFail Then TB_Errors.Text &= "Inserter-" & i & " Arm Did Not Move-Check Air Line/Movement" & vbCrLf
            If PLC.XY.Faults.InserterArms(i).Fault_ArmRetractFail Then TB_Errors.Text &= "Inserter-" & i & " Arm Did Not Return Up-Check Air Line/Movement" & vbCrLf
            If PLC.XY.Faults.InserterArms(i).Fault_PartJam Then TB_Errors.Text &= "Part Jam at Inserter-" & i & " Remove Cover and Clear Jam" & vbCrLf
            If PLC.XY.Faults.InserterArms(i).Fault_PartNotDetected Then TB_Errors.Text &= "No Part Detected at Inserter-" & i & "-Check Part Line" & vbCrLf
            If PLC.XY.Faults.BowlFault_NoPart(i) Then TB_Errors.Text &= "No Part Detected in Bowl-" & i & "-Check Bowl" & vbCrLf
        Next
    End Sub

    Private Sub BUTT_Retry_Click(sender As Object, e As EventArgs) Handles BUTT_Retry.Click
        'PLC.TCP_SystemCommand_Run()
        TF.BUTT_ProgramRun.PerformClick()
        Me.Close()
    End Sub

    Private Sub BUTT_Stop_Click(sender As Object, e As EventArgs) Handles BUTT_Stop.Click
        PLC.TCP_SystemCommand_Stop()
        TF.DisableControlsForRunning(False)
        Me.Close()
    End Sub
End Class