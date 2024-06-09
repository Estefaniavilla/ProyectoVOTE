<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lbl1 = New Label()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbl1
        ' 
        lbl1.AutoSize = True
        lbl1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        lbl1.Location = New Point(184, 78)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(367, 25)
        lbl1.TabIndex = 0
        lbl1.Text = "Welcome to the Electronic Voting Process"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 11.25F, FontStyle.Italic)
        Button1.Location = New Point(282, 132)
        Button1.Name = "Button1"
        Button1.Size = New Size(193, 37)
        Button1.TabIndex = 1
        Button1.Text = "Register a new Vote"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(226, 187)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(301, 218)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleTurquoise
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(Button1)
        Controls.Add(lbl1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
