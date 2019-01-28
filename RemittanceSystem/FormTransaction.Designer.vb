<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTransaction
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransaction))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LblUserName = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnAdminTool = New System.Windows.Forms.Button()
        Me.BtnClaimTrans = New System.Windows.Forms.Button()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnHome = New System.Windows.Forms.Button()
        Me.LblEmpID = New System.Windows.Forms.Label()
        Me.BtnMakeTran = New System.Windows.Forms.Button()
        Me.DgvUsers = New System.Windows.Forms.DataGridView()
        Me.PanelHome = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageEmployee = New System.Windows.Forms.TabPage()
        Me.BtnAdminManageEmp = New System.Windows.Forms.Button()
        Me.BtnShowFormUpdatePW = New System.Windows.Forms.Button()
        Me.LblCount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.TxtDateIssueClaim = New System.Windows.Forms.TextBox()
        Me.PanelTransaction = New System.Windows.Forms.Panel()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.LinkNext1 = New System.Windows.Forms.LinkLabel()
        Me.TxtRefNo3 = New System.Windows.Forms.TextBox()
        Me.TxtRefNo2 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtTotalAmt = New System.Windows.Forms.TextBox()
        Me.Txtholder = New System.Windows.Forms.TextBox()
        Me.Txtchange = New System.Windows.Forms.TextBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.TxtCashTendered = New System.Windows.Forms.TextBox()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.TxtCharge = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtAmount = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtExpirtyDate = New System.Windows.Forms.TextBox()
        Me.TxtIssueDate = New System.Windows.Forms.TextBox()
        Me.TxtIssuePlace = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtRelationtoRec = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtMobile = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtPurpose = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CboIDtype = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtRefNo1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCustName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.LinkNext2 = New System.Windows.Forms.LinkLabel()
        Me.TxtReceiverRefNo3 = New System.Windows.Forms.TextBox()
        Me.TxtReceiverRefNo2 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtrecAmount = New System.Windows.Forms.TextBox()
        Me.TxtRecBranchAdd = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.CboCorrespondent = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxtRecAddress = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtRecRelationship = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TxtRecMobile = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CboRecIDtype = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtreceiverRefNo1 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtRecName = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.LblAdminCheckCorr = New System.Windows.Forms.Label()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.LblAdminCheckBranck = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.LblAdminCheckRecAmount = New System.Windows.Forms.Label()
        Me.LblAdminCheckRecAdd = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.LblAdminCheckRecMob = New System.Windows.Forms.Label()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.LblAdminCheckRecRel = New System.Windows.Forms.Label()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.LblAdminCheckRecId = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.LblAdminCheckRecName = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.LblAdminCheckAmountRemit = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.LblAdminCheckCharge = New System.Windows.Forms.Label()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.LblAdminCheckTotal = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.LblAdminCheckIssue = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.LblAdminCheckExpiry = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.LblAdminCheckIssuePlace = New System.Windows.Forms.Label()
        Me.LblAdminCheckCustRel = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.LblAdminCheckAddress = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.LblAdminCheckMob = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.LblAdminCheckPurpose = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.LblAdminCheckCustName = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.LblAdminCheckIDtype = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.LblAdminCheckRefNo = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.PanelAdminRemitPrintReceipt = New System.Windows.Forms.Panel()
        Me.LblAdminRecNameReceipt = New System.Windows.Forms.Label()
        Me.LbltotalAmount = New System.Windows.Forms.Label()
        Me.Lblcharge = New System.Windows.Forms.Label()
        Me.Lblamount = New System.Windows.Forms.Label()
        Me.LblexpiryDate = New System.Windows.Forms.Label()
        Me.LblissuePlace = New System.Windows.Forms.Label()
        Me.LblissueDate = New System.Windows.Forms.Label()
        Me.LblCustName = New System.Windows.Forms.Label()
        Me.LblRefNo = New System.Windows.Forms.Label()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.LabelAdminAmtInWordsReceipt = New System.Windows.Forms.Label()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.Label111 = New System.Windows.Forms.Label()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.Label117 = New System.Windows.Forms.Label()
        Me.Label119 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Lbldate = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PanelClaimTransaction = New System.Windows.Forms.Panel()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPageClaim = New System.Windows.Forms.TabPage()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.TxtClaimStatus = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.TxtClaimExpiryDate = New System.Windows.Forms.TextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.TxtClaimIDtype = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TxtClaimCorrespondent = New System.Windows.Forms.TextBox()
        Me.TxtClaimAmount = New System.Windows.Forms.TextBox()
        Me.TxtClaimBranch = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.TxtClaimAddress = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.TxtClaimRelationship = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.TxtClaimMobile = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.TxtClaimName = New System.Windows.Forms.TextBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.TxtClaimRefNo = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.TabPageClaimReceipt = New System.Windows.Forms.TabPage()
        Me.PanelAdminClaimReceipt = New System.Windows.Forms.Panel()
        Me.LabelcAddress = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.LabelcMobileNo = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.LabelcRefNo = New System.Windows.Forms.Label()
        Me.LabelcName = New System.Windows.Forms.Label()
        Me.LabelcStatus = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.LabelcBranch = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.LabelcCorrespondent = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.LblAdminClaimAmtInWords = New System.Windows.Forms.Label()
        Me.LabelcAmount = New System.Windows.Forms.Label()
        Me.Label118 = New System.Windows.Forms.Label()
        Me.Label120 = New System.Windows.Forms.Label()
        Me.Label121 = New System.Windows.Forms.Label()
        Me.Label122 = New System.Windows.Forms.Label()
        Me.Label123 = New System.Windows.Forms.Label()
        Me.Label124 = New System.Windows.Forms.Label()
        Me.Label125 = New System.Windows.Forms.Label()
        Me.Label126 = New System.Windows.Forms.Label()
        Me.Label127 = New System.Windows.Forms.Label()
        Me.Label128 = New System.Windows.Forms.Label()
        Me.Label129 = New System.Windows.Forms.Label()
        Me.Label130 = New System.Windows.Forms.Label()
        Me.Label132 = New System.Windows.Forms.Label()
        Me.Label133 = New System.Windows.Forms.Label()
        Me.Label134 = New System.Windows.Forms.Label()
        Me.Label141 = New System.Windows.Forms.Label()
        Me.Label142 = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.PanelControlContainer = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PanelHomeTools = New System.Windows.Forms.Panel()
        Me.BtnPrintViewAdminStat = New System.Windows.Forms.Button()
        Me.BtnPrintAdminStatus = New System.Windows.Forms.Button()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.BtnManageCustomers = New System.Windows.Forms.Button()
        Me.BtnSearchSender = New System.Windows.Forms.Button()
        Me.BtnSearchBeneficiary = New System.Windows.Forms.Button()
        Me.BtnSearchStat = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnClaimCancel = New System.Windows.Forms.Button()
        Me.BtnAdminClaimPreview = New System.Windows.Forms.Button()
        Me.BtnClaimChangeStat = New System.Windows.Forms.Button()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.BtnClaimStartTrans = New System.Windows.Forms.Button()
        Me.BtnAdminClaimPrint = New System.Windows.Forms.Button()
        Me.BtnClaimSaveTrans = New System.Windows.Forms.Button()
        Me.PanelRemitTools = New System.Windows.Forms.Panel()
        Me.BtnAdminNewTrans = New System.Windows.Forms.Button()
        Me.BtnCancelRemitAdmin = New System.Windows.Forms.Button()
        Me.BtnAdminRemitPreview = New System.Windows.Forms.Button()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.BtnStartTran = New System.Windows.Forms.Button()
        Me.BtnAdminRemitPrint = New System.Windows.Forms.Button()
        Me.BtnSaveTran = New System.Windows.Forms.Button()
        Me.PanelAdminFileExplorer = New System.Windows.Forms.Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TreeViewAdmin = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocumentAdminClaim = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialogAdminClaim = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocumentAdminRemitReceipt = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialogAdminRemit = New System.Windows.Forms.PrintPreviewDialog()
        Me.PbRight = New System.Windows.Forms.PictureBox()
        Me.PbviewFiles = New System.Windows.Forms.PictureBox()
        Me.PbviewButtons = New System.Windows.Forms.PictureBox()
        Me.PbLeft = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHome.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPageEmployee.SuspendLayout()
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
        Me.PanelTransaction.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.PanelAdminRemitPrintReceipt.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.PanelClaimTransaction.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPageClaim.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.TabPageClaimReceipt.SuspendLayout()
        Me.PanelAdminClaimReceipt.SuspendLayout()
        Me.PanelControlContainer.SuspendLayout()
        Me.PanelHomeTools.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelRemitTools.SuspendLayout()
        Me.PanelAdminFileExplorer.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PbRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbviewFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbviewButtons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblUserName
        '
        Me.LblUserName.AutoSize = True
        Me.LblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUserName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblUserName.Location = New System.Drawing.Point(50, 41)
        Me.LblUserName.Name = "LblUserName"
        Me.LblUserName.Size = New System.Drawing.Size(16, 16)
        Me.LblUserName.TabIndex = 2
        Me.LblUserName.Text = "--"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.BtnAdminTool)
        Me.Panel1.Controls.Add(Me.BtnClaimTrans)
        Me.Panel1.Controls.Add(Me.LabelName)
        Me.Panel1.Controls.Add(Me.LblUserName)
        Me.Panel1.Controls.Add(Me.BtnLogout)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BtnHome)
        Me.Panel1.Controls.Add(Me.LblEmpID)
        Me.Panel1.Controls.Add(Me.BtnMakeTran)
        Me.Panel1.Location = New System.Drawing.Point(-2, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(190, 627)
        Me.Panel1.TabIndex = 3
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
        Me.BtnAdminTool.Location = New System.Drawing.Point(5, 456)
        Me.BtnAdminTool.Name = "BtnAdminTool"
        Me.BtnAdminTool.Size = New System.Drawing.Size(180, 77)
        Me.BtnAdminTool.TabIndex = 14
        Me.BtnAdminTool.Text = "ADMINISTRATIVE TOOL"
        Me.BtnAdminTool.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAdminTool.UseVisualStyleBackColor = False
        '
        'BtnClaimTrans
        '
        Me.BtnClaimTrans.BackColor = System.Drawing.Color.Transparent
        Me.BtnClaimTrans.FlatAppearance.BorderSize = 0
        Me.BtnClaimTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClaimTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClaimTrans.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnClaimTrans.Image = CType(resources.GetObject("BtnClaimTrans.Image"), System.Drawing.Image)
        Me.BtnClaimTrans.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnClaimTrans.Location = New System.Drawing.Point(3, 342)
        Me.BtnClaimTrans.Name = "BtnClaimTrans"
        Me.BtnClaimTrans.Size = New System.Drawing.Size(187, 77)
        Me.BtnClaimTrans.TabIndex = 12
        Me.BtnClaimTrans.Text = "CLAIM TRANSACTION"
        Me.BtnClaimTrans.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnClaimTrans.UseVisualStyleBackColor = False
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelName.Location = New System.Drawing.Point(24, 17)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(90, 16)
        Me.LabelName.TabIndex = 7
        Me.LabelName.Text = "User Name:"
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
        Me.BtnLogout.Location = New System.Drawing.Point(3, 559)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(182, 51)
        Me.BtnLogout.TabIndex = 5
        Me.BtnLogout.Text = "     LOG OUT"
        Me.BtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(24, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Employee ID:"
        '
        'BtnHome
        '
        Me.BtnHome.BackColor = System.Drawing.Color.Transparent
        Me.BtnHome.FlatAppearance.BorderSize = 0
        Me.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHome.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnHome.Image = CType(resources.GetObject("BtnHome.Image"), System.Drawing.Image)
        Me.BtnHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnHome.Location = New System.Drawing.Point(2, 127)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(187, 77)
        Me.BtnHome.TabIndex = 0
        Me.BtnHome.Text = "HOME AND REPORTS"
        Me.BtnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnHome.UseCompatibleTextRendering = True
        Me.BtnHome.UseVisualStyleBackColor = False
        '
        'LblEmpID
        '
        Me.LblEmpID.AutoSize = True
        Me.LblEmpID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmpID.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblEmpID.Location = New System.Drawing.Point(50, 90)
        Me.LblEmpID.Name = "LblEmpID"
        Me.LblEmpID.Size = New System.Drawing.Size(16, 16)
        Me.LblEmpID.TabIndex = 6
        Me.LblEmpID.Text = "--"
        '
        'BtnMakeTran
        '
        Me.BtnMakeTran.BackColor = System.Drawing.Color.Transparent
        Me.BtnMakeTran.FlatAppearance.BorderSize = 0
        Me.BtnMakeTran.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMakeTran.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMakeTran.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnMakeTran.Image = CType(resources.GetObject("BtnMakeTran.Image"), System.Drawing.Image)
        Me.BtnMakeTran.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnMakeTran.Location = New System.Drawing.Point(3, 232)
        Me.BtnMakeTran.Name = "BtnMakeTran"
        Me.BtnMakeTran.Size = New System.Drawing.Size(187, 77)
        Me.BtnMakeTran.TabIndex = 3
        Me.BtnMakeTran.Text = "REMIT TRANSACTION"
        Me.BtnMakeTran.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnMakeTran.UseVisualStyleBackColor = False
        '
        'DgvUsers
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvUsers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvUsers.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvUsers.Location = New System.Drawing.Point(29, 68)
        Me.DgvUsers.Name = "DgvUsers"
        Me.DgvUsers.Size = New System.Drawing.Size(700, 252)
        Me.DgvUsers.TabIndex = 0
        '
        'PanelHome
        '
        Me.PanelHome.Controls.Add(Me.TabControl1)
        Me.PanelHome.Location = New System.Drawing.Point(186, 53)
        Me.PanelHome.Name = "PanelHome"
        Me.PanelHome.Size = New System.Drawing.Size(786, 627)
        Me.PanelHome.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageEmployee)
        Me.TabControl1.Controls.Add(Me.TabPageVStatus)
        Me.TabControl1.Controls.Add(Me.TabPageSender)
        Me.TabControl1.Controls.Add(Me.TabPageBeneficiary)
        Me.TabControl1.ItemSize = New System.Drawing.Size(200, 30)
        Me.TabControl1.Location = New System.Drawing.Point(-2, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(763, 565)
        Me.TabControl1.TabIndex = 0
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
        'TxtDateIssueClaim
        '
        Me.TxtDateIssueClaim.Enabled = False
        Me.TxtDateIssueClaim.Location = New System.Drawing.Point(18, 47)
        Me.TxtDateIssueClaim.Name = "TxtDateIssueClaim"
        Me.TxtDateIssueClaim.Size = New System.Drawing.Size(173, 20)
        Me.TxtDateIssueClaim.TabIndex = 2
        '
        'PanelTransaction
        '
        Me.PanelTransaction.Controls.Add(Me.TabControl2)
        Me.PanelTransaction.Location = New System.Drawing.Point(186, 53)
        Me.PanelTransaction.Name = "PanelTransaction"
        Me.PanelTransaction.Size = New System.Drawing.Size(786, 627)
        Me.PanelTransaction.TabIndex = 8
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.ItemSize = New System.Drawing.Size(200, 30)
        Me.TabControl2.Location = New System.Drawing.Point(3, 2)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(753, 631)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.LinkNext1)
        Me.TabPage4.Controls.Add(Me.TxtRefNo3)
        Me.TabPage4.Controls.Add(Me.TxtRefNo2)
        Me.TabPage4.Controls.Add(Me.GroupBox2)
        Me.TabPage4.Controls.Add(Me.GroupBox1)
        Me.TabPage4.Controls.Add(Me.TxtAddress)
        Me.TabPage4.Controls.Add(Me.Label9)
        Me.TabPage4.Controls.Add(Me.TxtRelationtoRec)
        Me.TabPage4.Controls.Add(Me.Label8)
        Me.TabPage4.Controls.Add(Me.TxtMobile)
        Me.TabPage4.Controls.Add(Me.Label6)
        Me.TabPage4.Controls.Add(Me.TxtPurpose)
        Me.TabPage4.Controls.Add(Me.Label7)
        Me.TabPage4.Controls.Add(Me.CboIDtype)
        Me.TabPage4.Controls.Add(Me.Label5)
        Me.TabPage4.Controls.Add(Me.TxtRefNo1)
        Me.TabPage4.Controls.Add(Me.Label4)
        Me.TabPage4.Controls.Add(Me.TxtCustName)
        Me.TabPage4.Controls.Add(Me.Label1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 34)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(745, 593)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "CUSTOMER"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'LinkNext1
        '
        Me.LinkNext1.AutoSize = True
        Me.LinkNext1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkNext1.Location = New System.Drawing.Point(551, 558)
        Me.LinkNext1.Name = "LinkNext1"
        Me.LinkNext1.Size = New System.Drawing.Size(164, 16)
        Me.LinkNext1.TabIndex = 10
        Me.LinkNext1.TabStop = True
        Me.LinkNext1.Text = "GO TO NEXT PAGE >>"
        '
        'TxtRefNo3
        '
        Me.TxtRefNo3.Location = New System.Drawing.Point(190, 52)
        Me.TxtRefNo3.Name = "TxtRefNo3"
        Me.TxtRefNo3.Size = New System.Drawing.Size(60, 20)
        Me.TxtRefNo3.TabIndex = 31
        Me.TxtRefNo3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtRefNo2
        '
        Me.TxtRefNo2.Location = New System.Drawing.Point(124, 52)
        Me.TxtRefNo2.Name = "TxtRefNo2"
        Me.TxtRefNo2.Size = New System.Drawing.Size(60, 20)
        Me.TxtRefNo2.TabIndex = 30
        Me.TxtRefNo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox10)
        Me.GroupBox2.Controls.Add(Me.Txtholder)
        Me.GroupBox2.Controls.Add(Me.Txtchange)
        Me.GroupBox2.Controls.Add(Me.Label73)
        Me.GroupBox2.Controls.Add(Me.TxtCashTendered)
        Me.GroupBox2.Controls.Add(Me.Label75)
        Me.GroupBox2.Controls.Add(Me.TxtCharge)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.TxtAmount)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(64, 402)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(588, 140)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "AMOUNT TO REMIT:"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Label15)
        Me.GroupBox10.Controls.Add(Me.TxtTotalAmt)
        Me.GroupBox10.Location = New System.Drawing.Point(382, 22)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(188, 103)
        Me.GroupBox10.TabIndex = 40
        Me.GroupBox10.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(14, 33)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 16)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Total Amount:"
        '
        'TxtTotalAmt
        '
        Me.TxtTotalAmt.Enabled = False
        Me.TxtTotalAmt.Location = New System.Drawing.Point(17, 52)
        Me.TxtTotalAmt.Name = "TxtTotalAmt"
        Me.TxtTotalAmt.Size = New System.Drawing.Size(154, 20)
        Me.TxtTotalAmt.TabIndex = 12
        '
        'Txtholder
        '
        Me.Txtholder.Enabled = False
        Me.Txtholder.Location = New System.Drawing.Point(326, 9)
        Me.Txtholder.Name = "Txtholder"
        Me.Txtholder.Size = New System.Drawing.Size(51, 20)
        Me.Txtholder.TabIndex = 39
        Me.Txtholder.Visible = False
        '
        'Txtchange
        '
        Me.Txtchange.Enabled = False
        Me.Txtchange.Location = New System.Drawing.Point(231, 51)
        Me.Txtchange.Name = "Txtchange"
        Me.Txtchange.Size = New System.Drawing.Size(128, 20)
        Me.Txtchange.TabIndex = 36
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.Location = New System.Drawing.Point(228, 32)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(65, 16)
        Me.Label73.TabIndex = 38
        Me.Label73.Text = "Change:"
        '
        'TxtCashTendered
        '
        Me.TxtCashTendered.Location = New System.Drawing.Point(34, 51)
        Me.TxtCashTendered.Name = "TxtCashTendered"
        Me.TxtCashTendered.Size = New System.Drawing.Size(128, 20)
        Me.TxtCashTendered.TabIndex = 8
        Me.TxtCashTendered.Tag = "Please enter amount"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.Location = New System.Drawing.Point(31, 32)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(119, 16)
        Me.Label75.TabIndex = 37
        Me.Label75.Text = "Cash Tendered:"
        '
        'TxtCharge
        '
        Me.TxtCharge.Enabled = False
        Me.TxtCharge.Location = New System.Drawing.Point(231, 98)
        Me.TxtCharge.Name = "TxtCharge"
        Me.TxtCharge.Size = New System.Drawing.Size(128, 20)
        Me.TxtCharge.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(228, 79)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 16)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Charge:"
        '
        'TxtAmount
        '
        Me.TxtAmount.Location = New System.Drawing.Point(34, 98)
        Me.TxtAmount.Name = "TxtAmount"
        Me.TxtAmount.Size = New System.Drawing.Size(128, 20)
        Me.TxtAmount.TabIndex = 9
        Me.TxtAmount.Tag = "Please enter amount"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(31, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 16)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Amount to remit:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtExpirtyDate)
        Me.GroupBox1.Controls.Add(Me.TxtIssueDate)
        Me.GroupBox1.Controls.Add(Me.TxtIssuePlace)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(61, 256)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(592, 140)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATE AND PLACE OF TRANSACTION:"
        '
        'TxtExpirtyDate
        '
        Me.TxtExpirtyDate.Enabled = False
        Me.TxtExpirtyDate.Location = New System.Drawing.Point(26, 104)
        Me.TxtExpirtyDate.Name = "TxtExpirtyDate"
        Me.TxtExpirtyDate.Size = New System.Drawing.Size(218, 20)
        Me.TxtExpirtyDate.TabIndex = 17
        '
        'TxtIssueDate
        '
        Me.TxtIssueDate.Enabled = False
        Me.TxtIssueDate.Location = New System.Drawing.Point(26, 52)
        Me.TxtIssueDate.Name = "TxtIssueDate"
        Me.TxtIssueDate.Size = New System.Drawing.Size(218, 20)
        Me.TxtIssueDate.TabIndex = 16
        '
        'TxtIssuePlace
        '
        Me.TxtIssuePlace.Location = New System.Drawing.Point(309, 52)
        Me.TxtIssuePlace.Name = "TxtIssuePlace"
        Me.TxtIssuePlace.Size = New System.Drawing.Size(218, 20)
        Me.TxtIssuePlace.TabIndex = 7
        Me.TxtIssuePlace.Tag = "This is a required field"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(306, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 16)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Issue Place:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(25, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 16)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Expiry Date:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 16)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Issue Date:"
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(58, 222)
        Me.TxtAddress.MaxLength = 100
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(337, 20)
        Me.TxtAddress.TabIndex = 5
        Me.TxtAddress.Tag = "This is a required field"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(55, 203)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 16)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Address:"
        '
        'TxtRelationtoRec
        '
        Me.TxtRelationtoRec.Location = New System.Drawing.Point(447, 222)
        Me.TxtRelationtoRec.Name = "TxtRelationtoRec"
        Me.TxtRelationtoRec.Size = New System.Drawing.Size(218, 20)
        Me.TxtRelationtoRec.TabIndex = 6
        Me.TxtRelationtoRec.Tag = "This is a required field"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(444, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(202, 16)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Relationship to the receiver:"
        '
        'TxtMobile
        '
        Me.TxtMobile.Location = New System.Drawing.Point(446, 167)
        Me.TxtMobile.MaxLength = 15
        Me.TxtMobile.Name = "TxtMobile"
        Me.TxtMobile.Size = New System.Drawing.Size(218, 20)
        Me.TxtMobile.TabIndex = 4
        Me.TxtMobile.Tag = "Mobile number is required"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(444, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 16)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Mobile Number:"
        '
        'TxtPurpose
        '
        Me.TxtPurpose.Location = New System.Drawing.Point(58, 165)
        Me.TxtPurpose.Name = "TxtPurpose"
        Me.TxtPurpose.Size = New System.Drawing.Size(218, 20)
        Me.TxtPurpose.TabIndex = 3
        Me.TxtPurpose.Tag = "Please input purpose"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(55, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 16)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Purpose:"
        '
        'CboIDtype
        '
        Me.CboIDtype.FormattingEnabled = True
        Me.CboIDtype.ItemHeight = 13
        Me.CboIDtype.Items.AddRange(New Object() {"SSS", "BIR", "SCHOOL ID", "COMPANY ID", "PASSPORT"})
        Me.CboIDtype.Location = New System.Drawing.Point(447, 109)
        Me.CboIDtype.Name = "CboIDtype"
        Me.CboIDtype.Size = New System.Drawing.Size(217, 21)
        Me.CboIDtype.TabIndex = 2
        Me.CboIDtype.Tag = "Choose ID type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(444, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "ID Type:"
        '
        'TxtRefNo1
        '
        Me.TxtRefNo1.Location = New System.Drawing.Point(58, 52)
        Me.TxtRefNo1.Name = "TxtRefNo1"
        Me.TxtRefNo1.Size = New System.Drawing.Size(60, 20)
        Me.TxtRefNo1.TabIndex = 1
        Me.TxtRefNo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Reference Number:"
        '
        'TxtCustName
        '
        Me.TxtCustName.Location = New System.Drawing.Point(58, 109)
        Me.TxtCustName.Name = "TxtCustName"
        Me.TxtCustName.Size = New System.Drawing.Size(218, 20)
        Me.TxtCustName.TabIndex = 1
        Me.TxtCustName.Tag = "Please enter customer name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Customer Name:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.LinkNext2)
        Me.TabPage3.Controls.Add(Me.TxtReceiverRefNo3)
        Me.TabPage3.Controls.Add(Me.TxtReceiverRefNo2)
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Controls.Add(Me.TxtRecAddress)
        Me.TabPage3.Controls.Add(Me.Label20)
        Me.TabPage3.Controls.Add(Me.TxtRecRelationship)
        Me.TabPage3.Controls.Add(Me.Label21)
        Me.TabPage3.Controls.Add(Me.TxtRecMobile)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.CboRecIDtype)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.TxtreceiverRefNo1)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.TxtRecName)
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(745, 593)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "RECEIVER"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'LinkNext2
        '
        Me.LinkNext2.AutoSize = True
        Me.LinkNext2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkNext2.Location = New System.Drawing.Point(506, 510)
        Me.LinkNext2.Name = "LinkNext2"
        Me.LinkNext2.Size = New System.Drawing.Size(164, 16)
        Me.LinkNext2.TabIndex = 18
        Me.LinkNext2.TabStop = True
        Me.LinkNext2.Text = "GO TO NEXT PAGE >>"
        '
        'TxtReceiverRefNo3
        '
        Me.TxtReceiverRefNo3.Location = New System.Drawing.Point(188, 67)
        Me.TxtReceiverRefNo3.Name = "TxtReceiverRefNo3"
        Me.TxtReceiverRefNo3.Size = New System.Drawing.Size(60, 20)
        Me.TxtReceiverRefNo3.TabIndex = 39
        '
        'TxtReceiverRefNo2
        '
        Me.TxtReceiverRefNo2.Location = New System.Drawing.Point(122, 67)
        Me.TxtReceiverRefNo2.Name = "TxtReceiverRefNo2"
        Me.TxtReceiverRefNo2.Size = New System.Drawing.Size(60, 20)
        Me.TxtReceiverRefNo2.TabIndex = 38
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtrecAmount)
        Me.GroupBox3.Controls.Add(Me.TxtRecBranchAdd)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.CboCorrespondent)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Location = New System.Drawing.Point(59, 311)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(579, 167)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CORRESPONDENT, BRANCH AND AMOUNT"
        '
        'TxtrecAmount
        '
        Me.TxtrecAmount.Enabled = False
        Me.TxtrecAmount.Location = New System.Drawing.Point(308, 48)
        Me.TxtrecAmount.Name = "TxtrecAmount"
        Me.TxtrecAmount.Size = New System.Drawing.Size(218, 20)
        Me.TxtrecAmount.TabIndex = 16
        Me.TxtrecAmount.Tag = "This is required field..."
        '
        'TxtRecBranchAdd
        '
        Me.TxtRecBranchAdd.Location = New System.Drawing.Point(18, 114)
        Me.TxtRecBranchAdd.Name = "TxtRecBranchAdd"
        Me.TxtRecBranchAdd.Size = New System.Drawing.Size(364, 20)
        Me.TxtRecBranchAdd.TabIndex = 17
        Me.TxtRecBranchAdd.Tag = "This is required field..."
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(306, 29)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(167, 16)
        Me.Label24.TabIndex = 39
        Me.Label24.Text = "Amount to be received:"
        '
        'CboCorrespondent
        '
        Me.CboCorrespondent.FormattingEnabled = True
        Me.CboCorrespondent.ItemHeight = 13
        Me.CboCorrespondent.Items.AddRange(New Object() {"PALAWAN PAWNSHOP", "CEBUANA PAWNSHOP", "WESTERN UNION"})
        Me.CboCorrespondent.Location = New System.Drawing.Point(18, 47)
        Me.CboCorrespondent.Name = "CboCorrespondent"
        Me.CboCorrespondent.Size = New System.Drawing.Size(217, 21)
        Me.CboCorrespondent.TabIndex = 16
        Me.CboCorrespondent.Tag = "This is required field..."
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(15, 95)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(122, 16)
        Me.Label23.TabIndex = 39
        Me.Label23.Text = "Branch Address:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(15, 28)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(114, 16)
        Me.Label22.TabIndex = 39
        Me.Label22.Text = "Correspondent:"
        '
        'TxtRecAddress
        '
        Me.TxtRecAddress.Location = New System.Drawing.Point(56, 261)
        Me.TxtRecAddress.MaxLength = 100
        Me.TxtRecAddress.Name = "TxtRecAddress"
        Me.TxtRecAddress.Size = New System.Drawing.Size(364, 20)
        Me.TxtRecAddress.TabIndex = 15
        Me.TxtRecAddress.Tag = "This is required field..."
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(53, 242)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 16)
        Me.Label20.TabIndex = 36
        Me.Label20.Text = "Address:"
        '
        'TxtRecRelationship
        '
        Me.TxtRecRelationship.Location = New System.Drawing.Point(56, 204)
        Me.TxtRecRelationship.Name = "TxtRecRelationship"
        Me.TxtRecRelationship.Size = New System.Drawing.Size(218, 20)
        Me.TxtRecRelationship.TabIndex = 13
        Me.TxtRecRelationship.Tag = "This is required field..."
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(53, 185)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(193, 16)
        Me.Label21.TabIndex = 34
        Me.Label21.Text = "Relationship to the sender:"
        '
        'TxtRecMobile
        '
        Me.TxtRecMobile.Location = New System.Drawing.Point(368, 204)
        Me.TxtRecMobile.MaxLength = 11
        Me.TxtRecMobile.Name = "TxtRecMobile"
        Me.TxtRecMobile.Size = New System.Drawing.Size(218, 20)
        Me.TxtRecMobile.TabIndex = 14
        Me.TxtRecMobile.Tag = "This is required field..."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(366, 185)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(117, 16)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Mobile Number:"
        '
        'CboRecIDtype
        '
        Me.CboRecIDtype.FormattingEnabled = True
        Me.CboRecIDtype.ItemHeight = 13
        Me.CboRecIDtype.Items.AddRange(New Object() {"SSS", "BIR", "SCHOOL ID", "COMPANY ID", "PASSPORT"})
        Me.CboRecIDtype.Location = New System.Drawing.Point(369, 147)
        Me.CboRecIDtype.Name = "CboRecIDtype"
        Me.CboRecIDtype.Size = New System.Drawing.Size(217, 21)
        Me.CboRecIDtype.TabIndex = 12
        Me.CboRecIDtype.Tag = "This is required field..."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(366, 128)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 16)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "ID Type:"
        '
        'TxtreceiverRefNo1
        '
        Me.TxtreceiverRefNo1.Location = New System.Drawing.Point(56, 67)
        Me.TxtreceiverRefNo1.Name = "TxtreceiverRefNo1"
        Me.TxtreceiverRefNo1.Size = New System.Drawing.Size(60, 20)
        Me.TxtreceiverRefNo1.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(53, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(142, 16)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "Reference Number:"
        '
        'TxtRecName
        '
        Me.TxtRecName.Location = New System.Drawing.Point(56, 147)
        Me.TxtRecName.Name = "TxtRecName"
        Me.TxtRecName.Size = New System.Drawing.Size(218, 20)
        Me.TxtRecName.TabIndex = 11
        Me.TxtRecName.Tag = "This is required field..."
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(53, 128)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(120, 16)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Receiver Name:"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label32)
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.LblAdminCheckRecAdd)
        Me.TabPage1.Controls.Add(Me.Label35)
        Me.TabPage1.Controls.Add(Me.LblAdminCheckRecMob)
        Me.TabPage1.Controls.Add(Me.Label103)
        Me.TabPage1.Controls.Add(Me.LblAdminCheckRecRel)
        Me.TabPage1.Controls.Add(Me.Label101)
        Me.TabPage1.Controls.Add(Me.LblAdminCheckRecId)
        Me.TabPage1.Controls.Add(Me.Label36)
        Me.TabPage1.Controls.Add(Me.LblAdminCheckRecName)
        Me.TabPage1.Controls.Add(Me.Label37)
        Me.TabPage1.Controls.Add(Me.Label41)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.LblAdminCheckCustRel)
        Me.TabPage1.Controls.Add(Me.Label48)
        Me.TabPage1.Controls.Add(Me.LblAdminCheckAddress)
        Me.TabPage1.Controls.Add(Me.Label45)
        Me.TabPage1.Controls.Add(Me.LblAdminCheckMob)
        Me.TabPage1.Controls.Add(Me.Label42)
        Me.TabPage1.Controls.Add(Me.LblAdminCheckPurpose)
        Me.TabPage1.Controls.Add(Me.Label28)
        Me.TabPage1.Controls.Add(Me.LblAdminCheckCustName)
        Me.TabPage1.Controls.Add(Me.Label33)
        Me.TabPage1.Controls.Add(Me.LblAdminCheckIDtype)
        Me.TabPage1.Controls.Add(Me.Label30)
        Me.TabPage1.Controls.Add(Me.LblAdminCheckRefNo)
        Me.TabPage1.Controls.Add(Me.Label31)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(745, 593)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "REVIEW INFO"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Maroon
        Me.Label32.Location = New System.Drawing.Point(38, 343)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(192, 16)
        Me.Label32.TabIndex = 80
        Me.Label32.Text = "RECEIVER INFORMATION"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label105)
        Me.GroupBox6.Controls.Add(Me.LblAdminCheckCorr)
        Me.GroupBox6.Controls.Add(Me.Label107)
        Me.GroupBox6.Controls.Add(Me.LblAdminCheckBranck)
        Me.GroupBox6.Controls.Add(Me.Label34)
        Me.GroupBox6.Controls.Add(Me.LblAdminCheckRecAmount)
        Me.GroupBox6.Location = New System.Drawing.Point(441, 388)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(268, 158)
        Me.GroupBox6.TabIndex = 79
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "RECEIVABLE INFORMATION:"
        '
        'Label105
        '
        Me.Label105.AutoSize = True
        Me.Label105.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label105.Location = New System.Drawing.Point(15, 26)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(105, 15)
        Me.Label105.TabIndex = 38
        Me.Label105.Text = "Correspondent:"
        '
        'LblAdminCheckCorr
        '
        Me.LblAdminCheckCorr.AutoSize = True
        Me.LblAdminCheckCorr.Location = New System.Drawing.Point(68, 47)
        Me.LblAdminCheckCorr.Name = "LblAdminCheckCorr"
        Me.LblAdminCheckCorr.Size = New System.Drawing.Size(25, 13)
        Me.LblAdminCheckCorr.TabIndex = 39
        Me.LblAdminCheckCorr.Text = "corr"
        '
        'Label107
        '
        Me.Label107.AutoSize = True
        Me.Label107.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label107.Location = New System.Drawing.Point(15, 63)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(56, 15)
        Me.Label107.TabIndex = 40
        Me.Label107.Text = "Branch:"
        '
        'LblAdminCheckBranck
        '
        Me.LblAdminCheckBranck.AutoSize = True
        Me.LblAdminCheckBranck.Location = New System.Drawing.Point(68, 81)
        Me.LblAdminCheckBranck.Name = "LblAdminCheckBranck"
        Me.LblAdminCheckBranck.Size = New System.Drawing.Size(40, 13)
        Me.LblAdminCheckBranck.TabIndex = 41
        Me.LblAdminCheckBranck.Text = "branch"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(18, 117)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(133, 15)
        Me.Label34.TabIndex = 42
        Me.Label34.Text = "Amount to received:"
        '
        'LblAdminCheckRecAmount
        '
        Me.LblAdminCheckRecAmount.AutoSize = True
        Me.LblAdminCheckRecAmount.Location = New System.Drawing.Point(68, 137)
        Me.LblAdminCheckRecAmount.Name = "LblAdminCheckRecAmount"
        Me.LblAdminCheckRecAmount.Size = New System.Drawing.Size(58, 13)
        Me.LblAdminCheckRecAmount.TabIndex = 43
        Me.LblAdminCheckRecAmount.Text = "recAmount"
        '
        'LblAdminCheckRecAdd
        '
        Me.LblAdminCheckRecAdd.AutoSize = True
        Me.LblAdminCheckRecAdd.Location = New System.Drawing.Point(58, 414)
        Me.LblAdminCheckRecAdd.Name = "LblAdminCheckRecAdd"
        Me.LblAdminCheckRecAdd.Size = New System.Drawing.Size(41, 13)
        Me.LblAdminCheckRecAdd.TabIndex = 78
        Me.LblAdminCheckRecAdd.Text = "recAdd"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(37, 396)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(62, 15)
        Me.Label35.TabIndex = 77
        Me.Label35.Text = "Address:"
        '
        'LblAdminCheckRecMob
        '
        Me.LblAdminCheckRecMob.AutoSize = True
        Me.LblAdminCheckRecMob.Location = New System.Drawing.Point(159, 437)
        Me.LblAdminCheckRecMob.Name = "LblAdminCheckRecMob"
        Me.LblAdminCheckRecMob.Size = New System.Drawing.Size(43, 13)
        Me.LblAdminCheckRecMob.TabIndex = 76
        Me.LblAdminCheckRecMob.Text = "recMob"
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label103.Location = New System.Drawing.Point(37, 435)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(110, 15)
        Me.Label103.TabIndex = 75
        Me.Label103.Text = "Mobile Number:"
        '
        'LblAdminCheckRecRel
        '
        Me.LblAdminCheckRecRel.AutoSize = True
        Me.LblAdminCheckRecRel.Location = New System.Drawing.Point(198, 501)
        Me.LblAdminCheckRecRel.Name = "LblAdminCheckRecRel"
        Me.LblAdminCheckRecRel.Size = New System.Drawing.Size(38, 13)
        Me.LblAdminCheckRecRel.TabIndex = 74
        Me.LblAdminCheckRecRel.Text = "recRel"
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.Location = New System.Drawing.Point(40, 497)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(152, 15)
        Me.Label101.TabIndex = 73
        Me.Label101.Text = "Relationshp to sender:"
        '
        'LblAdminCheckRecId
        '
        Me.LblAdminCheckRecId.AutoSize = True
        Me.LblAdminCheckRecId.Location = New System.Drawing.Point(102, 471)
        Me.LblAdminCheckRecId.Name = "LblAdminCheckRecId"
        Me.LblAdminCheckRecId.Size = New System.Drawing.Size(31, 13)
        Me.LblAdminCheckRecId.TabIndex = 72
        Me.LblAdminCheckRecId.Text = "recId"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(40, 469)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(59, 15)
        Me.Label36.TabIndex = 71
        Me.Label36.Text = "ID Type:"
        '
        'LblAdminCheckRecName
        '
        Me.LblAdminCheckRecName.AutoSize = True
        Me.LblAdminCheckRecName.Location = New System.Drawing.Point(152, 372)
        Me.LblAdminCheckRecName.Name = "LblAdminCheckRecName"
        Me.LblAdminCheckRecName.Size = New System.Drawing.Size(50, 13)
        Me.LblAdminCheckRecName.TabIndex = 70
        Me.LblAdminCheckRecName.Text = "recName"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(36, 370)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(109, 15)
        Me.Label37.TabIndex = 69
        Me.Label37.Text = "Receiver Name:"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Maroon
        Me.Label41.Location = New System.Drawing.Point(32, 17)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(179, 16)
        Me.Label41.TabIndex = 68
        Me.Label41.Text = "SENDER INFORMATION"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.LblAdminCheckAmountRemit)
        Me.GroupBox5.Controls.Add(Me.Label78)
        Me.GroupBox5.Controls.Add(Me.LblAdminCheckCharge)
        Me.GroupBox5.Controls.Add(Me.Label81)
        Me.GroupBox5.Controls.Add(Me.LblAdminCheckTotal)
        Me.GroupBox5.Location = New System.Drawing.Point(39, 255)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(662, 66)
        Me.GroupBox5.TabIndex = 66
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "AMOUNT PAYABLE:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(18, 24)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(112, 15)
        Me.Label25.TabIndex = 20
        Me.Label25.Text = "Amount to remit:"
        '
        'LblAdminCheckAmountRemit
        '
        Me.LblAdminCheckAmountRemit.AutoSize = True
        Me.LblAdminCheckAmountRemit.Location = New System.Drawing.Point(140, 26)
        Me.LblAdminCheckAmountRemit.Name = "LblAdminCheckAmountRemit"
        Me.LblAdminCheckAmountRemit.Size = New System.Drawing.Size(29, 13)
        Me.LblAdminCheckAmountRemit.TabIndex = 21
        Me.LblAdminCheckAmountRemit.Text = "remit"
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.Location = New System.Drawing.Point(207, 24)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(57, 15)
        Me.Label78.TabIndex = 22
        Me.Label78.Text = "Charge:"
        '
        'LblAdminCheckCharge
        '
        Me.LblAdminCheckCharge.AutoSize = True
        Me.LblAdminCheckCharge.Location = New System.Drawing.Point(270, 26)
        Me.LblAdminCheckCharge.Name = "LblAdminCheckCharge"
        Me.LblAdminCheckCharge.Size = New System.Drawing.Size(40, 13)
        Me.LblAdminCheckCharge.TabIndex = 23
        Me.LblAdminCheckCharge.Text = "charge"
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.Location = New System.Drawing.Point(347, 24)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(95, 15)
        Me.Label81.TabIndex = 24
        Me.Label81.Text = "Total Amount:"
        '
        'LblAdminCheckTotal
        '
        Me.LblAdminCheckTotal.AutoSize = True
        Me.LblAdminCheckTotal.Location = New System.Drawing.Point(451, 26)
        Me.LblAdminCheckTotal.Name = "LblAdminCheckTotal"
        Me.LblAdminCheckTotal.Size = New System.Drawing.Size(27, 13)
        Me.LblAdminCheckTotal.TabIndex = 25
        Me.LblAdminCheckTotal.Text = "total"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label64)
        Me.GroupBox4.Controls.Add(Me.LblAdminCheckIssue)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.LblAdminCheckExpiry)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.LblAdminCheckIssuePlace)
        Me.GroupBox4.Location = New System.Drawing.Point(485, 60)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(216, 174)
        Me.GroupBox4.TabIndex = 65
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "DATE INFORMATION:"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(6, 37)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(79, 15)
        Me.Label64.TabIndex = 14
        Me.Label64.Text = "Issue Date:"
        '
        'LblAdminCheckIssue
        '
        Me.LblAdminCheckIssue.AutoSize = True
        Me.LblAdminCheckIssue.Location = New System.Drawing.Point(105, 39)
        Me.LblAdminCheckIssue.Name = "LblAdminCheckIssue"
        Me.LblAdminCheckIssue.Size = New System.Drawing.Size(31, 13)
        Me.LblAdminCheckIssue.TabIndex = 15
        Me.LblAdminCheckIssue.Text = "issue"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(5, 74)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(84, 15)
        Me.Label26.TabIndex = 16
        Me.Label26.Text = "Expiry Date:"
        '
        'LblAdminCheckExpiry
        '
        Me.LblAdminCheckExpiry.AutoSize = True
        Me.LblAdminCheckExpiry.Location = New System.Drawing.Point(105, 76)
        Me.LblAdminCheckExpiry.Name = "LblAdminCheckExpiry"
        Me.LblAdminCheckExpiry.Size = New System.Drawing.Size(34, 13)
        Me.LblAdminCheckExpiry.TabIndex = 17
        Me.LblAdminCheckExpiry.Text = "expiry"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(6, 116)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(85, 15)
        Me.Label27.TabIndex = 18
        Me.Label27.Text = "Issue Place:"
        '
        'LblAdminCheckIssuePlace
        '
        Me.LblAdminCheckIssuePlace.AutoSize = True
        Me.LblAdminCheckIssuePlace.Location = New System.Drawing.Point(44, 141)
        Me.LblAdminCheckIssuePlace.Name = "LblAdminCheckIssuePlace"
        Me.LblAdminCheckIssuePlace.Size = New System.Drawing.Size(58, 13)
        Me.LblAdminCheckIssuePlace.TabIndex = 19
        Me.LblAdminCheckIssuePlace.Text = "issuePlace"
        '
        'LblAdminCheckCustRel
        '
        Me.LblAdminCheckCustRel.AutoSize = True
        Me.LblAdminCheckCustRel.Location = New System.Drawing.Point(204, 223)
        Me.LblAdminCheckCustRel.Name = "LblAdminCheckCustRel"
        Me.LblAdminCheckCustRel.Size = New System.Drawing.Size(43, 13)
        Me.LblAdminCheckCustRel.TabIndex = 64
        Me.LblAdminCheckCustRel.Text = "custRel"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(36, 219)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(163, 15)
        Me.Label48.TabIndex = 63
        Me.Label48.Text = "Relationship to receiver:"
        '
        'LblAdminCheckAddress
        '
        Me.LblAdminCheckAddress.AutoSize = True
        Me.LblAdminCheckAddress.Location = New System.Drawing.Point(103, 113)
        Me.LblAdminCheckAddress.Name = "LblAdminCheckAddress"
        Me.LblAdminCheckAddress.Size = New System.Drawing.Size(44, 13)
        Me.LblAdminCheckAddress.TabIndex = 62
        Me.LblAdminCheckAddress.Text = "address"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(33, 111)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(62, 15)
        Me.Label45.TabIndex = 61
        Me.Label45.Text = "Address:"
        '
        'LblAdminCheckMob
        '
        Me.LblAdminCheckMob.AutoSize = True
        Me.LblAdminCheckMob.Location = New System.Drawing.Point(150, 136)
        Me.LblAdminCheckMob.Name = "LblAdminCheckMob"
        Me.LblAdminCheckMob.Size = New System.Drawing.Size(43, 13)
        Me.LblAdminCheckMob.TabIndex = 60
        Me.LblAdminCheckMob.Text = "mobNO"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(34, 134)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(110, 15)
        Me.Label42.TabIndex = 59
        Me.Label42.Text = "Mobile Number:"
        '
        'LblAdminCheckPurpose
        '
        Me.LblAdminCheckPurpose.AutoSize = True
        Me.LblAdminCheckPurpose.Location = New System.Drawing.Point(107, 195)
        Me.LblAdminCheckPurpose.Name = "LblAdminCheckPurpose"
        Me.LblAdminCheckPurpose.Size = New System.Drawing.Size(45, 13)
        Me.LblAdminCheckPurpose.TabIndex = 58
        Me.LblAdminCheckPurpose.Text = "purpose"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(36, 193)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(64, 15)
        Me.Label28.TabIndex = 57
        Me.Label28.Text = "Purpose:"
        '
        'LblAdminCheckCustName
        '
        Me.LblAdminCheckCustName.AutoSize = True
        Me.LblAdminCheckCustName.Location = New System.Drawing.Point(152, 91)
        Me.LblAdminCheckCustName.Name = "LblAdminCheckCustName"
        Me.LblAdminCheckCustName.Size = New System.Drawing.Size(55, 13)
        Me.LblAdminCheckCustName.TabIndex = 56
        Me.LblAdminCheckCustName.Text = "custName"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(32, 89)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(114, 15)
        Me.Label33.TabIndex = 55
        Me.Label33.Text = "Customer Name:"
        '
        'LblAdminCheckIDtype
        '
        Me.LblAdminCheckIDtype.AutoSize = True
        Me.LblAdminCheckIDtype.Location = New System.Drawing.Point(99, 174)
        Me.LblAdminCheckIDtype.Name = "LblAdminCheckIDtype"
        Me.LblAdminCheckIDtype.Size = New System.Drawing.Size(39, 13)
        Me.LblAdminCheckIDtype.TabIndex = 54
        Me.LblAdminCheckIDtype.Text = "idType"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(34, 172)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(59, 15)
        Me.Label30.TabIndex = 53
        Me.Label30.Text = "ID Type:"
        '
        'LblAdminCheckRefNo
        '
        Me.LblAdminCheckRefNo.AutoSize = True
        Me.LblAdminCheckRefNo.Location = New System.Drawing.Point(170, 44)
        Me.LblAdminCheckRefNo.Name = "LblAdminCheckRefNo"
        Me.LblAdminCheckRefNo.Size = New System.Drawing.Size(33, 13)
        Me.LblAdminCheckRefNo.TabIndex = 52
        Me.LblAdminCheckRefNo.Text = "refNo"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(32, 42)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(132, 15)
        Me.Label31.TabIndex = 51
        Me.Label31.Text = "Reference Number:"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.PanelAdminRemitPrintReceipt)
        Me.TabPage5.Location = New System.Drawing.Point(4, 34)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(745, 593)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "PRINT RECEIPT"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'PanelAdminRemitPrintReceipt
        '
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.LblAdminRecNameReceipt)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.LbltotalAmount)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.Lblcharge)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.Lblamount)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.LblexpiryDate)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.LblissuePlace)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.LblissueDate)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.LblCustName)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.LblRefNo)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.Label88)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.Label89)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.Label90)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.Label91)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.Label92)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.Label93)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.Label94)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.Label95)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.Label96)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.Label97)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.Label98)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.Label99)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.LabelAdminAmtInWordsReceipt)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.Label100)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.Label102)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.Label104)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.Label106)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.Label108)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.Label110)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.Label111)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.Label114)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.Label116)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.Label117)
        Me.PanelAdminRemitPrintReceipt.Controls.Add(Me.Label119)
        Me.PanelAdminRemitPrintReceipt.Location = New System.Drawing.Point(6, 6)
        Me.PanelAdminRemitPrintReceipt.Name = "PanelAdminRemitPrintReceipt"
        Me.PanelAdminRemitPrintReceipt.Size = New System.Drawing.Size(733, 542)
        Me.PanelAdminRemitPrintReceipt.TabIndex = 0
        '
        'LblAdminRecNameReceipt
        '
        Me.LblAdminRecNameReceipt.AutoSize = True
        Me.LblAdminRecNameReceipt.Location = New System.Drawing.Point(157, 198)
        Me.LblAdminRecNameReceipt.Name = "LblAdminRecNameReceipt"
        Me.LblAdminRecNameReceipt.Size = New System.Drawing.Size(50, 13)
        Me.LblAdminRecNameReceipt.TabIndex = 149
        Me.LblAdminRecNameReceipt.Text = "recName"
        '
        'LbltotalAmount
        '
        Me.LbltotalAmount.AutoSize = True
        Me.LbltotalAmount.Location = New System.Drawing.Point(171, 312)
        Me.LbltotalAmount.Name = "LbltotalAmount"
        Me.LbltotalAmount.Size = New System.Drawing.Size(63, 13)
        Me.LbltotalAmount.TabIndex = 148
        Me.LbltotalAmount.Text = "totalAmount"
        '
        'Lblcharge
        '
        Me.Lblcharge.AutoSize = True
        Me.Lblcharge.Location = New System.Drawing.Point(88, 283)
        Me.Lblcharge.Name = "Lblcharge"
        Me.Lblcharge.Size = New System.Drawing.Size(40, 13)
        Me.Lblcharge.TabIndex = 147
        Me.Lblcharge.Text = "charge"
        '
        'Lblamount
        '
        Me.Lblamount.AutoSize = True
        Me.Lblamount.Location = New System.Drawing.Point(88, 267)
        Me.Lblamount.Name = "Lblamount"
        Me.Lblamount.Size = New System.Drawing.Size(42, 13)
        Me.Lblamount.TabIndex = 146
        Me.Lblamount.Text = "amount"
        '
        'LblexpiryDate
        '
        Me.LblexpiryDate.AutoSize = True
        Me.LblexpiryDate.Location = New System.Drawing.Point(550, 221)
        Me.LblexpiryDate.Name = "LblexpiryDate"
        Me.LblexpiryDate.Size = New System.Drawing.Size(57, 13)
        Me.LblexpiryDate.TabIndex = 145
        Me.LblexpiryDate.Text = "expiryDate"
        '
        'LblissuePlace
        '
        Me.LblissuePlace.AutoSize = True
        Me.LblissuePlace.Location = New System.Drawing.Point(549, 176)
        Me.LblissuePlace.Name = "LblissuePlace"
        Me.LblissuePlace.Size = New System.Drawing.Size(58, 13)
        Me.LblissuePlace.TabIndex = 143
        Me.LblissuePlace.Text = "issuePlace"
        '
        'LblissueDate
        '
        Me.LblissueDate.AutoSize = True
        Me.LblissueDate.Location = New System.Drawing.Point(549, 198)
        Me.LblissueDate.Name = "LblissueDate"
        Me.LblissueDate.Size = New System.Drawing.Size(54, 13)
        Me.LblissueDate.TabIndex = 144
        Me.LblissueDate.Text = "issueDate"
        '
        'LblCustName
        '
        Me.LblCustName.AutoSize = True
        Me.LblCustName.Location = New System.Drawing.Point(157, 178)
        Me.LblCustName.Name = "LblCustName"
        Me.LblCustName.Size = New System.Drawing.Size(55, 13)
        Me.LblCustName.TabIndex = 142
        Me.LblCustName.Text = "custName"
        '
        'LblRefNo
        '
        Me.LblRefNo.AutoSize = True
        Me.LblRefNo.Location = New System.Drawing.Point(157, 148)
        Me.LblRefNo.Name = "LblRefNo"
        Me.LblRefNo.Size = New System.Drawing.Size(66, 13)
        Me.LblRefNo.TabIndex = 141
        Me.LblRefNo.Text = "referenceNo"
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.Location = New System.Drawing.Point(30, 478)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(213, 9)
        Me.Label88.TabIndex = 140
        Me.Label88.Text = "the receiver failed to claim it within the range of specified date."
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.Location = New System.Drawing.Point(29, 468)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(166, 9)
        Me.Label89.TabIndex = 139
        Me.Label89.Text = "The company will not allow any refund incase of"
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.Location = New System.Drawing.Point(30, 452)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(78, 9)
        Me.Label90.TabIndex = 138
        Me.Label90.Text = "this transaction void.  "
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label91.Location = New System.Drawing.Point(30, 442)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(187, 9)
        Me.Label91.TabIndex = 137
        Me.Label91.Text = "Failure to claim the money by the receiver will subject"
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.Location = New System.Drawing.Point(29, 433)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(206, 9)
        Me.Label92.TabIndex = 136
        Me.Label92.Text = "This transaction is only valid upon the specified date herein. "
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.Location = New System.Drawing.Point(29, 417)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(169, 13)
        Me.Label93.TabIndex = 135
        Me.Label93.Text = "TERMS AND CONDITIONS :"
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.ForeColor = System.Drawing.Color.Maroon
        Me.Label94.Location = New System.Drawing.Point(29, 119)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(651, 13)
        Me.Label94.TabIndex = 134
        Me.Label94.Text = "_________________________________________________________________________________" &
    "___________"
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label95.Location = New System.Drawing.Point(452, 373)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(175, 13)
        Me.Label95.TabIndex = 133
        Me.Label95.Text = "________________________"
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label96.Location = New System.Drawing.Point(455, 391)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(167, 13)
        Me.Label96.TabIndex = 132
        Me.Label96.Text = "Signature over printed name"
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.Location = New System.Drawing.Point(32, 83)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(203, 13)
        Me.Label97.TabIndex = 131
        Me.Label97.Text = "43 SHAW BLVD. MANDALUYONG CITY"
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.Location = New System.Drawing.Point(32, 101)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(137, 13)
        Me.Label98.TabIndex = 130
        Me.Label98.Text = "BIR NO. : 123-987-437-000"
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label99.Location = New System.Drawing.Point(29, 66)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(235, 13)
        Me.Label99.TabIndex = 129
        Me.Label99.Text = "CONNECT TECH MONEY REMITTANCE"
        '
        'LabelAdminAmtInWordsReceipt
        '
        Me.LabelAdminAmtInWordsReceipt.AutoSize = True
        Me.LabelAdminAmtInWordsReceipt.Location = New System.Drawing.Point(149, 338)
        Me.LabelAdminAmtInWordsReceipt.Name = "LabelAdminAmtInWordsReceipt"
        Me.LabelAdminAmtInWordsReceipt.Size = New System.Drawing.Size(63, 13)
        Me.LabelAdminAmtInWordsReceipt.TabIndex = 128
        Me.LabelAdminAmtInWordsReceipt.Text = "totalAmount"
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.Location = New System.Drawing.Point(29, 338)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(108, 13)
        Me.Label100.TabIndex = 127
        Me.Label100.Text = "Amount in words :"
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label102.Location = New System.Drawing.Point(29, 198)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(98, 13)
        Me.Label102.TabIndex = 125
        Me.Label102.Text = "Receiver Name:"
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label104.Location = New System.Drawing.Point(25, 312)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(135, 13)
        Me.Label104.TabIndex = 123
        Me.Label104.Text = "Total Amount Payable:"
        '
        'Label106
        '
        Me.Label106.AutoSize = True
        Me.Label106.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label106.Location = New System.Drawing.Point(29, 283)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(51, 13)
        Me.Label106.TabIndex = 121
        Me.Label106.Text = "Charge:"
        '
        'Label108
        '
        Me.Label108.AutoSize = True
        Me.Label108.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label108.Location = New System.Drawing.Point(29, 267)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(53, 13)
        Me.Label108.TabIndex = 119
        Me.Label108.Text = "Amount:"
        '
        'Label110
        '
        Me.Label110.AutoSize = True
        Me.Label110.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label110.Location = New System.Drawing.Point(466, 176)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(77, 13)
        Me.Label110.TabIndex = 113
        Me.Label110.Text = "Issue Place:"
        '
        'Label111
        '
        Me.Label111.AutoSize = True
        Me.Label111.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label111.Location = New System.Drawing.Point(466, 221)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(76, 13)
        Me.Label111.TabIndex = 117
        Me.Label111.Text = "Expiry Date:"
        '
        'Label114
        '
        Me.Label114.AutoSize = True
        Me.Label114.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label114.Location = New System.Drawing.Point(466, 199)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(72, 13)
        Me.Label114.TabIndex = 115
        Me.Label114.Text = "Issue Date:"
        '
        'Label116
        '
        Me.Label116.AutoSize = True
        Me.Label116.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label116.Location = New System.Drawing.Point(29, 178)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(96, 13)
        Me.Label116.TabIndex = 111
        Me.Label116.Text = "Received From:"
        '
        'Label117
        '
        Me.Label117.AutoSize = True
        Me.Label117.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label117.ForeColor = System.Drawing.Color.Maroon
        Me.Label117.Location = New System.Drawing.Point(27, 34)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(173, 25)
        Me.Label117.TabIndex = 110
        Me.Label117.Text = "Official Receipt"
        '
        'Label119
        '
        Me.Label119.AutoSize = True
        Me.Label119.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label119.Location = New System.Drawing.Point(28, 147)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(117, 13)
        Me.Label119.TabIndex = 108
        Me.Label119.Text = "Reference Number:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
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
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 690)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1362, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(150, 16)
        Me.ToolStripProgressBar1.Visible = False
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(130, 17)
        Me.ToolStripStatusLabel1.Text = "Data successfully saved"
        Me.ToolStripStatusLabel1.Visible = False
        '
        'PanelClaimTransaction
        '
        Me.PanelClaimTransaction.Controls.Add(Me.TabControl3)
        Me.PanelClaimTransaction.Location = New System.Drawing.Point(186, 50)
        Me.PanelClaimTransaction.Name = "PanelClaimTransaction"
        Me.PanelClaimTransaction.Size = New System.Drawing.Size(786, 630)
        Me.PanelClaimTransaction.TabIndex = 12
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPageClaim)
        Me.TabControl3.Controls.Add(Me.TabPageClaimReceipt)
        Me.TabControl3.ItemSize = New System.Drawing.Size(200, 30)
        Me.TabControl3.Location = New System.Drawing.Point(3, 17)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(743, 620)
        Me.TabControl3.TabIndex = 0
        '
        'TabPageClaim
        '
        Me.TabPageClaim.Controls.Add(Me.GroupBox8)
        Me.TabPageClaim.Controls.Add(Me.TxtClaimIDtype)
        Me.TabPageClaim.Controls.Add(Me.GroupBox7)
        Me.TabPageClaim.Controls.Add(Me.TxtClaimAddress)
        Me.TabPageClaim.Controls.Add(Me.Label52)
        Me.TabPageClaim.Controls.Add(Me.TxtClaimRelationship)
        Me.TabPageClaim.Controls.Add(Me.Label53)
        Me.TabPageClaim.Controls.Add(Me.TxtClaimMobile)
        Me.TabPageClaim.Controls.Add(Me.Label54)
        Me.TabPageClaim.Controls.Add(Me.Label55)
        Me.TabPageClaim.Controls.Add(Me.TxtClaimName)
        Me.TabPageClaim.Controls.Add(Me.Label56)
        Me.TabPageClaim.Controls.Add(Me.TxtClaimRefNo)
        Me.TabPageClaim.Controls.Add(Me.BtnSearch)
        Me.TabPageClaim.Location = New System.Drawing.Point(4, 34)
        Me.TabPageClaim.Name = "TabPageClaim"
        Me.TabPageClaim.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageClaim.Size = New System.Drawing.Size(735, 582)
        Me.TabPageClaim.TabIndex = 0
        Me.TabPageClaim.Text = "CLAIM TRANSACTION"
        Me.TabPageClaim.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label58)
        Me.GroupBox8.Controls.Add(Me.TxtClaimStatus)
        Me.GroupBox8.Controls.Add(Me.Label57)
        Me.GroupBox8.Controls.Add(Me.TxtClaimExpiryDate)
        Me.GroupBox8.Controls.Add(Me.Label59)
        Me.GroupBox8.Controls.Add(Me.TxtDateIssueClaim)
        Me.GroupBox8.Location = New System.Drawing.Point(38, 423)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(579, 137)
        Me.GroupBox8.TabIndex = 49
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "TRANSACTION STATUS:"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(17, 74)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(92, 16)
        Me.Label58.TabIndex = 52
        Me.Label58.Text = "Expiry Date:"
        '
        'TxtClaimStatus
        '
        Me.TxtClaimStatus.Enabled = False
        Me.TxtClaimStatus.Location = New System.Drawing.Point(329, 45)
        Me.TxtClaimStatus.Name = "TxtClaimStatus"
        Me.TxtClaimStatus.Size = New System.Drawing.Size(173, 20)
        Me.TxtClaimStatus.TabIndex = 51
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(326, 25)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(55, 16)
        Me.Label57.TabIndex = 50
        Me.Label57.Text = "Status:"
        '
        'TxtClaimExpiryDate
        '
        Me.TxtClaimExpiryDate.Enabled = False
        Me.TxtClaimExpiryDate.Location = New System.Drawing.Point(17, 95)
        Me.TxtClaimExpiryDate.Name = "TxtClaimExpiryDate"
        Me.TxtClaimExpiryDate.Size = New System.Drawing.Size(173, 20)
        Me.TxtClaimExpiryDate.TabIndex = 49
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(15, 28)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(86, 16)
        Me.Label59.TabIndex = 39
        Me.Label59.Text = "Issue Date:"
        '
        'TxtClaimIDtype
        '
        Me.TxtClaimIDtype.Enabled = False
        Me.TxtClaimIDtype.Location = New System.Drawing.Point(348, 86)
        Me.TxtClaimIDtype.Name = "TxtClaimIDtype"
        Me.TxtClaimIDtype.Size = New System.Drawing.Size(173, 20)
        Me.TxtClaimIDtype.TabIndex = 48
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.TxtClaimCorrespondent)
        Me.GroupBox7.Controls.Add(Me.TxtClaimAmount)
        Me.GroupBox7.Controls.Add(Me.TxtClaimBranch)
        Me.GroupBox7.Controls.Add(Me.Label43)
        Me.GroupBox7.Controls.Add(Me.Label46)
        Me.GroupBox7.Controls.Add(Me.Label50)
        Me.GroupBox7.Location = New System.Drawing.Point(38, 250)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(579, 167)
        Me.GroupBox7.TabIndex = 42
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "CORRESPONDENT, BRANCH AND AMOUNT"
        '
        'TxtClaimCorrespondent
        '
        Me.TxtClaimCorrespondent.Enabled = False
        Me.TxtClaimCorrespondent.Location = New System.Drawing.Point(18, 48)
        Me.TxtClaimCorrespondent.Name = "TxtClaimCorrespondent"
        Me.TxtClaimCorrespondent.Size = New System.Drawing.Size(173, 20)
        Me.TxtClaimCorrespondent.TabIndex = 49
        '
        'TxtClaimAmount
        '
        Me.TxtClaimAmount.Enabled = False
        Me.TxtClaimAmount.Location = New System.Drawing.Point(308, 48)
        Me.TxtClaimAmount.Name = "TxtClaimAmount"
        Me.TxtClaimAmount.Size = New System.Drawing.Size(218, 20)
        Me.TxtClaimAmount.TabIndex = 16
        Me.TxtClaimAmount.Tag = "This is required field..."
        '
        'TxtClaimBranch
        '
        Me.TxtClaimBranch.Enabled = False
        Me.TxtClaimBranch.Location = New System.Drawing.Point(18, 114)
        Me.TxtClaimBranch.Name = "TxtClaimBranch"
        Me.TxtClaimBranch.Size = New System.Drawing.Size(364, 20)
        Me.TxtClaimBranch.TabIndex = 17
        Me.TxtClaimBranch.Tag = "This is required field..."
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(306, 29)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(128, 16)
        Me.Label43.TabIndex = 39
        Me.Label43.Text = "Amount received:"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(15, 95)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(122, 16)
        Me.Label46.TabIndex = 39
        Me.Label46.Text = "Branch Address:"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(15, 28)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(114, 16)
        Me.Label50.TabIndex = 39
        Me.Label50.Text = "Correspondent:"
        '
        'TxtClaimAddress
        '
        Me.TxtClaimAddress.Enabled = False
        Me.TxtClaimAddress.Location = New System.Drawing.Point(35, 200)
        Me.TxtClaimAddress.Name = "TxtClaimAddress"
        Me.TxtClaimAddress.Size = New System.Drawing.Size(364, 20)
        Me.TxtClaimAddress.TabIndex = 40
        Me.TxtClaimAddress.Tag = "This is required field..."
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(32, 181)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(70, 16)
        Me.Label52.TabIndex = 47
        Me.Label52.Text = "Address:"
        '
        'TxtClaimRelationship
        '
        Me.TxtClaimRelationship.Enabled = False
        Me.TxtClaimRelationship.Location = New System.Drawing.Point(35, 143)
        Me.TxtClaimRelationship.Name = "TxtClaimRelationship"
        Me.TxtClaimRelationship.Size = New System.Drawing.Size(218, 20)
        Me.TxtClaimRelationship.TabIndex = 38
        Me.TxtClaimRelationship.Tag = "This is required field..."
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(32, 124)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(193, 16)
        Me.Label53.TabIndex = 46
        Me.Label53.Text = "Relationship to the sender:"
        '
        'TxtClaimMobile
        '
        Me.TxtClaimMobile.Enabled = False
        Me.TxtClaimMobile.Location = New System.Drawing.Point(347, 143)
        Me.TxtClaimMobile.Name = "TxtClaimMobile"
        Me.TxtClaimMobile.Size = New System.Drawing.Size(218, 20)
        Me.TxtClaimMobile.TabIndex = 39
        Me.TxtClaimMobile.Tag = "This is required field..."
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(345, 124)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(117, 16)
        Me.Label54.TabIndex = 45
        Me.Label54.Text = "Mobile Number:"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(345, 67)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(67, 16)
        Me.Label55.TabIndex = 44
        Me.Label55.Text = "ID Type:"
        '
        'TxtClaimName
        '
        Me.TxtClaimName.Enabled = False
        Me.TxtClaimName.Location = New System.Drawing.Point(35, 86)
        Me.TxtClaimName.Name = "TxtClaimName"
        Me.TxtClaimName.Size = New System.Drawing.Size(218, 20)
        Me.TxtClaimName.TabIndex = 37
        Me.TxtClaimName.Tag = "This is required field..."
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(32, 67)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(120, 16)
        Me.Label56.TabIndex = 43
        Me.Label56.Text = "Receiver Name:"
        '
        'TxtClaimRefNo
        '
        Me.TxtClaimRefNo.Enabled = False
        Me.TxtClaimRefNo.Location = New System.Drawing.Point(233, 26)
        Me.TxtClaimRefNo.Name = "TxtClaimRefNo"
        Me.TxtClaimRefNo.Size = New System.Drawing.Size(173, 20)
        Me.TxtClaimRefNo.TabIndex = 4
        '
        'BtnSearch
        '
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSearch.Location = New System.Drawing.Point(36, 19)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(178, 32)
        Me.BtnSearch.TabIndex = 3
        Me.BtnSearch.Text = "SEARCH REFERENCE NO."
        Me.BtnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'TabPageClaimReceipt
        '
        Me.TabPageClaimReceipt.Controls.Add(Me.PanelAdminClaimReceipt)
        Me.TabPageClaimReceipt.Location = New System.Drawing.Point(4, 34)
        Me.TabPageClaimReceipt.Name = "TabPageClaimReceipt"
        Me.TabPageClaimReceipt.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageClaimReceipt.Size = New System.Drawing.Size(735, 582)
        Me.TabPageClaimReceipt.TabIndex = 1
        Me.TabPageClaimReceipt.Text = "RECEIPT"
        Me.TabPageClaimReceipt.UseVisualStyleBackColor = True
        '
        'PanelAdminClaimReceipt
        '
        Me.PanelAdminClaimReceipt.Controls.Add(Me.LabelcAddress)
        Me.PanelAdminClaimReceipt.Controls.Add(Me.Label70)
        Me.PanelAdminClaimReceipt.Controls.Add(Me.LabelcMobileNo)
        Me.PanelAdminClaimReceipt.Controls.Add(Me.Label74)
        Me.PanelAdminClaimReceipt.Controls.Add(Me.LabelcRefNo)
        Me.PanelAdminClaimReceipt.Controls.Add(Me.LabelcName)
        Me.PanelAdminClaimReceipt.Controls.Add(Me.LabelcStatus)
        Me.PanelAdminClaimReceipt.Controls.Add(Me.Label71)
        Me.PanelAdminClaimReceipt.Controls.Add(Me.LabelcBranch)
        Me.PanelAdminClaimReceipt.Controls.Add(Me.Label66)
        Me.PanelAdminClaimReceipt.Controls.Add(Me.LabelcCorrespondent)
        Me.PanelAdminClaimReceipt.Controls.Add(Me.Label68)
        Me.PanelAdminClaimReceipt.Controls.Add(Me.LblAdminClaimAmtInWords)
        Me.PanelAdminClaimReceipt.Controls.Add(Me.LabelcAmount)
        Me.PanelAdminClaimReceipt.Controls.Add(Me.Label118)
        Me.PanelAdminClaimReceipt.Controls.Add(Me.Label120)
        Me.PanelAdminClaimReceipt.Controls.Add(Me.Label121)
        Me.PanelAdminClaimReceipt.Controls.Add(Me.Label122)
        Me.PanelAdminClaimReceipt.Controls.Add(Me.Label123)
        Me.PanelAdminClaimReceipt.Controls.Add(Me.Label124)
        Me.PanelAdminClaimReceipt.Controls.Add(Me.Label125)
        Me.PanelAdminClaimReceipt.Controls.Add(Me.Label126)
        Me.PanelAdminClaimReceipt.Controls.Add(Me.Label127)
        Me.PanelAdminClaimReceipt.Controls.Add(Me.Label128)
        Me.PanelAdminClaimReceipt.Controls.Add(Me.Label129)
        Me.PanelAdminClaimReceipt.Controls.Add(Me.Label130)
        Me.PanelAdminClaimReceipt.Controls.Add(Me.Label132)
        Me.PanelAdminClaimReceipt.Controls.Add(Me.Label133)
        Me.PanelAdminClaimReceipt.Controls.Add(Me.Label134)
        Me.PanelAdminClaimReceipt.Controls.Add(Me.Label141)
        Me.PanelAdminClaimReceipt.Controls.Add(Me.Label142)
        Me.PanelAdminClaimReceipt.Location = New System.Drawing.Point(6, 6)
        Me.PanelAdminClaimReceipt.Name = "PanelAdminClaimReceipt"
        Me.PanelAdminClaimReceipt.Size = New System.Drawing.Size(723, 554)
        Me.PanelAdminClaimReceipt.TabIndex = 0
        '
        'LabelcAddress
        '
        Me.LabelcAddress.AutoSize = True
        Me.LabelcAddress.Location = New System.Drawing.Point(110, 219)
        Me.LabelcAddress.Name = "LabelcAddress"
        Me.LabelcAddress.Size = New System.Drawing.Size(51, 13)
        Me.LabelcAddress.TabIndex = 249
        Me.LabelcAddress.Text = "cAddress"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(48, 219)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(56, 13)
        Me.Label70.TabIndex = 248
        Me.Label70.Text = "Address:"
        '
        'LabelcMobileNo
        '
        Me.LabelcMobileNo.AutoSize = True
        Me.LabelcMobileNo.Location = New System.Drawing.Point(152, 199)
        Me.LabelcMobileNo.Name = "LabelcMobileNo"
        Me.LabelcMobileNo.Size = New System.Drawing.Size(58, 13)
        Me.LabelcMobileNo.TabIndex = 247
        Me.LabelcMobileNo.Text = "cMobileNo"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.Location = New System.Drawing.Point(48, 199)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(95, 13)
        Me.Label74.TabIndex = 246
        Me.Label74.Text = "Mobile Number:"
        '
        'LabelcRefNo
        '
        Me.LabelcRefNo.AutoSize = True
        Me.LabelcRefNo.Location = New System.Drawing.Point(172, 148)
        Me.LabelcRefNo.Name = "LabelcRefNo"
        Me.LabelcRefNo.Size = New System.Drawing.Size(44, 13)
        Me.LabelcRefNo.TabIndex = 245
        Me.LabelcRefNo.Text = "cRefNo"
        '
        'LabelcName
        '
        Me.LabelcName.AutoSize = True
        Me.LabelcName.Location = New System.Drawing.Point(152, 179)
        Me.LabelcName.Name = "LabelcName"
        Me.LabelcName.Size = New System.Drawing.Size(41, 13)
        Me.LabelcName.TabIndex = 244
        Me.LabelcName.Text = "cName"
        '
        'LabelcStatus
        '
        Me.LabelcStatus.AutoSize = True
        Me.LabelcStatus.Location = New System.Drawing.Point(105, 300)
        Me.LabelcStatus.Name = "LabelcStatus"
        Me.LabelcStatus.Size = New System.Drawing.Size(43, 13)
        Me.LabelcStatus.TabIndex = 243
        Me.LabelcStatus.Text = "cStatus"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(48, 300)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(47, 13)
        Me.Label71.TabIndex = 242
        Me.Label71.Text = "Status:"
        '
        'LabelcBranch
        '
        Me.LabelcBranch.AutoSize = True
        Me.LabelcBranch.Location = New System.Drawing.Point(105, 277)
        Me.LabelcBranch.Name = "LabelcBranch"
        Me.LabelcBranch.Size = New System.Drawing.Size(47, 13)
        Me.LabelcBranch.TabIndex = 241
        Me.LabelcBranch.Text = "cBranch"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(48, 277)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(51, 13)
        Me.Label66.TabIndex = 240
        Me.Label66.Text = "Branch:"
        '
        'LabelcCorrespondent
        '
        Me.LabelcCorrespondent.AutoSize = True
        Me.LabelcCorrespondent.Location = New System.Drawing.Point(143, 257)
        Me.LabelcCorrespondent.Name = "LabelcCorrespondent"
        Me.LabelcCorrespondent.Size = New System.Drawing.Size(82, 13)
        Me.LabelcCorrespondent.TabIndex = 239
        Me.LabelcCorrespondent.Text = "cCorrespondent"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(48, 257)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(93, 13)
        Me.Label68.TabIndex = 238
        Me.Label68.Text = "Correspondent:"
        '
        'LblAdminClaimAmtInWords
        '
        Me.LblAdminClaimAmtInWords.AutoSize = True
        Me.LblAdminClaimAmtInWords.Location = New System.Drawing.Point(189, 364)
        Me.LblAdminClaimAmtInWords.Name = "LblAdminClaimAmtInWords"
        Me.LblAdminClaimAmtInWords.Size = New System.Drawing.Size(49, 13)
        Me.LblAdminClaimAmtInWords.TabIndex = 237
        Me.LblAdminClaimAmtInWords.Text = "cAmount"
        '
        'LabelcAmount
        '
        Me.LabelcAmount.AutoSize = True
        Me.LabelcAmount.Location = New System.Drawing.Point(208, 341)
        Me.LabelcAmount.Name = "LabelcAmount"
        Me.LabelcAmount.Size = New System.Drawing.Size(49, 13)
        Me.LabelcAmount.TabIndex = 236
        Me.LabelcAmount.Text = "cAmount"
        '
        'Label118
        '
        Me.Label118.AutoSize = True
        Me.Label118.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label118.Location = New System.Drawing.Point(33, 529)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(213, 9)
        Me.Label118.TabIndex = 235
        Me.Label118.Text = "the receiver failed to claim it within the range of specified date."
        '
        'Label120
        '
        Me.Label120.AutoSize = True
        Me.Label120.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label120.Location = New System.Drawing.Point(32, 519)
        Me.Label120.Name = "Label120"
        Me.Label120.Size = New System.Drawing.Size(166, 9)
        Me.Label120.TabIndex = 234
        Me.Label120.Text = "The company will not allow any refund incase of"
        '
        'Label121
        '
        Me.Label121.AutoSize = True
        Me.Label121.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label121.Location = New System.Drawing.Point(33, 503)
        Me.Label121.Name = "Label121"
        Me.Label121.Size = New System.Drawing.Size(78, 9)
        Me.Label121.TabIndex = 233
        Me.Label121.Text = "this transaction void.  "
        '
        'Label122
        '
        Me.Label122.AutoSize = True
        Me.Label122.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label122.Location = New System.Drawing.Point(33, 493)
        Me.Label122.Name = "Label122"
        Me.Label122.Size = New System.Drawing.Size(187, 9)
        Me.Label122.TabIndex = 232
        Me.Label122.Text = "Failure to claim the money by the receiver will subject"
        '
        'Label123
        '
        Me.Label123.AutoSize = True
        Me.Label123.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label123.Location = New System.Drawing.Point(32, 484)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(206, 9)
        Me.Label123.TabIndex = 231
        Me.Label123.Text = "This transaction is only valid upon the specified date herein. "
        '
        'Label124
        '
        Me.Label124.AutoSize = True
        Me.Label124.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label124.Location = New System.Drawing.Point(32, 468)
        Me.Label124.Name = "Label124"
        Me.Label124.Size = New System.Drawing.Size(169, 13)
        Me.Label124.TabIndex = 230
        Me.Label124.Text = "TERMS AND CONDITIONS :"
        '
        'Label125
        '
        Me.Label125.AutoSize = True
        Me.Label125.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label125.ForeColor = System.Drawing.Color.Maroon
        Me.Label125.Location = New System.Drawing.Point(37, 121)
        Me.Label125.Name = "Label125"
        Me.Label125.Size = New System.Drawing.Size(651, 13)
        Me.Label125.TabIndex = 229
        Me.Label125.Text = "_________________________________________________________________________________" &
    "___________"
        '
        'Label126
        '
        Me.Label126.AutoSize = True
        Me.Label126.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label126.Location = New System.Drawing.Point(445, 440)
        Me.Label126.Name = "Label126"
        Me.Label126.Size = New System.Drawing.Size(175, 13)
        Me.Label126.TabIndex = 228
        Me.Label126.Text = "________________________"
        '
        'Label127
        '
        Me.Label127.AutoSize = True
        Me.Label127.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label127.Location = New System.Drawing.Point(448, 458)
        Me.Label127.Name = "Label127"
        Me.Label127.Size = New System.Drawing.Size(167, 13)
        Me.Label127.TabIndex = 227
        Me.Label127.Text = "Signature over printed name"
        '
        'Label128
        '
        Me.Label128.AutoSize = True
        Me.Label128.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label128.Location = New System.Drawing.Point(40, 85)
        Me.Label128.Name = "Label128"
        Me.Label128.Size = New System.Drawing.Size(203, 13)
        Me.Label128.TabIndex = 226
        Me.Label128.Text = "43 SHAW BLVD. MANDALUYONG CITY"
        '
        'Label129
        '
        Me.Label129.AutoSize = True
        Me.Label129.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label129.Location = New System.Drawing.Point(40, 103)
        Me.Label129.Name = "Label129"
        Me.Label129.Size = New System.Drawing.Size(137, 13)
        Me.Label129.TabIndex = 225
        Me.Label129.Text = "BIR NO. : 123-987-437-000"
        '
        'Label130
        '
        Me.Label130.AutoSize = True
        Me.Label130.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label130.Location = New System.Drawing.Point(37, 68)
        Me.Label130.Name = "Label130"
        Me.Label130.Size = New System.Drawing.Size(235, 13)
        Me.Label130.TabIndex = 224
        Me.Label130.Text = "CONNECT TECH MONEY REMITTANCE"
        '
        'Label132
        '
        Me.Label132.AutoSize = True
        Me.Label132.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label132.Location = New System.Drawing.Point(49, 364)
        Me.Label132.Name = "Label132"
        Me.Label132.Size = New System.Drawing.Size(108, 13)
        Me.Label132.TabIndex = 223
        Me.Label132.Text = "Amount in words :"
        '
        'Label133
        '
        Me.Label133.AutoSize = True
        Me.Label133.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label133.Location = New System.Drawing.Point(48, 179)
        Me.Label133.Name = "Label133"
        Me.Label133.Size = New System.Drawing.Size(98, 13)
        Me.Label133.TabIndex = 222
        Me.Label133.Text = "Receiver Name:"
        '
        'Label134
        '
        Me.Label134.AutoSize = True
        Me.Label134.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label134.Location = New System.Drawing.Point(49, 341)
        Me.Label134.Name = "Label134"
        Me.Label134.Size = New System.Drawing.Size(144, 13)
        Me.Label134.TabIndex = 221
        Me.Label134.Text = "Total Amount Received:"
        '
        'Label141
        '
        Me.Label141.AutoSize = True
        Me.Label141.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label141.ForeColor = System.Drawing.Color.Maroon
        Me.Label141.Location = New System.Drawing.Point(35, 36)
        Me.Label141.Name = "Label141"
        Me.Label141.Size = New System.Drawing.Size(289, 25)
        Me.Label141.TabIndex = 220
        Me.Label141.Text = "Claim Transaction Receipt"
        '
        'Label142
        '
        Me.Label142.AutoSize = True
        Me.Label142.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label142.Location = New System.Drawing.Point(48, 148)
        Me.Label142.Name = "Label142"
        Me.Label142.Size = New System.Drawing.Size(117, 13)
        Me.Label142.TabIndex = 219
        Me.Label142.Text = "Reference Number:"
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelDate.Location = New System.Drawing.Point(1113, 17)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(48, 20)
        Me.LabelDate.TabIndex = 13
        Me.LabelDate.Text = "DATE:"
        '
        'PanelControlContainer
        '
        Me.PanelControlContainer.Controls.Add(Me.Panel4)
        Me.PanelControlContainer.Controls.Add(Me.PanelHomeTools)
        Me.PanelControlContainer.Controls.Add(Me.Panel2)
        Me.PanelControlContainer.Controls.Add(Me.PanelRemitTools)
        Me.PanelControlContainer.Location = New System.Drawing.Point(972, 52)
        Me.PanelControlContainer.Name = "PanelControlContainer"
        Me.PanelControlContainer.Size = New System.Drawing.Size(316, 627)
        Me.PanelControlContainer.TabIndex = 14
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(978, 111)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(225, 576)
        Me.Panel4.TabIndex = 18
        '
        'PanelHomeTools
        '
        Me.PanelHomeTools.BackColor = System.Drawing.Color.Teal
        Me.PanelHomeTools.Controls.Add(Me.BtnPrintViewAdminStat)
        Me.PanelHomeTools.Controls.Add(Me.BtnPrintAdminStatus)
        Me.PanelHomeTools.Controls.Add(Me.Label60)
        Me.PanelHomeTools.Controls.Add(Me.BtnManageCustomers)
        Me.PanelHomeTools.Controls.Add(Me.BtnSearchSender)
        Me.PanelHomeTools.Controls.Add(Me.BtnSearchBeneficiary)
        Me.PanelHomeTools.Controls.Add(Me.BtnSearchStat)
        Me.PanelHomeTools.Location = New System.Drawing.Point(113, 0)
        Me.PanelHomeTools.Name = "PanelHomeTools"
        Me.PanelHomeTools.Size = New System.Drawing.Size(197, 627)
        Me.PanelHomeTools.TabIndex = 4
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
        Me.BtnPrintViewAdminStat.Location = New System.Drawing.Point(31, 326)
        Me.BtnPrintViewAdminStat.Name = "BtnPrintViewAdminStat"
        Me.BtnPrintViewAdminStat.Size = New System.Drawing.Size(139, 66)
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
        Me.BtnPrintAdminStatus.Location = New System.Drawing.Point(31, 230)
        Me.BtnPrintAdminStatus.Name = "BtnPrintAdminStatus"
        Me.BtnPrintAdminStatus.Size = New System.Drawing.Size(139, 66)
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
        Me.Label60.Location = New System.Drawing.Point(37, 73)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(124, 20)
        Me.Label60.TabIndex = 6
        Me.Label60.Text = "HOME TOOLS"
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
        Me.BtnManageCustomers.Location = New System.Drawing.Point(3, 134)
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
        Me.BtnSearchSender.Location = New System.Drawing.Point(3, 134)
        Me.BtnSearchSender.Name = "BtnSearchSender"
        Me.BtnSearchSender.Size = New System.Drawing.Size(191, 79)
        Me.BtnSearchSender.TabIndex = 8
        Me.BtnSearchSender.Text = "FIND SENDER"
        Me.BtnSearchSender.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSearchSender.UseVisualStyleBackColor = False
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
        Me.BtnSearchBeneficiary.Location = New System.Drawing.Point(3, 134)
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
        Me.BtnSearchStat.Location = New System.Drawing.Point(3, 134)
        Me.BtnSearchStat.Name = "BtnSearchStat"
        Me.BtnSearchStat.Size = New System.Drawing.Size(191, 79)
        Me.BtnSearchStat.TabIndex = 7
        Me.BtnSearchStat.Text = "SEARCH STATUS"
        Me.BtnSearchStat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSearchStat.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.BtnClaimCancel)
        Me.Panel2.Controls.Add(Me.BtnAdminClaimPreview)
        Me.Panel2.Controls.Add(Me.BtnClaimChangeStat)
        Me.Panel2.Controls.Add(Me.Label62)
        Me.Panel2.Controls.Add(Me.BtnClaimStartTrans)
        Me.Panel2.Controls.Add(Me.BtnAdminClaimPrint)
        Me.Panel2.Controls.Add(Me.BtnClaimSaveTrans)
        Me.Panel2.Location = New System.Drawing.Point(113, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(197, 627)
        Me.Panel2.TabIndex = 33
        '
        'BtnClaimCancel
        '
        Me.BtnClaimCancel.BackColor = System.Drawing.Color.Transparent
        Me.BtnClaimCancel.FlatAppearance.BorderSize = 0
        Me.BtnClaimCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClaimCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClaimCancel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnClaimCancel.Image = CType(resources.GetObject("BtnClaimCancel.Image"), System.Drawing.Image)
        Me.BtnClaimCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnClaimCancel.Location = New System.Drawing.Point(21, 520)
        Me.BtnClaimCancel.Name = "BtnClaimCancel"
        Me.BtnClaimCancel.Size = New System.Drawing.Size(160, 66)
        Me.BtnClaimCancel.TabIndex = 35
        Me.BtnClaimCancel.Text = "CANCEL TRANSACTION"
        Me.BtnClaimCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnClaimCancel.UseVisualStyleBackColor = False
        '
        'BtnAdminClaimPreview
        '
        Me.BtnAdminClaimPreview.BackColor = System.Drawing.Color.Transparent
        Me.BtnAdminClaimPreview.FlatAppearance.BorderSize = 0
        Me.BtnAdminClaimPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdminClaimPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdminClaimPreview.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnAdminClaimPreview.Image = CType(resources.GetObject("BtnAdminClaimPreview.Image"), System.Drawing.Image)
        Me.BtnAdminClaimPreview.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAdminClaimPreview.Location = New System.Drawing.Point(25, 433)
        Me.BtnAdminClaimPreview.Name = "BtnAdminClaimPreview"
        Me.BtnAdminClaimPreview.Size = New System.Drawing.Size(147, 66)
        Me.BtnAdminClaimPreview.TabIndex = 34
        Me.BtnAdminClaimPreview.Text = "PRINT PREVIEW"
        Me.BtnAdminClaimPreview.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAdminClaimPreview.UseVisualStyleBackColor = False
        '
        'BtnClaimChangeStat
        '
        Me.BtnClaimChangeStat.BackColor = System.Drawing.Color.Transparent
        Me.BtnClaimChangeStat.FlatAppearance.BorderSize = 0
        Me.BtnClaimChangeStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClaimChangeStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClaimChangeStat.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnClaimChangeStat.Image = CType(resources.GetObject("BtnClaimChangeStat.Image"), System.Drawing.Image)
        Me.BtnClaimChangeStat.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnClaimChangeStat.Location = New System.Drawing.Point(23, 180)
        Me.BtnClaimChangeStat.Name = "BtnClaimChangeStat"
        Me.BtnClaimChangeStat.Size = New System.Drawing.Size(149, 67)
        Me.BtnClaimChangeStat.TabIndex = 33
        Me.BtnClaimChangeStat.Text = "CHANGE STATUS"
        Me.BtnClaimChangeStat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnClaimChangeStat.UseVisualStyleBackColor = False
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label62.Location = New System.Drawing.Point(37, 54)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(118, 19)
        Me.Label62.TabIndex = 15
        Me.Label62.Text = "CLAIM TOOLS"
        '
        'BtnClaimStartTrans
        '
        Me.BtnClaimStartTrans.BackColor = System.Drawing.Color.Transparent
        Me.BtnClaimStartTrans.FlatAppearance.BorderSize = 0
        Me.BtnClaimStartTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClaimStartTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClaimStartTrans.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnClaimStartTrans.Image = CType(resources.GetObject("BtnClaimStartTrans.Image"), System.Drawing.Image)
        Me.BtnClaimStartTrans.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnClaimStartTrans.Location = New System.Drawing.Point(23, 102)
        Me.BtnClaimStartTrans.Name = "BtnClaimStartTrans"
        Me.BtnClaimStartTrans.Size = New System.Drawing.Size(149, 66)
        Me.BtnClaimStartTrans.TabIndex = 32
        Me.BtnClaimStartTrans.Text = "Start Transaction"
        Me.BtnClaimStartTrans.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnClaimStartTrans.UseVisualStyleBackColor = False
        '
        'BtnAdminClaimPrint
        '
        Me.BtnAdminClaimPrint.BackColor = System.Drawing.Color.Transparent
        Me.BtnAdminClaimPrint.FlatAppearance.BorderSize = 0
        Me.BtnAdminClaimPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdminClaimPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdminClaimPrint.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnAdminClaimPrint.Image = CType(resources.GetObject("BtnAdminClaimPrint.Image"), System.Drawing.Image)
        Me.BtnAdminClaimPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAdminClaimPrint.Location = New System.Drawing.Point(23, 348)
        Me.BtnAdminClaimPrint.Name = "BtnAdminClaimPrint"
        Me.BtnAdminClaimPrint.Size = New System.Drawing.Size(149, 66)
        Me.BtnAdminClaimPrint.TabIndex = 4
        Me.BtnAdminClaimPrint.Text = "PRINT DOCUMENT"
        Me.BtnAdminClaimPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAdminClaimPrint.UseVisualStyleBackColor = False
        '
        'BtnClaimSaveTrans
        '
        Me.BtnClaimSaveTrans.BackColor = System.Drawing.Color.Transparent
        Me.BtnClaimSaveTrans.FlatAppearance.BorderSize = 0
        Me.BtnClaimSaveTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClaimSaveTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClaimSaveTrans.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnClaimSaveTrans.Image = CType(resources.GetObject("BtnClaimSaveTrans.Image"), System.Drawing.Image)
        Me.BtnClaimSaveTrans.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnClaimSaveTrans.Location = New System.Drawing.Point(23, 261)
        Me.BtnClaimSaveTrans.Name = "BtnClaimSaveTrans"
        Me.BtnClaimSaveTrans.Size = New System.Drawing.Size(149, 66)
        Me.BtnClaimSaveTrans.TabIndex = 11
        Me.BtnClaimSaveTrans.Text = "SAVE TRANSACTION"
        Me.BtnClaimSaveTrans.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnClaimSaveTrans.UseVisualStyleBackColor = False
        '
        'PanelRemitTools
        '
        Me.PanelRemitTools.BackColor = System.Drawing.Color.Teal
        Me.PanelRemitTools.Controls.Add(Me.BtnAdminNewTrans)
        Me.PanelRemitTools.Controls.Add(Me.BtnCancelRemitAdmin)
        Me.PanelRemitTools.Controls.Add(Me.BtnAdminRemitPreview)
        Me.PanelRemitTools.Controls.Add(Me.Label61)
        Me.PanelRemitTools.Controls.Add(Me.BtnStartTran)
        Me.PanelRemitTools.Controls.Add(Me.BtnAdminRemitPrint)
        Me.PanelRemitTools.Controls.Add(Me.BtnSaveTran)
        Me.PanelRemitTools.Location = New System.Drawing.Point(113, 0)
        Me.PanelRemitTools.Name = "PanelRemitTools"
        Me.PanelRemitTools.Size = New System.Drawing.Size(197, 627)
        Me.PanelRemitTools.TabIndex = 6
        '
        'BtnAdminNewTrans
        '
        Me.BtnAdminNewTrans.BackColor = System.Drawing.Color.Transparent
        Me.BtnAdminNewTrans.FlatAppearance.BorderSize = 0
        Me.BtnAdminNewTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdminNewTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdminNewTrans.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnAdminNewTrans.Image = CType(resources.GetObject("BtnAdminNewTrans.Image"), System.Drawing.Image)
        Me.BtnAdminNewTrans.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAdminNewTrans.Location = New System.Drawing.Point(23, 411)
        Me.BtnAdminNewTrans.Name = "BtnAdminNewTrans"
        Me.BtnAdminNewTrans.Size = New System.Drawing.Size(165, 66)
        Me.BtnAdminNewTrans.TabIndex = 35
        Me.BtnAdminNewTrans.Text = "NEW TRANSACTION"
        Me.BtnAdminNewTrans.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAdminNewTrans.UseVisualStyleBackColor = False
        '
        'BtnCancelRemitAdmin
        '
        Me.BtnCancelRemitAdmin.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelRemitAdmin.FlatAppearance.BorderSize = 0
        Me.BtnCancelRemitAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelRemitAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelRemitAdmin.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnCancelRemitAdmin.Image = CType(resources.GetObject("BtnCancelRemitAdmin.Image"), System.Drawing.Image)
        Me.BtnCancelRemitAdmin.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCancelRemitAdmin.Location = New System.Drawing.Point(23, 497)
        Me.BtnCancelRemitAdmin.Name = "BtnCancelRemitAdmin"
        Me.BtnCancelRemitAdmin.Size = New System.Drawing.Size(165, 66)
        Me.BtnCancelRemitAdmin.TabIndex = 34
        Me.BtnCancelRemitAdmin.Text = "CANCEL TRANSACTION"
        Me.BtnCancelRemitAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCancelRemitAdmin.UseVisualStyleBackColor = False
        '
        'BtnAdminRemitPreview
        '
        Me.BtnAdminRemitPreview.BackColor = System.Drawing.Color.Transparent
        Me.BtnAdminRemitPreview.FlatAppearance.BorderSize = 0
        Me.BtnAdminRemitPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdminRemitPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdminRemitPreview.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnAdminRemitPreview.Image = CType(resources.GetObject("BtnAdminRemitPreview.Image"), System.Drawing.Image)
        Me.BtnAdminRemitPreview.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAdminRemitPreview.Location = New System.Drawing.Point(34, 329)
        Me.BtnAdminRemitPreview.Name = "BtnAdminRemitPreview"
        Me.BtnAdminRemitPreview.Size = New System.Drawing.Size(147, 66)
        Me.BtnAdminRemitPreview.TabIndex = 33
        Me.BtnAdminRemitPreview.Text = "PRINT PREVIEW"
        Me.BtnAdminRemitPreview.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAdminRemitPreview.UseVisualStyleBackColor = False
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label61.Location = New System.Drawing.Point(37, 49)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(118, 19)
        Me.Label61.TabIndex = 15
        Me.Label61.Text = "REMIT TOOLS"
        '
        'BtnStartTran
        '
        Me.BtnStartTran.BackColor = System.Drawing.Color.Transparent
        Me.BtnStartTran.FlatAppearance.BorderSize = 0
        Me.BtnStartTran.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStartTran.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStartTran.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnStartTran.Image = CType(resources.GetObject("BtnStartTran.Image"), System.Drawing.Image)
        Me.BtnStartTran.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnStartTran.Location = New System.Drawing.Point(25, 80)
        Me.BtnStartTran.Name = "BtnStartTran"
        Me.BtnStartTran.Size = New System.Drawing.Size(149, 66)
        Me.BtnStartTran.TabIndex = 32
        Me.BtnStartTran.Text = "Start Transaction"
        Me.BtnStartTran.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnStartTran.UseVisualStyleBackColor = False
        '
        'BtnAdminRemitPrint
        '
        Me.BtnAdminRemitPrint.BackColor = System.Drawing.Color.Transparent
        Me.BtnAdminRemitPrint.FlatAppearance.BorderSize = 0
        Me.BtnAdminRemitPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdminRemitPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdminRemitPrint.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnAdminRemitPrint.Image = CType(resources.GetObject("BtnAdminRemitPrint.Image"), System.Drawing.Image)
        Me.BtnAdminRemitPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAdminRemitPrint.Location = New System.Drawing.Point(25, 247)
        Me.BtnAdminRemitPrint.Name = "BtnAdminRemitPrint"
        Me.BtnAdminRemitPrint.Size = New System.Drawing.Size(149, 66)
        Me.BtnAdminRemitPrint.TabIndex = 4
        Me.BtnAdminRemitPrint.Text = "PRINT DOCUMENT"
        Me.BtnAdminRemitPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAdminRemitPrint.UseVisualStyleBackColor = False
        '
        'BtnSaveTran
        '
        Me.BtnSaveTran.BackColor = System.Drawing.Color.Transparent
        Me.BtnSaveTran.FlatAppearance.BorderSize = 0
        Me.BtnSaveTran.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSaveTran.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveTran.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnSaveTran.Image = CType(resources.GetObject("BtnSaveTran.Image"), System.Drawing.Image)
        Me.BtnSaveTran.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSaveTran.Location = New System.Drawing.Point(25, 162)
        Me.BtnSaveTran.Name = "BtnSaveTran"
        Me.BtnSaveTran.Size = New System.Drawing.Size(149, 66)
        Me.BtnSaveTran.TabIndex = 11
        Me.BtnSaveTran.Text = "SAVE TRANSACTION"
        Me.BtnSaveTran.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSaveTran.UseVisualStyleBackColor = False
        '
        'PanelAdminFileExplorer
        '
        Me.PanelAdminFileExplorer.Controls.Add(Me.Label29)
        Me.PanelAdminFileExplorer.Controls.Add(Me.TreeViewAdmin)
        Me.PanelAdminFileExplorer.Controls.Add(Me.Panel6)
        Me.PanelAdminFileExplorer.Location = New System.Drawing.Point(972, 52)
        Me.PanelAdminFileExplorer.Name = "PanelAdminFileExplorer"
        Me.PanelAdminFileExplorer.Size = New System.Drawing.Size(316, 627)
        Me.PanelAdminFileExplorer.TabIndex = 18
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label29.Location = New System.Drawing.Point(84, 40)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(149, 20)
        Me.Label29.TabIndex = 20
        Me.Label29.Text = "FILE EXPLORER"
        '
        'TreeViewAdmin
        '
        Me.TreeViewAdmin.ImageIndex = 0
        Me.TreeViewAdmin.ImageList = Me.ImageList1
        Me.TreeViewAdmin.Location = New System.Drawing.Point(3, 69)
        Me.TreeViewAdmin.Name = "TreeViewAdmin"
        Me.TreeViewAdmin.SelectedImageIndex = 0
        Me.TreeViewAdmin.Size = New System.Drawing.Size(310, 398)
        Me.TreeViewAdmin.TabIndex = 19
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Panel6
        '
        Me.Panel6.Location = New System.Drawing.Point(978, 111)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(225, 576)
        Me.Panel6.TabIndex = 18
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.OliveDrab
        Me.Panel3.Controls.Add(Me.Lbldate)
        Me.Panel3.Controls.Add(Me.Label63)
        Me.Panel3.Controls.Add(Me.LabelDate)
        Me.Panel3.Location = New System.Drawing.Point(-1, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1375, 51)
        Me.Panel3.TabIndex = 17
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Imprint MT Shadow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label63.Location = New System.Drawing.Point(390, 8)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(464, 25)
        Me.Label63.TabIndex = 0
        Me.Label63.Text = "CONNECT TECH MONEY REMITTANCE"
        '
        'PrintDocument1
        '
        '
        'PrintDocumentAdminClaim
        '
        '
        'PrintPreviewDialogAdminClaim
        '
        Me.PrintPreviewDialogAdminClaim.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogAdminClaim.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogAdminClaim.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialogAdminClaim.Enabled = True
        Me.PrintPreviewDialogAdminClaim.Icon = CType(resources.GetObject("PrintPreviewDialogAdminClaim.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialogAdminClaim.Name = "PrintPreviewDialogAdminClaim"
        Me.PrintPreviewDialogAdminClaim.Visible = False
        '
        'PrintDocumentAdminRemitReceipt
        '
        '
        'PrintPreviewDialogAdminRemit
        '
        Me.PrintPreviewDialogAdminRemit.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogAdminRemit.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogAdminRemit.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialogAdminRemit.Enabled = True
        Me.PrintPreviewDialogAdminRemit.Icon = CType(resources.GetObject("PrintPreviewDialogAdminRemit.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialogAdminRemit.Name = "PrintPreviewDialogAdminRemit"
        Me.PrintPreviewDialogAdminRemit.Visible = False
        '
        'PbRight
        '
        Me.PbRight.BackColor = System.Drawing.Color.Transparent
        Me.PbRight.Image = CType(resources.GetObject("PbRight.Image"), System.Drawing.Image)
        Me.PbRight.Location = New System.Drawing.Point(1290, 309)
        Me.PbRight.Name = "PbRight"
        Me.PbRight.Size = New System.Drawing.Size(72, 70)
        Me.PbRight.TabIndex = 16
        Me.PbRight.TabStop = False
        '
        'PbviewFiles
        '
        Me.PbviewFiles.BackColor = System.Drawing.Color.Transparent
        Me.PbviewFiles.Image = CType(resources.GetObject("PbviewFiles.Image"), System.Drawing.Image)
        Me.PbviewFiles.Location = New System.Drawing.Point(1310, 52)
        Me.PbviewFiles.Name = "PbviewFiles"
        Me.PbviewFiles.Size = New System.Drawing.Size(40, 292)
        Me.PbviewFiles.TabIndex = 18
        Me.PbviewFiles.TabStop = False
        '
        'PbviewButtons
        '
        Me.PbviewButtons.BackColor = System.Drawing.Color.Transparent
        Me.PbviewButtons.Image = CType(resources.GetObject("PbviewButtons.Image"), System.Drawing.Image)
        Me.PbviewButtons.Location = New System.Drawing.Point(1310, 343)
        Me.PbviewButtons.Name = "PbviewButtons"
        Me.PbviewButtons.Size = New System.Drawing.Size(40, 292)
        Me.PbviewButtons.TabIndex = 19
        Me.PbviewButtons.TabStop = False
        '
        'PbLeft
        '
        Me.PbLeft.BackColor = System.Drawing.Color.Transparent
        Me.PbLeft.Image = CType(resources.GetObject("PbLeft.Image"), System.Drawing.Image)
        Me.PbLeft.Location = New System.Drawing.Point(1290, 309)
        Me.PbLeft.Name = "PbLeft"
        Me.PbLeft.Size = New System.Drawing.Size(72, 70)
        Me.PbLeft.TabIndex = 15
        Me.PbLeft.TabStop = False
        '
        'FormTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1362, 712)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PbRight)
        Me.Controls.Add(Me.PbviewFiles)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PbviewButtons)
        Me.Controls.Add(Me.PbLeft)
        Me.Controls.Add(Me.PanelControlContainer)
        Me.Controls.Add(Me.PanelAdminFileExplorer)
        Me.Controls.Add(Me.PanelClaimTransaction)
        Me.Controls.Add(Me.PanelTransaction)
        Me.Controls.Add(Me.PanelHome)
        Me.Name = "FormTransaction"
        Me.Text = "ADMIN AND TRANSACTION:"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHome.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageEmployee.ResumeLayout(False)
        Me.TabPageEmployee.PerformLayout()
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
        Me.PanelTransaction.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.PanelAdminRemitPrintReceipt.ResumeLayout(False)
        Me.PanelAdminRemitPrintReceipt.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.PanelClaimTransaction.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPageClaim.ResumeLayout(False)
        Me.TabPageClaim.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.TabPageClaimReceipt.ResumeLayout(False)
        Me.PanelAdminClaimReceipt.ResumeLayout(False)
        Me.PanelAdminClaimReceipt.PerformLayout()
        Me.PanelControlContainer.ResumeLayout(False)
        Me.PanelHomeTools.ResumeLayout(False)
        Me.PanelHomeTools.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelRemitTools.ResumeLayout(False)
        Me.PanelRemitTools.PerformLayout()
        Me.PanelAdminFileExplorer.ResumeLayout(False)
        Me.PanelAdminFileExplorer.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PbRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbviewFiles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbviewButtons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnHome As Button
    Friend WithEvents LblUserName As Label
    Friend WithEvents BtnMakeTran As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents LblEmpID As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents DgvUsers As DataGridView
    Friend WithEvents PanelHome As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPageEmployee As TabPage
    Friend WithEvents TabPageVStatus As TabPage
    Friend WithEvents LblCount As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelTransaction As Panel
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtTotalAmt As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtCharge As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtAmount As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtIssuePlace As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtRelationtoRec As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtMobile As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtPurpose As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CboIDtype As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtRefNo1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCustName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtRecAddress As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtRecRelationship As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TxtRecMobile As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents CboRecIDtype As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtreceiverRefNo1 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtRecName As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtrecAmount As TextBox
    Friend WithEvents TxtRecBranchAdd As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents CboCorrespondent As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TxtRefNo3 As TextBox
    Friend WithEvents TxtRefNo2 As TextBox
    Friend WithEvents TxtReceiverRefNo3 As TextBox
    Friend WithEvents TxtReceiverRefNo2 As TextBox
    Friend WithEvents LinkNext1 As LinkLabel
    Friend WithEvents LinkNext2 As LinkLabel
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TxtExpirtyDate As TextBox
    Friend WithEvents TxtIssueDate As TextBox
    Friend WithEvents Lbldate As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TxtDateIssueClaim As TextBox
    Friend WithEvents BtnClaimTrans As Button
    Friend WithEvents PanelClaimTransaction As Panel
    Friend WithEvents LabelDate As Label
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPageClaim As TabPage
    Friend WithEvents TabPageClaimReceipt As TabPage
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label58 As Label
    Friend WithEvents TxtClaimStatus As TextBox
    Friend WithEvents Label57 As Label
    Friend WithEvents TxtClaimExpiryDate As TextBox
    Friend WithEvents Label59 As Label
    Friend WithEvents TxtClaimIDtype As TextBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents TxtClaimCorrespondent As TextBox
    Friend WithEvents TxtClaimAmount As TextBox
    Friend WithEvents TxtClaimBranch As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents TxtClaimAddress As TextBox
    Friend WithEvents Label52 As Label
    Friend WithEvents TxtClaimRelationship As TextBox
    Friend WithEvents Label53 As Label
    Friend WithEvents TxtClaimMobile As TextBox
    Friend WithEvents Label54 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents TxtClaimName As TextBox
    Friend WithEvents Label56 As Label
    Friend WithEvents TxtClaimRefNo As TextBox
    Friend WithEvents PanelControlContainer As Panel
    Friend WithEvents BtnLogout As Button
    Friend WithEvents PbRight As PictureBox
    Friend WithEvents PbLeft As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label63 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents PanelStatus As Panel
    Friend WithEvents Label67 As Label
    Friend WithEvents RadExpired As RadioButton
    Friend WithEvents RadNotClaimed As RadioButton
    Friend WithEvents RadClaimed As RadioButton
    Friend WithEvents Label65 As Label
    Friend WithEvents CboCategory As ComboBox
    Friend WithEvents DgvStatus As DataGridView
    Friend WithEvents PanelDateStat As Panel
    Friend WithEvents Label69 As Label
    Friend WithEvents RadPerMonth As RadioButton
    Friend WithEvents RadToday As RadioButton
    Friend WithEvents RadSpecifyDate As RadioButton
    Friend WithEvents TextDTGpicker As TextBox
    Friend WithEvents TvRefno As TextBox
    Friend WithEvents LabelinputRefNo As Label
    Friend WithEvents PanelRemitTools As Panel
    Friend WithEvents Label61 As Label
    Friend WithEvents BtnStartTran As Button
    Friend WithEvents BtnAdminRemitPrint As Button
    Friend WithEvents BtnSaveTran As Button
    Friend WithEvents PanelHomeTools As Panel
    Friend WithEvents BtnSearchStat As Button
    Friend WithEvents BtnPrintAdminStatus As Button
    Friend WithEvents Label60 As Label
    Friend WithEvents BtnAddUser As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnClaimChangeStat As Button
    Friend WithEvents Label62 As Label
    Friend WithEvents BtnClaimStartTrans As Button
    Friend WithEvents BtnAdminClaimPrint As Button
    Friend WithEvents BtnClaimSaveTrans As Button
    Friend WithEvents Txtchange As TextBox
    Friend WithEvents Label73 As Label
    Friend WithEvents TxtCashTendered As TextBox
    Friend WithEvents Label75 As Label
    Friend WithEvents Txtholder As TextBox
    Friend WithEvents TabPageSender As TabPage
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents BtnSearchSender As Button
    Friend WithEvents BtnManageCustomers As Button
    Friend WithEvents TvSenderRefNo As TextBox
    Friend WithEvents LabelSenderRefNo As Label
    Friend WithEvents Label79 As Label
    Friend WithEvents CboSenderCategory As ComboBox
    Friend WithEvents DgvSenderInfo As DataGridView
    Friend WithEvents PanelSenderInfo As Panel
    Friend WithEvents dtpSenderDate As DateTimePicker
    Friend WithEvents RadSenderSpecifyDate As RadioButton
    Friend WithEvents Label77 As Label
    Friend WithEvents RadSenderPerMonth As RadioButton
    Friend WithEvents RadSenderToday As RadioButton
    Friend WithEvents TvSenderDateholder As TextBox
    Friend WithEvents dtpStat2 As DateTimePicker
    Friend WithEvents dtpStat1 As DateTimePicker
    Friend WithEvents Txtdtp2Picker As TextBox
    Friend WithEvents Txtdtp1Picker As TextBox
    Friend WithEvents TxtdtpSenderHandler2 As TextBox
    Friend WithEvents TxtdtpSenderHandler1 As TextBox
    Friend WithEvents dtpSenderMonthly2 As DateTimePicker
    Friend WithEvents dtpSenderMonthly1 As DateTimePicker
    Friend WithEvents Label84 As Label
    Friend WithEvents Label85 As Label
    Friend WithEvents Label83 As Label
    Friend WithEvents Label82 As Label
    Friend WithEvents TabPageBeneficiary As TabPage
    Friend WithEvents TvBeneRefNo As TextBox
    Friend WithEvents LabelBeneficiaryRefNo As Label
    Friend WithEvents Label86 As Label
    Friend WithEvents CboBeneCategory As ComboBox
    Friend WithEvents dtgBeneficiary As DataGridView
    Friend WithEvents BtnSearchBeneficiary As Button
    Friend WithEvents LabelBeneCorres As Label
    Friend WithEvents CboBeneCorrespondent As ComboBox
    Friend WithEvents PanelBeneRefNo As Panel
    Friend WithEvents PanelBeneNothing As Panel
    Friend WithEvents PanelBeneCorrespondent As Panel
    Friend WithEvents PanelStatNothing As Panel
    Friend WithEvents PanelEmpId As Panel
    Friend WithEvents TvEmpIDStat As TextBox
    Friend WithEvents Label87 As Label
    Friend WithEvents PanelRefNo As Panel
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents BtnPrintViewAdminStat As Button
    Friend WithEvents PanelAdminRemitPrintReceipt As Panel
    Friend WithEvents LbltotalAmount As Label
    Friend WithEvents Lblcharge As Label
    Friend WithEvents Lblamount As Label
    Friend WithEvents LblexpiryDate As Label
    Friend WithEvents LblissuePlace As Label
    Friend WithEvents LblissueDate As Label
    Friend WithEvents LblCustName As Label
    Friend WithEvents LblRefNo As Label
    Friend WithEvents Label88 As Label
    Friend WithEvents Label89 As Label
    Friend WithEvents Label90 As Label
    Friend WithEvents Label91 As Label
    Friend WithEvents Label92 As Label
    Friend WithEvents Label93 As Label
    Friend WithEvents Label94 As Label
    Friend WithEvents Label95 As Label
    Friend WithEvents Label96 As Label
    Friend WithEvents Label97 As Label
    Friend WithEvents Label98 As Label
    Friend WithEvents Label99 As Label
    Friend WithEvents LabelAdminAmtInWordsReceipt As Label
    Friend WithEvents Label100 As Label
    Friend WithEvents Label102 As Label
    Friend WithEvents Label104 As Label
    Friend WithEvents Label106 As Label
    Friend WithEvents Label108 As Label
    Friend WithEvents Label110 As Label
    Friend WithEvents Label111 As Label
    Friend WithEvents Label114 As Label
    Friend WithEvents Label116 As Label
    Friend WithEvents Label117 As Label
    Friend WithEvents Label119 As Label
    Friend WithEvents PanelAdminClaimReceipt As Panel
    Friend WithEvents LabelcAddress As Label
    Friend WithEvents Label70 As Label
    Friend WithEvents LabelcMobileNo As Label
    Friend WithEvents Label74 As Label
    Friend WithEvents LabelcRefNo As Label
    Friend WithEvents LabelcName As Label
    Friend WithEvents LabelcStatus As Label
    Friend WithEvents Label71 As Label
    Friend WithEvents LabelcBranch As Label
    Friend WithEvents Label66 As Label
    Friend WithEvents LabelcCorrespondent As Label
    Friend WithEvents Label68 As Label
    Friend WithEvents LblAdminClaimAmtInWords As Label
    Friend WithEvents LabelcAmount As Label
    Friend WithEvents Label118 As Label
    Friend WithEvents Label120 As Label
    Friend WithEvents Label121 As Label
    Friend WithEvents Label122 As Label
    Friend WithEvents Label123 As Label
    Friend WithEvents Label124 As Label
    Friend WithEvents Label125 As Label
    Friend WithEvents Label126 As Label
    Friend WithEvents Label127 As Label
    Friend WithEvents Label128 As Label
    Friend WithEvents Label129 As Label
    Friend WithEvents Label130 As Label
    Friend WithEvents Label132 As Label
    Friend WithEvents Label133 As Label
    Friend WithEvents Label134 As Label
    Friend WithEvents Label141 As Label
    Friend WithEvents Label142 As Label
    Friend WithEvents BtnAdminClaimPreview As Button
    Friend WithEvents BtnAdminRemitPreview As Button
    Friend WithEvents PrintDocumentAdminClaim As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialogAdminClaim As PrintPreviewDialog
    Friend WithEvents PrintDocumentAdminRemitReceipt As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialogAdminRemit As PrintPreviewDialog
    Friend WithEvents BtnShowFormUpdatePW As Button
    Friend WithEvents BtnCancelRemitAdmin As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label41 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label25 As Label
    Friend WithEvents LblAdminCheckAmountRemit As Label
    Friend WithEvents Label78 As Label
    Friend WithEvents LblAdminCheckCharge As Label
    Friend WithEvents Label81 As Label
    Friend WithEvents LblAdminCheckTotal As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label64 As Label
    Friend WithEvents LblAdminCheckIssue As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents LblAdminCheckExpiry As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents LblAdminCheckIssuePlace As Label
    Friend WithEvents LblAdminCheckCustRel As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents LblAdminCheckAddress As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents LblAdminCheckMob As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents LblAdminCheckPurpose As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents LblAdminCheckCustName As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents LblAdminCheckIDtype As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents LblAdminCheckRefNo As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label105 As Label
    Friend WithEvents LblAdminCheckCorr As Label
    Friend WithEvents Label107 As Label
    Friend WithEvents LblAdminCheckBranck As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents LblAdminCheckRecAmount As Label
    Friend WithEvents LblAdminCheckRecAdd As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents LblAdminCheckRecMob As Label
    Friend WithEvents Label103 As Label
    Friend WithEvents LblAdminCheckRecRel As Label
    Friend WithEvents Label101 As Label
    Friend WithEvents LblAdminCheckRecId As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents LblAdminCheckRecName As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents LblAdminRecNameReceipt As Label
    Friend WithEvents BtnAdminNewTrans As Button
    Friend WithEvents BtnClaimCancel As Button
    Friend WithEvents LabelRevenueAmount As Label
    Friend WithEvents LabelRevenue As Label
    Friend WithEvents BtnAdminManageEmp As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PanelAdminFileExplorer As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TreeViewAdmin As TreeView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PbviewFiles As PictureBox
    Friend WithEvents PbviewButtons As PictureBox
    Friend WithEvents Label29 As Label
    Friend WithEvents BtnAdminTool As Button
End Class
