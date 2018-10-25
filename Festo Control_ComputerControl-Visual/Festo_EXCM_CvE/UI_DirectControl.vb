Public Class UI_DirectControl
    Private Sub UI_DirectControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub UI_DirectControl_Opened(sender As Object, e As EventArgs) Handles MyBase.Activated
        CBUTT_Bowl1.BackColor = InserterColors(1)
        CBUTT_Bowl2.BackColor = InserterColors(2)
        CBUTT_Bowl3.BackColor = InserterColors(3)
        CBUTT_Bowl4.BackColor = InserterColors(4)

        LAB_Trick.Select()
    End Sub

    Private Sub CBUTT_Bowl1_CheckedChanged(sender As Object, e As EventArgs) Handles CBUTT_Bowl1.CheckedChanged, CBUTT_Bowl2.CheckedChanged, CBUTT_Bowl3.CheckedChanged, CBUTT_Bowl4.CheckedChanged
        LAB_Trick.Select()
        PLC.TCP_BowlStateChange(CBUTT_Bowl1.Checked, CBUTT_Bowl2.Checked, CBUTT_Bowl3.Checked, CBUTT_Bowl4.Checked)
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
        BUTT_GO.PerformClick()
    End Sub

    Private Sub BUTT_Jog_YP_Click(sender As Object, e As EventArgs) Handles BUTT_Jog_YP.Click
        NUD_Ypos_Set.Value += NUD_JogIncrement.Value
        BUTT_GO.PerformClick()
    End Sub

    Private Sub BUTT_Jog_YN_Click(sender As Object, e As EventArgs) Handles BUTT_Jog_YN.Click
        NUD_Ypos_Set.Value -= NUD_JogIncrement.Value
        BUTT_GO.PerformClick()
    End Sub

    Private Sub UI_DirectControl_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If NUD_Xpos_Set.Focused Then Exit Sub
        If NUD_Ypos_Set.Focused Then Exit Sub
        If NUD_JogIncrement.Focused Then Exit Sub

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
        BUTT_GO.PerformClick()
    End Sub

    Private Sub BUTT_GO_Click(sender As Object, e As EventArgs) Handles BUTT_GO.Click
        Dim tc As New objCommand_Move
        tc.X = NUD_Xpos_Set.Value
        tc.Y = NUD_Ypos_Set.Value
        tc.Speed = GantrySpeed

        PLC.TCP_CommandMove(tc)
    End Sub
End Class