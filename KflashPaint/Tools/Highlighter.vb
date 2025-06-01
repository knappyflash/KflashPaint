Imports System.ComponentModel

Public Class Highlighter
    Private _myForm As Form
    Private _myLocation As Point
    Private _myBgColor As Color
    Private _myBorderColor As Color
    Private _mySize As Size

    <Category("General")>
    Public ReadOnly Property ToolType As String
        Get
            Return "Highlighter"
        End Get
    End Property

    <Category("Position & Size")>
    Public Property Location As Point
        Get
            Return _myLocation
        End Get
        Set(value As Point)
            _myLocation = value
            CanvasForm.Invalidate()
        End Set
    End Property

    <Category("Position & Size")>
    Public Property Size As Size
        Get
            Return _mySize
        End Get
        Set(value As Size)
            _mySize = value
            CanvasForm.Invalidate()
        End Set
    End Property

    <Category("Appearance")>
    Public Property BgColor As Color
        Get
            Return _myBgColor
        End Get
        Set(value As Color)
            _myBgColor = value
            CanvasForm.Invalidate()
        End Set
    End Property

    <Category("Appearance")>
    Public Property BorderColor As Color
        Get
            Return _myBorderColor
        End Get
        Set(value As Color)
            _myBorderColor = value
            CanvasForm.Invalidate()
        End Set
    End Property

    Public Sub New()
        _myForm = CanvasForm
        _myLocation = New Point(0, 0)
        _myBgColor = Color.FromArgb(100, 255, 255, 0)
        _myBorderColor = Color.FromArgb(0, 255, 255, 255)
        MainAppForm.ToolsPropertyGrid.SelectedObject = Me
        CanvasForm.Invalidate()
    End Sub

    Public Sub Draw(g As Graphics)
        'Dim g As Graphics = _myForm.CreateGraphics()
        Dim mySolidBrush As SolidBrush
        Dim myBorderPen As Pen
        Dim rect As Rectangle

        If My.Resources.creeper IsNot Nothing Then
            Dim originalBitmap As Bitmap = My.Resources.creeper
            Dim newWidth As Integer = originalBitmap.Width \ 4 ' Half the width
            Dim newHeight As Integer = originalBitmap.Height \ 4 ' Half the height

            Dim resizedBitmap As New Bitmap(originalBitmap, newWidth, newHeight)

            ' Draw the scaled image
            g.DrawImage(resizedBitmap, New Point(30, 30))
        End If


        mySolidBrush = New SolidBrush(_myBgColor)
        myBorderPen = New Pen(_myBorderColor)
        rect = New Rectangle(_myLocation.X, _myLocation.Y, 100, 100)
        g.FillRectangle(mySolidBrush, rect)
        g.DrawRectangle(myBorderPen, rect)
    End Sub

End Class
