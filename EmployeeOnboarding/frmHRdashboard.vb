Imports Business
Imports EmployeeOnboarding.Business
Imports System.Linq

Public Class frmHRdashboard
    ''' <summary>
    ''' Presentation layer for HR dashboard.
    ''' UI responsibility:
    ''' - Handle user events, call the business layer, and bind results to controls.
    ''' - Do not perform data access directly here.
    ''' </summary>

    ' Business service instance (presentation calls business layer only).
    Private dashboardService As New HRDashboardService()

    Private Sub frmHRdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Seed sample data (presentation triggers the seed; data layer still owns seeding).
        Data.InMemoryRequestStore.SeedSampleData()

        ' Load and display requests in the grid.
        LoadRequestsGrid()
    End Sub

    ''' <summary>
    ''' LoadRequestsGrid
    ''' - Queries the business layer for requests.
    ''' - Creates a simplified anonymous projection for display.
    ''' - Binds the projection to dgvRequests for a clean read-only view.
    ''' </summary>
    Private Sub LoadRequestsGrid()
        ' 1) Get raw requests from the business layer.
        Dim requests = dashboardService.GetAllRequests()

        ' 2) Ensure the grid is cleared before rebinding.
        ' If dgvRequests is not present on the form, this will raise a runtime error.
        ' The spec assumes a DataGridView named dgvRequests exists.
        dgvRequests.DataSource = Nothing

        ' 3) Create a simplified display list using LINQ Select (anonymous type).
        Dim displayList = requests.Select(Function(r) New With {
                                              .RequestID = r.RequestId,
                                              .EmployeeName = String.Format("{0} {1}", r.Employee.FirstName, r.Employee.LastName),
                                              .Department = r.Employee.Department,
                                              .JobTitle = r.Employee.JobTitle,
                                              .Status = r.Status,
                                              .Manager = r.ManagerName,
                                              .CreatedDate = r.CreatedAt
                                          }).ToList()

        ' 4) Bind the list to the DataGridView.
        dgvRequests.AutoGenerateColumns = True
        dgvRequests.DataSource = displayList

        ' 5) Small visual adjustments (presentation only).
        dgvRequests.Refresh()
        dgvRequests.AutoResizeColumns()
    End Sub

    Private Sub btnCreateRequest_Click(sender As Object, e As EventArgs) Handles btnCreateRequest.Click
        ' Open the onboarding request creation dialog.
        ' The dialog is responsible for adding a new request into the Data.InMemoryRequestStore.
        Dim frm As New frmRequestDetails()
        frm.ShowDialog()

        ' After the dialog closes, refresh the grid to show any new requests.
        LoadRequestsGrid()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Return to role selection (presentation action).
        Dim frm As New frmRoleSelection()
        frm.Show()

        ' Close the HR dashboard window.
        Me.Close()
    End Sub
End Class
