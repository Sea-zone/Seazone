Imports System.Data.OleDb
Imports System.Data

Public Class Form2


    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles refresh_button.Enter

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form5.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Form3.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form4.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatientDataSet.Table1' table. You can move, or remove it, as needed.
        patient_data_load()
        doctor_data_load()
        nurse_data_load()

    End Sub


    '   Paticent function    '
    Private Sub patient_data_load()

        Dim querry As String = "select from patient"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\hospital.accdb"

        Dim conn = New OleDbConnection(dbsource)
        Dim cmd As New OleDbCommand(querry, conn)

        Dim sql As String
        sql = "SELECT * FROM patient"
        ' This is our DataAdapter. This executes our SQL Statement above against the Database
        ' we defined in the Connection String

        Dim adapter As New OleDbDataAdapter(sql, conn)
        ' Gets the records from the table and fills our adapter with those.

        Dim dt As New DataTable("patient")

        adapter.Fill(dt)
        ' Assigns our DataSource on the DataGridView
        patient_data.DataSource = dt

        '

        Dim sql1 As String
        sql1 = "SELECT * FROM patient"
        Dim adapter1 As New OleDbDataAdapter(sql1, conn)
        Dim cmd1 As New OleDbCommand(sql1, conn)
        'Dim dt1 As New DataTable("users")
        conn.Open()
        Dim myreader As OleDbDataReader = cmd1.ExecuteReader
        myreader.Read()
        conn.Close()

    End Sub


    '   Doctor function    '
    Private Sub doctor_data_load()

        Dim querry As String = "select from doctor"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\hospital.accdb"

        Dim conn = New OleDbConnection(dbsource)
        Dim cmd As New OleDbCommand(querry, conn)

        Dim sql As String
        sql = "SELECT * FROM doctor"
        ' This is our DataAdapter. This executes our SQL Statement above against the Database
        ' we defined in the Connection String

        Dim adapter As New OleDbDataAdapter(sql, conn)
        ' Gets the records from the table and fills our adapter with those.

        Dim dt As New DataTable("doctor")

        adapter.Fill(dt)
        ' Assigns our DataSource on the DataGridView
        doctor_data.DataSource = dt

        '

        Dim sql1 As String
        sql1 = "SELECT * FROM doctor"
        Dim adapter1 As New OleDbDataAdapter(sql1, conn)
        Dim cmd1 As New OleDbCommand(sql1, conn)
        'Dim dt1 As New DataTable("users")
        conn.Open()
        Dim myreader As OleDbDataReader = cmd1.ExecuteReader
        myreader.Read()
        conn.Close()

    End Sub

    '   Nurse function    '
    Private Sub nurse_data_load()

        Dim querry As String = "select from nurse"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\hospital.accdb"

        Dim conn = New OleDbConnection(dbsource)
        Dim cmd As New OleDbCommand(querry, conn)

        Dim sql As String
        sql = "SELECT * FROM nurse"
        ' This is our DataAdapter. This executes our SQL Statement above against the Database
        ' we defined in the Connection String

        Dim adapter As New OleDbDataAdapter(sql, conn)
        ' Gets the records from the table and fills our adapter with those.

        Dim dt As New DataTable("nurse")

        adapter.Fill(dt)
        ' Assigns our DataSource on the DataGridView
        nurse_data.DataSource = dt

        '

        Dim sql1 As String
        sql1 = "SELECT * FROM nurse"
        Dim adapter1 As New OleDbDataAdapter(sql1, conn)
        Dim cmd1 As New OleDbCommand(sql1, conn)
        'Dim dt1 As New DataTable("users")
        conn.Open()
        Dim myreader As OleDbDataReader = cmd1.ExecuteReader
        myreader.Read()
        conn.Close()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Public Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        patient_data_load()
        doctor_data_load()
        nurse_data_load()
    End Sub

    Private Sub patient_data_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles patient_data.CellContentClick

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        doctor_data.Visible = True
        patient_data.Visible = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        doctor_data.Visible = False
        patient_data.Visible = True


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        doctor_data.Visible = False
        patient_data.Visible = False
        nurse_data.Visible = True

    End Sub

    Private Sub doctor_data_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles doctor_data.CellContentClick

    End Sub

    Private Sub nurse_data_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles nurse_data.CellContentClick

    End Sub

    Private Sub Appointment_Enter(sender As Object, e As EventArgs) Handles appointment_box.Enter

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class