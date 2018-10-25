Public Class UI_Setup
    Private Sub UF_IP_Address_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LAB_Trick.Select()
        'Populate PLC IP
        NUD_IP_Byte1.Value = PLC.IP_Addr.Split(".")(0)
        NUD_IP_Byte2.Value = PLC.IP_Addr.Split(".")(1)
        NUD_IP_Byte3.Value = PLC.IP_Addr.Split(".")(2)
        NUD_IP_Byte4.Value = PLC.IP_Addr.Split(".")(3)

        NUD_Port.Value = PLC.Port

        'Populate color picker colors and number boxes
        For i As Integer = 1 To NumberOfInserters
            CType(Me.Controls.Find("TB_InserterDescription_" & i, True)(0), TextBox).Text = InserterDescription(i)
            CType(Me.Controls.Find("NUD_InsertX_" & i, True)(0), NumericUpDown).Value = InserterX(i)
            CType(Me.Controls.Find("NUD_InsertY_" & i, True)(0), NumericUpDown).Value = InserterY(i)
            Me.Controls.Find("ColorPicker_Back_" & i, True)(0).BackColor = InserterColors(i)
        Next

        NUD_GantrySpeed.Value = GantrySpeed
    End Sub

    Private Sub BUTT_Cancel_Click(sender As Object, e As EventArgs) Handles BUTT_Cancel.Click
        Me.Close()
    End Sub

    Private Sub BUTT_OK_Click(sender As Object, e As EventArgs) Handles BUTT_OK.Click
        PLC.IP_Addr = NUD_IP_Byte1.Value & "." & NUD_IP_Byte2.Value & "." & NUD_IP_Byte3.Value & "." & NUD_IP_Byte4.Value
        PLC.Port = NUD_Port.Value

        Dim oWrite As System.IO.StreamWriter = New IO.StreamWriter(FILE_INI)

        oWrite.WriteLine("[PLC IP Address]")
        oWrite.WriteLine("IP Address=" & PLC.IP_Addr)
        oWrite.WriteLine("Port=" & PLC.Port)
        oWrite.Close()

        Me.Close()

        For i As Integer = 1 To 4
            InserterDescription(i) = Me.Controls.Find("TB_InserterDescription_" & i, True)(0).Text
            InserterX(i) = CType(Me.Controls.Find("NUD_InsertX_" & i, True)(0), NumericUpDown).Value
            InserterY(i) = CType(Me.Controls.Find("NUD_InsertY_" & i, True)(0), NumericUpDown).Value
            InserterColors(i) = Me.Controls.Find("ColorPicker_Back_" & i, True)(0).BackColor
        Next

        INI_SaveFile(FILE_INI)
    End Sub

    Private Sub ColorPick_Click(sender As Object, e As EventArgs) Handles ColorPicker_Back_1.Click, ColorPicker_Back_2.Click, ColorPicker_Back_3.Click, ColorPicker_Back_4.Click
        Dim tc = CType(sender, Panel) 'Force the sender back into correct type

        Dim ColorNum As Integer = tc.Name.Split("_")(2)

        If ColorDialog1.ShowDialog = DialogResult.OK Then tc.BackColor = ColorDialog1.Color 'Just change the background. We assign it on "OK"
    End Sub

    Private Sub BUTT_Teach_Click(sender As Object, e As EventArgs) Handles BUTT_Teach_1.Click, BUTT_Teach_2.Click, BUTT_Teach_3.Click, BUTT_Teach_4.Click

        Dim tc = CType(sender, Button) 'Force the sender back into correct type

        Dim Num As Integer = tc.Name.Split("_")(2)

        'Populate color picker colors and number boxes
        For i As Integer = 1 To NumberOfInserters
            CType(Me.Controls.Find("NUD_InsertX_" & Num, True)(0), NumericUpDown).Value = NUD_Xpos_Set.Value
            CType(Me.Controls.Find("NUD_InsertY_" & Num, True)(0), NumericUpDown).Value = NUD_Ypos_Set.Value
        Next
    End Sub

    Private Sub BUTT_GO_Click(sender As Object, e As EventArgs) Handles BUTT_GO.Click
        'TB_Trick.Focus()

        Dim command As New objCommand_Move
        command.Relative = False
        command.X = NUD_Xpos_Set.Value
        command.Y = NUD_Ypos_Set.Value
        command.Speed = NUD_GantrySpeed.Value

        PLC.TCP_CommandMove(command)
    End Sub

    Private Sub BUTT_Jog_XP_Click(sender As Object, e As EventArgs) Handles BUTT_Jog_XP.Click
        NUD_Xpos_Set.Value += NUD_JogIncrement.Value
        Dim tc As New objCommand_Move
        tc.X = NUD_Xpos_Set.Value
        tc.Y = NUD_Ypos_Set.Value
        tc.Speed = GantrySpeed

        PLC.TCP_CommandMove(tc)
    End Sub

    Private Sub BUTT_Jog_XN_Click(sender As Object, e As EventArgs) Handles BUTT_Jog_XN.Click
        NUD_Xpos_Set.Value -= NUD_JogIncrement.Value
        Dim tc As New objCommand_Move
        tc.X = NUD_Xpos_Set.Value
        tc.Y = NUD_Ypos_Set.Value
        tc.Speed = GantrySpeed

        PLC.TCP_CommandMove(tc)
    End Sub

    Private Sub BUTT_Jog_YP_Click(sender As Object, e As EventArgs) Handles BUTT_Jog_YP.Click
        NUD_Ypos_Set.Value += NUD_JogIncrement.Value
        Dim tc As New objCommand_Move
        tc.X = NUD_Xpos_Set.Value
        tc.Y = NUD_Ypos_Set.Value
        tc.Speed = GantrySpeed

        PLC.TCP_CommandMove(tc)
    End Sub

    Private Sub BUTT_Jog_YN_Click(sender As Object, e As EventArgs) Handles BUTT_Jog_YN.Click
        NUD_Ypos_Set.Value -= NUD_JogIncrement.Value
        Dim tc As New objCommand_Move
        tc.X = NUD_Xpos_Set.Value
        tc.Y = NUD_Ypos_Set.Value
        tc.Speed = GantrySpeed

        PLC.TCP_CommandMove(tc)
    End Sub

    Private Sub UI_Setup_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Exit Sub

        LAB_Trick.Select()

        Select Case e.KeyCode
            Case Keys.Tab 'Kill tab
                e.Handled = True

            Case Keys.Left
                If BUTT_Jog_XN.Enabled Then BUTT_Jog_XN.PerformClick()
                e.Handled = True 'Prevent the key from being sent otherwise

            Case Keys.Right
                If BUTT_Jog_XP.Enabled Then BUTT_Jog_XP.PerformClick()
                e.Handled = True 'Prevent the key from being sent otherwise

            Case Keys.Up
                If BUTT_Jog_YP.Enabled Then BUTT_Jog_YP.PerformClick()
                e.Handled = True 'Prevent the key from being sent otherwise

            Case Keys.Down
                If BUTT_Jog_YN.Enabled Then BUTT_Jog_YN.PerformClick()
                e.Handled = True 'Prevent the key from being sent otherwise

            Case Else 'We only handle the arrows
        End Select
    End Sub

    Private Sub BUTT_GoToLoad_Click(sender As Object, e As EventArgs) Handles BUTT_GoToLoad.Click
        NUD_Xpos_Set.Value = 55
        NUD_Ypos_Set.Value = 0
        Dim tc As New objCommand_Move
        tc.X = NUD_Xpos_Set.Value
        tc.Y = NUD_Ypos_Set.Value
        tc.Speed = GantrySpeed

        PLC.TCP_CommandMove(tc)
    End Sub
End Class