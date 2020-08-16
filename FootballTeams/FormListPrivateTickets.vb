Public Class FormListPrivateTickets
    Private Sub FormListPrivateTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setup the datagrid
        DataGridViewPST.AutoGenerateColumns = True
        DataGridViewPST.AllowUserToAddRows = False
        DataGridViewPST.AllowUserToDeleteRows = False
        'Create a new binding source 
        Dim bindPrivTic As New BindingSource
        'Set the data source to the list of objects in the global project module
        bindPrivTic.DataSource = psTickets
        'Set the datagrid to the binding source variable
        DataGridViewPST.DataSource = bindPrivTic
        'Update the count for the total amount of tickets 
        LabelTotalTicketsPST.Text = PrivateSeasonTickets.CountTickets()
    End Sub
    Private Sub ButtonDeleteTicketPST_Click(sender As Object, e As EventArgs) Handles ButtonDeleteTicketPST.Click
        'This will remove a row in the datagrid
        Dim privTicDel As PrivateSeasonTickets
        'This loops through each selected row in the datagrid. 
        For Each drP As DataGridViewRow In DataGridViewPST.SelectedRows
            'Sets the corporate ticket variable to the ticket object in the row.
            privTicDel = drP.DataBoundItem()
            'This will remove a row in the datagrid 
            DataGridViewPST.Rows.Remove(drP)
            'This will remove one object from the count
            privTicDel.Remove()
        Next
        'Update the count for the total amount of tickets 
        LabelTotalTicketsPST.Text = PrivateSeasonTickets.CountTickets()
    End Sub

    Private Sub ButtonCloseFormListPST_Click(sender As Object, e As EventArgs) Handles ButtonCloseFormListPST.Click
        'This will close the current form
        Me.Close()
    End Sub

    Private Sub ButtonAnalysisTicketListPST_Click(sender As Object, e As EventArgs) Handles ButtonAnalysisTicketListPST.Click
        'This variable is to point to a private season ticket object
        Dim PrivTicAnal As PrivateSeasonTickets
        'If the Corporate Season Ticket class count is over 0 otherwise it will clear the strings in the analysis text boxes to blank.
        If PrivateSeasonTickets.CountTickets > 0 = True Then
            'This variable is to point to the current corporate season ticket object in the datagrid
            PrivTicAnal = DataGridViewPST.CurrentRow.DataBoundItem
            'Equal the textboxes to the methods in the Corporate Season Ticket class. 
            TextBoxVATValueListPST.Text = PrivTicAnal.USEVAT(10)
            TextBoxTicketChargeListPST.Text = PrivTicAnal.GetSeasonTicketCharge
            TextBoxFullAddressListPST.Text = PrivTicAnal.GetFullAddress
        Else
            TextBoxVATValueListPST.Text = ""
            TextBoxTicketChargeListPST.Text = ""
            TextBoxFullAddressListPST.Text = ""
        End If
    End Sub

    Private Sub ButtonHelpListPST_Click(sender As Object, e As EventArgs) Handles ButtonHelpListPST.Click
        'This will open the help form
        FormHelpScreen.Show()
    End Sub
End Class