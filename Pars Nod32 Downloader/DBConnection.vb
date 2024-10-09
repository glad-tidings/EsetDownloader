Public Class DBConnection

#Region "Class Import"

    Friend WithEvents OLEConn As New System.Data.OleDb.OleDbConnection
    Friend WithEvents OLEComm As New System.Data.OleDb.OleDbCommand
    Public Shared dataReturned As New ArrayList

#End Region

#Region "class Function"

    Function ConnectMe(ByVal DBString As String) As Boolean
        Dim DBProvider As String = "Provider=Microsoft.Jet.OLEDB.4.0"
        Dim DBMode As String = "Mode=ReadWrite"
        Dim DBPath As String = "Data source=" & App_Path() & "PND.mdb"
        Dim DBPass As String = "Jet OLEDB:Database Password=n@jk#d77W#5C85$&43CM"
        Try
            OLEConn.ConnectionString = DBProvider & ";" & DBMode & ";" & DBPath '& ";" & DBPass
            OLEConn.Open()
            OLEComm.CommandText = DBString
            Return True
        Catch err As System.Exception
            Return False
        End Try
    End Function

    Function getData(ByVal FieldName As String) As ArrayList
        Try
            OLEComm.Connection = OLEConn
            getData = New ArrayList
            Dim d As OleDb.OleDbDataReader = OLEComm.ExecuteReader()
            Do While d.Read
                dataReturned.Add(d(FieldName.ToString))
            Loop
            Try
                OLEConn.Close()
            Catch err As System.Exception
            End Try
        Catch err As System.Exception
        End Try
        Return dataReturned
    End Function

#End Region

End Class