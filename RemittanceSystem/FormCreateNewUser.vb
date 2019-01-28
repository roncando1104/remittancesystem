Imports Oracle.ManagedDataAccess.Client

Public Class FormCreateNewUser

    Public dr As OracleDataReader
    Private StrengthWords() As String = {"Very Very Weak", "Very Weak", "Weak", "Better", "Medium", "Strong", "Strongest"}

    Private Sub FormCreateNewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
           + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
           + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
           + "User Id=SYSTEM;Password=SYSTEM;"
        Dim conn As New OracleConnection()
        conn.ConnectionString = OraDB

        conn.Open()
        Dim sqlView As String = "SELECT * FROM REM_EMPLOYEE" 'WHERE [EMPLOYEE_ID] = 1-0001"
        'Dim sqlView As String = "SELECT TOP 1 * FROM REM_EMPLOYEE ORDER BY EMPLOYEE_ID DESC"
        'WHERE [EMPLOYEE_ID] = 1-0001"
        Dim cmd As New OracleCommand(sqlView, conn)
        'cmd.CommandType = CommandType.Text
        dr = cmd.ExecuteReader
        While dr.Read()
            TxtLastID.Text = dr("EMPLOYEE_ID").ToString
        End While
        conn.Close()


    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click

        TxtEmpID.Clear()
        TxtUserName.Clear()
        TxtPassword.Clear()
        TxtReEnterPW.Clear()
        TxtFName.Clear()
        TxtLName.Clear()

    End Sub

    Private Sub LinkLogOut_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLogOut.LinkClicked
        Me.Hide()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        If TxtPassword.Text <> TxtReEnterPW.Text Then
            MessageBox.Show("Password Mismatch", "ERROR PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtReEnterPW.Text = ""
            TxtReEnterPW.Text = vbNormalFocus
            Exit Sub

        ElseIf TxtPassword.Text = TxtPassword.Text Then
            MessageBox.Show("New user has been successfully created",
                            "ACCOUNT CREATED", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'getting the function of inserting row
            InsertRowData()
        End If

    End Sub
    'function for inserting row
    Public Sub InsertRowData()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
         + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
         + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
         + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New OracleConnection()
        Dim transaction As OracleTransaction
        'Dim cmd As OracleCommand = conn.CreateCommand()
        conn.ConnectionString = OraDB

        conn.Open()
        Try
            Using cmd As OracleCommand = New OracleCommand(OraDB, conn)
                'Start a local transaction
                transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
                'Assign transaction object for a pending local transaction
                cmd.Transaction = transaction
                Const sqlInsert As String = "INSERT INTO REM_EMPLOYEE VALUES (:var1, :var2, :var3, :var4, :var5, :var6)"

                cmd.Parameters.Add(New OracleParameter("var1", TxtEmpID.Text))
                cmd.Parameters.Add(New OracleParameter("var2", TxtFName.Text))
                cmd.Parameters.Add(New OracleParameter("var3", TxtLName.Text))
                cmd.Parameters.Add(New OracleParameter("var4", TxtRole.Text))
                cmd.Parameters.Add(New OracleParameter("var5", TxtUserName.Text))
                cmd.Parameters.Add(New OracleParameter("var6", TxtPassword.Text))
                cmd.CommandText = sqlInsert
                cmd.ExecuteNonQuery()
                transaction.Commit()

                cmd.Dispose()
                conn.Close()
                TxtEmpID.Clear()
                TxtFName.Clear()
                TxtLName.Clear()
                TxtUserName.Clear()
                TxtPassword.Clear()
                TxtReEnterPW.Clear()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub CboShowPW_CheckedChanged(sender As Object, e As EventArgs) Handles CboShowPW.CheckedChanged
        TxtPassword.UseSystemPasswordChar = Not CboShowPW.Checked
        TxtReEnterPW.UseSystemPasswordChar = Not CboShowPW.Checked
    End Sub

    Sub CalculateMeter()

        Dim score As Integer
        Dim password As String = TxtPassword.Text
        If (password.Length > 6) Then score += 1
        If System.Text.RegularExpressions.Regex.IsMatch(password, "[a-z]") And
            System.Text.RegularExpressions.Regex.IsMatch(password, "[A-Z]") Then
            score += 1
        End If

        If System.Text.RegularExpressions.Regex.IsMatch(password, "\d+") Then
            score += 1
        End If

        If System.Text.RegularExpressions.Regex.IsMatch(password, "[!,@,#,$,%,^,&,*,?,_,~,-,/""]") Then
            score += 1
        End If

        If (password.Length >= 6) Then score += 1
        If (password.Length > 7) Then score += 1
        PassProgressBar.Value = score / 6 * 100
        LblPWProgress.Width = 50 * score
        LblPWProgress.Text = StrengthWords(score)
        LblPWProgress.TextAlign = ContentAlignment.MiddleCenter
        'lblProgressBar.BackColor = GetColor(score)
        LblPWProgress.ForeColor = GetColor(score)

    End Sub

    Private Function GetColor(ByVal score As Integer) As Color
        Select Case score

            Case 0
                Return Color.Red
            Case 1
                Return Color.Red
            Case 2
                Return Color.Purple
            Case 3
                Return Color.LightGreen
            Case 4
                Return Color.MediumSeaGreen
            Case 5
                Return Color.Green
            Case 6
                Return Color.DarkGreen

        End Select
    End Function

    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged
        CalculateMeter()
    End Sub

    Private Sub TxtFName_Leave(sender As Object, e As EventArgs) Handles TxtFName.Leave

        If (TxtFName.Text <> "") Then

            Dim userInput As String = TxtFName.Text

            If Not (ValidString(userInput) = True) Then
                TxtFName.Clear()
                TxtFName.Focus()
                MessageBox.Show("Invalid character, letters only", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub
    'function for letter only validation, copy to all textbox that needs same validation
    Function ValidString(input As String)

        Dim userInput As String = input
        Dim filteredUserInput As String = userInput

        Dim listOfLetters As String() = New String() _
            {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O",
           "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f",
           "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v",
           "w", "x", "y", "z"}

        For Each letter In listOfLetters
            filteredUserInput = Replace(filteredUserInput, letter, "")

        Next

        If (filteredUserInput <> "") Then
            Return False
        Else
            Return True
        End If

    End Function

    'check if the username input already exists
    Private Sub AccountUserNameValidation()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
           + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
           + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
           + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New OracleConnection()
        conn.ConnectionString = OraDB
        Dim sqlBlock As String = ("SELECT * FROM REM_EMPLOYEE WHERE USERNAME = '" & TxtUserName.Text & "'")
        Dim cmd As New OracleCommand(sqlBlock, conn)


        conn.Open()

        Dim reader As OracleDataReader = cmd.ExecuteReader

        If reader.HasRows Then
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sqlBlock
            cmd.ExecuteNonQuery()
            reader.Read()

            If reader("USERNAME") = TxtUserName.Text Then

                MessageBox.Show("Username already exist. Please use another one", "ACCOUNT SECURITY", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtUserName.Clear()
                TxtUserName.Focus()

            End If
        End If


    End Sub

    Private Sub TxtUserName_Leave(sender As Object, e As EventArgs) Handles TxtUserName.Leave
        AccountUserNameValidation()

    End Sub
End Class