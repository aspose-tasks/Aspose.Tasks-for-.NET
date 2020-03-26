/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithProjectViews
{
    using System;
    using System.Drawing;

    using Aspose.Tasks.Saving;

    internal class ConfigureGanttChart
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
            
            try
            {
                //ExStart:ConfigureGanttChart
                //ExFor: Project.Tables
                //ExFor: Table.TableFields
                //ExSummary: Shows how to configure Gantt Chart properties.
                var project = new Project(dataDir + "Project5.mpp"); // Create a new project task
                var task = project.RootTask.Children.Add("New Activity");

                // Define new custom attribute
                var definition = ExtendedAttributeDefinition.CreateTaskDefinition(ExtendedAttributeTask.Text1, null);
                project.ExtendedAttributes.Add(definition);
                // Add custom text attribute to created task.
                task.ExtendedAttributes.Add(definition.CreateExtendedAttribute("Activity attribute"));

                // Customize table by adding text attribute field
                var field = new TableField();
                field.Field = Field.TaskText1;
                field.Width = 20;
                field.Title = "Custom attribute";
                field.AlignTitle = StringAlignment.Center;
                field.AlignData = StringAlignment.Center;

                var table = project.Tables.ToList()[0];
                table.TableFields.Insert(3, field);

                project.Save(dataDir + @"ConfigureGantChart_out.mpp", new MPPSaveOptions { WriteViewData = true });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
            //ExEnd:ConfigureGanttChart
        }
    }
}