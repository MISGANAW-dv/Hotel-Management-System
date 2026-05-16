Imports System.Data.SqlClient

Module dbConnection
    ' ኖትፓድ ላይ የያዝከው አድራሻ እዚህ ጋር ይገባል
    Public loggedInUser As String ' የገባውን ሰው ስም ለመያዝPublic LoggedInUser As String = ""
    Public UserFirstName As String = ""
    Public UserLastName As String = ""
    Public conn As New SqlConnection("Server=.\SQLEXPRESS; Database=HotelDB; Integrated Security=True; TrustServerCertificate=True;")
End Module