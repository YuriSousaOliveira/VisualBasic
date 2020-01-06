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
        Me.TextBoxnum1 = New System.Windows.Forms.TextBox()
        Me.Labelnum2 = New System.Windows.Forms.Label()
        Me.TextBoxnum2 = New System.Windows.Forms.TextBox()
        Me.Lbelresult = New System.Windows.Forms.Label()
        Me.TextBoxresult = New System.Windows.Forms.TextBox()
        Me.buttoncalc = New System.Windows.Forms.Button()
        Me.RadioButtonadicao = New System.Windows.Forms.RadioButton()
        Me.RadioButtonsubtracao = New System.Windows.Forms.RadioButton()
        Me.RadioButtonmultiplicacao = New System.Windows.Forms.RadioButton()
        Me.RadioButtondivisao = New System.Windows.Forms.RadioButton()
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
        'TextBoxnum1
        '
        Me.TextBoxnum1.Location = New System.Drawing.Point(35, 52)
        Me.TextBoxnum1.Name = "TextBoxnum1"
        Me.TextBoxnum1.Size = New System.Drawing.Size(106, 20)
        Me.TextBoxnum1.TabIndex = 1
        '
        'Labelnum2
        '
        Me.Labelnum2.AutoSize = True
        Me.Labelnum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelnum2.Location = New System.Drawing.Point(31, 75)
        Me.Labelnum2.Name = "Labelnum2"
        Me.Labelnum2.Size = New System.Drawing.Size(110, 24)
        Me.Labelnum2.TabIndex = 2
        Me.Labelnum2.Text = "2º Numero"
        '
        'TextBoxnum2
        '
        Me.TextBoxnum2.Location = New System.Drawing.Point(35, 102)
        Me.TextBoxnum2.Name = "TextBoxnum2"
        Me.TextBoxnum2.Size = New System.Drawing.Size(106, 20)
        Me.TextBoxnum2.TabIndex = 3
        '
        'Lbelresult
        '
        Me.Lbelresult.AutoSize = True
        Me.Lbelresult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbelresult.Location = New System.Drawing.Point(31, 125)
        Me.Lbelresult.Name = "Lbelresult"
        Me.Lbelresult.Size = New System.Drawing.Size(103, 24)
        Me.Lbelresult.TabIndex = 4
        Me.Lbelresult.Text = "Resultado"
        '
        'TextBoxresult
        '
        Me.TextBoxresult.Location = New System.Drawing.Point(35, 152)
        Me.TextBoxresult.Name = "TextBoxresult"
        Me.TextBoxresult.Size = New System.Drawing.Size(106, 20)
        Me.TextBoxresult.TabIndex = 5
        '
        'buttoncalc
        '
        Me.buttoncalc.Location = New System.Drawing.Point(35, 178)
        Me.buttoncalc.Name = "buttoncalc"
        Me.buttoncalc.Size = New System.Drawing.Size(106, 28)
        Me.buttoncalc.TabIndex = 6
        Me.buttoncalc.Text = "Calcular"
        Me.buttoncalc.UseVisualStyleBackColor = True
        '
        'RadioButtonadicao
        '
        Me.RadioButtonadicao.AutoSize = True
        Me.RadioButtonadicao.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonadicao.Location = New System.Drawing.Point(266, 32)
        Me.RadioButtonadicao.Name = "RadioButtonadicao"
        Me.RadioButtonadicao.Size = New System.Drawing.Size(93, 28)
        Me.RadioButtonadicao.TabIndex = 7
        Me.RadioButtonadicao.TabStop = True
        Me.RadioButtonadicao.Text = "Adição"
        Me.RadioButtonadicao.UseVisualStyleBackColor = True
        '
        'RadioButtonsubtracao
        '
        Me.RadioButtonsubtracao.AutoSize = True
        Me.RadioButtonsubtracao.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonsubtracao.Location = New System.Drawing.Point(266, 66)
        Me.RadioButtonsubtracao.Name = "RadioButtonsubtracao"
        Me.RadioButtonsubtracao.Size = New System.Drawing.Size(122, 28)
        Me.RadioButtonsubtracao.TabIndex = 8
        Me.RadioButtonsubtracao.TabStop = True
        Me.RadioButtonsubtracao.Text = "Subtração"
        Me.RadioButtonsubtracao.UseVisualStyleBackColor = True
        '
        'RadioButtonmultiplicacao
        '
        Me.RadioButtonmultiplicacao.AutoSize = True
        Me.RadioButtonmultiplicacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonmultiplicacao.Location = New System.Drawing.Point(266, 100)
        Me.RadioButtonmultiplicacao.Name = "RadioButtonmultiplicacao"
        Me.RadioButtonmultiplicacao.Size = New System.Drawing.Size(150, 28)
        Me.RadioButtonmultiplicacao.TabIndex = 9
        Me.RadioButtonmultiplicacao.TabStop = True
        Me.RadioButtonmultiplicacao.Text = "Multiplicação"
        Me.RadioButtonmultiplicacao.UseVisualStyleBackColor = True
        '
        'RadioButtondivisao
        '
        Me.RadioButtondivisao.AutoSize = True
        Me.RadioButtondivisao.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtondivisao.Location = New System.Drawing.Point(266, 134)
        Me.RadioButtondivisao.Name = "RadioButtondivisao"
        Me.RadioButtondivisao.Size = New System.Drawing.Size(95, 28)
        Me.RadioButtondivisao.TabIndex = 10
        Me.RadioButtondivisao.TabStop = True
        Me.RadioButtondivisao.Text = "Divisão"
        Me.RadioButtondivisao.UseVisualStyleBackColor = True
        '
        'F
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 272)
        Me.Controls.Add(Me.RadioButtondivisao)
        Me.Controls.Add(Me.RadioButtonmultiplicacao)
        Me.Controls.Add(Me.RadioButtonsubtracao)
        Me.Controls.Add(Me.RadioButtonadicao)
        Me.Controls.Add(Me.buttoncalc)
        Me.Controls.Add(Me.TextBoxresult)
        Me.Controls.Add(Me.Lbelresult)
        Me.Controls.Add(Me.TextBoxnum2)
        Me.Controls.Add(Me.Labelnum2)
        Me.Controls.Add(Me.TextBoxnum1)
        Me.Controls.Add(Me.labelnum1)
        Me.Name = "F"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelnum1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxnum1 As System.Windows.Forms.TextBox
    Friend WithEvents Labelnum2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxnum2 As System.Windows.Forms.TextBox
    Friend WithEvents Lbelresult As System.Windows.Forms.Label
    Friend WithEvents TextBoxresult As System.Windows.Forms.TextBox
    Friend WithEvents buttoncalc As System.Windows.Forms.Button
    Friend WithEvents RadioButtonadicao As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonsubtracao As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonmultiplicacao As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtondivisao As System.Windows.Forms.RadioButton

End Class
