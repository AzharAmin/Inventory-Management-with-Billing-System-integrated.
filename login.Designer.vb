<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.TextBoxUsername = New System.Windows.Forms.TextBox
        Me.TextBoxPassword = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.BTN_LOGIN = New System.Windows.Forms.Button
        Me.BTN_CANCEL = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(523, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUsername.Location = New System.Drawing.Point(664, 224)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(243, 35)
        Me.TextBoxUsername.TabIndex = 1
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPassword.Location = New System.Drawing.Point(664, 282)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(243, 35)
        Me.TextBoxPassword.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(523, 290)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password:"
        '
        'BTN_LOGIN
        '
        Me.BTN_LOGIN.BackColor = System.Drawing.Color.Aqua
        Me.BTN_LOGIN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_LOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_LOGIN.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_LOGIN.Location = New System.Drawing.Point(528, 380)
        Me.BTN_LOGIN.Name = "BTN_LOGIN"
        Me.BTN_LOGIN.Size = New System.Drawing.Size(145, 42)
        Me.BTN_LOGIN.TabIndex = 4
        Me.BTN_LOGIN.Text = "LogIn"
        Me.BTN_LOGIN.UseVisualStyleBackColor = False
        '
        'BTN_CANCEL
        '
        Me.BTN_CANCEL.BackColor = System.Drawing.Color.Red
        Me.BTN_CANCEL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CANCEL.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CANCEL.Location = New System.Drawing.Point(762, 380)
        Me.BTN_CANCEL.Name = "BTN_CANCEL"
        Me.BTN_CANCEL.Size = New System.Drawing.Size(145, 42)
        Me.BTN_CANCEL.TabIndex = 5
        Me.BTN_CANCEL.Text = "CANCEL"
        Me.BTN_CANCEL.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(664, 334)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(123, 23)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "show password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1012, 542)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.BTN_CANCEL)
        Me.Controls.Add(Me.BTN_LOGIN)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Controls.Add(Me.Label1)
        Me.Name = "login"
        Me.Text = "login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxUsername As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BTN_LOGIN As System.Windows.Forms.Button
    Friend WithEvents BTN_CANCEL As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
