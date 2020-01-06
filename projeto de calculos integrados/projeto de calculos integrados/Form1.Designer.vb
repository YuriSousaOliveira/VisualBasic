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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MédiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SomaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubtraçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultiplicaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FecharToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(30, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sejam Bem Vindos ao Nosso Sistema"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MédiaToolStripMenuItem, Me.SomaToolStripMenuItem, Me.SubtraçãoToolStripMenuItem, Me.MultiplicaçãoToolStripMenuItem, Me.FecharToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(325, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MédiaToolStripMenuItem
        '
        Me.MédiaToolStripMenuItem.Name = "MédiaToolStripMenuItem"
        Me.MédiaToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.MédiaToolStripMenuItem.Text = "Média"
        '
        'SomaToolStripMenuItem
        '
        Me.SomaToolStripMenuItem.Name = "SomaToolStripMenuItem"
        Me.SomaToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SomaToolStripMenuItem.Text = "Soma"
        '
        'SubtraçãoToolStripMenuItem
        '
        Me.SubtraçãoToolStripMenuItem.Name = "SubtraçãoToolStripMenuItem"
        Me.SubtraçãoToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.SubtraçãoToolStripMenuItem.Text = "Subtração"
        '
        'MultiplicaçãoToolStripMenuItem
        '
        Me.MultiplicaçãoToolStripMenuItem.Name = "MultiplicaçãoToolStripMenuItem"
        Me.MultiplicaçãoToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.MultiplicaçãoToolStripMenuItem.Text = "Multiplicação"
        '
        'FecharToolStripMenuItem
        '
        Me.FecharToolStripMenuItem.Name = "FecharToolStripMenuItem"
        Me.FecharToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FecharToolStripMenuItem.Text = "Fechar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(325, 263)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MédiaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SomaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubtraçãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MultiplicaçãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FecharToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
