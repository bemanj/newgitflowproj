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


End Class
