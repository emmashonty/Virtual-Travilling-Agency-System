Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Partial Public Class Pin_Report
    Inherits System.Web.UI.Page
    Dim myDA As OleDbDataAdapter
    Dim myDataSet As DataSet
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim con As OleDbConnection = New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.3.51;Data Source=C:\Users\eee p\Documents\Visual Studio 2008\Projects\Virtual Travilling Agency System\VIRTUALTRAVEL.mdb;")
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM User_Pin_Generator ", con)

        con.Open()

        myDA = New OleDbDataAdapter(cmd)

        'Here one CommandBuilder object is required.

        'It will automatically generate DeleteCommand,UpdateCommand and InsertCommand for DataAdapter object

        Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(myDA)

        myDataSet = New DataSet()

        myDA.Fill(myDataSet, "MyTable")

        GridView1.DataSource = myDataSet.Tables("MyTable").DefaultView
        GridView1.DataBind()

        con.Close()

        con = Nothing
    End Sub

    Protected Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnPrint.Click
        PrintHelper.PrintWebControl(Panel1)

    End Sub
End Class