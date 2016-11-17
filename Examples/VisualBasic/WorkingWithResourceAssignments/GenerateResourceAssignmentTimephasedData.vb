
Namespace WorkingWithResourceAssignments
    Public Class GenerateResourceAssignmentTimephasedData
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:GenerateResourceAssignmentTimephasedData
            ' Create project instance
            Dim project1 As New Project(dataDir + "ResourceAssignmentTimephasedData.mpp")

            ' Get the first task of the Project
            Dim task As Task = project1.RootTask.Children.GetById(1)

            ' Get the First Resource Assignment of the Project
            Dim firstRA As ResourceAssignment = project1.ResourceAssignments.ToList()(0)

            ' Flat contour is default contour
            Console.WriteLine("Flat contour")
            Dim td As TimephasedData
            Dim tdList = task.GetTimephasedData(project1.Get(Prj.StartDate), project1.Get(Prj.FinishDate))
            For Each td In tdList
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value)
            Next

            ' Change contour
            firstRA.Set(Asn.WorkContour, WorkContourType.Turtle)
            Console.WriteLine("Turtle contour")
            tdList = task.GetTimephasedData(project1.Get(Prj.StartDate), project1.Get(Prj.FinishDate))
            For Each td In tdList
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value)
            Next

            ' Change contour
            firstRA.Set(Asn.WorkContour, WorkContourType.BackLoaded)
            Console.WriteLine("BackLoaded contour")
            tdList = task.GetTimephasedData(project1.Get(Prj.StartDate), project1.Get(Prj.FinishDate))
            For Each td In tdList
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value)
            Next

            ' Change contour
            firstRA.Set(Asn.WorkContour, WorkContourType.FrontLoaded)
            Console.WriteLine("FrontLoaded contour")
            tdList = task.GetTimephasedData(project1.Get(Prj.StartDate), project1.Get(Prj.FinishDate))
            For Each td In tdList
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value)
            Next

            ' Change contour
            firstRA.Set(Asn.WorkContour, WorkContourType.Bell)
            Console.WriteLine("Bell contour")
            tdList = task.GetTimephasedData(project1.Get(Prj.StartDate), project1.Get(Prj.FinishDate))
            For Each td In tdList
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value)
            Next

            ' Change contour
            firstRA.Set(Asn.WorkContour, WorkContourType.EarlyPeak)
            Console.WriteLine("EarlyPeak contour")
            tdList = task.GetTimephasedData(project1.Get(Prj.StartDate), project1.Get(Prj.FinishDate))
            For Each td In tdList
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value)
            Next

            ' Change contour
            firstRA.Set(Asn.WorkContour, WorkContourType.LatePeak)
            Console.WriteLine("LatePeak contour")
            tdList = task.GetTimephasedData(project1.Get(Prj.StartDate), project1.Get(Prj.FinishDate))
            For Each td In tdList
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value)
            Next

            ' Change contour
            firstRA.Set(Asn.WorkContour, WorkContourType.DoublePeak)
            Console.WriteLine("DoublePeak contour")
            tdList = task.GetTimephasedData(project1.Get(Prj.StartDate), project1.Get(Prj.FinishDate))
            For Each td In tdList
                Console.WriteLine(td.Start.ToShortDateString() + " " + td.Value)
            Next
            ' ExEnd:GenerateResourceAssignmentTimephasedData
        End Sub
    End Class
End Namespace