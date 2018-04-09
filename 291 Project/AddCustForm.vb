Imports System.Data.SqlClient

Public Class AddCustForm
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Public id As Int16
    Public first As String
    Public last As String
    Public address As String
    Public city As String
    Public state As String
    Public zip As String
    Public email As String
    Public credit As String
    Public rating As String
    Public account As String

    Private Sub AddCustForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConn = New SqlConnection("Initial Catalog=CMPT291_Project;" & "Data Source=localhost;Integrated Security=SSPI")
        If id = Nothing Then
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT count(*)FROM Customer"
            myConn.Open()

            myReader = myCmd.ExecuteReader()

            Do While myReader.Read()
                id = myReader.GetInt32(0)
            Loop
            id = id + 1

            myReader.Close()
            myConn.Close()
        Else
            FirstNameBox.Text = first
            LastNameBox.Text = last
            AddressBox.Text = address
            CityBox.Text = city
            StateBox.Text = state
            ZipBox.Text = zip
            EmailBox.Text = email
            AccountBox.Text = account
        End If
    End Sub

    Private Sub AddCustBotton_Click(sender As Object, e As EventArgs) Handles AddCustButton.Click
        myCmd = myConn.CreateCommand
        first = FirstNameBox.Text
        last = LastNameBox.Text
        address = AddressBox.Text
        city = CityBox.Text
        state = StateBox.Text
        zip = ZipBox.Text
        email = EmailBox.Text
        credit = CreditBox.Text
        rating = RatingBox.Text
        account = AccountBox.Text
        rating = "0.0"
        If IsNumeric(CreditBox.Text) Then
            myCmd.CommandText = "INSERT INTO Customer Values(" + id.ToString + ",'" + first + "'," + last + "," + address + "," + city + "," + state + "," + zip + "," + email + "," + credit + "," + rating + "," + account + ")"
            myConn.Open()
            myCmd.ExecuteNonQuery()
            myConn.Close()
            CustRep.RefreshCustData()
            Me.Close()
        End If

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles FirstNameBox.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles EmailBox.TextChanged

    End Sub

    Private Sub CancelCustButton_Click(sender As Object, e As EventArgs) Handles CancelCustButton.Click
        Dim DeleteChoice As DialogResult
        DeleteChoice = MsgBox("Are you sure you want to Cancel?", MessageBoxButtons.OKCancel)
        If DeleteChoice = DialogResult.OK Then
            Me.Close()

        End If

    End Sub
End Class