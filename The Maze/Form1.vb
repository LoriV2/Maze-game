
Public Class Form1
    Public points As Integer = 500
    Public Lose As Boolean = False
    Public win As Boolean = False
    'if you keep losing you can set counting to higher values 
    Public counting As Integer = 1
    Dim hh, mm, ss As Integer

    Public Sub btn_win(receiver As Object, e As EventArgs) Handles win_btn.MouseEnter
        win = True
        If Timer1.Enabled = True Then
            Timer1.Enabled = False

            Form2.Win = True
            Form2.player_points.Text = points
            Form2.Show()
        End If

    End Sub


    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Form2.Label1.Text = Format(hh, "00:") & Format(mm, "00:") & Format(ss, "00")
        ss += 1
        If ss > 59 Then
            ss = 0
            mm += 1
        End If
        If mm > 59 Then
            mm = 0
            points -= 1
            hh += 1
        End If



    End Sub



    Private Sub Start_click(sender As Object, e As EventArgs) Handles Button2.Click
        If Timer1.Enabled = True Then
        Else
            points = 500
            Lose = False
            win = False
            counting = 1
            hh = 0
            mm = 0
            ss = 0
        End If
        If TextBox1.Text = "" Then
            Label1.Text = "INSERT YOUR NAME"
        Else
            Timer1.Enabled = True
            Label1.Text = "Player's name"
            Form2.player_name.Text = TextBox1.Text
            ProgressBar80.Left += 4
        End If

    End Sub
    Public Sub Loss_(sender As Object, e As EventArgs) Handles Me.MouseEnter
        If Timer1.Enabled = True And win = False Then
            counting = counting - 1
            If counting < 0 Then
                points = 0
                Form2.player_points.Text = points
                Timer1.Enabled = False
                Form2.Lose = True
                Form2.Show()
            End If
        End If


    End Sub
End Class