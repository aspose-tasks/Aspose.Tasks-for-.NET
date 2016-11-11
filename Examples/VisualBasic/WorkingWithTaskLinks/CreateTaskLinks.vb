
Namespace WorkingWithTaskLinks
    Public Class CreateTaskLinks
        Public Shared Sub Run()
            ' ExStart:CreateTaskLinks
            ' Create new project and add tasks
            Dim project1 As New Project()
            Dim pred As Task = project1.RootTask.Children.Add("Task 1")
            Dim succ As Task = project1.RootTask.Children.Add("Task 2")

            ' Link tasks
            Dim link As TaskLink = project1.TaskLinks.Add(pred, succ)
            ' ExEnd:CreateTaskLinks
        End Sub
    End Class
End Namespace

