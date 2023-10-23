Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Partial Public Class UserRegistration
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click
        Dim strSQL As String
        Dim objCmd As New OleDbCommand
        Dim Con = New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.3.51;Data Source=C:\Users\eee p\Documents\Visual Studio 2008\Projects\Virtual Travilling Agency System\VIRTUALTRAVEL.mdb;")
        strSQL = "INSERT INTO UserRegistration(Sur_Name, First_Name, Last_Name, C_Gender,C_Occupation, Phone_Number,User_Name, C_Password, E_mail, C_Town,C_State, C_Country)"
        strSQL = strSQL & "VALUES('" & (txtSur.Text) & "', '" & (txtFirst.Text) & "', '" & (txtLast.Text) & "','" & (txtGender.Text) & "','" & (txtOccup.Text) & "','" & (txtPhone.Text) & "','" & (txtUser.Text) & "', '" & (txtPass.Text) & "', '" & (txtEmail.Text) & "','" & (txtTown.Text) & "','" & (txtState.Text) & "','" & (txtCountry.Text) & "');"
        Con.Open()
        objCmd = New OleDbCommand(strSQL, Con)
        objCmd.ExecuteNonQuery()
        Con.Close()

        ClientScript.RegisterStartupScript(Page.[GetType](), "validation", "<script language='javascript'>alert('Customer information has been successfull')</script>")
        txtSur.Text = ""
        txtFirst.Text = ""
        txtLast.Text = ""
        txtGender.Text = ""
        txtOccup.Text = ""
        txtPhone.Text = ""
        txtUser.Text = ""
        txtPass.Text = ""
        txtEmail.Text = ""
        txtTown.Text = ""
        txtState.Text = ""
        txtCountry.Text = ""
    End Sub

    Protected Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        txtSur.Text = ""
        txtFirst.Text = ""
        txtLast.Text = ""
        txtGender.Text = ""
        txtOccup.Text = ""
        txtPhone.Text = ""
        txtUser.Text = ""
        txtPass.Text = ""
        txtEmail.Text = ""
        txtTown.Text = ""
        txtState.Text = ""
        txtCountry.Text = ""

    End Sub
End Class