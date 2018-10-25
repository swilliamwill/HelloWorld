<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_ConnectionError
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BUTT_Yes = New System.Windows.Forms.Button()
        Me.BUTT_No = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 60)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Communication error with PLC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reconnect? (Reconnecting will reset program)"
        '
        'BUTT_Yes
        '
        Me.BUTT_Yes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BUTT_Yes.Location = New System.Drawing.Point(12, 100)
        Me.BUTT_Yes.Name = "BUTT_Yes"
        Me.BUTT_Yes.Size = New System.Drawing.Size(77, 29)
        Me.BUTT_Yes.TabIndex = 1
        Me.BUTT_Yes.Text = "Yes"
        Me.BUTT_Yes.UseVisualStyleBackColor = True
        '
        'BUTT_No
        '
        Me.BUTT_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BUTT_No.Location = New System.Drawing.Point(95, 100)
        Me.BUTT_No.Name = "BUTT_No"
        Me.BUTT_No.Size = New System.Drawing.Size(77, 29)
        Me.BUTT_No.TabIndex = 2
        Me.BUTT_No.Text = "No"
        Me.BUTT_No.UseVisualStyleBackColor = True
        '
        'UI_ConnectionError
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 144)
        Me.ControlBox = False
        Me.Controls.Add(Me.BUTT_No)
        Me.Controls.Add(Me.BUTT_Yes)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UI_ConnectionError"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Connection Error"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BUTT_Yes As Button
    Friend WithEvents BUTT_No As Button
End Class
