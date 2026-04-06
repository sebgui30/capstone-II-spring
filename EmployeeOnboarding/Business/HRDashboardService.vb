Imports System.Collections.Generic
Imports Npgsql
Imports EmployeeOnboarding.Data
Imports EmployeeOnboarding.Models

Namespace Business

    Public Class HRDashboardService

        Private ReadOnly connString As String = "Host=localhost;Port=5432;Username=postgres;Password=0116646;Database=onboarding_portal"

        ' Business layer method to retrieve all onboarding requests from PostgreSQL
        Public Function GetAllRequests() As List(Of OnboardingRequest)

            Dim requests As New List(Of OnboardingRequest)

            Using conn As New NpgsqlConnection(connString)
                conn.Open()

                Dim query As String = "
                    SELECT
                        r.request_id,
                        e.employee_id,
                        e.first_name,
                        e.last_name,
                        e.personal_email,
                        e.department,
                        e.job_title,
                        e.start_date,
                        COALESCE(u.full_name, 'Assigned Manager') AS manager_name,
                        s.status_code,
                        r.notes,
                        r.requested_systems,
                        r.created_at,
                        r.updated_at
                    FROM onboarding.onboarding_requests r
                    INNER JOIN onboarding.employees e
                        ON r.employee_id = e.employee_id
                    LEFT JOIN onboarding.users u
                        ON r.manager_user_id = u.user_id
                    INNER JOIN onboarding.onboarding_request_statuses s
                        ON r.status_id = s.status_id
                    ORDER BY r.request_id;
                "

                Using cmd As New NpgsqlCommand(query, conn)
                    Using reader = cmd.ExecuteReader()

                        While reader.Read()

                            Dim emp As New Employee With {
                                .EmployeeId = Convert.ToInt32(reader("employee_id")),
                                .FirstName = reader("first_name").ToString(),
                                .LastName = reader("last_name").ToString(),
                                .Email = reader("personal_email").ToString(),
                                .Department = reader("department").ToString(),
                                .JobTitle = reader("job_title").ToString(),
                                .StartDate = Convert.ToDateTime(reader("start_date"))
                            }

                            Dim req As New OnboardingRequest With {
                                .RequestId = Convert.ToInt32(reader("request_id")),
                                .Employee = emp,
                                .Status = reader("status_code").ToString(),
                                .ManagerName = reader("manager_name").ToString(),
                                .Notes = reader("notes").ToString(),
                                .RequestedSystems = New List(Of String),
                                .CreatedAt = Convert.ToDateTime(reader("created_at")),
                                .UpdatedAt = Convert.ToDateTime(reader("updated_at"))
                            }

                            If Not IsDBNull(reader("requested_systems")) AndAlso Not String.IsNullOrWhiteSpace(reader("requested_systems").ToString()) Then
                                req.RequestedSystems = reader("requested_systems").ToString().Split(","c).Select(Function(x) x.Trim()).ToList()
                            End If

                            requests.Add(req)

                        End While

                    End Using
                End Using
            End Using

            Return requests

        End Function

    End Class

End Namespace
