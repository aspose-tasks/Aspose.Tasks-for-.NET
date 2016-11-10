
Namespace WorkingWithTasks
    Public Class ReadTaskCosts
        Public Shared Sub Run()
            ' ExStart:ReadTaskCosts
            ' Create new project
            Dim project As New Project()

            ' Add task and set cost
            Dim task As Task = project.RootTask.Children.Add("Task")
            task.[Set](Tsk.Cost, 800)

            ' Display cost related properties of task
            Console.WriteLine(task.[Get](Tsk.RemainingCost))
            Console.WriteLine(task.[Get](Tsk.FixedCost))
            Console.WriteLine(task.[Get](Tsk.CostVariance))
            Console.WriteLine(project.RootTask.[Get](Tsk.Cost))
            Console.WriteLine(project.RootTask.[Get](Tsk.FixedCost))
            Console.WriteLine(project.RootTask.[Get](Tsk.RemainingCost))
            Console.WriteLine(project.RootTask.[Get](Tsk.CostVariance))
            ' ExEnd:ReadTaskCosts
        End Sub
    End Class
End Namespace

