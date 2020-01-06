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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.Lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.Lbl4 = New System.Windows.Forms.Label()
        Me.Lblvitorias = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lblmediavitorias = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(22, 22)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 42)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Girar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(361, 22)
        Me.Button2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 42)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Parar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl1.Location = New System.Drawing.Point(22, 153)
        Me.Lbl1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(2, 26)
        Me.Lbl1.TabIndex = 2
        '
        'Lbl2
        '
        Me.Lbl2.AutoSize = True
        Me.Lbl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl2.Location = New System.Drawing.Point(254, 81)
        Me.Lbl2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(2, 26)
        Me.Lbl2.TabIndex = 3
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(497, 153)
        Me.lbl3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(2, 26)
        Me.lbl3.TabIndex = 4
        '
        'Lbl4
        '
        Me.Lbl4.AutoSize = True
        Me.Lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl4.Location = New System.Drawing.Point(30, 256)
        Me.Lbl4.Name = "Lbl4"
        Me.Lbl4.Size = New System.Drawing.Size(469, 31)
        Me.Lbl4.TabIndex = 5
        Me.Lbl4.Text = "Você esta com Sorte Apareceu o Nº 7"
        Me.Lbl4.Visible = False
        '
        'Lblvitorias
        '
        Me.Lblvitorias.AutoSize = True
        Me.Lblvitorias.ForeColor = System.Drawing.Color.OrangeRed
        Me.Lblvitorias.Location = New System.Drawing.Point(12, 224)
        Me.Lblvitorias.Name = "Lblvitorias"
        Me.Lblvitorias.Size = New System.Drawing.Size(91, 24)
        Me.Lblvitorias.TabIndex = 6
        Me.Lblvitorias.Text = "Vitórias: 0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(443, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 24)
        Me.Label2.TabIndex = 7
        '
        'Lblmediavitorias
        '
        Me.Lblmediavitorias.AutoSize = True
        Me.Lblmediavitorias.ForeColor = System.Drawing.Color.OrangeRed
        Me.Lblmediavitorias.Location = New System.Drawing.Point(433, 224)
        Me.Lblmediavitorias.Name = "Lblmediavitorias"
        Me.Lblmediavitorias.Size = New System.Drawing.Size(50, 24)
        Me.Lblmediavitorias.TabIndex = 8
        Me.Lblmediavitorias.Text = "0.0%"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 314)
        Me.Controls.Add(Me.Lblmediavitorias)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lblvitorias)
        Me.Controls.Add(Me.Lbl4)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.Lbl2)
        Me.Controls.Add(Me.Lbl1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Lbl1 As System.Windows.Forms.Label
    Friend WithEvents Lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents Lbl4 As System.Windows.Forms.Label
    Friend WithEvents Lblvitorias As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Lblmediavitorias As System.Windows.Forms.Label

End Class
