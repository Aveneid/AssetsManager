Public Class frmPartSelect
    Public Property Parts As List(Of Part) = Nothing
    Dim prts As List(Of Part)

    Private Sub frmPartSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Globals.populateManufacturers()
        Globals.populateParts()

        For Each part In Globals.parts
            dgvParts.Rows.Add({part.id, False, part.name, part.specification, part.catalog_no, part.manufacturer.name})
        Next
        prts = New List(Of Part)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        For Each row As DataGridViewRow In dgvParts.Rows
            If row.Cells(1).Value = True Then
                prts.Add(Globals.findPartById(row.Cells(0).Value))
            End If
        Next
        Parts = prts
        Me.Close()
    End Sub
End Class