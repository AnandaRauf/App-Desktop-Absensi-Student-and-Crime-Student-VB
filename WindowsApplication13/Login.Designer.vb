<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PassBox = New System.Windows.Forms.TextBox()
        Me.UserBox = New System.Windows.Forms.TextBox()
        Me.QuitBut = New System.Windows.Forms.Button()
        Me.LogBut = New System.Windows.Forms.Button()
        Me.PassLBL = New System.Windows.Forms.Label()
        Me.UserLBL = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SpringGreen
        Me.GroupBox1.Controls.Add(Me.PassBox)
        Me.GroupBox1.Controls.Add(Me.UserBox)
        Me.GroupBox1.Controls.Add(Me.QuitBut)
        Me.GroupBox1.Controls.Add(Me.LogBut)
        Me.GroupBox1.Controls.Add(Me.PassLBL)
        Me.GroupBox1.Controls.Add(Me.UserLBL)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(463, 221)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'PassBox
        '
        Me.PassBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassBox.Location = New System.Drawing.Point(133, 110)
        Me.PassBox.Name = "PassBox"
        Me.PassBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassBox.Size = New System.Drawing.Size(242, 26)
        Me.PassBox.TabIndex = 9
        '
        'UserBox
        '
        Me.UserBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserBox.Location = New System.Drawing.Point(133, 29)
        Me.UserBox.Name = "UserBox"
        Me.UserBox.Size = New System.Drawing.Size(192, 26)
        Me.UserBox.TabIndex = 8
        '
        'QuitBut
        '
        Me.QuitBut.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitBut.Location = New System.Drawing.Point(306, 169)
        Me.QuitBut.Name = "QuitBut"
        Me.QuitBut.Size = New System.Drawing.Size(96, 34)
        Me.QuitBut.TabIndex = 5
        Me.QuitBut.Text = "Quit"
        Me.QuitBut.UseVisualStyleBackColor = True
        '
        'LogBut
        '
        Me.LogBut.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogBut.Location = New System.Drawing.Point(23, 169)
        Me.LogBut.Name = "LogBut"
        Me.LogBut.Size = New System.Drawing.Size(96, 34)
        Me.LogBut.TabIndex = 4
        Me.LogBut.Text = "Login"
        Me.LogBut.UseVisualStyleBackColor = True
        '
        'PassLBL
        '
        Me.PassLBL.AutoSize = True
        Me.PassLBL.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassLBL.Location = New System.Drawing.Point(19, 105)
        Me.PassLBL.Name = "PassLBL"
        Me.PassLBL.Size = New System.Drawing.Size(100, 21)
        Me.PassLBL.TabIndex = 1
        Me.PassLBL.Text = "Password :"
        '
        'UserLBL
        '
        Me.UserLBL.AutoSize = True
        Me.UserLBL.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserLBL.Location = New System.Drawing.Point(19, 29)
        Me.UserLBL.Name = "UserLBL"
        Me.UserLBL.Size = New System.Drawing.Size(107, 21)
        Me.UserLBL.TabIndex = 0
        Me.UserLBL.Text = "Username :"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(799, 477)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PassBox As TextBox
    Friend WithEvents UserBox As TextBox
    Friend WithEvents QuitBut As Button
    Friend WithEvents LogBut As Button
    Friend WithEvents PassLBL As Label
    Friend WithEvents UserLBL As Label
End Class
