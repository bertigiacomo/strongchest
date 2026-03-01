Public Class ManangeSpace

    Public Shared Limits As New Dictionary(Of Integer, Integer)
    Public Shared PublicLimit As Integer

    Private Sub CloseForm_Click(sender As Object, e As EventArgs) Handles CloseForm.Click

        'Avverti l'utente se il limite di dati che stà cercando di impostare è troppo alto
        Dim filesData As Decimal = Math.Round(Convert.ToInt32(GetFolderSize(Paths.UserData) / 1000000))
        If (Limits.Item(LimitBar.Value) < filesData) And LimitBar.Value <> 0 Then
            AdviseBox("Limite dati troppo basso. Prova ad alzare il limite muovendo lo slider.")
            Exit Sub
        End If

        'Aggiorna dati
        Settings.SpaceLimitMB = LimitBar.Value
        Configs.SaveConfig()

        'Chiudi
        Close()

    End Sub

    Private Sub Form_ManageSpace_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Carica valore
        LimitBar.Value = Settings.SpaceLimitMB

        'Dichiarazioni
        tmrLimiterConfig.Start()

        'Calcola categorie di dati
        Dim filesData As Decimal = Math.Round(Convert.ToInt32(GetFolderSize(Paths.UserData) / 1000000))
        Dim totalData As Decimal = Math.Round(Convert.ToInt32(GetFolderSize(Paths.AppData) / 1000000) + Convert.ToInt32(GetFolderSize(Paths.LocalData) / 1000000))
        Dim appSizeData As Decimal = totalData - filesData
        Dim freeDiskSpace = Math.Round(My.Computer.FileSystem.Drives.Item(0).AvailableFreeSpace / 1000000)

        'Stampa valori in GB, o MB in base alla quantità di dati
        lblUserUse.Text = "Utilizzo utente: " & If(filesData >= 1000, Convert.ToInt32(filesData \ 1000) & "GB", Convert.ToInt32(filesData) & "MB") & " (Quantità di file)"
        lblAppUse.Text = "Utilizzo applicazione: " & If(appSizeData >= 1000, Convert.ToInt32(appSizeData \ 1000) & "GB", Convert.ToInt32(appSizeData) & "MB") & " (Aggiornamenti e altro)"
        lblFreeSpace.Text = "Spazio libero: " & If(freeDiskSpace >= 1000, Convert.ToInt32(freeDiskSpace \ 1000) & "GB", Convert.ToInt32(freeDiskSpace) & "MB") & " (In tutto il disco)"

        'Se è impostato un limite, mostra sul grafico la quantità di dati prima della fine del limite, altrimenti l'utilizzo del disco
        If Settings.SpaceLimitMB = 0 Then
            Dim usePercentage As Decimal = (totalData * 100) / freeDiskSpace
            Dim usePercentageInteger As Integer = Convert.ToInt32(usePercentage)
            CircularGraph.Value = usePercentageInteger
        Else
            Dim usePercentage As Decimal = (totalData * 100) / Limits.Item(Settings.SpaceLimitMB)
            Dim usePercentageInteger As Integer = Convert.ToInt32(usePercentage)
            CircularGraph.Value = usePercentageInteger
        End If

    End Sub

    Sub TmrLimiterConfig_Tick(sender As Object, e As EventArgs) Handles tmrLimiterConfig.Tick
        If LimitBar.Value <> 0 Then

            Dim Current

            If Limits.Item(LimitBar.Value) >= 1000 Then
                Current = Limits.Item(LimitBar.Value) \ 1000
                If Current >= 1000 Then
                    Current = Current \ 1000 & "TB"
                Else
                    Current &= "GB"
                End If
            Else
                Current = Limits.Item(LimitBar.Value) & "MB"
            End If

            Dim filesData = Convert.ToInt32(GetFolderSize(Paths.UserData) / 1000000)
            Dim usePercentage As Integer = Convert.ToInt32(filesData * 100) / Limits.Item(LimitBar.Value)

            PublicLimit = usePercentage

            If usePercentage > 90 Then
                lblLimitSet.Text = "Limite di " & Current & " troppo basso"
            Else
                lblLimitSet.Text = "Limite attuale: " & Current & " (utilizzato al " & usePercentage & "%)"
            End If
        Else
            lblLimitSet.Text = "Nessun limite impostato (trascina lo slider)"
        End If

    End Sub

    Public Shared Sub DeclareDic()

        Limits.Add(0, 0)
        Limits.Add(1, 20)
        Limits.Add(2, 50)
        Limits.Add(3, 100)
        Limits.Add(4, 150)
        Limits.Add(5, 180)
        Limits.Add(6, 200)
        Limits.Add(7, 250)
        Limits.Add(8, 300)
        Limits.Add(9, 350)
        Limits.Add(10, 400)
        Limits.Add(11, 450)
        Limits.Add(12, 500)
        Limits.Add(13, 600)
        Limits.Add(14, 700)
        Limits.Add(15, 750)
        Limits.Add(16, 800)
        Limits.Add(17, 900)
        Limits.Add(18, 1000)
        Limits.Add(19, 1100)
        Limits.Add(20, 1200)
        Limits.Add(21, 1300)
        Limits.Add(22, 1400)
        Limits.Add(23, 1500)
        Limits.Add(24, 1750)
        Limits.Add(25, 2000)
        Limits.Add(26, 2250)
        Limits.Add(27, 2500)
        Limits.Add(28, 2750)
        Limits.Add(29, 3000)
        Limits.Add(30, 3250)
        Limits.Add(31, 3500)
        Limits.Add(32, 3750)
        Limits.Add(33, 4000)
        Limits.Add(34, 4250)
        Limits.Add(35, 4500)
        Limits.Add(36, 4750)
        Limits.Add(37, 5000)
        Limits.Add(38, 5250)
        Limits.Add(39, 5500)
        Limits.Add(40, 5750)
        Limits.Add(41, 6000)
        Limits.Add(42, 6250)
        Limits.Add(43, 6500)
        Limits.Add(44, 7000)
        Limits.Add(45, 7500)
        Limits.Add(46, 8000)
        Limits.Add(47, 8500)
        Limits.Add(48, 9000)
        Limits.Add(49, 9500)
        Limits.Add(50, 10000)
        Limits.Add(51, 11000)
        Limits.Add(52, 12000)
        Limits.Add(53, 13000)
        Limits.Add(54, 14000)
        Limits.Add(55, 15000)
        Limits.Add(56, 16000)
        Limits.Add(57, 17000)
        Limits.Add(58, 18000)
        Limits.Add(59, 19000)
        Limits.Add(60, 20000)
        Limits.Add(61, 21000)
        Limits.Add(62, 22000)
        Limits.Add(63, 23000)
        Limits.Add(64, 24000)
        Limits.Add(65, 25000)
        Limits.Add(66, 26000)
        Limits.Add(67, 27000)
        Limits.Add(68, 28000)
        Limits.Add(69, 29000)
        Limits.Add(70, 30000)
        Limits.Add(71, 32500)
        Limits.Add(72, 35000)
        Limits.Add(73, 37500)
        Limits.Add(74, 40000)
        Limits.Add(75, 42500)
        Limits.Add(76, 45000)
        Limits.Add(77, 47500)
        Limits.Add(78, 50000)
        Limits.Add(79, 52500)
        Limits.Add(80, 55000)
        Limits.Add(81, 60000)
        Limits.Add(82, 65000)
        Limits.Add(83, 70000)
        Limits.Add(84, 75000)
        Limits.Add(85, 80000)
        Limits.Add(86, 85000)
        Limits.Add(87, 90000)
        Limits.Add(88, 95000)
        Limits.Add(89, 100000)
        Limits.Add(90, 110000)
        Limits.Add(91, 120000)
        Limits.Add(92, 130000)
        Limits.Add(93, 140000)
        Limits.Add(94, 150000)
        Limits.Add(95, 200000)
        Limits.Add(96, 300000)
        Limits.Add(97, 400000)
        Limits.Add(98, 500000)
        Limits.Add(99, 1000000)
        Limits.Add(100, 10000000)




    End Sub
End Class