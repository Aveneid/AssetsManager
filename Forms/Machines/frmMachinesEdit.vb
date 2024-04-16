Imports AssetsManager.Misc

Public Class frmMachinesEdit


    Public _mach As Machine = Nothing
    Dim _machineParts As List(Of Part)
    Dim _picture As Picture

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        'picture add
        Using f2 As New frmPictureSelect
            f2.ShowDialog()
            _picture = f2.selectedImage
            If _picture IsNot Nothing Then
                _mach.setPicture(_picture)
                machine_picture.Image = _picture.image
            End If
        End Using
    End Sub

    Sub setMachine(mach As Machine)
        _mach = mach
    End Sub
    Private Sub frmMachinesEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Globals.populateDepartments()
        Globals.populateTypes()
        Globals.populateManufacturers()
        Globals.populateEmployees()
        Globals.populateMachines()
        Globals.populateParts()

        loadData()



        checkUserAccess()
    End Sub
    Sub loadData()

        Globals.populateTypes()
        Dim tmpType = Nothing
        If cbMachineType.SelectedItem IsNot Nothing Then
            tmpType = cbMachineType.SelectedItem
        End If
        cbMachineType.Items.Clear()
        For Each t In Globals.types
            cbMachineType.Items.Add(New DictionaryEntry(t.name, t.id))
        Next
        If tmpType IsNot Nothing Then
            cbMachineType.SelectedValue = tmpType.value
        End If

        Globals.populateManufacturers()
        Dim tmpManu = Nothing
        If cbMachineManufacturer.SelectedItem IsNot Nothing Then tmpManu = cbMachineManufacturer.SelectedItem
        cbMachineManufacturer.Items.Clear()
        For Each m In Globals.manufacturers
            cbMachineManufacturer.Items.Add(New DictionaryEntry(m.name, m.id))
        Next
        If tmpManu IsNot Nothing Then cbMachineManufacturer.SelectedValue = tmpManu.value





        Globals.populateDepartments()
        Dim tmpDept = Nothing
        If cbMachineDepartment.SelectedItem IsNot Nothing Then tmpDept = cbMachineDepartment.SelectedItem
        cbMachineDepartment.Items.Clear()
        For Each d In Globals.departments
            cbMachineDepartment.Items.Add(New DictionaryEntry(d.name, d.id))
        Next
        If tmpDept IsNot Nothing Then cbMachineDepartment.SelectedValue = tmpDept.value

        Globals.populateEmployees()
        Dim tmpEmp = Nothing
        If cbMachineRespEmployee.SelectedItem IsNot Nothing Then tmpEmp = cbMachineRespEmployee.SelectedItem
        cbMachineRespEmployee.Items.Clear()
        For Each emp In Globals.employees
            cbMachineRespEmployee.Items.Add(New DictionaryEntry(emp.name, emp.id))
        Next
        If tmpEmp IsNot Nothing Then cbMachineRespEmployee.SelectedValue = tmpEmp.value

        If _mach IsNot Nothing Then
            tbMachineName.Text = _mach.name
            tbMachineModel.Text = _mach.model


            For Each itm In cbMachineType.Items
                If itm.value = _mach.type.id Then
                    cbMachineType.SelectedItem = itm
                    Exit For
                End If
            Next

            For Each itm In cbMachineManufacturer.Items
                If itm.value = _mach.manufacturer.id Then
                    cbMachineManufacturer.SelectedItem = itm
                    Exit For
                End If
            Next

            For Each itm In cbMachineDepartment.Items
                If itm.value = _mach.department.id Then
                    cbMachineDepartment.SelectedItem = itm
                    Exit For
                End If
            Next


            For Each itm In cbMachineRespEmployee.Items
                If itm.value = _mach.resp_employee.id Then
                    cbMachineRespEmployee.SelectedItem = itm
                    Exit For
                End If
            Next

            If _mach.parts IsNot Nothing Then
                dgvMachineParts.Rows.Clear()
                For Each prt In _mach.parts
                    dgvMachineParts.Rows.Add({prt.id, prt.name, prt.specification, prt.catalog_no, prt.manufacturer.name})
                Next
            End If

            If _mach.picture > 0 Then
                machine_picture.Image = SQLDriver.sqlRetreiveImage(_mach.picture)
            Else
                machine_picture.Image = Nothing
            End If



            lbMachineName.Text = _mach.name

        End If



    End Sub
    Sub checkUserAccess()
        If Globals.loggedEmployee.access_lv > 2 Then
            tbMachineModel.Enabled = True
            tbMachineName.Enabled = True
            cbMachineDepartment.Enabled = True
            cbMachineManufacturer.Enabled = True
            cbMachineRespEmployee.Enabled = True
            cbMachineType.Enabled = True
            grpParts.Enabled = True
            grpImage.Enabled = True
            btnSave.Enabled = True
        End If
    End Sub

    Private Sub btnAddPart_Click(sender As Object, e As EventArgs) Handles btnAddPart.Click
        Using f2 As New frmPartSelect
            f2.ShowDialog()
            _machineParts = f2.Parts
            If _machineParts IsNot Nothing Then
                For Each part In _machineParts
                    dgvMachineParts.Rows.Add({part.id, part.name, part.specification, part.catalog_no, part.manufacturer.name})
                Next
            End If
        End Using
    End Sub
    Private Sub btnDeletePart_Click(sender As Object, e As EventArgs) Handles btnDeletePart.Click
        Dim curRow = dgvMachineParts.CurrentRow.Index
        If curRow >= 0 Then
            If MsgBox("Usunąć część " & dgvMachineParts.Rows(curRow).Cells(1).Value, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                '_mach.parts.Remove(Globals.findPartById(dgvMachineParts.Rows(curRow).Cells(0).Value))
                dgvMachineParts.Rows.Remove(dgvMachineParts.Rows(curRow))
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim parts As List(Of Part) = New List(Of Part)
        For Each row As DataGridViewRow In dgvMachineParts.Rows
            parts.Add(New Part(row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, Globals.findManufacturerByName(row.Cells(4).Value), row.Cells(0).Value))
        Next

        If _mach Is Nothing Then
            _mach = New Machine(tbMachineName.Text, Globals.findTypeById(cbMachineType.SelectedItem.value), tbMachineModel.Text,
                            Globals.findManufacturerById(cbMachineManufacturer.SelectedItem.value), Globals.findDepartmentById(cbMachineDepartment.SelectedItem.value),
                            Enums.Status.Working, "", Globals.findEmployeeById(cbMachineRespEmployee.SelectedItem.value), parts:=parts)
        Else
            _mach.parts = parts
        End If
        If Globals.saveMachine(_mach) Then lbMachineName.Text = _mach.name
    End Sub

    Private Sub btnAddType_Click(sender As Object, e As EventArgs) Handles btnAddType.Click
        frmTypeAdd.ShowDialog()
        loadData()
    End Sub

    Private Sub btnAddManufacturer_Click(sender As Object, e As EventArgs) Handles btnAddManufacturer.Click
        frmManufacturerAdd.ShowDialog()
        loadData()
    End Sub

    Private Sub btnAddDepartment_Click(sender As Object, e As EventArgs) Handles btnAddDepartment.Click
        frmDepartmentsEdit.ShowDialog()
        loadData()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        _mach.setPicture(Nothing)
        If Globals.saveMachine(_mach) Then loadData()
    End Sub
End Class