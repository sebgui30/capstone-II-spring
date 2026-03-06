Imports EmployeeOnboarding.Models

Namespace EmployeeOnboarding.Data

    Module InMemoryRequestStore

        Public Requests As New List(Of OnboardingRequest)
        Public NextRequestId As Integer = 1

        ' Seed sample data for testing
        Public Sub SeedTestData()

            If Requests.Count > 0 Then Return

            Dim emp1 As New Employee With {
                .EmployeeId = 1,
                .FirstName = "John",
                .LastName = "Doe",
                .Department = "IT",
                .JobTitle = "Support Specialist",
                .StartDate = Date.Today.AddDays(7)
            }

            Dim req1 As New OnboardingRequest With {
                .RequestId = NextRequestId,
                .Employee = emp1,
                .Status = "Pending",
                .ManagerName = "Sarah Johnson",
                .TemplateName = "Standard IT Access",
                .Notes = "New employee onboarding request",
                .RequestedSystems = New List(Of String) From {
                    "Active Directory",
                    "Email",
                    "VPN"
                },
                .CreatedAt = DateTime.Now,
                .UpdatedAt = DateTime.Now
            }

            Requests.Add(req1)
            NextRequestId += 1

        End Sub

    End Module

End Namespace