Imports AssetsManager.Misc.SQLDriver

Public Class frmWarehouses
    Dim dtWarehouses As DataTable = New DataTable
    Dim _wrhs As Warehouse
    Sub loadData()

        Globals.populateWarehouses()
        Globals.populateDepartments()
        Globals.populateEmployees()

        dtWarehouses.Clear()
        dtWarehouses.Columns.Clear()
        dtWarehouses.Columns.Add("id")
        dtWarehouses.Columns.Add("name")
        dtWarehouses.Columns.Add("idx")
        dtWarehouses.Columns.Add("department")
        dtWarehouses.Columns.Add("description")
        dtWarehouses.Columns.Add("resp_employee")

        For Each wrhs As Warehouse In Globals.warehouses
            Dim emp = Globals.employees.Find(Function(c) c.id = wrhs.resp_employee)
            Dim dept = Globals.departments.Find(Function(c) c.id = wrhs.department.id)
            dtWarehouses.Rows.Add({wrhs.id, wrhs.name, wrhs.idx, dept.name, wrhs.description, emp.name})
        Next

        dgvWarehouses.DataSource = dtWarehouses

    End Sub
    Private Sub frmWarehouses_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Globals.SetDoubleBuffered(dgvWarehouses, True)
        loadData()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmWarehousesEdit.ShowDialog()
        loadData()
    End Sub

    Private Sub dgvDepartments_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvWarehouses.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim emp = Globals.employees.Find(Function(c) c.name = dgvWarehouses.Rows(e.RowIndex).Cells(5).Value)
            Dim dept = Globals.departments.Find(Function(c) c.name = dgvWarehouses.Rows(e.RowIndex).Cells(3).Value)

            Dim wrhs As Warehouse = New Warehouse(dgvWarehouses.Rows(e.RowIndex).Cells(1).Value, dgvWarehouses.Rows(e.RowIndex).Cells(4).Value, dgvWarehouses.Rows(e.RowIndex).Cells(2).Value,
                                                  dept, emp, dgvWarehouses.Rows(e.RowIndex).Cells(0).Value)
            Dim frmWrhs = New frmWarehousesEdit
            frmWrhs.Show()

            loadData()
        End If
    End Sub

    Private Sub dgvDepartments_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvWarehouses.MouseClick
        If e.Button = MouseButtons.Right Then
            dgvWarehouses.ClearSelection()
            If dgvWarehouses.HitTest(e.X, e.Y).RowIndex > -1 And dgvWarehouses.HitTest(e.X, e.Y).ColumnIndex > -1 Then
                dgvWarehouses.Rows(dgvWarehouses.HitTest(e.X, e.Y).RowIndex).Selected = True
                Dim location = Cursor.Position
                ContextMenuStrip1.Show(location)
            End If
        End If
    End Sub
    Sub setWrhs()
        Dim curRow = dgvWarehouses.CurrentRow.Index
        _wrhs = New Warehouse(dgvWarehouses.Rows(curRow).Cells(1).Value, dgvWarehouses.Rows(curRow).Cells(4).Value, dgvWarehouses.Rows(curRow).Cells(2).Value,
                              dgvWarehouses.Rows(curRow).Cells(3).Value, dgvWarehouses.Rows(curRow).Cells(5).Value, dgvWarehouses.Rows(curRow).Cells(0).Value)
    End Sub

    Private Sub DodajToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodajToolStripMenuItem.Click
        frmWarehousesEdit.ShowDialog()
        loadData()
    End Sub

    Private Sub EdytujToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EdytujToolStripMenuItem.Click
        Dim curRow = dgvWarehouses.CurrentRow.Index
        If dgvWarehouses.CurrentRow.Index > 0 Then
            Dim wrhs As Warehouse = New Warehouse(dgvWarehouses.Rows(curRow).Cells(1).Value, dgvWarehouses.Rows(curRow).Cells(4).Value, dgvWarehouses.Rows(curRow).Cells(2).Value,
                                                  Globals.findDepartmentByName(dgvWarehouses.Rows(curRow).Cells(3).Value), Globals.findEmployeeByName(dgvWarehouses.Rows(curRow).Cells(5).Value), dgvWarehouses.Rows(curRow).Cells(0).Value)
            Dim frmWrhs = New frmWarehousesEdit

            frmWrhs.Show()
            loadData()
        End If
    End Sub

    Private Sub UsuńToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuńToolStripMenuItem.Click
        Debug.Print("ID: " & dgvWarehouses.SelectedRows(0).Cells(0).Value)
        If checkIfInUse(_wrhs) Then
            MsgBox("Nie można usunąć magazynu który jest w użyciu!")
        Else
            Debug.Print("usuwam " & dgvWarehouses.SelectedRows(0).Cells(1).Value)
            ' SQLDriver.sqlExeNonQuery("DELETE FROM INV_departments WHERE id = " & dgvDepartments.SelectedRows(1).Cells(1).Value)
        End If
    End Sub


End Class