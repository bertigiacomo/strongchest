Module Globals

    Public Class Paths

        'Directory Readonly
        Public Shared ReadOnly ParentFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Strongchest\"
        Public Shared ReadOnly CompanyData As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Strongchest\Configuration\"
        Public Shared ReadOnly AppData As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Strongchest\Storage\"
        Public Shared ReadOnly UserData As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Strongchest\Storage\Data\"
        Public Shared ReadOnly TempData As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Strongchest\Storage\Temp\"
        Public Shared ReadOnly LogsData As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Strongchest\Telemetry\"
        Public Shared ReadOnly ExportData As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Strongchest\Storage\Export\"

        'Path di installazione
        Public Shared ReadOnly LocalData As String = Application.StartupPath & "\"

        'Working directory
        Public Shared workingDirectory As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Strongchest\Storage\Data\"

        'Directory dell'updater
        Public Shared UpdaterDir As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\StrongchestUpdater\"


    End Class

    Public Class CDN

        Public Const CheckServer As String = "captive.apple.com"
        Public Const MainServer As String = "http://giacomoberticdn.imfast.io/strongchest/"

        Public Const Installer As String = "http://giacomoberticdn.imfast.io/strongchest/installer.msi"
        Public Const Version As String = "http://giacomoberticdn.imfast.io/strongchest/version.txt"

    End Class




End Module
