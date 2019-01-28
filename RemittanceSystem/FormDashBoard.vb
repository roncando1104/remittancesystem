Imports Oracle.ManagedDataAccess.Client
Imports Oracle.DataAccess.Client
Imports System.Drawing.Printing

Public Class FormDashBoard

    Dim OraDB As String = "Data Source= (DESCRIPTION =" _
           + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
           + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
           + "User Id=SYSTEM;Password=SYSTEM;"

    Private Sub BtnAddChart_Click(sender As Object, e As EventArgs) Handles BtnAddChart.Click
        Chart1.Series.Add("Remittance")
        Chart1.Series.Add("Charges")

        Chart4.Series.Add("Correspondent")
        Chart5.Series.Add("Status")



        Dim conn As New Oracle.DataAccess.Client.OracleConnection()
        conn.ConnectionString = OraDB

        conn.Open()

        Dim sql As String = "SELECT ISSUE_DATE, AMOUNT FROM REM_CUSTOMER"
        Dim cmd As New Oracle.DataAccess.Client.OracleCommand(sql, conn)
        Dim dr As Oracle.DataAccess.Client.OracleDataReader = cmd.ExecuteReader
        'cmd.CommandType = CommandType.Text

        While dr.Read
            Chart1.Series("Remittance").Points.AddXY(dr("ISSUE_DATE").ToString, dr("AMOUNT").ToString)
        End While
        dr.Close()
        cmd.Dispose()

        cmd = New Oracle.DataAccess.Client.OracleCommand("SELECT ISSUE_DATE, CHARGE FROM REM_CUSTOMER ", conn)
        dr = cmd.ExecuteReader
        While dr.Read
            Chart1.Series("Charges").Points.AddXY(dr("ISSUE_DATE").ToString, dr("CHARGE").ToString)
        End While

        cmd = New Oracle.DataAccess.Client.OracleCommand("SELECT AMOUNT_RECEIVED, CORRESPONDENT FROM REM_BENEFICIARIES ", conn)
        dr = cmd.ExecuteReader
        While dr.Read
            Chart4.Series("Correspondent").Points.AddXY(dr("CORRESPONDENT").ToString, dr("AMOUNT_RECEIVED").ToString)
        End While

        cmd = New Oracle.DataAccess.Client.OracleCommand("SELECT AMOUNT, STATUS FROM REM_STATUS ", conn)
        dr = cmd.ExecuteReader
        While dr.Read
            Chart5.Series("Status").Points.AddXY(dr("STATUS").ToString, dr("AMOUNT").ToString)
        End While


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        LabelDate.Text = Format(Now, "dddd, dd-MMM-yyyy hh:mm:ss tt")
        'Lbltime.TabIndex = Format(Now, "hh:mm:ss tt")
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Close()
    End Sub
End Class