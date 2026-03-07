Imports EmployeeOnboarding.Models

Namespace EmployeeOnboarding.Data

    Module InMemoryRequestStore

        Public Requests As New List(Of OnboardingRequest)
        Public NextRequestId As Integer = 1

        ' Seed sample data for testing and UI visualization
        Public Sub SeedTestData()

            If Requests.Count > 0 Then Return

            Dim emp1 As New Employee With {
                .EmployeeId = 1,
                .FirstName = "John",
                .LastName = "Doe",
                .Email = "john.doe@company.com",
                .Department = "IT",
                .JobTitle = "Support Specialist",
                .StartDate = Date.Today.AddDays(7)
            }

            Dim req1 As New OnboardingRequest With {
                .RequestId = NextRequestId,
                .Employee = emp1,
                .Status = "In Progress",
                .ManagerName = "Sarah Johnson",
                .TemplateName = "Standard Access",
                .Notes = "New hire onboarding request",
                .RequestedSystems = New List(Of String) From {
                    "Active Directory",
                    "Outlook",
                    "VPN"
                },
                .CreatedAt = DateTime.Now.AddDays(-2),
                .UpdatedAt = DateTime.Now.AddDays(-2)
            }
            Requests.Add(req1)
            NextRequestId += 1

            Dim emp2 As New Employee With {
                .EmployeeId = 2,
                .FirstName = "Emily",
                .LastName = "Smith",
                .Email = "emily.smith@company.com",
                .Department = "HR",
                .JobTitle = "HR Assistant",
                .StartDate = Date.Today.AddDays(10)
            }

            Dim req2 As New OnboardingRequest With {
                .RequestId = NextRequestId,
                .Employee = emp2,
                .Status = "In Progress",
                .ManagerName = "Michael Brown",
                .TemplateName = "HR Access",
                .Notes = "Laptop provisioning in progress",
                .RequestedSystems = New List(Of String) From {
                    "Payroll System",
                    "Outlook",
                    "Shared Drive"
                },
                .CreatedAt = DateTime.Now.AddDays(-4),
                .UpdatedAt = DateTime.Now.AddDays(-1)
            }
            Requests.Add(req2)
            NextRequestId += 1

            Dim emp3 As New Employee With {
                .EmployeeId = 3,
                .FirstName = "Carlos",
                .LastName = "Mendez",
                .Email = "carlos.mendez@company.com",
                .Department = "Finance",
                .JobTitle = "Analyst",
                .StartDate = Date.Today.AddDays(14)
            }

            Dim req3 As New OnboardingRequest With {
                .RequestId = NextRequestId,
                .Employee = emp3,
                .Status = "Approved",
                .ManagerName = "Laura Green",
                .TemplateName = "Finance Access",
                .Notes = "All systems completed",
                .RequestedSystems = New List(Of String) From {
                    "ERP",
                    "Excel",
                    "Finance Shared Drive"
                },
                .CreatedAt = DateTime.Now.AddDays(-6),
                .UpdatedAt = DateTime.Now
            }
            Requests.Add(req3)
            NextRequestId += 1

            Dim emp4 As New Employee With {
                .EmployeeId = 4,
                .FirstName = "Ana",
                .LastName = "Rivera",
                .Email = "ana.rivera@company.com",
                .Department = "Marketing",
                .JobTitle = "Coordinator",
                .StartDate = Date.Today.AddDays(5)
            }

            Dim req4 As New OnboardingRequest With {
                .RequestId = NextRequestId,
                .Employee = emp4,
                .Status = "Rejected",
                .ManagerName = "Daniel White",
                .TemplateName = "Marketing Access",
                .Notes = "Request denied due to incomplete information",
                .RequestedSystems = New List(Of String) From {
                    "Canva",
                    "Outlook"
                },
                .CreatedAt = DateTime.Now.AddDays(-1),
                .UpdatedAt = DateTime.Now
            }
            Requests.Add(req4)
            NextRequestId += 1

        End Sub

    End Module

End Namespace