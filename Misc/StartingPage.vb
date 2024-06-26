﻿Imports AssetsManager.Misc.SQLDriver

Module StartingPage
    Public Function generateStartingPage(wb As WebBrowser)
        Dim content As String = "<html><body><center>"

        Dim tbl = ConvertToDataTable(Of Warehouse)(Globals.warehouses)

        content &= createTable(tbl, {"Identyfikator", "Nazwa", "Opis", "Indeks", "Wydział nadrzędny", "Pracownik odpowiedzialny"}, "<b> Wydziały i ich powiązania </b>", border:=True)


        content &= "</center></body></html>"
        wb.Document.Write(content)
    End Function

    Function createTable(tbl As DataTable, columnNames() As String, Optional caption As String = "", Optional border As Boolean = False)
        Dim ret As String = ""

        ret = "<table" & If(border, " border='2'>", ">")
        If caption <> "" Then ret &= " <caption>" & caption & "</caption>"

        For Each c In columnNames
            ret &= "<th>" & c & "</th>"
        Next

        For Each r As DataRow In tbl.Rows
            ret &= "<tr>"
            For Each c In r.ItemArray
                ret &= "<td>" & c & "</td>"
            Next
            ret &= "</tr>"
        Next

        ret &= "</table>"
        Return ret
    End Function
End Module
