Imports Transitions

Public Class Form1

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim max As Integer = Math.Max(Width, Height)
        Width = max
        Height = max
    End Sub

    Private Sub AnimatedPbx1_MouseEnter(sender As Object, e As EventArgs) Handles AnimatedPbx1.MouseEnter

        Dim t = New Transition(New TransitionType_Acceleration(500))
        t.add(Me, "Height", 500)
        t.run()
    End Sub
End Class
