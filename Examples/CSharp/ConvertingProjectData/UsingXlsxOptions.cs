using Aspose.Tasks.Saving;
using Aspose.Tasks.Visualization;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.ConvertingProjectData
{
    public class UsingXlsxOptions
    {
        public static void Run()
        {           
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:UsingXlsxOptions
            // Read the input Project file
            Project project = new Project(dataDir + "CreateProject2.mpp");
                                   
            XlsxOptions options = new XlsxOptions();

            // Add desired Gantt Chart columns
            GanttChartColumn col = new GanttChartColumn("WBS", 100, delegate(Task task) { return task.Get(Tsk.WBS); });
            options.View.Columns.Add(col);

            // Add desired resource view columns
            ResourceViewColumn rscCol = new ResourceViewColumn(
                "Cost center",
                100,
                delegate(Resource resource)
                    {
                        return resource.Get(Rsc.CostCenter);
                    });
            options.ResourceView.Columns.Add(rscCol);

            // Add desired assignment view columns
            AssignmentViewColumn assnCol = new AssignmentViewColumn("Notes", 200, delegate(ResourceAssignment assignment) { return assignment.Get(Asn.Notes); });
            options.AssignmentView.Columns.Add(assnCol);

            project.Save(dataDir + "UsingXlsxOptions_out.xlsx", options);
            //ExEnd:UsingXlsxOptions
        }
    }
}