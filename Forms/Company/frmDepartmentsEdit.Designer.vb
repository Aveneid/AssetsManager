<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDepartmentsEdit
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
        Me.cbDepartments = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbDeptName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbDeptLocation = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbDeptDescription = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnEditSave = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbDeptIdx = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cbDepartments
        '
        Me.cbDepartments.DisplayMember = "key"
        Me.cbDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDepartments.FormattingEnabled = True
        Me.cbDepartments.Location = New System.Drawing.Point(104, 25)
        Me.cbDepartments.Name = "cbDepartments"
        Me.cbDepartments.Size = New System.Drawing.Size(239, 21)
        Me.cbDepartments.TabIndex = 0
        Me.cbDepartments.ValueMember = "value"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Wydział"
        '
        'tbDeptName
        '
        Me.tbDeptName.Enabled = False
        Me.tbDeptName.Location = New System.Drawing.Point(104, 69)
        Me.tbDeptName.MaxLength = 30
        Me.tbDeptName.Name = "tbDeptName"
        Me.tbDeptName.Size = New System.Drawing.Size(239, 20)
        Me.tbDeptName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nazwa wydziału"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Lokalizacja"
        '
        'tbDeptLocation
        '
        Me.tbDeptLocation.Enabled = False
        Me.tbDeptLocation.Location = New System.Drawing.Point(104, 121)
        Me.tbDeptLocation.MaxLength = 50
        Me.tbDeptLocation.Name = "tbDeptLocation"
        Me.tbDeptLocation.Size = New System.Drawing.Size(239, 20)
        Me.tbDeptLocation.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Opis"
        '
        'tbDeptDescription
        '
        Me.tbDeptDescription.Enabled = False
        Me.tbDeptDescription.Location = New System.Drawing.Point(104, 147)
        Me.tbDeptDescription.MaxLength = 150
        Me.tbDeptDescription.Multiline = True
        Me.tbDeptDescription.Name = "tbDeptDescription"
        Me.tbDeptDescription.Size = New System.Drawing.Size(239, 84)
        Me.tbDeptDescription.TabIndex = 5
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(379, 284)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Zamknij"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnEditSave
        '
        Me.btnEditSave.Location = New System.Drawing.Point(379, 23)
        Me.btnEditSave.Name = "btnEditSave"
        Me.btnEditSave.Size = New System.Drawing.Size(75, 23)
        Me.btnEditSave.TabIndex = 1
        Me.btnEditSave.Text = "Edytuj"
        Me.btnEditSave.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Indeks"
        '
        'tbDeptIdx
        '
        Me.tbDeptIdx.Enabled = False
        Me.tbDeptIdx.Location = New System.Drawing.Point(104, 95)
        Me.tbDeptIdx.MaxLength = 5
        Me.tbDeptIdx.Name = "tbDeptIdx"
        Me.tbDeptIdx.Size = New System.Drawing.Size(239, 20)
        Me.tbDeptIdx.TabIndex = 3
        '
        'frmDepartmentsEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 331)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbDeptIdx)
        Me.Controls.Add(Me.btnEditSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbDeptDescription)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbDeptLocation)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbDeptName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbDepartments)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDepartmentsEdit"
        Me.Text = "Wydziały"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbDepartments As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbDeptName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbDeptLocation As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbDeptDescription As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnEditSave As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents tbDeptIdx As TextBox
End Class
