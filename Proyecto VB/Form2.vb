Public Class Form2
    Public Property Vote As String
    Public Property NewVote As String

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim form3 As New Form3()
        form3.Vote = "NewVote"
        form3.Show()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim form3 As New Form3()
        form3.Vote = "NewVote"
        form3.Show()
    End Sub
End Class