Public Class Machine
    Public Property id As Integer
    Public Property name As String
    Public Property type As Integer
    Public Property model As String
    Public Property manufacturer As String
    Public Property departament_id As Integer
    Public Property status As Enums.Status
    Public Property barcode As String
    Public Property resp_employee As Integer
    Public Property picture As String
    Public Property parts As List(Of Integer)

End Class
