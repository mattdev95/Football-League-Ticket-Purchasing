Public Class FormHelpScreen
    Private Sub ButtonCloseFormHelp_Click(sender As Object, e As EventArgs) Handles ButtonCloseFormHelp.Click
        'This will close the form
        Me.Close()
    End Sub

    Private Sub FormHelpScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim l As String
        'This loads the help document into the help form
        l = Application.StartupPath & "\Resources\HelpForm.mht"
        WebBrowserHelpForm.Navigate(l)
    End Sub
End Class