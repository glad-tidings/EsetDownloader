Module Tools

    Public Function App_Path() As String
        If Right(Application.StartupPath, 1) = "\" Or Right(Application.StartupPath, 1) = "/" Then
            Return Application.StartupPath
        Else
            Return Application.StartupPath & "\"
        End If
    End Function

    Public Function Fix_Path(ByVal Path As String) As String
        If Microsoft.VisualBasic.Right(Path, 1) = "\" Or Microsoft.VisualBasic.Right(Path, 1) = "/" Then
            Return Path
        Else
            Return Path & "\"
        End If
    End Function

    Public Function PrevInstance() As Boolean
        If UBound(Diagnostics.Process.GetProcessesByName(Diagnostics.Process.GetCurrentProcess.ProcessName)) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ProInstanceCount() As Integer
        Return UBound(Diagnostics.Process.GetProcessesByName(Diagnostics.Process.GetCurrentProcess.ProcessName))
    End Function
End Module