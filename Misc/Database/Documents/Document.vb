Public Class Document
    Public Property id As Integer
    Public Property warehouse_to As Integer
    Public Property dat As Date
    Public Property direction As Enums.Direction
    Public Property user_id As Integer
    Public Property entries As List(Of DocumentEntry)

End Class
