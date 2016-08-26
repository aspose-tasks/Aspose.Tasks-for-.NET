Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Tasks

Namespace Aspose.Tasks.Examples.VisualBasic.CustomizingCreatedProject
    Public Class SetAttributesForNewTasks
        Public Shared Sub Run()

            ' Exstart: SetAttributesForNewTasks
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_CustomizingCreatedProject()

            ' Create a project instance Set new task property and Save the project as XML project file
            Dim project As New Project()
            project.[Set](Prj.NewTaskStartDate, TaskStartDateType.CurrentDate)
            project.Save(dataDir & "project.xml", Aspose.Tasks.Saving.SaveFileFormat.XML)

            ' Display Status.
            System.Console.WriteLine("New Task created with start date successfully.")
            ' Exend: SetAttributesForNewTasks
        End Sub
    End Class
End Namespace