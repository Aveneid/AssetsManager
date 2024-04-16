<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMachines
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
        Me.dgvMachines = New System.Windows.Forms.DataGridView()
        Me.mach_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mach_picture = New System.Windows.Forms.DataGridViewImageColumn()
        Me.mach_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mach_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mach_model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mach_manufacturer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mach_department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mach_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mach_resp_employee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DodajToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdytujToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UsuńToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvMachines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvMachines
        '
        Me.dgvMachines.AllowUserToAddRows = False
        Me.dgvMachines.AllowUserToDeleteRows = False
        Me.dgvMachines.AllowUserToResizeColumns = False
        Me.dgvMachines.AllowUserToResizeRows = False
        Me.dgvMachines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMachines.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.mach_id, Me.mach_picture, Me.mach_name, Me.mach_type, Me.mach_model, Me.mach_manufacturer, Me.mach_department, Me.mach_status, Me.mach_resp_employee})
        Me.dgvMachines.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMachines.Location = New System.Drawing.Point(0, 47)
        Me.dgvMachines.MultiSelect = False
        Me.dgvMachines.Name = "dgvMachines"
        Me.dgvMachines.ReadOnly = True
        Me.dgvMachines.RowTemplate.Height = 80
        Me.dgvMachines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMachines.Size = New System.Drawing.Size(800, 403)
        Me.dgvMachines.TabIndex = 2
        '
        'mach_id
        '
        Me.mach_id.DataPropertyName = "id"
        Me.mach_id.HeaderText = "ID"
        Me.mach_id.Name = "mach_id"
        Me.mach_id.ReadOnly = True
        Me.mach_id.Visible = False
        Me.mach_id.Width = 43
        '
        'mach_picture
        '
        Me.mach_picture.DataPropertyName = "picture"
        Me.mach_picture.FillWeight = 150.0!
        Me.mach_picture.HeaderText = "Zdjęcie"
        Me.mach_picture.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.mach_picture.Name = "mach_picture"
        Me.mach_picture.ReadOnly = True
        Me.mach_picture.Width = 48
        '
        'mach_name
        '
        Me.mach_name.DataPropertyName = "mach_name"
        Me.mach_name.HeaderText = "Nazwa"
        Me.mach_name.Name = "mach_name"
        Me.mach_name.ReadOnly = True
        Me.mach_name.Width = 65
        '
        'mach_type
        '
        Me.mach_type.DataPropertyName = "type"
        Me.mach_type.HeaderText = "Typ"
        Me.mach_type.Name = "mach_type"
        Me.mach_type.ReadOnly = True
        Me.mach_type.Width = 50
        '
        'mach_model
        '
        Me.mach_model.DataPropertyName = "model"
        Me.mach_model.HeaderText = "Model"
        Me.mach_model.Name = "mach_model"
        Me.mach_model.ReadOnly = True
        Me.mach_model.Width = 61
        '
        'mach_manufacturer
        '
        Me.mach_manufacturer.DataPropertyName = "manufacturer"
        Me.mach_manufacturer.HeaderText = "Producent"
        Me.mach_manufacturer.Name = "mach_manufacturer"
        Me.mach_manufacturer.ReadOnly = True
        Me.mach_manufacturer.Width = 81
        '
        'mach_department
        '
        Me.mach_department.DataPropertyName = "department"
        Me.mach_department.HeaderText = "Wydział"
        Me.mach_department.Name = "mach_department"
        Me.mach_department.ReadOnly = True
        Me.mach_department.Width = 71
        '
        'mach_status
        '
        Me.mach_status.DataPropertyName = "status"
        Me.mach_status.HeaderText = "Status"
        Me.mach_status.Name = "mach_status"
        Me.mach_status.ReadOnly = True
        Me.mach_status.Width = 62
        '
        'mach_resp_employee
        '
        Me.mach_resp_employee.DataPropertyName = "resp_employee"
        Me.mach_resp_employee.HeaderText = "Pracownik odpowiedzialny"
        Me.mach_resp_employee.Name = "mach_resp_employee"
        Me.mach_resp_employee.ReadOnly = True
        Me.mach_resp_employee.Width = 143
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 47)
        Me.Panel1.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Dodaj"
        Me.btnAdd.UseVisualStyleBackColor = True
        Me.btnAdd.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DodajToolStripMenuItem, Me.EdytujToolStripMenuItem, Me.ToolStripSeparator1, Me.UsuńToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 76)
        '
        'DodajToolStripMenuItem
        '
        Me.DodajToolStripMenuItem.Name = "DodajToolStripMenuItem"
        Me.DodajToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DodajToolStripMenuItem.Text = "Dodaj"
        '
        'EdytujToolStripMenuItem
        '
        Me.EdytujToolStripMenuItem.Name = "EdytujToolStripMenuItem"
        Me.EdytujToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.EdytujToolStripMenuItem.Text = "Edytuj"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(104, 6)
        '
        'UsuńToolStripMenuItem
        '
        Me.UsuńToolStripMenuItem.Name = "UsuńToolStripMenuItem"
        Me.UsuńToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.UsuńToolStripMenuItem.Text = "Usuń"
        '
        'frmMachines
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvMachines)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Name = "frmMachines"
        Me.Text = "frmMachines"
        CType(Me.dgvMachines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvMachines As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DodajToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdytujToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents UsuńToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mach_id As DataGridViewTextBoxColumn
    Friend WithEvents mach_picture As DataGridViewImageColumn
    Friend WithEvents mach_name As DataGridViewTextBoxColumn
    Friend WithEvents mach_type As DataGridViewTextBoxColumn
    Friend WithEvents mach_model As DataGridViewTextBoxColumn
    Friend WithEvents mach_manufacturer As DataGridViewTextBoxColumn
    Friend WithEvents mach_department As DataGridViewTextBoxColumn
    Friend WithEvents mach_status As DataGridViewTextBoxColumn
    Friend WithEvents mach_resp_employee As DataGridViewTextBoxColumn
End Class
