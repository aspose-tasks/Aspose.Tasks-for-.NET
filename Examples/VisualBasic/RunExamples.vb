Imports System.IO
Imports Aspose.Tasks.Examples.VisualBasic.CreatingAndSaving
Imports Aspose.Tasks.Examples.VisualBasic.CustomizingCreatedProject
Imports Aspose.Tasks.Examples.VisualBasic.HandlingBasicProperties
Imports Aspose.Tasks.Examples.VisualBasic.ManipulatingMPPFile
Imports Aspose.Tasks.Examples.VisualBasic.ModifyingCreatedProject
Imports Aspose.Tasks.Examples.VisualBasic.PrintingAndExporting
Imports Aspose.Tasks.Examples.VisualBasic.ReadingData
Imports Aspose.Tasks.Examples.VisualBasic.WorkingWithCalendars
Imports Aspose.Tasks.Examples.VisualBasic.WorkingWithProjects

Namespace Aspose.Tasks.Examples.VisualBasic
    Class RunExamples

        Public Shared Sub Main()
            Console.WriteLine("Open RunExamples.vb. " & vbLf & "In Main() method, uncomment the example that you want to run")
            Console.WriteLine("=====================================================")


            ' Uncomment the one you want to try out

            ' =====================================================
            ' =====================================================
            ' Creating And Saving
            ' =====================================================
            ' =====================================================

            'CustomizeDateFormats.Run()
            'CustomizeTextStyle.Run()
            'FitContentsToCellSize.Run()
            'IgnoreInvalidCharactersDuringloadingProject.Run()
            'ImportProjectDataFromDatabase.Run()
            'ReadPasswordProtectedProjectFile.Run()
            'SaveProjectAsCSV.Run()
            'SaveProjectAsPDF.Run()
            'SaveProjectAsSVG.Run()
            'SaveProjectAsXLSX.Run()
            'SaveProjectDataAsHTML.Run()
            'SaveProjectDataToSpreadsheet2003XML.Run()
            'SaveToMultiplePDFFiles.Run()
            'UseSvgOptions.Run()
            'UsingXlsxOptions.Run()


            ' =====================================================
            ' =====================================================
            ' Customizing Created Project
            ' =====================================================
            ' =====================================================

            'CalculateCriticalPath.Run()
            'CreateEmptyProjectSaveXML.Run()            
            'ReschedueProjectFromFinishDate.Run()
            'ExtendedAttributes.Run()
            'ReschedueProjectFromFinishDate.Run()
            'ReschedueProjectFromStartDate.Run()
            'RescheduleProjectStartOrFinishDate.Run()
            'RetrieveCalendarInfo.Run()
            'SetAttributesForNewTasks.Run()

            ' =====================================================
            ' =====================================================
            ' Handling Basic Properties
            ' =====================================================
            ' =====================================================

            'DefaultProperties.Run()
            'WriteFiscalYearProperties.Run()
            'WriteDefaultProperties.Run()
            'WriteWeekdayProperties.Run()
            'WriteProjectInfo.Run()
            'WriteCurrencyProperties.Run()
            'ReadWeekdayProperties.Run()
            'ReadProjectInfo.Run()
            'ReadFiscalYearProperties.Run()
            'ReadCurrencyProperties.Run()
            'DetermineProjectVersion.Run()


            ' =====================================================
            ' =====================================================
            ' Manipulating MPP File
            ' =====================================================
            ' =====================================================

            'AddImageToPageHeaderFooter.Run()
            'MPPFileUpdate.Run()
            'ReadFilterCriteriaData.Run()
            'ReadFilterDefinitionData.Run()
            'WriteMPPProjectSummary.Run()


            ' =====================================================
            ' =====================================================
            ' Modifying Created Project 
            ' =====================================================
            ' =====================================================

            'ConfigureGantChart.Run()
            'ConfigureTheGantChartViewShowSelectedColumnFields.Run()
            'CustomizeTimescaleTierLabels.Run()
            'EmbeddedObjectsCreatedInsideApplication.Run()
            'ReadOnlyAccessToCustomFieldValuesUsingFormulas.Run()
            'RenderProjectDataToFormat24bppRgb.Run()
            'SetTimeScaleCount.Run()


            ' =====================================================
            ' =====================================================
            ' Printing And Exporting
            ' =====================================================
            ' =====================================================

            'ExportProjectDataToPrimaveraMPXFormat.Run()
            'ExportProjectDataToXERFormat.Run()
            'ExportProjectDataToXMLFormat.Run()
            'ImportDataFromXMLFileFormats.Run()
            'PrintProjectPagesToSeparateFiles.Run()
            'PrintProjectUsingCustomPrinter.Run()
            'PrintTaskWritingException.Run()
            'PrintTheProject.Run()
            'SupportForSQLiteDatabase.Run()


            ' =====================================================
            ' =====================================================
            ' Reading Data
            ' =====================================================
            ' =====================================================

            'GetNumberOfPages.Run()
            'GetNumberOfPagesForViews.Run()
            'ReadOutlineCodes.Run()
            'ReadTableDataFromProjectFile.Run()


            ' =====================================================
            ' =====================================================
            ' Working With Calendars
            ' =====================================================
            ' =====================================================

            'CreatingCalendar.Run()
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

            'GetObjectByFieldMethods.Run()
            'MoveTaskAtTheEnd.Run()
            'MoveTaskUnderAnotherParent.Run()
            'MoveTaskUnderSameParent.Run()
            'ReadModuleAttributesInforamtion.Run()
            'ReadModulesInformation.Run()
            'ReadProjectFileFromStream.Run()
            'ReadProjectFiles.Run()
            'ReadReferencesInformation.Run()
            'ReplaceCalendar.Run()
            'SaveProjectDataAsTemplate.Run()
            'TaskSettingStartFinishDates.Run()
            'ReadPasswordProtectedProjectFile.Run()
            'UpdateProjectAndRescheduleUncompletedWork.Run()

            ' =====================================================
            ' =====================================================
            ' Working With VBA
            ' =====================================================
            ' =====================================================

            ' ReadVBAProjectInformation.Run()
            ' ReadReferencesInformation.Run()
            ' ReadModulesInformation.Run()
            ' ReadModuleAttributesInforamtion.Run()


            ' Stop before exiting
            Console.WriteLine(vbLf & vbLf & "Program Finished. Press any key to exit..")
            Console.ReadKey()
        End Sub

        Public Shared Function GetDataDir_Projects() As [String]
            Return Path.GetFullPath("././ProgrammersGuide/WorkingWithProjects/Data/")
        End Function

        Friend Shared Function GetDataDir_ReadingData() As String
            Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("ReadingData/"))
        End Function

        Friend Shared Function GetDataDir_WorkingWithCalendars() As String
            Return Path.GetFullPath(GetDataDir_Data() + "WorkingWithCalendars/")
        End Function

        Friend Shared Function GetDataDir_PrintingAndExporting() As String
            Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("PrintingAndExporting/"))
        End Function

        Friend Shared Function GetDataDir_ModifyingCreatedProject() As String
            Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("ModifyingCreatedProject/"))
        End Function


        Friend Shared Function GetDataDir_HandlingBasicProperties() As String
            Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("HandlingBasicProperties/"))
        End Function

        Friend Shared Function GetDataDir_WorkingWithProjects() As String
            Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("WorkingWithProjects/"))
        End Function

        Friend Shared Function GetDataDir_ManipulatingMPPFile() As String
            Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("ManipulatingMPPFile/"))
        End Function

        Friend Shared Function GetDataDir_CustomizingCreatedProject() As String
            Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("CustomizingCreatedProject/"))
        End Function

        Friend Shared Function GetDataDir_CreatingAndSaving() As String
            Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("CreatingAndSaving/"))
        End Function


        Private Shared Function GetDataDir_Data() As String
            Dim parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent
            Dim startDirectory As String = Nothing
            If parent IsNot Nothing Then
                Dim directoryInfo = parent.Parent
                If directoryInfo IsNot Nothing Then
                    startDirectory = directoryInfo.FullName
                End If
            Else
                startDirectory = parent.FullName
            End If
            Return If(startDirectory IsNot Nothing, Path.Combine(startDirectory, "Data\"), Nothing)
        End Function

    End Class
End Namespace
