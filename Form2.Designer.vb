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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.refresh_button = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.patient_data = New System.Windows.Forms.DataGridView()
        Me.doctor_data = New System.Windows.Forms.DataGridView()
        Me.nurse_data = New System.Windows.Forms.DataGridView()
        Me.appointment_box = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button12 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.refresh_button.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.patient_data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.doctor_data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nurse_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.appointment_box.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(818, 129)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Location = New System.Drawing.Point(0, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(156, 332)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'refresh_button
        '
        Me.refresh_button.Controls.Add(Me.GroupBox4)
        Me.refresh_button.Dock = System.Windows.Forms.DockStyle.Left
        Me.refresh_button.Location = New System.Drawing.Point(156, 129)
        Me.refresh_button.Name = "refresh_button"
        Me.refresh_button.Size = New System.Drawing.Size(378, 332)
        Me.refresh_button.TabIndex = 1
        Me.refresh_button.TabStop = False
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(273, 16)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(78, 23)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "refresh BTN"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button11)
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Controls.Add(Me.Button10)
        Me.GroupBox4.Controls.Add(Me.Button9)
        Me.GroupBox4.Controls.Add(Me.Button8)
        Me.GroupBox4.Controls.Add(Me.patient_data)
        Me.GroupBox4.Controls.Add(Me.doctor_data)
        Me.GroupBox4.Controls.Add(Me.nurse_data)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(374, 320)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'patient_data
        '
        Me.patient_data.AllowUserToAddRows = False
        Me.patient_data.AllowUserToResizeColumns = False
        Me.patient_data.AllowUserToResizeRows = False
        Me.patient_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.patient_data.Location = New System.Drawing.Point(0, 36)
        Me.patient_data.Name = "patient_data"
        Me.patient_data.Size = New System.Drawing.Size(257, 279)
        Me.patient_data.TabIndex = 0
        '
        'doctor_data
        '
        Me.doctor_data.AllowUserToAddRows = False
        Me.doctor_data.AllowUserToResizeColumns = False
        Me.doctor_data.AllowUserToResizeRows = False
        Me.doctor_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.doctor_data.Location = New System.Drawing.Point(0, 36)
        Me.doctor_data.Name = "doctor_data"
        Me.doctor_data.Size = New System.Drawing.Size(257, 278)
        Me.doctor_data.TabIndex = 1
        '
        'nurse_data
        '
        Me.nurse_data.AllowUserToAddRows = False
        Me.nurse_data.AllowUserToResizeColumns = False
        Me.nurse_data.AllowUserToResizeRows = False
        Me.nurse_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.nurse_data.Location = New System.Drawing.Point(1, 36)
        Me.nurse_data.Name = "nurse_data"
        Me.nurse_data.Size = New System.Drawing.Size(256, 279)
        Me.nurse_data.TabIndex = 2
        '
        'appointment_box
        '
        Me.appointment_box.Controls.Add(Me.Button12)
        Me.appointment_box.Controls.Add(Me.DataGridView1)
        Me.appointment_box.Controls.Add(Me.TextBox2)
        Me.appointment_box.Dock = System.Windows.Forms.DockStyle.Right
        Me.appointment_box.Location = New System.Drawing.Point(542, 129)
        Me.appointment_box.Name = "appointment_box"
        Me.appointment_box.Size = New System.Drawing.Size(276, 332)
        Me.appointment_box.TabIndex = 1
        Me.appointment_box.TabStop = False
        Me.appointment_box.Text = "Appiontment"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(3, 42)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(270, 287)
        Me.DataGridView1.TabIndex = 0
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(273, 56)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(78, 23)
        Me.Button9.TabIndex = 3
        Me.Button9.Text = "Edit"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(273, 95)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(78, 23)
        Me.Button10.TabIndex = 4
        Me.Button10.Text = "Delete"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(217, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Button11
        '
        Me.Button11.Image = Global.hospital_management_system.My.Resources.Resources.magnifier
        Me.Button11.Location = New System.Drawing.Point(224, 11)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(33, 23)
        Me.Button11.TabIndex = 5
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(0, 81)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(156, 43)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "Nurse"
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = Global.hospital_management_system.My.Resources.Resources.doctor_m_t
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(0, 42)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(156, 43)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Doctor"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.hospital_management_system.My.Resources.Resources.Patient2
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(0, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(156, 39)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Patient"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button7.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Image = Global.hospital_management_system.My.Resources.Resources.Appointment
        Me.Button7.Location = New System.Drawing.Point(363, 20)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(92, 88)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Add Appointment"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button3.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(246, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 88)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Add Nurse"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.hospital_management_system.My.Resources.Resources.doctor_m
        Me.Button1.Location = New System.Drawing.Point(133, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 88)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Add Doctor"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.hospital_management_system.My.Resources.Resources.Patient2
        Me.Button2.Location = New System.Drawing.Point(22, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 88)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Add Patient"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.Image = Global.hospital_management_system.My.Resources.Resources.magnifier
        Me.Button12.Location = New System.Drawing.Point(240, 12)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(33, 23)
        Me.Button12.TabIndex = 7
        Me.Button12.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(3, 15)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(228, 20)
        Me.TextBox2.TabIndex = 6
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 461)
        Me.Controls.Add(Me.appointment_box)
        Me.Controls.Add(Me.refresh_button)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.refresh_button.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.patient_data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.doctor_data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nurse_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.appointment_box.ResumeLayout(False)
        Me.appointment_box.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents refresh_button As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents patient_data As System.Windows.Forms.DataGridView
    Friend WithEvents Table1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YearDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PostalCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BloodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents doctor_data As System.Windows.Forms.DataGridView
    Friend WithEvents nurse_data As System.Windows.Forms.DataGridView
    Friend WithEvents appointment_box As System.Windows.Forms.GroupBox
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
End Class
