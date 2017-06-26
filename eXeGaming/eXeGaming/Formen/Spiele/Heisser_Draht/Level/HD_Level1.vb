Public Class HD_Level1

    Dim R01 As New PictureBox
    Dim R02 As New PictureBox
    Dim R03 As New PictureBox
    Dim R04 As New PictureBox
    Dim R05 As New PictureBox
    Dim R06 As New PictureBox
    Dim R07 As New PictureBox
    Dim R08 As New PictureBox
    Dim ZeitText As New Label
    Dim Zeit As Integer
    Dim Versuch As Integer

    Private Sub HD_Level1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .FormBorderStyle = FormBorderStyle.Fixed3D
            .Width = Datenbank.Level_Breite
            .Height = Datenbank.Level_Höhe
            .BackColor = Datenbank.Level_Hintergrundfarbe
            .ForeColor = Datenbank.Level_Schriftfarbe
            .AutoSizeMode = AutoSizeMode.GrowAndShrink
            .StartPosition = FormStartPosition.CenterScreen
            .WindowState = FormWindowState.Maximized
            '.Icon = My.Resources
            Zeit = 0
            Versuch = 0
            init()

        End With
        Dim x As Integer = Datenbank.Maus_Back_Breite
        Dim y As Integer = Datenbank.Maus_Back_höhe
        SetCursorPos(x, y)

        If Datenbank.Launcher_Musik_Modus = True Then
            My.Computer.Audio.Play(Datenbank.Spiel_Pfad & Datenbank.Spiel_Pfad_Spiel & "/sounds/" & Datenbank.Launcher_Titel_Song & ".wav", AudioPlayMode.BackgroundLoop)
        Else
            My.Computer.Audio.Stop()
        End If
    End Sub

    Private Declare Function SetCursorPos Lib "user32" (ByVal X As Integer, ByVal Y As Integer) As Integer

    Private Sub init()
        R01_Erstellen()
        R02_Erstellen()
        R03_Erstellen()
        R04_Erstellen()
        R05_Erstellen()
        R06_Erstellen()
        R07_Erstellen()
        R08_Erstellen()
        ZeitText_Erstellen()
        Timer1.Start()
        versuche()

    End Sub

    Private Sub ZeitText_Erstellen()
        TSB_Zeit.Text = "Zeit: " & Zeit & " Sekunden"
    End Sub
    Private Sub countdown()

        Zeit += 1
        Timer1.Start()
    End Sub

    Private Sub versuche()
        TSB_Versuche.Text = "Versuche:" & " " & Versuch
    End Sub

    Private Sub R01_Erstellen()
        With R01
            .Location = New Point(12, 12)
            .Size = New Size(30, 1017)
            .BackgroundImage = Datenbank.Balkenfarbe
            .BackgroundImageLayout = ImageLayout.Tile
        End With
        AddHandler R01.MouseEnter, AddressOf R01_MouseEnter
        Controls.Add(R01)
        R01.Parent = Me
    End Sub

    Private Sub R01_MouseEnter(sender As Object, e As EventArgs)
        Versuch += 1
        MsgBox("Game Over")
        Dim x As Integer = Datenbank.Maus_Back_Breite
        Dim y As Integer = Datenbank.Maus_Back_höhe
        SetCursorPos(x, y)
    End Sub

    Private Sub R02_Erstellen()
        With R02
            .Location = New Point(42, 962)
            .Size = New Size(1850, 30)
            .BackgroundImage = Datenbank.Balkenfarbe
            .BackgroundImageLayout = ImageLayout.Tile
        End With
        AddHandler R02.MouseEnter, AddressOf R02_MouseEnter
        Controls.Add(R02)
        R02.Parent = Me
    End Sub

    Private Sub R02_MouseEnter(sender As Object, e As EventArgs)
        Versuch += 1
        MsgBox("Game Over")
        Dim x As Integer = Datenbank.Maus_Back_Breite
        Dim y As Integer = Datenbank.Maus_Back_höhe
        SetCursorPos(x, y)
    End Sub

    Private Sub R03_Erstellen()
        With R03
            .Location = New Point(1862, 283)
            .Size = New Size(30, 717)
            .BackgroundImage = Datenbank.Balkenfarbe
            .BackgroundImageLayout = ImageLayout.Tile
        End With
        AddHandler R03.MouseEnter, AddressOf R03_MouseEnter
        Controls.Add(R03)
        R03.Parent = Me
    End Sub

    Private Sub R03_MouseEnter(sender As Object, e As EventArgs)
        Versuch += 1
        MsgBox("Game Over")
        Dim x As Integer = Datenbank.Maus_Back_Breite
        Dim y As Integer = Datenbank.Maus_Back_höhe
        SetCursorPos(x, y)
        SetCursorPos(x, y)
    End Sub

    Private Sub R04_Erstellen()
        With R04
            .Location = New Point(362, 283)
            .Size = New Size(1500, 400)
            .BackgroundImage = Datenbank.Balkenfarbe
            .BackgroundImageLayout = ImageLayout.Tile
        End With
        AddHandler R04.MouseEnter, AddressOf R04_MouseEnter
        Controls.Add(R04)
        R04.Parent = Me
    End Sub

    Private Sub R04_MouseEnter(sender As Object, e As EventArgs)
        Versuch += 1
        MsgBox("Game Over")
        Dim x As Integer = Datenbank.Maus_Back_Breite
        Dim y As Integer = Datenbank.Maus_Back_höhe
        SetCursorPos(x, y)
    End Sub

    Private Sub R05_Erstellen()
        With R05
            .Location = New Point(362, 130)
            .Size = New Size(400, 30)
            .BackgroundImage = Datenbank.Balkenfarbe
            .BackgroundImageLayout = ImageLayout.Tile
        End With
        AddHandler R05.MouseEnter, AddressOf R05_MouseEnter
        Controls.Add(R05)
        R05.Parent = Me
    End Sub

    Private Sub R05_MouseEnter(sender As Object, e As EventArgs)
        Versuch += 1
        MsgBox("Game Over")
        Dim x As Integer = Datenbank.Maus_Back_Breite
        Dim y As Integer = Datenbank.Maus_Back_höhe
        SetCursorPos(x, y)
    End Sub

    Private Sub R06_Erstellen()
        With R06
            .Location = New Point(42, 12)
            .Size = New Size(1500, 30)
            .BackgroundImage = Datenbank.Balkenfarbe
            .BackgroundImageLayout = ImageLayout.Tile
        End With
        AddHandler R06.MouseEnter, AddressOf R06_MouseEnter
        Controls.Add(R06)
        R06.Parent = Me
    End Sub

    Private Sub R06_MouseEnter(sender As Object, e As EventArgs)
        Versuch += 1
        MsgBox("Game Over")
        Dim x As Integer = Datenbank.Maus_Back_Breite
        Dim y As Integer = Datenbank.Maus_Back_höhe
        SetCursorPos(x, y)
    End Sub

    Private Sub R07_Erstellen()
        With R07
            .Location = New Point(1663, 791)
            .Size = New Size(128, 128)
            .BackgroundImage = My.Resources.Level_Ziel
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackColor = Nothing
        End With
        AddHandler R07.MouseEnter, AddressOf R07_MouseEnter
        Controls.Add(R07)
        R07.Parent = Me
    End Sub

    Private Sub R07_MouseEnter(sender As Object, e As EventArgs)
        Heisser_Draht_Level.level_done_001 = True
        Heisser_Draht_Level.level_002 = True
        Heisser_Draht_Level_Menu.Show()
        MsgBox("Glückwunsch, du hast es geschafft")
        Timer1.Stop()
        Me.Close()
    End Sub

    Private Sub R08_Erstellen()
        With R08
            .Location = New Point(1663, 102)
            .Size = New Size(128, 128)
            .BackgroundImage = My.Resources.Level_Start
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackColor = Nothing
        End With
        Controls.Add(R08)
        R08.Parent = Me
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        countdown()
        ZeitText_Erstellen()
        versuche()
    End Sub
End Class