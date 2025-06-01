Imports System.Net.Mime.MediaTypeNames

Public Class Highlighter
    Private _myForm As Form
    Private _location As Point

    Public Sub New(myForm As Form, location As Point)
        _myForm = myForm
        _location = location
    End Sub

    Public Sub DrawHighlight()
        Dim g As Graphics = _myForm.CreateGraphics()
        Dim transparentBrush As SolidBrush
        Dim rect As Rectangle

        If My.Resources.creeper IsNot Nothing Then
            Dim originalBitmap As Bitmap = My.Resources.creeper
            Dim newWidth As Integer = originalBitmap.Width \ 4 ' Half the width
            Dim newHeight As Integer = originalBitmap.Height \ 4 ' Half the height

            Dim resizedBitmap As New Bitmap(originalBitmap, newWidth, newHeight)

            ' Draw the scaled image
            g.DrawImage(resizedBitmap, New Point(30, 30))
        End If


        transparentBrush = New SolidBrush(Color.FromArgb(128, Color.Yellow)) ' Semi-transparent yellow
        rect = New Rectangle(_location.X, _location.Y, 100, 100)
        g.FillRectangle(transparentBrush, rect)
        g.DrawRectangle(Pens.Black, rect)

        transparentBrush = New SolidBrush(Color.FromArgb(128, Color.Blue)) ' Semi-transparent yellow
        rect = New Rectangle(_location.X + 50, _location.Y, 100, 100)
        g.FillRectangle(transparentBrush, rect)
        g.DrawRectangle(Pens.Black, rect)

    End Sub
End Class
