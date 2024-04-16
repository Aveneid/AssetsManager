Public Class frmWarehousesEdit
    Public adding As Boolean = False
    Public _wrhs As Warehouse = Nothing
    Sub setWrhs(wrhs As Warehouse)
        _wrhs = wrhs
    End Sub
    Private Sub frmWarehouses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Globals.populateDepartments()
        Globals.populateWarehouses()
        Globals.populateEmployees()

        For Each dep As Department In Globals.departments
            cbWrhsDepartment.Items.Add(New DictionaryEntry(dep.name, dep.id))
        Next

        For Each emp As Employee In Globals.employees
            cbWrhsRespEmployee.Items.Add(New DictionaryEntry(emp.name, emp.id))
        Next

        If _wrhs IsNot Nothing Then
            lbWarehouse.Text = _wrhs.name
            wrhsID.Text = _wrhs.id
            tbWrhsIdx.Text = _wrhs.idx
            tbWrhsName.Text = _wrhs.name
            tbWrhsDescription.Text = _wrhs.description

            For Each itm In cbWrhsDepartment.Items
                If itm.value = _wrhs.department.id Then
                    cbWrhsDepartment.SelectedItem = itm
                    Exit For
                End If
            Next

            For Each itm In cbWrhsRespEmployee.Items
                If itm.value = _wrhs.resp_employee.id Then
                    cbWrhsRespEmployee.SelectedItem = itm
                    Exit For
                End If
            Next

        End If



        'simple permission check
        Select Case Globals.loggedEmployee.access_lv
            Case 4 To 5
                tbWrhsName.Enabled = True
                tbWrhsDescription.Enabled = True
                tbWrhsIdx.Enabled = True
                cbWrhsDepartment.Enabled = True
                btnEditSave.Enabled = True
                cbWrhsRespEmployee.Enabled = True

                If _wrhs Is Nothing Then
                    lbWarehouse.Text = "nowy..."
                    btnEditSave.Text = "Dodaj"
                End If
        End Select

    End Sub





    Private Sub btnEditSave_Click(sender As Object, e As EventArgs) Handles btnEditSave.Click

        'rewrite this

        If btnEditSave.Text = "Zapisz" Then
            Dim wrhs = Globals.warehouses.Find(Function(c) c.id = CInt(wrhsID.Text))
            If saveWarehouses(New Warehouse(tbWrhsName.Text, tbWrhsDescription.Text, tbWrhsIdx.Text, Globals.findDepartmentById(cbWrhsDepartment.SelectedItem.value), Globals.findEmployeeById(cbWrhsRespEmployee.SelectedItem.value), wrhs.id)) Then
                btnEditSave.Text = "Edytuj"
            Else
                MsgBox("Wystąpił błąd przy zapisywaniu.")
            End If

        ElseIf btnEditSave.Text = "Dodaj" Then
            'add here
            If addWarehouse(New Warehouse(tbWrhsName.Text, tbWrhsDescription.Text, tbWrhsIdx.Text, Globals.findDepartmentById(cbWrhsDepartment.SelectedItem.value), Globals.findEmployeeById(cbWrhsRespEmployee.SelectedItem.value))) Then

                btnEditSave.Text = "Edytuj"
            End If
        ElseIf btnEditSave.Text = "Edytuj" Then
            tbWrhsDescription.Enabled = True
            cbWrhsDepartment.Enabled = True
            tbWrhsName.Enabled = True
            'tbWrhsIdx.Enabled = True
            cbWrhsRespEmployee.Enabled = True
            btnEditSave.Text = "Zapisz"
        End If


    End Sub

    'Private Sub cbWarehouses_SelectedValueChanged(sender As Object, e As EventArgs)
    '    If cbWarehouses.SelectedItem IsNot Nothing And cbWarehouses.SelectedIndex > 0 Then


    '        Dim wrhs = Globals.warehouses.Find(Function(c) c.id = cbWarehouses.SelectedItem.value)
    '        tbWrhsName.Text = wrhs.name

    '        For Each item In cbWrhsDepartment.Items
    '            If item.GetType().ToString <> "System.String" Then
    '                If item.value = wrhs.department.id Then
    '                    cbWrhsDepartment.SelectedItem = item
    '                    Exit For
    '                End If
    '            End If
    '        Next

    '        tbWrhsDescription.Text = wrhs.description
    '        tbWrhsIdx.Text = wrhs.idx

    '        For Each item In cbWrhsRespEmployee.Items
    '            If item.GetType().ToString <> "System.String" Then
    '                If item.value = wrhs.resp_employee Then
    '                    cbWrhsRespEmployee.SelectedItem = item
    '                    Exit For
    '                End If
    '            End If
    '        Next




    '    End If
    '    If cbWarehouses.Text = "--- Dodaj ---" Then
    '        tbWrhsDescription.Enabled = True
    '        ' tbDeptLocation.Enabled = True
    '        tbWrhsName.Enabled = True
    '        tbWrhsIdx.Enabled = True

    '        cbWrhsDepartment.Enabled = True
    '        cbWrhsRespEmployee.Enabled = True



    '        tbWrhsDescription.Text = ""
    '        tbWrhsIdx.Text = ""
    '        ' tbDeptLocation.Text = ""
    '        tbWrhsName.Text = ""


    '        btnEditSave.Text = "Dodaj"
    '    End If
    'End Sub

    Private Sub frmWarehousesEdit_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class