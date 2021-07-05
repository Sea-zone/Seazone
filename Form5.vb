Imports System.Data.OleDb
Imports System.Data
Public Class Form5

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String = N_name.Text
        Dim email As String = N_email.Text
        Dim phone As String = N_phone.Text
        Dim address As String = N_address.Text



        If name = "" Or email = "" Or phone = "" Or address = "" Then
            MsgBox("Plz Fill All the info")
        Else
            Dim querry As String = "insert into nurse(name,email,address,phone) values('" & name & "','" & email & "','" & address & "','" & phone & "')"
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class