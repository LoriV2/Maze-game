Public Class Form2
    Public Lose As Boolean
    Public Win As Boolean

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Win = True Then
            Me.BackgroundImage = Image.FromFile("win.jpg")
        ElseIf Lose = True Then
            Me.BackgroundImage = Image.FromFile("lose.jpg")
        End If
    End Sub
End Class