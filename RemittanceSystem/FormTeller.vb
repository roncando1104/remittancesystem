Imports Oracle.ManagedDataAccess.Client
Imports Oracle.DataAccess.Client
Imports System.Drawing.Printing

Public Class FormTeller

    Private bmp As Bitmap
    Private currentIndex As Integer
    Dim MyDataGridViewPrinter As DataGridViewPrinter

    Private Sub FormTeller_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim mRootNode As New TreeNode
        mRootNode.Text = RootPath
        mRootNode.Tag = RootPath
        mRootNode.Nodes.Add("*DUMMY*")
        TreeViewTeller.Nodes.Add(mRootNode)

        mRootNode.ImageKey = CacheShellIcon(RootPath)
        mRootNode.SelectedImageKey = mRootNode.ImageKey


        TpTellerReceiver.Enabled = False

        TxtCustName.Enabled = False
        CboIDtype.Enabled = False
        TxtMobile.Enabled = False
        TxtPurpose.Enabled = False
        TxtAddress.Enabled = False
        TxtRelationtoRec.Enabled = False
        TxtIssuePlace.Enabled = False
        TxtAmount.Enabled = False

        currentIndex = 0
    End Sub


    Private mRootPath As String = "c:\Users\ronal\source\repos\RemittanceSystem\Admin Files\Teller Reports\"
    Property RootPath As String
        Get
            Return mRootPath
        End Get
        Set(value As String)
            mRootPath = value
        End Set
    End Property

    Private Sub TreeViewAdmin_BeforeCollapse(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeViewTeller.BeforeCollapse

        e.Node.Nodes.Clear()

        e.Node.Nodes.Add("*DUMMY*")

    End Sub

    Private Sub TreeViewAdmin_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeViewTeller.BeforeExpand

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

    Private Sub TreeViewTeller_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeViewTeller.NodeMouseDoubleClick

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

    'opens the file in treeview
    Private Sub TreeViewTeller_NodeClick(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeViewTeller.NodeMouseDoubleClick

        If Not String.IsNullOrEmpty(eventArgs.Node.Tag) Then
            Process.Start(eventArgs.Node.Tag)
        End If

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

    Private Sub LinkNextCustomer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkNextCustomer.LinkClicked

        currentIndex = 1
        Dim answer As Integer

        'error provider, add all the txtbox in here and add msg in tag for each txtboxes
        If vld(TxtCustName, CboIDtype, TxtMobile, TxtPurpose, TxtRelationtoRec,
               TxtAddress, TxtIssuePlace, TxtAmount) = False Then
            Exit Sub
        End If
        If currentIndex >= 0 AndAlso currentIndex < TabControlTellerRemit.TabCount Then

            answer = MessageBox.Show("Check all fields.  You will not be able to alter data after proceeding to next page" _
                                     , "SECURE ALL ENTRY", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If answer = DialogResult.OK Then
                TabControlTellerRemit.SelectedIndex = currentIndex
                TpTellerReceiver.Enabled = True
                TxtRecName.Focus()
                TxtAmount.Enabled = False
            End If
        End If


    End Sub


    Private Sub LinkNextReceiver_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkNextReceiver.LinkClicked
        currentIndex = 2
        Dim answer2 As Integer

        'error provider, add all the txtbox in here and add msg in tag for each txtboxes
        If vld(TxtRecName, CboRecIDtype, TxtRecRelationship, TxtRecAddress, CboCorrespondent, TxtRecBranchAdd) = False Then
            Exit Sub
        End If

        If currentIndex >= 0 AndAlso currentIndex < TabControlTellerRemit.TabCount Then

            answer2 = MessageBox.Show("Check all fields.  You will not be able to alter data after proceeding to next page" _
                                     , "SECURE ALL ENTRY", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If answer2 = DialogResult.OK Then
                TabControlTellerRemit.SelectedIndex = currentIndex
                'BtnSaveTran.Enabled = True
            End If

        End If

    End Sub

    Private Sub LinkLabelCheckNext_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelCheckNext.LinkClicked
        currentIndex = 3
        Dim answer2 As Integer

        'error provider, add all the txtbox in here and add msg in tag for each txtboxes
        If vld(TxtRecName, CboRecIDtype, TxtRecRelationship, TxtRecMobile, TxtRecAddress, CboCorrespondent, TxtRecBranchAdd) = False Then
            Exit Sub
        End If

        If currentIndex >= 0 AndAlso currentIndex < TabControlTellerRemit.TabCount Then

            answer2 = MessageBox.Show("Verify all information before proceeding to printing the receipt" _
                                     , "SECURE ALL ENTRY", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If answer2 = DialogResult.OK Then
                TabControlTellerRemit.SelectedIndex = currentIndex
                'BtnSaveTran.Enabled = True
            End If

        End If
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

    Private Sub TxtAmount_Leave(sender As Object, e As EventArgs) Handles TxtAmount.Leave


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
            'LabelAmountInWords.Text = AmountInWords(TxtTotalAmt.Text.Trim)

        Catch ex As Exception
            MessageBox.Show("Please enter an amount", "AMOUNT TO BE REMITTED", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If DialogResult.OK Then
                TxtCashTendered.Focus()

            End If
        End Try

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblTellerDate.Text = Format(Now, "dd-MMM-yyyy")

        LabelSysDate.Text = Format(Now, "dddd, dd-MMM-yyyy hh:mm:ss tt")
    End Sub

    Private Sub BtnTellerLogout_Click(sender As Object, e As EventArgs) Handles BtnTellerLogout.Click
        Dim goOut As Integer
        goOut = MessageBox.Show("End all session?", "LOG OUT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If goOut = DialogResult.OK Then
            Close()
            End
        End If
    End Sub

    Private Sub BtnTellerHome_Click(sender As Object, e As EventArgs) Handles BtnTellerHome.Click
        PanelTellerHome.BringToFront()
        PanelTellerRemit.SendToBack()
    End Sub

    Private Sub BtnTellerRemit_Click(sender As Object, e As EventArgs) Handles BtnTellerRemit.Click
        PanelTellerRemit.BringToFront()
        'TabControlTellerRemit.Enabled = False
        BtnTellerRemitStart.Enabled = True
        PanelTellerHome.SendToBack()
    End Sub

    Private Sub BtnTellerRefresh1_Click(sender As Object, e As EventArgs) Handles BtnTellerRefresh1.Click
        DisplayTodayTransaction()
    End Sub

    Private Sub BtnTellerRefresh2_Click(sender As Object, e As EventArgs) Handles BtnTellerRefresh2.Click
        DisplayTodayTransaction2()
    End Sub

    Private Sub TabControlTellerRemit_Selecting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles TabControlTellerRemit.Selecting

        'transferring data to print receipt tab
        LblRefNo.Text = TxtRefNo1.Text & "-" & TxtRefNo2.Text & "-" & TxtRefNo3.Text
        TxtreceiverRefNo1.Text = TxtRefNo1.Text
        TxtReceiverRefNo2.Text = TxtRefNo2.Text
        TxtReceiverRefNo3.Text = TxtRefNo3.Text
        'customer transfer data
        LblCustName.Text = LblTellerCheckCustName.Text
        LblTellerCheckCustName.Text = TxtCustName.Text
        LblTellerCheckIDtype.Text = CboIDtype.Text
        LblTellerCheckMob.Text = TxtMobile.Text
        LblTellerCheckPurpose.Text = TxtPurpose.Text
        LblTellerCheckCustRel.Text = TxtRelationtoRec.Text
        LblTellerCheckAddress.Text = TxtAddress.Text
        LblTellerCheckIssuePlace.Text = TxtIssuePlace.Text
        LblTellerCheckIssue.Text = TxtIssueDate.Text
        LblTellerCheckExpiry.Text = TxtExpirtyDate.Text
        Try
            LblTellerCheckAmountRemit.Text = FormatNumber(TxtAmount.Text, 2)
        Catch ex As Exception
            ' MsgBox("Complete all entries")
        End Try
        'LblPurpose.Text = TxtPurpose.Text
        'LblrelationToRec.Text = TxtRelationtoRec.Text
        'Lbladdress.Text = TxtAddress.Text
        LblissuePlace.Text = TxtIssuePlace.Text
        LblissueDate.Text = TxtIssueDate.Text
        LblexpiryDate.Text = TxtExpirtyDate.Text
        LabelAmtInWordsReceipt.Text = AmountInWords(TxtTotalAmt.Text)
        Try
            Lblamount.Text = FormatNumber(TxtAmount.Text, 2) '& ".00 php"
            'customer data to receiver data
            TxtrecAmount.Text = FormatNumber(TxtAmount.Text, 2)
        Catch ex As Exception
            MsgBox("Complete all entries")
        End Try

        LblTellerCheckRefNo.Text = LblRefNo.Text
        LblTellerCheckCharge.Text = TxtCharge.Text
        LblTellerCheckTotal.Text = TxtTotalAmt.Text

        Lblcharge.Text = TxtCharge.Text
        LbltotalAmount.Text = TxtTotalAmt.Text
        'receiver transfer data
        LblreceiverName.Text = TxtRecName.Text
        'LblreceiverIDtype.Text = CboRecIDtype.Text
        'LblreceiverMobileNo.Text = TxtRecMobile.Text
        'LblreceiverRelationToSender.Text = TxtRecRelationship.Text
        'LblreceiverAddress.Text = TxtRecAddress.Text
        'LblreceiverCorrespondent.Text = CboCorrespondent.Text
        'LblreceiverBranch.Text = TxtRecBranchAdd.Text
        'LblreceiverAmount.Text = TxtrecAmount.Text

        LblTellerCheckRecName.Text = TxtRecName.Text
        LblTellerCheckRecId.Text = CboRecIDtype.Text
        LblTellerCheckRecMob.Text = TxtRecMobile.Text
        LblTellerCheckRecRel.Text = TxtRecRelationship.Text
        LblTellerCheckRecAdd.Text = TxtRecAddress.Text
        LblTellerCheckCorr.Text = CboCorrespondent.Text
        LblTellerCheckBranck.Text = TxtRecBranchAdd.Text
        LblTellerCheckRecAmount.Text = TxtrecAmount.Text

    End Sub

    Private Sub BtnTellerRemitStart_Click(sender As Object, e As EventArgs) Handles BtnTellerRemitStart.Click

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
        BtnTellerRemitStart.Enabled = False

        TxtIssueDate.Text = LblTellerDate.Text

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
        TabControlTellerRemit.Enabled = True

        BtnTellerSaveRemit.BringToFront()
        BtnTellerRemitStart.SendToBack()
        BtnTellerPrintRemit.SendToBack()

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

    Private Sub TxtRecMobile_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtRecMobile.KeyPress
        'receiver mobile number
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MessageBox.Show("Numbers only", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                TxtRecMobile.Text = ""
                TxtRecMobile.Focus()
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

    Private Sub BtnTellerSaveRemit_Click(sender As Object, e As EventArgs) Handles BtnTellerSaveRemit.Click

        BtnTellerSaveRemit.SendToBack()
        BtnTellerPrintRemit.BringToFront()

        InsertTransaction()
        InsertBeneficiaries()
        InsertStatus()

    End Sub

    Private Sub BtnTellerStartClaim_Click(sender As Object, e As EventArgs) Handles BtnTellerStartClaim.Click
        TxtClaimRefNo.Enabled = True

    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        SearchClaimStatus()
        SearchClaimantInfo()

        BtnClaimChangeStat.Enabled = True
    End Sub

    Private Sub BtnTellerClaim_Click(sender As Object, e As EventArgs) Handles BtnTellerClaim.Click
        PanelTellerClaimTrans.BringToFront()
        BtnClaimChangeStat.Enabled = False
        PanelTellerRemit.SendToBack()
        PanelTellerHome.SendToBack()

    End Sub



    'link to go to next tab on claim teller panel

    Private Sub LinkLabelcNext_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelcNext.LinkClicked
        currentIndex = 1

        If TxtClaimStatus.Text = "NOT CLAIMED" Then

            MessageBox.Show("You cannot proceed without changing the status. Select change status.", "CLAIMED STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf TxtClaimStatus.Text = "EXPIRED" Then
            MessageBox.Show("This transaction is already expired.", "ERROR ON CLAIM TRANSACTION", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf TxtClaimRefNo.Text = "" Then
            MessageBox.Show("Enter the Reference Number.", "CLAIMED STATUS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        ElseIf currentIndex >= 0 AndAlso currentIndex < TabControlTellerClaim.TabCount Then
            TabControlTellerClaim.SelectedIndex = currentIndex
        End If
    End Sub

    Private Sub TabControlTellerClaim_Selecting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles TabControlTellerClaim.Selecting

        'data transfer from claim transaction to receipt
        LabelcRefNo.Text = TxtClaimRefNo.Text
        LabelcName.Text = TxtClaimName.Text
        LblTellerClaimAmtInWords.Text = AmountInWords(TxtClaimAmount.Text)
        LabelcMobileNo.Text = TxtClaimMobile.Text
        LabelcAddress.Text = TxtClaimAddress.Text
        LabelcCorrespondent.Text = TxtClaimCorrespondent.Text
        LabelcBranch.Text = TxtClaimBranch.Text
        LabelcAmount.Text = TxtClaimAmount.Text
        LabelcStatus.Text = TxtClaimStatus.Text
        Label66.Text = TxtExpirtyDate.Text


    End Sub


    'function for searching status and beneficiary info

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

    'function for inserting records from remittance transaction

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
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var2", LblCustName.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var3", LblTellerCheckIDtype.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var4", LblTellerCheckMob.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var5", LblTellerCheckPurpose.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var6", LblTellerCheckCustRel.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var7", LblTellerCheckAddress.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var8", LblTellerCheckIssue.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var9", LblTellerCheckIssuePlace.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var10", LblTellerCheckExpiry.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var11", Lblamount.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var12", Lblcharge.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var13", LbltotalAmount.Text))
                cmd.CommandText = sqlCustomer
                cmd.ExecuteNonQuery()
                transaction.Commit()

                cmd.Dispose()
                conn.Close()

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
                'TxtRecMobile.Clear()
                TxtRecAddress.Clear()
                TxtRecRelationship.Clear()
                TxtrecAmount.Clear()
                TxtRecBranchAdd.Clear()


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
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var2", LblreceiverName.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var3", LblTellerCheckRecId.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var4", LblTellerCheckRecMob.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var5", LblTellerCheckRecAdd.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var6", LblTellerCheckRecRel.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var7", LblTellerCheckCorr.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var8", LblTellerCheckBranck.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var9", LblTellerCheckRecAmount.Text))
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
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var2", LblTellerEmpID.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var3", LblissueDate.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var4", LblexpiryDate.Text))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var5", ("NOT CLAIMED")))
                cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("var6", LblTellerCheckRecAmount.Text))
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

    'function for displaying today per id transaction on tabcontroltellerhome and customer
    Public Sub DisplayTodayTransaction()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
        + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
        + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
        + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()
        conn.ConnectionString = OraDB
        'Dim sql As String = "SELECT * FROM REM_STATUS WHERE EMPLOYEE_ID = '" & LblTellerEmpID.Text & "' AND ISSUE_DATE = '" & LblTellerDate.Text & "'"
        Dim sql As String = "SELECT T1.REFERENCE_NUMBER, T1.NAME, T1.ISSUE_DATE, T1.ISSUE_PLACE, T1.EXPIRY_DATE, T1.AMOUNT, T1.CHARGE, T1.TOTAL_AMOUNT, T2.EMPLOYEE_ID FROM REM_CUSTOMER T1 INNER JOIN REM_STATUS T2 ON T1.REFERENCE_NUMBER = T2.REFERENCE_NUMBER WHERE T2.EMPLOYEE_ID = '" & LblTellerEmpID.Text & "' AND T2.ISSUE_DATE = '" & LblTellerDate.Text & "' "
        Dim cmd As New Oracle.DataAccess.Client.OracleCommand(sql, conn)
        cmd.CommandType = CommandType.Text

        conn.Open()

        Dim dt As New DataTable("REM_STATUS")
        Dim rs As New Oracle.DataAccess.Client.OracleDataAdapter(cmd)
        rs.Fill(dt)
        dgvTellerTodayTransaction.DataSource = dt
        dgvTellerTodayTransaction.Refresh()

        'LblCount.Text = dt.Rows.Count
        rs.Dispose()
        conn.Close()

        Dim total, chg, Tamount As Double
        For i As Integer = 0 To dgvTellerTodayTransaction.Rows.Count - 1
            total = total + dgvTellerTodayTransaction.Rows(i).Cells(5).Value
            chg = chg + dgvTellerTodayTransaction.Rows(i).Cells(6).Value
            Tamount = Tamount + dgvTellerTodayTransaction.Rows(i).Cells(7).Value

        Next
        Dim blankRow = dt.NewRow
        blankRow(1) = ""
        dt.Rows.Add(blankRow)

        Dim myrow = dt.NewRow
        myrow(6) = "REMITTANCES: "
        myrow(7) = FormatNumber(total, 2)
        dt.Rows.Add(myrow)

        Dim myrow2 = dt.NewRow
        myrow2(6) = "TOTAL CHARGES: "
        myrow2(7) = FormatNumber(chg, 2)
        dt.Rows.Add(myrow2)

        Dim myrow3 = dt.NewRow
        myrow3(6) = "TOTAL AMOUNT: "
        myrow3(7) = FormatNumber(Tamount, 2)
        dt.Rows.Add(myrow3)


    End Sub

    'function for displaying today per id transaction on tabcontroltellerhome and beneficiaries
    Public Sub DisplayTodayTransaction2()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
        + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
        + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
        + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()
        conn.ConnectionString = OraDB
        'Dim sql As String = "SELECT * FROM REM_STATUS WHERE EMPLOYEE_ID = '" & LblTellerEmpID.Text & "' AND ISSUE_DATE = '" & LblTellerDate.Text & "'"
        Dim sql As String = "SELECT T1.REFERENCE_NUMBER, T1.NAME, T1.MOBILE_NUMBER, T1.CORRESPONDENT, T1.BRANCH_ADDRESS, T1.AMOUNT_RECEIVED, T2.EMPLOYEE_ID FROM REM_BENEFICIARIES T1 INNER JOIN REM_STATUS T2 ON T1.REFERENCE_NUMBER = T2.REFERENCE_NUMBER WHERE T2.EMPLOYEE_ID = '" & LblTellerEmpID.Text & "' AND T2.ISSUE_DATE = '" & LblTellerDate.Text & "' "
        Dim cmd As New Oracle.DataAccess.Client.OracleCommand(sql, conn)
        cmd.CommandType = CommandType.Text

        conn.Open()

        Dim dt As New DataTable("REM_STATUS")
        Dim rs As New Oracle.DataAccess.Client.OracleDataAdapter(cmd)
        rs.Fill(dt)
        dgvTellerClaim.DataSource = dt
        dgvTellerClaim.Refresh()

        'LblCount.Text = dt.Rows.Count
        rs.Dispose()
        conn.Close()

        Dim total As Double
        For i As Integer = 0 To dgvTellerClaim.Rows.Count - 1
            total = total + dgvTellerClaim.Rows(i).Cells(5).Value


        Next
        Dim blankRow = dt.NewRow
        blankRow(1) = ""
        dt.Rows.Add(blankRow)

        Dim myrow = dt.NewRow
        myrow(4) = "TOTAL AMOUNT: "
        myrow(5) = FormatNumber(total, 2)

        dt.Rows.Add(myrow)

    End Sub

    Private Sub BtnTellerHomePrint2_Click(sender As Object, e As EventArgs) Handles BtnTellerHomePrint2.Click
        If PrintReceiver() Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub BtnTellerHomePreview2_Click(sender As Object, e As EventArgs) Handles BtnTellerHomePreview2.Click
        If PrintReceiver() Then
            Dim MyPrintPreviewDialog As PrintPreviewDialog = New PrintPreviewDialog()
            MyPrintPreviewDialog.Document = PrintDocument1
            MyPrintPreviewDialog.ShowDialog()
        End If
    End Sub

    Private Sub BtnTellerHomePreview1_Click(sender As Object, e As EventArgs) Handles BtnTellerHomePreview1.Click
        If PrintSender() Then
            Dim MyPrintPreviewDialog As PrintPreviewDialog = New PrintPreviewDialog()
            MyPrintPreviewDialog.Document = PrintDocument1
            MyPrintPreviewDialog.ShowDialog()
        End If

    End Sub

    Private Sub BtnTellerHomePrint1_Click(sender As Object, e As EventArgs) Handles BtnTellerHomePrint1.Click

        If PrintSender() Then
            PrintDocument1.Print()
        End If

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim more As Boolean = MyDataGridViewPrinter.DrawDataGridView(e.Graphics)

        If more = True Then
            e.HasMorePages = True
        End If
    End Sub

    Private Function PrintSender()

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
            MyDataGridViewPrinter = New DataGridViewPrinter(dgvTellerTodayTransaction, PrintDocument1, True, True, "SENDER INFORMATION", New Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, True)
        Else
            MyDataGridViewPrinter = New DataGridViewPrinter(dgvTellerTodayTransaction, PrintDocument1, False, True, "SENDER INFORMATION", New Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, True)
        End If

        Return True

    End Function

    Private Function PrintReceiver()

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

        PrintDocument1.DocumentName = "RECEIVER INFORMATION"

        PrintDocument1.PrinterSettings = MyPrintDialog.PrinterSettings
        PrintDocument1.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings
        PrintDocument1.DefaultPageSettings.Margins = New Margins(40, 40, 40, 40)

        If MessageBox.Show("Do you want the report to be centered on the page", "PRINT SETTINGS", MessageBoxButtons.YesNo, MessageBoxIcon.Information) Then
            MyDataGridViewPrinter = New DataGridViewPrinter(dgvTellerClaim, PrintDocument1, True, True, "RECEIVER INFORMATION", New Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, True)
        Else
            MyDataGridViewPrinter = New DataGridViewPrinter(dgvTellerClaim, PrintDocument1, False, True, "RECEIVER INFORMATION", New Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, True)
        End If

        Return True

    End Function
    'still needed to be edited because groupbox is not showing in preview
    Private Sub BtnTellerRemitPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTellerRemitPreview.Click

        bmp = New Bitmap(PanelTellerRemitReceipt.Width, PanelTellerRemitReceipt.Height)
        Dim G As Graphics = Graphics.FromImage(bmp)
        PanelTellerRemitReceipt.DrawToBitmap(bmp, PanelTellerRemitReceipt.ClientRectangle)
        G.Dispose()

        PrintPreviewDialog1.Document = PrintDocumentTellerSender

        PrintPreviewDialog1.ShowDialog()

    End Sub
    'printing the receipt for teller sender
    Private Sub BtnTellerPrintRemit_Click(sender As Object, e As EventArgs) Handles BtnTellerPrintRemit.Click

        Dim dlgSettings As New PrintDialog()
        dlgSettings.Document = PrintDocumentTellerSender

        If dlgSettings.ShowDialog() = DialogResult.OK Then
            PanelTellerRemitReceipt.VerticalScroll.Value = 0
            PrintDocumentTellerSender.DefaultPageSettings.PaperSize = New PaperSize("Custom", 850, 1100)
            PrintDocumentTellerSender.Print()
        End If



    End Sub
    'function for printing the receipt of teller sender
    Private Sub PrintDocumentTellerSender_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocumentTellerSender.PrintPage

        Static page As Integer = 1
        Dim startPosition As Integer = (page - 1) * PrintDocumentTellerSender.DefaultPageSettings.Bounds.Height - 50
        Static maxPages As Integer = 0

        If page = 1 Then

            For Each ctrl As Control In PanelTellerRemitReceipt.Controls
                If TypeOf ctrl Is TextBox Or TypeOf ctrl Is Label Or TypeOf ctrl Is PictureBox Then
                    ctrl.Tag = Int((ctrl.Top + ctrl.Height) / PrintDocumentTellerSender.DefaultPageSettings.Bounds.Height) + 1
                    If CInt(ctrl.Tag) > maxPages Then
                        maxPages = CInt(ctrl.Tag)

                    End If
                End If

            Next

        End If

        For Each ctrl As Control In PanelTellerRemitReceipt.Controls
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

    Private Sub BtnClaimChangeStat_Click(sender As Object, e As EventArgs) Handles BtnClaimChangeStat.Click

        If TxtClaimStatus.Text = "EXPIRED" Then
            MessageBox.Show("This transaction is already expired.", "ERROR ON CHANGING STATUS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            TxtClaimStatus.Text = "CLAIMED"
        End If

    End Sub

    Private Sub BtnTellerClaimSave_Click(sender As Object, e As EventArgs) Handles BtnTellerClaimSave.Click

        If TxtClaimStatus.Text = "EXPIRED" Then
            MessageBox.Show("This transaction is already expired.", "ERROR ON CHANGING STATUS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TxtClaimStatus.Text = "" Then

            MessageBox.Show("You cannot save transaction without changing the status.", "ERROR ON CHANGING STATUS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else

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

            BtnTellerClaimSave.SendToBack()

        End If



    End Sub




    'button print, preview and function for claim receitp

    Private Sub BtnClaimPrintTeller_Click(sender As Object, e As EventArgs) Handles BtnClaimPrintTeller.Click

        Dim dlgSettings As New PrintDialog()
        dlgSettings.Document = PrintDocumentTellerClaim

        If dlgSettings.ShowDialog() = DialogResult.OK Then
            PanelTellerClaimReceipt.VerticalScroll.Value = 0
            PrintDocumentTellerClaim.DefaultPageSettings.PaperSize = New PaperSize("Custom", 850, 1100)
            PrintDocumentTellerClaim.Print()
        End If


    End Sub

    Private Sub BtnTellerClaimPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTellerClaimPreview.Click

        bmp = New Bitmap(PanelTellerClaimReceipt.Width, PanelTellerClaimReceipt.Height)
        Dim G As Graphics = Graphics.FromImage(bmp)
        PanelTellerRemitReceipt.DrawToBitmap(bmp, PanelTellerClaimReceipt.ClientRectangle)
        G.Dispose()

        PrintPreviewDialogTellerClaim.Document = PrintDocumentTellerClaim

        PrintPreviewDialogTellerClaim.ShowDialog()

    End Sub

    Private Sub PrintDocumentTellerClaim_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocumentTellerClaim.PrintPage

        Static page As Integer = 1
        Dim startPosition As Integer = (page - 1) * PrintDocumentTellerClaim.DefaultPageSettings.Bounds.Height - 50
        Static maxPages As Integer = 0

        If page = 1 Then

            For Each ctrl As Control In PanelTellerClaimReceipt.Controls
                If TypeOf ctrl Is TextBox Or TypeOf ctrl Is Label Or TypeOf ctrl Is PictureBox Then
                    ctrl.Tag = Int((ctrl.Top + ctrl.Height) / PrintDocumentTellerClaim.DefaultPageSettings.Bounds.Height) + 1
                    If CInt(ctrl.Tag) > maxPages Then
                        maxPages = CInt(ctrl.Tag)

                    End If
                End If

            Next

        End If

        For Each ctrl As Control In PanelTellerClaimReceipt.Controls
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

    Private Sub BtnTellerNewTrans_Click(sender As Object, e As EventArgs) Handles BtnTellerNewTrans.Click
        TabControlTellerRemit.SelectedIndex = 0

        BtnTellerRemitStart.Enabled = True

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

    Private Sub BtnTellerCancelRemit_Click(sender As Object, e As EventArgs) Handles BtnTellerCancelRemit.Click

        MessageBox.Show("Are you sure to cancel transaction?", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If DialogResult.OK Then
            TabControlTellerRemit.SelectedIndex = 0

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
            CboIDtype.Text = ""
            CboCorrespondent.Text = ""
            CboRecIDtype.Text = ""
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

    Private Sub BtnTellerClaimCancel_Click(sender As Object, e As EventArgs) Handles BtnTellerClaimCancel.Click

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

    Private Sub TxtMobile_Leave(sender As Object, e As EventArgs) Handles TxtMobile.Leave
        If TxtMobile.TextLength < 11 Then
            MessageBox.Show("Invalid Contact Number. This field only accepts cellphone number", "INVALID NUMBER", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtMobile.Clear()
            TxtMobile.Focus()
        End If
    End Sub

    Private Sub TxtRecMobile_Leave(sender As Object, e As EventArgs) Handles TxtRecMobile.Leave
        If TxtRecMobile.TextLength < 11 Then
            MessageBox.Show("Invalid Contact Number. This field only accepts cellphone number", "INVALID NUMBER", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtRecMobile.Clear()
            TxtRecMobile.Focus()
        End If
    End Sub

    Private Sub BtnAdminTool_Click(sender As Object, e As EventArgs) Handles BtnAdminTool.Click
        AdminLogin.Show()
    End Sub

    Private Sub Label66_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label66_Click_1(sender As Object, e As EventArgs) Handles Label66.Click

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub


End Class


