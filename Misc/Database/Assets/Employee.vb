Public Class Employee
    Private Property _id As Integer
    Public ReadOnly Property id()
        Get
            Return _id
        End Get
    End Property

    Private Property _name As String
    Public Property name()
        Get
            Return _name
        End Get
        Set(value)
            _name = value
        End Set
    End Property

    Private Property _username As String
    Public Property username()
        Get
            Return _username
        End Get
        Set(value)
            _username = value
        End Set
    End Property
    Private Property _password As String = ""
    Public Property password()
        Get
            Return _password
        End Get
        Set(value)
            _password = value
        End Set
    End Property

    Private Property _position As Position
    Public Property position()
        Get
            Return _position.id
        End Get
        Set(value)
            _position = value
        End Set
    End Property
    Public ReadOnly Property positionName As String
        Get
            Return _position.name
        End Get
    End Property
    Private Property _phone As String
    Public Property phone() As String
        Get
            Return _phone
        End Get
        Set(value As String)
            _phone = value
        End Set
    End Property
    Private Property _access_lv As Integer
    Public ReadOnly Property access_lv()
        Get
            Return _access_lv
        End Get
    End Property


    Sub New(name As String, username As String, password As String, position As Position, phone As String, access_lv As Integer, Optional id As Integer = -1)
        _id = id
        _name = name
        _username = username
        _password = password
        _position = position
        _phone = phone
        _access_lv = access_lv
    End Sub

    Public Shared Operator &(ByVal op1 As String, ByVal op2 As Employee) As String
        Return op1 & op2.name
    End Operator
End Class
