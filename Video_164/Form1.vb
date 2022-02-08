Public Class Form1
    Private g As Graphics
    Private xPos As Integer
    Private yPos As Integer
    Private polyPoints() As Point = {New Point(10, 10), New Point(30, 50), New Point(40, 100), New Point(40, 50)}

    Private Sub btnDraw_Click(sender As Object, e As EventArgs) Handles btnDraw.Click
        g.FillRectangle(Brushes.Black, 30, 30, 50, 40)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        g = Me.CreateGraphics
    End Sub

    Private Sub Form1_Click(sender As Object, e As MouseEventArgs) Handles MyBase.Click
        xPos = e.X
        yPos = e.Y
        DrawNewRectangle(e.X, e.Y)
    End Sub

    Private Sub DrawNewRectangle(ByVal xPos As Integer, ByVal yPos As Integer)
        Me.Refresh()
        g.FillRectangle(Brushes.CadetBlue, xPos, yPos, 60, 60)
    End Sub

    Private Sub btnAnimate_Click(sender As Object, e As EventArgs) Handles btnAnimate.Click
        'Timer1.Start()
        'g.DrawLine(Pens.Black, New Point(10, 15), New Point(100, 90))
        g.FillPolygon(Brushes.Black, polyPoints)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If xPos > Me.Size.Width Then
            xPos = 0
        ElseIf xPos < 0 Then
            xPos = Me.Size.Width
        End If
        xPos += 3
        DrawNewRectangle(xPos, yPos)
    End Sub
End Class
