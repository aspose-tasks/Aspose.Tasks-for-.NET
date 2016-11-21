Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithFormulas
    Public Class WriteFormulasInExtendedAttributesToMPP
        Public Shared Sub Run()
            Try
                ' ExStart:WriteFormulasInExtendedAttributesToMPP
                ' Create project instance
                Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)
                Dim project As New Project(dataDir & Convert.ToString("Project1.mpp"))
                project.[Set](Prj.NewTasksAreManual, False)

                ' Create new custom field (Task Text1) with formula which will double task cost
                Dim attr As New ExtendedAttributeDefinition()
                attr.FieldId = ExtendedAttributeTask.Text1.ToString("D")
                attr.[Alias] = "Double Costs"
                attr.Formula = "[Cost]*2"
                project.ExtendedAttributes.Add(attr)

                ' Add a task
                Dim task As Task = project.RootTask.Children.Add("Task")

                ' Set task cost            
                task.[Set](Tsk.Cost, 100)

                ' Save project
                project.Save(dataDir & Convert.ToString("WriteFormulasInExtendedAttributesToMPP_out.mpp"), SaveFileFormat.MPP)
                ' ExEnd:WriteFormulasInExtendedAttributesToMPP
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace