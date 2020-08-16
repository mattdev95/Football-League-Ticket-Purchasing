Public Class FormAddPrivateTickets
    Dim psTicketType As PrivateSeasonTickets
    Private Sub FormAddPrivateTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Make the group boxes invisible 
        GroupBoxPrivateSeasonTicketsAdd.Visible = False
        GroupBoxAnalysisPST.Visible = False
        'Make the save button invisible
        ButtonSaveTicketPST.Visible = False
    End Sub

    Private Sub ButtonNewTicketPST_Click(sender As Object, e As EventArgs) Handles ButtonNewTicketPST.Click
        'When clicked the add ticket groupbox will appear to add another ticket
        GroupBoxPrivateSeasonTicketsAdd.Visible = True
        ButtonSaveTicketPST.Visible = True
        GroupBoxAnalysisPST.Visible = False
        GroupBoxPrivateSeasonTicketsAdd.Enabled = True
    End Sub

    Private Sub ButtonSaveTicketPST_Click(sender As Object, e As EventArgs) Handles ButtonSaveTicketPST.Click
        If Me.ValidateChildren() = True Then
            'This is a new object for the private season tickets which includes the properties from the base contructor. This is linked to the main fields in the add tickets groupbox.
            psTicketType = New PrivateSeasonTickets(SessionTicketNumTextBox.Text, YearlyChargeTextBox.Text, TeamNameTextBox.Text, StartDateDateTimePicker.Value, DatePurchasedDateTimePicker.Value, CustomerTitleTextBox.Text,
            CustomerForenameTextBox.Text, CustomerSurnameTextBox.Text, CustomerAddressTextBox.Text, CustomerPostcodeTextBox.Text, CustomerTelNumTextBox.Text)
            'Setting the other properties from the private season ticket class to equal the textboxes. 
            psTicketType.EmployerNumber = EmployerNumberTextBox.Text
            psTicketType.DiscountPercentage = DiscountPercentageTextBox.Text
            psTicketType.PaymentMethod = PaymentMethodTextBox.Text
            'This is to add the object to the list of the objects created in the module. 
            'The try catch will look for an error if there is a problem adding the list of objects.
            Try
                psTickets.Add(psTicketType)
            Catch ex As Exception
                MsgBox("Something went wrong when adding the list", vbExclamation, "Error has occured")
            End Try
            'Make the analysis ticket groupbox visible.
            GroupBoxAnalysisPST.Visible = True
            'Make the corporate ticket details group enabled to false so the user cannot change it.
            GroupBoxPrivateSeasonTicketsAdd.Enabled = False
            'Make the save ticket button invisible.
            ButtonSaveTicketPST.Visible = False
        End If
    End Sub

    Private Sub ButtonAnalysisTicketAddPST_Click(sender As Object, e As EventArgs) Handles ButtonAnalysisTicketAddPST.Click
        'Set the VAT textbox value to the GetVAT method
        TextBoxVATValueAddPST.Text = psTicketType.USEVAT(10)
        'Set the ticket charge textbox value to the GetSeasonTicketCharge
        TextBoxTicketChargeAddPST.Text = psTicketType.GetSeasonTicketCharge
        'Set the full address text box value to the GetBusinessFullAddress
        TextBoxFullAddressAddPST.Text = psTicketType.GetFullAddress
    End Sub

    Private Sub ButtonCloseFormAddCST_Click(sender As Object, e As EventArgs) Handles ButtonCloseFormAddCST.Click
        'This will ask the user if they want to close the form
        Dim closeP = MessageBox.Show("Do you want to close the form?", "Are you sure?", MessageBoxButtons.YesNoCancel)
        If closeP = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub ButtonHelpAddCST_Click(sender As Object, e As EventArgs) Handles ButtonHelpAddCST.Click
        'This will open the help form
        FormHelpScreen.Show()
    End Sub

    'Setup validation
    Private Sub SessionTicketNumTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SessionTicketNumTextBox.Validating
        If SessionTicketNumTextBox.Text = "" Then
            MsgBox("No value was entered in session ticket num", vbExclamation, "Please enter a value")
            e.Cancel = True
        ElseIf IsNumeric(SessionTicketNumTextBox.Text) = False Then
            MsgBox("Must be numbers only", vbExclamation, "Invalid Input")
            e.Cancel = True
        End If
    End Sub

    Private Sub TeamNameTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TeamNameTextBox.Validating
        If TeamNameTextBox.Text = "" Then
            MsgBox("No value was entered in team name", vbExclamation, "Please enter a value")
            e.Cancel = True
        ElseIf IsNumeric(TeamNameTextBox.Text) = True Then
            MsgBox("Must be letters only", vbExclamation, "Invalid Input")
            e.Cancel = True
        End If
    End Sub

    Private Sub YearlyChargeTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles YearlyChargeTextBox.Validating
        If YearlyChargeTextBox.Text = "" Then
            MsgBox("No value was entered in yearly charge", vbExclamation, "Please enter a value")
            e.Cancel = True
        ElseIf IsNumeric(YearlyChargeTextBox.Text) = False Then
            MsgBox("Must be numbers only", vbExclamation, "Invalid Input")
            e.Cancel = True
        End If
    End Sub

    Private Sub EmployerNumberTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles EmployerNumberTextBox.Validating
        If EmployerNumberTextBox.Text = "" Then
            MsgBox("No value was entered in employer number", vbExclamation, "Please enter a value")
            e.Cancel = True
        ElseIf IsNumeric(EmployerNumberTextBox.Text) = False Then
            MsgBox("Must be numbers only", vbExclamation, "Invalid Input")
            e.Cancel = True
        End If
    End Sub

    Private Sub DiscountPercentageTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles DiscountPercentageTextBox.Validating
        If DiscountPercentageTextBox.Text = "" Then
            MsgBox("No value was entered in discount percentage", vbExclamation, "Please enter a value")
            e.Cancel = True
        ElseIf IsNumeric(DiscountPercentageTextBox.Text) = False Then
            MsgBox("Must be numbers only", vbExclamation, "Invalid Input")
            e.Cancel = True
        ElseIf DiscountPercentageTextBox.Text > 100 Then
            MsgBox("The number percentage range is from 1 to 100", vbExclamation, "Value too high")
            e.Cancel = True
        End If
    End Sub

    Private Sub PaymentMethodTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles PaymentMethodTextBox.Validating
        If PaymentMethodTextBox.Text = "" Then
            MsgBox("No value was entered in payment method", vbExclamation, "Please enter a value")
            e.Cancel = True
        ElseIf IsNumeric(PaymentMethodTextBox.Text) = True Then
            MsgBox("Must be letters only", vbExclamation, "Invalid Input")
            e.Cancel = True
        End If
    End Sub

    Private Sub CustomerTitleTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CustomerTitleTextBox.Validating
        If CustomerTitleTextBox.Text = "" Then
            MsgBox("No value was entered in customer title", vbExclamation, "Please enter a value")
            e.Cancel = True
        ElseIf IsNumeric(CustomerTitleTextBox.Text) = True Then
            MsgBox("Must be letters only", vbExclamation, "Invalid Input")
            e.Cancel = True
        End If
    End Sub

    Private Sub CustomerForenameTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CustomerForenameTextBox.Validating
        If CustomerForenameTextBox.Text = "" Then
            MsgBox("No value was entered in customer forename", vbExclamation, "Please enter a value")
            e.Cancel = True
        ElseIf IsNumeric(CustomerForenameTextBox.Text) = True Then
            MsgBox("Must be letters only", vbExclamation, "Invalid Input")
            e.Cancel = True
        End If
    End Sub

    Private Sub CustomerSurnameTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CustomerSurnameTextBox.Validating
        If CustomerSurnameTextBox.Text = "" Then
            MsgBox("No value was entered in customer surname", vbExclamation, "Please enter a value")
            e.Cancel = True
        ElseIf IsNumeric(CustomerSurnameTextBox.Text) = True Then
            MsgBox("Must be letters only", vbExclamation, "Invalid Input")
            e.Cancel = True
        End If
    End Sub

    Private Sub CustomerAddressTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CustomerAddressTextBox.Validating
        If CustomerAddressTextBox.Text = "" Then
            MsgBox("No value was entered in customer address", vbExclamation, "Please enter a value")
            e.Cancel = True
        End If
    End Sub

    Private Sub CustomerPostcodeTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CustomerPostcodeTextBox.Validating
        If CustomerPostcodeTextBox.Text = "" Then
            MsgBox("No value was entered in customer postcode", vbExclamation, "Please enter a value")
            e.Cancel = True
        End If
    End Sub

    Private Sub CustomerTelNumTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CustomerTelNumTextBox.Validating
        If CustomerTelNumTextBox.Text = "" Then
            MsgBox("No value was entered in customer telephone", vbExclamation, "Please enter a value")
            e.Cancel = True
        End If
    End Sub
End Class