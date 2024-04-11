Imports System.Reflection
Imports AssetsManager.Misc.SQLDriver

Public Module Globals

    Public loggedEmployee As Employee

#Region "basedata"

    Private _departments As List(Of Department) = New List(Of Department)
    Public ReadOnly Property departments() As List(Of Department)
        Get
            Return _departments
        End Get
    End Property
    Private _warehouses As List(Of Warehouse) = New List(Of Warehouse)

    Public ReadOnly Property warehouses() As List(Of Warehouse)
        Get
            Return _warehouses
        End Get
    End Property


    Private _employees As List(Of Employee) = New List(Of Employee)

    Public ReadOnly Property employees() As List(Of Employee)
        Get
            Return _employees
        End Get
    End Property


    Private _positions As List(Of Position) = New List(Of Position)

    Public ReadOnly Property positions() As List(Of Position)
        Get
            Return _positions
        End Get
    End Property


#Region "departments"
    Sub populateDepartments()
        Dim s = "SELECT * FROM INV_departments;"
        Dim dtDepartments = SQLDriver.sqlExeQuery(s)
        _departments.Clear()
        For Each d As DataRow In dtDepartments.Rows
            _departments.Add(New Department(d.Field(Of String)("name"), d.Field(Of String)("idx"), d.Field(Of String)("location"),
                                            d.Field(Of String)("description"), d.Field(Of Integer)("id")))
        Next
    End Sub


    Function saveDepartments(dept As Department)
        'check if exists

        If SQLDriver.sqlExeNonQuery("UPDATE INV_departments SET name = '" & dept.name & "', location='" & dept.location & "', idx='" & dept.idx &
                                     "', description='" & dept.description & "' WHERE id = " & dept.id) Then
            Return True
        End If
        Return False

    End Function

    Function addDepartment(dept As Department)
        If Not departments.Find(Function(c) c.idx = dept.idx) IsNot Nothing Then
            If SQLDriver.sqlExeNonQuery("INSERT INTO INV_departments VALUES('" & dept.name & "', '" & dept.idx & "', '" & dept.location &
                                    "', '" & dept.description & "')") Then
                Return True
            End If
        Else
            MsgBox("Wydział z takim indeksem już istnieje.")
        End If
        Return False
    End Function

    Public Function checkIfInUse(department As Department)
        If SQLDriver.sqlExeQueryCount("INV_warehouses", "department_id", " department_id = " & department.id) > 0 And SQLDriver.sqlExeQueryCount("INV_machinery", "department_id", " department_id = " & department.id) > 0 Then
            Return True
        End If
        Return False

    End Function
    Public Function checkIfInUse(warehouse As Warehouse)
        If SQLDriver.sqlExeQueryCount("INV_tools", "warehouse_id", " warehouse_id = " & warehouse.id) > 0 Then
            Return True
        End If
        Return False

    End Function
    Public Function checkIfInUse(employee As Employee)
        If SQLDriver.sqlExeQueryCount("INV_warehouses", "resp_employee", " resp_employee = " & employee.id) > 0 Then
            Return True
        End If
        Return False

    End Function

    Public Function findDepartmentById(id As Integer) As Department
        Return departments.Find(Function(c) c.id = id)
    End Function
    Public Function findDepartmentByName(name As String) As Department
        Return departments.Find(Function(c) c.name = name)
    End Function
#End Region

#Region "warehouses"
    Sub populateWarehouses()
        Dim s = "SELECT * FROM INV_warehouses;"
        Dim dtWarehouses = SQLDriver.sqlExeQuery(s)
        _warehouses.Clear()
        For Each d As DataRow In dtWarehouses.Rows
            _warehouses.Add(New Warehouse(d.Field(Of String)("name"), d.Field(Of String)("description"), d.Field(Of String)("idx"),
                                          findDepartmentById(d.Field(Of Integer)("department_id")), findEmployeeById(d.Field(Of Integer)("resp_employee")), d.Field(Of Integer)("id")))
        Next

    End Sub

    Function saveWarehouses(wrhs As Warehouse)
        'check if exists

        If SQLDriver.sqlExeNonQuery("UPDATE INV_warehouses SET name = '" & wrhs.name & "',', idx='" & wrhs.idx &
                                     "', description='" & wrhs.description & "', resp_employee=" & wrhs.resp_employee & " WHERE id = " & wrhs.id) Then
            Return True
        End If
        Return False

    End Function

    Function addWarehouse(wrhs As Warehouse)
        If Not _warehouses.Find(Function(c) c.idx = wrhs.idx) IsNot Nothing Then
            If SQLDriver.sqlExeNonQuery("INSERT INTO INV_warehouses VALUES('" & wrhs.name & "','" & wrhs.description & "','" _
                                        & wrhs.idx & "'," & wrhs.department.id & "," & wrhs.resp_employee & ")") Then
                Return True
            End If
        Else
            MsgBox("Magazyn z takim indeksem już istnieje.")

        End If
        Return False

    End Function



#End Region


#Region "positions"
    Sub populatePositions()

        Dim s = "SELECT * FROM INV_emp_positions;"
        Dim dtEmployees = SQLDriver.sqlExeQuery(s)
        _positions.Clear()
        For Each d As DataRow In dtEmployees.Rows
            _positions.Add(New Position(d.Field(Of Integer)("id"), d.Field(Of String)("name")))
        Next

    End Sub
    Sub savePosition(pos As Position)
        If Not SQLDriver.sqlExeNonQuery("UPDATE INV_emp_positions SET name='" * pos.name & "' WHERE id = " & pos.id) Then
            MsgBox("Wystąpił błąd przy zapisywaniu.")
        End If
    End Sub

    Function addPosition(pos As Position)

        If Not _positions.Find(Function(c) c.name = pos.name) IsNot Nothing Then
            If SQLDriver.sqlExeNonQuery("INSERT INTO INV_emp_positions values('" & pos.name & "')") Then
                Return True
            End If
            Return False
        Else
            MsgBox("takie stanowisko już istnieje.")
        End If
        Return False
    End Function

    Function findPositionById(id As Integer) As Position
        Return _positions.Find(Function(c) c.id = id)
    End Function
    Function findPositionByName(name As String) As Position
        Return _positions.Find(Function(c) c.name = name)
    End Function

#End Region

#Region "employees"
    Sub populateEmployees()
        populatePositions()
        Dim s = "SELECT * FROM INV_employees;"
        Dim dtEmployees = SQLDriver.sqlExeQuery(s)
        _employees.Clear()
        For Each d As DataRow In dtEmployees.Rows
            Dim pos = _positions.Find(Function(c) c.id = d.Field(Of Integer)("position"))
            _employees.Add(New Employee(d.Field(Of String)("name"), d.Field(Of String)("username"), d.Field(Of String)("password"), pos, d.Field(Of String)("phone"), d.Field(Of Integer)("access_lv"), d.Field(Of Integer)("id")))
        Next

    End Sub

    Function saveEmployee(emp As Employee)
        'check if exists
        If emp.password <> "" Then
            If SQLDriver.sqlExeNonQuery("UPDATE INV_employees SET name = '" & emp.name & "',password = '" & emp.password & "', position=' " & emp.position & "', phone = '" & emp.phone & "', access_lv = " & emp.access_lv & " WHERE id = " & emp.id) Then
                Return True
            End If
        Else
            If SQLDriver.sqlExeNonQuery("UPDATE INV_employees SET name = '" & emp.name & "', position=' " & emp.position & "', phone = '" & emp.phone & "', access_lv = " & emp.access_lv & " WHERE id = " & emp.id) Then
                Return True
            End If
        End If
        Return False

    End Function

    Function addEmployee(emp As Employee)
        If Not _employees.Find(Function(c) c.name = emp.name) IsNot Nothing Then
            If SQLDriver.sqlExeNonQuery("INSERT INTO INV_employees VALUES('" & emp.name & "','" & emp.username & "','" & createhashMD5(emp.password) & "','" _
                                        & emp.position & "','" & emp.phone & "'," & emp.access_lv & ")") Then
                Return True
            End If
        Else
            MsgBox("Taki pracownik już istnieje.")

        End If
        Return False

    End Function

    Public Function findEmployeeById(id As Integer) As Employee
        Return employees.Find(Function(c) c.id = id)
    End Function
    Public Function findEmployeeByName(name As String) As Employee
        Return employees.Find(Function(c) c.name = name)
    End Function




#End Region


#End Region

    Public Sub SetDoubleBuffered(ByRef control As Control, ByVal buffered As Boolean)
        GetType(Control).InvokeMember("DoubleBuffered", BindingFlags.SetProperty Or BindingFlags.Instance Or BindingFlags.NonPublic, Nothing, control, New Object() {buffered})
    End Sub



    Public Function ConvertToDataTable(Of T)(ByVal list As IList(Of T)) As DataTable
        Dim table As New DataTable()
        Dim fields() As PropertyInfo = GetType(T).GetProperties()
        For Each field As PropertyInfo In fields
            table.Columns.Add(field.Name, field.PropertyType)
        Next
        For Each item As T In list
            Dim row As DataRow = table.NewRow()
            For Each field As PropertyInfo In fields
                row(field.Name) = field.GetValue(item)
            Next
            table.Rows.Add(row)
        Next
        Return table
    End Function

End Module
