

Namespace WorkingWithTaskBaselines
    Public Class CreateTaskBaseline
        Public Shared Sub Run()
            ' ExStart:CreateTaskBaseline
            ' Create project instance
            Dim project1 As New Project()

            ' Creating TaskBaseline
            Dim task As Task = project1.RootTask.Children.Add("Task")

            ' Set baseline for specified tasks and entire project
            project1.SetBaseline(BaselineType.Baseline, New Task() {task})
            project1.SetBaseline(BaselineType.Baseline)
            ' ExEnd:CreateTaskBaseline
        End Sub
    End Class
End Namespace

