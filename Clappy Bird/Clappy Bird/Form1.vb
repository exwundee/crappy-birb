Public Class Form1

    Dim yspeed As Integer = 0
    Dim gravity As Integer = 2
    Dim gapBetweenpipes As Integer = 440
    Dim pipespeed As Single = 3.5

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Timer1.Enabled = True
        CreatePipes(1)
        CreateTopPipes(1)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        yspeed += gravity
        Bird.Top += yspeed
        For i = 0 To 1
            pipe.Left -= 2
            topPipe.Left -= 2
            If Collision(topPipe, Bird) = False Then
                Application.Exit()
            End If
            If Collision(pipe, Bird) = False Then
                Application.Exit()
            
            ElseIf pipe.Left < 0 Then
                pipe.Left += 400
                topPipe.Left += 400
                pipe.Top = 70 + 290 * Rnd()
                topPipe.Top = pipe.Top - 400
            End If
        Next
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space Then
            yspeed = -15
        End If
    End Sub

    Private Sub CreatePipes(ByVal Number As Integer)
        Dim i As Integer = 0
        For i = 0 To Number
            Dim teep As New PictureBox
            Me.Controls.Add(teep)
            teep.Width = 40
            teep.Height = 200
            teep.BorderStyle = BorderStyle.FixedSingle
            teep.BackColor = Color.Green
            teep.Top = 70 + 290 * Rnd()
            teep.Left = (i * 200) + 350
            pipe = teep
            pipe.Visible = True
        Next
    End Sub

    Private Sub CreateTopPipes(ByVal Number As Integer)
        Dim i As Integer = 0
        For i = 0 To Number

        Next
        Dim teep As New PictureBox
        Me.Controls.Add(teep)
        teep.Width = 40
        teep.Height = 300
        teep.BorderStyle = BorderStyle.FixedSingle
        teep.BackColor = Color.Green
        teep.Top = (i * 200) + Rnd()
        teep.Left = (i * 200) + 100
        topPipe = teep
        topPipe.Visible = True
    End Sub

    Private Function Collision(ByVal Object1 As Object, ByVal Object2 As Object) As Boolean
        Dim Collided As Boolean = False
        If Object1.top + Object1.Height >= Object2.top And
                Object1.top + Object1.Height >= Object2.top And
                Object1.left + Object1.Width >= Object2.Left And
                Object1.left + Object1.Width >= Object2.Left And Object1.Visible = True And Object1.Visible = True Then
            Collided = True
        End If
        Return Collided
    End Function

End Class
