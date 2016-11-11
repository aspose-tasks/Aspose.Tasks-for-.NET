
Namespace WorkingWithTasks
    Public Class ReadWriteTimephasedData
        Public Shared Sub Run()
            ' ExStart:ReadWriteTimephasedData
            ' Create project instance
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
            Dim project1 As New Project(dataDir & "project.mpp")

            ' Set project properties
            project1.[Set](Prj.StartDate, New DateTime(2013, 10, 30, 9, 0, 0))
            project1.[Set](Prj.NewTasksAreManual, False)

            ' Add task and resources
            Dim task As Task = project1.RootTask.Children.Add("Task")
            Dim rsc1 As Resource = project1.Resources.Add("Rsc")

            ' Set resource rates and task duration
            rsc1.[Set](Rsc.StandardRate, 10)
            rsc1.[Set](Rsc.OvertimeRate, 15)
            task.[Set](Tsk.Duration, project1.GetDuration(6))

            ' Create resource assignment
            Dim assn As ResourceAssignment = project1.ResourceAssignments.Add(task, rsc1)
            assn.[Set](Asn.[Stop], DateTime.MinValue)
            assn.[Set](Asn.[Resume], DateTime.MinValue)

            ' Set Backloaded contour, it increases task duration from 6 to 10 days
            assn.[Set](Asn.WorkContour, WorkContourType.BackLoaded)

            project1.SetBaseline(BaselineType.Baseline)
            task.[Set](Tsk.PercentComplete, 50)

            ' Read timephased data
            Dim td As List(Of TimephasedData) = assn.GetTimephasedData(assn.[Get](Asn.Start), assn.[Get](Asn.Finish), TimephasedDataType.AssignmentRemainingWork).ToList()
            Console.WriteLine(td.Count)
            For Each timePhasedValue As TimephasedData In td
                Console.WriteLine(timePhasedValue.Value)
            Next
            ' ExEnd:ReadWriteTimephasedData
        End Sub
    End Class
End Namespace
