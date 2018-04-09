Imports System.Data.SqlClient
Imports System.Data

Public Class Form1
    Private myConn As SqlConnection = New SqlConnection("Initial Catalog=CMPT291_Project;" & "Data Source=localhost;Integrated Security=SSPI")
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private test As String
    Private dt = New DataTable()
    Private ordertable = New DataTable()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set Defaults for DataGridViews
        MovieGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        OrderGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        EmployeeGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        TopCustomerDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        TopYearlyDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ActorGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        'Set Defaults for Comboboxes
        CustomerListCombo.SelectedIndex = 0
        MovieListCombo.SelectedIndex = 0

        'Populate DataGrids
        TopCustomerData()
        TopMovieData()
        GetOrders()
        RefreshMovieData()
        RefreshEmployeeData()
        RefreshActorData()




    End Sub

    Public Sub RefreshActorData()
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT AID, FirstName, LastName, Gender, DateofBirth, Age, Rating From Actor"
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        Dim actortable = New DataTable()
        actortable.Clear()
        actortable.Load(myReader)

        ActorGridView.AutoGenerateColumns = True
        ActorGridView.DataSource = actortable
        ActorGridView.Refresh()

        myReader.Close()
        myConn.Close()
    End Sub

    Public Sub RefreshEmployeeData()
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT EID, SSN, FirstName, LastName, StreetAddress, City, State, ZipCode, StartDate, HourlyWage, Position From Employee"
        myConn.Open()

        myReader = myCmd.ExecuteReader()

        Dim employeetable = New DataTable()
        employeetable.Clear()
        employeetable.Load(myReader)

        EmployeeGridView.AutoGenerateColumns = True
        EmployeeGridView.DataSource = employeetable
        EmployeeGridView.Refresh()

        myReader.Close()
        myConn.Close()
    End Sub

    Private Sub GetOrders()
        'myConn = New SqlConnection("Initial Catalog=CMPT291_Project;" & "Data Source=localhost;Integrated Security=SSPI")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT OID, Date, ExpectedReturn, ActualReturn, Orders.MID, Title, Orders.CID, Customer.FirstName + ' ' + Customer.LastName as CustomerName, Orders.EID, Employee.FirstName + ' ' + Employee.LastName as EmployeeName FROM Orders, Movie, Employee, Customer WHERE Orders.MID = Movie.MID and Orders.CID = Customer.CID and Employee.EID = Orders.EID"
        myConn.Open()

        myReader = myCmd.ExecuteReader()


        ordertable.Clear()
        ordertable.Load(myReader)

        OrderGridView.AutoGenerateColumns = True
        OrderGridView.DataSource = ordertable
        OrderGridView.Refresh()

        myReader.Close()
        myConn.Close()

    End Sub

    Public Sub RefreshMovieData()
        'myConn = New SqlConnection("Initial Catalog=CMPT291_Project;" & "Data Source=localhost;Integrated Security=SSPI")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT MID, Title, Distrib_Fee, Copies, Rating From Movie"
        myConn.Open()

        myReader = myCmd.ExecuteReader()


        dt.Clear()
        dt.Load(myReader)

        MovieGridView.AutoGenerateColumns = True
        MovieGridView.DataSource = dt
        MovieGridView.Refresh()

        myReader.Close()
        myConn.Close()

        'Refresh the Assorted Lists when Any Changes Occur
        AssortedLists()

    End Sub

    Private Sub TopMovieData()
        'myConn = New SqlConnection("Initial Catalog=CMPT291_Project;" & "Data Source=localhost;Integrated Security=SSPI")
        myCmd = myConn.CreateCommand

        If (MovieListCombo.SelectedIndex = 0) Then 'Yearly
            TopMovieDatePicker.Visible = True
            TopMovieDatePicker.ShowUpDown = True
            TopMovieDatePicker.CustomFormat = "yyyy"
            Dim year = TopMovieDatePicker.Value.Year.ToString
            myCmd.CommandText = "select Movie.MID, Movie.Title, YearRentals.TotalRentals from Movie, (select MID, count(*) as TotalRentals from orders where YEAR(Date) = " + year + " group by orders.MID) as YearRentals where YearRentals.MID = Movie.MID  order by YearRentals.TotalRentals desc"

        ElseIf (MovieListCombo.SelectedIndex = 1) Then 'Monthly
            TopMovieDatePicker.Visible = True
            TopMovieDatePicker.ShowUpDown = True
            TopMovieDatePicker.CustomFormat = "MMMM, yyyy"
            Dim year = TopMovieDatePicker.Value.Year.ToString
            Dim month = TopMovieDatePicker.Value.Month.ToString
            myCmd.CommandText = "select Movie.MID, Movie.Title, YearRentals.TotalRentals from Movie, (select MID, count(*) as TotalRentals from orders where YEAR(Date) = " + year + "and Month(Date) = " + month + " group by orders.MID) as YearRentals where YearRentals.MID = Movie.MID  order by YearRentals.TotalRentals desc"
        ElseIf (MovieListCombo.SelectedIndex = 2) Then 'Daily
            TopMovieDatePicker.Visible = True
            TopMovieDatePicker.ShowUpDown = False
            TopMovieDatePicker.CustomFormat = "MMMM dd, yyyy"
            Dim year = TopMovieDatePicker.Value.Year.ToString
            Dim month = TopMovieDatePicker.Value.Month.ToString
            Dim day = TopMovieDatePicker.Value.Day.ToString
            myCmd.CommandText = "select Movie.MID, Movie.Title, YearRentals.TotalRentals from Movie, (select MID, count(*) as TotalRentals from orders where YEAR(Date) = " + year + "and Month(Date) = " + month + "and DAY(Date) = " + day + " group by orders.MID) as YearRentals where YearRentals.MID = Movie.MID  order by YearRentals.TotalRentals desc"
            'ElseIf (MovieListCombo.SelectedIndex = 3) Then 'All Time
        Else
            TopMovieDatePicker.Visible = False
            myCmd.CommandText = "select Movie.MID, Movie.Title, YearRentals.TotalRentals from Movie, (select MID, count(*) as TotalRentals from orders group by orders.MID) as YearRentals where YearRentals.MID = Movie.MID  order by YearRentals.TotalRentals desc"
        End If


        myConn.Open()

        myReader = myCmd.ExecuteReader()

        Dim topmovietable = New DataTable()
        topmovietable.Clear()
        topmovietable.Load(myReader)

        TopYearlyDataGrid.AutoGenerateColumns = True
        TopYearlyDataGrid.DataSource = topmovietable
        TopYearlyDataGrid.Refresh()

        myReader.Close()
        myConn.Close()
    End Sub

    Private Sub TopCustomerData()
        myCmd = myConn.CreateCommand

        If (CustomerListCombo.SelectedIndex = 0) Then 'Yearly
            TopCustomerDatePicker.Visible = True
            TopCustomerDatePicker.ShowUpDown = True
            TopCustomerDatePicker.CustomFormat = "yyyy"
            Dim year = TopCustomerDatePicker.Value.Year.ToString
            myCmd.CommandText = "select Customer.CID, Customer.FirstName + ' ' + Customer.LastName as Name, YearRentals.TotalRentals from Customer, (select CID, count(*) as TotalRentals from orders where YEAR(Date) = " + year + " group by orders.CID) as YearRentals where YearRentals.CID = Customer.CID  order by YearRentals.TotalRentals desc"

        ElseIf (CustomerListCombo.SelectedIndex = 1) Then 'Monthly
            TopCustomerDatePicker.Visible = True
            TopCustomerDatePicker.ShowUpDown = True
            TopCustomerDatePicker.CustomFormat = "MMMM, yyyy"
            Dim year = TopCustomerDatePicker.Value.Year.ToString
            Dim month = TopCustomerDatePicker.Value.Month.ToString
            myCmd.CommandText = "select Customer.CID, Customer.FirstName + ' ' + Customer.LastName as Name, YearRentals.TotalRentals from Customer, (select CID, count(*) as TotalRentals from orders where YEAR(Date) = " + year + "and Month(Date) = " + month + " group by orders.CID) as YearRentals where YearRentals.CID = Customer.CID  order by YearRentals.TotalRentals desc"
        ElseIf (CustomerListCombo.SelectedIndex = 2) Then 'Daily
            TopCustomerDatePicker.Visible = True
            TopCustomerDatePicker.ShowUpDown = False
            TopCustomerDatePicker.CustomFormat = "MMMM dd, yyyy"
            Dim year = TopCustomerDatePicker.Value.Year.ToString
            Dim month = TopCustomerDatePicker.Value.Month.ToString
            Dim day = TopCustomerDatePicker.Value.Day.ToString
            myCmd.CommandText = "select Customer.CID, Customer.FirstName + ' ' + Customer.LastName as Name, YearRentals.TotalRentals from Customer, (select CID, count(*) as TotalRentals from orders where YEAR(Date) = " + year + "and Month(Date) = " + month + "and DAY(Date) = " + day + " group by orders.CID) as YearRentals where YearRentals.CID = Customer.CID  order by YearRentals.TotalRentals desc"
            'ElseIf (MovieListCombo.SelectedIndex = 3) Then 'All Time
        Else
            TopCustomerDatePicker.Visible = False
            myCmd.CommandText = "select Customer.CID, Customer.FirstName + ' ' + Customer.LastName as Name, YearRentals.TotalRentals from Customer, (select CID, count(*) as TotalRentals from orders group by orders.CID) as YearRentals where YearRentals.CID = Customer.CID  order by YearRentals.TotalRentals desc"
        End If


        myConn.Open()

        myReader = myCmd.ExecuteReader()

        Dim topcustomertable = New DataTable()
        topcustomertable.Clear()
        topcustomertable.Load(myReader)

        TopCustomerDataGrid.AutoGenerateColumns = True
        TopCustomerDataGrid.DataSource = topcustomertable
        TopCustomerDataGrid.Refresh()

        myReader.Close()
        myConn.Close()
    End Sub

    Private Sub AssortedLists()
        'Most Rented Actor
        Dim MRA As String = AssortedQuery("SELECT TOP 1 T.Name FROM (SELECT Actor.FirstName + ' ' + Actor.LastName as Name, MovieCount FROM Actor, (SELECT MovieActor.AID, COUNT(*) as MovieCount FROM Orders, MovieActor WHERE Orders.MID = MovieActor.MID GROUP BY MovieActor.AID) AS Q WHERE Q.AID = Actor.AID) AS T ORDER BY T.MovieCount DESC")
        LabMostActor.Text = "Most Rented Actor: " + MRA

        'Most Rented Genre
        Dim MRG As String = AssortedQuery("SELECT TOP 1 T.Type FROM (SELECT MovieType.Type, COUNT(*) as MovieCount FROM Orders, MovieType WHERE Orders.MID = MovieType.MID GROUP BY MovieType.Type) AS T ORDER BY T.MovieCount DESC")
        LabMostGenre.Text = "Most Rented Genre: " + MRG

        'Actor with Most Movies
        Dim AMM As String = AssortedQuery("SELECT TOP 1 T.Name FROM (SELECT Actor.FirstName + ' ' + Actor.LastName as Name, Total FROM Actor, (SELECT count(*) AS Total, MovieActor.AID FROM MovieActor GROUP BY MovieActor.AID) AS Q WHERE Q.AID = Actor.AID) as T ORDER BY T.Total DESC")
        LabActorMostMovies.Text = "Actor with Most Movies: " + AMM

        'Genre with Most Movies
        Dim GMM As String = AssortedQuery("SELECT TOP 1 T.Type FROM (SELECT count(*) AS Total, MovieType.Type FROM MovieType GROUP BY MovieType.Type) as T ORDER BY T.Total DESC")
        LabGenreMostMovies.Text = "Genre with Most Movies: " + GMM

        'Highest Rated Actor
        Dim HRA As String = AssortedQuery("SELECT Actor.FirstName + ' ' + Actor.LastName as ActorName FROM Actor WHERE rating = (SELECT MAX(rating) FROM Actor)")
        LabHighestActor.Text = "Highest Rated Actor: " + HRA

        'Highest Rated Movie
        Dim HRM As String = AssortedQuery("SELECT Title FROM Movie WHERE rating = (SELECT max(rating) FROM Movie)")
        LabHighestMovie.Text = "Highest Rated Movie: " + HRM

        'Highest Rated Genre
        Dim HRG As String = AssortedQuery("SELECT TOP 1 T.Type FROM (SELECT avg(Movie.Rating) AS AVGRating, MovieType.Type FROM Movie, MovieType WHERE Movie.MID = MovieType.MID GROUP BY MovieType.Type) AS T ORDER BY T.AVGRating DESC")
        LabHighestGenre.Text = "Highest Rated Genre: " + HRG

        'Highest Rated Customer
        Dim HRC As String = AssortedQuery("SELECT Customer.FirstName + ' ' + Customer.LastName as CustomerName FROM Customer WHERE rating = (SELECT MAX(rating) FROM Customer)")
        LabHighestCustomer.Text = "Highest Rated Customer: " + HRC

        'Month with Most Rentals
        Dim MMR As String = AssortedQuery("Select Top 1 T.M From (Select Month(Date) as M, Count(*) as Total From Orders Group By Month(Date)) as T Order BY T.Total DESC")
        LabMostMonth.Text = "Month with Most Rentals: " + MonthName(MMR)

        'Day with Most Rentals
        Dim DMR As String = AssortedQuery("Select Top 1 Date From (Select Date, Count(*) as Total From Orders Group By Date) as T Order BY T.Total DESC")
        LabMostDay.Text = "Day with Most Rentals: " + DMR

    End Sub

    Private Function AssortedQuery(query As String) As String
        Dim result As String = ""

        myCmd = myConn.CreateCommand

        myCmd.CommandText = query
        myConn.Open()

        myReader = myCmd.ExecuteReader()
        If myReader.HasRows Then
            Do While myReader.Read()
                result = myReader.GetValue(0)
            Loop
        End If

        myReader.Close()
        myConn.Close()

        Return result
    End Function

    Private Sub AddMovie_Click(sender As System.Object, e As System.EventArgs) Handles AddMovie.Click
        Dim box = New AddMovieForm
        box.Show()

    End Sub

    Private Sub DeleteMovie_Click(sender As Object, e As EventArgs) Handles DeleteMovie.Click
        Dim DeleteChoice As DialogResult
        DeleteChoice = MsgBox("Are you sure you want to delete this movie(s)?", MessageBoxButtons.OKCancel)
        If DeleteChoice = DialogResult.OK Then

            myConn.Open()

            For Each row As DataGridViewRow In MovieGridView.SelectedRows
                myCmd = myConn.CreateCommand
                Dim mid As Integer
                mid = row.Cells(0).Value
                myCmd.CommandText = "Delete From Movie where MID = " + mid.ToString
                myCmd.ExecuteNonQuery()

            Next
            myConn.Close()
            RefreshMovieData()
        End If

    End Sub

    Private Sub EditMovie_Click(sender As Object, e As EventArgs) Handles EditMovie.Click
        For Each row As DataGridViewRow In MovieGridView.SelectedRows
            Dim ebox = New AddMovieForm
            ebox.id = row.Cells(0).Value
            ebox.title = row.Cells(1).Value
            ebox.fee = row.Cells(2).Value
            ebox.copies = row.Cells(3).Value
            ebox.rating = row.Cells(4).Value
            ebox.Show()

        Next






    End Sub

    Private Sub BtnTest_Click(sender As Object, e As EventArgs) Handles BtnTest.Click
        Dim userForm = New User
        userForm.Show()
    End Sub

    Private Sub TopMovieDatePicker_ValueChanged(sender As Object, e As EventArgs) Handles TopMovieDatePicker.ValueChanged
        TopMovieData()
    End Sub

    Private Sub MovieListCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MovieListCombo.SelectedIndexChanged
        TopMovieData()
    End Sub

    Private Sub CustomerListCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CustomerListCombo.SelectedIndexChanged
        TopCustomerData()
    End Sub

    Private Sub TopCustomerDatePicker_ValueChanged(sender As Object, e As EventArgs) Handles TopCustomerDatePicker.ValueChanged
        TopCustomerData()
    End Sub

    Private Sub AddEmployee_Click(sender As Object, e As EventArgs) Handles AddEmployee.Click
        Dim addemploy = New AddEmployeeForm
        addemploy.Show()

    End Sub

    Private Sub EditEmployee_Click(sender As Object, e As EventArgs) Handles EditEmployee.Click
        For Each row As DataGridViewRow In EmployeeGridView.SelectedRows
            Dim editemploy = New AddEmployeeForm
            editemploy.eid = row.Cells(0).Value
            editemploy.ssn = row.Cells(1).Value
            editemploy.fname = row.Cells(2).Value
            editemploy.lname = row.Cells(3).Value
            editemploy.street = row.Cells(4).Value
            editemploy.city = row.Cells(5).Value
            editemploy.state = row.Cells(6).Value
            editemploy.zip = row.Cells(7).Value
            editemploy.start = row.Cells(8).Value
            editemploy.wage = row.Cells(9).Value
            editemploy.pos = row.Cells(10).Value
            editemploy.Show()

        Next
    End Sub

    Private Sub DeleteEmployee_Click(sender As Object, e As EventArgs) Handles DeleteEmployee.Click
        Dim DeleteChoice As DialogResult
        DeleteChoice = MsgBox("Are you sure you want to delete this employee(s)?", MessageBoxButtons.OKCancel)
        If DeleteChoice = DialogResult.OK Then

            myConn.Open()

            For Each row As DataGridViewRow In EmployeeGridView.SelectedRows
                myCmd = myConn.CreateCommand
                Dim eid As Integer
                eid = row.Cells(0).Value
                myCmd.CommandText = "Delete From Employee where EID = " + eid.ToString
                myCmd.ExecuteNonQuery()

            Next
            myConn.Close()
            RefreshEmployeeData()
        End If
    End Sub

    Private Sub EditActorBut_Click(sender As Object, e As EventArgs) Handles EditActorBut.Click
        For Each row As DataGridViewRow In EmployeeGridView.SelectedRows
            Dim editact = New AddActorForm
            editact.aid = row.Cells(0).Value
            editact.fname = row.Cells(2).Value
            editact.lname = row.Cells(3).Value
            editact.gen = row.Cells(4).Value
            editact.dob = row.Cells(5).Value
            editact.age = row.Cells(6).Value
            editact.rating = row.Cells(7).Value
            editact.Show()

        Next
    End Sub

    Private Sub RemoveActorButton_Click(sender As Object, e As EventArgs) Handles RemoveActorButton.Click
        Dim DeleteChoice As DialogResult
        DeleteChoice = MsgBox("Are you sure you want to delete this employee(s)?", MessageBoxButtons.OKCancel)
        If DeleteChoice = DialogResult.OK Then

            myConn.Open()

            For Each row As DataGridViewRow In ActorGridView.SelectedRows
                myCmd = myConn.CreateCommand
                Dim aid As Integer
                aid = row.Cells(0).Value
                myCmd.CommandText = "Delete From Actor where AID = " + aid.ToString
                myCmd.ExecuteNonQuery()

            Next
            myConn.Close()
            RefreshEmployeeData()
        End If
    End Sub

    Private Sub AddActorBut_Click(sender As Object, e As EventArgs) Handles AddActorBut.Click
        Dim addact = New AddActorForm
        addact.Show()
    End Sub
End Class
