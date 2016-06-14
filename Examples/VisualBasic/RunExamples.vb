Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Text
Imports Aspose.Tasks.Examples.VisualBasic.ProgrammersGuide.WorkingWithCalendars
Imports Aspose.Tasks.Examples.VisualBasic.WorkingWithProjects


Namespace Aspose.Tasks.Examples.VisualBasic
    Friend Class RunExamples
        <STAThread> _
        Public Shared Sub Main()
            Console.WriteLine("Open RunExamples.vb. " & vbLf & "In Main() method, uncomment the example that you want to run")
            Console.WriteLine("=====================================================")

            ' Uncomment the one you want to try out

            ' =====================================================
            ' =====================================================
            ' Working With Calendars
            ' =====================================================
            ' =====================================================

            CreatingCalendar.Run()
            'DefineWeekdaysForCalendar.Run()
            'GeneralCalendarProperties.Run()
            'MakeAStandardCalendar.Run()
            'ReadWorkWeeksInformation.Run()
            'WriteUpdatedCalendarDataToMPP.Run()

            ' =====================================================
            ' =====================================================
            ' Working With Projects
            ' =====================================================
            ' =====================================================

            'CalculateCriticalPath.Run()
            'CreateEmptyProjectSaveXML.Run()
            'DefaultProperties.Run()
            'DetermineProjectVersion.Run()
            'ExtendedAttributes.Run()
            'GetNumberOfPages.Run()
            'GetNumberOfPagesForViews.Run()
            'GetObjectByFieldMethods.Run()
            'MPPFileUpdate.Run()
            'PrintTaskWritingException.Run()
            'ReadCurrencyProperties.Run()
            'ReadFiscalYearProperties.Run()
            'ReadProjectFiles.Run()
            'ReadProjectInfo.Run()
            'ReadWeekdayProperties.Run()
            'ReplaceCalendar.Run()
            'RetrieveCalendarInfo.Run()
            'SetAttributesForNewTasks.Run()
            'WriteCurrencyProperties.Run()
            'WriteFiscalYearProperties.Run()
            'WriteMPPProjectSummary.Run()
            'WriteProjectInfo.Run()
            'WriteUpdatedExtendedAttributeDefinitions.Run()
            'WriteWeekdayProperties.Run()
            'TaskSettingStartFinishDates.Run()
            'WriteCurrencyProperties.Run()
            'WriteFiscalYearProperties.Run()
            'WriteMPPProjectSummary.Run()
            'WriteProjectInfo.Run()
            'WriteUpdatedExtendedAttributeDefinitions.Run()
            'WriteWeekdayProperties.Run()


            ' =====================================================
            ' =====================================================
            ' Working With VBA
            ' =====================================================
            ' =====================================================

            'ReadVBAProjectInformation.Run()
            'ReadReferencesInformation.Run()
            'ReadModulesInformation.Run()
            'ReadModuleAttributesInforamtion.Run()


            ' Stop before exiting
            Console.WriteLine(Constants.vbLf + Constants.vbLf & "Program Finished. Press any key to exit....")
            Console.ReadKey()
        End Sub

        Public Shared Function GetDataDir_Projects() As String
            Return Path.GetFullPath("../../ProgrammersGuide/WorkingWithProjects/Data/")
        End Function

    End Class
End Namespace