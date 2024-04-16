Public Class Machine
    Private _id As Integer
    Private _name As String
    Private _type As Type
    Private _model As String
    Private _manufacturer As Manufacturer
    Private _departament As Department
    Private _status As Enums.Status
    Private _barcode As String
    Private _resp_employee As Employee
    Private _pictureID As Integer
    Private _parts As List(Of Part)

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
    Public Property type As Type
        Get
            Return _type
        End Get
        Set(value As Type)
            _type = value
        End Set
    End Property
    Public Property model As String
        Get
            Return _model
        End Get
        Set(value As String)
            _model = value
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

    Public Property department As Department
        Get
            Return _departament
        End Get
        Set(value As Department)
            _departament = value
        End Set
    End Property

    Public Property status As Enums.Status
        Get
            Return _status
        End Get
        Set(value As Enums.Status)
            _status = value
        End Set
    End Property
    Public ReadOnly Property barcode As String
        Get
            Return _barcode
        End Get
    End Property
    Public Property resp_employee As Employee
        Get
            Return _resp_employee
        End Get
        Set(value As Employee)
            _resp_employee = value
        End Set
    End Property

    Public ReadOnly Property picture As Integer
        Get
            Return _pictureID
        End Get
    End Property

    Public Property parts As List(Of Part)
        Get
            Return _parts
        End Get
        Set(value As List(Of Part))
            _parts = value
        End Set
    End Property

    Public Sub setPicture(pic As Picture)
        If pic IsNot Nothing Then
            _pictureID = pic.id
        Else
            _pictureID = -1
        End If
    End Sub

    Sub New(name As String, type As Type, model As String, manufacturer As Manufacturer, department As Department, status As Enums.Status, barcode As String, resp_employee As Employee, Optional picture As Integer = -1, Optional parts As List(Of Part) = Nothing, Optional id As Integer = -1)
        _id = id
        _name = name
        _type = type
        _model = model
        _manufacturer = manufacturer
        _departament = department
        _status = status
        _barcode = barcode
        _resp_employee = resp_employee
        _pictureID = picture
        _parts = parts
    End Sub


End Class
