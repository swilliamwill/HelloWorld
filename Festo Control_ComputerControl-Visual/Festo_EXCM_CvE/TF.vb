'Version History
'1.0 Initial Release
'1.01 Fix for adding insert when an insert was selected not putting move/insert combo in correct place. Added undo function (one undo)
'2.00 Rework for proof of concept

Imports System.ComponentModel

Public Class TF

    Dim Gantry As New classGantry
    Dim LastFileName As String = ""

    Public setImage As Bitmap

    Dim backBuffer As Bitmap

    Dim ProgramRunning As Boolean = False

    Private Sub TF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        setImage = New Bitmap(PB_Connector.Height, PB_Connector.Width)

        DisableEvents = True

        Me.Text &= " " & SoftwareVersion
        LoadProgramToolStripMenuItem.Enabled = True

        My.Computer.FileSystem.CreateDirectory(DIR_Data)
        My.Computer.FileSystem.CreateDirectory(DIR_Setup)

        'Load the Ip address, etc
        If System.IO.File.Exists(FILE_INI) Then
            INI_LoadFile(FILE_INI)
        End If

        TB_Trick.Focus()

        Dim TrialConnector As New objConnector
        LOAD_XML_ConnectorFile(DIR_Data & "\MIL-STD-1560.xml", TrialConnector, True)

        TrialConnector.TrayIndex = "1"
        TrialConnector.TrayPositionX = (-0.9 * 25.4)
        TrialConnector.TrayPositionY = (0.9 * 25.4)
        ConnTray.Connectors.Add(TrialConnector)

        TrialConnector = New objConnector
        LOAD_XML_ConnectorFile(DIR_Data & "\MIL-STD-1560.xml", TrialConnector, True)
        TrialConnector.TrayIndex = "2"
        TrialConnector.TrayPositionX = (0.9 * 25.4)
        TrialConnector.TrayPositionY = (0.9 * 25.4)
        ConnTray.Connectors.Add(TrialConnector)

        TrialConnector = New objConnector
        LOAD_XML_ConnectorFile(DIR_Data & "\MIL-STD-1560.xml", TrialConnector, True)
        TrialConnector.TrayIndex = "3"
        TrialConnector.TrayPositionX = (-0.9 * 25.4)
        TrialConnector.TrayPositionY = (-0.9 * 25.4)
        ConnTray.Connectors.Add(TrialConnector)

        TrialConnector = New objConnector
        LOAD_XML_ConnectorFile(DIR_Data & "\MIL-STD-1560.xml", TrialConnector, True)
        TrialConnector.TrayIndex = "4"
        TrialConnector.TrayPositionX = (0.9 * 25.4)
        TrialConnector.TrayPositionY = (-0.9 * 25.4)
        ConnTray.Connectors.Add(TrialConnector)

        ConnTray.SizeX = 3.75 * 25.4
        ConnTray.SizeY = 4 * 25.4
        ConnTray.CenterX = 1.875 * 25.4
        ConnTray.CenterY = 2.15 * 2.54


        UpdateInserterButtons()

        DisableEvents = False

        BUTT_Conn1.PerformClick()
        RB_Insert_1_1.PerformClick()

        LAB_RunState.Visible = False

        LAB_RunState.Location = New Point(LAB_RunState.Location.X, PB_Connector.Location.Y + PB_Connector.Height / 2 - LAB_RunState.Height / 2)

        DisableControlsForRunning(False)

        Try
            ConnectToPLC(False)
        Catch
        End Try
    End Sub

    Private Sub LoadProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadProgramToolStripMenuItem.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.InitialDirectory = DIR_Setup
        openFileDialog1.Filter = "XML file|*.xml"
        openFileDialog1.FileName = ""
        openFileDialog1.Title = "Open Setup file"

        'if file dialog has been named then start read
        If openFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If openFileDialog1.FileName <> "" Then
                LOAD_XML_TrayProgram(openFileDialog1.FileName, ConnTray)
                'ShowConnector(ConnTray.Connectors(CurrentConnector), LAB_Manufacturer, LAB_PartNumber)
                BUTT_Conn1.PerformClick()
                RebuildAndShowCommands()
                UserProgram.NeedsPLC_Load = True
            End If
        End If
    End Sub

    Private Sub NewProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewProgramToolStripMenuItem.Click
        'FIXXX

        If MessageBox.Show("This will clear all programmed moves. Continue?",
                           "New Program", MessageBoxButtons.OKCancel) = DialogResult.OK Then

            UserProgram.CommandList.Clear()
            UserProgram.Name = ""
            TB_ProgramName.Text = ""

            LB_Commands.ClearSelected()
            LB_Commands.Items.Clear()
        End If
    End Sub

    Private Sub DeleteCommandItem()
        'This will delete an item from the command list and user programs. If we're deleting a move followed by an insert we delete the following insert as well

        If LB_Commands.SelectedIndex = -1 Then Return

        Dim IndexToDelete = LB_Commands.SelectedIndex

        Dim CheckForInsertRemoval As Boolean = (UserProgram.CommandList(IndexToDelete).GetType = GetType(objCommand_Move)) 'Do we need to check for an insert to remove
        If IndexToDelete = LB_Commands.Items.Count - 1 Then CheckForInsertRemoval = False

        LB_Commands.Items.RemoveAt(IndexToDelete)
        UserProgram.CommandList.RemoveAt(IndexToDelete)

        If IndexToDelete <= LB_Commands.Items.Count - 1 Then
            LB_Commands.SelectedIndex = IndexToDelete
        ElseIf LB_Commands.Items.Count <> 0 Then
            IndexToDelete = LB_Commands.Items.Count - 1
            LB_Commands.SelectedIndex = IndexToDelete
        End If

        If Not CheckForInsertRemoval Then Return

        'We've deleted a move, let's check if there's an insert and take it out if there is
        If (UserProgram.CommandList(IndexToDelete).GetType = GetType(objCommand_Insert)) Then
            LB_Commands.Items.RemoveAt(IndexToDelete)
            UserProgram.CommandList.RemoveAt(IndexToDelete)

            If IndexToDelete <= LB_Commands.Items.Count - 1 Then
                LB_Commands.SelectedIndex = IndexToDelete
            ElseIf LB_Commands.Items.Count <> 0 Then
                IndexToDelete = LB_Commands.Items.Count - 1
                LB_Commands.SelectedIndex = IndexToDelete
            End If
        End If

    End Sub

    Private Sub BUTT_DeleteCommand_Click(sender As Object, e As EventArgs)
        TB_Trick.Focus()

        UserProgram_Undos.CopyFromUP(UserProgram)
        DeleteCommandItem()

    End Sub

    Private Sub LoadToPLCToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If TB_ProgramName.Text = "" Then
            MessageBox.Show("Please give program name before downloading")
            Return
        End If

        Try
            UserProgram.Name = TB_ProgramName.Text

            PLC.TCP_SendProgram_Name(UserProgram)
            PLC.TCP_ClearDataTable()

            For Each cmd As Object In UserProgram.CommandList
                PLC.TCP_DataTable_AddCommand(cmd)
            Next

            MessageBox.Show("Program """ & UserProgram.Name & """ Loaded to controller")
        Catch
            MessageBox.Show("Error Loading Program to PLC")
        End Try
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If LastFileName = "" Then
            SaveAsToolStripMenuItem.PerformClick()
            Return
        End If

        TB_Trick().Focus()
        UserProgram.Name = TB_ProgramName.Text

        SAVE_XML_TrayProgram(LastFileName, ConnTray)
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        TB_Trick().Focus()
        UserProgram.Name = TB_ProgramName.Text

        Dim SFD As New SaveFileDialog

        SFD.InitialDirectory = DIR_Setup
        SFD.OverwritePrompt = True
        SFD.Filter = "XML file|*.xml"

        SFD.FileName = If(LastFileName = "", "NewSetup.xml", LastFileName)
        SFD.Title = "Save Connector Definition"
        DialogResult = SFD.ShowDialog

        ' If the file name is not an empty string open it for saving.
        If DialogResult = Windows.Forms.DialogResult.OK Then
            LastFileName = SFD.FileName
            SAVE_XML_TrayProgram(SFD.FileName, ConnTray)
        End If
    End Sub

    Private Sub TB_ProgramName_TextChanged(sender As Object, e As EventArgs) Handles TB_ProgramName.TextChanged
        UserProgram.Name = TB_ProgramName.Text
    End Sub

    Private Sub BUTT_SaveToPLC_Click(sender As Object, e As EventArgs)
        TB_Trick.Focus()

        If TB_ProgramName.Text = "" Then
            MessageBox.Show("Program name can not be blank")
            Return
        End If

        Try
            UserProgram.Name = TB_ProgramName.Text

            PLC.TCP_SendProgram_Name(UserProgram)
            PLC.TCP_ClearDataTable()

            For Each cmd As Object In UserProgram.CommandList
                PLC.TCP_DataTable_AddCommand(cmd)
            Next
        Catch
            MessageBox.Show("Error Loading Program to PLC")
        End Try

        MessageBox.Show("Program """ & UserProgram.Name & """ Loaded to controller")
    End Sub

    Private Sub ModifyCommandItem()
        If LB_Commands.SelectedIndex = -1 Then Return

        Dim IndexToReturn = LB_Commands.SelectedIndex

        Select Case UserProgram.CommandList(LB_Commands.SelectedIndex).GetType
            Case GetType(objCommand_Move)
                Dim MM As New UI_ModifyMove
                MM.LoadMove(UserProgram.CommandList(LB_Commands.SelectedIndex))
                MM.ShowDialog()
                AddUserProgramToListBox(UserProgram)

                LB_Commands.SelectedIndex = IndexToReturn
            Case Else
        End Select
    End Sub

    Private Sub LB_Commands_DoubleClick(sender As Object, e As EventArgs) Handles LB_Commands.DoubleClick
        ModifyCommandItem()
    End Sub

    Private Sub BUTT_Home_Click(sender As Object, e As EventArgs)
        TB_Trick.Focus()
        PLC.TCP_CommandHome()
    End Sub

    Private Sub TF_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Online Then
            Try
                Gantry.TCP_Connect(False)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub BUTT_ClearSelection_Click(sender As Object, e As EventArgs)
        TB_Trick.Focus()
        LB_Commands.SelectedItem = Nothing
    End Sub

    Private Sub LB_Commands_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LB_Commands.MouseUp
        'Added a hack in here since Modifications while scrolled were screwing things up. For left mouse up we only process the "clicked on nothing"

        If LB_Commands.IndexFromPoint(e.X, e.Y) < 0 AndAlso e.Button = Windows.Forms.MouseButtons.Left Then
            LB_Commands.SelectedIndex = -1
            Return
        End If

        If e.Button <> Windows.Forms.MouseButtons.Right Then Return

        LB_Commands.SelectedIndex = LB_Commands.IndexFromPoint(e.X, e.Y) 'Move the selected index to where you are clicking. This works to clear the selected index too

        If LB_Commands.SelectedIndex < 0 Then Return 'Don't show if there's no selected index

        Dim cms = New ContextMenuStrip

        If UserProgram.CommandList(LB_Commands.SelectedIndex).GetType = GetType(objCommand_Move) Then
            Dim item1 = cms.Items.Add("Modify")
            item1.Tag = 1
            AddHandler item1.Click, AddressOf menuChoice
        End If

        cms.Show(LB_Commands, e.Location)
    End Sub

    Private Sub menuChoice(ByVal sender As Object, ByVal e As EventArgs)
        Dim item = CType(sender, ToolStripMenuItem)
        Dim selection = CInt(item.Tag)

        Select Case selection
            Case 1
                ModifyCommandItem()

            Case 2
                DeleteCommandItem()
            Case Else
        End Select

    End Sub

    Private Sub InstructionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstructionsToolStripMenuItem.Click
        WF_Instructions.Show()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'UserProgram.CopyFromUP(UserProgram_Undos)
        'AddUserProgramToListBox(UserProgram)

    End Sub

    Private Sub RebuildAndShowCommands()
        UserProgram.CommandList.Clear()

        For Each conn As objConnector In ConnTray.Connectors

            'Do all basic inserts first
            For Each pin As objConnector_Pin In conn.Pins
                If Not pin.Used Then Continue For

                Dim MoveCommand As New objCommand_Move
                MoveCommand.X = GetX_ForPinInserter(conn, pin.Name, Asc(pin.InsertOrder.Substring(0, 1)) - 48)
                MoveCommand.Y = GetY_ForPinInserter(conn, pin.Name, Asc(pin.InsertOrder.Substring(0, 1)) - 48)
                MoveCommand.Speed = GantrySpeed

                MoveCommand.Inserter = Asc(pin.InsertOrder.Substring(0, 1)) - 48

                UserProgram.CommandList.Add(MoveCommand)

                ' Dim NewInsert As New objCommand_Insert
                ' NewInsert.Inserter = Asc(pin.InsertOrder.Substring(0, 1)) - 48

                'UserProgram.CommandList.Add(NewInsert)
            Next

            'Do any second inserts
            For Each pin As objConnector_Pin In conn.Pins
                If Not pin.Used Then Continue For
                If Not pin.InsertOrder.Length > 1 Then Continue For

                Dim MoveCommand As New objCommand_Move
                MoveCommand.X = GetX_ForPinInserter(conn, pin.Name, Asc(pin.InsertOrder.Substring(1, 1)) - 48)
                MoveCommand.Y = GetY_ForPinInserter(conn, pin.Name, Asc(pin.InsertOrder.Substring(1, 1)) - 48)
                MoveCommand.Speed = GantrySpeed 'NUD_Speed.Value

                MoveCommand.Inserter = Asc(pin.InsertOrder.Substring(1, 1)) - 48

                UserProgram.CommandList.Add(MoveCommand)

                'Dim NewInsert As New objCommand_Insert
                'NewInsert.Inserter = Asc(pin.InsertOrder.Substring(1, 1)) - 48

                ' UserProgram.CommandList.Add(NewInsert)
            Next
        Next

        AddUserProgramToListBox(UserProgram)
    End Sub

    Private Sub DrawButton(text As String, textsize As Integer, location As Point, Diameter As Integer, BottomColor As Color, Optional TopColor As Color = Nothing)
        'koko

        ' Using g As Graphics = PB_Connector.CreateGraphics
        Using g As Graphics = Graphics.FromImage(setImage) 'Put image object into memory

            If TopColor = Nothing Then TopColor = BottomColor


            Dim rect As Rectangle = New Rectangle(location.X - Diameter / 2, location.Y - Diameter / 2, Diameter, Diameter)
            Dim pen1 As New System.Drawing.Pen(Color.Black, 3)

            g.FillPie(New SolidBrush(BottomColor), rect, 0, 180)
            g.FillPie(New SolidBrush(TopColor), rect, 180, 180)
            g.DrawEllipse(pen1, rect.X, rect.Y, Diameter, Diameter)

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias

            Dim sf As StringFormat = New StringFormat
            sf.Alignment = StringAlignment.Center
            sf.LineAlignment = StringAlignment.Center

            Using gp As New System.Drawing.Drawing2D.GraphicsPath, f As New Font(FontFamily.GenericSansSerif, textsize, FontStyle.Bold), p As New Pen(Brushes.White, 2)
                gp.AddString(text, f.FontFamily, f.Style, f.Size + 3, location, sf)

                g.DrawPath(p, gp)
                g.FillPath(Brushes.Black, gp)
                p.Dispose()
                gp.Dispose()
            End Using

            PB_Connector.Image = setImage

            sf.Dispose()
            g.Dispose()
            pen1.Dispose()
        End Using
    End Sub

    'Private Sub ShowConnector(Conn As objConnector, Optional Manuf_Label As Label = Nothing, Optional PartNo_Label As Label = Nothing)
    '    'This function displays the assigned pins/etc for the selected tray connector
    '    pinbuttlist.Clear()

    '    'Dim PixelsPerUnit As Decimal = PB_Connector.Width / Math.Max(ConnTray.Connectors(CurrentConnector).SizeX, ConnTray.Connectors(CurrentConnector).SizeY)

    '    Dim PixelsPerUnit As Decimal = PB_Connector.Width / Math.Max(ConnTray.Connectors(CurrentConnector).SizeX, ConnTray.Connectors(CurrentConnector).SizeY)
    '    Dim pinnum As Integer = 0 'pointer to keep link between pin button and pin object

    '    For Each outline As objOutline In Conn.OutlineShapes 'ConnTray.Connectors(CurrentConnector).OutlineShapes
    '        With outline
    '            Select Case .Shape
    '                'Remember here that all X/Y co-ords are from the center of the connector

    '                Case "circle"
    '                    Dim test As objOutline = outline

    '                    Dim LocP1 As Point = New Point(.point1.X * PixelsPerUnit + PB_Connector.Width / 2, - .point1.Y * PixelsPerUnit + PB_Connector.Height / 2)
    '                    Dim DrawDiameter = .Diameter * PixelsPerUnit - .LineThickness

    '                    'Using g As Graphics = PB_Connector.CreateGraphics
    '                    'Using g As Graphics = Graphics.FromImage(setImage)
    '                    Using g As Graphics = Graphics.FromImage(setImage)
    '                        Dim pen1 As New System.Drawing.Pen(Color.Black, .LineThickness)
    '                        g.DrawEllipse(pen1, LocP1.X - DrawDiameter / 2, LocP1.Y - DrawDiameter / 2, DrawDiameter - .LineThickness, DrawDiameter - .LineThickness) 'Draw button border

    '                        PB_Connector.Image = setImage
    '                        pen1.Dispose()
    '                        g.Dispose()
    '                    End Using
    '            End Select
    '        End With
    '    Next

    '    For Each pin As objConnector_Pin In ConnTray.Connectors(CurrentConnector).Pins
    '        Dim LocP As Point = New Point((ConnTray.Connectors(CurrentConnector).PinRefZeroX + pin.X) * PixelsPerUnit,
    '                                          (ConnTray.Connectors(CurrentConnector).PinRefZeroY - pin.Y) * PixelsPerUnit)

    '        With ConnTray.Connectors(CurrentConnector).Pins(pinnum).InsertOrder
    '            Select Case .Length
    '                Case 0 'There's no insert
    '                    pinbuttlist.Add(New Control_RoundSplitButtonForPictureBox(PB_Connector, setImage, pin.Name, LocP, pin.Diameter * PixelsPerUnit))
    '                Case 1 'We're inserting one item
    '                    pinbuttlist.Add(New Control_RoundSplitButtonForPictureBox(PB_Connector, setImage, pin.Name, LocP, pin.Diameter * PixelsPerUnit, False))
    '                    pinbuttlist(pinnum).SetButton(InserterColors(.Substring(0, 1)))
    '                Case Else 'We're inserting two items
    '                    pinbuttlist.Add(New Control_RoundSplitButtonForPictureBox(PB_Connector, setImage, pin.Name, LocP, pin.Diameter * PixelsPerUnit, False))
    '                    pinbuttlist(pinnum).SetButton(InserterColors(.Substring(1, 1)), InserterColors(.Substring(0, 1)))
    '            End Select
    '        End With

    '        pinnum += 1
    '    Next

    '    If Manuf_Label IsNot Nothing Then Manuf_Label.Text = "Manufacturer: " & ConnTray.Connectors(CurrentConnector).Manufacturer
    '    If PartNo_Label IsNot Nothing Then PartNo_Label.Text = "Part Number: " & ConnTray.Connectors(CurrentConnector).PartNumber

    '    'LAB_Manufacturer.Text = "Manufacturer: " & ConnTray.Connectors(CurrentConnector).Manufacturer
    '    'LAB_PartNumber.Text = "Part Number: " & ConnTray.Connectors(CurrentConnector).PartNumber
    'End Sub

    Private Sub BUTT_ConnX_Click(sender As Object, e As EventArgs) Handles BUTT_Conn1.Click, BUTT_Conn2.Click, BUTT_Conn3.Click, BUTT_Conn4.Click
        Dim btn = CType(sender, Button)

        BUTT_Conn1.BackColor = Color.White
        BUTT_Conn2.BackColor = Color.White
        BUTT_Conn3.BackColor = Color.White
        BUTT_Conn4.BackColor = Color.White

        btn.BackColor = Color.PaleTurquoise

        CurrentConnector = CInt(btn.Text) - 1
        'ShowConnector(ConnTray.Connectors(CurrentConnector), LAB_Manufacturer, LAB_PartNumber)
        ConnTray.Connectors(CurrentConnector).ShowConnector(PB_Connector, LAB_Manufacturer, LAB_PartNumber)
    End Sub

    Private Sub SetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetupToolStripMenuItem.Click
        If Not ReConnectToPLC() Then Exit Sub

        UI_Setup.ShowDialog()
        UpdateInserterButtons()
        RebuildAndShowCommands()
    End Sub

    Private Sub BUTT_ClearTray_Click(sender As Object, e As EventArgs) Handles BUTT_ClearTray.Click
        Dim result As Integer = MessageBox.Show("This will clear all pin selections from all connectors on the tray. Continue?", "Clear Tray", MessageBoxButtons.OKCancel)

        If result = DialogResult.Cancel Then Exit Sub

        For Each c As objConnector In ConnTray.Connectors
            For Each p As objConnector_Pin In c.Pins
                p.InsertOrder = ""
            Next
        Next

        'ShowConnector(ConnTray.Connectors(CurrentConnector), LAB_Manufacturer, LAB_PartNumber)
        ConnTray.Connectors(CurrentConnector).ShowConnector(PB_Connector, LAB_Manufacturer, LAB_PartNumber)
        'BUTT_Conn1.PerformClick()
        RebuildAndShowCommands()
    End Sub

    Private Sub BUTT_ClearConnector_Click(sender As Object, e As EventArgs) Handles BUTT_ClearConnector.Click
        Dim result As Integer = MessageBox.Show("This will clear all pin selections from this connector. Continue?", "Clear Connector", MessageBoxButtons.OKCancel)

        For Each p As objConnector_Pin In ConnTray.Connectors(CurrentConnector).Pins
            p.InsertOrder = ""
        Next

        'ShowConnector(ConnTray.Connectors(CurrentConnector), LAB_Manufacturer, LAB_PartNumber)
        ConnTray.Connectors(CurrentConnector).ShowConnector(PB_Connector, LAB_Manufacturer, LAB_PartNumber)
        RebuildAndShowCommands()
    End Sub

    Private Sub BUTT_CopyConnector_Click(sender As Object, e As EventArgs) Handles BUTT_CopyConnector.Click
        UI_CopyConnector.UF_CopyConnector_SetConnector(CurrentConnector)
    End Sub

    Private Sub RB_Insert_1_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Insert_1_1.CheckedChanged, RB_Insert_1_2.CheckedChanged, RB_Insert_1_3.CheckedChanged,
        RB_Insert_1_4.CheckedChanged

        If DisableEvents Then Exit Sub

        DisableEvents = True

        Dim tc As RadioButton = CType(sender, RadioButton)
        If tc.Name = "" Then Exit Sub 'Buttons load initally without name? Fuck if I know, but this fixes the load issue

        Dim num As Integer = tc.Name.Split("_")(UBound(tc.Name.Split("_"))) 'Get the number we're using
        SelectedInserter = num

        RB_Insert_1_1.Checked = (num = 1)
        RB_Insert_1_2.Checked = (num = 2)
        RB_Insert_1_3.Checked = (num = 3)
        RB_Insert_1_4.Checked = (num = 4)

        RB_Insert_2_1.Visible = (num <> 1)
        RB_Insert_2_2.Visible = (num <> 2)
        RB_Insert_2_3.Visible = (num <> 3)
        RB_Insert_2_4.Visible = (num <> 4)

        DisableEvents = False

        RB_Insert_2_NONE.Checked = True 'De-select second insert
    End Sub

    Private Sub RB_Insert_2_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Insert_2_1.CheckedChanged, RB_Insert_2_2.CheckedChanged, RB_Insert_2_3.CheckedChanged,
        RB_Insert_2_4.CheckedChanged, RB_Insert_2_NONE.CheckedChanged

        If DisableEvents Then Exit Sub

        DisableEvents = True

        Dim tc As RadioButton = CType(sender, RadioButton)
        If tc.Name = "" Then Exit Sub 'Buttons load initally without name? Fuck if I know, but this fixes the load issue

        Dim num As Integer = 0
        If tc.Name <> "RB_Insert_2_NONE" Then num = tc.Name.Split("_")(UBound(tc.Name.Split("_"))) 'Get the number we're using
        SecondInserter = num

        RB_Insert_2_1.Checked = (num = 1)
        RB_Insert_2_2.Checked = (num = 2)
        RB_Insert_2_3.Checked = (num = 3)
        RB_Insert_2_4.Checked = (num = 4)
        RB_Insert_2_NONE.Checked = (num = 0)

        DisableEvents = False
    End Sub

    Private Sub UpdateInserterButtons()
        For i As Integer = 1 To 4
            CType(Me.Controls.Find("RB_Insert_1_" & i, True)(0), RadioButton).Text = InserterDescription(i)
            Me.Controls.Find("RB_Insert_1_" & i, True)(0).BackColor = InserterColors(i)
            Me.Controls.Find("Panel_Insert_1_" & i, True)(0).BackColor = InserterColors(i)

            CType(Me.Controls.Find("RB_Insert_2_" & i, True)(0), RadioButton).Text = InserterDescription(i)
            Me.Controls.Find("RB_Insert_2_" & i, True)(0).BackColor = InserterColors(i)
            Me.Controls.Find("Panel_Insert_2_" & i, True)(0).BackColor = InserterColors(i)
        Next
    End Sub

    Private Function GetInsertOrderFromUI() As String
        Dim ii As String = ""

        If RB_Insert_1_1.Checked Then ii = "1"
        If RB_Insert_1_2.Checked Then ii = "2"
        If RB_Insert_1_3.Checked Then ii = "3"
        If RB_Insert_1_4.Checked Then ii = "4"

        If RB_Insert_2_1.Checked Then ii &= "1"
        If RB_Insert_2_2.Checked Then ii &= "2"
        If RB_Insert_2_3.Checked Then ii &= "3"
        If RB_Insert_2_4.Checked Then ii &= "4"

        Return ii
    End Function

    Private Sub PB_Connector_MouseUp(sender As Object, e As MouseEventArgs) Handles PB_Connector.MouseUp
        'This form is called when the mouse is over the connector form and the button is released (after a click, yeah?) We use this one because it will capture mouse position
        'Mouse position is e.X,e.Y

        'We first look through all the pin buttons to see if this click is within the button
        Dim pinnum As Integer = 0
        For Each p As Control_RoundSplitButtonForPictureBox In pinbuttlist
            Dim radiusSQ As Decimal = (p.Diameter / 2) ^ 2

            If ((e.X - p.CenterPoint.X) ^ 2 + (e.Y - p.CenterPoint.Y) ^ 2) <= radiusSQ Then 'Are we clicking within this pin button?
                'We've found the button we clicked on, process it

                With ConnTray.Connectors(CurrentConnector).Pins(pinnum)
                    If .Used Then
                        .InsertOrder = ""
                    Else
                        If RB_Insert_1_1.Checked Then .InsertOrder = "1"
                        If RB_Insert_1_2.Checked Then .InsertOrder = "2"
                        If RB_Insert_1_3.Checked Then .InsertOrder = "3"
                        If RB_Insert_1_4.Checked Then .InsertOrder = "4"

                        If RB_Insert_2_1.Checked Then .InsertOrder &= "1"
                        If RB_Insert_2_2.Checked Then .InsertOrder &= "2"
                        If RB_Insert_2_3.Checked Then .InsertOrder &= "3"
                        If RB_Insert_2_4.Checked Then .InsertOrder &= "4"
                    End If

                    Select Case ConnTray.Connectors(CurrentConnector).Pins(pinnum).InsertOrder.Length
                        Case 0 'There's no insert
                            p.ClearButton()
                        Case 1 'We're inserting one item
                            p.SetButton(InserterColors(.InsertOrder.Substring(0, 1)))
                        Case Else 'We're inserting two items
                            p.SetButton(InserterColors(.InsertOrder.Substring(1, 1)), InserterColors(.InsertOrder.Substring(0, 1)))
                    End Select

                    UserProgram.NeedsPLC_Load = True 'We've made a change, we must reload

                    Exit For 'We're done, exit out
                End With
            End If

            pinnum += 1
        Next

        RebuildAndShowCommands() 'Update the program list and display it
    End Sub

    Private Sub BUTT_ProgramRun_Click(sender As Object, e As EventArgs) Handles BUTT_ProgramRun.Click
        If UserProgram.CommandList.LongCount = 0 Then
            MessageBox.Show("No inserts selected to run")
            Exit Sub
        End If

        If Not ReConnectToPLC() Then Exit Sub

        Try
            If UserProgram.NeedsPLC_Load Then
                If Not LoadProgramToPLC() Then Exit Sub
            End If

            PLC.TCP_SystemCommand_Run()
            System.Threading.Thread.Sleep(100)
            bgw.RunWorkerAsync()

            DisableControlsForRunning(True)
        Catch
            MessageBox.Show("Problem with run command")
        End Try
    End Sub

    Public Sub DisableControlsForRunning(running As Boolean)
        PB_Connector.Enabled = Not running
        BUTT_ClearTray.Enabled = Not running
        BUTT_CopyConnector.Enabled = Not running
        BUTT_ClearConnector.Enabled = Not running
        BUTT_ClearTray.Enabled = Not running
        GB_FirstInsert.Enabled = Not running
        GB_SecondInsert.Enabled = Not running

        BUTT_ProgramRun.Enabled = Not running
        BUTT_ProgramStop.Enabled = running
        BUTT_ProgramPause.Enabled = running

        TB_ProgramName.Enabled = Not running

        FileToolStripMenuItem.Enabled = Not running
        SetupToolStripMenuItem.Enabled = Not running
        DirectControlToolStripMenuItem.Enabled = Not running
        'LoadToPLCToolStripMenuItem.Enabled = Not PLC.XY.Running
    End Sub

    Private Sub SetRunState(runstate As String)
        LAB_RunState.Text = runstate

        Select Case runstate.ToUpper
            Case "PAUSED"
                LAB_RunState.BackColor = Color.LightSalmon
                LAB_RunState.Visible = True
                BUTT_ProgramRun.Enabled = True
                BUTT_ProgramStop.Enabled = True
                BUTT_ProgramPause.Enabled = False
        End Select
    End Sub

    Private Sub bgw_Dowork(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles bgw.DoWork
        While Not bgw.CancellationPending
            Try
                PLC.TCP_GetSystemStatus()
                bgw.ReportProgress(0, "")
                System.Threading.Thread.Sleep(500)
            Catch
            End Try
        End While

        e.Cancel = True
    End Sub

    Private Sub bgw_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs) Handles bgw.ProgressChanged
        'RaiseEvent bgwProgressChanged(e)

        If PLC.XY.HasFault Then
            ' UI_Error.Show()
            bgw.CancelAsync()
        End If

        LAB_RunState.BringToFront()
        If PLC.XY.Paused Then
            LAB_RunState.Text = "PAUSED"
            LAB_RunState.BackColor = Color.LightSalmon
            LAB_RunState.Visible = True
        Else
            If PLC.XY.Running Then
                LAB_RunState.Text = "RUNNING-" & PLC.XY.ProgramRowRunning & "/" & UserProgram.CommandList.LongCount
                LAB_RunState.BackColor = Color.LightGreen
                LAB_RunState.Visible = True
            Else
                bgw.CancelAsync()
                'Need to set the system to STOP here
            End If
        End If
    End Sub

    Private Sub bgw_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles bgw.RunWorkerCompleted
        DisableControlsForRunning(False)

        Select Case bgw_command.ToUpper
            Case "STOP"
                PLC.TCP_SystemCommand_Stop()
                LAB_RunState.Visible = False
            Case "PAUSE"
                PLC.TCP_SystemCommand_Pause()
                LAB_RunState.Text = "PAUSED"
                LAB_RunState.BackColor = Color.LightSalmon
                LAB_RunState.Visible = True

                BUTT_ProgramStop.Enabled = True
            Case Else
                LAB_RunState.Visible = False
        End Select

        If PLC.XY.HasFault Then
            UI_Error.ShowDialog()
        End If

        bgw_command = ""
    End Sub

    Private Sub BUTT_ProgramStop_Click(sender As Object, e As EventArgs) Handles BUTT_ProgramStop.Click
        bgw_command = "STOP"
        bgw.CancelAsync()
    End Sub

    Private Sub BUTT_ProgramPause_Click(sender As Object, e As EventArgs) Handles BUTT_ProgramPause.Click
        bgw_command = "PAUSE"
        bgw.CancelAsync()
    End Sub

    Private Sub DirectControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DirectControlToolStripMenuItem.Click
        If Not ReConnectToPLC() Then Exit Sub

        UI_DirectControl.ShowDialog()
    End Sub

    Private Sub ModifyTrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyTrayToolStripMenuItem.Click
        UI_TrayCreator.LoadTray(ConnTray)
    End Sub

    Private Sub NewConnectorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewConnectorToolStripMenuItem.Click
        UI_ModifyConnector.LoadConnector("")
    End Sub

    Private Sub ModifyConnectorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyConnectorToolStripMenuItem.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.InitialDirectory = DIR_Connectors
        openFileDialog1.Filter = "XML file|*.xml"
        openFileDialog1.FileName = ""
        openFileDialog1.Title = "Open Connector file"

        'if file dialog has been named then start read
        If openFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If openFileDialog1.FileName <> "" Then UI_ModifyConnector.LoadConnector(openFileDialog1.FileName)
        End If
    End Sub

    Private Sub NewTrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewTrayToolStripMenuItem.Click

    End Sub
End Class
