// ReSharper disable RedundantUsingDirective
namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.IO;
    using System.Reflection;
    using Aspose.Tasks;
    using Aspose.Tasks.Examples.CSharp.Articles;
    using Aspose.Tasks.Examples.CSharp.ConvertingProjectData;
    using Aspose.Tasks.Examples.CSharp.KnowledgeBase;
    using Aspose.Tasks.Examples.CSharp.Miscellaneous;
    using Aspose.Tasks.Examples.CSharp.WorkingWithCalendarExceptions;
    using Aspose.Tasks.Examples.CSharp.WorkingWithCalendars;
    using Aspose.Tasks.Examples.CSharp.WorkingWithCalendars.CreatingUpdatingAndRemoving;
    using Aspose.Tasks.Examples.CSharp.WorkingWithCurrencies;
    using Aspose.Tasks.Examples.CSharp.WorkingWithFormulas;
    using Aspose.Tasks.Examples.CSharp.WorkingWithProjects;
    using Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving;
    using Aspose.Tasks.Examples.CSharp.WorkingWithProjects.ImportingAndExporting;
    using Aspose.Tasks.Examples.CSharp.WorkingWithProjects.Miscellaneous;
    using Aspose.Tasks.Examples.CSharp.WorkingWithProjects.Printing;
    using Aspose.Tasks.Examples.CSharp.WorkingWithProjects.Rescheduling;
    using Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithExtendedAttributes;
    using Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithProjectProperties;
    using Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithProjectViews;
    using Aspose.Tasks.Examples.CSharp.WorkingWithResourceAssignments;
    using Aspose.Tasks.Examples.CSharp.WorkingWithResources;
    using Aspose.Tasks.Examples.CSharp.WorkingWithTaskBaselines;
    using Aspose.Tasks.Examples.CSharp.WorkingWithTaskLinks;
    using Aspose.Tasks.Examples.CSharp.WorkingWithTasks;
    using Aspose.Tasks.Examples.CSharp.WorkingWithTasks.WorkingWithTaskConstraints;
    using Aspose.Tasks.Examples.CSharp.WorkingWithVBA;
    using Licensing;

    internal class RunExamples
    {
        public static void Main()
        {
            Console.WriteLine("Open RunExamples.cs. \nIn Main() method, uncomment the example that you want to run");
            Console.WriteLine("=====================================================");

            RunAllExamples();
            
            // License lic = new License();
            // lic.SetLicense(@"Aspose.Total.NET.lic");

            // Uncomment the one you want to try out

            // =====================================================
            // =====================================================
            // Articles
            // =====================================================
            // =====================================================

            // AlignCellContents.Run();
            // ChangeGanttBarsColorGradient.Run();
            // ImplementCustomBarStyleWriting.Run();
            // ReadCustomBarStyle.Run();
            // RenderDifferentPresentationFormatsToXAML.Run();
            // RenderGanttChartWithBarsNotRolledUp.Run();
            // RenderGanttChartWithBarsRolledUp.Run();
            // RenderMultipageTIFF.Run();
            // RenderProjectToPredefinedPageSizes.Run();
            // RenderToXAML.Run();
            // RenderXAMLWithOptions.Run();
            // RetrieveTaskEmbeddedDocuments.Run();
            // SetGanttChartViewStartDate.Run();
            // SortTasksByColumnInGanttChart.Run();
            // TimescaleSettings.Run();
            // CustomizeTextWithTaskBars.Run();

            // Converting Project Data
            // =====================================================
            
            // AddDefaultFontDuringSavingAsPDF.Run();
            // ControlHeaderNameDuringHTMLExport.Run();
            // CustomizeDateFormats.Run();
            // CustomizeTextStyle.Run();
            // FitContentsToCellSize.Run();
            // HideLegendsDuringSave.Run();
            // PrintProjectPagesToSeparateFiles.Run();
            // ReducingGapBetweenTasksListAndFooter.Run();
            // RenderProjectDataToFormat24bppRgb.Run();
            // SaveProjectAsCSV.Run();
            // SaveProjectAsJPEG.Run();
            // SaveProjectAsPDF.Run();
            // SaveProjectAsSVG.Run();
            // SaveProjectAsText.Run();
            // SaveProjectAsXLSX.Run();
            // SaveProjectDataAsHTML.Run();
            // SaveProjectDataAsTemplate.Run();
            // SaveProjectDataToSpreadsheet2003XML.Run();
            // SaveToMultiplePDFFiles.Run();
            // UsingSpreadsheet2003SaveOptions.Run();
            // UsingSvgOptions.Run();
            // UsingXlsxOptions.Run();
            // RenderCommentsWhenConverting.Run();
            // AddingCssStylePrefix.Run();

            // =====================================================
            // =====================================================
            // Knowledge Base
            // =====================================================
            // =====================================================

            // AddNewTask.Run();
            // CreateResourcesAndLinkToTasks.Run();
            // LinkTasks.Run();
            // ReadCriticalPath.Run();
            // ReadTaskAndResources.Run();

            // =====================================================
            // =====================================================
            // Miscellaneous
            // =====================================================
            // =====================================================

            // HandleExceptions.Run();
            // PerformRiskAnalysis.Run();
            // SaveProjectReports.Run();
            // SaveProjectOverviewReport.Run();
            // SortResourcesByName.Run();
            // SortTasksByName.Run();
            // UpdateOutlineCodes.Run();
            // WriteMetadataToMPP.Run();
            // ApplyLicenseUsingFile.Run();
            // ApplyLicenseUsingStream.Run();
            // EvaluationDateTimeLimitations.Run();

            // =====================================================
            // =====================================================
            // Working With Calendar Exceptions
            // =====================================================
            // =====================================================

            // RetrieveCalendarExceptions.Run();
            // AddRemoveCalendarExceptions.Run();
            // DefineWeekdayExceptions.Run();
            // HandleExceptionOccurrences.Run();

            // =====================================================
            // =====================================================
            // Working With Calendars
            // =====================================================
            // =====================================================

            // CalculateWorkHours.Run();            
            // GeneralCalendarProperties.Run();
            // ReadWorkWeeksInformation.Run();
            // RetrieveCalendarInfo.Run();  

            // Creating, Updating and Removing
            // =====================================================

            // CreatingCalendar.Run();
            // DefineWeekdaysForCalendar.Run();
            // MakeAStandardCalendar.Run();
            // ReplaceCalendar.Run();
            // WriteUpdatedCalendarDataToMPP.Run();

            // =====================================================
            // =====================================================
            // Working With Currencies
            // =====================================================
            // =====================================================

            // GetCurrencyCodes.Run();
            // GetCurrencyDigits.Run();
            // GetCurrencySymbol.Run();
            // SetCurrencyCodes.Run();
            // SetCurrencyDigits.Run();
            // SetCurrencySymbol.Run();

            // =====================================================
            // =====================================================
            // Working With Formulas
            // =====================================================
            // =====================================================

            // AccessReadOnlyCustomFieldValuesUsingFormulas.Run();
            // CalculateDateTimeFunctions.Run();
            // CalculateGeneralFunctions.Run();
            // CalculateMathExpressions.Run();
            // CalculateTextFunctions.Run();
            // FormulaWithBooleanValues.Run();
            // FormulaWithProjectFields.Run();
            // ReadFormulasExtendedAttributesFromMPP.Run();
            // UsingArithmeticExpression.Run();
            // UsingTaskNumberFields.Run();
            // UsingTasksAndResourceFieldsInFormulaCalculations.Run();
            // WriteFormulasInExtendedAttributesToMPP.Run();

            // =====================================================
            // =====================================================
            // Working With Projects
            // =====================================================
            // =====================================================

            // CreateEmptyProjectSaveMPP.Run();
            // ProjectCreation.Run();
            // ProjectCopying.Run();
            // CreateProjectWithLoadOptions.Run();
            // AddImageToPageHeaderFooter.Run();
            // GetNumberOfPages.Run();
            // GetNumberOfPagesForViews.Run();
            // GetPageCountOnStartAndEndDates.Run();
            // MPPFileUpdate.Run();
            // ReadHeaderFooterInfo.Run();
            // WorkingWithOutlineCodes.Run();
            // SaveProjectDataAsTemplate.Run();
            // ProjectRecalculations.Run();
            // CreateProjectOnline.Run();
            // ReadingProjectOnline.Run();
            // ReadAndCreateInProjectServer.Run();

            // Creating, Reading and Saving
            // =====================================================

            // CreateEmptyProjectSaveXML.Run();
            // CreateEmptyProjectSaveStream.Run();
            // IgnoreInvalidCharactersDuringProjectLoading.Run();
            // ImportProjectDataFromDatabase.Run();
            // ReadPasswordProtectedProjectFile.Run();
            // ReadProjectFileFromStream.Run();
            // ReadProjectFiles.Run();
            // WorkingWithEncodings.Run();
            // ReadProjectUIDsFromXMLFile.Run();
            // ReadXMLFileWithMultipleProjects.Run();
            // ImportDataFromMPXFileFormats.Run();

            // Importing and Exporting
            // =====================================================

            // ExportProjectDataToPrimaveraMPXFormat.Run();
            // ExportProjectDataToXERFormat.Run();
            // ExportProjectDataToP6XMLFormat.Run();
            // ImportDataFromXMLFileFormats.Run();
            // ImportProjectFromPrimaveraDBSQLite.Run();
            // ImportProjectDataFromMPDFile.Run();
            // ImportProjectFromPrimaveraDB.Run();
            // ExportProjectDataToPrimaveraXML.Run(); 

            // Project's Miscellaneous
            // =====================================================

            // CalculateCriticalPath.Run();
            // EmbeddedObjectsCreatedInsideApplication.Run();
            // ExtractEmbeddedObjects.Run();
            // PrintTaskWritingException.Run();
            // ReadFilterCriteriaData.Run();
            // ReadFilterDefinitionData.Run();
            // ReadGroupDefinitionData.Run();
            // ReadTableDataFromProjectFile.Run();
            // ReadWriteProjectCustomProperties.Run();
            // GetProjectDefaultWeekWorkingDays.Run();
            // ProjectDisplayOptionsUsage.Run();
            // WorkWithBaselineSaveTime.Run();
            // WorkWithDurations.Run();

            // Printing
            // =====================================================

            // PrintProjectUsingCustomPrinter.Run();
            // PrintTheProject.Run();
            // PrintLargeFiles.Run();
            // PrintPrintOptionsAndPrinterSettings.Run();

            // Rescheduling
            // =====================================================

            // RescheduleProjectFromFinishDate.Run();
            // RescheduleProjectFromStartDate.Run();
            // UpdateProjectAndRescheduleUncompletedWork.Run();

            // Working with Extended Attributes
            // =====================================================

            // CreateExtendedAttributes.Run();
            // WriteExtendedAttributes.Run();
            // WriteUpdatedExtendedAttributeDefinitions.Run();

            // Working with Project properties
            // =====================================================

            // ApplyCalculationModeAuto.Run();
            // ApplyCalculationModeManual.Run();
            // ApplyCalculationModeNone.Run();
            // DetermineProjectVersion.Run();
            // ReadCurrencyProperties.Run();
            // ReadDefaultProperties.Run();
            // ReadFiscalYearProperties.Run();
            // ReadProjectInfo.Run();
            // ReadWeekdayProperties.Run();
            // SetAttributesForNewTasks.Run();
            // WriteCurrencyProperties.Run();
            // WriteDefaultProperties.Run();
            // WriteFiscalYearProperties.Run();
            // WriteMPPProjectSummary.Run();
            // WriteProjectInfo.Run();
            // WriteWeekdayProperties.Run();
            // ReadMetaProperties.Run();

            // Working with Project Views
            // =====================================================

            // ConfigureGanttChart.Run();
            // CustomizeTimescaleTierLabels.Run();
            // ReadSpecificGanttChartViewData.Run();
            // SetTimeScaleCount.Run();
            // SupportForTextStyle.Run();
            // SaveWithDefaultGanttChartView.Run();

            // =====================================================
            // =====================================================
            // Working With Resource Assignments
            // =====================================================
            // =====================================================

            // AddExtendedAttributesToResourceAssignment.Run();
            // AddExtendedAttributesToRAWithLookUp.Run();
            // CreateResourceAssignments.Run();
            // GenerateResourceAssignmentTimephasedData.Run();
            // GetGeneralResourceAssignmentProperties.Run();
            // GetResourceAssignmentBudget.Run();
            // GetResourceAssignmentCosts.Run();
            // GetResourceAssignmentOvertimes.Run();
            // GetResourceAssignmentPercentWorkComplete.Run();
            // GetResourceAssignmentStopResumeDates.Run();
            // GetResourceAssignmentVariance.Run();
            // UpdateResourceAssignmentInMPP.Run();
            // ReadWriteRateScaleForResourceAssignment.Run();
            // CreateMultipleResourceAssignmentsForOneTask.Run();
            // SetGeneralResourceAssignmentProperties.Run();

            // =====================================================
            // =====================================================
            // Working With Resources
            // =====================================================
            // =====================================================

            // CreateResources.Run();
            // GetResourceCalendar.Run();
            // GetResourceCosts.Run();
            // GetResourceOvertime.Run();
            // GetResourcePercentWorkComplete.Run();
            // GetResourceWorkVariance.Run();
            // ReadResourceTimephasedData.Run();
            // RenderResourceSheetView.Run();
            // RenderResourceUsageView.Run();
            // SetGeneralResourceProperties.Run();
            // SetResourceCalendar.Run();
            // SetResourceExtendedAttributes.Run();
            // UpdateResourceDataInMPP.Run();
            // ResourcePrefixForNestedResources.Run();

            // =====================================================
            // =====================================================
            // Working With Task Baselines
            // =====================================================
            // =====================================================

            // CreateTaskBaseline.Run();
            // GetTaskBaselineDuration.Run();

            // =====================================================
            // =====================================================
            // Working With Task Links
            // =====================================================
            // =====================================================

            // CreateTaskLinks.Run();
            // GetCrossProjectTaskLinks.Run();
            // GetPredecessorSuccessorTasks.Run();
            // GetTaskLinkType.Run();
            // IdentifyCrossProjectTasks.Run();
            // SetTaskLinkType.Run();

            // =====================================================
            // =====================================================
            // Working With Tasks
            // =====================================================
            // =====================================================

            // AddTaskExtendedAttributes.Run();
            // AddWBSCodes.Run();
            // CalculateSplitTaskFinishDate.Run();
            // CalculateTaskDurations.Run();
            // ChangeTaskProgress.Run();
            // CreateSplitTasks.Run();
            // CreateSubProjectTask.Run();
            // CreateTasks.Run();
            // FindCriticalEffortDrivenTasks.Run();
            // FindEstimatedMilestoneTasks.Run();
            // MoveTaskAtTheEnd.Run();
            // MoveTaskUnderAnotherParent.Run();
            // MoveTaskUnderSameParent.Run();
            // ReadActualTaskProperties.Run();
            // ReadBudgetWorkAndCost.Run();
            // ReadParentChildTasks.Run();
            // ReadStopResumeDates.Run();
            // ReadTaskCalendar.Run();
            // ReadTaskCosts.Run();
            // ReadTaskExtendedAttributes.Run();
            // ReadTaskOutlineProperties.Run();
            // ReadTaskOvertimes.Run();
            // ReadTaskPercentageCompletion.Run();
            // ReadTaskPriority.Run();
            // ReadTaskProperties.Run();
            // ReadTaskWBS.Run();
            // ReadWriteTimephasedData.Run();
            // RenderTaskSheetView.Run();
            // RenderTaskUsageView.Run();
            // RenderTaskUsageViewWithDetails.Run();
            // RenumberTaskWBSCodes.Run();
            // UpdateTaskData.Run();
            // ViewSplitTasks.Run();
            // WriteTaskCalendar.Run();
            // WriteTaskDuration.Run();
            // WriteTaskProperties.Run();
            // TaskWarning.Run();
            // CreateRecurringTask.Run();

            // Working with Task Constraints
            // =====================================================

            // GetConstraints.Run();
            // WorkWithConstraints.Run();

            // =====================================================
            // =====================================================
            // Working With VBA
            // =====================================================
            // =====================================================

            // ReadModuleAttributesInformation.Run();
            // ReadModulesInformation.Run();
            // ReadReferencesInformation.Run();
            // ReadVBAProjectInformation.Run();

            // Stop before exiting
            Console.WriteLine("\n\nProgram Finished. Press any key to exit..");
            Console.ReadKey();
        }

        private static void RunAllExamples()
        {
            // License lic = new License();
            // lic.SetLicense(@"Aspose.Total.NET.lic");

            // Uncomment the one you want to try out

            // =====================================================
            // =====================================================
            // Articles
            // =====================================================
            // =====================================================

            AlignCellContents.Run();
            ChangeGanttBarsColorGradient.Run();
            ImplementCustomBarStyleWriting.Run();
            ReadCustomBarStyle.Run();
            RenderDifferentPresentationFormatsToXAML.Run();
            RenderGanttChartWithBarsNotRolledUp.Run();
            RenderGanttChartWithBarsRolledUp.Run();
            RenderMultipageTIFF.Run();
            RenderProjectToPredefinedPageSizes.Run();
            RenderToXAML.Run();
            RenderXAMLWithOptions.Run();
            RetrieveTaskEmbeddedDocuments.Run();
            SetGanttChartViewStartDate.Run();
            SortTasksByColumnInGanttChart.Run();
            TimescaleSettings.Run();
            CustomizeTextWithTaskBars.Run();

            // Converting Project Data
            // =====================================================
            
            AddDefaultFontDuringSavingAsPDF.Run();
            ControlHeaderNameDuringHTMLExport.Run();
            CustomizeDateFormats.Run();
            CustomizeTextStyle.Run();
            FitContentsToCellSize.Run();
            HideLegendsDuringSave.Run();
            PrintProjectPagesToSeparateFiles.Run();
            ReducingGapBetweenTasksListAndFooter.Run();
            RenderProjectDataToFormat24bppRgb.Run();
            SaveProjectAsCSV.Run();
            SaveProjectAsJPEG.Run();
            SaveProjectAsPDF.Run();
            SaveProjectAsSVG.Run();
            SaveProjectAsText.Run();
            SaveProjectAsXLSX.Run();
            SaveProjectDataAsHTML.Run();
            SaveProjectDataAsTemplate.Run();
            SaveProjectDataToSpreadsheet2003XML.Run();
            SaveToMultiplePDFFiles.Run();
            UsingSpreadsheet2003SaveOptions.Run();
            UsingSvgOptions.Run();
            UsingXlsxOptions.Run();
            RenderCommentsWhenConverting.Run();
            AddingCssStylePrefix.Run();

            // =====================================================
            // =====================================================
            // Knowledge Base
            // =====================================================
            // =====================================================

            AddNewTask.Run();
            CreateResourcesAndLinkToTasks.Run();
            LinkTasks.Run();
            ReadCriticalPath.Run();
            ReadTaskAndResources.Run();

            // =====================================================
            // =====================================================
            // Miscellaneous
            // =====================================================
            // =====================================================

            HandleExceptions.Run();
            PerformRiskAnalysis.Run();
            SaveProjectReports.Run();
            SaveProjectOverviewReport.Run();
            SortResourcesByName.Run();
            SortTasksByName.Run();
            UpdateOutlineCodes.Run();
            WriteMetadataToMPP.Run();
            ApplyLicenseUsingFile.Run();
            ApplyLicenseUsingStream.Run();
            EvaluationDateTimeLimitations.Run();

            // =====================================================
            // =====================================================
            // Working With Calendar Exceptions
            // =====================================================
            // =====================================================

            RetrieveCalendarExceptions.Run();
            AddRemoveCalendarExceptions.Run();
            DefineWeekdayExceptions.Run();
            HandleExceptionOccurrences.Run();

            // =====================================================
            // =====================================================
            // Working With Calendars
            // =====================================================
            // =====================================================

            CalculateWorkHours.Run();            
            GeneralCalendarProperties.Run();
            ReadWorkWeeksInformation.Run();
            RetrieveCalendarInfo.Run();  

            // Creating, Updating and Removing
            // =====================================================

            CreatingCalendar.Run();
            DefineWeekdaysForCalendar.Run();
            MakeAStandardCalendar.Run();
            ReplaceCalendar.Run();
            WriteUpdatedCalendarDataToMPP.Run();

            // =====================================================
            // =====================================================
            // Working With Currencies
            // =====================================================
            // =====================================================

            GetCurrencyCodes.Run();
            GetCurrencyDigits.Run();
            GetCurrencySymbol.Run();
            SetCurrencyCodes.Run();
            SetCurrencyDigits.Run();
            SetCurrencySymbol.Run();

            // =====================================================
            // =====================================================
            // Working With Formulas
            // =====================================================
            // =====================================================

            AccessReadOnlyCustomFieldValuesUsingFormulas.Run();
            CalculateDateTimeFunctions.Run();
            CalculateGeneralFunctions.Run();
            CalculateMathExpressions.Run();
            CalculateTextFunctions.Run();
            FormulaWithBooleanValues.Run();
            FormulaWithProjectFields.Run();
            ReadFormulasExtendedAttributesFromMPP.Run();
            UsingArithmeticExpression.Run();
            UsingTaskNumberFields.Run();
            UsingTasksAndResourceFieldsInFormulaCalculations.Run();
            WriteFormulasInExtendedAttributesToMPP.Run();

            // =====================================================
            // =====================================================
            // Working With Projects
            // =====================================================
            // =====================================================

            CreateEmptyProjectSaveMPP.Run();
            ProjectCreation.Run();
            ProjectCopying.Run();
            CreateProjectWithLoadOptions.Run();
            AddImageToPageHeaderFooter.Run();
            GetNumberOfPages.Run();
            GetNumberOfPagesForViews.Run();
            GetPageCountOnStartAndEndDates.Run();
            MPPFileUpdate.Run();
            ReadHeaderFooterInfo.Run();
            WorkingWithOutlineCodes.Run();
            SaveProjectDataAsTemplate.Run();
            ProjectRecalculations.Run();
            CreateProjectOnline.Run();
            UpdateProjectOnline.Run();
            ReadingProjectOnline.Run();
            ReadAndCreateInProjectServer.Run();
            UpdateInProjectServer.Run();

            // Creating, Reading and Saving
            // =====================================================

            CreateEmptyProjectSaveXML.Run();
            CreateEmptyProjectSaveStream.Run();
            IgnoreInvalidCharactersDuringProjectLoading.Run();
            ImportProjectDataFromDatabase.Run();
            ReadPasswordProtectedProjectFile.Run();
            ReadProjectFileFromStream.Run();
            ReadProjectFiles.Run();
            WorkingWithEncodings.Run();
            ReadProjectUIDsFromXMLFile.Run();
            ReadXMLFileWithMultipleProjects.Run();
            ImportDataFromMPXFileFormats.Run();

            // Importing and Exporting
            // =====================================================

            ExportProjectDataToPrimaveraMPXFormat.Run();
            ExportProjectDataToXERFormat.Run();
            ExportProjectDataToP6XMLFormat.Run();
            ImportDataFromXMLFileFormats.Run();
            ImportProjectFromPrimaveraDBSQLite.Run();
            // ImportProjectDataFromMPDFile.Run();
            ImportProjectFromPrimaveraDB.Run();
            ExportProjectDataToPrimaveraXML.Run(); 

            // Project's Miscellaneous
            // =====================================================

            CalculateCriticalPath.Run();
            EmbeddedObjectsCreatedInsideApplication.Run();
            ExtractEmbeddedObjects.Run();
            PrintTaskWritingException.Run();
            ReadFilterCriteriaData.Run();
            ReadFilterDefinitionData.Run();
            ReadGroupDefinitionData.Run();
            ReadTableDataFromProjectFile.Run();
            ReadWriteProjectCustomProperties.Run();
            GetProjectDefaultWeekWorkingDays.Run();
            ProjectDisplayOptionsUsage.Run();
            WorkWithBaselineSaveTime.Run();
            WorkWithDurations.Run();

            // Printing
            // =====================================================

            // PrintProjectUsingCustomPrinter.Run();
            // PrintTheProject.Run();
            // PrintLargeFiles.Run();
            // PrintPrintOptionsAndPrinterSettings.Run();

            // Rescheduling
            // =====================================================

            RescheduleProjectFromFinishDate.Run();
            RescheduleProjectFromStartDate.Run();
            UpdateProjectAndRescheduleUncompletedWork.Run();

            // Working with Extended Attributes
            // =====================================================

            CreateExtendedAttributes.Run();
            WriteExtendedAttributes.Run();
            WriteUpdatedExtendedAttributeDefinitions.Run();

            // Working with Project properties
            // =====================================================

            ApplyCalculationModeAuto.Run();
            ApplyCalculationModeManual.Run();
            ApplyCalculationModeNone.Run();
            DetermineProjectVersion.Run();
            ReadCurrencyProperties.Run();
            ReadDefaultProperties.Run();
            ReadFiscalYearProperties.Run();
            ReadProjectInfo.Run();
            ReadWeekdayProperties.Run();
            SetAttributesForNewTasks.Run();
            WriteCurrencyProperties.Run();
            WriteDefaultProperties.Run();
            WriteFiscalYearProperties.Run();
            WriteMPPProjectSummary.Run();
            WriteProjectInfo.Run();
            WriteWeekdayProperties.Run();
            ReadMetaProperties.Run();

            // Working with Project Views
            // =====================================================

            ConfigureGanttChart.Run();
            CustomizeTimescaleTierLabels.Run();
            ReadSpecificGanttChartViewData.Run();
            SetTimeScaleCount.Run();
            SupportForTextStyle.Run();
            SaveWithDefaultGanttChartView.Run();

            // =====================================================
            // =====================================================
            // Working With Resource Assignments
            // =====================================================
            // =====================================================

            AddExtendedAttributesToResourceAssignment.Run();
            AddExtendedAttributesToRAWithLookUp.Run();
            CreateResourceAssignments.Run();
            // GenerateResourceAssignmentTimephasedData.Run();
            GetGeneralResourceAssignmentProperties.Run();
            GetResourceAssignmentBudget.Run();
            GetResourceAssignmentCosts.Run();
            GetResourceAssignmentOvertimes.Run();
            GetResourceAssignmentPercentWorkComplete.Run();
            GetResourceAssignmentStopResumeDates.Run();
            GetResourceAssignmentVariance.Run();
            UpdateResourceAssignmentInMPP.Run();
            ReadWriteRateScaleForResourceAssignment.Run();
            CreateMultipleResourceAssignmentsForOneTask.Run();
            SetGeneralResourceAssignmentProperties.Run();

            // =====================================================
            // =====================================================
            // Working With Resources
            // =====================================================
            // =====================================================

            CreateResources.Run();
            GetResourceCalendar.Run();
            GetResourceCosts.Run();
            GetResourceOvertime.Run();
            GetResourcePercentWorkComplete.Run();
            GetResourceWorkVariance.Run();
            ReadResourceTimephasedData.Run();
            RenderResourceSheetView.Run();
            RenderResourceUsageView.Run();
            SetGeneralResourceProperties.Run();
            SetResourceCalendar.Run();
            SetResourceExtendedAttributes.Run();
            UpdateResourceDataInMPP.Run();
            ResourcePrefixForNestedResources.Run();

            // =====================================================
            // =====================================================
            // Working With Task Baselines
            // =====================================================
            // =====================================================

            CreateTaskBaseline.Run();
            GetTaskBaselineDuration.Run();

            // =====================================================
            // =====================================================
            // Working With Task Links
            // =====================================================
            // =====================================================

            CreateTaskLinks.Run();
            GetCrossProjectTaskLinks.Run();
            GetPredecessorSuccessorTasks.Run();
            GetTaskLinkType.Run();
            IdentifyCrossProjectTasks.Run();
            SetTaskLinkType.Run();

            // =====================================================
            // =====================================================
            // Working With Tasks
            // =====================================================
            // =====================================================

            AddTaskExtendedAttributes.Run();
            AddWBSCodes.Run();
            CalculateSplitTaskFinishDate.Run();
            CalculateTaskDurations.Run();
            ChangeTaskProgress.Run();
            CreateSplitTasks.Run();
            CreateSubProjectTask.Run();
            CreateTasks.Run();
            FindCriticalEffortDrivenTasks.Run();
            FindEstimatedMilestoneTasks.Run();
            MoveTaskAtTheEnd.Run();
            MoveTaskUnderAnotherParent.Run();
            MoveTaskUnderSameParent.Run();
            ReadActualTaskProperties.Run();
            ReadBudgetWorkAndCost.Run();
            ReadParentChildTasks.Run();
            ReadStopResumeDates.Run();
            ReadTaskCalendar.Run();
            ReadTaskCosts.Run();
            ReadTaskExtendedAttributes.Run();
            ReadTaskOutlineProperties.Run();
            ReadTaskOvertimes.Run();
            ReadTaskPercentageCompletion.Run();
            ReadTaskPriority.Run();
            ReadTaskProperties.Run();
            ReadTaskWBS.Run();
            ReadWriteTimephasedData.Run();
            RenderTaskSheetView.Run();
            RenderTaskUsageView.Run();
            RenderTaskUsageViewWithDetails.Run();
            RenumberTaskWBSCodes.Run();
            UpdateTaskData.Run();
            ViewSplitTasks.Run();
            WriteTaskCalendar.Run();
            WriteTaskDuration.Run();
            WriteTaskProperties.Run();
            TaskWarning.Run();
            CreateRecurringTask.Run();

            // Working with Task Constraints
            // =====================================================

            GetConstraints.Run();
            WorkWithConstraints.Run();

            // =====================================================
            // =====================================================
            // Working With VBA
            // =====================================================
            // =====================================================

            ReadModuleAttributesInformation.Run();
            ReadModulesInformation.Run();
            ReadReferencesInformation.Run();
            ReadVBAProjectInformation.Run();
        }

        public static string GetDataDir(MethodBase methodBase)
        {
            if (methodBase == null)
            {
                throw new ArgumentNullException("methodBase");
            }
            
            if (methodBase.DeclaringType == null)
            {
                throw new NullReferenceException("Declaring type is null.");
            }

            return GetDataDir(methodBase.DeclaringType.FullName);
        }

        private static string GetDataDir(string exampleName)
        {
            var categoryName = exampleName;
            categoryName = categoryName.Replace("Aspose.Tasks.Examples.CSharp.", string.Empty);
            var testName = categoryName.Substring(categoryName.IndexOf(".", StringComparison.Ordinal) + 1);
            categoryName = categoryName.Substring(0, categoryName.IndexOf(".", StringComparison.Ordinal));
            categoryName = categoryName.Replace('.', Path.DirectorySeparatorChar);
            var p = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..", "Data", categoryName));
            p += Path.DirectorySeparatorChar;

            if (Directory.Exists(p))
            {
                Console.WriteLine("Using Data Dir {0}", p);
            }
            else
            {
                Directory.CreateDirectory(p);
                Console.WriteLine("Created Data Dir {0}", p);
            }
            
            Console.WriteLine("The '{0}' example is running...", testName);

            return p;
        }
    }
}