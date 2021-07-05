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
        Me.components = New System.ComponentModel.Container()
        Me.blood = New System.Windows.Forms.GroupBox()
        Me.p_name = New System.Windows.Forms.TextBox()
        Me.p_gender = New System.Windows.Forms.ComboBox()
        Me.p_bloodgroup = New System.Windows.Forms.TextBox()
        Me.p_birthdate = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.p_contact = New System.Windows.Forms.TextBox()
        Me.p_email = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.p_country = New System.Windows.Forms.TextBox()
        Me.p_city = New System.Windows.Forms.TextBox()
        Me.p_postal = New System.Windows.Forms.TextBox()
        Me.p_address = New System.Windows.Forms.TextBox()
        Me.blood.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'blood
        '
        Me.blood.Controls.Add(Me.p_name)
        Me.blood.Controls.Add(Me.p_gender)
        Me.blood.Controls.Add(Me.p_bloodgroup)
        Me.blood.Controls.Add(Me.p_birthdate)
        Me.blood.Controls.Add(Me.Label13)
        Me.blood.Controls.Add(Me.Label6)
        Me.blood.Controls.Add(Me.Label5)
        Me.blood.Controls.Add(Me.PictureBox1)
        Me.blood.Controls.Add(Me.Label4)
        Me.blood.Controls.Add(Me.Label2)
        Me.blood.Location = New System.Drawing.Point(0, 0)
        Me.blood.Name = "blood"
        Me.blood.Size = New System.Drawing.Size(482, 244)
        Me.blood.TabIndex = 0
        Me.blood.TabStop = False
        Me.blood.Text = "General Information"
        '
        'p_name
        '
        Me.p_name.Location = New System.Drawing.Point(89, 31)
        Me.p_name.Name = "p_name"
        Me.p_name.Size = New System.Drawing.Size(100, 20)
        Me.p_name.TabIndex = 21
        '
        'p_gender
        '
        Me.p_gender.FormattingEnabled = True
        Me.p_gender.Items.AddRange(New Object() {"male", "female"})
        Me.p_gender.Location = New System.Drawing.Point(89, 74)
        Me.p_gender.Name = "p_gender"
        Me.p_gender.Size = New System.Drawing.Size(86, 21)
        Me.p_gender.TabIndex = 20
        '
        'p_bloodgroup
        '
        Me.p_bloodgroup.Location = New System.Drawing.Point(256, 71)
        Me.p_bloodgroup.Name = "p_bloodgroup"
        Me.p_bloodgroup.Size = New System.Drawing.Size(69, 20)
        Me.p_bloodgroup.TabIndex = 19
        '
        'p_birthdate
        '
        Me.p_birthdate.Location = New System.Drawing.Point(89, 111)
        Me.p_birthdate.Name = "p_birthdate"
        Me.p_birthdate.Size = New System.Drawing.Size(200, 20)
        Me.p_birthdate.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(186, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Blood Group :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Date of Birth :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(331, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Patient Image :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.Image = Global.hospital_management_system.My.Resources.Resources.Patient1
        Me.PictureBox1.Location = New System.Drawing.Point(333, 92)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(124, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Gender :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Patient Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.p_address)
        Me.GroupBox2.Controls.Add(Me.p_postal)
        Me.GroupBox2.Controls.Add(Me.p_city)
        Me.GroupBox2.Controls.Add(Me.p_country)
        Me.GroupBox2.Controls.Add(Me.p_contact)
        Me.GroupBox2.Controls.Add(Me.p_email)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 250)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(482, 219)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Contact Details"
        '
        'p_contact
        '
        Me.p_contact.Location = New System.Drawing.Point(101, 128)
        Me.p_contact.Name = "p_contact"
        Me.p_contact.Size = New System.Drawing.Size(280, 20)
        Me.p_contact.TabIndex = 26
        '
        'p_email
        '
        Me.p_email.Location = New System.Drawing.Point(100, 155)
        Me.p_email.Name = "p_email"
        Me.p_email.Size = New System.Drawing.Size(309, 20)
        Me.p_email.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 158)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Email Address :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 128)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Contact number :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(210, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Address :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Postal Code :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(231, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "City :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Country :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(14, 488)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 36)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(100, 488)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 36)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(383, 488)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 36)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'p_country
        '
        Me.p_country.Location = New System.Drawing.Point(61, 51)
        Me.p_country.Name = "p_country"
        Me.p_country.Size = New System.Drawing.Size(100, 20)
        Me.p_country.TabIndex = 27
        '
        'p_city
        '
        Me.p_city.Location = New System.Drawing.Point(285, 50)
        Me.p_city.Name = "p_city"
        Me.p_city.Size = New System.Drawing.Size(100, 20)
        Me.p_city.TabIndex = 28
        '
        'p_postal
        '
        Me.p_postal.Location = New System.Drawing.Point(83, 91)
        Me.p_postal.Name = "p_postal"
        Me.p_postal.Size = New System.Drawing.Size(100, 20)
        Me.p_postal.TabIndex = 29
        '
        'p_address
        '
        Me.p_address.Location = New System.Drawing.Point(281, 91)
        Me.p_address.Name = "p_address"
        Me.p_address.Size = New System.Drawing.Size(100, 20)
        Me.p_address.TabIndex = 30
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 549)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.blood)
        Me.Name = "Form3"
        Me.Text = "Add Patient"
        Me.blood.ResumeLayout(False)
        Me.blood.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents blood As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Table1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents p_birthdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents p_email As System.Windows.Forms.TextBox
    Friend WithEvents p_contact As System.Windows.Forms.TextBox
    Friend WithEvents p_bloodgroup As System.Windows.Forms.TextBox
    Friend WithEvents p_gender As System.Windows.Forms.ComboBox
    Friend WithEvents p_name As System.Windows.Forms.TextBox
    Friend WithEvents p_address As System.Windows.Forms.TextBox
    Friend WithEvents p_postal As System.Windows.Forms.TextBox
    Friend WithEvents p_city As System.Windows.Forms.TextBox
    Friend WithEvents p_country As System.Windows.Forms.TextBox
End Class
