<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FindEmployeeRelations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FindEmployeeRelations))
        Me.wbEmployeeRelations = New System.Windows.Forms.WebBrowser()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'wbEmployeeRelations
        '
        Me.wbEmployeeRelations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbEmployeeRelations.Location = New System.Drawing.Point(0, 25)
        Me.wbEmployeeRelations.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbEmployeeRelations.Name = "wbEmployeeRelations"
        Me.wbEmployeeRelations.Size = New System.Drawing.Size(784, 401)
        Me.wbEmployeeRelations.TabIndex = 2
        Me.wbEmployeeRelations.Url = New System.Uri("about:blank", System.UriKind.Absolute)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(784, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'FindEmployeeRelations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 426)
        Me.Controls.Add(Me.wbEmployeeRelations)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FindEmployeeRelations"
        Me.Text = "FindEmployeeRelations"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents wbEmployeeRelations As WebBrowser
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
