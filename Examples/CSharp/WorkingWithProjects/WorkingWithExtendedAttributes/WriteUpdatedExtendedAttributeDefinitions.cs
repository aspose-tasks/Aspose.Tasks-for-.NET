using System;
using Aspose.Tasks.Saving;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithExtendedAttributes
{
    public class WriteUpdatedExtendedAttributeDefinitions
    {
        public static void Run()
        {
            // This example requires Aspose.Task for .NET, a trial version can be download from  http://www.aspose.com/corporate/purchase/temporary-license.aspx
            try
            {
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

                // ExStart:WriteUpdatedExtendedAttributeDefinitions
                Project project = new Project(dataDir + "WriteUpdatedExtendedAttributeDefinitions.mpp");

                #region task attributes

                // Add new text3 extended attribute with lookup and one lookup value
                ExtendedAttributeDefinition taskTextAttributeDefinition = ExtendedAttributeDefinition.CreateLookupTaskDefinition(ExtendedAttributeTask.Text3, "New text3 attribute");
                taskTextAttributeDefinition.ElementType = ElementType.Task;
                project.ExtendedAttributes.Add(taskTextAttributeDefinition);

                Value textVal = new Value();
                textVal.Id = 1;
                textVal.Description = "Text value descr";
                textVal.Val = "Text value1";

                taskTextAttributeDefinition.AddLookupValue(textVal);

                // Add new cost1 extended attribute with lookup and two cost values
                ExtendedAttributeDefinition taskCostAttributeDefinition = ExtendedAttributeDefinition.CreateLookupTaskDefinition(ExtendedAttributeTask.Cost1, "New cost1 attribute");
                project.ExtendedAttributes.Add(taskCostAttributeDefinition);

                Value costVal1 = new Value();
                costVal1.Id = 2;
                costVal1.Description = "Cost value 1 descr";
                costVal1.Val = "99900";

                Value costVal2 = new Value();
                costVal2.Id = 3;
                costVal2.Description = "Cost value 2 descr";
                costVal2.Val = "11100";

                taskCostAttributeDefinition.AddLookupValue(costVal1);
                taskCostAttributeDefinition.AddLookupValue(costVal2);

                // Add new task and assign attribute lookup value.
                Task task = project.RootTask.Children.Add("New task");

                ExtendedAttribute taskAttr = taskCostAttributeDefinition.CreateExtendedAttribute(costVal1);
                task.ExtendedAttributes.Add(taskAttr);

                ExtendedAttributeDefinition taskStartAttributeDefinition = ExtendedAttributeDefinition.CreateLookupTaskDefinition(ExtendedAttributeTask.Start7, "New start 7 attribute");

                Value startVal = new Value();
                startVal.Id = 4;
                startVal.DateTimeValue = DateTime.Now;
                startVal.Description = "Start 7 value description";

                taskStartAttributeDefinition.AddLookupValue(startVal);

                project.ExtendedAttributes.Add(taskStartAttributeDefinition);

                ExtendedAttributeDefinition taskFinishAttributeDefinition = ExtendedAttributeDefinition.CreateLookupTaskDefinition(ExtendedAttributeTask.Finish4, "New finish 4 attribute");

                Value finishVal = new Value();
                finishVal.Id = 5;
                finishVal.DateTimeValue = DateTime.Now;
                finishVal.Description = "Finish 4 value description";

                taskFinishAttributeDefinition.ValueList.Add(finishVal);

                project.ExtendedAttributes.Add(taskFinishAttributeDefinition);

                ExtendedAttributeDefinition numberAttributeDefinition = ExtendedAttributeDefinition.CreateLookupTaskDefinition(ExtendedAttributeTask.Number20, "New number attribute");

                Value val1 = new Value();
                val1.Id = 6;
                val1.Val = "1";
                val1.Description = "Number 1 value";
                Value val2 = new Value();
                val2.Id = 7;
                val2.Val = "2";
                val2.Description = "Number 2 value";
                Value val3 = new Value();
                val2.Id = 8;
                val3.Val = "3";
                val3.Description = "Number 3 value";

                numberAttributeDefinition.AddLookupValue(val1);
                numberAttributeDefinition.AddLookupValue(val2);
                numberAttributeDefinition.AddLookupValue(val3);

                project.ExtendedAttributes.Add(numberAttributeDefinition);

                #endregion

                ExtendedAttributeDefinition rscStartAttributeDefinition = ExtendedAttributeDefinition.CreateLookupResourceDefinition(ExtendedAttributeResource.Start5, "New start5 attribute");

                Value startVal2 = new Value();
                startVal2.Id = 9;
                startVal2.DateTimeValue = DateTime.Now;
                startVal2.Description = "this is start5 value descr";

                rscStartAttributeDefinition.AddLookupValue(startVal2);

                project.ExtendedAttributes.Add(rscStartAttributeDefinition);

                // Define a duration attribute without lookup.
                ExtendedAttributeDefinition taskDurationAttributeDefinition = ExtendedAttributeDefinition.CreateTaskDefinition(ExtendedAttributeTask.Duration1, "New Duration");
                project.ExtendedAttributes.Add(taskDurationAttributeDefinition);

                // Add new task and assign duration value to the previously defined duration attribute.
                Task timeTask = project.RootTask.Children.Add("New task");

                ExtendedAttribute durationExtendedAttribute = taskDurationAttributeDefinition.CreateExtendedAttribute();

                durationExtendedAttribute.DurationValue = project.GetDuration(3.0, TimeUnitType.Hour);
                timeTask.ExtendedAttributes.Add(durationExtendedAttribute);

                MPPSaveOptions mppSaveOptions = new MPPSaveOptions();
                mppSaveOptions.WriteViewData = true;

                // Save the project as MPP project file
                project.Save(dataDir + "WriteUpdatedExtendedAttributeDefinitions_out.mpp", mppSaveOptions);
                // ExEnd:WriteUpdatedExtendedAttributeDefinitions
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }

        }
    }
}