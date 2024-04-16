Public Class Picture
    Private Property _id As Integer
    Private Property _image As Image
    Private Property _name As String

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
    Public Property image As Image
        Get
            Return _image
        End Get
        Set(value As Image)
            _image = value
        End Set
    End Property

    Sub New(name As String, image As Image, Optional id As Integer = -1)
        _id = id
        _name = name
        _image = image
    End Sub
End Class
