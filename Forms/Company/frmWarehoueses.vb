Imports AssetsManager.Misc.SQLDriver

Public Class frmWarehouses
    Dim dtWarehouses As DataTable = New DataTable
    Dim _wrhs As Warehouse
    Sub loadData(Optional setCell = True)

        Dim tmpCell = Nothing
        If dgvWarehouses.CurrentCell IsNot Nothing Then
            tmpCell = {dgvWarehouses.CurrentCell.RowIndex, dgvWarehouses.CurrentCell.ColumnIndex}
        End If

        Globals.populateWarehouses()
        Globals.populateDepartments()
        Globals.populateEmployees()

        dtWarehouses.Clear()


        For Each wrhs As Warehouse In Globals.warehouses
            Dim emp = Globals.employees.Find(Function(c) c.id = wrhs.resp_employee.id)
            Dim dept = Globals.departments.Find(Function(c) c.id = wrhs.department.id)
            dtWarehouses.Rows.Add({wrhs.id, wrhs.name, wrhs.idx, dept.name, wrhs.description, emp.name})
        Next

        dgvWarehouses.DataSource = dtWarehouses

        If tmpCell IsNot Nothing And setCell Then
            dgvWarehouses.Rows(tmpCell(0)).Cells(tmpCell(1)).Selected = True
        End If


    End Sub
    Private Sub frmWarehouses_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Globals.SetDoubleBuffered(dgvWarehouses, True)
        dtWarehouses.Columns.Clear()
        dtWarehouses.Columns.Add("id")
        dtWarehouses.Columns.Add("name")
        dtWarehouses.Columns.Add("idx")
        dtWarehouses.Columns.Add("department")
        dtWarehouses.Columns.Add("description")
        dtWarehouses.Columns.Add("resp_employee")

        If Globals.loggedEmployee.access_lv > 3 Then
            btnAdd.Enabled = True
            btnAdd.Visible = True
        End If

        loadData()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmWarehousesEdit.adding = True
        frmWarehousesEdit.ShowDialog()

        loadData()
    End Sub

    Private Sub dgvDepartments_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvWarehouses.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim curRow = dgvWarehouses.CurrentRow.Index
            Dim frmWrhs = New frmWarehousesEdit
            frmWrhs.setWrhs(Globals.findWarehouseById(dgvWarehouses.Rows(curRow).Cells(0).Value))
            frmWrhs.TopMost = True
            frmWrhs.Show()


            loadData()
        End If
    End Sub

    Private Sub dgvDepartments_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvWarehouses.MouseClick
        If e.Button = MouseButtons.Right Then
            dgvWarehouses.ClearSelection()
            If dgvWarehouses.HitTest(e.X, e.Y).RowIndex > -1 And dgvWarehouses.HitTest(e.X, e.Y).ColumnIndex > -1 Then
                dgvWarehouses.Rows(dgvWarehouses.HitTest(e.X, e.Y).RowIndex).Cells(dgvWarehouses.HitTest(e.X, e.Y).ColumnIndex).Selected = True
                Dim location = Cursor.Position
                ContextMenuStrip1.Show(location)
            End If
        End If
    End Sub
    Private Sub DodajToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodajToolStripMenuItem.Click
        frmWarehousesEdit.ShowDialog()
        loadData()
    End Sub

    Private Sub EdytujToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EdytujToolStripMenuItem.Click
        Dim curRow = dgvWarehouses.CurrentRow.Index
        If dgvWarehouses.CurrentRow.Index > 0 Then

            Dim frmWrhs = New frmWarehousesEdit
            frmWrhs.setWrhs(Globals.findWarehouseById(dgvWarehouses.Rows(curRow).Cells(0).Value))
            frmWrhs.Show()
            loadData()
        End If
    End Sub

    Private Sub UsuńToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuńToolStripMenuItem.Click
        If MsgBox("Czy na pewno chcesz usunąć ten magazyn?", MsgBoxStyle.YesNo, "Usuwanie magazynu") = MsgBoxResult.Yes Then
            Dim curRow = dgvWarehouses.CurrentRow.Index
            If checkIfInUse(Globals.findWarehouseById(dgvWarehouses.Rows(curRow).Cells(0).Value)) Then
                MsgBox("Nie można usunąć magazynu który jest w użyciu!")
            Else
                Debug.Print("usuwam " & dgvWarehouses.SelectedRows(0).Cells(1).Value)
                'SQLDriver.sqlExeNonQuery("DELETE FROM INV_warehouses WHERE id = " & dgvWarehouses.SelectedRows(0).Cells(0).Value)
                Globals.deleteWarehouse(Globals.findWarehouseById(dgvWarehouses.Rows(curRow).Cells(0).Value))
                MsgBox("Usunięto magazyn " & dgvWarehouses.Rows(curRow).Cells(1).Value)
            End If
            loadData()
        End If
    End Sub

    Private Sub frmWarehouses_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            loadData(False)
        End If
    End Sub
End Class