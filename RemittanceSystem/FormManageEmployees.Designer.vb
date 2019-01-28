<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormManageEmployees
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormManageEmployees))
        Me.PanelViewEmpInfo = New System.Windows.Forms.Panel()
        Me.TxtManagePosition = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtManageLName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtManageFName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtManageEmpID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelManageEmpTool = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnManageDeleteEmployee = New System.Windows.Forms.Button()
        Me.BtnManageUpdateEmp = New System.Windows.Forms.Button()
        Me.BtnManageEmpSearch = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelViewEmpInfo.SuspendLayout()
        Me.PanelManageEmpTool.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelViewEmpInfo
        '
        Me.PanelViewEmpInfo.Controls.Add(Me.TxtManagePosition)
        Me.PanelViewEmpInfo.Controls.Add(Me.Label4)
        Me.PanelViewEmpInfo.Controls.Add(Me.TxtManageLName)
        Me.PanelViewEmpInfo.Controls.Add(Me.Label3)
        Me.PanelViewEmpInfo.Controls.Add(Me.TxtManageFName)
        Me.PanelViewEmpInfo.Controls.Add(Me.Label2)
        Me.PanelViewEmpInfo.Controls.Add(Me.TxtManageEmpID)
        Me.PanelViewEmpInfo.Controls.Add(Me.Label1)
        Me.PanelViewEmpInfo.Location = New System.Drawing.Point(224, 12)
        Me.PanelViewEmpInfo.Name = "PanelViewEmpInfo"
        Me.PanelViewEmpInfo.Size = New System.Drawing.Size(405, 273)
        Me.PanelViewEmpInfo.TabIndex = 0
        '
        'TxtManagePosition
        '
        Me.TxtManagePosition.Location = New System.Drawing.Point(168, 191)
        Me.TxtManagePosition.Name = "TxtManagePosition"
        Me.TxtManagePosition.Size = New System.Drawing.Size(187, 20)
        Me.TxtManagePosition.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Position:"
        '
        'TxtManageLName
        '
        Me.TxtManageLName.Location = New System.Drawing.Point(168, 138)
        Me.TxtManageLName.Name = "TxtManageLName"
        Me.TxtManageLName.Size = New System.Drawing.Size(187, 20)
        Me.TxtManageLName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Last Name:"
        '
        'TxtManageFName
        '
        Me.TxtManageFName.Location = New System.Drawing.Point(168, 92)
        Me.TxtManageFName.Name = "TxtManageFName"
        Me.TxtManageFName.Size = New System.Drawing.Size(187, 20)
        Me.TxtManageFName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name:"
        '
        'TxtManageEmpID
        '
        Me.TxtManageEmpID.Location = New System.Drawing.Point(168, 42)
        Me.TxtManageEmpID.Name = "TxtManageEmpID"
        Me.TxtManageEmpID.Size = New System.Drawing.Size(100, 20)
        Me.TxtManageEmpID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee ID:"
        '
        'PanelManageEmpTool
        '
        Me.PanelManageEmpTool.Controls.Add(Me.Button1)
        Me.PanelManageEmpTool.Controls.Add(Me.Label5)
        Me.PanelManageEmpTool.Controls.Add(Me.BtnManageDeleteEmployee)
        Me.PanelManageEmpTool.Controls.Add(Me.BtnManageUpdateEmp)
        Me.PanelManageEmpTool.Controls.Add(Me.BtnManageEmpSearch)
        Me.PanelManageEmpTool.Location = New System.Drawing.Point(12, 12)
        Me.PanelManageEmpTool.Name = "PanelManageEmpTool"
        Me.PanelManageEmpTool.Size = New System.Drawing.Size(206, 273)
        Me.PanelManageEmpTool.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "MANAGEMENT TOOLS"
        '
        'BtnManageDeleteEmployee
        '
        Me.BtnManageDeleteEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnManageDeleteEmployee.Image = CType(resources.GetObject("BtnManageDeleteEmployee.Image"), System.Drawing.Image)
        Me.BtnManageDeleteEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnManageDeleteEmployee.Location = New System.Drawing.Point(11, 176)
        Me.BtnManageDeleteEmployee.Name = "BtnManageDeleteEmployee"
        Me.BtnManageDeleteEmployee.Size = New System.Drawing.Size(177, 47)
        Me.BtnManageDeleteEmployee.TabIndex = 2
        Me.BtnManageDeleteEmployee.Text = "DELETE EMPLOYEE"
        Me.BtnManageDeleteEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnManageDeleteEmployee.UseVisualStyleBackColor = True
        '
        'BtnManageUpdateEmp
        '
        Me.BtnManageUpdateEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnManageUpdateEmp.Image = CType(resources.GetObject("BtnManageUpdateEmp.Image"), System.Drawing.Image)
        Me.BtnManageUpdateEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnManageUpdateEmp.Location = New System.Drawing.Point(11, 108)
        Me.BtnManageUpdateEmp.Name = "BtnManageUpdateEmp"
        Me.BtnManageUpdateEmp.Size = New System.Drawing.Size(177, 47)
        Me.BtnManageUpdateEmp.TabIndex = 1
        Me.BtnManageUpdateEmp.Text = "UPDATE EMPLOYEE"
        Me.BtnManageUpdateEmp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnManageUpdateEmp.UseVisualStyleBackColor = True
        '
        'BtnManageEmpSearch
        '
        Me.BtnManageEmpSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnManageEmpSearch.Image = CType(resources.GetObject("BtnManageEmpSearch.Image"), System.Drawing.Image)
        Me.BtnManageEmpSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnManageEmpSearch.Location = New System.Drawing.Point(11, 42)
        Me.BtnManageEmpSearch.Name = "BtnManageEmpSearch"
        Me.BtnManageEmpSearch.Size = New System.Drawing.Size(177, 47)
        Me.BtnManageEmpSearch.TabIndex = 0
        Me.BtnManageEmpSearch.Text = "SEARCH EMPLOYEE"
        Me.BtnManageEmpSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnManageEmpSearch.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Maroon
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(11, 232)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 38)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "LOG OUT"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormManageEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 302)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelManageEmpTool)
        Me.Controls.Add(Me.PanelViewEmpInfo)
        Me.Name = "FormManageEmployees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EMPLOYEE RECORD MANAGEMENT"
        Me.PanelViewEmpInfo.ResumeLayout(False)
        Me.PanelViewEmpInfo.PerformLayout()
        Me.PanelManageEmpTool.ResumeLayout(False)
        Me.PanelManageEmpTool.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelViewEmpInfo As Panel
    Friend WithEvents TxtManagePosition As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtManageLName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtManageFName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtManageEmpID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelManageEmpTool As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnManageDeleteEmployee As Button
    Friend WithEvents BtnManageUpdateEmp As Button
    Friend WithEvents BtnManageEmpSearch As Button
    Friend WithEvents Button1 As Button
End Class
