﻿Public Class Form1
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
        CanvasForm.Tools.Add(New Highlighter)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

End Class
