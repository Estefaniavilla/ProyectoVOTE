<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        Label2 = New Label()
        txtBoxFirstName = New TextBox()
        txtBoxLastName = New TextBox()
        txtBoxResidenceEntity = New TextBox()
        txtBoxCity = New TextBox()
        txtBoxElectorKey = New TextBox()
        txtBoxPhoneNumber = New TextBox()
        txtBoxAge = New TextBox()
        txtBoxGender = New TextBox()
        button1 = New Button()
        button2 = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label1.Location = New Point(40, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 21)
        Label1.TabIndex = 0
        Label1.Text = "General information"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        Label2.Location = New Point(63, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 20)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' txtBoxFirstName
        ' 
        txtBoxFirstName.Location = New Point(150, 37)
        txtBoxFirstName.Name = "txtBoxFirstName"
        txtBoxFirstName.Size = New Size(198, 23)
        txtBoxFirstName.TabIndex = 2
        ' 
        ' txtBoxLastName
        ' 
        txtBoxLastName.Location = New Point(384, 37)
        txtBoxLastName.Name = "txtBoxLastName"
        txtBoxLastName.Size = New Size(198, 23)
        txtBoxLastName.TabIndex = 3
        ' 
        ' txtBoxResidenceEntity
        ' 
        txtBoxResidenceEntity.Location = New Point(150, 107)
        txtBoxResidenceEntity.Name = "txtBoxResidenceEntity"
        txtBoxResidenceEntity.Size = New Size(198, 23)
        txtBoxResidenceEntity.TabIndex = 4
        ' 
        ' txtBoxCity
        ' 
        txtBoxCity.Location = New Point(384, 107)
        txtBoxCity.Name = "txtBoxCity"
        txtBoxCity.Size = New Size(198, 23)
        txtBoxCity.TabIndex = 5
        ' 
        ' txtBoxElectorKey
        ' 
        txtBoxElectorKey.Location = New Point(150, 182)
        txtBoxElectorKey.Name = "txtBoxElectorKey"
        txtBoxElectorKey.Size = New Size(198, 23)
        txtBoxElectorKey.TabIndex = 6
        ' 
        ' txtBoxPhoneNumber
        ' 
        txtBoxPhoneNumber.Location = New Point(384, 182)
        txtBoxPhoneNumber.Name = "txtBoxPhoneNumber"
        txtBoxPhoneNumber.Size = New Size(198, 23)
        txtBoxPhoneNumber.TabIndex = 7
        ' 
        ' txtBoxAge
        ' 
        txtBoxAge.Location = New Point(150, 254)
        txtBoxAge.Name = "txtBoxAge"
        txtBoxAge.Size = New Size(100, 23)
        txtBoxAge.TabIndex = 8
        ' 
        ' txtBoxGender
        ' 
        txtBoxGender.Location = New Point(150, 315)
        txtBoxGender.Name = "txtBoxGender"
        txtBoxGender.Size = New Size(100, 23)
        txtBoxGender.TabIndex = 9
        ' 
        ' button1
        ' 
        button1.Font = New Font("Segoe UI Semilight", 11.25F)
        button1.Location = New Point(443, 369)
        button1.Name = "button1"
        button1.Size = New Size(149, 39)
        button1.TabIndex = 10
        button1.Text = "Save Information"
        button1.UseVisualStyleBackColor = True
        ' 
        ' button2
        ' 
        button2.Font = New Font("Segoe UI Semilight", 11.25F)
        button2.Location = New Point(619, 369)
        button2.Name = "button2"
        button2.Size = New Size(134, 39)
        button2.TabIndex = 11
        button2.Text = "Vote"
        button2.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        Label3.Location = New Point(284, 73)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 15)
        Label3.TabIndex = 12
        Label3.Text = "First Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        Label4.Location = New Point(518, 73)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 15)
        Label4.TabIndex = 13
        Label4.Text = "Last Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        Label5.Location = New Point(256, 143)
        Label5.Name = "Label5"
        Label5.Size = New Size(92, 15)
        Label5.TabIndex = 14
        Label5.Text = "Residence Entity"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        Label6.Location = New Point(554, 143)
        Label6.Name = "Label6"
        Label6.Size = New Size(28, 15)
        Label6.TabIndex = 15
        Label6.Text = "City"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        Label7.Location = New Point(284, 218)
        Label7.Name = "Label7"
        Label7.Size = New Size(63, 15)
        Label7.TabIndex = 16
        Label7.Text = "Elector Key"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        Label8.Location = New Point(496, 218)
        Label8.Name = "Label8"
        Label8.Size = New Size(86, 15)
        Label8.TabIndex = 17
        Label8.Text = "Phone Number"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        Label9.Location = New Point(63, 257)
        Label9.Name = "Label9"
        Label9.Size = New Size(40, 20)
        Label9.TabIndex = 18
        Label9.Text = "Age "
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        Label10.Location = New Point(40, 318)
        Label10.Name = "Label10"
        Label10.Size = New Size(91, 20)
        Label10.TabIndex = 19
        Label10.Text = "Gender M/F"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(button2)
        Controls.Add(button1)
        Controls.Add(txtBoxGender)
        Controls.Add(txtBoxAge)
        Controls.Add(txtBoxPhoneNumber)
        Controls.Add(txtBoxElectorKey)
        Controls.Add(txtBoxCity)
        Controls.Add(txtBoxResidenceEntity)
        Controls.Add(txtBoxLastName)
        Controls.Add(txtBoxFirstName)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBoxFirstName As TextBox
    Friend WithEvents txtBoxLastName As TextBox
    Friend WithEvents txtBoxResidenceEntity As TextBox
    Friend WithEvents txtBoxCity As TextBox
    Friend WithEvents txtBoxElectorKey As TextBox
    Friend WithEvents txtBoxPhoneNumber As TextBox
    Friend WithEvents txtBoxAge As TextBox
    Friend WithEvents txtBoxGender As TextBox
    Friend WithEvents button1 As Button
    Friend WithEvents button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
