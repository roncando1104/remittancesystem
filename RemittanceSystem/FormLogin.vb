﻿Imports Oracle.DataAccess.Client
'Imports Oracle.DataAccess.Client.OracleDataReader

Public Class FormLogin

    'Login data
    Public Sub LoginData()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
            + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
            + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
            + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New OracleConnection()
        conn.ConnectionString = OraDB
        Dim sqlLogin As String = ("SELECT * FROM REM_EMPLOYEE WHERE USERNAME = '" & TxtUsername.Text & "' AND PASSWORD = '" & TxtPassword.Text & "'")
        Dim cmd As New OracleCommand(sqlLogin, conn)
        Static trial As Byte
        Dim answer As Integer
        Dim retry As Integer

        conn.Open()

        Dim reader As OracleDataReader = cmd.ExecuteReader

        If TxtUsername.Text = "" And TxtPassword.Text = "" Then

            retry = MessageBox.Show("Please input username and password", "INVALID CREDENTIALS", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question)
            If retry = DialogResult.Retry Then
                TxtUsername.Focus()
            Else
                Close()
            End If

        Else

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sqlLogin
            cmd.ExecuteNonQuery()
            reader.Read()

            If reader.HasRows Then

                If reader("EMP_ROLE") = "ADMIN" Then

                    'FormCreateNewUser.Show()
                    FormTransaction.Show()
                    FormTransaction.LblUserName.Text = reader("FIRST_NAME")
                    FormTransaction.LblEmpID.Text = reader("EMPLOYEE_ID")
                    Me.Hide()

                ElseIf reader("EMP_ROLE") = "TELLER" Then
                    FormTeller.Show()
                    FormTeller.LblTellerUserID.Text = reader("FIRST_NAME")
                    FormTeller.LblTellerEmpID.Text = reader("EMPLOYEE_ID")
                    Me.Hide()

                ElseIf reader("EMP_ROLE") = "MANAGER" Then
                    FormManager.Show()
                    FormManager.LblUserName.Text = reader("FIRST_NAME")
                    FormManager.LblEmpID.Text = reader("EMPLOYEE_ID")
                    Me.Hide()
                    ' ElseIf reader("PASSWORD") = "error123E" Then

                    'MessageBox.Show("Your account has been blocked. Please call your admin to reset the password", "ACCOUNT SECURITY", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'TxtUsername.Clear()
                End If

            ElseIf trial = 2 Then

                MessageBox.Show("Your accout has been blocked.  Please call admin to reset your password", "Password Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                cmd.CommandText = "UPDATE REM_EMPLOYEE SET PASSWORD = 'error123E' WHERE USERNAME = '" & TxtUsername.Text & "'"
                cmd.ExecuteNonQuery()
                Close()

            Else
                answer = MessageBox.Show("Invalid username or password, Try Again?", "Password Entry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question)
                If answer = DialogResult.Retry Then
                    trial = trial + 1
                    TxtPassword.Text = ""
                    TxtPassword.Focus()
                Else
                    Close()

                End If

            End If

        End If

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        'If TxtUsername.Text = "admin" AndAlso TxtPassword.Text = "admin" Then
        'MessageBox.Show("You have successfully logged in", "LOGIN INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'FormCreateNewUser.Show()
        'Me.Hide()
        'Else
        LoginData()

        'End If
    End Sub

    Private Sub AccountBlockValidation()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
           + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
           + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
           + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New OracleConnection()
        conn.ConnectionString = OraDB
        Dim sqlBlock As String = "SELECT PASSWORD FROM REM_EMPLOYEE WHERE USERNAME = '" & TxtUsername.Text & "'"
        Dim cmd As New OracleCommand(sqlBlock, conn)


        conn.Open()

        Dim reader As OracleDataReader = cmd.ExecuteReader

        If reader.HasRows Then
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sqlBlock
            cmd.ExecuteNonQuery()
            reader.Read()

            If reader("PASSWORD") = "error123E" Then

                MessageBox.Show("Your account has been blocked. Please call your admin to reset the password", "ACCOUNT SECURITY", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtUsername.Clear()

                End

            End If
        End If


    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DisplayData()

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        End
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim x As Integer = 115

        Panel1.BackColor = Color.FromArgb(x, Color.Black)

    End Sub

    Private Sub BtnShowPW_MouseHover(sender As Object, e As EventArgs) Handles BtnShowPW.MouseHover
        TxtPassword.UseSystemPasswordChar = False
    End Sub

    Private Sub BtnShowPW_MouseLeave(sender As Object, e As EventArgs) Handles BtnShowPW.MouseLeave
        TxtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub TxtUsername_Leave(sender As Object, e As EventArgs) Handles TxtUsername.Leave
        AccountBlockValidation()
    End Sub
End Class
