Public Class Type
    Private _id As Integer
    Private _name As String

    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Public Property name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Sub New(name As String, Optional id As Integer = -1)
        _id = id
        _name = name
    End Sub

    Public Overloads Function ToString()
        Return _name
    End Function
End Class
