Public Class frmTypeAdd
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If tbTypeName.Text.Length > 1 Then
            Dim type = New Type(tbTypeName.Text)
            If Globals.addType(type) Then Me.Close()
        End If
    End Sub
End Class