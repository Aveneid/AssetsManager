Public Class frmStartingPage
    Private Sub frmStartingPage_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        generateStartingPage(wbStartingPage)
    End Sub

    Private Sub frmStartingPage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then e.Cancel = True
    End Sub

End Class