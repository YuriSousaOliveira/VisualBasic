<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F
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
        Me.labelnum1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'labelnum1
        '
        Me.labelnum1.AutoSize = True
        Me.labelnum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelnum1.Location = New System.Drawing.Point(31, 25)
        Me.labelnum1.Name = "labelnum1"
        Me.labelnum1.Size = New System.Drawing.Size(110, 24)
        Me.labelnum1.TabIndex = 0
        Me.labelnum1.Text = "1º Numero"
        '
        'F
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 227)
        Me.Controls.Add(Me.labelnum1)
        Me.Name = "F"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelnum1 As System.Windows.Forms.Label

End Class
