/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.Articles
{
    using System;

    using Aspose.Tasks.Saving;

    internal class SetGanttChartViewStartDate
    {
        public static void Run()
        {            
            try
            {
                // The path to the documents directory.
                var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

                //ExStart:SetGanttChartViewStartDate
                //ExFor: Prj.TimescaleStart
                //ExSummary: Shows how to set timescale start date to tune the date where the view should start.
                var project = new Project(dataDir + "Project2.mpp");
                project.Set(Prj.TimescaleStart, new DateTime(2012, 4, 30));
                project.Save(dataDir + "SetGanttChartViewStartDate_out.mpp", SaveFileFormat.MPP);
                //ExEnd:SetGanttChartViewStartDate
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
