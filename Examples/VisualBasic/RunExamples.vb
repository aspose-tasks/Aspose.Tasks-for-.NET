Imports System.IO
Imports Aspose.Tasks.Examples.VisualBasic.WorkingWithCalendars
Imports Aspose.Tasks.Examples.VisualBasic.WorkingWithProjects
Imports Aspose.Tasks.Examples.VisualBasic.WorkingWithProjects.CreatingReadingAndSaving
Imports Aspose.Tasks.Examples.VisualBasic.WorkingWithProjects.WorkingWithProjectProperties
Imports Aspose.Tasks.Examples.VisualBasic.WorkingWithProjects.WorkingWithExtendedAttributes
Imports Aspose.Tasks.Examples.VisualBasic.WorkingWithProjects.Miscellaneous
Imports Aspose.Tasks.Examples.VisualBasic.WorkingWithProjects.Printing
Imports Aspose.Tasks.Examples.VisualBasic.WorkingWithProjects.Rescheduling
Imports Aspose.Tasks.Examples.VisualBasic.WorkingWithProjects.ImportingAndExporting
Imports Aspose.Tasks.Examples.VisualBasic.WorkingWithProjects.WorkingWithProjectViews
Imports Aspose.Tasks.Examples.VisualBasic.WorkingWithCalendars.CreatingUpdatingAndRemoving
Imports Aspose.Tasks.Examples.VisualBasic.WorkingWithCalendarExceptions
Imports Aspose.Tasks.Examples.VisualBasic.WorkingWithTasks
Imports Aspose.Tasks.Examples.VisualBasic.WorkingWithTasks.WorkingWithTaskConstraints
Imports Aspose.Tasks.Examples.VisualBasic.WorkingWithTaskLinks
Imports Aspose.Tasks.Examples.VisualBasic.WorkingWithTaskBaselines
Imports Aspose.Tasks.Examples.VisualBasic.WorkingWithResources
Imports Aspose.Tasks.Examples.VisualBasic.WorkingWithResourceAssignments
Imports Aspose.Tasks.Examples.VisualBasic.WorkingWithFormulas
Imports Aspose.Tasks.Examples.VisualBasic.WorkingWithCurrencies
Imports Aspose.Tasks.Examples.VisualBasic.Miscellaneous
Imports Aspose.Tasks.Examples.VisualBasic.WorkingWithVBA
Imports Aspose.Tasks.Examples.VisualBasic.ConvertingProjectData

Class RunExamples

    Public Shared Sub Main()
        Console.WriteLine("Open RunExamples.vb. " & vbLf & "In Main() method, uncomment the example that you want to run")
        Console.WriteLine("=====================================================")

        ' Uncomment the one you want to try out

        ' =====================================================
        ' =====================================================
        ' Converting Project Data
        ' =====================================================
        ' =====================================================

        'ControlHeaderNameDuringHTMLExport.Run()
        'CustomizeDateFormats.Run()
        'CustomizeTextStyle.Run()
        'FitContentsToCellSize.Run()
        'HideLegendsDuringSave.Run()
        'PrintProjectPagesToSeparateFiles.Run()
        'RenderProjectDataToFormat24bppRgb.Run()
        'SaveProjectAsCSV.Run()
        'SaveProjectAsPDF.Run()
        'SaveProjectAsSVG.Run()
        'SaveProjectAsText.Run()
        'SaveProjectAsXLSX.Run()
        'SaveProjectDataAsHTML.Run()
        'SaveProjectDataAsTemplate.Run()
        'SaveProjectDataToSpreadsheet2003XML.Run
        'SaveToMultiplePDFFiles.Run()
        'UsingSpreadsheet2003SaveOptions.Run()
        'UsingSvgOptions.Run()
        'UsingXlsxOptions.Run()

        ' =====================================================
        ' =====================================================
        ' Miscellaneous
        ' =====================================================
        ' =====================================================

        'HandleExceptions.Run()
        'PerformRiskAnalysis.Run()
        'SaveBestPracticeAnalyzerReport.Run()
        'SaveBurnDownReport.Run()
        'SaveCashFlowReport.Run()
        'SaveCostOverrunsReport.Run()
        'SaveCostOverviewReport.Run()
        'SaveCriticalTasksReport.Run()
        'SaveLateTasksReport.Run()
        'SaveMilestonesReport.Run()
        'SaveOverallocatedResourcesReport.Run()
        'SaveProjectOverviewReport.Run()
        'SaveResourceCostOverviewReport.Run()
        'SaveResourceOverviewReport.Run()
        'SaveSlippingTasksReport.Run()
        'SaveTaskCostOverviewReport.Run()
        'SaveUpcomingTasksReport.Run()
        'SaveWorkOverviewReport.Run()
        'SortResourcesByName.Run()
        'SortTasksByName.Run()
        'UpdateOutlineCodes.Run()
        'WriteMetadataToMPP.Run()

        ' =====================================================
        ' =====================================================
        ' Working With Calendar Exceptions
        ' =====================================================
        ' =====================================================

        'RetrieveCalendarExceptions.Run()
        'AddRemoveCalendarExceptions.Run()
        'DefineWeekdayExceptions.Run()
        'HandleExceptionOccurences.Run()

        ' =====================================================
        ' =====================================================
        ' Working With Calendars
        ' =====================================================
        ' =====================================================

        'CalculateWorkHours.Run()
        'GeneralCalendarProperties.Run()
        'ReadWorkWeeksInformation.Run()
        'RetrieveCalendarInfo.Run()

        ' Creating, Updating and Removing
        ' =====================================================

        'CreatingCalendar.Run()
        'DefineWeekdaysForCalendar.Run()
        'MakeAStandardCalendar.Run()
        'ReplaceCalendar.Run()
        'ReplaceCalendarWithNewCalendar.Run()
        'WriteUpdatedCalendarDataToMPP.Run()

        ' =====================================================
        ' =====================================================
        ' Working With Currencies
        ' =====================================================
        ' =====================================================

        'GetCurrencyCodes.Run()
        'GetCurrencyDigits.Run()
        'GetCurrencySymbol.Run()
        'SetCurrencyCodes.Run()
        'SetCurrencyDigits.Run()
        'SetCurrencySymbol.Run()

        ' =====================================================
        ' =====================================================
        ' Working With Formulas
        ' =====================================================
        ' =====================================================

        'AccessReadOnlyCustomFieldValuesUsingFormulas.Run()
        'CalculateDateTimeFunctions.Run()
        'CalculateGeneralFunctions.Run()
        'CalculateMathExpressions.Run()
        'CalculateTextFunctions.Run()
        'FormulaWithBooleanValues.Run()
        'FormulaWithProjectFields.Run()
        'ReadFormulasExtendedAttributesFromMPP.Run()
        'UsingArithmeticExpression.Run()
        'UsingTaskNumberFields.Run()
        'UsingTasksAndResourceFieldsInFormulaCalculations.Run()
        'WriteFormulasInExtendedAttributesToMPP.Run()

        ' =====================================================
        ' =====================================================
        ' Working With Projects
        ' =====================================================
        ' =====================================================

        'AddImageToPageHeaderFooter.Run()
        'GetNumberOfPages.Run()
        'GetNumberOfPagesForViews.Run()
        'MPPFileUpdate.Run()
        'ReadHeaderFooterInfo.Run()
        'ReadOutlineCodes.Run()
        'SaveProjectDataAsTemplate.Run()
        'TaskSettingStartFinishDates.Run()

        ' Creating, Reading and Saving
        ' =====================================================

        'CreateEmptyProjectSaveXML.Run()
        'CreateEmptyProjectSaveStream.Run()
        'IgnoreInvalidCharactersDuringloadingProject.Run()
        'ImportProjectDataFromDatabase.Run()
        'ReadPasswordProtectedProjectFile.Run()
        'ReadProjectFileFromStream.Run()
        'ReadProjectFiles.Run()

        ' Importing and Exporting
        ' =====================================================

        'ExportProjectDataToPrimaveraMPXFormat.Run()
        'ExportProjectDataToXERFormat.Run()
        'ExportProjectDataToXMLFormat.Run()
        'ImportDataFromXMLFileFormats.Run()
        'SupportForSQLiteDatabase.Run()
        'UsingPrimaveraXMLSaveOptions.Run()

        ' Miscellaneous
        ' =====================================================

        'CalculateCriticalPath.Run()
        'EmbeddedObjectsCreatedInsideApplication.Run()
        'PrintTaskWritingException.Run()
        'ReadFilterCriteriaData.Run()
        'ReadFilterDefinitionData.Run()
        'ReadGroupDefinitionData.Run()
        'ReadTableDataFromProjectFile.Run()

        ' Printing
        ' =====================================================

        'PrintProjectUsingCustomPrinter.Run()
        'PrintTheProject.Run()

        ' Rescheduling
        ' =====================================================

        'RescheduleProjectFromFinishDate.Run()
        'RescheduleProjectFromStartDate.Run()
        'RescheduleProjectStartOrFinishDate.Run()
        'UpdateProjectAndRescheduleUncompletedWork.Run()

        ' Working with Extended Attributes
        ' =====================================================

        'CreateExtendedAttributes.Run()
        'WriteExtendedAttributes.Run()
        'WriteUpdatedExtendedAttributeDefinitions.Run()

        ' Working with Project properties
        ' =====================================================

        'ApplyCalculationModeAuto.Run()
        'ApplyCalculationModeManual.Run()
        'ApplyCalculationModeNone.Run()
        'DetermineProjectVersion.Run()
        'ReadCurrencyProperties.Run()
        'ReadDefaultProperties.Run()
        'ReadFiscalYearProperties.Run()
        'ReadProjectInfo.Run()
        'ReadWeekdayProperties.Run()
        'SetAttributesForNewTasks.Run()
        'WriteCurrencyProperties.Run()
        'WriteDefaultProperties.Run()
        'WriteFiscalYearProperties.Run()
        'WriteMPPProjectSummary.Run()
        'WriteProjectInfo.Run()
        'WriteWeekdayProperties.Run()

        ' Working with Project Views
        ' =====================================================

        'ConfigureGantChart.Run()
        'ConfigureTheGantChartViewShowSelectedColumnFields.Run()
        'CustomizeTimescaleTierLabels.Run()
        'ReadSpecificGantChartViewData.Run()
        'SetTimeScaleCount.Run()

        ' =====================================================
        ' =====================================================
        ' Working With Resource Assignments
        ' =====================================================
        ' =====================================================

        'CreateResourceAssignments.Run()
        'GenerateResourceAssignmentTimephasedData.Run()
        'GetGeneralResourceAssignmentProperties.Run()
        'GetResourceAssignmentBudget.Run()
        'GetResourceAssignmentCosts.Run()
        'GetResourceAssignmentOvertimes.Run()
        'GetResourceAssignmentPercentWorkComplete.Run()
        'GetResourceAssignmentStopResumeDates.Run()
        'GetResourceAssignmentVariance.Run()
        'SetGeneralResourceAssignmentProperties.Run()
        'UpdateResourceAssignmentInMPP.Run()

        ' =====================================================
        ' =====================================================
        ' Working With Resources
        ' =====================================================
        ' =====================================================

        'CreateResources.Run()
        'GetResourceCalendar.Run()
        'GetResourceCosts.Run()
        'GetResourceOvertime.Run()
        'GetResourcePercentWorkComplete.Run()
        'GetResourceWorkVariance.Run()
        'ReadResourceTimephasedData.Run()
        'RenderResourceSheetView.Run()
        'RenderResourceUsageView.Run()
        'SetGeneralResourceProperties.Run()
        'SetResourceCalendar.Run()
        'SetResourceExtendedAttributes.Run()
        'UpdateResourceDataInMPP.Run()

        ' =====================================================
        ' =====================================================
        ' Working With Task Baselines
        ' =====================================================
        ' =====================================================

        'CreateTaskBaseline.Run()
        'GetTaskBaselineDuration.Run()
        'GetTaskBaselineSchedule.Run()

        ' =====================================================
        ' =====================================================
        ' Working With Task Links
        ' =====================================================
        ' =====================================================

        'CreateTaskLinks.Run()
        'GetCrossProjectTaskLinks.Run()
        'GetPredecessorSuccessorTasks.Run()
        'GetTaskLinkType.Run()
        'IdentifyCrossProjectTasks.Run()
        'SetTaskLinkType.Run()

        ' =====================================================
        ' =====================================================
        ' Working With Tasks
        ' =====================================================
        ' =====================================================

        'AddTaskExtendedAttributes.Run()
        'CalculateSplitTaskFinishDate.Run()
        'CalculateTaskDurations.Run()
        'ChangeTaskProgress.Run()
        'CreateSplitTasks.Run()
        'CreateSubProjectTask.Run()
        'CreateTasks.Run()
        'FindCriticalEffortDrivenTasks.Run()
        'FindEstimatedMilestoneTasks.Run()
        'MoveTaskAtTheEnd.Run()
        'MoveTaskUnderAnotherParent.Run()
        'MoveTaskUnderSameParent.Run()
        'ReadActualTaskProperties.Run()
        'ReadBudgetWorkAndCost.Run()
        'ReadParentChildTasks.Run()
        'ReadStopResumeDates.Run()
        'ReadTaskCalendar.Run()
        'ReadTaskCosts.Run()
        'ReadTaskExtendedAttributes.Run()
        'ReadTaskOutlineProperties.Run()
        'ReadTaskOvertimes.Run()
        'ReadTaskPercentageCompletion.Run()
        'ReadTaskPriority.Run()
        'ReadTaskProperties.Run()
        'ReadTaskWBS.Run()
        'ReadWriteTimephasedData.Run()
        'RenderTaskSheetView.Run()
        'RenderTaskUsageView.Run()
        'RenderTaskUsageViewWithDetails.Run()
        'UpdateTaskData.Run()
        'ViewSplitTasks.Run()
        'WriteTaskCalendar.Run()
        'WriteTaskDuration.Run()
        'WriteTaskProperties.Run()

        ' Working with Task Constraints
        ' =====================================================

        'GetConstraints.Run()
        'SetConstraintAsLateAsPossible.Run()
        'SetConstraintFinishNoEarlierThan.Run()
        'SetConstraintMustFinishOn.Run()
        'SetConstraintMustStartOn.Run()
        'SetConstraintStartNoEarlierThan.Run()

        ' =====================================================
        ' =====================================================
        ' Working With VBA
        ' =====================================================
        ' =====================================================

        'ReadModuleAttributesInformation.Run()
        'ReadModulesInformation.Run()
        'ReadReferencesInformation.Run()
        'ReadVBAProjectInformation.Run()

        ' Stop before exiting
        Console.WriteLine(vbLf & vbLf & "Program Finished. Press any key to exit..")
        Console.ReadKey()
    End Sub

    Public Shared Function GetDataDir(exampleName As String) As String
        Dim categoryName As String = exampleName
        categoryName = categoryName.Replace("Aspose.Tasks.Examples.VisualBasic.", "")
        categoryName = categoryName.Substring(0, categoryName.IndexOf("."))
        categoryName = categoryName.Replace(".", Path.DirectorySeparatorChar)
        Dim p As String = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..", "Data", categoryName))
        p &= Path.DirectorySeparatorChar

        If Directory.Exists(p) Then
            Console.WriteLine("Using Data Dir {0}", p)
        Else
            Directory.CreateDirectory(p)
            Console.WriteLine("Created Data Dir {0}", p)
        End If
        Return p
    End Function
End Class
