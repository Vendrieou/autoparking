Imports MySql.Data.MySqlClient
Module Connector
    Public Sub connect()
        Dim conn As New MySqlConnection
        Dim DatabaseName As String = "db_autoparking"
        Dim server As String = "127.0.0.1"
        Dim userName As String = "greensite"
        Dim password As String = "greensite"
        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        Try
            conn.Open()

            MsgBox("Connected")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
End Module
