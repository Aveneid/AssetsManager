<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPictureSelect
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
        Me.cbImageSelect = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbImageSelect
        '
        Me.cbImageSelect.DisplayMember = "Key"
        Me.cbImageSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbImageSelect.FormattingEnabled = True
        Me.cbImageSelect.Location = New System.Drawing.Point(64, 12)
        Me.cbImageSelect.Name = "cbImageSelect"
        Me.cbImageSelect.Size = New System.Drawing.Size(431, 21)
        Me.cbImageSelect.TabIndex = 0
        Me.cbImageSelect.ValueMember = "Value"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Obrazek"
        '
        'pbImage
        '
        Me.pbImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbImage.Location = New System.Drawing.Point(0, 55)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(507, 356)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImage.TabIndex = 2
        Me.pbImage.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbImageSelect)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(507, 55)
        Me.Panel1.TabIndex = 3
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(266, 6)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Usuń"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(12, 6)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnSelect.TabIndex = 3
        Me.btnSelect.Text = "Wybierz"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.btnSelect)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 411)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(507, 39)
        Me.Panel2.TabIndex = 4
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(420, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Zamknij"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(185, 6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Dodaj"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = """Images|*.jpg;*.png;*.jpeg"""
        Me.OpenFileDialog1.RestoreDirectory = True
        '
        'frmPictureSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 450)
        Me.Controls.Add(Me.pbImage)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmPictureSelect"
        Me.Text = "frmPictureSelect"
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbImageSelect As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pbImage As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSelect As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
