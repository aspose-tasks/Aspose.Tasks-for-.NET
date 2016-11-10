

Namespace WorkingWithTasks
    Public Class ReadTaskExtendedAttributes
        Public Shared Sub Run()
            ' ExStart:ReadTaskExtendedAttributes
            ' Create project instance
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
            Dim project1 As New Project(dataDir & "project.mpp")

            ' Read extended attributes for tasks
            For Each tsk As Task In project1.RootTask.Children
                For Each ea As ExtendedAttribute In tsk.ExtendedAttributes
                    Console.WriteLine(ea.FieldId)
                    Console.WriteLine(ea.Value)
                    Console.WriteLine(ea.ValueGuid)
                Next
            Next
            ' ExEnd:ReadTaskExtendedAttributes
        End Sub
    End Class
End Namespace

