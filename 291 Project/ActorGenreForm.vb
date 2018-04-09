Imports System.Data.SqlClient

Public Class ActorGenreForm
    Public actor As Boolean
    Public mid As Int16
    Private myConn As SqlConnection = New SqlConnection("Initial Catalog=CMPT291_Project;" & "Data Source=localhost;Integrated Security=SSPI")
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActorGenreDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        If actor = True Then
            ComboActor.Visible = True
            Me.Text = "Add/Remove Actors"

            Dim dataset As New DataSet
            Dim connectionString As String = "Initial Catalog=CMPT291_Project;" & "Data Source=localhost;Integrated Security=SSPI"
            Using connection As New SqlConnection(connectionString)
                Dim adapter As New SqlDataAdapter()
                adapter.SelectCommand = New SqlCommand("SELECT AID, Actor.FirstName + ' ' + Actor.LastName as Name FROM Actor", connection)
                adapter.Fill(dataset)
            End Using

            ComboActor.DataSource = DataSet.Tables(0)
            ComboActor.DisplayMember = "Name"
            ComboActor.ValueMember = "AID"
        Else
            TextGenre.Visible = True
            Me.Text = "Add/Remove Genre"
        End If

    End Sub

    Private Sub RefreshData()
        myCmd = myConn.CreateCommand

        If actor = True Then
            myCmd.CommandText = "SELECT Actor.AID, Actor.FirstName + ' ' + Actor.LastName as Name FROM Actor, MovieActor WHERE Actor.AID = MovieActor.AID and MovieActor.MID = " + mid.ToString
        Else
            myCmd.CommandText = "SELECT MovieType.Type as Genre From MovieType WHERE MovieType.MID = " + mid.ToString
        End If

        myConn.Open()

        myReader = myCmd.ExecuteReader()

        Dim actgentable = New DataTable()
        actgentable.Clear()
        actgentable.Load(myReader)

        ActorGenreDataGrid.AutoGenerateColumns = True
        ActorGenreDataGrid.DataSource = actgentable
        ActorGenreDataGrid.Refresh()

        myReader.Close()
        myConn.Close()
    End Sub

    Private Sub AddBut_Click(sender As Object, e As EventArgs) Handles AddBut.Click
        myCmd = myConn.CreateCommand

        If actor = True Then
            Dim aid = ComboActor.SelectedValue
            myCmd.CommandText = "INSERT INTO MovieActor Values(" + mid.ToString + ",'" + aid + "')"

        Else
            myCmd.CommandText = "INSERT INTO MovieType Values(" + mid.ToString + ",'" + TextGenre.Text + "')"
        End If
        myConn.Open()
        myCmd.ExecuteNonQuery()
        myConn.Close()
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Dim DeleteChoice As DialogResult
        DeleteChoice = MsgBox("Are you sure you want to delete this movie(s)?", MessageBoxButtons.OKCancel)
        If DeleteChoice = DialogResult.OK Then

            myConn.Open()

            For Each row As DataGridViewRow In ActorGenreDataGrid.SelectedRows
                myCmd = myConn.CreateCommand
                Dim id As Integer
                id = row.Cells(0).Value


                If actor = True Then
                    myCmd.CommandText = "Delete From MovieActor where MID = " + mid.ToString + " and AID = " + id.ToString
                Else
                    myCmd.CommandText = "Delete From MovieType where MID = " + mid.ToString + " and Type = " + id.ToString
                End If


                myCmd.ExecuteNonQuery()

            Next
            myConn.Close()
        End If

    End Sub
End Class