Imports System.Data.OleDb
Imports System.Data

Public Class Form3

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles blood.Enter

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatientDataSet.Table1' table. You can move, or remove it, as needed.

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Dim id As String = p_id.Text
        Dim name As String = p_name.Text
        Dim gender As String = p_gender.SelectedItem.ToString
        Dim bloodgroup As String = p_bloodgroup.Text
        Dim birthdate As String = p_birthdate.Value
        Dim country As String = p_country.Text
        Dim city As String = p_city.Text
        Dim postal As String = p_postal.Text
        Dim address As String = p_address.Text
        Dim contact As String = p_contact.Text
        Dim email As String = p_email.Text

        If name = "" Or gender = "" Then
            MsgBox("Plz Fill All the info")
        Else
            Dim querry As String = "insert into patient(name,gender,bloodgroup,birthdate,country,city,postal,address,contact,email) values('" & name & "','" & gender & "','" & bloodgroup & "','" & birthdate & "','" & country & "','" & city & "','" & postal & "','" & address & "','" & contact & "','" & email & "')"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\hospital.accdb"

            Dim conn = New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(querry, conn)

            Try
                conn.Open()
                MsgBox(querry)




                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            MsgBox("Executed")

            'If (pword = pass) Then
            '    Form2.Show()
            '    If Form2.Visible Then
            '        Me.Hide()
            '    End If

            'Else
            '    MsgBox("login Failed")
            '    TextBox1.Clear()
            '    TextBox2.Clear()
            'End If
        End If
    End Sub

    Private Sub p_name_Leave(sender As Object, e As EventArgs) Handles p_name.Leave

    End Sub
End Class