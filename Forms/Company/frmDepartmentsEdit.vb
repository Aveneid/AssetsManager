Public Class frmDepartmentsEdit

    Public _dept As Department = Nothing
    Private Sub frmDepartments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Globals.populateDepartments()
        If _dept IsNot Nothing Then
            deptID.Text = _dept.id
            tbDeptDescription.Text = _dept.description
            tbDeptIdx.Text = _dept.idx
            tbDeptLocation.Text = _dept.location
            tbDeptName.Text = _dept.name
            lbDepartment.Text = _dept.name
            btnEditSave.Text = "Zapisz"
        End If

        'simple permission check
        Select Case Globals.loggedEmployee.access_lv
            Case 4 To 5
                tbDeptDescription.Enabled = True
                tbDeptLocation.Enabled = True
                tbDeptName.Enabled = True
                tbDeptIdx.Enabled = True
                btnEditSave.Enabled = True
                If _dept Is Nothing Then
                    lbDepartment.Text = "nowy..."
                    btnEditSave.Text = "Dodaj"
                End If
        End Select

    End Sub
    Sub setDept(dept As Department)
        _dept = dept
    End Sub

    'Private Sub cbDepartments_SelectedValueChanged(sender As Object, e As EventArgs)
    '    If cbDepartments.SelectedItem IsNot Nothing And cbDepartments.SelectedIndex > 0 Then
    '        Dim dep = Globals.departments.Find(Function(c) c.id = cbDepartments.SelectedItem.value)
    '        tbDeptName.Text = dep.name
    '        tbDeptLocation.Text = dep.location
    '        tbDeptDescription.Text = dep.description
    '        tbDeptIdx.Text = dep.idx

    '    End If

    '    If cbDepartments.Text = "--- Dodaj ---" Then
    '        tbDeptDescription.Enabled = True
    '        tbDeptLocation.Enabled = True
    '        tbDeptName.Enabled = True
    '        tbDeptIdx.Enabled = True

    '        cbDepartments.Enabled = False



    '        tbDeptDescription.Text = ""
    '        tbDeptIdx.Text = ""
    '        tbDeptLocation.Text = ""
    '        tbDeptName.Text = ""

    '        saved = False

    '        btnEditSave.Text = "Dodaj"
    '    End If

    'End Sub


    Private Sub btnEditSave_Click(sender As Object, e As EventArgs) Handles btnEditSave.Click

        'rewrite this shit

        If btnEditSave.Text = "Zapisz" Then
            Dim dep = Globals.departments.Find(Function(c) c.id = CInt(deptID.Text))
            If saveDepartments(New Department(tbDeptName.Text, tbDeptIdx.Text, tbDeptLocation.Text, tbDeptDescription.Text, dep.id)) Then
                btnEditSave.Text = "Edytuj"
            Else
                MsgBox("Wystąpił błąd przy zapisywaniu.")
            End If

        ElseIf btnEditSave.Text = "Dodaj" Then
            'add here
            If addDepartment(New Department(tbDeptName.Text, tbDeptIdx.Text, tbDeptLocation.Text, tbDeptDescription.Text)) Then
                btnEditSave.Text = "Edytuj"
                Me.Close()
            End If
        ElseIf btnEditSave.Text = "Edytuj" Then
            tbDeptDescription.Enabled = True
            tbDeptLocation.Enabled = True
            tbDeptName.Enabled = True
            btnEditSave.Text = "Zapisz"
        End If




    End Sub

    Function checkIfDifferers()
        If _dept IsNot Nothing Then
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
        End If
        Return False
    End Function

    Private Sub frmDepartmentsEdit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        If checkIfDifferers() Then
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