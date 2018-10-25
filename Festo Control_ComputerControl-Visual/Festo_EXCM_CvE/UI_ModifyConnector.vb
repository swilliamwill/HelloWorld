Imports System.ComponentModel

Public Class UI_ModifyConnector
    Private Class pobjRectangle
        Property X1 As Decimal
        Property Y1 As Decimal
        Property X2 As Decimal
        Property Y2 As Decimal
    End Class

    Private Class pobjCircle
        Property X As Decimal
        Property Y As Decimal
        Property Diameter As Decimal
    End Class

    Dim DisableEvents As Boolean = False

    Dim filename As String = ""

    Dim ModConn As New objConnector
    Dim oCircles As New BindingList(Of pobjCircle)
    Dim oRectangles As New BindingList(Of pobjRectangle)

    Private Sub UI_ModifyConnector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_Pins.DataSource = ModConn.Pins
        DGV_Outlines_Circle.DataSource = oCircles
        DGV_Outlines_Rect.DataSource = oRectangles
    End Sub

    Public Sub UpdateConnector()
        ModConn.SizeX = NUD_Size_X.Value
        ModConn.SizeY = NUD_Size_Y.Value
        ModConn.PinRefZeroX = NUD_PinRef_X.Value
        ModConn.PinRefZeroY = NUD_PinRef_Y.Value
    End Sub

    Public Sub UpdateOutlines()
        ModConn.OutlineShapes.Clear()

        For Each o As pobjCircle In oCircles
            Dim newout As New objOutline

            newout.Shape = "circle"
            newout.point1.X = o.X
            newout.point1.Y = o.Y
            newout.Diameter = o.Diameter

            ModConn.OutlineShapes.Add(newout)
        Next

        For Each o As pobjRectangle In oRectangles
            Dim newout As New objOutline

            newout.Shape = "rectangle"
            newout.point1.X = o.X1
            newout.point1.Y = o.Y1
            newout.point2.X = o.X2
            newout.point2.Y = o.Y2

            ModConn.OutlineShapes.Add(newout)
        Next
    End Sub

    Public Sub NewConnector()
        TB_Manufacturer.Text = ""
        TB_PartNumber.Text = ""

        ModConn = New objConnector
        oCircles.Clear()
        oRectangles.Clear()

        UpdateConnector()

        ModConn.ShowConnector(PB_Connector)

        CB_DGV_Display.SelectedIndex = 0

        Me.Show()
    End Sub

    Public Sub LoadConnector(filename As String)

        If filename = "" Then 'We want a blank connector
            ModConn = New objConnector
        Else 'We're modifying an existing connector
            LOAD_XML_ConnectorFile(filename, ModConn, True)
        End If

        TB_Manufacturer.Text = ModConn.Manufacturer
        TB_PartNumber.Text = ModConn.PartNumber

        DisableEvents = True

        NUD_Size_X.Value = ModConn.SizeX
        NUD_Size_Y.Value = ModConn.SizeY
        ChB_CenterRef.Checked = False
        NUD_PinRef_X.Value = ModConn.PinRefZeroX
        NUD_PinRef_Y.Value = ModConn.PinRefZeroY

        oCircles.Clear()
        oRectangles.Clear()

        For Each o As objOutline In ModConn.OutlineShapes
            Select Case o.Shape.ToLower
                Case "circle"
                    Dim newShape As New pobjCircle
                    newShape.Diameter = o.Diameter
                    newShape.X = o.point1.X
                    newShape.Y = o.point1.Y

                    oCircles.Add(newShape)

                Case "rectangle"
                    Dim newShape As New pobjRectangle
                    newShape.X1 = o.point1.X
                    newShape.Y1 = o.point1.Y
                    newShape.X2 = o.point2.X
                    newShape.Y2 = o.point2.Y

                    oRectangles.Add(newShape)

                    oRectangles.Add(newShape)
            End Select
        Next

        DisableEvents = False

        ' UpdateConnector()

        ModConn.ShowConnector(PB_Connector)
        CB_DGV_Display.SelectedIndex = 0

        Me.Show()
    End Sub

    Private Sub BUTT_AddPin_Click(sender As Object, e As EventArgs) Handles BUTT_AddPin.Click
        If TB_Pin_Label.Text = "" Then
            MessageBox.Show("Pin Label Cannot be Blank")
            Exit Sub
        End If

        Dim NewPin As New objConnector_Pin
        NewPin.X = NUD_Pin_X.Value
        NewPin.Y = NUD_Pin_Y.Value
        NewPin.Diameter = NUD_Pin_DisplayDiameter.Value
        NewPin.Name = TB_Pin_Label.Text

        ModConn.Pins.Add(NewPin)
        ModConn.ShowConnector(PB_Connector)

        CB_DGV_Display.SelectedItem = "Pins"

        ' DGV_Pins.DataSource = ModConn.Pins
    End Sub

    Private Sub Connector_ValueChanged(sender As Object, e As EventArgs) Handles NUD_Size_X.ValueChanged, NUD_Size_Y.ValueChanged, NUD_PinRef_X.ValueChanged, NUD_PinRef_Y.ValueChanged
        If DisableEvents Then Exit Sub

        Try 'This will divide by zero when first loading so we need this

            If ChB_CenterRef.Checked Then
                NUD_PinRef_X.Value = NUD_Size_X.Value / 2
                NUD_PinRef_Y.Value = NUD_Size_Y.Value / 2
            End If

            UpdateConnector()
            ModConn.ShowConnector(PB_Connector)

        Catch
        End Try
    End Sub

    Private Sub DGV_Pins_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Pins.CellValueChanged
        ModConn.ShowConnector(PB_Connector)
    End Sub

    Private Sub OutlinesChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Outlines_Circle.CellValueChanged, DGV_Outlines_Rect.CellValueChanged
        UpdateOutlines()
        ModConn.ShowConnector(PB_Connector)
    End Sub

    Private Sub OutlinesAdd(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DGV_Outlines_Circle.RowsAdded, DGV_Outlines_Rect.RowsAdded
        UpdateOutlines()
        ModConn.ShowConnector(PB_Connector)
    End Sub

    Private Sub OutlinesRemoved(sender As Object, e As DataGridViewRowEventArgs) Handles DGV_Outlines_Circle.UserDeletedRow, DGV_Outlines_Rect.UserDeletedRow
        UpdateOutlines()
        ModConn.ShowConnector(PB_Connector)
    End Sub

    Private Sub BUTT_UpdateDiameters_Click(sender As Object, e As EventArgs) Handles BUTT_UpdateDiameters.Click
        For Each p As objConnector_Pin In ModConn.Pins
            p.Diameter = NUD_DiameterOverride.Value
        Next

        ModConn.ShowConnector(PB_Connector)
    End Sub

    Private Sub CB_DGV_Display_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_DGV_Display.SelectedIndexChanged

        DGV_Pins.Visible = False
        DGV_Outlines_Rect.Visible = False
        DGV_Outlines_Circle.Visible = False

        Select Case CB_DGV_Display.SelectedItem
            Case "Pins"
                DGV_Pins.Visible = True

            Case "Outlines-Circle"
                DGV_Outlines_Circle.Visible = True

            Case "Outlines-Rect"
                DGV_Outlines_Rect.Visible = True

            Case Else
                MessageBox.Show("Error: Bad selected index text: ", CB_DGV_Display.SelectedItem)
        End Select
    End Sub

    Private Sub BUTT_AddCircle_Click(sender As Object, e As EventArgs) Handles BUTT_AddCircle.Click
        Dim newo As New pobjCircle

        newo.X = NUD_CircleX.Value
        newo.Y = NUD_CircleY.Value
        newo.Diameter = NUD_CircleDiameter.Value

        oCircles.Add(newo)

        CB_DGV_Display.SelectedItem = "Outlines-Circle"
    End Sub

    Private Sub BUTT_AddRectangle_Click(sender As Object, e As EventArgs) Handles BUTT_AddRectangle.Click
        Dim newo As New pobjRectangle

        newo.X1 = NUD_Rect_X1.Value
        newo.Y1 = NUD_Rect_Y1.Value
        newo.X2 = NUD_Rect_X2.Value
        newo.Y2 = NUD_Rect_Y2.Value

        oRectangles.Add(newo)

        CB_DGV_Display.SelectedItem = "Outlines-Rect"
    End Sub

    Private Sub BUTT_Cancel_Click(sender As Object, e As EventArgs) Handles BUTT_Cancel.Click
        Me.Close()
    End Sub

    Private Sub BUTT_Save_Click(sender As Object, e As EventArgs) Handles BUTT_Save.Click
        TB_Trick().Focus()

        Dim SFD As New SaveFileDialog

        SFD.InitialDirectory = DIR_Connectors
        SFD.OverwritePrompt = True
        SFD.Filter = "XML file|*.xml"

        SFD.FileName = If(filename = "", If((TB_Manufacturer.Text = "" AndAlso TB_PartNumber.Text = ""), "NewConn.xml", TB_Manufacturer.Text & "_" & TB_PartNumber.Text & ".xml"), filename)

        SFD.Title = "Save Connector Definition"
        DialogResult = SFD.ShowDialog

        ' If the file name is not an empty string open it for saving.
        If DialogResult = Windows.Forms.DialogResult.OK Then
            SAVE_XML_Connector(SFD.FileName, ModConn)
            Me.Close()
        End If
    End Sub

    Private Sub BUTT_AddBorderCircle_Click(sender As Object, e As EventArgs) Handles BUTT_AddBorderCircle.Click
        NUD_CircleX.Value = 0
        NUD_CircleY.Value = 0

        NUD_CircleDiameter.Value = Math.Min(NUD_Size_X.Value, NUD_Size_Y.Value)

        BUTT_AddCircle.PerformClick()
    End Sub

    Private Sub BUTT_AddBorder_Rectangle_Click(sender As Object, e As EventArgs) Handles BUTT_AddBorder_Rectangle.Click
        NUD_Rect_X2.Value = NUD_Size_X.Value / 2
        NUD_Rect_Y2.Value = NUD_Size_Y.Value / 2
        NUD_Rect_X1.Value = -NUD_Rect_X2.Value
        NUD_Rect_Y1.Value = -NUD_Rect_Y2.Value

        BUTT_AddRectangle.PerformClick()
    End Sub
End Class