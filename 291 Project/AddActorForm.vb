Imports System.Data.SqlClient

Public Class AddActorForm
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Public aid As Int16
    Public fname As String
    Public lname As String
    Public gen As String
    Public dob As String
    Public age As String
    Public rating As String

    Private Sub AddActorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConn = New SqlConnection("Initial Catalog=CMPT291_Project;" & "Data Source=localhost;Integrated Security=SSPI")
        If aid = Nothing Then
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT count(*)FROM Actor"
            myConn.Open()

            myReader = myCmd.ExecuteReader()

            Do While myReader.Read()
                aid = myReader.GetInt32(0)
            Loop
            aid = aid + 1

            myReader.Close()
            myConn.Close()
            age = 0
        Else

        End If
    End Sub

    Private Sub AddAct_Click(sender As Object, e As EventArgs) Handles AddAct.Click
        myCmd = myConn.CreateCommand
        fname = TextFirstName.Text
        lname = TextLastName.Text
        gen = ComboGender.SelectedItem
        Dim formats() As String = {"yyyy-MM-dd"}
        For Each fmt In formats
            dob = DateBirth.Value.ToString(fmt)
        Next

        myCmd.CommandText = "INSERT INTO Actor Values(" + aid.ToString + ",'" + fname + "," + lname + "," + gen + "," + dob + "," + age + "," + rating + ")"
        myConn.Open()
        myCmd.ExecuteNonQuery()
        myConn.Close()
        Form1.RefreshEmployeeData()
        Me.Close()

    End Sub

    Private Sub CancelAct_Click(sender As Object, e As EventArgs) Handles CancelAct.Click
        Dim DeleteChoice As DialogResult
        DeleteChoice = MsgBox("Are you sure you want to Cancel?", MessageBoxButtons.OKCancel)
        If DeleteChoice = DialogResult.OK Then
            Me.Close()

        End If
    End Sub

End Class