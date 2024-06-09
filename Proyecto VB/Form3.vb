Public Class Form3
    Public Property Vote As String
    Public Property NewVote As String

    Private Sub btnVote1_Click(sender As Object, e As EventArgs) Handles btnVote1.Click
        lblMensaje.Text = "Thank you for your vote!!"
    End Sub

    Private Sub btnVote2_Click(sender As Object, e As EventArgs) Handles btnVote2.Click
        lblMensaje2.Text = "Thank you for your vote!!"
    End Sub

    Private Sub btnVote3_Click(sender As Object, e As EventArgs) Handles btnVote3.Click
        lblMensaje3.Text = "Thank you for your vote!!"
    End Sub

End Class