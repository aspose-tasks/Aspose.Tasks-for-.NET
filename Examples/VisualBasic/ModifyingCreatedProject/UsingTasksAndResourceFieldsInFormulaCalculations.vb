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

Namespace Aspose.Tasks.Examples.VisualBasic.ModifyingCreatedProject
    Public Class UsingTasksAndResourceFieldsInFormulaCalculations
        Public Shared Sub Run()
            ' ExStart:UsingTasksAndResourceFieldsInFormulaCalculations

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingCreatedProject()
            Dim project As New Project()
            project.[Set](Prj.StartDate, New DateTime(2015, 3, 6, 8, 0, 0))

            Dim extendedAttributeDefinition As New ExtendedAttributeDefinition()
            project.ExtendedAttributes.Add(extendedAttributeDefinition)
            extendedAttributeDefinition.FieldId = ExtendedAttributeTask.Text1.ToString("D")
            Dim task As Task = project.RootTask.Children.Add("Task")
            Dim extendedAttribute As ExtendedAttribute = extendedAttributeDefinition.CreateExtendedAttribute()
            task.ExtendedAttributes.Add(extendedAttribute)
            Dim rsc As Resource = project.Resources.Add("Rsc")
            Dim assn As ResourceAssignment = project.ResourceAssignments.Add(task, rsc)
            Dim extendedAttributeDefinition1 As ExtendedAttributeDefinition = project.ExtendedAttributes(0)
            extendedAttributeDefinition1.[Alias] = "Days from finish to deadline"
            extendedAttributeDefinition1.Formula = "[Deadline] - [Finish]"

            Dim task1 As Task = project.RootTask.Children.GetById(1)
            task.[Set](Tsk.Deadline, New DateTime(2015, 3, 20, 17, 0, 0))
            project.Save(dataDir & Convert.ToString("UsingTasksAndResourceFieldsInFormulaCalculations_out.mpp"), SaveFileFormat.MPP)
            ' ExEnd:UsingTasksAndResourceFieldsInFormulaCalculations            
        End Sub
    End Class
End Namespace