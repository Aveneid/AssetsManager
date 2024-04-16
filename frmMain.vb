Imports AssetsManager.GlobalData
Public Class frmMain


    Dim forms As List(Of Form) = New List(Of Form)

    Private Sub MagazynyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MagazynyToolStripMenuItem1.Click
        Dim found = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmWarehouses.Name Then
                f.BringToFront()
                f.Top = 0
                f.Left = 0
                f.WindowState = FormWindowState.Maximized
                found = True
                Exit For
            End If
        Next

        If Not found Then

            frmWarehouses.MdiParent = Me
            frmWarehouses.TopMost = True
            frmWarehouses.Show()
        End If
    End Sub

    Private Sub WydziałyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WydziałyToolStripMenuItem.Click
        Dim found = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmDepartments.Name Then
                f.BringToFront()
                f.Top = 0
                f.Left = 0
                f.WindowState = FormWindowState.Maximized
                found = True
                Exit For
            End If
        Next

        If Not found Then

            frmDepartments.MdiParent = Me
            frmDepartments.TopMost = True
            frmDepartments.Show()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlBlur.BringToFront()
        pnlBlur.Size = Me.Size
        pnlBlur.Location = New Point(0, 0)

        If frmLogin.ShowDialog() <> DialogResult.OK Then
            Me.Close()
            Exit Sub
        End If

        pnlBlur.SendToBack()
        MenuStrip1.SendToBack()

        Globals.populateAllData()



        frmStartingPage.MdiParent = Me
        frmStartingPage.Show()
        frmStartingPage.BringToFront()
        frmStartingPage.WindowState = FormWindowState.Maximized

        tslUser.Text = "Zalogowano jako: " & loggedEmployee.name



    End Sub

    Private Sub CallDebuggerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CallDebuggerToolStripMenuItem.Click
        Debugger.Break()
    End Sub

    Private Sub PracownicyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PracownicyToolStripMenuItem.Click
        Dim found = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmEmployees.Name Then
                f.BringToFront()
                f.Top = 0
                f.Left = 0
                f.WindowState = FormWindowState.Maximized
                found = True
                Exit For
            End If
        Next

        If Not found Then
            frmEmployees.MdiParent = Me
            frmEmployees.TopMost = True
            frmEmployees.Show()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MaszynyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaszynyToolStripMenuItem.Click
        Dim found = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmMachines.Name Then
                f.BringToFront()
                f.Top = 0
                f.Left = 0
                f.WindowState = FormWindowState.Maximized
                found = True
                Exit For
            End If
        Next

        If Not found Then
            frmMachines.MdiParent = Me
            frmMachines.TopMost = True
            frmMachines.Show()
        End If
    End Sub

    Private Sub CzęściZamienneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CzęściZamienneToolStripMenuItem.Click
        Dim found = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmParts.Name Then
                f.BringToFront()
                f.Top = 0
                f.Left = 0
                f.WindowState = FormWindowState.Maximized
                found = True
                Exit For
            End If
        Next

        If Not found Then
            frmParts.MdiParent = Me
            frmParts.TopMost = True
            frmParts.Show()
        End If
    End Sub
End Class
