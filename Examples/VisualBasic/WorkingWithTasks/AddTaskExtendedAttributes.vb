Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithTasks
    Public Class AddTaskExtendedAttributes
        Public Shared Sub Run()
            Try
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

                ' ExStart:AddTaskExtendedAttributes
                ' Create new project
                Dim project1 As New Project(dataDir & "Blank2010.mpp")

                ' Create the Extended Attribute Definition of Text Type
                Dim taskExtendedAttributeText9Definition As ExtendedAttributeDefinition
                taskExtendedAttributeText9Definition = New ExtendedAttributeDefinition()
                taskExtendedAttributeText9Definition.[Alias] = "Task City Name"
                taskExtendedAttributeText9Definition.FieldName = "Text9"
                taskExtendedAttributeText9Definition.ElementType = ElementType.Task
                taskExtendedAttributeText9Definition.CfType = CustomFieldType.Text
                taskExtendedAttributeText9Definition.FieldId = Convert.ToInt32(ExtendedAttributeTask.Text9).ToString(System.Globalization.CultureInfo.InvariantCulture)

                ' Create an Extended Attribute Definition of Flag Type
                Dim taskExtendedAttributeFlag1Definition As ExtendedAttributeDefinition
                taskExtendedAttributeFlag1Definition = New ExtendedAttributeDefinition()
                taskExtendedAttributeFlag1Definition.[Alias] = "Is Billable"
                taskExtendedAttributeFlag1Definition.FieldName = "Flag1"
                taskExtendedAttributeFlag1Definition.ElementType = ElementType.Task
                taskExtendedAttributeFlag1Definition.CfType = CustomFieldType.Flag
                taskExtendedAttributeFlag1Definition.FieldId = Convert.ToInt32(ExtendedAttributeTask.Flag1).ToString(System.Globalization.CultureInfo.InvariantCulture)

                ' Add the Extended Attribute Definitions to the Project's Extended Attribute Collection
                project1.ExtendedAttributes.Add(taskExtendedAttributeText9Definition)
                project1.ExtendedAttributes.Add(taskExtendedAttributeFlag1Definition)

                ' Add a task to project and set its properties
                Dim task As Task = project1.RootTask.Children.Add("Task 1")
                task.[Set](Tsk.Start, New DateTime(2016, 7, 27, 8, 0, 0))
                task.[Set](Tsk.Duration, project1.GetDuration(8, TimeUnitType.Hour))

                ' Create Extended Attribute and set it's values
                Dim taskExtendedAttributeText9 As New ExtendedAttribute()
                taskExtendedAttributeText9.FieldId = taskExtendedAttributeText9Definition.FieldId
                taskExtendedAttributeText9.Value = "London"

                ' Create Extended Attribute of Flag type and set it's values
                Dim taskExtendedAttributeFlag1 As New ExtendedAttribute()
                taskExtendedAttributeFlag1.FieldId = taskExtendedAttributeFlag1Definition.FieldId
                taskExtendedAttributeFlag1.Value = "1"

                ' Add the Extended Attributes to Task
                task.ExtendedAttributes.Add(taskExtendedAttributeText9)
                task.ExtendedAttributes.Add(taskExtendedAttributeFlag1)

                ' Save the Project
                project1.Save(dataDir & "AddTaskExtendedAttributes_out.mpp", SaveFileFormat.MPP)
                ' ExEnd:AddTaskExtendedAttributes
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace

