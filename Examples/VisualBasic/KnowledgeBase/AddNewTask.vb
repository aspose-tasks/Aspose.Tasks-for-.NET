Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace KnowledgeBase
    Public Class AddNewTask
        Public Shared Sub Run()
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:AddNewTask            
            Dim project As New Project(dataDir + "Project1.mpp")

            Dim task As Task = project.RootTask.Children.Add("Task1")
            task.Set(Tsk.ActualStart, DateTime.Parse("23-Aug-2012"))

            ' Set duration in hours
            task.Set(Tsk.Duration, project.GetDuration(24, TimeUnitType.Hour))
            task.Set(Tsk.DurationFormat, TimeUnitType.Day)
            project.RootTask.Children.Add(task)

            ' Save the Project as XML
            project.Save(dataDir + "AddNewTask_out.xml", SaveFileFormat.XML)
            ' ExEnd:AddNewTask        
        End Sub
    End Class
End Namespace