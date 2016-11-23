Imports System.Collections.Generic

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithProjects.Miscellaneous
    Public Class ReadFilterDefinitionData
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:ReadFilterDefinitionData
            ' Instantiate project and access task filters
            Dim project As New Project(dataDir & Convert.ToString("ReadFilterDefinitionData.mpp"))
            Dim taskFilters As List(Of Filter) = project.TaskFilters.ToList()
            Console.WriteLine("Task Filters Count: " + taskFilters.Count.ToString())
            Console.WriteLine("All Tasks: " + taskFilters(0).Name)
            Console.WriteLine("Task Item: " + taskFilters(0).FilterType.ToString())
            Console.WriteLine("Task Filters Show In Menu: " + taskFilters(0).ShowInMenu.ToString())
            Console.WriteLine("Task filter ShowRelatedSummaryRows: " + taskFilters(0).ShowRelatedSummaryRows.ToString())

            ' Access resource filters
            Dim rscFilters As List(Of Filter) = project.ResourceFilters.ToList()
            Console.WriteLine("Project.ResourceFilters count: " & rscFilters.Count)
            Console.WriteLine("Resource Filter Item Type: Item.ResourceType: " & rscFilters(0).FilterType)
            Console.WriteLine("Resource filter ShowInMenu" & rscFilters(0).ShowInMenu)
            Console.WriteLine("Resource filter ShowRelatedSummaryRows: " & rscFilters(0).ShowRelatedSummaryRows)
            ' ExEnd:ReadFilterDefinitionData
        End Sub
    End Class
End Namespace