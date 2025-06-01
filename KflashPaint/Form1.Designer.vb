<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JpgToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HighlighterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AppPanel = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolToolStripMenuItem, Me.ImageToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.ExportToolStripMenuItem, Me.PrintToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PngToolStripMenuItem, Me.JpgToolStripMenuItem})
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'PngToolStripMenuItem
        '
        Me.PngToolStripMenuItem.Name = "PngToolStripMenuItem"
        Me.PngToolStripMenuItem.Size = New System.Drawing.Size(95, 22)
        Me.PngToolStripMenuItem.Text = "png"
        '
        'JpgToolStripMenuItem
        '
        Me.JpgToolStripMenuItem.Name = "JpgToolStripMenuItem"
        Me.JpgToolStripMenuItem.Size = New System.Drawing.Size(95, 22)
        Me.JpgToolStripMenuItem.Text = "jpg"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'ToolToolStripMenuItem
        '
        Me.ToolToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArrowToolStripMenuItem, Me.HighlighterToolStripMenuItem, Me.BlurToolStripMenuItem, Me.TextToolStripMenuItem, Me.LineToolStripMenuItem})
        Me.ToolToolStripMenuItem.Name = "ToolToolStripMenuItem"
        Me.ToolToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ToolToolStripMenuItem.Text = "Tools"
        '
        'ArrowToolStripMenuItem
        '
        Me.ArrowToolStripMenuItem.Name = "ArrowToolStripMenuItem"
        Me.ArrowToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ArrowToolStripMenuItem.Text = "Arrow"
        '
        'HighlighterToolStripMenuItem
        '
        Me.HighlighterToolStripMenuItem.Name = "HighlighterToolStripMenuItem"
        Me.HighlighterToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HighlighterToolStripMenuItem.Text = "Highlighter"
        '
        'BlurToolStripMenuItem
        '
        Me.BlurToolStripMenuItem.Name = "BlurToolStripMenuItem"
        Me.BlurToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BlurToolStripMenuItem.Text = "Blur"
        '
        'TextToolStripMenuItem
        '
        Me.TextToolStripMenuItem.Name = "TextToolStripMenuItem"
        Me.TextToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TextToolStripMenuItem.Text = "Text"
        '
        'LineToolStripMenuItem
        '
        Me.LineToolStripMenuItem.Name = "LineToolStripMenuItem"
        Me.LineToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LineToolStripMenuItem.Text = "Line"
        '
        'ImageToolStripMenuItem
        '
        Me.ImageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResizeToolStripMenuItem})
        Me.ImageToolStripMenuItem.Name = "ImageToolStripMenuItem"
        Me.ImageToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.ImageToolStripMenuItem.Text = "Image"
        '
        'ResizeToolStripMenuItem
        '
        Me.ResizeToolStripMenuItem.Name = "ResizeToolStripMenuItem"
        Me.ResizeToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.ResizeToolStripMenuItem.Text = "Resize"
        '
        'AppPanel
        '
        Me.AppPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppPanel.Location = New System.Drawing.Point(12, 27)
        Me.AppPanel.Name = "AppPanel"
        Me.AppPanel.Size = New System.Drawing.Size(776, 411)
        Me.AppPanel.TabIndex = 1
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AppPanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Kflash Paint"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AppPanel As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JpgToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArrowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HighlighterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlurToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResizeToolStripMenuItem As ToolStripMenuItem
End Class
