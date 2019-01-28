Imports Oracle.ManagedDataAccess.Client
Imports Oracle.DataAccess.Client
Imports System.Drawing.Printing

Public Class FormManager

    Private bmp As Bitmap
    Private m_currentIndex As Integer
    Dim MyDataGridViewPrinter As DataGridViewPrinter

    Private Sub FormManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mRootNode As New TreeNode
        mRootNode.Text = RootPath
        mRootNode.Tag = RootPath
        mRootNode.Nodes.Add("*DUMMY*")
        TreeViewAdmin.Nodes.Add(mRootNode)

        mRootNode.ImageKey = CacheShellIcon(RootPath)
        mRootNode.SelectedImageKey = mRootNode.ImageKey

        'shows a message if there is a expired transaction
        dateValidation()

        DisplayData()
        'BtnSaveTran.Enabled = False
        'BtnAdminRemitPrint.Enabled = False

        'BtnAdminRemitPreview.Enabled = False
        'BtnAdminNewTrans.Enabled = False
        'TabPage3.Enabled = False
        'BtnClaimSaveTrans.Enabled = False
        'PanelSenderInfo.Enabled = False
        'm_currentIndex = 0

        'TxtCustName.Enabled = False
        'CboIDtype.Enabled = False
        'TxtMobile.Enabled = False
        'TxtPurpose.Enabled = False
        'TxtAddress.Enabled = False
        'TxtRelationtoRec.Enabled = False
        'TxtIssuePlace.Enabled = False
        'TxtAmount.Enabled = False

        'PbviewButtons.Hide()
        'PbviewFiles.Show()

    End Sub


    Private mRootPath As String = "c:\Users\ronal\source\repos\RemittanceSystem\Admin Files"
    Property RootPath As String
        Get
            Return mRootPath
        End Get
        Set(value As String)
            mRootPath = value
        End Set
    End Property

    Private Sub TreeViewAdmin_BeforeCollapse(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeViewAdmin.BeforeCollapse

        e.Node.Nodes.Clear()

        e.Node.Nodes.Add("*DUMMY*")

    End Sub

    Private Sub TreeViewAdmin_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeViewAdmin.BeforeExpand

        e.Node.Nodes.Clear()

        Dim mNodeDirectory As IO.DirectoryInfo
        mNodeDirectory = New IO.DirectoryInfo(e.Node.Tag.ToString)



        For Each mDirectory As IO.DirectoryInfo In mNodeDirectory.GetDirectories
            Dim mDirectoryNode As New TreeNode

            mDirectoryNode.Tag = mDirectory.FullName

            mDirectoryNode.Text = mDirectory.Name

            mDirectoryNode.Nodes.Add("*DUMMY*")

            e.Node.Nodes.Add(mDirectoryNode)

            mDirectoryNode.ImageKey = CacheShellIcon(mDirectory.FullName)
            mDirectoryNode.SelectedImageKey = mDirectoryNode.ImageKey
        Next

        For Each mFile As IO.FileInfo In mNodeDirectory.GetFiles
            Dim mFileNode As New TreeNode

            mFileNode.Tag = mFile.FullName

            mFileNode.Text = mFile.Name

            mFileNode.ImageKey = CacheShellIcon(mFile.FullName)
            mFileNode.SelectedImageKey = mFileNode.ImageKey & "-open"
            e.Node.Nodes.Add(mFileNode)


        Next

    End Sub

    Function CacheShellIcon(ByVal argPath As String) As String
        Dim mKey As String = Nothing

        If IO.Directory.Exists(argPath) = True Then
            mKey = "Folder"
        ElseIf IO.File.Exists(argPath) = True Then
            mKey = IO.Path.GetExtension(argPath)
        End If

        If ImageList1.Images.ContainsKey(mKey) = False Then
            ImageList1.Images.Add(mKey, GetShellIconAsImage(argPath))
            ImageList1.Images.Add(mKey & "-open", GetShellIconAsImage(argPath))
        End If
        Return mKey
    End Function

    Private Sub TreeViewAdmin_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeViewAdmin.NodeMouseDoubleClick

        If e.Node.ImageKey = "Folder" Then
            Exit Sub
            If e.Node.Tag = "" Then
                Exit Sub

                Try
                    Process.Start(e.Node.Tag)
                Catch ex As Exception
                    MessageBox.Show("Error opening file: " & ex.Message)
                End Try
            End If
        End If

    End Sub
    'should open the files in treeview
    Private Sub TreeViewAdmin_NodeClick(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeViewAdmin.NodeMouseDoubleClick

        If Not String.IsNullOrEmpty(eventArgs.Node.Tag) Then
            Process.Start(eventArgs.Node.Tag)
        End If

    End Sub

    'expiry date validation

    Private Sub dateValidation()

        Refresh()
        Dim cos As Integer
        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
           + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
           + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
           + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()
        conn.ConnectionString = OraDB
        'Dim sql As String = "SELECT * FROM [REM_STATUS]"
        Dim cmd As New Oracle.DataAccess.Client.OracleCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        conn.Open()

        Try
            cmd.CommandText = "SELECT AMOUNT FROM REM_STATUS WHERE EXPIRY_DATE = TRUNC(SYSDATE) AND STATUS = 'NOT CLAIMED'"
            cos = cmd.ExecuteScalar()
            cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        If cos > 0 Then
            MessageBox.Show("Expired remittance detected", "EXPIRY VALIDATION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmd.CommandText = "UPDATE REM_STATUS SET STATUS = 'EXPIRED' WHERE EXPIRY_DATE = TRUNC(SYSDATE)"
            cmd.ExecuteNonQuery()
            Exit Sub
        End If

        conn.Close()




    End Sub

    Public Sub DisplayData()

        Refresh()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
            + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
            + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
            + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()
        conn.ConnectionString = OraDB
        Dim sql As String = "SELECT * FROM [REM_EMPLOYEE]"
        Dim cmd As New Oracle.DataAccess.Client.OracleCommand(sql, conn)
        cmd.CommandType = CommandType.Text

        conn.Open()

        Dim dt As New DataTable("REM_EMPLOYEE")
        Dim rs As New Oracle.DataAccess.Client.OracleDataAdapter(cmd)
        rs.Fill(dt)
        DgvUsers.DataSource = dt
        DgvUsers.Refresh()

        LblCount.Text = dt.Rows.Count
        rs.Dispose()
        conn.Close()

        'add a row for total amount
        'Dim total As Double
        'For i As Integer = 0 To DgvUsers.Rows.Count - 1
        'total = total + DgvUsers.Rows(i).Cells(5).Value
        'Next

        Dim blankRow = dt.NewRow
        blankRow(1) = ""
        dt.Rows.Add(blankRow)

        Dim myrow = dt.NewRow
        myrow(4) = "TOTAL NO. OF EMPLOYEE :  "
        myrow(5) = LblCount.Text
        ' myrow(5) = FormatNumber(total, 2)
        dt.Rows.Add(myrow)



    End Sub

    Private Sub BtnAddUser_Click(sender As Object, e As EventArgs) Handles BtnAddUser.Click
        FormCreateNewUser.Show()

    End Sub


    Private Sub DgvUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvUsers.CellContentClick
        DisplayData()
    End Sub

    'Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
    '   PanelHome.BringToFront()
    '  PanelTransaction.SendToBack()
    '  PanelHomeTools.BringToFront()
    '  PanelRemitTools.SendToBack()
    '  TabControl1.Show()
    '  DgvUsers.Show()
    '  BtnAddUser.Show()

    'End Sub
    'button transaction
    ' Private Sub BtnMakeTran_Click(sender As Object, e As EventArgs) Handles BtnMakeTran.Click
    '    PanelTransaction.BringToFront()
    '   PanelHome.SendToBack()
    '   PanelHomeTools.SendToBack()
    '   PanelRemitTools.BringToFront()
    '   TabControl1.Hide()
    '   BtnSaveTran.Enabled = False
    '   BtnStartTran.Enabled = True


    'End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click

        Dim goOut As Integer
        goOut = MessageBox.Show("End all session?", "LOG OUT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If goOut = DialogResult.OK Then

            Close()
            End
        End If

    End Sub

    Private Sub BtnShowFormUpdatePW_Click(sender As Object, e As EventArgs) Handles BtnShowFormUpdatePW.Click
        FormChangePW.Show()
    End Sub

    'make transaction tabcontrol print receipt / tabcontrol2 receipt
    'Private Sub TabPage5_Enter(sender As Object, e As EventArgs) Handles TabPage5.Enter
    '   BtnSaveTran.Enabled = True
    '  BtnAdminRemitPrint.Enabled = True
    ' BtnAdminRemitPreview.Enabled = True

    'End Sub
    'make transaction tabcontrol receiver info / tabcontrol2 customer
    ' Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Enter
    '    BtnSaveTran.Enabled = False
    '    BtnAdminRemitPrint.Enabled = False
    '    BtnAdminRemitPreview.Enabled = False
    '    TxtRefNo1.Enabled = False
    '    TxtRefNo2.Enabled = False
    '    TxtRefNo3.Enabled = False

    'End Sub
    'make transaction tabcontrol sender info / tabcontrol 2 receiver
    'Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Enter
    '   BtnSaveTran.Enabled = False
    '   BtnAdminRemitPrint.Enabled = False
    '   TxtreceiverRefNo1.Enabled = False
    '   TxtReceiverRefNo2.Enabled = False
    '   TxtReceiverRefNo3.Enabled = False
    'End Sub
    'Home tabcontrol user
    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPageEmployee.Click
        DgvUsers.Show()
        BtnAddUser.Show()

    End Sub








    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Lbldate.Text = Format(Now, "dd-MMM-yyyy")
        LabelDate.Text = Format(Now, "dddd, dd-MMM-yyyy hh:mm:ss tt")
        'Lbltime.TabIndex = Format(Now, "hh:mm:ss tt")
    End Sub





    'function for letter only validation, copy to all textbox that needs same validation
    Function ValidString(input As String)

        Dim userInput As String = input
        Dim filteredUserInput As String = userInput

        Dim listOfLetters As String() = New String() _
            {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O",
           "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f",
           "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v",
           "w", "x", "y", "z", " ", "."}

        For Each letter In listOfLetters
            filteredUserInput = Replace(filteredUserInput, letter, "")

        Next

        If (filteredUserInput <> "") Then
            Return False
        Else
            Return True
        End If

    End Function

    ' Private Sub TxtCustName_Leave(sender As Object, e As EventArgs) Handles TxtCustName.Leave

    '    If (TxtCustName.Text <> "") Then

    '       Dim userInput As String = TxtCustName.Text

    '      If Not (ValidString(userInput) = True) Then
    '         TxtCustName.Clear()
    '         TxtCustName.Focus()
    '         MessageBox.Show("Invalid character, letters only", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error)
    'End If
    'End If

    'End Sub


    'Private Sub TxtCashTendered_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCashTendered.KeyPress

    'sender mobile number
    '   If Asc(e.KeyChar) <> 8 Then
    '      If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
    '         e.Handled = True
    '        MessageBox.Show("Numbers only", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)

    '       TxtCashTendered.Text = ""
    '       TxtCashTendered.Focus()
    'End If
    'End If

    'End Sub






    'Public Sub InsertStatus()

    '   Dim OraDB As String = "Data Source= (DESCRIPTION =" _
    '   + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
    '   + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
    '   + "User Id=SYSTEM;Password=SYSTEM;"

    '  Dim conn As New Oracle.DataAccess.Client.OracleConnection()
    '  Dim transaction As Oracle.DataAccess.Client.OracleTransaction
    '  'Dim cmd As OracleCommand = conn.CreateCommand()
    '  conn.ConnectionString = OraDB

    '  conn.Open()

    '  Try
    '      Using cmd As Oracle.DataAccess.Client.OracleCommand = New Oracle.DataAccess.Client.OracleCommand(OraDB, conn)
    '          transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
    '          cmd.Transaction = transaction

    '          Const sqlStatus As String = "INSERT INTO REM_STATUS VALUES (:var1, :var2, :var3, :var4, :var5, :var6)"

    '         cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var1", LblRefNo.Text))
    '         cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var2", LblEmpID.Text))
    '         cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var3", LblissueDate.Text))
    '         cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var4", LblexpiryDate.Text))
    '         cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var5", ("NOT CLAIMED")))
    '         cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var6", LblAdminCheckRecAmount.Text))
    '         cmd.CommandText = sqlStatus

    '         cmd.ExecuteNonQuery()
    '         transaction.Commit()

    '         cmd.Dispose()
    '         conn.Close()

    '    End Using

    'Catch ex As Exception
    '   MsgBox(ex.Message)
    'End Try

    'End Sub

    'Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

    '   If TxtClaimRefNo.Text = "" Then

    '      MessageBox.Show("You cannot search without reference number.", "ERROR SEARCHING INFO", MessageBoxButtons.OK, MessageBoxIcon.Error)

    ' Else

    '    If TxtClaimStatus.Text = "EXPIRED" Then
    '       MessageBox.Show("This transaction is already expired.", "EXPIRED TRANSACTION", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '       BtnClaimSaveTrans.Enabled = False
    '       BtnClaimChangeStat.Enabled = False

    '  Else
    '      SearchClaimStatus()
    '      SearchClaimantInfo()
    '      BtnClaimSaveTrans.Enabled = True
    '      BtnClaimChangeStat.Enabled = True
    '      TxtClaimRefNo.Enabled = False

    'End If

    'End If

    'End Sub

    'searching claim record
    'Public Sub SearchClaimStatus()

    '   Dim OraDB As String = "Data Source= (DESCRIPTION =" _
    '  + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
    ' + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
    ' + "User Id=SYSTEM;Password=SYSTEM;"

    ' Dim dr As Oracle.DataAccess.Client.OracleDataReader
    ' Dim strRetrieve As String
    ' strRetrieve = "SELECT * FROM REM_STATUS WHERE (REFERENCE_NUMBER = '" & TxtClaimRefNo.Text & "')"

    'Dim conn As New Oracle.DataAccess.Client.OracleConnection()

    'conn.ConnectionString = OraDB

    'Dim cmd As Oracle.DataAccess.Client.OracleCommand = New Oracle.DataAccess.Client.OracleCommand(strRetrieve, conn)

    'conn.Open()

    'dr = cmd.ExecuteReader

    'Try

    '   While dr.Read

    '       TxtDateIssueClaim.Text = dr("ISSUE_DATE").ToString
    '       TxtClaimExpiryDate.Text = dr("EXPIRY_DATE").ToString
    '       TxtClaimStatus.Text = dr("STATUS").ToString

    '  End While

    '  TxtDateIssueClaim.Text = Format(CDate(TxtDateIssueClaim.Text), "dd-MMM-yyyy")
    '  TxtClaimExpiryDate.Text = Format(CDate(TxtClaimExpiryDate.Text), "dd-MMM-yyyy")
    'Catch ex As Exception
    '   MsgBox(ex.ToString)
    'End Try


    'End Sub

    'search claimant info
    'Public Sub SearchClaimantInfo()

    '    Dim OraDB As String = "Data Source= (DESCRIPTION =" _
    '  + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
    '  + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
    '  + "User Id=SYSTEM;Password=SYSTEM;"

    '    Dim dr As Oracle.DataAccess.Client.OracleDataReader
    '    Dim strClaim As String
    '    strClaim = "SELECT * FROM REM_BENEFICIARIES WHERE (REFERENCE_NUMBER = '" & TxtClaimRefNo.Text & "')"

    '    Dim conn As New Oracle.DataAccess.Client.OracleConnection()

    '    conn.ConnectionString = OraDB

    '    Dim cmd As Oracle.DataAccess.Client.OracleCommand = New Oracle.DataAccess.Client.OracleCommand(strClaim, conn)

    '    conn.Open()

    '    dr = cmd.ExecuteReader

    '    Try

    '        While dr.Read

    '            TxtClaimName.Text = dr("NAME").ToString
    '            TxtClaimIDtype.Text = dr("ID_TYPE").ToString
    '            TxtClaimMobile.Text = dr("MOBILE_NUMBER").ToString
    '            TxtClaimAddress.Text = dr("ADDRESS").ToString
    '            TxtClaimRelationship.Text = dr("RELATIONSHIP_TO_THE_SENDER").ToString
    '            TxtClaimCorrespondent.Text = dr("CORRESPONDENT").ToString
    '            TxtClaimBranch.Text = dr("BRANCH_ADDRESS").ToString
    '            TxtClaimAmount.Text = dr("AMOUNT_RECEIVED").ToString


    '        End While

    '        'TxtClaimAmount.Text = Format(C(TxtDateIssueClaim.Text), "dd-MMM-yyyy")

    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    End Try

    'End Sub





    Private Sub TabControl1_Selecting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles TabControl1.Selecting

        'm_currentIndex = 1

        If TabControl1.SelectedTab Is TabPageVStatus Then
            BtnSearchSender.SendToBack()
            BtnManageCustomers.SendToBack()
            BtnSearchBeneficiary.SendToBack()
            BtnSearchStat.BringToFront()
            dtpStat1.Enabled = False
            dtpStat2.Enabled = False
            DateTimePicker1.Enabled = False
            BtnAddUser.Enabled = False
            PanelSenderInfo.Enabled = False
        ElseIf TabControl1.SelectedTab Is TabPageSender Then
            BtnSearchSender.BringToFront()
            BtnSearchBeneficiary.SendToBack()
            BtnSearchStat.SendToBack()
            BtnManageCustomers.SendToBack()
            BtnAddUser.Enabled = False
            LabelRevenue.Visible = False
            LabelRevenueAmount.Visible = False
            PanelSenderInfo.Enabled = True
            dtpSenderDate.Enabled = False
            dtpSenderMonthly1.Enabled = False
            dtpSenderMonthly2.Enabled = False

        ElseIf TabControl1.SelectedTab Is TabPageEmployee Then
            BtnAddUser.Enabled = True
            BtnManageCustomers.BringToFront()
            BtnSearchBeneficiary.SendToBack()
            BtnSearchStat.SendToBack()
            BtnSearchSender.SendToBack()
            PanelSenderInfo.Enabled = False
            dtpSenderDate.Enabled = False
            dtpSenderMonthly1.Enabled = False
            dtpSenderMonthly2.Enabled = False

        ElseIf TabControl1.SelectedTab Is TabPageBeneficiary Then
            BtnSearchBeneficiary.BringToFront()
            BtnSearchSender.SendToBack()
            BtnSearchStat.SendToBack()
            BtnManageCustomers.SendToBack()
            PanelBeneNothing.BringToFront()
            PanelBeneCorrespondent.SendToBack()
            PanelBeneRefNo.SendToBack()
            'LabelBeneficiaryRefNo.Visible = False
            'TvBeneRefNo.Visible = False
            'LabelBeneCorres.Visible = False
            'CboBeneCorrespondent.Visible = False
        End If

        dtpSenderDate.Format = DateTimePickerFormat.Custom
        dtpSenderDate.CustomFormat = "dd-MMM-yy"

        dtpStat1.Format = DateTimePickerFormat.Custom
        dtpStat1.CustomFormat = "dd-MMM-yy"
        dtpStat2.Format = DateTimePickerFormat.Custom
        dtpStat2.CustomFormat = "dd-MMM-yy"

        dtpSenderMonthly1.Format = DateTimePickerFormat.Custom
        dtpSenderMonthly1.CustomFormat = "dd-MMM-yy"
        dtpSenderMonthly2.Format = DateTimePickerFormat.Custom
        dtpSenderMonthly2.CustomFormat = "dd-MMM-yy"

        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd-MMM-yy"

        'LabelinputRefNo.Visible = False
        'TvRefno.Visible = False


    End Sub

    Private Sub BtnSearchStat_Click(sender As Object, e As EventArgs) Handles BtnSearchStat.Click

        If CboCategory.SelectedIndex = 0 Then

            If RadClaimed.Checked Then
                DisplayClaimed()

            ElseIf RadNotClaimed.Checked Then
                DisplayNotClaimed()
            Else
                DisplayExpired()
            End If

        ElseIf CboCategory.SelectedIndex = 1 Then
            PanelSenderInfo.Enabled = True

            If RadToday.Checked Then

                DisplayToday()
            ElseIf RadSpecifyDate.Checked Then
                DisplaySpecificDate()
                DateTimePicker1.Enabled = True
            ElseIf RadPerMonth.Checked Then
                dtpStat1.Enabled = True
                dtpStat2.Enabled = True
                DisplayMonthly()
            End If

        ElseIf CboCategory.SelectedIndex = 2 Then
            DisplayRefNo()

        ElseIf CboCategory.SelectedIndex = 3 Then
            DisplayPerEmpID()


        End If

    End Sub

    'comboboxStatus

    Public Sub DisplayPerEmpID()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
          + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
          + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
          + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()
        conn.ConnectionString = OraDB
        Dim sql As String = "SELECT * FROM REM_STATUS WHERE EMPLOYEE_ID = '" & TvEmpIDStat.Text & "'"
        Dim cmd As New Oracle.DataAccess.Client.OracleCommand(sql, conn)
        cmd.CommandType = CommandType.Text

        conn.Open()

        Dim dt As New DataTable("REM_STATUS")
        Dim rs As New Oracle.DataAccess.Client.OracleDataAdapter(cmd)
        rs.Fill(dt)
        DgvStatus.DataSource = dt
        DgvStatus.Refresh()

        LblCount.Text = dt.Rows.Count
        rs.Dispose()
        conn.Close()

        'add a row for total amount
        Dim total As Double
        For i As Integer = 0 To DgvStatus.Rows.Count - 1
            total = total + DgvStatus.Rows(i).Cells(5).Value
        Next
        Dim blankRow = dt.NewRow
        blankRow(1) = ""
        dt.Rows.Add(blankRow)

        Dim myrow = dt.NewRow
        myrow(4) = "TOTAL AMOUNT:  "
        myrow(5) = FormatNumber(total, 2)
        dt.Rows.Add(myrow)

    End Sub

    Public Sub DisplayClaimed()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
            + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
            + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
            + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()
        conn.ConnectionString = OraDB
        Dim sql As String = "SELECT * FROM REM_STATUS WHERE STATUS = 'CLAIMED'"
        Dim cmd As New Oracle.DataAccess.Client.OracleCommand(sql, conn)
        cmd.CommandType = CommandType.Text

        conn.Open()

        Dim dt As New DataTable("REM_STATUS")
        Dim rs As New Oracle.DataAccess.Client.OracleDataAdapter(cmd)
        rs.Fill(dt)
        DgvStatus.DataSource = dt
        DgvStatus.Refresh()

        LblCount.Text = dt.Rows.Count
        rs.Dispose()
        conn.Close()

        'add a row for total amount
        Dim total As Double
        For i As Integer = 0 To DgvStatus.Rows.Count - 1
            total = total + DgvStatus.Rows(i).Cells(5).Value
        Next
        Dim blankRow = dt.NewRow
        blankRow(1) = ""
        dt.Rows.Add(blankRow)

        Dim myrow = dt.NewRow
        myrow(4) = "TOTAL AMOUNT:  "
        myrow(5) = FormatNumber(total, 2)
        dt.Rows.Add(myrow)

    End Sub

    Public Sub DisplayNotClaimed()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
            + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
            + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
            + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()
        conn.ConnectionString = OraDB
        Dim sql As String = "SELECT * FROM REM_STATUS WHERE STATUS = 'NOT CLAIMED'"
        Dim cmd As New Oracle.DataAccess.Client.OracleCommand(sql, conn)
        cmd.CommandType = CommandType.Text

        conn.Open()

        Dim dt As New DataTable("REM_STATUS")
        Dim rs As New Oracle.DataAccess.Client.OracleDataAdapter(cmd)
        rs.Fill(dt)
        DgvStatus.DataSource = dt
        DgvStatus.Refresh()

        LblCount.Text = dt.Rows.Count
        rs.Dispose()
        conn.Close()
        'add a row for total amount
        Dim total As Double
        For i As Integer = 0 To DgvStatus.Rows.Count - 1
            total = total + DgvStatus.Rows(i).Cells(5).Value
        Next
        Dim blankRow = dt.NewRow
        blankRow(1) = ""
        dt.Rows.Add(blankRow)

        Dim myrow = dt.NewRow
        myrow(4) = "TOTAL AMOUNT:  "
        myrow(5) = FormatNumber(total, 2)
        dt.Rows.Add(myrow)

    End Sub

    Public Sub DisplayExpired()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
            + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
            + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
            + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()
        conn.ConnectionString = OraDB
        Dim sql As String = "SELECT * FROM REM_STATUS WHERE STATUS = 'EXPIRED'"
        Dim cmd As New Oracle.DataAccess.Client.OracleCommand(sql, conn)
        cmd.CommandType = CommandType.Text

        conn.Open()

        Dim dt As New DataTable("REM_STATUS")
        Dim rs As New Oracle.DataAccess.Client.OracleDataAdapter(cmd)
        rs.Fill(dt)
        DgvStatus.DataSource = dt
        DgvStatus.Refresh()

        LblCount.Text = dt.Rows.Count
        rs.Dispose()
        conn.Close()

        'add a row for total amount
        Dim total As Double
        For i As Integer = 0 To DgvStatus.Rows.Count - 1
            total = total + DgvStatus.Rows(i).Cells(5).Value
        Next
        Dim blankRow = dt.NewRow
        blankRow(1) = ""
        dt.Rows.Add(blankRow)

        Dim myrow = dt.NewRow
        myrow(4) = "TOTAL AMOUNT:  "
        myrow(5) = FormatNumber(total, 2)
        dt.Rows.Add(myrow)

    End Sub

    'comboboxDate
    Public Sub DisplayToday()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
            + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
            + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
            + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()
        conn.ConnectionString = OraDB
        Dim sql As String = "SELECT * FROM REM_STATUS WHERE ISSUE_DATE = '" & Lbldate.Text & "'"
        Dim cmd As New Oracle.DataAccess.Client.OracleCommand(sql, conn)
        cmd.CommandType = CommandType.Text

        conn.Open()

        Dim dt As New DataTable("REM_STATUS")
        Dim rs As New Oracle.DataAccess.Client.OracleDataAdapter(cmd)
        rs.Fill(dt)
        DgvStatus.DataSource = dt
        DgvStatus.Refresh()

        LblCount.Text = dt.Rows.Count
        rs.Dispose()
        conn.Close()

        'add a row for total amount
        Dim total As Double
        For i As Integer = 0 To DgvStatus.Rows.Count - 1
            total = total + DgvStatus.Rows(i).Cells(5).Value
        Next
        Dim blankRow = dt.NewRow
        blankRow(1) = ""
        dt.Rows.Add(blankRow)

        Dim myrow = dt.NewRow
        myrow(4) = "TOTAL AMOUNT:  "
        myrow(5) = FormatNumber(total, 2)
        dt.Rows.Add(myrow)

    End Sub

    Public Sub DisplaySpecificDate()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
            + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
            + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
            + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()
        conn.ConnectionString = OraDB
        Dim sql As String = "SELECT * FROM REM_STATUS WHERE ISSUE_DATE = '" & TextDTGpicker.Text & "'"

        Try
            TextDTGpicker.Text = Format(CDate(TextDTGpicker.Text), "dd-MMM-yyyy")
        Catch ex As Exception
            MessageBox.Show("Select a date first")
        End Try

        Dim cmd As New Oracle.DataAccess.Client.OracleCommand(sql, conn)
        cmd.CommandType = CommandType.Text

        conn.Open()

        Dim dt As New DataTable("REM_STATUS")
        Dim rs As New Oracle.DataAccess.Client.OracleDataAdapter(cmd)
        rs.Fill(dt)
        DgvStatus.DataSource = dt
        DgvStatus.Refresh()

        LblCount.Text = dt.Rows.Count
        rs.Dispose()
        conn.Close()

        'add a row for total amount
        Dim total As Double
        For i As Integer = 0 To DgvStatus.Rows.Count - 1
            total = total + DgvStatus.Rows(i).Cells(5).Value
        Next
        Dim blankRow = dt.NewRow
        blankRow(1) = ""
        dt.Rows.Add(blankRow)

        Dim myrow = dt.NewRow
        myrow(4) = "TOTAL AMOUNT:  "
        myrow(5) = FormatNumber(total, 2)
        dt.Rows.Add(myrow)

    End Sub

    'displaying by reference number
    Public Sub DisplayRefNo()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
            + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
            + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
            + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()
        conn.ConnectionString = OraDB
        Dim sql As String = "SELECT * FROM REM_STATUS WHERE REFERENCE_NUMBER = '" & TvRefno.Text & "'"

        Dim cmd As New Oracle.DataAccess.Client.OracleCommand(sql, conn)
        cmd.CommandType = CommandType.Text

        conn.Open()

        Dim dt As New DataTable("REM_STATUS")
        Dim rs As New Oracle.DataAccess.Client.OracleDataAdapter(cmd)
        rs.Fill(dt)
        DgvStatus.DataSource = dt
        DgvStatus.Refresh()

        LblCount.Text = dt.Rows.Count
        rs.Dispose()
        conn.Close()
        'add a row for total amount
        Dim total As Double
        For i As Integer = 0 To DgvStatus.Rows.Count - 1
            total = total + DgvStatus.Rows(i).Cells(5).Value
        Next
        Dim blankRow = dt.NewRow
        blankRow(1) = ""
        dt.Rows.Add(blankRow)

        Dim myrow = dt.NewRow
        myrow(4) = "TOTAL AMOUNT:  "
        myrow(5) = FormatNumber(total, 2)
        dt.Rows.Add(myrow)

    End Sub


    'DISPLAYING THE MONTHS FUNCTION


    Public Sub DisplayMonthly()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
          + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
          + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
          + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()
        conn.ConnectionString = OraDB
        Dim sql As String = "SELECT * FROM REM_STATUS WHERE ISSUE_DATE BETWEEN '" & Txtdtp1Picker.Text & "' AND '" & Txtdtp2Picker.Text & "'"

        Dim cmd As New Oracle.DataAccess.Client.OracleCommand(sql, conn)
        cmd.CommandType = CommandType.Text

        conn.Open()

        Dim dt As New DataTable("REM_STATUS")
        Dim rs As New Oracle.DataAccess.Client.OracleDataAdapter(cmd)
        rs.Fill(dt)
        DgvStatus.DataSource = dt
        DgvStatus.Refresh()

        LblCount.Text = dt.Rows.Count
        rs.Dispose()
        conn.Close()

        'add a row for total amount
        Dim total As Double
        For i As Integer = 0 To DgvStatus.Rows.Count - 1
            total = total + DgvStatus.Rows(i).Cells(5).Value
        Next
        Dim blankRow = dt.NewRow
        blankRow(1) = ""
        dt.Rows.Add(blankRow)

        Dim myrow = dt.NewRow
        myrow(4) = "TOTAL AMOUNT:  "
        myrow(5) = FormatNumber(total, 2)
        dt.Rows.Add(myrow)

    End Sub

    'category for status in tab control 1
    Private Sub CboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCategory.SelectedIndexChanged

        If CboCategory.SelectedIndex = 0 Then
            PanelStatus.BringToFront()
            PanelDateStat.SendToBack()
            'LabelinputRefNo.Visible = False
            'TvRefno.Visible = False
            PanelStatNothing.BringToFront()
            PanelRefNo.SendToBack()
            PanelEmpId.SendToBack()

            RadPerMonth.Enabled = True
            RadToday.Enabled = True
            RadSpecifyDate.Enabled = True

        ElseIf CboCategory.SelectedIndex = 1 Then

            PanelDateStat.BringToFront()
            PanelStatus.SendToBack()
            dtpStat1.Enabled = False
            dtpStat2.Enabled = False
            DateTimePicker1.Enabled = False
            'LabelinputRefNo.Visible = False
            'TvRefno.Visible = False
            PanelStatNothing.BringToFront()
            PanelRefNo.SendToBack()
            PanelEmpId.SendToBack()
            RadPerMonth.Enabled = True
            RadToday.Enabled = True
            RadSpecifyDate.Enabled = True


        ElseIf CboCategory.SelectedIndex = 2 Then
            'LabelinputRefNo.Visible = True
            'TvRefno.Visible = True
            PanelStatNothing.SendToBack()
            PanelRefNo.BringToFront()
            PanelEmpId.SendToBack()
            TvRefno.Clear()
            RadPerMonth.Enabled = False
            RadToday.Enabled = False
            RadSpecifyDate.Enabled = False
            RadClaimed.Enabled = False
            RadExpired.Enabled = False
            RadNotClaimed.Enabled = False

        ElseIf CboCategory.SelectedIndex = 3 Then
            PanelStatNothing.SendToBack()
            PanelRefNo.SendToBack()
            PanelEmpId.BringToFront()
            TvEmpIDStat.Clear()
            RadPerMonth.Enabled = False
            RadToday.Enabled = False
            RadSpecifyDate.Enabled = False
            RadClaimed.Enabled = False
            RadExpired.Enabled = False
            RadNotClaimed.Enabled = False


        ElseIf String.IsNullOrEmpty(CboCategory.Text) Then
            dtpSenderDate.Enabled = False
            dtpSenderMonthly1.Enabled = False
            dtpSenderMonthly2.Enabled = False
            RadSenderPerMonth.Enabled = False
            RadToday.Enabled = False
            RadSpecifyDate.Enabled = False
        End If

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker1.Enabled = True
        TextDTGpicker.Text = DateTimePicker1.Value
        TextDTGpicker.Text = Format(CDate(TextDTGpicker.Text), "dd-MMM-yyyy")
        'TxtClaimExpiryDate.Text = Format(CDate(TxtClaimExpiryDate.Text), "dd-MMM-yyyy")

    End Sub

    'SEARCH FOR SENDER INFO FROM CONTROL TAB 1
    Private Sub BtnSearchSender_Click(sender As Object, e As EventArgs) Handles BtnSearchSender.Click

        If CboSenderCategory.SelectedIndex = 0 Then
            DisplaySenderReferenceNumber()
        ElseIf CboSenderCategory.SelectedIndex = 1 Then
            If RadSenderToday.Checked Then
                SenderToday()
                dtpSenderDate.Enabled = False
                dtpSenderMonthly1.Enabled = False
                dtpSenderMonthly2.Enabled = False
            ElseIf RadSenderSpecifyDate.Checked Then
                SenderSpecificDate()
                dtpSenderDate.Enabled = True
                dtpSenderMonthly1.Enabled = False
                dtpSenderMonthly2.Enabled = False
            ElseIf RadSenderPerMonth.Checked Then
                dtpSenderDate.Enabled = False
                dtpSenderMonthly1.Enabled = True
                dtpSenderMonthly2.Enabled = True
                DisplaySenderMontly()
            End If
        ElseIf CboSenderCategory.SelectedIndex = 2 Then
            TotalRevenue()
        End If

    End Sub

    'DATE FUNCTION FOR SENDER DATE INFO TABCONTROL 1


    Public Sub DisplaySenderMontly()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
          + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
          + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
          + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()
        conn.ConnectionString = OraDB
        Dim sql As String = "SELECT REFERENCE_NUMBER, NAME, ISSUE_DATE, EXPIRY_DATE, AMOUNT, CHARGE, TOTAL_AMOUNT FROM REM_CUSTOMER WHERE ISSUE_DATE BETWEEN '" & TxtdtpSenderHandler1.Text & "' AND '" & TxtdtpSenderHandler2.Text & "'"

        Dim cmd As New Oracle.DataAccess.Client.OracleCommand(sql, conn)
        cmd.CommandType = CommandType.Text

        conn.Open()

        Dim dt As New DataTable("REM_CUSTOMER")
        Dim rs As New Oracle.DataAccess.Client.OracleDataAdapter(cmd)
        rs.Fill(dt)
        DgvSenderInfo.DataSource = dt
        DgvSenderInfo.Refresh()

        'LblCount.Text = dt.Rows.Count
        rs.Dispose()
        conn.Close()

        'add a row for total amount
        Dim total, total2 As Double
        For i As Integer = 0 To DgvSenderInfo.Rows.Count - 1
            total = total + DgvSenderInfo.Rows(i).Cells(5).Value
            total2 = total2 + DgvSenderInfo.Rows(i).Cells(6).Value
        Next
        Dim myrow = dt.NewRow
        Dim myrow2 = dt.NewRow
        Dim blankRow = dt.NewRow

        blankRow(1) = ""
        dt.Rows.Add(blankRow)

        myrow(5) = "TOTAL CHARGES:  "
        myrow(6) = FormatNumber(total, 2)
        dt.Rows.Add(myrow)

        myrow2(5) = "TOTAL REMITTANCE: "
        myrow2(6) = FormatNumber(total2, 2)
        dt.Rows.Add(myrow2)


    End Sub

    Public Sub DisplaySenderReferenceNumber()


        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
          + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
          + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
          + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()
        conn.ConnectionString = OraDB
        Dim sql As String = "SELECT REFERENCE_NUMBER, NAME, ISSUE_DATE, EXPIRY_DATE, AMOUNT, CHARGE, TOTAL_AMOUNT
 FROM REM_CUSTOMER WHERE REFERENCE_NUMBER = '" & TvSenderRefNo.Text & "'"

        Dim cmd As New Oracle.DataAccess.Client.OracleCommand(sql, conn)
        cmd.CommandType = CommandType.Text

        conn.Open()

        Dim dt As New DataTable("REM_CUSTOMER")
        Dim rs As New Oracle.DataAccess.Client.OracleDataAdapter(cmd)
        rs.Fill(dt)
        DgvSenderInfo.DataSource = dt
        DgvSenderInfo.Refresh()

        LblCount.Text = dt.Rows.Count
        rs.Dispose()
        conn.Close()

        'add a row for total amount
        Dim total, total2 As Double
        For i As Integer = 0 To DgvSenderInfo.Rows.Count - 1
            total = total + DgvSenderInfo.Rows(i).Cells(5).Value
            total2 = total2 + DgvSenderInfo.Rows(i).Cells(6).Value
        Next
        Dim myrow = dt.NewRow
        Dim myrow2 = dt.NewRow
        Dim blankRow = dt.NewRow

        blankRow(1) = ""
        dt.Rows.Add(blankRow)

        myrow(5) = "TOTAL CHARGES:  "
        myrow(6) = FormatNumber(total, 2)
        dt.Rows.Add(myrow)

        myrow2(5) = "TOTAL REMITTANCE: "
        myrow2(6) = FormatNumber(total2, 2)
        dt.Rows.Add(myrow2)


    End Sub

    'selecting for total revenue in sender info control tab 1
    Public Sub TotalRevenue()
        Dim totalval As Double = 0
        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
          + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
          + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
          + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()
        conn.ConnectionString = OraDB
        Dim sql As String = "SELECT REFERENCE_NUMBER, NAME, ISSUE_DATE, EXPIRY_DATE, AMOUNT, CHARGE, TOTAL_AMOUNT FROM REM_CUSTOMER"

        Dim cmd As New Oracle.DataAccess.Client.OracleCommand(sql, conn)
        cmd.CommandType = CommandType.Text

        conn.Open()

        Dim dt As New DataTable("REM_CUSTOMER")
        Dim rs As New Oracle.DataAccess.Client.OracleDataAdapter(cmd)
        rs.Fill(dt)
        DgvSenderInfo.DataSource = dt
        DgvSenderInfo.Refresh()



        For i As Integer = 0 To DgvSenderInfo.RowCount - 1
            totalval += DgvSenderInfo.Rows(i).Cells(5).Value
        Next
        LabelRevenueAmount.Text = FormatNumber(totalval, 2)

        rs.Dispose()
        conn.Close()

        'add a row for total amount
        Dim total, total2 As Double
        For i As Integer = 0 To DgvSenderInfo.Rows.Count - 1
            total = total + DgvSenderInfo.Rows(i).Cells(5).Value
            total2 = total2 + DgvSenderInfo.Rows(i).Cells(6).Value
        Next
        Dim myrow = dt.NewRow
        Dim myrow2 = dt.NewRow
        Dim blankRow = dt.NewRow

        blankRow(1) = ""
        dt.Rows.Add(blankRow)

        myrow(5) = "TOTAL CHARGES:  "
        myrow(6) = FormatNumber(total, 2)
        dt.Rows.Add(myrow)

        myrow2(5) = "TOTAL REMITTANCE: "
        myrow2(6) = FormatNumber(total2, 2)
        dt.Rows.Add(myrow2)

    End Sub
    'sender tabcontrol1 date today
    Public Sub SenderToday()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
          + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
          + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
          + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()
        conn.ConnectionString = OraDB
        Dim sql As String = "SELECT REFERENCE_NUMBER, NAME, ISSUE_DATE, EXPIRY_DATE, AMOUNT, CHARGE, TOTAL_AMOUNT FROM REM_CUSTOMER WHERE ISSUE_DATE = '" & Lbldate.Text & "'"
        Dim cmd As New Oracle.DataAccess.Client.OracleCommand(sql, conn)
        cmd.CommandType = CommandType.Text

        conn.Open()

        Dim dt As New DataTable("REM_CUSTOMER")
        Dim rs As New Oracle.DataAccess.Client.OracleDataAdapter(cmd)
        rs.Fill(dt)
        DgvSenderInfo.DataSource = dt
        DgvSenderInfo.Refresh()

        LblCount.Text = dt.Rows.Count
        rs.Dispose()
        conn.Close()


        'add a row for total amount
        Dim total, total2 As Double
        For i As Integer = 0 To DgvSenderInfo.Rows.Count - 1
            total = total + DgvSenderInfo.Rows(i).Cells(5).Value
            total2 = total2 + DgvSenderInfo.Rows(i).Cells(6).Value
        Next
        Dim myrow = dt.NewRow
        Dim myrow2 = dt.NewRow
        Dim blankRow = dt.NewRow

        blankRow(1) = ""
        dt.Rows.Add(blankRow)

        myrow(5) = "TOTAL CHARGES:  "
        myrow(6) = FormatNumber(total, 2)
        dt.Rows.Add(myrow)

        myrow2(5) = "TOTAL REMITTANCE: "
        myrow2(6) = FormatNumber(total2, 2)
        dt.Rows.Add(myrow2)

    End Sub
    'sender specific date tabcontrol 1
    Public Sub SenderSpecificDate()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
           + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
           + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
           + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()
        conn.ConnectionString = OraDB
        Dim sql As String = "SELECT REFERENCE_NUMBER, NAME, ISSUE_DATE, EXPIRY_DATE, AMOUNT, CHARGE, TOTAL_AMOUNT FROM REM_CUSTOMER WHERE ISSUE_DATE = '" & TvSenderDateholder.Text & "'"
        'TvSenderDateholder.Text = Format(CDate(TvSenderDateholder.Text), "dd-MMM-yyyy")
        Dim cmd As New Oracle.DataAccess.Client.OracleCommand(sql, conn)
        cmd.CommandType = CommandType.Text

        conn.Open()

        Dim dt As New DataTable("REM_CUSTOMER")
        Dim rs As New Oracle.DataAccess.Client.OracleDataAdapter(cmd)
        rs.Fill(dt)
        DgvSenderInfo.DataSource = dt
        DgvSenderInfo.Refresh()

        LblCount.Text = dt.Rows.Count
        rs.Dispose()
        conn.Close()

        'add a row for total amount
        Dim total, total2 As Double
        For i As Integer = 0 To DgvSenderInfo.Rows.Count - 1
            total = total + DgvSenderInfo.Rows(i).Cells(5).Value
            total2 = total2 + DgvSenderInfo.Rows(i).Cells(6).Value
        Next
        Dim myrow = dt.NewRow
        Dim myrow2 = dt.NewRow
        Dim blankRow = dt.NewRow

        blankRow(1) = ""
        dt.Rows.Add(blankRow)

        myrow(5) = "TOTAL CHARGES:  "
        myrow(6) = FormatNumber(total, 2)
        dt.Rows.Add(myrow)

        myrow2(5) = "TOTAL REMITTANCE: "
        myrow2(6) = FormatNumber(total2, 2)
        dt.Rows.Add(myrow2)

    End Sub

    'search for ref number of beneficiary tab control 1
    Public Sub BeneficiaryReferenceNumber()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
          + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
          + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
          + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()
        conn.ConnectionString = OraDB
        Dim sql As String = "SELECT REFERENCE_NUMBER, NAME, CORRESPONDENT, BRANCH_ADDRESS, AMOUNT_RECEIVED FROM REM_BENEFICIARIES WHERE REFERENCE_NUMBER = '" & TvBeneRefNo.Text & "'"

        Dim cmd As New Oracle.DataAccess.Client.OracleCommand(sql, conn)
        cmd.CommandType = CommandType.Text

        conn.Open()

        Dim dt As New DataTable("REM_BENEFICIARIES")
        Dim rs As New Oracle.DataAccess.Client.OracleDataAdapter(cmd)
        rs.Fill(dt)
        dtgBeneficiary.DataSource = dt
        dtgBeneficiary.Refresh()

        LblCount.Text = dt.Rows.Count
        rs.Dispose()
        conn.Close()

        'add a row for total amount
        Dim total As Double
        For i As Integer = 0 To dtgBeneficiary.Rows.Count - 1
            total = total + dtgBeneficiary.Rows(i).Cells(4).Value

        Next
        Dim myrow = dt.NewRow
        Dim myrow2 = dt.NewRow
        Dim blankRow = dt.NewRow

        blankRow(1) = ""
        dt.Rows.Add(blankRow)

        myrow(3) = "TOTAL AMOUNT:  "
        myrow(4) = FormatNumber(total, 2)
        dt.Rows.Add(myrow)

    End Sub

    Public Sub BeneficiaryCorrespondent()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
         + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
         + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
         + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()
        conn.ConnectionString = OraDB
        Dim sql As String = "SELECT REFERENCE_NUMBER, NAME, CORRESPONDENT, BRANCH_ADDRESS, AMOUNT_RECEIVED FROM REM_BENEFICIARIES WHERE CORRESPONDENT = '" & CboBeneCorrespondent.Text & "'"

        Dim cmd As New Oracle.DataAccess.Client.OracleCommand(sql, conn)
        cmd.CommandType = CommandType.Text

        conn.Open()

        Dim dt As New DataTable("REM_BENEFICIARIES")
        Dim rs As New Oracle.DataAccess.Client.OracleDataAdapter(cmd)
        rs.Fill(dt)
        dtgBeneficiary.DataSource = dt
        dtgBeneficiary.Refresh()

        LblCount.Text = dt.Rows.Count
        rs.Dispose()
        conn.Close()

        'add a row for total amount
        Dim total As Double
        For i As Integer = 0 To dtgBeneficiary.Rows.Count - 1
            total = total + dtgBeneficiary.Rows(i).Cells(4).Value

        Next
        Dim myrow = dt.NewRow

        Dim blankRow = dt.NewRow

        blankRow(1) = ""
        dt.Rows.Add(blankRow)

        myrow(3) = "TOTAL AMOUNT:  "
        myrow(4) = FormatNumber(total, 2)
        dt.Rows.Add(myrow)

    End Sub

    'category for sender info control tab 1
    Private Sub CboSenderCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboSenderCategory.SelectedIndexChanged

        If CboSenderCategory.SelectedIndex = 0 Then
            LabelSenderRefNo.Visible = True
            TvSenderRefNo.Visible = True
            LabelRevenue.Visible = False
            LabelRevenueAmount.Visible = False
            PanelSenderInfo.Enabled = False
            RadSenderToday.Enabled = False
            RadSenderSpecifyDate.Enabled = False
            RadSenderPerMonth.Enabled = False
        ElseIf CboSenderCategory.SelectedIndex = 1 Then
            LabelSenderRefNo.Visible = False
            TvSenderRefNo.Visible = False
            LabelRevenue.Visible = False
            LabelRevenueAmount.Visible = False
            PanelSenderInfo.Enabled = True
            RadSenderToday.Enabled = True
            RadSenderSpecifyDate.Enabled = True
            RadSenderPerMonth.Enabled = True
        ElseIf CboSenderCategory.SelectedIndex = 2 Then
            RadSenderToday.Enabled = False
            RadSenderSpecifyDate.Enabled = False
            RadSenderPerMonth.Enabled = False
            LabelSenderRefNo.Visible = False
            TvSenderRefNo.Visible = False
            LabelRevenue.Visible = True
            LabelRevenueAmount.Visible = True
            PanelSenderInfo.Enabled = False
        End If

    End Sub

    Private Sub dtpSenderDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpSenderDate.ValueChanged
        TvSenderDateholder.Text = dtpSenderDate.Value
        TvSenderDateholder.Text = Format(CDate(TvSenderDateholder.Text), "dd-MMM-yyyy")
        'TxtClaimExpiryDate.Text = Format(CDate(TxtClaimExpiryDate.Text), "dd-MMM-yyyy")
    End Sub

    Private Sub dtpStat1_ValueChanged(sender As Object, e As EventArgs) Handles dtpStat1.ValueChanged
        Txtdtp1Picker.Text = dtpStat1.Value
        Txtdtp1Picker.Text = Format(CDate(Txtdtp1Picker.Text), "dd-MMM-yyyy")
    End Sub

    Private Sub dtpStat2_ValueChanged(sender As Object, e As EventArgs) Handles dtpStat2.ValueChanged
        Txtdtp2Picker.Text = dtpStat2.Value
        Txtdtp2Picker.Text = Format(CDate(Txtdtp2Picker.Text), "dd-MMM-yyyy")
    End Sub

    Private Sub dtpSenderMonthly1_ValueChanged(sender As Object, e As EventArgs) Handles dtpSenderMonthly1.ValueChanged
        TxtdtpSenderHandler1.Text = dtpSenderMonthly1.Value
        TxtdtpSenderHandler1.Text = Format(CDate(TxtdtpSenderHandler1.Text), "dd-MMM-yyyy")
    End Sub

    Private Sub dtpSenderMonthly2_ValueChanged(sender As Object, e As EventArgs) Handles dtpSenderMonthly2.ValueChanged
        TxtdtpSenderHandler2.Text = dtpSenderMonthly2.Value
        TxtdtpSenderHandler2.Text = Format(CDate(TxtdtpSenderHandler2.Text), "dd-MMM-yyyy")
    End Sub

    Private Sub RadPerMonth_CheckedChanged(sender As Object, e As EventArgs) Handles RadPerMonth.CheckedChanged
        dtpStat1.Enabled = True
        dtpStat2.Enabled = True
        DateTimePicker1.Enabled = False
    End Sub

    Private Sub RadSpecifyDate_CheckedChanged(sender As Object, e As EventArgs) Handles RadSpecifyDate.CheckedChanged
        DateTimePicker1.Enabled = True
        dtpStat1.Enabled = False
        dtpStat2.Enabled = False
    End Sub

    Private Sub RadToday_CheckedChanged(sender As Object, e As EventArgs) Handles RadToday.CheckedChanged
        DateTimePicker1.Enabled = False
        dtpStat1.Enabled = False
        dtpStat2.Enabled = False
    End Sub

    Private Sub RadSenderPerMonth_CheckedChanged(sender As Object, e As EventArgs) Handles RadSenderPerMonth.CheckedChanged
        dtpSenderMonthly1.Enabled = True
        dtpSenderMonthly2.Enabled = True
        dtpSenderDate.Enabled = False
    End Sub

    Private Sub RadSenderSpecifyDate_CheckedChanged(sender As Object, e As EventArgs) Handles RadSenderSpecifyDate.CheckedChanged
        dtpSenderMonthly1.Enabled = False
        dtpSenderMonthly2.Enabled = False
        dtpSenderDate.Enabled = True
    End Sub

    Private Sub RadSenderToday_CheckedChanged(sender As Object, e As EventArgs) Handles RadSenderToday.CheckedChanged
        dtpSenderMonthly1.Enabled = False
        dtpSenderMonthly2.Enabled = False
        dtpSenderDate.Enabled = False
    End Sub

    Private Sub CboBeneCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboBeneCategory.SelectedIndexChanged

        If CboBeneCategory.SelectedIndex = 0 Then
            'LabelBeneficiaryRefNo.Visible = True
            'TvBeneRefNo.Visible = True
            'LabelBeneCorres.Visible = False
            'CboBeneCorrespondent.Visible = False
            PanelBeneNothing.SendToBack()
            PanelBeneCorrespondent.SendToBack()
            PanelBeneRefNo.BringToFront()

        ElseIf CboBeneCategory.SelectedIndex = 1 Then
            'LabelBeneficiaryRefNo.Visible = False
            'TvBeneRefNo.Visible = False
            'LabelBeneCorres.Visible = True
            'CboBeneCorrespondent.Visible = True
            PanelBeneNothing.SendToBack()
            PanelBeneCorrespondent.BringToFront()
            PanelBeneRefNo.SendToBack()
        End If

    End Sub

    Private Sub BtnSearchBeneficiary_Click(sender As Object, e As EventArgs) Handles BtnSearchBeneficiary.Click
        If CboBeneCategory.SelectedIndex = 0 Then
            BeneficiaryReferenceNumber()
        ElseIf CboBeneCategory.SelectedIndex = 1 Then
            BeneficiaryCorrespondent()
        End If
    End Sub


    'print functions and codes

    Private Sub BtnPrintAdminStatus_Click(sender As Object, e As EventArgs) Handles BtnPrintAdminStatus.Click

        If TabControl1.SelectedTab Is TabPageEmployee Then
            If SetupThePrintingEmployee() Then
                PrintDocument1.Print()
            End If
        ElseIf TabControl1.SelectedTab Is TabPageVStatus Then
            If SetupThePrinting() Then
                PrintDocument1.Print()
            End If
        ElseIf TabControl1.SelectedTab Is TabPageSender Then
            If SetupThePrintingSender() Then
                PrintDocument1.Print()
            End If
        ElseIf TabControl1.SelectedTab Is TabPageBeneficiary Then
            If SetupThePrintingBeneficiary() Then
                PrintDocument1.Print()
            Else
                MessageBox.Show("Nothing to print", "ERROR PRINTING", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim more As Boolean = MyDataGridViewPrinter.DrawDataGridView(e.Graphics)

        If more = True Then
            e.HasMorePages = True
        End If
    End Sub


    Private Sub BtnPrintViewAdminStat_Click(sender As Object, e As EventArgs) Handles BtnPrintViewAdminStat.Click

        If TabControl1.SelectedTab Is TabPageEmployee Then
            If SetupThePrintingEmployee() Then
                Dim MyPrintPreviewDialog As PrintPreviewDialog = New PrintPreviewDialog()
                MyPrintPreviewDialog.Document = PrintDocument1
                MyPrintPreviewDialog.ShowDialog()
            End If
        ElseIf TabControl1.SelectedTab Is TabPageVStatus Then
            If SetupThePrinting() Then
                Dim MyPrintPreviewDialog As PrintPreviewDialog = New PrintPreviewDialog()
                MyPrintPreviewDialog.Document = PrintDocument1
                MyPrintPreviewDialog.ShowDialog()
            End If
        ElseIf TabControl1.SelectedTab Is TabPageSender Then
            If SetupThePrintingSender() Then
                Dim MyPrintPreviewDialog As PrintPreviewDialog = New PrintPreviewDialog()
                MyPrintPreviewDialog.Document = PrintDocument1
                MyPrintPreviewDialog.ShowDialog()
            End If
        ElseIf TabControl1.SelectedTab Is TabPageBeneficiary Then
            If SetupThePrintingBeneficiary() Then
                Dim MyPrintPreviewDialog As PrintPreviewDialog = New PrintPreviewDialog()
                MyPrintPreviewDialog.Document = PrintDocument1
                MyPrintPreviewDialog.ShowDialog()
            Else
                MessageBox.Show("No Preview To Show", "ERROR PREVIEW", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    'for dataGridView of Status on Admin
    Private Function SetupThePrinting() As Boolean

        Dim MyPrintDialog As PrintDialog = New PrintDialog()
        MyPrintDialog.AllowCurrentPage = False
        MyPrintDialog.AllowPrintToFile = False
        MyPrintDialog.AllowSelection = False
        MyPrintDialog.AllowSomePages = False
        MyPrintDialog.ShowHelp = False
        MyPrintDialog.ShowNetwork = False

        If MyPrintDialog.ShowDialog() <> DialogResult.OK Then
            Return False
        End If

        PrintDocument1.DocumentName = "Transaction Status"

        PrintDocument1.PrinterSettings = MyPrintDialog.PrinterSettings
        PrintDocument1.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings
        PrintDocument1.DefaultPageSettings.Margins = New Margins(40, 40, 40, 40)

        If MessageBox.Show("Do you want the report to be centered on the page", "PRINT SETTINGS", MessageBoxButtons.YesNo, MessageBoxIcon.Information) Then
            MyDataGridViewPrinter = New DataGridViewPrinter(DgvStatus, PrintDocument1, True, True, "Status", New Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, True)
        Else
            MyDataGridViewPrinter = New DataGridViewPrinter(DgvStatus, PrintDocument1, False, True, "Status", New Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, True)
        End If

        Return True

    End Function

    Private Function SetupThePrintingEmployee() As Boolean

        Dim MyPrintDialog As PrintDialog = New PrintDialog()
        MyPrintDialog.AllowCurrentPage = False
        MyPrintDialog.AllowPrintToFile = False
        MyPrintDialog.AllowSelection = False
        MyPrintDialog.AllowSomePages = False
        MyPrintDialog.ShowHelp = False
        MyPrintDialog.ShowNetwork = False

        If MyPrintDialog.ShowDialog() <> DialogResult.OK Then
            Return False
        End If

        PrintDocument1.DocumentName = "EMPLOYEES"

        PrintDocument1.PrinterSettings = MyPrintDialog.PrinterSettings
        PrintDocument1.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings
        PrintDocument1.DefaultPageSettings.Margins = New Margins(40, 40, 40, 40)

        If MessageBox.Show("Do you want the report to be centered on the page", "PRINT SETTINGS", MessageBoxButtons.YesNo, MessageBoxIcon.Information) Then
            MyDataGridViewPrinter = New DataGridViewPrinter(DgvUsers, PrintDocument1, True, True, "Employees", New Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, True)
        Else
            MyDataGridViewPrinter = New DataGridViewPrinter(DgvUsers, PrintDocument1, False, True, "Employees", New Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, True)
        End If

        Return True

    End Function

    Private Function SetupThePrintingSender() As Boolean

        Dim MyPrintDialog As PrintDialog = New PrintDialog()
        MyPrintDialog.AllowCurrentPage = False
        MyPrintDialog.AllowPrintToFile = False
        MyPrintDialog.AllowSelection = False
        MyPrintDialog.AllowSomePages = False
        MyPrintDialog.ShowHelp = False
        MyPrintDialog.ShowNetwork = False

        If MyPrintDialog.ShowDialog() <> DialogResult.OK Then
            Return False
        End If

        PrintDocument1.DocumentName = "SENDER INFORMATION"

        PrintDocument1.PrinterSettings = MyPrintDialog.PrinterSettings
        PrintDocument1.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings
        PrintDocument1.DefaultPageSettings.Margins = New Margins(40, 40, 40, 40)

        If MessageBox.Show("Do you want the report to be centered on the page", "PRINT SETTINGS", MessageBoxButtons.YesNo, MessageBoxIcon.Information) Then
            MyDataGridViewPrinter = New DataGridViewPrinter(DgvSenderInfo, PrintDocument1, True, True, "Sender Information", New Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, True)
        Else
            MyDataGridViewPrinter = New DataGridViewPrinter(DgvSenderInfo, PrintDocument1, False, True, "Sender Information", New Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, True)
        End If

        Return True

    End Function

    Private Function SetupThePrintingBeneficiary() As Boolean

        Dim MyPrintDialog As PrintDialog = New PrintDialog()
        MyPrintDialog.AllowCurrentPage = False
        MyPrintDialog.AllowPrintToFile = False
        MyPrintDialog.AllowSelection = False
        MyPrintDialog.AllowSomePages = False
        MyPrintDialog.ShowHelp = False
        MyPrintDialog.ShowNetwork = False

        If MyPrintDialog.ShowDialog() <> DialogResult.OK Then
            Return False
        End If

        PrintDocument1.DocumentName = "BENEFICIARIES INFORMATION"

        PrintDocument1.PrinterSettings = MyPrintDialog.PrinterSettings
        PrintDocument1.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings
        PrintDocument1.DefaultPageSettings.Margins = New Margins(40, 40, 40, 40)

        If MessageBox.Show("Do you want the report to be centered on the page", "PRINT SETTINGS", MessageBoxButtons.YesNo, MessageBoxIcon.Information) Then
            MyDataGridViewPrinter = New DataGridViewPrinter(dtgBeneficiary, PrintDocument1, True, True, "Beneficiaries", New Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, True)
        Else
            MyDataGridViewPrinter = New DataGridViewPrinter(dtgBeneficiary, PrintDocument1, False, True, "Beneficiaries", New Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, True)
        End If

        Return True

    End Function


    Private Sub BtnAdminManageEmp_Click(sender As Object, e As EventArgs) Handles BtnAdminManageEmp.Click
        FormManageEmployees.Show()
    End Sub

    Private Sub BtnManageCustomers_Click(sender As Object, e As EventArgs) Handles BtnManageCustomers.Click
        FormManagedCustomers.Show()
    End Sub

    Private Sub BtnViewDBoard_Click(sender As Object, e As EventArgs) Handles BtnViewDBoard.Click
        FormDashBoard.Show()
    End Sub

    Private Sub BtnAdminTool_Click(sender As Object, e As EventArgs) Handles BtnAdminTool.Click
        AdminLogin.Show()
    End Sub
End Class