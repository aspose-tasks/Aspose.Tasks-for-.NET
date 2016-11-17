
Namespace WorkingWithTaskLinks
    Public Class IdentifyCrossProjectTasks
        Public Shared Sub Run()
            ' ExStart:IdentifyCrossProjectTasks
            ' Create project instance and access task
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)
            Dim project1 As New Project(dataDir + "External.mpp")
            Dim externalTask As Task = project1.RootTask.Children.GetByUid(1)

            ' Show ID of the task in the external project
            Console.WriteLine(externalTask.[Get](Tsk.Id).ToString())

            ' Show ID of the task in the original project
            Console.WriteLine(externalTask.[Get](Tsk.ExternalId).ToString())
            ' ExEnd:IdentifyCrossProjectTasks
        End Sub
    End Class
End Namespace

