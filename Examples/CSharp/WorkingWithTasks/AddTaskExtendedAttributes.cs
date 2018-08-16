using Aspose.Tasks.Saving;
using System;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
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
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

                // Create new project
                Project project = new Project(dataDir + "Blank2010.mpp");

                #region Adding Plain Text Attribute
                //Create an Extended Attribute Definition of Text1 type
                var taskExtendedAttributeText1Definition = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Text, ExtendedAttributeTask.Text1, "Task City Name");

                //Add it to the project's Extended Attributes collection
                project.ExtendedAttributes.Add(taskExtendedAttributeText1Definition);

                //Add a task to the project
                var task = project.RootTask.Children.Add("Task 1");

                //Create an Extended Attribute from the Attribute Definition
                var taskExtendedAttributeText1 = taskExtendedAttributeText1Definition.CreateExtendedAttribute();

                //Assign a value to the generated Extended Attribute. The type of the attribute is "Text", the "TextValue" property should be used.
                taskExtendedAttributeText1.TextValue = "London";

                //Add the Extended Attribute to task
                task.ExtendedAttributes.Add(taskExtendedAttributeText1);

                project.Save(dataDir + "PlainTextExtendedAttribute_out.mpp", SaveFileFormat.MPP);
                #endregion

                #region Adding Text Attribute with Lookup option

                Project project1 = new Project(dataDir + "Blank2010.mpp");

                //Create an Extended Attribute Definition of Text2 type
                var taskExtendedAttributeText2Definition = ExtendedAttributeDefinition.CreateLookupTaskDefinition(CustomFieldType.Text, ExtendedAttributeTask.Text2, "Task Towns Name");

                //Add lookup values for the extended attribute definition
                taskExtendedAttributeText2Definition.AddLookupValue(new Value { Id = 1, StringValue = "Town1", Description = "This is Town1" });
                taskExtendedAttributeText2Definition.AddLookupValue(new Value { Id = 2, StringValue = "Town2", Description = "This is Town2" });

                //Add it to the porject's Extended Attributes collection
                project1.ExtendedAttributes.Add(taskExtendedAttributeText2Definition);

                //Add a task to the project
                var task2 = project1.RootTask.Children.Add("Task 2");

                //Crate an Extended Attribute from the Text2 Lookup Definition for Id 1
                var taskExtendedAttributeText2 = taskExtendedAttributeText2Definition.CreateExtendedAttribute(taskExtendedAttributeText2Definition.ValueList[1]);

                //Add the Extended Attribute to task
                task2.ExtendedAttributes.Add(taskExtendedAttributeText2);

                project1.Save(dataDir + "TextExtendedAttributeWithLookup_out.mpp", SaveFileFormat.MPP);
                #endregion

                #region Adding Duration Attribute with Lookup option
                
                Project project2 = new Project(dataDir + "Blank2010.mpp");

                //Create an Extended Attribute Definition of Duration2 type
                var taskExtendedAttributeDuration2Definition = ExtendedAttributeDefinition.CreateLookupTaskDefinition(CustomFieldType.Duration, ExtendedAttributeTask.Duration2, "Some duration");

                //Add lookup values for extended attribute definition
                taskExtendedAttributeDuration2Definition.AddLookupValue(new Value { Id = 2, Duration = project2.GetDuration(4, TimeUnitType.Hour), Description = "4 hours" });
                taskExtendedAttributeDuration2Definition.AddLookupValue(new Value { Id = 3, Duration = project2.GetDuration(1, TimeUnitType.Day), Description = "1 day" });
                taskExtendedAttributeDuration2Definition.AddLookupValue(new Value { Id = 4, Duration = project2.GetDuration(1, TimeUnitType.Hour), Description = "1 hour" });
                taskExtendedAttributeDuration2Definition.AddLookupValue(new Value { Id = 7, Duration = project2.GetDuration(10, TimeUnitType.Day), Description = "10 days" });

                //Add the definition to the project's Extended Attributes collection
                project2.ExtendedAttributes.Add(taskExtendedAttributeDuration2Definition);

                //Add a task to the project
                var task3 = project2.RootTask.Children.Add("Task 3");

                //Create an Extended Attribute from the Duration2 Lookup Definition for Id 3
                var taskExtendedAttributeDuration2 = taskExtendedAttributeDuration2Definition.CreateExtendedAttribute(taskExtendedAttributeDuration2Definition.ValueList[3]);

                //Add the Extended Attribute to task
                task3.ExtendedAttributes.Add(taskExtendedAttributeDuration2);

                project2.Save(dataDir + "DurationExtendedAttributeWithLookup_out.mpp", SaveFileFormat.MPP);

                #endregion

                #region Adding Date-Time with Lookup option

                Project project3 = new Project(dataDir + "Blank2010.mpp");

                //Create an Extended Attribute Definition of Finish2 Type
                var taskExtendedAttributeFinish2Definition = ExtendedAttributeDefinition.CreateLookupTaskDefinition(CustomFieldType.Finish, ExtendedAttributeTask.Finish2, "Some finish");

                //Add lookup values for extended attribute defintion
                taskExtendedAttributeFinish2Definition.AddLookupValue(new Value { Id = 2, DateTimeValue = new DateTime(1984, 01, 01, 00, 00, 01), Description = "This is Value2" });
                taskExtendedAttributeFinish2Definition.AddLookupValue(new Value { Id = 3, DateTimeValue = new DateTime(1994, 01, 01, 00, 01, 01), Description = "This is Value3" });
                taskExtendedAttributeFinish2Definition.AddLookupValue(new Value { Id = 4, DateTimeValue = new DateTime(2009, 12, 31, 00, 00, 00), Description = "This is Value4" });
                taskExtendedAttributeFinish2Definition.AddLookupValue(new Value { Id = 7, DateTimeValue = DateTime.Now, Description = "This is Value6" });

                //Add the definition to the project's Extended Attributes collection
                project3.ExtendedAttributes.Add(taskExtendedAttributeFinish2Definition);

                //Add a task to the project
                var task4 = project3.RootTask.Children.Add("Task 4");

                //Create an Extneded Attribute from the Finish2 Lookup Definition for Id 3
                var taskExtendedAttributeFinish2 = taskExtendedAttributeFinish2Definition.CreateExtendedAttribute(taskExtendedAttributeFinish2Definition.ValueList[3]);

                //Add the Extended Attribute to task
                task4.ExtendedAttributes.Add(taskExtendedAttributeFinish2);

                // Save the Project               
                project3.Save(dataDir + "FinishExtendedAttributeWithLookup_out.mpp", SaveFileFormat.MPP);                
                #endregion


                // ExEnd:AddTaskExtendedAttributes
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
