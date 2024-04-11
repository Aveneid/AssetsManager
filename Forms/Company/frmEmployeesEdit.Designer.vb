<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmployeesEdit
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
        Me.cbEmployees = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbEmpName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbEmpPhone = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnEditSave = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbEmpPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbEmpAccessLevel = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnPasswordChange = New System.Windows.Forms.CheckBox()
        Me.tbEmpUsername = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbEmpAccessLv = New System.Windows.Forms.TextBox()
        Me.tbEmpId = New System.Windows.Forms.TextBox()
        Me.tbEmpPassword2 = New System.Windows.Forms.TextBox()
        Me.cbEmpPosition = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cbEmployees
        '
        Me.cbEmployees.DisplayMember = "key"
        Me.cbEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmployees.Enabled = False
        Me.cbEmployees.FormattingEnabled = True
        Me.cbEmployees.Location = New System.Drawing.Point(104, 25)
        Me.cbEmployees.Name = "cbEmployees"
        Me.cbEmployees.Size = New System.Drawing.Size(239, 21)
        Me.cbEmployees.TabIndex = 0
        Me.cbEmployees.ValueMember = "value"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pracownik"
        '
        'tbEmpName
        '
        Me.tbEmpName.Enabled = False
        Me.tbEmpName.Location = New System.Drawing.Point(104, 69)
        Me.tbEmpName.MaxLength = 30
        Me.tbEmpName.Name = "tbEmpName"
        Me.tbEmpName.Size = New System.Drawing.Size(239, 20)
        Me.tbEmpName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Imię i nazwisko"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Stanowisko"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Telefon"
        '
        'tbEmpPhone
        '
        Me.tbEmpPhone.Enabled = False
        Me.tbEmpPhone.Location = New System.Drawing.Point(104, 147)
        Me.tbEmpPhone.MaxLength = 150
        Me.tbEmpPhone.Name = "tbEmpPhone"
        Me.tbEmpPhone.Size = New System.Drawing.Size(239, 20)
        Me.tbEmpPhone.TabIndex = 5
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(377, 284)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Zamknij"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnEditSave
        '
        Me.btnEditSave.Enabled = False
        Me.btnEditSave.Location = New System.Drawing.Point(377, 23)
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
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Hasło"
        '
        'tbEmpPassword
        '
        Me.tbEmpPassword.Enabled = False
        Me.tbEmpPassword.Location = New System.Drawing.Point(104, 95)
        Me.tbEmpPassword.MaxLength = 16
        Me.tbEmpPassword.Name = "tbEmpPassword"
        Me.tbEmpPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbEmpPassword.Size = New System.Drawing.Size(239, 20)
        Me.tbEmpPassword.TabIndex = 3
        Me.tbEmpPassword.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Poziom dostępu"
        '
        'cbEmpAccessLevel
        '
        Me.cbEmpAccessLevel.DisplayMember = "key"
        Me.cbEmpAccessLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpAccessLevel.Enabled = False
        Me.cbEmpAccessLevel.FormattingEnabled = True
        Me.cbEmpAccessLevel.Location = New System.Drawing.Point(104, 173)
        Me.cbEmpAccessLevel.Name = "cbEmpAccessLevel"
        Me.cbEmpAccessLevel.Size = New System.Drawing.Size(239, 21)
        Me.cbEmpAccessLevel.TabIndex = 6
        Me.cbEmpAccessLevel.ValueMember = "value"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Powtórz hasło"
        Me.Label7.Visible = False
        '
        'btnPasswordChange
        '
        Me.btnPasswordChange.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnPasswordChange.AutoSize = True
        Me.btnPasswordChange.Enabled = False
        Me.btnPasswordChange.Location = New System.Drawing.Point(376, 93)
        Me.btnPasswordChange.Name = "btnPasswordChange"
        Me.btnPasswordChange.Size = New System.Drawing.Size(76, 23)
        Me.btnPasswordChange.TabIndex = 19
        Me.btnPasswordChange.Text = "Zmień hasło"
        Me.btnPasswordChange.UseVisualStyleBackColor = True
        '
        'tbEmpUsername
        '
        Me.tbEmpUsername.Enabled = False
        Me.tbEmpUsername.Location = New System.Drawing.Point(104, 200)
        Me.tbEmpUsername.MaxLength = 16
        Me.tbEmpUsername.Name = "tbEmpUsername"
        Me.tbEmpUsername.Size = New System.Drawing.Size(239, 20)
        Me.tbEmpUsername.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Login"
        '
        'tbEmpAccessLv
        '
        Me.tbEmpAccessLv.Location = New System.Drawing.Point(12, 299)
        Me.tbEmpAccessLv.Name = "tbEmpAccessLv"
        Me.tbEmpAccessLv.Size = New System.Drawing.Size(100, 20)
        Me.tbEmpAccessLv.TabIndex = 22
        Me.tbEmpAccessLv.Text = "tbEmpAccessLv"
        Me.tbEmpAccessLv.Visible = False
        '
        'tbEmpId
        '
        Me.tbEmpId.Location = New System.Drawing.Point(118, 299)
        Me.tbEmpId.Name = "tbEmpId"
        Me.tbEmpId.Size = New System.Drawing.Size(100, 20)
        Me.tbEmpId.TabIndex = 23
        Me.tbEmpId.Text = "tbEmpId"
        Me.tbEmpId.Visible = False
        '
        'tbEmpPassword2
        '
        Me.tbEmpPassword2.Enabled = False
        Me.tbEmpPassword2.Location = New System.Drawing.Point(104, 121)
        Me.tbEmpPassword2.MaxLength = 16
        Me.tbEmpPassword2.Name = "tbEmpPassword2"
        Me.tbEmpPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbEmpPassword2.Size = New System.Drawing.Size(207, 20)
        Me.tbEmpPassword2.TabIndex = 17
        Me.tbEmpPassword2.UseSystemPasswordChar = True
        Me.tbEmpPassword2.Visible = False
        '
        'cbEmpPosition
        '
        Me.cbEmpPosition.DisplayMember = "key"
        Me.cbEmpPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpPosition.Enabled = False
        Me.cbEmpPosition.FormattingEnabled = True
        Me.cbEmpPosition.Location = New System.Drawing.Point(104, 120)
        Me.cbEmpPosition.Name = "cbEmpPosition"
        Me.cbEmpPosition.Size = New System.Drawing.Size(239, 21)
        Me.cbEmpPosition.TabIndex = 24
        Me.cbEmpPosition.ValueMember = "value"
        '
        'frmEmployeesEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 331)
        Me.Controls.Add(Me.tbEmpId)
        Me.Controls.Add(Me.tbEmpAccessLv)
        Me.Controls.Add(Me.tbEmpUsername)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnPasswordChange)
        Me.Controls.Add(Me.tbEmpPassword2)
        Me.Controls.Add(Me.cbEmpAccessLevel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbEmpPassword)
        Me.Controls.Add(Me.btnEditSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbEmpPhone)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbEmpName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbEmployees)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbEmpPosition)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmployeesEdit"
        Me.Text = "Pracownik"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbEmployees As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbEmpName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbEmpPhone As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnEditSave As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents tbEmpPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbEmpAccessLevel As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnPasswordChange As CheckBox
    Friend WithEvents tbEmpUsername As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbEmpAccessLv As TextBox
    Friend WithEvents tbEmpId As TextBox
    Friend WithEvents tbEmpPassword2 As TextBox
    Friend WithEvents cbEmpPosition As ComboBox
End Class
