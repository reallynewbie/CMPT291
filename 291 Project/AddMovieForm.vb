Imports System.Data.SqlClient

Public Class AddMovieForm
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Public id As Int16
    Public title As String
    Public copies As String
    Public rating As String
    Public fee As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConn = New SqlConnection("Initial Catalog=CMPT291_Project;" & "Data Source=localhost;Integrated Security=SSPI")
        If id = Nothing Then
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT count(*)FROM Movie"
            myConn.Open()

            myReader = myCmd.ExecuteReader()

            Do While myReader.Read()
                id = myReader.GetInt32(0)
            Loop
            id = id + 1

            myReader.Close()
            myConn.Close()
        Else
            AddTitleBox.Text = title
            AddFeeBox.Text = fee
            AddCopiesBox.Text = copies
        End If
    End Sub

    Private Sub AddMovieButton_Click(sender As Object, e As EventArgs) Handles AddMovieButton.Click
        myCmd = myConn.CreateCommand
        title = AddTitleBox.Text
        fee = AddFeeBox.Text
        copies = AddCopiesBox.Text
        rating = "0.0"
        If IsNumeric(AddFeeBox.Text) And IsNumeric(AddCopiesBox.Text) Then
            myCmd.CommandText = "INSERT INTO Movie Values(" + id.ToString + ",'" + title + "'," + fee + "," + copies + ",0.0)"
            myConn.Open()
            myCmd.ExecuteNonQuery()
            myConn.Close()
            Form1.RefreshMovieData()
            Me.Close()
        Else
            SubmissionErrorMessage.Visible = True

        End If



    End Sub

    Private Sub CancelMovieButton_Click(sender As Object, e As EventArgs) Handles CancelMovieButton.Click
        Dim DeleteChoice As DialogResult
        DeleteChoice = MsgBox("Are you sure you want to Cancel?", MessageBoxButtons.OKCancel)
        If DeleteChoice = DialogResult.OK Then
            Me.Close()

        End If

    End Sub

    Private Sub ButActors_Click(sender As Object, e As EventArgs) Handles ButActors.Click
        Dim actbox = New ActorGenreForm
        actbox.actor = True
        actbox.mid = id
        actbox.Show()

    End Sub

    Private Sub ButGenres_Click(sender As Object, e As EventArgs) Handles ButGenres.Click
        Dim genbox = New ActorGenreForm
        genbox.actor = False
        genbox.mid = id
        genbox.Show()
    End Sub

    Private Sub AddTitleBox_TextChanged(sender As Object, e As EventArgs) Handles AddTitleBox.TextChanged

    End Sub
End Class