Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowMainAppForm()
    End Sub

    Private Sub ShowMainAppForm()
        MainAppForm.TopLevel = False
        MainAppForm.FormBorderStyle = FormBorderStyle.None
        MainAppForm.Dock = DockStyle.Fill
        AppPanel.Controls.Add(MainAppForm)
        MainAppForm.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub HighlighterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HighlighterToolStripMenuItem.Click
        Dim highlighter As New Highlighter()
        CanvasForm.Tools.Add(highlighter)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

End Class
