Public Class FormAddCorporateTickets
    Dim csTicketType As CorporateSeasonTickets
    Private Sub FormAddCorporateTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Make the group boxes invisible 
        GroupBoxAddCorporateTickets.Visible = False
        GroupBoxAnalysisCST.Visible = False
        'Make the save button invisible
        ButtonSaveTicketCST.Visible = False
    End Sub

    Private Sub ButtonCloseFormAddCST_Click(sender As Object, e As EventArgs) Handles ButtonCloseFormAddCST.Click
        'This will ask the user if they want to close the form
        Dim closeC = MessageBox.Show("Do you want to close the form?", "Are you sure?", MessageBoxButtons.YesNoCancel)
        If closeC = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub ButtonNewTicketCST_Click(sender As Object, e As EventArgs) Handles ButtonNewTicketCST.Click
        'When clicked the add ticket groupbox will appear to add another ticket
        GroupBoxAddCorporateTickets.Visible = True
        ButtonSaveTicketCST.Visible = True
        GroupBoxAnalysisCST.Visible = False
        GroupBoxAddCorporateTickets.Enabled = True
    End Sub

    Private Sub ButtonSaveTicketCST_Click(sender As Object, e As EventArgs) Handles ButtonSaveTicketCST.Click
        If Me.ValidateChildren() = True Then
            'This is a new object for the corporate season tickets which includes the properties from the base contructor. This is linked to the main fields in the add tickets groupbox. 
            csTicketType = New CorporateSeasonTickets(SessionTicketNumTextBox.Text, YearlyChargeTextBox.Text, TeamNameTextBox.Text, StartDateDateTimePicker.Value, DatePurchasedDateTimePicker.Value, CustomerTitleTextBox.Text,
                CustomerForenameTextBox.Text, CustomerSurnameTextBox.Text, CustomerAddressTextBox.Text, CustomerPostcodeTextBox.Text, CustomerTelNumTextBox.Text)

            'Setting the other properties from the corporate season ticket class to equal the textboxes. 
            csTicketType.CompanyName = CompanyNameTextBox.Text
            csTicketType.CompanyContactName = CompanyContactNameTextBox.Text
            csTicketType.DiscountPercentage = DiscountPercentageTextBox.Text
            csTicketType.VIPAccessRequired = VIPAccessRequiredTextBox.Text
            csTicketType.VIPCost = VIPCostTextBox.Text

            'This is to add the object to the list of the objects created in the module. 
            'The try catch will look for an error if there is a problem adding the list of objects. 
            Try
                csTickets.Add(csTicketType)
            Catch ex As Exception
                MsgBox("Something went wrong when adding the list", vbExclamation, "Error has occured")
            End Try


            'Make the analysis ticket groupbox visible.
            GroupBoxAnalysisCST.Visible = True
            'Make the corporate ticket details group enabled to false so the user cannot change it.
            GroupBoxAddCorporateTickets.Enabled = False
            'Make the save ticket button invisible.
            ButtonSaveTicketCST.Visible = False
        End If
    End Sub

    Private Sub ButtonAnalysisTicketAddCST_Click(sender As Object, e As EventArgs) Handles ButtonAnalysisTicketAddCST.Click
        'Set the VAT textbox value to the GetVAT method
        TextBoxVATValueAddCST.Text = csTicketType.USEVAT(10)
        'Set the ticket charge textbox value to the GetSeasonTicketCharge
        TextBoxTicketChargeAddCST.Text = csTicketType.GetSeasonTicketCharge
        'Set the full address text box value to the GetBusinessFullAddress
        TextBoxFullAddressAddCST.Text = csTicketType.GetBusinessFullAddress

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

    Private Sub CompanyNameTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CompanyNameTextBox.Validating
        If CompanyNameTextBox.Text = "" Then
            MsgBox("No value was entered in company name", vbExclamation, "Please enter a value")
            e.Cancel = True
        End If
    End Sub

    Private Sub CompanyContactNameTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CompanyContactNameTextBox.Validating
        If CompanyContactNameTextBox.Text = "" Then
            MsgBox("No value was entered in company contact name", vbExclamation, "Please enter a value")
            e.Cancel = True
        ElseIf IsNumeric(CompanyContactNameTextBox.Text) = True Then
            MsgBox("Must be letters only", vbExclamation, "Invalid Input")
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

    Private Sub VIPAccessRequiredTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles VIPAccessRequiredTextBox.Validating

        If VIPAccessRequiredTextBox.Text = "" Then
            MsgBox("No value was entered in VIP access required", vbExclamation, "Please enter a value")
            e.Cancel = True
        ElseIf VIPAccessRequiredTextBox.Text <> "Y" And VIPAccessRequiredTextBox.Text <> "N" Then
            MsgBox("Must be Y or N entered", vbExclamation, "Invalid Input")
            e.Cancel = True

        End If
    End Sub

    Private Sub VIPCostTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles VIPCostTextBox.Validating
        If VIPCostTextBox.Text = "" Then
            MsgBox("No value was entered in VIP cost", vbExclamation, "Please enter a value")
            e.Cancel = True
        ElseIf IsNumeric(VIPCostTextBox.Text) = False Then
            MsgBox("Must be numbers only", vbExclamation, "Invalid Input")
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
            MsgBox("No value was entered in customer telephone number", vbExclamation, "Please enter a value")
            e.Cancel = True
        End If
    End Sub

End Class