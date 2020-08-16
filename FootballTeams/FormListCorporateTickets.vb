Public Class FormListCorporateTickets
    Private Sub FormListCorporateTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setup the datagrid
        DataGridViewCST.AutoGenerateColumns = True
        DataGridViewCST.AllowUserToAddRows = False
        DataGridViewCST.AllowUserToDeleteRows = False
        'Create a new binding source 
        Dim bindCorp As New BindingSource
        'Set the data source to the list of objects in the global project module.
        bindCorp.DataSource = csTickets
        'Set the datagrid to the binding source variable
        DataGridViewCST.DataSource = bindCorp
        'Update the count for the total amount of tickets 
        LabelTotalTicketsCST.Text = CorporateSeasonTickets.CountTickets
    End Sub
    Private Sub ButtonCloseFormListCST_Click(sender As Object, e As EventArgs) Handles ButtonCloseFormListCST.Click
        'This will close the current form
        Me.Close()
    End Sub
    Private Sub ButtonDeleteTicketCST_Click(sender As Object, e As EventArgs) Handles ButtonDeleteTicketCST.Click
        'This will remove a row in the datagrid
        Dim corpTickDels As CorporateSeasonTickets
        'This loops through each selected row in the datagrid. 
        For Each drC As DataGridViewRow In DataGridViewCST.SelectedRows
            'sets the corporate ticket variable to the ticket object in the row.
            corpTickDels = drC.DataBoundItem()
            'This will remove a row in the datagrid 
            DataGridViewCST.Rows.Remove(drC)
            'This will remove one object from the count
            corpTickDels.Remove()
        Next
        'Update the count for the total amount of tickets 
        LabelTotalTicketsCST.Text = CorporateSeasonTickets.CountTickets
    End Sub

    Private Sub ButtonAnalysisTicketListCST_Click(sender As Object, e As EventArgs) Handles ButtonAnalysisTicketListCST.Click
        'This variable is to point to a corporate season ticket object
        Dim corpTickAnaly As CorporateSeasonTickets

        'If the Corporate Season Ticket class count is over 0 otherwise it will clear the strings in the analysis text boxes to blank.
        If CorporateSeasonTickets.CountTickets > 0 = True Then
            'This variable is to point to the current corporate season ticket object in the datagrid
            corpTickAnaly = DataGridViewCST.CurrentRow.DataBoundItem
            'Equal the textboxes to the methods in the Corporate Season Ticket class. 
            TextBoxVATValueListCST.Text = corpTickAnaly.USEVAT(10)
            TextBoxTicketChargeListCST.Text = corpTickAnaly.GetSeasonTicketCharge
            TextBoxFullAddressListCST.Text = corpTickAnaly.GetBusinessFullAddress
        Else
            TextBoxVATValueListCST.Text = ""
            TextBoxTicketChargeListCST.Text = ""
            TextBoxFullAddressListCST.Text = ""
        End If
    End Sub
    Private Sub ButtonHelpListCST_Click(sender As Object, e As EventArgs) Handles ButtonHelpListCST.Click
        'This will open the help form
        FormHelpScreen.Show()
    End Sub
End Class