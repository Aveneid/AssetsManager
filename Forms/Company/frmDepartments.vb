Imports AssetsManager.Misc.SQLDriver

Public Class frmDepartments
    Dim dtDepartments As DataTable = New DataTable
    Dim _dept As Department
    Sub loadData(Optional setCell As Boolean = True)

        Dim tmpCell = Nothing
        If dgvDepartments.CurrentCell IsNot Nothing Then
            tmpCell = {dgvDepartments.CurrentCell.RowIndex, dgvDepartments.CurrentCell.ColumnIndex}
        End If
        Globals.populateDepartments()
        dtDepartments.Clear()


        For Each dpt As Department In Globals.departments
            dtDepartments.Rows.Add({dpt.id, dpt.name, dpt.idx, dpt.location, dpt.description})
        Next

        dgvDepartments.DataSource = dtDepartments

        If tmpCell IsNot Nothing And setCell Then

            dgvDepartments.Rows(tmpCell(0)).Cells(tmpCell(1)).Selected = True
        End If

    End Sub
    Private Sub frmDepartments_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Globals.SetDoubleBuffered(dgvDepartments, True)
        dtDepartments.Columns.Clear()


        dtDepartments.Columns.Add("id")
        dtDepartments.Columns.Add("name")
        dtDepartments.Columns.Add("idx")
        dtDepartments.Columns.Add("location")
        dtDepartments.Columns.Add("description")
        loadData()

        If Globals.loggedEmployee.access_lv > 3 Then
            btnAdd.Visible = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmDepartmentsEdit.ShowDialog()
        loadData()
    End Sub

    Private Sub dgvDepartments_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDepartments.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim frmDpt = New frmDepartmentsEdit
            frmDpt.setDept(Globals.findDepartmentById(dgvDepartments.Rows(e.RowIndex).Cells(0).Value))
            frmDpt.TopMost = True
            frmDpt.ShowDialog()

            loadData()
        End If
    End Sub

    Private Sub dgvDepartments_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvDepartments.MouseClick
        If e.Button = MouseButtons.Right Then
            dgvDepartments.ClearSelection()
            If dgvDepartments.HitTest(e.X, e.Y).RowIndex > -1 And dgvDepartments.HitTest(e.X, e.Y).ColumnIndex > -1 Then
                dgvDepartments.Rows(dgvDepartments.HitTest(e.X, e.Y).RowIndex).Cells(dgvDepartments.HitTest(e.X, e.Y).ColumnIndex).Selected = True
                Dim location = Cursor.Position
                ContextMenuStrip1.Show(location)
            End If
        End If
    End Sub

    Private Sub DodajToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodajToolStripMenuItem.Click
        frmDepartmentsEdit.ShowDialog()
        loadData()
    End Sub

    Private Sub EdytujToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EdytujToolStripMenuItem.Click
        Dim curRow = dgvDepartments.CurrentRow.Index
        If dgvDepartments.CurrentRow.Index > 0 Then
            Dim frmDpt = New frmDepartmentsEdit
            frmDpt.setDept(Globals.findDepartmentById(dgvDepartments.Rows(curRow).Cells(0).Value))
            frmDpt.TopMost = True
            frmDpt.Show()
            loadData()
        End If
    End Sub

    Private Sub UsuńToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuńToolStripMenuItem.Click
        If MsgBox("Czy na pewno chcesz usunąć ten wydział?", MsgBoxStyle.YesNo, "Usuwanie wydziału") = MsgBoxResult.Yes Then
            Dim curRow = dgvDepartments.CurrentRow.Index
            If checkIfInUse(Globals.findDepartmentById(dgvDepartments.Rows(curRow).Cells(0).Value)) Then
                MsgBox("Nie można usunąć wydziału który jest w użyciu!")
            Else
                Debug.Print("usuwam " & dgvDepartments.SelectedRows(0).Cells(1).Value)
                Globals.deleteDepartment(Globals.findDepartmentById(dgvDepartments.Rows(curRow).Cells(0).Value))
                MsgBox("Usunięto wydział " & dgvDepartments.Rows(curRow).Cells(1).Value)
            End If
            loadData(False)
        End If
    End Sub

    Private Sub frmDepartments_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            loadData(False)
        End If
    End Sub
End Class