//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;
using System;

namespace WritingUpdatedExtendedAttributeDefinitionsExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            string newFile = dataDir+ "project.mpp";
            string resultFile = dataDir+ "Output.mpp";

            Project project = new Project(dataDir + "project.mpp");

            #region task attributes
            // Add new text3 extended attribute and one text value
            ExtendedAttributeDefinition taskTextAttr = new ExtendedAttributeDefinition();
            taskTextAttr.Alias = "New text3 attribute";
            taskTextAttr.FieldName = "Text3";
            taskTextAttr.ElementType = ElementType.Task;
            taskTextAttr.CfType = CustomFieldType.Text;

            project.ExtendedAttributes.Add(taskTextAttr);

            Value textVal = new Value();
            textVal.Id = 1;
            textVal.Description = "Text value descr";
            textVal.Val = "Text value1";

            taskTextAttr.ValueList.Add(textVal);

            // Add new cost1 extended attribute and two cost values
            ExtendedAttributeDefinition taskCostAttr = new ExtendedAttributeDefinition();
            taskCostAttr.Alias = "New cost1 attribute";
            taskCostAttr.FieldName = "Cost1";
            taskCostAttr.ElementType = ElementType.Task;
            taskCostAttr.CfType = CustomFieldType.Cost;

            project.ExtendedAttributes.Add(taskCostAttr);

            Value costVal1 = new Value();
            costVal1.Id = 2;
            costVal1.Description = "Cost value 1 descr";
            costVal1.Val = "99900";

            Value costVal2 = new Value();
            costVal2.Id = 3;
            costVal2.Description = "Cost value 2 descr";
            costVal2.Val = "11100";

            taskCostAttr.ValueList.Add(costVal1);
            taskCostAttr.ValueList.Add(costVal2);

            // Add new task and assign attribute value
            Task task = project.RootTask.Children.Add("New task");

            ExtendedAttribute taskAttr = new ExtendedAttribute();
            taskAttr.AttributeDefinition = taskCostAttr;
            taskAttr.Value = "99900";
            taskAttr.FieldId = taskCostAttr.FieldId;
            task.ExtendedAttributes.Add(taskAttr);

            ExtendedAttributeDefinition taskStartAttr = new ExtendedAttributeDefinition();
            taskStartAttr.Alias = "New start 7 attribute";
            taskStartAttr.CfType = CustomFieldType.Start;
            taskStartAttr.ElementType = ElementType.Task;
            taskStartAttr.FieldName = "Start7";

            Value startVal = new Value();
            startVal.Val = DateTime.Now.ToString();
            startVal.Description = "Start 7 value description";

            taskStartAttr.ValueList.Add(startVal);

            project.ExtendedAttributes.Add(taskStartAttr);

            ExtendedAttributeDefinition taskFinishAttr = new ExtendedAttributeDefinition();
            taskFinishAttr.Alias = "New finish 4 attribute";
            taskFinishAttr.CfType = CustomFieldType.Finish;
            taskFinishAttr.ElementType = ElementType.Task;
            taskFinishAttr.FieldName = "Finish4";

            Value finishVal = new Value();
            finishVal.Val = DateTime.Now.ToString();
            finishVal.Description = "Finish 4 value description";

            taskFinishAttr.ValueList.Add(finishVal);

            project.ExtendedAttributes.Add(taskFinishAttr);

            ExtendedAttributeDefinition numberAttr = new ExtendedAttributeDefinition();
            numberAttr.Alias = "New number attribute";
            numberAttr.FieldName = "Number20";
            numberAttr.CfType = CustomFieldType.Number;
            numberAttr.ElementType = ElementType.Task;

            Value val1 = new Value();
            val1.Val = "1";
            val1.Description = "Number 1 value";
            Value val2 = new Value();
            val2.Val = "2";
            val2.Description = "Number 2 value";
            Value val3 = new Value();
            val3.Val = "3";
            val3.Description = "Number 3 value";

            numberAttr.ValueList.Add(val1);
            numberAttr.ValueList.Add(val2);
            numberAttr.ValueList.Add(val3);

            project.ExtendedAttributes.Add(numberAttr);

            #endregion

            ExtendedAttributeDefinition rscStartAttr = new ExtendedAttributeDefinition();
            rscStartAttr.Alias = "New start5 attribute";
            rscStartAttr.FieldName = "Start5";
            rscStartAttr.ElementType = ElementType.Resource;
            rscStartAttr.CfType = CustomFieldType.Start;

            Value startVal2 = new Value();
            startVal2.Id = 4;
            startVal2.Val = DateTime.Now.ToString();
            startVal2.Description = "this is start5 value descr";

            rscStartAttr.ValueList.Add(startVal2);

            project.ExtendedAttributes.Add(rscStartAttr);


            //Save the project as MPP project file
            project.Save(resultFile, Aspose.Tasks.Saving.SaveFileFormat.MPP);
        }
    }
}