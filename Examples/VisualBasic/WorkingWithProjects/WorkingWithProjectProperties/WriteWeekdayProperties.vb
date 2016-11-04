Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Tasks
Imports Aspose.Tasks.Saving

Namespace WorkingWithProjects.WorkingWithProjectProperties
    Public Class WriteWeekdayProperties
        Public Shared Sub Run()
            ' ExStart: WriteWeekdayProperties
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Create a project instance
            Dim project As New Project(dataDir & "WriteWeekdayProperties.mpp")

            ' Set week days properties
            project.Set(Prj.WeekStartDay, DayType.Monday)
            project.Set(Prj.DaysPerMonth, 24)
            project.Set(Prj.MinutesPerDay, 540)
            project.Set(Prj.MinutesPerWeek, 3240)
            project.Save(dataDir & "saved_out.xml", SaveFileFormat.XML)
            ' ExEnd: WriteWeekdayProperties
        End Sub
    End Class
End Namespace