<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stockdetails
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBoxSearch = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(618, 364)
        Me.DataGridView1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(499, 261)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(670, 407)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Label1.Font = New System.Drawing.Font("Brush Script MT", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(634, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 59)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Product Stock Check"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Teal
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(495, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Value To Search"
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.Location = New System.Drawing.Point(725, 212)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(444, 29)
        Me.TextBoxSearch.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(749, 674)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 40)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'stockdetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1401, 774)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "stockdetails"
        Me.Text = "stockdetails"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSearch As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
