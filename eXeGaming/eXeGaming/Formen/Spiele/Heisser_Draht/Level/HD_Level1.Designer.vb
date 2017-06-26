<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HD_Level1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label_Versuche = New System.Windows.Forms.Label()
        Me.Label_Zeit = New System.Windows.Forms.Label()
        Me.PB_Start = New System.Windows.Forms.PictureBox()
        Me.PB_Ziel = New System.Windows.Forms.PictureBox()
        Me.PB_Wall1 = New System.Windows.Forms.PictureBox()
        Me.PB_Wall2 = New System.Windows.Forms.PictureBox()
        Me.PB_Wall3 = New System.Windows.Forms.PictureBox()
        Me.PB_Wall5 = New System.Windows.Forms.PictureBox()
        Me.PB_Wall6 = New System.Windows.Forms.PictureBox()
        Me.PB_Wall4 = New System.Windows.Forms.PictureBox()
        Me.PB_Wall7 = New System.Windows.Forms.PictureBox()
        Me.PB_Wall8 = New System.Windows.Forms.PictureBox()
        CType(Me.PB_Start, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Ziel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Wall1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Wall2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Wall3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Wall5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Wall6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Wall4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Wall7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Wall8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label_Versuche
        '
        Me.Label_Versuche.AutoSize = True
        Me.Label_Versuche.BackColor = System.Drawing.Color.Transparent
        Me.Label_Versuche.Font = New System.Drawing.Font("SF Sports Night NS Upright", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Versuche.ForeColor = System.Drawing.Color.White
        Me.Label_Versuche.Location = New System.Drawing.Point(1666, 494)
        Me.Label_Versuche.Name = "Label_Versuche"
        Me.Label_Versuche.Size = New System.Drawing.Size(23, 31)
        Me.Label_Versuche.TabIndex = 0
        Me.Label_Versuche.Text = "1"
        '
        'Label_Zeit
        '
        Me.Label_Zeit.AutoSize = True
        Me.Label_Zeit.BackColor = System.Drawing.Color.Transparent
        Me.Label_Zeit.Font = New System.Drawing.Font("SF Sports Night NS Upright", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Zeit.ForeColor = System.Drawing.Color.White
        Me.Label_Zeit.Location = New System.Drawing.Point(1666, 531)
        Me.Label_Zeit.Name = "Label_Zeit"
        Me.Label_Zeit.Size = New System.Drawing.Size(53, 31)
        Me.Label_Zeit.TabIndex = 1
        Me.Label_Zeit.Text = "0 "
        '
        'PB_Start
        '
        Me.PB_Start.BackColor = System.Drawing.Color.Transparent
        Me.PB_Start.Location = New System.Drawing.Point(1642, 142)
        Me.PB_Start.Name = "PB_Start"
        Me.PB_Start.Size = New System.Drawing.Size(128, 128)
        Me.PB_Start.TabIndex = 2
        Me.PB_Start.TabStop = False
        '
        'PB_Ziel
        '
        Me.PB_Ziel.BackColor = System.Drawing.Color.Transparent
        Me.PB_Ziel.Location = New System.Drawing.Point(1642, 782)
        Me.PB_Ziel.Name = "PB_Ziel"
        Me.PB_Ziel.Size = New System.Drawing.Size(128, 128)
        Me.PB_Ziel.TabIndex = 3
        Me.PB_Ziel.TabStop = False
        '
        'PB_Wall1
        '
        Me.PB_Wall1.BackColor = System.Drawing.Color.Transparent
        Me.PB_Wall1.Location = New System.Drawing.Point(57, 78)
        Me.PB_Wall1.Name = "PB_Wall1"
        Me.PB_Wall1.Size = New System.Drawing.Size(1777, 64)
        Me.PB_Wall1.TabIndex = 4
        Me.PB_Wall1.TabStop = False
        '
        'PB_Wall2
        '
        Me.PB_Wall2.BackColor = System.Drawing.Color.Transparent
        Me.PB_Wall2.Location = New System.Drawing.Point(298, 270)
        Me.PB_Wall2.Name = "PB_Wall2"
        Me.PB_Wall2.Size = New System.Drawing.Size(1536, 160)
        Me.PB_Wall2.TabIndex = 5
        Me.PB_Wall2.TabStop = False
        '
        'PB_Wall3
        '
        Me.PB_Wall3.BackColor = System.Drawing.Color.Transparent
        Me.PB_Wall3.Location = New System.Drawing.Point(1770, 142)
        Me.PB_Wall3.Name = "PB_Wall3"
        Me.PB_Wall3.Size = New System.Drawing.Size(149, 128)
        Me.PB_Wall3.TabIndex = 6
        Me.PB_Wall3.TabStop = False
        '
        'PB_Wall5
        '
        Me.PB_Wall5.BackColor = System.Drawing.Color.Transparent
        Me.PB_Wall5.Location = New System.Drawing.Point(1770, 782)
        Me.PB_Wall5.Name = "PB_Wall5"
        Me.PB_Wall5.Size = New System.Drawing.Size(149, 128)
        Me.PB_Wall5.TabIndex = 9
        Me.PB_Wall5.TabStop = False
        '
        'PB_Wall6
        '
        Me.PB_Wall6.BackColor = System.Drawing.Color.Transparent
        Me.PB_Wall6.Location = New System.Drawing.Point(57, 910)
        Me.PB_Wall6.Name = "PB_Wall6"
        Me.PB_Wall6.Size = New System.Drawing.Size(1777, 64)
        Me.PB_Wall6.TabIndex = 8
        Me.PB_Wall6.TabStop = False
        '
        'PB_Wall4
        '
        Me.PB_Wall4.BackColor = System.Drawing.Color.Transparent
        Me.PB_Wall4.Location = New System.Drawing.Point(298, 622)
        Me.PB_Wall4.Name = "PB_Wall4"
        Me.PB_Wall4.Size = New System.Drawing.Size(1536, 160)
        Me.PB_Wall4.TabIndex = 7
        Me.PB_Wall4.TabStop = False
        '
        'PB_Wall7
        '
        Me.PB_Wall7.BackColor = System.Drawing.Color.Transparent
        Me.PB_Wall7.Location = New System.Drawing.Point(57, 142)
        Me.PB_Wall7.Name = "PB_Wall7"
        Me.PB_Wall7.Size = New System.Drawing.Size(64, 769)
        Me.PB_Wall7.TabIndex = 10
        Me.PB_Wall7.TabStop = False
        '
        'PB_Wall8
        '
        Me.PB_Wall8.BackColor = System.Drawing.Color.Transparent
        Me.PB_Wall8.Location = New System.Drawing.Point(298, 328)
        Me.PB_Wall8.Name = "PB_Wall8"
        Me.PB_Wall8.Size = New System.Drawing.Size(64, 390)
        Me.PB_Wall8.TabIndex = 11
        Me.PB_Wall8.TabStop = False
        '
        'HD_Level1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.eXeGaming.My.Resources.Resources.HD_Level001
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.PB_Wall8)
        Me.Controls.Add(Me.PB_Wall7)
        Me.Controls.Add(Me.PB_Wall5)
        Me.Controls.Add(Me.PB_Wall6)
        Me.Controls.Add(Me.PB_Wall4)
        Me.Controls.Add(Me.PB_Wall3)
        Me.Controls.Add(Me.PB_Wall2)
        Me.Controls.Add(Me.PB_Wall1)
        Me.Controls.Add(Me.PB_Ziel)
        Me.Controls.Add(Me.PB_Start)
        Me.Controls.Add(Me.Label_Zeit)
        Me.Controls.Add(Me.Label_Versuche)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HD_Level1"
        Me.Text = "HD_Level1"
        CType(Me.PB_Start, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Ziel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Wall1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Wall2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Wall3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Wall5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Wall6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Wall4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Wall7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Wall8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label_Versuche As Label
    Friend WithEvents Label_Zeit As Label
    Friend WithEvents PB_Start As PictureBox
    Friend WithEvents PB_Ziel As PictureBox
    Friend WithEvents PB_Wall1 As PictureBox
    Friend WithEvents PB_Wall2 As PictureBox
    Friend WithEvents PB_Wall3 As PictureBox
    Friend WithEvents PB_Wall5 As PictureBox
    Friend WithEvents PB_Wall6 As PictureBox
    Friend WithEvents PB_Wall4 As PictureBox
    Friend WithEvents PB_Wall7 As PictureBox
    Friend WithEvents PB_Wall8 As PictureBox
End Class
