Imports System.Data.SqlClient

Public Class AddEmployeeForm

    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Public eid As Int16
    Public ssn As String
    Public fname As String
    Public lname As String
    Public street As String
    Public city As String
    Public state As String
    Public zip As String
    Public start As String
    Public wage As String
    Public pos As String

    'EID, SSN, FirstName, LastName, StreetAddress, City, State, ZipCode, StartDate, HourlyWage, Position

    Private Sub AddEmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConn = New SqlConnection("Initial Catalog=CMPT291_Project;" & "Data Source=localhost;Integrated Security=SSPI")
        If eid = Nothing Then
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT count(*)FROM Employee"
            myConn.Open()

            myReader = myCmd.ExecuteReader()

            Do While myReader.Read()
                eid = myReader.GetInt32(0)
            Loop
            eid = eid + 1

            myReader.Close()
            myConn.Close()
        Else
            TextFirstName.Text = fname
            TextLastName.Text = lname
            TextSSN.Text = ssn
            TextStreet.Text = street
            TextCity.Text = city
            TextState.Text = state
            TextZip.Text = zip
            DateStart.Value = start



            TextWage.Text = wage
            ComboPosition.SelectedItem = pos
        End If



    End Sub

    Private Sub CancelEmploy_Click(sender As Object, e As EventArgs) Handles CancelEmploy.Click
        Dim DeleteChoice As DialogResult
        DeleteChoice = MsgBox("Are you sure you want to Cancel?", MessageBoxButtons.OKCancel)
        If DeleteChoice = DialogResult.OK Then
            Me.Close()

        End If
    End Sub

    Private Sub AddEmploy_Click(sender As Object, e As EventArgs) Handles AddEmploy.Click
        myCmd = myConn.CreateCommand
        fname = TextFirstName.Text
        lname = TextLastName.Text
        ssn = TextSSN.Text
        street = TextStreet.Text
        city = TextCity.Text
        state = TextState.Text
        zip = TextZip.Text
        wage = TextWage.Text
        pos = ComboPosition.SelectedItem

        Dim formats() As String = {"yyyy-MM-dd"}
        For Each fmt In formats
            start = DateStart.Value.ToString(fmt)
        Next


        If IsNumeric(TextWage.Text) Then
            myCmd.CommandText = "INSERT INTO Employee Values(" + eid.ToString + ",'" + ssn + "'," + fname + "," + lname + "," + street + "," + city + "," + state + "," + zip + "," + start + "," + wage + "," + pos + ")"
            myConn.Open()
            myCmd.ExecuteNonQuery()
            myConn.Close()
            Form1.RefreshEmployeeData()
            Me.Close()
        Else
            SubmissionErrorMessage.Visible = True

        End If
    End Sub


End Class