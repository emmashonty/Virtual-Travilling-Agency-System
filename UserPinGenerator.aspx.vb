Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Partial Public Class UserPinGenerator
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Dim random As New Random
    Protected Sub btnGenerate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGenerate.Click
        txtGen.Text = random.Next
        ClientScript.RegisterStartupScript(Page.[GetType](), "validation", "<script language='javascript'>alert('Pin has been successfully generated')</script>")

    End Sub

    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Dim strSQL As String
        Dim objCmd As New OleDbCommand
        Dim Con = New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.3.51;Data Source=C:\Users\eee p\Documents\Visual Studio 2008\Projects\Virtual Travilling Agency System\VIRTUALTRAVEL.mdb;")
        strSQL = "INSERT INTO User_Pin_Generator(Pin)"
        strSQL = strSQL & "VALUES('" & (txtGen.Text) & "');"
        Con.Open()
        objCmd = New OleDbCommand(strSQL, Con)
        objCmd.ExecuteNonQuery()
        Con.Close()

        ClientScript.RegisterStartupScript(Page.[GetType](), "validation", "<script language='javascript'>alert('Pin has been successfully Save')</script>")
        txtGen.Text = ""
        txtGen0.Text = ""
    End Sub
End Class