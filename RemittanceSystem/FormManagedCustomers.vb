Imports Oracle.ManagedDataAccess.Client
Imports Oracle.DataAccess.Client
Imports System.Drawing.Printing

Public Class FormManagedCustomers


    Private Sub ViewAllSpecificCustomerTransaction()




        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
        + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
        + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
        + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()
        conn.ConnectionString = OraDB
        'Dim sql As String = "SELECT * FROM REM_STATUS WHERE EMPLOYEE_ID = '" & LblTellerEmpID.Text & "' AND ISSUE_DATE = '" & LblTellerDate.Text & "'"
        Dim sql As String = "SELECT T1.REFERENCE_NUMBER, T1.NAME, T1.ID_TYPE, T1.MOBILE_NUMBER, T1.PURPOSE, T1.RELATIONSHIP_TO_THE_RECEIVER, T1.ADDRESS, T1.ISSUE_DATE, T1.ISSUE_PLACE, T1.EXPIRY_DATE, T1.AMOUNT, T1.CHARGE, T1.TOTAL_AMOUNT, T2.EMPLOYEE_ID, T2.STATUS, T3.NAME, T3.ID_TYPE, T3.MOBILE_NUMBER, T3.ADDRESS, T3.RELATIONSHIP_TO_THE_SENDER, T3.CORRESPONDENT, T3.BRANCH_ADDRESS, T3.AMOUNT_RECEIVED FROM REM_CUSTOMER T1 INNER JOIN REM_STATUS T2 ON T1.REFERENCE_NUMBER = T2.REFERENCE_NUMBER INNER JOIN REM_BENEFICIARIES T3 ON T3.REFERENCE_NUMBER = T2.REFERENCE_NUMBER WHERE T1.NAME = '" & TvCustomerName.Text & "'"
        Dim cmd As New Oracle.DataAccess.Client.OracleCommand(sql, conn)
        cmd.CommandType = CommandType.Text

        conn.Open()

        Dim dt As New DataTable("REM_STATUS")
        Dim rs As New Oracle.DataAccess.Client.OracleDataAdapter(cmd)
        rs.Fill(dt)
        dgvSpecificCustomerTransactions.DataSource = dt
        dgvSpecificCustomerTransactions.Refresh()

        'LblCount.Text = dt.Rows.Count
        rs.Dispose()
        conn.Close()



    End Sub

    Private Sub DeleteSpecificCustomerRecords()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
      + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
      + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
      + "User Id=SYSTEM;Password=SYSTEM;"


        Dim conn As New Oracle.DataAccess.Client.OracleConnection()

        conn.ConnectionString = OraDB

        conn.Open()

        Try

            Dim SqlDelete As String

            Dim SqlDelete2 As String

            Dim sQLDelete3 As String

            If MessageBox.Show("Do you really want to delete this records? All data will be lost about this customer.", "CUSTOMER RECORD MANAGEMENT",
                               MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.No Then

                MessageBox.Show("Operation cancelled")
                Exit Sub
            ElseIf TvCustomerName.Text <> "" Then
                SqlDelete = "DELETER FROM REM_CUSTOMER WHERE REFERENCE_NUMBER = '" & TxtRefNumber.Text & "'"
                SqlDelete2 = "DELETER FROM REM_BENEFICIARIES WHERE REFERENCE_NUMBER = '" & TxtRefNumber.Text & "'"
                sQLDelete3 = "DELETER FROM REM_STATUS WHERE REFERENCE_NUMBER = '" & TxtRefNumber.Text & "'"
                '"DELETE FROM REM_CUSTOMER T1 INNER JOIN REM_BENEFICIARIES T2 ON T2.REFERENCE_NUMBER = T1.REFERENCE_NUMBER INNER JOIN REM_STATUS T3 ON T3.REFERENCE_NUMBER = T1.REFERENCE_NUMBER WHERE T1.NAME = '" & TvCustomerName.Text & "'"

                Dim cmd As Oracle.DataAccess.Client.OracleCommand = New Oracle.DataAccess.Client.OracleCommand(SqlDelete, conn)
                Dim cmd2 As Oracle.DataAccess.Client.OracleCommand = New Oracle.DataAccess.Client.OracleCommand(SqlDelete2, conn)
                Dim cmd3 As Oracle.DataAccess.Client.OracleCommand = New Oracle.DataAccess.Client.OracleCommand(sQLDelete3, conn)

                Try
                    cmd.CommandText = SqlDelete
                    cmd2.CommandText = SqlDelete2
                    cmd3.CommandText = sQLDelete3
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    conn.Close()
                    MessageBox.Show("Records has been deleted successfully", "Customer Record Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub


    Private Sub BtnFindCustName_Click(sender As Object, e As EventArgs) Handles BtnFindCustName.Click

        If TvCustomerName.Text = "" Then
            MessageBox.Show("Enter name to search records.", "CUSTOMER RECORD MANAGEMENT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            ViewAllSpecificCustomerTransaction()
        End If

    End Sub

    Private Sub BtnDeleteSpecificCustRecords_Click(sender As Object, e As EventArgs) Handles BtnDeleteSpecificCustRecords.Click

        If TvCustomerName.Text = "" Then

            MessageBox.Show("Enter name of customer to delete.", "CUSTOMER RECORD MANAGEMENT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            DeleteSpecificCustomerRecords()
        End If

    End Sub
End Class