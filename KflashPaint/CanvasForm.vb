Public Class CanvasForm

    Public Tools As New List(Of Object)
    Private Sub CanvasForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoopTimer.Start()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        DrawAll(e.Graphics)
    End Sub

    Public Sub DrawAll(g As Graphics)
        For Each obj As Object In Tools
            obj.Draw(g)
            obj.ShowSelectAnimation(g)
        Next
    End Sub

    Private Sub LoopTimer_Tick(sender As Object, e As EventArgs) Handles LoopTimer.Tick
        Me.Invalidate()
    End Sub

End Class