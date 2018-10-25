Module UserPrograms
    Public Function LOAD_UserProgam(filename As String, UP As objUserProgram) As Boolean

        Dim objReader As New System.IO.StreamReader(filename)
        Dim textline As String = ""
        Dim stxt As String()
        Dim schar As Char = ","

        Dim line As Integer = 0 'Yeah, bad practice

        Dim Speed As Decimal = -1 'Set speed not set
        Dim Acceleration As Decimal = -1 'Set accel not set (not used yet)
        Dim AbsoluteMoveMade As Boolean = False

        UP.ClearAll() 'Clear out the user program

        Try
            If objReader.Peek() = -1 Then
                MessageBox.Show("Setup File Empty. No data read")
                Return False
            End If

            'We're going to do some bad practice for expediency and just assume we know what the file looks like
            'Get Filetype, version
            stxt = objReader.ReadLine().Trim.Split(schar)
            If stxt(0).ToUpper <> "C-DAVIS GANTRY PROGRAM" Then
                MessageBox.Show("File is not a gantry program")
                Return False
            End If

            If stxt(1).ToUpper = ("VERSION") Then
                UP.Version = stxt(2)
            Else
                MessageBox.Show("Unable to get file version number, please check file")
                Return False
            End If

            line += 1
            stxt = objReader.ReadLine().Trim.Split(schar)

            If stxt(0).ToUpper = ("PROGRAM NAME") Then
                UP.Name = stxt(1)
            Else
                MessageBox.Show("Unable to get file version number, please check file")
                Return False
            End If

            line += 1

            objReader.ReadLine() 'Move past blank
            objReader.ReadLine() 'Move past header
            line += 2

            While ((objReader.Peek() <> -1))
                'Get the command string
                stxt = objReader.ReadLine().Trim.Split(schar)

                'Get the command type and process accordingly
                Select Case stxt(0).ToUpper
                    Case "MOVEABS"
                        Dim nc As New objCommand_Move
                        nc.Relative = False

                        If stxt(1) = "" OrElse stxt(2) = "" Then
                            MessageBox.Show("Bad command on line " & line & vbCrLf & vbCrLf & "Blank X or Y co-ordinate" & vbCrLf & textline)
                            Throw New Exception
                        End If

                        nc.X = stxt(1)
                        nc.Y = stxt(2)

                        If stxt(3) = "" Then
                            If Speed = -1 Then
                                MessageBox.Show("First move command must have a speed. Please correct file")
                                Throw New Exception
                            End If

                            nc.Speed = -1 'Indicate no speed change
                        Else
                            If stxt(3) <= 0 Then
                                MessageBox.Show("Bad command on line " & line & vbCrLf & vbCrLf & "Speed cannot be less than or equal to zero" & vbCrLf & textline)
                                Throw New Exception
                            End If

                            Speed = stxt(3)
                            nc.Speed = Speed
                        End If

                        ' nc.Speed = Speed
                        'nc.Acceleration = Acceleration

                        UP.CommandList.Add(nc)
                        AbsoluteMoveMade = True

                    Case "MOVEREL"
                        If Not AbsoluteMoveMade Then
                            MessageBox.Show("Bad command on line " & line & vbCrLf & vbCrLf & "Relative moves not allowed before an absolute move is made" & vbCrLf & textline)
                            Throw New Exception
                        End If

                        Dim nc As New objCommand_Move
                        nc.Relative = True

                        nc.X = stxt(1) 'Blank will be zero
                        nc.Y = stxt(2) 'Blank will be zero

                        If stxt(3) = "" Then
                            If Speed = -1 Then
                                MessageBox.Show("First move command must have a speed. Please correct file")
                                Throw New Exception
                            End If

                            nc.Speed = -1 'Indicate no speed change
                        Else
                            If stxt(3) <= 0 Then
                                MessageBox.Show("Bad command on line " & line & vbCrLf & vbCrLf & "Speed cannot be less than or equal to zero" & vbCrLf & textline)
                                Throw New Exception
                            End If

                            Speed = stxt(3)
                            nc.Speed = Speed
                        End If

                        'nc.Speed = Speed
                        'nc.Acceleration = Acceleration

                        UP.CommandList.Add(nc)

                    Case "WAIT"
                        Dim nc As New objCommand_Wait

                        If stxt(1) < 0 Then
                            MessageBox.Show("Bad command on line " & line & vbCrLf & vbCrLf & "Wait Time Cannot be less than zero" & vbCrLf & textline)
                            Throw New Exception
                        End If

                        nc.ms = stxt(1)

                        UP.CommandList.Add(nc)

                    Case "INSERT"
                        Dim nc As New objCommand_Insert
                        UP.CommandList.Add(nc)

                    Case "WAITFORRUN"
                        Dim nc As New objCommand_WaitForRun
                        UP.CommandList.Add(nc)

                    Case "STOPRUN"
                        Dim nc As New objCommand_StopRun
                        UP.CommandList.Add(nc)

                    Case Else
                        MessageBox.Show("Bad command on line " & line & vbCrLf & vbCrLf & "Bad command type" & vbCrLf & textline)
                        Throw New Exception
                End Select

                line += 1
            End While

        Catch ex As Exception
            Return False
        Finally
            objReader.Close()
        End Try

        If UP.CommandList.Count = 0 Then
            MessageBox.Show("Program Is Empty")
            Return False
        End If

        AddUserProgramToListBox(UP)
        UP.FileName = filename
        Return True
    End Function

    Public Sub AddCommandToListBox(cmd As Object, Optional InsertAt As Integer = -1)
        Dim mline As String = ""

        Select Case cmd.GetType
            Case GetType(objCommand_WaitForRun)
                mline = "WAIT FOR RUN BUTTON"

            Case GetType(objCommand_StopRun)
                mline = "STOP RUN"

            Case GetType(objCommand_Home)
                mline = "HOME"

            Case GetType(objCommand_Move)
                Dim tc As objCommand_Move = cmd

                If (InsertAt > 0) Then
                    mline = (InsertAt + 1) & "-"
                Else
                    mline = (TF.LB_Commands.Items.Count) + 1 & "-"
                End If

                If tc.Inserter = 0 Then
                    mline &= If(tc.Relative, vbTab & "Move-Relative: ", "Move: ")
                Else
                    mline &= "Insert:" & tc.Inserter & " @"
                End If

                '   mline &= If(tc.Relative, vbTab & "Move-Relative: ", "Move: ")
                mline &= "(" & tc.X & "," & tc.Y & ")"

                If tc.Speed <> -1 Then mline &= ", Speed=" & tc.Speed & " mm/s"

            Case GetType(objCommand_Wait)
                Dim tc As objCommand_Wait = cmd
                mline = "Wait: time=" & tc.ms & "ms"

            Case GetType(objCommand_Insert)
                If (InsertAt > 0) Then
                    mline = InsertAt + 1 ' + 1 & "-Insert"
                Else
                    mline = TF.LB_Commands.Items.Count + 1 ' + 1 & "-Insert"
                End If

                Dim tc As objCommand_Insert = cmd
                mline &= "-Insert " & tc.Inserter

            Case Else
                MessageBox.Show("Attempting to add bad command to listbox")
                Exit Sub
        End Select

        If InsertAt = -1 Then
            TF.LB_Commands.Items.Add(mline)
        Else
            TF.LB_Commands.Items.Insert(InsertAt, mline)
        End If
    End Sub

    Public Sub AddUserProgramToListBox(UP As objUserProgram)
        TF.TB_ProgramName.Text = UP.Name

        'We should now have a fully populated command list, let's send it to the UI
        TF.LB_Commands.Items.Clear() 'Get rid of all items

        Dim mline As String = ""
        For Each cmd As Object In UP.CommandList
            AddCommandToListBox(cmd)
        Next
    End Sub
End Module
