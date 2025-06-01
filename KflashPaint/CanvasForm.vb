Public Class CanvasForm

    Public Tools As New List(Of Object)
    Private Sub CanvasForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub DrawAll()
        'Me.Invalidate()
        For Each obj As Object In Tools
            obj.Draw
        Next
    End Sub

End Class