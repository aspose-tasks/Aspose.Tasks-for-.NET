Imports Aspose.Tasks
Imports Aspose.Tasks.Saving
Imports Aspose.Tasks.Visualization

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithProjects.WorkingWithProjectViews
    Public Class CustomizeTimescaleTierLabels
        Public Shared Sub Run()
            ' ExStart:CustomizeTimescaleTierLabels
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            Dim project As New Project(dataDir & Convert.ToString("Project5.mpp"))

            ' Here is just some test data
            project.TaskLinks.Add(project.RootTask.Children.Add("Task 1"), project.RootTask.Children.Add("Task 2"))
            Dim view As GanttChartView = DirectCast(project.DefaultView, GanttChartView)

            ' This code is added for better visualization
            view.MiddleTimescaleTier.Unit = TimescaleUnit.Months
            project.[Set](Prj.TimescaleStart, New DateTime(2012, 8, 6))

            ' Customize middle tier dates
            view.MiddleTimescaleTier.DateTimeConverter = Function([date]) {"Янв.", "Фев.", "Мар.", "Апр.", "Май", "Июнь", "Июль", "Авг.", "Сен.", "Окт.", "Ноя.", "Дек."}([date].Month - 1)
            project.Save(dataDir & Convert.ToString("Result_out.pdf"), SaveFileFormat.PDF)
            ' ExEnd:CustomizeTimescaleTierLabels
        End Sub
    End Class
End Namespace