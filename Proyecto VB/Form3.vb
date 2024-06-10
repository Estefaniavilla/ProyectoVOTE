Imports System.IO
Public Class Form3
    Public Property Vote As String
    Public Property NewVote As String

    Private Sub btnVote1_Click(sender As Object, e As EventArgs) Handles btnVote1.Click
        lblMensaje.Text = "Thank you for your vote!!"
        pbPri.Image = Image.FromFile("C:\Users\jovan\source\repos\Proyecto\Proyecto\Resources\PRI_Votado.png")
        pb1Pan.Image = Image.FromFile("C:\Users\jovan\source\repos\Proyecto\Proyecto\Resources\descarga.png")
        pbMorena.Image = Image.FromFile("C:\Users\jovan\source\repos\Proyecto\Proyecto\Resources\1024px-Morena_partido_logo.png")
    End Sub


    Private Sub btnVote2_Click(sender As Object, e As EventArgs) Handles btnVote2.Click
        lblMensaje2.Text = "Thank you for your vote!!"
        pbPri.Image = Image.FromFile("C:\Users\jovan\source\repos\Proyecto\Proyecto\Resources\PRI_(partido_revolucionario_institucional)_logo_(Mexico).png")
        pb1Pan.Image = Image.FromFile("C:\Users\jovan\source\repos\Proyecto\Proyecto\Resources\PAN_Votado.png")
        pbMorena.Image = Image.FromFile("C:\Users\jovan\source\repos\Proyecto\Proyecto\Resources\1024px-Morena_partido_logo.png")
    End Sub

    Private Sub btnVote3_Click(sender As Object, e As EventArgs) Handles btnVote3.Click
        lblMensaje3.Text = "Thank you for your vote!!"
        pbPri.Image = Image.FromFile("C:\Users\jovan\source\repos\Proyecto\Proyecto\Resources\PRI_(partido_revolucionario_institucional)_logo_(Mexico).png")
        pb1Pan.Image = Image.FromFile("C:\Users\jovan\source\repos\Proyecto\Proyecto\Resources\descarga.png")
        pbMorena.Image = Image.FromFile("C:\Users\jovan\source\repos\Proyecto\Proyecto\Resources\Morena_votado.png")
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim saveFileDialog1 As New SaveFileDialog()

            saveFileDialog1.Title = "Save Review File"
            saveFileDialog1.DefaultExt = "txt"
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"

            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = saveFileDialog1.FileName
                File.WriteAllText(filePath, txtSuggetion.Text)
                MessageBox.Show("Review saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while saving the review: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class