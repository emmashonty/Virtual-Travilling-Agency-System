Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Partial Public Class Enquiry
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnSend_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSend.Click
        Dim strSQL As String
        Dim objCmd As New OleDbCommand
        Dim Con = New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.3.51;Data Source=C:\Users\eee p\Documents\Visual Studio 2008\Projects\Virtual Travilling Agency System\VIRTUALTRAVEL.mdb;")
        strSQL = "INSERT INTO Enquiry(E_Mail, UserName, Topic, Message)"
        strSQL = strSQL & "VALUES('" & (txtEmail.Text) & "', '" & (txtUsername.Text) & "', '" & (txtTopic.Text) & "','" & (txtEnquire.Text) & "');"
        Con.Open()
        objCmd = New OleDbCommand(strSQL, Con)
        objCmd.ExecuteNonQuery()
        Con.Close()

        ClientScript.RegisterStartupScript(Page.[GetType](), "validation", "<script language='javascript'>alert('Enquiry has been successfull')</script>")
        txtEmail.Text = ""
        txtUsername.Text = ""
        txtTopic.Text = ""
        txtEnquire.Text = ""
    End Sub

    Protected Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        txtEmail.Text = ""
        txtUsername.Text = ""
        txtTopic.Text = ""
        txtEnquire.Text = ""

    End Sub
End Class