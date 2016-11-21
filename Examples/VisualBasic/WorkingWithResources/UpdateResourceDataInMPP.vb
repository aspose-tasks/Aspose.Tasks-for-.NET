Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithResources
    Public Class UpdateResourceDataInMPP
        Public Shared Sub Run()
            Try
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

                ' ExStart:UpdateResourceDataInMPP
                ' Create project instance
                Dim project1 As New Project(dataDir & "UpdateResourceData.mpp")

                ' Add resource and set some properties
                Dim rsc1 As Resource = project1.Resources.Add("Rsc")
                rsc1.[Set](Rsc.StandardRate, 30)
                rsc1.[Set](Rsc.OvertimeRate, 45)
                rsc1.[Set](Rsc.Group, "Workgroup1")

                ' Save the Project
                project1.Save(dataDir & "UpdateResourceData_out.mpp", SaveFileFormat.MPP)
                ' ExEnd:UpdateResourceDataInMPP
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace
