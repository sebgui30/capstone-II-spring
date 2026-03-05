Namespace Data
    ''' <summary>
    ''' Simple in-memory session storage for the application (Data layer).
    ''' Data layer responsibility: hold shared state only (no DB).
    ''' </summary>
    Public Module SessionStore
        ' Holds the currently selected role ("HR", "Manager", "IT").
        Public CurrentRole As String = String.Empty
    End Module
End Namespace