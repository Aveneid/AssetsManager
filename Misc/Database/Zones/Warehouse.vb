Public Class Warehouse
    Private Property _id As Integer = -1
    Public ReadOnly Property id()
        Get
            Return _id
        End Get
    End Property


    Private Property _name As String
    Public ReadOnly Property name()
        Get
            Return _name
        End Get
    End Property
    Private Property _description As String
    Public ReadOnly Property description()
        Get
            Return _description
        End Get
    End Property
    Private Property _idx As String
    Public ReadOnly Property idx()
        Get
            Return _idx
        End Get
    End Property
    Private Property _department As Department
    'Public ReadOnly Property department_id()
    '    Get
    '        Return _department.id
    '    End Get
    'End Property
    Public Property department As Department
        Get
            Return _department
        End Get
        Set(value As Department)
            _department = value
        End Set
    End Property
    Private Property _resp_employee As Employee
    'Public ReadOnly Property resp_employee_id()
    '    Get
    '        Return _resp_employee.id
    '    End Get
    'End Property
    Public Property resp_employee As Employee
        Get
            Return _resp_employee
        End Get
        Set(value As Employee)
            _resp_employee = value
        End Set
    End Property


    Sub New(name As String, description As String, idx As String, department As Department, resp_employee As Employee, Optional id As Integer = -1)
        _id = id
        _name = name
        _description = description
        _idx = idx
        _department = department
        _resp_employee = resp_employee



    End Sub

End Class
