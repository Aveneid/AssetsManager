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
            Dim frm = frmWarehouses
            frm.MdiParent = Me
            frm.TopMost = True
            frm.Show()
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
            Dim frm = frmDepartments
            frm.MdiParent = Me
            frm.TopMost = True
            frm.Show()
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

        Globals.populatePositions()
        Globals.populateEmployees()
        Globals.populateDepartments()
        Globals.populateWarehouses()


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
            Dim frm = frmEmployees
            frm.MdiParent = Me
            frm.TopMost = True
            frm.Show()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
