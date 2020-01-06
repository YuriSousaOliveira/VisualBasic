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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txtespaco = New System.Windows.Forms.TextBox()
        Me.Txttempo = New System.Windows.Forms.TextBox()
        Me.Txtkm = New System.Windows.Forms.TextBox()
        Me.Txtms = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Espaço"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tempo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Km/H"
        '
        'Txtespaco
        '
        Me.Txtespaco.Location = New System.Drawing.Point(12, 25)
        Me.Txtespaco.Name = "Txtespaco"
        Me.Txtespaco.Size = New System.Drawing.Size(105, 20)
        Me.Txtespaco.TabIndex = 3
        '
        'Txttempo
        '
        Me.Txttempo.Location = New System.Drawing.Point(12, 64)
        Me.Txttempo.Name = "Txttempo"
        Me.Txttempo.Size = New System.Drawing.Size(105, 20)
        Me.Txttempo.TabIndex = 4
        '
        'Txtkm
        '
        Me.Txtkm.Location = New System.Drawing.Point(12, 103)
        Me.Txtkm.Name = "Txtkm"
        Me.Txtkm.Size = New System.Drawing.Size(105, 20)
        Me.Txtkm.TabIndex = 5
        '
        'Txtms
        '
        Me.Txtms.Location = New System.Drawing.Point(12, 142)
        Me.Txtms.Name = "Txtms"
        Me.Txtms.Size = New System.Drawing.Size(105, 20)
        Me.Txtms.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "M/S"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 27)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(126, 262)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txtms)
        Me.Controls.Add(Me.Txtkm)
        Me.Controls.Add(Me.Txttempo)
        Me.Controls.Add(Me.Txtespaco)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txtespaco As System.Windows.Forms.TextBox
    Friend WithEvents Txttempo As System.Windows.Forms.TextBox
    Friend WithEvents Txtkm As System.Windows.Forms.TextBox
    Friend WithEvents Txtms As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
