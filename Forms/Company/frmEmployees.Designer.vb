<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployees
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
        Me.dgvEmployees = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DodajToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdytujToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UsuńToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.emp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_position = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_access_lv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvEmployees
        '
        Me.dgvEmployees.AllowUserToAddRows = False
        Me.dgvEmployees.AllowUserToDeleteRows = False
        Me.dgvEmployees.AllowUserToResizeColumns = False
        Me.dgvEmployees.AllowUserToResizeRows = False
        Me.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.emp_id, Me.emp_name, Me.emp_position, Me.emp_phone, Me.emp_access_lv})
        Me.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEmployees.Location = New System.Drawing.Point(0, 47)
        Me.dgvEmployees.MultiSelect = False
        Me.dgvEmployees.Name = "dgvEmployees"
        Me.dgvEmployees.ReadOnly = True
        Me.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmployees.Size = New System.Drawing.Size(804, 414)
        Me.dgvEmployees.TabIndex = 0
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
        'emp_id
        '
        Me.emp_id.DataPropertyName = "id"
        Me.emp_id.HeaderText = "ID"
        Me.emp_id.Name = "emp_id"
        Me.emp_id.ReadOnly = True
        Me.emp_id.Width = 43
        '
        'emp_name
        '
        Me.emp_name.DataPropertyName = "name"
        Me.emp_name.HeaderText = "Imię i nazwisko"
        Me.emp_name.Name = "emp_name"
        Me.emp_name.ReadOnly = True
        Me.emp_name.Width = 150
        '
        'emp_position
        '
        Me.emp_position.DataPropertyName = "position"
        Me.emp_position.FillWeight = 300.0!
        Me.emp_position.HeaderText = "Stanowisko"
        Me.emp_position.Name = "emp_position"
        Me.emp_position.ReadOnly = True
        Me.emp_position.Width = 250
        '
        'emp_phone
        '
        Me.emp_phone.DataPropertyName = "phone"
        Me.emp_phone.HeaderText = "Telefon"
        Me.emp_phone.Name = "emp_phone"
        Me.emp_phone.ReadOnly = True
        Me.emp_phone.Width = 68
        '
        'emp_access_lv
        '
        Me.emp_access_lv.DataPropertyName = "access_lv"
        Me.emp_access_lv.HeaderText = "Poziom dostępu"
        Me.emp_access_lv.Name = "emp_access_lv"
        Me.emp_access_lv.ReadOnly = True
        Me.emp_access_lv.Width = 98
        '
        'frmEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 461)
        Me.Controls.Add(Me.dgvEmployees)
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(820, 500)
        Me.Name = "frmEmployees"
        Me.Text = "frmEmployees"
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvEmployees As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DodajToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdytujToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents UsuńToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents emp_id As DataGridViewTextBoxColumn
    Friend WithEvents emp_name As DataGridViewTextBoxColumn
    Friend WithEvents emp_position As DataGridViewTextBoxColumn
    Friend WithEvents emp_phone As DataGridViewTextBoxColumn
    Friend WithEvents emp_access_lv As DataGridViewTextBoxColumn
End Class
