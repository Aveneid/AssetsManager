Public Class Manufacturer
    Private Property _id As Integer
    Private Property _name As String
    Private Property _location As String
    Private Property _phone As String
    Private Property _idx As String

    Public ReadOnly Property id As Integer
        Get
            Return _id
        End Get
    End Property
    Public ReadOnly Property name As String
        Get
            Return _name
        End Get
    End Property
    Public ReadOnly Property location As String
        Get
            Return _location
        End Get
    End Property
    Public ReadOnly Property phone As String
        Get
            Return _phone
        End Get
    End Property
    Public ReadOnly Property idx As String
        Get
            Return _idx
        End Get
    End Property

    Sub New(name As String, location As String, phone As String, idx As String, Optional id As Integer = -1)
        _id = id
        _name = name
        _location = location
        _phone = phone
        _idx = idx
    End Sub
    Public Overloads Function ToString()
        Return _name
    End Function
End Class
