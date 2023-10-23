Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Partial Public Class PinChecker
    Inherits System.Web.UI.Page
    Public Shared NuNameTB As TextBox
    Public Shared NuNameTB2 As TextBox

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub btnCheck_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCheck.Click
        Dim SQL As String
        Dim dbConnection As OleDbConnection
        Dim dbCommand As New OleDbCommand
        Dim dbFilePath As String = "C:\Users\eee p\Documents\Visual Studio 2008\Projects\Virtual Travilling Agency System\VIRTUALTRAVEL.mdb;"
        SQL = "SELECT Pin  FROM User_Pin_Generator"
        dbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbFilePath)
        dbCommand = New OleDbCommand(SQL, dbConnection)
        Dim data As New OleDbDataAdapter(dbCommand)
        Dim table As New DataTable("Test")
        dbConnection.Open()
        data.Fill(table)
        txtCheck.Text = table.Rows(txtCheck0.Text)("Pin").ToString()
        ClientScript.RegisterStartupScript(Page.[GetType](), "validation", "<script language='javascript'>alert('Valid Pin, you are due for the journey')</script>")

    End Sub

    Protected Sub btnProceed_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnProceed.Click
        NuNameTB = txtCheck0
        NuNameTB2 = txtCheck
        Response.Redirect("Pin slip.aspx")
    End Sub
End Class