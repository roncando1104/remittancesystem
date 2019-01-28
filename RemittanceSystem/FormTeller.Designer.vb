<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTeller
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTeller))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblTellerUserID = New System.Windows.Forms.Label()
        Me.LblTellerEmpID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.LblTellerDate = New System.Windows.Forms.Label()
        Me.LabelSysDate = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelTellerClaimReceipt = New System.Windows.Forms.Panel()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.LabelcStatus = New System.Windows.Forms.Label()
        Me.LabelcAmount = New System.Windows.Forms.Label()
        Me.LabelcBranch = New System.Windows.Forms.Label()
        Me.LabelcCorrespondent = New System.Windows.Forms.Label()
        Me.LabelcRefNo = New System.Windows.Forms.Label()
        Me.LabelcAddress = New System.Windows.Forms.Label()
        Me.LabelcMobileNo = New System.Windows.Forms.Label()
        Me.LabelcName = New System.Windows.Forms.Label()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.LblTellerClaimAmtInWords = New System.Windows.Forms.Label()
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
        Me.BtnAdminTool = New System.Windows.Forms.Button()
        Me.BtnTellerClaim = New System.Windows.Forms.Button()
        Me.BtnTellerLogout = New System.Windows.Forms.Button()
        Me.BtnTellerHome = New System.Windows.Forms.Button()
        Me.BtnTellerRemit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelTellerHome = New System.Windows.Forms.Panel()
        Me.TabControlTellerHome = New System.Windows.Forms.TabControl()
        Me.TabPageTellerSender = New System.Windows.Forms.TabPage()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.BtnTellerHomePreview1 = New System.Windows.Forms.Button()
        Me.BtnTellerHomePrint1 = New System.Windows.Forms.Button()
        Me.BtnTellerRefresh1 = New System.Windows.Forms.Button()
        Me.dgvTellerTodayTransaction = New System.Windows.Forms.DataGridView()
        Me.TabPageTellerClaim = New System.Windows.Forms.TabPage()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.dgvTellerClaim = New System.Windows.Forms.DataGridView()
        Me.BtnTellerHomePreview2 = New System.Windows.Forms.Button()
        Me.BtnTellerHomePrint2 = New System.Windows.Forms.Button()
        Me.BtnTellerRefresh2 = New System.Windows.Forms.Button()
        Me.PanelTellerRemit = New System.Windows.Forms.Panel()
        Me.TabControlTellerRemit = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnTellerCancelRemit = New System.Windows.Forms.Button()
        Me.LinkLabelCheckNext = New System.Windows.Forms.LinkLabel()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.LblTellerCheckCorr = New System.Windows.Forms.Label()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.LblTellerCheckBranck = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.LblTellerCheckRecAmount = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.LblTellerCheckAmountRemit = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.LblTellerCheckCharge = New System.Windows.Forms.Label()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.LblTellerCheckTotal = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.LblTellerCheckIssue = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.LblTellerCheckExpiry = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.LblTellerCheckIssuePlace = New System.Windows.Forms.Label()
        Me.LblTellerCheckRecAdd = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.LblTellerCheckRecMob = New System.Windows.Forms.Label()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.LblTellerCheckRecRel = New System.Windows.Forms.Label()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.LblTellerCheckRecId = New System.Windows.Forms.Label()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.LblTellerCheckRecName = New System.Windows.Forms.Label()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.LblTellerCheckCustRel = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.LblTellerCheckAddress = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.LblTellerCheckMob = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.LblTellerCheckPurpose = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.LblTellerCheckCustName = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.LblTellerCheckIDtype = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.LblTellerCheckRefNo = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TpTellerCust = New System.Windows.Forms.TabPage()
        Me.BtnTellerRemitStart = New System.Windows.Forms.Button()
        Me.LinkNextCustomer = New System.Windows.Forms.LinkLabel()
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TpTellerReceiver = New System.Windows.Forms.TabPage()
        Me.LinkNextReceiver = New System.Windows.Forms.LinkLabel()
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
        Me.TpTellerReceipt = New System.Windows.Forms.TabPage()
        Me.BtnTellerNewTrans = New System.Windows.Forms.Button()
        Me.BtnTellerRemitPreview = New System.Windows.Forms.Button()
        Me.PanelTellerRemitReceipt = New System.Windows.Forms.Panel()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.LabelAmtInWordsReceipt = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.LblreceiverName = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.LbltotalAmount = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Lblcharge = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Lblamount = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.LblexpiryDate = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.LblissuePlace = New System.Windows.Forms.Label()
        Me.LblissueDate = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.LblCustName = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.LblRefNo = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.BtnTellerPrintRemit = New System.Windows.Forms.Button()
        Me.BtnTellerSaveRemit = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelTellerClaimTrans = New System.Windows.Forms.Panel()
        Me.TabControlTellerClaim = New System.Windows.Forms.TabControl()
        Me.TabPageClaim = New System.Windows.Forms.TabPage()
        Me.BtnTellerClaimCancel = New System.Windows.Forms.Button()
        Me.BtnTellerStartClaim = New System.Windows.Forms.Button()
        Me.LinkLabelcNext = New System.Windows.Forms.LinkLabel()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.BtnClaimChangeStat = New System.Windows.Forms.Button()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.TxtClaimStatus = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.TxtClaimExpiryDate = New System.Windows.Forms.TextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.TxtDateIssueClaim = New System.Windows.Forms.TextBox()
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
        Me.BtnTellerClaimPreview = New System.Windows.Forms.Button()
        Me.BtnTellerClaimSave = New System.Windows.Forms.Button()
        Me.BtnClaimPrintTeller = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocumentTellerSender = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocumentTellerClaim = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialogTellerClaim = New System.Windows.Forms.PrintPreviewDialog()
        Me.TreeViewTeller = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelTellerClaimReceipt.SuspendLayout()
        Me.PanelTellerHome.SuspendLayout()
        Me.TabControlTellerHome.SuspendLayout()
        Me.TabPageTellerSender.SuspendLayout()
        CType(Me.dgvTellerTodayTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageTellerClaim.SuspendLayout()
        CType(Me.dgvTellerClaim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTellerRemit.SuspendLayout()
        Me.TabControlTellerRemit.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TpTellerCust.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TpTellerReceiver.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TpTellerReceipt.SuspendLayout()
        Me.PanelTellerRemitReceipt.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTellerClaimTrans.SuspendLayout()
        Me.TabControlTellerClaim.SuspendLayout()
        Me.TabPageClaim.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.TabPageClaimReceipt.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(22, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Name:"
        '
        'LblTellerUserID
        '
        Me.LblTellerUserID.AutoSize = True
        Me.LblTellerUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTellerUserID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblTellerUserID.Location = New System.Drawing.Point(43, 40)
        Me.LblTellerUserID.Name = "LblTellerUserID"
        Me.LblTellerUserID.Size = New System.Drawing.Size(16, 16)
        Me.LblTellerUserID.TabIndex = 1
        Me.LblTellerUserID.Text = "--"
        '
        'LblTellerEmpID
        '
        Me.LblTellerEmpID.AutoSize = True
        Me.LblTellerEmpID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTellerEmpID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblTellerEmpID.Location = New System.Drawing.Point(43, 97)
        Me.LblTellerEmpID.Name = "LblTellerEmpID"
        Me.LblTellerEmpID.Size = New System.Drawing.Size(16, 16)
        Me.LblTellerEmpID.TabIndex = 3
        Me.LblTellerEmpID.Text = "--"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(22, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Employee ID:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.OliveDrab
        Me.Panel3.Controls.Add(Me.Label63)
        Me.Panel3.Controls.Add(Me.LblTellerDate)
        Me.Panel3.Location = New System.Drawing.Point(0, -2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1374, 50)
        Me.Panel3.TabIndex = 18
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
        'LblTellerDate
        '
        Me.LblTellerDate.AutoSize = True
        Me.LblTellerDate.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTellerDate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblTellerDate.Location = New System.Drawing.Point(1114, 13)
        Me.LblTellerDate.Name = "LblTellerDate"
        Me.LblTellerDate.Size = New System.Drawing.Size(57, 20)
        Me.LblTellerDate.TabIndex = 20
        Me.LblTellerDate.Text = "Label40"
        Me.LblTellerDate.Visible = False
        '
        'LabelSysDate
        '
        Me.LabelSysDate.AutoSize = True
        Me.LabelSysDate.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSysDate.Location = New System.Drawing.Point(997, 57)
        Me.LabelSysDate.Name = "LabelSysDate"
        Me.LabelSysDate.Size = New System.Drawing.Size(35, 20)
        Me.LabelSysDate.TabIndex = 21
        Me.LabelSysDate.Text = "date"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.BtnAdminTool)
        Me.Panel1.Controls.Add(Me.BtnTellerClaim)
        Me.Panel1.Controls.Add(Me.BtnTellerLogout)
        Me.Panel1.Controls.Add(Me.LblTellerEmpID)
        Me.Panel1.Controls.Add(Me.BtnTellerHome)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.BtnTellerRemit)
        Me.Panel1.Controls.Add(Me.LblTellerUserID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(190, 637)
        Me.Panel1.TabIndex = 19
        '
        'PanelTellerClaimReceipt
        '
        Me.PanelTellerClaimReceipt.Controls.Add(Me.Label66)
        Me.PanelTellerClaimReceipt.Controls.Add(Me.LabelcStatus)
        Me.PanelTellerClaimReceipt.Controls.Add(Me.LabelcAmount)
        Me.PanelTellerClaimReceipt.Controls.Add(Me.LabelcBranch)
        Me.PanelTellerClaimReceipt.Controls.Add(Me.LabelcCorrespondent)
        Me.PanelTellerClaimReceipt.Controls.Add(Me.LabelcRefNo)
        Me.PanelTellerClaimReceipt.Controls.Add(Me.LabelcAddress)
        Me.PanelTellerClaimReceipt.Controls.Add(Me.LabelcMobileNo)
        Me.PanelTellerClaimReceipt.Controls.Add(Me.LabelcName)
        Me.PanelTellerClaimReceipt.Controls.Add(Me.Label88)
        Me.PanelTellerClaimReceipt.Controls.Add(Me.Label90)
        Me.PanelTellerClaimReceipt.Controls.Add(Me.Label94)
        Me.PanelTellerClaimReceipt.Controls.Add(Me.Label96)
        Me.PanelTellerClaimReceipt.Controls.Add(Me.Label98)
        Me.PanelTellerClaimReceipt.Controls.Add(Me.LblTellerClaimAmtInWords)
        Me.PanelTellerClaimReceipt.Controls.Add(Me.Label118)
        Me.PanelTellerClaimReceipt.Controls.Add(Me.Label120)
        Me.PanelTellerClaimReceipt.Controls.Add(Me.Label121)
        Me.PanelTellerClaimReceipt.Controls.Add(Me.Label122)
        Me.PanelTellerClaimReceipt.Controls.Add(Me.Label123)
        Me.PanelTellerClaimReceipt.Controls.Add(Me.Label124)
        Me.PanelTellerClaimReceipt.Controls.Add(Me.Label125)
        Me.PanelTellerClaimReceipt.Controls.Add(Me.Label126)
        Me.PanelTellerClaimReceipt.Controls.Add(Me.Label127)
        Me.PanelTellerClaimReceipt.Controls.Add(Me.Label128)
        Me.PanelTellerClaimReceipt.Controls.Add(Me.Label129)
        Me.PanelTellerClaimReceipt.Controls.Add(Me.Label130)
        Me.PanelTellerClaimReceipt.Controls.Add(Me.Label132)
        Me.PanelTellerClaimReceipt.Controls.Add(Me.Label133)
        Me.PanelTellerClaimReceipt.Controls.Add(Me.Label134)
        Me.PanelTellerClaimReceipt.Controls.Add(Me.Label141)
        Me.PanelTellerClaimReceipt.Controls.Add(Me.Label142)
        Me.PanelTellerClaimReceipt.Location = New System.Drawing.Point(5, 10)
        Me.PanelTellerClaimReceipt.Name = "PanelTellerClaimReceipt"
        Me.PanelTellerClaimReceipt.Size = New System.Drawing.Size(724, 531)
        Me.PanelTellerClaimReceipt.TabIndex = 0
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(499, 249)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(45, 13)
        Me.Label66.TabIndex = 319
        Me.Label66.Text = "Label66"
        '
        'LabelcStatus
        '
        Me.LabelcStatus.AutoSize = True
        Me.LabelcStatus.Location = New System.Drawing.Point(492, 224)
        Me.LabelcStatus.Name = "LabelcStatus"
        Me.LabelcStatus.Size = New System.Drawing.Size(43, 13)
        Me.LabelcStatus.TabIndex = 318
        Me.LabelcStatus.Text = "cStatus"
        '
        'LabelcAmount
        '
        Me.LabelcAmount.AutoSize = True
        Me.LabelcAmount.Location = New System.Drawing.Point(195, 273)
        Me.LabelcAmount.Name = "LabelcAmount"
        Me.LabelcAmount.Size = New System.Drawing.Size(49, 13)
        Me.LabelcAmount.TabIndex = 317
        Me.LabelcAmount.Text = "cAmount"
        '
        'LabelcBranch
        '
        Me.LabelcBranch.AutoSize = True
        Me.LabelcBranch.Location = New System.Drawing.Point(492, 202)
        Me.LabelcBranch.Name = "LabelcBranch"
        Me.LabelcBranch.Size = New System.Drawing.Size(47, 13)
        Me.LabelcBranch.TabIndex = 316
        Me.LabelcBranch.Text = "cBranch"
        '
        'LabelcCorrespondent
        '
        Me.LabelcCorrespondent.AutoSize = True
        Me.LabelcCorrespondent.Location = New System.Drawing.Point(534, 181)
        Me.LabelcCorrespondent.Name = "LabelcCorrespondent"
        Me.LabelcCorrespondent.Size = New System.Drawing.Size(82, 13)
        Me.LabelcCorrespondent.TabIndex = 315
        Me.LabelcCorrespondent.Text = "cCorrespondent"
        '
        'LabelcRefNo
        '
        Me.LabelcRefNo.AutoSize = True
        Me.LabelcRefNo.Location = New System.Drawing.Point(168, 151)
        Me.LabelcRefNo.Name = "LabelcRefNo"
        Me.LabelcRefNo.Size = New System.Drawing.Size(44, 13)
        Me.LabelcRefNo.TabIndex = 314
        Me.LabelcRefNo.Text = "cRefNo"
        '
        'LabelcAddress
        '
        Me.LabelcAddress.AutoSize = True
        Me.LabelcAddress.Location = New System.Drawing.Point(110, 222)
        Me.LabelcAddress.Name = "LabelcAddress"
        Me.LabelcAddress.Size = New System.Drawing.Size(51, 13)
        Me.LabelcAddress.TabIndex = 313
        Me.LabelcAddress.Text = "cAddress"
        '
        'LabelcMobileNo
        '
        Me.LabelcMobileNo.AutoSize = True
        Me.LabelcMobileNo.Location = New System.Drawing.Point(149, 201)
        Me.LabelcMobileNo.Name = "LabelcMobileNo"
        Me.LabelcMobileNo.Size = New System.Drawing.Size(58, 13)
        Me.LabelcMobileNo.TabIndex = 312
        Me.LabelcMobileNo.Text = "cMobileNo"
        '
        'LabelcName
        '
        Me.LabelcName.AutoSize = True
        Me.LabelcName.Location = New System.Drawing.Point(152, 182)
        Me.LabelcName.Name = "LabelcName"
        Me.LabelcName.Size = New System.Drawing.Size(41, 13)
        Me.LabelcName.TabIndex = 311
        Me.LabelcName.Text = "cName"
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.Location = New System.Drawing.Point(48, 222)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(56, 13)
        Me.Label88.TabIndex = 310
        Me.Label88.Text = "Address:"
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.Location = New System.Drawing.Point(48, 202)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(95, 13)
        Me.Label90.TabIndex = 309
        Me.Label90.Text = "Mobile Number:"
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.Location = New System.Drawing.Point(435, 224)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(47, 13)
        Me.Label94.TabIndex = 308
        Me.Label94.Text = "Status:"
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label96.Location = New System.Drawing.Point(435, 201)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(51, 13)
        Me.Label96.TabIndex = 307
        Me.Label96.Text = "Branch:"
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.Location = New System.Drawing.Point(435, 181)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(93, 13)
        Me.Label98.TabIndex = 306
        Me.Label98.Text = "Correspondent:"
        '
        'LblTellerClaimAmtInWords
        '
        Me.LblTellerClaimAmtInWords.AutoSize = True
        Me.LblTellerClaimAmtInWords.Location = New System.Drawing.Point(168, 296)
        Me.LblTellerClaimAmtInWords.Name = "LblTellerClaimAmtInWords"
        Me.LblTellerClaimAmtInWords.Size = New System.Drawing.Size(49, 13)
        Me.LblTellerClaimAmtInWords.TabIndex = 305
        Me.LblTellerClaimAmtInWords.Text = "cAmount"
        '
        'Label118
        '
        Me.Label118.AutoSize = True
        Me.Label118.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label118.Location = New System.Drawing.Point(38, 483)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(213, 9)
        Me.Label118.TabIndex = 304
        Me.Label118.Text = "the receiver failed to claim it within the range of specified date."
        '
        'Label120
        '
        Me.Label120.AutoSize = True
        Me.Label120.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label120.Location = New System.Drawing.Point(37, 473)
        Me.Label120.Name = "Label120"
        Me.Label120.Size = New System.Drawing.Size(166, 9)
        Me.Label120.TabIndex = 303
        Me.Label120.Text = "The company will not allow any refund incase of"
        '
        'Label121
        '
        Me.Label121.AutoSize = True
        Me.Label121.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label121.Location = New System.Drawing.Point(38, 457)
        Me.Label121.Name = "Label121"
        Me.Label121.Size = New System.Drawing.Size(78, 9)
        Me.Label121.TabIndex = 302
        Me.Label121.Text = "this transaction void.  "
        '
        'Label122
        '
        Me.Label122.AutoSize = True
        Me.Label122.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label122.Location = New System.Drawing.Point(38, 447)
        Me.Label122.Name = "Label122"
        Me.Label122.Size = New System.Drawing.Size(187, 9)
        Me.Label122.TabIndex = 301
        Me.Label122.Text = "Failure to claim the money by the receiver will subject"
        '
        'Label123
        '
        Me.Label123.AutoSize = True
        Me.Label123.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label123.Location = New System.Drawing.Point(37, 438)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(206, 9)
        Me.Label123.TabIndex = 300
        Me.Label123.Text = "This transaction is only valid upon the specified date herein. "
        '
        'Label124
        '
        Me.Label124.AutoSize = True
        Me.Label124.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label124.Location = New System.Drawing.Point(37, 422)
        Me.Label124.Name = "Label124"
        Me.Label124.Size = New System.Drawing.Size(169, 13)
        Me.Label124.TabIndex = 299
        Me.Label124.Text = "TERMS AND CONDITIONS :"
        '
        'Label125
        '
        Me.Label125.AutoSize = True
        Me.Label125.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label125.ForeColor = System.Drawing.Color.Maroon
        Me.Label125.Location = New System.Drawing.Point(37, 124)
        Me.Label125.Name = "Label125"
        Me.Label125.Size = New System.Drawing.Size(651, 13)
        Me.Label125.TabIndex = 298
        Me.Label125.Text = "_________________________________________________________________________________" &
    "___________"
        '
        'Label126
        '
        Me.Label126.AutoSize = True
        Me.Label126.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label126.Location = New System.Drawing.Point(460, 378)
        Me.Label126.Name = "Label126"
        Me.Label126.Size = New System.Drawing.Size(175, 13)
        Me.Label126.TabIndex = 297
        Me.Label126.Text = "________________________"
        '
        'Label127
        '
        Me.Label127.AutoSize = True
        Me.Label127.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label127.Location = New System.Drawing.Point(463, 396)
        Me.Label127.Name = "Label127"
        Me.Label127.Size = New System.Drawing.Size(167, 13)
        Me.Label127.TabIndex = 296
        Me.Label127.Text = "Signature over printed name"
        '
        'Label128
        '
        Me.Label128.AutoSize = True
        Me.Label128.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label128.Location = New System.Drawing.Point(40, 88)
        Me.Label128.Name = "Label128"
        Me.Label128.Size = New System.Drawing.Size(203, 13)
        Me.Label128.TabIndex = 295
        Me.Label128.Text = "43 SHAW BLVD. MANDALUYONG CITY"
        '
        'Label129
        '
        Me.Label129.AutoSize = True
        Me.Label129.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label129.Location = New System.Drawing.Point(40, 106)
        Me.Label129.Name = "Label129"
        Me.Label129.Size = New System.Drawing.Size(137, 13)
        Me.Label129.TabIndex = 294
        Me.Label129.Text = "BIR NO. : 123-987-437-000"
        '
        'Label130
        '
        Me.Label130.AutoSize = True
        Me.Label130.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label130.Location = New System.Drawing.Point(37, 71)
        Me.Label130.Name = "Label130"
        Me.Label130.Size = New System.Drawing.Size(235, 13)
        Me.Label130.TabIndex = 293
        Me.Label130.Text = "CONNECT TECH MONEY REMITTANCE"
        '
        'Label132
        '
        Me.Label132.AutoSize = True
        Me.Label132.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label132.Location = New System.Drawing.Point(48, 296)
        Me.Label132.Name = "Label132"
        Me.Label132.Size = New System.Drawing.Size(108, 13)
        Me.Label132.TabIndex = 292
        Me.Label132.Text = "Amount in words :"
        '
        'Label133
        '
        Me.Label133.AutoSize = True
        Me.Label133.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label133.Location = New System.Drawing.Point(48, 182)
        Me.Label133.Name = "Label133"
        Me.Label133.Size = New System.Drawing.Size(98, 13)
        Me.Label133.TabIndex = 291
        Me.Label133.Text = "Receiver Name:"
        '
        'Label134
        '
        Me.Label134.AutoSize = True
        Me.Label134.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label134.Location = New System.Drawing.Point(48, 273)
        Me.Label134.Name = "Label134"
        Me.Label134.Size = New System.Drawing.Size(144, 13)
        Me.Label134.TabIndex = 290
        Me.Label134.Text = "Total Amount Received:"
        '
        'Label141
        '
        Me.Label141.AutoSize = True
        Me.Label141.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label141.ForeColor = System.Drawing.Color.Maroon
        Me.Label141.Location = New System.Drawing.Point(35, 39)
        Me.Label141.Name = "Label141"
        Me.Label141.Size = New System.Drawing.Size(289, 25)
        Me.Label141.TabIndex = 289
        Me.Label141.Text = "Claim Transaction Receipt"
        '
        'Label142
        '
        Me.Label142.AutoSize = True
        Me.Label142.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label142.Location = New System.Drawing.Point(48, 151)
        Me.Label142.Name = "Label142"
        Me.Label142.Size = New System.Drawing.Size(117, 13)
        Me.Label142.TabIndex = 288
        Me.Label142.Text = "Reference Number:"
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
        Me.BtnAdminTool.Location = New System.Drawing.Point(5, 446)
        Me.BtnAdminTool.Name = "BtnAdminTool"
        Me.BtnAdminTool.Size = New System.Drawing.Size(180, 77)
        Me.BtnAdminTool.TabIndex = 13
        Me.BtnAdminTool.Text = "ADMINISTRATIVE TOOL"
        Me.BtnAdminTool.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAdminTool.UseVisualStyleBackColor = False
        '
        'BtnTellerClaim
        '
        Me.BtnTellerClaim.BackColor = System.Drawing.Color.Transparent
        Me.BtnTellerClaim.FlatAppearance.BorderSize = 0
        Me.BtnTellerClaim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTellerClaim.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTellerClaim.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnTellerClaim.Image = CType(resources.GetObject("BtnTellerClaim.Image"), System.Drawing.Image)
        Me.BtnTellerClaim.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnTellerClaim.Location = New System.Drawing.Point(3, 335)
        Me.BtnTellerClaim.Name = "BtnTellerClaim"
        Me.BtnTellerClaim.Size = New System.Drawing.Size(185, 77)
        Me.BtnTellerClaim.TabIndex = 12
        Me.BtnTellerClaim.Text = "CLAIM TRANSACTION"
        Me.BtnTellerClaim.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnTellerClaim.UseVisualStyleBackColor = False
        '
        'BtnTellerLogout
        '
        Me.BtnTellerLogout.BackColor = System.Drawing.Color.Transparent
        Me.BtnTellerLogout.FlatAppearance.BorderSize = 0
        Me.BtnTellerLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTellerLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTellerLogout.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnTellerLogout.Image = CType(resources.GetObject("BtnTellerLogout.Image"), System.Drawing.Image)
        Me.BtnTellerLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTellerLogout.Location = New System.Drawing.Point(14, 585)
        Me.BtnTellerLogout.Name = "BtnTellerLogout"
        Me.BtnTellerLogout.Size = New System.Drawing.Size(155, 41)
        Me.BtnTellerLogout.TabIndex = 5
        Me.BtnTellerLogout.Text = "     LOG OUT"
        Me.BtnTellerLogout.UseVisualStyleBackColor = False
        '
        'BtnTellerHome
        '
        Me.BtnTellerHome.BackColor = System.Drawing.Color.Transparent
        Me.BtnTellerHome.FlatAppearance.BorderSize = 0
        Me.BtnTellerHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTellerHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTellerHome.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnTellerHome.Image = CType(resources.GetObject("BtnTellerHome.Image"), System.Drawing.Image)
        Me.BtnTellerHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnTellerHome.Location = New System.Drawing.Point(2, 127)
        Me.BtnTellerHome.Name = "BtnTellerHome"
        Me.BtnTellerHome.Size = New System.Drawing.Size(185, 77)
        Me.BtnTellerHome.TabIndex = 0
        Me.BtnTellerHome.Text = "HOME AND REPORTS"
        Me.BtnTellerHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnTellerHome.UseVisualStyleBackColor = False
        '
        'BtnTellerRemit
        '
        Me.BtnTellerRemit.BackColor = System.Drawing.Color.Transparent
        Me.BtnTellerRemit.FlatAppearance.BorderSize = 0
        Me.BtnTellerRemit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTellerRemit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTellerRemit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnTellerRemit.Image = CType(resources.GetObject("BtnTellerRemit.Image"), System.Drawing.Image)
        Me.BtnTellerRemit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnTellerRemit.Location = New System.Drawing.Point(3, 232)
        Me.BtnTellerRemit.Name = "BtnTellerRemit"
        Me.BtnTellerRemit.Size = New System.Drawing.Size(185, 77)
        Me.BtnTellerRemit.TabIndex = 3
        Me.BtnTellerRemit.Text = "REMIT TRANSACTION"
        Me.BtnTellerRemit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnTellerRemit.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PanelTellerHome
        '
        Me.PanelTellerHome.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PanelTellerHome.Controls.Add(Me.TabControlTellerHome)
        Me.PanelTellerHome.Location = New System.Drawing.Point(189, 47)
        Me.PanelTellerHome.Name = "PanelTellerHome"
        Me.PanelTellerHome.Size = New System.Drawing.Size(786, 637)
        Me.PanelTellerHome.TabIndex = 22
        '
        'TabControlTellerHome
        '
        Me.TabControlTellerHome.Controls.Add(Me.TabPageTellerSender)
        Me.TabControlTellerHome.Controls.Add(Me.TabPageTellerClaim)
        Me.TabControlTellerHome.ItemSize = New System.Drawing.Size(200, 30)
        Me.TabControlTellerHome.Location = New System.Drawing.Point(1, 13)
        Me.TabControlTellerHome.Name = "TabControlTellerHome"
        Me.TabControlTellerHome.SelectedIndex = 0
        Me.TabControlTellerHome.Size = New System.Drawing.Size(761, 613)
        Me.TabControlTellerHome.TabIndex = 0
        '
        'TabPageTellerSender
        '
        Me.TabPageTellerSender.Controls.Add(Me.Label44)
        Me.TabPageTellerSender.Controls.Add(Me.BtnTellerHomePreview1)
        Me.TabPageTellerSender.Controls.Add(Me.BtnTellerHomePrint1)
        Me.TabPageTellerSender.Controls.Add(Me.BtnTellerRefresh1)
        Me.TabPageTellerSender.Controls.Add(Me.dgvTellerTodayTransaction)
        Me.TabPageTellerSender.Location = New System.Drawing.Point(4, 34)
        Me.TabPageTellerSender.Name = "TabPageTellerSender"
        Me.TabPageTellerSender.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageTellerSender.Size = New System.Drawing.Size(753, 575)
        Me.TabPageTellerSender.TabIndex = 0
        Me.TabPageTellerSender.Text = "SENDER TRANSACTIONS"
        Me.TabPageTellerSender.UseVisualStyleBackColor = True
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Maroon
        Me.Label44.Location = New System.Drawing.Point(255, 27)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(231, 20)
        Me.Label44.TabIndex = 7
        Me.Label44.Text = "Your Transaction For Today"
        '
        'BtnTellerHomePreview1
        '
        Me.BtnTellerHomePreview1.Image = CType(resources.GetObject("BtnTellerHomePreview1.Image"), System.Drawing.Image)
        Me.BtnTellerHomePreview1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTellerHomePreview1.Location = New System.Drawing.Point(457, 532)
        Me.BtnTellerHomePreview1.Name = "BtnTellerHomePreview1"
        Me.BtnTellerHomePreview1.Size = New System.Drawing.Size(131, 37)
        Me.BtnTellerHomePreview1.TabIndex = 6
        Me.BtnTellerHomePreview1.Text = "PREVIEW DATA"
        Me.BtnTellerHomePreview1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTellerHomePreview1.UseVisualStyleBackColor = True
        '
        'BtnTellerHomePrint1
        '
        Me.BtnTellerHomePrint1.Image = CType(resources.GetObject("BtnTellerHomePrint1.Image"), System.Drawing.Image)
        Me.BtnTellerHomePrint1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTellerHomePrint1.Location = New System.Drawing.Point(309, 532)
        Me.BtnTellerHomePrint1.Name = "BtnTellerHomePrint1"
        Me.BtnTellerHomePrint1.Size = New System.Drawing.Size(117, 37)
        Me.BtnTellerHomePrint1.TabIndex = 5
        Me.BtnTellerHomePrint1.Text = "PRINT DATA"
        Me.BtnTellerHomePrint1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTellerHomePrint1.UseVisualStyleBackColor = True
        '
        'BtnTellerRefresh1
        '
        Me.BtnTellerRefresh1.Image = CType(resources.GetObject("BtnTellerRefresh1.Image"), System.Drawing.Image)
        Me.BtnTellerRefresh1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTellerRefresh1.Location = New System.Drawing.Point(148, 532)
        Me.BtnTellerRefresh1.Name = "BtnTellerRefresh1"
        Me.BtnTellerRefresh1.Size = New System.Drawing.Size(131, 37)
        Me.BtnTellerRefresh1.TabIndex = 2
        Me.BtnTellerRefresh1.Text = "REFRESH DATA"
        Me.BtnTellerRefresh1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTellerRefresh1.UseVisualStyleBackColor = True
        '
        'dgvTellerTodayTransaction
        '
        Me.dgvTellerTodayTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTellerTodayTransaction.Location = New System.Drawing.Point(12, 61)
        Me.dgvTellerTodayTransaction.Name = "dgvTellerTodayTransaction"
        Me.dgvTellerTodayTransaction.Size = New System.Drawing.Size(729, 465)
        Me.dgvTellerTodayTransaction.TabIndex = 1
        '
        'TabPageTellerClaim
        '
        Me.TabPageTellerClaim.Controls.Add(Me.Label47)
        Me.TabPageTellerClaim.Controls.Add(Me.dgvTellerClaim)
        Me.TabPageTellerClaim.Controls.Add(Me.BtnTellerHomePreview2)
        Me.TabPageTellerClaim.Controls.Add(Me.BtnTellerHomePrint2)
        Me.TabPageTellerClaim.Controls.Add(Me.BtnTellerRefresh2)
        Me.TabPageTellerClaim.Location = New System.Drawing.Point(4, 34)
        Me.TabPageTellerClaim.Name = "TabPageTellerClaim"
        Me.TabPageTellerClaim.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageTellerClaim.Size = New System.Drawing.Size(753, 575)
        Me.TabPageTellerClaim.TabIndex = 1
        Me.TabPageTellerClaim.Text = "CLAIM TRANSACTIONS"
        Me.TabPageTellerClaim.UseVisualStyleBackColor = True
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.Maroon
        Me.Label47.Location = New System.Drawing.Point(255, 20)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(231, 20)
        Me.Label47.TabIndex = 8
        Me.Label47.Text = "Your Transaction For Today"
        '
        'dgvTellerClaim
        '
        Me.dgvTellerClaim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTellerClaim.Location = New System.Drawing.Point(12, 55)
        Me.dgvTellerClaim.Name = "dgvTellerClaim"
        Me.dgvTellerClaim.Size = New System.Drawing.Size(729, 465)
        Me.dgvTellerClaim.TabIndex = 2
        '
        'BtnTellerHomePreview2
        '
        Me.BtnTellerHomePreview2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTellerHomePreview2.Image = CType(resources.GetObject("BtnTellerHomePreview2.Image"), System.Drawing.Image)
        Me.BtnTellerHomePreview2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTellerHomePreview2.Location = New System.Drawing.Point(510, 527)
        Me.BtnTellerHomePreview2.Name = "BtnTellerHomePreview2"
        Me.BtnTellerHomePreview2.Size = New System.Drawing.Size(176, 37)
        Me.BtnTellerHomePreview2.TabIndex = 5
        Me.BtnTellerHomePreview2.Text = "PREVIEW DATA"
        Me.BtnTellerHomePreview2.UseVisualStyleBackColor = True
        '
        'BtnTellerHomePrint2
        '
        Me.BtnTellerHomePrint2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTellerHomePrint2.Image = CType(resources.GetObject("BtnTellerHomePrint2.Image"), System.Drawing.Image)
        Me.BtnTellerHomePrint2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTellerHomePrint2.Location = New System.Drawing.Point(287, 527)
        Me.BtnTellerHomePrint2.Name = "BtnTellerHomePrint2"
        Me.BtnTellerHomePrint2.Size = New System.Drawing.Size(180, 37)
        Me.BtnTellerHomePrint2.TabIndex = 4
        Me.BtnTellerHomePrint2.Text = "PRINT DATA"
        Me.BtnTellerHomePrint2.UseVisualStyleBackColor = True
        '
        'BtnTellerRefresh2
        '
        Me.BtnTellerRefresh2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTellerRefresh2.Image = CType(resources.GetObject("BtnTellerRefresh2.Image"), System.Drawing.Image)
        Me.BtnTellerRefresh2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTellerRefresh2.Location = New System.Drawing.Point(58, 527)
        Me.BtnTellerRefresh2.Name = "BtnTellerRefresh2"
        Me.BtnTellerRefresh2.Size = New System.Drawing.Size(191, 37)
        Me.BtnTellerRefresh2.TabIndex = 3
        Me.BtnTellerRefresh2.Text = "REFRESH DATA"
        Me.BtnTellerRefresh2.UseVisualStyleBackColor = True
        '
        'PanelTellerRemit
        '
        Me.PanelTellerRemit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PanelTellerRemit.Controls.Add(Me.TabControlTellerRemit)
        Me.PanelTellerRemit.Location = New System.Drawing.Point(189, 47)
        Me.PanelTellerRemit.Name = "PanelTellerRemit"
        Me.PanelTellerRemit.Size = New System.Drawing.Size(786, 637)
        Me.PanelTellerRemit.TabIndex = 23
        '
        'TabControlTellerRemit
        '
        Me.TabControlTellerRemit.Controls.Add(Me.TabPage1)
        Me.TabControlTellerRemit.Controls.Add(Me.TpTellerCust)
        Me.TabControlTellerRemit.Controls.Add(Me.TpTellerReceiver)
        Me.TabControlTellerRemit.Controls.Add(Me.TpTellerReceipt)
        Me.TabControlTellerRemit.ItemSize = New System.Drawing.Size(200, 30)
        Me.TabControlTellerRemit.Location = New System.Drawing.Point(1, 1)
        Me.TabControlTellerRemit.Name = "TabControlTellerRemit"
        Me.TabControlTellerRemit.SelectedIndex = 0
        Me.TabControlTellerRemit.Size = New System.Drawing.Size(753, 636)
        Me.TabControlTellerRemit.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BtnTellerCancelRemit)
        Me.TabPage1.Controls.Add(Me.LinkLabelCheckNext)
        Me.TabPage1.Controls.Add(Me.Label41)
        Me.TabPage1.Controls.Add(Me.Label29)
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.LblTellerCheckRecAdd)
        Me.TabPage1.Controls.Add(Me.Label35)
        Me.TabPage1.Controls.Add(Me.LblTellerCheckRecMob)
        Me.TabPage1.Controls.Add(Me.Label103)
        Me.TabPage1.Controls.Add(Me.LblTellerCheckRecRel)
        Me.TabPage1.Controls.Add(Me.Label101)
        Me.TabPage1.Controls.Add(Me.LblTellerCheckRecId)
        Me.TabPage1.Controls.Add(Me.Label99)
        Me.TabPage1.Controls.Add(Me.LblTellerCheckRecName)
        Me.TabPage1.Controls.Add(Me.Label95)
        Me.TabPage1.Controls.Add(Me.LblTellerCheckCustRel)
        Me.TabPage1.Controls.Add(Me.Label48)
        Me.TabPage1.Controls.Add(Me.LblTellerCheckAddress)
        Me.TabPage1.Controls.Add(Me.Label45)
        Me.TabPage1.Controls.Add(Me.LblTellerCheckMob)
        Me.TabPage1.Controls.Add(Me.Label42)
        Me.TabPage1.Controls.Add(Me.LblTellerCheckPurpose)
        Me.TabPage1.Controls.Add(Me.Label40)
        Me.TabPage1.Controls.Add(Me.LblTellerCheckCustName)
        Me.TabPage1.Controls.Add(Me.Label33)
        Me.TabPage1.Controls.Add(Me.LblTellerCheckIDtype)
        Me.TabPage1.Controls.Add(Me.Label30)
        Me.TabPage1.Controls.Add(Me.LblTellerCheckRefNo)
        Me.TabPage1.Controls.Add(Me.Label27)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(745, 598)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "CHECK INFO"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnTellerCancelRemit
        '
        Me.BtnTellerCancelRemit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTellerCancelRemit.Image = CType(resources.GetObject("BtnTellerCancelRemit.Image"), System.Drawing.Image)
        Me.BtnTellerCancelRemit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTellerCancelRemit.Location = New System.Drawing.Point(42, 554)
        Me.BtnTellerCancelRemit.Name = "BtnTellerCancelRemit"
        Me.BtnTellerCancelRemit.Size = New System.Drawing.Size(250, 38)
        Me.BtnTellerCancelRemit.TabIndex = 52
        Me.BtnTellerCancelRemit.Text = "CANCEL TRANSACTION"
        Me.BtnTellerCancelRemit.UseVisualStyleBackColor = True
        '
        'LinkLabelCheckNext
        '
        Me.LinkLabelCheckNext.AutoSize = True
        Me.LinkLabelCheckNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelCheckNext.Location = New System.Drawing.Point(534, 571)
        Me.LinkLabelCheckNext.Name = "LinkLabelCheckNext"
        Me.LinkLabelCheckNext.Size = New System.Drawing.Size(164, 16)
        Me.LinkLabelCheckNext.TabIndex = 51
        Me.LinkLabelCheckNext.TabStop = True
        Me.LinkLabelCheckNext.Text = "GO TO NEXT PAGE >>"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Maroon
        Me.Label41.Location = New System.Drawing.Point(37, 12)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(179, 16)
        Me.Label41.TabIndex = 50
        Me.Label41.Text = "SENDER INFORMATION"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Maroon
        Me.Label29.Location = New System.Drawing.Point(42, 334)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(192, 16)
        Me.Label29.TabIndex = 49
        Me.Label29.Text = "RECEIVER INFORMATION"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label105)
        Me.GroupBox6.Controls.Add(Me.LblTellerCheckCorr)
        Me.GroupBox6.Controls.Add(Me.Label107)
        Me.GroupBox6.Controls.Add(Me.LblTellerCheckBranck)
        Me.GroupBox6.Controls.Add(Me.Label31)
        Me.GroupBox6.Controls.Add(Me.LblTellerCheckRecAmount)
        Me.GroupBox6.Location = New System.Drawing.Point(447, 393)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(268, 158)
        Me.GroupBox6.TabIndex = 48
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
        'LblTellerCheckCorr
        '
        Me.LblTellerCheckCorr.AutoSize = True
        Me.LblTellerCheckCorr.Location = New System.Drawing.Point(68, 47)
        Me.LblTellerCheckCorr.Name = "LblTellerCheckCorr"
        Me.LblTellerCheckCorr.Size = New System.Drawing.Size(25, 13)
        Me.LblTellerCheckCorr.TabIndex = 39
        Me.LblTellerCheckCorr.Text = "corr"
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
        'LblTellerCheckBranck
        '
        Me.LblTellerCheckBranck.AutoSize = True
        Me.LblTellerCheckBranck.Location = New System.Drawing.Point(68, 81)
        Me.LblTellerCheckBranck.Name = "LblTellerCheckBranck"
        Me.LblTellerCheckBranck.Size = New System.Drawing.Size(40, 13)
        Me.LblTellerCheckBranck.TabIndex = 41
        Me.LblTellerCheckBranck.Text = "branch"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(18, 117)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(133, 15)
        Me.Label31.TabIndex = 42
        Me.Label31.Text = "Amount to received:"
        '
        'LblTellerCheckRecAmount
        '
        Me.LblTellerCheckRecAmount.AutoSize = True
        Me.LblTellerCheckRecAmount.Location = New System.Drawing.Point(68, 137)
        Me.LblTellerCheckRecAmount.Name = "LblTellerCheckRecAmount"
        Me.LblTellerCheckRecAmount.Size = New System.Drawing.Size(58, 13)
        Me.LblTellerCheckRecAmount.TabIndex = 43
        Me.LblTellerCheckRecAmount.Text = "recAmount"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label74)
        Me.GroupBox5.Controls.Add(Me.LblTellerCheckAmountRemit)
        Me.GroupBox5.Controls.Add(Me.Label78)
        Me.GroupBox5.Controls.Add(Me.LblTellerCheckCharge)
        Me.GroupBox5.Controls.Add(Me.Label81)
        Me.GroupBox5.Controls.Add(Me.LblTellerCheckTotal)
        Me.GroupBox5.Location = New System.Drawing.Point(44, 250)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(662, 66)
        Me.GroupBox5.TabIndex = 47
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "AMOUNT PAYABLE:"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.Location = New System.Drawing.Point(18, 24)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(112, 15)
        Me.Label74.TabIndex = 20
        Me.Label74.Text = "Amount to remit:"
        '
        'LblTellerCheckAmountRemit
        '
        Me.LblTellerCheckAmountRemit.AutoSize = True
        Me.LblTellerCheckAmountRemit.Location = New System.Drawing.Point(140, 26)
        Me.LblTellerCheckAmountRemit.Name = "LblTellerCheckAmountRemit"
        Me.LblTellerCheckAmountRemit.Size = New System.Drawing.Size(29, 13)
        Me.LblTellerCheckAmountRemit.TabIndex = 21
        Me.LblTellerCheckAmountRemit.Text = "remit"
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
        'LblTellerCheckCharge
        '
        Me.LblTellerCheckCharge.AutoSize = True
        Me.LblTellerCheckCharge.Location = New System.Drawing.Point(270, 26)
        Me.LblTellerCheckCharge.Name = "LblTellerCheckCharge"
        Me.LblTellerCheckCharge.Size = New System.Drawing.Size(40, 13)
        Me.LblTellerCheckCharge.TabIndex = 23
        Me.LblTellerCheckCharge.Text = "charge"
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
        'LblTellerCheckTotal
        '
        Me.LblTellerCheckTotal.AutoSize = True
        Me.LblTellerCheckTotal.Location = New System.Drawing.Point(451, 26)
        Me.LblTellerCheckTotal.Name = "LblTellerCheckTotal"
        Me.LblTellerCheckTotal.Size = New System.Drawing.Size(27, 13)
        Me.LblTellerCheckTotal.TabIndex = 25
        Me.LblTellerCheckTotal.Text = "total"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label64)
        Me.GroupBox4.Controls.Add(Me.LblTellerCheckIssue)
        Me.GroupBox4.Controls.Add(Me.Label68)
        Me.GroupBox4.Controls.Add(Me.LblTellerCheckExpiry)
        Me.GroupBox4.Controls.Add(Me.Label71)
        Me.GroupBox4.Controls.Add(Me.LblTellerCheckIssuePlace)
        Me.GroupBox4.Location = New System.Drawing.Point(490, 55)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(216, 174)
        Me.GroupBox4.TabIndex = 46
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
        'LblTellerCheckIssue
        '
        Me.LblTellerCheckIssue.AutoSize = True
        Me.LblTellerCheckIssue.Location = New System.Drawing.Point(105, 39)
        Me.LblTellerCheckIssue.Name = "LblTellerCheckIssue"
        Me.LblTellerCheckIssue.Size = New System.Drawing.Size(31, 13)
        Me.LblTellerCheckIssue.TabIndex = 15
        Me.LblTellerCheckIssue.Text = "issue"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(5, 74)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(84, 15)
        Me.Label68.TabIndex = 16
        Me.Label68.Text = "Expiry Date:"
        '
        'LblTellerCheckExpiry
        '
        Me.LblTellerCheckExpiry.AutoSize = True
        Me.LblTellerCheckExpiry.Location = New System.Drawing.Point(105, 76)
        Me.LblTellerCheckExpiry.Name = "LblTellerCheckExpiry"
        Me.LblTellerCheckExpiry.Size = New System.Drawing.Size(34, 13)
        Me.LblTellerCheckExpiry.TabIndex = 17
        Me.LblTellerCheckExpiry.Text = "expiry"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(6, 116)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(85, 15)
        Me.Label71.TabIndex = 18
        Me.Label71.Text = "Issue Place:"
        '
        'LblTellerCheckIssuePlace
        '
        Me.LblTellerCheckIssuePlace.AutoSize = True
        Me.LblTellerCheckIssuePlace.Location = New System.Drawing.Point(44, 141)
        Me.LblTellerCheckIssuePlace.Name = "LblTellerCheckIssuePlace"
        Me.LblTellerCheckIssuePlace.Size = New System.Drawing.Size(58, 13)
        Me.LblTellerCheckIssuePlace.TabIndex = 19
        Me.LblTellerCheckIssuePlace.Text = "issuePlace"
        '
        'LblTellerCheckRecAdd
        '
        Me.LblTellerCheckRecAdd.AutoSize = True
        Me.LblTellerCheckRecAdd.Location = New System.Drawing.Point(64, 419)
        Me.LblTellerCheckRecAdd.Name = "LblTellerCheckRecAdd"
        Me.LblTellerCheckRecAdd.Size = New System.Drawing.Size(41, 13)
        Me.LblTellerCheckRecAdd.TabIndex = 45
        Me.LblTellerCheckRecAdd.Text = "recAdd"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(43, 401)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(62, 15)
        Me.Label35.TabIndex = 44
        Me.Label35.Text = "Address:"
        '
        'LblTellerCheckRecMob
        '
        Me.LblTellerCheckRecMob.AutoSize = True
        Me.LblTellerCheckRecMob.Location = New System.Drawing.Point(165, 442)
        Me.LblTellerCheckRecMob.Name = "LblTellerCheckRecMob"
        Me.LblTellerCheckRecMob.Size = New System.Drawing.Size(43, 13)
        Me.LblTellerCheckRecMob.TabIndex = 37
        Me.LblTellerCheckRecMob.Text = "recMob"
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label103.Location = New System.Drawing.Point(43, 440)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(110, 15)
        Me.Label103.TabIndex = 36
        Me.Label103.Text = "Mobile Number:"
        '
        'LblTellerCheckRecRel
        '
        Me.LblTellerCheckRecRel.AutoSize = True
        Me.LblTellerCheckRecRel.Location = New System.Drawing.Point(204, 506)
        Me.LblTellerCheckRecRel.Name = "LblTellerCheckRecRel"
        Me.LblTellerCheckRecRel.Size = New System.Drawing.Size(38, 13)
        Me.LblTellerCheckRecRel.TabIndex = 35
        Me.LblTellerCheckRecRel.Text = "recRel"
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.Location = New System.Drawing.Point(46, 502)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(152, 15)
        Me.Label101.TabIndex = 34
        Me.Label101.Text = "Relationshp to sender:"
        '
        'LblTellerCheckRecId
        '
        Me.LblTellerCheckRecId.AutoSize = True
        Me.LblTellerCheckRecId.Location = New System.Drawing.Point(108, 476)
        Me.LblTellerCheckRecId.Name = "LblTellerCheckRecId"
        Me.LblTellerCheckRecId.Size = New System.Drawing.Size(31, 13)
        Me.LblTellerCheckRecId.TabIndex = 33
        Me.LblTellerCheckRecId.Text = "recId"
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label99.Location = New System.Drawing.Point(46, 474)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(59, 15)
        Me.Label99.TabIndex = 32
        Me.Label99.Text = "ID Type:"
        '
        'LblTellerCheckRecName
        '
        Me.LblTellerCheckRecName.AutoSize = True
        Me.LblTellerCheckRecName.Location = New System.Drawing.Point(158, 377)
        Me.LblTellerCheckRecName.Name = "LblTellerCheckRecName"
        Me.LblTellerCheckRecName.Size = New System.Drawing.Size(50, 13)
        Me.LblTellerCheckRecName.TabIndex = 31
        Me.LblTellerCheckRecName.Text = "recName"
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label95.Location = New System.Drawing.Point(42, 375)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(109, 15)
        Me.Label95.TabIndex = 30
        Me.Label95.Text = "Receiver Name:"
        '
        'LblTellerCheckCustRel
        '
        Me.LblTellerCheckCustRel.AutoSize = True
        Me.LblTellerCheckCustRel.Location = New System.Drawing.Point(209, 218)
        Me.LblTellerCheckCustRel.Name = "LblTellerCheckCustRel"
        Me.LblTellerCheckCustRel.Size = New System.Drawing.Size(43, 13)
        Me.LblTellerCheckCustRel.TabIndex = 13
        Me.LblTellerCheckCustRel.Text = "custRel"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(41, 214)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(163, 15)
        Me.Label48.TabIndex = 12
        Me.Label48.Text = "Relationship to receiver:"
        '
        'LblTellerCheckAddress
        '
        Me.LblTellerCheckAddress.AutoSize = True
        Me.LblTellerCheckAddress.Location = New System.Drawing.Point(108, 108)
        Me.LblTellerCheckAddress.Name = "LblTellerCheckAddress"
        Me.LblTellerCheckAddress.Size = New System.Drawing.Size(44, 13)
        Me.LblTellerCheckAddress.TabIndex = 11
        Me.LblTellerCheckAddress.Text = "address"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(38, 106)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(62, 15)
        Me.Label45.TabIndex = 10
        Me.Label45.Text = "Address:"
        '
        'LblTellerCheckMob
        '
        Me.LblTellerCheckMob.AutoSize = True
        Me.LblTellerCheckMob.Location = New System.Drawing.Point(155, 131)
        Me.LblTellerCheckMob.Name = "LblTellerCheckMob"
        Me.LblTellerCheckMob.Size = New System.Drawing.Size(43, 13)
        Me.LblTellerCheckMob.TabIndex = 9
        Me.LblTellerCheckMob.Text = "mobNO"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(39, 129)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(110, 15)
        Me.Label42.TabIndex = 8
        Me.Label42.Text = "Mobile Number:"
        '
        'LblTellerCheckPurpose
        '
        Me.LblTellerCheckPurpose.AutoSize = True
        Me.LblTellerCheckPurpose.Location = New System.Drawing.Point(112, 190)
        Me.LblTellerCheckPurpose.Name = "LblTellerCheckPurpose"
        Me.LblTellerCheckPurpose.Size = New System.Drawing.Size(45, 13)
        Me.LblTellerCheckPurpose.TabIndex = 7
        Me.LblTellerCheckPurpose.Text = "purpose"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(41, 188)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(64, 15)
        Me.Label40.TabIndex = 6
        Me.Label40.Text = "Purpose:"
        '
        'LblTellerCheckCustName
        '
        Me.LblTellerCheckCustName.AutoSize = True
        Me.LblTellerCheckCustName.Location = New System.Drawing.Point(157, 86)
        Me.LblTellerCheckCustName.Name = "LblTellerCheckCustName"
        Me.LblTellerCheckCustName.Size = New System.Drawing.Size(55, 13)
        Me.LblTellerCheckCustName.TabIndex = 5
        Me.LblTellerCheckCustName.Text = "custName"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(37, 84)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(114, 15)
        Me.Label33.TabIndex = 4
        Me.Label33.Text = "Customer Name:"
        '
        'LblTellerCheckIDtype
        '
        Me.LblTellerCheckIDtype.AutoSize = True
        Me.LblTellerCheckIDtype.Location = New System.Drawing.Point(104, 169)
        Me.LblTellerCheckIDtype.Name = "LblTellerCheckIDtype"
        Me.LblTellerCheckIDtype.Size = New System.Drawing.Size(39, 13)
        Me.LblTellerCheckIDtype.TabIndex = 3
        Me.LblTellerCheckIDtype.Text = "idType"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(39, 167)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(59, 15)
        Me.Label30.TabIndex = 2
        Me.Label30.Text = "ID Type:"
        '
        'LblTellerCheckRefNo
        '
        Me.LblTellerCheckRefNo.AutoSize = True
        Me.LblTellerCheckRefNo.Location = New System.Drawing.Point(175, 39)
        Me.LblTellerCheckRefNo.Name = "LblTellerCheckRefNo"
        Me.LblTellerCheckRefNo.Size = New System.Drawing.Size(33, 13)
        Me.LblTellerCheckRefNo.TabIndex = 1
        Me.LblTellerCheckRefNo.Text = "refNo"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(37, 37)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(132, 15)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Reference Number:"
        '
        'TpTellerCust
        '
        Me.TpTellerCust.Controls.Add(Me.BtnTellerRemitStart)
        Me.TpTellerCust.Controls.Add(Me.LinkNextCustomer)
        Me.TpTellerCust.Controls.Add(Me.TxtRefNo3)
        Me.TpTellerCust.Controls.Add(Me.TxtRefNo2)
        Me.TpTellerCust.Controls.Add(Me.GroupBox2)
        Me.TpTellerCust.Controls.Add(Me.GroupBox1)
        Me.TpTellerCust.Controls.Add(Me.TxtAddress)
        Me.TpTellerCust.Controls.Add(Me.Label9)
        Me.TpTellerCust.Controls.Add(Me.TxtRelationtoRec)
        Me.TpTellerCust.Controls.Add(Me.Label8)
        Me.TpTellerCust.Controls.Add(Me.TxtMobile)
        Me.TpTellerCust.Controls.Add(Me.Label6)
        Me.TpTellerCust.Controls.Add(Me.TxtPurpose)
        Me.TpTellerCust.Controls.Add(Me.Label7)
        Me.TpTellerCust.Controls.Add(Me.CboIDtype)
        Me.TpTellerCust.Controls.Add(Me.Label5)
        Me.TpTellerCust.Controls.Add(Me.TxtRefNo1)
        Me.TpTellerCust.Controls.Add(Me.Label4)
        Me.TpTellerCust.Controls.Add(Me.TxtCustName)
        Me.TpTellerCust.Controls.Add(Me.Label2)
        Me.TpTellerCust.Location = New System.Drawing.Point(4, 34)
        Me.TpTellerCust.Name = "TpTellerCust"
        Me.TpTellerCust.Padding = New System.Windows.Forms.Padding(3)
        Me.TpTellerCust.Size = New System.Drawing.Size(745, 598)
        Me.TpTellerCust.TabIndex = 1
        Me.TpTellerCust.Text = "CUSTOMER"
        Me.TpTellerCust.UseVisualStyleBackColor = True
        '
        'BtnTellerRemitStart
        '
        Me.BtnTellerRemitStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTellerRemitStart.Image = CType(resources.GetObject("BtnTellerRemitStart.Image"), System.Drawing.Image)
        Me.BtnTellerRemitStart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTellerRemitStart.Location = New System.Drawing.Point(201, 550)
        Me.BtnTellerRemitStart.Name = "BtnTellerRemitStart"
        Me.BtnTellerRemitStart.Size = New System.Drawing.Size(310, 38)
        Me.BtnTellerRemitStart.TabIndex = 4
        Me.BtnTellerRemitStart.Text = "START TRANSACTION"
        Me.BtnTellerRemitStart.UseVisualStyleBackColor = True
        '
        'LinkNextCustomer
        '
        Me.LinkNextCustomer.AutoSize = True
        Me.LinkNextCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkNextCustomer.Location = New System.Drawing.Point(551, 558)
        Me.LinkNextCustomer.Name = "LinkNextCustomer"
        Me.LinkNextCustomer.Size = New System.Drawing.Size(164, 16)
        Me.LinkNextCustomer.TabIndex = 10
        Me.LinkNextCustomer.TabStop = True
        Me.LinkNextCustomer.Text = "GO TO NEXT PAGE >>"
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
        Me.Label15.Size = New System.Drawing.Size(157, 16)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Total amount to remit:"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Customer Name:"
        '
        'TpTellerReceiver
        '
        Me.TpTellerReceiver.Controls.Add(Me.LinkNextReceiver)
        Me.TpTellerReceiver.Controls.Add(Me.TxtReceiverRefNo3)
        Me.TpTellerReceiver.Controls.Add(Me.TxtReceiverRefNo2)
        Me.TpTellerReceiver.Controls.Add(Me.GroupBox3)
        Me.TpTellerReceiver.Controls.Add(Me.TxtRecAddress)
        Me.TpTellerReceiver.Controls.Add(Me.Label20)
        Me.TpTellerReceiver.Controls.Add(Me.TxtRecRelationship)
        Me.TpTellerReceiver.Controls.Add(Me.Label21)
        Me.TpTellerReceiver.Controls.Add(Me.TxtRecMobile)
        Me.TpTellerReceiver.Controls.Add(Me.Label16)
        Me.TpTellerReceiver.Controls.Add(Me.CboRecIDtype)
        Me.TpTellerReceiver.Controls.Add(Me.Label17)
        Me.TpTellerReceiver.Controls.Add(Me.TxtreceiverRefNo1)
        Me.TpTellerReceiver.Controls.Add(Me.Label18)
        Me.TpTellerReceiver.Controls.Add(Me.TxtRecName)
        Me.TpTellerReceiver.Controls.Add(Me.Label19)
        Me.TpTellerReceiver.Location = New System.Drawing.Point(4, 34)
        Me.TpTellerReceiver.Name = "TpTellerReceiver"
        Me.TpTellerReceiver.Padding = New System.Windows.Forms.Padding(3)
        Me.TpTellerReceiver.Size = New System.Drawing.Size(745, 598)
        Me.TpTellerReceiver.TabIndex = 0
        Me.TpTellerReceiver.Text = "RECEIVER"
        Me.TpTellerReceiver.UseVisualStyleBackColor = True
        '
        'LinkNextReceiver
        '
        Me.LinkNextReceiver.AutoSize = True
        Me.LinkNextReceiver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkNextReceiver.Location = New System.Drawing.Point(506, 510)
        Me.LinkNextReceiver.Name = "LinkNextReceiver"
        Me.LinkNextReceiver.Size = New System.Drawing.Size(164, 16)
        Me.LinkNextReceiver.TabIndex = 8
        Me.LinkNextReceiver.TabStop = True
        Me.LinkNextReceiver.Text = "GO TO NEXT PAGE >>"
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
        Me.GroupBox3.TabIndex = 6
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
        Me.TxtRecBranchAdd.TabIndex = 7
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
        Me.CboCorrespondent.TabIndex = 6
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
        Me.TxtRecAddress.Name = "TxtRecAddress"
        Me.TxtRecAddress.Size = New System.Drawing.Size(364, 20)
        Me.TxtRecAddress.TabIndex = 5
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
        Me.TxtRecRelationship.TabIndex = 3
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
        Me.TxtRecMobile.MaxLength = 15
        Me.TxtRecMobile.Name = "TxtRecMobile"
        Me.TxtRecMobile.Size = New System.Drawing.Size(218, 20)
        Me.TxtRecMobile.TabIndex = 4
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
        Me.CboRecIDtype.TabIndex = 2
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
        Me.TxtRecName.TabIndex = 1
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
        'TpTellerReceipt
        '
        Me.TpTellerReceipt.Controls.Add(Me.BtnTellerNewTrans)
        Me.TpTellerReceipt.Controls.Add(Me.BtnTellerRemitPreview)
        Me.TpTellerReceipt.Controls.Add(Me.PanelTellerRemitReceipt)
        Me.TpTellerReceipt.Controls.Add(Me.BtnTellerPrintRemit)
        Me.TpTellerReceipt.Controls.Add(Me.BtnTellerSaveRemit)
        Me.TpTellerReceipt.Location = New System.Drawing.Point(4, 34)
        Me.TpTellerReceipt.Name = "TpTellerReceipt"
        Me.TpTellerReceipt.Padding = New System.Windows.Forms.Padding(3)
        Me.TpTellerReceipt.Size = New System.Drawing.Size(745, 598)
        Me.TpTellerReceipt.TabIndex = 2
        Me.TpTellerReceipt.Text = "PRINT RECEIPT"
        Me.TpTellerReceipt.UseVisualStyleBackColor = True
        '
        'BtnTellerNewTrans
        '
        Me.BtnTellerNewTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTellerNewTrans.Image = CType(resources.GetObject("BtnTellerNewTrans.Image"), System.Drawing.Image)
        Me.BtnTellerNewTrans.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTellerNewTrans.Location = New System.Drawing.Point(480, 552)
        Me.BtnTellerNewTrans.Name = "BtnTellerNewTrans"
        Me.BtnTellerNewTrans.Size = New System.Drawing.Size(250, 38)
        Me.BtnTellerNewTrans.TabIndex = 6
        Me.BtnTellerNewTrans.Text = "NEW TRANSACTION"
        Me.BtnTellerNewTrans.UseVisualStyleBackColor = True
        '
        'BtnTellerRemitPreview
        '
        Me.BtnTellerRemitPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTellerRemitPreview.Image = CType(resources.GetObject("BtnTellerRemitPreview.Image"), System.Drawing.Image)
        Me.BtnTellerRemitPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTellerRemitPreview.Location = New System.Drawing.Point(285, 551)
        Me.BtnTellerRemitPreview.Name = "BtnTellerRemitPreview"
        Me.BtnTellerRemitPreview.Size = New System.Drawing.Size(181, 40)
        Me.BtnTellerRemitPreview.TabIndex = 5
        Me.BtnTellerRemitPreview.Text = "VIEW RECEIPT"
        Me.BtnTellerRemitPreview.UseVisualStyleBackColor = True
        '
        'PanelTellerRemitReceipt
        '
        Me.PanelTellerRemitReceipt.Controls.Add(Me.Label72)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.Label70)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.Label86)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.Label85)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.Label84)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.Label83)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.Label82)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.Label79)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.Label77)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.Label69)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.Label67)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.Label65)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.Label62)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.Label60)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.LabelAmtInWordsReceipt)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.Label61)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.LblreceiverName)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.Label51)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.LbltotalAmount)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.Label39)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.Lblcharge)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.Label37)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.Lblamount)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.Label34)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.LblexpiryDate)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.Label38)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.Label32)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.LblissuePlace)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.LblissueDate)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.Label36)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.LblCustName)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.Label28)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.Label26)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.LblRefNo)
        Me.PanelTellerRemitReceipt.Controls.Add(Me.Label25)
        Me.PanelTellerRemitReceipt.Location = New System.Drawing.Point(7, 7)
        Me.PanelTellerRemitReceipt.Name = "PanelTellerRemitReceipt"
        Me.PanelTellerRemitReceipt.Size = New System.Drawing.Size(732, 538)
        Me.PanelTellerRemitReceipt.TabIndex = 4
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Location = New System.Drawing.Point(505, 247)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(46, 13)
        Me.Label72.TabIndex = 109
        Me.Label72.Text = "days left"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Location = New System.Drawing.Point(427, 247)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(34, 13)
        Me.Label70.TabIndex = 108
        Me.Label70.Text = "Days:"
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.Location = New System.Drawing.Point(31, 480)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(213, 9)
        Me.Label86.TabIndex = 107
        Me.Label86.Text = "the receiver failed to claim it within the range of specified date."
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.Location = New System.Drawing.Point(30, 470)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(166, 9)
        Me.Label85.TabIndex = 106
        Me.Label85.Text = "The company will not allow any refund incase of"
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.Location = New System.Drawing.Point(31, 454)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(78, 9)
        Me.Label84.TabIndex = 105
        Me.Label84.Text = "this transaction void.  "
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.Location = New System.Drawing.Point(31, 444)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(187, 9)
        Me.Label83.TabIndex = 104
        Me.Label83.Text = "Failure to claim the money by the receiver will subject"
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.Location = New System.Drawing.Point(30, 435)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(206, 9)
        Me.Label82.TabIndex = 103
        Me.Label82.Text = "This transaction is only valid upon the specified date herein. "
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.Location = New System.Drawing.Point(30, 419)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(169, 13)
        Me.Label79.TabIndex = 102
        Me.Label79.Text = "TERMS AND CONDITIONS :"
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.ForeColor = System.Drawing.Color.Maroon
        Me.Label77.Location = New System.Drawing.Point(30, 121)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(651, 13)
        Me.Label77.TabIndex = 101
        Me.Label77.Text = "_________________________________________________________________________________" &
    "___________"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.Location = New System.Drawing.Point(453, 375)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(175, 13)
        Me.Label69.TabIndex = 100
        Me.Label69.Text = "________________________"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(456, 393)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(167, 13)
        Me.Label67.TabIndex = 99
        Me.Label67.Text = "Signature over printed name"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(33, 85)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(203, 13)
        Me.Label65.TabIndex = 98
        Me.Label65.Text = "43 SHAW BLVD. MANDALUYONG CITY"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(33, 103)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(137, 13)
        Me.Label62.TabIndex = 97
        Me.Label62.Text = "BIR NO. : 123-987-437-000"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(30, 68)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(235, 13)
        Me.Label60.TabIndex = 96
        Me.Label60.Text = "CONNECT TECH MONEY REMITTANCE"
        '
        'LabelAmtInWordsReceipt
        '
        Me.LabelAmtInWordsReceipt.AutoSize = True
        Me.LabelAmtInWordsReceipt.Location = New System.Drawing.Point(136, 340)
        Me.LabelAmtInWordsReceipt.Name = "LabelAmtInWordsReceipt"
        Me.LabelAmtInWordsReceipt.Size = New System.Drawing.Size(63, 13)
        Me.LabelAmtInWordsReceipt.TabIndex = 95
        Me.LabelAmtInWordsReceipt.Text = "totalAmount"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(30, 340)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(108, 13)
        Me.Label61.TabIndex = 94
        Me.Label61.Text = "Amount in words :"
        '
        'LblreceiverName
        '
        Me.LblreceiverName.AutoSize = True
        Me.LblreceiverName.Location = New System.Drawing.Point(130, 200)
        Me.LblreceiverName.Name = "LblreceiverName"
        Me.LblreceiverName.Size = New System.Drawing.Size(73, 13)
        Me.LblreceiverName.TabIndex = 93
        Me.LblreceiverName.Text = "receiverName"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(30, 200)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(98, 13)
        Me.Label51.TabIndex = 92
        Me.Label51.Text = "Receiver Name:"
        '
        'LbltotalAmount
        '
        Me.LbltotalAmount.AutoSize = True
        Me.LbltotalAmount.Location = New System.Drawing.Point(167, 314)
        Me.LbltotalAmount.Name = "LbltotalAmount"
        Me.LbltotalAmount.Size = New System.Drawing.Size(63, 13)
        Me.LbltotalAmount.TabIndex = 91
        Me.LbltotalAmount.Text = "totalAmount"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(26, 314)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(140, 13)
        Me.Label39.TabIndex = 90
        Me.Label39.Text = "Total Amount Remitted:"
        '
        'Lblcharge
        '
        Me.Lblcharge.AutoSize = True
        Me.Lblcharge.Location = New System.Drawing.Point(83, 285)
        Me.Lblcharge.Name = "Lblcharge"
        Me.Lblcharge.Size = New System.Drawing.Size(40, 13)
        Me.Lblcharge.TabIndex = 89
        Me.Lblcharge.Text = "charge"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(30, 285)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(51, 13)
        Me.Label37.TabIndex = 88
        Me.Label37.Text = "Charge:"
        '
        'Lblamount
        '
        Me.Lblamount.AutoSize = True
        Me.Lblamount.Location = New System.Drawing.Point(83, 269)
        Me.Lblamount.Name = "Lblamount"
        Me.Lblamount.Size = New System.Drawing.Size(42, 13)
        Me.Lblamount.TabIndex = 87
        Me.Lblamount.Text = "amount"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(30, 269)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(53, 13)
        Me.Label34.TabIndex = 86
        Me.Label34.Text = "Amount:"
        '
        'LblexpiryDate
        '
        Me.LblexpiryDate.AutoSize = True
        Me.LblexpiryDate.Location = New System.Drawing.Point(506, 222)
        Me.LblexpiryDate.Name = "LblexpiryDate"
        Me.LblexpiryDate.Size = New System.Drawing.Size(57, 13)
        Me.LblexpiryDate.TabIndex = 85
        Me.LblexpiryDate.Text = "expiryDate"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(427, 178)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(77, 13)
        Me.Label38.TabIndex = 80
        Me.Label38.Text = "Issue Place:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(427, 223)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(76, 13)
        Me.Label32.TabIndex = 84
        Me.Label32.Text = "Expiry Date:"
        '
        'LblissuePlace
        '
        Me.LblissuePlace.AutoSize = True
        Me.LblissuePlace.Location = New System.Drawing.Point(505, 178)
        Me.LblissuePlace.Name = "LblissuePlace"
        Me.LblissuePlace.Size = New System.Drawing.Size(58, 13)
        Me.LblissuePlace.TabIndex = 81
        Me.LblissuePlace.Text = "issuePlace"
        '
        'LblissueDate
        '
        Me.LblissueDate.AutoSize = True
        Me.LblissueDate.Location = New System.Drawing.Point(506, 201)
        Me.LblissueDate.Name = "LblissueDate"
        Me.LblissueDate.Size = New System.Drawing.Size(54, 13)
        Me.LblissueDate.TabIndex = 83
        Me.LblissueDate.Text = "issueDate"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(427, 201)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 13)
        Me.Label36.TabIndex = 82
        Me.Label36.Text = "Issue Date:"
        '
        'LblCustName
        '
        Me.LblCustName.AutoSize = True
        Me.LblCustName.Location = New System.Drawing.Point(129, 180)
        Me.LblCustName.Name = "LblCustName"
        Me.LblCustName.Size = New System.Drawing.Size(55, 13)
        Me.LblCustName.TabIndex = 79
        Me.LblCustName.Text = "custName"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(30, 180)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(96, 13)
        Me.Label28.TabIndex = 78
        Me.Label28.Text = "Received From:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Maroon
        Me.Label26.Location = New System.Drawing.Point(28, 36)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(173, 25)
        Me.Label26.TabIndex = 77
        Me.Label26.Text = "Official Receipt"
        '
        'LblRefNo
        '
        Me.LblRefNo.AutoSize = True
        Me.LblRefNo.Location = New System.Drawing.Point(147, 149)
        Me.LblRefNo.Name = "LblRefNo"
        Me.LblRefNo.Size = New System.Drawing.Size(66, 13)
        Me.LblRefNo.TabIndex = 76
        Me.LblRefNo.Text = "referenceNo"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(29, 149)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(117, 13)
        Me.Label25.TabIndex = 75
        Me.Label25.Text = "Reference Number:"
        '
        'BtnTellerPrintRemit
        '
        Me.BtnTellerPrintRemit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTellerPrintRemit.Image = CType(resources.GetObject("BtnTellerPrintRemit.Image"), System.Drawing.Image)
        Me.BtnTellerPrintRemit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTellerPrintRemit.Location = New System.Drawing.Point(22, 551)
        Me.BtnTellerPrintRemit.Name = "BtnTellerPrintRemit"
        Me.BtnTellerPrintRemit.Size = New System.Drawing.Size(250, 38)
        Me.BtnTellerPrintRemit.TabIndex = 3
        Me.BtnTellerPrintRemit.Text = "PRINT TRANSACTION"
        Me.BtnTellerPrintRemit.UseVisualStyleBackColor = True
        '
        'BtnTellerSaveRemit
        '
        Me.BtnTellerSaveRemit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTellerSaveRemit.Image = Global.RemittanceSystem.My.Resources.Resources.save2
        Me.BtnTellerSaveRemit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTellerSaveRemit.Location = New System.Drawing.Point(22, 551)
        Me.BtnTellerSaveRemit.Name = "BtnTellerSaveRemit"
        Me.BtnTellerSaveRemit.Size = New System.Drawing.Size(250, 38)
        Me.BtnTellerSaveRemit.TabIndex = 2
        Me.BtnTellerSaveRemit.Text = "SAVE TRANSACTION"
        Me.BtnTellerSaveRemit.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'PanelTellerClaimTrans
        '
        Me.PanelTellerClaimTrans.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PanelTellerClaimTrans.Controls.Add(Me.TabControlTellerClaim)
        Me.PanelTellerClaimTrans.Location = New System.Drawing.Point(189, 47)
        Me.PanelTellerClaimTrans.Name = "PanelTellerClaimTrans"
        Me.PanelTellerClaimTrans.Size = New System.Drawing.Size(786, 637)
        Me.PanelTellerClaimTrans.TabIndex = 24
        '
        'TabControlTellerClaim
        '
        Me.TabControlTellerClaim.Controls.Add(Me.TabPageClaim)
        Me.TabControlTellerClaim.Controls.Add(Me.TabPageClaimReceipt)
        Me.TabControlTellerClaim.ItemSize = New System.Drawing.Size(200, 30)
        Me.TabControlTellerClaim.Location = New System.Drawing.Point(2, 2)
        Me.TabControlTellerClaim.Name = "TabControlTellerClaim"
        Me.TabControlTellerClaim.SelectedIndex = 0
        Me.TabControlTellerClaim.Size = New System.Drawing.Size(743, 635)
        Me.TabControlTellerClaim.TabIndex = 1
        '
        'TabPageClaim
        '
        Me.TabPageClaim.Controls.Add(Me.BtnTellerClaimCancel)
        Me.TabPageClaim.Controls.Add(Me.BtnTellerStartClaim)
        Me.TabPageClaim.Controls.Add(Me.LinkLabelcNext)
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
        Me.TabPageClaim.Size = New System.Drawing.Size(735, 597)
        Me.TabPageClaim.TabIndex = 0
        Me.TabPageClaim.Text = "CLAIM TRANSACTION"
        Me.TabPageClaim.UseVisualStyleBackColor = True
        '
        'BtnTellerClaimCancel
        '
        Me.BtnTellerClaimCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTellerClaimCancel.Image = CType(resources.GetObject("BtnTellerClaimCancel.Image"), System.Drawing.Image)
        Me.BtnTellerClaimCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTellerClaimCancel.Location = New System.Drawing.Point(389, 553)
        Me.BtnTellerClaimCancel.Name = "BtnTellerClaimCancel"
        Me.BtnTellerClaimCancel.Size = New System.Drawing.Size(205, 37)
        Me.BtnTellerClaimCancel.TabIndex = 52
        Me.BtnTellerClaimCancel.Text = "CANCEL TRANSACTION"
        Me.BtnTellerClaimCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTellerClaimCancel.UseVisualStyleBackColor = True
        '
        'BtnTellerStartClaim
        '
        Me.BtnTellerStartClaim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTellerStartClaim.Image = CType(resources.GetObject("BtnTellerStartClaim.Image"), System.Drawing.Image)
        Me.BtnTellerStartClaim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTellerStartClaim.Location = New System.Drawing.Point(84, 554)
        Me.BtnTellerStartClaim.Name = "BtnTellerStartClaim"
        Me.BtnTellerStartClaim.Size = New System.Drawing.Size(231, 37)
        Me.BtnTellerStartClaim.TabIndex = 51
        Me.BtnTellerStartClaim.Text = "START CLAIM TRANSACTION"
        Me.BtnTellerStartClaim.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTellerStartClaim.UseVisualStyleBackColor = True
        '
        'LinkLabelcNext
        '
        Me.LinkLabelcNext.AutoSize = True
        Me.LinkLabelcNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelcNext.Location = New System.Drawing.Point(646, 564)
        Me.LinkLabelcNext.Name = "LinkLabelcNext"
        Me.LinkLabelcNext.Size = New System.Drawing.Size(68, 16)
        Me.LinkLabelcNext.TabIndex = 50
        Me.LinkLabelcNext.TabStop = True
        Me.LinkLabelcNext.Text = "NEXT >>"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.BtnClaimChangeStat)
        Me.GroupBox8.Controls.Add(Me.Label58)
        Me.GroupBox8.Controls.Add(Me.TxtClaimStatus)
        Me.GroupBox8.Controls.Add(Me.Label57)
        Me.GroupBox8.Controls.Add(Me.TxtClaimExpiryDate)
        Me.GroupBox8.Controls.Add(Me.Label59)
        Me.GroupBox8.Controls.Add(Me.TxtDateIssueClaim)
        Me.GroupBox8.Location = New System.Drawing.Point(39, 410)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(579, 137)
        Me.GroupBox8.TabIndex = 49
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "TRANSACTION STATUS:"
        '
        'BtnClaimChangeStat
        '
        Me.BtnClaimChangeStat.Location = New System.Drawing.Point(354, 83)
        Me.BtnClaimChangeStat.Name = "BtnClaimChangeStat"
        Me.BtnClaimChangeStat.Size = New System.Drawing.Size(117, 23)
        Me.BtnClaimChangeStat.TabIndex = 52
        Me.BtnClaimChangeStat.Text = "CHANGE STATUS"
        Me.BtnClaimChangeStat.UseVisualStyleBackColor = True
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(18, 90)
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
        Me.TxtClaimExpiryDate.Location = New System.Drawing.Point(18, 111)
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
        'TxtDateIssueClaim
        '
        Me.TxtDateIssueClaim.Enabled = False
        Me.TxtDateIssueClaim.Location = New System.Drawing.Point(18, 47)
        Me.TxtDateIssueClaim.Name = "TxtDateIssueClaim"
        Me.TxtDateIssueClaim.Size = New System.Drawing.Size(173, 20)
        Me.TxtDateIssueClaim.TabIndex = 2
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
        Me.GroupBox7.Location = New System.Drawing.Point(39, 237)
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
        Me.TxtClaimRefNo.Location = New System.Drawing.Point(226, 26)
        Me.TxtClaimRefNo.Name = "TxtClaimRefNo"
        Me.TxtClaimRefNo.Size = New System.Drawing.Size(173, 20)
        Me.TxtClaimRefNo.TabIndex = 4
        '
        'BtnSearch
        '
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSearch.Location = New System.Drawing.Point(35, 19)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(181, 32)
        Me.BtnSearch.TabIndex = 3
        Me.BtnSearch.Text = "SEARCH REFERENCE NO."
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'TabPageClaimReceipt
        '
        Me.TabPageClaimReceipt.Controls.Add(Me.PanelTellerClaimReceipt)
        Me.TabPageClaimReceipt.Controls.Add(Me.BtnTellerClaimPreview)
        Me.TabPageClaimReceipt.Controls.Add(Me.BtnTellerClaimSave)
        Me.TabPageClaimReceipt.Controls.Add(Me.BtnClaimPrintTeller)
        Me.TabPageClaimReceipt.Location = New System.Drawing.Point(4, 34)
        Me.TabPageClaimReceipt.Name = "TabPageClaimReceipt"
        Me.TabPageClaimReceipt.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageClaimReceipt.Size = New System.Drawing.Size(735, 597)
        Me.TabPageClaimReceipt.TabIndex = 1
        Me.TabPageClaimReceipt.Text = "RECEIPT"
        Me.TabPageClaimReceipt.UseVisualStyleBackColor = True
        '
        'BtnTellerClaimPreview
        '
        Me.BtnTellerClaimPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTellerClaimPreview.Location = New System.Drawing.Point(517, 547)
        Me.BtnTellerClaimPreview.Name = "BtnTellerClaimPreview"
        Me.BtnTellerClaimPreview.Size = New System.Drawing.Size(158, 40)
        Me.BtnTellerClaimPreview.TabIndex = 321
        Me.BtnTellerClaimPreview.Text = "VIEW RECEIPT"
        Me.BtnTellerClaimPreview.UseVisualStyleBackColor = True
        '
        'BtnTellerClaimSave
        '
        Me.BtnTellerClaimSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTellerClaimSave.Image = Global.RemittanceSystem.My.Resources.Resources.save2
        Me.BtnTellerClaimSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTellerClaimSave.Location = New System.Drawing.Point(21, 550)
        Me.BtnTellerClaimSave.Name = "BtnTellerClaimSave"
        Me.BtnTellerClaimSave.Size = New System.Drawing.Size(310, 38)
        Me.BtnTellerClaimSave.TabIndex = 319
        Me.BtnTellerClaimSave.Text = "SAVE TRANSACTION"
        Me.BtnTellerClaimSave.UseVisualStyleBackColor = True
        '
        'BtnClaimPrintTeller
        '
        Me.BtnClaimPrintTeller.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClaimPrintTeller.Image = CType(resources.GetObject("BtnClaimPrintTeller.Image"), System.Drawing.Image)
        Me.BtnClaimPrintTeller.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnClaimPrintTeller.Location = New System.Drawing.Point(21, 550)
        Me.BtnClaimPrintTeller.Name = "BtnClaimPrintTeller"
        Me.BtnClaimPrintTeller.Size = New System.Drawing.Size(310, 38)
        Me.BtnClaimPrintTeller.TabIndex = 320
        Me.BtnClaimPrintTeller.Text = "PRINT TRANSACTION"
        Me.BtnClaimPrintTeller.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintDocumentTellerSender
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocumentTellerClaim
        '
        '
        'PrintPreviewDialogTellerClaim
        '
        Me.PrintPreviewDialogTellerClaim.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogTellerClaim.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogTellerClaim.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialogTellerClaim.Enabled = True
        Me.PrintPreviewDialogTellerClaim.Icon = CType(resources.GetObject("PrintPreviewDialogTellerClaim.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialogTellerClaim.Name = "PrintPreviewDialogTellerClaim"
        Me.PrintPreviewDialogTellerClaim.Visible = False
        '
        'TreeViewTeller
        '
        Me.TreeViewTeller.ImageIndex = 0
        Me.TreeViewTeller.ImageList = Me.ImageList1
        Me.TreeViewTeller.Location = New System.Drawing.Point(1001, 178)
        Me.TreeViewTeller.Name = "TreeViewTeller"
        Me.TreeViewTeller.SelectedImageIndex = 0
        Me.TreeViewTeller.Size = New System.Drawing.Size(335, 400)
        Me.TreeViewTeller.TabIndex = 25
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label49.Location = New System.Drawing.Point(1057, 130)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(221, 20)
        Me.Label49.TabIndex = 26
        Me.Label49.Text = "TELLER FILE EXPLORER"
        '
        'FormTeller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1362, 712)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.TreeViewTeller)
        Me.Controls.Add(Me.LabelSysDate)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelTellerClaimTrans)
        Me.Controls.Add(Me.PanelTellerRemit)
        Me.Controls.Add(Me.PanelTellerHome)
        Me.Name = "FormTeller"
        Me.Text = "TELLER REMIT AND CLAIM TRANSACTION:"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelTellerClaimReceipt.ResumeLayout(False)
        Me.PanelTellerClaimReceipt.PerformLayout()
        Me.PanelTellerHome.ResumeLayout(False)
        Me.TabControlTellerHome.ResumeLayout(False)
        Me.TabPageTellerSender.ResumeLayout(False)
        Me.TabPageTellerSender.PerformLayout()
        CType(Me.dgvTellerTodayTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageTellerClaim.ResumeLayout(False)
        Me.TabPageTellerClaim.PerformLayout()
        CType(Me.dgvTellerClaim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTellerRemit.ResumeLayout(False)
        Me.TabControlTellerRemit.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TpTellerCust.ResumeLayout(False)
        Me.TpTellerCust.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TpTellerReceiver.ResumeLayout(False)
        Me.TpTellerReceiver.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TpTellerReceipt.ResumeLayout(False)
        Me.PanelTellerRemitReceipt.ResumeLayout(False)
        Me.PanelTellerRemitReceipt.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTellerClaimTrans.ResumeLayout(False)
        Me.TabControlTellerClaim.ResumeLayout(False)
        Me.TabPageClaim.ResumeLayout(False)
        Me.TabPageClaim.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.TabPageClaimReceipt.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LblTellerUserID As Label
    Friend WithEvents LblTellerEmpID As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label63 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnTellerClaim As Button
    Friend WithEvents BtnTellerLogout As Button
    Friend WithEvents BtnTellerHome As Button
    Friend WithEvents BtnTellerRemit As Button
    Friend WithEvents LabelSysDate As Label
    Friend WithEvents LblTellerDate As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PanelTellerHome As Panel
    Friend WithEvents TabControlTellerHome As TabControl
    Friend WithEvents TabPageTellerSender As TabPage
    Friend WithEvents dgvTellerTodayTransaction As DataGridView
    Friend WithEvents TabPageTellerClaim As TabPage
    Friend WithEvents BtnTellerRefresh1 As Button
    Friend WithEvents dgvTellerClaim As DataGridView
    Friend WithEvents BtnTellerRefresh2 As Button
    Friend WithEvents BtnTellerHomePrint1 As Button
    Friend WithEvents BtnTellerHomePrint2 As Button
    Friend WithEvents PanelTellerRemit As Panel
    Friend WithEvents TabControlTellerRemit As TabControl
    Friend WithEvents TpTellerCust As TabPage
    Friend WithEvents LinkNextCustomer As LinkLabel
    Friend WithEvents TxtRefNo3 As TextBox
    Friend WithEvents TxtRefNo2 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtTotalAmt As TextBox
    Friend WithEvents Txtholder As TextBox
    Friend WithEvents Txtchange As TextBox
    Friend WithEvents Label73 As Label
    Friend WithEvents TxtCashTendered As TextBox
    Friend WithEvents Label75 As Label
    Friend WithEvents TxtCharge As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtAmount As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtExpirtyDate As TextBox
    Friend WithEvents TxtIssueDate As TextBox
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
    Friend WithEvents Label2 As Label
    Friend WithEvents TpTellerReceiver As TabPage
    Friend WithEvents LinkNextReceiver As LinkLabel
    Friend WithEvents TxtReceiverRefNo3 As TextBox
    Friend WithEvents TxtReceiverRefNo2 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtrecAmount As TextBox
    Friend WithEvents TxtRecBranchAdd As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents CboCorrespondent As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
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
    Friend WithEvents TpTellerReceipt As TabPage
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents BtnTellerSaveRemit As Button
    Friend WithEvents BtnTellerPrintRemit As Button
    Friend WithEvents BtnTellerRemitStart As Button
    Friend WithEvents PanelTellerClaimTrans As Panel
    Friend WithEvents TabControlTellerClaim As TabControl
    Friend WithEvents TabPageClaim As TabPage
    Friend WithEvents LinkLabelcNext As LinkLabel
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label58 As Label
    Friend WithEvents TxtClaimStatus As TextBox
    Friend WithEvents Label57 As Label
    Friend WithEvents TxtClaimExpiryDate As TextBox
    Friend WithEvents Label59 As Label
    Friend WithEvents TxtDateIssueClaim As TextBox
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
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TabPageClaimReceipt As TabPage
    Friend WithEvents BtnTellerStartClaim As Button
    Friend WithEvents BtnClaimChangeStat As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents BtnTellerHomePreview1 As Button
    Friend WithEvents BtnTellerHomePreview2 As Button
    Friend WithEvents PrintDocumentTellerSender As Printing.PrintDocument
    Friend WithEvents PanelTellerRemitReceipt As Panel
    Friend WithEvents BtnTellerRemitPreview As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents LblreceiverName As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents LbltotalAmount As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Lblcharge As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Lblamount As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents LblexpiryDate As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents LblissuePlace As Label
    Friend WithEvents LblissueDate As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents LblCustName As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents LblRefNo As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents LabelAmtInWordsReceipt As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label86 As Label
    Friend WithEvents Label85 As Label
    Friend WithEvents Label84 As Label
    Friend WithEvents Label83 As Label
    Friend WithEvents Label82 As Label
    Friend WithEvents Label79 As Label
    Friend WithEvents Label77 As Label
    Friend WithEvents Label69 As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents BtnTellerClaimPreview As Button
    Friend WithEvents PanelTellerClaimReceipt As Panel
    Friend WithEvents LabelcStatus As Label
    Friend WithEvents LabelcAmount As Label
    Friend WithEvents LabelcBranch As Label
    Friend WithEvents LabelcCorrespondent As Label
    Friend WithEvents LabelcRefNo As Label
    Friend WithEvents LabelcAddress As Label
    Friend WithEvents LabelcMobileNo As Label
    Friend WithEvents LabelcName As Label
    Friend WithEvents Label88 As Label
    Friend WithEvents Label90 As Label
    Friend WithEvents Label94 As Label
    Friend WithEvents Label96 As Label
    Friend WithEvents Label98 As Label
    Friend WithEvents LblTellerClaimAmtInWords As Label
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
    Friend WithEvents BtnTellerClaimSave As Button
    Friend WithEvents BtnClaimPrintTeller As Button
    Friend WithEvents PrintDocumentTellerClaim As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialogTellerClaim As PrintPreviewDialog
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents LblTellerCheckBranck As Label
    Friend WithEvents Label107 As Label
    Friend WithEvents LblTellerCheckCorr As Label
    Friend WithEvents Label105 As Label
    Friend WithEvents LblTellerCheckRecMob As Label
    Friend WithEvents Label103 As Label
    Friend WithEvents LblTellerCheckRecRel As Label
    Friend WithEvents Label101 As Label
    Friend WithEvents LblTellerCheckRecId As Label
    Friend WithEvents Label99 As Label
    Friend WithEvents LblTellerCheckRecName As Label
    Friend WithEvents Label95 As Label
    Friend WithEvents LblTellerCheckTotal As Label
    Friend WithEvents Label81 As Label
    Friend WithEvents LblTellerCheckCharge As Label
    Friend WithEvents Label78 As Label
    Friend WithEvents LblTellerCheckAmountRemit As Label
    Friend WithEvents Label74 As Label
    Friend WithEvents LblTellerCheckIssuePlace As Label
    Friend WithEvents Label71 As Label
    Friend WithEvents LblTellerCheckExpiry As Label
    Friend WithEvents Label68 As Label
    Friend WithEvents LblTellerCheckIssue As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents LblTellerCheckCustRel As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents LblTellerCheckAddress As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents LblTellerCheckMob As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents LblTellerCheckPurpose As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents LblTellerCheckCustName As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents LblTellerCheckIDtype As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents LblTellerCheckRefNo As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents LblTellerCheckRecAmount As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents LblTellerCheckRecAdd As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents LinkLabelCheckNext As LinkLabel
    Friend WithEvents Label41 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BtnTellerNewTrans As Button
    Friend WithEvents BtnTellerCancelRemit As Button
    Friend WithEvents Label44 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents BtnTellerClaimCancel As Button
    Friend WithEvents Label49 As Label
    Friend WithEvents TreeViewTeller As TreeView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents BtnAdminTool As Button
    Friend WithEvents Label72 As Label
    Friend WithEvents Label70 As Label
    Friend WithEvents Label66 As Label
End Class
