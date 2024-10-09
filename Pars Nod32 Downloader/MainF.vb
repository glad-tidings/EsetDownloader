Imports System.Net

Public Class MainF

    Dim DBConn As DBConnection
    Dim Item As ListViewItem
    Private WithEvents WClient As WebClient = New WebClient
    Dim DLCount As Integer
    Dim Options(2) As String
    Dim TR, BBR As Long

    Public Sub Get_Settings()
        Try
            DBConn = New DBConnection
            DBConn.ConnectMe("SELECT * FROM URLList;")
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                Do While d.Read
                    Item = URLList.Items.Add(d("ID".ToString))
                    With Item
                        .SubItems.Add(d("PURL".ToString))
                        .SubItems.Add(d("PName".ToString))
                        .SubItems.Add(IIf(d("PAuthorize".ToString) = True, "Yes", "No"))
                        .SubItems.Add("")
                        .SubItems.Add("")
                        .SubItems.Add("")
                        .SubItems.Add("")
                    End With
                Loop
                Try
                    DBConn.OLEConn.Close()
                Catch err As System.Exception
                    MsgBox("Problem in connect to database", MsgBoxStyle.Information)
                    Exit Sub
                End Try
            Catch err As System.Exception
                MsgBox("Problem in connect to database", MsgBoxStyle.Information)
                Exit Sub
            End Try
        Catch err As System.Exception
            MsgBox("Problem in connect to database", MsgBoxStyle.Information)
            Exit Sub
        End Try
        Try
            DBConn = New DBConnection
            DBConn.ConnectMe("SELECT * FROM Options WHERE ID=1;")
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                Do While d.Read
                    Options(0) = d("PUser".ToString)
                    Options(1) = d("PPas".ToString)
                    Options(2) = d("PSave".ToString)
                Loop
                Try
                    DBConn.OLEConn.Close()
                Catch err As System.Exception
                    MsgBox("Problem in connect to database", MsgBoxStyle.Information)
                    Exit Sub
                End Try
            Catch err As System.Exception
                MsgBox("Problem in connect to database", MsgBoxStyle.Information)
                Exit Sub
            End Try
        Catch err As System.Exception
            MsgBox("Problem in connect to database", MsgBoxStyle.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub MainF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Get_Settings()
    End Sub

    Private Sub StartDT_Click(sender As Object, e As EventArgs) Handles StartDT.Click
        If URLList.Items.Count <> 0 Then
            StartDT.Enabled = False
            DLCount = 0
            TR = 0
            BBR = 0
            Download_File()
        End If
    End Sub

    Private Sub Download_File()
        If URLList.Items.Item(DLCount).SubItems(3).Text = "Yes" Then
            WClient.Credentials = New NetworkCredential(Options(0), Options(1))
        End If
        If IO.Directory.Exists(Options(2) & URLList.Items.Item(DLCount).SubItems(2).Text) = False Then
            IO.Directory.CreateDirectory(Options(2) & URLList.Items.Item(DLCount).SubItems(2).Text)
        End If
        WClient.DownloadFileAsync(New Uri(URLList.Items.Item(DLCount).SubItems(1).Text), Options(2) & URLList.Items.Item(DLCount).SubItems(2).Text & "\" & IO.Path.GetFileName(URLList.Items.Item(DLCount).SubItems(1).Text))
    End Sub

    Private Sub WClient_DownloadFileCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles WClient.DownloadFileCompleted
        If (URLList.Items.Count - 1) <> DLCount Then
            DLCount += 1
            TR = 0
            BBR = 0
            Download_File()
        End If
    End Sub

    Private Sub WClient_DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles WClient.DownloadProgressChanged
        TR = e.BytesReceived - BBR
        BBR = e.BytesReceived
        If e.TotalBytesToReceive < 1024 Then
            URLList.Items.Item(DLCount).SubItems(4).Text = e.TotalBytesToReceive & " Bytes"
        ElseIf e.TotalBytesToReceive < 1048576 Then
            URLList.Items.Item(DLCount).SubItems(4).Text = Math.Round((e.TotalBytesToReceive / 1024), 3) & " KB"
        Else
            URLList.Items.Item(DLCount).SubItems(4).Text = Math.Round((e.TotalBytesToReceive / 1048576), 3) & " MB"
        End If
        If e.BytesReceived < 1024 Then
            URLList.Items.Item(DLCount).SubItems(5).Text = e.BytesReceived & " Byte"
        ElseIf e.BytesReceived < 1048576 Then
            URLList.Items.Item(DLCount).SubItems(5).Text = Math.Round((e.BytesReceived / 1024), 3) & " KB"
        Else
            URLList.Items.Item(DLCount).SubItems(5).Text = Math.Round((e.BytesReceived / 1048576), 3) & " MB"
        End If
        If TR < 1024 Then
            URLList.Items.Item(DLCount).SubItems(6).Text = TR & " Bytes/sec"
        ElseIf TR < 1048576 Then
            URLList.Items.Item(DLCount).SubItems(6).Text = Math.Round((TR / 1024), 0) & " KB/sec"
        Else
            URLList.Items.Item(DLCount).SubItems(6).Text = Math.Round((TR / 1048576), 0) & " MB/sec"
        End If
    End Sub
End Class
