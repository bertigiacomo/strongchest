Module Mod_Network

    Public Class Network

        Shared ReadOnly NetworkClient As New System.Net.WebClient
        Public Shared Function CheckForUpdates() As Boolean

            'Cerca aggiornamenti
            If (Business.UpdatesEnabled = True And Business.Enabled = True) Or Business.Enabled = False Then
                Try
                    Dim lastestVersion = NetworkClient.DownloadString(CDN.Version)
                    If lastestVersion <> ApplicationConstants.AppBuild Then
                        Return True
                    Else
                        Return False
                    End If
                Catch ex As Exception
                    Return False
                End Try
            Else
                Return False
            End If


        End Function




    End Class
End Module
