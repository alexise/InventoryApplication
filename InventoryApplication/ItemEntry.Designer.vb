<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EntryForm))
        Me.lblDate = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.CategorymasterBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryDBDataSet2 = New InventoryApplication.InventoryDBDataSet2()
        Me.txtCategory = New System.Windows.Forms.Label()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.txtUnitPrice = New System.Windows.Forms.Label()
        Me.UnitPriceTextBox = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.Label()
        Me.ItemNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CategorymasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryDBDataSet = New InventoryApplication.InventoryDBDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.EstimatedPeriodComboBox = New System.Windows.Forms.ComboBox()
        Me.SalvageValueTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DepreciationTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.EstimatedUsefulTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Category_masterTableAdapter = New InventoryApplication.InventoryDBDataSetTableAdapters.category_masterTableAdapter()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.ItemFlexGrid = New AxMSFlexGridLib.AxMSFlexGrid()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.DateAcquired = New System.Windows.Forms.DateTimePicker()
        Me.txtDateAcq = New System.Windows.Forms.Label()
        Me.InvoiceNoTextBox = New System.Windows.Forms.TextBox()
        Me.InvoiceNo = New System.Windows.Forms.Label()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Category_masterTableAdapter1 = New InventoryApplication.InventoryDBDataSet2TableAdapters.category_masterTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CategorymasterBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDBDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategorymasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ItemFlexGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(714, 15)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(39, 13)
        Me.lblDate.TabIndex = 6
        Me.lblDate.Text = "Label4"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CategoryComboBox)
        Me.GroupBox1.Controls.Add(Me.txtCategory)
        Me.GroupBox1.Controls.Add(Me.QuantityTextBox)
        Me.GroupBox1.Controls.Add(Me.txtUnitPrice)
        Me.GroupBox1.Controls.Add(Me.UnitPriceTextBox)
        Me.GroupBox1.Controls.Add(Me.txtQty)
        Me.GroupBox1.Controls.Add(Me.ItemNameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(28, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 171)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item Information"
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CategorymasterBindingSource1, "category_id", True))
        Me.CategoryComboBox.DataSource = Me.CategorymasterBindingSource1
        Me.CategoryComboBox.DisplayMember = "category_type"
        Me.CategoryComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Location = New System.Drawing.Point(115, 117)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CategoryComboBox.TabIndex = 21
        Me.CategoryComboBox.ValueMember = "category_id"
        '
        'CategorymasterBindingSource1
        '
        Me.CategorymasterBindingSource1.DataMember = "category_master"
        Me.CategorymasterBindingSource1.DataSource = Me.InventoryDBDataSet2
        '
        'InventoryDBDataSet2
        '
        Me.InventoryDBDataSet2.DataSetName = "InventoryDBDataSet2"
        Me.InventoryDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtCategory
        '
        Me.txtCategory.AutoSize = True
        Me.txtCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Location = New System.Drawing.Point(33, 125)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(49, 13)
        Me.txtCategory.TabIndex = 20
        Me.txtCategory.Text = "Category"
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTextBox.Location = New System.Drawing.Point(115, 90)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(140, 20)
        Me.QuantityTextBox.TabIndex = 19
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.AutoSize = True
        Me.txtUnitPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitPrice.Location = New System.Drawing.Point(33, 67)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(53, 13)
        Me.txtUnitPrice.TabIndex = 18
        Me.txtUnitPrice.Text = "Unit Price"
        '
        'UnitPriceTextBox
        '
        Me.UnitPriceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnitPriceTextBox.Location = New System.Drawing.Point(115, 64)
        Me.UnitPriceTextBox.Name = "UnitPriceTextBox"
        Me.UnitPriceTextBox.Size = New System.Drawing.Size(140, 20)
        Me.UnitPriceTextBox.TabIndex = 17
        '
        'txtQty
        '
        Me.txtQty.AutoSize = True
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(33, 93)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(46, 13)
        Me.txtQty.TabIndex = 16
        Me.txtQty.Text = "Quantity"
        '
        'ItemNameTextBox
        '
        Me.ItemNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemNameTextBox.Location = New System.Drawing.Point(115, 34)
        Me.ItemNameTextBox.Name = "ItemNameTextBox"
        Me.ItemNameTextBox.Size = New System.Drawing.Size(140, 20)
        Me.ItemNameTextBox.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Item Name"
        '
        'CategorymasterBindingSource
        '
        Me.CategorymasterBindingSource.DataMember = "category_master"
        Me.CategorymasterBindingSource.DataSource = Me.InventoryDBDataSet
        '
        'InventoryDBDataSet
        '
        Me.InventoryDBDataSet.DataSetName = "InventoryDBDataSet"
        Me.InventoryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(675, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Date"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.EstimatedPeriodComboBox)
        Me.GroupBox2.Controls.Add(Me.SalvageValueTextBox)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.DepreciationTextBox)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.EstimatedUsefulTextBox)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(475, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(364, 138)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Depreciation Details"
        '
        'EstimatedPeriodComboBox
        '
        Me.EstimatedPeriodComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstimatedPeriodComboBox.FormattingEnabled = True
        Me.EstimatedPeriodComboBox.Items.AddRange(New Object() {"mos.", "yrs."})
        Me.EstimatedPeriodComboBox.Location = New System.Drawing.Point(305, 37)
        Me.EstimatedPeriodComboBox.Name = "EstimatedPeriodComboBox"
        Me.EstimatedPeriodComboBox.Size = New System.Drawing.Size(40, 21)
        Me.EstimatedPeriodComboBox.TabIndex = 25
        '
        'SalvageValueTextBox
        '
        Me.SalvageValueTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalvageValueTextBox.Location = New System.Drawing.Point(159, 72)
        Me.SalvageValueTextBox.Name = "SalvageValueTextBox"
        Me.SalvageValueTextBox.Size = New System.Drawing.Size(140, 20)
        Me.SalvageValueTextBox.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(2, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Approximate Salvage Value"
        '
        'DepreciationTextBox
        '
        Me.DepreciationTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.DepreciationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepreciationTextBox.Location = New System.Drawing.Point(159, 110)
        Me.DepreciationTextBox.Name = "DepreciationTextBox"
        Me.DepreciationTextBox.Size = New System.Drawing.Size(140, 20)
        Me.DepreciationTextBox.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(2, 113)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Accumulated Depreciation"
        '
        'EstimatedUsefulTextBox
        '
        Me.EstimatedUsefulTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstimatedUsefulTextBox.Location = New System.Drawing.Point(159, 37)
        Me.EstimatedUsefulTextBox.Name = "EstimatedUsefulTextBox"
        Me.EstimatedUsefulTextBox.Size = New System.Drawing.Size(140, 20)
        Me.EstimatedUsefulTextBox.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(2, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Estimated Useful Life "
        '
        'Category_masterTableAdapter
        '
        Me.Category_masterTableAdapter.ClearBeforeFill = True
        '
        'AddButton
        '
        Me.AddButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AddButton.Location = New System.Drawing.Point(480, 246)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 20
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CancelButton.Location = New System.Drawing.Point(572, 246)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 21
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'ItemFlexGrid
        '
        Me.ItemFlexGrid.Location = New System.Drawing.Point(12, 287)
        Me.ItemFlexGrid.Name = "ItemFlexGrid"
        Me.ItemFlexGrid.OcxState = CType(resources.GetObject("ItemFlexGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ItemFlexGrid.Size = New System.Drawing.Size(858, 129)
        Me.ItemFlexGrid.TabIndex = 22
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(690, 555)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 24
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(609, 555)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'DateAcquired
        '
        Me.DateAcquired.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateAcquired.Location = New System.Drawing.Point(114, 61)
        Me.DateAcquired.Name = "DateAcquired"
        Me.DateAcquired.Size = New System.Drawing.Size(200, 20)
        Me.DateAcquired.TabIndex = 26
        '
        'txtDateAcq
        '
        Me.txtDateAcq.AutoSize = True
        Me.txtDateAcq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateAcq.Location = New System.Drawing.Point(32, 67)
        Me.txtDateAcq.Name = "txtDateAcq"
        Me.txtDateAcq.Size = New System.Drawing.Size(75, 13)
        Me.txtDateAcq.TabIndex = 25
        Me.txtDateAcq.Text = "Date Acquired"
        '
        'InvoiceNoTextBox
        '
        Me.InvoiceNoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InvoiceNoTextBox.Location = New System.Drawing.Point(114, 35)
        Me.InvoiceNoTextBox.Name = "InvoiceNoTextBox"
        Me.InvoiceNoTextBox.Size = New System.Drawing.Size(140, 20)
        Me.InvoiceNoTextBox.TabIndex = 28
        '
        'InvoiceNo
        '
        Me.InvoiceNo.AutoSize = True
        Me.InvoiceNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InvoiceNo.Location = New System.Drawing.Point(32, 42)
        Me.InvoiceNo.Name = "InvoiceNo"
        Me.InvoiceNo.Size = New System.Drawing.Size(59, 13)
        Me.InvoiceNo.TabIndex = 27
        Me.InvoiceNo.Text = "Invoice No"
        '
        'NotesTextBox
        '
        Me.NotesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotesTextBox.Location = New System.Drawing.Point(18, 28)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(464, 90)
        Me.NotesTextBox.TabIndex = 29
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.NotesTextBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(28, 445)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(497, 133)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Notes"
        '
        'Category_masterTableAdapter1
        '
        Me.Category_masterTableAdapter1.ClearBeforeFill = True
        '
        'EntryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 612)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.InvoiceNoTextBox)
        Me.Controls.Add(Me.InvoiceNo)
        Me.Controls.Add(Me.DateAcquired)
        Me.Controls.Add(Me.txtDateAcq)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.ItemFlexGrid)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EntryForm"
        Me.Text = "Inventory System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CategorymasterBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDBDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategorymasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ItemFlexGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents txtUnitPrice As System.Windows.Forms.Label
    Friend WithEvents UnitPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents txtQty As System.Windows.Forms.Label
    Friend WithEvents ItemNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SalvageValueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DepreciationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents EstimatedUsefulTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CategoryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents txtCategory As System.Windows.Forms.Label
    Friend WithEvents InventoryDBDataSet As InventoryApplication.InventoryDBDataSet
    Friend WithEvents CategorymasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Category_masterTableAdapter As InventoryApplication.InventoryDBDataSetTableAdapters.category_masterTableAdapter
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents ItemFlexGrid As AxMSFlexGridLib.AxMSFlexGrid
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents EstimatedPeriodComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DateAcquired As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDateAcq As System.Windows.Forms.Label
    Friend WithEvents InvoiceNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InvoiceNo As System.Windows.Forms.Label
    Friend WithEvents NotesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents InventoryDBDataSet2 As InventoryApplication.InventoryDBDataSet2
    Friend WithEvents CategorymasterBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Category_masterTableAdapter1 As InventoryApplication.InventoryDBDataSet2TableAdapters.category_masterTableAdapter
End Class
