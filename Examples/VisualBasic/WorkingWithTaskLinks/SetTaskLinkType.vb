
Namespace WorkingWithTaskLinks
    Public Class SetTaskLinkType
        Public Shared Sub Run()
            ' ExStart:SetTaskLinkType
            ' Create new project and add tasks
            Dim project As New Project()
            Dim pred As Task = project.RootTask.Children.Add("Task 1")
            Dim succ As Task = project.RootTask.Children.Add("Task 2")

            ' Link tasks with link type set to Start to Start
            Dim link As TaskLink = project.TaskLinks.Add(pred, succ)
            link.LinkType = TaskLinkType.StartToStart
            ' ExEnd:SetTaskLinkType
        End Sub
    End Class
End Namespace

