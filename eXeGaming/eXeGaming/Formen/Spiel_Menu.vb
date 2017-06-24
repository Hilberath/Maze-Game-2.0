Public Class Spiel_Menu

    Dim titel As String = Datenbank.Spielwelt_Titel

    Dim G As Graphics
    Dim MyFont = New Font("Arial", 8)
    Dim MyPen = New Pen(Brushes.White, 3)

    Dim Button_Spiel_Starten As New Button
    Dim Button_Laden As New Button
    Dim Button_Highscore As New Button
    Dim Button_Einstellungen As New Button
    Dim Button_Schliessen As New Button


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

        Button_Spiel_Starten_Erstellen()
        Button_Laden_Erstellen()
        Button_Einstellungen_Erstellen()
        Button_Schliessen_Erstellen()
        Button_Highscore_erstellen()
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

#Region "Button_Spiel_Starten"
    Private Sub Button_Spiel_Starten_Erstellen()
        With Button_Spiel_Starten
            .Location = New Point((Datenbank.Spielmenu_Breite / 2) - (250 / 2), Datenbank.Spielmenu_Höhe / 2 - 125)
            .Size = Datenbank.Spielmenu_Button
            .Text = "Spiel Starten"
            .BackColor = Color.LightGray
        End With
        AddHandler Button_Spiel_Starten.Click, AddressOf Button_Spiel_Starten_Click

        Controls.Add(Button_Spiel_Starten)
        Button_Spiel_Starten.Parent = Me
    End Sub

    Private Sub Button_Spiel_Starten_Click(sender As Object, e As EventArgs)
        Spiel_Auswahl.Show()
        Me.Close()
    End Sub
#End Region

#Region "Button_Laden"
    Private Sub Button_Laden_Erstellen()
        With Button_Laden
            .Location = New Point((Datenbank.Spielmenu_Breite / 2) - (250 / 2), Datenbank.Spielmenu_Höhe / 2 - 125 + 55)
            .Size = Datenbank.Spielmenu_Button
            .Text = "Laden"
            .BackColor = Color.LightGray
        End With
        AddHandler Button_Laden.Click, AddressOf Button_Laden_Click

        Controls.Add(Button_Laden)
        Button_Laden.Parent = Me
    End Sub

    Private Sub Button_Laden_Click(sender As Object, e As EventArgs)

    End Sub
#End Region

#Region "Button_Highscore"
    Private Sub Button_Highscore_erstellen()
        With Button_Highscore
            .Location = New Point((Datenbank.Spielmenu_Breite / 2) - (250 / 2), Datenbank.Spielmenu_Höhe / 2 - 125 + 110)
            .Size = Datenbank.Spielmenu_Button
            .Text = "Highscore - Erfolge"
            .BackColor = Color.LightGray
        End With
        AddHandler Button_Highscore.Click, AddressOf Button_Highscore_Click

        Controls.Add(Button_Highscore)
        Button_Highscore.Parent = Me
    End Sub

    Private Sub Button_Highscore_Click(sender As Object, e As EventArgs)

    End Sub
#End Region

#Region "Button_Einstellungen"
    Private Sub Button_Einstellungen_Erstellen()
        With Button_Einstellungen
            .Location = New Point((Datenbank.Spielmenu_Breite / 2) - (250 / 2), Datenbank.Spielmenu_Höhe / 2 - 125 + 165)
            .Size = Datenbank.Spielmenu_Button
            .Text = "Einstellungen"
            .BackColor = Color.LightGray
        End With
        AddHandler Button_Einstellungen.Click, AddressOf Button_Einstellungen_Click

        Controls.Add(Button_Einstellungen)
        Button_Einstellungen.Parent = Me
    End Sub

    Private Sub Button_Einstellungen_Click(sender As Object, e As EventArgs)
        Einstellungen.Show()
    End Sub
#End Region

#Region "Button_Schliessen"
    Private Sub Button_Schliessen_Erstellen()
        With Button_Schliessen
            .Location = New Point((Datenbank.Spielmenu_Breite / 2) - (250 / 2), Datenbank.Spielmenu_Höhe / 2 - 125 + 220)
            .Size = Datenbank.Spielmenu_Button
            .Text = "Schliessen"
            .BackColor = Color.LightGray
        End With
        AddHandler Button_Schliessen.Click, AddressOf Button_Schliessen_Click

        Controls.Add(Button_Schliessen)
        Button_Schliessen.Parent = Me
    End Sub

    Private Sub Button_Schliessen_Click(sender As Object, e As EventArgs)
        Me.Close()
        Launcher.Show()
    End Sub
#End Region

End Class