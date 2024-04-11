<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartments
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
        Me.dgvDepartments = New System.Windows.Forms.DataGridView()
        Me.dept_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dept_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dept_idx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dept_location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dept_description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DodajToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdytujToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UsuńToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvDepartments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDepartments
        '
        Me.dgvDepartments.AllowUserToAddRows = False
        Me.dgvDepartments.AllowUserToDeleteRows = False
        Me.dgvDepartments.AllowUserToResizeColumns = False
        Me.dgvDepartments.AllowUserToResizeRows = False
        Me.dgvDepartments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDepartments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dept_id, Me.dept_name, Me.dept_idx, Me.dept_location, Me.dept_description})
        Me.dgvDepartments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDepartments.Location = New System.Drawing.Point(0, 47)
        Me.dgvDepartments.MultiSelect = False
        Me.dgvDepartments.Name = "dgvDepartments"
        Me.dgvDepartments.ReadOnly = True
        Me.dgvDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDepartments.Size = New System.Drawing.Size(804, 414)
        Me.dgvDepartments.TabIndex = 0
        '
        'dept_id
        '
        Me.dept_id.DataPropertyName = "id"
        Me.dept_id.HeaderText = "ID"
        Me.dept_id.Name = "dept_id"
        Me.dept_id.ReadOnly = True
        Me.dept_id.Width = 43
        '
        'dept_name
        '
        Me.dept_name.DataPropertyName = "name"
        Me.dept_name.HeaderText = "Nazwa"
        Me.dept_name.Name = "dept_name"
        Me.dept_name.ReadOnly = True
        Me.dept_name.Width = 65
        '
        'dept_idx
        '
        Me.dept_idx.DataPropertyName = "idx"
        Me.dept_idx.HeaderText = "IDX"
        Me.dept_idx.Name = "dept_idx"
        Me.dept_idx.ReadOnly = True
        Me.dept_idx.Width = 50
        '
        'dept_location
        '
        Me.dept_location.DataPropertyName = "location"
        Me.dept_location.HeaderText = "Lokalizacja"
        Me.dept_location.Name = "dept_location"
        Me.dept_location.ReadOnly = True
        Me.dept_location.Width = 85
        '
        'dept_description
        '
        Me.dept_description.DataPropertyName = "description"
        Me.dept_description.HeaderText = "Opis"
        Me.dept_description.Name = "dept_description"
        Me.dept_description.ReadOnly = True
        Me.dept_description.Width = 53
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
        'frmDepartments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 461)
        Me.Controls.Add(Me.dgvDepartments)
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(820, 500)
        Me.Name = "frmDepartments"
        Me.Text = "frmDepartments"
        CType(Me.dgvDepartments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvDepartments As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents dept_id As DataGridViewTextBoxColumn
    Friend WithEvents dept_name As DataGridViewTextBoxColumn
    Friend WithEvents dept_idx As DataGridViewTextBoxColumn
    Friend WithEvents dept_location As DataGridViewTextBoxColumn
    Friend WithEvents dept_description As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DodajToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdytujToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents UsuńToolStripMenuItem As ToolStripMenuItem
End Class
