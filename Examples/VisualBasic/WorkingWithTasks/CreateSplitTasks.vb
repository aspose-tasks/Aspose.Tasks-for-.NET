Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithTasks
    Public Class CreateSplitTasks
        Public Shared Sub Run()
            ' ExStart:CreateSplitTasks
            ' Create new project
            Dim splitTaskProject As New Project()

            ' Get a standard calendar
            Dim calendar As Calendar = splitTaskProject.[Get](Prj.Calendar)

            ' Set project's calendar settings
            splitTaskProject.[Set](Prj.StartDate, New DateTime(2000, 3, 15, 8, 0, 0))
            splitTaskProject.[Set](Prj.FinishDate, New DateTime(2000, 3, 21, 17, 0, 0))

            ' Add a new task to root task
            Dim rootTask As Task = splitTaskProject.RootTask
            rootTask.[Set](Tsk.Name, "Root")
            Dim taskToSplit As Task = rootTask.Children.Add("Task1")
            taskToSplit.[Set](Tsk.Duration, splitTaskProject.GetDuration(3))

            ' Create a new resource assignment and generate timephased data
            Dim splitResourceAssignment As ResourceAssignment = splitTaskProject.ResourceAssignments.Add(taskToSplit, Nothing)
            splitResourceAssignment.TimephasedDataFromTaskDuration(calendar)

            ' Split the task into 3 parts.
            ' Provide start date and finish date arguments to SplitTask method which will be used for split
            splitResourceAssignment.SplitTask(New DateTime(2000, 3, 16, 8, 0, 0), New DateTime(2000, 3, 16, 17, 0, 0), calendar)
            splitResourceAssignment.SplitTask(New DateTime(2000, 3, 18, 8, 0, 0), New DateTime(2000, 3, 18, 17, 0, 0), calendar)
            splitResourceAssignment.[Set](Asn.WorkContour, WorkContourType.Contoured)

            ' Save the Project
            splitTaskProject.Save("Project_out.xml", SaveFileFormat.XML)
            ' ExEnd:CreateSplitTasks
        End Sub
    End Class
End Namespace

