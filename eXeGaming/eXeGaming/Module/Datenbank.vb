Module Datenbank 'Dies ist die Datenbank des Spiels

    'Spiel Einstellungen
    Public Spiel_Name As String = "eXeGaming"
    Public Spiel_Inhaber As String = "David Hilberath"
    Public Spiel_Coder As String = "David Hilberath"
    Public Spiel_Email As String = "info@Gaming-Newspaper.de"
    Public Spiel_Webseite As String = "https://executive-clan.de"
    Public Spiel_Pfad As String = "C:\"
    Public Spiel_Pfad_Spiel As String = "\" & Datenbank.Spiel_Name & "\"
    Public Spiel_Version As String = String.Format("Version {0}.{1: 00}", My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
    Public Spiel_Version_Status As String = "Alpha" 'Alpha | Beta | Release
    Public Spiel_Debug_Modus As Boolean = False
    Public Spiel_Vollbild As Boolean = False
    Public Spiel_Fenstervollbild As Boolean = True
    Public Spiel_Fenster As Boolean = False
    Public Spiel_FensterModus As String = "" 'Volldbild | Vollbild-Fenster | Fenster
    Public Spiel_AutoUpdate As Boolean = True
    Public Spiel_Musik_Modus As Boolean = False

    'Launcher Einstellungen
    Public Launcher_Titel As String = Datenbank.Spiel_Name & " - Launcher"
    Public Launcher_Breite As Integer = 800
    Public Launcher_Höhe As Integer = 600
    Public Launcher_Hintergrundgrafik = My.Resources.Launcher
    Public Launcher_Hintergrundfarbe As Color = Color.Orange
    Public Launcher_Schriftfarbe As Color = Color.White
    Public Launcher_Musik_Modus As Boolean = False
    Public Launcher_Titel_Song As String = "Launcher_Title_Screen"
    Public Launcher_Windows_Buttons As Integer = 22
    Public Launcher_Social_Media_Buttons As Integer = 19
    Public Launcher_News = New Size(302, 416)
    Public Launcher_Spiel_Starten = New Size(139, 52)
    Public Launcher_Zurueck = New Size(139, 52)

    'Spiel-Menü Einstellungen
    Public Spielmenu_Titel As String = Datenbank.Spiel_Name & " - Spielmenu"
    Public Spielmenu_Breite As Integer = 1920
    Public Spielmenu_Höhe As Integer = 1080
    Public Spielmenu_Hintergrundfarbe As Color = Color.Orange
    Public Spielmenu_Schriftfarbe As Color = Color.Black
    Public Spielmenu_Titel_Song As String = "Spiele_Titel_Song"
    Public Spielmenu_Button = New Size(480, 80)
    Public Spielmenu_Buttonabstand As Integer = 5
    Public Spielmenu_Buttonhoehe As Integer = 80

    'Spiel Auswahl
    Public Spielauswahl_Breite As Integer = 1920
    Public Spielauswahl_Höhe As Integer = 1080
    Public Spielauswahl_Bild_Größe As Integer = 128
    Public Spielauswahl_Breite_1_12 As Integer = (Datenbank.Spielauswahl_Breite / 10) / 3
    Public Spielauswahl_Höhe_1_12 As Integer = (Datenbank.Spielauswahl_Höhe / 10) / 3
    Public Spielauswahl_PB_Abstand As Integer = 25

    'Spiel Einstellungen
    Public Spielwelt_Titel As String = Datenbank.Spiel_Name & " - Ingame"
    Public Spielwelt_Breite As Integer = 1920
    Public Spielwelt_Höhe As Integer = 1080
    Public Spielwelt_Hintergrundfarbe As Color = Color.LightBlue
    Public Spielwelt_Schriftfarbe As Color = Color.Black
    Public Spielwelt_Titel_Song As String = "Spiele_Titel_Song"

    'Spiel Auswahl
    Public Spielauswahl_Titel As String = Datenbank.Spiel_Name & " - Auswahl"

    'Level Einstellungen
    Public Level_Breite As Integer = 1920
    Public Level_Höhe As Integer = 1080
    Public Level_Hintergrundfarbe As Color = Color.LightSkyBlue
    Public Level_Schriftfarbe As Color = Color.Black
    Public Level_Titel_Song As String = "Level_Titel_Song"
    Public Level_Bild_Größe As Integer = 112
    Public Level_Breite_1_12 As Integer = (Datenbank.Level_Breite / 10) / 3
    Public Level_Höhe_1_12 As Integer = (Datenbank.Level_Höhe / 10) / 3
    Public Level_PB_Abstand As Integer = 25
    Public Maus_Back_Breite As Integer = 1727
    Public Maus_Back_höhe As Integer = 166
    Public Balkenfarbe As Image = My.Resources.heisser_draht_textur




    'Setting Einstellungen
    Public Einstellungen_Titel As String = Datenbank.Spiel_Name & " - Einstellungen"
    Public Einstellungen_Breite As Integer = 800
    Public Einstellungen_Höhe As Integer = 600
    Public Einstellungen_Hintergrundgrafik = My.Resources.Einstellungen
    Public Einstellungen_Hintergrundfarbe As Color = Launcher_Hintergrundfarbe
    Public Einstellungen_Schriftfarbe As Color = Launcher_Schriftfarbe

    'Spieler Einstellungen
    Public Spieler_Name As String = Environment.UserName
    Public Spieler_Passwort As String = Nothing
    Public Spieler_Geld As Integer = 0
    Public Spieler_Gold As Integer = 0
    Public Spieler_Ep As Integer = 0
    Public Spieler_Ep_next_Level As Integer = 10
    Public Spieler_Level As Integer = 1

    Public Spieler_Größe As Integer = 32
    Public Spieler_Grafikname As String = "Spielfigur1-"
    Public Spieler_Leben As Double = 100.0
    Public Spieler_MaxLeben As Double = 100.0
    Public Spieler_Schild As Double = 100.0
    Public Spieler_MaxSchild As Double = 100.0
    Public Spieler_Energie As Double = 100.0
    Public Spieler_MaxEnergie As Double = 100.0
    Public Spieler_Hunger As Double = 100.0
    Public Spieler_MaxHunger As Double = 100.0
    Public Spieler_Durst As Double = 100.0
    Public Spieler_MaxDurst As Double = 100.0
    Public Spieler_Schaden As Double = 1.0
    Public Spieler_Geschwindigkeit As Double = 1.0

    ' Public Spieler Reset
    Public Sub reset_Spieler()
        Spieler_Name = Environment.UserName
        Spieler_Passwort = Nothing
        Spieler_Geld = 0
        Spieler_Ep = 0
        Spieler_Level = 1
    End Sub

End Module