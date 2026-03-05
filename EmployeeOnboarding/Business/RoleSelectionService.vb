Namespace Business
    ''' <summary>
    ''' Business layer: performs validation and maps UI state to domain value,
    ''' and coordinates writing the session role to the Data layer.
    ''' UI (forms) should only call this service and handle presentation concerns.
    ''' </summary>
    Public Class RoleSelectionService
        ''' <summary>
        ''' Ensure at least one radio button is selected.
        ''' </summary>
        Public Function ValidateRoleSelected(isHR As Boolean, isManager As Boolean, isIT As Boolean) As Boolean
            Return isHR OrElse isManager OrElse isIT
        End Function

        ''' <summary>
        ''' Convert radio button booleans into the role string.
        ''' Returns "" when none selected.
        ''' </summary>
        Public Function GetSelectedRole(isHR As Boolean, isManager As Boolean, isIT As Boolean) As String
            If isHR Then
                Return "HR"
            End If
            If isManager Then
                Return "Manager"
            End If
            If isIT Then
                Return "IT"
            End If
            Return String.Empty
        End Function

        ''' <summary>
        ''' Persist the selected role into the Data.SessionStore (in-memory).
        ''' </summary>
        Public Sub SetCurrentRole(role As String)
            Data.SessionStore.CurrentRole = role
        End Sub
    End Class
End Namespace