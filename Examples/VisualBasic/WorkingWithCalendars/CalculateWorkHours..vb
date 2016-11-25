
Namespace WorkingWithCalendars
    Public Class CalculateWorkHours
        Public Shared Sub Run()
            ' ExStart:CalculateWorkHours
            ' Load an existing project
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)
            Dim project As New Project(dataDir + "CalculateWorkHours.mpp")

            ' Access Task By Id
            Dim task As Task = project.RootTask.Children.GetById(1)

            ' Access Calendar and it's start and end dates
            Dim taskCalendar As Calendar = task.[Get](Tsk.Calendar)
            Dim startDate As DateTime = task.[Get](Tsk.Start)
            Dim endDate As DateTime = task.[Get](Tsk.Finish)
            Dim tempDate As DateTime = startDate

            ' Access resource and their calendar
            Dim resource As Resource = project.Resources.GetByUid(1)
            Dim resourceCalendar As Calendar = resource.[Get](Rsc.Calendar)

            Dim timeSpan As TimeSpan

            ' Get Duration in Minutes
            Dim durationInMins As Double = 0
            While tempDate < endDate
                If taskCalendar.IsDayWorking(tempDate) AndAlso resourceCalendar.IsDayWorking(tempDate) Then
                    timeSpan = taskCalendar.GetWorkingHours(tempDate)
                    durationInMins = durationInMins + timeSpan.TotalMinutes
                End If
                tempDate = tempDate.AddDays(1)
            End While
            tempDate = startDate

            ' Get Duration in Hours
            Dim durationInHours As Double = 0
            While tempDate < endDate
                If taskCalendar.IsDayWorking(tempDate) AndAlso resourceCalendar.IsDayWorking(tempDate) Then
                    timeSpan = taskCalendar.GetWorkingHours(tempDate)
                    durationInHours = durationInHours + timeSpan.TotalHours
                End If
                tempDate = tempDate.AddDays(1)
            End While
            tempDate = startDate

            ' Get Duration in Days
            Dim durationInDays As Double = 0
            While tempDate < endDate
                If taskCalendar.IsDayWorking(tempDate) AndAlso resourceCalendar.IsDayWorking(tempDate) Then
                    timeSpan = taskCalendar.GetWorkingHours(tempDate)
                    If timeSpan.TotalHours > 0 Then
                        durationInDays = durationInDays + timeSpan.TotalDays * (24 / (timeSpan.TotalHours))
                    End If
                End If
                tempDate = tempDate.AddDays(1)
            End While
            tempDate = startDate

            Console.WriteLine("Duration in Minutes = " & durationInMins)
            Console.WriteLine("Duration in Hours = " & durationInHours)
            Console.WriteLine("Duration in Days = " & durationInDays)
            ' ExEnd:CalculateWorkHours
        End Sub
    End Class
End Namespace

