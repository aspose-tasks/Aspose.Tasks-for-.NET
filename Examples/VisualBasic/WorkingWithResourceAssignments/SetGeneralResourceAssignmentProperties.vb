Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithResourceAssignments
    Public Class SetGeneralResourceAssignmentProperties
        Public Shared Sub Run()
            ' ExStart:SetGeneralResourceAssignmentProperties
            ' Create empty project
            Dim project1 As New Project()

            ' Add new task and resource
            Dim task1 As Task = project1.RootTask.Children.Add("Task")
            Dim rsc1 As Resource = project1.Resources.Add("Rsc")
            rsc1.[Set](Rsc.StandardRate, 10)
            rsc1.[Set](Rsc.OvertimeRate, 15)

            ' Assign the resource desired task
            Dim assn As ResourceAssignment = project1.ResourceAssignments.Add(task1, rsc1)
            ' ExEnd:SetGeneralResourceAssignmentProperties

            ' Save project as PDF
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)
            project1.Save(dataDir & "SetGeneralResourceAssignmentProperties_out.pdf", SaveFileFormat.PDF)
        End Sub
    End Class
End Namespace