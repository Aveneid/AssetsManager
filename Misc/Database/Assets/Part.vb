Public Class Part

    Private Property _id As Integer
    Private Property _name As String
    Private Property _specification As String
    Private Property _catalog_no As String
    Private Property _manufacturer As Manufacturer

    Public ReadOnly Property id As Integer
        Get
            Return _id
        End Get
    End Property
    Public Property name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property specification As String
        Get
            Return _specification
        End Get
        Set(value As String)
            _specification = value
        End Set
    End Property
    Public Property catalog_no As String
        Get
            Return _catalog_no
        End Get
        Set(value As String)
            _catalog_no = value
        End Set
    End Property

    Public Property manufacturer As Manufacturer
        Get
            Return _manufacturer
        End Get
        Set(value As Manufacturer)
            _manufacturer = value
        End Set
    End Property

    Sub New(name As String, specification As String, catalog_no As String, manufacturer As Manufacturer, Optional id As Integer = -1)
        _id = id
        _name = name
        _specification = specification
        _catalog_no = catalog_no
        _manufacturer = manufacturer
    End Sub
End Class
