<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManufacturerAdd
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
        Me.tbManufacturerLocation = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbManufacturerPhone = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbManufacturerName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbManufacturerIDX = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Lokalizacja"
        '
        'tbManufacturerLocation
        '
        Me.tbManufacturerLocation.Location = New System.Drawing.Point(92, 89)
        Me.tbManufacturerLocation.MaxLength = 100
        Me.tbManufacturerLocation.Name = "tbManufacturerLocation"
        Me.tbManufacturerLocation.Size = New System.Drawing.Size(239, 20)
        Me.tbManufacturerLocation.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(256, 184)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Dodaj"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Indeks"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Telefon"
        '
        'tbManufacturerPhone
        '
        Me.tbManufacturerPhone.Location = New System.Drawing.Point(92, 115)
        Me.tbManufacturerPhone.MaxLength = 30
        Me.tbManufacturerPhone.Name = "tbManufacturerPhone"
        Me.tbManufacturerPhone.Size = New System.Drawing.Size(239, 20)
        Me.tbManufacturerPhone.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Nazwa"
        '
        'tbManufacturerName
        '
        Me.tbManufacturerName.Location = New System.Drawing.Point(92, 63)
        Me.tbManufacturerName.MaxLength = 50
        Me.tbManufacturerName.Name = "tbManufacturerName"
        Me.tbManufacturerName.Size = New System.Drawing.Size(239, 20)
        Me.tbManufacturerName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(11, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Producent"
        '
        'tbManufacturerIDX
        '
        Me.tbManufacturerIDX.Location = New System.Drawing.Point(92, 144)
        Me.tbManufacturerIDX.MaxLength = 5
        Me.tbManufacturerIDX.Name = "tbManufacturerIDX"
        Me.tbManufacturerIDX.Size = New System.Drawing.Size(239, 20)
        Me.tbManufacturerIDX.TabIndex = 3
        '
        'frmManufacturerAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 222)
        Me.Controls.Add(Me.tbManufacturerIDX)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbManufacturerLocation)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbManufacturerPhone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbManufacturerName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmManufacturerAdd"
        Me.Text = "frmManufacturerAdd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents tbManufacturerLocation As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbManufacturerPhone As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbManufacturerName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbManufacturerIDX As TextBox
End Class
