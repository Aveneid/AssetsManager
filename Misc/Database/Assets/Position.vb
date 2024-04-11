Public Class Position

    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Private _id As Integer

    Public Property name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property
    Private _name As String

    Sub New(id As Integer, name As String)
        _id = id
        _name = name.Trim()
    End Sub
    Function ToString()
        Return _name
    End Function
End Class
