
Namespace WorkingWithResources
    Public Class ReadResourceTimephasedData
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:ReadResourceTimephasedData
            ' Create project instance
            Dim project1 As New Project(dataDir + "ResourceTimephasedData.mpp")

            ' Get the Resource by its ID
            Dim resource As Resource = project1.Resources.GetByUid(1)

            ' Print Timephased data of ResourceWork
            Console.WriteLine("Timephased data of ResourceWork")
            For Each td As TimephasedData In resource.GetTimephasedData(project1.Get(Prj.StartDate), project1.Get(Prj.FinishDate))
                Console.Write("Start: " + td.Start.ToShortDateString())
                Console.Write(" Work: " + td.Value + Environment.NewLine)
            Next

            ' Print Timephased data of ResourceCost
            Console.WriteLine("Timephased data of ResourceCost")
            For Each td As TimephasedData In resource.GetTimephasedData(project1.Get(Prj.StartDate), project1.Get(Prj.FinishDate), TimephasedDataType.ResourceCost)
                Console.Write("Start: " + td.Start.ToShortDateString())
                Console.Write(" Cost: " + td.Value + Environment.NewLine)
            Next
            ' ExEnd:ReadResourceTimephasedData
        End Sub
    End Class
End Namespace

