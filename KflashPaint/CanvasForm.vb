Public Class CanvasForm

    Public Tools As New List(Of Object)
    Private Sub CanvasForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        DrawAll(e.Graphics)
    End Sub

    Public Sub DrawAll(g As Graphics)
        For Each obj As Object In Tools
            obj.Draw(g)
        Next
    End Sub

End Class