Public Class Heisser_Draht_Level_Menu

    Dim titel As String = Datenbank.Spielwelt_Titel

    Dim G As Graphics
    Dim MyFont = New Font("Arial", 8)
    Dim MyPen = New Pen(Brushes.White, 3)

    Dim PB_LvL_001 As New PictureBox
    Dim PB_LvL_002 As New PictureBox
    Dim PB_LvL_003 As New PictureBox
    Dim PB_LvL_004 As New PictureBox
    Dim PB_LvL_005 As New PictureBox
    Dim PB_LvL_006 As New PictureBox
    Dim PB_LvL_007 As New PictureBox
    Dim PB_LvL_008 As New PictureBox
    Dim PB_LvL_009 As New PictureBox
    Dim PB_LvL_010 As New PictureBox
    Dim PB_LvL_011 As New PictureBox
    Dim PB_LvL_012 As New PictureBox
    Dim PB_LvL_013 As New PictureBox
    Dim PB_LvL_014 As New PictureBox
    Dim PB_LvL_015 As New PictureBox
    Dim PB_LvL_016 As New PictureBox
    Dim PB_LvL_017 As New PictureBox
    Dim PB_LvL_018 As New PictureBox
    Dim PB_LvL_019 As New PictureBox
    Dim PB_LvL_020 As New PictureBox
    Dim PB_LvL_021 As New PictureBox
    Dim PB_LvL_022 As New PictureBox
    Dim PB_LvL_023 As New PictureBox
    Dim PB_LvL_024 As New PictureBox
    Dim PB_LvL_025 As New PictureBox
    Dim PB_LvL_026 As New PictureBox
    Dim PB_LvL_027 As New PictureBox
    Dim PB_LvL_028 As New PictureBox
    Dim PB_LvL_029 As New PictureBox
    Dim PB_LvL_030 As New PictureBox
    Dim PB_LvL_031 As New PictureBox
    Dim PB_LvL_032 As New PictureBox
    Dim PB_LvL_033 As New PictureBox
    Dim PB_LvL_034 As New PictureBox
    Dim PB_LvL_035 As New PictureBox
    Dim PB_LvL_036 As New PictureBox
    Dim PB_LvL_037 As New PictureBox
    Dim PB_LvL_038 As New PictureBox
    Dim PB_LvL_039 As New PictureBox
    Dim PB_LvL_040 As New PictureBox
    Dim PB_LvL_041 As New PictureBox
    Dim PB_LvL_042 As New PictureBox
    Dim PB_LvL_043 As New PictureBox
    Dim PB_LvL_044 As New PictureBox
    Dim PB_LvL_045 As New PictureBox
    Dim PB_LvL_046 As New PictureBox
    Dim PB_LvL_047 As New PictureBox
    Dim PB_LvL_048 As New PictureBox
    Dim PB_LvL_049 As New PictureBox
    Dim PB_LvL_050 As New PictureBox
    Dim PB_LvL_051 As New PictureBox
    Dim PB_LvL_052 As New PictureBox
    Dim PB_LvL_053 As New PictureBox
    Dim PB_LvL_054 As New PictureBox
    Dim PB_LvL_055 As New PictureBox
    Dim PB_LvL_056 As New PictureBox
    Dim PB_LvL_057 As New PictureBox
    Dim PB_LvL_058 As New PictureBox
    Dim PB_LvL_059 As New PictureBox
    Dim PB_LvL_060 As New PictureBox
    Dim PB_LvL_061 As New PictureBox
    Dim PB_LvL_062 As New PictureBox
    Dim PB_LvL_063 As New PictureBox
    Dim PB_LvL_064 As New PictureBox
    Dim PB_LvL_065 As New PictureBox
    Dim PB_LvL_066 As New PictureBox
    Dim PB_LvL_067 As New PictureBox
    Dim PB_LvL_068 As New PictureBox
    Dim PB_LvL_069 As New PictureBox
    Dim PB_LvL_070 As New PictureBox
    Dim PB_LvL_071 As New PictureBox
    Dim PB_LvL_072 As New PictureBox

    Private Sub Level_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        LevelBG()

        'Zeile 1.  Level 1 - 12
        PB_LvL_001_Erstellen()
        PB_LvL_002_Erstellen()
        PB_LvL_003_Erstellen()
        PB_LvL_004_Erstellen()
        PB_LvL_005_Erstellen()
        PB_LvL_006_Erstellen()
        PB_LvL_007_Erstellen()
        PB_LvL_008_Erstellen()
        PB_LvL_009_Erstellen()
        PB_LvL_010_Erstellen()
        PB_LvL_011_Erstellen()
        PB_LvL_012_Erstellen()
        'Zeile 2.  Level 13 - 24
        PB_LvL_013_Erstellen()
        PB_LvL_014_Erstellen()
        PB_LvL_015_Erstellen()
        PB_LvL_016_Erstellen()
        PB_LvL_017_Erstellen()
        PB_LvL_018_Erstellen()
        PB_LvL_019_Erstellen()
        PB_LvL_020_Erstellen()
        PB_LvL_021_Erstellen()
        PB_LvL_022_Erstellen()
        PB_LvL_023_Erstellen()
        PB_LvL_024_Erstellen()
        'Zeile 3.  Level 25 - 36
        PB_LvL_025_Erstellen()
        PB_LvL_026_Erstellen()
        PB_LvL_027_Erstellen()
        PB_LvL_028_Erstellen()
        PB_LvL_029_Erstellen()
        PB_LvL_030_Erstellen()
        PB_LvL_031_Erstellen()
        PB_LvL_032_Erstellen()
        PB_LvL_033_Erstellen()
        PB_LvL_034_Erstellen()
        PB_LvL_035_Erstellen()
        PB_LvL_036_Erstellen()
        'Zeile 4.  Level 37 - 48
        PB_LvL_037_Erstellen()
        PB_LvL_038_Erstellen()
        PB_LvL_039_Erstellen()
        PB_LvL_040_Erstellen()
        PB_LvL_041_Erstellen()
        PB_LvL_042_Erstellen()
        PB_LvL_043_Erstellen()
        PB_LvL_044_Erstellen()
        PB_LvL_045_Erstellen()
        PB_LvL_046_Erstellen()
        PB_LvL_047_Erstellen()
        PB_LvL_048_Erstellen()
        'Zeile 5.  Level 49 - 60
        PB_LvL_049_Erstellen()
        PB_LvL_050_Erstellen()
        PB_LvL_051_Erstellen()
        PB_LvL_052_Erstellen()
        PB_LvL_053_Erstellen()
        PB_LvL_054_Erstellen()
        PB_LvL_055_Erstellen()
        PB_LvL_056_Erstellen()
        PB_LvL_057_Erstellen()
        PB_LvL_058_Erstellen()
        PB_LvL_059_Erstellen()
        PB_LvL_060_Erstellen()
        'Zeile 6.  Level 61 - 72
        PB_LvL_061_Erstellen()
        PB_LvL_062_Erstellen()
        PB_LvL_063_Erstellen()
        PB_LvL_064_Erstellen()
        PB_LvL_065_Erstellen()
        PB_LvL_066_Erstellen()
        PB_LvL_067_Erstellen()
        PB_LvL_068_Erstellen()
        PB_LvL_069_Erstellen()
        PB_LvL_070_Erstellen()
        PB_LvL_071_Erstellen()
        PB_LvL_072_Erstellen()
    End Sub

    Private Sub Debug_Modus()

        If Datenbank.Spiel_Debug_Modus = True Then

        Else

        End If
    End Sub

    Private Sub LevelBG()
        If Heisser_Draht_Level.level_001 = True Then
            PB_LvL_001.BackgroundImage = My.Resources.Level001F
        Else
            PB_LvL_001.BackgroundImage = My.Resources.Level001G
        End If

        If Heisser_Draht_Level.level_002 = True Then
            PB_LvL_002.BackgroundImage = My.Resources.Level002F
        Else
            PB_LvL_002.BackgroundImage = My.Resources.Level002G
        End If

        If Heisser_Draht_Level.level_003 = True Then
            PB_LvL_003.BackgroundImage = My.Resources.Level003F
        Else
            PB_LvL_003.BackgroundImage = My.Resources.Level003G
        End If

        If Heisser_Draht_Level.level_004 = True Then
            PB_LvL_004.BackgroundImage = My.Resources.Level004F
        Else
            PB_LvL_004.BackgroundImage = My.Resources.Level004G
        End If

        If Heisser_Draht_Level.level_005 = True Then
            PB_LvL_005.BackgroundImage = My.Resources.Level005F
        Else
            PB_LvL_005.BackgroundImage = My.Resources.Level005G
        End If

        If Heisser_Draht_Level.level_006 = True Then
            PB_LvL_006.BackgroundImage = My.Resources.Level006F
        Else
            PB_LvL_006.BackgroundImage = My.Resources.Level006G
        End If

        If Heisser_Draht_Level.level_006 = True Then
            PB_LvL_006.BackgroundImage = My.Resources.Level006F
        Else
            PB_LvL_006.BackgroundImage = My.Resources.Level006G
        End If

        If Heisser_Draht_Level.level_007 = True Then
            PB_LvL_007.BackgroundImage = My.Resources.Level007F
        Else
            PB_LvL_007.BackgroundImage = My.Resources.Level007G
        End If

        If Heisser_Draht_Level.level_008 = True Then
            PB_LvL_008.BackgroundImage = My.Resources.Level008F
        Else
            PB_LvL_008.BackgroundImage = My.Resources.Level008G
        End If

        If Heisser_Draht_Level.level_009 = True Then
            PB_LvL_009.BackgroundImage = My.Resources.Level009F
        Else
            PB_LvL_009.BackgroundImage = My.Resources.Level009G
        End If

        If Heisser_Draht_Level.level_010 = True Then
            PB_LvL_010.BackgroundImage = My.Resources.Level010F
        Else
            PB_LvL_010.BackgroundImage = My.Resources.Level010G
        End If

        If Heisser_Draht_Level.level_011 = True Then
            PB_LvL_011.BackgroundImage = My.Resources.Level011F
        Else
            PB_LvL_011.BackgroundImage = My.Resources.Level011G
        End If

        If Heisser_Draht_Level.level_012 = True Then
            PB_LvL_012.BackgroundImage = My.Resources.Level012F
        Else
            PB_LvL_012.BackgroundImage = My.Resources.Level012G
        End If

        If Heisser_Draht_Level.level_013 = True Then
            PB_LvL_013.BackgroundImage = My.Resources.Level013F
        Else
            PB_LvL_013.BackgroundImage = My.Resources.Level013G
        End If

        If Heisser_Draht_Level.level_014 = True Then
            PB_LvL_014.BackgroundImage = My.Resources.Level014F
        Else
            PB_LvL_014.BackgroundImage = My.Resources.Level014G
        End If

        If Heisser_Draht_Level.level_015 = True Then
            PB_LvL_015.BackgroundImage = My.Resources.Level015F
        Else
            PB_LvL_015.BackgroundImage = My.Resources.Level015G
        End If

        If Heisser_Draht_Level.level_016 = True Then
            PB_LvL_016.BackgroundImage = My.Resources.Level016F
        Else
            PB_LvL_016.BackgroundImage = My.Resources.Level016G
        End If

        If Heisser_Draht_Level.level_017 = True Then
            PB_LvL_017.BackgroundImage = My.Resources.Level017F
        Else
            PB_LvL_017.BackgroundImage = My.Resources.Level017G
        End If

        If Heisser_Draht_Level.level_018 = True Then
            PB_LvL_018.BackgroundImage = My.Resources.Level018F
        Else
            PB_LvL_018.BackgroundImage = My.Resources.Level018G
        End If

        If Heisser_Draht_Level.level_019 = True Then
            PB_LvL_019.BackgroundImage = My.Resources.Level019F
        Else
            PB_LvL_019.BackgroundImage = My.Resources.Level019G
        End If

        If Heisser_Draht_Level.level_020 = True Then
            PB_LvL_020.BackgroundImage = My.Resources.Level020F
        Else
            PB_LvL_020.BackgroundImage = My.Resources.Level020G
        End If

        If Heisser_Draht_Level.level_021 = True Then
            PB_LvL_021.BackgroundImage = My.Resources.Level021F
        Else
            PB_LvL_021.BackgroundImage = My.Resources.Level021G
        End If

        If Heisser_Draht_Level.level_022 = True Then
            PB_LvL_022.BackgroundImage = My.Resources.Level022F
        Else
            PB_LvL_022.BackgroundImage = My.Resources.Level022G
        End If

        If Heisser_Draht_Level.level_023 = True Then
            PB_LvL_023.BackgroundImage = My.Resources.Level023F
        Else
            PB_LvL_023.BackgroundImage = My.Resources.Level023G
        End If

        If Heisser_Draht_Level.level_024 = True Then
            PB_LvL_024.BackgroundImage = My.Resources.Level024F
        Else
            PB_LvL_024.BackgroundImage = My.Resources.Level024G
        End If

        If Heisser_Draht_Level.level_025 = True Then
            PB_LvL_025.BackgroundImage = My.Resources.Level025F
        Else
            PB_LvL_025.BackgroundImage = My.Resources.Level025G
        End If

        If Heisser_Draht_Level.level_026 = True Then
            PB_LvL_026.BackgroundImage = My.Resources.Level026F
        Else
            PB_LvL_026.BackgroundImage = My.Resources.Level026G
        End If

        If Heisser_Draht_Level.level_027 = True Then
            PB_LvL_027.BackgroundImage = My.Resources.Level027F
        Else
            PB_LvL_027.BackgroundImage = My.Resources.Level027G
        End If

        If Heisser_Draht_Level.level_028 = True Then
            PB_LvL_028.BackgroundImage = My.Resources.Level028F
        Else
            PB_LvL_028.BackgroundImage = My.Resources.Level028G
        End If

        If Heisser_Draht_Level.level_029 = True Then
            PB_LvL_029.BackgroundImage = My.Resources.Level029F
        Else
            PB_LvL_029.BackgroundImage = My.Resources.Level029G
        End If

        If Heisser_Draht_Level.level_030 = True Then
            PB_LvL_030.BackgroundImage = My.Resources.Level030F
        Else
            PB_LvL_030.BackgroundImage = My.Resources.Level030G
        End If

        If Heisser_Draht_Level.level_031 = True Then
            PB_LvL_031.BackgroundImage = My.Resources.Level031F
        Else
            PB_LvL_031.BackgroundImage = My.Resources.Level031G
        End If

        If Heisser_Draht_Level.level_032 = True Then
            PB_LvL_032.BackgroundImage = My.Resources.Level032F
        Else
            PB_LvL_032.BackgroundImage = My.Resources.Level032G
        End If

        If Heisser_Draht_Level.level_033 = True Then
            PB_LvL_033.BackgroundImage = My.Resources.Level033F
        Else
            PB_LvL_033.BackgroundImage = My.Resources.Level033G
        End If

        If Heisser_Draht_Level.level_034 = True Then
            PB_LvL_034.BackgroundImage = My.Resources.Level034F
        Else
            PB_LvL_034.BackgroundImage = My.Resources.Level034G
        End If

        If Heisser_Draht_Level.level_035 = True Then
            PB_LvL_035.BackgroundImage = My.Resources.Level035F
        Else
            PB_LvL_035.BackgroundImage = My.Resources.Level035G
        End If

        If Heisser_Draht_Level.level_036 = True Then
            PB_LvL_036.BackgroundImage = My.Resources.Level036F
        Else
            PB_LvL_036.BackgroundImage = My.Resources.Level036G
        End If

        If Heisser_Draht_Level.level_037 = True Then
            PB_LvL_037.BackgroundImage = My.Resources.Level037F
        Else
            PB_LvL_037.BackgroundImage = My.Resources.Level037G
        End If

        If Heisser_Draht_Level.level_038 = True Then
            PB_LvL_038.BackgroundImage = My.Resources.Level038F
        Else
            PB_LvL_038.BackgroundImage = My.Resources.Level038G
        End If

        If Heisser_Draht_Level.level_039 = True Then
            PB_LvL_039.BackgroundImage = My.Resources.Level039F
        Else
            PB_LvL_039.BackgroundImage = My.Resources.Level039G
        End If

        If Heisser_Draht_Level.level_040 = True Then
            PB_LvL_040.BackgroundImage = My.Resources.Level040F
        Else
            PB_LvL_040.BackgroundImage = My.Resources.Level040G
        End If

        If Heisser_Draht_Level.level_041 = True Then
            PB_LvL_041.BackgroundImage = My.Resources.Level041F
        Else
            PB_LvL_041.BackgroundImage = My.Resources.Level041G
        End If

        If Heisser_Draht_Level.level_042 = True Then
            PB_LvL_042.BackgroundImage = My.Resources.Level042F
        Else
            PB_LvL_042.BackgroundImage = My.Resources.Level042G
        End If

        If Heisser_Draht_Level.level_043 = True Then
            PB_LvL_043.BackgroundImage = My.Resources.Level043F
        Else
            PB_LvL_043.BackgroundImage = My.Resources.Level043G
        End If

        If Heisser_Draht_Level.level_044 = True Then
            PB_LvL_044.BackgroundImage = My.Resources.Level044F
        Else
            PB_LvL_044.BackgroundImage = My.Resources.Level044G
        End If

        If Heisser_Draht_Level.level_045 = True Then
            PB_LvL_045.BackgroundImage = My.Resources.Level045F
        Else
            PB_LvL_045.BackgroundImage = My.Resources.Level045G
        End If

        If Heisser_Draht_Level.level_046 = True Then
            PB_LvL_046.BackgroundImage = My.Resources.Level046F
        Else
            PB_LvL_046.BackgroundImage = My.Resources.Level046G
        End If

        If Heisser_Draht_Level.level_047 = True Then
            PB_LvL_047.BackgroundImage = My.Resources.Level047F
        Else
            PB_LvL_047.BackgroundImage = My.Resources.Level047G
        End If

        If Heisser_Draht_Level.level_048 = True Then
            PB_LvL_048.BackgroundImage = My.Resources.Level048F
        Else
            PB_LvL_048.BackgroundImage = My.Resources.Level048G
        End If

        If Heisser_Draht_Level.level_049 = True Then
            PB_LvL_049.BackgroundImage = My.Resources.Level049F
        Else
            PB_LvL_049.BackgroundImage = My.Resources.Level049G
        End If

        If Heisser_Draht_Level.level_050 = True Then
            PB_LvL_050.BackgroundImage = My.Resources.Level050F
        Else
            PB_LvL_050.BackgroundImage = My.Resources.Level050G
        End If

        If Heisser_Draht_Level.level_051 = True Then
            PB_LvL_051.BackgroundImage = My.Resources.Level051F
        Else
            PB_LvL_051.BackgroundImage = My.Resources.Level051G
        End If

        If Heisser_Draht_Level.level_052 = True Then
            PB_LvL_052.BackgroundImage = My.Resources.Level052F
        Else
            PB_LvL_052.BackgroundImage = My.Resources.Level052G
        End If

        If Heisser_Draht_Level.level_053 = True Then
            PB_LvL_053.BackgroundImage = My.Resources.Level053F
        Else
            PB_LvL_053.BackgroundImage = My.Resources.Level053G
        End If

        If Heisser_Draht_Level.level_054 = True Then
            PB_LvL_054.BackgroundImage = My.Resources.Level054F
        Else
            PB_LvL_054.BackgroundImage = My.Resources.Level054G
        End If

        If Heisser_Draht_Level.level_055 = True Then
            PB_LvL_055.BackgroundImage = My.Resources.Level055F
        Else
            PB_LvL_055.BackgroundImage = My.Resources.Level055G
        End If

        If Heisser_Draht_Level.level_056 = True Then
            PB_LvL_056.BackgroundImage = My.Resources.Level056F
        Else
            PB_LvL_056.BackgroundImage = My.Resources.Level056G
        End If

        If Heisser_Draht_Level.level_057 = True Then
            PB_LvL_057.BackgroundImage = My.Resources.Level057F
        Else
            PB_LvL_057.BackgroundImage = My.Resources.Level057G
        End If

        If Heisser_Draht_Level.level_058 = True Then
            PB_LvL_058.BackgroundImage = My.Resources.Level058F
        Else
            PB_LvL_058.BackgroundImage = My.Resources.Level058G
        End If

        If Heisser_Draht_Level.level_059 = True Then
            PB_LvL_059.BackgroundImage = My.Resources.Level059F
        Else
            PB_LvL_059.BackgroundImage = My.Resources.Level059G
        End If

        If Heisser_Draht_Level.level_060 = True Then
            PB_LvL_060.BackgroundImage = My.Resources.Level060F
        Else
            PB_LvL_060.BackgroundImage = My.Resources.Level060G
        End If

        If Heisser_Draht_Level.level_061 = True Then
            PB_LvL_061.BackgroundImage = My.Resources.Level061F
        Else
            PB_LvL_061.BackgroundImage = My.Resources.Level061G
        End If

        If Heisser_Draht_Level.level_062 = True Then
            PB_LvL_062.BackgroundImage = My.Resources.Level062F
        Else
            PB_LvL_062.BackgroundImage = My.Resources.Level062G
        End If

        If Heisser_Draht_Level.level_063 = True Then
            PB_LvL_063.BackgroundImage = My.Resources.Level063F
        Else
            PB_LvL_063.BackgroundImage = My.Resources.Level063G
        End If

        If Heisser_Draht_Level.level_064 = True Then
            PB_LvL_064.BackgroundImage = My.Resources.Level064F
        Else
            PB_LvL_064.BackgroundImage = My.Resources.Level064G
        End If

        If Heisser_Draht_Level.level_065 = True Then
            PB_LvL_065.BackgroundImage = My.Resources.Level065F
        Else
            PB_LvL_065.BackgroundImage = My.Resources.Level065G
        End If

        If Heisser_Draht_Level.level_066 = True Then
            PB_LvL_066.BackgroundImage = My.Resources.Level066F
        Else
            PB_LvL_066.BackgroundImage = My.Resources.Level066G
        End If

        If Heisser_Draht_Level.level_067 = True Then
            PB_LvL_067.BackgroundImage = My.Resources.Level067F
        Else
            PB_LvL_067.BackgroundImage = My.Resources.Level067G
        End If

        If Heisser_Draht_Level.level_068 = True Then
            PB_LvL_068.BackgroundImage = My.Resources.Level068F
        Else
            PB_LvL_068.BackgroundImage = My.Resources.Level068G
        End If

        If Heisser_Draht_Level.level_069 = True Then
            PB_LvL_069.BackgroundImage = My.Resources.Level069F
        Else
            PB_LvL_069.BackgroundImage = My.Resources.Level069G
        End If

        If Heisser_Draht_Level.level_070 = True Then
            PB_LvL_070.BackgroundImage = My.Resources.Level070F
        Else
            PB_LvL_070.BackgroundImage = My.Resources.Level070G
        End If

        If Heisser_Draht_Level.level_071 = True Then
            PB_LvL_071.BackgroundImage = My.Resources.Level071F
        Else
            PB_LvL_071.BackgroundImage = My.Resources.Level071G
        End If

        If Heisser_Draht_Level.level_072 = True Then
            PB_LvL_072.BackgroundImage = My.Resources.Level072F
        Else
            PB_LvL_072.BackgroundImage = My.Resources.Level072G
        End If
    End Sub

#Region "PB_LvL_001"
    Private Sub PB_LvL_001_Erstellen()
        With PB_LvL_001
            .Location = New Point(Datenbank.Level_Breite_1_12, Datenbank.Level_Höhe_1_12)
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_001.Click, AddressOf PB_LvL_001_Click
        Controls.Add(PB_LvL_001)
        PB_LvL_001.Parent = Me
    End Sub

    Private Sub PB_LvL_001_Click(sender As Object, e As EventArgs)
        HD_Level1.Show()
        Me.Close()
    End Sub

#End Region

#Region "PB_LvL_002"
    Private Sub PB_LvL_002_Erstellen()
        With PB_LvL_002
            .Location = New Point(Datenbank.Level_Breite_1_12 + (Datenbank.Level_Bild_Größe + Level_PB_Abstand), Datenbank.Level_Höhe_1_12)
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_002.Click, AddressOf PB_LvL_002_Click
        Controls.Add(PB_LvL_002)
        PB_LvL_002.Parent = Me
    End Sub

    Private Sub PB_LvL_002_Click(sender As Object, e As EventArgs)
        If Heisser_Draht_Level.level_002 = True Then
            HD_Level2.Show()
            Me.Close()
        Else

        End If
    End Sub

#End Region

#Region "PB_LvL_003"
    Private Sub PB_LvL_003_Erstellen()
        With PB_LvL_003
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 2), Datenbank.Level_Höhe_1_12)
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_003.Click, AddressOf PB_LvL_003_Click
        Controls.Add(PB_LvL_003)
        PB_LvL_003.Parent = Me
    End Sub

    Private Sub PB_LvL_003_Click(sender As Object, e As EventArgs)
        If Heisser_Draht_Level.level_003 = True Then

        Else

        End If
    End Sub

#End Region

#Region "PB_LvL_004"
    Private Sub PB_LvL_004_Erstellen()
        With PB_LvL_004
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 3), Datenbank.Level_Höhe_1_12)
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_004.Click, AddressOf PB_LvL_004_Click
        Controls.Add(PB_LvL_004)
        PB_LvL_004.Parent = Me
    End Sub

    Private Sub PB_LvL_004_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_005"
    Private Sub PB_LvL_005_Erstellen()
        With PB_LvL_005
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 4), Datenbank.Level_Höhe_1_12)
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_005.Click, AddressOf PB_LvL_005_Click
        Controls.Add(PB_LvL_005)
        PB_LvL_005.Parent = Me
    End Sub

    Private Sub PB_LvL_005_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_006"
    Private Sub PB_LvL_006_Erstellen()
        With PB_LvL_006
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 5), Datenbank.Level_Höhe_1_12)
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_006.Click, AddressOf PB_LvL_006_Click
        Controls.Add(PB_LvL_006)
        PB_LvL_006.Parent = Me
    End Sub

    Private Sub PB_LvL_006_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_007"
    Private Sub PB_LvL_007_Erstellen()
        With PB_LvL_007
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 6), Datenbank.Level_Höhe_1_12)
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_007.Click, AddressOf PB_LvL_007_Click
        Controls.Add(PB_LvL_007)
        PB_LvL_007.Parent = Me
    End Sub

    Private Sub PB_LvL_007_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_008"
    Private Sub PB_LvL_008_Erstellen()
        With PB_LvL_008
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 7), Datenbank.Level_Höhe_1_12)
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_008.Click, AddressOf PB_LvL_008_Click
        Controls.Add(PB_LvL_008)
        PB_LvL_008.Parent = Me
    End Sub

    Private Sub PB_LvL_008_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_009"
    Private Sub PB_LvL_009_Erstellen()
        With PB_LvL_009
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 8), Datenbank.Level_Höhe_1_12)
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_009.Click, AddressOf PB_LvL_009_Click
        Controls.Add(PB_LvL_009)
        PB_LvL_009.Parent = Me
    End Sub

    Private Sub PB_LvL_009_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_010"
    Private Sub PB_LvL_010_Erstellen()
        With PB_LvL_010
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 9), Datenbank.Level_Höhe_1_12)
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_010.Click, AddressOf PB_LvL_010_Click
        Controls.Add(PB_LvL_010)
        PB_LvL_010.Parent = Me
    End Sub

    Private Sub PB_LvL_010_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_011"
    Private Sub PB_LvL_011_Erstellen()
        With PB_LvL_011
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 10), Datenbank.Level_Höhe_1_12)
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_011.Click, AddressOf PB_LvL_011_Click
        Controls.Add(PB_LvL_011)
        PB_LvL_011.Parent = Me
    End Sub

    Private Sub PB_LvL_011_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_012"
    Private Sub PB_LvL_012_Erstellen()
        With PB_LvL_012
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 11), Datenbank.Level_Höhe_1_12)
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_012.Click, AddressOf PB_LvL_012_Click
        Controls.Add(PB_LvL_012)
        PB_LvL_012.Parent = Me
    End Sub

    Private Sub PB_LvL_012_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_013"
    Private Sub PB_LvL_013_Erstellen()
        With PB_LvL_013
            .Location = New Point(Datenbank.Level_Breite_1_12, Datenbank.Level_Höhe_1_12 + (Datenbank.Level_Bild_Größe + Level_PB_Abstand))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_013.Click, AddressOf PB_LvL_013_Click
        Controls.Add(PB_LvL_013)
        PB_LvL_013.Parent = Me
    End Sub

    Private Sub PB_LvL_013_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_014"
    Private Sub PB_LvL_014_Erstellen()
        With PB_LvL_014
            .Location = New Point(Datenbank.Level_Breite_1_12 + (Datenbank.Level_Bild_Größe + Level_PB_Abstand), Datenbank.Level_Höhe_1_12 + (Datenbank.Level_Bild_Größe + Level_PB_Abstand))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_014.Click, AddressOf PB_LvL_014_Click
        Controls.Add(PB_LvL_014)
        PB_LvL_014.Parent = Me
    End Sub

    Private Sub PB_LvL_014_Click(sender As Object, e As EventArgs)

    End Sub
#End Region

#Region "PB_LvL_015"
    Private Sub PB_LvL_015_Erstellen()
        With PB_LvL_015
            .Location = New Point(Datenbank.Level_Breite_1_12 + (Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 2, Datenbank.Level_Höhe_1_12 + (Datenbank.Level_Bild_Größe + Level_PB_Abstand))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_015.Click, AddressOf PB_LvL_015_Click
        Controls.Add(PB_LvL_015)
        PB_LvL_015.Parent = Me
    End Sub

    Private Sub PB_LvL_015_Click(sender As Object, e As EventArgs)

    End Sub
#End Region

#Region "PB_LvL_016"
    Private Sub PB_LvL_016_Erstellen()
        With PB_LvL_016
            .Location = New Point(Datenbank.Level_Breite_1_12 + (Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 3, Datenbank.Level_Höhe_1_12 + (Datenbank.Level_Bild_Größe + Level_PB_Abstand))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_016.Click, AddressOf PB_LvL_016_Click
        Controls.Add(PB_LvL_016)
        PB_LvL_016.Parent = Me
    End Sub

    Private Sub PB_LvL_016_Click(sender As Object, e As EventArgs)

    End Sub
#End Region

#Region "PB_LvL_017"
    Private Sub PB_LvL_017_Erstellen()
        With PB_LvL_017
            .Location = New Point(Datenbank.Level_Breite_1_12 + (Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 4, Datenbank.Level_Höhe_1_12 + (Datenbank.Level_Bild_Größe + Level_PB_Abstand))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_017.Click, AddressOf PB_LvL_017_Click
        Controls.Add(PB_LvL_017)
        PB_LvL_017.Parent = Me
    End Sub

    Private Sub PB_LvL_017_Click(sender As Object, e As EventArgs)

    End Sub
#End Region

#Region "PB_LvL_018"
    Private Sub PB_LvL_018_Erstellen()
        With PB_LvL_018
            .Location = New Point(Datenbank.Level_Breite_1_12 + (Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 5, Datenbank.Level_Höhe_1_12 + (Datenbank.Level_Bild_Größe + Level_PB_Abstand))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_018.Click, AddressOf PB_LvL_018_Click
        Controls.Add(PB_LvL_018)
        PB_LvL_018.Parent = Me
    End Sub

    Private Sub PB_LvL_018_Click(sender As Object, e As EventArgs)

    End Sub
#End Region

#Region "PB_LvL_019"
    Private Sub PB_LvL_019_Erstellen()
        With PB_LvL_019
            .Location = New Point(Datenbank.Level_Breite_1_12 + (Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 6, Datenbank.Level_Höhe_1_12 + (Datenbank.Level_Bild_Größe + Level_PB_Abstand))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_019.Click, AddressOf PB_LvL_019_Click
        Controls.Add(PB_LvL_019)
        PB_LvL_019.Parent = Me
    End Sub

    Private Sub PB_LvL_019_Click(sender As Object, e As EventArgs)

    End Sub
#End Region

#Region "PB_LvL_020"
    Private Sub PB_LvL_020_Erstellen()
        With PB_LvL_020
            .Location = New Point(Datenbank.Level_Breite_1_12 + (Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 7, Datenbank.Level_Höhe_1_12 + (Datenbank.Level_Bild_Größe + Level_PB_Abstand))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_020.Click, AddressOf PB_LvL_020_Click
        Controls.Add(PB_LvL_020)
        PB_LvL_020.Parent = Me
    End Sub

    Private Sub PB_LvL_020_Click(sender As Object, e As EventArgs)

    End Sub
#End Region

#Region "PB_LvL_021"
    Private Sub PB_LvL_021_Erstellen()
        With PB_LvL_021
            .Location = New Point(Datenbank.Level_Breite_1_12 + (Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 8, Datenbank.Level_Höhe_1_12 + (Datenbank.Level_Bild_Größe + Level_PB_Abstand))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_021.Click, AddressOf PB_LvL_021_Click
        Controls.Add(PB_LvL_021)
        PB_LvL_021.Parent = Me
    End Sub

    Private Sub PB_LvL_021_Click(sender As Object, e As EventArgs)

    End Sub
#End Region

#Region "PB_LvL_022"
    Private Sub PB_LvL_022_Erstellen()
        With PB_LvL_022
            .Location = New Point(Datenbank.Level_Breite_1_12 + (Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 9, Datenbank.Level_Höhe_1_12 + (Datenbank.Level_Bild_Größe + Level_PB_Abstand))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_022.Click, AddressOf PB_LvL_022_Click
        Controls.Add(PB_LvL_022)
        PB_LvL_022.Parent = Me
    End Sub

    Private Sub PB_LvL_022_Click(sender As Object, e As EventArgs)

    End Sub
#End Region

#Region "PB_LvL_023"
    Private Sub PB_LvL_023_Erstellen()
        With PB_LvL_023
            .Location = New Point(Datenbank.Level_Breite_1_12 + (Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 10, Datenbank.Level_Höhe_1_12 + (Datenbank.Level_Bild_Größe + Level_PB_Abstand))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_023.Click, AddressOf PB_LvL_023_Click
        Controls.Add(PB_LvL_023)
        PB_LvL_023.Parent = Me
    End Sub

    Private Sub PB_LvL_023_Click(sender As Object, e As EventArgs)

    End Sub
#End Region

#Region "PB_LvL_024"
    Private Sub PB_LvL_024_Erstellen()
        With PB_LvL_024
            .Location = New Point(Datenbank.Level_Breite_1_12 + (Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 11, Datenbank.Level_Höhe_1_12 + (Datenbank.Level_Bild_Größe + Level_PB_Abstand))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_024.Click, AddressOf PB_LvL_024_Click
        Controls.Add(PB_LvL_024)
        PB_LvL_024.Parent = Me
    End Sub

    Private Sub PB_LvL_024_Click(sender As Object, e As EventArgs)

    End Sub
#End Region

#Region "PB_LvL_025"
    Private Sub PB_LvL_025_Erstellen()
        With PB_LvL_025
            .Location = New Point(Datenbank.Level_Breite_1_12, Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 2))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_025.Click, AddressOf PB_LvL_025_Click
        Controls.Add(PB_LvL_025)
        PB_LvL_025.Parent = Me
    End Sub

    Private Sub PB_LvL_025_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_026"
    Private Sub PB_LvL_026_Erstellen()
        With PB_LvL_026
            .Location = New Point(Datenbank.Level_Breite_1_12 + (Datenbank.Level_Bild_Größe + Level_PB_Abstand), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 2))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_026.Click, AddressOf PB_LvL_026_Click
        Controls.Add(PB_LvL_026)
        PB_LvL_026.Parent = Me
    End Sub

    Private Sub PB_LvL_026_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_027"
    Private Sub PB_LvL_027_Erstellen()
        With PB_LvL_027
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 2), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 2))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_027.Click, AddressOf PB_LvL_027_Click
        Controls.Add(PB_LvL_027)
        PB_LvL_027.Parent = Me
    End Sub

    Private Sub PB_LvL_027_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_028"
    Private Sub PB_LvL_028_Erstellen()
        With PB_LvL_028
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 3), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 2))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_028.Click, AddressOf PB_LvL_028_Click
        Controls.Add(PB_LvL_028)
        PB_LvL_028.Parent = Me
    End Sub

    Private Sub PB_LvL_028_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_029"
    Private Sub PB_LvL_029_Erstellen()
        With PB_LvL_029
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 4), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 2))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_029.Click, AddressOf PB_LvL_029_Click
        Controls.Add(PB_LvL_029)
        PB_LvL_029.Parent = Me
    End Sub

    Private Sub PB_LvL_029_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_030"
    Private Sub PB_LvL_030_Erstellen()
        With PB_LvL_030
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 5), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 2))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_030.Click, AddressOf PB_LvL_030_Click
        Controls.Add(PB_LvL_030)
        PB_LvL_030.Parent = Me
    End Sub

    Private Sub PB_LvL_030_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_031"
    Private Sub PB_LvL_031_Erstellen()
        With PB_LvL_031
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 6), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 2))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_031.Click, AddressOf PB_LvL_031_Click
        Controls.Add(PB_LvL_031)
        PB_LvL_031.Parent = Me
    End Sub

    Private Sub PB_LvL_031_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_032"
    Private Sub PB_LvL_032_Erstellen()
        With PB_LvL_032
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 7), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 2))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_032.Click, AddressOf PB_LvL_032_Click
        Controls.Add(PB_LvL_032)
        PB_LvL_032.Parent = Me
    End Sub

    Private Sub PB_LvL_032_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_033"
    Private Sub PB_LvL_033_Erstellen()
        With PB_LvL_033
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 8), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 2))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_033.Click, AddressOf PB_LvL_033_Click
        Controls.Add(PB_LvL_033)
        PB_LvL_033.Parent = Me
    End Sub

    Private Sub PB_LvL_033_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_034"
    Private Sub PB_LvL_034_Erstellen()
        With PB_LvL_034
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 9), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 2))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_034.Click, AddressOf PB_LvL_034_Click
        Controls.Add(PB_LvL_034)
        PB_LvL_034.Parent = Me
    End Sub

    Private Sub PB_LvL_034_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_035"
    Private Sub PB_LvL_035_Erstellen()
        With PB_LvL_035
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 10), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 2))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_035.Click, AddressOf PB_LvL_035_Click
        Controls.Add(PB_LvL_035)
        PB_LvL_035.Parent = Me
    End Sub

    Private Sub PB_LvL_035_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_036"
    Private Sub PB_LvL_036_Erstellen()
        With PB_LvL_036
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 11), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 2))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_036.Click, AddressOf PB_LvL_036_Click
        Controls.Add(PB_LvL_036)
        PB_LvL_036.Parent = Me
    End Sub

    Private Sub PB_LvL_036_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_037"
    Private Sub PB_LvL_037_Erstellen()
        With PB_LvL_037
            .Location = New Point(Datenbank.Level_Breite_1_12, Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 3))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_037.Click, AddressOf PB_LvL_037_Click
        Controls.Add(PB_LvL_037)
        PB_LvL_037.Parent = Me
    End Sub

    Private Sub PB_LvL_037_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_038"
    Private Sub PB_LvL_038_Erstellen()
        With PB_LvL_038
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand)), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 3))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_038.Click, AddressOf PB_LvL_038_Click
        Controls.Add(PB_LvL_038)
        PB_LvL_038.Parent = Me
    End Sub

    Private Sub PB_LvL_038_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_039"
    Private Sub PB_LvL_039_Erstellen()
        With PB_LvL_039
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 2), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 3))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_039.Click, AddressOf PB_LvL_039_Click
        Controls.Add(PB_LvL_039)
        PB_LvL_039.Parent = Me
    End Sub

    Private Sub PB_LvL_039_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_040"
    Private Sub PB_LvL_040_Erstellen()
        With PB_LvL_040
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 3), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 3))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_040.Click, AddressOf PB_LvL_040_Click
        Controls.Add(PB_LvL_040)
        PB_LvL_040.Parent = Me
    End Sub

    Private Sub PB_LvL_040_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_041"
    Private Sub PB_LvL_041_Erstellen()
        With PB_LvL_041
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 4), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 3))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_041.Click, AddressOf PB_LvL_041_Click
        Controls.Add(PB_LvL_041)
        PB_LvL_041.Parent = Me
    End Sub

    Private Sub PB_LvL_041_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_042"
    Private Sub PB_LvL_042_Erstellen()
        With PB_LvL_042
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 5), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 3))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_042.Click, AddressOf PB_LvL_042_Click
        Controls.Add(PB_LvL_042)
        PB_LvL_042.Parent = Me
    End Sub

    Private Sub PB_LvL_042_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_043"
    Private Sub PB_LvL_043_Erstellen()
        With PB_LvL_043
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 6), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 3))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_043.Click, AddressOf PB_LvL_043_Click
        Controls.Add(PB_LvL_043)
        PB_LvL_043.Parent = Me
    End Sub

    Private Sub PB_LvL_043_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_044"
    Private Sub PB_LvL_044_Erstellen()
        With PB_LvL_044
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 7), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 3))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_044.Click, AddressOf PB_LvL_044_Click
        Controls.Add(PB_LvL_044)
        PB_LvL_044.Parent = Me
    End Sub

    Private Sub PB_LvL_044_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_045"
    Private Sub PB_LvL_045_Erstellen()
        With PB_LvL_045
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 8), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 3))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_045.Click, AddressOf PB_LvL_045_Click
        Controls.Add(PB_LvL_045)
        PB_LvL_045.Parent = Me
    End Sub

    Private Sub PB_LvL_045_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_046"
    Private Sub PB_LvL_046_Erstellen()
        With PB_LvL_046
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 9), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 3))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_046.Click, AddressOf PB_LvL_046_Click
        Controls.Add(PB_LvL_046)
        PB_LvL_046.Parent = Me
    End Sub

    Private Sub PB_LvL_046_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_047"
    Private Sub PB_LvL_047_Erstellen()
        With PB_LvL_047
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 10), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 3))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_047.Click, AddressOf PB_LvL_047_Click
        Controls.Add(PB_LvL_047)
        PB_LvL_047.Parent = Me
    End Sub

    Private Sub PB_LvL_047_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_048"
    Private Sub PB_LvL_048_Erstellen()
        With PB_LvL_048
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 11), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 3))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_048.Click, AddressOf PB_LvL_048_Click
        Controls.Add(PB_LvL_048)
        PB_LvL_048.Parent = Me
    End Sub

    Private Sub PB_LvL_048_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_049"
    Private Sub PB_LvL_049_Erstellen()
        With PB_LvL_049
            .Location = New Point(Datenbank.Level_Breite_1_12, Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 4))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_049.Click, AddressOf PB_LvL_049_Click
        Controls.Add(PB_LvL_049)
        PB_LvL_049.Parent = Me
    End Sub

    Private Sub PB_LvL_049_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_050"
    Private Sub PB_LvL_050_Erstellen()
        With PB_LvL_050
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand)), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 4))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_050.Click, AddressOf PB_LvL_050_Click
        Controls.Add(PB_LvL_050)
        PB_LvL_050.Parent = Me
    End Sub

    Private Sub PB_LvL_050_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_051"
    Private Sub PB_LvL_051_Erstellen()
        With PB_LvL_051
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 2), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 4))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_051.Click, AddressOf PB_LvL_051_Click
        Controls.Add(PB_LvL_051)
        PB_LvL_051.Parent = Me
    End Sub

    Private Sub PB_LvL_051_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_052"
    Private Sub PB_LvL_052_Erstellen()
        With PB_LvL_052
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 3), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 4))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_052.Click, AddressOf PB_LvL_052_Click
        Controls.Add(PB_LvL_052)
        PB_LvL_052.Parent = Me
    End Sub

    Private Sub PB_LvL_052_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_053"
    Private Sub PB_LvL_053_Erstellen()
        With PB_LvL_053
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 4), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 4))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_053.Click, AddressOf PB_LvL_053_Click
        Controls.Add(PB_LvL_053)
        PB_LvL_053.Parent = Me
    End Sub

    Private Sub PB_LvL_053_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_054"
    Private Sub PB_LvL_054_Erstellen()
        With PB_LvL_054
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 5), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 4))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_054.Click, AddressOf PB_LvL_054_Click
        Controls.Add(PB_LvL_054)
        PB_LvL_054.Parent = Me
    End Sub

    Private Sub PB_LvL_054_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_055"
    Private Sub PB_LvL_055_Erstellen()
        With PB_LvL_055
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 6), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 4))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_055.Click, AddressOf PB_LvL_055_Click
        Controls.Add(PB_LvL_055)
        PB_LvL_055.Parent = Me
    End Sub

    Private Sub PB_LvL_055_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_056"
    Private Sub PB_LvL_056_Erstellen()
        With PB_LvL_056
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 7), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 4))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_056.Click, AddressOf PB_LvL_056_Click
        Controls.Add(PB_LvL_056)
        PB_LvL_056.Parent = Me
    End Sub

    Private Sub PB_LvL_056_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_057"
    Private Sub PB_LvL_057_Erstellen()
        With PB_LvL_057
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 8), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 4))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_057.Click, AddressOf PB_LvL_057_Click
        Controls.Add(PB_LvL_057)
        PB_LvL_057.Parent = Me
    End Sub

    Private Sub PB_LvL_057_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_058"
    Private Sub PB_LvL_058_Erstellen()
        With PB_LvL_058
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 9), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 4))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_058.Click, AddressOf PB_LvL_058_Click
        Controls.Add(PB_LvL_058)
        PB_LvL_058.Parent = Me
    End Sub

    Private Sub PB_LvL_058_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_059"
    Private Sub PB_LvL_059_Erstellen()
        With PB_LvL_059
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 10), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 4))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_059.Click, AddressOf PB_LvL_059_Click
        Controls.Add(PB_LvL_059)
        PB_LvL_059.Parent = Me
    End Sub

    Private Sub PB_LvL_059_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_060"
    Private Sub PB_LvL_060_Erstellen()
        With PB_LvL_060
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 11), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 4))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_060.Click, AddressOf PB_LvL_060_Click
        Controls.Add(PB_LvL_060)
        PB_LvL_060.Parent = Me
    End Sub

    Private Sub PB_LvL_060_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_061"
    Private Sub PB_LvL_061_Erstellen()
        With PB_LvL_061
            .Location = New Point(Datenbank.Level_Breite_1_12, Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 5))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_061.Click, AddressOf PB_LvL_061_Click
        Controls.Add(PB_LvL_061)
        PB_LvL_061.Parent = Me
    End Sub

    Private Sub PB_LvL_061_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_062"
    Private Sub PB_LvL_062_Erstellen()
        With PB_LvL_062
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand)), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 5))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_062.Click, AddressOf PB_LvL_062_Click
        Controls.Add(PB_LvL_062)
        PB_LvL_062.Parent = Me
    End Sub

    Private Sub PB_LvL_062_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_063"
    Private Sub PB_LvL_063_Erstellen()
        With PB_LvL_063
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 2), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 5))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_063.Click, AddressOf PB_LvL_063_Click
        Controls.Add(PB_LvL_063)
        PB_LvL_063.Parent = Me
    End Sub

    Private Sub PB_LvL_063_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_064"
    Private Sub PB_LvL_064_Erstellen()
        With PB_LvL_064
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 3), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 5))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_064.Click, AddressOf PB_LvL_064_Click
        Controls.Add(PB_LvL_064)
        PB_LvL_064.Parent = Me
    End Sub

    Private Sub PB_LvL_064_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_065"
    Private Sub PB_LvL_065_Erstellen()
        With PB_LvL_065
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 4), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 5))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_065.Click, AddressOf PB_LvL_065_Click
        Controls.Add(PB_LvL_065)
        PB_LvL_065.Parent = Me
    End Sub

    Private Sub PB_LvL_065_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_066"
    Private Sub PB_LvL_066_Erstellen()
        With PB_LvL_066
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 5), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 5))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_066.Click, AddressOf PB_LvL_066_Click
        Controls.Add(PB_LvL_066)
        PB_LvL_066.Parent = Me
    End Sub

    Private Sub PB_LvL_066_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_067"
    Private Sub PB_LvL_067_Erstellen()
        With PB_LvL_067
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 6), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 5))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_067.Click, AddressOf PB_LvL_067_Click
        Controls.Add(PB_LvL_067)
        PB_LvL_067.Parent = Me
    End Sub

    Private Sub PB_LvL_067_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_068"
    Private Sub PB_LvL_068_Erstellen()
        With PB_LvL_068
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 7), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 5))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_068.Click, AddressOf PB_LvL_068_Click
        Controls.Add(PB_LvL_068)
        PB_LvL_068.Parent = Me
    End Sub

    Private Sub PB_LvL_068_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_069"
    Private Sub PB_LvL_069_Erstellen()
        With PB_LvL_069
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 8), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 5))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_069.Click, AddressOf PB_LvL_069_Click
        Controls.Add(PB_LvL_069)
        PB_LvL_069.Parent = Me
    End Sub

    Private Sub PB_LvL_069_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_070"
    Private Sub PB_LvL_070_Erstellen()
        With PB_LvL_070
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 9), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 5))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_070.Click, AddressOf PB_LvL_070_Click
        Controls.Add(PB_LvL_070)
        PB_LvL_070.Parent = Me
    End Sub

    Private Sub PB_LvL_070_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_071"
    Private Sub PB_LvL_071_Erstellen()
        With PB_LvL_071
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 10), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 5))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_071.Click, AddressOf PB_LvL_071_Click
        Controls.Add(PB_LvL_071)
        PB_LvL_071.Parent = Me
    End Sub

    Private Sub PB_LvL_071_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_LvL_072"
    Private Sub PB_LvL_072_Erstellen()
        With PB_LvL_072
            .Location = New Point(Datenbank.Level_Breite_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 11), Datenbank.Level_Höhe_1_12 + ((Datenbank.Level_Bild_Größe + Level_PB_Abstand) * 5))
            .Size = New Size(Datenbank.Level_Bild_Größe, Datenbank.Level_Bild_Größe)
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler PB_LvL_072.Click, AddressOf PB_LvL_072_Click
        Controls.Add(PB_LvL_072)
        PB_LvL_072.Parent = Me
    End Sub

    Private Sub PB_LvL_072_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

End Class