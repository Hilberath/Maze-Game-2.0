Public Class Einstellungen
    Dim titel As String = Datenbank.Launcher_Titel

    Dim G As Graphics
    Dim MyFont = New Font("Arial", 8)
    Dim MyPen = New Pen(Brushes.White, 3)

    Dim PB_Schliessen As New PictureBox
    Dim PB_Spiel_Starten As New PictureBox

    Dim MausLocation As Point


    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            MausLocation = e.Location
        End If
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = MouseButtons.Left Then
            Me.Location = e.Location - MausLocation + Me.Location
        End If
    End Sub


    Private Sub Launcher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
        Verzeichnis.Spielpfad_erstellen()
        With Me
            .FormBorderStyle = FormBorderStyle.None
            .Width = Datenbank.Launcher_Breite
            .Height = Datenbank.Launcher_Höhe
            '.BackColor = Datenbank.Launcher_Hintergrundfarbe
            .ForeColor = Datenbank.Launcher_Schriftfarbe
            .Text = titel
            .ControlBox = False
            .MaximizeBox = False
            .MinimizeBox = False
            .BackgroundImage = My.Resources.Einstellungen
            .AutoSizeMode = AutoSizeMode.GrowAndShrink
            .StartPosition = FormStartPosition.CenterScreen
            .WindowState = FormWindowState.Normal
            '.Icon = My.Resources

            init()

        End With
    End Sub

    Private Sub init()
        PB_Schliessen_Erstellen()
    End Sub

#Region "PB_Schliessen"
    Private Sub PB_Schliessen_Erstellen()
        With PB_Schliessen
            .Location = New Point(768, 4)
            .Size = New Size(Datenbank.Launcher_Windows_Buttons, Datenbank.Launcher_Windows_Buttons)
            .Image = My.Resources.button_close_op
        End With
        AddHandler PB_Schliessen.Click, AddressOf PB_Schliessen_Click
        AddHandler PB_Schliessen.MouseEnter, AddressOf PB_Schliessen_MouseEnter
        AddHandler PB_Schliessen.MouseLeave, AddressOf PB_Schliessen_MouseLeave
        Controls.Add(PB_Schliessen)
        PB_Schliessen.Parent = Me
    End Sub

    Private Sub PB_Schliessen_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub PB_Schliessen_MouseEnter(sender As Object, e As EventArgs)
        PB_Schliessen.Image = My.Resources.button_close_mp
    End Sub

    Private Sub PB_Schliessen_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Schliessen.Parent = Me
        PB_Schliessen.Image = My.Resources.button_close_op
    End Sub
#End Region

#Region "PB_Spiel-Starten"
    Private Sub PB_Spiel_Starten_Erstellen()
        With PB_Spiel_Starten
            .Location = New Point(651, 533)
            .Size = Datenbank.Launcher_Spiel_Starten
            .Image = My.Resources.button_play_op
            .BackColor = Color.Transparent

        End With
        AddHandler PB_Spiel_Starten.Click, AddressOf PB_Spiel_Starten_Click
        AddHandler PB_Spiel_Starten.MouseEnter, AddressOf PB_Spiel_Starten_MouseEnter
        AddHandler PB_Spiel_Starten.MouseLeave, AddressOf PB_Spiel_Starten_MouseLeave
        Controls.Add(PB_Spiel_Starten)
        PB_Spiel_Starten.Parent = Me
    End Sub

    Private Sub PB_Spiel_Starten_Click(sender As Object, e As EventArgs)
        Spiel_Menu.Show()
        Me.Close()
    End Sub
    Private Sub PB_Spiel_Starten_MouseEnter(sender As Object, e As EventArgs)
        PB_Spiel_Starten.Image = My.Resources.button_play_mp
    End Sub

    Private Sub PB_Spiel_Starten_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Spiel_Starten.Parent = Me
        PB_Spiel_Starten.Image = My.Resources.button_play_op
    End Sub
#End Region

    Private Sub Einstellungen_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Dim Result As MsgBoxResult
        Result = MsgBox("Soll das Spiel geschlossen werden?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo)

        If e.KeyCode = Keys.Escape = True Then
            If Result = MsgBoxResult.Yes = True Then
                Application.Exit()
            Else
            End If
        End If
    End Sub
End Class