Namespace Models
    ''' <summary>
    ''' Simple Employee model used inside onboarding requests.
    ''' Keep this class minimal for the MVP.
    ''' </summary>
    Public Class Employee
        Public Property EmployeeId As Integer
        Public Property FirstName As String = String.Empty
        Public Property LastName As String = String.Empty
        Public Property Email As String = String.Empty
        Public Property Department As String = String.Empty
        Public Property JobTitle As String = String.Empty
        Public Property StartDate As Date
    End Class
End Namespace