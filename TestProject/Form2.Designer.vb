<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ContactsBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContactsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContactsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContactsBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UserManagementDataSet = New TestProject.UserManagementDataSet()
        Me.UserManagementDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserManagementDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContactsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContactsTableAdapter = New TestProject.UserManagementDataSetTableAdapters.ContactsTableAdapter()
        Me.ContactsBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NickNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthDayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        CType(Me.ContactsBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactsBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserManagementDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserManagementDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactsBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(241, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 42)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add Contacts"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(447, 58)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 42)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Show Contacts"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(42, 145)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1144, 461)
        Me.Panel1.TabIndex = 2
        '
        'ContactsBindingSource4
        '
        Me.ContactsBindingSource4.DataMember = "Contacts"
        '
        'ContactsBindingSource1
        '
        Me.ContactsBindingSource1.DataMember = "Contacts"
        '
        'ContactsBindingSource2
        '
        Me.ContactsBindingSource2.DataMember = "Contacts"
        '
        'ContactsBindingSource3
        '
        Me.ContactsBindingSource3.DataMember = "Contacts"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.NickNameDataGridViewTextBoxColumn, Me.BirthDayDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ContactsBindingSource5
        Me.DataGridView1.Location = New System.Drawing.Point(16, 14)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1106, 434)
        Me.DataGridView1.TabIndex = 0
        '
        'UserManagementDataSet
        '
        Me.UserManagementDataSet.DataSetName = "UserManagementDataSet"
        Me.UserManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserManagementDataSetBindingSource
        '
        Me.UserManagementDataSetBindingSource.DataSource = Me.UserManagementDataSet
        Me.UserManagementDataSetBindingSource.Position = 0
        '
        'UserManagementDataSetBindingSource1
        '
        Me.UserManagementDataSetBindingSource1.DataSource = Me.UserManagementDataSet
        Me.UserManagementDataSetBindingSource1.Position = 0
        '
        'ContactsBindingSource
        '
        Me.ContactsBindingSource.DataMember = "Contacts"
        Me.ContactsBindingSource.DataSource = Me.UserManagementDataSetBindingSource
        '
        'ContactsTableAdapter
        '
        Me.ContactsTableAdapter.ClearBeforeFill = True
        '
        'ContactsBindingSource5
        '
        Me.ContactsBindingSource5.DataMember = "Contacts"
        Me.ContactsBindingSource5.DataSource = Me.UserManagementDataSetBindingSource
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'NickNameDataGridViewTextBoxColumn
        '
        Me.NickNameDataGridViewTextBoxColumn.DataPropertyName = "NickName"
        Me.NickNameDataGridViewTextBoxColumn.HeaderText = "NickName"
        Me.NickNameDataGridViewTextBoxColumn.Name = "NickNameDataGridViewTextBoxColumn"
        '
        'BirthDayDataGridViewTextBoxColumn
        '
        Me.BirthDayDataGridViewTextBoxColumn.DataPropertyName = "BirthDay"
        Me.BirthDayDataGridViewTextBoxColumn.HeaderText = "BirthDay"
        Me.BirthDayDataGridViewTextBoxColumn.Name = "BirthDayDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(659, 58)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(158, 42)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Export"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1144, 127)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1220, 649)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        CType(Me.ContactsBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactsBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserManagementDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserManagementDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactsBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ContactsBindingSource1 As BindingSource
    Friend WithEvents ContactsBindingSource2 As BindingSource
    Friend WithEvents ContactsBindingSource4 As BindingSource
    Friend WithEvents ContactsBindingSource3 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents UserManagementDataSetBindingSource1 As BindingSource
    Friend WithEvents UserManagementDataSet As UserManagementDataSet
    Friend WithEvents UserManagementDataSetBindingSource As BindingSource
    Friend WithEvents ContactsBindingSource As BindingSource
    Friend WithEvents ContactsTableAdapter As UserManagementDataSetTableAdapters.ContactsTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NickNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BirthDayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactsBindingSource5 As BindingSource
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
