Imports System.Linq
Imports EmployeeOnboarding.Data
Imports EmployeeOnboarding.EmployeeOnboarding.Data
Imports EmployeeOnboarding.Models

Namespace EmployeeOnboarding.Business

    Public Class RequestDetailsService

        ' Business layer method to find a request by ID
        Public Function GetRequestById(requestId As Integer) As OnboardingRequest
            Return InMemoryRequestStore.Requests.FirstOrDefault(Function(r) r.RequestId = requestId)
        End Function

        ' Business layer method to approve a request
        Public Function ApproveRequest(requestId As Integer) As Boolean
            Dim req = GetRequestById(requestId)

            If req Is Nothing Then
                Return False
            End If

            req.Status = "Approved"
            req.UpdatedAt = DateTime.Now
            Return True
        End Function

        ' Business layer method to reject a request
        Public Function RejectRequest(requestId As Integer) As Boolean
            Dim req = GetRequestById(requestId)

            If req Is Nothing Then
                Return False
            End If

            req.Status = "Rejected"
            req.UpdatedAt = DateTime.Now
            Return True
        End Function

    End Class

End Namespace