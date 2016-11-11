Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithProjects.Miscellaneous
    Public Class ReadGroupDefinitionData
        Public Shared Sub Run()
            ' ExStart:ReadGroupDefinitionData
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            Dim project As New Project(dataDir & Convert.ToString("Project1.mpp"))

            Console.WriteLine("Task Groups Count: " & project.TaskGroups.Count)
            Dim taskGroup As Group = project.TaskGroups.ToList()(1)
            Console.WriteLine("Group Name:", taskGroup.Name)
            Console.WriteLine("Group Criteria count: " & taskGroup.GroupCriteria.Count)
            Console.WriteLine(vbLf & "************* Retrieving Task Group's Criterion information *************")
            Dim criterion As GroupCriterion = taskGroup.GroupCriteria.ToList()(0)
            Console.WriteLine("Criterion Field: " & criterion.Field.ToString())
            Console.WriteLine("Criterion GroupOn: " & criterion.GroupOn.ToString())
            Console.WriteLine("Criterion Cell Color: " & criterion.CellColor.ToString())
            Console.WriteLine("Criterion Pattern: " & criterion.Pattern.ToString())

            If taskGroup.Equals(criterion.ParentGroup) Then
                Console.WriteLine("Parent Group is equval to task Group.")
            End If

            Console.WriteLine(vbLf & "*********** Retreivnig Criterion's Font Information ***********")
            Console.WriteLine("Font Name: " & criterion.Font.Name)
            Console.WriteLine("Font Size: " & criterion.Font.Size)
            Console.WriteLine("Font Style: " & criterion.Font.Style)
            Console.WriteLine("Ascending/Dscending: " & criterion.Ascending)
            ' ExEnd:ReadGroupDefinitionData
        End Sub
    End Class
End Namespace