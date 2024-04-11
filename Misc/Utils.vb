Imports System.ComponentModel
Imports System.Globalization
Imports WindowsApp3.Misc.SQLDriver

Public Class Utils

    'https://www.codeguru.com/visual-basic/localization-in-vb-net/
    Public Shared Sub ChangeLanguage(ByVal Language As String, frm As Form)
        For Each c As Control In frm.Controls
            Dim crmLang As ComponentResourceManager = New ComponentResourceManager(frm.GetType())
            crmLang.ApplyResources(c, c.Name, New CultureInfo(Language)) 'Set desired language
        Next c
    End Sub

End Class
