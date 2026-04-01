Namespace Models
    ''' <summary>
    ''' OnboardingRequest model representing an HR onboarding request.
    ''' Contains a reference to an Employee and simple metadata.
    ''' </summary>
    Public Class OnboardingRequest
        Public Property RequestId As Integer
        Public Property Employee As Employee
        Public Property Status As String = String.Empty
        Public Property ManagerName As String = String.Empty
        Public Property TemplateName As String = String.Empty
        Public Property Notes As String = String.Empty
        Public Property CreatedAt As DateTime
        Public Property UpdatedAt As DateTime

        ' Simple list of requested systems. Presentation reads this to populate the ListBox.
        Public Property RequestedSystems As List(Of String) = New List(Of String)()
    End Class
End Namespace