Public Class MainMenu
    Private Sub BtnAdmin_Click(sender As Object, e As EventArgs) Handles BtnAdmin.Click
        Dim Admin = New Form1
        Admin.Show()
    End Sub

    Private Sub BtnUser_Click(sender As Object, e As EventArgs) Handles BtnUser.Click
        Dim userform = New User
        userform.Show()
    End Sub

    Private Sub BtnCusRep_Click(sender As Object, e As EventArgs) Handles BtnCusRep.Click
        Dim CusRep = New CustRep
        CusRep.Show()
    End Sub
End Class