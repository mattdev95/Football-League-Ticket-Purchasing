<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListCorporateTickets
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBoxAnalysisCST = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxFullAddressListCST = New System.Windows.Forms.TextBox()
        Me.TextBoxTicketChargeListCST = New System.Windows.Forms.TextBox()
        Me.TextBoxVATValueListCST = New System.Windows.Forms.TextBox()
        Me.ButtonAnalysisTicketListCST = New System.Windows.Forms.Button()
        Me.DataGridViewCST = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelTotalTicketsCST = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonCloseFormListCST = New System.Windows.Forms.Button()
        Me.ButtonDeleteTicketCST = New System.Windows.Forms.Button()
        Me.ButtonHelpListCST = New System.Windows.Forms.Button()
        Me.ToolTipCorporateList = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBoxAnalysisCST.SuspendLayout()
        CType(Me.DataGridViewCST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxAnalysisCST
        '
        Me.GroupBoxAnalysisCST.Controls.Add(Me.Label7)
        Me.GroupBoxAnalysisCST.Controls.Add(Me.Label5)
        Me.GroupBoxAnalysisCST.Controls.Add(Me.Label3)
        Me.GroupBoxAnalysisCST.Controls.Add(Me.Label2)
        Me.GroupBoxAnalysisCST.Controls.Add(Me.Label1)
        Me.GroupBoxAnalysisCST.Controls.Add(Me.TextBoxFullAddressListCST)
        Me.GroupBoxAnalysisCST.Controls.Add(Me.TextBoxTicketChargeListCST)
        Me.GroupBoxAnalysisCST.Controls.Add(Me.TextBoxVATValueListCST)
        Me.GroupBoxAnalysisCST.Controls.Add(Me.ButtonAnalysisTicketListCST)
        Me.GroupBoxAnalysisCST.Location = New System.Drawing.Point(75, 385)
        Me.GroupBoxAnalysisCST.Name = "GroupBoxAnalysisCST"
        Me.GroupBoxAnalysisCST.Size = New System.Drawing.Size(820, 157)
        Me.GroupBoxAnalysisCST.TabIndex = 35
        Me.GroupBoxAnalysisCST.TabStop = False
        Me.GroupBoxAnalysisCST.Text = "Analysis Corporate Season Ticket"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(115, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Season Ticket Charge:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(167, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "VAT Value:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(435, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Business Full Address:"
        '
        'TextBoxFullAddressListCST
        '
        Me.TextBoxFullAddressListCST.Enabled = False
        Me.TextBoxFullAddressListCST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxFullAddressListCST.Location = New System.Drawing.Point(585, 39)
        Me.TextBoxFullAddressListCST.Multiline = True
        Me.TextBoxFullAddressListCST.Name = "TextBoxFullAddressListCST"
        Me.TextBoxFullAddressListCST.Size = New System.Drawing.Size(183, 112)
        Me.TextBoxFullAddressListCST.TabIndex = 3
        '
        'TextBoxTicketChargeListCST
        '
        Me.TextBoxTicketChargeListCST.Enabled = False
        Me.TextBoxTicketChargeListCST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTicketChargeListCST.Location = New System.Drawing.Point(274, 74)
        Me.TextBoxTicketChargeListCST.Name = "TextBoxTicketChargeListCST"
        Me.TextBoxTicketChargeListCST.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxTicketChargeListCST.TabIndex = 2
        '
        'TextBoxVATValueListCST
        '
        Me.TextBoxVATValueListCST.Enabled = False
        Me.TextBoxVATValueListCST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxVATValueListCST.Location = New System.Drawing.Point(274, 42)
        Me.TextBoxVATValueListCST.Name = "TextBoxVATValueListCST"
        Me.TextBoxVATValueListCST.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxVATValueListCST.TabIndex = 1
        '
        'ButtonAnalysisTicketListCST
        '
        Me.ButtonAnalysisTicketListCST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAnalysisTicketListCST.Location = New System.Drawing.Point(18, 55)
        Me.ButtonAnalysisTicketListCST.Name = "ButtonAnalysisTicketListCST"
        Me.ButtonAnalysisTicketListCST.Size = New System.Drawing.Size(75, 50)
        Me.ButtonAnalysisTicketListCST.TabIndex = 0
        Me.ButtonAnalysisTicketListCST.Text = "Analysis Ticket"
        Me.ToolTipCorporateList.SetToolTip(Me.ButtonAnalysisTicketListCST, "Anaysis the selected ticket")
        Me.ButtonAnalysisTicketListCST.UseVisualStyleBackColor = True
        '
        'DataGridViewCST
        '
        Me.DataGridViewCST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCST.Location = New System.Drawing.Point(93, 86)
        Me.DataGridViewCST.Name = "DataGridViewCST"
        Me.DataGridViewCST.Size = New System.Drawing.Size(750, 227)
        Me.DataGridViewCST.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(584, 339)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 16)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Total Tickets:"
        '
        'LabelTotalTicketsCST
        '
        Me.LabelTotalTicketsCST.AutoSize = True
        Me.LabelTotalTicketsCST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalTicketsCST.Location = New System.Drawing.Point(679, 339)
        Me.LabelTotalTicketsCST.Name = "LabelTotalTicketsCST"
        Me.LabelTotalTicketsCST.Size = New System.Drawing.Size(15, 16)
        Me.LabelTotalTicketsCST.TabIndex = 38
        Me.LabelTotalTicketsCST.Text = "0"
        Me.ToolTipCorporateList.SetToolTip(Me.LabelTotalTicketsCST, "The total number of tickets including corporate and private season tickets")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(370, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(214, 20)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Corporate Season Ticket List"
        '
        'ButtonCloseFormListCST
        '
        Me.ButtonCloseFormListCST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCloseFormListCST.Location = New System.Drawing.Point(862, 86)
        Me.ButtonCloseFormListCST.Name = "ButtonCloseFormListCST"
        Me.ButtonCloseFormListCST.Size = New System.Drawing.Size(75, 44)
        Me.ButtonCloseFormListCST.TabIndex = 40
        Me.ButtonCloseFormListCST.Text = "Close Form"
        Me.ToolTipCorporateList.SetToolTip(Me.ButtonCloseFormListCST, "Close this form")
        Me.ButtonCloseFormListCST.UseVisualStyleBackColor = True
        '
        'ButtonDeleteTicketCST
        '
        Me.ButtonDeleteTicketCST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDeleteTicketCST.Location = New System.Drawing.Point(862, 149)
        Me.ButtonDeleteTicketCST.Name = "ButtonDeleteTicketCST"
        Me.ButtonDeleteTicketCST.Size = New System.Drawing.Size(75, 66)
        Me.ButtonDeleteTicketCST.TabIndex = 41
        Me.ButtonDeleteTicketCST.Text = "Delete Selected Ticket"
        Me.ToolTipCorporateList.SetToolTip(Me.ButtonDeleteTicketCST, "Delete a selected ticket on the datagrid")
        Me.ButtonDeleteTicketCST.UseVisualStyleBackColor = True
        '
        'ButtonHelpListCST
        '
        Me.ButtonHelpListCST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHelpListCST.Location = New System.Drawing.Point(862, 339)
        Me.ButtonHelpListCST.Name = "ButtonHelpListCST"
        Me.ButtonHelpListCST.Size = New System.Drawing.Size(75, 49)
        Me.ButtonHelpListCST.TabIndex = 73
        Me.ButtonHelpListCST.Text = "?"
        Me.ToolTipCorporateList.SetToolTip(Me.ButtonHelpListCST, "Open help form")
        Me.ButtonHelpListCST.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(253, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "£"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(253, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "£"
        '
        'FormListCorporateTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 554)
        Me.Controls.Add(Me.ButtonHelpListCST)
        Me.Controls.Add(Me.ButtonDeleteTicketCST)
        Me.Controls.Add(Me.ButtonCloseFormListCST)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelTotalTicketsCST)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridViewCST)
        Me.Controls.Add(Me.GroupBoxAnalysisCST)
        Me.Name = "FormListCorporateTickets"
        Me.Text = "FormListCorporateTickets"
        Me.GroupBoxAnalysisCST.ResumeLayout(False)
        Me.GroupBoxAnalysisCST.PerformLayout()
        CType(Me.DataGridViewCST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxAnalysisCST As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxFullAddressListCST As TextBox
    Friend WithEvents TextBoxTicketChargeListCST As TextBox
    Friend WithEvents TextBoxVATValueListCST As TextBox
    Friend WithEvents ButtonAnalysisTicketListCST As Button
    Friend WithEvents DataGridViewCST As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelTotalTicketsCST As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonCloseFormListCST As Button
    Friend WithEvents ButtonDeleteTicketCST As Button
    Friend WithEvents ButtonHelpListCST As Button
    Friend WithEvents ToolTipCorporateList As ToolTip
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
End Class
