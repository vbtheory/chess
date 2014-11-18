Public Class Form1

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim max As Integer = Math.Max(Width, Height)
        Width = max
        Height = max
    End Sub
End Class
