Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Partial Public Class AdminPinChecker
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click
        Dim strSQL As String
        Dim objCmd As New OleDbCommand
        Dim Con = New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.3.51;Data Source=C:\Users\eee p\Documents\Visual Studio 2008\Projects\Virtual Travilling Agency SystemC:\Users\eee p\Documents\Visual Studio 2008\Projects\Virtual Travilling Agency System\VIRTUALTRAVEL.mdb;")
        strSQL = "INSERT INTO Admin_Check_Pin(Pin)"
        strSQL = strSQL & "VALUES('" & (txtCheck.Text) & "');"
        Con.Open()
        objCmd = New OleDbCommand(strSQL, Con)
        objCmd.ExecuteNonQuery()
        Con.Close()

        ClientScript.RegisterStartupScript(Page.[GetType](), "validation", "<script language='javascript'>alert('You have been successfull applied')</script>")
        Response.Redirect("Admin.aspx")
    End Sub
End Class