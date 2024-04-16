Public Class frmPartEdit
    Dim _part As Part = Nothing
    Private Sub frmPartEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Globals.populateParts()

        cbPartManufacturer.Items.Add(" --- DODAJ --- ")
        For Each manu In Globals.manufacturers
            cbPartManufacturer.Items.Add(New DictionaryEntry(manu.name, manu.id))
        Next

        If _part IsNot Nothing Then
            tbPartCatalogNo.Text = _part.catalog_no
            tbPartName.Text = _part.name
            tbPartSpecs.Text = _part.specification

            For Each itm In cbPartManufacturer.Items
                If itm.GetType.ToString <> "System.String" Then
                    If itm.value = _part.manufacturer.id Then
                        cbPartManufacturer.SelectedItem = itm
                        Exit For
                    End If
                End If
            Next
            btnEditSave.Text = "Edytuj"

            tbPartCatalogNo.Enabled = False
            tbPartName.Enabled = False
            tbPartSpecs.Enabled = False
            cbPartManufacturer.Enabled = False
            partID.Text = _part.id
        End If


    End Sub
    Sub setPart(part As Part)
        _part = part
    End Sub

    Private Sub btnEditSave_Click(sender As Object, e As EventArgs) Handles btnEditSave.Click

        'should i allow to edit parts or archive it?

        If btnEditSave.Text = "Edytuj" Then
            tbPartCatalogNo.Enabled = True
            tbPartName.Enabled = True
            tbPartSpecs.Enabled = True
            cbPartManufacturer.Enabled = True
            btnEditSave.Text = "Zapisz"
        ElseIf btnEditSave.Text = "Zapisz" Then
            Globals.savePart(New Part(tbPartName.Text, tbPartSpecs.Text, tbPartCatalogNo.Text, Globals.findManufacturerById(cbPartManufacturer.SelectedItem.value), _part.id))

        ElseIf btnEditSave.Text = "Dodaj" Then



        End If
    End Sub

    Private Sub cbPartManufacturer_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbPartManufacturer.SelectedValueChanged
        If cbPartManufacturer.SelectedIndex = 0 Then

            frmManufacturerAdd.ShowDialog()
                Globals.populateManufacturers()
                cbPartManufacturer.Items.Clear()
                cbPartManufacturer.Items.Add(" --- DODAJ --- ")
                For Each manu In Globals.manufacturers
                    cbPartManufacturer.Items.Add(New DictionaryEntry(manu.name, manu.id))
                Next

        End If
    End Sub
End Class