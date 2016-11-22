Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithProjects
    Public Class ReadOutlineCodes
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:ReadOutlineCodes		
            Dim project As New Project(dataDir & Convert.ToString("OutlineCodes.mpp"))

            For Each ocd As OutlineCodeDefinition In project.OutlineCodes
                Console.WriteLine("Alias = " + ocd.[Alias])
                If ocd.AllLevelsRequired Then
                    Console.WriteLine("It contains property: must have all levels")
                Else
                    Console.WriteLine("It does not contain property: must have all levels")
                End If
                If ocd.Enterprise Then
                    Console.WriteLine("It is an enterprise custom outline code.")
                Else
                    Console.WriteLine("It is not an enterprise custom outline code.")
                End If

                Console.WriteLine("Reference to another custom field for which this outline code definition is an alias is = " + ocd.EnterpriseOutlineCodeAlias)
                Console.WriteLine("Field Id = " + ocd.FieldId)
                Console.WriteLine("Field Name = " + ocd.FieldName)
                Console.WriteLine("Phonetic Alias = " + ocd.PhoneticAlias)
                Console.WriteLine("Guid = " + ocd.Guid)

                ' Display outline code masks
                For Each outlineMask As OutlineMask In ocd.Masks
                    Console.WriteLine("Level of a mask = " + outlineMask.Level)
                    Console.WriteLine("Mask = " + outlineMask.ToString())
                Next

                ' Display out line code values
                For Each outlineMask1 As OutlineValue In ocd.Values
                    Console.WriteLine("Description of outline value = " + outlineMask1.Description)
                    Console.WriteLine("Value Id = " + outlineMask1.ValueId)
                    Console.WriteLine("Value = " + outlineMask1.Value)
                    Console.WriteLine("Type = " + outlineMask1.Type)
                Next
            Next
            ' ExEnd:ReadOutlineCodes
        End Sub
    End Class
End Namespace