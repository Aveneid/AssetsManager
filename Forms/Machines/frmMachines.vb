Imports AssetsManager.Misc

Public Class frmMachines
    Dim dtMachines As DataTable = New DataTable
    Dim _mach As Employee

    Sub loadData(Optional setCell = True)
        Dim tmpCell = Nothing
        If dgvMachines.CurrentCell IsNot Nothing Then
            tmpCell = {dgvMachines.CurrentCell.RowIndex, dgvMachines.CurrentCell.ColumnIndex}
        End If
        Globals.populateMachines()
        dtMachines.Clear()
        For Each mach As Machine In Globals.machines
            Dim img = Nothing
            img = SQLDriver.sqlRetreiveImage(mach.picture)
            dtMachines.Rows.Add({mach.id, mach.name, mach.model, mach.type.name, mach.manufacturer.name, mach.department.name, mach.status, mach.resp_employee.name, img})
        Next
        dgvMachines.DataSource = dtMachines
        If tmpCell IsNot Nothing And setCell Then
            dgvMachines.Rows(tmpCell(0)).Cells(tmpCell(1)).Selected = True
        End If
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        frmMachinesEdit.ShowDialog()
        frmMachinesEdit.Dispose()
        loadData()

    End Sub

    Private Sub frmMachines_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Globals.SetDoubleBuffered(dgvMachines, True)
        dtMachines.Columns.Clear()

        dtMachines.Columns.Add("id")
        dtMachines.Columns.Add("mach_name")
        dtMachines.Columns.Add("model")
        dtMachines.Columns.Add("type")
        dtMachines.Columns.Add("manufacturer")
        dtMachines.Columns.Add("department")
        dtMachines.Columns.Add("status")
        dtMachines.Columns.Add("resp_employee")
        dtMachines.Columns.Add("picture", GetType(Image))

        loadData()

        If Globals.loggedEmployee.access_lv > 3 Then
            btnAdd.Visible = True
        End If

    End Sub

    Private Sub dgvMachines_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMachines.CellDoubleClick
        Dim curRow = dgvMachines.CurrentRow.Index
        Dim frm = frmMachinesEdit
        frm.setMachine(Globals.findMachineById(dgvMachines.Rows(curRow).Cells(0).Value))
        frm.ShowDialog()
        frm.Dispose()
        loadData()

    End Sub

    Dim lastPress = 0
    Private Sub KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If lastPress = 0 Then
            lastPress = (DateTime.Now - New DateTime(1970, 1, 1)).TotalMilliseconds
            loadData()
        End If
        Dim curPress = (DateTime.Now - New DateTime(1970, 1, 1)).TotalMilliseconds

        If curPress - lastPress > 3000 Then
            loadData()
            frmMain.ToolStripStatusLabel1.Text = "last refresh: " & New DateTime(lastPress).ToString
            lastPress = curPress
        Else
            frmMain.ToolStripStatusLabel1.Text = "not refreshed: " & New DateTime(lastPress).ToString
        End If
    End Sub
End Class