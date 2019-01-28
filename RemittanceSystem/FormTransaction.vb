Imports Oracle.ManagedDataAccess.Client
Imports Oracle.DataAccess.Client
Imports System.Drawing.Printing
Imports System.IO


Public Class FormTransaction

    Private bmp As Bitmap
    Private m_currentIndex As Integer
    Dim MyDataGridViewPrinter As DataGridViewPrinter


    Private Sub FormTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
        BtnSaveTran.Enabled = False
        BtnAdminRemitPrint.Enabled = False

        BtnAdminRemitPreview.Enabled = False
        BtnAdminNewTrans.Enabled = False
        TabPage3.Enabled = False
        BtnClaimSaveTrans.Enabled = False
        PanelSenderInfo.Enabled = False
        m_currentIndex = 0

        TxtCustName.Enabled = False
        CboIDtype.Enabled = False
        TxtMobile.Enabled = False
        TxtPurpose.Enabled = False
        TxtAddress.Enabled = False
        TxtRelationtoRec.Enabled = False
        TxtIssuePlace.Enabled = False
        TxtAmount.Enabled = False

        PbviewButtons.Hide()
        PbviewFiles.Show()

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

    'error provider

    Private Function vld(ByVal ParamArray ctl() As Object) As Boolean
        For i As Integer = 0 To UBound(ctl)
            If ctl(i).text = "" Then
                ErrorProvider1.SetError(ctl(i), ctl(i).tag)
                Return False
                Exit Function
            End If
        Next
        Return True

    End Function

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

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        PanelHome.BringToFront()
        PanelTransaction.SendToBack()
        PanelHomeTools.BringToFront()
        PanelRemitTools.SendToBack()
        TabControl1.Show()
        DgvUsers.Show()
        BtnAddUser.Show()

    End Sub
    'button transaction
    Private Sub BtnMakeTran_Click(sender As Object, e As EventArgs) Handles BtnMakeTran.Click
        PanelTransaction.BringToFront()
        PanelHome.SendToBack()
        PanelHomeTools.SendToBack()
        PanelRemitTools.BringToFront()
        TabControl1.Hide()
        BtnSaveTran.Enabled = False
        BtnStartTran.Enabled = True


    End Sub

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
    Private Sub TabPage5_Enter(sender As Object, e As EventArgs) Handles TabPage5.Enter
        BtnSaveTran.Enabled = True
        BtnAdminRemitPrint.Enabled = True
        BtnAdminRemitPreview.Enabled = True

    End Sub
    'make transaction tabcontrol receiver info / tabcontrol2 customer
    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Enter
        BtnSaveTran.Enabled = False
        BtnAdminRemitPrint.Enabled = False
        BtnAdminRemitPreview.Enabled = False
        TxtRefNo1.Enabled = False
        TxtRefNo2.Enabled = False
        TxtRefNo3.Enabled = False

    End Sub
    'make transaction tabcontrol sender info / tabcontrol 2 receiver
    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Enter
        BtnSaveTran.Enabled = False
        BtnAdminRemitPrint.Enabled = False
        TxtreceiverRefNo1.Enabled = False
        TxtReceiverRefNo2.Enabled = False
        TxtReceiverRefNo3.Enabled = False
    End Sub
    'Home tabcontrol user
    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPageEmployee.Click
        DgvUsers.Show()
        BtnAddUser.Show()

    End Sub

    Private Sub TabControl2_Selecting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles TabControl2.Selecting

        'transferring data to print receipt tab
        LblRefNo.Text = TxtRefNo1.Text & "-" & TxtRefNo2.Text & "-" & TxtRefNo3.Text
        TxtreceiverRefNo1.Text = TxtRefNo1.Text
        TxtReceiverRefNo2.Text = TxtRefNo2.Text
        TxtReceiverRefNo3.Text = TxtRefNo3.Text
        LblAdminCheckRefNo.Text = LblRefNo.Text
        'customer transfer data
        LblCustName.Text = TxtCustName.Text
        LblAdminCheckCustName.Text = TxtCustName.Text
        LblAdminCheckIDtype.Text = CboIDtype.Text
        LblAdminCheckMob.Text = TxtMobile.Text
        LblAdminCheckPurpose.Text = TxtPurpose.Text
        LblAdminCheckCustRel.Text = TxtRelationtoRec.Text
        LblAdminCheckAddress.Text = TxtAddress.Text
        LblAdminCheckIssue.Text = TxtIssueDate.Text
        LblAdminCheckIssuePlace.Text = TxtIssuePlace.Text
        LblAdminCheckExpiry.Text = TxtExpirtyDate.Text
        'LblIDType.Text = CboIDtype.Text
        'LblmobileNo.Text = TxtMobile.Text
        'LblPurpose.Text = TxtPurpose.Text
        'LblrelationToRec.Text = TxtRelationtoRec.Text
        'Lbladdress.Text = TxtAddress.Text
        LblissuePlace.Text = TxtIssuePlace.Text
        LblissueDate.Text = TxtIssueDate.Text
        LblexpiryDate.Text = TxtExpirtyDate.Text
        LabelAdminAmtInWordsReceipt.Text = AmountInWords(TxtTotalAmt.Text)

        Try
            LblAdminCheckAmountRemit.Text = FormatNumber(TxtAmount.Text, 2)
            TxtrecAmount.Text = FormatNumber(TxtrecAmount.Text, 2)
        Catch ex As Exception

        End Try

        Try
            Lblamount.Text = FormatNumber(TxtAmount.Text, 2) '& ".00 php"
            'customer data to receiver data
            TxtrecAmount.Text = FormatNumber(TxtTotalAmt.Text, 2)
        Catch ex As Exception
            MsgBox("Complete all entries")
        End Try

        Lblcharge.Text = TxtCharge.Text
        LbltotalAmount.Text = TxtTotalAmt.Text
        LblAdminCheckCharge.Text = TxtCharge.Text
        LblAdminCheckTotal.Text = TxtTotalAmt.Text

        'receiver transfer data
        'LblreceiverName.Text = TxtRecName.Text
        'LblreceiverIDtype.Text = CboRecIDtype.Text
        'LblreceiverMobileNo.Text = TxtRecMobile.Text
        'LblreceiverRelationToSender.Text = TxtRecRelationship.Text
        'LblreceiverAddress.Text = TxtRecAddress.Text
        'LblreceiverCorrespondent.Text = CboCorrespondent.Text
        'LblreceiverBranch.Text = TxtRecBranchAdd.Text
        'LblreceiverAmount.Text = TxtrecAmount.Text

        'to receipt
        LblAdminRecNameReceipt.Text = LblAdminCheckRecName.Text
        LbltotalAmount.Text = TxtrecAmount.Text
        TxtrecAmount.Text = TxtAmount.Text
        Try

            TxtrecAmount.Text = FormatNumber(TxtrecAmount.Text, 2)
        Catch ex As Exception

        End Try


        LblAdminCheckRecName.Text = TxtRecName.Text
        LblAdminCheckRecId.Text = CboRecIDtype.Text
        LblAdminCheckRecMob.Text = TxtRecMobile.Text
        LblAdminCheckRecRel.Text = TxtRecRelationship.Text
        LblAdminCheckRecAdd.Text = TxtRecAddress.Text
        LblAdminCheckCorr.Text = CboCorrespondent.Text
        LblAdminCheckBranck.Text = TxtRecBranchAdd.Text
        LblAdminCheckRecAmount.Text = TxtrecAmount.Text
        Try
            LblAdminCheckRecAmount.Text = FormatNumber(LblAdminCheckRecAmount.Text, 2)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub BtnStartTran_Click(sender As Object, e As EventArgs) Handles BtnStartTran.Click
        'randomizes character to form a reference number
        Dim pool1 As String = "0123456789"
        Dim pool2 As String = "0987654321ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
        Dim pool3 As String = "0987654321"
        Dim count = 0
        Dim count2 = 0
        Dim count3 = 0

        TxtRefNo1.Text = ""
        TxtRefNo2.Text = ""
        TxtRefNo3.Text = ""

        Dim c1 As New Random
        Dim c2 As New Random
        Dim c3 As New Random

        Dim s1 = ""
        Dim s2 = ""
        Dim s3 = ""

        While count <= 3
            s1 = c1.Next(0, pool1.Length)
            TxtRefNo1.Text = TxtRefNo1.Text & pool1(s1)
            count = count + 1
        End While

        While count2 <= 5
            s2 = c2.Next(0, pool2.Length)
            TxtRefNo2.Text = TxtRefNo2.Text & pool2(s2)
            count2 = count2 + 1
        End While

        While count3 <= 5
            s3 = c3.Next(0, pool3.Length)
            TxtRefNo3.Text = TxtRefNo3.Text & pool3(s3)
            count3 = count3 + 1
        End While

        TxtCustName.Focus()

        TxtRefNo1.Enabled = False
        TxtRefNo2.Enabled = False
        TxtRefNo3.Enabled = False
        TxtreceiverRefNo1.Enabled = False
        TxtReceiverRefNo2.Enabled = False
        TxtReceiverRefNo3.Enabled = False
        BtnStartTran.Enabled = False

        TxtIssueDate.Text = Lbldate.Text

        'add 1 month to issue date for expiry
        Dim newDate As DateTime = DateTime.Now.AddMonths(1)
        TxtExpirtyDate.Text = Format(newDate, "dd-MMM-yyyy")

        'enables all the fields of customer
        TxtCustName.Enabled = True
        CboIDtype.Enabled = True
        TxtMobile.Enabled = True
        TxtPurpose.Enabled = True
        TxtAddress.Enabled = True
        TxtRelationtoRec.Enabled = True
        TxtIssuePlace.Enabled = True
        TxtAmount.Enabled = True

        BtnSaveTran.Enabled = False
        BtnAdminRemitPrint.Enabled = False
        BtnAdminRemitPreview.Enabled = False
        BtnAdminNewTrans.Enabled = False


    End Sub

    Private Sub LinkNext1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkNext1.LinkClicked

        m_currentIndex = 1
        Dim answer As Integer

        'error provider, add all the txtbox in here and add msg in tag for each txtboxes
        If vld(TxtCustName, CboIDtype, TxtMobile, TxtPurpose, TxtRelationtoRec,
                       TxtAddress, TxtIssuePlace, TxtAmount) = False Then
            Exit Sub
        End If

        If m_currentIndex >= 0 AndAlso m_currentIndex < TabControl2.TabCount Then

            answer = MessageBox.Show("Check all fields.  You will not be able to alter data after proceeding to next page" _
                                     , "SECURE ALL ENTRY", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If answer = DialogResult.OK Then
                TabControl2.SelectedIndex = m_currentIndex
                TabPage3.Enabled = True
                TxtRecName.Focus()
                TxtAmount.Enabled = False

            End If
        End If


    End Sub

    Private Sub LinkNext2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkNext2.LinkClicked
        m_currentIndex = 2
        Dim answer2 As Integer

        'error provider, add all the txtbox in here and add msg in tag for each txtboxes
        If vld(TxtRecName, CboRecIDtype, TxtRecRelationship, TxtRecMobile, TxtRecAddress, CboCorrespondent, TxtRecBranchAdd) = False Then
            Exit Sub
        End If

        If m_currentIndex >= 0 AndAlso m_currentIndex < TabControl2.TabCount Then

            answer2 = MessageBox.Show("Check all fields.  You will not be able to alter data after proceeding to next page" _
                                     , "SECURE ALL ENTRY", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If answer2 = DialogResult.OK Then
                TabControl2.SelectedIndex = m_currentIndex
                BtnSaveTran.Enabled = True
            End If

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Lbldate.Text = Format(Now, "dd-MMM-yyyy")
        LabelDate.Text = Format(Now, "dddd, dd-MMM-yyyy hh:mm:ss tt")
        'Lbltime.TabIndex = Format(Now, "hh:mm:ss tt")
    End Sub

    Private Sub Txtchange_TextChanged(sender As Object, e As EventArgs) Handles Txtchange.TextChanged
        If Val(Txtchange.Text) < 0 Then
            MessageBox.Show("Cash tendered is insufficient", "ERROR TRANSACTION", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If DialogResult.OK Then

                TxtAmount.Clear()
                Txtchange.Clear()
                Txtchange.Clear()
                TxtAmount.Focus()

            End If
        ElseIf Val(Txtchange.Text) = 0 Then


        End If
    End Sub

    Private Sub TxtAmount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtAmount.Leave
        'check the error, "" string is not accepted because it is in the formatnumber
        'that is why it is needed to be catched
        Dim chg, MyAmt As Double


        chg = 0.1

        Try

            If Val(TxtAmount.Text) <= 499 Then

                    MessageBox.Show("500.00PHP is the minimum amount for this transaction", "INVALID AMOUNT", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If DialogResult.OK Then
                    TxtCashTendered.Clear()
                    TxtCashTendered.Focus()
                    TxtAmount.Clear()
                    TxtCharge.Text = FormatNumber(0, 2)
                    Txtchange.Text = FormatNumber(0, 2)
                End If

            ElseIf Val(TxtAmount.Text) = 500 Then
                TxtCharge.Text = FormatNumber(50, 2)

            ElseIf Val(TxtAmount.Text) >= 501 And Val(TxtAmount.Text) <= 1000 Then
                TxtCharge.Text = FormatNumber(75, 2)

            ElseIf Val(TxtAmount.Text) >= 1001 And Val(TxtAmount.Text) <= 2000 Then
                TxtCharge.Text = FormatNumber(150, 2)

            ElseIf Val(TxtAmount.Text) >= 2001 And Val(TxtAmount.Text) <= 3000 Then
                TxtCharge.Text = FormatNumber(250, 2)

            ElseIf Val(TxtAmount.Text) >= 3001 And Val(TxtAmount.Text) <= 4000 Then
                TxtCharge.Text = FormatNumber(350, 2)

            ElseIf Val(TxtAmount.Text) >= 4001 And Val(TxtAmount.Text) <= 5000 Then
                TxtCharge.Text = FormatNumber(450, 2)

            ElseIf Val(TxtAmount.Text) >= 5001 Then
                MyAmt = FormatNumber(TxtAmount.Text, 2) * chg
                TxtCharge.Text = FormatNumber(MyAmt, 2)


            End If

            Txtholder.Text = Val(TxtAmount.Text) + (TxtCharge.Text)


            Txtchange.Text = Val(TxtCashTendered.Text) - Val(Txtholder.Text)
            Txtchange.Text = FormatNumber(Txtchange.Text, 2)
            TxtTotalAmt.Text = Val(TxtAmount.Text) + (TxtCharge.Text)
            'TxtTotalAmt.Text = TxtAmount.Text - TxtCharge.Text
            TxtTotalAmt.Text = FormatNumber(TxtTotalAmt.Text, 2)


        Catch ex As Exception
            MessageBox.Show("Please enter an amount", "AMOUNT TO BE REMITTED", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If DialogResult.OK Then
                TxtCashTendered.Focus()

            End If
        End Try
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

    Private Sub TxtCustName_Leave(sender As Object, e As EventArgs) Handles TxtCustName.Leave

        If (TxtCustName.Text <> "") Then

            Dim userInput As String = TxtCustName.Text

            If Not (ValidString(userInput) = True) Then
                TxtCustName.Clear()
                TxtCustName.Focus()
                MessageBox.Show("Invalid character, letters only", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub TxtPurpose_Leave(sender As Object, e As EventArgs) Handles TxtPurpose.Leave

        If (TxtPurpose.Text <> "") Then

            Dim userInput As String = TxtCustName.Text

            If Not (ValidString(userInput) = True) Then
                TxtPurpose.Clear()
                TxtPurpose.Focus()
                MessageBox.Show("Invalid character, letters only", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub


    Private Sub TxtRelationtoRec_Leave(sender As Object, e As EventArgs) Handles TxtRelationtoRec.Leave

        If (TxtRelationtoRec.Text <> "") Then

            Dim userInput As String = TxtRelationtoRec.Text

            If Not (ValidString(userInput) = True) Then
                TxtRelationtoRec.Clear()
                TxtRelationtoRec.Focus()
                MessageBox.Show("Invalid character, letters only", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub TxtIssuePlace_Leave(sender As Object, e As EventArgs) Handles TxtIssuePlace.Leave

        If (TxtIssuePlace.Text <> "") Then

            Dim userInput As String = TxtIssuePlace.Text

            If Not (ValidString(userInput) = True) Then
                TxtIssuePlace.Clear()
                TxtIssuePlace.Focus()
                MessageBox.Show("Invalid character, letters only", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub TxtCashTendered_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCashTendered.KeyPress

        'sender mobile number
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MessageBox.Show("Numbers only", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                TxtCashTendered.Text = ""
                TxtCashTendered.Focus()
            End If
        End If

    End Sub

    Private Sub TxtAmount_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAmount.KeyPress

        'sender mobile number
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MessageBox.Show("Numbers only", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                TxtAmount.Text = ""
                TxtAmount.Focus()
            End If
        End If

    End Sub

    Private Sub TxtMobile_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMobile.KeyPress
        'sender mobile number
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MessageBox.Show("Numbers only", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                TxtMobile.Text = ""
                TxtMobile.Focus()
            End If
        End If

    End Sub

    Private Sub TxtRecMobile_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtRecMobile.KeyPress, TxtRecMobile.KeyPress
        'receiver mobile number
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MessageBox.Show("Numbers only", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                TxtMobile.Text = ""
                TxtMobile.Focus()
            End If
        End If

    End Sub

    Private Sub TxtRecName_Leave(sender As Object, e As EventArgs) Handles TxtRecName.Leave

        If (TxtRecName.Text <> "") Then

            Dim userInput As String = TxtRecName.Text

            If Not (ValidString(userInput) = True) Then
                TxtRecName.Clear()
                TxtRecName.Focus()
                MessageBox.Show("Invalid character, letters only", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub TxtRecRelationship_Leave(sender As Object, e As EventArgs) Handles TxtRecRelationship.Leave
        If (TxtRecRelationship.Text <> "") Then

            Dim userInput As String = TxtRecRelationship.Text

            If Not (ValidString(userInput) = True) Then
                TxtRecRelationship.Clear()
                TxtRecRelationship.Focus()
                MessageBox.Show("Invalid character, letters only", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub BtnSaveTran_Click(sender As Object, e As EventArgs) Handles BtnSaveTran.Click

        m_currentIndex = 3
        Dim answer2 As Integer

        If m_currentIndex >= 0 AndAlso m_currentIndex < TabControl2.TabCount Then

            answer2 = MessageBox.Show("Check all fields.  You will not be able to alter data after proceeding to next page" _
                                     , "SECURE ALL ENTRY", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If answer2 = DialogResult.OK Then
                InsertTransaction()
                InsertBeneficiaries()
                InsertStatus()

                BtnAdminRemitPrint.Enabled = True
                BtnAdminRemitPreview.Enabled = True
                BtnAdminNewTrans.Enabled = True
                BtnCancelRemitAdmin.Enabled = False
                MessageBox.Show("Transaction successful", "TRANSACTION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TabControl2.SelectedIndex = m_currentIndex
                BtnSaveTran.Enabled = True
            ElseIf answer2 = DialogResult.Cancel Then
                TabControl2.SelectedIndex = 2
                BtnCancelRemitAdmin.Enabled = True
            End If

        End If

        'notifies the user if saved already at the bottom of the form
        ToolStripProgressBar1.Visible = True

        For i As Integer = 0 To ToolStripProgressBar1.Maximum - 1
            ToolStripProgressBar1.Value = ToolStripProgressBar1.Value + 1
            ToolStripStatusLabel1.Visible = True
        Next

    End Sub

    Public Sub InsertTransaction()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
         + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
         + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
         + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()
        Dim transaction As Oracle.DataAccess.Client.OracleTransaction
        'Dim cmd As OracleCommand = conn.CreateCommand()
        conn.ConnectionString = OraDB

        conn.Open()

        Try
            Using cmd As Oracle.DataAccess.Client.OracleCommand = New Oracle.DataAccess.Client.OracleCommand(OraDB, conn)
                transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
                cmd.Transaction = transaction
                Const sqlCustomer As String = "INSERT INTO REM_CUSTOMER VALUES (:var1, :var2, :var3, :var4, :var5, :var6, :var7, :var8, :var9, :var10, :var11, :var12, :var13)"

                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var1", LblRefNo.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var2", LblAdminCheckCustName.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var3", LblAdminCheckIDtype.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var4", LblAdminCheckMob.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var5", LblAdminCheckPurpose.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var6", LblAdminCheckCustRel.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var7", LblAdminCheckAddress.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var8", LblAdminCheckIssue.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var9", LblAdminCheckIssuePlace.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var10", LblAdminCheckExpiry.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var11", LblAdminCheckAmountRemit.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var12", LblAdminCheckCharge.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var13", LblAdminCheckTotal.Text))
                cmd.CommandText = sqlCustomer
                cmd.ExecuteNonQuery()
                transaction.Commit()

                cmd.Dispose()
                conn.Close()




            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub InsertBeneficiaries()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
        + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
        + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
        + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()
        Dim transaction As Oracle.DataAccess.Client.OracleTransaction
        'Dim cmd As OracleCommand = conn.CreateCommand()
        conn.ConnectionString = OraDB

        conn.Open()

        Try
            Using cmd As Oracle.DataAccess.Client.OracleCommand = New Oracle.DataAccess.Client.OracleCommand(OraDB, conn)
                transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
                cmd.Transaction = transaction
                Const sqlReceiver As String = "INSERT INTO REM_BENEFICIARIES VALUES (:var1, :var2, :var3, :var4, :var5, :var6, :var7, :var8, :var9)"


                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var1", LblRefNo.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var2", LblAdminCheckRecName.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var3", LblAdminCheckRecId.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var4", LblAdminCheckRecMob.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var5", LblAdminCheckRecAdd.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var6", LblAdminCheckRecRel.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var7", LblAdminCheckCorr.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var8", LblAdminCheckBranck.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var9", LblAdminCheckRecAmount.Text))

                cmd.CommandText = sqlReceiver
                cmd.ExecuteNonQuery()
                transaction.Commit()

                cmd.Dispose()
                conn.Close()

            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub InsertStatus()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
        + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
        + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
        + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()
        Dim transaction As Oracle.DataAccess.Client.OracleTransaction
        'Dim cmd As OracleCommand = conn.CreateCommand()
        conn.ConnectionString = OraDB

        conn.Open()

        Try
            Using cmd As Oracle.DataAccess.Client.OracleCommand = New Oracle.DataAccess.Client.OracleCommand(OraDB, conn)
                transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
                cmd.Transaction = transaction

                Const sqlStatus As String = "INSERT INTO REM_STATUS VALUES (:var1, :var2, :var3, :var4, :var5, :var6)"

                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var1", LblRefNo.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var2", LblEmpID.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var3", LblissueDate.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var4", LblexpiryDate.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var5", ("NOT CLAIMED")))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var6", LblAdminCheckRecAmount.Text))
                cmd.CommandText = sqlStatus

                cmd.ExecuteNonQuery()
                transaction.Commit()

                cmd.Dispose()
                conn.Close()

            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

        If TxtClaimRefNo.Text = "" Then

            MessageBox.Show("You cannot search without reference number.", "ERROR SEARCHING INFO", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            If TxtClaimStatus.Text = "EXPIRED" Then
                MessageBox.Show("This transaction is already expired.", "EXPIRED TRANSACTION", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BtnClaimSaveTrans.Enabled = False
                BtnClaimChangeStat.Enabled = False

            Else
                SearchClaimStatus()
                SearchClaimantInfo()
                BtnClaimSaveTrans.Enabled = True
                BtnClaimChangeStat.Enabled = True
                TxtClaimRefNo.Enabled = False

            End If

        End If

    End Sub

    'searching claim record
    Public Sub SearchClaimStatus()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
       + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
       + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
       + "User Id=SYSTEM;Password=SYSTEM;"

        Dim dr As Oracle.DataAccess.Client.OracleDataReader
        Dim strRetrieve As String
        strRetrieve = "SELECT * FROM REM_STATUS WHERE (REFERENCE_NUMBER = '" & TxtClaimRefNo.Text & "')"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()

        conn.ConnectionString = OraDB

        Dim cmd As Oracle.DataAccess.Client.OracleCommand = New Oracle.DataAccess.Client.OracleCommand(strRetrieve, conn)

        conn.Open()

        dr = cmd.ExecuteReader

        Try

            While dr.Read

                TxtDateIssueClaim.Text = dr("ISSUE_DATE").ToString
                TxtClaimExpiryDate.Text = dr("EXPIRY_DATE").ToString
                TxtClaimStatus.Text = dr("STATUS").ToString

            End While

            TxtDateIssueClaim.Text = Format(CDate(TxtDateIssueClaim.Text), "dd-MMM-yyyy")
            TxtClaimExpiryDate.Text = Format(CDate(TxtClaimExpiryDate.Text), "dd-MMM-yyyy")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    'search claimant info
    Public Sub SearchClaimantInfo()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
      + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
      + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
      + "User Id=SYSTEM;Password=SYSTEM;"

        Dim dr As Oracle.DataAccess.Client.OracleDataReader
        Dim strClaim As String
        strClaim = "SELECT * FROM REM_BENEFICIARIES WHERE (REFERENCE_NUMBER = '" & TxtClaimRefNo.Text & "')"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()

        conn.ConnectionString = OraDB

        Dim cmd As Oracle.DataAccess.Client.OracleCommand = New Oracle.DataAccess.Client.OracleCommand(strClaim, conn)

        conn.Open()

        dr = cmd.ExecuteReader

        Try

            While dr.Read

                TxtClaimName.Text = dr("NAME").ToString
                TxtClaimIDtype.Text = dr("ID_TYPE").ToString
                TxtClaimMobile.Text = dr("MOBILE_NUMBER").ToString
                TxtClaimAddress.Text = dr("ADDRESS").ToString
                TxtClaimRelationship.Text = dr("RELATIONSHIP_TO_THE_SENDER").ToString
                TxtClaimCorrespondent.Text = dr("CORRESPONDENT").ToString
                TxtClaimBranch.Text = dr("BRANCH_ADDRESS").ToString
                TxtClaimAmount.Text = dr("AMOUNT_RECEIVED").ToString


            End While

            'TxtClaimAmount.Text = Format(C(TxtDateIssueClaim.Text), "dd-MMM-yyyy")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnClaimTrans_Click(sender As Object, e As EventArgs) Handles BtnClaimTrans.Click
        PanelClaimTransaction.BringToFront()
        BtnClaimChangeStat.Enabled = False
        BtnAdminClaimPrint.Enabled = False
        BtnAdminClaimPreview.Enabled = False
        PanelRemitTools.SendToBack()
        PanelHome.SendToBack()
        Panel2.BringToFront()


    End Sub

    Private Sub PbLeft_Click_1(sender As Object, e As EventArgs) Handles PbLeft.Click
        PbRight.BringToFront()

        PbviewFiles.Show()
        PbviewButtons.Hide()

        PanelControlContainer.BringToFront()
        PanelAdminFileExplorer.SendToBack()
    End Sub

    Private Sub PbRight_Click_1(sender As Object, e As EventArgs) Handles PbRight.Click
        PbLeft.BringToFront()

        PbviewFiles.Hide()
        PbviewButtons.Show()

        PanelControlContainer.SendToBack()
        PanelAdminFileExplorer.BringToFront()
    End Sub

    Private Sub BtnClaimStartTrans_Click(sender As Object, e As EventArgs) Handles BtnClaimStartTrans.Click
        TxtClaimRefNo.Enabled = True
        'BtnClaimSaveTrans.Enabled = True

        TabControl3.SelectedIndex = 0
        TxtClaimRefNo.Clear()
        TxtClaimName.Clear()
        TxtClaimIDtype.Clear()
        TxtClaimRelationship.Clear()
        TxtClaimMobile.Clear()
        TxtClaimAddress.Clear()
        TxtClaimCorrespondent.Clear()
        TxtClaimAmount.Clear()
        TxtClaimBranch.Clear()
        TxtDateIssueClaim.Clear()
        TxtClaimExpiryDate.Clear()
        TxtClaimStatus.Clear()

        BtnClaimCancel.Enabled = True
    End Sub

    Private Sub BtnClaimChangeStat_Click(sender As Object, e As EventArgs) Handles BtnClaimChangeStat.Click
        TxtClaimStatus.Text = "CLAIMED"
        BtnClaimChangeStat.Enabled = False
    End Sub

    Private Sub BtnClaimSaveTrans_Click(sender As Object, e As EventArgs) Handles BtnClaimSaveTrans.Click

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
     + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
     + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
     + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()
        conn.ConnectionString = OraDB

        conn.Open()
        Dim strChangeStat As String
        strChangeStat = "UPDATE REM_STATUS SET STATUS = '" & TxtClaimStatus.Text & "' WHERE REFERENCE_NUMBER = '" & TxtClaimRefNo.Text & "'"
        Dim cmd As Oracle.DataAccess.Client.OracleCommand = New Oracle.DataAccess.Client.OracleCommand(strChangeStat, conn)

        cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("STATUS", TxtClaimStatus.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        BtnAdminClaimPrint.Enabled = True
        BtnAdminClaimPreview.Enabled = True

        BtnClaimCancel.Enabled = False

        'will go to next tab, the receipt

        m_currentIndex = 1

        If TxtClaimStatus.Text = "NOT CLAIMED" Then

            MessageBox.Show("You cannot proceed without changing the status. Select change status.", "CLAIMED STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If DialogResult.OK Then
                BtnClaimSaveTrans.Enabled = True
            Else
                BtnClaimSaveTrans.Enabled = False
            End If
        ElseIf TxtClaimStatus.Text = "" Then
            MessageBox.Show("No transaction has been made yet.", "CLAIMED STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf m_currentIndex >= 0 AndAlso m_currentIndex < TabControl3.TabCount Then
            TabControl3.SelectedIndex = m_currentIndex
            BtnClaimSaveTrans.Enabled = False
        End If


    End Sub

    Private Sub TabControl3_Selecting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles TabControl3.Selecting

        'data transfer from claim transaction to receipt
        LabelcRefNo.Text = TxtClaimRefNo.Text
        LabelcName.Text = TxtClaimName.Text
        LblAdminClaimAmtInWords.Text = AmountInWords(TxtClaimAmount.Text)
        LabelcMobileNo.Text = TxtClaimMobile.Text
        LabelcAddress.Text = TxtClaimAddress.Text
        LabelcCorrespondent.Text = TxtClaimCorrespondent.Text
        LabelcBranch.Text = TxtClaimBranch.Text
        LabelcAmount.Text = TxtClaimAmount.Text
        LabelcStatus.Text = TxtClaimStatus.Text


    End Sub


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

    Private Sub TxtAddress_keyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAddress.KeyPress
        If TxtAddress.Text.Length = 100 Then
            MessageBox.Show("You have already reached the maximum length for address", "INVALID ADDRESS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtAddress.Clear()
        End If
    End Sub

    Private Sub TxtRecAddress_TextChanged(sender As Object, e As EventArgs) Handles TxtRecAddress.TextChanged
        If TxtRecAddress.Text.Length = 100 Then
            MessageBox.Show("You have already reached the maximum length for address", "INVALID ADDRESS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtAddress.Clear()
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

    Public Function AmountInWords(ByVal nAmount As String, Optional ByVal wAmount As String = vbNullString, Optional ByVal nSet As Object = Nothing) As String
        'Let's make sure entered value is numeric
        If Not IsNumeric(nAmount) Then Return "Please enter numeric values only."

        Dim tempDecValue As String = String.Empty : If InStr(nAmount, ".") Then tempDecValue = nAmount.Substring(nAmount.IndexOf("."))

        'Removing the decimal value from nAmount
        nAmount = Replace(nAmount, tempDecValue, String.Empty)

        Try

            Dim intAmount As Long = nAmount

            'Let's trap the values entered into the recursion; if greater than 0 then let's evaluate the numbers in set, otherwise, 
            '(1) all numbers have already been evaluated and return the designated word values (for entered whole numbers); or
            '(2) evaluate last set, which is the decimal value
            'either which proceed to else statement and/or return the result
            If intAmount > 0 Then
                'Let's segregate the entered values into 3-digit sets of numbers and count it then store in the nSet
                'For example: 9223372036854775807 has 7 sets; start from right to left (807, 775, 854, 036...), until the last set which is 9 
                nSet = IIf((intAmount.ToString.Trim.Length / 3) > (CLng(intAmount.ToString.Trim.Length / 3)), CLng(intAmount.ToString.Trim.Length / 3) + 1, CLng(intAmount.ToString.Trim.Length / 3))

                'eAmount gets each 3-digit set entered into the recursion
                'Though I said sets start from right to left, we start evaluating each set from left to right of the entered values.
                'For example: 9223372036854775807 (actual: 9,223,372,036,854,775,807), 9 (1st set to be evaluated), 223 (next set), 372 (next set),... and so on
                'and so forth until all are evaluated, including the decimal values, in case there exists
                'NOTE: 9 is in Quintillion range, 223 is in Quadrillion, 372 in Trillion, and so on and so forth
                Dim eAmount As Long = Microsoft.VisualBasic.Left(intAmount.ToString.Trim, (intAmount.ToString.Trim.Length - ((nSet - 1) * 3)))

                'Multiplier gets the 10 to the power of the nSet
                'This is needed to remove the evaluated set from the original values
                'For example: 1st set is 9 (the 1st value of eAmount) and there are 7 sets so:
                '10 ^ (((7 - 1) * 3)) is 1000000000000000000
                '9 multiplied by 1000000000000000000 is 9000000000000000000
                'remove 9000000000000000000 from 9223372036854775807 which results in 223372036854775807, the next value of nAmount within which the decimal value .75 shall be attached
                'the flow goes on and on until nAmount reaches zero, or the decimal value
                'so multiplier has a vital function as we go on and we shall see later
                Dim multiplier As Long = 10 ^ (((nSet - 1) * 3))

                'These are the worded values
                Dim Ones() As String = {"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"}
                Dim Teens() As String = {"", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                Dim Tens() As String = {"", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"}
                Dim HMBT() As String = {"", "", "Thousand", "Million", "Billion", "Trillion", "Quadrillion", "Quintillion"}

                'Let's reuse the intAmount object
                intAmount = eAmount

                'Remember, we have a 3-digit number in each set
                'from left to right is hundreds, tens, and ones
                'For example 9 is the ones in the first set for evaluation; the next set is 223 (1st 2 is hundreds, next 2 is tens, and 3 is ones)
                'These statements segregate the numbers in the set
                Dim nHundred As Integer = intAmount \ 100 : intAmount = intAmount Mod 100
                Dim nTen As Integer = intAmount \ 10 : intAmount = intAmount Mod 10
                Dim nOne As Integer = intAmount \ 1

                'After the segregation, we now have to evaluate the retrieved numbers and put the corresponding words for each number                
                If nHundred > 0 Then wAmount = wAmount & Ones(nHundred) & " Hundred " 'This is for hundreds                
                If nTen > 0 Then 'This is for tens and teens
                    'In case of teens, like 11 to 19, it will be trapped in here and proceed to the designated word                    
                    If nTen = 1 And nOne > 0 Then 'This is for teens (number ten plus ones succeeding it) Example:
                        wAmount = wAmount & Teens(nOne) & " " '11 is Eleven, 12 is Twelve, 15 is Fifteen, 17 is Seventeen, and so on
                    Else 'This is for tens, 10 to 90
                        wAmount = wAmount & Tens(nTen) & IIf(nOne > 0, "-", " ") 'If there is ones succeeding it, put a dash before the ones, example: Twenty-, Thirty-, Forty-, etc.
                        If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " " 'This is for ones (1-9) with the tens (20-90) preceeding it. Example: 21 is Twenty-One, 34 is Thirty-Four, 48 is Forty-Eight
                    End If
                Else 'This is for ones, 1 to 9
                    If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                End If
                'Let's put in here the ranges (1st set(number 9) is Quintillion, next(number 223) is Quadrillion, next(372) is Trillion, ...so on and so forth)
                wAmount = wAmount & HMBT(nSet) & " "
                'Proceed to next set to evaluate by entering the same function we are in (recursion)
                wAmount = AmountInWords(CStr(CLng(nAmount) - (eAmount * multiplier)).Trim & tempDecValue, wAmount, nSet - 1)
            Else 'When nAmount reaches 0, we proceed to this statement
                'If there is no decimal value then proceed to display the result
                'But if there is a decimal value then let's evaluate each number of the decimal value
                'First we re-attach the decimal value to its original value, the nAmount
                If Val(nAmount) = 0 Then nAmount = nAmount & tempDecValue : tempDecValue = String.Empty
                'Now, if we have decimal value, let's convert it into whole numbers (not rounding it off, but actually converting to whole numbers), 
                'put it into the recursion for the last time, evaluate it, give the corresponding words and then finally, display the result
                If (Math.Round(Val(nAmount), 2) * 100) > 0 Then wAmount = Trim(AmountInWords(CStr(Math.Round(Val(nAmount), 2) * 100), wAmount.Trim & " Pesos And ", 1)) & " Cents Only"
            End If
        Catch ex As Exception
            'Should there be any error encountered, this will handle it.
            MessageBox.Show("Error Encountered: " & ex.Message, "Convert Numbers To Words", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "!#ERROR_ENCOUNTERED"
        End Try

        'Trap null values
        If IsNothing(wAmount) = True Then wAmount = String.Empty Else wAmount = IIf(InStr(wAmount.Trim.ToLower, " pesos "), wAmount.Trim, wAmount.Trim & " Pesos ")

        'Display the result
        Return wAmount
    End Function

    'printing and preview buttons
    Private Sub BtnAdminClaimPrint_Click(sender As Object, e As EventArgs) Handles BtnAdminClaimPrint.Click

        Dim dlgSettings As New PrintDialog()
        dlgSettings.Document = PrintDocumentAdminClaim

        If dlgSettings.ShowDialog() = DialogResult.OK Then
            PanelAdminClaimReceipt.VerticalScroll.Value = 0
            PrintDocumentAdminClaim.DefaultPageSettings.PaperSize = New PaperSize("Custom", 850, 1100)
            PrintDocumentAdminClaim.Print()
        End If

    End Sub

    Private Sub BtnAdminClaimPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdminClaimPreview.Click

        bmp = New Bitmap(PanelAdminClaimReceipt.Width, PanelAdminClaimReceipt.Height)
        Dim G As Graphics = Graphics.FromImage(bmp)
        PanelAdminClaimReceipt.DrawToBitmap(bmp, PanelAdminClaimReceipt.ClientRectangle)
        G.Dispose()

        PrintPreviewDialogAdminClaim.Document = PrintDocumentAdminClaim

        PrintPreviewDialogAdminClaim.ShowDialog()

    End Sub


    'function for printing the receipt of teller sender
    Private Sub PrintDocumentAdminClaim_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocumentAdminClaim.PrintPage

        Static page As Integer = 1
        Dim startPosition As Integer = (page - 1) * PrintDocumentAdminClaim.DefaultPageSettings.Bounds.Height - 50
        Static maxPages As Integer = 0

        If page = 1 Then

            For Each ctrl As Control In PanelAdminClaimReceipt.Controls
                If TypeOf ctrl Is TextBox Or TypeOf ctrl Is Label Or TypeOf ctrl Is PictureBox Then
                    ctrl.Tag = Int((ctrl.Top + ctrl.Height) / PrintDocumentAdminClaim.DefaultPageSettings.Bounds.Height) + 1
                    If CInt(ctrl.Tag) > maxPages Then
                        maxPages = CInt(ctrl.Tag)

                    End If
                End If

            Next

        End If

        For Each ctrl As Control In PanelAdminClaimReceipt.Controls
            If CInt(ctrl.Tag) = page Then
                If TypeOf ctrl Is TextBox Or TypeOf ctrl Is Label Then
                    Dim sf As New System.Drawing.StringFormat
                    If TypeOf ctrl Is TextBox Then
                        If DirectCast(ctrl, TextBox).TextAlign = HorizontalAlignment.Center Then
                            sf.Alignment = StringAlignment.Center
                        Else
                            sf.Alignment = StringAlignment.Center
                        End If
                    ElseIf TypeOf ctrl Is Label Then
                        If DirectCast(ctrl, Label).TextAlign = ContentAlignment.MiddleRight Then
                            sf.Alignment = StringAlignment.Center
                        ElseIf DirectCast(ctrl, Label).TextAlign = ContentAlignment.MiddleRight Then
                            sf.Alignment = StringAlignment.Center
                        End If
                    End If
                    sf.FormatFlags = StringFormatFlags.NoClip
                    e.Graphics.DrawString(ctrl.Text, ctrl.Font, New SolidBrush(ctrl.ForeColor), New RectangleF(ctrl.Left + 5, ctrl.Top - startPosition, ctrl.Width, ctrl.Height), sf)
                ElseIf TypeOf ctrl Is PictureBox Then
                    e.Graphics.DrawImage(DirectCast(ctrl, PictureBox).Image, New PointF(ctrl.Left, ctrl.Top - startPosition))

                End If
            End If
        Next

        page += 1
        If page > maxPages Then
            e.HasMorePages = False
            page = 1
            maxPages = 0
        Else
            e.HasMorePages = True
        End If

    End Sub

    'print and preview buttons for remittance

    Private Sub BtnAdminRemitPrint_Click(sender As Object, e As EventArgs) Handles BtnAdminRemitPrint.Click

        Dim dlgSettings As New PrintDialog()
        dlgSettings.Document = PrintDocumentAdminRemitReceipt

        If dlgSettings.ShowDialog() = DialogResult.OK Then
            PanelAdminRemitPrintReceipt.VerticalScroll.Value = 0
            PrintDocumentAdminRemitReceipt.DefaultPageSettings.PaperSize = New PaperSize("Custom", 850, 1100)
            PrintDocumentAdminRemitReceipt.Print()
        End If

    End Sub

    Private Sub BtnAdminRemitPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdminRemitPreview.Click

        bmp = New Bitmap(PanelAdminRemitPrintReceipt.Width, PanelAdminRemitPrintReceipt.Height)
        Dim G As Graphics = Graphics.FromImage(bmp)
        PanelAdminClaimReceipt.DrawToBitmap(bmp, PanelAdminRemitPrintReceipt.ClientRectangle)
        G.Dispose()

        PrintPreviewDialogAdminRemit.Document = PrintDocumentAdminRemitReceipt

        PrintPreviewDialogAdminRemit.ShowDialog()

    End Sub

    Private Sub PrintDocumentAdminRemitReceipt_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocumentAdminRemitReceipt.PrintPage
        'PanelAdminRemitPrintReceipt

        Static page As Integer = 1
        Dim startPosition As Integer = (page - 1) * PrintDocumentAdminRemitReceipt.DefaultPageSettings.Bounds.Height - 50
        Static maxPages As Integer = 0

        If page = 1 Then

            For Each ctrl As Control In PanelAdminRemitPrintReceipt.Controls
                If TypeOf ctrl Is TextBox Or TypeOf ctrl Is Label Or TypeOf ctrl Is PictureBox Then
                    ctrl.Tag = Int((ctrl.Top + ctrl.Height) / PrintDocumentAdminRemitReceipt.DefaultPageSettings.Bounds.Height) + 1
                    If CInt(ctrl.Tag) > maxPages Then
                        maxPages = CInt(ctrl.Tag)

                    End If
                End If

            Next

        End If

        For Each ctrl As Control In PanelAdminRemitPrintReceipt.Controls
            If CInt(ctrl.Tag) = page Then
                If TypeOf ctrl Is TextBox Or TypeOf ctrl Is Label Then
                    Dim sf As New System.Drawing.StringFormat
                    If TypeOf ctrl Is TextBox Then
                        If DirectCast(ctrl, TextBox).TextAlign = HorizontalAlignment.Center Then
                            sf.Alignment = StringAlignment.Center
                        Else
                            sf.Alignment = StringAlignment.Center
                        End If
                    ElseIf TypeOf ctrl Is Label Then
                        If DirectCast(ctrl, Label).TextAlign = ContentAlignment.MiddleRight Then
                            sf.Alignment = StringAlignment.Center
                        ElseIf DirectCast(ctrl, Label).TextAlign = ContentAlignment.MiddleRight Then
                            sf.Alignment = StringAlignment.Center
                        End If
                    End If
                    sf.FormatFlags = StringFormatFlags.NoClip
                    e.Graphics.DrawString(ctrl.Text, ctrl.Font, New SolidBrush(ctrl.ForeColor), New RectangleF(ctrl.Left + 5, ctrl.Top - startPosition, ctrl.Width, ctrl.Height), sf)
                ElseIf TypeOf ctrl Is PictureBox Then
                    e.Graphics.DrawImage(DirectCast(ctrl, PictureBox).Image, New PointF(ctrl.Left, ctrl.Top - startPosition))

                End If
            End If
        Next

        page += 1
        If page > maxPages Then
            e.HasMorePages = False
            page = 1
            maxPages = 0
        Else
            e.HasMorePages = True
        End If

    End Sub

    Private Sub BtnCancelRemitAdmin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCancelRemitAdmin.Click


        MessageBox.Show("Are you sure to cancel transaction?", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If DialogResult.OK Then
            PanelHomeTools.BringToFront()
            PanelHome.BringToFront()
            TabControl1.Show()
            PanelClaimTransaction.SendToBack()
            Panel2.SendToBack()
            PanelTransaction.SendToBack()
            PanelRemitTools.SendToBack()

            TxtRefNo1.Clear()
            TxtRefNo2.Clear()
            TxtRefNo3.Clear()
            TxtCustName.Clear()
            TxtMobile.Clear()
            TxtPurpose.Clear()
            TxtRelationtoRec.Clear()
            TxtAddress.Clear()
            TxtIssueDate.Clear()
            TxtIssuePlace.Clear()
            TxtExpirtyDate.Clear()
            TxtAmount.Clear()
            TxtCharge.Clear()
            TxtCashTendered.Clear()
            Txtchange.Clear()
            TxtTotalAmt.Clear()
            TxtreceiverRefNo1.Clear()
            TxtReceiverRefNo2.Clear()
            TxtReceiverRefNo3.Clear()
            TxtRecName.Clear()
            TxtRecMobile.Clear()
            TxtRecAddress.Clear()
            TxtRecRelationship.Clear()
            TxtrecAmount.Clear()
            TxtRecBranchAdd.Clear()

        End If




    End Sub

    Private Sub BtnAdminNewTrans_Click(sender As Object, e As EventArgs) Handles BtnAdminNewTrans.Click
        TabControl2.SelectedIndex = 0
        BtnStartTran.Enabled = True

        TxtRefNo1.Clear()
        TxtRefNo2.Clear()
        TxtRefNo3.Clear()
        TxtCustName.Clear()
        TxtMobile.Clear()
        TxtPurpose.Clear()
        TxtRelationtoRec.Clear()
        TxtAddress.Clear()
        TxtIssueDate.Clear()
        TxtIssuePlace.Clear()
        TxtExpirtyDate.Clear()
        TxtAmount.Clear()
        TxtCharge.Clear()
        TxtCashTendered.Clear()
        Txtchange.Clear()
        TxtTotalAmt.Clear()
        TxtreceiverRefNo1.Clear()
        TxtReceiverRefNo2.Clear()
        TxtReceiverRefNo3.Clear()
        TxtRecName.Clear()
        TxtRecMobile.Clear()
        TxtRecAddress.Clear()
        TxtRecRelationship.Clear()
        TxtrecAmount.Clear()
        TxtRecBranchAdd.Clear()
    End Sub

    Private Sub BtnClaimCancel_Click(sender As Object, e As EventArgs) Handles BtnClaimCancel.Click
        MessageBox.Show("Are you sure to cancel this transaction?", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
        PanelHome.BringToFront()
        PanelHomeTools.BringToFront()

        TxtClaimRefNo.Clear()
        TxtClaimName.Clear()
        TxtClaimIDtype.Clear()
        TxtClaimRelationship.Clear()
        TxtClaimMobile.Clear()
        TxtClaimAddress.Clear()
        TxtClaimCorrespondent.Clear()
        TxtClaimAmount.Clear()
        TxtClaimBranch.Clear()
        TxtDateIssueClaim.Clear()
        TxtClaimExpiryDate.Clear()
        TxtClaimStatus.Clear()
    End Sub

    Private Sub TxtRecMobile_TextChanged(sender As Object, e As EventArgs) Handles TxtRecMobile.Leave

        If TxtRecMobile.TextLength < 11 Then
            MessageBox.Show("Invalid Contact Number. This field only accepts cellphone number", "INVALID NUMBER", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtRecMobile.Clear()
            TxtRecMobile.Focus()
        End If

    End Sub

    Private Sub TxtMobile_TextChanged(sender As Object, e As EventArgs) Handles TxtMobile.Leave
        'Dim newNumber As String
        If TxtMobile.TextLength < 11 Then
            MessageBox.Show("Invalid Contact Number. This field only accepts cellphone number", "INVALID NUMBER", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtMobile.Clear()
            TxtMobile.Focus()

            '
            'TxtMobile.Text = Format(TxtMobile.Text, "(####) ### ####")
            'newNumber = "(" & TxtMobile.Text.Substring(0, 3) & ")" & "-" & TxtMobile.Text.Substring(4, 3) & "-" & TxtMobile.Text.Substring(5, 4)
        End If

    End Sub

    Private Sub BtnAdminManageEmp_Click(sender As Object, e As EventArgs) Handles BtnAdminManageEmp.Click
        FormManageEmployees.Show()
    End Sub

    Private Sub BtnManageCustomers_Click(sender As Object, e As EventArgs) Handles BtnManageCustomers.Click
        FormManagedCustomers.Show()
    End Sub

    Private Sub BtnAdminTool_Click(sender As Object, e As EventArgs) Handles BtnAdminTool.Click
        AdminLogin.Show()
    End Sub
End Class