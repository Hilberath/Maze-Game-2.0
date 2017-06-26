Imports System.IO
Imports System.Net
Imports INIDatei.INIDatei 'DLL INIDatei

Public Class Launcher

    Dim titel As String = Datenbank.Launcher_Titel

    Dim G As Graphics
    Dim MyFont = New Font("Arial", 8)
    Dim MyPen = New Pen(Brushes.White, 3)

    Dim PB_Schliessen As New PictureBox
    Dim PB_Minimieren As New PictureBox
    Dim PB_Einstellungen As New PictureBox
    Dim PB_Facebook As New PictureBox
    Dim PB_Twitter As New PictureBox
    Dim PB_YouTube As New PictureBox
    Dim PB_Google_Plus As New PictureBox
    Dim PB_News As New PictureBox
    Dim PB_News_Trenner As New PictureBox
    Dim PB_Spiel_Starten As New PictureBox

    Dim RTB_Version As New RichTextBox

    Dim VersionProgressbar As New ProgressBar
    Dim Versiongroesse As New Label
    Dim News_Text As New Label

    Dim INI As New INIDatei.INIDatei 'Dekalriert INI
    Private WithEvents HTTPClient As WebClient 'HTTPClient

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
            .BackgroundImage = Datenbank.Launcher_Hintergrundgrafik
            .AutoSizeMode = AutoSizeMode.GrowAndShrink
            .StartPosition = FormStartPosition.CenterScreen
            .WindowState = FormWindowState.Normal
            '.Icon = My.Resources

            init()

        End With
        If Datenbank.Launcher_Musik_Modus = True Then
            My.Computer.Audio.Play(Datenbank.Spiel_Pfad & Datenbank.Spiel_Pfad_Spiel & "/sounds/" & Datenbank.Launcher_Titel_Song & ".wav", AudioPlayMode.BackgroundLoop)
        Else
            My.Computer.Audio.Stop()
        End If
    End Sub


    Private Sub init()
        PB_Schliessen_Erstellen()
        PB_Minimieren_Erstellen()
        PB_Einstellungen_Erstellen()
        PB_Facebook_Erstellen()
        PB_Twitter_Erstellen()
        PB_YouTube_Erstellen()
        PB_Google_Plus_Erstellen()
        PB_News_Erstellen()
        PB_Spiel_Starten_Erstellen()

        VersionProgressbar_Erstellen()
        Versiongroesse_Erstellen()
        RTB_Version_Erstellen()

        News_Text_Erstellen()

        If Datenbank.Spiel_AutoUpdate = True Then
            UpdatePrüfung()
        Else
            Versiongroesse.Text = "AutoUpdate ist Deaktiviert"
        End If

    End Sub

    Public Sub UpdateLabelChange()

        If Not Datenbank.Spiel_AutoUpdate = True Then
            Versiongroesse.Text = "AutoUpdate ist Deaktiviert"
        Else
            UpdatePrüfung()
        End If

    End Sub

#Region "Update Funktion"

    Sub UpdatePrüfung()
        Try
            If My.Computer.Network.IsAvailable = True Then 'Prüft ob Netzwerk-Verbindung besteht
                'Definitionen
                Dim FTPLink As String
                Dim DownloadVerzeichnisVersion As String
                Dim AktuelleVersion As String
                Dim NeueVersion As String

                'Zuweisungen
                FTPLink = "https://raw.githubusercontent.com/DavHil/eXeGaming/master/eXeGaming/eXeGaming/Version.txt" 'FTP-DownloadLink zur Text-Datei mit evtl. neuer Version
                DownloadVerzeichnisVersion = My.Application.Info.DirectoryPath & "\Temp\Version.txt" 'System.Text.Encoding.GetEncoding(1252) 'Wohin die Text-Datei heruntergeladen werden soll
                AktuelleVersion = Application.ProductVersion 'Die derzeit verwendete Version

                'Download der Version.txt
                My.Computer.Network.DownloadFile(FTPLink, DownloadVerzeichnisVersion, "", "", False, 3000, True) 'Download der Text-Datei (Adresse, Ziel, Benutzername, Passwort, UI, Timeout, Overwrite) lädt alle Dateien nicht nur binäre

                'Einlesen der Version.txt in RTB1
                Dim LeseVerzeichnis As String = My.Application.Info.DirectoryPath & "\Temp\Version.txt"
                Dim SRText As String
                Using SR As New System.IO.StreamReader(LeseVerzeichnis)
                    SRText = SR.ReadToEnd()
                End Using
                RTB_Version.Text = SRText

                'Schreiben in PrüfenVersion.txt aus RTB1
                Dim Schreiben As String = My.Application.Info.DirectoryPath & "\Temp\PrüfenVersion.txt"
                Using SW As New System.IO.StreamWriter(Schreiben, False, System.Text.Encoding.GetEncoding(1252)) '(True = Anfügen der Daten / False = Überschreiben der Daten)
                    SW.Write(SRText)
                End Using

                'Auf Version prüfen
                INI.Pfad = My.Application.Info.DirectoryPath & "\Temp\PrüfenVersion.txt" 'Pfad zum Auslesen der Text-Datei (hier wird die Klasse "INIDatei" verwendet - siehe ältere Videos)
                NeueVersion = INI.WertLesen("Info", "Version", "") 'Liest Version aus

                Select Case True 'Vergleicht Version
                    Case AktuelleVersion = NeueVersion Or AktuelleVersion > NeueVersion 'Gleiche 
                        Versiongroesse.Text = "Spiel ist auf dem aktuellen Stand"
                    Case AktuelleVersion < NeueVersion 'Alte Version auf PC
                        Dim Result As MsgBoxResult
                        Result = MsgBox("Es ist eine neue Version (" & NeueVersion & ") verfügbar. Soll diese heruntergeladen werden?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "ABC")

                        If Result = MsgBoxResult.Yes = True Then
                            Dim DownloadLink As String 'Downloadlink zu Update.exe
                            Dim DownloadVerzeichnisUpdate As String 'Zielpfad, wohin die Update.exe heruntergeladen werden soll

                            DownloadLink = INI.WertLesen("Info", "DownloadLink", "") 'Liest DownloadLinks aus
                            DownloadVerzeichnisUpdate = My.Application.Info.DirectoryPath & "\Temp\Update.exe" 'Gibt Zielpfad an

                            'Schaltet Progressbar visible
                            VersionProgressbar.Value = 0
                            VersionProgressbar.Maximum = 100
                            VersionProgressbar.Visible = True
                            Versiongroesse.Visible = True

                            HTTPClient = New WebClient 'HttpClient (lädt nur binäre Dateien)
                            Try
                                HTTPClient.DownloadFileAsync(New Uri(DownloadLink), DownloadVerzeichnisUpdate) 'Lädt Update herunter (asynchron, damit Anzeige in ProgressBar möglich ist - MultiThreading)
                            Catch ex As Exception
                                MsgBox(ex.Message)
                            End Try
                        Else
                            Exit Sub
                        End If
                    Case Else 'Nicht definierter Zustand
                        Exit Sub
                End Select
            Else
                MsgBox("Ihr PC hat derzeit keinen Internetzugriff.", MsgBoxStyle.Exclamation, "ABC")
                Exit Sub
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub HTTPClient_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles HTTPClient.DownloadFileCompleted
        'Wenn Download fertig
        Try
            MsgBox("Das Update wurde erfolgreich heruntergeladen. Der Installer wird nun gestartet. Folgen Sie den Anweisungen auf dem Bildschirm.", MsgBoxStyle.Information, "ABC")

            Dim UpdateStarten As String
            UpdateStarten = My.Application.Info.DirectoryPath & "\Temp\Update.exe"

            Process.Start(UpdateStarten) 'Ausführen des Updates
            Me.Dispose() 'Beendet das Programm für das Update
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "TextCrypter")
        End Try
    End Sub

    Private Sub HTTPClient_DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles HTTPClient.DownloadProgressChanged
        'Progressbar
        With VersionProgressbar 'Berechnet Anzeige für Fortschritt
            .Value = e.ProgressPercentage

            Dim TotalBytes As Long = e.TotalBytesToReceive / 1024 'Fragt Gesamtgröße (Bytes) ab, die es zu empfangen gilt (/1024 um KiloBytes zu erhalten)
            Dim Bytes As Long = e.BytesReceived / 1024 'Fragt Bytes ab, die schon angekommen sind
            If TotalBytes < 1 Then TotalBytes = 1 'Wenn kleiner 1 Byte, dann 1 Byte
            If Bytes < 1 Then Bytes = 1 'Wenn kleiner 1 Byte, dann 1 Byte

            Versiongroesse.Text = Bytes.ToString & " KB von " & TotalBytes.ToString & " KB" 'Anzeige im Label

            VersionProgressbar.Refresh() 'Refresh für ProgressBar
        End With
    End Sub

#End Region

#Region "Launcher Überschrift"
    Private Sub Launcher_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        G = e.Graphics

        With G
            .DrawString(Datenbank.Launcher_Titel, MyFont, Brushes.White, 12, 10)
            .DrawString(Datenbank.Spiel_Version, MyFont, Brushes.White, 485, 10)
        End With

        With e.Graphics
            .SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            .PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
            .InterpolationMode = Drawing2D.InterpolationMode.HighQualityBilinear
            .CompositingQuality = Drawing2D.CompositingQuality.HighQuality
        End With

    End Sub
#End Region

#Region "VersionProgressbar"
    Private Sub VersionProgressbar_Erstellen()
        With VersionProgressbar
            .Location = New Point(15, 550)
            .Size = New Size(600, 25)
        End With
        Controls.Add(VersionProgressbar)
        VersionProgressbar.Parent = Me
    End Sub
#End Region

#Region "Versiongroesse"
    Private Sub Versiongroesse_Erstellen()
        With Versiongroesse
            .Location = New Point(15, 580)
            .ForeColor = Color.White
            .BackColor = Color.Transparent
            .Text = "0 Kb"
            .Size = New Size(200, 13)
        End With
        Controls.Add(Versiongroesse)
        Versiongroesse.Parent = Me
    End Sub
#End Region

#Region "RTB_Version"
    Private Sub RTB_Version_Erstellen()
        With RTB_Version
            .Location = New Point(490, 82)
            .Size = New Size(298, 358)
            .BackColor = Color.Black
            .ForeColor = Color.White
            .ReadOnly = True
        End With
        Controls.Add(RTB_Version)
        RTB_Version.Parent = Me
    End Sub
#End Region

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
        Application.Exit()
    End Sub
    Private Sub PB_Schliessen_MouseEnter(sender As Object, e As EventArgs)
        PB_Schliessen.Image = My.Resources.button_close_mp
    End Sub

    Private Sub PB_Schliessen_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Schliessen.Parent = Me
        PB_Schliessen.Image = My.Resources.button_close_op
    End Sub
#End Region

#Region "PB_Mini"
    Private Sub PB_Minimieren_Erstellen()
        With PB_Minimieren
            .Location = New Point(740, 4)
            .Size = New Size(Datenbank.Launcher_Windows_Buttons, Datenbank.Launcher_Windows_Buttons)
            .Image = My.Resources.button_minim_op
        End With
        AddHandler PB_Minimieren.Click, AddressOf PB_Minimieren_Click
        AddHandler PB_Minimieren.MouseEnter, AddressOf PB_Minimieren_MouseEnter
        AddHandler PB_Minimieren.MouseLeave, AddressOf PB_Minimieren_MouseLeave
        Controls.Add(PB_Minimieren)
        PB_Minimieren.Parent = Me
    End Sub

    Private Sub PB_Minimieren_Click(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub PB_Minimieren_MouseEnter(sender As Object, e As EventArgs)
        PB_Minimieren.Image = My.Resources.button_minim_mp
    End Sub

    Private Sub PB_Minimieren_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Minimieren.Parent = Me
        PB_Minimieren.Image = My.Resources.button_minim_op
    End Sub
#End Region

#Region "PB_Einstellungen"
    Private Sub PB_Einstellungen_Erstellen()
        With PB_Einstellungen
            .Location = New Point(702, 4)
            .Size = New Size(Datenbank.Launcher_Windows_Buttons, Datenbank.Launcher_Windows_Buttons)
            .Image = My.Resources.button_config_op
        End With
        AddHandler PB_Einstellungen.Click, AddressOf PB_Einstellungen_Click
        AddHandler PB_Einstellungen.MouseEnter, AddressOf PB_Einstellungen_MouseEnter
        AddHandler PB_Einstellungen.MouseLeave, AddressOf PB_Einstellungen_MouseLeave
        Controls.Add(PB_Einstellungen)
        PB_Einstellungen.Parent = Me
    End Sub

    Private Sub PB_Einstellungen_Click(sender As Object, e As EventArgs)
        ' Einstellungen.Show()
    End Sub
    Private Sub PB_Einstellungen_MouseEnter(sender As Object, e As EventArgs)
        PB_Einstellungen.Image = My.Resources.button_config_mp
    End Sub

    Private Sub PB_Einstellungen_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Einstellungen.Parent = Me
        PB_Einstellungen.Image = My.Resources.button_config_op
    End Sub
#End Region

#Region "PB_Facebook"
    Private Sub PB_Facebook_Erstellen()
        With PB_Facebook
            .Location = New Point(686, 48)
            .Size = New Size(Datenbank.Launcher_Social_Media_Buttons, Datenbank.Launcher_Social_Media_Buttons)
            .Image = My.Resources.sbutton_facebook_op
        End With
        AddHandler PB_Facebook.Click, AddressOf PB_Facebook_Click
        AddHandler PB_Facebook.MouseEnter, AddressOf PB_Facebook_MouseEnter
        AddHandler PB_Facebook.MouseLeave, AddressOf PB_Facebook_MouseLeave
        Controls.Add(PB_Facebook)
        PB_Facebook.Parent = Me
    End Sub

    Private Sub PB_Facebook_Click(sender As Object, e As EventArgs)
        Process.Start("www.facebook.com/eXeCutive.Multigaming/")
    End Sub
    Private Sub PB_Facebook_MouseEnter(sender As Object, e As EventArgs)
        PB_Facebook.Image = My.Resources.sbutton_facebook_mp
    End Sub

    Private Sub PB_Facebook_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Facebook.Parent = Me
        PB_Facebook.Image = My.Resources.sbutton_facebook_op
    End Sub
#End Region

#Region "PB_Twitter"
    Private Sub PB_Twitter_Erstellen()
        With PB_Twitter
            .Location = New Point(714, 48)
            .Size = New Size(Datenbank.Launcher_Social_Media_Buttons, Datenbank.Launcher_Social_Media_Buttons)
            .Image = My.Resources.sbutton_twitter_op
        End With
        AddHandler PB_Twitter.Click, AddressOf PB_Twitter_Click
        AddHandler PB_Twitter.MouseEnter, AddressOf PB_Twitter_MouseEnter
        AddHandler PB_Twitter.MouseLeave, AddressOf PB_Twitter_MouseLeave
        Controls.Add(PB_Twitter)
        PB_Twitter.Parent = Me
    End Sub

    Private Sub PB_Twitter_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub PB_Twitter_MouseEnter(sender As Object, e As EventArgs)
        PB_Twitter.Image = My.Resources.sbutton_twitter_mp
    End Sub

    Private Sub PB_Twitter_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Twitter.Parent = Me
        PB_Twitter.Image = My.Resources.sbutton_twitter_op
    End Sub
#End Region

#Region "YouTube"
    Private Sub PB_YouTube_Erstellen()
        With PB_YouTube
            .Location = New Point(742, 48)
            .Size = New Size(Datenbank.Launcher_Social_Media_Buttons, Datenbank.Launcher_Social_Media_Buttons)
            .Image = My.Resources.sbutton_youtube_op
        End With
        AddHandler PB_YouTube.Click, AddressOf PB_YouTube_Click
        AddHandler PB_YouTube.MouseEnter, AddressOf PB_YouTube_MouseEnter
        AddHandler PB_YouTube.MouseLeave, AddressOf PB_YouTube_MouseLeave
        Controls.Add(PB_YouTube)
        PB_YouTube.Parent = Me
    End Sub

    Private Sub PB_YouTube_Click(sender As Object, e As EventArgs)
        Process.Start("www.youtube.com/channel/UCb-7yW2zDFSpDmyPDHClmDw")
    End Sub
    Private Sub PB_YouTube_MouseEnter(sender As Object, e As EventArgs)
        PB_YouTube.Image = My.Resources.sbutton_youtube_mp
    End Sub

    Private Sub PB_YouTube_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_YouTube.Parent = Me
        PB_YouTube.Image = My.Resources.sbutton_youtube_op
    End Sub
#End Region

#Region "PB_Google+"
    Private Sub PB_Google_Plus_Erstellen()
        With PB_Google_Plus
            .Location = New Point(770, 48)
            .Size = New Size(Datenbank.Launcher_Social_Media_Buttons, Datenbank.Launcher_Social_Media_Buttons)
            .Image = My.Resources.sbutton_google_op
        End With
        AddHandler PB_Google_Plus.Click, AddressOf PB_Google_Plus_Click
        AddHandler PB_Google_Plus.MouseEnter, AddressOf PB_Google_Plus_MouseEnter
        AddHandler PB_Google_Plus.MouseLeave, AddressOf PB_Google_Plus_MouseLeave
        Controls.Add(PB_Google_Plus)
        PB_Google_Plus.Parent = Me
    End Sub

    Private Sub PB_Google_Plus_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub PB_Google_Plus_MouseEnter(sender As Object, e As EventArgs)
        PB_Google_Plus.Image = My.Resources.sbutton_google_mp
    End Sub

    Private Sub PB_Google_Plus_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Google_Plus.Parent = Me
        PB_Google_Plus.Image = My.Resources.sbutton_google_op
    End Sub
#End Region

#Region "PB_News"

    Private Sub PB_News_Erstellen()
        'With PB_News
        '    .Location = New Point(488, 80)
        '    .Size = Datenbank.Launcher_News
        '    .BackgroundImage = My.Resources.News_bg
        'End With

        'Controls.Add(PB_News)
        'PB_News.Parent = Me
    End Sub
#End Region

    Private Sub News_Text_Erstellen()
        'With News_Text
        '    .Location = New Point(500, 465)
        '    .ForeColor = Color.White
        '    .BackColor = Color.Transparent
        '    .Text = "585858"
        'End With
        'Controls.Add(News_Text)
        'News_Text.Parent = Me
    End Sub

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
    End Sub
    Private Sub PB_Spiel_Starten_MouseEnter(sender As Object, e As EventArgs)
        PB_Spiel_Starten.Image = My.Resources.button_play_mp
    End Sub

    Private Sub PB_Spiel_Starten_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Spiel_Starten.Parent = Me
        PB_Spiel_Starten.Image = My.Resources.button_play_op
    End Sub
#End Region

End Class