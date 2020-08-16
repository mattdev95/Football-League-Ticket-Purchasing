<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHelpScreen
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
        Me.WebBrowserHelpForm = New System.Windows.Forms.WebBrowser()
        Me.ButtonCloseFormHelp = New System.Windows.Forms.Button()
        Me.ToolTipHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'WebBrowserHelpForm
        '
        Me.WebBrowserHelpForm.Location = New System.Drawing.Point(34, 12)
        Me.WebBrowserHelpForm.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserHelpForm.Name = "WebBrowserHelpForm"
        Me.WebBrowserHelpForm.Size = New System.Drawing.Size(1038, 480)
        Me.WebBrowserHelpForm.TabIndex = 0
        '
        'ButtonCloseFormHelp
        '
        Me.ButtonCloseFormHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCloseFormHelp.Location = New System.Drawing.Point(48, 529)
        Me.ButtonCloseFormHelp.Name = "ButtonCloseFormHelp"
        Me.ButtonCloseFormHelp.Size = New System.Drawing.Size(75, 47)
        Me.ButtonCloseFormHelp.TabIndex = 1
        Me.ButtonCloseFormHelp.Text = "Close Form"
        Me.ToolTipHelp.SetToolTip(Me.ButtonCloseFormHelp, "Close the form")
        Me.ButtonCloseFormHelp.UseVisualStyleBackColor = True
        '
        'FormHelpScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1110, 630)
        Me.Controls.Add(Me.ButtonCloseFormHelp)
        Me.Controls.Add(Me.WebBrowserHelpForm)
        Me.Name = "FormHelpScreen"
        Me.Text = "FormHelpScreen"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WebBrowserHelpForm As WebBrowser
    Friend WithEvents ButtonCloseFormHelp As Button
    Friend WithEvents ToolTipHelp As ToolTip
End Class
