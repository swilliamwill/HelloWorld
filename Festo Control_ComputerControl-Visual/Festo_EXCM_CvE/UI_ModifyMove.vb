Public Class UI_ModifyMove
    Private OriginalCommand As objCommand_Move
    'Private REF_Command As objCommand_Move

    Property REF_Command As objCommand_Move

    Private Sub UF_ModifyMove_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BUTT_GO.Enabled = Online
    End Sub

    Public Sub LoadMove(cmd As objCommand_Move)
        BUTT_GO.Enabled = Online

        REF_Command = cmd

        NUD_Xpos_Set.Value = cmd.X
        NUD_Ypos_Set.Value = cmd.Y
        NUD_Speed.Value = cmd.Speed
    End Sub

    'Public Sub ShowMove(cmd As objCommand_Move)

    '    REF_Command = cmd 'Set up reference for modifying command

    '    'Set up original command for cancellation
    '    OriginalCommand.Relative = False
    '    OriginalCommand.X = cmd.X
    '    OriginalCommand.Y = cmd.Y
    '    OriginalCommand.Speed = cmd.Speed

    '    cmd.Relative = False
    '    NUD_Xpos_Set.Value = cmd.X
    '    NUD_Ypos_Set.Value = cmd.Y
    '    NUD_Speed.Value = cmd.Speed
    'End Sub

    Private Sub BUTT_Cancel_Click(sender As Object, e As EventArgs) Handles BUTT_Cancel.Click
        Me.Close()
    End Sub

    Private Sub BUTT_OK_Click(sender As Object, e As EventArgs) Handles BUTT_OK.Click
        'Remember here that REF_Command will modify the actual command sent here by reference

        UserProgram_Undos.CopyFromUP(UserProgram) 'Create undo

        REF_Command.X = NUD_Xpos_Set.Value
        REF_Command.Y = NUD_Ypos_Set.Value
        REF_Command.Speed = NUD_Speed.Value

        Me.Close()
    End Sub

    Private Sub BUTT_GO_Click(sender As Object, e As EventArgs) Handles BUTT_GO.Click
        Dim command As New objCommand_Move

        command.Relative = False
        command.X = NUD_Xpos_Set.Value
        command.Y = NUD_Ypos_Set.Value
        command.Speed = NUD_Speed.Value

        PLC.TCP_CommandMove(command)
    End Sub
End Class