<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormChangePW
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
        Me.TxtUpdatePWempID = New System.Windows.Forms.TextBox()
        Me.TxtUpdatorNewPW = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtUpdatorRetypePW = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProgressBarChangePW = New System.Windows.Forms.ProgressBar()
        Me.LabelProgressChangePW = New System.Windows.Forms.Label()
        Me.BtnUpdatePW = New System.Windows.Forms.Button()
        Me.BtnCloseUpdate = New System.Windows.Forms.Button()
        Me.CboViewPW = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee ID:"
        '
        'TxtUpdatePWempID
        '
        Me.TxtUpdatePWempID.Location = New System.Drawing.Point(31, 40)
        Me.TxtUpdatePWempID.Name = "TxtUpdatePWempID"
        Me.TxtUpdatePWempID.Size = New System.Drawing.Size(100, 20)
        Me.TxtUpdatePWempID.TabIndex = 1
        '
        'TxtUpdatorNewPW
        '
        Me.TxtUpdatorNewPW.Location = New System.Drawing.Point(167, 89)
        Me.TxtUpdatorNewPW.Name = "TxtUpdatorNewPW"
        Me.TxtUpdatorNewPW.Size = New System.Drawing.Size(171, 20)
        Me.TxtUpdatorNewPW.TabIndex = 2
        Me.TxtUpdatorNewPW.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "New Password:"
        '
        'TxtUpdatorRetypePW
        '
        Me.TxtUpdatorRetypePW.Location = New System.Drawing.Point(167, 172)
        Me.TxtUpdatorRetypePW.Name = "TxtUpdatorRetypePW"
        Me.TxtUpdatorRetypePW.Size = New System.Drawing.Size(171, 20)
        Me.TxtUpdatorRetypePW.TabIndex = 3
        Me.TxtUpdatorRetypePW.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Re-type Password:"
        '
        'ProgressBarChangePW
        '
        Me.ProgressBarChangePW.Location = New System.Drawing.Point(167, 115)
        Me.ProgressBarChangePW.Name = "ProgressBarChangePW"
        Me.ProgressBarChangePW.Size = New System.Drawing.Size(171, 13)
        Me.ProgressBarChangePW.TabIndex = 6
        '
        'LabelProgressChangePW
        '
        Me.LabelProgressChangePW.AutoSize = True
        Me.LabelProgressChangePW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProgressChangePW.Location = New System.Drawing.Point(174, 131)
        Me.LabelProgressChangePW.Name = "LabelProgressChangePW"
        Me.LabelProgressChangePW.Size = New System.Drawing.Size(15, 15)
        Me.LabelProgressChangePW.TabIndex = 7
        Me.LabelProgressChangePW.Text = "--"
        '
        'BtnUpdatePW
        '
        Me.BtnUpdatePW.Location = New System.Drawing.Point(23, 246)
        Me.BtnUpdatePW.Name = "BtnUpdatePW"
        Me.BtnUpdatePW.Size = New System.Drawing.Size(138, 37)
        Me.BtnUpdatePW.TabIndex = 4
        Me.BtnUpdatePW.Text = "UPDATE PASSWORD"
        Me.BtnUpdatePW.UseVisualStyleBackColor = True
        '
        'BtnCloseUpdate
        '
        Me.BtnCloseUpdate.Location = New System.Drawing.Point(200, 246)
        Me.BtnCloseUpdate.Name = "BtnCloseUpdate"
        Me.BtnCloseUpdate.Size = New System.Drawing.Size(138, 37)
        Me.BtnCloseUpdate.TabIndex = 5
        Me.BtnCloseUpdate.Text = "CLOSE"
        Me.BtnCloseUpdate.UseVisualStyleBackColor = True
        '
        'CboViewPW
        '
        Me.CboViewPW.AutoSize = True
        Me.CboViewPW.Location = New System.Drawing.Point(167, 198)
        Me.CboViewPW.Name = "CboViewPW"
        Me.CboViewPW.Size = New System.Drawing.Size(104, 17)
        Me.CboViewPW.TabIndex = 10
        Me.CboViewPW.Text = "View Password?"
        Me.CboViewPW.UseVisualStyleBackColor = True
        '
        'FormChangePW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 295)
        Me.Controls.Add(Me.CboViewPW)
        Me.Controls.Add(Me.BtnCloseUpdate)
        Me.Controls.Add(Me.BtnUpdatePW)
        Me.Controls.Add(Me.LabelProgressChangePW)
        Me.Controls.Add(Me.ProgressBarChangePW)
        Me.Controls.Add(Me.TxtUpdatorRetypePW)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtUpdatorNewPW)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtUpdatePWempID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormChangePW"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UPDATE PASSWORD:"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtUpdatePWempID As TextBox
    Friend WithEvents TxtUpdatorNewPW As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtUpdatorRetypePW As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ProgressBarChangePW As ProgressBar
    Friend WithEvents LabelProgressChangePW As Label
    Friend WithEvents BtnUpdatePW As Button
    Friend WithEvents BtnCloseUpdate As Button
    Friend WithEvents CboViewPW As CheckBox
End Class
