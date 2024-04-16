Imports System.IO
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

    Public ReadOnly Property warehouses As List(Of Warehouse)
        Get
            Return _warehouses
        End Get
    End Property


    Private _employees As List(Of Employee) = New List(Of Employee)

    Public ReadOnly Property employees As List(Of Employee)
        Get
            Return _employees
        End Get
    End Property


    Private _positions As List(Of Position) = New List(Of Position)

    Public ReadOnly Property positions As List(Of Position)
        Get
            Return _positions
        End Get
    End Property

    Private _machines As List(Of Machine) = New List(Of Machine)

    Public ReadOnly Property machines As List(Of Machine)
        Get
            Return _machines
        End Get
    End Property

    Private _types As List(Of Type) = New List(Of Type)

    Public ReadOnly Property types As List(Of Type)
        Get
            Return _types
        End Get
    End Property

    Private _manufacturers As List(Of Manufacturer) = New List(Of Manufacturer)

    Public ReadOnly Property manufacturers As List(Of Manufacturer)
        Get
            Return _manufacturers
        End Get
    End Property

    Private _parts As List(Of Part) = New List(Of Part)

    Public ReadOnly Property parts As List(Of Part)
        Get
            Return _parts
        End Get
    End Property

    Sub populateAllData()
        populateTypes()
        populatePositions()
        populateDepartments()
        populateEmployees()
        populateWarehouses()
        populateTypes()
        populateManufacturers()
        populateParts()
        populateMachines()
    End Sub


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

    Public Function deleteDepartment(dept As Department)
        If SQLDriver.sqlExeNonQuery("DELETE FROM INV_departments WHERE id = " & dept.id) Then
            Return True
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
    Public Function checkIfAdmin(employee As Employee)
        Return IIf(employee.access_lv > 4, True, False)
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
                                     "', description='" & wrhs.description & "', resp_employee=" & wrhs.resp_employee.id & " WHERE id = " & wrhs.id) Then
            Return True
        End If
        Return False

    End Function

    Function addWarehouse(wrhs As Warehouse)
        If Not _warehouses.Find(Function(c) c.idx = wrhs.idx) IsNot Nothing Then
            If SQLDriver.sqlExeNonQuery("INSERT INTO INV_warehouses VALUES('" & wrhs.name & "','" & wrhs.description & "','" _
                                        & wrhs.idx & "'," & wrhs.department.id & "," & wrhs.resp_employee.id & ")") Then
                Return True
            End If
        Else
            MsgBox("Magazyn z takim indeksem już istnieje.")

        End If
        Return False

    End Function
    Public Function deleteWarehouse(wrhs As Warehouse)
        If SQLDriver.sqlExeNonQuery("DELETE FROM INV_warehouses WHERE id = " & wrhs.id) Then
            Return True
        End If
        Return False
    End Function


    Function findWarehouseById(id As Integer) As Warehouse
        Return _warehouses.Find(Function(c) c.id = id)
    End Function
    Function findWarehouseByName(name As String) As Warehouse
        Return _warehouses.Find(Function(c) c.name = name)
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
            If SQLDriver.sqlExeNonQuery("UPDATE INV_employees SET name = '" & emp.name & "',password = '" & emp.password & "', position=' " & emp.position.id & "', phone = '" & emp.phone & "', access_lv = " & emp.access_lv & " WHERE id = " & emp.id) Then
                Return True
            End If
        Else
            If SQLDriver.sqlExeNonQuery("UPDATE INV_employees SET name = '" & emp.name & "', position=' " & emp.position.id & "', phone = '" & emp.phone & "', access_lv = " & emp.access_lv & " WHERE id = " & emp.id) Then
                Return True
            End If
        End If
        Return False

    End Function

    Function addEmployee(emp As Employee)
        If Not _employees.Find(Function(c) c.name = emp.name) IsNot Nothing Then
            If SQLDriver.sqlExeNonQuery("INSERT INTO INV_employees VALUES('" & emp.name & "','" & emp.username & "','" & createhashMD5(emp.password) & "','" _
                                        & emp.position.id & "','" & emp.phone & "'," & emp.access_lv & ")") Then
                Return True
            End If
        Else
            MsgBox("Taki pracownik już istnieje.")

        End If
        Return False

    End Function
    Public Function deleteEmployee(emp As Employee)
        If SQLDriver.sqlExeNonQuery("DELETE FROM INV_employees WHERE id =" & emp.id) Then
            Return True
        End If
        Return False
    End Function
    Public Function findEmployeeById(id As Integer) As Employee
        Return employees.Find(Function(c) c.id = id)
    End Function
    Public Function findEmployeeByName(name As String) As Employee
        Return employees.Find(Function(c) c.name = name)
    End Function

    Public Function findEmployeeRelations(id As Integer, mode As Integer) As DataTable
        'mode  0 - warehouses, 1 - machines
        Dim tmp As DataTable
        Select Case mode
            Case 0
                tmp = SQLDriver.sqlExeQuery("SELECT * FROM INV_warehouses where resp_employee = " & id)
            Case 1
                tmp = SQLDriver.sqlExeQuery("SELECT * FROM INV_machinery where resp_employee = " & id)
        End Select

        Return tmp
    End Function



#End Region


#Region "manufacturers"

    Sub populateManufacturers()
        Dim s = "SELECT * FROM INV_manufacturers;"
        Dim dtManufacturers = SQLDriver.sqlExeQuery(s)
        _manufacturers.Clear()
        For Each d As DataRow In dtManufacturers.Rows
            _manufacturers.Add(New Manufacturer(d.Field(Of String)("name"), d.Field(Of String)("location"), d.Field(Of String)("phone"), d.Field(Of String)("idx"), d.Field(Of Integer)("id"))) ' dont know (?) if image will work correctly
        Next

    End Sub

    Function findManufacturerById(id As Integer)
        Globals.populateManufacturers()
        Return _manufacturers.Find(Function(c) c.id = id)
    End Function

    Function findManufacturerByName(name As String)
        Globals.populateManufacturers()
        Return _manufacturers.Find(Function(c) c.name = name)
    End Function

    Function findManufacturerByIdx(idx As String)
        Globals.populateManufacturers()
        Return _manufacturers.Find(Function(c) c.idx = idx)
    End Function

    Function addManufacturer(manu As Manufacturer)
        If SQLDriver.sqlExeNonQuery("INSERT INTO INV_manufacturers VALUES('" & manu.name & "','" & manu.location & "','" & manu.phone & "','" & manu.idx & "')") Then
            Return True
        Else
            MsgBox("Wystąpił błąd podczas zapisu danych.")
        End If
        Return False
    End Function

#End Region

#Region "types"
    Sub populateTypes()
        Dim s = "SELECT * FROM INV_types;"
        Dim dtTypes = SQLDriver.sqlExeQuery(s)
        _types.Clear()
        For Each d As DataRow In dtTypes.Rows
            _types.Add(New Type(d.Field(Of String)("name"), d.Field(Of Integer)("id")))
        Next

    End Sub
    Public Function addType(Type As Type)
        'check if exists
        If Not _types.Find(Function(c) c.name = Type.name) IsNot Nothing Then
            If SQLDriver.sqlExeNonQuery("INSERT INTO INV_types VALUES('" & Type.name & "')") Then
                Return True
            End If
        Else
            MsgBox("Taki typ już istnieje.")
        End If
        Return False
    End Function

    Public Function saveType(type As Type)
        'check if not empty
        If type.name <> "" Then
            If SQLDriver.sqlExeNonQuery("UPDATE INV_types SET name = '" & type.name & "' WHERE id = " & type.id) Then
                Return True
            End If
        End If
        Return False

    End Function
    Function findTypeById(id As Integer)
        Return _types.Find(Function(c) c.id = id)
    End Function


#End Region

#Region "parts"
    Sub populateParts()
        Dim s = "SELECT * FROM INV_parts;"
        Dim dtParts = SQLDriver.sqlExeQuery(s)
        _parts.Clear()
        Dim manu As Manufacturer
        For Each d As DataRow In dtParts.Rows
            manu = findManufacturerById(d.Field(Of Integer)("manufacturer_id"))
            _parts.Add(New Part(d.Field(Of String)("name"), d.Field(Of String)("specification"), d.Field(Of String)("catalog_number"), manu, d.Field(Of Integer)("id")))
        Next
    End Sub

    Public Function addPart(part As Part)
        'check if exists
        If Not _parts.Find(Function(c) c.name = part.name) IsNot Nothing Then
            If SQLDriver.sqlExeNonQuery("INSERT INTO INV_parts(name,specification,manufacturer_id) VALUES('" & part.name & "','" & part.specification & "'," & part.manufacturer.id & ")") Then
                Return True
            End If
        Else
            MsgBox("Taki typ już istnieje.")
        End If
        Return False
    End Function

    Public Function savePart(part As Part)
        'check if not empty
        If part.name <> "" Then
            If SQLDriver.sqlExeNonQuery("UPDATE INV_types Set name = '" & part.name & "', specification='" & part.specification & "', manufacturer_id=" & part.manufacturer.id & " WHERE id = " & part.id) Then
                Return True
            End If
        End If
        Return False
    End Function

    Public Function findPartById(id As Integer) As Part
        Return _parts.Find(Function(c) c.id = id)
    End Function



#End Region


#Region "machines"
    Sub populateMachines()
        Dim s = "SELECT * FROM INV_machinery;"
        Dim dtMachinery = SQLDriver.sqlExeQuery(s)
        _machines.Clear()
        For Each d As DataRow In dtMachinery.Rows
            Dim dept = _departments.Find(Function(c) c.id = d.Field(Of Integer)("department_id"))
            Dim emp = _employees.Find(Function(c) c.id = d.Field(Of Integer)("resp_employee"))
            Dim type = _types.Find(Function(c) c.id = d.Field(Of Integer)("type_id"))
            Dim manu = _manufacturers.Find(Function(c) c.id = d.Field(Of Integer)("manufacturer_id"))
            Dim parts = New List(Of Part)

            If d.Field(Of String)("parts") <> "" Then
                If d.Field(Of String)("parts").Length = 1 Then
                    parts.Add(findPartById(CInt(d.Field(Of String)("parts"))))
                Else
                    For Each part_id In d.Field(Of String)("parts").Split(",")
                        parts.Add(findPartById(part_id))
                    Next
                End If
            End If


            'do this differently maybe?
            _machines.Add(New Machine(d.Field(Of String)("mach_name"), type, d.Field(Of String)("model"), manu, dept, d.Field(Of Integer)("stat"),
                                      d.Field(Of String)("barcode"), emp, picture:=convertInteger(d.Field(Of Integer)("picture_id")), parts:=parts, id:=d.Field(Of Integer)("id"))) ' dont know (?) if image will work correctly
        Next

    End Sub

    Function addMachine(mach As Machine)
        If Not _machines.Find(Function(c) (c.name = mach.name) And (c.model = mach.model)) IsNot Nothing Then
            If SQLDriver.sqlExeNonQuery("INSERT INV_machinery(mach_name,model,type_id,manufacturer_id,department_id,stat,barcode,resp_employee,parts) VALUES(" &
                    "'" & mach.name & "'," &
                    "'" & mach.model & "'," &
                    mach.type.id & "," &
                    mach.manufacturer.id & "," &
                    mach.department.id & "," &
                    mach.status & "," &
                    "'" & mach.barcode & "'," &
                    mach.resp_employee.id & "," &
                    "'" & partsExplode(mach.parts) & "')") Then Return True
        End If
        Return False
    End Function



    Function partsExplode(parts As List(Of Part)) As String
        Dim tmp As String = ""
        For Each part In parts
            tmp &= part.id & ","
        Next
        If tmp <> "" Then
            tmp = tmp.Substring(0, tmp.Length - 1)
        End If
        Return tmp
    End Function

    Function findMachineById(id As Integer) As Machine
        Return _machines.Find(Function(c) c.id = id)
    End Function

    Public Function saveMachine(mach As Machine)
        If _machines.Find(Function(c) c.id = mach.id) IsNot Nothing Then
            If SQLDriver.sqlExeNonQuery("UPDATE INV_machinery set " &
                "mach_name='" & mach.name & "'," &
                "model='" & mach.model & "'," &
                "type_id =" & mach.type.id & "," &
                "manufacturer_id =" & mach.manufacturer.id & "," &
                "department_id =" & mach.department.id & "," &
                "stat=" & mach.status & "," &
                "barcode='" & mach.barcode & "'," &
                "resp_employee =" & mach.resp_employee.id & "," &
                 "parts ='" & partsExplode(mach.parts) & "'," &
                 "picture_id=" & mach.picture &
               " WHERE id = " & mach.id) Then
                Return True
            End If
        Else
            If addMachine(mach) Then Return True
        End If
        Return False
    End Function
#End Region



#End Region


    Public Function resizeImage(pic As Image, scale As Double) As Image
        Dim ret As Image = pic
        If pic.Width * scale < 50 And pic.Height * scale < 50 Then

            Dim newScaleW = pic.Width / 50
            Dim newScaleH = pic.Height / 50
            ret = New Bitmap(pic, New Size(pic.Width * newScaleW, pic.Height * newScaleH))
        ElseIf pic.Width * scale > 1000 And pic.Height * scale > 1000 Then

            Dim newScaleW = pic.Width / 1000
            Dim newScaleH = pic.Height / 1000
            ret = New Bitmap(pic, New Size(pic.Width * newScaleW, pic.Height * newScaleH))
        Else

            ret = New Bitmap(pic, New Size(pic.Width * scale, pic.Height * scale))
        End If

        Return ret
    End Function


    Private Function convertInteger(intInteger As Object) As Integer

        If IsDBNull(intInteger) Then
            Return -1
        End If

        Return intInteger

    End Function

    'based on https://www.codeproject.com/Articles/437937/Save-and-Retrieve-Image-from-a-SQL-Server-Database
    Public Function getImageFromBytes(data As Byte()) As Image
        Dim img = Nothing
        If data IsNot Nothing Then
            Using ms As New MemoryStream(data, 0, data.Length)
                ms.Write(data, 0, data.Length)
                img = Image.FromStream(ms, True)
            End Using
        End If
        Return img
    End Function

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
