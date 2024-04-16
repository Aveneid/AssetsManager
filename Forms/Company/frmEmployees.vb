Imports AssetsManager.Misc.SQLDriver

Public Class frmEmployees
    Dim dtEmployees As DataTable = New DataTable
    Dim _emp As Employee
    Sub loadData(Optional setCell = True)
        Dim tmpCell = Nothing
        If dgvEmployees.CurrentCell IsNot Nothing Then
            tmpCell = {dgvEmployees.CurrentCell.RowIndex, dgvEmployees.CurrentCell.ColumnIndex}
        End If

        Globals.populateEmployees()
        dtEmployees.Clear()


        For Each emp As Employee In Globals.employees
            dtEmployees.Rows.Add({emp.id, emp.name, emp.positionName, emp.phone, emp.access_lv})
        Next

        dgvEmployees.DataSource = dtEmployees
        If tmpCell IsNot Nothing And setCell Then
            dgvEmployees.Rows(tmpCell(0)).Cells(tmpCell(1)).Selected = True
        End If
    End Sub
    Private Sub frmEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Globals.SetDoubleBuffered(dgvEmployees, True)
        dtEmployees.Columns.Clear()


        dtEmployees.Columns.Add("id")
        dtEmployees.Columns.Add("name")
        dtEmployees.Columns.Add("position")
        dtEmployees.Columns.Add("phone")
        dtEmployees.Columns.Add("access_lv")
        loadData()

        If Globals.loggedEmployee.access_lv > 3 Then
            btnAdd.Visible = True
            btnAdd.Enabled = True
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmEmployeesEdit.ShowDialog()
        loadData()
    End Sub

    Private Sub dgvEmployees_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployees.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim curRow = dgvEmployees.CurrentRow.Index
            Dim frmEmp = New frmEmployeesEdit
            frmEmp.setEmp(Globals.findEmployeeById(dgvEmployees.Rows(curRow).Cells(0).Value))
            frmEmp.TopMost = True

            frmEmp.ShowDialog()

            loadData()

        End If
    End Sub

    Private Sub dgvEmployees_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvEmployees.MouseClick
        If e.Button = MouseButtons.Right Then

            dgvEmployees.ClearSelection()
            If dgvEmployees.HitTest(e.X, e.Y).RowIndex > -1 And dgvEmployees.HitTest(e.X, e.Y).ColumnIndex > -1 Then
                dgvEmployees.Rows(dgvEmployees.HitTest(e.X, e.Y).RowIndex).Cells(dgvEmployees.HitTest(e.X, e.Y).ColumnIndex).Selected = True

                Dim location = Cursor.Position
                ContextMenuStrip1.Show(location)
            End If
        End If
    End Sub

    Private Sub DodajToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodajToolStripMenuItem.Click
        frmEmployeesEdit.setEmp(New Employee(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        frmEmployeesEdit.ShowDialog()
        loadData()
    End Sub

    Private Sub EdytujToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EdytujToolStripMenuItem.Click
        Dim curRow = dgvEmployees.CurrentRow.Index
        If curRow >= 0 Then
            Dim frmEmp = New frmEmployeesEdit
            frmEmp.setEmp(Globals.findEmployeeById(dgvEmployees.Rows(curRow).Cells(0).Value))
            frmEmp.TopMost = True
            frmEmp.ShowDialog()
            loadData()

        End If
    End Sub
    Private Sub UsuńToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuńToolStripMenuItem.Click
        If MsgBox("Czy na pewno chcesz usunąć tego użytkownika?", MsgBoxStyle.YesNo, "Usuwanie użytkownika") = MsgBoxResult.Yes Then


            Dim curRow = dgvEmployees.CurrentRow.Index
            If checkIfAdmin(Globals.findEmployeeById(dgvEmployees.Rows(curRow).Cells(0).Value)) Then
                Exit Sub
            End If
            If checkIfInUse(Globals.findEmployeeById(dgvEmployees.Rows(curRow).Cells(0).Value)) Then
                MsgBox("Nie można usunąć pracownka który przypisany!")
            Else
                Debug.Print("usuwam " & dgvEmployees.SelectedRows(0).Cells(1).Value)
                Globals.deleteEmployee(Globals.findEmployeeById(dgvEmployees.Rows(curRow).Cells(0).Value))
                MsgBox("Usunięto użytkownika " & dgvEmployees.Rows(curRow).Cells(1).Value)
            End If
            loadData(False)
        End If
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        ContextMenuStrip1.Items(0).Enabled = True
        ContextMenuStrip1.Items(3).Enabled = True
        ContextMenuStrip1.Items(1).Enabled = True
        ContextMenuStrip1.Items(2).Enabled = True

        If Globals.loggedEmployee.access_lv < 4 Then
            ContextMenuStrip1.Items(0).Enabled = False
            ContextMenuStrip1.Items(3).Enabled = False

            If Globals.loggedEmployee.id <> dgvEmployees.CurrentRow.Cells(0).Value Then
                ContextMenuStrip1.Items(1).Enabled = False
            End If
        End If
    End Sub

    Private Sub frmEmployees_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            loadData(False)
        End If
    End Sub

    Private Sub ĄzaniaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĄzaniaToolStripMenuItem.Click
        Dim curRow = dgvEmployees.CurrentRow.Index
        Dim frm = FindEmployeeRelations
        frm._emp = Globals.findEmployeeById(dgvEmployees.Rows(curRow).Cells(0).Value)
        frm.TopMost = True

        frm.ShowDialog()

    End Sub
End Class
