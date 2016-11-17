Imports Aspose.Tasks.Saving
Imports Aspose.Tasks.Visualization
Imports System.Drawing

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithTasks
    Public Class RenderTaskUsageViewWithDetails
        Public Shared Sub Run()
            ' ExStart:RenderTaskUsageViewWithDetails
            ' Create project instance
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)
            Dim project1 As New Project(dataDir & "TaskUsageViewWithDetails.mpp")

            ' Get Default view
            Dim view As UsageView = TryCast(project1.DefaultView, TaskUsageView)

            ' Details header column will not be displayed
            view.DisplayDetailsHeaderColumn = False
            view.RepeatDetailsHeaderOnAllRows = False
            view.AlignDetailsData = StringAlignment.Near
            project1.Save(dataDir & "task usage1_out.pdf", SaveFileFormat.PDF)

            ' Display details header column
            view.DisplayDetailsHeaderColumn = True

            ' Repeat details header on all assignments rows
            view.RepeatDetailsHeaderOnAllRows = True
            view.AlignDetailsData = StringAlignment.Far
            project1.Save(dataDir & "task usage2_out.pdf", SaveFileFormat.PDF)
            ' ExEnd:RenderTaskUsageViewWithDetails
        End Sub
    End Class
End Namespace

