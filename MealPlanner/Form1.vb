Imports System.Data.SqlClient
Public Class Form1
    Inherits System.Windows.Forms.Form
    'Create ADO.NET objects.
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConn = New SqlConnection("server = atleesql.database.windows.net; database = Nutrition; User ID=atlee; Password=B@seba1l73")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT Food FROM Food WHERE Calories = 95"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        'Concatenate the query result into a string.
        Do While myReader.Read()
            results = results & myReader.GetString(0) & vbLf
        Loop
        '
        lblOutput.Text = results
        myReader.Close()
        myConn.Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        results = ""
        lblOutput.Text = ""
        Dim calories As String = txtCalorieInput.Text
        myConn.Open()
        myCmd.CommandText = "SELECT Food FROM Food WHERE Calories < " & calories
        myReader = myCmd.ExecuteReader()
        'Concatenate the query result into a string.
        Do While myReader.Read()
            results = results & myReader.GetString(0) & vbLf
        Loop
        '
        lblOutput.Text = results
        myReader.Close()
        myConn.Close()
    End Sub
End Class