<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class billing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(billing))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.LabelCname = New System.Windows.Forms.Label
        Me.LabelCust_name = New System.Windows.Forms.Label
        Me.LabelB = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LabelDate = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBoxBillNo = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.LabelSum = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.Labelgrandtotal = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Labelsgst = New System.Windows.Forms.Label
        Me.Labelcgst = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(503, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(645, 73)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GADGET's GALAXY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Teal
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(782, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ABC Building"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Teal
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(772, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "XYZ Coumpund"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Teal
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(782, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Pune,411036"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Teal
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(688, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(291, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Contact:-9797857496,8600659856"
        '
        'LabelCname
        '
        Me.LabelCname.AutoSize = True
        Me.LabelCname.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCname.Location = New System.Drawing.Point(58, 192)
        Me.LabelCname.Name = "LabelCname"
        Me.LabelCname.Size = New System.Drawing.Size(213, 31)
        Me.LabelCname.TabIndex = 5
        Me.LabelCname.Text = "Customer Name:"
        '
        'LabelCust_name
        '
        Me.LabelCust_name.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelCust_name.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCust_name.ForeColor = System.Drawing.Color.Black
        Me.LabelCust_name.Location = New System.Drawing.Point(268, 192)
        Me.LabelCust_name.Name = "LabelCust_name"
        Me.LabelCust_name.Size = New System.Drawing.Size(226, 24)
        Me.LabelCust_name.TabIndex = 6
        '
        'LabelB
        '
        Me.LabelB.AutoSize = True
        Me.LabelB.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelB.Location = New System.Drawing.Point(1082, 192)
        Me.LabelB.Name = "LabelB"
        Me.LabelB.Size = New System.Drawing.Size(168, 31)
        Me.LabelB.TabIndex = 7
        Me.LabelB.Text = "Bill Number:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(0, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1540, 180)
        Me.Panel1.TabIndex = 9
        '
        'LabelDate
        '
        Me.LabelDate.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelDate.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDate.Location = New System.Drawing.Point(726, 192)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(226, 24)
        Me.LabelDate.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(633, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 31)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Date:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(17, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(810, 153)
        Me.DataGridView1.TabIndex = 12
        '
        'Column1
        '
        Me.Column1.HeaderText = "Particulars"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Rate"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Quantity"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Amount"
        Me.Column4.Name = "Column4"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'TextBoxBillNo
        '
        Me.TextBoxBillNo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBillNo.Location = New System.Drawing.Point(1267, 192)
        Me.TextBoxBillNo.Name = "TextBoxBillNo"
        Me.TextBoxBillNo.Size = New System.Drawing.Size(156, 29)
        Me.TextBoxBillNo.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Teal
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(530, 170)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 27)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Net Total"
        '
        'LabelSum
        '
        Me.LabelSum.BackColor = System.Drawing.Color.Teal
        Me.LabelSum.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSum.Location = New System.Drawing.Point(655, 170)
        Me.LabelSum.Name = "LabelSum"
        Me.LabelSum.Size = New System.Drawing.Size(129, 27)
        Me.LabelSum.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(544, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 17)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "CGST(9%)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(546, 244)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 17)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "SGST(9%)"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Labelgrandtotal)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel2.Location = New System.Drawing.Point(311, 268)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(915, 449)
        Me.Panel2.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Teal
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Yellow
        Me.Label11.Location = New System.Drawing.Point(509, 329)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(159, 31)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Grand Total"
        '
        'Labelgrandtotal
        '
        Me.Labelgrandtotal.BackColor = System.Drawing.Color.Teal
        Me.Labelgrandtotal.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelgrandtotal.Location = New System.Drawing.Point(691, 333)
        Me.Labelgrandtotal.Name = "Labelgrandtotal"
        Me.Labelgrandtotal.Size = New System.Drawing.Size(129, 27)
        Me.Labelgrandtotal.TabIndex = 22
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Labelsgst)
        Me.Panel3.Controls.Add(Me.Labelcgst)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Controls.Add(Me.LabelSum)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Location = New System.Drawing.Point(36, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(849, 281)
        Me.Panel3.TabIndex = 13
        '
        'Labelsgst
        '
        Me.Labelsgst.BackColor = System.Drawing.Color.Teal
        Me.Labelsgst.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelsgst.Location = New System.Drawing.Point(655, 241)
        Me.Labelsgst.Name = "Labelsgst"
        Me.Labelsgst.Size = New System.Drawing.Size(129, 27)
        Me.Labelsgst.TabIndex = 26
        '
        'Labelcgst
        '
        Me.Labelcgst.BackColor = System.Drawing.Color.Teal
        Me.Labelcgst.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelcgst.Location = New System.Drawing.Point(655, 206)
        Me.Labelcgst.Name = "Labelcgst"
        Me.Labelcgst.Size = New System.Drawing.Size(129, 27)
        Me.Labelcgst.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(307, 731)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 24)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Thank You"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1124, 731)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 24)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Visit Again"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(696, 383)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 37)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "PAID"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'billing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1540, 845)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TextBoxBillNo)
        Me.Controls.Add(Me.LabelDate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LabelB)
        Me.Controls.Add(Me.LabelCust_name)
        Me.Controls.Add(Me.LabelCname)
        Me.Name = "billing"
        Me.Text = "billing"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LabelCname As System.Windows.Forms.Label
    Friend WithEvents LabelCust_name As System.Windows.Forms.Label
    Friend WithEvents LabelB As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LabelDate As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TextBoxBillNo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LabelSum As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Labelgrandtotal As System.Windows.Forms.Label
    Friend WithEvents Labelsgst As System.Windows.Forms.Label
    Friend WithEvents Labelcgst As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
