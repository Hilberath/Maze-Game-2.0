<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HD_Level1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HD_Level1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSB_Zeit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSB_Versuche = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSB_Zeit, Me.ToolStripSeparator1, Me.TSB_Versuche})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 427)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(911, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "statusleiste"
        '
        'TSB_Zeit
        '
        Me.TSB_Zeit.Image = CType(resources.GetObject("TSB_Zeit.Image"), System.Drawing.Image)
        Me.TSB_Zeit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_Zeit.Name = "TSB_Zeit"
        Me.TSB_Zeit.Size = New System.Drawing.Size(65, 22)
        Me.TSB_Zeit.Text = "Zeit: 01"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'TSB_Versuche
        '
        Me.TSB_Versuche.Image = CType(resources.GetObject("TSB_Versuche.Image"), System.Drawing.Image)
        Me.TSB_Versuche.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_Versuche.Name = "TSB_Versuche"
        Me.TSB_Versuche.Size = New System.Drawing.Size(99, 22)
        Me.TSB_Versuche.Text = "TSB_Versuche"
        '
        'HD_Level1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 452)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "HD_Level1"
        Me.Text = "HD_Level1"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TSB_Versuche As ToolStripButton
    Friend WithEvents TSB_Zeit As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
