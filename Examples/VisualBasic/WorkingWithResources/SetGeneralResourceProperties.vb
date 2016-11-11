Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithResources
    Public Class SetGeneralResourceProperties
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Create project instance
            Dim project As New Project()

            ' ExStart:SetGeneralResourceProperties
            ' Add resources
            Dim rsc1 As Resource = project.Resources.Add("Rsc")

            ' Set resource properties, Resource properties are represented by static class Rsc
            rsc1.[Set](Rsc.StandardRate, 15)
            rsc1.[Set](Rsc.OvertimeRate, 20)
            ' ExEnd:SetGeneralResourceProperties

            ' Save project
            project.Save(dataDir & "project_out.xml", SaveFileFormat.XML)
        End Sub
    End Class
End Namespace