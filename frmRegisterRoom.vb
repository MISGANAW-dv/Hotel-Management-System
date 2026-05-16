Imports System.Data.SqlClient

Public Class frmRegisterRoom
    ' ለ Update ስራ የሚያስፈልጉ ተለዋዋጮች
    Public IsUpdate As Boolean = False
    Public TargetRoomID As Integer = 0

    ' 1. ፎርሙ ሲከፈት የሚሰሩ ስራዎች
    Private Sub frmRegisterRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' አዲስ ምዝገባ ከሆነ ብቻ Available በዲፎልት እንዲመረጥ
        If IsUpdate = False Then
            If cmbStatus.Items.Count > 0 Then
                cmbStatus.SelectedIndex = 0
            End If
            Me.Text = "Register New Room"
            btnSave.Text = "Save Room"
        Else
            ' ለማስተካከያ ከሆነ የፎርሙን ርዕስ ቀይረው
            Me.Text = "Update Room Information"
            btnSave.Text = "Update Information"
        End If
    End Sub

    ' 2. መረጃን የመመዝገብ ወይም የማስተካከል ተግባር
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' ባዶ ቦታ አለመኖሩን ማረጋገጥ
        If txtRoomNumber.Text = "" Or txtPrice.Text = "" Or cmbRoomType.Text = "" Then
            MsgBox("እባክዎ ሁሉንም መረጃዎች በትክክል ያስገቡ!", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim sql As String = ""

            ' እንደ ሁኔታው (Update ወይም Insert) SQL መቀየር
            If IsUpdate = False Then
                ' አዲስ ምዝገባ
                sql = "INSERT INTO Rooms (RoomNumber, RoomType, PricePerNight, Status) VALUES (@rNum, @rType, @price, @status)"
            Else
                ' ማስተካከያ
                sql = "UPDATE Rooms SET RoomNumber=@rNum, RoomType=@rType, PricePerNight=@price, Status=@status WHERE RoomID=@id"
            End If

            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@rNum", txtRoomNumber.Text.Trim())
            cmd.Parameters.AddWithValue("@rType", cmbRoomType.Text)
            cmd.Parameters.AddWithValue("@price", Decimal.Parse(txtPrice.Text))
            cmd.Parameters.AddWithValue("@status", cmbStatus.Text)

            ' ለማስተካከያ ከሆነ ID መጨመር አለበት
            If IsUpdate Then
                cmd.Parameters.AddWithValue("@id", TargetRoomID)
            End If

            cmd.ExecuteNonQuery()

            ' መልዕክት ማሳየት
            If IsUpdate Then
                MsgBox("መረጃው በተሳካ ሁኔታ ተስተካክሏል!", MsgBoxStyle.Information)
                ' ስራው ሲያልቅ ወደ View ገጽ እንዲመለስ እና ዝርዝሩን እንዲያድስ
                frmViewRooms.LoadAllRooms()
                Me.Close()
            Else
                MsgBox("ክፍሉ በተሳካ ሁኔታ ተመዝግቧል!", MsgBoxStyle.Information)
                ClearFields() ' አዲስ ከተመዘገበ ፎርሙን ብቻ አጽዳ
            End If

            conn.Close()
        Catch ex As Exception
            MsgBox("ስህተት፦ " & ex.Message, MsgBoxStyle.Critical)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
        frmAdminDashboard.Show()
        Me.Hide()

    End Sub

    ' 3. ፎርሙን ለማጽዳት የሚያገለግል (ለአዲስ ምዝገባ ብቻ)
    Private Sub ClearFields()
        txtRoomNumber.Clear()
        txtPrice.Clear()
        If cmbRoomType.Items.Count > 0 Then cmbRoomType.SelectedIndex = -1
        If cmbStatus.Items.Count > 0 Then cmbStatus.SelectedIndex = 0
        txtRoomNumber.Focus()
    End Sub

    ' 4. ወደ ኋላ መመለሻ
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If IsUpdate Then
            frmAdminDashboard.Show()
            Me.Close() ' ለማስተካከያ ከሆነ ዝም ብሎ ይዘጋ
        Else
            frmAdminDashboard.Show()
            Me.Hide()
        End If
    End Sub
End Class