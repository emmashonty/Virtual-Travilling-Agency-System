Public Partial Class Pin_slip
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = PinChecker.NuNameTB.Text
        Label2.Text = PinChecker.NuNameTB2.Text

    End Sub

    Protected Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnPrint.Click
        PrintHelper.PrintWebControl(Panel1)

    End Sub
End Class