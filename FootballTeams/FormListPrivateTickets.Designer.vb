<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListPrivateTickets
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
        Me.GroupBoxAnalysisPST = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxFullAddressListPST = New System.Windows.Forms.TextBox()
        Me.TextBoxTicketChargeListPST = New System.Windows.Forms.TextBox()
        Me.TextBoxVATValueListPST = New System.Windows.Forms.TextBox()
        Me.ButtonAnalysisTicketListPST = New System.Windows.Forms.Button()
        Me.DataGridViewPST = New System.Windows.Forms.DataGridView()
        Me.LabelTotalTicketsPST = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonDeleteTicketPST = New System.Windows.Forms.Button()
        Me.ButtonCloseFormListPST = New System.Windows.Forms.Button()
        Me.ButtonHelpListPST = New System.Windows.Forms.Button()
        Me.ToolTipPrivateList = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBoxAnalysisPST.SuspendLayout()
        CType(Me.DataGridViewPST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxAnalysisPST
        '
        Me.GroupBoxAnalysisPST.Controls.Add(Me.Label7)
        Me.GroupBoxAnalysisPST.Controls.Add(Me.Label6)
        Me.GroupBoxAnalysisPST.Controls.Add(Me.Label3)
        Me.GroupBoxAnalysisPST.Controls.Add(Me.Label2)
        Me.GroupBoxAnalysisPST.Controls.Add(Me.Label1)
        Me.GroupBoxAnalysisPST.Controls.Add(Me.TextBoxFullAddressListPST)
        Me.GroupBoxAnalysisPST.Controls.Add(Me.TextBoxTicketChargeListPST)
        Me.GroupBoxAnalysisPST.Controls.Add(Me.TextBoxVATValueListPST)
        Me.GroupBoxAnalysisPST.Controls.Add(Me.ButtonAnalysisTicketListPST)
        Me.GroupBoxAnalysisPST.Location = New System.Drawing.Point(33, 338)
        Me.GroupBoxAnalysisPST.Name = "GroupBoxAnalysisPST"
        Me.GroupBoxAnalysisPST.Size = New System.Drawing.Size(886, 157)
        Me.GroupBoxAnalysisPST.TabIndex = 40
        Me.GroupBoxAnalysisPST.TabStop = False
        Me.GroupBoxAnalysisPST.Text = "Analysis Private Membership Ticket"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(285, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "£"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(285, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "£"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(100, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Season Ticket Charge"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(145, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "VAT Value:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(525, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Full Address:"
        '
        'TextBoxFullAddressListPST
        '
        Me.TextBoxFullAddressListPST.Enabled = False
        Me.TextBoxFullAddressListPST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxFullAddressListPST.Location = New System.Drawing.Point(617, 39)
        Me.TextBoxFullAddressListPST.Multiline = True
        Me.TextBoxFullAddressListPST.Name = "TextBoxFullAddressListPST"
        Me.TextBoxFullAddressListPST.Size = New System.Drawing.Size(200, 112)
        Me.TextBoxFullAddressListPST.TabIndex = 3
        '
        'TextBoxTicketChargeListPST
        '
        Me.TextBoxTicketChargeListPST.Enabled = False
        Me.TextBoxTicketChargeListPST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTicketChargeListPST.Location = New System.Drawing.Point(306, 77)
        Me.TextBoxTicketChargeListPST.Name = "TextBoxTicketChargeListPST"
        Me.TextBoxTicketChargeListPST.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxTicketChargeListPST.TabIndex = 2
        '
        'TextBoxVATValueListPST
        '
        Me.TextBoxVATValueListPST.Enabled = False
        Me.TextBoxVATValueListPST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxVATValueListPST.Location = New System.Drawing.Point(306, 45)
        Me.TextBoxVATValueListPST.Name = "TextBoxVATValueListPST"
        Me.TextBoxVATValueListPST.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxVATValueListPST.TabIndex = 1
        '
        'ButtonAnalysisTicketListPST
        '
        Me.ButtonAnalysisTicketListPST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAnalysisTicketListPST.Location = New System.Drawing.Point(18, 42)
        Me.ButtonAnalysisTicketListPST.Name = "ButtonAnalysisTicketListPST"
        Me.ButtonAnalysisTicketListPST.Size = New System.Drawing.Size(75, 50)
        Me.ButtonAnalysisTicketListPST.TabIndex = 0
        Me.ButtonAnalysisTicketListPST.Text = "Analysis Ticket"
        Me.ToolTipPrivateList.SetToolTip(Me.ButtonAnalysisTicketListPST, "Analysis the selected ticket")
        Me.ButtonAnalysisTicketListPST.UseVisualStyleBackColor = True
        '
        'DataGridViewPST
        '
        Me.DataGridViewPST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPST.Location = New System.Drawing.Point(51, 44)
        Me.DataGridViewPST.Name = "DataGridViewPST"
        Me.DataGridViewPST.Size = New System.Drawing.Size(767, 270)
        Me.DataGridViewPST.TabIndex = 41
        '
        'LabelTotalTicketsPST
        '
        Me.LabelTotalTicketsPST.AutoSize = True
        Me.LabelTotalTicketsPST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalTicketsPST.Location = New System.Drawing.Point(747, 319)
        Me.LabelTotalTicketsPST.Name = "LabelTotalTicketsPST"
        Me.LabelTotalTicketsPST.Size = New System.Drawing.Size(15, 16)
        Me.LabelTotalTicketsPST.TabIndex = 40
        Me.LabelTotalTicketsPST.Text = "0"
        Me.ToolTipPrivateList.SetToolTip(Me.LabelTotalTicketsPST, "The total number of tickets including corporate and private season tickets")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(652, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 16)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Total Tickets:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(400, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(199, 20)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Private Season Tickets List"
        '
        'ButtonDeleteTicketPST
        '
        Me.ButtonDeleteTicketPST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDeleteTicketPST.Location = New System.Drawing.Point(866, 152)
        Me.ButtonDeleteTicketPST.Name = "ButtonDeleteTicketPST"
        Me.ButtonDeleteTicketPST.Size = New System.Drawing.Size(75, 65)
        Me.ButtonDeleteTicketPST.TabIndex = 44
        Me.ButtonDeleteTicketPST.Text = "Delete Selected Ticket"
        Me.ToolTipPrivateList.SetToolTip(Me.ButtonDeleteTicketPST, "Delete a selected ticket on the datagrid")
        Me.ButtonDeleteTicketPST.UseVisualStyleBackColor = True
        '
        'ButtonCloseFormListPST
        '
        Me.ButtonCloseFormListPST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCloseFormListPST.Location = New System.Drawing.Point(866, 89)
        Me.ButtonCloseFormListPST.Name = "ButtonCloseFormListPST"
        Me.ButtonCloseFormListPST.Size = New System.Drawing.Size(75, 54)
        Me.ButtonCloseFormListPST.TabIndex = 43
        Me.ButtonCloseFormListPST.Text = "Close Form"
        Me.ToolTipPrivateList.SetToolTip(Me.ButtonCloseFormListPST, "Close this form")
        Me.ButtonCloseFormListPST.UseVisualStyleBackColor = True
        '
        'ButtonHelpListPST
        '
        Me.ButtonHelpListPST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHelpListPST.Location = New System.Drawing.Point(866, 251)
        Me.ButtonHelpListPST.Name = "ButtonHelpListPST"
        Me.ButtonHelpListPST.Size = New System.Drawing.Size(75, 49)
        Me.ButtonHelpListPST.TabIndex = 73
        Me.ButtonHelpListPST.Text = "?"
        Me.ToolTipPrivateList.SetToolTip(Me.ButtonHelpListPST, "Open the help form")
        Me.ButtonHelpListPST.UseVisualStyleBackColor = True
        '
        'FormListPrivateTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 518)
        Me.Controls.Add(Me.ButtonHelpListPST)
        Me.Controls.Add(Me.ButtonDeleteTicketPST)
        Me.Controls.Add(Me.ButtonCloseFormListPST)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelTotalTicketsPST)
        Me.Controls.Add(Me.DataGridViewPST)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBoxAnalysisPST)
        Me.Name = "FormListPrivateTickets"
        Me.Text = "FormListPrivateTickets"
        Me.GroupBoxAnalysisPST.ResumeLayout(False)
        Me.GroupBoxAnalysisPST.PerformLayout()
        CType(Me.DataGridViewPST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxAnalysisPST As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxFullAddressListPST As TextBox
    Friend WithEvents TextBoxTicketChargeListPST As TextBox
    Friend WithEvents TextBoxVATValueListPST As TextBox
    Friend WithEvents ButtonAnalysisTicketListPST As Button
    Friend WithEvents DataGridViewPST As DataGridView
    Friend WithEvents LabelTotalTicketsPST As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonDeleteTicketPST As Button
    Friend WithEvents ButtonCloseFormListPST As Button
    Friend WithEvents ButtonHelpListPST As Button
    Friend WithEvents ToolTipPrivateList As ToolTip
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
