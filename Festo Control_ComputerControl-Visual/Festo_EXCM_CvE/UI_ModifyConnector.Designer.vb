<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_ModifyConnector
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PB_Connector = New System.Windows.Forms.PictureBox()
        Me.LAB_PartNumber = New System.Windows.Forms.Label()
        Me.TB_PartNumber = New System.Windows.Forms.TextBox()
        Me.TB_Manufacturer = New System.Windows.Forms.TextBox()
        Me.NUD_PinRef_Y = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NUD_Size_Y = New System.Windows.Forms.NumericUpDown()
        Me.NUD_PinRef_X = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.NUD_Size_X = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BUTT_AddPin = New System.Windows.Forms.Button()
        Me.NUD_Pin_DisplayDiameter = New System.Windows.Forms.NumericUpDown()
        Me.TB_Pin_Label = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NUD_Pin_Y = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NUD_Pin_X = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DGV_Pins = New System.Windows.Forms.DataGridView()
        Me.DGV_Pins_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Pins_X = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Pins_Y = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Pins_DisplayDiameter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChB_CenterRef = New System.Windows.Forms.CheckBox()
        Me.NUD_DiameterOverride = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BUTT_UpdateDiameters = New System.Windows.Forms.Button()
        Me.CB_DGV_Display = New System.Windows.Forms.ComboBox()
        Me.DGV_Outlines_Circle = New System.Windows.Forms.DataGridView()
        Me.DGV_Circles_X = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Circles_Y = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Circles_Diameter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BUTT_Save = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BUTT_AddBorderCircle = New System.Windows.Forms.Button()
        Me.BUTT_AddCircle = New System.Windows.Forms.Button()
        Me.NUD_CircleDiameter = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NUD_CircleY = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.NUD_CircleX = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BUTT_AddBorder_Rectangle = New System.Windows.Forms.Button()
        Me.NUD_Rect_Y2 = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.NUD_Rect_X2 = New System.Windows.Forms.NumericUpDown()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.BUTT_AddRectangle = New System.Windows.Forms.Button()
        Me.NUD_Rect_Y1 = New System.Windows.Forms.NumericUpDown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.NUD_Rect_X1 = New System.Windows.Forms.NumericUpDown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DGV_Outlines_Rect = New System.Windows.Forms.DataGridView()
        Me.DGV_Outlines_Rect_X1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Outlines_Rect_X2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Outlines_Rect_Y2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BUTT_Cancel = New System.Windows.Forms.Button()
        Me.TB_Trick = New System.Windows.Forms.TextBox()
        CType(Me.PB_Connector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_PinRef_Y, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Size_Y, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_PinRef_X, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Size_X, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NUD_Pin_DisplayDiameter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Pin_Y, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Pin_X, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Pins, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_DiameterOverride, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Outlines_Circle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.NUD_CircleDiameter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_CircleY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_CircleX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.NUD_Rect_Y2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Rect_X2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Rect_Y1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Rect_X1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Outlines_Rect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PB_Connector
        '
        Me.PB_Connector.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PB_Connector.InitialImage = Nothing
        Me.PB_Connector.Location = New System.Drawing.Point(12, 90)
        Me.PB_Connector.Name = "PB_Connector"
        Me.PB_Connector.Size = New System.Drawing.Size(600, 600)
        Me.PB_Connector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Connector.TabIndex = 67
        Me.PB_Connector.TabStop = False
        '
        'LAB_PartNumber
        '
        Me.LAB_PartNumber.AutoSize = True
        Me.LAB_PartNumber.Location = New System.Drawing.Point(9, 48)
        Me.LAB_PartNumber.Name = "LAB_PartNumber"
        Me.LAB_PartNumber.Size = New System.Drawing.Size(66, 13)
        Me.LAB_PartNumber.TabIndex = 101
        Me.LAB_PartNumber.Text = "Part Number"
        '
        'TB_PartNumber
        '
        Me.TB_PartNumber.Location = New System.Drawing.Point(12, 64)
        Me.TB_PartNumber.Name = "TB_PartNumber"
        Me.TB_PartNumber.Size = New System.Drawing.Size(228, 20)
        Me.TB_PartNumber.TabIndex = 102
        '
        'TB_Manufacturer
        '
        Me.TB_Manufacturer.Location = New System.Drawing.Point(12, 25)
        Me.TB_Manufacturer.Name = "TB_Manufacturer"
        Me.TB_Manufacturer.Size = New System.Drawing.Size(228, 20)
        Me.TB_Manufacturer.TabIndex = 96
        '
        'NUD_PinRef_Y
        '
        Me.NUD_PinRef_Y.DecimalPlaces = 2
        Me.NUD_PinRef_Y.Location = New System.Drawing.Point(488, 66)
        Me.NUD_PinRef_Y.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.NUD_PinRef_Y.Minimum = New Decimal(New Integer() {999, 0, 0, -2147483648})
        Me.NUD_PinRef_Y.Name = "NUD_PinRef_Y"
        Me.NUD_PinRef_Y.Size = New System.Drawing.Size(70, 20)
        Me.NUD_PinRef_Y.TabIndex = 100
        Me.NUD_PinRef_Y.TabStop = False
        Me.NUD_PinRef_Y.Value = New Decimal(New Integer() {125, 0, 0, 65536})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(246, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 13)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Pin Reference (From Lower Left)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(485, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Y [mm]"
        '
        'NUD_Size_Y
        '
        Me.NUD_Size_Y.DecimalPlaces = 2
        Me.NUD_Size_Y.Location = New System.Drawing.Point(488, 26)
        Me.NUD_Size_Y.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.NUD_Size_Y.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.NUD_Size_Y.Name = "NUD_Size_Y"
        Me.NUD_Size_Y.Size = New System.Drawing.Size(70, 20)
        Me.NUD_Size_Y.TabIndex = 96
        Me.NUD_Size_Y.TabStop = False
        Me.NUD_Size_Y.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'NUD_PinRef_X
        '
        Me.NUD_PinRef_X.DecimalPlaces = 2
        Me.NUD_PinRef_X.Location = New System.Drawing.Point(412, 66)
        Me.NUD_PinRef_X.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.NUD_PinRef_X.Minimum = New Decimal(New Integer() {999, 0, 0, -2147483648})
        Me.NUD_PinRef_X.Name = "NUD_PinRef_X"
        Me.NUD_PinRef_X.Size = New System.Drawing.Size(70, 20)
        Me.NUD_PinRef_X.TabIndex = 98
        Me.NUD_PinRef_X.TabStop = False
        Me.NUD_PinRef_X.Value = New Decimal(New Integer() {125, 0, 0, 65536})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(409, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 97
        Me.Label4.Text = "X [mm]"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(485, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 95
        Me.Label12.Text = "Height [mm]"
        '
        'NUD_Size_X
        '
        Me.NUD_Size_X.DecimalPlaces = 2
        Me.NUD_Size_X.Location = New System.Drawing.Point(412, 26)
        Me.NUD_Size_X.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.NUD_Size_X.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.NUD_Size_X.Name = "NUD_Size_X"
        Me.NUD_Size_X.Size = New System.Drawing.Size(70, 20)
        Me.NUD_Size_X.TabIndex = 94
        Me.NUD_Size_X.TabStop = False
        Me.NUD_Size_X.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(409, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Width [mm]"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BUTT_AddPin)
        Me.GroupBox1.Controls.Add(Me.NUD_Pin_DisplayDiameter)
        Me.GroupBox1.Controls.Add(Me.TB_Pin_Label)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.NUD_Pin_Y)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.NUD_Pin_X)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(641, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(158, 172)
        Me.GroupBox1.TabIndex = 94
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Pin/Socket"
        '
        'BUTT_AddPin
        '
        Me.BUTT_AddPin.Location = New System.Drawing.Point(6, 140)
        Me.BUTT_AddPin.Name = "BUTT_AddPin"
        Me.BUTT_AddPin.Size = New System.Drawing.Size(70, 23)
        Me.BUTT_AddPin.TabIndex = 0
        Me.BUTT_AddPin.Text = "Add"
        Me.BUTT_AddPin.UseVisualStyleBackColor = True
        '
        'NUD_Pin_DisplayDiameter
        '
        Me.NUD_Pin_DisplayDiameter.DecimalPlaces = 2
        Me.NUD_Pin_DisplayDiameter.Location = New System.Drawing.Point(6, 114)
        Me.NUD_Pin_DisplayDiameter.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.NUD_Pin_DisplayDiameter.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.NUD_Pin_DisplayDiameter.Name = "NUD_Pin_DisplayDiameter"
        Me.NUD_Pin_DisplayDiameter.Size = New System.Drawing.Size(70, 20)
        Me.NUD_Pin_DisplayDiameter.TabIndex = 102
        Me.NUD_Pin_DisplayDiameter.TabStop = False
        Me.NUD_Pin_DisplayDiameter.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'TB_Pin_Label
        '
        Me.TB_Pin_Label.Location = New System.Drawing.Point(6, 34)
        Me.TB_Pin_Label.Name = "TB_Pin_Label"
        Me.TB_Pin_Label.Size = New System.Drawing.Size(90, 20)
        Me.TB_Pin_Label.TabIndex = 96
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 13)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "Display Diameter [mm]"
        '
        'NUD_Pin_Y
        '
        Me.NUD_Pin_Y.DecimalPlaces = 2
        Me.NUD_Pin_Y.Location = New System.Drawing.Point(82, 74)
        Me.NUD_Pin_Y.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.NUD_Pin_Y.Minimum = New Decimal(New Integer() {999, 0, 0, -2147483648})
        Me.NUD_Pin_Y.Name = "NUD_Pin_Y"
        Me.NUD_Pin_Y.Size = New System.Drawing.Size(70, 20)
        Me.NUD_Pin_Y.TabIndex = 100
        Me.NUD_Pin_Y.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Pin Label/Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(79, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "Y [mm]"
        '
        'NUD_Pin_X
        '
        Me.NUD_Pin_X.DecimalPlaces = 2
        Me.NUD_Pin_X.Location = New System.Drawing.Point(6, 74)
        Me.NUD_Pin_X.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.NUD_Pin_X.Minimum = New Decimal(New Integer() {999, 0, 0, -2147483648})
        Me.NUD_Pin_X.Name = "NUD_Pin_X"
        Me.NUD_Pin_X.Size = New System.Drawing.Size(70, 20)
        Me.NUD_Pin_X.TabIndex = 98
        Me.NUD_Pin_X.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 97
        Me.Label8.Text = "X [mm]"
        '
        'DGV_Pins
        '
        Me.DGV_Pins.AllowUserToAddRows = False
        Me.DGV_Pins.AllowUserToResizeColumns = False
        Me.DGV_Pins.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGV_Pins.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_Pins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_Pins.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_Pins_Name, Me.DGV_Pins_X, Me.DGV_Pins_Y, Me.DGV_Pins_DisplayDiameter})
        Me.DGV_Pins.Location = New System.Drawing.Point(641, 292)
        Me.DGV_Pins.Name = "DGV_Pins"
        Me.DGV_Pins.RowHeadersWidth = 40
        Me.DGV_Pins.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGV_Pins.Size = New System.Drawing.Size(360, 427)
        Me.DGV_Pins.TabIndex = 104
        '
        'DGV_Pins_Name
        '
        Me.DGV_Pins_Name.DataPropertyName = "Name"
        Me.DGV_Pins_Name.HeaderText = "Name"
        Me.DGV_Pins_Name.Name = "DGV_Pins_Name"
        Me.DGV_Pins_Name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Pins_Name.Width = 50
        '
        'DGV_Pins_X
        '
        Me.DGV_Pins_X.DataPropertyName = "X"
        Me.DGV_Pins_X.HeaderText = "X [mm]"
        Me.DGV_Pins_X.Name = "DGV_Pins_X"
        Me.DGV_Pins_X.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Pins_X.Width = 50
        '
        'DGV_Pins_Y
        '
        Me.DGV_Pins_Y.DataPropertyName = "Y"
        Me.DGV_Pins_Y.HeaderText = "Y [mm]"
        Me.DGV_Pins_Y.Name = "DGV_Pins_Y"
        Me.DGV_Pins_Y.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Pins_Y.Width = 50
        '
        'DGV_Pins_DisplayDiameter
        '
        Me.DGV_Pins_DisplayDiameter.DataPropertyName = "Diameter"
        Me.DGV_Pins_DisplayDiameter.HeaderText = "Display Diameter [mm]"
        Me.DGV_Pins_DisplayDiameter.Name = "DGV_Pins_DisplayDiameter"
        Me.DGV_Pins_DisplayDiameter.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Pins_DisplayDiameter.Width = 140
        '
        'ChB_CenterRef
        '
        Me.ChB_CenterRef.AutoSize = True
        Me.ChB_CenterRef.Checked = True
        Me.ChB_CenterRef.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChB_CenterRef.Location = New System.Drawing.Point(564, 67)
        Me.ChB_CenterRef.Name = "ChB_CenterRef"
        Me.ChB_CenterRef.Size = New System.Drawing.Size(57, 17)
        Me.ChB_CenterRef.TabIndex = 105
        Me.ChB_CenterRef.Text = "Center"
        Me.ChB_CenterRef.UseVisualStyleBackColor = True
        '
        'NUD_DiameterOverride
        '
        Me.NUD_DiameterOverride.DecimalPlaces = 2
        Me.NUD_DiameterOverride.Location = New System.Drawing.Point(729, 206)
        Me.NUD_DiameterOverride.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.NUD_DiameterOverride.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.NUD_DiameterOverride.Name = "NUD_DiameterOverride"
        Me.NUD_DiameterOverride.Size = New System.Drawing.Size(70, 20)
        Me.NUD_DiameterOverride.TabIndex = 104
        Me.NUD_DiameterOverride.TabStop = False
        Me.NUD_DiameterOverride.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(638, 187)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 13)
        Me.Label11.TabIndex = 103
        Me.Label11.Text = "Display Diameter [mm]"
        '
        'BUTT_UpdateDiameters
        '
        Me.BUTT_UpdateDiameters.Location = New System.Drawing.Point(641, 203)
        Me.BUTT_UpdateDiameters.Name = "BUTT_UpdateDiameters"
        Me.BUTT_UpdateDiameters.Size = New System.Drawing.Size(82, 23)
        Me.BUTT_UpdateDiameters.TabIndex = 105
        Me.BUTT_UpdateDiameters.Text = "Change All"
        Me.BUTT_UpdateDiameters.UseVisualStyleBackColor = True
        '
        'CB_DGV_Display
        '
        Me.CB_DGV_Display.FormattingEnabled = True
        Me.CB_DGV_Display.Items.AddRange(New Object() {"Pins", "Outlines-Circle", "Outlines-Rect"})
        Me.CB_DGV_Display.Location = New System.Drawing.Point(641, 265)
        Me.CB_DGV_Display.Name = "CB_DGV_Display"
        Me.CB_DGV_Display.Size = New System.Drawing.Size(121, 21)
        Me.CB_DGV_Display.TabIndex = 106
        '
        'DGV_Outlines_Circle
        '
        Me.DGV_Outlines_Circle.AllowUserToAddRows = False
        Me.DGV_Outlines_Circle.AllowUserToResizeColumns = False
        Me.DGV_Outlines_Circle.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGV_Outlines_Circle.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_Outlines_Circle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_Outlines_Circle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_Circles_X, Me.DGV_Circles_Y, Me.DGV_Circles_Diameter})
        Me.DGV_Outlines_Circle.Location = New System.Drawing.Point(641, 292)
        Me.DGV_Outlines_Circle.Name = "DGV_Outlines_Circle"
        Me.DGV_Outlines_Circle.RowHeadersWidth = 40
        Me.DGV_Outlines_Circle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGV_Outlines_Circle.Size = New System.Drawing.Size(316, 427)
        Me.DGV_Outlines_Circle.TabIndex = 108
        Me.DGV_Outlines_Circle.Visible = False
        '
        'DGV_Circles_X
        '
        Me.DGV_Circles_X.DataPropertyName = "X"
        Me.DGV_Circles_X.HeaderText = "X [mm]"
        Me.DGV_Circles_X.Name = "DGV_Circles_X"
        Me.DGV_Circles_X.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Circles_X.Width = 50
        '
        'DGV_Circles_Y
        '
        Me.DGV_Circles_Y.DataPropertyName = "Y"
        Me.DGV_Circles_Y.HeaderText = "Y [mm]"
        Me.DGV_Circles_Y.Name = "DGV_Circles_Y"
        Me.DGV_Circles_Y.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Circles_Y.Width = 50
        '
        'DGV_Circles_Diameter
        '
        Me.DGV_Circles_Diameter.DataPropertyName = "Diameter"
        Me.DGV_Circles_Diameter.HeaderText = "Diameter [mm]"
        Me.DGV_Circles_Diameter.Name = "DGV_Circles_Diameter"
        Me.DGV_Circles_Diameter.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Circles_Diameter.Width = 140
        '
        'BUTT_Save
        '
        Me.BUTT_Save.Location = New System.Drawing.Point(12, 696)
        Me.BUTT_Save.Name = "BUTT_Save"
        Me.BUTT_Save.Size = New System.Drawing.Size(80, 23)
        Me.BUTT_Save.TabIndex = 109
        Me.BUTT_Save.Text = "Save"
        Me.BUTT_Save.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Manufacturer"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BUTT_AddBorderCircle)
        Me.GroupBox3.Controls.Add(Me.BUTT_AddCircle)
        Me.GroupBox3.Controls.Add(Me.NUD_CircleDiameter)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.NUD_CircleY)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.NUD_CircleX)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Location = New System.Drawing.Point(805, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(221, 134)
        Me.GroupBox3.TabIndex = 103
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Add Circle Outline"
        '
        'BUTT_AddBorderCircle
        '
        Me.BUTT_AddBorderCircle.Location = New System.Drawing.Point(95, 100)
        Me.BUTT_AddBorderCircle.Name = "BUTT_AddBorderCircle"
        Me.BUTT_AddBorderCircle.Size = New System.Drawing.Size(114, 23)
        Me.BUTT_AddBorderCircle.TabIndex = 106
        Me.BUTT_AddBorderCircle.Text = "Add Border"
        Me.BUTT_AddBorderCircle.UseVisualStyleBackColor = True
        '
        'BUTT_AddCircle
        '
        Me.BUTT_AddCircle.Location = New System.Drawing.Point(6, 100)
        Me.BUTT_AddCircle.Name = "BUTT_AddCircle"
        Me.BUTT_AddCircle.Size = New System.Drawing.Size(70, 23)
        Me.BUTT_AddCircle.TabIndex = 0
        Me.BUTT_AddCircle.Text = "Add"
        Me.BUTT_AddCircle.UseVisualStyleBackColor = True
        '
        'NUD_CircleDiameter
        '
        Me.NUD_CircleDiameter.DecimalPlaces = 2
        Me.NUD_CircleDiameter.Location = New System.Drawing.Point(6, 74)
        Me.NUD_CircleDiameter.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.NUD_CircleDiameter.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.NUD_CircleDiameter.Name = "NUD_CircleDiameter"
        Me.NUD_CircleDiameter.Size = New System.Drawing.Size(70, 20)
        Me.NUD_CircleDiameter.TabIndex = 102
        Me.NUD_CircleDiameter.TabStop = False
        Me.NUD_CircleDiameter.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 13)
        Me.Label10.TabIndex = 101
        Me.Label10.Text = "Display Diameter [mm]"
        '
        'NUD_CircleY
        '
        Me.NUD_CircleY.DecimalPlaces = 2
        Me.NUD_CircleY.Location = New System.Drawing.Point(82, 34)
        Me.NUD_CircleY.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.NUD_CircleY.Minimum = New Decimal(New Integer() {999, 0, 0, -2147483648})
        Me.NUD_CircleY.Name = "NUD_CircleY"
        Me.NUD_CircleY.Size = New System.Drawing.Size(70, 20)
        Me.NUD_CircleY.TabIndex = 100
        Me.NUD_CircleY.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(79, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 13)
        Me.Label14.TabIndex = 99
        Me.Label14.Text = "Y [mm]"
        '
        'NUD_CircleX
        '
        Me.NUD_CircleX.DecimalPlaces = 2
        Me.NUD_CircleX.Location = New System.Drawing.Point(6, 34)
        Me.NUD_CircleX.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.NUD_CircleX.Minimum = New Decimal(New Integer() {999, 0, 0, -2147483648})
        Me.NUD_CircleX.Name = "NUD_CircleX"
        Me.NUD_CircleX.Size = New System.Drawing.Size(70, 20)
        Me.NUD_CircleX.TabIndex = 98
        Me.NUD_CircleX.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 13)
        Me.Label15.TabIndex = 97
        Me.Label15.Text = "X [mm]"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BUTT_AddBorder_Rectangle)
        Me.GroupBox4.Controls.Add(Me.NUD_Rect_Y2)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.NUD_Rect_X2)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.BUTT_AddRectangle)
        Me.GroupBox4.Controls.Add(Me.NUD_Rect_Y1)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.NUD_Rect_X1)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Location = New System.Drawing.Point(805, 152)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(221, 134)
        Me.GroupBox4.TabIndex = 104
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Add Rectangle Outline"
        '
        'BUTT_AddBorder_Rectangle
        '
        Me.BUTT_AddBorder_Rectangle.Location = New System.Drawing.Point(95, 100)
        Me.BUTT_AddBorder_Rectangle.Name = "BUTT_AddBorder_Rectangle"
        Me.BUTT_AddBorder_Rectangle.Size = New System.Drawing.Size(114, 23)
        Me.BUTT_AddBorder_Rectangle.TabIndex = 105
        Me.BUTT_AddBorder_Rectangle.Text = "Add Border"
        Me.BUTT_AddBorder_Rectangle.UseVisualStyleBackColor = True
        '
        'NUD_Rect_Y2
        '
        Me.NUD_Rect_Y2.DecimalPlaces = 2
        Me.NUD_Rect_Y2.Location = New System.Drawing.Point(82, 74)
        Me.NUD_Rect_Y2.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.NUD_Rect_Y2.Minimum = New Decimal(New Integer() {999, 0, 0, -2147483648})
        Me.NUD_Rect_Y2.Name = "NUD_Rect_Y2"
        Me.NUD_Rect_Y2.Size = New System.Drawing.Size(70, 20)
        Me.NUD_Rect_Y2.TabIndex = 104
        Me.NUD_Rect_Y2.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(79, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 103
        Me.Label13.Text = "Y2 [mm]"
        '
        'NUD_Rect_X2
        '
        Me.NUD_Rect_X2.DecimalPlaces = 2
        Me.NUD_Rect_X2.Location = New System.Drawing.Point(6, 74)
        Me.NUD_Rect_X2.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.NUD_Rect_X2.Minimum = New Decimal(New Integer() {999, 0, 0, -2147483648})
        Me.NUD_Rect_X2.Name = "NUD_Rect_X2"
        Me.NUD_Rect_X2.Size = New System.Drawing.Size(70, 20)
        Me.NUD_Rect_X2.TabIndex = 102
        Me.NUD_Rect_X2.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 57)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 13)
        Me.Label18.TabIndex = 101
        Me.Label18.Text = "X2 [mm]"
        '
        'BUTT_AddRectangle
        '
        Me.BUTT_AddRectangle.Location = New System.Drawing.Point(6, 100)
        Me.BUTT_AddRectangle.Name = "BUTT_AddRectangle"
        Me.BUTT_AddRectangle.Size = New System.Drawing.Size(70, 23)
        Me.BUTT_AddRectangle.TabIndex = 0
        Me.BUTT_AddRectangle.Text = "Add"
        Me.BUTT_AddRectangle.UseVisualStyleBackColor = True
        '
        'NUD_Rect_Y1
        '
        Me.NUD_Rect_Y1.DecimalPlaces = 2
        Me.NUD_Rect_Y1.Location = New System.Drawing.Point(82, 34)
        Me.NUD_Rect_Y1.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.NUD_Rect_Y1.Minimum = New Decimal(New Integer() {999, 0, 0, -2147483648})
        Me.NUD_Rect_Y1.Name = "NUD_Rect_Y1"
        Me.NUD_Rect_Y1.Size = New System.Drawing.Size(70, 20)
        Me.NUD_Rect_Y1.TabIndex = 100
        Me.NUD_Rect_Y1.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(79, 17)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 99
        Me.Label16.Text = "Y1 [mm]"
        '
        'NUD_Rect_X1
        '
        Me.NUD_Rect_X1.DecimalPlaces = 2
        Me.NUD_Rect_X1.Location = New System.Drawing.Point(6, 34)
        Me.NUD_Rect_X1.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.NUD_Rect_X1.Minimum = New Decimal(New Integer() {999, 0, 0, -2147483648})
        Me.NUD_Rect_X1.Name = "NUD_Rect_X1"
        Me.NUD_Rect_X1.Size = New System.Drawing.Size(70, 20)
        Me.NUD_Rect_X1.TabIndex = 98
        Me.NUD_Rect_X1.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 13)
        Me.Label17.TabIndex = 97
        Me.Label17.Text = "X1 [mm]"
        '
        'DGV_Outlines_Rect
        '
        Me.DGV_Outlines_Rect.AllowUserToAddRows = False
        Me.DGV_Outlines_Rect.AllowUserToResizeColumns = False
        Me.DGV_Outlines_Rect.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGV_Outlines_Rect.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_Outlines_Rect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_Outlines_Rect.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_Outlines_Rect_X1, Me.DataGridViewTextBoxColumn2, Me.DGV_Outlines_Rect_X2, Me.DGV_Outlines_Rect_Y2})
        Me.DGV_Outlines_Rect.Location = New System.Drawing.Point(641, 292)
        Me.DGV_Outlines_Rect.Name = "DGV_Outlines_Rect"
        Me.DGV_Outlines_Rect.RowHeadersWidth = 40
        Me.DGV_Outlines_Rect.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGV_Outlines_Rect.Size = New System.Drawing.Size(299, 427)
        Me.DGV_Outlines_Rect.TabIndex = 110
        Me.DGV_Outlines_Rect.Visible = False
        '
        'DGV_Outlines_Rect_X1
        '
        Me.DGV_Outlines_Rect_X1.DataPropertyName = "X1"
        Me.DGV_Outlines_Rect_X1.HeaderText = "X1 [mm]"
        Me.DGV_Outlines_Rect_X1.Name = "DGV_Outlines_Rect_X1"
        Me.DGV_Outlines_Rect_X1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Outlines_Rect_X1.Width = 55
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Y1"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Y1 [mm]"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn2.Width = 55
        '
        'DGV_Outlines_Rect_X2
        '
        Me.DGV_Outlines_Rect_X2.DataPropertyName = "X2"
        Me.DGV_Outlines_Rect_X2.HeaderText = "X2 [mm]"
        Me.DGV_Outlines_Rect_X2.Name = "DGV_Outlines_Rect_X2"
        Me.DGV_Outlines_Rect_X2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Outlines_Rect_X2.Width = 55
        '
        'DGV_Outlines_Rect_Y2
        '
        Me.DGV_Outlines_Rect_Y2.DataPropertyName = "Y2"
        Me.DGV_Outlines_Rect_Y2.HeaderText = "Y2 [mm]"
        Me.DGV_Outlines_Rect_Y2.Name = "DGV_Outlines_Rect_Y2"
        Me.DGV_Outlines_Rect_Y2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Outlines_Rect_Y2.Width = 55
        '
        'BUTT_Cancel
        '
        Me.BUTT_Cancel.Location = New System.Drawing.Point(98, 696)
        Me.BUTT_Cancel.Name = "BUTT_Cancel"
        Me.BUTT_Cancel.Size = New System.Drawing.Size(80, 23)
        Me.BUTT_Cancel.TabIndex = 111
        Me.BUTT_Cancel.Text = "Cancel"
        Me.BUTT_Cancel.UseVisualStyleBackColor = True
        '
        'TB_Trick
        '
        Me.TB_Trick.Location = New System.Drawing.Point(502, 115)
        Me.TB_Trick.Name = "TB_Trick"
        Me.TB_Trick.Size = New System.Drawing.Size(100, 20)
        Me.TB_Trick.TabIndex = 112
        '
        'UI_ModifyConnector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 729)
        Me.Controls.Add(Me.BUTT_Cancel)
        Me.Controls.Add(Me.DGV_Outlines_Rect)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ChB_CenterRef)
        Me.Controls.Add(Me.TB_Manufacturer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LAB_PartNumber)
        Me.Controls.Add(Me.TB_PartNumber)
        Me.Controls.Add(Me.NUD_PinRef_Y)
        Me.Controls.Add(Me.BUTT_Save)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DGV_Outlines_Circle)
        Me.Controls.Add(Me.NUD_PinRef_X)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NUD_Size_Y)
        Me.Controls.Add(Me.CB_DGV_Display)
        Me.Controls.Add(Me.BUTT_UpdateDiameters)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.NUD_DiameterOverride)
        Me.Controls.Add(Me.NUD_Size_X)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DGV_Pins)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PB_Connector)
        Me.Controls.Add(Me.TB_Trick)
        Me.Name = "UI_ModifyConnector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modify Connector"
        Me.TopMost = True
        CType(Me.PB_Connector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_PinRef_Y, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Size_Y, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_PinRef_X, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Size_X, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NUD_Pin_DisplayDiameter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Pin_Y, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Pin_X, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Pins, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_DiameterOverride, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Outlines_Circle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.NUD_CircleDiameter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_CircleY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_CircleX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.NUD_Rect_Y2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Rect_X2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Rect_Y1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Rect_X1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Outlines_Rect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PB_Connector As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NUD_Size_Y As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents NUD_Size_X As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NUD_PinRef_X As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents NUD_PinRef_Y As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BUTT_AddPin As Button
    Friend WithEvents NUD_Pin_DisplayDiameter As NumericUpDown
    Friend WithEvents TB_Pin_Label As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents NUD_Pin_Y As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NUD_Pin_X As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents LAB_PartNumber As Label
    Friend WithEvents TB_PartNumber As TextBox
    Friend WithEvents TB_Manufacturer As TextBox
    Friend WithEvents DGV_Pins As DataGridView
    Friend WithEvents ChB_CenterRef As CheckBox
    Friend WithEvents DGV_Pins_Name As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Pins_X As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Pins_Y As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Pins_DisplayDiameter As DataGridViewTextBoxColumn
    Friend WithEvents NUD_DiameterOverride As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents BUTT_UpdateDiameters As Button
    Friend WithEvents CB_DGV_Display As ComboBox
    Friend WithEvents DGV_Outlines_Circle As DataGridView
    Friend WithEvents DGV_Circles_X As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Circles_Y As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Circles_Diameter As DataGridViewTextBoxColumn
    Friend WithEvents BUTT_Save As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BUTT_AddCircle As Button
    Friend WithEvents NUD_CircleDiameter As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents NUD_CircleY As NumericUpDown
    Friend WithEvents Label14 As Label
    Friend WithEvents NUD_CircleX As NumericUpDown
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents NUD_Rect_Y2 As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents NUD_Rect_X2 As NumericUpDown
    Friend WithEvents Label18 As Label
    Friend WithEvents BUTT_AddRectangle As Button
    Friend WithEvents NUD_Rect_Y1 As NumericUpDown
    Friend WithEvents Label16 As Label
    Friend WithEvents NUD_Rect_X1 As NumericUpDown
    Friend WithEvents Label17 As Label
    Friend WithEvents DGV_Outlines_Rect As DataGridView
    Friend WithEvents DGV_Outlines_Rect_X1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Outlines_Rect_X2 As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Outlines_Rect_Y2 As DataGridViewTextBoxColumn
    Friend WithEvents BUTT_Cancel As Button
    Friend WithEvents TB_Trick As TextBox
    Friend WithEvents BUTT_AddBorderCircle As Button
    Friend WithEvents BUTT_AddBorder_Rectangle As Button
End Class
