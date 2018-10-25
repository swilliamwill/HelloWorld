<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_DirectControl
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
        Me.GB_BowlControl = New System.Windows.Forms.GroupBox()
        Me.CBUTT_Bowl1 = New System.Windows.Forms.CheckBox()
        Me.CBUTT_Bowl4 = New System.Windows.Forms.CheckBox()
        Me.CBUTT_Bowl3 = New System.Windows.Forms.CheckBox()
        Me.CBUTT_Bowl2 = New System.Windows.Forms.CheckBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.NUD_Xpos_Set = New System.Windows.Forms.NumericUpDown()
        Me.NUD_Ypos_Set = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BUTT_GO = New System.Windows.Forms.Button()
        Me.BUTT_GoToLoad = New System.Windows.Forms.Button()
        Me.BUTT_Jog_YP = New System.Windows.Forms.Button()
        Me.NUD_JogIncrement = New System.Windows.Forms.NumericUpDown()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.BUTT_Jog_YN = New System.Windows.Forms.Button()
        Me.BUTT_Jog_XN = New System.Windows.Forms.Button()
        Me.BUTT_Jog_XP = New System.Windows.Forms.Button()
        Me.LAB_Trick = New System.Windows.Forms.Label()
        Me.GB_BowlControl.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.NUD_Xpos_Set, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Ypos_Set, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_JogIncrement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GB_BowlControl
        '
        Me.GB_BowlControl.Controls.Add(Me.CBUTT_Bowl1)
        Me.GB_BowlControl.Controls.Add(Me.CBUTT_Bowl4)
        Me.GB_BowlControl.Controls.Add(Me.CBUTT_Bowl3)
        Me.GB_BowlControl.Controls.Add(Me.CBUTT_Bowl2)
        Me.GB_BowlControl.Location = New System.Drawing.Point(264, 12)
        Me.GB_BowlControl.Name = "GB_BowlControl"
        Me.GB_BowlControl.Size = New System.Drawing.Size(169, 182)
        Me.GB_BowlControl.TabIndex = 1
        Me.GB_BowlControl.TabStop = False
        Me.GB_BowlControl.Text = "Bowl Control"
        '
        'CBUTT_Bowl1
        '
        Me.CBUTT_Bowl1.Appearance = System.Windows.Forms.Appearance.Button
        Me.CBUTT_Bowl1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CBUTT_Bowl1.Location = New System.Drawing.Point(6, 19)
        Me.CBUTT_Bowl1.Name = "CBUTT_Bowl1"
        Me.CBUTT_Bowl1.Size = New System.Drawing.Size(75, 75)
        Me.CBUTT_Bowl1.TabIndex = 4
        Me.CBUTT_Bowl1.Text = "BOWL 1"
        Me.CBUTT_Bowl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CBUTT_Bowl1.UseVisualStyleBackColor = True
        '
        'CBUTT_Bowl4
        '
        Me.CBUTT_Bowl4.Appearance = System.Windows.Forms.Appearance.Button
        Me.CBUTT_Bowl4.Location = New System.Drawing.Point(87, 100)
        Me.CBUTT_Bowl4.Name = "CBUTT_Bowl4"
        Me.CBUTT_Bowl4.Size = New System.Drawing.Size(75, 75)
        Me.CBUTT_Bowl4.TabIndex = 7
        Me.CBUTT_Bowl4.Text = "BOWL 4"
        Me.CBUTT_Bowl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CBUTT_Bowl4.UseVisualStyleBackColor = True
        '
        'CBUTT_Bowl3
        '
        Me.CBUTT_Bowl3.Appearance = System.Windows.Forms.Appearance.Button
        Me.CBUTT_Bowl3.Location = New System.Drawing.Point(6, 100)
        Me.CBUTT_Bowl3.Name = "CBUTT_Bowl3"
        Me.CBUTT_Bowl3.Size = New System.Drawing.Size(75, 75)
        Me.CBUTT_Bowl3.TabIndex = 6
        Me.CBUTT_Bowl3.Text = "BOWL 3"
        Me.CBUTT_Bowl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CBUTT_Bowl3.UseVisualStyleBackColor = True
        '
        'CBUTT_Bowl2
        '
        Me.CBUTT_Bowl2.Appearance = System.Windows.Forms.Appearance.Button
        Me.CBUTT_Bowl2.Location = New System.Drawing.Point(87, 19)
        Me.CBUTT_Bowl2.Name = "CBUTT_Bowl2"
        Me.CBUTT_Bowl2.Size = New System.Drawing.Size(75, 75)
        Me.CBUTT_Bowl2.TabIndex = 5
        Me.CBUTT_Bowl2.Text = "BOWL 2"
        Me.CBUTT_Bowl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CBUTT_Bowl2.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.NUD_Xpos_Set)
        Me.GroupBox7.Controls.Add(Me.NUD_Ypos_Set)
        Me.GroupBox7.Controls.Add(Me.Label11)
        Me.GroupBox7.Controls.Add(Me.Label16)
        Me.GroupBox7.Controls.Add(Me.BUTT_GO)
        Me.GroupBox7.Controls.Add(Me.BUTT_GoToLoad)
        Me.GroupBox7.Controls.Add(Me.BUTT_Jog_YP)
        Me.GroupBox7.Controls.Add(Me.NUD_JogIncrement)
        Me.GroupBox7.Controls.Add(Me.Label28)
        Me.GroupBox7.Controls.Add(Me.BUTT_Jog_YN)
        Me.GroupBox7.Controls.Add(Me.BUTT_Jog_XN)
        Me.GroupBox7.Controls.Add(Me.BUTT_Jog_XP)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(246, 216)
        Me.GroupBox7.TabIndex = 94
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Gantry Controls"
        '
        'NUD_Xpos_Set
        '
        Me.NUD_Xpos_Set.DecimalPlaces = 1
        Me.NUD_Xpos_Set.Location = New System.Drawing.Point(6, 62)
        Me.NUD_Xpos_Set.Maximum = New Decimal(New Integer() {110, 0, 0, 0})
        Me.NUD_Xpos_Set.Name = "NUD_Xpos_Set"
        Me.NUD_Xpos_Set.Size = New System.Drawing.Size(95, 20)
        Me.NUD_Xpos_Set.TabIndex = 1
        Me.NUD_Xpos_Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NUD_Ypos_Set
        '
        Me.NUD_Ypos_Set.DecimalPlaces = 1
        Me.NUD_Ypos_Set.Location = New System.Drawing.Point(107, 62)
        Me.NUD_Ypos_Set.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.NUD_Ypos_Set.Name = "NUD_Ypos_Set"
        Me.NUD_Ypos_Set.Size = New System.Drawing.Size(95, 20)
        Me.NUD_Ypos_Set.TabIndex = 2
        Me.NUD_Ypos_Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(104, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Y Set Position [mm]"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 45)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 13)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "X Set Position [mm]"
        '
        'BUTT_GO
        '
        Me.BUTT_GO.Location = New System.Drawing.Point(208, 59)
        Me.BUTT_GO.Name = "BUTT_GO"
        Me.BUTT_GO.Size = New System.Drawing.Size(31, 23)
        Me.BUTT_GO.TabIndex = 26
        Me.BUTT_GO.TabStop = False
        Me.BUTT_GO.Text = "Go"
        Me.BUTT_GO.UseVisualStyleBackColor = True
        '
        'BUTT_GoToLoad
        '
        Me.BUTT_GoToLoad.Location = New System.Drawing.Point(6, 19)
        Me.BUTT_GoToLoad.Name = "BUTT_GoToLoad"
        Me.BUTT_GoToLoad.Size = New System.Drawing.Size(96, 23)
        Me.BUTT_GoToLoad.TabIndex = 56
        Me.BUTT_GoToLoad.TabStop = False
        Me.BUTT_GoToLoad.Text = "Go To Load"
        Me.BUTT_GoToLoad.UseVisualStyleBackColor = True
        '
        'BUTT_Jog_YP
        '
        Me.BUTT_Jog_YP.Location = New System.Drawing.Point(100, 137)
        Me.BUTT_Jog_YP.Name = "BUTT_Jog_YP"
        Me.BUTT_Jog_YP.Size = New System.Drawing.Size(34, 23)
        Me.BUTT_Jog_YP.TabIndex = 45
        Me.BUTT_Jog_YP.TabStop = False
        Me.BUTT_Jog_YP.Text = "+Y"
        Me.BUTT_Jog_YP.UseVisualStyleBackColor = True
        '
        'NUD_JogIncrement
        '
        Me.NUD_JogIncrement.DecimalPlaces = 1
        Me.NUD_JogIncrement.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NUD_JogIncrement.Location = New System.Drawing.Point(75, 111)
        Me.NUD_JogIncrement.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.NUD_JogIncrement.Name = "NUD_JogIncrement"
        Me.NUD_JogIncrement.Size = New System.Drawing.Size(95, 20)
        Me.NUD_JogIncrement.TabIndex = 3
        Me.NUD_JogIncrement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NUD_JogIncrement.Value = New Decimal(New Integer() {5, 0, 0, 65536})
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(72, 95)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(99, 13)
        Me.Label28.TabIndex = 47
        Me.Label28.Text = "Jog Increment [mm]"
        '
        'BUTT_Jog_YN
        '
        Me.BUTT_Jog_YN.Location = New System.Drawing.Point(100, 185)
        Me.BUTT_Jog_YN.Name = "BUTT_Jog_YN"
        Me.BUTT_Jog_YN.Size = New System.Drawing.Size(34, 23)
        Me.BUTT_Jog_YN.TabIndex = 48
        Me.BUTT_Jog_YN.TabStop = False
        Me.BUTT_Jog_YN.Text = "-Y"
        Me.BUTT_Jog_YN.UseVisualStyleBackColor = True
        '
        'BUTT_Jog_XN
        '
        Me.BUTT_Jog_XN.Location = New System.Drawing.Point(69, 161)
        Me.BUTT_Jog_XN.Name = "BUTT_Jog_XN"
        Me.BUTT_Jog_XN.Size = New System.Drawing.Size(34, 23)
        Me.BUTT_Jog_XN.TabIndex = 49
        Me.BUTT_Jog_XN.TabStop = False
        Me.BUTT_Jog_XN.Text = "-X"
        Me.BUTT_Jog_XN.UseVisualStyleBackColor = True
        '
        'BUTT_Jog_XP
        '
        Me.BUTT_Jog_XP.Location = New System.Drawing.Point(131, 161)
        Me.BUTT_Jog_XP.Name = "BUTT_Jog_XP"
        Me.BUTT_Jog_XP.Size = New System.Drawing.Size(34, 23)
        Me.BUTT_Jog_XP.TabIndex = 50
        Me.BUTT_Jog_XP.TabStop = False
        Me.BUTT_Jog_XP.Text = "+X"
        Me.BUTT_Jog_XP.UseVisualStyleBackColor = True
        '
        'LAB_Trick
        '
        Me.LAB_Trick.AutoSize = True
        Me.LAB_Trick.Location = New System.Drawing.Point(426, 207)
        Me.LAB_Trick.Name = "LAB_Trick"
        Me.LAB_Trick.Size = New System.Drawing.Size(0, 13)
        Me.LAB_Trick.TabIndex = 95
        '
        'UI_DirectControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(439, 236)
        Me.Controls.Add(Me.LAB_Trick)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GB_BowlControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UI_DirectControl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UI_DirectControl"
        Me.GB_BowlControl.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.NUD_Xpos_Set, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Ypos_Set, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_JogIncrement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GB_BowlControl As GroupBox
    Friend WithEvents CBUTT_Bowl4 As CheckBox
    Friend WithEvents CBUTT_Bowl3 As CheckBox
    Friend WithEvents CBUTT_Bowl2 As CheckBox
    Friend WithEvents CBUTT_Bowl1 As CheckBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents NUD_Xpos_Set As NumericUpDown
    Friend WithEvents NUD_Ypos_Set As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents BUTT_GO As Button
    Friend WithEvents BUTT_GoToLoad As Button
    Friend WithEvents BUTT_Jog_YP As Button
    Friend WithEvents NUD_JogIncrement As NumericUpDown
    Friend WithEvents Label28 As Label
    Friend WithEvents BUTT_Jog_YN As Button
    Friend WithEvents BUTT_Jog_XN As Button
    Friend WithEvents BUTT_Jog_XP As Button
    Friend WithEvents LAB_Trick As Label
End Class
