<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI_Error
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
        Me.TB_Errors = New System.Windows.Forms.TextBox()
        Me.BUTT_Retry = New System.Windows.Forms.Button()
        Me.BUTT_Stop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TB_Errors
        '
        Me.TB_Errors.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_Errors.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Errors.Location = New System.Drawing.Point(12, 12)
        Me.TB_Errors.Multiline = True
        Me.TB_Errors.Name = "TB_Errors"
        Me.TB_Errors.Size = New System.Drawing.Size(447, 265)
        Me.TB_Errors.TabIndex = 1
        Me.TB_Errors.Text = "The system has encountered the following errors:"
        '
        'BUTT_Retry
        '
        Me.BUTT_Retry.Location = New System.Drawing.Point(12, 283)
        Me.BUTT_Retry.Name = "BUTT_Retry"
        Me.BUTT_Retry.Size = New System.Drawing.Size(75, 23)
        Me.BUTT_Retry.TabIndex = 2
        Me.BUTT_Retry.Text = "Retry"
        Me.BUTT_Retry.UseVisualStyleBackColor = True
        '
        'BUTT_Stop
        '
        Me.BUTT_Stop.Location = New System.Drawing.Point(384, 283)
        Me.BUTT_Stop.Name = "BUTT_Stop"
        Me.BUTT_Stop.Size = New System.Drawing.Size(75, 23)
        Me.BUTT_Stop.TabIndex = 3
        Me.BUTT_Stop.Text = "Stop"
        Me.BUTT_Stop.UseVisualStyleBackColor = True
        '
        'UI_Error
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(473, 316)
        Me.ControlBox = False
        Me.Controls.Add(Me.BUTT_Stop)
        Me.Controls.Add(Me.BUTT_Retry)
        Me.Controls.Add(Me.TB_Errors)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UI_Error"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XY System Error"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TB_Errors As TextBox
    Friend WithEvents BUTT_Retry As Button
    Friend WithEvents BUTT_Stop As Button
End Class
