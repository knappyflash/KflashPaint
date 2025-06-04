Public Class CanvasForm

    Public Tools As New List(Of Object)
    Public myMouseLocation As Point
    Public myMouseClickDownPoint As Point
    Public myMouseIsDown As Boolean
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
        Next
    End Sub

    Private Sub LoopTimer_Tick(sender As Object, e As EventArgs) Handles LoopTimer.Tick
        Me.Invalidate()
    End Sub

    Private Sub CanvasForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        myMouseLocation = e.Location
    End Sub

    Private Sub CanvasForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If Not myMouseIsDown Then
            myMouseIsDown = True
            myMouseClickDownPoint = e.Location
        End If
    End Sub

    Private Sub CanvasForm_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        myMouseIsDown = False
    End Sub

End Class