Public Class HD_Level2

    Dim ZeitText As New Label
    Dim Zeit As Integer
    Dim Versuch As Integer

    Private Sub HD_Level2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .FormBorderStyle = FormBorderStyle.None
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

        ZeitText_Erstellen()
        Timer1.Start()
        versuche()

    End Sub

    Private Sub ZeitText_Erstellen()
        Label_Zeit.Text = Zeit
    End Sub
    Private Sub countdown()

        Zeit += 1
        Timer1.Start()
    End Sub

    Private Sub versuche()
        Label_Versuche.Text = Versuch
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        countdown()
        ZeitText_Erstellen()
        versuche()
    End Sub

    Private Sub HD_Level1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Dim Result As MsgBoxResult
        Result = MsgBox("Zurück zum Level Menü", MsgBoxStyle.Information Or MsgBoxStyle.YesNo)

        If e.KeyCode = Keys.Escape = True Then
            If Result = MsgBoxResult.Yes = True Then
                Heisser_Draht_Level_Menu.Show()
            Else
            End If
        End If
    End Sub

    Private Sub PB_Wall1_MouseEnter(sender As Object, e As EventArgs) Handles PB_Wall1.MouseEnter
        Versuch += 1
        MsgBox("Game Over")
        Dim x As Integer = Datenbank.Maus_Back_Breite
        Dim y As Integer = Datenbank.Maus_Back_höhe
        SetCursorPos(x, y)
    End Sub

    Private Sub PB_Wall3_MouseEnter(sender As Object, e As EventArgs) Handles PB_Wall3.MouseEnter
        Versuch += 1
        MsgBox("Game Over")
        Dim x As Integer = Datenbank.Maus_Back_Breite
        Dim y As Integer = Datenbank.Maus_Back_höhe
        SetCursorPos(x, y)
    End Sub

    Private Sub PB_Wall2_MouseEnter(sender As Object, e As EventArgs) Handles PB_Wall2.MouseEnter
        Versuch += 1
        MsgBox("Game Over")
        Dim x As Integer = Datenbank.Maus_Back_Breite
        Dim y As Integer = Datenbank.Maus_Back_höhe
        SetCursorPos(x, y)
    End Sub

    Private Sub PB_Wall7_MouseEnter(sender As Object, e As EventArgs) Handles PB_Wall7.MouseEnter
        Versuch += 1
        MsgBox("Game Over")
        Dim x As Integer = Datenbank.Maus_Back_Breite
        Dim y As Integer = Datenbank.Maus_Back_höhe
        SetCursorPos(x, y)
    End Sub

    Private Sub PB_Wall8_MouseEnter(sender As Object, e As EventArgs) Handles PB_Wall8.MouseEnter
        Versuch += 1
        MsgBox("Game Over")
        Dim x As Integer = Datenbank.Maus_Back_Breite
        Dim y As Integer = Datenbank.Maus_Back_höhe
        SetCursorPos(x, y)
    End Sub

    Private Sub PB_Wall4_MouseEnter(sender As Object, e As EventArgs) Handles PB_Wall4.MouseEnter
        Versuch += 1
        MsgBox("Game Over")
        Dim x As Integer = Datenbank.Maus_Back_Breite
        Dim y As Integer = Datenbank.Maus_Back_höhe
        SetCursorPos(x, y)
    End Sub

    Private Sub PB_Wall6_MouseEnter(sender As Object, e As EventArgs) Handles PB_Wall6.MouseEnter
        Versuch += 1
        MsgBox("Game Over")
        Dim x As Integer = Datenbank.Maus_Back_Breite
        Dim y As Integer = Datenbank.Maus_Back_höhe
        SetCursorPos(x, y)
    End Sub

    Private Sub PB_Wall5_MouseEnter(sender As Object, e As EventArgs) Handles PB_Wall5.MouseEnter
        Versuch += 1
        MsgBox("Game Over")
        Dim x As Integer = Datenbank.Maus_Back_Breite
        Dim y As Integer = Datenbank.Maus_Back_höhe
        SetCursorPos(x, y)
    End Sub

    Private Sub PB_Ziel_MouseEnter(sender As Object, e As EventArgs) Handles PB_Ziel.MouseEnter
        Heisser_Draht_Level.level_done_002 = True
        Heisser_Draht_Level.level_003 = True
        Heisser_Draht_Level_Menu.Show()
        Me.Close()
    End Sub

    Private Sub PB_Wall9_MouseEnter(sender As Object, e As EventArgs) Handles PB_Wall9.MouseEnter
        Versuch += 1
        MsgBox("Game Over")
        Dim x As Integer = Datenbank.Maus_Back_Breite
        Dim y As Integer = Datenbank.Maus_Back_höhe
        SetCursorPos(x, y)
    End Sub

    Private Sub PB_Wall10_MouseEnter(sender As Object, e As EventArgs) Handles PB_Wall10.MouseEnter
        Versuch += 1
        MsgBox("Game Over")
        Dim x As Integer = Datenbank.Maus_Back_Breite
        Dim y As Integer = Datenbank.Maus_Back_höhe
        SetCursorPos(x, y)
    End Sub

    Private Sub PB_Wall11_MouseEnter(sender As Object, e As EventArgs) Handles PB_Wall11.MouseEnter
        Versuch += 1
        MsgBox("Game Over")
        Dim x As Integer = Datenbank.Maus_Back_Breite
        Dim y As Integer = Datenbank.Maus_Back_höhe
        SetCursorPos(x, y)
    End Sub

    Private Sub PB_wall12_MouseEnter(sender As Object, e As EventArgs) Handles PB_wall12.MouseEnter
        Versuch += 1
        MsgBox("Game Over")
        Dim x As Integer = Datenbank.Maus_Back_Breite
        Dim y As Integer = Datenbank.Maus_Back_höhe
        SetCursorPos(x, y)
    End Sub

    Private Sub PB_Wall13_MouseEnter(sender As Object, e As EventArgs) Handles PB_Wall13.MouseEnter
        Versuch += 1
        MsgBox("Game Over")
        Dim x As Integer = Datenbank.Maus_Back_Breite
        Dim y As Integer = Datenbank.Maus_Back_höhe
        SetCursorPos(x, y)
    End Sub
End Class