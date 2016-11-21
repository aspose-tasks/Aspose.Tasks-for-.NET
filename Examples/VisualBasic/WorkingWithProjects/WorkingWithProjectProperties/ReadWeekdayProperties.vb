Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Tasks
Imports System

Namespace WorkingWithProjects.WorkingWithProjectProperties
    Public Class ReadWeekdayProperties
        Public Shared Sub Run()
            ' ExStart: ReadWeekdayProperties
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' Create project instance
            Dim project As New Project(dataDir & "ReadWeekdayProperties.mpp")

            ' Display week days properties
            Console.WriteLine("Week Start Date : " & project.Get(Prj.WeekStartDay).ToString())
            Console.WriteLine("Days Per Month : " & project.Get(Prj.DaysPerMonth).ToString())
            Console.WriteLine("Minutes Per Day : " & project.Get(Prj.MinutesPerDay).ToString())
            Console.WriteLine("Minutes Per Week : " & project.Get(Prj.MinutesPerWeek).ToString())
            ' ExEnd: ReadWeekdayProperties
        End Sub
    End Class
End Namespace