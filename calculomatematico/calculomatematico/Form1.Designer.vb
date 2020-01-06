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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.La = New System.Windows.Forms.Label()
        Me.TextBoxco = New System.Windows.Forms.TextBox()
        Me.TextBoxca = New System.Windows.Forms.TextBox()
        Me.Buttoncalc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cateto Oposto"
        '
        'La
        '
        Me.La.AutoSize = True
        Me.La.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.La.Location = New System.Drawing.Point(184, 9)
        Me.La.Name = "La"
        Me.La.Size = New System.Drawing.Size(132, 17)
        Me.La.TabIndex = 1
        Me.La.Text = "Cateto Adjacente"
        '
        'TextBoxco
        '
        Me.TextBoxco.Location = New System.Drawing.Point(12, 29)
        Me.TextBoxco.Name = "TextBoxco"
        Me.TextBoxco.Size = New System.Drawing.Size(112, 20)
        Me.TextBoxco.TabIndex = 3
        '
        'TextBoxca
        '
        Me.TextBoxca.Location = New System.Drawing.Point(187, 29)
        Me.TextBoxca.Name = "TextBoxca"
        Me.TextBoxca.Size = New System.Drawing.Size(129, 20)
        Me.TextBoxca.TabIndex = 4
        '
        'Buttoncalc
        '
        Me.Buttoncalc.Location = New System.Drawing.Point(95, 66)
        Me.Buttoncalc.Name = "Buttoncalc"
        Me.Buttoncalc.Size = New System.Drawing.Size(100, 23)
        Me.Buttoncalc.TabIndex = 10
        Me.Buttoncalc.Text = "Calcular"
        Me.Buttoncalc.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 118)
        Me.Controls.Add(Me.Buttoncalc)
        Me.Controls.Add(Me.TextBoxca)
        Me.Controls.Add(Me.TextBoxco)
        Me.Controls.Add(Me.La)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents La As System.Windows.Forms.Label
    Friend WithEvents TextBoxco As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxca As System.Windows.Forms.TextBox
    Friend WithEvents Buttoncalc As System.Windows.Forms.Button

End Class
