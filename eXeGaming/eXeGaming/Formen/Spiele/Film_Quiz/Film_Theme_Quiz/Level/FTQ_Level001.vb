Public Class FTQ_Level001

    Dim titel As String = Datenbank.Spielwelt_Titel

    Dim G As Graphics
    Dim MyFont = New Font("Arial", 22)
    Dim MyPen = New Pen(Brushes.White, 3)

    Dim Antwort_1 As New Button
    Dim Antwort_2 As New Button
    Dim Antwort_3 As New Button
    Dim Antwort_4 As New Button

    Private Sub FTQ_Level001_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        End With

        My.Computer.Audio.Play(My.Resources.Star_Wars_Theme, AudioPlayMode.BackgroundLoop)

        Init()
    End Sub

    Private Sub Init()
        Debug_Modus()
        Antwort_1_Erstellen()
        Antwort_2_Erstellen()
        Antwort_3_Erstellen()
        Antwort_4_Erstellen()
    End Sub

    Private Sub Debug_Modus()

        If Datenbank.Spiel_Debug_Modus = True Then

        Else

        End If
    End Sub

    Private Sub Frage_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        G = e.Graphics

        With G
            .DrawString("Wie lautet der Film zu diesem Soundtrack?", MyFont, Brushes.White, (Datenbank.Spielmenu_Breite / 2) - 440, 110)

        End With

    End Sub

    Private Sub Antwort_1_Erstellen()
        With Antwort_1
            .Location = New Point((Datenbank.Spielmenu_Breite / 2) - 40, Datenbank.Spielmenu_Höhe / 2 - 125)
            .Size = Datenbank.Spielmenu_Button
            .Text = "Star Trek"
            .BackColor = Color.LightGray
        End With
        AddHandler Antwort_1.Click, AddressOf Antwort_1_Click

        Controls.Add(Antwort_1)
        Antwort_1.Parent = Me
    End Sub

    Private Sub Antwort_1_Click(sender As Object, e As EventArgs)
        My.Computer.Audio.Stop()
        MsgBox("Diese Antwort ist leider Falsch")
    End Sub

    Private Sub Antwort_2_Erstellen()
        With Antwort_2
            .Location = New Point((Datenbank.Spielmenu_Breite / 2) - 440, Datenbank.Spielmenu_Höhe / 2 - 125)
            .Size = Datenbank.Spielmenu_Button
            .Text = "Star Wars"
            .BackColor = Color.LightGray
        End With
        AddHandler Antwort_2.Click, AddressOf Antwort_2_Click

        Controls.Add(Antwort_2)
        Antwort_2.Parent = Me
    End Sub

    Private Sub Antwort_2_Click(sender As Object, e As EventArgs)
        My.Computer.Audio.Stop()
        MsgBox("Diese Antwort ist Richtig")
    End Sub

    Private Sub Antwort_3_Erstellen()
        With Antwort_3
            .Location = New Point((Datenbank.Spielmenu_Breite / 2) - 40, Datenbank.Spielmenu_Höhe / 2 - 175)
            .Size = Datenbank.Spielmenu_Button
            .Text = "Matrix"
            .BackColor = Color.LightGray
        End With
        AddHandler Antwort_3.Click, AddressOf Antwort_3_Click

        Controls.Add(Antwort_3)
        Antwort_3.Parent = Me
    End Sub

    Private Sub Antwort_3_Click(sender As Object, e As EventArgs)
        My.Computer.Audio.Stop()
        MsgBox("Diese Antwort ist leider Falsch")
    End Sub

    Private Sub Antwort_4_Erstellen()
        With Antwort_4
            .Location = New Point((Datenbank.Spielmenu_Breite / 2) - 440, Datenbank.Spielmenu_Höhe / 2 - 175)
            .Size = Datenbank.Spielmenu_Button
            .Text = "Toy Story"
            .BackColor = Color.LightGray
        End With
        AddHandler Antwort_4.Click, AddressOf Antwort_4_Click

        Controls.Add(Antwort_4)
        Antwort_4.Parent = Me
    End Sub

    Private Sub Antwort_4_Click(sender As Object, e As EventArgs)
        My.Computer.Audio.Stop()
        MsgBox("Diese Antwort ist Richtig")
    End Sub

    Private Sub FTQ_Level001_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

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