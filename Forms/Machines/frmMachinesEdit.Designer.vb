<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMachinesEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMachinesEdit))
        Me.cbMachineType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbMachineRespEmployee = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbMachineModel = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbMachineName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbMachineManufacturer = New System.Windows.Forms.ComboBox()
        Me.cbMachineDepartment = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grpImage = New System.Windows.Forms.GroupBox()
        Me.machine_picture = New System.Windows.Forms.PictureBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.grpParts = New System.Windows.Forms.GroupBox()
        Me.dgvMachineParts = New System.Windows.Forms.DataGridView()
        Me.part_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.part_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.part_specs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.part_catalog_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.part_producer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAddPart = New System.Windows.Forms.ToolStripButton()
        Me.btnDeletePart = New System.Windows.Forms.ToolStripButton()
        Me.lbMachineName = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAddType = New System.Windows.Forms.Button()
        Me.btnAddManufacturer = New System.Windows.Forms.Button()
        Me.btnAddDepartment = New System.Windows.Forms.Button()
        Me.btnAddEmployee = New System.Windows.Forms.Button()
        Me.grpImage.SuspendLayout()
        CType(Me.machine_picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.grpParts.SuspendLayout()
        CType(Me.dgvMachineParts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbMachineType
        '
        Me.cbMachineType.DisplayMember = "Key"
        Me.cbMachineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMachineType.Enabled = False
        Me.cbMachineType.FormattingEnabled = True
        Me.cbMachineType.Location = New System.Drawing.Point(105, 104)
        Me.cbMachineType.Name = "cbMachineType"
        Me.cbMachineType.Size = New System.Drawing.Size(314, 21)
        Me.cbMachineType.TabIndex = 2
        Me.cbMachineType.ValueMember = "Value"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 26)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Pracownik " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "odpowiedzialny"
        '
        'cbMachineRespEmployee
        '
        Me.cbMachineRespEmployee.DisplayMember = "Key"
        Me.cbMachineRespEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMachineRespEmployee.Enabled = False
        Me.cbMachineRespEmployee.FormattingEnabled = True
        Me.cbMachineRespEmployee.Location = New System.Drawing.Point(105, 193)
        Me.cbMachineRespEmployee.Name = "cbMachineRespEmployee"
        Me.cbMachineRespEmployee.Size = New System.Drawing.Size(314, 21)
        Me.cbMachineRespEmployee.TabIndex = 5
        Me.cbMachineRespEmployee.ValueMember = "Value"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Model"
        '
        'tbMachineModel
        '
        Me.tbMachineModel.Enabled = False
        Me.tbMachineModel.Location = New System.Drawing.Point(105, 78)
        Me.tbMachineModel.MaxLength = 5
        Me.tbMachineModel.Name = "tbMachineModel"
        Me.tbMachineModel.Size = New System.Drawing.Size(314, 20)
        Me.tbMachineModel.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(815, 523)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 23)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Zamknij"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Producent"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Typ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Nazwa maszyny"
        '
        'tbMachineName
        '
        Me.tbMachineName.Enabled = False
        Me.tbMachineName.Location = New System.Drawing.Point(105, 52)
        Me.tbMachineName.MaxLength = 30
        Me.tbMachineName.Name = "tbMachineName"
        Me.tbMachineName.Size = New System.Drawing.Size(314, 20)
        Me.tbMachineName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Maszyna"
        '
        'cbMachineManufacturer
        '
        Me.cbMachineManufacturer.DisplayMember = "Key"
        Me.cbMachineManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMachineManufacturer.Enabled = False
        Me.cbMachineManufacturer.FormattingEnabled = True
        Me.cbMachineManufacturer.Location = New System.Drawing.Point(105, 131)
        Me.cbMachineManufacturer.Name = "cbMachineManufacturer"
        Me.cbMachineManufacturer.Size = New System.Drawing.Size(314, 21)
        Me.cbMachineManufacturer.TabIndex = 3
        Me.cbMachineManufacturer.ValueMember = "Value"
        '
        'cbMachineDepartment
        '
        Me.cbMachineDepartment.DisplayMember = "Key"
        Me.cbMachineDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMachineDepartment.Enabled = False
        Me.cbMachineDepartment.FormattingEnabled = True
        Me.cbMachineDepartment.Location = New System.Drawing.Point(105, 158)
        Me.cbMachineDepartment.Name = "cbMachineDepartment"
        Me.cbMachineDepartment.Size = New System.Drawing.Size(314, 21)
        Me.cbMachineDepartment.TabIndex = 4
        Me.cbMachineDepartment.ValueMember = "Value"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Wydział"
        '
        'grpImage
        '
        Me.grpImage.Controls.Add(Me.machine_picture)
        Me.grpImage.Controls.Add(Me.ToolStrip2)
        Me.grpImage.Enabled = False
        Me.grpImage.Location = New System.Drawing.Point(457, 12)
        Me.grpImage.Name = "grpImage"
        Me.grpImage.Size = New System.Drawing.Size(446, 257)
        Me.grpImage.TabIndex = 45
        Me.grpImage.TabStop = False
        Me.grpImage.Text = "Zdjęcie"
        '
        'machine_picture
        '
        Me.machine_picture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.machine_picture.Location = New System.Drawing.Point(3, 41)
        Me.machine_picture.Name = "machine_picture"
        Me.machine_picture.Size = New System.Drawing.Size(440, 213)
        Me.machine_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.machine_picture.TabIndex = 0
        Me.machine_picture.TabStop = False
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(440, 25)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
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
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'grpParts
        '
        Me.grpParts.Controls.Add(Me.dgvMachineParts)
        Me.grpParts.Controls.Add(Me.ToolStrip1)
        Me.grpParts.Enabled = False
        Me.grpParts.Location = New System.Drawing.Point(17, 281)
        Me.grpParts.Name = "grpParts"
        Me.grpParts.Size = New System.Drawing.Size(631, 235)
        Me.grpParts.TabIndex = 46
        Me.grpParts.TabStop = False
        Me.grpParts.Text = "Części"
        '
        'dgvMachineParts
        '
        Me.dgvMachineParts.AllowUserToAddRows = False
        Me.dgvMachineParts.AllowUserToDeleteRows = False
        Me.dgvMachineParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMachineParts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.part_id, Me.part_name, Me.part_specs, Me.part_catalog_no, Me.part_producer})
        Me.dgvMachineParts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMachineParts.Location = New System.Drawing.Point(3, 41)
        Me.dgvMachineParts.Name = "dgvMachineParts"
        Me.dgvMachineParts.ReadOnly = True
        Me.dgvMachineParts.RowHeadersWidth = 15
        Me.dgvMachineParts.Size = New System.Drawing.Size(625, 191)
        Me.dgvMachineParts.TabIndex = 0
        '
        'part_id
        '
        Me.part_id.HeaderText = "part_id"
        Me.part_id.Name = "part_id"
        Me.part_id.ReadOnly = True
        Me.part_id.Visible = False
        '
        'part_name
        '
        Me.part_name.HeaderText = "Nazwa"
        Me.part_name.Name = "part_name"
        Me.part_name.ReadOnly = True
        '
        'part_specs
        '
        Me.part_specs.HeaderText = "Specyfikacja"
        Me.part_specs.Name = "part_specs"
        Me.part_specs.ReadOnly = True
        '
        'part_catalog_no
        '
        Me.part_catalog_no.HeaderText = "Numer katalogowy"
        Me.part_catalog_no.Name = "part_catalog_no"
        Me.part_catalog_no.ReadOnly = True
        '
        'part_producer
        '
        Me.part_producer.HeaderText = "Producent"
        Me.part_producer.Name = "part_producer"
        Me.part_producer.ReadOnly = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAddPart, Me.btnDeletePart})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(625, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAddPart
        '
        Me.btnAddPart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAddPart.Image = CType(resources.GetObject("btnAddPart.Image"), System.Drawing.Image)
        Me.btnAddPart.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAddPart.Name = "btnAddPart"
        Me.btnAddPart.Size = New System.Drawing.Size(23, 22)
        Me.btnAddPart.Text = "ToolStripButton1"
        '
        'btnDeletePart
        '
        Me.btnDeletePart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDeletePart.Image = CType(resources.GetObject("btnDeletePart.Image"), System.Drawing.Image)
        Me.btnDeletePart.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDeletePart.Name = "btnDeletePart"
        Me.btnDeletePart.Size = New System.Drawing.Size(23, 22)
        Me.btnDeletePart.Text = "ToolStripButton2"
        '
        'lbMachineName
        '
        Me.lbMachineName.AutoSize = True
        Me.lbMachineName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbMachineName.Location = New System.Drawing.Point(101, 9)
        Me.lbMachineName.Name = "lbMachineName"
        Me.lbMachineName.Size = New System.Drawing.Size(61, 20)
        Me.lbMachineName.TabIndex = 48
        Me.lbMachineName.Text = " nowy..."
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(692, 523)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 23)
        Me.btnSave.TabIndex = 49
        Me.btnSave.Text = "Zapisz"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAddType
        '
        Me.btnAddType.Image = CType(resources.GetObject("btnAddType.Image"), System.Drawing.Image)
        Me.btnAddType.Location = New System.Drawing.Point(425, 104)
        Me.btnAddType.Name = "btnAddType"
        Me.btnAddType.Size = New System.Drawing.Size(21, 21)
        Me.btnAddType.TabIndex = 50
        Me.btnAddType.UseVisualStyleBackColor = True
        '
        'btnAddManufacturer
        '
        Me.btnAddManufacturer.Image = CType(resources.GetObject("btnAddManufacturer.Image"), System.Drawing.Image)
        Me.btnAddManufacturer.Location = New System.Drawing.Point(425, 131)
        Me.btnAddManufacturer.Name = "btnAddManufacturer"
        Me.btnAddManufacturer.Size = New System.Drawing.Size(21, 21)
        Me.btnAddManufacturer.TabIndex = 51
        Me.btnAddManufacturer.UseVisualStyleBackColor = True
        '
        'btnAddDepartment
        '
        Me.btnAddDepartment.Image = CType(resources.GetObject("btnAddDepartment.Image"), System.Drawing.Image)
        Me.btnAddDepartment.Location = New System.Drawing.Point(425, 158)
        Me.btnAddDepartment.Name = "btnAddDepartment"
        Me.btnAddDepartment.Size = New System.Drawing.Size(21, 21)
        Me.btnAddDepartment.TabIndex = 52
        Me.btnAddDepartment.UseVisualStyleBackColor = True
        '
        'btnAddEmployee
        '
        Me.btnAddEmployee.Image = CType(resources.GetObject("btnAddEmployee.Image"), System.Drawing.Image)
        Me.btnAddEmployee.Location = New System.Drawing.Point(425, 193)
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.Size = New System.Drawing.Size(21, 21)
        Me.btnAddEmployee.TabIndex = 53
        Me.btnAddEmployee.UseVisualStyleBackColor = True
        '
        'frmMachinesEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 558)
        Me.Controls.Add(Me.btnAddEmployee)
        Me.Controls.Add(Me.btnAddDepartment)
        Me.Controls.Add(Me.btnAddManufacturer)
        Me.Controls.Add(Me.btnAddType)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lbMachineName)
        Me.Controls.Add(Me.grpParts)
        Me.Controls.Add(Me.grpImage)
        Me.Controls.Add(Me.cbMachineDepartment)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbMachineManufacturer)
        Me.Controls.Add(Me.cbMachineType)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbMachineRespEmployee)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbMachineModel)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbMachineName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMachinesEdit"
        Me.Text = "frmMachinesEdit"
        Me.grpImage.ResumeLayout(False)
        Me.grpImage.PerformLayout()
        CType(Me.machine_picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.grpParts.ResumeLayout(False)
        Me.grpParts.PerformLayout()
        CType(Me.dgvMachineParts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbMachineType As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbMachineRespEmployee As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbMachineModel As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbMachineName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbMachineManufacturer As ComboBox
    Friend WithEvents cbMachineDepartment As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents grpImage As GroupBox
    Friend WithEvents machine_picture As PictureBox
    Friend WithEvents grpParts As GroupBox
    Friend WithEvents dgvMachineParts As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnAddPart As ToolStripButton
    Friend WithEvents btnDeletePart As ToolStripButton
    Friend WithEvents lbMachineName As Label
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents part_id As DataGridViewTextBoxColumn
    Friend WithEvents part_name As DataGridViewTextBoxColumn
    Friend WithEvents part_specs As DataGridViewTextBoxColumn
    Friend WithEvents part_catalog_no As DataGridViewTextBoxColumn
    Friend WithEvents part_producer As DataGridViewTextBoxColumn
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAddType As Button
    Friend WithEvents btnAddManufacturer As Button
    Friend WithEvents btnAddDepartment As Button
    Friend WithEvents btnAddEmployee As Button
End Class
