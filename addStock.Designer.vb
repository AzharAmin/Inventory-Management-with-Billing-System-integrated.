<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addStock
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBoxSNAME = New System.Windows.Forms.TextBox
        Me.BTN_SHOW = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TextBoxMNO = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBoxPNAME = New System.Windows.Forms.TextBox
        Me.TextBoxSTOCK = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBoxTYPE = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.BTN_CANCEL = New System.Windows.Forms.Button
        Me.BTN_ADDSTOCK = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TextBoxSNAME)
        Me.Panel1.Controls.Add(Me.BTN_SHOW)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.TextBoxMNO)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextBoxPNAME)
        Me.Panel1.Controls.Add(Me.TextBoxSTOCK)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TextBoxTYPE)
        Me.Panel1.Location = New System.Drawing.Point(233, 190)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(472, 344)
        Me.Panel1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 24)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Supplier Name"
        '
        'TextBoxSNAME
        '
        Me.TextBoxSNAME.Enabled = False
        Me.TextBoxSNAME.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSNAME.Location = New System.Drawing.Point(184, 214)
        Me.TextBoxSNAME.Name = "TextBoxSNAME"
        Me.TextBoxSNAME.Size = New System.Drawing.Size(236, 32)
        Me.TextBoxSNAME.TabIndex = 34
        '
        'BTN_SHOW
        '
        Me.BTN_SHOW.BackColor = System.Drawing.Color.Teal
        Me.BTN_SHOW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_SHOW.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SHOW.Location = New System.Drawing.Point(345, 29)
        Me.BTN_SHOW.Name = "BTN_SHOW"
        Me.BTN_SHOW.Size = New System.Drawing.Size(75, 29)
        Me.BTN_SHOW.TabIndex = 32
        Me.BTN_SHOW.Text = "SHOW"
        Me.BTN_SHOW.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(184, 28)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(146, 30)
        Me.ComboBox1.TabIndex = 30
        '
        'TextBoxMNO
        '
        Me.TextBoxMNO.Enabled = False
        Me.TextBoxMNO.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMNO.Location = New System.Drawing.Point(184, 120)
        Me.TextBoxMNO.Name = "TextBoxMNO"
        Me.TextBoxMNO.Size = New System.Drawing.Size(236, 32)
        Me.TextBoxMNO.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 24)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Model Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Product ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 24)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Product Name"
        '
        'TextBoxPNAME
        '
        Me.TextBoxPNAME.Enabled = False
        Me.TextBoxPNAME.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPNAME.Location = New System.Drawing.Point(184, 72)
        Me.TextBoxPNAME.Name = "TextBoxPNAME"
        Me.TextBoxPNAME.Size = New System.Drawing.Size(236, 32)
        Me.TextBoxPNAME.TabIndex = 21
        '
        'TextBoxSTOCK
        '
        Me.TextBoxSTOCK.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSTOCK.Location = New System.Drawing.Point(184, 258)
        Me.TextBoxSTOCK.Name = "TextBoxSTOCK"
        Me.TextBoxSTOCK.Size = New System.Drawing.Size(236, 32)
        Me.TextBoxSTOCK.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 24)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Poduct Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 24)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "New Stock"
        '
        'TextBoxTYPE
        '
        Me.TextBoxTYPE.Enabled = False
        Me.TextBoxTYPE.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTYPE.Location = New System.Drawing.Point(184, 166)
        Me.TextBoxTYPE.Name = "TextBoxTYPE"
        Me.TextBoxTYPE.Size = New System.Drawing.Size(236, 32)
        Me.TextBoxTYPE.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 48.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(646, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 73)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Stock"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Panel2.Controls.Add(Me.BTN_CANCEL)
        Me.Panel2.Controls.Add(Me.BTN_ADDSTOCK)
        Me.Panel2.Location = New System.Drawing.Point(233, 557)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(472, 84)
        Me.Panel2.TabIndex = 33
        '
        'BTN_CANCEL
        '
        Me.BTN_CANCEL.BackColor = System.Drawing.Color.Teal
        Me.BTN_CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CANCEL.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CANCEL.Location = New System.Drawing.Point(268, 21)
        Me.BTN_CANCEL.Name = "BTN_CANCEL"
        Me.BTN_CANCEL.Size = New System.Drawing.Size(173, 37)
        Me.BTN_CANCEL.TabIndex = 1
        Me.BTN_CANCEL.Text = "CANCEL"
        Me.BTN_CANCEL.UseVisualStyleBackColor = False
        '
        'BTN_ADDSTOCK
        '
        Me.BTN_ADDSTOCK.BackColor = System.Drawing.Color.Teal
        Me.BTN_ADDSTOCK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ADDSTOCK.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ADDSTOCK.Location = New System.Drawing.Point(31, 20)
        Me.BTN_ADDSTOCK.Name = "BTN_ADDSTOCK"
        Me.BTN_ADDSTOCK.Size = New System.Drawing.Size(173, 38)
        Me.BTN_ADDSTOCK.TabIndex = 0
        Me.BTN_ADDSTOCK.Text = "ADD STOCK"
        Me.BTN_ADDSTOCK.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(757, 190)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(538, 342)
        Me.DataGridView1.TabIndex = 34
        '
        'addStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1391, 653)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "addStock"
        Me.Text = "addStock"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxMNO As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPNAME As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSTOCK As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTYPE As System.Windows.Forms.TextBox
    Friend WithEvents BTN_SHOW As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BTN_CANCEL As System.Windows.Forms.Button
    Friend WithEvents BTN_ADDSTOCK As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSNAME As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
