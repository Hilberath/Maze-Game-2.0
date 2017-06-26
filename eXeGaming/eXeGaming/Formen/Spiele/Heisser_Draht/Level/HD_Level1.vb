Public Class HD_Level1

    Dim ZeitText As New Label
    Dim Zeit As Integer
    Dim Versuch As Integer

    Private Sub HD_Level1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
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
        Heisser_Draht_Level.level_done_001 = True
        Heisser_Draht_Level.level_002 = True
        HD_Level2.Show()
        Me.Close()
    End Sub

    Private Sub PB_Wall4_Click(sender As Object, e As EventArgs) Handles PB_Wall4.Click

    End Sub

    Private Sub Label_Versuche_Click(sender As Object, e As EventArgs) Handles Label_Versuche.Click

    End Sub

    Private Sub Label_Zeit_Click(sender As Object, e As EventArgs) Handles Label_Zeit.Click

    End Sub

    Private Sub PB_Start_Click(sender As Object, e As EventArgs) Handles PB_Start.Click

    End Sub

    Private Sub PB_Ziel_Click(sender As Object, e As EventArgs) Handles PB_Ziel.Click

    End Sub

    Private Sub PB_Wall1_Click(sender As Object, e As EventArgs) Handles PB_Wall1.Click

    End Sub

    Private Sub PB_Wall2_Click(sender As Object, e As EventArgs) Handles PB_Wall2.Click

    End Sub

    Private Sub PB_Wall3_Click(sender As Object, e As EventArgs) Handles PB_Wall3.Click

    End Sub

    Private Sub PB_Wall5_Click(sender As Object, e As EventArgs) Handles PB_Wall5.Click

    End Sub

    Private Sub PB_Wall6_Click(sender As Object, e As EventArgs) Handles PB_Wall6.Click

    End Sub

    Private Sub PB_Wall7_Click(sender As Object, e As EventArgs) Handles PB_Wall7.Click

    End Sub

    Private Sub PB_Wall8_Click(sender As Object, e As EventArgs) Handles PB_Wall8.Click

    End Sub
End Class