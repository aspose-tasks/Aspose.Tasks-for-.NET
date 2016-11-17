using Aspose.Tasks.Saving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    class AddTaskExtendedAttributes
    {
        public static void Run()
        {
            try
            {
                // ExStart:AddTaskExtendedAttributes
                // Create new project
                Project project1 = new Project();

                // Create the Extended Attribute Definition of Text Type
                ExtendedAttributeDefinition taskExtendedAttributeText9Definition;
                taskExtendedAttributeText9Definition = new ExtendedAttributeDefinition();
                taskExtendedAttributeText9Definition.Alias = "Task City Name";      
                taskExtendedAttributeText9Definition.FieldName = "Text9";
                taskExtendedAttributeText9Definition.ElementType = ElementType.Task;
                taskExtendedAttributeText9Definition.CfType = CustomFieldType.Text;
                taskExtendedAttributeText9Definition.FieldId = Convert.ToInt32(ExtendedAttributeTask.Text9).ToString(System.Globalization.CultureInfo.InvariantCulture);

                // Create an Extended Attribute Definition of Flag Type
                ExtendedAttributeDefinition taskExtendedAttributeFlag1Definition;
                taskExtendedAttributeFlag1Definition = new ExtendedAttributeDefinition();
                taskExtendedAttributeFlag1Definition.Alias = "Is Billable";
                taskExtendedAttributeFlag1Definition.FieldName = "Flag1";
                taskExtendedAttributeFlag1Definition.ElementType = ElementType.Task;
                taskExtendedAttributeFlag1Definition.CfType = CustomFieldType.Flag;
                taskExtendedAttributeFlag1Definition.FieldId = Convert.ToInt32(ExtendedAttributeTask.Flag1).ToString(System.Globalization.CultureInfo.InvariantCulture);

                // Add the Extended Attribute Definitions to the Project's Extended Attribute Collection
                project1.ExtendedAttributes.Add(taskExtendedAttributeText9Definition);
                project1.ExtendedAttributes.Add(taskExtendedAttributeFlag1Definition);

                // Add a task to project and set its properties
                Task task = project1.RootTask.Children.Add("Task 1");
                task.Set(Tsk.Start, new DateTime(2016, 7, 27, 8, 0, 0));
                task.Set(Tsk.Duration, project1.GetDuration(8, TimeUnitType.Hour));

                // Create Extended Attribute and set it's values
                ExtendedAttribute taskExtendedAttributeText9 = new ExtendedAttribute();
                taskExtendedAttributeText9.FieldId = taskExtendedAttributeText9Definition.FieldId;
                taskExtendedAttributeText9.Value = "London";               
                
                // Create Extended Attribute of Flag type and set it's values
                ExtendedAttribute taskExtendedAttributeFlag1 = new ExtendedAttribute();
                taskExtendedAttributeFlag1.FieldId = taskExtendedAttributeFlag1Definition.FieldId;
                taskExtendedAttributeFlag1.Value = "1";

                // Add the Extended Attributes to Task
                task.ExtendedAttributes.Add(taskExtendedAttributeText9);
                task.ExtendedAttributes.Add(taskExtendedAttributeFlag1);

                // Save the Project
                string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
                project1.Save(dataDir + "AddTaskExtendedAttributes_out.mpp", SaveFileFormat.MPP);
                // ExEnd:AddTaskExtendedAttributes
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
