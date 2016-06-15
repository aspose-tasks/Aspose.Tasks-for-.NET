using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Aspose.Tasks.Examples.CSharp.ProgrammersGuide.WorkingWithCalendars;
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
            // Working With Calendars
            // =====================================================
            // =====================================================

            CreatingCalendar.Run();
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

            //CalculateCriticalPath.Run();
            //CreateEmptyProjectSaveXML.Run();
            //DefaultProperties.Run();
            //DetermineProjectVersion.Run();
            //ExtendedAttributes.Run();
            //GetNumberOfPages.Run();
            //GetNumberOfPagesForViews.Run();
            //GetObjectByFieldMethods.Run();
            //MPPFileUpdate.Run();
            //PrintTaskWritingException.Run();
            //ReadCurrencyProperties.Run();
            //ReadFiscalYearProperties.Run();
            //ReadProjectFiles.Run();
            //ReadProjectInfo.Run();
            //ReadWeekdayProperties.Run();
            //ReplaceCalendar.Run();
            //RetrieveCalendarInfo.Run();
            //SetAttributesForNewTasks.Run();
            //WriteCurrencyProperties.Run();
            //WriteFiscalYearProperties.Run();
            //WriteMPPProjectSummary.Run();
            //WriteProjectInfo.Run();
            //WriteUpdatedExtendedAttributeDefinitions.Run();
            //WriteWeekdayProperties.Run();
            //TaskSettingStartFinishDates.Run();
            //WriteCurrencyProperties.Run();
            //WriteFiscalYearProperties.Run();
            //WriteMPPProjectSummary.Run();
            //WriteProjectInfo.Run();
            //WriteUpdatedExtendedAttributeDefinitions.Run();
            //WriteWeekdayProperties.Run();


            // =====================================================
            // =====================================================
            // Working With VBA
            // =====================================================
            // =====================================================

            //ReadVBAProjectInformation.Run();
            //ReadReferencesInformation.Run();
            //ReadModulesInformation.Run();
            //ReadModuleAttributesInforamtion.Run();


            // Stop before exiting
            Console.WriteLine("\n\nProgram Finished. Press any key to exit....");
            Console.ReadKey();
        }

        public static String GetDataDir_Projects()
        {
            return Path.GetFullPath("../../ProgrammersGuide/WorkingWithProjects/Data/");
        }

    }
}