Namespace Business
    ''' <summary>
    ''' Business layer service for the HR dashboard.
    ''' Business responsibilities:
    ''' - Encapsulate simple business rules and coordinate access to the Data layer.
    ''' - Keep the presentation layer free of data-access details.
    ''' </summary>
    Public Class HRDashboardService
        ''' <summary>
        ''' Return all onboarding requests from the data layer.
        ''' Business layer can add filtering, sorting, or mapping here later.
        ''' </summary>
        Public Function GetAllRequests() As List(Of Models.OnboardingRequest)
            Return Data.InMemoryRequestStore.Requests
        End Function
    End Class
End Namespace