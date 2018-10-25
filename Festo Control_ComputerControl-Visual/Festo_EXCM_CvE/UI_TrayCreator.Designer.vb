<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_TrayCreator
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
        Me.PB_Tray = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_ConnectorFile = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NUD_Width = New System.Windows.Forms.NumericUpDown()
        Me.GB_Tray = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NUD_TrayCenterY = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NUD_TrayCenterX = New System.Windows.Forms.NumericUpDown()
        Me.NUD_Height = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NUD_ConnectorCenterY = New System.Windows.Forms.NumericUpDown()
        Me.NUD_ConnectorCenterX = New System.Windows.Forms.NumericUpDown()
        Me.GB_Connector = New System.Windows.Forms.GroupBox()
        Me.NUD_DeleteConnector = New System.Windows.Forms.Button()
        Me.BUTT_AddNewConnector = New System.Windows.Forms.Button()
        Me.NUD_AcceptTray = New System.Windows.Forms.Button()
        Me.NUD_Cancel = New System.Windows.Forms.Button()
        CType(Me.PB_Tray, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Width, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Tray.SuspendLayout()
        CType(Me.NUD_TrayCenterY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_TrayCenterX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Height, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_ConnectorCenterY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_ConnectorCenterX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Connector.SuspendLayout()
        Me.SuspendLayout()
        '
        'PB_Tray
        '
        Me.PB_Tray.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PB_Tray.Location = New System.Drawing.Point(12, 25)
        Me.PB_Tray.Name = "PB_Tray"
        Me.PB_Tray.Size = New System.Drawing.Size(400, 400)
        Me.PB_Tray.TabIndex = 0
        Me.PB_Tray.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tray"
        '
        'CB_ConnectorFile
        '
        Me.CB_ConnectorFile.FormattingEnabled = True
        Me.CB_ConnectorFile.Location = New System.Drawing.Point(6, 32)
        Me.CB_ConnectorFile.Name = "CB_ConnectorFile"
        Me.CB_ConnectorFile.Size = New System.Drawing.Size(237, 21)
        Me.CB_ConnectorFile.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Connector File"
        '
        'NUD_Width
        '
        Me.NUD_Width.DecimalPlaces = 4
        Me.NUD_Width.Location = New System.Drawing.Point(9, 32)
        Me.NUD_Width.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NUD_Width.Name = "NUD_Width"
        Me.NUD_Width.Size = New System.Drawing.Size(81, 20)
        Me.NUD_Width.TabIndex = 4
        Me.NUD_Width.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'GB_Tray
        '
        Me.GB_Tray.Controls.Add(Me.Label5)
        Me.GB_Tray.Controls.Add(Me.Label4)
        Me.GB_Tray.Controls.Add(Me.Label6)
        Me.GB_Tray.Controls.Add(Me.NUD_TrayCenterY)
        Me.GB_Tray.Controls.Add(Me.Label3)
        Me.GB_Tray.Controls.Add(Me.NUD_TrayCenterX)
        Me.GB_Tray.Controls.Add(Me.NUD_Height)
        Me.GB_Tray.Controls.Add(Me.NUD_Width)
        Me.GB_Tray.Location = New System.Drawing.Point(418, 25)
        Me.GB_Tray.Name = "GB_Tray"
        Me.GB_Tray.Size = New System.Drawing.Size(185, 102)
        Me.GB_Tray.TabIndex = 5
        Me.GB_Tray.TabStop = False
        Me.GB_Tray.Text = "Tray Size/Center"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(93, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Center-Y [in]"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(93, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Height [in]"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Center-X [in]"
        '
        'NUD_TrayCenterY
        '
        Me.NUD_TrayCenterY.DecimalPlaces = 4
        Me.NUD_TrayCenterY.Location = New System.Drawing.Point(96, 71)
        Me.NUD_TrayCenterY.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NUD_TrayCenterY.Name = "NUD_TrayCenterY"
        Me.NUD_TrayCenterY.Size = New System.Drawing.Size(81, 20)
        Me.NUD_TrayCenterY.TabIndex = 11
        Me.NUD_TrayCenterY.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Width [in]"
        '
        'NUD_TrayCenterX
        '
        Me.NUD_TrayCenterX.DecimalPlaces = 4
        Me.NUD_TrayCenterX.Location = New System.Drawing.Point(9, 71)
        Me.NUD_TrayCenterX.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NUD_TrayCenterX.Name = "NUD_TrayCenterX"
        Me.NUD_TrayCenterX.Size = New System.Drawing.Size(81, 20)
        Me.NUD_TrayCenterX.TabIndex = 9
        Me.NUD_TrayCenterX.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'NUD_Height
        '
        Me.NUD_Height.DecimalPlaces = 4
        Me.NUD_Height.Location = New System.Drawing.Point(96, 32)
        Me.NUD_Height.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NUD_Height.Name = "NUD_Height"
        Me.NUD_Height.Size = New System.Drawing.Size(81, 20)
        Me.NUD_Height.TabIndex = 7
        Me.NUD_Height.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(90, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Center-Y [in]"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Center-X [in]"
        '
        'NUD_ConnectorCenterY
        '
        Me.NUD_ConnectorCenterY.DecimalPlaces = 4
        Me.NUD_ConnectorCenterY.Location = New System.Drawing.Point(93, 72)
        Me.NUD_ConnectorCenterY.Name = "NUD_ConnectorCenterY"
        Me.NUD_ConnectorCenterY.Size = New System.Drawing.Size(81, 20)
        Me.NUD_ConnectorCenterY.TabIndex = 15
        '
        'NUD_ConnectorCenterX
        '
        Me.NUD_ConnectorCenterX.DecimalPlaces = 4
        Me.NUD_ConnectorCenterX.Location = New System.Drawing.Point(6, 72)
        Me.NUD_ConnectorCenterX.Name = "NUD_ConnectorCenterX"
        Me.NUD_ConnectorCenterX.Size = New System.Drawing.Size(81, 20)
        Me.NUD_ConnectorCenterX.TabIndex = 13
        '
        'GB_Connector
        '
        Me.GB_Connector.Controls.Add(Me.CB_ConnectorFile)
        Me.GB_Connector.Controls.Add(Me.BUTT_AddNewConnector)
        Me.GB_Connector.Controls.Add(Me.Label7)
        Me.GB_Connector.Controls.Add(Me.Label2)
        Me.GB_Connector.Controls.Add(Me.Label8)
        Me.GB_Connector.Controls.Add(Me.NUD_ConnectorCenterX)
        Me.GB_Connector.Controls.Add(Me.NUD_ConnectorCenterY)
        Me.GB_Connector.Location = New System.Drawing.Point(418, 133)
        Me.GB_Connector.Name = "GB_Connector"
        Me.GB_Connector.Size = New System.Drawing.Size(251, 143)
        Me.GB_Connector.TabIndex = 17
        Me.GB_Connector.TabStop = False
        Me.GB_Connector.Text = "Connector"
        '
        'NUD_DeleteConnector
        '
        Me.NUD_DeleteConnector.Location = New System.Drawing.Point(418, 292)
        Me.NUD_DeleteConnector.Name = "NUD_DeleteConnector"
        Me.NUD_DeleteConnector.Size = New System.Drawing.Size(81, 36)
        Me.NUD_DeleteConnector.TabIndex = 19
        Me.NUD_DeleteConnector.Text = "Delete This Connector"
        Me.NUD_DeleteConnector.UseVisualStyleBackColor = True
        '
        'BUTT_AddNewConnector
        '
        Me.BUTT_AddNewConnector.Location = New System.Drawing.Point(6, 98)
        Me.BUTT_AddNewConnector.Name = "BUTT_AddNewConnector"
        Me.BUTT_AddNewConnector.Size = New System.Drawing.Size(67, 36)
        Me.BUTT_AddNewConnector.TabIndex = 18
        Me.BUTT_AddNewConnector.Text = "Add New Connector"
        Me.BUTT_AddNewConnector.UseVisualStyleBackColor = True
        '
        'NUD_AcceptTray
        '
        Me.NUD_AcceptTray.Location = New System.Drawing.Point(424, 402)
        Me.NUD_AcceptTray.Name = "NUD_AcceptTray"
        Me.NUD_AcceptTray.Size = New System.Drawing.Size(75, 23)
        Me.NUD_AcceptTray.TabIndex = 18
        Me.NUD_AcceptTray.Text = "Accept Tray"
        Me.NUD_AcceptTray.UseVisualStyleBackColor = True
        '
        'NUD_Cancel
        '
        Me.NUD_Cancel.Location = New System.Drawing.Point(594, 402)
        Me.NUD_Cancel.Name = "NUD_Cancel"
        Me.NUD_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.NUD_Cancel.TabIndex = 19
        Me.NUD_Cancel.Text = "Cancel"
        Me.NUD_Cancel.UseVisualStyleBackColor = True
        '
        'UI_TrayCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 438)
        Me.Controls.Add(Me.NUD_DeleteConnector)
        Me.Controls.Add(Me.NUD_Cancel)
        Me.Controls.Add(Me.NUD_AcceptTray)
        Me.Controls.Add(Me.GB_Connector)
        Me.Controls.Add(Me.GB_Tray)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PB_Tray)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UI_TrayCreator"
        Me.Text = "Tray Creator"
        CType(Me.PB_Tray, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Width, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Tray.ResumeLayout(False)
        Me.GB_Tray.PerformLayout()
        CType(Me.NUD_TrayCenterY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_TrayCenterX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Height, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_ConnectorCenterY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_ConnectorCenterX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Connector.ResumeLayout(False)
        Me.GB_Connector.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PB_Tray As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_ConnectorFile As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NUD_Width As NumericUpDown
    Friend WithEvents GB_Tray As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NUD_TrayCenterY As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents NUD_TrayCenterX As NumericUpDown
    Friend WithEvents NUD_Height As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents NUD_ConnectorCenterY As NumericUpDown
    Friend WithEvents NUD_ConnectorCenterX As NumericUpDown
    Friend WithEvents GB_Connector As GroupBox
    Friend WithEvents NUD_DeleteConnector As Button
    Friend WithEvents BUTT_AddNewConnector As Button
    Friend WithEvents NUD_AcceptTray As Button
    Friend WithEvents NUD_Cancel As Button
End Class
