Public Class DataItem
    Private ItemData As Long
    Private Name As String
    Private Name1 As String
    Public Sub New(ByVal NameArgument As String, ByVal Value As Long, Optional ByVal Name1Argument As String = Nothing)
        Name = NameArgument
        ItemData = Value
        Name1 = Name1Argument
    End Sub
    Overrides Function ToString() As String
        Return Name
    End Function
    Public Function GetData() As Long
        Return ItemData
    End Function
    Public Function GetDesc() As String
        Return Name1
    End Function
End Class