Public Class frmWarehousesEdit
    Private Sub frmWarehouses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Globals.populateDepartments()
        Globals.populateWarehouses()
        Globals.populateEmployees()

        cbWarehouses.Items.Add("--- Dodaj ---")
        For Each dep As Department In Globals.departments
            cbWrhsDepartment.Items.Add(New DictionaryEntry(dep.name, dep.id))
        Next

        For Each wrhs As Warehouse In Globals.warehouses
            cbWarehouses.Items.Add(New DictionaryEntry(wrhs.name, wrhs.id))
        Next

        For Each emp As Employee In Globals.employees
            cbWrhsRespEmployee.Items.Add(New DictionaryEntry(emp.name, emp.id))
        Next

        checkUserAccessLevel()

    End Sub

    Sub checkUserAccessLevel()
        If Globals.loggedEmployee.access_lv < 4 Then
            tbWrhsDescription.Enabled = False
            tbWrhsIdx.Enabled = False
            tbWrhsName.Enabled = False
            cbWarehouses.Enabled = False
            cbWrhsDepartment.Enabled = False
            cbWrhsRespEmployee.Enabled = False
            btnEditSave.Enabled = False
        End If
    End Sub

    Private Sub btnEditSave_Click(sender As Object, e As EventArgs) Handles btnEditSave.Click

        Dim reloadData As Boolean = False
        If btnEditSave.Text = "Edytuj" Then
            tbWrhsDescription.Enabled = True
            cbWrhsDepartment.Enabled = True
            tbWrhsName.Enabled = True
            tbWrhsIdx.Enabled = True
            cbWrhsRespEmployee.Enabled = True

            cbWarehouses.Enabled = False

            btnEditSave.Text = "Zapisz"

        ElseIf btnEditSave.Text = "Zapisz" Then
            Dim wrhs = Globals.warehouses.Find(Function(c) c.id = cbWarehouses.SelectedItem.value)
            If saveWarehouses(New Warehouse(tbWrhsName.Text, tbWrhsDescription.Text, tbWrhsIdx.Text, Globals.findDepartmentById(cbWrhsDepartment.SelectedItem.value), Globals.findEmployeeById(cbWrhsRespEmployee.SelectedItem.value), wrhs.id)) Then
                cbWarehouses.Enabled = True
                btnEditSave.Text = "Edytuj"
            Else
                MsgBox("Wystąpił błąd przy zapisywaniu.")
            End If
            reloadData = True

        ElseIf btnEditSave.Text = "Dodaj" Then
            'add here
            If addWarehouse(New Warehouse(tbWrhsName.Text, tbWrhsDescription.Text, tbWrhsIdx.Text, Globals.findDepartmentById(cbWrhsDepartment.SelectedItem.value), Globals.findEmployeeById(cbWrhsRespEmployee.SelectedItem.value))) Then
                reloadData = True
                btnEditSave.Text = "Edytuj"
            End If
        End If

        If reloadData Then
            Dim tmp = cbWarehouses.SelectedIndex
            Globals.populateWarehouses()
            cbWarehouses.Items.Clear()
            cbWarehouses.Items.Add("--- Dodaj ---")
            For Each wrhs As Warehouse In Globals.warehouses
                cbWarehouses.Items.Add(New DictionaryEntry(wrhs.name, wrhs.id))
            Next
            cbWarehouses.SelectedIndex = tmp
            tbWrhsDescription.Enabled = False
            cbWrhsDepartment.Enabled = False
            tbWrhsName.Enabled = False
            tbWrhsIdx.Enabled = False

            cbWarehouses.Enabled = True
        End If

    End Sub

    Private Sub cbWarehouses_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbWarehouses.SelectedValueChanged
        If cbWarehouses.SelectedItem IsNot Nothing And cbWarehouses.SelectedIndex > 0 Then


            Dim wrhs = Globals.warehouses.Find(Function(c) c.id = cbWarehouses.SelectedItem.value)
            tbWrhsName.Text = wrhs.name

            For Each item In cbWrhsDepartment.Items
                If item.GetType().ToString <> "System.String" Then
                    If item.value = wrhs.department.id Then
                        cbWrhsDepartment.SelectedItem = item
                        Exit For
                    End If
                End If
            Next

            tbWrhsDescription.Text = wrhs.description
            tbWrhsIdx.Text = wrhs.idx

            For Each item In cbWrhsRespEmployee.Items
                If item.GetType().ToString <> "System.String" Then
                    If item.value = wrhs.resp_employee Then
                        cbWrhsRespEmployee.SelectedItem = item
                        Exit For
                    End If
                End If
            Next




        End If
        If cbWarehouses.Text = "--- Dodaj ---" Then
            tbWrhsDescription.Enabled = True
            ' tbDeptLocation.Enabled = True
            tbWrhsName.Enabled = True
            tbWrhsIdx.Enabled = True

            cbWrhsDepartment.Enabled = True
            cbWrhsRespEmployee.Enabled = True



            tbWrhsDescription.Text = ""
            tbWrhsIdx.Text = ""
            ' tbDeptLocation.Text = ""
            tbWrhsName.Text = ""


            btnEditSave.Text = "Dodaj"
        End If
    End Sub

    Private Sub frmWarehousesEdit_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class