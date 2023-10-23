Imports System.Data
Imports System.Data.OleDb
Partial Public Class AdminLogin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Login1_Authenticate(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.AuthenticateEventArgs) Handles Login1.Authenticate
        Dim connString As String = "PROVIDER=Microsoft.Jet.OLEDB.3.51;Data Source=C:\Users\eee p\Documents\Visual Studio 2008\Projects\Virtual Travilling Agency System\VIRTUALTRAVEL.mdb;"
        Dim myConnection As OleDbConnection = New OleDbConnection
        Dim da As OleDbDataAdapter
        Dim strSQL As String
        Dim ds As DataSet
        Dim RegNo As String
        strSQL = "SELECT* FROM Admin_Registration "
        strSQL = strSQL & "WHERE (User_Name = '" & (Login1.UserName) & "' "
        strSQL = strSQL & "And Pass_word = '" & (Login1.Password) & "');"
        myConnection.ConnectionString = connString
        da = New OleDbDataAdapter(strSQL, myConnection)
        ds = New DataSet
        da.Fill(ds, "Infor")
        myConnection.Close()
        For Each rowTest In ds.Tables(0).Rows
            RegNo = rowTest("Pass_word").ToString
            If RegNo <> "" Then
                Response.Redirect("Admin.aspx")
            Else
                ClientScript.RegisterStartupScript(Page.[GetType](), "validation", "<script language='javascript'>alert('Invalid Admin User, check your Username and Password and try again')</script>")
            End If
        Next

    End Sub
End Class