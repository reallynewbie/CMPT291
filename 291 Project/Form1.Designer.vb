<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ManageMovieTab = New System.Windows.Forms.TabPage()
        Me.MovieGridView = New System.Windows.Forms.DataGridView()
        Me.DeleteMovie = New System.Windows.Forms.Button()
        Me.EditMovie = New System.Windows.Forms.Button()
        Me.AddMovie = New System.Windows.Forms.Button()
        Me.ManageActorsTab = New System.Windows.Forms.TabPage()
        Me.ActorGridView = New System.Windows.Forms.DataGridView()
        Me.EditActorBut = New System.Windows.Forms.Button()
        Me.RemoveActorButton = New System.Windows.Forms.Button()
        Me.AddActorBut = New System.Windows.Forms.Button()
        Me.ManageEmployeesTab = New System.Windows.Forms.TabPage()
        Me.EmployeeGridView = New System.Windows.Forms.DataGridView()
        Me.EditEmployee = New System.Windows.Forms.Button()
        Me.DeleteEmployee = New System.Windows.Forms.Button()
        Me.AddEmployee = New System.Windows.Forms.Button()
        Me.ManageSalesTab = New System.Windows.Forms.TabPage()
        Me.OrderGridView = New System.Windows.Forms.DataGridView()
        Me.ManageListsTab = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.ListsMovieRentals = New System.Windows.Forms.TabPage()
        Me.MovieListCombo = New System.Windows.Forms.ComboBox()
        Me.TopMovieDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.TopYearlyDataGrid = New System.Windows.Forms.DataGridView()
        Me.ListsCustomerRentals = New System.Windows.Forms.TabPage()
        Me.TopCustomerDataGrid = New System.Windows.Forms.DataGridView()
        Me.TopCustomerDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.CustomerListCombo = New System.Windows.Forms.ComboBox()
        Me.ListsAssorted = New System.Windows.Forms.TabPage()
        Me.LabMostMonth = New System.Windows.Forms.Label()
        Me.LabMostDay = New System.Windows.Forms.Label()
        Me.LabHighestCustomer = New System.Windows.Forms.Label()
        Me.LabHighestGenre = New System.Windows.Forms.Label()
        Me.LabHighestMovie = New System.Windows.Forms.Label()
        Me.LabHighestActor = New System.Windows.Forms.Label()
        Me.LabGenreMostMovies = New System.Windows.Forms.Label()
        Me.LabMostGenre = New System.Windows.Forms.Label()
        Me.LabActorMostMovies = New System.Windows.Forms.Label()
        Me.LabMostActor = New System.Windows.Forms.Label()
        Me._291ProjectDataSet1 = New _291_Project._291ProjectDataSet()
        Me._291ProjectDataSet2 = New _291_Project._291ProjectDataSet()
        Me.BtnTest = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.ManageMovieTab.SuspendLayout()
        CType(Me.MovieGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ManageActorsTab.SuspendLayout()
        CType(Me.ActorGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ManageEmployeesTab.SuspendLayout()
        CType(Me.EmployeeGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ManageSalesTab.SuspendLayout()
        CType(Me.OrderGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ManageListsTab.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.ListsMovieRentals.SuspendLayout()
        CType(Me.TopYearlyDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ListsCustomerRentals.SuspendLayout()
        CType(Me.TopCustomerDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ListsAssorted.SuspendLayout()
        CType(Me._291ProjectDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._291ProjectDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.ManageMovieTab)
        Me.TabControl1.Controls.Add(Me.ManageActorsTab)
        Me.TabControl1.Controls.Add(Me.ManageEmployeesTab)
        Me.TabControl1.Controls.Add(Me.ManageSalesTab)
        Me.TabControl1.Controls.Add(Me.ManageListsTab)
        Me.TabControl1.Location = New System.Drawing.Point(1, 30)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(744, 478)
        Me.TabControl1.TabIndex = 0
        '
        'ManageMovieTab
        '
        Me.ManageMovieTab.Controls.Add(Me.MovieGridView)
        Me.ManageMovieTab.Controls.Add(Me.DeleteMovie)
        Me.ManageMovieTab.Controls.Add(Me.EditMovie)
        Me.ManageMovieTab.Controls.Add(Me.AddMovie)
        Me.ManageMovieTab.Location = New System.Drawing.Point(4, 22)
        Me.ManageMovieTab.Name = "ManageMovieTab"
        Me.ManageMovieTab.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.ManageMovieTab.Size = New System.Drawing.Size(736, 452)
        Me.ManageMovieTab.TabIndex = 0
        Me.ManageMovieTab.Text = "Movies"
        Me.ManageMovieTab.UseVisualStyleBackColor = True
        '
        'MovieGridView
        '
        Me.MovieGridView.AllowUserToAddRows = False
        Me.MovieGridView.AllowUserToDeleteRows = False
        Me.MovieGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MovieGridView.Location = New System.Drawing.Point(24, 57)
        Me.MovieGridView.Name = "MovieGridView"
        Me.MovieGridView.ReadOnly = True
        Me.MovieGridView.Size = New System.Drawing.Size(689, 340)
        Me.MovieGridView.TabIndex = 3
        '
        'DeleteMovie
        '
        Me.DeleteMovie.Location = New System.Drawing.Point(633, 419)
        Me.DeleteMovie.Name = "DeleteMovie"
        Me.DeleteMovie.Size = New System.Drawing.Size(80, 23)
        Me.DeleteMovie.TabIndex = 2
        Me.DeleteMovie.Text = "Delete Movie"
        Me.DeleteMovie.UseVisualStyleBackColor = True
        '
        'EditMovie
        '
        Me.EditMovie.Location = New System.Drawing.Point(552, 419)
        Me.EditMovie.Name = "EditMovie"
        Me.EditMovie.Size = New System.Drawing.Size(75, 23)
        Me.EditMovie.TabIndex = 1
        Me.EditMovie.Text = "Edit Movie"
        Me.EditMovie.UseVisualStyleBackColor = True
        '
        'AddMovie
        '
        Me.AddMovie.Location = New System.Drawing.Point(24, 15)
        Me.AddMovie.Name = "AddMovie"
        Me.AddMovie.Size = New System.Drawing.Size(75, 23)
        Me.AddMovie.TabIndex = 0
        Me.AddMovie.Text = "Add Movie"
        Me.AddMovie.UseVisualStyleBackColor = True
        '
        'ManageActorsTab
        '
        Me.ManageActorsTab.Controls.Add(Me.ActorGridView)
        Me.ManageActorsTab.Controls.Add(Me.EditActorBut)
        Me.ManageActorsTab.Controls.Add(Me.RemoveActorButton)
        Me.ManageActorsTab.Controls.Add(Me.AddActorBut)
        Me.ManageActorsTab.Location = New System.Drawing.Point(4, 22)
        Me.ManageActorsTab.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ManageActorsTab.Name = "ManageActorsTab"
        Me.ManageActorsTab.Size = New System.Drawing.Size(736, 452)
        Me.ManageActorsTab.TabIndex = 4
        Me.ManageActorsTab.Text = "Actors"
        Me.ManageActorsTab.UseVisualStyleBackColor = True
        '
        'ActorGridView
        '
        Me.ActorGridView.AllowUserToAddRows = False
        Me.ActorGridView.AllowUserToDeleteRows = False
        Me.ActorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ActorGridView.Location = New System.Drawing.Point(15, 52)
        Me.ActorGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ActorGridView.Name = "ActorGridView"
        Me.ActorGridView.ReadOnly = True
        Me.ActorGridView.RowTemplate.Height = 24
        Me.ActorGridView.Size = New System.Drawing.Size(709, 353)
        Me.ActorGridView.TabIndex = 3
        '
        'EditActorBut
        '
        Me.EditActorBut.Location = New System.Drawing.Point(557, 424)
        Me.EditActorBut.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.EditActorBut.Name = "EditActorBut"
        Me.EditActorBut.Size = New System.Drawing.Size(82, 22)
        Me.EditActorBut.TabIndex = 2
        Me.EditActorBut.Text = "Edit Actor"
        Me.EditActorBut.UseVisualStyleBackColor = True
        '
        'RemoveActorButton
        '
        Me.RemoveActorButton.Location = New System.Drawing.Point(644, 424)
        Me.RemoveActorButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RemoveActorButton.Name = "RemoveActorButton"
        Me.RemoveActorButton.Size = New System.Drawing.Size(80, 22)
        Me.RemoveActorButton.TabIndex = 1
        Me.RemoveActorButton.Text = "Delete Actor"
        Me.RemoveActorButton.UseVisualStyleBackColor = True
        '
        'AddActorBut
        '
        Me.AddActorBut.Location = New System.Drawing.Point(15, 13)
        Me.AddActorBut.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AddActorBut.Name = "AddActorBut"
        Me.AddActorBut.Size = New System.Drawing.Size(76, 22)
        Me.AddActorBut.TabIndex = 0
        Me.AddActorBut.Text = "Add Actor"
        Me.AddActorBut.UseVisualStyleBackColor = True
        '
        'ManageEmployeesTab
        '
        Me.ManageEmployeesTab.Controls.Add(Me.EmployeeGridView)
        Me.ManageEmployeesTab.Controls.Add(Me.EditEmployee)
        Me.ManageEmployeesTab.Controls.Add(Me.DeleteEmployee)
        Me.ManageEmployeesTab.Controls.Add(Me.AddEmployee)
        Me.ManageEmployeesTab.Location = New System.Drawing.Point(4, 22)
        Me.ManageEmployeesTab.Name = "ManageEmployeesTab"
        Me.ManageEmployeesTab.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.ManageEmployeesTab.Size = New System.Drawing.Size(736, 452)
        Me.ManageEmployeesTab.TabIndex = 1
        Me.ManageEmployeesTab.Text = "Employees"
        Me.ManageEmployeesTab.UseVisualStyleBackColor = True
        '
        'EmployeeGridView
        '
        Me.EmployeeGridView.AllowUserToAddRows = False
        Me.EmployeeGridView.AllowUserToDeleteRows = False
        Me.EmployeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeGridView.Location = New System.Drawing.Point(16, 54)
        Me.EmployeeGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.EmployeeGridView.Name = "EmployeeGridView"
        Me.EmployeeGridView.ReadOnly = True
        Me.EmployeeGridView.RowTemplate.Height = 24
        Me.EmployeeGridView.Size = New System.Drawing.Size(713, 349)
        Me.EmployeeGridView.TabIndex = 3
        '
        'EditEmployee
        '
        Me.EditEmployee.Location = New System.Drawing.Point(532, 421)
        Me.EditEmployee.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.EditEmployee.Name = "EditEmployee"
        Me.EditEmployee.Size = New System.Drawing.Size(90, 24)
        Me.EditEmployee.TabIndex = 2
        Me.EditEmployee.Text = "Edit Employee"
        Me.EditEmployee.UseVisualStyleBackColor = True
        '
        'DeleteEmployee
        '
        Me.DeleteEmployee.Location = New System.Drawing.Point(627, 421)
        Me.DeleteEmployee.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DeleteEmployee.Name = "DeleteEmployee"
        Me.DeleteEmployee.Size = New System.Drawing.Size(102, 25)
        Me.DeleteEmployee.TabIndex = 1
        Me.DeleteEmployee.Text = "Delete Employee"
        Me.DeleteEmployee.UseVisualStyleBackColor = True
        '
        'AddEmployee
        '
        Me.AddEmployee.Location = New System.Drawing.Point(16, 19)
        Me.AddEmployee.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AddEmployee.Name = "AddEmployee"
        Me.AddEmployee.Size = New System.Drawing.Size(96, 23)
        Me.AddEmployee.TabIndex = 0
        Me.AddEmployee.Text = "Add Employee"
        Me.AddEmployee.UseVisualStyleBackColor = True
        '
        'ManageSalesTab
        '
        Me.ManageSalesTab.Controls.Add(Me.OrderGridView)
        Me.ManageSalesTab.Location = New System.Drawing.Point(4, 22)
        Me.ManageSalesTab.Name = "ManageSalesTab"
        Me.ManageSalesTab.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.ManageSalesTab.Size = New System.Drawing.Size(736, 452)
        Me.ManageSalesTab.TabIndex = 2
        Me.ManageSalesTab.Text = "Orders"
        Me.ManageSalesTab.UseVisualStyleBackColor = True
        '
        'OrderGridView
        '
        Me.OrderGridView.AllowUserToAddRows = False
        Me.OrderGridView.AllowUserToDeleteRows = False
        Me.OrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrderGridView.Location = New System.Drawing.Point(5, 6)
        Me.OrderGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.OrderGridView.Name = "OrderGridView"
        Me.OrderGridView.ReadOnly = True
        Me.OrderGridView.RowTemplate.Height = 24
        Me.OrderGridView.Size = New System.Drawing.Size(724, 440)
        Me.OrderGridView.TabIndex = 0
        '
        'ManageListsTab
        '
        Me.ManageListsTab.Controls.Add(Me.TabControl2)
        Me.ManageListsTab.Location = New System.Drawing.Point(4, 22)
        Me.ManageListsTab.Name = "ManageListsTab"
        Me.ManageListsTab.Size = New System.Drawing.Size(736, 452)
        Me.ManageListsTab.TabIndex = 3
        Me.ManageListsTab.Text = "Lists"
        Me.ManageListsTab.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.ListsMovieRentals)
        Me.TabControl2.Controls.Add(Me.ListsCustomerRentals)
        Me.TabControl2.Controls.Add(Me.ListsAssorted)
        Me.TabControl2.Location = New System.Drawing.Point(-3, 2)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(744, 455)
        Me.TabControl2.TabIndex = 0
        '
        'ListsMovieRentals
        '
        Me.ListsMovieRentals.Controls.Add(Me.MovieListCombo)
        Me.ListsMovieRentals.Controls.Add(Me.TopMovieDatePicker)
        Me.ListsMovieRentals.Controls.Add(Me.TopYearlyDataGrid)
        Me.ListsMovieRentals.Location = New System.Drawing.Point(4, 22)
        Me.ListsMovieRentals.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListsMovieRentals.Name = "ListsMovieRentals"
        Me.ListsMovieRentals.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListsMovieRentals.Size = New System.Drawing.Size(736, 429)
        Me.ListsMovieRentals.TabIndex = 0
        Me.ListsMovieRentals.Text = "Top Movie Rentals"
        Me.ListsMovieRentals.UseVisualStyleBackColor = True
        '
        'MovieListCombo
        '
        Me.MovieListCombo.FormattingEnabled = True
        Me.MovieListCombo.Items.AddRange(New Object() {"Yearly", "Monthly", "Daily", "All Time"})
        Me.MovieListCombo.Location = New System.Drawing.Point(5, 6)
        Me.MovieListCombo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MovieListCombo.Name = "MovieListCombo"
        Me.MovieListCombo.Size = New System.Drawing.Size(118, 21)
        Me.MovieListCombo.TabIndex = 2
        '
        'TopMovieDatePicker
        '
        Me.TopMovieDatePicker.CustomFormat = "yyyy"
        Me.TopMovieDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TopMovieDatePicker.Location = New System.Drawing.Point(127, 6)
        Me.TopMovieDatePicker.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TopMovieDatePicker.Name = "TopMovieDatePicker"
        Me.TopMovieDatePicker.ShowUpDown = True
        Me.TopMovieDatePicker.Size = New System.Drawing.Size(180, 20)
        Me.TopMovieDatePicker.TabIndex = 1
        '
        'TopYearlyDataGrid
        '
        Me.TopYearlyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TopYearlyDataGrid.Location = New System.Drawing.Point(5, 33)
        Me.TopYearlyDataGrid.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TopYearlyDataGrid.Name = "TopYearlyDataGrid"
        Me.TopYearlyDataGrid.RowTemplate.Height = 24
        Me.TopYearlyDataGrid.Size = New System.Drawing.Size(730, 393)
        Me.TopYearlyDataGrid.TabIndex = 0
        '
        'ListsCustomerRentals
        '
        Me.ListsCustomerRentals.Controls.Add(Me.TopCustomerDataGrid)
        Me.ListsCustomerRentals.Controls.Add(Me.TopCustomerDatePicker)
        Me.ListsCustomerRentals.Controls.Add(Me.CustomerListCombo)
        Me.ListsCustomerRentals.Location = New System.Drawing.Point(4, 22)
        Me.ListsCustomerRentals.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListsCustomerRentals.Name = "ListsCustomerRentals"
        Me.ListsCustomerRentals.Size = New System.Drawing.Size(736, 429)
        Me.ListsCustomerRentals.TabIndex = 4
        Me.ListsCustomerRentals.Text = "Top Customer Rentals"
        Me.ListsCustomerRentals.UseVisualStyleBackColor = True
        '
        'TopCustomerDataGrid
        '
        Me.TopCustomerDataGrid.AllowUserToAddRows = False
        Me.TopCustomerDataGrid.AllowUserToDeleteRows = False
        Me.TopCustomerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TopCustomerDataGrid.Location = New System.Drawing.Point(2, 27)
        Me.TopCustomerDataGrid.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TopCustomerDataGrid.Name = "TopCustomerDataGrid"
        Me.TopCustomerDataGrid.ReadOnly = True
        Me.TopCustomerDataGrid.RowTemplate.Height = 24
        Me.TopCustomerDataGrid.Size = New System.Drawing.Size(739, 408)
        Me.TopCustomerDataGrid.TabIndex = 2
        '
        'TopCustomerDatePicker
        '
        Me.TopCustomerDatePicker.CustomFormat = "yyyy"
        Me.TopCustomerDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TopCustomerDatePicker.Location = New System.Drawing.Point(102, 4)
        Me.TopCustomerDatePicker.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TopCustomerDatePicker.Name = "TopCustomerDatePicker"
        Me.TopCustomerDatePicker.ShowUpDown = True
        Me.TopCustomerDatePicker.Size = New System.Drawing.Size(182, 20)
        Me.TopCustomerDatePicker.TabIndex = 1
        '
        'CustomerListCombo
        '
        Me.CustomerListCombo.AllowDrop = True
        Me.CustomerListCombo.FormattingEnabled = True
        Me.CustomerListCombo.Items.AddRange(New Object() {"Yearly", "Monthly", "Daily", "All Time"})
        Me.CustomerListCombo.Location = New System.Drawing.Point(6, 3)
        Me.CustomerListCombo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CustomerListCombo.Name = "CustomerListCombo"
        Me.CustomerListCombo.Size = New System.Drawing.Size(92, 21)
        Me.CustomerListCombo.TabIndex = 0
        '
        'ListsAssorted
        '
        Me.ListsAssorted.Controls.Add(Me.LabMostMonth)
        Me.ListsAssorted.Controls.Add(Me.LabMostDay)
        Me.ListsAssorted.Controls.Add(Me.LabHighestCustomer)
        Me.ListsAssorted.Controls.Add(Me.LabHighestGenre)
        Me.ListsAssorted.Controls.Add(Me.LabHighestMovie)
        Me.ListsAssorted.Controls.Add(Me.LabHighestActor)
        Me.ListsAssorted.Controls.Add(Me.LabGenreMostMovies)
        Me.ListsAssorted.Controls.Add(Me.LabMostGenre)
        Me.ListsAssorted.Controls.Add(Me.LabActorMostMovies)
        Me.ListsAssorted.Controls.Add(Me.LabMostActor)
        Me.ListsAssorted.Location = New System.Drawing.Point(4, 22)
        Me.ListsAssorted.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListsAssorted.Name = "ListsAssorted"
        Me.ListsAssorted.Size = New System.Drawing.Size(736, 429)
        Me.ListsAssorted.TabIndex = 3
        Me.ListsAssorted.Text = "Assorted"
        Me.ListsAssorted.UseVisualStyleBackColor = True
        '
        'LabMostMonth
        '
        Me.LabMostMonth.AutoSize = True
        Me.LabMostMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMostMonth.Location = New System.Drawing.Point(22, 293)
        Me.LabMostMonth.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabMostMonth.Name = "LabMostMonth"
        Me.LabMostMonth.Size = New System.Drawing.Size(150, 15)
        Me.LabMostMonth.TabIndex = 9
        Me.LabMostMonth.Text = "Month With Most Rentals: "
        '
        'LabMostDay
        '
        Me.LabMostDay.AutoSize = True
        Me.LabMostDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMostDay.Location = New System.Drawing.Point(22, 331)
        Me.LabMostDay.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabMostDay.Name = "LabMostDay"
        Me.LabMostDay.Size = New System.Drawing.Size(134, 15)
        Me.LabMostDay.TabIndex = 8
        Me.LabMostDay.Text = "Day with Most Rentals: "
        '
        'LabHighestCustomer
        '
        Me.LabHighestCustomer.AutoSize = True
        Me.LabHighestCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabHighestCustomer.Location = New System.Drawing.Point(22, 260)
        Me.LabHighestCustomer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabHighestCustomer.Name = "LabHighestCustomer"
        Me.LabHighestCustomer.Size = New System.Drawing.Size(147, 15)
        Me.LabHighestCustomer.TabIndex = 7
        Me.LabHighestCustomer.Text = "Highest Rated Customer: "
        '
        'LabHighestGenre
        '
        Me.LabHighestGenre.AutoSize = True
        Me.LabHighestGenre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabHighestGenre.Location = New System.Drawing.Point(22, 228)
        Me.LabHighestGenre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabHighestGenre.Name = "LabHighestGenre"
        Me.LabHighestGenre.Size = New System.Drawing.Size(128, 15)
        Me.LabHighestGenre.TabIndex = 6
        Me.LabHighestGenre.Text = "Highest Rated Genre: "
        '
        'LabHighestMovie
        '
        Me.LabHighestMovie.AutoSize = True
        Me.LabHighestMovie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabHighestMovie.Location = New System.Drawing.Point(22, 197)
        Me.LabHighestMovie.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabHighestMovie.Name = "LabHighestMovie"
        Me.LabHighestMovie.Size = New System.Drawing.Size(127, 15)
        Me.LabHighestMovie.TabIndex = 5
        Me.LabHighestMovie.Text = "Highest Rated Movie: "
        '
        'LabHighestActor
        '
        Me.LabHighestActor.AutoSize = True
        Me.LabHighestActor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabHighestActor.Location = New System.Drawing.Point(22, 165)
        Me.LabHighestActor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabHighestActor.Name = "LabHighestActor"
        Me.LabHighestActor.Size = New System.Drawing.Size(121, 15)
        Me.LabHighestActor.TabIndex = 4
        Me.LabHighestActor.Text = "Highest Rated Actor: "
        '
        'LabGenreMostMovies
        '
        Me.LabGenreMostMovies.AutoSize = True
        Me.LabGenreMostMovies.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabGenreMostMovies.Location = New System.Drawing.Point(22, 129)
        Me.LabGenreMostMovies.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabGenreMostMovies.Name = "LabGenreMostMovies"
        Me.LabGenreMostMovies.Size = New System.Drawing.Size(144, 15)
        Me.LabGenreMostMovies.TabIndex = 3
        Me.LabGenreMostMovies.Text = "Genre with Most Movies: "
        '
        'LabMostGenre
        '
        Me.LabMostGenre.AutoSize = True
        Me.LabMostGenre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMostGenre.Location = New System.Drawing.Point(22, 57)
        Me.LabMostGenre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabMostGenre.Name = "LabMostGenre"
        Me.LabMostGenre.Size = New System.Drawing.Size(120, 15)
        Me.LabMostGenre.TabIndex = 2
        Me.LabMostGenre.Text = "Most Rented Genre: "
        '
        'LabActorMostMovies
        '
        Me.LabActorMostMovies.AutoSize = True
        Me.LabActorMostMovies.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabActorMostMovies.Location = New System.Drawing.Point(22, 92)
        Me.LabActorMostMovies.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabActorMostMovies.Name = "LabActorMostMovies"
        Me.LabActorMostMovies.Size = New System.Drawing.Size(137, 15)
        Me.LabActorMostMovies.TabIndex = 1
        Me.LabActorMostMovies.Text = "Actor with Most Movies: "
        '
        'LabMostActor
        '
        Me.LabMostActor.AutoSize = True
        Me.LabMostActor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMostActor.Location = New System.Drawing.Point(22, 24)
        Me.LabMostActor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabMostActor.Name = "LabMostActor"
        Me.LabMostActor.Size = New System.Drawing.Size(113, 15)
        Me.LabMostActor.TabIndex = 0
        Me.LabMostActor.Text = "Most Rented Actor: "
        '
        '_291ProjectDataSet1
        '
        Me._291ProjectDataSet1.DataSetName = "_291ProjectDataSet"
        Me._291ProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '_291ProjectDataSet2
        '
        Me._291ProjectDataSet2.DataSetName = "_291ProjectDataSet"
        Me._291ProjectDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnTest
        '
        Me.BtnTest.Location = New System.Drawing.Point(877, 15)
        Me.BtnTest.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTest.Name = "BtnTest"
        Me.BtnTest.Size = New System.Drawing.Size(100, 28)
        Me.BtnTest.TabIndex = 4
        Me.BtnTest.Text = "OpenUserPage(Test)"
        Me.BtnTest.UseVisualStyleBackColor = True
        '
        'ManageActorsTab
        '
        Me.ManageActorsTab.Controls.Add(Me.ActorGridView)
        Me.ManageActorsTab.Controls.Add(Me.EditActorBut)
        Me.ManageActorsTab.Controls.Add(Me.RemoveActorButton)
        Me.ManageActorsTab.Controls.Add(Me.AddActorBut)
        Me.ManageActorsTab.Location = New System.Drawing.Point(4, 25)
        Me.ManageActorsTab.Name = "ManageActorsTab"
        Me.ManageActorsTab.Size = New System.Drawing.Size(984, 559)
        Me.ManageActorsTab.TabIndex = 4
        Me.ManageActorsTab.Text = "Actors"
        Me.ManageActorsTab.UseVisualStyleBackColor = True
        '
        'AddActorBut
        '
        Me.AddActorBut.Location = New System.Drawing.Point(20, 16)
        Me.AddActorBut.Name = "AddActorBut"
        Me.AddActorBut.Size = New System.Drawing.Size(101, 27)
        Me.AddActorBut.TabIndex = 0
        Me.AddActorBut.Text = "Add Actor"
        Me.AddActorBut.UseVisualStyleBackColor = True
        '
        'RemoveActorButton
        '
        Me.RemoveActorButton.Location = New System.Drawing.Point(858, 522)
        Me.RemoveActorButton.Name = "RemoveActorButton"
        Me.RemoveActorButton.Size = New System.Drawing.Size(107, 27)
        Me.RemoveActorButton.TabIndex = 1
        Me.RemoveActorButton.Text = "Delete Actor"
        Me.RemoveActorButton.UseVisualStyleBackColor = True
        '
        'EditActorBut
        '
        Me.EditActorBut.Location = New System.Drawing.Point(743, 522)
        Me.EditActorBut.Name = "EditActorBut"
        Me.EditActorBut.Size = New System.Drawing.Size(109, 27)
        Me.EditActorBut.TabIndex = 2
        Me.EditActorBut.Text = "Edit Actor"
        Me.EditActorBut.UseVisualStyleBackColor = True
        '
        'ActorGridView
        '
        Me.ActorGridView.AllowUserToAddRows = False
        Me.ActorGridView.AllowUserToDeleteRows = False
        Me.ActorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ActorGridView.Location = New System.Drawing.Point(20, 64)
        Me.ActorGridView.Name = "ActorGridView"
        Me.ActorGridView.ReadOnly = True
        Me.ActorGridView.RowTemplate.Height = 24
        Me.ActorGridView.Size = New System.Drawing.Size(945, 435)
        Me.ActorGridView.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 623)
        Me.Controls.Add(Me.BtnTest)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Management"
        Me.TabControl1.ResumeLayout(False)
        Me.ManageMovieTab.ResumeLayout(False)
        CType(Me.MovieGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ManageActorsTab.ResumeLayout(False)
        CType(Me.ActorGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ManageEmployeesTab.ResumeLayout(False)
        CType(Me.EmployeeGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ManageSalesTab.ResumeLayout(False)
        CType(Me.OrderGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ManageListsTab.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.ListsMovieRentals.ResumeLayout(False)
        CType(Me.TopYearlyDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ListsCustomerRentals.ResumeLayout(False)
        CType(Me.TopCustomerDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ListsAssorted.ResumeLayout(False)
        Me.ListsAssorted.PerformLayout()
        CType(Me._291ProjectDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._291ProjectDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ManageMovieTab As TabPage
    Friend WithEvents ManageEmployeesTab As TabPage
    Friend WithEvents ManageSalesTab As TabPage
    Friend WithEvents DeleteMovie As Button
    Friend WithEvents EditMovie As Button
    Friend WithEvents AddMovie As Button
    Friend WithEvents ManageListsTab As TabPage
    Friend WithEvents _291ProjectDataSet1 As _291ProjectDataSet
    Friend WithEvents MovieGridView As DataGridView
    Friend WithEvents _291ProjectDataSet2 As _291ProjectDataSet
    Friend WithEvents OrderGridView As DataGridView
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents ListsMovieRentals As TabPage
    Friend WithEvents TopMovieDatePicker As DateTimePicker
    Friend WithEvents TopYearlyDataGrid As DataGridView
    Friend WithEvents ListsAssorted As TabPage
    Friend WithEvents ListsCustomerRentals As TabPage
    Friend WithEvents CustomerListCombo As ComboBox
    Friend WithEvents MovieListCombo As ComboBox
    Friend WithEvents TopCustomerDatePicker As DateTimePicker
    Friend WithEvents TopCustomerDataGrid As DataGridView
    Friend WithEvents EditEmployee As Button
    Friend WithEvents DeleteEmployee As Button
    Friend WithEvents AddEmployee As Button
    Friend WithEvents EmployeeGridView As DataGridView
    Friend WithEvents LabHighestGenre As Label
    Friend WithEvents LabHighestMovie As Label
    Friend WithEvents LabHighestActor As Label
    Friend WithEvents LabGenreMostMovies As Label
    Friend WithEvents LabMostGenre As Label
    Friend WithEvents LabActorMostMovies As Label
    Friend WithEvents LabMostActor As Label
    Friend WithEvents LabHighestCustomer As Label
    Friend WithEvents LabMostDay As Label
    Friend WithEvents LabMostMonth As Label
    Friend WithEvents ManageActorsTab As TabPage
    Friend WithEvents ActorGridView As DataGridView
    Friend WithEvents EditActorBut As Button
    Friend WithEvents RemoveActorButton As Button
    Friend WithEvents AddActorBut As Button
End Class
