Public Class GitBase
    Private _last As String
    Public Property LastName() As String
        Get
            Return _last
        End Get
        Set(ByVal value As String)
            _last = value
        End Set
    End Property

    Sub AddEmployee()
        MsgBox("New employee added")
    End Sub

End Class
