<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepartmentMaster
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
        Me.CancelDeptButton = New System.Windows.Forms.Button()
        Me.SaveDepButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.DepartmentDataGridView = New System.Windows.Forms.DataGridView()
        Me.DepartmentmasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryDBDataSet3 = New InventoryApplication.InventoryDBDataSet3()
        Me.DepartmentTexbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Department_masterTableAdapter = New InventoryApplication.InventoryDBDataSet3TableAdapters.department_masterTableAdapter()
        Me.Department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DepartmentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentmasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDBDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CancelDeptButton
        '
        Me.CancelDeptButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CancelDeptButton.Location = New System.Drawing.Point(287, 294)
        Me.CancelDeptButton.Name = "CancelDeptButton"
        Me.CancelDeptButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelDeptButton.TabIndex = 11
        Me.CancelDeptButton.Text = "CANCEL"
        Me.CancelDeptButton.UseVisualStyleBackColor = True
        '
        'SaveDepButton
        '
        Me.SaveDepButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SaveDepButton.Location = New System.Drawing.Point(206, 294)
        Me.SaveDepButton.Name = "SaveDepButton"
        Me.SaveDepButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveDepButton.TabIndex = 10
        Me.SaveDepButton.Text = "SAVE"
        Me.SaveDepButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AddButton.ForeColor = System.Drawing.Color.Black
        Me.AddButton.Location = New System.Drawing.Point(287, 41)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 9
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'DepartmentDataGridView
        '
        Me.DepartmentDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DepartmentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DepartmentDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DepartmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DepartmentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Department})
        Me.DepartmentDataGridView.Location = New System.Drawing.Point(11, 79)
        Me.DepartmentDataGridView.Name = "DepartmentDataGridView"
        Me.DepartmentDataGridView.Size = New System.Drawing.Size(211, 160)
        Me.DepartmentDataGridView.TabIndex = 8
        '
        'DepartmentmasterBindingSource
        '
        Me.DepartmentmasterBindingSource.DataMember = "department_master"
        Me.DepartmentmasterBindingSource.DataSource = Me.InventoryDBDataSet3
        '
        'InventoryDBDataSet3
        '
        Me.InventoryDBDataSet3.DataSetName = "InventoryDBDataSet3"
        Me.InventoryDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DepartmentTexbox
        '
        Me.DepartmentTexbox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DepartmentTexbox.Location = New System.Drawing.Point(119, 39)
        Me.DepartmentTexbox.Name = "DepartmentTexbox"
        Me.DepartmentTexbox.Size = New System.Drawing.Size(138, 20)
        Me.DepartmentTexbox.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Department Name"
        '
        'Department_masterTableAdapter
        '
        Me.Department_masterTableAdapter.ClearBeforeFill = True
        '
        'Department
        '
        Me.Department.HeaderText = "Department"
        Me.Department.Name = "Department"
        Me.Department.Width = 87
        '
        'DepartmentMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 350)
        Me.Controls.Add(Me.CancelDeptButton)
        Me.Controls.Add(Me.SaveDepButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.DepartmentDataGridView)
        Me.Controls.Add(Me.DepartmentTexbox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DepartmentMaster"
        Me.Text = "DepartmentMaster"
        CType(Me.DepartmentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentmasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDBDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CancelDeptButton As System.Windows.Forms.Button
    Friend WithEvents SaveDepButton As System.Windows.Forms.Button
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents DepartmentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DepartmentTexbox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents InventoryDBDataSet3 As InventoryApplication.InventoryDBDataSet3
    Friend WithEvents DepartmentmasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Department_masterTableAdapter As InventoryApplication.InventoryDBDataSet3TableAdapters.department_masterTableAdapter
    Friend WithEvents Department As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
