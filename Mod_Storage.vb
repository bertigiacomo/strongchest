Imports Newtonsoft.Json

Module Mod_Storage

    Public StorageInfo As New Storage.StorageAccess

    Public Class Storage

        Public Shared Sub InizializeStorage()

            'Accedi alle informazioni dello spazio
            If Settings.IsSetUp = True Then

                Dim jsonStringStorage As String = IO.File.ReadAllText(Paths.AppData & "storage_data.json")
                Dim data As StorageAccess = Newtonsoft.Json.JsonConvert.DeserializeObject(Of StorageAccess)(jsonStringStorage)

                'Carica dati
                StorageInfo = data

            End If


        End Sub

        Public Shared Sub WriteData()

            Dim jsonScript As String = JsonConvert.SerializeObject(StorageInfo, Formatting.Indented)
            IO.File.WriteAllText(Paths.AppData & "storage_data.json", jsonScript)


        End Sub
        Public Class StorageAccess

            'Definisce l'username dell'utente proprietario
            Property Username As String = ""
            'Definisce la password sottoforma di Hash
            Property Password As String = ""
            'Definisce la versione dello Storage
            Property Version As Integer
            'Definisce quando è stato creato lo spazio (o importato)
            Property GenerationDate As Date
            'Definisce il nome del computer dove lo spazio è stato creato (o importato)
            Property ComputerName As String = ""
            'Assegna un id allo spazio
            Property StorageID As String = ""


        End Class

    End Class

End Module
