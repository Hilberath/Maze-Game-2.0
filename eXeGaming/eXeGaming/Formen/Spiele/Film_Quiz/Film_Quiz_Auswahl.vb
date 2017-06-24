Public Class Film_Quiz_Auswahl

    Dim titel As String = Datenbank.Spielwelt_Titel

    Dim G As Graphics
    Dim MyFont = New Font("Arial", 8)
    Dim MyPen = New Pen(Brushes.White, 3)

    Dim Film_Quiz_Spiel_001 As New PictureBox
    Dim Film_Quiz_Spiel_002 As New PictureBox
    Dim Film_Quiz_Spiel_003 As New PictureBox

    Private Sub Film_Quiz_Auswahl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With Me
            '.Icon = Datenbank.Spiel_Icon
            .Text = titel
            .Width = Datenbank.Spielmenu_Breite
            .Height = Datenbank.Spielmenu_Höhe
            .BackColor = Datenbank.Spielmenu_Hintergrundfarbe
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

        Film_Quiz_Spiel_001_Erstellen()
        Film_Quiz_Spiel_002_Erstellen()
        Film_Quiz_Spiel_003_Erstellen()
    End Sub

    Private Sub Debug_Modus()

        If Datenbank.Spiel_Debug_Modus = True Then

        Else

        End If
    End Sub

#Region "Film_Quiz_Spiel_001"
    Private Sub Film_Quiz_Spiel_001_Erstellen()
        With Film_Quiz_Spiel_001
            .Location = New Point(Datenbank.Spielmenu_Breite / 2 - 389, Datenbank.Spielmenu_Höhe / 2 - 128)
            .Size = New Size(256, 256)
            .BackgroundImage = My.Resources.Level001F
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler Film_Quiz_Spiel_001.Click, AddressOf Film_Quiz_Spiel_001_Click
        Controls.Add(Film_Quiz_Spiel_001)
        Film_Quiz_Spiel_001.Parent = Me
    End Sub

    Private Sub Film_Quiz_Spiel_001_Click(sender As Object, e As EventArgs)
        HD_Level1.Show()
        Me.Close()
    End Sub

#End Region

#Region "Film_Quiz_Spiel_002"
    Private Sub Film_Quiz_Spiel_002_Erstellen()
        With Film_Quiz_Spiel_002
            .Location = New Point(Datenbank.Spielmenu_Breite / 2 - 128, Datenbank.Spielmenu_Höhe / 2 - 128)
            .Size = New Size(256, 256)
            .BackgroundImage = My.Resources.Level001F
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler Film_Quiz_Spiel_002.Click, AddressOf Film_Quiz_Spiel_002_Click
        Controls.Add(Film_Quiz_Spiel_002)
        Film_Quiz_Spiel_002.Parent = Me
    End Sub

    Private Sub Film_Quiz_Spiel_002_Click(sender As Object, e As EventArgs)
        HD_Level1.Show()
        Me.Close()
    End Sub

#End Region

#Region "Film_Quiz_Spiel_003"
    Private Sub Film_Quiz_Spiel_003_Erstellen()
        With Film_Quiz_Spiel_003
            .Location = New Point(Datenbank.Spielmenu_Breite / 2 + 133, Datenbank.Spielmenu_Höhe / 2 - 128)
            .Size = New Size(256, 256)
            .BackgroundImage = My.Resources.Level001F
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler Film_Quiz_Spiel_003.Click, AddressOf Film_Quiz_Spiel_003_Click
        Controls.Add(Film_Quiz_Spiel_003)
        Film_Quiz_Spiel_003.Parent = Me
    End Sub

    Private Sub Film_Quiz_Spiel_003_Click(sender As Object, e As EventArgs)
        HD_Level1.Show()
        Me.Close()
    End Sub

#End Region

End Class