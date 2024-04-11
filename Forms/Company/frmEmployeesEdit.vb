Imports AssetsManager.Misc.SQLDriver

Public Class frmEmployeesEdit
    Dim _emp As Employee = Nothing
    Public preview As Boolean = False

    Sub setEmp(emp As Employee)
        _emp = emp
        cbEmployees.Enabled = False
    End Sub
    Private Sub frmEmployeesEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Globals.populateEmployees()

        cbEmpPosition.Items.Clear()


        cbEmployees.Items.Add("--- Dodaj ---")
        For Each emp As Employee In Globals.employees
            cbEmployees.Items.Add(New DictionaryEntry(emp.name, emp.id))
        Next

        cbEmpAccessLevel.Items.Clear()
        'cbEmployees.Items.Add("--- Dodaj ---")
        For Each aclv As DataRow In SQLDriver.sqlExeQuery("SELECT * FROM INV_access_lv").Rows
            cbEmpAccessLevel.Items.Add(New DictionaryEntry(aclv.ItemArray(1), aclv.ItemArray(0)))
        Next

        cbEmpPosition.Items.Add("--- Dodaj ---")
        For Each pos In Globals.positions
            cbEmpPosition.Items.Add(New DictionaryEntry(pos.name, pos.id))
        Next

        If _emp IsNot Nothing And _emp.name <> "" Then


            For Each item In cbEmployees.Items
                If item.GetType().ToString <> "System.String" Then
                    If item.value = _emp.id Then
                        cbEmployees.SelectedItem = item
                        Exit For
                    End If
                End If
            Next

            For Each item In cbEmpAccessLevel.Items
                If item.GetType().ToString <> "System.String" Then
                    If item.value = _emp.access_lv Then
                        cbEmpAccessLevel.SelectedItem = item
                        Exit For
                    End If
                End If
            Next

            For Each item In cbEmpPosition.Items
                If item.GetType().ToString <> "System.String" Then
                    If item.value = _emp.position Then
                        cbEmpPosition.SelectedItem = item
                        Exit For
                    End If
                End If
            Next

            tbEmpName.Text = _emp.name
            tbEmpPassword.Text = "******"
            tbEmpPhone.Text = _emp.phone


            btnEditSave.Text = "Zapisz"


        ElseIf _emp IsNot Nothing And _emp.name = Nothing Then

            cbEmployees.SelectedIndex = 0
            cbEmployees.Enabled = False
            tbEmpPassword.Enabled = True
            cbEmpAccessLevel.Enabled = True
            tbEmpUsername.Enabled = True

            cbEmpAccessLevel.SelectedIndex = 0
        End If


        checkUserAccessLevel()

        If preview Then
            btnEditSave.Visible = False
            btnPasswordChange.Visible = False

        End If

    End Sub

    Sub checkUserAccessLevel()
        If Not preview Then
            If _emp.id = Globals.loggedEmployee.id Or Globals.loggedEmployee.access_lv > 3 Then
                btnEditSave.Enabled = True
                tbEmpPhone.Enabled = True

            End If
            If Globals.loggedEmployee.access_lv > 3 Then
                cbEmpPosition.Enabled = True
                cbEmpAccessLevel.Enabled = True
                tbEmpName.Enabled = True
            End If
        End If


    End Sub

    Private Sub cbEmployees_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbEmployees.SelectedValueChanged
        If cbEmployees.SelectedItem IsNot Nothing And cbEmployees.SelectedIndex > 0 Then
            Dim emp = Globals.employees.Find(Function(c) c.id = cbEmployees.SelectedItem.value)
            tbEmpName.Text = emp.name
            tbEmpPhone.Text = emp.phone
            cbEmpPosition.Text = emp.position
            tbEmpUsername.Text = emp.username
            tbEmpPassword.Text = "******"
            tbEmpAccessLv.Text = emp.access_lv
            tbEmpId.Text = emp.id

            For Each item In cbEmpAccessLevel.Items
                If item.GetType().ToString <> "System.String" Then
                    If item.value = emp.access_lv Then
                        cbEmpAccessLevel.SelectedItem = item
                        Exit For
                    End If
                End If
            Next


            tbEmpName.Enabled = False
            tbEmpPhone.Enabled = False
            cbEmpPosition.Enabled = False
            btnPasswordChange.Enabled = False


        End If
        If cbEmployees.Text = "--- Dodaj ---" Then
            tbEmpName.Enabled = True
            tbEmpPhone.Enabled = True
            cbEmpPosition.Enabled = True
            btnPasswordChange.Enabled = False
            tbEmpUsername.Visible = True

            btnEditSave.Text = "Dodaj"

        End If
    End Sub

    Private Sub btnPasswordChange_CheckedChanged(sender As Object, e As EventArgs) Handles btnPasswordChange.CheckedChanged

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
                Dim emp = New Employee(tbEmpName.Text, tbEmpUsername.Text, SQLDriver.createhashMD5(tbEmpPassword.Text), Globals.findPositionById(cbEmpPosition.SelectedValue), tbEmpPhone.Text, tbEmpAccessLv.Text, tbEmpId.Text)
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


            Else
                MsgBox("Hasła nie są identyczne!")
                tbEmpPassword.Select()
                btnPasswordChange.Checked = False
            End If


        End If


    End Sub

    Private Sub btnEditSave_Click(sender As Object, e As EventArgs) Handles btnEditSave.Click
        Select Case btnEditSave.Text
            Case "Edytuj"

            Case "Dodaj"
                If Not (tbEmpName.Text.Length = 0 And tbEmpPassword.Text.Length = 0 And tbEmpUsername.Text.Length = 0 And cbEmpPosition.Text.Length = 0) Then
                    Dim emp = New Employee(tbEmpName.Text, tbEmpUsername.Text, tbEmpPassword.Text, Globals.findPositionById(cbEmpPosition.SelectedValue), tbEmpPhone.Text, cbEmpAccessLevel.SelectedValue, _emp.id)
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