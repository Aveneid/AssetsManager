Public Class frmDepartmentsEdit

    Public _dept As Department
    Dim saved As Boolean = False
    Private Sub frmDepartments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Globals.populateDepartments()
        cbDepartments.Items.Add("--- Dodaj ---")
        For Each dep As Department In Globals.departments
            cbDepartments.Items.Add(New DictionaryEntry(dep.name, dep.id))
        Next

        If _dept IsNot Nothing Then
            For Each item In cbDepartments.Items
                If item.GetType().ToString <> "System.String" Then
                    If item.value = _dept.id Then
                        cbDepartments.SelectedItem = item
                        Exit For
                    End If
                End If
            Next

            'allow only editing current department
            cbDepartments.Enabled = False
            tbDeptDescription.Enabled = True
            tbDeptLocation.Enabled = True
            tbDeptName.Enabled = True
            tbDeptIdx.Enabled = True

            btnEditSave.Text = "Zapisz"
        End If

    End Sub
    Sub setDept(dept As Department)
        _dept = dept
    End Sub

    Private Sub cbDepartments_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbDepartments.SelectedValueChanged
        If cbDepartments.SelectedItem IsNot Nothing And cbDepartments.SelectedIndex > 0 Then
            Dim dep = Globals.departments.Find(Function(c) c.id = cbDepartments.SelectedItem.value)
            tbDeptName.Text = dep.name
            tbDeptLocation.Text = dep.location
            tbDeptDescription.Text = dep.description
            tbDeptIdx.Text = dep.idx

        End If

        If cbDepartments.Text = "--- Dodaj ---" Then
            tbDeptDescription.Enabled = True
            tbDeptLocation.Enabled = True
            tbDeptName.Enabled = True
            tbDeptIdx.Enabled = True

            cbDepartments.Enabled = False



            tbDeptDescription.Text = ""
            tbDeptIdx.Text = ""
            tbDeptLocation.Text = ""
            tbDeptName.Text = ""

            saved = False

            btnEditSave.Text = "Dodaj"
        End If

    End Sub


    Private Sub btnEditSave_Click(sender As Object, e As EventArgs) Handles btnEditSave.Click
        Dim reloadData As Boolean = False

        If _dept IsNot Nothing Then
            Dim dep = Globals.departments.Find(Function(c) c.id = cbDepartments.SelectedItem.value)
            If Not saveDepartments(New Department(tbDeptName.Text, tbDeptIdx.Text, tbDeptLocation.Text, tbDeptDescription.Text, dep.id)) Then
                MsgBox("Wystąpił błąd przy zapisywaniu.")
            End If
            Exit Sub
        End If


        If btnEditSave.Text = "Edytuj" Then
            tbDeptDescription.Enabled = True
            tbDeptLocation.Enabled = True
            tbDeptName.Enabled = True
            tbDeptIdx.Enabled = True

            cbDepartments.Enabled = False

            btnEditSave.Text = "Zapisz"

            saved = False

        ElseIf btnEditSave.Text = "Zapisz" Then
            Dim dep = Globals.departments.Find(Function(c) c.id = cbDepartments.SelectedItem.value)
            If saveDepartments(New Department(tbDeptName.Text, tbDeptIdx.Text, tbDeptLocation.Text, tbDeptDescription.Text, dep.id)) Then
                cbDepartments.Enabled = True
                btnEditSave.Text = "Edytuj"
            Else
                MsgBox("Wystąpił błąd przy zapisywaniu.")
            End If
            reloadData = True

        ElseIf btnEditSave.Text = "Dodaj" Then
            'add here
            If addDepartment(New Department(tbDeptName.Text, tbDeptIdx.Text, tbDeptLocation.Text, tbDeptDescription.Text)) Then
                reloadData = True
                btnEditSave.Text = "Edytuj"
            End If
        End If

        If reloadData Then
            Dim tmp = cbDepartments.SelectedIndex
            Globals.populateDepartments()
            cbDepartments.Items.Clear()
            cbDepartments.Items.Add("--- Dodaj ---")
            For Each dep As Department In Globals.departments
                cbDepartments.Items.Add(New DictionaryEntry(dep.name, dep.id))
            Next
            cbDepartments.SelectedIndex = tmp
            tbDeptDescription.Enabled = False
            tbDeptLocation.Enabled = False
            tbDeptName.Enabled = False
            tbDeptIdx.Enabled = False

            cbDepartments.Enabled = True
            saved = True
        End If


    End Sub

    Function checkIfDifferers()
        If _dept.name <> tbDeptName.Text Then
            Return True
        End If
        If _dept.idx <> tbDeptIdx.Text Then
            Return True
        End If
        If _dept.location <> tbDeptLocation.Text Then
            Return True
        End If
        If _dept.description <> tbDeptDescription.Text Then
            Return True
        End If

        Return False
    End Function

    Private Sub frmDepartmentsEdit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        If cbDepartments.Enabled = False And checkIfDifferers() Then
            If MsgBox("Wprowadzone dane nie zostały zapisane." & vbCrLf & "Kontynuować?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then e.Cancel = False
        Else
            e.Cancel = False

        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmDepartmentsEdit_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class