<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AreaDoQuadradoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AreaDoTrianguloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HipotenusaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AreaDoQuadradoToolStripMenuItem, Me.AreaDoTrianguloToolStripMenuItem, Me.HipotenusaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(340, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AreaDoQuadradoToolStripMenuItem
        '
        Me.AreaDoQuadradoToolStripMenuItem.Name = "AreaDoQuadradoToolStripMenuItem"
        Me.AreaDoQuadradoToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.AreaDoQuadradoToolStripMenuItem.Text = "Area do Quadrado"
        '
        'AreaDoTrianguloToolStripMenuItem
        '
        Me.AreaDoTrianguloToolStripMenuItem.Name = "AreaDoTrianguloToolStripMenuItem"
        Me.AreaDoTrianguloToolStripMenuItem.Size = New System.Drawing.Size(114, 20)
        Me.AreaDoTrianguloToolStripMenuItem.Text = "Area do Triangulo"
        '
        'HipotenusaToolStripMenuItem
        '
        Me.HipotenusaToolStripMenuItem.Name = "HipotenusaToolStripMenuItem"
        Me.HipotenusaToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.HipotenusaToolStripMenuItem.Text = "Hipotenusa"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 29)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AreaDoQuadradoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AreaDoTrianguloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HipotenusaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
