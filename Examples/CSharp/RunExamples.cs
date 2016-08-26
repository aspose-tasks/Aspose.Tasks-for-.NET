using System;
using System.IO;
using Aspose.Tasks.Examples.CSharp.CreatingAndSaving;
using Aspose.Tasks.Examples.CSharp.CustomizingCreatedProject;
using Aspose.Tasks.Examples.CSharp.HandlingBasicProperties;
using Aspose.Tasks.Examples.CSharp.ManipulatingMPPFile;
using Aspose.Tasks.Examples.CSharp.ModifyingCreatedProject;
using Aspose.Tasks.Examples.CSharp.PrintingAndExporting;
using Aspose.Tasks.Examples.CSharp.ReadingData;
using Aspose.Tasks.Examples.CSharp.WorkingWithProjects;

namespace Aspose.Tasks.Examples.CSharp
{
    class RunExamples
    {

        public static void Main()
        {
            Console.WriteLine("Open RunExamples.cs. \nIn Main() method, uncomment the example that you want to run");
            Console.WriteLine("=====================================================");


            // Uncomment the one you want to try out

            // =====================================================
            // =====================================================
            // Creating And Saving
            // =====================================================
            // =====================================================

            //CustomizeDateFormats.Run();
            //CustomizeTextStyle.Run();
            //FitContentsToCellSize.Run();
            //IgnoreInvalidCharactersDuringloadingProject.Run();
            //ImportProjectDataFromDatabase.Run();
            //ReadPasswordProtectedProjectFile.Run();
            //SaveProjectAsCSV.Run();
            //SaveProjectAsPDF.Run();
            //SaveProjectAsSVG.Run();
            //SaveProjectAsText.Run();
            //SaveProjectAsXLSX.Run();
            //SaveProjectDataAsHTML.Run();
            //SaveProjectDataToSpreadsheet2003XML.Run();
            //SaveToMultiplePDFFiles.Run();
            //UseSvgOptions.Run();
            //UsingXlsxOptions.Run();


            // =====================================================
            // =====================================================
            // Customizing Created Project
            // =====================================================
            // =====================================================

            //CalculateCriticalPath.Run();
            //CreateEmptyProjectSaveXML.Run();            
            //ReschedueProjectFromFinishDate.Run();
            //ExtendedAttributes.Run();
            //ReschedueProjectFromFinishDate.Run();
            //ReschedueProjectFromStartDate.Run();
            //RescheduleProjectStartOrFinishDate.Run();
            //RetrieveCalendarInfo.Run();
            //SetAttributesForNewTasks.Run();

            // =====================================================
            // =====================================================
            // Handling Basic Properties
            // =====================================================
            // =====================================================

            //DefaultProperties.Run();
            //WriteFiscalYearProperties.Run();
            //WriteDefaultProperties.Run();
            //WriteWeekdayProperties.Run();
            //WriteProjectInfo.Run();
            //WriteCurrencyProperties.Run();
            //ReadWeekdayProperties.Run();
            //ReadProjectInfo.Run();
            //ReadFiscalYearProperties.Run();
            //ReadCurrencyProperties.Run();
            //DetermineProjectVersion.Run();


            // =====================================================
            // =====================================================
            // Manipulating MPP File
            // =====================================================
            // =====================================================

            //AddImageToPageHeaderFooter.Run();
            //MPPFileUpdate.Run();
            //ReadFilterCriteriaData.Run();
            //ReadFilterDefinitionData.Run();
            //WriteMPPProjectSummary.Run();


            // =====================================================
            // =====================================================
            // Modifying Created Project 
            // =====================================================
            // =====================================================

            //ConfigureGantChart.Run();
            //ConfigureTheGantChartViewShowSelectedColumnFields.Run();
            //CustomizeTimescaleTierLabels.Run();
            //EmbeddedObjectsCreatedInsideApplication.Run();
            //ReadOnlyAccessToCustomFieldValuesUsingFormulas.Run();
            //RenderProjectDataToFormat24bppRgb.Run();
            //SetTimeScaleCount.Run();
             

            // =====================================================
            // =====================================================
            // Printing And Exporting
            // =====================================================
            // =====================================================

            //ExportProjectDataToPrimaveraMPXFormat.Run();
            //ExportProjectDataToXERFormat.Run();
            //ExportProjectDataToXMLFormat.Run();            
            //ImportDataFromXMLFileFormats.Run();
            //PrintProject.Run();
            //PrintProjectPagesToSeparateFiles.Run();
            //PrintProjectUsingCustomPrinter.Run();
            //PrintTaskWritingException.Run();
            //PrintTheProject.Run();          
            //SupportForSQLiteDatabase.Run();


            // =====================================================
            // =====================================================
            // Reading Data
            // =====================================================
            // =====================================================

            GetNumberOfPages.Run();
            GetNumberOfPagesForViews.Run();
            ReadOutlineCodes.Run();          
            ReadTableDataFromProjectFile.Run();



            // =====================================================
            // =====================================================
            // Working With Calendars
            // =====================================================
            // =====================================================

            //CreatingCalendar.Run();
            //DefineWeekdaysForCalendar.Run();
            //GeneralCalendarProperties.Run();
            //MakeAStandardCalendar.Run();
            //ReadWorkWeeksInformation.Run();
            //WriteUpdatedCalendarDataToMPP.Run();

            // =====================================================
            // =====================================================
            // Working With Projects
            // =====================================================
            // =====================================================

            //GetObjectByFieldMethods.Run();
            //MoveTaskAtTheEnd.Run();
            //MoveTaskUnderAnotherParent.Run();
            //MoveTaskUnderSameParent.Run();
            //ReadModuleAttributesInforamtion.Run();
            //ReadModulesInformation.Run();
            //ReadProjectFileFromStream.Run();
            //ReadProjectFiles.Run();
            //ReadReferencesInformation.Run();
            //ReplaceCalendar.Run();
            //SaveProjectDataAsTemplate.Run();
            //TaskSettingStartFinishDates.Run();
            // ReadPasswordProtectedProjectFile.Run();
            //UpdateProjectAndRescheduleUncompletedWork.Run();

            // =====================================================
            // =====================================================
            // Working With VBA
            // =====================================================
            // =====================================================

            // ReadVBAProjectInformation.Run();
            // ReadReferencesInformation.Run();
            // ReadModulesInformation.Run();
            // ReadModuleAttributesInforamtion.Run();


            // Stop before exiting
            Console.WriteLine("\n\nProgram Finished. Press any key to exit..");
            Console.ReadKey();
        }

        public static String GetDataDir_Projects()
        {
            return Path.GetFullPath("././ProgrammersGuide/WorkingWithProjects/Data/");
        }

        internal static string GetDataDir_ReadingData()
        {
            return Path.GetFullPath(GetDataDir_Data() + "ReadingData/");
        }


        internal static string GetDataDir_PrintingAndExporting()
        {
            return Path.GetFullPath(GetDataDir_Data() + "PrintingAndExporting/");
        }

        internal static string GetDataDir_ModifyingCreatedProject()
        {
            return Path.GetFullPath(GetDataDir_Data() + "ModifyingCreatedProject/");
        }


        internal static string GetDataDir_HandlingBasicProperties()
        {
            return Path.GetFullPath(GetDataDir_Data() + "HandlingBasicProperties/");
        }


        internal static string GetDataDir_ManipulatingMPPFile()
        {
            return Path.GetFullPath(GetDataDir_Data() + "ManipulatingMPPFile/");
        }

        internal static string GetDataDir_CustomizingCreatedProject()
        {
            return Path.GetFullPath(GetDataDir_Data() + "CustomizingCreatedProject/");
        }

        internal static string GetDataDir_CreatingAndSaving()
        {
            return Path.GetFullPath(GetDataDir_Data() + "CreatingAndSaving/");
        }


        private static string GetDataDir_Data()
        {
            var parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;
            string startDirectory = null;
            if (parent != null)
            {
                var directoryInfo = parent.Parent;
                if (directoryInfo != null)
                {
                    startDirectory = directoryInfo.FullName;
                }
            }
            else
            {
                startDirectory = parent.FullName;
            }
            return startDirectory != null ? Path.Combine(startDirectory, "Data\\") : null;
        }

    }
}