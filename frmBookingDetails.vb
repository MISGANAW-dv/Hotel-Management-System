Imports System.Data.SqlClient
Imports System.IO

Public Class frmBookingDetails
    ' ከቀደመው ፎርም የሚመጡ መረጃዎች
    Public TargetRoomID As Integer
    Public RoomPrice As Decimal

    Private Sub frmBookingDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. የክፍያ አማራጮችን መሙላት
        cmbPaymentMethod.Items.Clear()
        cmbPaymentMethod.Items.AddRange(New String() {"Telebirr", "CBE Birr", "CBE Bank"})

        ' 2. ቀኖቹን አስተካክል (ከዛሬ በፊት መምረጥ አይቻልም)
        dtpCheckIn.MinDate = DateTime.Now
        dtpCheckOut.MinDate = DateTime.Now.AddDays(1)

        ' 3. የመጀመሪያ ምርጫ
        If cmbPaymentMethod.Items.Count > 0 Then cmbPaymentMethod.SelectedIndex = 0

        CalculateTotal()
    End Sub

    ' የቆይታ ቀናትን እና ሂሳብን ለማስላት
    Private Sub CalculateTotal() Handles dtpCheckIn.ValueChanged, dtpCheckOut.ValueChanged
        ' የመውጫ ቀን ከመግቢያ ቀን ማነስ የለበትም (Validation)
        If dtpCheckOut.Value.Date <= dtpCheckIn.Value.Date Then
            dtpCheckOut.Value = dtpCheckIn.Value.AddDays(1)
        End If

        Dim duration As TimeSpan = dtpCheckOut.Value.Date - dtpCheckIn.Value.Date
        Dim days As Integer = duration.Days

        ' ቢያንስ 1 ቀን ተብሎ እንዲታሰብ
        If days <= 0 Then days = 1

        Dim totalAmount As Decimal = days * RoomPrice

        ' ውጤቱን በሌብል ላይ ማሳየት (ስሙ Label6 ከሆነ)
        Label6.Text = "Total Amount: " & totalAmount.ToString("N2") & " ETB"
    End Sub

    ' የክፍያ ምርጫ ሲቀየር አካውንት የሚያሳይ
    Private Sub cmbPaymentMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPaymentMethod.SelectedIndexChanged
        Select Case cmbPaymentMethod.Text
            Case "Telebirr"
                lblAccountDetails.Text = "Send to Telebirr: 0911223344 (Hotel Name)"
            Case "CBE Birr"
                lblAccountDetails.Text = "Send to CBE Birr: 0911223344"
            Case "CBE Bank"
                lblAccountDetails.Text = "CBE Account: 1000123456789 (Main Branch)"
        End Select
    End Sub

    ' ፎቶ ለመጫን (Upload Receipt)
    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim opf As New OpenFileDialog()
        opf.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        If opf.ShowDialog() = DialogResult.OK Then
            picReceipt.Image = Image.FromFile(opf.FileName)
            picReceipt.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    ' ፎቶውን ወደ Byte Array መቀየር (ለዳታቤዝ)
    Private Function ImageToByteArray(ByVal img As Image) As Byte()
        Using ms As New MemoryStream()
            img.Save(ms, img.RawFormat)
            Return ms.ToArray()
        End Using
    End Function

    ' ዳታቤዝ ላይ ሴቭ ለማድረግ (Confirm)
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        ' 1. የደረሰኝ ፎቶ መጫኑን ቼክ ማድረግ
        If picReceipt.Image Is Nothing Then
            MsgBox("እባክዎ መጀመሪያ የደረሰኝዎን ፎቶ (Receipt Image) ይጫኑ!", MsgBoxStyle.Critical)
            Return
        End If

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' 2. ቡኪንጉን መመዝገብ (ReceiptImage ተጨምሯል፣ BookingDate በራሱ ይሞላል)
            Dim sql As String = "INSERT INTO Bookings (Username, RoomID, CheckInDate, CheckOutDate, TotalAmount, PaymentStatus, ReceiptImage) " &
                               "VALUES (@user, @rid, @in, @out, @total, 'Pending', @img)"

            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@user", loggedInUser)
            cmd.Parameters.AddWithValue("@rid", TargetRoomID)
            cmd.Parameters.AddWithValue("@in", dtpCheckIn.Value.Date)
            cmd.Parameters.AddWithValue("@out", dtpCheckOut.Value.Date)

            ' የቆይታ ቀናት ስሌት
            Dim days As Integer = (dtpCheckOut.Value.Date - dtpCheckIn.Value.Date).Days
            If days <= 0 Then days = 1
            cmd.Parameters.AddWithValue("@total", days * RoomPrice)

            ' ፎቶውን ወደ ባይነሪ ቀይሮ መላክ
            cmd.Parameters.AddWithValue("@img", ImageToByteArray(picReceipt.Image))

            cmd.ExecuteNonQuery()

            ' 3. የክፍሉን ስታተስ ከ 'Available' ወደ 'Booked' መቀየር
            Dim updateSql As String = "UPDATE Rooms SET Status = 'Booked' WHERE RoomID = @rid"
            Dim updateCmd As New SqlCommand(updateSql, conn)
            updateCmd.Parameters.AddWithValue("@rid", TargetRoomID)
            updateCmd.ExecuteNonQuery()

            MsgBox("ቡኪንጉ በስኬት ተጠናቋል! አድሚኑ ደረሰኙን አይቶ ያጸድቀዋል።", MsgBoxStyle.Information)

            ' 4. ዳሽቦርዱን አድሶ መመለስ
            conn.Close()
            frmCustomerDashboard.LoadRoomsIntoDashboard()
            frmCustomerDashboard.Show()
            Me.Close()

        Catch ex As Exception
            MsgBox("ስህተት: " & ex.Message, MsgBoxStyle.Critical)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmCustomerDashboard.Show()
        Me.Close()
    End Sub
End Class