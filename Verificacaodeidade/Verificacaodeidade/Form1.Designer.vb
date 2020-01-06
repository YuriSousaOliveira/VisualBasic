<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Labelid = New System.Windows.Forms.Label()
        Me.TextBoxid = New System.Windows.Forms.TextBox()
        Me.Labelverifica = New System.Windows.Forms.Label()
        Me.TextBoxverifica = New System.Windows.Forms.TextBox()
        Me.Buttonve = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Labelid
        '
        Me.Labelid.AutoSize = True
        Me.Labelid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelid.Location = New System.Drawing.Point(78, 21)
        Me.Labelid.Name = "Labelid"
        Me.Labelid.Size = New System.Drawing.Size(68, 24)
        Me.Labelid.TabIndex = 0
        Me.Labelid.Text = "Idade:"
        '
        'TextBoxid
        '
        Me.TextBoxid.Location = New System.Drawing.Point(152, 25)
        Me.TextBoxid.Name = "TextBoxid"
        Me.TextBoxid.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxid.TabIndex = 2
        '
        'Labelverifica
        '
        Me.Labelverifica.AutoSize = True
        Me.Labelverifica.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelverifica.Location = New System.Drawing.Point(26, 54)
        Me.Labelverifica.Name = "Labelverifica"
        Me.Labelverifica.Size = New System.Drawing.Size(120, 24)
        Me.Labelverifica.TabIndex = 3
        Me.Labelverifica.Text = "Verificação:"
        '
        'TextBoxverifica
        '
        Me.TextBoxverifica.Location = New System.Drawing.Point(152, 59)
        Me.TextBoxverifica.Name = "TextBoxverifica"
        Me.TextBoxverifica.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxverifica.TabIndex = 4
        '
        'Buttonve
        '
        Me.Buttonve.Location = New System.Drawing.Point(152, 95)
        Me.Buttonve.Name = "Buttonve"
        Me.Buttonve.Size = New System.Drawing.Size(100, 23)
        Me.Buttonve.TabIndex = 5
        Me.Buttonve.Text = "Verificar"
        Me.Buttonve.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 134)
        Me.Controls.Add(Me.Buttonve)
        Me.Controls.Add(Me.TextBoxverifica)
        Me.Controls.Add(Me.Labelverifica)
        Me.Controls.Add(Me.TextBoxid)
        Me.Controls.Add(Me.Labelid)
        Me.Name = "Form1"
        Me.Text = " Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Labelid As System.Windows.Forms.Label
    Friend WithEvents TextBoxid As System.Windows.Forms.TextBox
    Friend WithEvents Labelverifica As System.Windows.Forms.Label
    Friend WithEvents TextBoxverifica As System.Windows.Forms.TextBox
    Friend WithEvents Buttonve As System.Windows.Forms.Button

End Class
