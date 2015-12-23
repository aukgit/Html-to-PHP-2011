<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class condition_replace
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
        Me.components = New System.ComponentModel.Container
        Me.Button1 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Php_replaceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds = New Html_to_Php_Converter.ds
        Me.PhpobjectvalueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReplacedphpobjnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FindobjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CaseSensetive = New System.Windows.Forms.DataGridViewCheckBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Php_replaceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "SetValues"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FindobjectDataGridViewTextBoxColumn, Me.ReplacedphpobjnameDataGridViewTextBoxColumn, Me.PhpobjectvalueDataGridViewTextBoxColumn, Me.CaseSensetive})
        Me.DataGridView1.DataSource = Me.Php_replaceBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(623, 415)
        Me.DataGridView1.TabIndex = 1
        '
        'Php_replaceBindingSource
        '
        Me.Php_replaceBindingSource.DataMember = "php_replace"
        Me.Php_replaceBindingSource.DataSource = Me.Ds
        '
        'Ds
        '
        Me.Ds.DataSetName = "ds"
        Me.Ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PhpobjectvalueDataGridViewTextBoxColumn
        '
        Me.PhpobjectvalueDataGridViewTextBoxColumn.DataPropertyName = "php_object_value"
        Me.PhpobjectvalueDataGridViewTextBoxColumn.HeaderText = "$Php_Name = 'value'"
        Me.PhpobjectvalueDataGridViewTextBoxColumn.Name = "PhpobjectvalueDataGridViewTextBoxColumn"
        Me.PhpobjectvalueDataGridViewTextBoxColumn.ToolTipText = "$Php_Name = 'value'"
        Me.PhpobjectvalueDataGridViewTextBoxColumn.Width = 97
        '
        'ReplacedphpobjnameDataGridViewTextBoxColumn
        '
        Me.ReplacedphpobjnameDataGridViewTextBoxColumn.DataPropertyName = "replaced_php_obj_name"
        Me.ReplacedphpobjnameDataGridViewTextBoxColumn.HeaderText = "Repalce Object $Php_Name"
        Me.ReplacedphpobjnameDataGridViewTextBoxColumn.Name = "ReplacedphpobjnameDataGridViewTextBoxColumn"
        Me.ReplacedphpobjnameDataGridViewTextBoxColumn.ToolTipText = "that Object's  repalce  $Php_Name"
        Me.ReplacedphpobjnameDataGridViewTextBoxColumn.Width = 157
        '
        'FindobjectDataGridViewTextBoxColumn
        '
        Me.FindobjectDataGridViewTextBoxColumn.DataPropertyName = "find_object"
        Me.FindobjectDataGridViewTextBoxColumn.HeaderText = "Find object String"
        Me.FindobjectDataGridViewTextBoxColumn.Name = "FindobjectDataGridViewTextBoxColumn"
        Me.FindobjectDataGridViewTextBoxColumn.Width = 114
        '
        'CaseSensetive
        '
        Me.CaseSensetive.DataPropertyName = "CaseSensetive"
        Me.CaseSensetive.HeaderText = "CaseSensetive"
        Me.CaseSensetive.Name = "CaseSensetive"
        Me.CaseSensetive.Width = 85
        '
        'condition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 482)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "condition"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "condition replace php"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Php_replaceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Php_replaceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds As Html_to_Php_Converter.ds
    Friend WithEvents FindobjectDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReplacedphpobjnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhpobjectvalueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaseSensetive As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
