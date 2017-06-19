Public Class Spiel_Auswahl

    Dim titel As String = Datenbank.Spielwelt_Titel

    Dim G As Graphics
    Dim MyFont = New Font("Arial", 8)
    Dim MyPen = New Pen(Brushes.White, 3)

    Dim PB_Spiel_001 As New PictureBox
    Dim PB_Spiel_002 As New PictureBox
    Dim PB_Spiel_003 As New PictureBox
    Dim PB_Spiel_004 As New PictureBox
    Dim PB_Spiel_005 As New PictureBox
    Dim PB_Spiel_006 As New PictureBox
    Dim PB_Spiel_007 As New PictureBox
    Dim PB_Spiel_008 As New PictureBox
    Dim PB_Spiel_009 As New PictureBox
    Dim PB_Spiel_010 As New PictureBox
    Dim PB_Spiel_011 As New PictureBox
    Dim PB_Spiel_012 As New PictureBox
    Dim PB_Spiel_013 As New PictureBox
    Dim PB_Spiel_014 As New PictureBox
    Dim PB_Spiel_015 As New PictureBox
    Dim PB_Spiel_016 As New PictureBox
    Dim PB_Spiel_017 As New PictureBox
    Dim PB_Spiel_018 As New PictureBox
    Dim PB_Spiel_019 As New PictureBox
    Dim PB_Spiel_020 As New PictureBox
    Dim PB_Spiel_021 As New PictureBox
    Dim PB_Spiel_022 As New PictureBox
    Dim PB_Spiel_023 As New PictureBox
    Dim PB_Spiel_024 As New PictureBox
    Dim PB_Spiel_025 As New PictureBox
    Dim PB_Spiel_026 As New PictureBox
    Dim PB_Spiel_027 As New PictureBox
    Dim PB_Spiel_028 As New PictureBox
    Dim PB_Spiel_029 As New PictureBox
    Dim PB_Spiel_030 As New PictureBox
    Dim PB_Spiel_031 As New PictureBox
    Dim PB_Spiel_032 As New PictureBox
    Dim PB_Spiel_033 As New PictureBox
    Dim PB_Spiel_034 As New PictureBox
    Dim PB_Spiel_035 As New PictureBox
    Dim PB_Spiel_036 As New PictureBox
    Dim PB_Spiel_037 As New PictureBox
    Dim PB_Spiel_038 As New PictureBox
    Dim PB_Spiel_039 As New PictureBox
    Dim PB_Spiel_040 As New PictureBox
    Dim PB_Spiel_041 As New PictureBox
    Dim PB_Spiel_042 As New PictureBox
    Dim PB_Spiel_043 As New PictureBox
    Dim PB_Spiel_044 As New PictureBox
    Dim PB_Spiel_045 As New PictureBox
    Dim PB_Spiel_046 As New PictureBox
    Dim PB_Spiel_047 As New PictureBox
    Dim PB_Spiel_048 As New PictureBox
    Dim PB_Spiel_049 As New PictureBox
    Dim PB_Spiel_050 As New PictureBox
    Dim PB_Spiel_051 As New PictureBox
    Dim PB_Spiel_052 As New PictureBox
    Dim PB_Spiel_053 As New PictureBox
    Dim PB_Spiel_054 As New PictureBox
    Dim PB_Spiel_055 As New PictureBox
    Dim PB_Spiel_056 As New PictureBox
    Dim PB_Spiel_057 As New PictureBox
    Dim PB_Spiel_058 As New PictureBox
    Dim PB_Spiel_059 As New PictureBox
    Dim PB_Spiel_060 As New PictureBox
    Dim PB_Spiel_061 As New PictureBox
    Dim PB_Spiel_062 As New PictureBox
    Dim PB_Spiel_063 As New PictureBox
    Dim PB_Spiel_064 As New PictureBox
    Dim PB_Spiel_065 As New PictureBox
    Dim PB_Spiel_066 As New PictureBox
    Dim PB_Spiel_067 As New PictureBox
    Dim PB_Spiel_068 As New PictureBox
    Dim PB_Spiel_069 As New PictureBox
    Dim PB_Spiel_070 As New PictureBox
    Dim PB_Spiel_071 As New PictureBox
    Dim PB_Spiel_072 As New PictureBox

    Dim Text_01 As New Label

    Private Sub Spiel_Auswahl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Spielauswahl_BG()

        'Zeile 1.  Spielauswahl 1 - 12
        PB_Spiel_001_Erstellen()
        PB_Spiel_002_Erstellen()
        PB_Spiel_003_Erstellen()
        PB_Spiel_004_Erstellen()
        PB_Spiel_005_Erstellen()
        PB_Spiel_006_Erstellen()
        PB_Spiel_007_Erstellen()
        PB_Spiel_008_Erstellen()
        PB_Spiel_009_Erstellen()
        PB_Spiel_010_Erstellen()
        PB_Spiel_011_Erstellen()
        PB_Spiel_012_Erstellen()
        'Zeile 2.  Spielauswahl 13 - 24
        PB_Spiel_013_Erstellen()
        PB_Spiel_014_Erstellen()
        PB_Spiel_015_Erstellen()
        PB_Spiel_016_Erstellen()
        PB_Spiel_017_Erstellen()
        PB_Spiel_018_Erstellen()
        PB_Spiel_019_Erstellen()
        PB_Spiel_020_Erstellen()
        PB_Spiel_021_Erstellen()
        PB_Spiel_022_Erstellen()
        PB_Spiel_023_Erstellen()
        PB_Spiel_024_Erstellen()
        'Zeile 3.  Spielauswahl 25 - 36
        PB_Spiel_025_Erstellen()
        PB_Spiel_026_Erstellen()
        PB_Spiel_027_Erstellen()
        PB_Spiel_028_Erstellen()
        PB_Spiel_029_Erstellen()
        PB_Spiel_030_Erstellen()
        PB_Spiel_031_Erstellen()
        PB_Spiel_032_Erstellen()
        PB_Spiel_033_Erstellen()
        PB_Spiel_034_Erstellen()
        PB_Spiel_035_Erstellen()
        PB_Spiel_036_Erstellen()
        'Zeile 4.  Spielauswahl 37 - 48
        PB_Spiel_037_Erstellen()
        PB_Spiel_038_Erstellen()
        PB_Spiel_039_Erstellen()
        PB_Spiel_040_Erstellen()
        PB_Spiel_041_Erstellen()
        PB_Spiel_042_Erstellen()
        PB_Spiel_043_Erstellen()
        PB_Spiel_044_Erstellen()
        PB_Spiel_045_Erstellen()
        PB_Spiel_046_Erstellen()
        PB_Spiel_047_Erstellen()
        PB_Spiel_048_Erstellen()
        'Zeile 5.  Spielauswahl 49 - 60
        PB_Spiel_049_Erstellen()
        PB_Spiel_050_Erstellen()
        PB_Spiel_051_Erstellen()
        PB_Spiel_052_Erstellen()
        PB_Spiel_053_Erstellen()
        PB_Spiel_054_Erstellen()
        PB_Spiel_055_Erstellen()
        PB_Spiel_056_Erstellen()
        PB_Spiel_057_Erstellen()
        PB_Spiel_058_Erstellen()
        PB_Spiel_059_Erstellen()
        PB_Spiel_060_Erstellen()
        'Zeile 6.  Spielauswahl 61 - 72
        PB_Spiel_061_Erstellen()
        PB_Spiel_062_Erstellen()
        PB_Spiel_063_Erstellen()
        PB_Spiel_064_Erstellen()
        PB_Spiel_065_Erstellen()
        PB_Spiel_066_Erstellen()
        PB_Spiel_067_Erstellen()
        PB_Spiel_068_Erstellen()
        PB_Spiel_069_Erstellen()
        PB_Spiel_070_Erstellen()
        PB_Spiel_071_Erstellen()
        PB_Spiel_072_Erstellen()
        Text_01_Erstellen()
    End Sub

    Private Sub Debug_Modus()

        If Datenbank.Spiel_Debug_Modus = True Then

        Else

        End If
    End Sub

    Private Sub Text_01_Erstellen()
        With Text_01
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 12), Datenbank.Spielauswahl_Höhe_1_12)
            .Text = "Event-Start"
            .Font = New Font("Tahoma", 10, FontStyle.Bold Or FontStyle.Italic)
        End With
        Controls.Add(Text_01)
        Text_01.Parent = Me
    End Sub


    Private Sub Spielauswahl_BG()

        PB_Spiel_001.BackgroundImage = My.Resources.Heißer_Draht
        PB_Spiel_002.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_003.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_004.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_005.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_006.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_007.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_008.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_009.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_010.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_011.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_012.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_013.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_014.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_015.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_016.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_017.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_018.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_019.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_020.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_021.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_022.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_023.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_024.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_025.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_026.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_027.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_028.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_029.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_030.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_031.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_032.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_033.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_034.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_035.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_036.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_037.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_038.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_039.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_040.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_041.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_042.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_043.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_044.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_045.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_046.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_047.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_048.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_049.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_050.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_051.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_052.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_053.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_054.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_055.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_056.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_057.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_058.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_059.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_060.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_061.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_062.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_063.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_064.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_065.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_066.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_067.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_068.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_069.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_070.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_071.BackgroundImage = My.Resources.Spielplatzhalter
        PB_Spiel_072.BackgroundImage = My.Resources.Spielplatzhalter

    End Sub

#Region "PB_Spiel_001"
    Private Sub PB_Spiel_001_Erstellen()
        With PB_Spiel_001
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12, Datenbank.Spielauswahl_Höhe_1_12)
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_001.Click, AddressOf PB_Spiel_001_Click
        Controls.Add(PB_Spiel_001)
        PB_Spiel_001.Parent = Me
    End Sub

    Private Sub PB_Spiel_001_Click(sender As Object, e As EventArgs)
        Heisser_Draht_Level_Menu.Show()
        Me.Close()
    End Sub

#End Region

#Region "PB_Spiel_002"
    Private Sub PB_Spiel_002_Erstellen()
        With PB_Spiel_002
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + (Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand), Datenbank.Spielauswahl_Höhe_1_12)
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_002.Click, AddressOf PB_Spiel_002_Click
        Controls.Add(PB_Spiel_002)
        PB_Spiel_002.Parent = Me
    End Sub

    Private Sub PB_Spiel_002_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_003"
    Private Sub PB_Spiel_003_Erstellen()
        With PB_Spiel_003
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 2), Datenbank.Spielauswahl_Höhe_1_12)
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_003.Click, AddressOf PB_Spiel_003_Click
        Controls.Add(PB_Spiel_003)
        PB_Spiel_003.Parent = Me
    End Sub

    Private Sub PB_Spiel_003_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_004"
    Private Sub PB_Spiel_004_Erstellen()
        With PB_Spiel_004
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 3), Datenbank.Spielauswahl_Höhe_1_12)
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_004.Click, AddressOf PB_Spiel_004_Click
        Controls.Add(PB_Spiel_004)
        PB_Spiel_004.Parent = Me
    End Sub

    Private Sub PB_Spiel_004_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_005"
    Private Sub PB_Spiel_005_Erstellen()
        With PB_Spiel_005
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 4), Datenbank.Spielauswahl_Höhe_1_12)
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_005.Click, AddressOf PB_Spiel_005_Click
        Controls.Add(PB_Spiel_005)
        PB_Spiel_005.Parent = Me
    End Sub

    Private Sub PB_Spiel_005_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_006"
    Private Sub PB_Spiel_006_Erstellen()
        With PB_Spiel_006
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 5), Datenbank.Spielauswahl_Höhe_1_12)
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_006.Click, AddressOf PB_Spiel_006_Click
        Controls.Add(PB_Spiel_006)
        PB_Spiel_006.Parent = Me
    End Sub

    Private Sub PB_Spiel_006_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_007"
    Private Sub PB_Spiel_007_Erstellen()
        With PB_Spiel_007
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 6), Datenbank.Spielauswahl_Höhe_1_12)
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_007.Click, AddressOf PB_Spiel_007_Click
        Controls.Add(PB_Spiel_007)
        PB_Spiel_007.Parent = Me
    End Sub

    Private Sub PB_Spiel_007_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_008"
    Private Sub PB_Spiel_008_Erstellen()
        With PB_Spiel_008
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 7), Datenbank.Spielauswahl_Höhe_1_12)
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_008.Click, AddressOf PB_Spiel_008_Click
        Controls.Add(PB_Spiel_008)
        PB_Spiel_008.Parent = Me
    End Sub

    Private Sub PB_Spiel_008_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_009"
    Private Sub PB_Spiel_009_Erstellen()
        With PB_Spiel_009
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 8), Datenbank.Spielauswahl_Höhe_1_12)
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_009.Click, AddressOf PB_Spiel_009_Click
        Controls.Add(PB_Spiel_009)
        PB_Spiel_009.Parent = Me
    End Sub

    Private Sub PB_Spiel_009_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_010"
    Private Sub PB_Spiel_010_Erstellen()
        With PB_Spiel_010
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 9), Datenbank.Spielauswahl_Höhe_1_12)
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_010.Click, AddressOf PB_Spiel_010_Click
        Controls.Add(PB_Spiel_010)
        PB_Spiel_010.Parent = Me
    End Sub

    Private Sub PB_Spiel_010_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_011"
    Private Sub PB_Spiel_011_Erstellen()
        With PB_Spiel_011
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 10), Datenbank.Spielauswahl_Höhe_1_12)
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_011.Click, AddressOf PB_Spiel_011_Click
        Controls.Add(PB_Spiel_011)
        PB_Spiel_011.Parent = Me
    End Sub

    Private Sub PB_Spiel_011_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_012"
    Private Sub PB_Spiel_012_Erstellen()
        With PB_Spiel_012
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 11), Datenbank.Spielauswahl_Höhe_1_12)
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_012.Click, AddressOf PB_Spiel_012_Click
        Controls.Add(PB_Spiel_012)
        PB_Spiel_012.Parent = Me
    End Sub

    Private Sub PB_Spiel_012_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_013"
    Private Sub PB_Spiel_013_Erstellen()
        With PB_Spiel_013
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12, Datenbank.Spielauswahl_Höhe_1_12 + (Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_013.Click, AddressOf PB_Spiel_013_Click
        Controls.Add(PB_Spiel_013)
        PB_Spiel_013.Parent = Me
    End Sub

    Private Sub PB_Spiel_013_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_014"
    Private Sub PB_Spiel_014_Erstellen()
        With PB_Spiel_014
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + (Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand), Datenbank.Spielauswahl_Höhe_1_12 + (Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_014.Click, AddressOf PB_Spiel_014_Click
        Controls.Add(PB_Spiel_014)
        PB_Spiel_014.Parent = Me
    End Sub

    Private Sub PB_Spiel_014_Click(sender As Object, e As EventArgs)

    End Sub
#End Region

#Region "PB_Spiel_015"
    Private Sub PB_Spiel_015_Erstellen()
        With PB_Spiel_015
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + (Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 2, Datenbank.Spielauswahl_Höhe_1_12 + (Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_015.Click, AddressOf PB_Spiel_015_Click
        Controls.Add(PB_Spiel_015)
        PB_Spiel_015.Parent = Me
    End Sub

    Private Sub PB_Spiel_015_Click(sender As Object, e As EventArgs)

    End Sub
#End Region

#Region "PB_Spiel_016"
    Private Sub PB_Spiel_016_Erstellen()
        With PB_Spiel_016
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + (Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 3, Datenbank.Spielauswahl_Höhe_1_12 + (Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_016.Click, AddressOf PB_Spiel_016_Click
        Controls.Add(PB_Spiel_016)
        PB_Spiel_016.Parent = Me
    End Sub

    Private Sub PB_Spiel_016_Click(sender As Object, e As EventArgs)

    End Sub
#End Region

#Region "PB_Spiel_017"
    Private Sub PB_Spiel_017_Erstellen()
        With PB_Spiel_017
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + (Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 4, Datenbank.Spielauswahl_Höhe_1_12 + (Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_017.Click, AddressOf PB_Spiel_017_Click
        Controls.Add(PB_Spiel_017)
        PB_Spiel_017.Parent = Me
    End Sub

    Private Sub PB_Spiel_017_Click(sender As Object, e As EventArgs)

    End Sub
#End Region

#Region "PB_Spiel_018"
    Private Sub PB_Spiel_018_Erstellen()
        With PB_Spiel_018
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + (Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 5, Datenbank.Spielauswahl_Höhe_1_12 + (Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_018.Click, AddressOf PB_Spiel_018_Click
        Controls.Add(PB_Spiel_018)
        PB_Spiel_018.Parent = Me
    End Sub

    Private Sub PB_Spiel_018_Click(sender As Object, e As EventArgs)

    End Sub
#End Region

#Region "PB_Spiel_019"
    Private Sub PB_Spiel_019_Erstellen()
        With PB_Spiel_019
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + (Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 6, Datenbank.Spielauswahl_Höhe_1_12 + (Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_019.Click, AddressOf PB_Spiel_019_Click
        Controls.Add(PB_Spiel_019)
        PB_Spiel_019.Parent = Me
    End Sub

    Private Sub PB_Spiel_019_Click(sender As Object, e As EventArgs)

    End Sub
#End Region

#Region "PB_Spiel_020"
    Private Sub PB_Spiel_020_Erstellen()
        With PB_Spiel_020
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + (Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 7, Datenbank.Spielauswahl_Höhe_1_12 + (Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_020.Click, AddressOf PB_Spiel_020_Click
        Controls.Add(PB_Spiel_020)
        PB_Spiel_020.Parent = Me
    End Sub

    Private Sub PB_Spiel_020_Click(sender As Object, e As EventArgs)

    End Sub
#End Region

#Region "PB_Spiel_021"
    Private Sub PB_Spiel_021_Erstellen()
        With PB_Spiel_021
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + (Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 8, Datenbank.Spielauswahl_Höhe_1_12 + (Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_021.Click, AddressOf PB_Spiel_021_Click
        Controls.Add(PB_Spiel_021)
        PB_Spiel_021.Parent = Me
    End Sub

    Private Sub PB_Spiel_021_Click(sender As Object, e As EventArgs)

    End Sub
#End Region

#Region "PB_Spiel_022"
    Private Sub PB_Spiel_022_Erstellen()
        With PB_Spiel_022
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + (Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 9, Datenbank.Spielauswahl_Höhe_1_12 + (Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_022.Click, AddressOf PB_Spiel_022_Click
        Controls.Add(PB_Spiel_022)
        PB_Spiel_022.Parent = Me
    End Sub

    Private Sub PB_Spiel_022_Click(sender As Object, e As EventArgs)

    End Sub
#End Region

#Region "PB_Spiel_023"
    Private Sub PB_Spiel_023_Erstellen()
        With PB_Spiel_023
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + (Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 10, Datenbank.Spielauswahl_Höhe_1_12 + (Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_023.Click, AddressOf PB_Spiel_023_Click
        Controls.Add(PB_Spiel_023)
        PB_Spiel_023.Parent = Me
    End Sub

    Private Sub PB_Spiel_023_Click(sender As Object, e As EventArgs)

    End Sub
#End Region

#Region "PB_Spiel_024"
    Private Sub PB_Spiel_024_Erstellen()
        With PB_Spiel_024
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + (Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 11, Datenbank.Spielauswahl_Höhe_1_12 + (Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_024.Click, AddressOf PB_Spiel_024_Click
        Controls.Add(PB_Spiel_024)
        PB_Spiel_024.Parent = Me
    End Sub

    Private Sub PB_Spiel_024_Click(sender As Object, e As EventArgs)

    End Sub
#End Region

#Region "PB_Spiel_025"
    Private Sub PB_Spiel_025_Erstellen()
        With PB_Spiel_025
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12, Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 2))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_025.Click, AddressOf PB_Spiel_025_Click
        Controls.Add(PB_Spiel_025)
        PB_Spiel_025.Parent = Me
    End Sub

    Private Sub PB_Spiel_025_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_026"
    Private Sub PB_Spiel_026_Erstellen()
        With PB_Spiel_026
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + (Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 2))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_026.Click, AddressOf PB_Spiel_026_Click
        Controls.Add(PB_Spiel_026)
        PB_Spiel_026.Parent = Me
    End Sub

    Private Sub PB_Spiel_026_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_027"
    Private Sub PB_Spiel_027_Erstellen()
        With PB_Spiel_027
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 2), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 2))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_027.Click, AddressOf PB_Spiel_027_Click
        Controls.Add(PB_Spiel_027)
        PB_Spiel_027.Parent = Me
    End Sub

    Private Sub PB_Spiel_027_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_028"
    Private Sub PB_Spiel_028_Erstellen()
        With PB_Spiel_028
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 3), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 2))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_028.Click, AddressOf PB_Spiel_028_Click
        Controls.Add(PB_Spiel_028)
        PB_Spiel_028.Parent = Me
    End Sub

    Private Sub PB_Spiel_028_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_029"
    Private Sub PB_Spiel_029_Erstellen()
        With PB_Spiel_029
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 4), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 2))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_029.Click, AddressOf PB_Spiel_029_Click
        Controls.Add(PB_Spiel_029)
        PB_Spiel_029.Parent = Me
    End Sub

    Private Sub PB_Spiel_029_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_030"
    Private Sub PB_Spiel_030_Erstellen()
        With PB_Spiel_030
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 5), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 2))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_030.Click, AddressOf PB_Spiel_030_Click
        Controls.Add(PB_Spiel_030)
        PB_Spiel_030.Parent = Me
    End Sub

    Private Sub PB_Spiel_030_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_031"
    Private Sub PB_Spiel_031_Erstellen()
        With PB_Spiel_031
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 6), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 2))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_031.Click, AddressOf PB_Spiel_031_Click
        Controls.Add(PB_Spiel_031)
        PB_Spiel_031.Parent = Me
    End Sub

    Private Sub PB_Spiel_031_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_032"
    Private Sub PB_Spiel_032_Erstellen()
        With PB_Spiel_032
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 7), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 2))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_032.Click, AddressOf PB_Spiel_032_Click
        Controls.Add(PB_Spiel_032)
        PB_Spiel_032.Parent = Me
    End Sub

    Private Sub PB_Spiel_032_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_033"
    Private Sub PB_Spiel_033_Erstellen()
        With PB_Spiel_033
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 8), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 2))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_033.Click, AddressOf PB_Spiel_033_Click
        Controls.Add(PB_Spiel_033)
        PB_Spiel_033.Parent = Me
    End Sub

    Private Sub PB_Spiel_033_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_034"
    Private Sub PB_Spiel_034_Erstellen()
        With PB_Spiel_034
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 9), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 2))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_034.Click, AddressOf PB_Spiel_034_Click
        Controls.Add(PB_Spiel_034)
        PB_Spiel_034.Parent = Me
    End Sub

    Private Sub PB_Spiel_034_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_035"
    Private Sub PB_Spiel_035_Erstellen()
        With PB_Spiel_035
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 10), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 2))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_035.Click, AddressOf PB_Spiel_035_Click
        Controls.Add(PB_Spiel_035)
        PB_Spiel_035.Parent = Me
    End Sub

    Private Sub PB_Spiel_035_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_036"
    Private Sub PB_Spiel_036_Erstellen()
        With PB_Spiel_036
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 11), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 2))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_036.Click, AddressOf PB_Spiel_036_Click
        Controls.Add(PB_Spiel_036)
        PB_Spiel_036.Parent = Me
    End Sub

    Private Sub PB_Spiel_036_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_037"
    Private Sub PB_Spiel_037_Erstellen()
        With PB_Spiel_037
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12, Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 3))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_037.Click, AddressOf PB_Spiel_037_Click
        Controls.Add(PB_Spiel_037)
        PB_Spiel_037.Parent = Me
    End Sub

    Private Sub PB_Spiel_037_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_038"
    Private Sub PB_Spiel_038_Erstellen()
        With PB_Spiel_038
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand)), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 3))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_038.Click, AddressOf PB_Spiel_038_Click
        Controls.Add(PB_Spiel_038)
        PB_Spiel_038.Parent = Me
    End Sub

    Private Sub PB_Spiel_038_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_039"
    Private Sub PB_Spiel_039_Erstellen()
        With PB_Spiel_039
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 2), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 3))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_039.Click, AddressOf PB_Spiel_039_Click
        Controls.Add(PB_Spiel_039)
        PB_Spiel_039.Parent = Me
    End Sub

    Private Sub PB_Spiel_039_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_040"
    Private Sub PB_Spiel_040_Erstellen()
        With PB_Spiel_040
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 3), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 3))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_040.Click, AddressOf PB_Spiel_040_Click
        Controls.Add(PB_Spiel_040)
        PB_Spiel_040.Parent = Me
    End Sub

    Private Sub PB_Spiel_040_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_041"
    Private Sub PB_Spiel_041_Erstellen()
        With PB_Spiel_041
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 4), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 3))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_041.Click, AddressOf PB_Spiel_041_Click
        Controls.Add(PB_Spiel_041)
        PB_Spiel_041.Parent = Me
    End Sub

    Private Sub PB_Spiel_041_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_042"
    Private Sub PB_Spiel_042_Erstellen()
        With PB_Spiel_042
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 5), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 3))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_042.Click, AddressOf PB_Spiel_042_Click
        Controls.Add(PB_Spiel_042)
        PB_Spiel_042.Parent = Me
    End Sub

    Private Sub PB_Spiel_042_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_043"
    Private Sub PB_Spiel_043_Erstellen()
        With PB_Spiel_043
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 6), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 3))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_043.Click, AddressOf PB_Spiel_043_Click
        Controls.Add(PB_Spiel_043)
        PB_Spiel_043.Parent = Me
    End Sub

    Private Sub PB_Spiel_043_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_044"
    Private Sub PB_Spiel_044_Erstellen()
        With PB_Spiel_044
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 7), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 3))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_044.Click, AddressOf PB_Spiel_044_Click
        Controls.Add(PB_Spiel_044)
        PB_Spiel_044.Parent = Me
    End Sub

    Private Sub PB_Spiel_044_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_045"
    Private Sub PB_Spiel_045_Erstellen()
        With PB_Spiel_045
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 8), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 3))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_045.Click, AddressOf PB_Spiel_045_Click
        Controls.Add(PB_Spiel_045)
        PB_Spiel_045.Parent = Me
    End Sub

    Private Sub PB_Spiel_045_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_046"
    Private Sub PB_Spiel_046_Erstellen()
        With PB_Spiel_046
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 9), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 3))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_046.Click, AddressOf PB_Spiel_046_Click
        Controls.Add(PB_Spiel_046)
        PB_Spiel_046.Parent = Me
    End Sub

    Private Sub PB_Spiel_046_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_047"
    Private Sub PB_Spiel_047_Erstellen()
        With PB_Spiel_047
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 10), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 3))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_047.Click, AddressOf PB_Spiel_047_Click
        Controls.Add(PB_Spiel_047)
        PB_Spiel_047.Parent = Me
    End Sub

    Private Sub PB_Spiel_047_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_048"
    Private Sub PB_Spiel_048_Erstellen()
        With PB_Spiel_048
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 11), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 3))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_048.Click, AddressOf PB_Spiel_048_Click
        Controls.Add(PB_Spiel_048)
        PB_Spiel_048.Parent = Me
    End Sub

    Private Sub PB_Spiel_048_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_049"
    Private Sub PB_Spiel_049_Erstellen()
        With PB_Spiel_049
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12, Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 4))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_049.Click, AddressOf PB_Spiel_049_Click
        Controls.Add(PB_Spiel_049)
        PB_Spiel_049.Parent = Me
    End Sub

    Private Sub PB_Spiel_049_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_050"
    Private Sub PB_Spiel_050_Erstellen()
        With PB_Spiel_050
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand)), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 4))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_050.Click, AddressOf PB_Spiel_050_Click
        Controls.Add(PB_Spiel_050)
        PB_Spiel_050.Parent = Me
    End Sub

    Private Sub PB_Spiel_050_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_051"
    Private Sub PB_Spiel_051_Erstellen()
        With PB_Spiel_051
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 2), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 4))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_051.Click, AddressOf PB_Spiel_051_Click
        Controls.Add(PB_Spiel_051)
        PB_Spiel_051.Parent = Me
    End Sub

    Private Sub PB_Spiel_051_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_052"
    Private Sub PB_Spiel_052_Erstellen()
        With PB_Spiel_052
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 3), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 4))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_052.Click, AddressOf PB_Spiel_052_Click
        Controls.Add(PB_Spiel_052)
        PB_Spiel_052.Parent = Me
    End Sub

    Private Sub PB_Spiel_052_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_053"
    Private Sub PB_Spiel_053_Erstellen()
        With PB_Spiel_053
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 4), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 4))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_053.Click, AddressOf PB_Spiel_053_Click
        Controls.Add(PB_Spiel_053)
        PB_Spiel_053.Parent = Me
    End Sub

    Private Sub PB_Spiel_053_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_054"
    Private Sub PB_Spiel_054_Erstellen()
        With PB_Spiel_054
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 5), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 4))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_054.Click, AddressOf PB_Spiel_054_Click
        Controls.Add(PB_Spiel_054)
        PB_Spiel_054.Parent = Me
    End Sub

    Private Sub PB_Spiel_054_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_055"
    Private Sub PB_Spiel_055_Erstellen()
        With PB_Spiel_055
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 6), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 4))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_055.Click, AddressOf PB_Spiel_055_Click
        Controls.Add(PB_Spiel_055)
        PB_Spiel_055.Parent = Me
    End Sub

    Private Sub PB_Spiel_055_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_056"
    Private Sub PB_Spiel_056_Erstellen()
        With PB_Spiel_056
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 7), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 4))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_056.Click, AddressOf PB_Spiel_056_Click
        Controls.Add(PB_Spiel_056)
        PB_Spiel_056.Parent = Me
    End Sub

    Private Sub PB_Spiel_056_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_057"
    Private Sub PB_Spiel_057_Erstellen()
        With PB_Spiel_057
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 8), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 4))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_057.Click, AddressOf PB_Spiel_057_Click
        Controls.Add(PB_Spiel_057)
        PB_Spiel_057.Parent = Me
    End Sub

    Private Sub PB_Spiel_057_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_058"
    Private Sub PB_Spiel_058_Erstellen()
        With PB_Spiel_058
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 9), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 4))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_058.Click, AddressOf PB_Spiel_058_Click
        Controls.Add(PB_Spiel_058)
        PB_Spiel_058.Parent = Me
    End Sub

    Private Sub PB_Spiel_058_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_059"
    Private Sub PB_Spiel_059_Erstellen()
        With PB_Spiel_059
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 10), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 4))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_059.Click, AddressOf PB_Spiel_059_Click
        Controls.Add(PB_Spiel_059)
        PB_Spiel_059.Parent = Me
    End Sub

    Private Sub PB_Spiel_059_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_060"
    Private Sub PB_Spiel_060_Erstellen()
        With PB_Spiel_060
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 11), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 4))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_060.Click, AddressOf PB_Spiel_060_Click
        Controls.Add(PB_Spiel_060)
        PB_Spiel_060.Parent = Me
    End Sub

    Private Sub PB_Spiel_060_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_061"
    Private Sub PB_Spiel_061_Erstellen()
        With PB_Spiel_061
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12, Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 5))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_061.Click, AddressOf PB_Spiel_061_Click
        Controls.Add(PB_Spiel_061)
        PB_Spiel_061.Parent = Me
    End Sub

    Private Sub PB_Spiel_061_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_062"
    Private Sub PB_Spiel_062_Erstellen()
        With PB_Spiel_062
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand)), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 5))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_062.Click, AddressOf PB_Spiel_062_Click
        Controls.Add(PB_Spiel_062)
        PB_Spiel_062.Parent = Me
    End Sub

    Private Sub PB_Spiel_062_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_063"
    Private Sub PB_Spiel_063_Erstellen()
        With PB_Spiel_063
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 2), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 5))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_063.Click, AddressOf PB_Spiel_063_Click
        Controls.Add(PB_Spiel_063)
        PB_Spiel_063.Parent = Me
    End Sub

    Private Sub PB_Spiel_063_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_064"
    Private Sub PB_Spiel_064_Erstellen()
        With PB_Spiel_064
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 3), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 5))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_064.Click, AddressOf PB_Spiel_064_Click
        Controls.Add(PB_Spiel_064)
        PB_Spiel_064.Parent = Me
    End Sub

    Private Sub PB_Spiel_064_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_065"
    Private Sub PB_Spiel_065_Erstellen()
        With PB_Spiel_065
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 4), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 5))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_065.Click, AddressOf PB_Spiel_065_Click
        Controls.Add(PB_Spiel_065)
        PB_Spiel_065.Parent = Me
    End Sub

    Private Sub PB_Spiel_065_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_066"
    Private Sub PB_Spiel_066_Erstellen()
        With PB_Spiel_066
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 5), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 5))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_066.Click, AddressOf PB_Spiel_066_Click
        Controls.Add(PB_Spiel_066)
        PB_Spiel_066.Parent = Me
    End Sub

    Private Sub PB_Spiel_066_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_067"
    Private Sub PB_Spiel_067_Erstellen()
        With PB_Spiel_067
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 6), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 5))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_067.Click, AddressOf PB_Spiel_067_Click
        Controls.Add(PB_Spiel_067)
        PB_Spiel_067.Parent = Me
    End Sub

    Private Sub PB_Spiel_067_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_068"
    Private Sub PB_Spiel_068_Erstellen()
        With PB_Spiel_068
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 7), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 5))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_068.Click, AddressOf PB_Spiel_068_Click
        Controls.Add(PB_Spiel_068)
        PB_Spiel_068.Parent = Me
    End Sub

    Private Sub PB_Spiel_068_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_069"
    Private Sub PB_Spiel_069_Erstellen()
        With PB_Spiel_069
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 8), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 5))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_069.Click, AddressOf PB_Spiel_069_Click
        Controls.Add(PB_Spiel_069)
        PB_Spiel_069.Parent = Me
    End Sub

    Private Sub PB_Spiel_069_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_070"
    Private Sub PB_Spiel_070_Erstellen()
        With PB_Spiel_070
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 9), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 5))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_070.Click, AddressOf PB_Spiel_070_Click
        Controls.Add(PB_Spiel_070)
        PB_Spiel_070.Parent = Me
    End Sub

    Private Sub PB_Spiel_070_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_071"
    Private Sub PB_Spiel_071_Erstellen()
        With PB_Spiel_071
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 10), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 5))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_071.Click, AddressOf PB_Spiel_071_Click
        Controls.Add(PB_Spiel_071)
        PB_Spiel_071.Parent = Me
    End Sub

    Private Sub PB_Spiel_071_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spiel_072"
    Private Sub PB_Spiel_072_Erstellen()
        With PB_Spiel_072
            .Location = New Point(Datenbank.Spielauswahl_Breite_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 11), Datenbank.Spielauswahl_Höhe_1_12 + ((Datenbank.Spielauswahl_Bild_Größe + Spielauswahl_PB_Abstand) * 5))
            .Size = New Size(Datenbank.Spielauswahl_Bild_Größe, Datenbank.Spielauswahl_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_Spiel_072.Click, AddressOf PB_Spiel_072_Click
        Controls.Add(PB_Spiel_072)
        PB_Spiel_072.Parent = Me
    End Sub

    Private Sub PB_Spiel_072_Click(sender As Object, e As EventArgs)

    End Sub
#End Region

End Class