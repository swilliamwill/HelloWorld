<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_ModifyMove
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
        Me.BUTT_GO = New System.Windows.Forms.Button()
        Me.NUD_Speed = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NUD_Ypos_Set = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NUD_Xpos_Set = New System.Windows.Forms.NumericUpDown()
        Me.BUTT_OK = New System.Windows.Forms.Button()
        Me.BUTT_Cancel = New System.Windows.Forms.Button()
        CType(Me.NUD_Speed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Ypos_Set, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Xpos_Set, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BUTT_GO
        '
        Me.BUTT_GO.Location = New System.Drawing.Point(15, 52)
        Me.BUTT_GO.Name = "BUTT_GO"
        Me.BUTT_GO.Size = New System.Drawing.Size(44, 23)
        Me.BUTT_GO.TabIndex = 33
        Me.BUTT_GO.Text = "Go"
        Me.BUTT_GO.UseVisualStyleBackColor = True
        '
        'NUD_Speed
        '
        Me.NUD_Speed.Location = New System.Drawing.Point(217, 26)
        Me.NUD_Speed.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.NUD_Speed.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUD_Speed.Name = "NUD_Speed"
        Me.NUD_Speed.Size = New System.Drawing.Size(70, 20)
        Me.NUD_Speed.TabIndex = 32
        Me.NUD_Speed.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(214, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Speed [mm/s]"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "X Set Position [mm]"
        '
        'NUD_Ypos_Set
        '
        Me.NUD_Ypos_Set.DecimalPlaces = 3
        Me.NUD_Ypos_Set.Enabled = False
        Me.NUD_Ypos_Set.Location = New System.Drawing.Point(15, 26)
        Me.NUD_Ypos_Set.Maximum = New Decimal(New Integer() {110, 0, 0, 0})
        Me.NUD_Ypos_Set.Name = "NUD_Ypos_Set"
        Me.NUD_Ypos_Set.ReadOnly = True
        Me.NUD_Ypos_Set.Size = New System.Drawing.Size(95, 20)
        Me.NUD_Ypos_Set.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(113, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Y Set Position [mm]"
        '
        'NUD_Xpos_Set
        '
        Me.NUD_Xpos_Set.DecimalPlaces = 3
        Me.NUD_Xpos_Set.Enabled = False
        Me.NUD_Xpos_Set.Location = New System.Drawing.Point(116, 26)
        Me.NUD_Xpos_Set.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.NUD_Xpos_Set.Name = "NUD_Xpos_Set"
        Me.NUD_Xpos_Set.ReadOnly = True
        Me.NUD_Xpos_Set.Size = New System.Drawing.Size(95, 20)
        Me.NUD_Xpos_Set.TabIndex = 27
        '
        'BUTT_OK
        '
        Me.BUTT_OK.Location = New System.Drawing.Point(131, 52)
        Me.BUTT_OK.Name = "BUTT_OK"
        Me.BUTT_OK.Size = New System.Drawing.Size(75, 23)
        Me.BUTT_OK.TabIndex = 34
        Me.BUTT_OK.Text = "OK"
        Me.BUTT_OK.UseVisualStyleBackColor = True
        '
        'BUTT_Cancel
        '
        Me.BUTT_Cancel.Location = New System.Drawing.Point(212, 52)
        Me.BUTT_Cancel.Name = "BUTT_Cancel"
        Me.BUTT_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.BUTT_Cancel.TabIndex = 35
        Me.BUTT_Cancel.Text = "Cancel"
        Me.BUTT_Cancel.UseVisualStyleBackColor = True
        '
        'UF_ModifyMove
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 89)
        Me.Controls.Add(Me.BUTT_Cancel)
        Me.Controls.Add(Me.BUTT_OK)
        Me.Controls.Add(Me.BUTT_GO)
        Me.Controls.Add(Me.NUD_Speed)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NUD_Ypos_Set)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NUD_Xpos_Set)
        Me.Name = "UF_ModifyMove"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modify Move"
        CType(Me.NUD_Speed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Ypos_Set, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Xpos_Set, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BUTT_GO As Button
    Friend WithEvents NUD_Speed As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NUD_Ypos_Set As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents NUD_Xpos_Set As NumericUpDown
    Friend WithEvents BUTT_OK As Button
    Friend WithEvents BUTT_Cancel As Button
End Class
