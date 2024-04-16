<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWarehousesEdit
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbWrhsIdx = New System.Windows.Forms.TextBox()
        Me.btnEditSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbWrhsDescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbWrhsName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbWrhsRespEmployee = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbWrhsDepartment = New System.Windows.Forms.ComboBox()
        Me.lbWarehouse = New System.Windows.Forms.Label()
        Me.wrhsID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Indeks"
        '
        'tbWrhsIdx
        '
        Me.tbWrhsIdx.Enabled = False
        Me.tbWrhsIdx.Location = New System.Drawing.Point(105, 95)
        Me.tbWrhsIdx.MaxLength = 5
        Me.tbWrhsIdx.Name = "tbWrhsIdx"
        Me.tbWrhsIdx.Size = New System.Drawing.Size(239, 20)
        Me.tbWrhsIdx.TabIndex = 3
        '
        'btnEditSave
        '
        Me.btnEditSave.Location = New System.Drawing.Point(380, 23)
        Me.btnEditSave.Name = "btnEditSave"
        Me.btnEditSave.Size = New System.Drawing.Size(75, 23)
        Me.btnEditSave.TabIndex = 1
        Me.btnEditSave.Text = "Edytuj"
        Me.btnEditSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(380, 284)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Zamknij"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Opis"
        '
        'tbWrhsDescription
        '
        Me.tbWrhsDescription.Enabled = False
        Me.tbWrhsDescription.Location = New System.Drawing.Point(105, 147)
        Me.tbWrhsDescription.MaxLength = 150
        Me.tbWrhsDescription.Multiline = True
        Me.tbWrhsDescription.Name = "tbWrhsDescription"
        Me.tbWrhsDescription.Size = New System.Drawing.Size(239, 84)
        Me.tbWrhsDescription.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Wydział"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nazwa magazynu"
        '
        'tbWrhsName
        '
        Me.tbWrhsName.Enabled = False
        Me.tbWrhsName.Location = New System.Drawing.Point(105, 69)
        Me.tbWrhsName.MaxLength = 30
        Me.tbWrhsName.Name = "tbWrhsName"
        Me.tbWrhsName.Size = New System.Drawing.Size(239, 20)
        Me.tbWrhsName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Magazyn"
        '
        'cbWrhsRespEmployee
        '
        Me.cbWrhsRespEmployee.DisplayMember = "Key"
        Me.cbWrhsRespEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbWrhsRespEmployee.Enabled = False
        Me.cbWrhsRespEmployee.FormattingEnabled = True
        Me.cbWrhsRespEmployee.Location = New System.Drawing.Point(105, 237)
        Me.cbWrhsRespEmployee.Name = "cbWrhsRespEmployee"
        Me.cbWrhsRespEmployee.Size = New System.Drawing.Size(239, 21)
        Me.cbWrhsRespEmployee.TabIndex = 6
        Me.cbWrhsRespEmployee.ValueMember = "Value"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 26)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Pracownik " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "odpowiedzialny"
        '
        'cbWrhsDepartment
        '
        Me.cbWrhsDepartment.DisplayMember = "Key"
        Me.cbWrhsDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbWrhsDepartment.Enabled = False
        Me.cbWrhsDepartment.FormattingEnabled = True
        Me.cbWrhsDepartment.Location = New System.Drawing.Point(105, 121)
        Me.cbWrhsDepartment.Name = "cbWrhsDepartment"
        Me.cbWrhsDepartment.Size = New System.Drawing.Size(239, 21)
        Me.cbWrhsDepartment.TabIndex = 4
        Me.cbWrhsDepartment.ValueMember = "Value"
        '
        'lbWarehouse
        '
        Me.lbWarehouse.AutoSize = True
        Me.lbWarehouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbWarehouse.Location = New System.Drawing.Point(91, 26)
        Me.lbWarehouse.Name = "lbWarehouse"
        Me.lbWarehouse.Size = New System.Drawing.Size(29, 20)
        Me.lbWarehouse.TabIndex = 28
        Me.lbWarehouse.Text = "     "
        '
        'wrhsID
        '
        Me.wrhsID.Enabled = False
        Me.wrhsID.Location = New System.Drawing.Point(12, 299)
        Me.wrhsID.MaxLength = 30
        Me.wrhsID.Name = "wrhsID"
        Me.wrhsID.Size = New System.Drawing.Size(48, 20)
        Me.wrhsID.TabIndex = 29
        Me.wrhsID.Text = "0"
        Me.wrhsID.Visible = False
        '
        'frmWarehousesEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 331)
        Me.Controls.Add(Me.wrhsID)
        Me.Controls.Add(Me.lbWarehouse)
        Me.Controls.Add(Me.cbWrhsDepartment)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbWrhsRespEmployee)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbWrhsIdx)
        Me.Controls.Add(Me.btnEditSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbWrhsDescription)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbWrhsName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmWarehousesEdit"
        Me.Text = "Magazyny"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents tbWrhsIdx As TextBox
    Friend WithEvents btnEditSave As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents tbWrhsDescription As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbWrhsName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbWrhsRespEmployee As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbWrhsDepartment As ComboBox
    Friend WithEvents lbWarehouse As Label
    Friend WithEvents wrhsID As TextBox
End Class
