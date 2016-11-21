Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithResources
    Public Class SetResourceExtendedAttributes
        Public Shared Sub Run()
            Try
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

                ' ExStart:SetResourceExtendedAttributes
                ' Create project instance
                Dim project1 As New Project(dataDir & "ResourceExtendedAttributes.mpp")

                Dim myNumber1 As ExtendedAttributeDefinition = Nothing

                ' Define extended attribute
                If project1.ExtendedAttributes.GetById(Convert.ToInt32(ExtendedAttributeResource.Number1.ToString("D"))) Is Nothing Then
                    myNumber1 = New ExtendedAttributeDefinition()
                    myNumber1.[Alias] = "Age"
                    myNumber1.CfType = CustomFieldType.Number
                    myNumber1.FieldId = ExtendedAttributeResource.Number1.ToString("D")
                    project1.ExtendedAttributes.Add(myNumber1)
                Else
                    myNumber1 = project1.ExtendedAttributes.GetById(Convert.ToInt32(ExtendedAttributeResource.Number1.ToString("D")))
                End If

                ' Create extended attribute and set its value
                Dim Number1Resource As ExtendedAttribute = myNumber1.CreateExtendedAttribute()
                Number1Resource.Value = "30.5345"

                ' Add a new resource and its extended attribute   
                Dim rsc As Resource = project1.Resources.Add("R1")
                rsc.ExtendedAttributes.Add(Number1Resource)

                ' Save project as MPP
                project1.Save(dataDir & "ResourceExtendedAttributes_out.mpp", SaveFileFormat.MPP)
                ' ExEnd:SetResourceExtendedAttributes
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace

