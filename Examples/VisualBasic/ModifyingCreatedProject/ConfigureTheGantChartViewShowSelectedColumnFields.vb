Imports System.Drawing
Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Tasks.Examples.VisualBasic.ModifyingCreatedProject
    Public Class ConfigureTheGantChartViewShowSelectedColumnFields
        Public Shared Sub Run()
            ' ExStart:ConfigureTheGantChartViewShowSelectedColumnFields
            Try
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_ModifyingCreatedProject()

                Dim project As New Project(dataDir & Convert.ToString("Project5.mpp"))
                ' Create a new project task
                Dim task As Task = project.RootTask.Children.Add("New Activity")

                ' Add custom text attribute to created task.
                Dim attr As New ExtendedAttribute()
                attr.FieldId = CInt(ExtendedAttributeTask.Text1).ToString()
                attr.Value = "Activity attribute"
                task.ExtendedAttributes.Add(attr)

                ' Customize table by adding text attribute field
                Dim attrField As New TableField()
                attrField.Field = Field.TaskText1
                attrField.Width = 20
                attrField.Title = "Custom attribute"
                attrField.AlignTitle = StringAlignment.Center
                attrField.AlignData = StringAlignment.Center
                Dim table As Table = project.Tables.ToList()(0)
                table.TableFields.Insert(3, attrField)

                ' The result of opening of saved project in MSP2010 is in attached screenshot
                project.Save(dataDir & Convert.ToString("ConfigureTheGantChartViewShowSelectedColumnFields_out.mpp"), SaveFileFormat.MPP)
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            End Try
            ' ExEnd:ConfigureTheGantChartViewShowSelectedColumnFields
        End Sub
    End Class
End Namespace