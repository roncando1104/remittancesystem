Imports Oracle.ManagedDataAccess.Client
Imports Oracle.DataAccess.Client
Imports System.Drawing.Printing

Public Class FormAdminEditTool


    Private bmp As Bitmap
    Private currentIndex As Integer
    Dim MyDataGridViewPrinter As DataGridViewPrinter

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

    Public Sub SearchClaimStatus()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
       + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
       + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
       + "User Id=SYSTEM;Password=SYSTEM;"

        Dim dr As Oracle.DataAccess.Client.OracleDataReader
        Dim strRetrieve As String
        strRetrieve = "SELECT * FROM REM_STATUS WHERE (REFERENCE_NUMBER = '" & TvRefNo.Text & "')"

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
        strClaim = "SELECT * FROM REM_BENEFICIARIES WHERE (REFERENCE_NUMBER = '" & TvRefNo.Text & "')"

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
            'MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub SearchSenderInfo()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
  + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
  + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
  + "User Id=SYSTEM;Password=SYSTEM;"

        Dim dr As Oracle.DataAccess.Client.OracleDataReader
        Dim strClaim As String
        strClaim = "SELECT * FROM REM_CUSTOMER WHERE (REFERENCE_NUMBER = '" & TvRefNo.Text & "')"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()

        conn.ConnectionString = OraDB

        Dim cmd As Oracle.DataAccess.Client.OracleCommand = New Oracle.DataAccess.Client.OracleCommand(strClaim, conn)

        conn.Open()

        dr = cmd.ExecuteReader

        Try

            While dr.Read

                TxtCustName.Text = dr("NAME").ToString
                TxtCustIDtype.Text = dr("ID_TYPE").ToString
                TxtMobile.Text = dr("MOBILE_NUMBER").ToString
                TxtPurpose.Text = dr("PURPOSE").ToString
                TxtRelationtoRec.Text = dr("RELATIONSHIP_TO_THE_RECEIVER").ToString
                TxtAddress.Text = dr("ADDRESS").ToString
                TxtIssueDate.Text = dr("ISSUE_DATE").ToString
                TxtIssuePlace.Text = dr("ISSUE_PLACE").ToString
                TxtExpirtyDate.Text = dr("EXPIRY_DATE").ToString
                TxtAmount.Text = dr("AMOUNT").ToString
                TxtCharge.Text = dr("CHARGE").ToString
                TxtTotalAmt.Text = dr("TOTAL_AMOUNT").ToString


            End While

            TxtIssueDate.Text = Format(CDate(TxtIssueDate.Text), "dd-MMM-yyyy")
            TxtExpirtyDate.Text = Format(CDate(TxtExpirtyDate.Text), "dd-MMM-yyyy")

            'TxtClaimAmount.Text = Format(C(TxtDateIssueClaim.Text), "dd-MMM-yyyy")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    'button search on sender tab
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SearchClaimantInfo()
        SearchClaimStatus()
        SearchSenderInfo()

        TvRefNo.Enabled = False
    End Sub

    Private Sub BtnSaveChanges_Click(sender As Object, e As EventArgs) Handles BtnSaveChanges.Click



        currentIndex = 3
        Dim answer2 As Integer

        If currentIndex >= 0 AndAlso currentIndex < TabControlAdminTool.TabCount Then

            answer2 = MessageBox.Show("Check all fields.  You will not be able to alter data after proceeding to next page" _
                                     , "SECURE ALL ENTRY", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If answer2 = DialogResult.OK Then

                MessageBox.Show("Transaction successful", "TRANSACTION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TabControlAdminTool.SelectedIndex = currentIndex
                UpdateBeneficiary()
                UpdateSender()
                UpdateStatus()

                BtnSaveChanges.Enabled = False
                BtnPrint.Enabled = True
                BtnCancelTrans.Enabled = False
                BtnPreview.Enabled = True

            ElseIf answer2 = DialogResult.Cancel Then
                TabControlAdminTool.SelectedIndex = 2

            End If

        End If

        ''notifies the user if saved already at the bottom of the form
        'toolstripprogressbar1.visible = true

        'for i as integer = 0 to toolstripprogressbar1.maximum - 1
        '    toolstripprogressbar1.value = toolstripprogressbar1.value + 1
        '    toolstripstatuslabel1.visible = true
        'next

    End Sub

    Private Sub BtnPreview_Click(sender As Object, e As EventArgs) Handles BtnPreview.Click
        bmp = New Bitmap(PanelNewReceipt.Width, PanelNewReceipt.Height)
        Dim G As Graphics = Graphics.FromImage(bmp)
        PanelNewReceipt.DrawToBitmap(bmp, PanelNewReceipt.ClientRectangle)
        G.Dispose()

        PrintPreviewDialog1.Document = PrintDocument1

        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click

        Dim dlgSettings As New PrintDialog()
        dlgSettings.Document = PrintDocument1

        If dlgSettings.ShowDialog() = DialogResult.OK Then
            PanelNewReceipt.VerticalScroll.Value = 0
            PrintDocument1.DefaultPageSettings.PaperSize = New PaperSize("Custom", 850, 1100)
            PrintDocument1.Print()
        End If



    End Sub

    'function for printing the receipt of teller sender
    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Static page As Integer = 1
        Dim startPosition As Integer = (page - 1) * PrintDocument1.DefaultPageSettings.Bounds.Height - 50
        Static maxPages As Integer = 0

        If page = 1 Then

            For Each ctrl As Control In PanelNewReceipt.Controls
                If TypeOf ctrl Is TextBox Or TypeOf ctrl Is Label Or TypeOf ctrl Is PictureBox Then
                    ctrl.Tag = Int((ctrl.Top + ctrl.Height) / PrintDocument1.DefaultPageSettings.Bounds.Height) + 1
                    If CInt(ctrl.Tag) > maxPages Then
                        maxPages = CInt(ctrl.Tag)

                    End If
                End If

            Next

        End If

        For Each ctrl As Control In PanelNewReceipt.Controls
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



    Private Sub TxtIssueDate_TextChanged(sender As Object, e As EventArgs) Handles TxtIssueDate.Leave
        TxtIssueDate.Text = Format(CDate(TxtIssueDate.Text), "dd-MMM-yyyy")

        Dim newDate As DateTime = DateTime.Now.AddMonths(1)
        TxtExpirtyDate.Text = Format(newDate, "dd-MMM-yyyy")
    End Sub

    Public Sub UpdateSender()


        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
     + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
     + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
     + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()
        conn.ConnectionString = OraDB

        conn.Open()
        Dim strChangeStat As String
        strChangeStat = "UPDATE REM_CUSTOMER SET NAME = '" & TxtCustName.Text & "', " & "ID_TYPE = '" & TxtCustIDtype.Text & "', " & "MOBILE_NUMBER = '" & TxtMobile.Text & "', " & "PURPOSE = '" & TxtPurpose.Text & "', " & "RELATIONSHIP_TO_THE_RECEIVER = '" & TxtRelationtoRec.Text & "', " & "ADDRESS = '" & TxtAddress.Text & "', " & "ISSUE_DATE = '" & TxtIssueDate.Text & "', " & " ISSUE_PLACE = '" & TxtIssuePlace.Text & "', " & "EXPIRY_DATE = '" & TxtExpirtyDate.Text & "', " & "AMOUNT = '" & TxtAmount.Text & "', " & "CHARGE = '" & TxtCharge.Text & "', " & "TOTAL_AMOUNT = '" & TxtTotalAmt.Text & "' WHERE REFERENCE_NUMBER = '" & TvRefNo.Text & "'"

        Dim cmd As Oracle.DataAccess.Client.OracleCommand = New Oracle.DataAccess.Client.OracleCommand(strChangeStat, conn)

        cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("NAME", TxtCustName.Text))
        cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("ID_TYPE", TxtCustIDtype.Text))
        cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("MOBILE_NUMBER", TxtMobile.Text))
        cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("PURPOSE", TxtPurpose.Text))
        cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("RELATIONSHIP_TO_THE_RECEIVER", TxtRelationtoRec.Text))
        cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("ADDRESS", TxtAddress.Text))
        cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("ISSUE_DATE", TxtIssueDate.Text))
        cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("ISSUE_PLACE", TxtIssuePlace.Text))
        cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("EXPIRY_DATE", TxtExpirtyDate.Text))
        cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("AMOUNT", TxtAmount.Text))
        cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("CHARGE", TxtCharge.Text))
        cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("TOTAL_AMOUNT", TxtTotalAmt.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub UpdateBeneficiary()


        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
     + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
     + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
     + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()
        conn.ConnectionString = OraDB

        conn.Open()
        Dim strChangeStat As String
        strChangeStat = "UPDATE REM_BENEFICIARIES SET NAME = '" & TxtClaimName.Text & "', " & "ID_TYPE = '" & TxtClaimIDtype.Text & "', " & "MOBILE_NUMBER = '" & TxtClaimMobile.Text & "',  " & "ADDRESS = '" & TxtClaimAddress.Text & "',  " & "RELATIONSHIP_TO_THE_SENDER = '" & TxtClaimRelationship.Text & "'," & "CORRESPONDENT = '" & TxtClaimCorrespondent.Text & "', " & " BRANCH_ADDRESS = '" & TxtClaimBranch.Text & "'," & "AMOUNT_RECEIVED = '" & TxtClaimAmount.Text & "' WHERE REFERENCE_NUMBER = '" & TvRefNo.Text & "'"

        Dim cmd As Oracle.DataAccess.Client.OracleCommand = New Oracle.DataAccess.Client.OracleCommand(strChangeStat, conn)

        cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("NAME", TxtClaimName.Text))
        cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("ID_TYPE", TxtClaimIDtype.Text))
        cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("MOBILE_NUMBER", TxtClaimMobile.Text))
        cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("ADDRESS", TxtClaimAddress.Text))
        cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("RELATIONSHIP_TO_THE_SENDER", TxtClaimRelationship.Text))
        cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("CORRESPONDENT", TxtClaimCorrespondent.Text))
        cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("BRANCH_ADDRESS", TxtClaimBranch.Text))
        cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("AMOUNT_RECEIVED", TxtClaimAmount.Text))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Public Sub UpdateStatus()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
     + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
     + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
     + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()
        conn.ConnectionString = OraDB

        conn.Open()
        Dim strChangeStat As String
        strChangeStat = "UPDATE REM_STATUS SET ISSUE_DATE = '" & TxtIssueDate.Text & "', " & "EXPIRY_DATE = '" & TxtExpirtyDate.Text & "', " & "STATUS = '" & TxtClaimStatus.Text & "',  " & "AMOUNT = '" & TxtClaimAmount.Text & "' WHERE REFERENCE_NUMBER = '" & TvRefNo.Text & "'"

        Dim cmd As Oracle.DataAccess.Client.OracleCommand = New Oracle.DataAccess.Client.OracleCommand(strChangeStat, conn)

        cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("ISSUE_DATE", TxtClaimName.Text))
        cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("EXPIRY_DATE", TxtClaimIDtype.Text))
        cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("STATUS", TxtClaimMobile.Text))
        cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("AMOUNT", TxtClaimAddress.Text))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
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

    Private Sub TxtClaimMobile_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtClaimMobile.KeyPress
        'receiver mobile number
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MessageBox.Show("Numbers only", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                TxtClaimMobile.Text = ""
                TxtClaimMobile.Focus()
            End If
        End If

    End Sub

    Private Sub TxtCashTendered_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCashTendered.KeyPress

        'receiver mobile number
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MessageBox.Show("Numbers only", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                TxtCashTendered.Text = ""
                TxtCashTendered.Focus()
            End If
        End If

    End Sub

    Private Sub TxtAmount_TextChanged_1(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAmount.KeyPress

        'receiver mobile number
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MessageBox.Show("Numbers only", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                TxtAmount.Text = ""
                TxtAmount.Focus()
            End If
        End If

    End Sub

    Private Sub TxtClaimName_Leave(sender As Object, e As EventArgs) Handles TxtClaimName.Leave

        If (TxtClaimName.Text <> "") Then

            Dim userInput As String = TxtClaimName.Text

            If Not (ValidString(userInput) = True) Then
                TxtClaimName.Clear()
                TxtClaimName.Focus()
                MessageBox.Show("Invalid character, letters only", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub TxtClaimRelationship_Leave(sender As Object, e As EventArgs) Handles TxtClaimRelationship.Leave
        If (TxtClaimRelationship.Text <> "") Then

            Dim userInput As String = TxtClaimRelationship.Text

            If Not (ValidString(userInput) = True) Then
                TxtClaimRelationship.Clear()
                TxtClaimRelationship.Focus()
                MessageBox.Show("Invalid character, letters only", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub TxtAmount_TextChanged(sender As Object, e As EventArgs) Handles TxtAmount.Leave
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

    Private Sub LinkLabelcNext_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelcNext.LinkClicked

        currentIndex = 1
        Dim answer As Integer

        'error provider, add all the txtbox in here and add msg in tag for each txtboxes
        If vld(TxtCustName, TxtCustIDtype, TxtMobile, TxtPurpose, TxtRelationtoRec,
               TxtAddress, TxtIssuePlace, TxtAmount) = False Then
            Exit Sub
        End If
        If currentIndex >= 0 AndAlso currentIndex < TabControlAdminTool.TabCount Then

            answer = MessageBox.Show("Check all fields.  You will not be able to alter data after proceeding to next page" _
                                     , "SECURE ALL ENTRY", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If answer = DialogResult.OK Then
                TabControlAdminTool.SelectedIndex = currentIndex
                'TpTellerReceiver.Enabled = True
                'TxtRecName.Focus()
                'TxtAmount.Enabled = False
            End If
        End If

    End Sub

    Private Sub LinkLabelNextClaim_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelNextClaim.LinkClicked

        currentIndex = 2
        Dim answer2 As Integer

        'error provider, add all the txtbox in here and add msg in tag for each txtboxes
        If vld(TxtClaimName, TxtClaimIDtype, TxtClaimRelationship, TxtClaimMobile, TxtClaimAddress, TxtClaimCorrespondent, TxtClaimBranch) = False Then
            Exit Sub
        End If

        If currentIndex >= 0 AndAlso currentIndex < TabControlAdminTool.TabCount Then

            answer2 = MessageBox.Show("Check all fields.  You will not be able to alter data after proceeding to next page" _
                                     , "SECURE ALL ENTRY", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If answer2 = DialogResult.OK Then
                TabControlAdminTool.SelectedIndex = currentIndex
                BtnSaveChanges.Enabled = True
                'BtnSaveTran.Enabled = True
            End If

        End If

    End Sub

    Private Sub TabControlAdminTool_Selecting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles TabControlAdminTool.Selecting


        'transferring data to print receipt tab
        LblRefNo.Text = TvRefNo.Text

        'customer transfer data
        LblCustName.Text = LblTellerCheckCustName.Text
        LblTellerCheckCustName.Text = TxtCustName.Text
        LblTellerCheckIDtype.Text = TxtCustIDtype.Text
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
            TxtClaimAmount.Text = FormatNumber(TxtAmount.Text, 2)
        Catch ex As Exception
            MsgBox("Complete all entries")
        End Try

        LblTellerCheckRefNo.Text = LblRefNo.Text
        LblTellerCheckCharge.Text = TxtCharge.Text
        LblTellerCheckTotal.Text = TxtTotalAmt.Text

        Lblcharge.Text = TxtCharge.Text
        LbltotalAmount.Text = TxtTotalAmt.Text
        'receiver transfer data
        LblreceiverName.Text = TxtClaimName.Text
        'LblreceiverIDtype.Text = CboRecIDtype.Text
        'LblreceiverMobileNo.Text = TxtRecMobile.Text
        'LblreceiverRelationToSender.Text = TxtRecRelationship.Text
        'LblreceiverAddress.Text = TxtRecAddress.Text
        'LblreceiverCorrespondent.Text = CboCorrespondent.Text
        'LblreceiverBranch.Text = TxtRecBranchAdd.Text
        'LblreceiverAmount.Text = TxtrecAmount.Text

        LblTellerCheckRecName.Text = TxtClaimName.Text
        LblTellerCheckRecId.Text = TxtClaimIDtype.Text
        LblTellerCheckRecMob.Text = TxtClaimMobile.Text
        LblTellerCheckRecRel.Text = TxtClaimRelationship.Text
        LblTellerCheckRecAdd.Text = TxtClaimAddress.Text
        LblTellerCheckCorr.Text = TxtClaimCorrespondent.Text
        LblTellerCheckBranck.Text = TxtClaimBranch.Text
        LblTellerCheckRecAmount.Text = TxtClaimAmount.Text

        TxtClaimExpiryDate.Text = TxtExpirtyDate.Text
        TxtDateIssueClaim.Text = TxtIssueDate.Text

        TxtClaimAmount.Text = TxtAmount.Text
        Try
            TxtClaimExpiryDate.Text = Format(CDate(TxtClaimExpiryDate.Text), "dd-MMM-yyyy")
            TxtDateIssueClaim.Text = Format(CDate(TxtDateIssueClaim.Text), "dd-MMM-yyyy")
            TxtClaimAmount.Text = FormatNumber(TxtClaimAmount.Text, 2)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try






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

    Private Sub TxtMobile_TextChanged(sender As Object, e As EventArgs) Handles TxtMobile.Leave
        If TxtMobile.TextLength < 11 Then
            MessageBox.Show("Invalid Contact Number. This field only accepts cellphone number", "INVALID NUMBER", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtMobile.Clear()
            TxtMobile.Focus()
        End If
    End Sub

    Private Sub TxtClaimMobile_TextChanged(sender As Object, e As EventArgs) Handles TxtClaimMobile.Leave, TxtClaimMobile.TextChanged, TxtClaimMobile.KeyPress
        If TxtClaimMobile.TextLength < 11 Then
            MessageBox.Show("Invalid Contact Number. This field only accepts cellphone number", "INVALID NUMBER", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtClaimMobile.Clear()
            TxtClaimMobile.Focus()
        End If
    End Sub

    Private Sub BtnTellerLogout_Click(sender As Object, e As EventArgs) Handles BtnTellerLogout.Click
        Me.Close()
    End Sub
End Class