<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_ModifyTray
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BUTT_Cancel = New System.Windows.Forms.Button()
        Me.DGV_Outlines_Rect = New System.Windows.Forms.DataGridView()
        Me.DGV_Outlines_Rect_X1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Outlines_Rect_X2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Outlines_Rect_Y2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BUTT_AddBorderCircle = New System.Windows.Forms.Button()
        Me.BUTT_AddCircle = New System.Windows.Forms.Button()
        Me.NUD_CircleDiameter = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NUD_CircleY = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.NUD_CircleX = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TB_Manufacturer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BUTT_Save = New System.Windows.Forms.Button()
        Me.DGV_Outlines_Circle = New System.Windows.Forms.DataGridView()
        Me.DGV_Circles_X = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Circles_Y = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Circles_Diameter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUD_Size_Y = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.NUD_Size_X = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PB_Connector = New System.Windows.Forms.PictureBox()
        Me.TB_Trick = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DGV_Outlines_Rect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.NUD_Rect_Y2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Rect_X2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Rect_Y1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Rect_X1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.NUD_CircleDiameter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_CircleY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_CircleX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Outlines_Circle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Size_Y, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Size_X, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Connector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BUTT_Cancel
        '
        Me.BUTT_Cancel.Location = New System.Drawing.Point(101, 696)
        Me.BUTT_Cancel.Name = "BUTT_Cancel"
        Me.BUTT_Cancel.Size = New System.Drawing.Size(80, 23)
        Me.BUTT_Cancel.TabIndex = 139
        Me.BUTT_Cancel.Text = "Cancel"
        Me.BUTT_Cancel.UseVisualStyleBackColor = True
        '
        'DGV_Outlines_Rect
        '
        Me.DGV_Outlines_Rect.AllowUserToAddRows = False
        Me.DGV_Outlines_Rect.AllowUserToResizeColumns = False
        Me.DGV_Outlines_Rect.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGV_Outlines_Rect.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_Outlines_Rect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_Outlines_Rect.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_Outlines_Rect_X1, Me.DataGridViewTextBoxColumn2, Me.DGV_Outlines_Rect_X2, Me.DGV_Outlines_Rect_Y2})
        Me.DGV_Outlines_Rect.Location = New System.Drawing.Point(630, 458)
        Me.DGV_Outlines_Rect.Name = "DGV_Outlines_Rect"
        Me.DGV_Outlines_Rect.RowHeadersWidth = 40
        Me.DGV_Outlines_Rect.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGV_Outlines_Rect.Size = New System.Drawing.Size(299, 250)
        Me.DGV_Outlines_Rect.TabIndex = 138
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
        Me.GroupBox4.Location = New System.Drawing.Point(857, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(221, 134)
        Me.GroupBox4.TabIndex = 131
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Add Rectangular Connector"
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
        Me.GroupBox3.Location = New System.Drawing.Point(630, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(221, 134)
        Me.GroupBox3.TabIndex = 127
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Add Circular Connector"
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
        'TB_Manufacturer
        '
        Me.TB_Manufacturer.Location = New System.Drawing.Point(15, 64)
        Me.TB_Manufacturer.Name = "TB_Manufacturer"
        Me.TB_Manufacturer.Size = New System.Drawing.Size(228, 20)
        Me.TB_Manufacturer.TabIndex = 120
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 134
        Me.Label1.Text = "Tray Name"
        '
        'BUTT_Save
        '
        Me.BUTT_Save.Location = New System.Drawing.Point(15, 696)
        Me.BUTT_Save.Name = "BUTT_Save"
        Me.BUTT_Save.Size = New System.Drawing.Size(80, 23)
        Me.BUTT_Save.TabIndex = 137
        Me.BUTT_Save.Text = "Save"
        Me.BUTT_Save.UseVisualStyleBackColor = True
        '
        'DGV_Outlines_Circle
        '
        Me.DGV_Outlines_Circle.AllowUserToAddRows = False
        Me.DGV_Outlines_Circle.AllowUserToResizeColumns = False
        Me.DGV_Outlines_Circle.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGV_Outlines_Circle.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_Outlines_Circle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_Outlines_Circle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_Circles_X, Me.DGV_Circles_Y, Me.DGV_Circles_Diameter})
        Me.DGV_Outlines_Circle.Location = New System.Drawing.Point(630, 172)
        Me.DGV_Outlines_Circle.Name = "DGV_Outlines_Circle"
        Me.DGV_Outlines_Circle.RowHeadersWidth = 40
        Me.DGV_Outlines_Circle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGV_Outlines_Circle.Size = New System.Drawing.Size(316, 250)
        Me.DGV_Outlines_Circle.TabIndex = 136
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
        'NUD_Size_Y
        '
        Me.NUD_Size_Y.DecimalPlaces = 2
        Me.NUD_Size_Y.Location = New System.Drawing.Point(545, 64)
        Me.NUD_Size_Y.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.NUD_Size_Y.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.NUD_Size_Y.Name = "NUD_Size_Y"
        Me.NUD_Size_Y.Size = New System.Drawing.Size(70, 20)
        Me.NUD_Size_Y.TabIndex = 119
        Me.NUD_Size_Y.TabStop = False
        Me.NUD_Size_Y.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(542, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 118
        Me.Label12.Text = "Height [mm]"
        '
        'NUD_Size_X
        '
        Me.NUD_Size_X.DecimalPlaces = 2
        Me.NUD_Size_X.Location = New System.Drawing.Point(469, 64)
        Me.NUD_Size_X.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.NUD_Size_X.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.NUD_Size_X.Name = "NUD_Size_X"
        Me.NUD_Size_X.Size = New System.Drawing.Size(70, 20)
        Me.NUD_Size_X.TabIndex = 116
        Me.NUD_Size_X.TabStop = False
        Me.NUD_Size_X.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(466, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "Width [mm]"
        '
        'PB_Connector
        '
        Me.PB_Connector.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PB_Connector.InitialImage = Nothing
        Me.PB_Connector.Location = New System.Drawing.Point(15, 90)
        Me.PB_Connector.Name = "PB_Connector"
        Me.PB_Connector.Size = New System.Drawing.Size(600, 600)
        Me.PB_Connector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Connector.TabIndex = 113
        Me.PB_Connector.TabStop = False
        '
        'TB_Trick
        '
        Me.TB_Trick.Location = New System.Drawing.Point(505, 115)
        Me.TB_Trick.Name = "TB_Trick"
        Me.TB_Trick.Size = New System.Drawing.Size(100, 20)
        Me.TB_Trick.TabIndex = 140
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(627, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 141
        Me.Label5.Text = "Circular"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(627, 442)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 142
        Me.Label6.Text = "Rectangular"
        '
        'UI_ModifyTray
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 729)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BUTT_Cancel)
        Me.Controls.Add(Me.DGV_Outlines_Rect)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.TB_Manufacturer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BUTT_Save)
        Me.Controls.Add(Me.DGV_Outlines_Circle)
        Me.Controls.Add(Me.NUD_Size_Y)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.NUD_Size_X)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PB_Connector)
        Me.Controls.Add(Me.TB_Trick)
        Me.Name = "UI_ModifyTray"
        Me.Text = "UI_ModifyTray"
        CType(Me.DGV_Outlines_Rect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.NUD_Rect_Y2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Rect_X2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Rect_Y1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Rect_X1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.NUD_CircleDiameter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_CircleY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_CircleX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Outlines_Circle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Size_Y, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Size_X, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Connector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BUTT_Cancel As Button
    Friend WithEvents DGV_Outlines_Rect As DataGridView
    Friend WithEvents DGV_Outlines_Rect_X1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Outlines_Rect_X2 As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Outlines_Rect_Y2 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BUTT_AddBorder_Rectangle As Button
    Friend WithEvents NUD_Rect_Y2 As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents NUD_Rect_X2 As NumericUpDown
    Friend WithEvents Label18 As Label
    Friend WithEvents BUTT_AddRectangle As Button
    Friend WithEvents NUD_Rect_Y1 As NumericUpDown
    Friend WithEvents Label16 As Label
    Friend WithEvents NUD_Rect_X1 As NumericUpDown
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BUTT_AddBorderCircle As Button
    Friend WithEvents BUTT_AddCircle As Button
    Friend WithEvents NUD_CircleDiameter As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents NUD_CircleY As NumericUpDown
    Friend WithEvents Label14 As Label
    Friend WithEvents NUD_CircleX As NumericUpDown
    Friend WithEvents Label15 As Label
    Friend WithEvents TB_Manufacturer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BUTT_Save As Button
    Friend WithEvents DGV_Outlines_Circle As DataGridView
    Friend WithEvents DGV_Circles_X As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Circles_Y As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Circles_Diameter As DataGridViewTextBoxColumn
    Friend WithEvents NUD_Size_Y As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents NUD_Size_X As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents PB_Connector As PictureBox
    Friend WithEvents TB_Trick As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
