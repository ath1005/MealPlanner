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
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnMaxCalOK.Click
        results = ""
        lblMaxCalOutput.Text = ""
        Dim calories As String = txtCalorieInput.Text
        myConn.Open()
        myCmd.CommandText = "SELECT Food FROM Food WHERE Calories < " & calories
        myReader = myCmd.ExecuteReader()
        'Concatenate the query result into a string.
        Do While myReader.Read()
            results = results & myReader.GetString(0) & vbLf
        Loop
        '
        lblMaxCalOutput.Text = results
        myReader.Close()
        myConn.Close()
    End Sub

    Private Sub btnFoodSearch_Click(sender As Object, e As EventArgs) Handles btnFoodSearch.Click
        results = ""
        Dim food As String = "'" & txtFoodSearch.Text & "'"
        myConn.Open()
        myCmd.CommandText = "SELECT Calories, Protein, Carbohydrate, Fat FROM Food WHERE Food = " & food
        myReader = myCmd.ExecuteReader()
        Do While myReader.Read()
            lblCalorieOutput.Text = myReader.GetInt32(0)
            lblProteinOutput.Text = myReader.GetDouble(1)
            lblCarbOutput.Text = myReader.GetDouble(2)
            lblFatOutput.Text = myReader.GetDouble(3)
        Loop
        myReader.Close()
        myConn.Close()
    End Sub
End Class