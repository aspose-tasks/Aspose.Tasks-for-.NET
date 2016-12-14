Imports Aspose.Tasks.Saving
Imports Aspose.Tasks.Util

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace KnowledgeBase
    Public Class CreateResourcesAndLinkToTasks
        Public Shared Sub Run()
            Try
                Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

                ' ExStart:CreateResourcesAndLinkToTasks
                Dim project1 As New Project(dataDir + "SampleProject.mpp")

                ' Declare ChildTasksCollector class object
                Dim collector As New ChildTasksCollector()

                ' Use TaskUtils to get all children tasks in RootTask
                TaskUtils.Apply(project1.RootTask, collector, 0)

                ' Define Resources
                For i = 0 To 4
                    Dim devloper As String = "Developer0" & i

                    ' Add resource to project
                    Dim newResource As Resource = project1.Resources.Add(devloper)
                    newResource.Set(Rsc.Type, ResourceType.Work)

                    ' Define assignment
                    Dim newResourceAssignment As ResourceAssignment = project1.ResourceAssignments.Add(TryCast(collector.Tasks(i), Task), newResource)
                Next i

                project1.Save(dataDir & "CreateResourcesAndLinkToTasks_out.mpp", SaveFileFormat.MPP)
                ' ExEnd:CreateResourcesAndLinkToTasks
            Catch ex As NotSupportedException
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace