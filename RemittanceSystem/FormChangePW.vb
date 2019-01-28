Imports Oracle.ManagedDataAccess.Client


Public Class FormChangePW

    Public dr As OracleDataReader
    Private StrengthWords() As String = {"Very Very Weak", "Very Weak", "Weak", "Better", "Medium", "Strong", "Strongest"}

    Private Sub BtnUpdatePW_Click(sender As Object, e As EventArgs) Handles BtnUpdatePW.Click

        If TxtUpdatorNewPW.Text <> TxtUpdatorRetypePW.Text Then

            MessageBox.Show("Password mismatch. ", "Password Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtUpdatorRetypePW.Clear()
            TxtUpdatorRetypePW.Focus()
        Else
            UpdatePassword()
        End If

    End Sub

    Private Sub TxtUpdatorNewPW_TextChanged(sender As Object, e As EventArgs) Handles TxtUpdatorNewPW.TextChanged
        CalculateMeter()
    End Sub

    Private Sub UpdatePassword()

        Dim OraDB As String = "Data Source= (DESCRIPTION =" _
            + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
            + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
            + "User Id=SYSTEM;Password=SYSTEM;"

        Dim conn As New OracleConnection()
        conn.ConnectionString = OraDB
        Dim sqlUpdate As String = ("UPDATE REM_EMPLOYEE SET PASSWORD = '" & TxtUpdatorRetypePW.Text & "' WHERE EMPLOYEE_ID = '" & TxtUpdatePWempID.Text & "'")
        Dim cmd As New OracleCommand(sqlUpdate, conn)

        conn.Open()

        cmd.CommandText = sqlUpdate
        cmd.ExecuteNonQuery()
        MessageBox.Show("Password has been successfully updated. ", "Password Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Sub CalculateMeter()

        Dim score As Integer
        Dim password As String = TxtUpdatorNewPW.Text
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
        ProgressBarChangePW.Value = score / 6 * 100
        LabelProgressChangePW.Width = 50 * score
        LabelProgressChangePW.Text = StrengthWords(score)
        LabelProgressChangePW.TextAlign = ContentAlignment.MiddleCenter
        'lblProgressBar.BackColor = GetColor(score)
        LabelProgressChangePW.ForeColor = GetColor(score)

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

    Private Sub CboViewPW_CheckedChanged(sender As Object, e As EventArgs) Handles CboViewPW.CheckedChanged
        TxtUpdatorNewPW.UseSystemPasswordChar = Not CboViewPW.Checked
        TxtUpdatorRetypePW.UseSystemPasswordChar = Not CboViewPW.Checked
    End Sub

    Private Sub BtnCloseUpdate_Click(sender As Object, e As EventArgs) Handles BtnCloseUpdate.Click
        Close()
        End
    End Sub
End Class