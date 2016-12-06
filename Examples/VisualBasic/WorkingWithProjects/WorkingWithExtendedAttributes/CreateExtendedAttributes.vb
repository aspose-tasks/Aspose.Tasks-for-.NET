Imports Aspose.Tasks.Saving

' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
' when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
' install it and then add its reference to this project. For any issues, questions or suggestions 
' please feel free to contact us using http://www.aspose.com/community/forums/default.aspx

Namespace WorkingWithProjects.WorkingWithExtendedAttributes
    Public Class CreateExtendedAttributes
        Public Shared Sub Run()
            Try
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

                ' ExStart:CreateExtendedAttributes  
                Dim project1 As New Project(dataDir & "Blank2010.mpp")

                Dim myText1Def As ExtendedAttributeDefinition = Nothing

                ' If the Custom field doesn't exist in Project, create it
                If project1.ExtendedAttributes.GetById(Convert.ToInt32(ExtendedAttributeTask.Text1.ToString("D"))) Is Nothing Then
                    myText1Def = New ExtendedAttributeDefinition()
                    myText1Def.Alias = "MyValue"
                    myText1Def.CfType = CustomFieldType.Number
                    myText1Def.FieldId = ExtendedAttributeTask.Text1.ToString("D")
                    project1.ExtendedAttributes.Add(myText1Def)
                Else
                    myText1Def = project1.ExtendedAttributes.GetById(Convert.ToInt32(ExtendedAttributeTask.Number1.ToString("D")))
                End If
                ' Generate Extended Attribute from definition
                Dim text1TaskAttr As ExtendedAttribute = myText1Def.CreateExtendedAttribute()
                text1TaskAttr.Value = "20.55"

                ' Add extended attribute to task
                Dim tsk As Task = project1.RootTask.Children.Add("Task 1")
                tsk.ExtendedAttributes.Add(text1TaskAttr)

                project1.Save(dataDir & "CreateExtendedAttributes_out.mpp", SaveFileFormat.MPP)
                ' ExEnd:CreateExtendedAttributes
            Catch ex As Exception
                Console.Write(ex.Message & vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace
