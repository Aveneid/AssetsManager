<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParts
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
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EdytujToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DodajToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UsuńToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvParts = New System.Windows.Forms.DataGridView()
        Me.part_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.part_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.part_specs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.part_catalog_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.part_manufacturer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvParts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(104, 6)
        '
        'EdytujToolStripMenuItem
        '
        Me.EdytujToolStripMenuItem.Name = "EdytujToolStripMenuItem"
        Me.EdytujToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.EdytujToolStripMenuItem.Text = "Edytuj"
        '
        'DodajToolStripMenuItem
        '
        Me.DodajToolStripMenuItem.Name = "DodajToolStripMenuItem"
        Me.DodajToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DodajToolStripMenuItem.Text = "Dodaj"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DodajToolStripMenuItem, Me.EdytujToolStripMenuItem, Me.ToolStripSeparator1, Me.UsuńToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 76)
        '
        'UsuńToolStripMenuItem
        '
        Me.UsuńToolStripMenuItem.Name = "UsuńToolStripMenuItem"
        Me.UsuńToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.UsuńToolStripMenuItem.Text = "Usuń"
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 47)
        Me.Panel1.TabIndex = 5
        '
        'dgvParts
        '
        Me.dgvParts.AllowUserToAddRows = False
        Me.dgvParts.AllowUserToDeleteRows = False
        Me.dgvParts.AllowUserToResizeColumns = False
        Me.dgvParts.AllowUserToResizeRows = False
        Me.dgvParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.part_id, Me.part_name, Me.part_specs, Me.part_catalog_no, Me.part_manufacturer})
        Me.dgvParts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvParts.Location = New System.Drawing.Point(0, 47)
        Me.dgvParts.MultiSelect = False
        Me.dgvParts.Name = "dgvParts"
        Me.dgvParts.ReadOnly = True
        Me.dgvParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvParts.Size = New System.Drawing.Size(800, 403)
        Me.dgvParts.TabIndex = 4
        '
        'part_id
        '
        Me.part_id.DataPropertyName = "id"
        Me.part_id.HeaderText = "ID"
        Me.part_id.Name = "part_id"
        Me.part_id.ReadOnly = True
        Me.part_id.Visible = False
        Me.part_id.Width = 43
        '
        'part_name
        '
        Me.part_name.HeaderText = "Nazwa"
        Me.part_name.Name = "part_name"
        Me.part_name.ReadOnly = True
        Me.part_name.Width = 65
        '
        'part_specs
        '
        Me.part_specs.HeaderText = "Specyfikacja"
        Me.part_specs.Name = "part_specs"
        Me.part_specs.ReadOnly = True
        Me.part_specs.Width = 93
        '
        'part_catalog_no
        '
        Me.part_catalog_no.HeaderText = "Numer katalogowy"
        Me.part_catalog_no.Name = "part_catalog_no"
        Me.part_catalog_no.ReadOnly = True
        Me.part_catalog_no.Width = 110
        '
        'part_manufacturer
        '
        Me.part_manufacturer.HeaderText = "Producent"
        Me.part_manufacturer.Name = "part_manufacturer"
        Me.part_manufacturer.ReadOnly = True
        Me.part_manufacturer.Width = 81
        '
        'frmParts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvParts)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmParts"
        Me.Text = "frmParts"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvParts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents EdytujToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DodajToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents UsuńToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnAdd As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvParts As DataGridView
    Friend WithEvents part_id As DataGridViewTextBoxColumn
    Friend WithEvents part_name As DataGridViewTextBoxColumn
    Friend WithEvents part_specs As DataGridViewTextBoxColumn
    Friend WithEvents part_catalog_no As DataGridViewTextBoxColumn
    Friend WithEvents part_manufacturer As DataGridViewTextBoxColumn
End Class
