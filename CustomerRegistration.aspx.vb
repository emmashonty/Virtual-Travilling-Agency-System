﻿Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Partial Public Class Customer_Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click
        Dim strSQL As String
        Dim objCmd As New OleDbCommand
        Dim Con = New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.3.51;Data Source=C:\Users\eee p\Documents\Visual Studio 2008\Projects\Virtual Travilling Agency System\VIRTUALTRAVEL.mdb;")
        strSQL = "INSERT INTO Customer_Login(Sur_Name, First_Name, E_Mail, Phone_Number,User_Name, Pass_word)"
        strSQL = strSQL & "VALUES('" & (txtSur.Text) & "', '" & (txtFirst.Text) & "', '" & (txtEmail.Text) & "','" & (txtPhone.Text) & "','" & (txtUser.Text) & "','" & (txtPass.Text) & "');"
        Con.Open()
        objCmd = New OleDbCommand(strSQL, Con)
        objCmd.ExecuteNonQuery()
        Con.Close()

        ClientScript.RegisterStartupScript(Page.[GetType](), "validation", "<script language='javascript'>alert('You have been successfull applied')</script>")
        Response.Redirect("Default.aspx")
    End Sub

    Protected Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        txtSur.Text = ""
        txtFirst.Text = ""
        txtEmail.Text = ""
        txtPhone.Text = ""
        txtUser.Text = ""
        txtPass.Text = ""
    End Sub
End Class