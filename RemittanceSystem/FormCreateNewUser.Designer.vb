<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCreateNewUser
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtLastID = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtRole = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CboShowPW = New System.Windows.Forms.CheckBox()
        Me.PassProgressBar = New System.Windows.Forms.ProgressBar()
        Me.LblPWProgress = New System.Windows.Forms.Label()
        Me.TxtReEnterPW = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtLName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtFName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtUserName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtEmpID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.LinkLogOut = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Last User ID:"
        '
        'TxtLastID
        '
        Me.TxtLastID.Enabled = False
        Me.TxtLastID.Location = New System.Drawing.Point(42, 31)
        Me.TxtLastID.Name = "TxtLastID"
        Me.TxtLastID.Size = New System.Drawing.Size(116, 20)
        Me.TxtLastID.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtRole)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.CboShowPW)
        Me.GroupBox1.Controls.Add(Me.PassProgressBar)
        Me.GroupBox1.Controls.Add(Me.LblPWProgress)
        Me.GroupBox1.Controls.Add(Me.TxtReEnterPW)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtLName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtFName)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtPassword)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtUserName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtEmpID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(553, 235)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NEW USER INFORMATION:"
        '
        'TxtRole
        '
        Me.TxtRole.Location = New System.Drawing.Point(17, 201)
        Me.TxtRole.Name = "TxtRole"
        Me.TxtRole.Size = New System.Drawing.Size(230, 20)
        Me.TxtRole.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Role / Position:"
        '
        'CboShowPW
        '
        Me.CboShowPW.AutoSize = True
        Me.CboShowPW.Location = New System.Drawing.Point(437, 191)
        Me.CboShowPW.Name = "CboShowPW"
        Me.CboShowPW.Size = New System.Drawing.Size(108, 17)
        Me.CboShowPW.TabIndex = 20
        Me.CboShowPW.Text = "Show Password?"
        Me.CboShowPW.UseVisualStyleBackColor = True
        '
        'PassProgressBar
        '
        Me.PassProgressBar.Location = New System.Drawing.Point(292, 152)
        Me.PassProgressBar.Name = "PassProgressBar"
        Me.PassProgressBar.Size = New System.Drawing.Size(115, 13)
        Me.PassProgressBar.TabIndex = 16
        '
        'LblPWProgress
        '
        Me.LblPWProgress.AutoSize = True
        Me.LblPWProgress.Location = New System.Drawing.Point(427, 131)
        Me.LblPWProgress.Name = "LblPWProgress"
        Me.LblPWProgress.Size = New System.Drawing.Size(10, 13)
        Me.LblPWProgress.TabIndex = 15
        Me.LblPWProgress.Text = "-"
        '
        'TxtReEnterPW
        '
        Me.TxtReEnterPW.Location = New System.Drawing.Point(292, 190)
        Me.TxtReEnterPW.Name = "TxtReEnterPW"
        Me.TxtReEnterPW.Size = New System.Drawing.Size(116, 20)
        Me.TxtReEnterPW.TabIndex = 8
        Me.TxtReEnterPW.UseSystemPasswordChar = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(292, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Re-enter Password:"
        '
        'TxtLName
        '
        Me.TxtLName.Location = New System.Drawing.Point(16, 156)
        Me.TxtLName.Name = "TxtLName"
        Me.TxtLName.Size = New System.Drawing.Size(230, 20)
        Me.TxtLName.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Last Name:"
        '
        'TxtFName
        '
        Me.TxtFName.Location = New System.Drawing.Point(16, 111)
        Me.TxtFName.Name = "TxtFName"
        Me.TxtFName.Size = New System.Drawing.Size(230, 20)
        Me.TxtFName.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "First Name:"
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(292, 128)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(116, 20)
        Me.TxtPassword.TabIndex = 7
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(292, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Password:"
        '
        'TxtUserName
        '
        Me.TxtUserName.Location = New System.Drawing.Point(292, 57)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(116, 20)
        Me.TxtUserName.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(292, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "User Name:"
        '
        'TxtEmpID
        '
        Me.TxtEmpID.Location = New System.Drawing.Point(16, 57)
        Me.TxtEmpID.Name = "TxtEmpID"
        Me.TxtEmpID.Size = New System.Drawing.Size(116, 20)
        Me.TxtEmpID.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Employee ID:"
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(114, 326)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(141, 31)
        Me.BtnSave.TabIndex = 9
        Me.BtnSave.Text = "SAVE RECORD"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(331, 326)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(141, 31)
        Me.BtnCancel.TabIndex = 10
        Me.BtnCancel.Text = "CANCEL"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'LinkLogOut
        '
        Me.LinkLogOut.AutoSize = True
        Me.LinkLogOut.Location = New System.Drawing.Point(524, 11)
        Me.LinkLogOut.Name = "LinkLogOut"
        Me.LinkLogOut.Size = New System.Drawing.Size(55, 13)
        Me.LinkLogOut.TabIndex = 5
        Me.LinkLogOut.TabStop = True
        Me.LinkLogOut.Text = "LOG OUT"
        '
        'FormCreateNewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 378)
        Me.ControlBox = False
        Me.Controls.Add(Me.LinkLogOut)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtLastID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormCreateNewUser"
        Me.Text = "CREATE NEW USER:"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtLastID As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtLName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtFName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtUserName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtEmpID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents LinkLogOut As LinkLabel
    Friend WithEvents TxtReEnterPW As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CboShowPW As CheckBox
    Friend WithEvents PassProgressBar As ProgressBar
    Friend WithEvents LblPWProgress As Label
    Friend WithEvents TxtRole As TextBox
    Friend WithEvents Label8 As Label
End Class
