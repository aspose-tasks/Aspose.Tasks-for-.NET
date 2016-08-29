Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Tasks.Examples.VisualBasic.ModifyingCreatedProject
    Public Class SetTimeScaleCount
        Public Shared Sub Run()
            ' ExStart:SetTimeScaleCount
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingCreatedProject()
            Dim project As New Project()
            Dim view As New GanttChartView()
            view.BottomTimescaleTier.Count = 2
            view.BottomTimescaleTier.ShowTicks = False
            ' Tick lines check box in MSP
            view.MiddleTimescaleTier.Count = 2
            view.MiddleTimescaleTier.ShowTicks = False
            project.Views.Add(view)
            ' Add some test data to project
            Dim task1 As Task = project.RootTask.Children.Add("Task 1")
            Dim task2 As Task = project.RootTask.Children.Add("Task 2")
            task1.[Set](Tsk.Duration, task1.ParentProject.GetDuration(24, TimeUnitType.Hour))
            task2.[Set](Tsk.Duration, task1.ParentProject.GetDuration(40, TimeUnitType.Hour))
            project.Save(dataDir & Convert.ToString("SetTimeScaleCount_out.pdf"), SaveFileFormat.PDF)
            ' Result is in attached screenshot
            ' ExEnd:SetTimeScaleCount
        End Sub
    End Class
End Namespace