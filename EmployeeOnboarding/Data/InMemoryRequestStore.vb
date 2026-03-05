Namespace Data
    ''' <summary>
    ''' Temporary in-memory storage for onboarding requests (MVP).
    ''' Data layer responsibility: hold shared app state for the lifetime of the process.
    ''' No persistence, no IO — just an in-memory list and a simple id counter.
    ''' </summary>
    Public Module InMemoryRequestStore
        ' Public list holding all onboarding requests.
        Public Requests As New List(Of Models.OnboardingRequest)()

        ' Simple counter used to assign RequestId values.
        Public NextRequestId As Integer = 1

        ''' <summary>
        ''' Seed two safe sample requests only when the store is empty.
        ''' This helps the HR dashboard display sample rows on first run.
        ''' </summary>
        Public Sub SeedSampleData()
            If Requests.Count > 0 Then
                Return
            End If

            Dim emp1 As New Models.Employee With {
                .EmployeeId = 1,
                .FirstName = "Alice",
                .LastName = "Johnson",
                .Email = "alice.johnson@example.com",
                .Department = "Finance",
                .JobTitle = "Payroll Specialist",
                .StartDate = Date.Today.AddDays(7)
            }

            Dim req1 As New Models.OnboardingRequest With {
                .RequestId = NextRequestId,
                .Employee = emp1,
                .Status = "Pending",
                .ManagerName = "Robert Smith",
                .TemplateName = "Finance Standard",
                .Notes = "Needs payroll and system access.",
                .CreatedAt = DateTime.Now,
                .UpdatedAt = DateTime.Now
            }
            Requests.Add(req1)
            NextRequestId += 1

            Dim emp2 As New Models.Employee With {
                .EmployeeId = 2,
                .FirstName = "Brian",
                .LastName = "Lee",
                .Email = "brian.lee@example.com",
                .Department = "Engineering",
                .JobTitle = "Junior Developer",
                .StartDate = Date.Today.AddDays(14)
            }

            Dim req2 As New Models.OnboardingRequest With {
                .RequestId = NextRequestId,
                .Employee = emp2,
                .Status = "Approved",
                .ManagerName = "Samantha Green",
                .TemplateName = "Developer Onboarding",
                .Notes = "Approved for laptop provisioning and repo access.",
                .CreatedAt = DateTime.Now.AddDays(-2),
                .UpdatedAt = DateTime.Now.AddDays(-1)
            }
            Requests.Add(req2)
            NextRequestId += 1
        End Sub
    End Module
End Namespace