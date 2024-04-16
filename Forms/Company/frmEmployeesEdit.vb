Imports AssetsManager.Misc.SQLDriver

Public Class frmEmployeesEdit
    Dim _emp As Employee = Nothing
    Sub setEmp(emp As Employee)
        _emp = emp

        lbEmployee.Text = _emp.name
    End Sub
    Private Sub frmEmployeesEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Globals.populateEmployees()

        cbEmpPosition.Items.Clear()


        cbEmpAccessLevel.Items.Clear()

        For Each aclv As DataRow In SQLDriver.sqlExeQuery("SELECT * FROM INV_access_lv").Rows
            cbEmpAccessLevel.Items.Add(New DictionaryEntry(aclv.ItemArray(1), aclv.ItemArray(0)))
        Next

        For Each pos In Globals.positions
            cbEmpPosition.Items.Add(New DictionaryEntry(pos.name, pos.id))
        Next
        cbEmpAccessLevel.SelectedIndex = 0
        cbEmpPosition.SelectedIndex = 0

        If _emp IsNot Nothing Then

            For Each itm In cbEmpAccessLevel.Items
                    If itm.value = _emp.access_lv Then
                        cbEmpAccessLevel.SelectedItem = itm
                        Exit For
                    End If
                Next

                For Each itm In cbEmpPosition.Items
                    If itm.value = _emp.position.id Then
                        cbEmpPosition.SelectedItem = itm
                        Exit For
                    End If
                Next

                tbEmpName.Text = _emp.name
                tbEmpPassword.Text = "******"
                tbEmpPhone.Text = _emp.phone


                btnEditSave.Text = "Zapisz"
                tbEmpId.Text = _emp.id
                tbEmpUsername.Text = _emp.username
            End If

        If _emp Is Nothing Then

            tbEmpPassword.Enabled = True
            cbEmpAccessLevel.Enabled = True
            tbEmpUsername.Enabled = True
            tbEmpName.Enabled = True
            btnEditSave.Enabled = True
            tbEmpPhone.Enabled = True
            lbEmployee.Text = "nowy..."
            btnEditSave.Text = "Dodaj"
            btnPasswordChange.Visible = False
            cbEmpAccessLevel.Enabled = True
            cbEmpPosition.Enabled = True

        End If

        If _emp IsNot Nothing Then
            checkUserAccessLevel()
        End If

    End Sub

    Sub checkUserAccessLevel()
        If _emp.id = Globals.loggedEmployee.id Or Globals.loggedEmployee.access_lv > 3 Then
            btnEditSave.Enabled = True
            tbEmpPhone.Enabled = True
            btnPasswordChange.Visible = True
            btnPasswordChange.Enabled = True
            btnEditSave.Visible = true
        End If
        If Globals.loggedEmployee.access_lv > 3 Then
            cbEmpPosition.Enabled = True
            cbEmpAccessLevel.Enabled = True
            tbEmpName.Enabled = True
        End If

        If _emp.id = Globals.loggedEmployee.id And Globals.loggedEmployee.access_lv > 3 Then
            cbEmpAccessLevel.Enabled = False
        End If

        If _emp.access_lv > 3 Then
            cbEmpAccessLevel.Enabled = False
        End If



    End Sub

    'Private Sub cbEmployees_SelectedValueChanged(sender As Object, e As EventArgs)
    '    If cbEmployees.SelectedItem IsNot Nothing And cbEmployees.SelectedIndex > 0 Then
    '        Dim emp = Globals.employees.Find(Function(c) c.id = cbEmployees.SelectedItem.value)
    '        tbEmpName.Text = emp.name
    '        tbEmpPhone.Text = emp.phone
    '        cbEmpPosition.Text = emp.position
    '        tbEmpUsername.Text = emp.username
    '        tbEmpPassword.Text = "******"
    '        tbEmpAccessLv.Text = emp.access_lv
    '        tbEmpId.Text = emp.id

    '        For Each item In cbEmpAccessLevel.Items
    '            If item.GetType().ToString <> "System.String" Then
    '                If item.value = emp.access_lv Then
    '                    cbEmpAccessLevel.SelectedItem = item
    '                    Exit For
    '                End If
    '            End If
    '        Next


    '        tbEmpName.Enabled = False
    '        tbEmpPhone.Enabled = False
    '        cbEmpPosition.Enabled = False
    '        btnPasswordChange.Enabled = False


    '    End If
    '    If cbEmployees.Text = "--- Dodaj ---" Then
    '        tbEmpName.Enabled = True
    '        tbEmpPhone.Enabled = True
    '        cbEmpPosition.Enabled = True
    '        btnPasswordChange.Enabled = False
    '        tbEmpUsername.Visible = True

    '        btnEditSave.Text = "Dodaj"

    '    End If
    'End Sub

    Private Sub btnPasswordChange_CheckedChanged(sender As Object, e As EventArgs) Handles btnPasswordChange.CheckedChanged

        'rewrite this shit, maybe new form?

        If btnPasswordChange.Checked Then
            tbEmpPassword.Enabled = True
            tbEmpPassword.Select()

            tbEmpPassword2.Visible = True
            tbEmpPassword2.Enabled = True
            Label7.Visible = True

            cbEmpPosition.Visible = False
            tbEmpPhone.Visible = False
            Label4.Visible = False
            Label3.Visible = False

            tbEmpName.Enabled = False
            cbEmpPosition.Enabled = False
            tbEmpPhone.Enabled = False
            btnEditSave.Enabled = False
            btnClose.Enabled = False
            tbEmpPassword.Text = ""


        Else
            If tbEmpPassword.Text = tbEmpPassword2.Text And tbEmpPassword.Text.Length = 0 Then
                'not updating password
                tbEmpPassword2.Visible = False
                tbEmpPassword2.Enabled = False
                Label7.Visible = False

                cbEmpPosition.Visible = True
                tbEmpPassword.Enabled = False
                tbEmpPhone.Visible = True
                tbEmpPhone.Enabled = True
                Label4.Visible = True
                Label3.Visible = True

                btnEditSave.Enabled = True
                btnClose.Enabled = True
                tbEmpPassword.Text = "******"


                Exit Sub
            End If
            If tbEmpPassword.Text = tbEmpPassword2.Text Then
                If tbEmpPassword.Text.Length < 6 Then
                    MsgBox("Hasło jest za krótkie! (min 6 znaków)")
                    btnPasswordChange.Checked = False
                    Exit Sub
                End If
                'updating password
                Dim emp = New Employee(tbEmpName.Text, tbEmpUsername.Text, SQLDriver.createhashMD5(tbEmpPassword.Text),
                                       Globals.findPositionById(cbEmpPosition.SelectedItem.value), tbEmpPhone.Text, cbEmpAccessLevel.SelectedItem.value, tbEmpId.Text)
                If Not Globals.saveEmployee(emp) Then
                    MsgBox("Wystąpił problem podczas zapisu danych.")
                    Exit Sub
                End If
                tbEmpPassword2.Visible = False
                tbEmpPassword2.Enabled = False
                Label7.Visible = False

                cbEmpPosition.Visible = True
                tbEmpPassword.Enabled = False
                tbEmpPhone.Visible = True
                Label4.Visible = True
                Label3.Visible = True

                btnEditSave.Enabled = True
                btnClose.Enabled = True
                cbEmpAccessLevel.Enabled = False


            Else
                MsgBox("Hasła nie są identyczne!")
                tbEmpPassword.Select()
                btnPasswordChange.Checked = False
            End If


        End If


    End Sub

    Private Sub btnEditSave_Click(sender As Object, e As EventArgs) Handles btnEditSave.Click

        'rewrite this
        Select Case btnEditSave.Text
            Case "Edytuj"

            Case "Dodaj"
                If Not (tbEmpName.Text.Length = 0 And tbEmpPassword.Text.Length = 0 And tbEmpUsername.Text.Length = 0 And cbEmpPosition.Text.Length = 0) Then
                    Dim emp = New Employee(tbEmpName.Text, tbEmpUsername.Text, tbEmpPassword.Text, Globals.findPositionById(cbEmpPosition.SelectedItem.value), tbEmpPhone.Text, cbEmpAccessLevel.SelectedItem.value)
                    If Not Globals.addEmployee(emp) Then
                        MsgBox("Wystąpił problem podczas zapisu danych.")
                        Exit Sub
                    Else
                        MsgBox("Dodano " & emp.name)
                        tbEmpName.Text = ""
                        tbEmpPassword.Text = ""
                        tbEmpUsername.Text = ""
                        cbEmpPosition.Text = ""
                        tbEmpPhone.Text = ""
                    End If
                Else
                    MsgBox("Wprowadź wymagane dane!")
                End If
            Case "Zapisz"
                Dim emp = New Employee(tbEmpName.Text, tbEmpUsername.Text, "", Globals.findPositionById(cbEmpPosition.SelectedItem.value), tbEmpPhone.Text, cbEmpAccessLevel.SelectedItem.value, _emp.id)
                If Not Globals.saveEmployee(emp) Then
                    MsgBox("Wystąpił problem podczas zapisu danych.")
                    Exit Sub
                Else
                    Me.Close()
                End If
        End Select



    End Sub

    Private Sub frmEmployeesEdit_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class