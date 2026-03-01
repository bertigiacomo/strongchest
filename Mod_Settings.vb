Imports Newtonsoft.Json

Module SettingsConf

    Public Settings As New UserSettings

    Public Class UserSettings

        'Definisce se Strongchest è stato configurato o meno
        Property IsSetUp As Boolean = False
        'Definisce se Strongchest deve chiedere la conferma password
        Property FirstAccess As Boolean = False
        'Definisce il tema di Strongchest
        Property LightTheme As Boolean = False
        'Definisce la dimensione della finestra
        Property AppSize As Size = New Size(0, 0)
        'Definisce se i log devono essere cifrati
        'Property EncryptLogs As Boolean = False
        'Definisce lo spazio limite che Strongchest può usare
        Property SpaceLimitMB As Integer = 0


    End Class

    Public Class Configs
        Public Shared Sub SaveConfig()

            'Salva dati delle impostazioni utente
            Dim jsonScriptSettings As String = JsonConvert.SerializeObject(Settings, Formatting.Indented)
            IO.File.WriteAllText(Paths.AppData & "settings.json", jsonScriptSettings)

        End Sub

        Private Shared Sub LoadSettings()

            'Carica dati delle impostazioni utente
            Dim stringSettings = IO.File.ReadAllText(Paths.AppData & "settings.json")
            Settings = JsonConvert.DeserializeObject(Of UserSettings)(stringSettings)

        End Sub

        Public Shared Sub ResetSettings()

            'Pulisci dati delle impostazioni utente
            Dim clearSettings As New UserSettings
            Dim jsonScriptSettings As String = JsonConvert.SerializeObject(clearSettings, Formatting.Indented)
            IO.File.WriteAllText(Paths.AppData & "settings.json", jsonScriptSettings)

            'Ricarica impostazioni i fogli delle impostazioni
            LoadSettings()

        End Sub

        Public Shared Sub InizializeSettings()

            'Verifica se le impostazioni esistono
            If Not IO.Directory.Exists(Paths.AppData) Then IO.Directory.CreateDirectory(Paths.AppData)
            If Not IO.File.Exists(Paths.AppData & "settings.json") Then
                SaveConfig()
            End If

            'Crea impostazioni se sono errate
            Try
                LoadSettings()
            Catch
                ResetSettings()
                Application.Restart()
            End Try


        End Sub
    End Class

    Public Class ApplicationConstants

        'Infomazioni eseguibile
        Public Const AppVersion = "2.1.0.0"
        Public Const AppBuild = 2020
        Public Const AppDisplayVersion = "2.1"
        Public Const StorageVersion = 1

        'Link utili
        Public Const VendorURL = "https://giacomo-berti.me"


    End Class
End Module
