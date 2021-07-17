<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class orderBilling
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.ButtonCancel = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBoxDate = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBoxQuantity = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBoxAddr = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBoxEmailId = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBoxPhone = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBoxCName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBoxCid = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelSum = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.ButtonNext = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Brush Script MT", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(400, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(825, 79)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Order and Billing Details"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.TextBoxDate)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TextBoxQuantity)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TextBoxAddr)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TextBoxEmailId)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TextBoxPhone)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBoxCName)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextBoxCid)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(60, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1406, 275)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ButtonCancel)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(487, 197)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(485, 75)
        Me.Panel2.TabIndex = 3
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.Teal
        Me.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.Location = New System.Drawing.Point(267, 18)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(141, 41)
        Me.ButtonCancel.TabIndex = 17
        Me.ButtonCancel.Text = "CANCEL"
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Teal
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(49, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 41)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBoxDate
        '
        Me.TextBoxDate.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDate.Location = New System.Drawing.Point(1152, 23)
        Me.TextBoxDate.Name = "TextBoxDate"
        Me.TextBoxDate.Size = New System.Drawing.Size(231, 29)
        Me.TextBoxDate.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(999, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 24)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Date"
        '
        'TextBoxQuantity
        '
        Me.TextBoxQuantity.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxQuantity.Location = New System.Drawing.Point(676, 141)
        Me.TextBoxQuantity.Name = "TextBoxQuantity"
        Me.TextBoxQuantity.Size = New System.Drawing.Size(190, 29)
        Me.TextBoxQuantity.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(523, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 24)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Quantity"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(169, 146)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(178, 32)
        Me.ComboBox1.TabIndex = 11
        Me.ComboBox1.Text = "select"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 24)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Select Product"
        '
        'TextBoxAddr
        '
        Me.TextBoxAddr.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAddr.Location = New System.Drawing.Point(676, 83)
        Me.TextBoxAddr.Name = "TextBoxAddr"
        Me.TextBoxAddr.Size = New System.Drawing.Size(190, 29)
        Me.TextBoxAddr.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(523, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 24)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Address"
        '
        'TextBoxEmailId
        '
        Me.TextBoxEmailId.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEmailId.Location = New System.Drawing.Point(169, 88)
        Me.TextBoxEmailId.Name = "TextBoxEmailId"
        Me.TextBoxEmailId.Size = New System.Drawing.Size(190, 29)
        Me.TextBoxEmailId.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 24)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Email ID"
        '
        'TextBoxPhone
        '
        Me.TextBoxPhone.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPhone.Location = New System.Drawing.Point(1152, 78)
        Me.TextBoxPhone.Name = "TextBoxPhone"
        Me.TextBoxPhone.Size = New System.Drawing.Size(231, 29)
        Me.TextBoxPhone.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(999, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Phone No."
        '
        'TextBoxCName
        '
        Me.TextBoxCName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCName.Location = New System.Drawing.Point(676, 23)
        Me.TextBoxCName.Name = "TextBoxCName"
        Me.TextBoxCName.Size = New System.Drawing.Size(190, 29)
        Me.TextBoxCName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(523, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Customer Name"
        '
        'TextBoxCid
        '
        Me.TextBoxCid.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCid.Location = New System.Drawing.Point(169, 23)
        Me.TextBoxCid.Name = "TextBoxCid"
        Me.TextBoxCid.Size = New System.Drawing.Size(190, 29)
        Me.TextBoxCid.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Customer ID"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column8, Me.Column4, Me.Column2, Me.Column3, Me.Column5, Me.Column7, Me.Column6, Me.Column9})
        Me.DataGridView1.Location = New System.Drawing.Point(60, 396)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1402, 207)
        Me.DataGridView1.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "Product ID"
        Me.Column1.Name = "Column1"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Product Name"
        Me.Column8.Name = "Column8"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Model No."
        Me.Column4.Name = "Column4"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Type"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Company Name"
        Me.Column3.Name = "Column3"
        '
        'Column5
        '
        Me.Column5.HeaderText = "warranty"
        Me.Column5.Name = "Column5"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Rate"
        Me.Column7.Name = "Column7"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Quantity"
        Me.Column6.Name = "Column6"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Amount"
        Me.Column9.Name = "Column9"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'LabelSum
        '
        Me.LabelSum.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelSum.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSum.Location = New System.Drawing.Point(1303, 629)
        Me.LabelSum.Name = "LabelSum"
        Me.LabelSum.Size = New System.Drawing.Size(0, 40)
        Me.LabelSum.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Teal
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1160, 629)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 40)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Total"
        '
        'ButtonNext
        '
        Me.ButtonNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNext.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNext.Location = New System.Drawing.Point(649, 681)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(241, 54)
        Me.ButtonNext.TabIndex = 20
        Me.ButtonNext.Text = "NEXT"
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(117, 220)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 26)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'orderBilling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1540, 845)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LabelSum)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "orderBilling"
        Me.Text = "orderBilling"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBoxPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxEmailId As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxAddr As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDate As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents LabelSum As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonNext As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
