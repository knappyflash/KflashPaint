Public Class MainAppForm
    Private Sub MainAppForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupMainAppForm()
    End Sub

    Private Sub SetupMainAppForm()
        CanvasForm.TopLevel = False
        CanvasForm.FormBorderStyle = FormBorderStyle.None
        CanvasForm.Dock = DockStyle.Fill
        SplitContainer1.Panel1.Controls.Add(CanvasForm)
        SplitContainer1.Panel2.Controls.Add(ToolsPropertyGrid)
        SplitContainer1.Dock = DockStyle.Fill
        CanvasForm.Show()
    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

End Class