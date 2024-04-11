<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWarehouses
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
        Me.components = New System.ComponentModel.Container()
        Me.dgvWarehouses = New System.Windows.Forms.DataGridView()
        Me.wrhs_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wrhs_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wrhs_idx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wrhs_department_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wrhs_description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wrhs_resp_employee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DodajToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdytujToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UsuńToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvWarehouses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvWarehouses
        '
        Me.dgvWarehouses.AllowUserToAddRows = False
        Me.dgvWarehouses.AllowUserToDeleteRows = False
        Me.dgvWarehouses.AllowUserToResizeColumns = False
        Me.dgvWarehouses.AllowUserToResizeRows = False
        Me.dgvWarehouses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvWarehouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWarehouses.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.wrhs_id, Me.wrhs_name, Me.wrhs_idx, Me.wrhs_department_id, Me.wrhs_description, Me.wrhs_resp_employee})
        Me.dgvWarehouses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvWarehouses.Location = New System.Drawing.Point(0, 47)
        Me.dgvWarehouses.MultiSelect = False
        Me.dgvWarehouses.Name = "dgvWarehouses"
        Me.dgvWarehouses.ReadOnly = True
        Me.dgvWarehouses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvWarehouses.Size = New System.Drawing.Size(804, 414)
        Me.dgvWarehouses.TabIndex = 0
        '
        'wrhs_id
        '
        Me.wrhs_id.DataPropertyName = "id"
        Me.wrhs_id.HeaderText = "ID"
        Me.wrhs_id.Name = "wrhs_id"
        Me.wrhs_id.ReadOnly = True
        Me.wrhs_id.Width = 43
        '
        'wrhs_name
        '
        Me.wrhs_name.DataPropertyName = "name"
        Me.wrhs_name.HeaderText = "Nazwa"
        Me.wrhs_name.Name = "wrhs_name"
        Me.wrhs_name.ReadOnly = True
        Me.wrhs_name.Width = 65
        '
        'wrhs_idx
        '
        Me.wrhs_idx.DataPropertyName = "idx"
        Me.wrhs_idx.HeaderText = "IDX"
        Me.wrhs_idx.Name = "wrhs_idx"
        Me.wrhs_idx.ReadOnly = True
        Me.wrhs_idx.Width = 50
        '
        'wrhs_department_id
        '
        Me.wrhs_department_id.DataPropertyName = "department"
        Me.wrhs_department_id.HeaderText = "Wydział nadrzędny"
        Me.wrhs_department_id.Name = "wrhs_department_id"
        Me.wrhs_department_id.ReadOnly = True
        Me.wrhs_department_id.Width = 113
        '
        'wrhs_description
        '
        Me.wrhs_description.DataPropertyName = "description"
        Me.wrhs_description.HeaderText = "Opis"
        Me.wrhs_description.Name = "wrhs_description"
        Me.wrhs_description.ReadOnly = True
        Me.wrhs_description.Width = 53
        '
        'wrhs_resp_employee
        '
        Me.wrhs_resp_employee.DataPropertyName = "resp_employee"
        Me.wrhs_resp_employee.HeaderText = "Pracownik odpowiedzialny"
        Me.wrhs_resp_employee.Name = "wrhs_resp_employee"
        Me.wrhs_resp_employee.ReadOnly = True
        Me.wrhs_resp_employee.Width = 143
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(804, 47)
        Me.Panel1.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Dodaj"
        Me.btnAdd.UseVisualStyleBackColor = True
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
        'frmWarehouses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 461)
        Me.Controls.Add(Me.dgvWarehouses)
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(820, 500)
        Me.Name = "frmWarehouses"
        Me.Text = "frmWarehouses"
        CType(Me.dgvWarehouses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvWarehouses As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DodajToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdytujToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents UsuńToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents wrhs_id As DataGridViewTextBoxColumn
    Friend WithEvents wrhs_name As DataGridViewTextBoxColumn
    Friend WithEvents wrhs_idx As DataGridViewTextBoxColumn
    Friend WithEvents wrhs_department_id As DataGridViewTextBoxColumn
    Friend WithEvents wrhs_description As DataGridViewTextBoxColumn
    Friend WithEvents wrhs_resp_employee As DataGridViewTextBoxColumn
End Class
