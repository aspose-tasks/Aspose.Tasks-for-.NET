Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithProjects.Miscellaneous
    Public Class ReadFilterCriteriaData
        Public Shared Sub Run()
            ' ExStart:ReadFilterCriteriaData
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            Dim project As New Project(dataDir & Convert.ToString("Project2003.mpp"))

            Dim filter As Filter = project.TaskFilters.ToList()(1)
            Console.WriteLine(filter.Criteria.CriteriaRows.Count)
            Console.WriteLine(filter.Criteria.Operation.ToString())

            Dim criteria1 As FilterCriteria = filter.Criteria.CriteriaRows(0)
            Console.WriteLine(criteria1.Test.ToString())
            Console.WriteLine(criteria1.Field.ToString())
            Console.WriteLine(criteria1.Values(0).ToString())

            Dim criteria2 As FilterCriteria = filter.Criteria.CriteriaRows(1)
            Console.WriteLine(criteria2.Operation.ToString())
            Console.WriteLine(criteria2.CriteriaRows.Count)

            Dim criteria21 As FilterCriteria = criteria2.CriteriaRows(0)
            Console.WriteLine(criteria21.Test.ToString())
            Console.WriteLine(criteria21.Field.ToString())
            Console.WriteLine(criteria21.Values(0).ToString())

            Dim criteria22 As FilterCriteria = criteria2.CriteriaRows(1)
            Console.WriteLine(criteria22.Test.ToString())
            Console.WriteLine(criteria22.Field.ToString())
            Console.WriteLine(criteria22.Values(0).ToString())
            ' ExEnd:ReadFilterCriteriaData
        End Sub
    End Class
End Namespace