Imports System.IO
Imports System.Reflection.Metadata
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab


Public Class Form2
    Private votante As Votante
    Public Sub New()
        InitializeComponent()
        votante = New Votante()
    End Sub

    Private information As String() = New String(8) {}

    Public Property Vote As String
        Get
            Return m_Vote
        End Get
        Set
            m_Vote = Value
        End Set
    End Property
    Private m_Vote As String

    Public Property NewVote As String
        Get
            Return m_NewVote
        End Get
        Set
            m_NewVote = Value
        End Set
    End Property
    Private m_NewVote As String

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim form3 As New Form3()
        form3.Vote = "NewVote"
        form3.Show()
        SaveWord()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim form3 As New Form3()
        form3.Vote = "NewVote"
        form3.Show()
    End Sub

    Private Sub SaveWord()
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Documentos de Word (.docx)|*.docx"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filepath As String = saveFileDialog.FileName

            Try
                ' Define namespace aliases
                Dim W As XNamespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main"

                ' Create a new Word document
                Dim doc As XDocument = New XDocument(
                    New XDeclaration("1.0", "UTF-8", "yes"),
                    New XElement(W + "document",
                        New XElement(W + "body",
                            From info In information
                            Select New XElement(W + "p",
                                New XElement(W + "r",
                                    New XElement(W + "t", info)
                                )
                            )
                        )
                    )
                )

                ' Save the document
                Using stream As New FileStream(filepath, FileMode.Create)
                    doc.Save(stream)
                End Using

                MessageBox.Show("Documento guardado correctamente.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al guardar el documento: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class