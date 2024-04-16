<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPartEdit
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
        Me.partID = New System.Windows.Forms.TextBox()
        Me.lbPart = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbPartSpecs = New System.Windows.Forms.TextBox()
        Me.btnEditSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbPartCatalogNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbPartName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbPartManufacturer = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'partID
        '
        Me.partID.Enabled = False
        Me.partID.Location = New System.Drawing.Point(15, 212)
        Me.partID.MaxLength = 30
        Me.partID.Name = "partID"
        Me.partID.Size = New System.Drawing.Size(29, 20)
        Me.partID.TabIndex = 28
        Me.partID.Text = "0"
        Me.partID.Visible = False
        '
        'lbPart
        '
        Me.lbPart.AutoSize = True
        Me.lbPart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbPart.Location = New System.Drawing.Point(143, 20)
        Me.lbPart.Name = "lbPart"
        Me.lbPart.Size = New System.Drawing.Size(29, 20)
        Me.lbPart.TabIndex = 27
        Me.lbPart.Text = "     "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Specyfikacja"
        '
        'tbPartSpecs
        '
        Me.tbPartSpecs.Location = New System.Drawing.Point(112, 89)
        Me.tbPartSpecs.MaxLength = 5
        Me.tbPartSpecs.Name = "tbPartSpecs"
        Me.tbPartSpecs.Size = New System.Drawing.Size(239, 20)
        Me.tbPartSpecs.TabIndex = 1
        '
        'btnEditSave
        '
        Me.btnEditSave.Location = New System.Drawing.Point(378, 17)
        Me.btnEditSave.Name = "btnEditSave"
        Me.btnEditSave.Size = New System.Drawing.Size(75, 23)
        Me.btnEditSave.TabIndex = 4
        Me.btnEditSave.Text = "Dodaj"
        Me.btnEditSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(378, 210)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Zamknij"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Producent"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Numer katalogowy"
        '
        'tbPartCatalogNo
        '
        Me.tbPartCatalogNo.Location = New System.Drawing.Point(113, 115)
        Me.tbPartCatalogNo.MaxLength = 50
        Me.tbPartCatalogNo.Name = "tbPartCatalogNo"
        Me.tbPartCatalogNo.Size = New System.Drawing.Size(239, 20)
        Me.tbPartCatalogNo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Nazwa części"
        '
        'tbPartName
        '
        Me.tbPartName.Location = New System.Drawing.Point(112, 63)
        Me.tbPartName.MaxLength = 30
        Me.tbPartName.Name = "tbPartName"
        Me.tbPartName.Size = New System.Drawing.Size(239, 20)
        Me.tbPartName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(11, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Część zamienna"
        '
        'cbPartManufacturer
        '
        Me.cbPartManufacturer.DisplayMember = "Key"
        Me.cbPartManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPartManufacturer.FormattingEnabled = True
        Me.cbPartManufacturer.Location = New System.Drawing.Point(112, 144)
        Me.cbPartManufacturer.Name = "cbPartManufacturer"
        Me.cbPartManufacturer.Size = New System.Drawing.Size(239, 21)
        Me.cbPartManufacturer.TabIndex = 3
        Me.cbPartManufacturer.ValueMember = "Value"
        '
        'frmPartEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 253)
        Me.Controls.Add(Me.cbPartManufacturer)
        Me.Controls.Add(Me.partID)
        Me.Controls.Add(Me.lbPart)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbPartSpecs)
        Me.Controls.Add(Me.btnEditSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbPartCatalogNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbPartName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPartEdit"
        Me.Text = "frmPartEdit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents partID As TextBox
    Friend WithEvents lbPart As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbPartSpecs As TextBox
    Friend WithEvents btnEditSave As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbPartCatalogNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbPartName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbPartManufacturer As ComboBox
End Class
