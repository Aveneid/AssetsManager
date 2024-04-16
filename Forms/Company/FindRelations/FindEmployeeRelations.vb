Public Class FindEmployeeRelations
    Public _emp As Employee
    Dim dtWarehouses As DataTable
    Dim dtDepartments As DataTable
    Dim dtMachines As DataTable

    Private Sub FindEmployeeRelations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtWarehouses = Globals.findEmployeeRelations(_emp.id, 0)
        dtMachines = Globals.findEmployeeRelations(_emp.id, 1)

        prepareTables()

        generatePage(wbEmployeeRelations)
    End Sub

    Sub prepareTables()
        Dim tmpWare As DataTable = New DataTable
        tmpWare.Columns.Add("name")
        tmpWare.Columns.Add("desc")
        tmpWare.Columns.Add("idx")
        tmpWare.Columns.Add("dept")
        tmpWare.Columns.Add("resp_emp")



        For Each r As DataRow In dtWarehouses.Rows
            tmpWare.Rows.Add({r.Item(1), r.Item(2), r.Item(3), Globals.findDepartmentById(r.Item(4)).name, Globals.findEmployeeById(r.Item(5)).name})
        Next
        dtWarehouses = tmpWare
    End Sub

    Public Function generatePage(wb As WebBrowser)
        Dim content As String = "<html><body>"

        content &= StartingPage.createTable(dtWarehouses, {"Nazwa", "Opis", "Indeks", "Wydział nadrzędny", "Pracownik odpowiedzialny"}, "Powiązania użytkownika <i>" & _emp.name & "</i> - magazyny", True)
        'content &= createTable(dtMachines, {"Identyfikator", "Nazwa", "Opis", "Indeks", "Wydział nadrzędny", "Pracownik odpowiedzialny"}, True)


        content &= "</body></html>"
        wb.Document.Write(content)
    End Function



    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        wbEmployeeRelations.ShowPrintDialog()
    End Sub
End Class
