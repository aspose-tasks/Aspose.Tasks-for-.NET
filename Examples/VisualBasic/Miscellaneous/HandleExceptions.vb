
Namespace Miscellaneous
    Public Class HandleExceptions
        Public Shared Sub Run()
            ' ExStart:HandleExceptions
            Dim project As Project
            Try
                Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)
                project = New Project(dataDir & "project.mpp")
            Catch ex As TasksReadingException
                Console.WriteLine("Message:")
                Console.WriteLine(ex.Message)
                Console.WriteLine("Log:")
                Console.WriteLine(ex.LogText)
                If ex.InnerException IsNot Nothing Then
                    Console.WriteLine("Inner exception message:")
                    Console.WriteLine(ex.InnerException.Message)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            ' ExEnd:HandleExceptions
        End Sub
    End Class
End Namespace