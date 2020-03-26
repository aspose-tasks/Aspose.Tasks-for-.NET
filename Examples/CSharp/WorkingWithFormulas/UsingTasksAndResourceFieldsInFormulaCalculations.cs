/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithFormulas
{
    using System;

    using Aspose.Tasks.Saving;

    internal class UsingTasksAndResourceFieldsInFormulaCalculations
    {
        private static readonly string DataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

        //ExStart:UsingTasksAndResourceFieldsInFormulaCalculations
        //ExFor: ExtendedAttributeDefinition.Formula
        //ExSummary: Shows how to use extended attribute functions by using task's and/or resource's fields.
        public static void Run()
        {
            try
            {
                var project = CreateTestProjectWithCustomField();
                var task = project.RootTask.Children.GetById(1);

                // Set formula for extended attribute
                var extendedAttributeDefinition1 = project.ExtendedAttributes[0];
                extendedAttributeDefinition1.Alias = "Days from finish to deadline";
                extendedAttributeDefinition1.Formula = "[Deadline] - [Finish]";

                // Set Task Deadline and save project
                task.Set(Tsk.Deadline, new DateTime(2015, 3, 20, 17, 0, 0));
                project.Save(DataDir + "project_UsingTasksAndResourceFields_out.mpp", SaveFileFormat.MPP);             
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }            
        }

        // Helper method to create project
        private static Project CreateTestProjectWithCustomField()
        {
            // Create new project instance
            var project = new Project(DataDir + "Blank2010.mpp");
            project.Set(Prj.StartDate, new DateTime(2015, 3, 6, 8, 0, 0));

            // Add new task with extended attribute
            var task = project.RootTask.Children.Add("Task");
            var extendedAttributeDefinition = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Text, ExtendedAttributeTask.Text5, "My Ext Attr");
            project.ExtendedAttributes.Add(extendedAttributeDefinition);
            var extendedAttribute = extendedAttributeDefinition.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(extendedAttribute);

            // Add resource and resource assignment
            var rsc = project.Resources.Add("Rsc");
            project.ResourceAssignments.Add(task, rsc);
            return project;
        }
        //ExEnd:UsingTasksAndResourceFieldsInFormulaCalculations            
    }
}