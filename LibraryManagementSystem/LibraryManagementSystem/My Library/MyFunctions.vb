Imports System.Drawing.Imaging

Module MyFunctions

    'generate id
    Public Function generateId(ByVal tableName As String, ByVal tableId As String, ByVal code As String) As String
        Dim id As String
        Dim count As Integer
        count = countRecord("SELECT COUNT(*) FROM " + tableName + ";") + 1
        id = code + count.ToString("00000000")
        While countRecord("SELECT COUNT(*) FROM " + tableName + " WHERE " + tableId + "='" + id + "';") > 0
            count += 1
            id = code + count.ToString("00000000")
        End While
        Return id
    End Function

    'count
    Public Function countRecord(ByVal sqlstr As String) As Integer
        Dim count As Integer = 0
        Try
            count = LibraryDatabase.fetchSQL(sqlstr).Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Return count
    End Function

    'byte to image
    Public Function Base64ToImage(str As String) As Image
        Try
            Dim mybyte() As Byte = Convert.FromBase64String(str)
            Dim ms As New System.IO.MemoryStream(mybyte)
            Dim image As Image
            image = image.FromStream(ms)
            Return image
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    'initialize value
    Public Function initializeDB() As String
        Dim sqlInsert As String = ""
        Return sqlInsert
    End Function
End Module
