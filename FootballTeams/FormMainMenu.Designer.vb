<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMainMenu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonAddCorporateTickets = New System.Windows.Forms.Button()
        Me.ButtonListCorporateSeasontickets = New System.Windows.Forms.Button()
        Me.ButtonAddPrivateSeasonTickets = New System.Windows.Forms.Button()
        Me.ButtonListPrivateSeasonTickets = New System.Windows.Forms.Button()
        Me.ButtonHelpMainMenu = New System.Windows.Forms.Button()
        Me.ButtonCloseFormMainMenu = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorporateSeasonTicketEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorporateSeasonTicketListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrivateSeasonTicketEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrivateSeasonTicketListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenHelpFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolTipMainMenu = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(437, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Main Menu"
        '
        'ButtonAddCorporateTickets
        '
        Me.ButtonAddCorporateTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddCorporateTickets.Location = New System.Drawing.Point(365, 98)
        Me.ButtonAddCorporateTickets.Name = "ButtonAddCorporateTickets"
        Me.ButtonAddCorporateTickets.Size = New System.Drawing.Size(219, 46)
        Me.ButtonAddCorporateTickets.TabIndex = 1
        Me.ButtonAddCorporateTickets.Text = "Corporate Season Tickets Entry"
        Me.ToolTipMainMenu.SetToolTip(Me.ButtonAddCorporateTickets, "Open corporate season ticket entry")
        Me.ButtonAddCorporateTickets.UseVisualStyleBackColor = True
        '
        'ButtonListCorporateSeasontickets
        '
        Me.ButtonListCorporateSeasontickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonListCorporateSeasontickets.Location = New System.Drawing.Point(364, 160)
        Me.ButtonListCorporateSeasontickets.Name = "ButtonListCorporateSeasontickets"
        Me.ButtonListCorporateSeasontickets.Size = New System.Drawing.Size(219, 39)
        Me.ButtonListCorporateSeasontickets.TabIndex = 2
        Me.ButtonListCorporateSeasontickets.Text = "Corporate Season Tickets List"
        Me.ToolTipMainMenu.SetToolTip(Me.ButtonListCorporateSeasontickets, "Open corporate season ticket list")
        Me.ButtonListCorporateSeasontickets.UseVisualStyleBackColor = True
        '
        'ButtonAddPrivateSeasonTickets
        '
        Me.ButtonAddPrivateSeasonTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddPrivateSeasonTickets.Location = New System.Drawing.Point(365, 220)
        Me.ButtonAddPrivateSeasonTickets.Name = "ButtonAddPrivateSeasonTickets"
        Me.ButtonAddPrivateSeasonTickets.Size = New System.Drawing.Size(218, 40)
        Me.ButtonAddPrivateSeasonTickets.TabIndex = 3
        Me.ButtonAddPrivateSeasonTickets.Text = "Private Season Tickets Entry"
        Me.ToolTipMainMenu.SetToolTip(Me.ButtonAddPrivateSeasonTickets, "Open private season ticket entry")
        Me.ButtonAddPrivateSeasonTickets.UseVisualStyleBackColor = True
        '
        'ButtonListPrivateSeasonTickets
        '
        Me.ButtonListPrivateSeasonTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonListPrivateSeasonTickets.Location = New System.Drawing.Point(365, 275)
        Me.ButtonListPrivateSeasonTickets.Name = "ButtonListPrivateSeasonTickets"
        Me.ButtonListPrivateSeasonTickets.Size = New System.Drawing.Size(218, 40)
        Me.ButtonListPrivateSeasonTickets.TabIndex = 4
        Me.ButtonListPrivateSeasonTickets.Text = "Private Season Tickets List"
        Me.ToolTipMainMenu.SetToolTip(Me.ButtonListPrivateSeasonTickets, "Open private season ticket list")
        Me.ButtonListPrivateSeasonTickets.UseVisualStyleBackColor = True
        '
        'ButtonHelpMainMenu
        '
        Me.ButtonHelpMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHelpMainMenu.Location = New System.Drawing.Point(799, 431)
        Me.ButtonHelpMainMenu.Name = "ButtonHelpMainMenu"
        Me.ButtonHelpMainMenu.Size = New System.Drawing.Size(75, 45)
        Me.ButtonHelpMainMenu.TabIndex = 5
        Me.ButtonHelpMainMenu.Text = "?"
        Me.ToolTipMainMenu.SetToolTip(Me.ButtonHelpMainMenu, "Open help form")
        Me.ButtonHelpMainMenu.UseVisualStyleBackColor = True
        '
        'ButtonCloseFormMainMenu
        '
        Me.ButtonCloseFormMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCloseFormMainMenu.Location = New System.Drawing.Point(799, 38)
        Me.ButtonCloseFormMainMenu.Name = "ButtonCloseFormMainMenu"
        Me.ButtonCloseFormMainMenu.Size = New System.Drawing.Size(75, 60)
        Me.ButtonCloseFormMainMenu.TabIndex = 6
        Me.ButtonCloseFormMainMenu.Text = "Close Form"
        Me.ToolTipMainMenu.SetToolTip(Me.ButtonCloseFormMainMenu, "This button will close the program")
        Me.ButtonCloseFormMainMenu.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(922, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CorporateSeasonTicketEntryToolStripMenuItem, Me.CorporateSeasonTicketListToolStripMenuItem, Me.PrivateSeasonTicketEntryToolStripMenuItem, Me.PrivateSeasonTicketListToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'CorporateSeasonTicketEntryToolStripMenuItem
        '
        Me.CorporateSeasonTicketEntryToolStripMenuItem.Name = "CorporateSeasonTicketEntryToolStripMenuItem"
        Me.CorporateSeasonTicketEntryToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.CorporateSeasonTicketEntryToolStripMenuItem.Text = "Corporate Season Ticket Entry"
        Me.CorporateSeasonTicketEntryToolStripMenuItem.ToolTipText = "Open corporate season ticket"
        '
        'CorporateSeasonTicketListToolStripMenuItem
        '
        Me.CorporateSeasonTicketListToolStripMenuItem.Name = "CorporateSeasonTicketListToolStripMenuItem"
        Me.CorporateSeasonTicketListToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.CorporateSeasonTicketListToolStripMenuItem.Text = "Corporate Season Ticket List"
        Me.CorporateSeasonTicketListToolStripMenuItem.ToolTipText = "Open corporate season list"
        '
        'PrivateSeasonTicketEntryToolStripMenuItem
        '
        Me.PrivateSeasonTicketEntryToolStripMenuItem.Name = "PrivateSeasonTicketEntryToolStripMenuItem"
        Me.PrivateSeasonTicketEntryToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.PrivateSeasonTicketEntryToolStripMenuItem.Text = "Private Season Ticket Entry"
        Me.PrivateSeasonTicketEntryToolStripMenuItem.ToolTipText = "Open private season ticket list"
        '
        'PrivateSeasonTicketListToolStripMenuItem
        '
        Me.PrivateSeasonTicketListToolStripMenuItem.Name = "PrivateSeasonTicketListToolStripMenuItem"
        Me.PrivateSeasonTicketListToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.PrivateSeasonTicketListToolStripMenuItem.Text = "Private Season Ticket List"
        Me.PrivateSeasonTicketListToolStripMenuItem.ToolTipText = "Open private season ticket list"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenHelpFormToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'OpenHelpFormToolStripMenuItem
        '
        Me.OpenHelpFormToolStripMenuItem.Name = "OpenHelpFormToolStripMenuItem"
        Me.OpenHelpFormToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.OpenHelpFormToolStripMenuItem.Text = "Open Help Form"
        Me.OpenHelpFormToolStripMenuItem.ToolTipText = "Open the help form"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitProgramToolStripMenuItem})
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ExitProgramToolStripMenuItem
        '
        Me.ExitProgramToolStripMenuItem.Name = "ExitProgramToolStripMenuItem"
        Me.ExitProgramToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ExitProgramToolStripMenuItem.Text = "Exit Program"
        Me.ExitProgramToolStripMenuItem.ToolTipText = "Exit the program"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'FormMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 504)
        Me.Controls.Add(Me.ButtonCloseFormMainMenu)
        Me.Controls.Add(Me.ButtonHelpMainMenu)
        Me.Controls.Add(Me.ButtonListPrivateSeasonTickets)
        Me.Controls.Add(Me.ButtonAddPrivateSeasonTickets)
        Me.Controls.Add(Me.ButtonListCorporateSeasontickets)
        Me.Controls.Add(Me.ButtonAddCorporateTickets)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMainMenu"
        Me.Text = "Main Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonAddCorporateTickets As Button
    Friend WithEvents ButtonListCorporateSeasontickets As Button
    Friend WithEvents ButtonAddPrivateSeasonTickets As Button
    Friend WithEvents ButtonListPrivateSeasonTickets As Button
    Friend WithEvents ButtonHelpMainMenu As Button
    Friend WithEvents ButtonCloseFormMainMenu As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CorporateSeasonTicketEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CorporateSeasonTicketListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrivateSeasonTicketEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrivateSeasonTicketListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenHelpFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolTipMainMenu As ToolTip
End Class
