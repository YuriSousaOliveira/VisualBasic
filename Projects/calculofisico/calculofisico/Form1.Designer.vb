﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.TextBoxtempo = New System.Windows.Forms.TextBox()
        Me.TextBoxespaco = New System.Windows.Forms.TextBox()
        Me.Buttoncalc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tempo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Espaço"
        '
        'TextBoxtempo
        '
        Me.TextBoxtempo.Location = New System.Drawing.Point(16, 36)
        Me.TextBoxtempo.Name = "TextBoxtempo"
        Me.TextBoxtempo.Size = New System.Drawing.Size(73, 20)
        Me.TextBoxtempo.TabIndex = 2
        '
        'TextBoxespaco
        '
        Me.TextBoxespaco.Location = New System.Drawing.Point(15, 95)
        Me.TextBoxespaco.Name = "TextBoxespaco"
        Me.TextBoxespaco.Size = New System.Drawing.Size(73, 20)
        Me.TextBoxespaco.TabIndex = 3
        '
        'Buttoncalc
        '
        Me.Buttoncalc.Location = New System.Drawing.Point(16, 134)
        Me.Buttoncalc.Name = "Buttoncalc"
        Me.Buttoncalc.Size = New System.Drawing.Size(73, 23)
        Me.Buttoncalc.TabIndex = 4
        Me.Buttoncalc.Text = "Calcular"
        Me.Buttoncalc.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(116, 166)
        Me.Controls.Add(Me.Buttoncalc)
        Me.Controls.Add(Me.TextBoxespaco)
        Me.Controls.Add(Me.TextBoxtempo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxtempo As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxespaco As System.Windows.Forms.TextBox
    Friend WithEvents Buttoncalc As System.Windows.Forms.Button

End Class