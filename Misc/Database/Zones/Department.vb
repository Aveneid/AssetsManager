Public Class Department
    Private Property _id As Integer = -1
    Public ReadOnly Property id()
        Get
            Return _id
        End Get
    End Property

    Private Property _name As String = ""
    Public Property name()
        Get
            Return _name
        End Get
        Set(value)
            _name = value
        End Set
    End Property
    Private Property _idx As String = ""
    Public Property idx()
        Get
            Return _idx
        End Get
        Set(value)
            _idx = value
        End Set
    End Property
    Private Property _location As String = ""
    Public Property location()
        Get
            Return _location
        End Get
        Set(value)
            _location = value

        End Set
    End Property
    Private Property _description As String = ""
    Public Property description()
        Set(value)
            _description = value
        End Set
        Get
            Return _description
        End Get
    End Property

    Sub New(name As String, idx As String, location As String, description As String, Optional id As Integer = -1)
        _id = id
        _name = name
        _location = location
        _idx = idx
        _description = description

    End Sub
    Function equals(ByVal other As Department)
        If other.idx = Me.idx And
            other.name = Me.name And
            other.id = Me.id Then
            Return True
        Else Return False
        End If
    End Function

    Public Shared Operator &(ByVal op1 As String, ByVal op2 As Department) As String
        Return op1 & op2.name
    End Operator

End Class
