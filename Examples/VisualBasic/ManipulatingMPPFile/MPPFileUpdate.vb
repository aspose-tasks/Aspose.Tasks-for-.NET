Imports Aspose.Tasks
Imports System
Imports Aspose.Tasks.Saving

Namespace ManipulatingMPPFile
    Public Class MPPFileUpdate
        Public Shared Sub Run()
            'ExStart: MPPFileUpdate
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManipulatingMPPFile()
            'Read an existing project
            Dim project As New Project(dataDir & "MPPFileUpdate.mpp")

            'create a new task
            Dim task As Task = project.RootTask.Children.Add("Task1")

            task.Set(Tsk.Start, New System.DateTime(2012, 8, 1))
            task.Set(Tsk.Finish, New DateTime(2012, 8, 5))

            'Save the project as MPP project file
            project.Save(dataDir & "AfterLinking.Mpp", SaveFileFormat.MPP)
            'ExEnd: MPPFileUpdate
        End Sub
    End Class
End Namespace