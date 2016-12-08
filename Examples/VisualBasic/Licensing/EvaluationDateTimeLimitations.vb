Imports Aspose.Tasks.Saving

'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx

Namespace Licensing
    Public Class EvaluationDateTimeLimitations
        Public Shared Sub Run()
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:DateTimeLimitations
            Dim project1 As New Project()

            ' Define Tasks
            Dim task1 As Task = project1.RootTask.Children.Add("Task1")
            task1.[Set](Tsk.ActualStart, DateTime.Parse("06-Apr-2010"))

            Dim task2 As Task = project1.RootTask.Children.Add("Task2")
            task2.[Set](Tsk.ActualStart, DateTime.Parse("10-Apr-2010"))

            ' Save the Project as XML
            project1.Save("EvalProject_out.xml", SaveFileFormat.XML)
            ' ExEnd:DateTimeLimitations
        End Sub
    End Class
End Namespace