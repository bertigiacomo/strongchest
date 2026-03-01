Module Logging

    Dim TextLog As String = LogIntroduction

    Const LogIntroduction = "=======================================================================" & vbNewLine &
                            "This is a Strongchest LOG. Check if Strongchest doesn't work well" & vbNewLine &
                            "You can send to the community. A log is written at every run." & vbNewLine &
                            "Version: 2" & vbNewLine &
                            "=======================================================================" & vbNewLine


    Public Enum Type

        Info = 1
        Warn = 2
        Erro = 3

    End Enum


    Public Class Log

        Public Shared Sub Add(Text As String, Optional LogType As Type = Type.Info)

            Dim StringType = "[IGNORE]"
            Dim Compose

            If LogType = 1 Then
                StringType = "[INFO]"
            ElseIf LogType = 2 Then
                StringType = "[WARN]"
            ElseIf LogType = 3 Then
                StringType = "[ERROR]"
            End If

            Compose = "[" & TimeOfDay & "] " & StringType & " " & Text
            TextLog = TextLog & vbNewLine & Compose

        End Sub

        Public Shared Sub Write()

            If IO.Directory.Exists(Paths.LogsData) = False Then
                IO.Directory.CreateDirectory(Paths.LogsData)
            End If


            IO.File.WriteAllText(Paths.LogsData & "(#" & GetAlphaString("8") & ") " & Date.Now.ToString.Replace("/", "-").Replace(":", "-") & ".log", TextLog)

        End Sub
    End Class




End Module
