Imports EmployeeOnboarding.Data
Imports EmployeeOnboarding.EmployeeOnboarding.Data
Imports EmployeeOnboarding.Models

Namespace EmployeeOnboarding.Business

    Public Class HRDashboardService

        ' Business layer method to retrieve all onboarding requests
        Public Function GetAllRequests() As List(Of OnboardingRequest)
            Return InMemoryRequestStore.Requests
        End Function

    End Class

End Namespace