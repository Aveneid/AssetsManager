Public Class frmManufacturerAdd
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If tbManufacturerIDX.Text.Length < 1 And tbManufacturerName.Text.Length < 1 Then
            MsgBox("Wypełnij wymagane pola: nazwa, indeks")
            Exit Sub
        End If
        If Globals.findManufacturerByIdx(tbManufacturerIDX.Text) = Nothing And Globals.findManufacturerByName(tbManufacturerName.Text) = Nothing Then
            If Globals.addManufacturer(New Manufacturer(tbManufacturerName.Text, tbManufacturerLocation.Text, tbManufacturerPhone.Text, tbManufacturerIDX.Text)) Then
                MsgBox("Dodano")
                tbManufacturerIDX.Text = ""
                tbManufacturerLocation.Text = ""
                tbManufacturerLocation.Text = ""
                tbManufacturerPhone.Text = ""
                tbManufacturerName.Text = ""
                tbManufacturerName.Select()
            End If
        Else
                MsgBox("Producent z takim indeksem lub nazwą już istnieje!")
        End If
    End Sub
End Class