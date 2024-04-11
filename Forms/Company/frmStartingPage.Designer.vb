<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStartingPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.wbStartingPage = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'wbStartingPage
        '
        Me.wbStartingPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbStartingPage.Location = New System.Drawing.Point(0, 0)
        Me.wbStartingPage.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbStartingPage.Name = "wbStartingPage"
        Me.wbStartingPage.Size = New System.Drawing.Size(800, 450)
        Me.wbStartingPage.TabIndex = 1
        Me.wbStartingPage.Url = New System.Uri("about:blank", System.UriKind.Absolute)
        '
        'frmStartingPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.wbStartingPage)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmStartingPage"
        Me.Text = "frmStartingPage"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents wbStartingPage As WebBrowser
End Class
