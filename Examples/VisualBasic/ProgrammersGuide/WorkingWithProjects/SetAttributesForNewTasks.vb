Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Tasks

Namespace Aspose.Tasks.Examples.VisualBasic.WorkingWithProjects
    Public Class SetAttributesForNewTasks
        Public Shared Sub Run()
            'Exstart: SetAttributesForNewTasks
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Projects()

            'Create a project instance
            Dim project As New Project()

            'Set new task property
            project.[Set](Prj.NewTaskStartDate, TaskStartDateType.CurrentDate)

            'Save the project as XML project file
            project.Save(dataDir & "project.xml", Aspose.Tasks.Saving.SaveFileFormat.XML)


            ' Display Status.
            System.Console.WriteLine("New Task created with start date successfully.")
            'Exend: SetAttributesForNewTasks
        End Sub
    End Class
End Namespace