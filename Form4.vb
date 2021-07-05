Imports System.Data.OleDb
Imports System.Data
Public Class Form4

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles D_name.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles D_email.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String = D_name.Text
        Dim email As String = D_email.Text
        Dim phone As String = D_phone.Text
        Dim address As String = D_address.Text
        Dim department As String = D_department.Text


        If name = "" Or email = "" Or phone = "" Or address = "" Or department = "" Then
            MsgBox("Plz Fill All the info")
        Else
            Dim querry As String = "insert into doctor(name,email,phone,address,department) values('" & name & "','" & email & "','" & phone & "','" & address & "','" & department & "')"
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
        End If
    End Sub
End Class