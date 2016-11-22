Imports System.IO
Imports Aspose.Tasks
Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithFormulas
    Public Class UsingTasksAndResourceFieldsInFormulaCalculations
        ' ExStart:UsingTasksAndResourceFieldsInFormulaCalculations
        Public Shared Sub Run()
            Try
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

                Dim project As Project = CreateTestProjectWithCustomField()
                Dim task As Task = project.RootTask.Children.GetById(1)

                ' Set formula for extended attribute
                Dim extendedAttributeDefinition1 As ExtendedAttributeDefinition = project.ExtendedAttributes(0)
                extendedAttributeDefinition1.[Alias] = "Days from finish to deadline"
                extendedAttributeDefinition1.Formula = "[Deadline] - [Finish]"

                ' Set Task Deadline and save project
                Dim task1 As Task = project.RootTask.Children.GetById(1)
                task.[Set](Tsk.Deadline, New DateTime(2015, 3, 20, 17, 0, 0))
                project.Save(dataDir & Convert.ToString("project_UsingTasksAndResourceFields_out.mpp"), SaveFileFormat.MPP)
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.")
            End Try
        End Sub

        ' Helper method to create project
        Public Shared Function CreateTestProjectWithCustomField() As Project
            ' Create new project instance
            Dim project As New Project()
            project.[Set](Prj.StartDate, New DateTime(2015, 3, 6, 8, 0, 0))

            ' Add new task with extended attribute
            Dim task As Task = project.RootTask.Children.Add("Task")
            Dim extendedAttributeDefinition As New ExtendedAttributeDefinition()
            extendedAttributeDefinition.FieldId = ExtendedAttributeTask.Text1.ToString("D")
            project.ExtendedAttributes.Add(extendedAttributeDefinition)
            Dim extendedAttribute As ExtendedAttribute = extendedAttributeDefinition.CreateExtendedAttribute()
            task.ExtendedAttributes.Add(extendedAttribute)

            ' Add resource and resource assignment
            Dim rsc As Resource = project.Resources.Add("Rsc")
            Dim assn As ResourceAssignment = project.ResourceAssignments.Add(task, rsc)

            Return project
        End Function
        ' ExEnd:UsingTasksAndResourceFieldsInFormulaCalculations 
    End Class
End Namespace