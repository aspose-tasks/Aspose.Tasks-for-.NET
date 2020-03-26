/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.ConvertingProjectData
{
    using Aspose.Tasks.Saving;
    using Aspose.Tasks.Visualization;

    internal class UsingSpreadsheet2003SaveOptions
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            // Read the input Project file
            var project = new Project(dataDir + "CreateProject2.mpp");

            //ExStart:UsingSpreadsheet2003SaveOptions
            //ExFor: Spreadsheet2003SaveOptions
            //ExFor: SaveOptions.View
            //ExFor: Spreadsheet2003SaveOptions.ResourceView
            //ExFor: Spreadsheet2003SaveOptions.AssignmentView
            //ExFor: AssignmentViewColumn
            //ExFor: ResourceViewColumn
            //ExSummary: Shows how to use add columns to be exported during export project into Spreadsheet2003 format. 
            var options = new Spreadsheet2003SaveOptions();
            var ganttChartColumn = new GanttChartColumn(
                "WBS", 
                100,
                delegate(Task task)
                {
                    return task.Get(Tsk.WBS);
                });
            options.View.Columns.Add(ganttChartColumn);

            var resourceViewColumn = new ResourceViewColumn(
                "Cost center",
                100,
                delegate(Resource resource)
                    {
                        return resource.Get(Rsc.CostCenter);
                    });
            options.ResourceView.Columns.Add(resourceViewColumn);

            var assignmentViewColumn = new AssignmentViewColumn(
                "Notes",
                200,
                delegate(ResourceAssignment assignment)
                    {
                        return assignment.Get(Asn.Notes);
                    });
            options.AssignmentView.Columns.Add(assignmentViewColumn);

            project.Save(dataDir + "UsingSpreadsheet2003SaveOptions_out.xml", options);
            //ExEnd:UsingSpreadsheet2003SaveOptions
        }
    }
}
