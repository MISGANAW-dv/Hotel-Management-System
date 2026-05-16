Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class frmRegister
    ' እነዚህ ቫሪያብሎች ከሌላ ፎርም የሚመጡ ናቸው
    Public OpenedByAdmin As Boolean = False
    Public IsUpdate As Boolean = False
    Public TargetUserID As Integer = 0

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ፎርሙ ሲከፈት አድሚን ከሆነ የ Role ሳጥኑን አሳይ
        If OpenedByAdmin Then
            txtRole.Visible = True
        Else
            txtRole.Visible = False
            txtRole.Text = "Customer" ' ተራ ደንበኛ በዲፎልት Customer እንዲሆን
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' 1. Validation
        If txtPassword.Text <> txtConfirmPass.Text Then
            MsgBox("የይለፍ ቃሉ አይመሳሰልም!", MsgBoxStyle.Critical)
            Return
        End If

        If txtFirstName.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("እባክዎ አስፈላጊ መረጃዎችን ያስገቡ!", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim sql As String = ""
            If IsUpdate = False Then
                sql = "INSERT INTO Users (FirstName, LastName, Username, Password, Address, PhoneNumber, Role) " &
                      "VALUES (@fn, @ln, @un, @pw, @ad, @ph, @role)"
            Else
                sql = "UPDATE Users SET FirstName=@fn, LastName=@ln, Username=@un, Password=@pw, Address=@ad, PhoneNumber=@ph, Role=@role " &
                      "WHERE UserID=@id"
            End If

            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@fn", txtFirstName.Text.Trim())
            cmd.Parameters.AddWithValue("@ln", txtLastName.Text.Trim())
            cmd.Parameters.AddWithValue("@un", txtUsername.Text.Trim())
            cmd.Parameters.AddWithValue("@pw", txtPassword.Text)
            cmd.Parameters.AddWithValue("@ad", txtAddress.Text.Trim())
            cmd.Parameters.AddWithValue("@ph", txtPhone.Text.Trim())

            ' Role አያያዝ
            If IsUpdate Then
                cmd.Parameters.AddWithValue("@role", txtRole.Text.Trim())
                cmd.Parameters.AddWithValue("@id", TargetUserID)
            Else
                ' አዲስ ምዝገባ ከሆነ - አድሚኑ ከከፈተው Staff፣ ደንበኛው ከሆነ Customer
                Dim defaultRole As String = If(OpenedByAdmin, "Staff", "Customer")
                cmd.Parameters.AddWithValue("@role", defaultRole)
            End If

            cmd.ExecuteNonQuery()
            conn.Close()

            ' --- ከምዝገባ በኋላ የሚከናወን ተግባር ---
            If IsUpdate Then
                MsgBox("መረጃው በተሳካ ሁኔታ ተስተካክሏል!", MsgBoxStyle.Information)
                Me.Close() ' አፕዴት ከሆነ ገጹ ይዘጋል
            Else
                MsgBox("ምዝገባው በተሳካ ሁኔታ ተጠናቋል!", MsgBoxStyle.Information)

                If OpenedByAdmin Then
                    ' አድሚን ከሆነ ሌላ ሰው መመዝገብ እንዲችል ገጹ አይዘጋም፣ ሳጥኖቹ ብቻ ይጸዳሉ
                    ClearRegistrationForm()
                Else
                    ' ተራ ደንበኛ ከሆነ ግን በቀጥታ ወደ Login ይወሰዳል
                    frmLogin.Show()
                    Me.Close()
                End If
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' ሁሉንም መረጃ ማጽጃ
    Public Sub ClearRegistrationForm()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtConfirmPass.Clear()
        txtAddress.Clear()
        txtPhone.Clear()
        txtRole.Clear()

        ' አፕዴት የነበረውን ወደ መደበኛ ምዝገባ መመለስ
        IsUpdate = False
        btnRegister.Text = "Register"

        If Not OpenedByAdmin Then txtRole.Text = "Customer"
        txtFirstName.Focus()
    End Sub

    ' ወደ ኋላ መመለሻ
    Private Sub btnBackToLogin_Click(sender As Object, e As EventArgs) Handles btnBackToLogin.Click
        If OpenedByAdmin Then
            Me.Close() ' አድሚኑ ከነበረ ወደ ዳሽቦርድ ይመለሳል
        Else
            frmLogin.Show()
            Me.Close()
        End If
    End Sub

    ' ገጹ ሲዘጋ ወይም ሲደበቅ ዳታው እንዲጠፋ
    Private Sub frmRegister_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = False Then
            ' አድሚኑ አፕዴት አድርጎ ሲመለስ ወይም ደንበኛው ገጹን ሲዘጋው ዳታው ይጸዳል
            ClearRegistrationForm()
        End If
    End Sub
End Class