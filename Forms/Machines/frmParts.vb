Public Class frmParts
    Private Sub frmParts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmPartEdit.ShowDialog()
    End Sub

    Sub loadData()
        Globals.populateManufacturers()
        Globals.populateParts()
        For Each part In Globals.parts
            dgvParts.Rows.Add({part.id, part.name, part.specification, part.catalog_no, part.manufacturer.name})
        Next
    End Sub

    Private Sub dgvParts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvParts.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim frmPrt = New frmPartEdit
            frmPartEdit.setPart(Globals.findPartById(dgvParts.Rows(e.RowIndex).Cells(0).Value))
            frmPartEdit.TopMost = True
            frmPartEdit.Show()

            loadData()
        End If

    End Sub
End Class