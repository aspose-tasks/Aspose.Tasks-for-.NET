Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Tasks
Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithProjects.WorkingWithProjectProperties
    Public Class SetAttributesForNewTasks
        Public Shared Sub Run()
            ' ExStart: SetAttributesForNewTasks
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' Create a project instance Set new task property and Save the project as XML project file
            Dim project As New Project()
            project.[Set](Prj.NewTaskStartDate, TaskStartDateType.CurrentDate)
            project.Save(dataDir & "SetAttributesForNewTasks_out.xml", SaveFileFormat.XML)

            ' Display Status.
            System.Console.WriteLine("New Task created with start date successfully.")
            ' ExEnd: SetAttributesForNewTasks
        End Sub
    End Class
End Namespace