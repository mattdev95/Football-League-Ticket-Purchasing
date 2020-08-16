Public Class FormMainMenu
    Private Sub ButtonAddCorporateTickets_Click(sender As Object, e As EventArgs) Handles ButtonAddCorporateTickets.Click
        'This will open the Corporate Season ticket entry form
        FormAddCorporateTickets.ShowDialog()
    End Sub
    Private Sub ButtonListCorporateSeasontickets_Click(sender As Object, e As EventArgs) Handles ButtonListCorporateSeasontickets.Click
        'This will open the Corporate Season ticket list form
        FormListCorporateTickets.ShowDialog()
    End Sub

    Private Sub ButtonAddPrivateSeasonTickets_Click(sender As Object, e As EventArgs) Handles ButtonAddPrivateSeasonTickets.Click
        'This will open the Private Season ticket entry form
        FormAddPrivateTickets.ShowDialog()
    End Sub

    Private Sub ButtonListPrivateSeasonTickets_Click(sender As Object, e As EventArgs) Handles ButtonListPrivateSeasonTickets.Click
        'This will open the Private Season ticket list form
        FormListPrivateTickets.ShowDialog()
    End Sub

    Private Sub ButtonCloseFormMainMenu_Click(sender As Object, e As EventArgs) Handles ButtonCloseFormMainMenu.Click
        'This will close the main menu
        Me.Close()
    End Sub

    Private Sub ButtonHelpMainMenu_Click(sender As Object, e As EventArgs) Handles ButtonHelpMainMenu.Click
        'This will open the help form
        FormHelpScreen.Show()
    End Sub

    Private Sub CorporateSeasonTicketEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorporateSeasonTicketEntryToolStripMenuItem.Click
        'This will open the Corporate Season ticket entry form
        FormAddCorporateTickets.Show()
    End Sub

    Private Sub CorporateSeasonTicketListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorporateSeasonTicketListToolStripMenuItem.Click
        'This will open the Corporate Season ticket list form
        FormListCorporateTickets.Show()
    End Sub

    Private Sub PrivateSeasonTicketEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrivateSeasonTicketEntryToolStripMenuItem.Click
        'This will open the Private Season ticket entry form
        FormAddPrivateTickets.Show()
    End Sub

    Private Sub PrivateSeasonTicketListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrivateSeasonTicketListToolStripMenuItem.Click
        'This will open the Private Season ticket entry form
        FormListPrivateTickets.Show()
    End Sub

    Private Sub OpenHelpFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenHelpFormToolStripMenuItem.Click
        'This will open the help form
        FormHelpScreen.Show()
    End Sub

    Private Sub ExitProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitProgramToolStripMenuItem.Click
        'This will exit the program
        Application.Exit()
    End Sub
End Class
