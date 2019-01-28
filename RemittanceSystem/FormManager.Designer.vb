<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormManager
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormManager))
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageEmployee = New System.Windows.Forms.TabPage()
        Me.BtnAdminManageEmp = New System.Windows.Forms.Button()
        Me.BtnShowFormUpdatePW = New System.Windows.Forms.Button()
        Me.LblCount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DgvUsers = New System.Windows.Forms.DataGridView()
        Me.BtnAddUser = New System.Windows.Forms.Button()
        Me.TabPageVStatus = New System.Windows.Forms.TabPage()
        Me.DgvStatus = New System.Windows.Forms.DataGridView()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.CboCategory = New System.Windows.Forms.ComboBox()
        Me.PanelStatus = New System.Windows.Forms.Panel()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.RadExpired = New System.Windows.Forms.RadioButton()
        Me.RadNotClaimed = New System.Windows.Forms.RadioButton()
        Me.RadClaimed = New System.Windows.Forms.RadioButton()
        Me.PanelDateStat = New System.Windows.Forms.Panel()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.Txtdtp2Picker = New System.Windows.Forms.TextBox()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.Txtdtp1Picker = New System.Windows.Forms.TextBox()
        Me.TextDTGpicker = New System.Windows.Forms.TextBox()
        Me.dtpStat2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpStat1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.RadSpecifyDate = New System.Windows.Forms.RadioButton()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.RadPerMonth = New System.Windows.Forms.RadioButton()
        Me.RadToday = New System.Windows.Forms.RadioButton()
        Me.PanelStatNothing = New System.Windows.Forms.Panel()
        Me.PanelEmpId = New System.Windows.Forms.Panel()
        Me.TvEmpIDStat = New System.Windows.Forms.TextBox()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.PanelRefNo = New System.Windows.Forms.Panel()
        Me.TvRefno = New System.Windows.Forms.TextBox()
        Me.LabelinputRefNo = New System.Windows.Forms.Label()
        Me.TabPageSender = New System.Windows.Forms.TabPage()
        Me.PanelSenderInfo = New System.Windows.Forms.Panel()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.TxtdtpSenderHandler2 = New System.Windows.Forms.TextBox()
        Me.TxtdtpSenderHandler1 = New System.Windows.Forms.TextBox()
        Me.dtpSenderMonthly2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpSenderMonthly1 = New System.Windows.Forms.DateTimePicker()
        Me.TvSenderDateholder = New System.Windows.Forms.TextBox()
        Me.dtpSenderDate = New System.Windows.Forms.DateTimePicker()
        Me.RadSenderSpecifyDate = New System.Windows.Forms.RadioButton()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.RadSenderPerMonth = New System.Windows.Forms.RadioButton()
        Me.RadSenderToday = New System.Windows.Forms.RadioButton()
        Me.LabelRevenueAmount = New System.Windows.Forms.Label()
        Me.LabelRevenue = New System.Windows.Forms.Label()
        Me.TvSenderRefNo = New System.Windows.Forms.TextBox()
        Me.LabelSenderRefNo = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.CboSenderCategory = New System.Windows.Forms.ComboBox()
        Me.DgvSenderInfo = New System.Windows.Forms.DataGridView()
        Me.TabPageBeneficiary = New System.Windows.Forms.TabPage()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.CboBeneCategory = New System.Windows.Forms.ComboBox()
        Me.dtgBeneficiary = New System.Windows.Forms.DataGridView()
        Me.PanelBeneNothing = New System.Windows.Forms.Panel()
        Me.PanelBeneCorrespondent = New System.Windows.Forms.Panel()
        Me.LabelBeneCorres = New System.Windows.Forms.Label()
        Me.CboBeneCorrespondent = New System.Windows.Forms.ComboBox()
        Me.PanelBeneRefNo = New System.Windows.Forms.Panel()
        Me.LabelBeneficiaryRefNo = New System.Windows.Forms.Label()
        Me.TvBeneRefNo = New System.Windows.Forms.TextBox()
        Me.PanelHomeTools = New System.Windows.Forms.Panel()
        Me.BtnViewDBoard = New System.Windows.Forms.Button()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.LblUserName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblEmpID = New System.Windows.Forms.Label()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnPrintViewAdminStat = New System.Windows.Forms.Button()
        Me.BtnPrintAdminStatus = New System.Windows.Forms.Button()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.BtnSearchBeneficiary = New System.Windows.Forms.Button()
        Me.BtnSearchStat = New System.Windows.Forms.Button()
        Me.BtnManageCustomers = New System.Windows.Forms.Button()
        Me.BtnSearchSender = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Lbldate = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.TreeViewAdmin = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.BtnAdminTool = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPageEmployee.SuspendLayout()
        CType(Me.DgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageVStatus.SuspendLayout()
        CType(Me.DgvStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelStatus.SuspendLayout()
        Me.PanelDateStat.SuspendLayout()
        Me.PanelEmpId.SuspendLayout()
        Me.PanelRefNo.SuspendLayout()
        Me.TabPageSender.SuspendLayout()
        Me.PanelSenderInfo.SuspendLayout()
        CType(Me.DgvSenderInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageBeneficiary.SuspendLayout()
        CType(Me.dtgBeneficiary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBeneCorrespondent.SuspendLayout()
        Me.PanelBeneRefNo.SuspendLayout()
        Me.PanelHomeTools.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Location = New System.Drawing.Point(198, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(780, 565)
        Me.Panel1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageEmployee)
        Me.TabControl1.Controls.Add(Me.TabPageVStatus)
        Me.TabControl1.Controls.Add(Me.TabPageSender)
        Me.TabControl1.Controls.Add(Me.TabPageBeneficiary)
        Me.TabControl1.ItemSize = New System.Drawing.Size(200, 30)
        Me.TabControl1.Location = New System.Drawing.Point(1, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(763, 565)
        Me.TabControl1.TabIndex = 1
        '
        'TabPageEmployee
        '
        Me.TabPageEmployee.Controls.Add(Me.BtnAdminManageEmp)
        Me.TabPageEmployee.Controls.Add(Me.BtnShowFormUpdatePW)
        Me.TabPageEmployee.Controls.Add(Me.LblCount)
        Me.TabPageEmployee.Controls.Add(Me.Label3)
        Me.TabPageEmployee.Controls.Add(Me.DgvUsers)
        Me.TabPageEmployee.Controls.Add(Me.BtnAddUser)
        Me.TabPageEmployee.Location = New System.Drawing.Point(4, 34)
        Me.TabPageEmployee.Name = "TabPageEmployee"
        Me.TabPageEmployee.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageEmployee.Size = New System.Drawing.Size(755, 527)
        Me.TabPageEmployee.TabIndex = 0
        Me.TabPageEmployee.Text = "EMPLOYEES"
        Me.TabPageEmployee.UseVisualStyleBackColor = True
        '
        'BtnAdminManageEmp
        '
        Me.BtnAdminManageEmp.BackColor = System.Drawing.Color.LightGray
        Me.BtnAdminManageEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdminManageEmp.Image = CType(resources.GetObject("BtnAdminManageEmp.Image"), System.Drawing.Image)
        Me.BtnAdminManageEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdminManageEmp.Location = New System.Drawing.Point(46, 438)
        Me.BtnAdminManageEmp.Name = "BtnAdminManageEmp"
        Me.BtnAdminManageEmp.Size = New System.Drawing.Size(295, 34)
        Me.BtnAdminManageEmp.TabIndex = 13
        Me.BtnAdminManageEmp.Text = "VIEW AND MANAGE EMPLOYEE DATA"
        Me.BtnAdminManageEmp.UseVisualStyleBackColor = False
        '
        'BtnShowFormUpdatePW
        '
        Me.BtnShowFormUpdatePW.BackColor = System.Drawing.Color.LightGray
        Me.BtnShowFormUpdatePW.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShowFormUpdatePW.Image = CType(resources.GetObject("BtnShowFormUpdatePW.Image"), System.Drawing.Image)
        Me.BtnShowFormUpdatePW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnShowFormUpdatePW.Location = New System.Drawing.Point(167, 392)
        Me.BtnShowFormUpdatePW.Name = "BtnShowFormUpdatePW"
        Me.BtnShowFormUpdatePW.Size = New System.Drawing.Size(174, 34)
        Me.BtnShowFormUpdatePW.TabIndex = 12
        Me.BtnShowFormUpdatePW.Text = "UPDATE PASSWORD"
        Me.BtnShowFormUpdatePW.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnShowFormUpdatePW.UseVisualStyleBackColor = False
        '
        'LblCount
        '
        Me.LblCount.AutoSize = True
        Me.LblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCount.Location = New System.Drawing.Point(612, 336)
        Me.LblCount.Name = "LblCount"
        Me.LblCount.Size = New System.Drawing.Size(19, 20)
        Me.LblCount.TabIndex = 3
        Me.LblCount.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(444, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total No. Of Users:"
        '
        'DgvUsers
        '
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvUsers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.DgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvUsers.DefaultCellStyle = DataGridViewCellStyle22
        Me.DgvUsers.Location = New System.Drawing.Point(29, 68)
        Me.DgvUsers.Name = "DgvUsers"
        Me.DgvUsers.Size = New System.Drawing.Size(700, 252)
        Me.DgvUsers.TabIndex = 0
        '
        'BtnAddUser
        '
        Me.BtnAddUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddUser.Image = CType(resources.GetObject("BtnAddUser.Image"), System.Drawing.Image)
        Me.BtnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddUser.Location = New System.Drawing.Point(46, 392)
        Me.BtnAddUser.Name = "BtnAddUser"
        Me.BtnAddUser.Size = New System.Drawing.Size(111, 34)
        Me.BtnAddUser.TabIndex = 1
        Me.BtnAddUser.Text = "ADD USER"
        Me.BtnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddUser.UseVisualStyleBackColor = True
        '
        'TabPageVStatus
        '
        Me.TabPageVStatus.Controls.Add(Me.DgvStatus)
        Me.TabPageVStatus.Controls.Add(Me.Label65)
        Me.TabPageVStatus.Controls.Add(Me.CboCategory)
        Me.TabPageVStatus.Controls.Add(Me.PanelStatus)
        Me.TabPageVStatus.Controls.Add(Me.PanelDateStat)
        Me.TabPageVStatus.Controls.Add(Me.PanelStatNothing)
        Me.TabPageVStatus.Controls.Add(Me.PanelEmpId)
        Me.TabPageVStatus.Controls.Add(Me.PanelRefNo)
        Me.TabPageVStatus.Location = New System.Drawing.Point(4, 34)
        Me.TabPageVStatus.Name = "TabPageVStatus"
        Me.TabPageVStatus.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageVStatus.Size = New System.Drawing.Size(755, 527)
        Me.TabPageVStatus.TabIndex = 1
        Me.TabPageVStatus.Text = "VIEW STATUS"
        Me.TabPageVStatus.UseVisualStyleBackColor = True
        '
        'DgvStatus
        '
        Me.DgvStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvStatus.Location = New System.Drawing.Point(27, 206)
        Me.DgvStatus.Name = "DgvStatus"
        Me.DgvStatus.Size = New System.Drawing.Size(705, 264)
        Me.DgvStatus.TabIndex = 7
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(24, 24)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(69, 13)
        Me.Label65.TabIndex = 5
        Me.Label65.Text = "CATEGORY:"
        '
        'CboCategory
        '
        Me.CboCategory.FormattingEnabled = True
        Me.CboCategory.Items.AddRange(New Object() {"STATUS", "DATE", "REFERENCE NUMBER", "BY EMPLOYEE ID"})
        Me.CboCategory.Location = New System.Drawing.Point(27, 40)
        Me.CboCategory.Name = "CboCategory"
        Me.CboCategory.Size = New System.Drawing.Size(157, 21)
        Me.CboCategory.TabIndex = 4
        Me.CboCategory.Text = "SEARCH FOR CATEGORY"
        '
        'PanelStatus
        '
        Me.PanelStatus.Controls.Add(Me.Label67)
        Me.PanelStatus.Controls.Add(Me.RadExpired)
        Me.PanelStatus.Controls.Add(Me.RadNotClaimed)
        Me.PanelStatus.Controls.Add(Me.RadClaimed)
        Me.PanelStatus.Location = New System.Drawing.Point(268, 29)
        Me.PanelStatus.Name = "PanelStatus"
        Me.PanelStatus.Size = New System.Drawing.Size(452, 155)
        Me.PanelStatus.TabIndex = 6
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(12, 7)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(111, 16)
        Me.Label67.TabIndex = 7
        Me.Label67.Text = "CHOOSE ONE:"
        '
        'RadExpired
        '
        Me.RadExpired.AutoSize = True
        Me.RadExpired.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadExpired.Location = New System.Drawing.Point(343, 39)
        Me.RadExpired.Name = "RadExpired"
        Me.RadExpired.Size = New System.Drawing.Size(72, 20)
        Me.RadExpired.TabIndex = 2
        Me.RadExpired.TabStop = True
        Me.RadExpired.Text = "Expired"
        Me.RadExpired.UseVisualStyleBackColor = True
        '
        'RadNotClaimed
        '
        Me.RadNotClaimed.AutoSize = True
        Me.RadNotClaimed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadNotClaimed.Location = New System.Drawing.Point(177, 37)
        Me.RadNotClaimed.Name = "RadNotClaimed"
        Me.RadNotClaimed.Size = New System.Drawing.Size(100, 20)
        Me.RadNotClaimed.TabIndex = 1
        Me.RadNotClaimed.TabStop = True
        Me.RadNotClaimed.Text = "Not Claimed"
        Me.RadNotClaimed.UseVisualStyleBackColor = True
        '
        'RadClaimed
        '
        Me.RadClaimed.AutoSize = True
        Me.RadClaimed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadClaimed.Location = New System.Drawing.Point(30, 39)
        Me.RadClaimed.Name = "RadClaimed"
        Me.RadClaimed.Size = New System.Drawing.Size(76, 20)
        Me.RadClaimed.TabIndex = 0
        Me.RadClaimed.TabStop = True
        Me.RadClaimed.Text = "Claimed"
        Me.RadClaimed.UseVisualStyleBackColor = True
        '
        'PanelDateStat
        '
        Me.PanelDateStat.Controls.Add(Me.Label84)
        Me.PanelDateStat.Controls.Add(Me.Txtdtp2Picker)
        Me.PanelDateStat.Controls.Add(Me.Label85)
        Me.PanelDateStat.Controls.Add(Me.Txtdtp1Picker)
        Me.PanelDateStat.Controls.Add(Me.TextDTGpicker)
        Me.PanelDateStat.Controls.Add(Me.dtpStat2)
        Me.PanelDateStat.Controls.Add(Me.dtpStat1)
        Me.PanelDateStat.Controls.Add(Me.DateTimePicker1)
        Me.PanelDateStat.Controls.Add(Me.RadSpecifyDate)
        Me.PanelDateStat.Controls.Add(Me.Label69)
        Me.PanelDateStat.Controls.Add(Me.RadPerMonth)
        Me.PanelDateStat.Controls.Add(Me.RadToday)
        Me.PanelDateStat.Location = New System.Drawing.Point(268, 29)
        Me.PanelDateStat.Name = "PanelDateStat"
        Me.PanelDateStat.Size = New System.Drawing.Size(452, 155)
        Me.PanelDateStat.TabIndex = 8
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.Location = New System.Drawing.Point(12, 107)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(28, 13)
        Me.Label84.TabIndex = 23
        Me.Label84.Text = "TO:"
        '
        'Txtdtp2Picker
        '
        Me.Txtdtp2Picker.AutoCompleteCustomSource.AddRange(New String() {"JANUARY", "FEBUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.Txtdtp2Picker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Txtdtp2Picker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Txtdtp2Picker.Location = New System.Drawing.Point(184, 109)
        Me.Txtdtp2Picker.Name = "Txtdtp2Picker"
        Me.Txtdtp2Picker.Size = New System.Drawing.Size(39, 20)
        Me.Txtdtp2Picker.TabIndex = 13
        Me.Txtdtp2Picker.Visible = False
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.Location = New System.Drawing.Point(4, 76)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(46, 13)
        Me.Label85.TabIndex = 22
        Me.Label85.Text = "FROM:"
        '
        'Txtdtp1Picker
        '
        Me.Txtdtp1Picker.AutoCompleteCustomSource.AddRange(New String() {"JANUARY", "FEBUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.Txtdtp1Picker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Txtdtp1Picker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Txtdtp1Picker.Location = New System.Drawing.Point(183, 73)
        Me.Txtdtp1Picker.Name = "Txtdtp1Picker"
        Me.Txtdtp1Picker.Size = New System.Drawing.Size(39, 20)
        Me.Txtdtp1Picker.TabIndex = 14
        Me.Txtdtp1Picker.Visible = False
        '
        'TextDTGpicker
        '
        Me.TextDTGpicker.AutoCompleteCustomSource.AddRange(New String() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.TextDTGpicker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextDTGpicker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextDTGpicker.Location = New System.Drawing.Point(275, 108)
        Me.TextDTGpicker.Name = "TextDTGpicker"
        Me.TextDTGpicker.Size = New System.Drawing.Size(20, 20)
        Me.TextDTGpicker.TabIndex = 10
        Me.TextDTGpicker.Visible = False
        '
        'dtpStat2
        '
        Me.dtpStat2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStat2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStat2.Location = New System.Drawing.Point(56, 107)
        Me.dtpStat2.Name = "dtpStat2"
        Me.dtpStat2.Size = New System.Drawing.Size(122, 22)
        Me.dtpStat2.TabIndex = 11
        '
        'dtpStat1
        '
        Me.dtpStat1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStat1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStat1.Location = New System.Drawing.Point(56, 71)
        Me.dtpStat1.Name = "dtpStat1"
        Me.dtpStat1.Size = New System.Drawing.Size(122, 22)
        Me.dtpStat1.TabIndex = 10
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(301, 108)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(122, 22)
        Me.DateTimePicker1.TabIndex = 3
        '
        'RadSpecifyDate
        '
        Me.RadSpecifyDate.AutoSize = True
        Me.RadSpecifyDate.Enabled = False
        Me.RadSpecifyDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadSpecifyDate.Location = New System.Drawing.Point(305, 85)
        Me.RadSpecifyDate.Name = "RadSpecifyDate"
        Me.RadSpecifyDate.Size = New System.Drawing.Size(103, 20)
        Me.RadSpecifyDate.TabIndex = 9
        Me.RadSpecifyDate.TabStop = True
        Me.RadSpecifyDate.Text = "Specify Date"
        Me.RadSpecifyDate.UseVisualStyleBackColor = True
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.Location = New System.Drawing.Point(12, 7)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(136, 16)
        Me.Label69.TabIndex = 7
        Me.Label69.Text = "CHOOSE OPTION:"
        '
        'RadPerMonth
        '
        Me.RadPerMonth.AutoSize = True
        Me.RadPerMonth.Enabled = False
        Me.RadPerMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadPerMonth.Location = New System.Drawing.Point(19, 45)
        Me.RadPerMonth.Name = "RadPerMonth"
        Me.RadPerMonth.Size = New System.Drawing.Size(86, 20)
        Me.RadPerMonth.TabIndex = 1
        Me.RadPerMonth.TabStop = True
        Me.RadPerMonth.Text = "Per Month"
        Me.RadPerMonth.UseVisualStyleBackColor = True
        '
        'RadToday
        '
        Me.RadToday.AutoSize = True
        Me.RadToday.Enabled = False
        Me.RadToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadToday.Location = New System.Drawing.Point(305, 45)
        Me.RadToday.Name = "RadToday"
        Me.RadToday.Size = New System.Drawing.Size(66, 20)
        Me.RadToday.TabIndex = 0
        Me.RadToday.TabStop = True
        Me.RadToday.Text = "Today"
        Me.RadToday.UseVisualStyleBackColor = True
        '
        'PanelStatNothing
        '
        Me.PanelStatNothing.Location = New System.Drawing.Point(27, 76)
        Me.PanelStatNothing.Name = "PanelStatNothing"
        Me.PanelStatNothing.Size = New System.Drawing.Size(200, 100)
        Me.PanelStatNothing.TabIndex = 19
        '
        'PanelEmpId
        '
        Me.PanelEmpId.Controls.Add(Me.TvEmpIDStat)
        Me.PanelEmpId.Controls.Add(Me.Label87)
        Me.PanelEmpId.Location = New System.Drawing.Point(27, 76)
        Me.PanelEmpId.Name = "PanelEmpId"
        Me.PanelEmpId.Size = New System.Drawing.Size(200, 100)
        Me.PanelEmpId.TabIndex = 10
        '
        'TvEmpIDStat
        '
        Me.TvEmpIDStat.AutoCompleteCustomSource.AddRange(New String() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.TvEmpIDStat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TvEmpIDStat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TvEmpIDStat.Location = New System.Drawing.Point(16, 33)
        Me.TvEmpIDStat.Name = "TvEmpIDStat"
        Me.TvEmpIDStat.Size = New System.Drawing.Size(162, 20)
        Me.TvEmpIDStat.TabIndex = 18
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.Location = New System.Drawing.Point(13, 13)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(138, 16)
        Me.Label87.TabIndex = 17
        Me.Label87.Text = "Input Employee ID:"
        '
        'PanelRefNo
        '
        Me.PanelRefNo.Controls.Add(Me.TvRefno)
        Me.PanelRefNo.Controls.Add(Me.LabelinputRefNo)
        Me.PanelRefNo.Location = New System.Drawing.Point(27, 76)
        Me.PanelRefNo.Name = "PanelRefNo"
        Me.PanelRefNo.Size = New System.Drawing.Size(200, 100)
        Me.PanelRefNo.TabIndex = 9
        '
        'TvRefno
        '
        Me.TvRefno.AutoCompleteCustomSource.AddRange(New String() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.TvRefno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TvRefno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TvRefno.Location = New System.Drawing.Point(16, 33)
        Me.TvRefno.Name = "TvRefno"
        Me.TvRefno.Size = New System.Drawing.Size(162, 20)
        Me.TvRefno.TabIndex = 12
        '
        'LabelinputRefNo
        '
        Me.LabelinputRefNo.AutoSize = True
        Me.LabelinputRefNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelinputRefNo.Location = New System.Drawing.Point(13, 13)
        Me.LabelinputRefNo.Name = "LabelinputRefNo"
        Me.LabelinputRefNo.Size = New System.Drawing.Size(170, 16)
        Me.LabelinputRefNo.TabIndex = 11
        Me.LabelinputRefNo.Text = "Input reference number:"
        '
        'TabPageSender
        '
        Me.TabPageSender.Controls.Add(Me.PanelSenderInfo)
        Me.TabPageSender.Controls.Add(Me.LabelRevenueAmount)
        Me.TabPageSender.Controls.Add(Me.LabelRevenue)
        Me.TabPageSender.Controls.Add(Me.TvSenderRefNo)
        Me.TabPageSender.Controls.Add(Me.LabelSenderRefNo)
        Me.TabPageSender.Controls.Add(Me.Label79)
        Me.TabPageSender.Controls.Add(Me.CboSenderCategory)
        Me.TabPageSender.Controls.Add(Me.DgvSenderInfo)
        Me.TabPageSender.Location = New System.Drawing.Point(4, 34)
        Me.TabPageSender.Name = "TabPageSender"
        Me.TabPageSender.Size = New System.Drawing.Size(755, 527)
        Me.TabPageSender.TabIndex = 2
        Me.TabPageSender.Text = "SENDER INFOS"
        Me.TabPageSender.UseVisualStyleBackColor = True
        '
        'PanelSenderInfo
        '
        Me.PanelSenderInfo.Controls.Add(Me.Label83)
        Me.PanelSenderInfo.Controls.Add(Me.Label82)
        Me.PanelSenderInfo.Controls.Add(Me.TxtdtpSenderHandler2)
        Me.PanelSenderInfo.Controls.Add(Me.TxtdtpSenderHandler1)
        Me.PanelSenderInfo.Controls.Add(Me.dtpSenderMonthly2)
        Me.PanelSenderInfo.Controls.Add(Me.dtpSenderMonthly1)
        Me.PanelSenderInfo.Controls.Add(Me.TvSenderDateholder)
        Me.PanelSenderInfo.Controls.Add(Me.dtpSenderDate)
        Me.PanelSenderInfo.Controls.Add(Me.RadSenderSpecifyDate)
        Me.PanelSenderInfo.Controls.Add(Me.Label77)
        Me.PanelSenderInfo.Controls.Add(Me.RadSenderPerMonth)
        Me.PanelSenderInfo.Controls.Add(Me.RadSenderToday)
        Me.PanelSenderInfo.Enabled = False
        Me.PanelSenderInfo.Location = New System.Drawing.Point(282, 20)
        Me.PanelSenderInfo.Name = "PanelSenderInfo"
        Me.PanelSenderInfo.Size = New System.Drawing.Size(452, 143)
        Me.PanelSenderInfo.TabIndex = 19
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.Location = New System.Drawing.Point(21, 99)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(28, 13)
        Me.Label83.TabIndex = 21
        Me.Label83.Text = "TO:"
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.Location = New System.Drawing.Point(21, 68)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(46, 13)
        Me.Label82.TabIndex = 20
        Me.Label82.Text = "FROM:"
        '
        'TxtdtpSenderHandler2
        '
        Me.TxtdtpSenderHandler2.AutoCompleteCustomSource.AddRange(New String() {"JANUARY", "FEBUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.TxtdtpSenderHandler2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TxtdtpSenderHandler2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtdtpSenderHandler2.Location = New System.Drawing.Point(202, 96)
        Me.TxtdtpSenderHandler2.Name = "TxtdtpSenderHandler2"
        Me.TxtdtpSenderHandler2.Size = New System.Drawing.Size(32, 20)
        Me.TxtdtpSenderHandler2.TabIndex = 14
        Me.TxtdtpSenderHandler2.Visible = False
        '
        'TxtdtpSenderHandler1
        '
        Me.TxtdtpSenderHandler1.AutoCompleteCustomSource.AddRange(New String() {"JANUARY", "FEBUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.TxtdtpSenderHandler1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TxtdtpSenderHandler1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtdtpSenderHandler1.Location = New System.Drawing.Point(201, 65)
        Me.TxtdtpSenderHandler1.Name = "TxtdtpSenderHandler1"
        Me.TxtdtpSenderHandler1.Size = New System.Drawing.Size(32, 20)
        Me.TxtdtpSenderHandler1.TabIndex = 13
        Me.TxtdtpSenderHandler1.Visible = False
        '
        'dtpSenderMonthly2
        '
        Me.dtpSenderMonthly2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSenderMonthly2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSenderMonthly2.Location = New System.Drawing.Point(73, 96)
        Me.dtpSenderMonthly2.Name = "dtpSenderMonthly2"
        Me.dtpSenderMonthly2.Size = New System.Drawing.Size(122, 22)
        Me.dtpSenderMonthly2.TabIndex = 12
        '
        'dtpSenderMonthly1
        '
        Me.dtpSenderMonthly1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSenderMonthly1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSenderMonthly1.Location = New System.Drawing.Point(73, 65)
        Me.dtpSenderMonthly1.Name = "dtpSenderMonthly1"
        Me.dtpSenderMonthly1.Size = New System.Drawing.Size(122, 22)
        Me.dtpSenderMonthly1.TabIndex = 11
        '
        'TvSenderDateholder
        '
        Me.TvSenderDateholder.AutoCompleteCustomSource.AddRange(New String() {"JANUARY", "FEBUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.TvSenderDateholder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TvSenderDateholder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TvSenderDateholder.Location = New System.Drawing.Point(425, 96)
        Me.TvSenderDateholder.Name = "TvSenderDateholder"
        Me.TvSenderDateholder.Size = New System.Drawing.Size(24, 20)
        Me.TvSenderDateholder.TabIndex = 10
        Me.TvSenderDateholder.Visible = False
        '
        'dtpSenderDate
        '
        Me.dtpSenderDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSenderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSenderDate.Location = New System.Drawing.Point(299, 96)
        Me.dtpSenderDate.Name = "dtpSenderDate"
        Me.dtpSenderDate.Size = New System.Drawing.Size(122, 22)
        Me.dtpSenderDate.TabIndex = 3
        '
        'RadSenderSpecifyDate
        '
        Me.RadSenderSpecifyDate.AutoSize = True
        Me.RadSenderSpecifyDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadSenderSpecifyDate.Location = New System.Drawing.Point(303, 73)
        Me.RadSenderSpecifyDate.Name = "RadSenderSpecifyDate"
        Me.RadSenderSpecifyDate.Size = New System.Drawing.Size(103, 20)
        Me.RadSenderSpecifyDate.TabIndex = 9
        Me.RadSenderSpecifyDate.TabStop = True
        Me.RadSenderSpecifyDate.Text = "Specify Date"
        Me.RadSenderSpecifyDate.UseVisualStyleBackColor = True
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.Location = New System.Drawing.Point(12, 7)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(136, 16)
        Me.Label77.TabIndex = 7
        Me.Label77.Text = "CHOOSE OPTION:"
        '
        'RadSenderPerMonth
        '
        Me.RadSenderPerMonth.AutoSize = True
        Me.RadSenderPerMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadSenderPerMonth.Location = New System.Drawing.Point(13, 37)
        Me.RadSenderPerMonth.Name = "RadSenderPerMonth"
        Me.RadSenderPerMonth.Size = New System.Drawing.Size(86, 20)
        Me.RadSenderPerMonth.TabIndex = 1
        Me.RadSenderPerMonth.TabStop = True
        Me.RadSenderPerMonth.Text = "Per Month"
        Me.RadSenderPerMonth.UseVisualStyleBackColor = True
        '
        'RadSenderToday
        '
        Me.RadSenderToday.AutoSize = True
        Me.RadSenderToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadSenderToday.Location = New System.Drawing.Point(303, 42)
        Me.RadSenderToday.Name = "RadSenderToday"
        Me.RadSenderToday.Size = New System.Drawing.Size(66, 20)
        Me.RadSenderToday.TabIndex = 0
        Me.RadSenderToday.TabStop = True
        Me.RadSenderToday.Text = "Today"
        Me.RadSenderToday.UseVisualStyleBackColor = True
        '
        'LabelRevenueAmount
        '
        Me.LabelRevenueAmount.AutoSize = True
        Me.LabelRevenueAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRevenueAmount.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelRevenueAmount.Location = New System.Drawing.Point(650, 487)
        Me.LabelRevenueAmount.Name = "LabelRevenueAmount"
        Me.LabelRevenueAmount.Size = New System.Drawing.Size(16, 16)
        Me.LabelRevenueAmount.TabIndex = 18
        Me.LabelRevenueAmount.Text = "0"
        '
        'LabelRevenue
        '
        Me.LabelRevenue.AutoSize = True
        Me.LabelRevenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRevenue.Location = New System.Drawing.Point(373, 487)
        Me.LabelRevenue.Name = "LabelRevenue"
        Me.LabelRevenue.Size = New System.Drawing.Size(266, 16)
        Me.LabelRevenue.TabIndex = 17
        Me.LabelRevenue.Text = "TOTAL REVENUE FROM CHARGES: "
        '
        'TvSenderRefNo
        '
        Me.TvSenderRefNo.AutoCompleteCustomSource.AddRange(New String() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.TvSenderRefNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TvSenderRefNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TvSenderRefNo.Location = New System.Drawing.Point(24, 94)
        Me.TvSenderRefNo.Name = "TvSenderRefNo"
        Me.TvSenderRefNo.Size = New System.Drawing.Size(162, 20)
        Me.TvSenderRefNo.TabIndex = 16
        Me.TvSenderRefNo.Visible = False
        '
        'LabelSenderRefNo
        '
        Me.LabelSenderRefNo.AutoSize = True
        Me.LabelSenderRefNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSenderRefNo.Location = New System.Drawing.Point(21, 74)
        Me.LabelSenderRefNo.Name = "LabelSenderRefNo"
        Me.LabelSenderRefNo.Size = New System.Drawing.Size(170, 16)
        Me.LabelSenderRefNo.TabIndex = 15
        Me.LabelSenderRefNo.Text = "Input reference number:"
        Me.LabelSenderRefNo.Visible = False
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Location = New System.Drawing.Point(17, 20)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(69, 13)
        Me.Label79.TabIndex = 14
        Me.Label79.Text = "CATEGORY:"
        '
        'CboSenderCategory
        '
        Me.CboSenderCategory.FormattingEnabled = True
        Me.CboSenderCategory.Items.AddRange(New Object() {"REFERENCE NUMBER", "ISSUE DATE", "TOTAL REVENUE"})
        Me.CboSenderCategory.Location = New System.Drawing.Point(20, 36)
        Me.CboSenderCategory.Name = "CboSenderCategory"
        Me.CboSenderCategory.Size = New System.Drawing.Size(157, 21)
        Me.CboSenderCategory.TabIndex = 13
        Me.CboSenderCategory.Text = "SEARCH FOR CATEGORY"
        '
        'DgvSenderInfo
        '
        Me.DgvSenderInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSenderInfo.Location = New System.Drawing.Point(20, 179)
        Me.DgvSenderInfo.Name = "DgvSenderInfo"
        Me.DgvSenderInfo.Size = New System.Drawing.Size(720, 290)
        Me.DgvSenderInfo.TabIndex = 0
        '
        'TabPageBeneficiary
        '
        Me.TabPageBeneficiary.Controls.Add(Me.Label86)
        Me.TabPageBeneficiary.Controls.Add(Me.CboBeneCategory)
        Me.TabPageBeneficiary.Controls.Add(Me.dtgBeneficiary)
        Me.TabPageBeneficiary.Controls.Add(Me.PanelBeneNothing)
        Me.TabPageBeneficiary.Controls.Add(Me.PanelBeneCorrespondent)
        Me.TabPageBeneficiary.Controls.Add(Me.PanelBeneRefNo)
        Me.TabPageBeneficiary.Location = New System.Drawing.Point(4, 34)
        Me.TabPageBeneficiary.Name = "TabPageBeneficiary"
        Me.TabPageBeneficiary.Size = New System.Drawing.Size(755, 527)
        Me.TabPageBeneficiary.TabIndex = 3
        Me.TabPageBeneficiary.Text = "BENEFICIARY INFOS"
        Me.TabPageBeneficiary.UseVisualStyleBackColor = True
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Location = New System.Drawing.Point(23, 16)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(69, 13)
        Me.Label86.TabIndex = 16
        Me.Label86.Text = "CATEGORY:"
        '
        'CboBeneCategory
        '
        Me.CboBeneCategory.FormattingEnabled = True
        Me.CboBeneCategory.Items.AddRange(New Object() {"REFERENCE NUMBER", "CORRESPONDENT"})
        Me.CboBeneCategory.Location = New System.Drawing.Point(26, 32)
        Me.CboBeneCategory.Name = "CboBeneCategory"
        Me.CboBeneCategory.Size = New System.Drawing.Size(157, 21)
        Me.CboBeneCategory.TabIndex = 15
        Me.CboBeneCategory.Text = "SEARCH FOR CATEGORY"
        '
        'dtgBeneficiary
        '
        Me.dtgBeneficiary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgBeneficiary.Location = New System.Drawing.Point(26, 156)
        Me.dtgBeneficiary.Name = "dtgBeneficiary"
        Me.dtgBeneficiary.Size = New System.Drawing.Size(708, 317)
        Me.dtgBeneficiary.TabIndex = 0
        '
        'PanelBeneNothing
        '
        Me.PanelBeneNothing.Location = New System.Drawing.Point(228, 11)
        Me.PanelBeneNothing.Name = "PanelBeneNothing"
        Me.PanelBeneNothing.Size = New System.Drawing.Size(200, 100)
        Me.PanelBeneNothing.TabIndex = 23
        '
        'PanelBeneCorrespondent
        '
        Me.PanelBeneCorrespondent.Controls.Add(Me.LabelBeneCorres)
        Me.PanelBeneCorrespondent.Controls.Add(Me.CboBeneCorrespondent)
        Me.PanelBeneCorrespondent.Location = New System.Drawing.Point(228, 11)
        Me.PanelBeneCorrespondent.Name = "PanelBeneCorrespondent"
        Me.PanelBeneCorrespondent.Size = New System.Drawing.Size(200, 100)
        Me.PanelBeneCorrespondent.TabIndex = 22
        '
        'LabelBeneCorres
        '
        Me.LabelBeneCorres.AutoSize = True
        Me.LabelBeneCorres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBeneCorres.Location = New System.Drawing.Point(6, 9)
        Me.LabelBeneCorres.Name = "LabelBeneCorres"
        Me.LabelBeneCorres.Size = New System.Drawing.Size(171, 16)
        Me.LabelBeneCorres.TabIndex = 20
        Me.LabelBeneCorres.Text = "Choose Correspondent:"
        '
        'CboBeneCorrespondent
        '
        Me.CboBeneCorrespondent.FormattingEnabled = True
        Me.CboBeneCorrespondent.Items.AddRange(New Object() {"PALAWAN PAWNSHOP", "CEBUANA PAWNSHOP", "WESTERN UNION"})
        Me.CboBeneCorrespondent.Location = New System.Drawing.Point(7, 32)
        Me.CboBeneCorrespondent.Name = "CboBeneCorrespondent"
        Me.CboBeneCorrespondent.Size = New System.Drawing.Size(157, 21)
        Me.CboBeneCorrespondent.TabIndex = 19
        Me.CboBeneCorrespondent.Text = "SEARCH HERE..."
        '
        'PanelBeneRefNo
        '
        Me.PanelBeneRefNo.Controls.Add(Me.LabelBeneficiaryRefNo)
        Me.PanelBeneRefNo.Controls.Add(Me.TvBeneRefNo)
        Me.PanelBeneRefNo.Location = New System.Drawing.Point(228, 11)
        Me.PanelBeneRefNo.Name = "PanelBeneRefNo"
        Me.PanelBeneRefNo.Size = New System.Drawing.Size(200, 100)
        Me.PanelBeneRefNo.TabIndex = 21
        '
        'LabelBeneficiaryRefNo
        '
        Me.LabelBeneficiaryRefNo.AutoSize = True
        Me.LabelBeneficiaryRefNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBeneficiaryRefNo.Location = New System.Drawing.Point(6, 9)
        Me.LabelBeneficiaryRefNo.Name = "LabelBeneficiaryRefNo"
        Me.LabelBeneficiaryRefNo.Size = New System.Drawing.Size(170, 16)
        Me.LabelBeneficiaryRefNo.TabIndex = 17
        Me.LabelBeneficiaryRefNo.Text = "Input reference number:"
        '
        'TvBeneRefNo
        '
        Me.TvBeneRefNo.AutoCompleteCustomSource.AddRange(New String() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.TvBeneRefNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TvBeneRefNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TvBeneRefNo.Location = New System.Drawing.Point(9, 29)
        Me.TvBeneRefNo.Name = "TvBeneRefNo"
        Me.TvBeneRefNo.Size = New System.Drawing.Size(162, 20)
        Me.TvBeneRefNo.TabIndex = 18
        '
        'PanelHomeTools
        '
        Me.PanelHomeTools.BackColor = System.Drawing.Color.Teal
        Me.PanelHomeTools.Controls.Add(Me.BtnPrintViewAdminStat)
        Me.PanelHomeTools.Controls.Add(Me.BtnPrintAdminStatus)
        Me.PanelHomeTools.Controls.Add(Me.Label60)
        Me.PanelHomeTools.Controls.Add(Me.BtnSearchBeneficiary)
        Me.PanelHomeTools.Controls.Add(Me.BtnSearchStat)
        Me.PanelHomeTools.Controls.Add(Me.BtnManageCustomers)
        Me.PanelHomeTools.Controls.Add(Me.BtnSearchSender)
        Me.PanelHomeTools.Location = New System.Drawing.Point(0, 53)
        Me.PanelHomeTools.Name = "PanelHomeTools"
        Me.PanelHomeTools.Size = New System.Drawing.Size(197, 586)
        Me.PanelHomeTools.TabIndex = 5
        '
        'BtnViewDBoard
        '
        Me.BtnViewDBoard.BackColor = System.Drawing.Color.Transparent
        Me.BtnViewDBoard.FlatAppearance.BorderSize = 0
        Me.BtnViewDBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnViewDBoard.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnViewDBoard.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnViewDBoard.Image = CType(resources.GetObject("BtnViewDBoard.Image"), System.Drawing.Image)
        Me.BtnViewDBoard.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnViewDBoard.Location = New System.Drawing.Point(674, 8)
        Me.BtnViewDBoard.Name = "BtnViewDBoard"
        Me.BtnViewDBoard.Size = New System.Drawing.Size(191, 66)
        Me.BtnViewDBoard.TabIndex = 17
        Me.BtnViewDBoard.Text = "VIEW DASHBOARD"
        Me.BtnViewDBoard.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnViewDBoard.UseVisualStyleBackColor = False
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelName.Location = New System.Drawing.Point(27, 7)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(90, 16)
        Me.LabelName.TabIndex = 16
        Me.LabelName.Text = "User Name:"
        '
        'LblUserName
        '
        Me.LblUserName.AutoSize = True
        Me.LblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUserName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblUserName.Location = New System.Drawing.Point(144, 7)
        Me.LblUserName.Name = "LblUserName"
        Me.LblUserName.Size = New System.Drawing.Size(16, 16)
        Me.LblUserName.TabIndex = 13
        Me.LblUserName.Text = "--"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(27, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Employee ID:"
        '
        'LblEmpID
        '
        Me.LblEmpID.AutoSize = True
        Me.LblEmpID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmpID.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblEmpID.Location = New System.Drawing.Point(144, 40)
        Me.LblEmpID.Name = "LblEmpID"
        Me.LblEmpID.Size = New System.Drawing.Size(16, 16)
        Me.LblEmpID.TabIndex = 15
        Me.LblEmpID.Text = "--"
        '
        'BtnLogout
        '
        Me.BtnLogout.BackColor = System.Drawing.Color.Transparent
        Me.BtnLogout.FlatAppearance.BorderSize = 0
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnLogout.Image = CType(resources.GetObject("BtnLogout.Image"), System.Drawing.Image)
        Me.BtnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLogout.Location = New System.Drawing.Point(6, 19)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(182, 51)
        Me.BtnLogout.TabIndex = 12
        Me.BtnLogout.Text = "     LOG OUT"
        Me.BtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'BtnPrintViewAdminStat
        '
        Me.BtnPrintViewAdminStat.BackColor = System.Drawing.Color.Transparent
        Me.BtnPrintViewAdminStat.FlatAppearance.BorderSize = 0
        Me.BtnPrintViewAdminStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrintViewAdminStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintViewAdminStat.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnPrintViewAdminStat.Image = CType(resources.GetObject("BtnPrintViewAdminStat.Image"), System.Drawing.Image)
        Me.BtnPrintViewAdminStat.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPrintViewAdminStat.Location = New System.Drawing.Point(5, 360)
        Me.BtnPrintViewAdminStat.Name = "BtnPrintViewAdminStat"
        Me.BtnPrintViewAdminStat.Size = New System.Drawing.Size(187, 66)
        Me.BtnPrintViewAdminStat.TabIndex = 11
        Me.BtnPrintViewAdminStat.Text = "PRINT PREVIEW"
        Me.BtnPrintViewAdminStat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPrintViewAdminStat.UseVisualStyleBackColor = False
        '
        'BtnPrintAdminStatus
        '
        Me.BtnPrintAdminStatus.BackColor = System.Drawing.Color.Transparent
        Me.BtnPrintAdminStatus.FlatAppearance.BorderSize = 0
        Me.BtnPrintAdminStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrintAdminStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintAdminStatus.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnPrintAdminStatus.Image = CType(resources.GetObject("BtnPrintAdminStatus.Image"), System.Drawing.Image)
        Me.BtnPrintAdminStatus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPrintAdminStatus.Location = New System.Drawing.Point(6, 255)
        Me.BtnPrintAdminStatus.Name = "BtnPrintAdminStatus"
        Me.BtnPrintAdminStatus.Size = New System.Drawing.Size(187, 66)
        Me.BtnPrintAdminStatus.TabIndex = 4
        Me.BtnPrintAdminStatus.Text = "PRINT DOCUMENT"
        Me.BtnPrintAdminStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPrintAdminStatus.UseVisualStyleBackColor = False
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label60.Location = New System.Drawing.Point(39, 69)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(124, 20)
        Me.Label60.TabIndex = 6
        Me.Label60.Text = "HOME TOOLS"
        '
        'BtnSearchBeneficiary
        '
        Me.BtnSearchBeneficiary.BackColor = System.Drawing.Color.Transparent
        Me.BtnSearchBeneficiary.FlatAppearance.BorderSize = 0
        Me.BtnSearchBeneficiary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearchBeneficiary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchBeneficiary.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnSearchBeneficiary.Image = CType(resources.GetObject("BtnSearchBeneficiary.Image"), System.Drawing.Image)
        Me.BtnSearchBeneficiary.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSearchBeneficiary.Location = New System.Drawing.Point(4, 141)
        Me.BtnSearchBeneficiary.Name = "BtnSearchBeneficiary"
        Me.BtnSearchBeneficiary.Size = New System.Drawing.Size(191, 79)
        Me.BtnSearchBeneficiary.TabIndex = 10
        Me.BtnSearchBeneficiary.Text = "FIND RECEIVER"
        Me.BtnSearchBeneficiary.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSearchBeneficiary.UseVisualStyleBackColor = False
        '
        'BtnSearchStat
        '
        Me.BtnSearchStat.BackColor = System.Drawing.Color.Transparent
        Me.BtnSearchStat.FlatAppearance.BorderSize = 0
        Me.BtnSearchStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearchStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchStat.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnSearchStat.Image = CType(resources.GetObject("BtnSearchStat.Image"), System.Drawing.Image)
        Me.BtnSearchStat.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSearchStat.Location = New System.Drawing.Point(3, 131)
        Me.BtnSearchStat.Name = "BtnSearchStat"
        Me.BtnSearchStat.Size = New System.Drawing.Size(191, 79)
        Me.BtnSearchStat.TabIndex = 7
        Me.BtnSearchStat.Text = "SEARCH STATUS"
        Me.BtnSearchStat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSearchStat.UseVisualStyleBackColor = False
        '
        'BtnManageCustomers
        '
        Me.BtnManageCustomers.BackColor = System.Drawing.Color.Transparent
        Me.BtnManageCustomers.FlatAppearance.BorderSize = 0
        Me.BtnManageCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnManageCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnManageCustomers.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnManageCustomers.Image = CType(resources.GetObject("BtnManageCustomers.Image"), System.Drawing.Image)
        Me.BtnManageCustomers.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnManageCustomers.Location = New System.Drawing.Point(3, 131)
        Me.BtnManageCustomers.Name = "BtnManageCustomers"
        Me.BtnManageCustomers.Size = New System.Drawing.Size(191, 79)
        Me.BtnManageCustomers.TabIndex = 9
        Me.BtnManageCustomers.Text = "MANAGED CUSTOMER INFOMATION"
        Me.BtnManageCustomers.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnManageCustomers.UseVisualStyleBackColor = False
        '
        'BtnSearchSender
        '
        Me.BtnSearchSender.BackColor = System.Drawing.Color.Transparent
        Me.BtnSearchSender.FlatAppearance.BorderSize = 0
        Me.BtnSearchSender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearchSender.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchSender.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnSearchSender.Image = CType(resources.GetObject("BtnSearchSender.Image"), System.Drawing.Image)
        Me.BtnSearchSender.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSearchSender.Location = New System.Drawing.Point(3, 131)
        Me.BtnSearchSender.Name = "BtnSearchSender"
        Me.BtnSearchSender.Size = New System.Drawing.Size(191, 79)
        Me.BtnSearchSender.TabIndex = 8
        Me.BtnSearchSender.Text = "FIND SENDER"
        Me.BtnSearchSender.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSearchSender.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.OliveDrab
        Me.Panel3.Controls.Add(Me.Lbldate)
        Me.Panel3.Controls.Add(Me.Label63)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1375, 51)
        Me.Panel3.TabIndex = 18
        '
        'Lbldate
        '
        Me.Lbldate.AutoSize = True
        Me.Lbldate.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbldate.Location = New System.Drawing.Point(891, 28)
        Me.Lbldate.Name = "Lbldate"
        Me.Lbldate.Size = New System.Drawing.Size(57, 20)
        Me.Lbldate.TabIndex = 9
        Me.Lbldate.Text = "Label40"
        Me.Lbldate.Visible = False
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Imprint MT Shadow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label63.Location = New System.Drawing.Point(421, 10)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(464, 25)
        Me.Label63.TabIndex = 0
        Me.Label63.Text = "CONNECT TECH MONEY REMITTANCE"
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelDate.Location = New System.Drawing.Point(1059, 13)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(48, 20)
        Me.LabelDate.TabIndex = 13
        Me.LabelDate.Text = "DATE:"
        '
        'TreeViewAdmin
        '
        Me.TreeViewAdmin.ImageIndex = 0
        Me.TreeViewAdmin.ImageList = Me.ImageList1
        Me.TreeViewAdmin.Location = New System.Drawing.Point(984, 149)
        Me.TreeViewAdmin.Name = "TreeViewAdmin"
        Me.TreeViewAdmin.SelectedImageIndex = 0
        Me.TreeViewAdmin.Size = New System.Drawing.Size(366, 490)
        Me.TreeViewAdmin.TabIndex = 20
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PrintDocument1
        '
        '
        'BtnAdminTool
        '
        Me.BtnAdminTool.BackColor = System.Drawing.Color.Transparent
        Me.BtnAdminTool.FlatAppearance.BorderSize = 0
        Me.BtnAdminTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdminTool.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdminTool.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnAdminTool.Image = CType(resources.GetObject("BtnAdminTool.Image"), System.Drawing.Image)
        Me.BtnAdminTool.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAdminTool.Location = New System.Drawing.Point(302, 8)
        Me.BtnAdminTool.Name = "BtnAdminTool"
        Me.BtnAdminTool.Size = New System.Drawing.Size(180, 77)
        Me.BtnAdminTool.TabIndex = 18
        Me.BtnAdminTool.Text = "ADMINISTRATIVE TOOL"
        Me.BtnAdminTool.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAdminTool.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.LabelName)
        Me.Panel2.Controls.Add(Me.LblEmpID)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.LblUserName)
        Me.Panel2.Location = New System.Drawing.Point(979, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(396, 67)
        Me.Panel2.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(1083, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "FILE EXPLORER"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Teal
        Me.Panel4.Controls.Add(Me.BtnLogout)
        Me.Panel4.Controls.Add(Me.BtnViewDBoard)
        Me.Panel4.Controls.Add(Me.BtnAdminTool)
        Me.Panel4.Controls.Add(Me.LabelDate)
        Me.Panel4.Location = New System.Drawing.Point(0, 638)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1363, 104)
        Me.Panel4.TabIndex = 23
        '
        'FormManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TreeViewAdmin)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelHomeTools)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormManager"
        Me.Text = "FormManager"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageEmployee.ResumeLayout(False)
        Me.TabPageEmployee.PerformLayout()
        CType(Me.DgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageVStatus.ResumeLayout(False)
        Me.TabPageVStatus.PerformLayout()
        CType(Me.DgvStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelStatus.ResumeLayout(False)
        Me.PanelStatus.PerformLayout()
        Me.PanelDateStat.ResumeLayout(False)
        Me.PanelDateStat.PerformLayout()
        Me.PanelEmpId.ResumeLayout(False)
        Me.PanelEmpId.PerformLayout()
        Me.PanelRefNo.ResumeLayout(False)
        Me.PanelRefNo.PerformLayout()
        Me.TabPageSender.ResumeLayout(False)
        Me.TabPageSender.PerformLayout()
        Me.PanelSenderInfo.ResumeLayout(False)
        Me.PanelSenderInfo.PerformLayout()
        CType(Me.DgvSenderInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageBeneficiary.ResumeLayout(False)
        Me.TabPageBeneficiary.PerformLayout()
        CType(Me.dtgBeneficiary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBeneCorrespondent.ResumeLayout(False)
        Me.PanelBeneCorrespondent.PerformLayout()
        Me.PanelBeneRefNo.ResumeLayout(False)
        Me.PanelBeneRefNo.PerformLayout()
        Me.PanelHomeTools.ResumeLayout(False)
        Me.PanelHomeTools.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelHomeTools As Panel
    Friend WithEvents BtnPrintViewAdminStat As Button
    Friend WithEvents BtnPrintAdminStatus As Button
    Friend WithEvents Label60 As Label
    Friend WithEvents BtnSearchStat As Button
    Friend WithEvents BtnManageCustomers As Button
    Friend WithEvents BtnSearchSender As Button
    Friend WithEvents BtnSearchBeneficiary As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Lbldate As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents LabelDate As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPageEmployee As TabPage
    Friend WithEvents BtnAdminManageEmp As Button
    Friend WithEvents BtnShowFormUpdatePW As Button
    Friend WithEvents LblCount As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DgvUsers As DataGridView
    Friend WithEvents BtnAddUser As Button
    Friend WithEvents TabPageVStatus As TabPage
    Friend WithEvents DgvStatus As DataGridView
    Friend WithEvents Label65 As Label
    Friend WithEvents CboCategory As ComboBox
    Friend WithEvents PanelStatus As Panel
    Friend WithEvents Label67 As Label
    Friend WithEvents RadExpired As RadioButton
    Friend WithEvents RadNotClaimed As RadioButton
    Friend WithEvents RadClaimed As RadioButton
    Friend WithEvents PanelDateStat As Panel
    Friend WithEvents Label84 As Label
    Friend WithEvents Txtdtp2Picker As TextBox
    Friend WithEvents Label85 As Label
    Friend WithEvents Txtdtp1Picker As TextBox
    Friend WithEvents TextDTGpicker As TextBox
    Friend WithEvents dtpStat2 As DateTimePicker
    Friend WithEvents dtpStat1 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents RadSpecifyDate As RadioButton
    Friend WithEvents Label69 As Label
    Friend WithEvents RadPerMonth As RadioButton
    Friend WithEvents RadToday As RadioButton
    Friend WithEvents PanelStatNothing As Panel
    Friend WithEvents PanelEmpId As Panel
    Friend WithEvents TvEmpIDStat As TextBox
    Friend WithEvents Label87 As Label
    Friend WithEvents PanelRefNo As Panel
    Friend WithEvents TvRefno As TextBox
    Friend WithEvents LabelinputRefNo As Label
    Friend WithEvents TabPageSender As TabPage
    Friend WithEvents PanelSenderInfo As Panel
    Friend WithEvents Label83 As Label
    Friend WithEvents Label82 As Label
    Friend WithEvents TxtdtpSenderHandler2 As TextBox
    Friend WithEvents TxtdtpSenderHandler1 As TextBox
    Friend WithEvents dtpSenderMonthly2 As DateTimePicker
    Friend WithEvents dtpSenderMonthly1 As DateTimePicker
    Friend WithEvents TvSenderDateholder As TextBox
    Friend WithEvents dtpSenderDate As DateTimePicker
    Friend WithEvents RadSenderSpecifyDate As RadioButton
    Friend WithEvents Label77 As Label
    Friend WithEvents RadSenderPerMonth As RadioButton
    Friend WithEvents RadSenderToday As RadioButton
    Friend WithEvents LabelRevenueAmount As Label
    Friend WithEvents LabelRevenue As Label
    Friend WithEvents TvSenderRefNo As TextBox
    Friend WithEvents LabelSenderRefNo As Label
    Friend WithEvents Label79 As Label
    Friend WithEvents CboSenderCategory As ComboBox
    Friend WithEvents DgvSenderInfo As DataGridView
    Friend WithEvents TabPageBeneficiary As TabPage
    Friend WithEvents Label86 As Label
    Friend WithEvents CboBeneCategory As ComboBox
    Friend WithEvents dtgBeneficiary As DataGridView
    Friend WithEvents PanelBeneNothing As Panel
    Friend WithEvents PanelBeneCorrespondent As Panel
    Friend WithEvents LabelBeneCorres As Label
    Friend WithEvents CboBeneCorrespondent As ComboBox
    Friend WithEvents PanelBeneRefNo As Panel
    Friend WithEvents LabelBeneficiaryRefNo As Label
    Friend WithEvents TvBeneRefNo As TextBox
    Friend WithEvents TreeViewAdmin As TreeView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents BtnLogout As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelName As Label
    Friend WithEvents LblUserName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblEmpID As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents BtnViewDBoard As Button
    Friend WithEvents BtnAdminTool As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
End Class
