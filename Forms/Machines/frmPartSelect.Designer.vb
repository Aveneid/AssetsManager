<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPartSelect
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
        Me.dgvParts = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.part_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.part_select = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.part_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.part_spec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.part_catalog_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.part_manu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvParts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvParts
        '
        Me.dgvParts.AllowUserToAddRows = False
        Me.dgvParts.AllowUserToDeleteRows = False
        Me.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.part_id, Me.part_select, Me.part_name, Me.part_spec, Me.part_catalog_no, Me.part_manu})
        Me.dgvParts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvParts.Location = New System.Drawing.Point(0, 0)
        Me.dgvParts.Name = "dgvParts"
        Me.dgvParts.Size = New System.Drawing.Size(800, 450)
        Me.dgvParts.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 409)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 41)
        Me.Panel1.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(713, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Zamknij"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Dodaj"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'part_id
        '
        Me.part_id.HeaderText = "part_id"
        Me.part_id.Name = "part_id"
        Me.part_id.Visible = False
        '
        'part_select
        '
        Me.part_select.HeaderText = "Wybierz"
        Me.part_select.Name = "part_select"
        Me.part_select.Width = 50
        '
        'part_name
        '
        Me.part_name.HeaderText = "Nazwa"
        Me.part_name.Name = "part_name"
        Me.part_name.ReadOnly = True
        '
        'part_spec
        '
        Me.part_spec.HeaderText = "Specyfikacja"
        Me.part_spec.Name = "part_spec"
        Me.part_spec.ReadOnly = True
        '
        'part_catalog_no
        '
        Me.part_catalog_no.HeaderText = "Numer katalogowy"
        Me.part_catalog_no.Name = "part_catalog_no"
        Me.part_catalog_no.ReadOnly = True
        '
        'part_manu
        '
        Me.part_manu.HeaderText = "Producent"
        Me.part_manu.Name = "part_manu"
        Me.part_manu.ReadOnly = True
        '
        'frmPartSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvParts)
        Me.Name = "frmPartSelect"
        Me.Text = "frmPartSelect"
        CType(Me.dgvParts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvParts As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents part_id As DataGridViewTextBoxColumn
    Friend WithEvents part_select As DataGridViewCheckBoxColumn
    Friend WithEvents part_name As DataGridViewTextBoxColumn
    Friend WithEvents part_spec As DataGridViewTextBoxColumn
    Friend WithEvents part_catalog_no As DataGridViewTextBoxColumn
    Friend WithEvents part_manu As DataGridViewTextBoxColumn
End Class
