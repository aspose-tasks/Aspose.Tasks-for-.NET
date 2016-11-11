Imports System.IO

Namespace WorkingWithTasks
    Public Class ReadTaskOvertimes
        Public Shared Sub Run()
            ' ExStart:ReadTaskOvertimes
            ' Read project from file stream
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
            Dim fs As New FileStream(dataDir & "project.mpp", FileMode.Open)
            Dim project1 As New Project(fs)
            fs.Close()

            ' Read overtime and percentage completion for tasks
            For Each tsk1 As Task In project1.RootTask.Children
                Console.WriteLine(tsk1.[Get](Tsk.OvertimeCost))
                Console.WriteLine(tsk1.[Get](Tsk.OvertimeWork).ToString())
                Console.WriteLine(tsk1.[Get](Tsk.PercentComplete))
                Console.WriteLine(tsk1.[Get](Tsk.PercentWorkComplete).ToString())
                Console.WriteLine(tsk1.[Get](Tsk.PhysicalPercentComplete).ToString())

                ' Set percent complete
                tsk1.[Set](Tsk.PercentComplete, 100)
            Next
            ' ExEnd:ReadTaskOvertimes
        End Sub
    End Class
End Namespace

