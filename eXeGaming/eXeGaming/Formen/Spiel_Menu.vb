Public Class Spiel_Menu

    Dim titel As String = Datenbank.Spielwelt_Titel

    Dim G As Graphics
    Dim MyFont = New Font("Arial", 8)
    Dim MyPen = New Pen(Brushes.White, 3)

    Dim PB_Spiel_Starten As New PictureBox
    Dim PB_Laden As New PictureBox
    Dim PB_Highscore As New PictureBox
    Dim PB_Erfolge As New PictureBox
    Dim PB_Einstellungen As New PictureBox
    Dim PB_Schliessen As New PictureBox


    Private Sub Spiel_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            '.Icon = Datenbank.Spiel_Icon
            .Text = titel
            .Width = Datenbank.Spielmenu_Breite
            .Height = Datenbank.Spielmenu_Höhe
            .BackgroundImage = My.Resources.Hintergrund_standart
            .ForeColor = Datenbank.Spielmenu_Schriftfarbe
            .BackgroundImageLayout = ImageLayout.None

        End With
        If Datenbank.Spiel_Vollbild = True Then
            Me.WindowState = FormWindowState.Maximized
            Me.FormBorderStyle = FormBorderStyle.None
            Me.ControlBox = False
            Me.MaximizeBox = False
            Me.MinimizeBox = False
        ElseIf Datenbank.Spiel_Fenstervollbild = True Then
            Me.WindowState = FormWindowState.Maximized
            Me.FormBorderStyle = FormBorderStyle.Fixed3D
            Me.Width = Datenbank.Spielwelt_Breite
            Me.Height = Datenbank.Spielwelt_Höhe
            Me.ControlBox = True
            Me.MaximizeBox = True
            Me.MinimizeBox = True
            Me.AutoSizeMode = AutoSizeMode.GrowAndShrink
            Me.StartPosition = FormStartPosition.CenterScreen
        ElseIf Datenbank.Spiel_Fenster = True Then
            Me.WindowState = FormWindowState.Normal
            Me.FormBorderStyle = FormBorderStyle.Sizable
            Me.Width = Datenbank.Spielwelt_Breite
            Me.Height = Datenbank.Spielwelt_Höhe
            Me.ControlBox = True
            Me.MaximizeBox = True
            Me.MinimizeBox = True
            Me.AutoSizeMode = AutoSizeMode.GrowAndShrink
            Me.StartPosition = FormStartPosition.CenterScreen
        End If

        Init()

    End Sub

    Private Sub Init()
        Debug_Modus()
        'Update_Statusleiste()
        'AntiAlias()

        PB_Spiel_Starten_Erstellen()
        PB_Laden_Erstellen()
        PB_Highscore_Erstellen()
        PB_Erfolge_Erstellen()
        PB_Einstellungen_Erstellen()
        PB_Schliessen_Erstellen()
    End Sub

    'Private Sub AntiAlias()

    '    With Grafik
    '        .SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
    '        .TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
    '        .PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
    '        .InterpolationMode = Drawing2D.InterpolationMode.HighQualityBilinear
    '        .CompositingQuality = Drawing2D.CompositingQuality.HighQuality
    '    End With

    'End Sub

    Private Sub Debug_Modus()

        If Datenbank.Spiel_Debug_Modus = True Then

        Else

        End If
    End Sub

#Region "PB_Spiel-Starten"
    Private Sub PB_Spiel_Starten_Erstellen()
        With PB_Spiel_Starten
            .Location = New Point((Datenbank.Spielmenu_Breite / 2) - (480 / 2), (Datenbank.Spielmenu_Höhe / 2) - ((Datenbank.Spielmenu_Buttonabstand * 3) + (Datenbank.Spielmenu_Buttonhoehe * 3)))
            .Size = Datenbank.Spielmenu_Button
            .Image = My.Resources.button_gamestart_op
            .BackColor = Color.Transparent

        End With
        AddHandler PB_Spiel_Starten.Click, AddressOf PB_Spiel_Starten_Click
        AddHandler PB_Spiel_Starten.MouseEnter, AddressOf PB_Spiel_Starten_MouseEnter
        AddHandler PB_Spiel_Starten.MouseLeave, AddressOf PB_Spiel_Starten_MouseLeave
        Controls.Add(PB_Spiel_Starten)
        PB_Spiel_Starten.Parent = Me
    End Sub

    Private Sub PB_Spiel_Starten_Click(sender As Object, e As EventArgs)
        Spiel_Auswahl.Show()
    End Sub
    Private Sub PB_Spiel_Starten_MouseEnter(sender As Object, e As EventArgs)
        PB_Spiel_Starten.Image = My.Resources.button_gamestart_mp
    End Sub

    Private Sub PB_Spiel_Starten_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Spiel_Starten.Parent = Me
        PB_Spiel_Starten.Image = My.Resources.button_gamestart_op
    End Sub
#End Region

#Region "PB_Store"
    Private Sub PB_Laden_Erstellen()
        With PB_Laden
            .Location = New Point((Datenbank.Spielmenu_Breite / 2) - (480 / 2), (Datenbank.Spielmenu_Höhe / 2) - ((Datenbank.Spielmenu_Buttonabstand * 2) + (Datenbank.Spielmenu_Buttonhoehe * 2)))
            .Size = Datenbank.Spielmenu_Button
            .Image = My.Resources.button_trader_op
            .BackColor = Color.Transparent

        End With
        AddHandler PB_Laden.Click, AddressOf PB_Laden_Click
        AddHandler PB_Laden.MouseEnter, AddressOf PB_Laden_MouseEnter
        AddHandler PB_Laden.MouseLeave, AddressOf PB_Laden_MouseLeave
        Controls.Add(PB_Laden)
        PB_Laden.Parent = Me
    End Sub

    Private Sub PB_Laden_Click(sender As Object, e As EventArgs)
        Spiel_Auswahl.Show()
    End Sub
    Private Sub PB_Laden_MouseEnter(sender As Object, e As EventArgs)
        PB_Laden.Image = My.Resources.button_trader_mp
    End Sub

    Private Sub PB_Laden_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Laden.Parent = Me
        PB_Laden.Image = My.Resources.button_trader_op
    End Sub
#End Region

#Region "PB_Highscore"
    Private Sub PB_Highscore_Erstellen()
        With PB_Highscore
            .Location = New Point((Datenbank.Spielmenu_Breite / 2) - (480 / 2), (Datenbank.Spielmenu_Höhe / 2) - ((Datenbank.Spielmenu_Buttonabstand * 1) + (Datenbank.Spielmenu_Buttonhoehe * 1)))
            .Size = Datenbank.Spielmenu_Button
            .Image = My.Resources.button_highscore_op
            .BackColor = Color.Transparent

        End With
        AddHandler PB_Highscore.Click, AddressOf PB_Highscore_Click
        AddHandler PB_Highscore.MouseEnter, AddressOf PB_Highscore_MouseEnter
        AddHandler PB_Highscore.MouseLeave, AddressOf PB_Highscore_MouseLeave
        Controls.Add(PB_Highscore)
        PB_Highscore.Parent = Me
    End Sub

    Private Sub PB_Highscore_Click(sender As Object, e As EventArgs)
        Spiel_Auswahl.Show()
    End Sub
    Private Sub PB_Highscore_MouseEnter(sender As Object, e As EventArgs)
        PB_Highscore.Image = My.Resources.button_highscore_mp
    End Sub

    Private Sub PB_Highscore_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Highscore.Parent = Me
        PB_Highscore.Image = My.Resources.button_highscore_op
    End Sub
#End Region

#Region "PB_Erfolge"
    Private Sub PB_Erfolge_Erstellen()
        With PB_Erfolge
            .Location = New Point((Datenbank.Spielmenu_Breite / 2) - (480 / 2), (Datenbank.Spielmenu_Höhe / 2))
            .Size = Datenbank.Spielmenu_Button
            .Image = My.Resources.button_erfolge_op
            .BackColor = Color.Transparent

        End With
        AddHandler PB_Erfolge.Click, AddressOf PB_Erfolge_Click
        AddHandler PB_Erfolge.MouseEnter, AddressOf PB_Erfolge_MouseEnter
        AddHandler PB_Erfolge.MouseLeave, AddressOf PB_Erfolge_MouseLeave
        Controls.Add(PB_Erfolge)
        PB_Erfolge.Parent = Me
    End Sub

    Private Sub PB_Erfolge_Click(sender As Object, e As EventArgs)
        Spiel_Auswahl.Show()
    End Sub
    Private Sub PB_Erfolge_MouseEnter(sender As Object, e As EventArgs)
        PB_Erfolge.Image = My.Resources.button_erfolge_mp
    End Sub

    Private Sub PB_Erfolge_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Erfolge.Parent = Me
        PB_Erfolge.Image = My.Resources.button_erfolge_op
    End Sub
#End Region

#Region "PB_Einstellungen"
    Private Sub PB_Einstellungen_Erstellen()
        With PB_Einstellungen
            .Location = New Point((Datenbank.Spielmenu_Breite / 2) - (480 / 2), (Datenbank.Spielmenu_Höhe / 2) + ((Datenbank.Spielmenu_Buttonabstand * 1) + (Datenbank.Spielmenu_Buttonhoehe * 1)))
            .Size = Datenbank.Spielmenu_Button
            .Image = My.Resources.button_einstellungen_op
            .BackColor = Color.Transparent

        End With
        AddHandler PB_Einstellungen.Click, AddressOf PB_Einstellungen_Click
        AddHandler PB_Einstellungen.MouseEnter, AddressOf PB_Einstellungen_MouseEnter
        AddHandler PB_Einstellungen.MouseLeave, AddressOf PB_Einstellungen_MouseLeave
        Controls.Add(PB_Einstellungen)
        PB_Einstellungen.Parent = Me
    End Sub

    Private Sub PB_Einstellungen_Click(sender As Object, e As EventArgs)
        Spiel_Auswahl.Show()
    End Sub
    Private Sub PB_Einstellungen_MouseEnter(sender As Object, e As EventArgs)
        PB_Einstellungen.Image = My.Resources.button_einstellungen_mp
    End Sub

    Private Sub PB_Einstellungen_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Einstellungen.Parent = Me
        PB_Einstellungen.Image = My.Resources.button_einstellungen_op
    End Sub
#End Region

#Region "PB_Schliessen"
    Private Sub PB_Schliessen_Erstellen()
        With PB_Schliessen
            .Location = New Point((Datenbank.Spielmenu_Breite / 2) - (480 / 2), (Datenbank.Spielmenu_Höhe / 2) + ((Datenbank.Spielmenu_Buttonabstand * 2) + (Datenbank.Spielmenu_Buttonhoehe * 2)))
            .Size = Datenbank.Spielmenu_Button
            .Image = My.Resources.button_beenden_op
            .BackColor = Color.Transparent

        End With
        AddHandler PB_Schliessen.Click, AddressOf PB_Schliessen_Click
        AddHandler PB_Schliessen.MouseEnter, AddressOf PB_Schliessen_MouseEnter
        AddHandler PB_Schliessen.MouseLeave, AddressOf PB_Schliessen_MouseLeave
        Controls.Add(PB_Schliessen)
        PB_Schliessen.Parent = Me
    End Sub

    Private Sub PB_Schliessen_Click(sender As Object, e As EventArgs)
        Spiel_Auswahl.Show()
    End Sub
    Private Sub PB_Schliessen_MouseEnter(sender As Object, e As EventArgs)
        PB_Schliessen.Image = My.Resources.button_beenden_mp
    End Sub

    Private Sub PB_Schliessen_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Schliessen.Parent = Me
        PB_Schliessen.Image = My.Resources.button_beenden_op
    End Sub
#End Region

End Class