Imports System.Linq
Imports System.Collections.Generic
Imports Npgsql
Imports EmployeeOnboarding.Data
Imports EmployeeOnboarding.Models

Namespace Business

    Public Class RequestDetailsService

        Private ReadOnly connString As String = "Host=localhost;Port=5432;Username=postgres;Password=0116646;Database=onboarding_portal"


        ' Business layer method to find a request by ID
        Public Function GetRequestById(requestId As Integer) As OnboardingRequest

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
            WHERE r.request_id = @requestId;
        "

                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@requestId", requestId)

                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
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
                                .TemplateName = "",
                                .Notes = reader("notes").ToString(),
                                .RequestedSystems = If(String.IsNullOrWhiteSpace(reader("requested_systems").ToString()),
                            New List(Of String),
                            reader("requested_systems").ToString().Split(","c).ToList()),
                                .CreatedAt = Convert.ToDateTime(reader("created_at")),
                                .UpdatedAt = Convert.ToDateTime(reader("updated_at"))
                            }

                            Return req
                        End If
                    End Using
                End Using
            End Using

            Return Nothing

        End Function

        ' Business layer method to approve a request
        Public Function ApproveRequest(requestId As Integer) As Boolean

            Using conn As New NpgsqlConnection(connString)
                conn.Open()

                Dim query As String = "
            UPDATE onboarding.onboarding_requests
            SET status_id = (
                SELECT status_id
                FROM onboarding.onboarding_request_statuses
                WHERE status_code = 'APPROVED'
            ),
            updated_at = NOW()
            WHERE request_id = @requestId;
        "

                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@requestId", requestId)

                    Dim rows = cmd.ExecuteNonQuery()
                    Return rows > 0
                End Using
            End Using

        End Function

        ' Business layer method to reject a request
        Public Function RejectRequest(requestId As Integer) As Boolean

            Using conn As New NpgsqlConnection(connString)
                conn.Open()

                Dim query As String = "
            UPDATE onboarding.onboarding_requests
            SET status_id = (
                SELECT status_id
                FROM onboarding.onboarding_request_statuses
                WHERE status_code = 'REJECTED'
            ),
            updated_at = NOW()
            WHERE request_id = @requestId;
        "

                Using cmd As New NpgsqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@requestId", requestId)

                    Dim rows = cmd.ExecuteNonQuery()
                    Return rows > 0
                End Using
            End Using

        End Function


    End Class

End Namespace