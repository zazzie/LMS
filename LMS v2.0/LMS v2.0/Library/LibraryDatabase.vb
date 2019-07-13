Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class LibraryDatabase
    Public Shared con As New MySqlConnection
    Public Shared da As MySqlDataAdapter
    Shared Sub openDatabase()
        Try
            If con.State = ConnectionState.Closed Then
                con.ConnectionString = "Server=" & My.Settings.ServerIP & ";Port=" & My.Settings.PortNo _
                                              & ";Database=" & My.Settings.DatabaseName & ";User=" & My.Settings.UserName _
                                              & ";Password=" & My.Settings.Password & ";"
                con.Open()
            End If
        Catch myerror As MySqlException
            MessageBox.Show(myerror.Number & myerror.Message & Chr(13) & _
                            "Check your Database Connection. ", "Connection Failed.", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Shared Sub closeDatabase()
        Try
            con.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message & Chr(13), "Disconnection Failed.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Shared Sub execSQL(ByVal sqlstr As String)
        Try
            openDatabase()
            Dim cmd As New MySqlCommand
            cmd.CommandText = sqlstr
            cmd.CommandType = CommandType.Text
            cmd.Connection = con
            cmd.ExecuteNonQuery()
        Catch ex As MySqlException
            MsgBox("ERROR " + ex.ErrorCode.ToString + ":" + ex.Message)
        Finally
            closeDatabase()
        End Try
    End Sub

    Shared Function execdeleteSQL(ByVal sqlstr As String) As Boolean
        Try
            openDatabase()
            Dim cmd As New MySqlCommand
            cmd.CommandText = sqlstr
            cmd.CommandType = CommandType.Text
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As MySqlException
            Return False
        Finally
            closeDatabase()
        End Try
    End Function

    Shared Function fetchSQL(ByVal sqlstr As String) As DataSet
        Try
            openDatabase()
            da = New MySqlDataAdapter(sqlstr, con)
            Dim ds As New DataSet
            da.Fill(ds, "Data")
            Return ds
        Catch ex As MySqlException
            MsgBox("ERROR:" + ex.ErrorCode.ToString + ":" + ex.Message)
            Return Nothing
        Finally
            closeDatabase()
        End Try
    End Function
    Shared Function GenerateID(ByVal sqlstr As String) As Integer
        Dim _id As Integer
        Try
            _id = fetchSQL(sqlstr).Tables(0).Rows(0).Item(0) + 1
        Catch
            _id = 1
        End Try
        Return _id
    End Function
    Shared Function isExisting(ByVal sqlstr As String) As Boolean
        Dim countMe As Integer
        countMe = fetchSQL(sqlstr).Tables(0).Rows(0).Item(0)
        If countMe > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Shared Function TestConnection(str As String) As Boolean
        Try
            If con.State = ConnectionState.Open Then
                closeDatabase()
            End If
            con.ConnectionString = str
            con.Open()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
