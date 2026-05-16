Imports System.Data.SqlClient

Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' 1. ባዶ መሆናቸውን ማረጋገጥ
        If String.IsNullOrWhiteSpace(txtUser.Text) Or String.IsNullOrWhiteSpace(txtPass.Text) Then
            MsgBox("እባክዎ ዩዘርኔም እና ፓስወርድ ያስገቡ!", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' 2. መረጃ መፈለግ
            Dim sql As String = "SELECT FirstName, LastName, Role FROM Users WHERE Username=@un AND Password=@pw"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@un", txtUser.Text.Trim())
            cmd.Parameters.AddWithValue("@pw", txtPass.Text.Trim())

            Dim adp As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adp.Fill(dt)

            ' 3. ተጠቃሚው ከተገኘ
            If dt.Rows.Count > 0 Then
                ' መረጃዎቹን በ Module ቫሪያብሎች ላይ መጫን
                loggedInUser = txtUser.Text.Trim()
                UserFirstName = dt.Rows(0)("FirstName").ToString()
                UserLastName = dt.Rows(0)("LastName").ToString()

                ' Role-ን እዚህ ጋር ዲክሌር እናድርገው (ይህ image_77c298.jpg ላይ ያለውን ስህተት ያጠፋል)
                Dim userRole As String = dt.Rows(0)("Role").ToString()

                ' በትክክለኛው ቫሪያብል (UserFirstName) ሰላምታ መስጠት
                MsgBox("እንኳን ደህና መጡ " & UserFirstName & "!", MsgBoxStyle.Information)

                ' 4. እንደ ስልጣኑ (Role) መለየት
                If userRole = "Admin" Then
                    frmAdminDashboard.Show()
                    Me.Hide()
                ElseIf userRole = "Customer" Then
                    frmCustomerDashboard.Show()
                    Me.Hide()
                Else
                    MsgBox("የተሰጥዎት ስልጣን በሲስተሙ አይታወቅም!", MsgBoxStyle.Critical)
                End If
            Else
                ' መረጃው ካልተገኘ
                MsgBox("የተሳሳተ ዩዘርኔም ወይም ፓስወርድ!", MsgBoxStyle.Critical)
                txtPass.Clear()
                txtUser.Focus()
            End If

            conn.Close()
        Catch ex As Exception
            MsgBox("ስህተት፦ " & ex.Message, MsgBoxStyle.Critical)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub btnGoRegister_Click(sender As Object, e As EventArgs) Handles btnGoRegister.Click
        frmRegister.Show()
        Me.Hide()
    End Sub

    Private Sub frmLogin_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        ' ገጹ ተመልሶ ሲታይ (Visible ሲሆን) መረጃዎችን ያጠፋል
        If Me.Visible = True Then
            txtUser.Clear()
            txtPass.Clear()
            txtUser.Focus() ' የመጻፊያ ምልክቷን ዩዘርኔም ላይ ያደርጋል
        End If
    End Sub
End Class