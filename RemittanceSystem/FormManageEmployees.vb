Imports Oracle.ManagedDataAccess.Client
Imports Oracle.DataAccess.Client

Public Class FormManageEmployees
    Private SqlDelete As String

    Private Sub BtnManageEmpSearch_Click(sender As Object, e As EventArgs) Handles BtnManageEmpSearch.Click

        If TxtManageEmpID.Text = "" Then
            MessageBox.Show("Enter Employee ID to search for information", "EMPLOYEE MANAGEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            SearchEmployeeInfo()
            TxtManageEmpID.Enabled = False
        End If

    End Sub

    Private Sub BtnManageDeleteEmployee_Click(sender As System.Object, e As System.EventArgs) Handles BtnManageDeleteEmployee.Click

        If TxtManageEmpID.Text = "" Then
            MessageBox.Show("Please enter an Employee ID", "DELETE EMPLOYEE", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            DeleteEmployee()
            TxtManageEmpID.Clear()
            TxtManageFName.Clear()
            TxtManageLName.Clear()
            TxtManagePosition.Clear()
        End If

    End Sub

    Private Sub BtnManageUpdateEmp_Click(sender As Object, e As EventArgs) Handles BtnManageUpdateEmp.Click

        If TxtManageEmpID.Text = "" Then
            MessageBox.Show("Please enter an Employee ID", "DELETE EMPLOYEE", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Record has been updated successfully", "UPDATE EMPLOYEE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UpdateEmployee()
            TxtManageEmpID.Clear()
            TxtManageFName.Clear()
            TxtManageLName.Clear()
            TxtManagePosition.Clear()
        End If

    End Sub

    Private Sub UpdateEmployee()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
     + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
     + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
     + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()
        conn.ConnectionString = OraDB

        conn.Open()
        Dim strChangeStat As String
        strChangeStat = "UPDATE REM_EMPLOYEE SET FIRST_NAME = '" & TxtManageFName.Text & "', " & "LAST_NAME = '" & TxtManageLName.Text & "', " & "EMP_ROLE = '" & TxtManagePosition.Text & "' WHERE EMPLOYEE_ID = '" & TxtManageEmpID.Text & "'"

        Dim cmd As Oracle.DataAccess.Client.OracleCommand = New Oracle.DataAccess.Client.OracleCommand(strChangeStat, conn)

        cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("FIRST_NAME", TxtManageFName.Text))
        cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("LAST_NAME", TxtManageLName.Text))
        cmd.Parameters.Add(New Oracle.DataAccess.Client.OracleParameter("EMP_ROLE", TxtManagePosition.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'delete emp info
    Public Sub DeleteEmployee()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
      + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
      + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
      + "User Id=SYSTEM;Password=SYSTEM;"


        Dim conn As New Oracle.DataAccess.Client.OracleConnection()

        conn.ConnectionString = OraDB

        conn.Open()

        Try

            If MessageBox.Show("Do you really want to delete this record?", "Delete",
                               MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.No Then

                MessageBox.Show("Operation cancelled")
                Exit Sub
            ElseIf TxtManageEmpID.Text <> "" Then
                SqlDelete = "DELETE  FROM REM_EMPLOYEE WHERE EMPLOYEE_ID = '" & TxtManageEmpID.Text & "'"

                Dim cmd As Oracle.DataAccess.Client.OracleCommand = New Oracle.DataAccess.Client.OracleCommand(SqlDelete, conn)

                Try
                    cmd.CommandText = SqlDelete
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    conn.Close()
                    MessageBox.Show("Delete Successful")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    'SEARCH EMPLOYEE
    Public Sub SearchEmployeeInfo()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
    + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
    + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
    + "User Id=SYSTEM;Password=SYSTEM;"

        Dim dr As Oracle.DataAccess.Client.OracleDataReader
        Dim strClaim As String
        strClaim = "SELECT * FROM REM_EMPLOYEE WHERE (EMPLOYEE_ID = '" & TxtManageEmpID.Text & "')"

        Dim conn As New Oracle.DataAccess.Client.OracleConnection()

        conn.ConnectionString = OraDB

        Dim cmd As Oracle.DataAccess.Client.OracleCommand = New Oracle.DataAccess.Client.OracleCommand(strClaim, conn)

        conn.Open()

        dr = cmd.ExecuteReader

        Try

            While dr.Read


                TxtManageFName.Text = dr("FIRST_NAME").ToString
                TxtManageLName.Text = dr("LAST_NAME").ToString
                TxtManagePosition.Text = dr("EMP_ROLE").ToString


            End While

            'TxtClaimAmount.Text = Format(C(TxtDateIssueClaim.Text), "dd-MMM-yyyy")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()

    End Sub
End Class