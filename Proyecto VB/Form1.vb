Public Class Form1

    Public Property NewVote As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form2 As New Form2()
        form2.Vote = "NewVote"
        form2.Show()
    End Sub

End Class


