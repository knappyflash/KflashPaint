Imports System.ComponentModel

Public Class Highlighter
    Private _myForm As Form
    Private _myLocation As Point
    Private _myBgColor As Color
    Private _myBorderColor As Color
    Private _mySize As Size
    Private _isSelected As Boolean
    Private _canMove As Boolean
    Private mouseLoc As New Point
    Private offset As New Point

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
        End Set
    End Property

    <Category("Position & Size")>
    Public Property Size As Size
        Get
            Return _mySize
        End Get
        Set(value As Size)
            _mySize = value
        End Set
    End Property

    <Category("Appearance")>
    Public Property BgColor As Color
        Get
            Return _myBgColor
        End Get
        Set(value As Color)
            _myBgColor = value
        End Set
    End Property

    <Category("Appearance")>
    Public Property BorderColor As Color
        Get
            Return _myBorderColor
        End Get
        Set(value As Color)
            _myBorderColor = value
        End Set
    End Property

    Public Sub New()
        _myForm = CanvasForm
        _myLocation = New Point(0, 0)
        _mySize = New Size(100, 100)
        _myBgColor = Color.FromArgb(100, 255, 255, 0)
        _myBorderColor = Color.FromArgb(0, 255, 255, 255)
        _isSelected = True
        _canMove = True
        MainAppForm.ToolsPropertyGrid.SelectedObject = Me
    End Sub

    Public Sub Draw(g As Graphics)
        Dim mySolidBrush As SolidBrush
        Dim myBorderPen As Pen
        Dim rect As Rectangle

        If My.Resources.creeper IsNot Nothing Then
            Dim originalBitmap As Bitmap = My.Resources.creeper
            Dim newWidth As Integer = originalBitmap.Width \ 4 ' Half the width
            Dim newHeight As Integer = originalBitmap.Height \ 4 ' Half the height

            Dim resizedBitmap As New Bitmap(originalBitmap, newWidth, newHeight)

            g.DrawImage(resizedBitmap, New Point(30, 30))
        End If


        mySolidBrush = New SolidBrush(_myBgColor)
        myBorderPen = New Pen(_myBorderColor)
        rect = New Rectangle(_myLocation.X, _myLocation.Y, _mySize.Width, _mySize.Height)
        g.FillRectangle(mySolidBrush, rect)
        g.DrawRectangle(myBorderPen, rect)

        ShowSelectAnimation(g)
        Update_Move()

    End Sub

    Public Sub ShowSelectAnimation(g As Graphics)

        If Not _isSelected Then Exit Sub

        Dim dashOffset As Integer = Environment.TickCount \ 100 Mod 16 ' Varies over time
        Dim myBorderPen As New Pen(Color.Black, 2) With {.DashStyle = Drawing2D.DashStyle.Dash}

        ' Define a shifting dash pattern
        myBorderPen.DashPattern = New Single() {4, 4}
        myBorderPen.DashOffset = dashOffset

        ' Draw the animated selection rectangle
        Dim rect As New Rectangle(_myLocation.X, _myLocation.Y, _mySize.Width, _mySize.Height)
        g.DrawRectangle(myBorderPen, rect)
    End Sub

    Private Sub Update_Move()

        mouseLoc = CanvasForm.myMouseLocation

        If Not _isSelected Then Exit Sub
        If Not _canMove Then Exit Sub
        If Not CanvasForm.myMouseIsDown Then
            offset = mouseLoc - _myLocation
            Exit Sub
        End If

        _myLocation = mouseLoc - offset

    End Sub

End Class
