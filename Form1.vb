Imports System.Data.OleDb
Imports System.Data

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uname As String = ""
        Dim pword As String = ""
        Dim username As String = ""
        Dim pass As String = ""
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Plz Fill All the info")
        Else
            uname = TextBox1.Text
            pword = TextBox2.Text
            Dim querry As String = "Select password from admin where user_name= '" & uname & "'"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\hospital.accdb"
            Dim conn = New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(querry, conn)

            Try
                conn.Open()
                pass = cmd.ExecuteScalar().ToString
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            If (pword = pass) Then
                Form2.Show()
                If Form2.Visible Then
                    Me.Hide()
                End If

            Else
                MsgBox("login Failed")
                TextBox1.Clear()
                TextBox2.Clear()
            End If
            End If

    End Sub
End Class
