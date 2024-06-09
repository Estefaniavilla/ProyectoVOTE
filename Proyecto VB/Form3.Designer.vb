<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        btnVote1 = New Button()
        btnVote2 = New Button()
        btnVote3 = New Button()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Button2 = New Button()
        lblMensaje = New Label()
        lblMensaje2 = New Label()
        lblMensaje3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.PRI__partido_revolucionario_institucional__logo__Mexico_
        PictureBox1.Location = New Point(43, 26)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(117, 114)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.descarga
        PictureBox2.Location = New Point(43, 159)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(117, 115)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources._1024px_Morena_partido_logo
        PictureBox3.Location = New Point(43, 289)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(117, 114)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' btnVote1
        ' 
        btnVote1.BackColor = SystemColors.ScrollBar
        btnVote1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        btnVote1.Location = New Point(187, 72)
        btnVote1.Name = "btnVote1"
        btnVote1.Size = New Size(75, 30)
        btnVote1.TabIndex = 3
        btnVote1.Text = "VOTE"
        btnVote1.UseVisualStyleBackColor = False
        ' 
        ' btnVote2
        ' 
        btnVote2.BackColor = SystemColors.ScrollBar
        btnVote2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        btnVote2.Location = New Point(187, 202)
        btnVote2.Name = "btnVote2"
        btnVote2.Size = New Size(75, 31)
        btnVote2.TabIndex = 4
        btnVote2.Text = "VOTE"
        btnVote2.UseVisualStyleBackColor = False
        ' 
        ' btnVote3
        ' 
        btnVote3.BackColor = SystemColors.ScrollBar
        btnVote3.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        btnVote3.Location = New Point(187, 323)
        btnVote3.Name = "btnVote3"
        btnVote3.Size = New Size(75, 31)
        btnVote3.TabIndex = 5
        btnVote3.Text = "VOTE"
        btnVote3.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ScrollBar
        Label1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        Label1.Location = New Point(725, 138)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 20)
        Label1.TabIndex = 6
        Label1.Text = "Suggestion Box:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(555, 170)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(298, 104)
        TextBox1.TabIndex = 4
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ScrollBar
        Button2.Font = New Font("Segoe UI", 11.25F, FontStyle.Italic)
        Button2.Location = New Point(725, 289)
        Button2.Name = "Button2"
        Button2.Size = New Size(119, 36)
        Button2.TabIndex = 7
        Button2.Text = "Save"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' lblMensaje
        ' 
        lblMensaje.AutoSize = True
        lblMensaje.BackColor = Color.White
        lblMensaje.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblMensaje.Location = New Point(187, 115)
        lblMensaje.Name = "lblMensaje"
        lblMensaje.Size = New Size(0, 20)
        lblMensaje.TabIndex = 8
        ' 
        ' lblMensaje2
        ' 
        lblMensaje2.AutoSize = True
        lblMensaje2.BackColor = Color.White
        lblMensaje2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblMensaje2.Location = New Point(187, 247)
        lblMensaje2.Name = "lblMensaje2"
        lblMensaje2.Size = New Size(0, 20)
        lblMensaje2.TabIndex = 9
        ' 
        ' lblMensaje3
        ' 
        lblMensaje3.AutoSize = True
        lblMensaje3.BackColor = Color.White
        lblMensaje3.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblMensaje3.Location = New Point(187, 367)
        lblMensaje3.Name = "lblMensaje3"
        lblMensaje3.Size = New Size(0, 20)
        lblMensaje3.TabIndex = 10
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(865, 475)
        Controls.Add(lblMensaje3)
        Controls.Add(lblMensaje2)
        Controls.Add(lblMensaje)
        Controls.Add(Button2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(btnVote3)
        Controls.Add(btnVote2)
        Controls.Add(btnVote1)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Name = "Form3"
        Text = "Form3"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnVote1 As Button
    Friend WithEvents btnVote2 As Button
    Friend WithEvents btnVote3 As Button
    Friend WithEvents Label1 As Label
    Private WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents lblMensaje As Label
    Friend WithEvents lblMensaje2 As Label
    Friend WithEvents lblMensaje3 As Label
End Class
