Imports AssetsManager.Misc.SQLDriver
Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Not checkForTextInTextbox() Then Exit Sub

        Dim login As DataTable
        login = SQLDriver.sqlExeQuery("SELECT * FROM INV_employees WHERE username ='" & tbLogin.Text & "' AND password='" & SQLDriver.createhashMD5(tbPassword.Text) & "'")
        If login.Rows.Count > 0 Then
            Me.DialogResult = DialogResult.OK
            Globals.loggedEmployee = New Employee(login.Rows(0).ItemArray(1).ToString, login.Rows(0).ItemArray(2).ToString, "", Globals.findPositionById(login.Rows(0).ItemArray(4)), login.Rows(0).ItemArray(5).ToString, login.Rows(0).ItemArray(6), login.Rows(0).ItemArray(0))
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MsgBox("Dane są nieprawidłowe.")
        End If

    End Sub


    Function checkForTextInTextbox()
        Dim tip = New ToolTip()
        tip.ToolTipTitle = "Wymagane dane"

        If tbLogin.Text.Length < 1 Then
            tip.Show("Login jest wymagany", tbLogin)
            tbLogin.Focus()
            Return False
        End If

        If tbPassword.Text.Length < 1 Then
            tip.Show("Hasło jest wymagane", tbPassword)
            tbPassword.Focus()
            Return False
        End If
        Return True

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'frmWizard.Show()
    End Sub

    Private Sub tbPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles tbPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class