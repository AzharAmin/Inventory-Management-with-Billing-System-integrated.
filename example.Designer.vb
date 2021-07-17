<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class example
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBoxID = New System.Windows.Forms.TextBox
        Me.TextBoxName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBoxDesc = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.BTN_INSERT = New System.Windows.Forms.Button
        Me.BTN_UPDATE = New System.Windows.Forms.Button
        Me.BTN_DELETE = New System.Windows.Forms.Button
        Me.TextBoxSearch = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.BTN_FIND = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'TextBoxID
        '
        Me.TextBoxID.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxID.Location = New System.Drawing.Point(208, 50)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(157, 32)
        Me.TextBoxID.TabIndex = 1
        '
        'TextBoxName
        '
        Me.TextBoxName.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxName.Location = New System.Drawing.Point(208, 111)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(157, 32)
        Me.TextBoxName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'TextBoxDesc
        '
        Me.TextBoxDesc.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDesc.Location = New System.Drawing.Point(208, 179)
        Me.TextBoxDesc.Name = "TextBoxDesc"
        Me.TextBoxDesc.Size = New System.Drawing.Size(157, 32)
        Me.TextBoxDesc.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Description"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox1.Location = New System.Drawing.Point(508, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 159)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(549, 217)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 30)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(208, 347)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(496, 384)
        Me.DataGridView1.TabIndex = 8
        '
        'BTN_INSERT
        '
        Me.BTN_INSERT.Location = New System.Drawing.Point(751, 52)
        Me.BTN_INSERT.Name = "BTN_INSERT"
        Me.BTN_INSERT.Size = New System.Drawing.Size(106, 30)
        Me.BTN_INSERT.TabIndex = 9
        Me.BTN_INSERT.Text = "Insert"
        Me.BTN_INSERT.UseVisualStyleBackColor = True
        '
        'BTN_UPDATE
        '
        Me.BTN_UPDATE.Location = New System.Drawing.Point(751, 101)
        Me.BTN_UPDATE.Name = "BTN_UPDATE"
        Me.BTN_UPDATE.Size = New System.Drawing.Size(106, 25)
        Me.BTN_UPDATE.TabIndex = 10
        Me.BTN_UPDATE.Text = "Update"
        Me.BTN_UPDATE.UseVisualStyleBackColor = True
        '
        'BTN_DELETE
        '
        Me.BTN_DELETE.Location = New System.Drawing.Point(751, 147)
        Me.BTN_DELETE.Name = "BTN_DELETE"
        Me.BTN_DELETE.Size = New System.Drawing.Size(106, 27)
        Me.BTN_DELETE.TabIndex = 11
        Me.BTN_DELETE.Text = "Delete"
        Me.BTN_DELETE.UseVisualStyleBackColor = True
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.Location = New System.Drawing.Point(419, 290)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(283, 32)
        Me.TextBoxSearch.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(204, 292)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(209, 30)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Enter value to Search"
        '
        'BTN_FIND
        '
        Me.BTN_FIND.Location = New System.Drawing.Point(371, 50)
        Me.BTN_FIND.Name = "BTN_FIND"
        Me.BTN_FIND.Size = New System.Drawing.Size(131, 32)
        Me.BTN_FIND.TabIndex = 14
        Me.BTN_FIND.Text = "Find"
        Me.BTN_FIND.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(957, 845)
        Me.Controls.Add(Me.BTN_FIND)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BTN_DELETE)
        Me.Controls.Add(Me.BTN_UPDATE)
        Me.Controls.Add(Me.BTN_INSERT)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBoxDesc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxID As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BTN_INSERT As System.Windows.Forms.Button
    Friend WithEvents BTN_UPDATE As System.Windows.Forms.Button
    Friend WithEvents BTN_DELETE As System.Windows.Forms.Button
    Friend WithEvents TextBoxSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BTN_FIND As System.Windows.Forms.Button
End Class
