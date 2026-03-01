Imports Newtonsoft.Json

Module CompanyConfig

    Public Business As New BusinessProfile


    Public Class BusinessProfile

        'Definisce se il profilo aziendale è attivo o meno
        Property Enabled As Boolean = False
        'Definisce il nome della "business company" che controlla le funzioni di Strongchest
        Property DisplayName As String = ""
        'Definisce il sito web del vendor del profilo "business company"
        Property BusinessURL As String = ""
        'Definisce se gli aggiornamenti sono abilitati o meno
        Property UpdatesEnabled As Boolean = True


    End Class

    Public Class Company
        Public Shared Sub SaveConfig()

            'Salva dati delle impostazioni aziendali
            Dim jsonScriptBusiness As String = JsonConvert.SerializeObject(Business, Formatting.Indented)
            IO.File.WriteAllText(Paths.CompanyData & "company_profile.json", jsonScriptBusiness)

        End Sub

        Private Shared Sub LoadSettings()

            'Carica dati impostazioni aziendali
            Dim stringBusiness = IO.File.ReadAllText(Paths.CompanyData & "company_profile.json")
            Business = JsonConvert.DeserializeObject(Of BusinessProfile)(stringBusiness)


        End Sub

        Public Shared Sub ResetSettings()

            'Pulisci dati delle impostazioni aziendali
            Dim clearBusiness As New BusinessProfile
            Dim jsonScriptBusiness As String = JsonConvert.SerializeObject(clearBusiness, Formatting.Indented)
            IO.File.WriteAllText(Paths.CompanyData & "company_profile.json", jsonScriptBusiness)

            'Ricarica impostazioni i fogli delle impostazioni
            LoadSettings()

        End Sub

        Public Shared Sub InizializeSettings()

            'Verifica se le impostazioni esistono
            If Not IO.Directory.Exists(Paths.CompanyData) Then IO.Directory.CreateDirectory(Paths.CompanyData)
            If Not IO.File.Exists(Paths.CompanyData & "company_profile.json") Then
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
End Module
