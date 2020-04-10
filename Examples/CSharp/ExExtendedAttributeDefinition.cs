namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExExtendedAttributeDefinitionFormula : ApiExampleBase
    {
        [Test]
        public void CalculateGeneralFunctions()
        {
            EvaluateChoose();
            EvaluateIsNumeric();
            EvaluateSwitch();
        }

        //ExStart:CalculateGeneralFunctions
        //ExFor: ExtendedAttributeDefinition
        //ExFor: ExtendedAttributeDefinition.Formula
        //ExSummary: Shows how to use common math functions with extended attributes.
        private static void EvaluateChoose()
        {    
            var project = CreateTestProjectWithCustomField();
    
            // Set Formula
            project.ExtendedAttributes[0].Formula = "Choose(3, \"This is a\", \"right\", \"choice\")";
    
            // Print extended attribute value
            var task = project.RootTask.Children.GetById(1);
            Console.WriteLine(task.ExtendedAttributes[0].TextValue);
        }

        private static void EvaluateIsNumeric()
        {
            string[] numericFormulas = { "IsNumeric('AAA')", @"IsNUmeric(1)", "IsNumeric(1<0)", "IsNumeric(\"1.1\")", "IsNumeric(Choose((2 + Sgn(2^-3)), 123, \"one two three\"))" };
    
            var project = CreateTestProjectWithCustomField();
    
            foreach (var numericFormula in numericFormulas)    
            {
                // Set Formula
                project.ExtendedAttributes[0].Formula = numericFormula;

                // Print extended attribute value
                var task = project.RootTask.Children.GetById(1);
                Console.WriteLine(task.ExtendedAttributes[0].TextValue);
            }           
        }

        private static void EvaluateSwitch()
        {    
            var project = CreateTestProjectWithCustomField();

            // Set Formula
            project.ExtendedAttributes[0].Formula = "Switch( 0 < 1, \"0 is lesser than 1\", 0 > 1, \"0 is greater than 1\")";

            // Print extended attribute value
            var task = project.RootTask.Children.GetById(1);
            Console.WriteLine(task.ExtendedAttributes[0].TextValue);
        }
        
        private static Project CreateTestProjectWithCustomField()
        {
            var project = new Project();
            var definition = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Text, ExtendedAttributeTask.Text1, "Custom Field");
            project.ExtendedAttributes.Add(definition);

            var task = project.RootTask.Children.Add("Task");

            var attribute = definition.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(attribute);
            return project;
        }
        //ExEnd:CalculateGeneralFunctions
        
        //ExStart:CalculateMathExpressions
        //ExFor: ExtendedAttributeDefinition.Formula
        //ExSummary: Shows how to use transcendent math functions with extended attributes.
        [Test] //ExSkip
        public void CalculateMathExpressions()
        {
            var project = CreateTestProjectWithCustomField2();
            
            // Set formula Sin(pi/2)
            project.ExtendedAttributes[0].Formula = "Sin(3.1415926/2)";

            // Print Calculated value
            var task = project.RootTask.Children.GetById(1);
            Console.WriteLine("Sin(pi/2): {0}", task.ExtendedAttributes[0].NumericValue);
        }

        private static Project CreateTestProjectWithCustomField2()
        {
            var project = new Project();
            var attr = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Number, ExtendedAttributeTask.Number1, "Sine");         
            project.ExtendedAttributes.Add(attr);

            var task = project.RootTask.Children.Add("Task");

            var attribute = attr.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(attribute);
            return project;
        }
        //ExEnd:CalculateMathExpressions
        
        [Test]
        public void CalculateTextFunctions()
        {
            EvaluateStrConv();
            EvaluateStringFunction();
        }

        //ExStart:CalculateTextFunctions
        //ExFor: ExtendedAttributeDefinition.Formula
        //ExSummary: Shows how to use text functions with extended attributes.
        private static void EvaluateStrConv()
        {
            var project = CreateTestProjectWithCustomField3();
            var task = project.RootTask.Children.GetById(1);

            // Set formulas and print extended attribute value
            project.ExtendedAttributes[0].Formula = "StrConv(\"sTring and sTRINg\",3)";
            Console.WriteLine(task.ExtendedAttributes[0].TextValue);
            project.ExtendedAttributes[0].Formula = "StrConv(\"sTring and sTRINg\",1)";
            Console.WriteLine(task.ExtendedAttributes[0].TextValue);
            project.ExtendedAttributes[0].Formula = "StrConv(\"sTring and sTRINg\",2)";
            Console.WriteLine(task.ExtendedAttributes[0].TextValue);
        }

        private static void EvaluateStringFunction()
        {
            var project = CreateTestProjectWithCustomField3();
            var task = project.RootTask.Children.GetById(1);
                        
            // Set formulas and print extended attribute value
            project.ExtendedAttributes[0].Formula = "String(5, 40)";
            Console.WriteLine(task.ExtendedAttributes[0].TextValue);
            project.ExtendedAttributes[0].Formula = "String(5, \"A\")";
            Console.WriteLine(task.ExtendedAttributes[0].TextValue);
            project.ExtendedAttributes[0].Formula = "String(-5, \"A\")";
            // #Error
            Console.WriteLine(task.ExtendedAttributes[0].TextValue);
        }

        private static Project CreateTestProjectWithCustomField3()
        {
            var project = new Project();
            var attr = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Text, ExtendedAttributeTask.Text1, "Custom Field");
            project.ExtendedAttributes.Add(attr);

            var task = project.RootTask.Children.Add("Task");

            var attribute = attr.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(attribute);
            return project;
        }
        //ExEnd:CalculateTextFunctions
        
        [Test]
        public void FormulaWithBooleanValues()
        {
            //ExStart:FormulaWithBooleanValues
            //ExFor: ExtendedAttributeDefinition.Formula
            //ExSummary: Shows how to use boolean functions with extended attributes.
            var project = CreateTestProjectWithCustomField4();

            // Set formula for extended attribute
            project.ExtendedAttributes[0].Formula = "[Critical]-[Marked]+4+[Active]-Not [Active]";
            
            // Print value of extended attribute
            var task = project.RootTask.Children.GetById(1);
            Console.WriteLine("Formula with boolean values: " + task.ExtendedAttributes[0].TextValue);
            //ExEnd:FormulaWithBooleanValues
        }
      
        private static Project CreateTestProjectWithCustomField4()
        {
            var project = new Project();
            project.Set(Prj.StartDate, new DateTime(2015, 3, 6, 8, 0, 0));
            var attr = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Text, ExtendedAttributeTask.Text1, "Custom Field");
            project.ExtendedAttributes.Add(attr);

            var task = project.RootTask.Children.Add("Task");
            var extendedAttribute = attr.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(extendedAttribute);
            return project;
        }
        
        //ExStart:FormulaWithProjectFields
        //ExFor: ExtendedAttributeDefinition.Formula
        //ExSummary: Shows how to use extended attribute functions by using project fields.
        [Test] // ExSkip
        public void FormulaWithProjectFields()
        {            
            var project = CreateTestProjectWithCustomFieldWithoutResource();

            // Set formula
            project.ExtendedAttributes[0].Formula = "\"Total tasks: \" & [Task Count] & \" Total resources: \" & [Resource Count]";
            
            // Print if formula value is computed correctly
            var task = project.RootTask.Children.GetById(1);
            Console.WriteLine("Check Total tasks: 1 Total resources: 0 - {0}", task.ExtendedAttributes[0].TextValue.Equals("Total tasks: 1 Total resources: 0"));
        }

        private static Project CreateTestProjectWithCustomFieldWithoutResource()
        {
            var project = new Project();
            project.Set(Prj.StartDate, new DateTime(2015, 3, 6, 8, 0, 0));
            var attr = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Text, ExtendedAttributeTask.Text1, "Custom");
            project.ExtendedAttributes.Add(attr);
         
            var task = project.RootTask.Children.Add("Task");
            var attribute = attr.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(attribute);
            return project;
        }
        //ExEnd:FormulaWithProjectFields
        
        [Test]
        public void UsingArithmeticExpression()
        {
            //ExStart:UsingArithmeticExpression
            //ExFor: ExtendedAttributeDefinition.Alias
            //ExFor: ExtendedAttributeDefinition.Formula
            //ExSummary: Shows how to use arithmetic functions with extended attributes.
            var project = CreateTestProjectWithCustomField5();
            
            // Set arithmetic formula for extended attribute
            var attr = project.ExtendedAttributes[0];
            attr.Alias = "Arithmetic Expression";
            attr.Formula = "(1+3*(2+ -5)+8/2)^3";

            // Display extended attribute value
            var task = project.RootTask.Children.GetById(1);
            Console.WriteLine(task.ExtendedAttributes[0].NumericValue);
        }

        private static Project CreateTestProjectWithCustomField5()
        {
            var project = new Project();
            project.Set(Prj.StartDate, new DateTime(2015, 3, 6, 8, 0, 0));
            var attr = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Number, ExtendedAttributeTask.Number1, "Custom");
            project.ExtendedAttributes.Add(attr);

            var task = project.RootTask.Children.Add("Task");
            var extendedAttribute = attr.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(extendedAttribute);
            return project;
        }
        //ExEnd:UsingArithmeticExpression
        
        [Test]
        public void UsingTaskNumberFields()
        {
            //ExStart:UsingTaskNumberFields
            //ExFor: ExtendedAttributeDefinition.Formula
            //ExSummary: Shows how to use extended attribute functions by using task number fields.
            var project = CreateTestProjectWithCustomField6();

            // Set formula
            var attr = project.ExtendedAttributes[0];
            attr.Alias = "Task number fields";
            attr.Formula = "([Outline Level] + [Priority] + [% Complete])/2";

            var task = project.RootTask.Children.GetById(1);

            // Print extended attribute value before and after updating task percent complete
            Console.WriteLine(task.ExtendedAttributes[0].NumericValue);
            task.Set(Tsk.PercentComplete, 50);
            Console.WriteLine(task.ExtendedAttributes[0].NumericValue);
            //ExEnd:UsingTaskNumberFields
        }

        private static Project CreateTestProjectWithCustomField6()
        {
            var project = new Project();
            project.Set(Prj.StartDate, new DateTime(2015, 3, 6, 8, 0, 0));
            var attr = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Number, ExtendedAttributeTask.Number1, "Custom");
            project.ExtendedAttributes.Add(attr);
         
            var task = project.RootTask.Children.Add("Task");
            var extendedAttribute = attr.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(extendedAttribute);
            return project;
        }
        
        //ExStart:UsingTasksAndResourceFieldsInFormulaCalculations
        //ExFor: ExtendedAttributeDefinition.Formula
        //ExSummary: Shows how to use extended attribute functions by using task's and/or resource's fields.
        [Test] //ExSkip
        public void UsingTasksAndResourceFieldsInFormulaCalculations()
        {
            try
            {
                var project = CreateTestProjectWithCustomField7();
                var task = project.RootTask.Children.GetById(1);

                // Set formula for extended attribute
                var extendedAttributeDefinition1 = project.ExtendedAttributes[0];
                extendedAttributeDefinition1.Alias = "Days from finish to deadline";
                extendedAttributeDefinition1.Formula = "[Deadline] - [Finish]";

                // Set Task Deadline and save project
                task.Set(Tsk.Deadline, new DateTime(2015, 3, 20, 17, 0, 0));
                project.Save(OutDir + "UsingTasksAndResourceFields_out.mpp", SaveFileFormat.MPP);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }            
        }

        // Helper method to create project
        private static Project CreateTestProjectWithCustomField7()
        {
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
        
        [Test]
        public void WriteFormulasInExtendedAttributesToMpp()
        {
            try
            {
                //ExStart:WriteFormulasInExtendedAttributesToMpp
                //ExFor: ExtendedAttributeDefinition.Formula
                //ExSummary: Shows how to use extended attribute formulas with aliases.
                var project = new Project(DataDir + "Project1.mpp");
                project.Set(Prj.NewTasksAreManual, false);

                // Create new custom field (Task Text1) with formula which will double task cost
                var attr = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Text, ExtendedAttributeTask.Text1, "Custom");
                attr.Alias = "Double Costs";
                attr.Formula = "[Cost]*2";
                project.ExtendedAttributes.Add(attr);

                // Add a task
                var task = project.RootTask.Children.Add("Task");

                // Set task cost            
                task.Set(Tsk.Cost, 100);

                project.Save(OutDir + "WriteFormulasInExtendedAttributesToMPP_out.mpp", SaveFileFormat.MPP);
                //ExEnd:WriteFormulasInExtendedAttributesToMpp
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }            
        }
        
        [Test]
        public void AddExtendedAttributesToRAWithLookUp()
        {
            try
            {
                //ExStart: AddExtendedAttributesToRAWithLookUp
                //ExFor: ExtendedAttributeDefinition.CreateLookupResourceDefinition(CustomFieldType, ExtendedAttributeResource, String)
                //ExFor: ExtendedAttributeDefinition.AddLookupValue(Value)
                //ExSummary: Shows how to add extended attributes with lookups for assignments.
                var project = new Project(DataDir + "Blank2010.mpp");

                // Assign resource "1 TRG: Trade Group" to the "TASK 1" by creating a ResourceAssignment object.
                var resource = project.Resources.GetById(1);
                var task = project.RootTask.Children.GetById(1);
                var assignment = project.ResourceAssignments.Add(task, resource);

                // Create custom attribute definition with lookup.
                var resExtendedAttributeDefinition = ExtendedAttributeDefinition.CreateLookupResourceDefinition(
                    CustomFieldType.Cost,
                    ExtendedAttributeResource.Cost5,
                    "My lookup resource cost");
                project.ExtendedAttributes.Add(resExtendedAttributeDefinition);

                var firstValue = new Value { NumericValue = 1500, Description = "Val 1", Id = 1, Val = "1500" };
                var secondValue = new Value { NumericValue = 2500, Description = "Val 2", Id = 2 };
                resExtendedAttributeDefinition.AddLookupValue(firstValue);
                resExtendedAttributeDefinition.AddLookupValue(secondValue);

                // This value can be seen in "Resource usage" view of MS Project.
                var attributeValue = resExtendedAttributeDefinition.CreateExtendedAttribute(firstValue);
                assignment.ExtendedAttributes.Add(attributeValue);

                // Create custom attribute definition with lookup.
                var taskCostAttr = ExtendedAttributeDefinition.CreateLookupTaskDefinition(
                    ExtendedAttributeTask.Cost4,
                    "My lookup task cost");
                project.ExtendedAttributes.Add(taskCostAttr);
                var taskFirstValue = new Value { NumericValue = 18, Description = "Task val 1", Id = 3, Val = "18" };
                var resSecondValue = new Value { NumericValue = 30, Description = "Task val 2", Id = 4 };
                
                taskCostAttr.AddLookupValue(taskFirstValue);
                resExtendedAttributeDefinition.AddLookupValue(resSecondValue);

                // This value can be seen in "Task usage" view of MS Project.
                assignment.ExtendedAttributes.Add(taskCostAttr.CreateExtendedAttribute(taskFirstValue));

                project.Save(OutDir + "AddExtendedAttributesToRAWithLookUp_out.mpp", SaveFileFormat.MPP);
                //ExEnd:AddExtendedAttributesToRAWithLookUp
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void AddExtendedAttributesToResourceAssignment()
        {
            try
            {
                //ExStart: AddExtendedAttributesToResourceAssignment
                //ExFor: ExtendedAttributeDefinition.CreateResourceDefinition(CustomFieldType,ExtendedAttributeResource,String)
                //ExSummary: Shows how to add extended attribute to a resource assignment.
                var project = new Project(DataDir + "Blank2010.mpp");

                // Add new task and resource
                var task = project.RootTask.Children.Add("Task");
                var resource = project.Resources.Add("Rsc");
                var assignment = project.ResourceAssignments.Add(task, resource);

                // Custom attributes which is visible in "Resource Usage" view can be created with ExtendedAttributeDefinition.CreateResourceDefinition method.
                {
                    var resCostAttributeDefinition = ExtendedAttributeDefinition.CreateResourceDefinition(
                        CustomFieldType.Cost,
                        ExtendedAttributeResource.Cost5,
                        "My cost");

                    project.ExtendedAttributes.Add(resCostAttributeDefinition);

                    var value = resCostAttributeDefinition.CreateExtendedAttribute();

                    // The type of the attribute is "Cost", so we need to use "NumericValue" property.
                    value.NumericValue = 1500;

                    assignment.ExtendedAttributes.Add(value);
                }

                // Custom attributes which is visible in "Task Usage" view can be created with ExtendedAttributeDefinition.CreateTaskDefinition method
                {
                    var taskCostAttributeDefinition = ExtendedAttributeDefinition.CreateTaskDefinition(
                        CustomFieldType.Cost,
                        ExtendedAttributeTask.Cost5,
                        "My cost for task");

                    project.ExtendedAttributes.Add(taskCostAttributeDefinition);

                    var value = taskCostAttributeDefinition.CreateExtendedAttribute();

                    // The type of the attribute is "Cost", so we need to use "NumericValue" property.
                    value.NumericValue = 2300;

                    assignment.ExtendedAttributes.Add(value);
                }

                project.Save(OutDir + "AddExtendedAttributesToResourceAssignment_out.mpp", SaveFileFormat.MPP);
                //ExEnd:AddExtendedAttributesToResourceAssignment
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void CreateExtendedAttributes()
        {
            try
            {
                //ExStart:CreateExtendedAttributes
                //ExFor: ExtendedAttributeDefinition.CreateExtendedAttribute
                //ExSummary: Shows how to create extended attributes.
                var project = new Project(DataDir + "Blank2010.mpp");

                var definition = project.ExtendedAttributes.GetById((int)ExtendedAttributeTask.Text1);

                // If the Custom field doesn't exist in Project, create it
                if (definition == null)
                {
                    definition = ExtendedAttributeDefinition.CreateTaskDefinition(ExtendedAttributeTask.Text1, "My text field");
                    project.ExtendedAttributes.Add(definition);
                }

                // Generate Extended Attribute from definition
                var attribute = definition.CreateExtendedAttribute();
                attribute.TextValue = "Text attribute value";

                // Add extended attribute to task
                var task = project.RootTask.Children.Add("Task 1");
                task.ExtendedAttributes.Add(attribute);

                project.Save(OutDir + "CreateExtendedAttributes_out.mpp", SaveFileFormat.MPP);
                //ExEnd:CreateExtendedAttributes
            }
            catch (NotSupportedException ex)
            {
                Console.Write(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void WriteUpdatedExtendedAttributeDefinitions()
        {
            try
            {
                //ExStart:WriteUpdatedExtendedAttributeDefinitions
                //ExFor: ExtendedAttributeDefinition.CreateLookupTaskDefinition(ExtendedAttributeTask,String)
                //ExFor: ExtendedAttributeDefinition.CreateLookupResourceDefinition(ExtendedAttributeResource,String)
                //ExSummary: Shows how to write updated extended attribute definitions.
                var project = new Project(DataDir + "WriteUpdatedExtendedAttributeDefinitions.mpp");

                // Add new text3 extended attribute with lookup and one lookup value
                var definition = ExtendedAttributeDefinition.CreateLookupTaskDefinition(ExtendedAttributeTask.Text3, "New text3 attribute");
                definition.ElementType = ElementType.Task;
                project.ExtendedAttributes.Add(definition);

                var textVal = new Value();
                textVal.Id = 1;
                textVal.Description = "Text value descr";
                textVal.Val = "Text value1";

                definition.AddLookupValue(textVal);

                // Add new cost1 extended attribute with lookup and two cost values
                var taskCostAttributeDefinition = ExtendedAttributeDefinition.CreateLookupTaskDefinition(ExtendedAttributeTask.Cost1, "New cost1 attribute");
                project.ExtendedAttributes.Add(taskCostAttributeDefinition);

                var costVal1 = new Value();
                costVal1.Id = 2;
                costVal1.Description = "Cost value 1 descr";
                costVal1.Val = "99900";

                var costVal2 = new Value();
                costVal2.Id = 3;
                costVal2.Description = "Cost value 2 descr";
                costVal2.Val = "11100";

                taskCostAttributeDefinition.AddLookupValue(costVal1);
                taskCostAttributeDefinition.AddLookupValue(costVal2);

                // Add new task and assign attribute lookup value.
                var task = project.RootTask.Children.Add("New task");

                var taskAttr = taskCostAttributeDefinition.CreateExtendedAttribute(costVal1);
                task.ExtendedAttributes.Add(taskAttr);

                var taskStartAttributeDefinition = ExtendedAttributeDefinition.CreateLookupTaskDefinition(ExtendedAttributeTask.Start7, "New start 7 attribute");

                var startVal = new Value();
                startVal.Id = 4;
                startVal.DateTimeValue = DateTime.Now;
                startVal.Description = "Start 7 value description";

                taskStartAttributeDefinition.AddLookupValue(startVal);

                project.ExtendedAttributes.Add(taskStartAttributeDefinition);

                var taskFinishAttributeDefinition = ExtendedAttributeDefinition.CreateLookupTaskDefinition(ExtendedAttributeTask.Finish4, "New finish 4 attribute");

                var finishVal = new Value();
                finishVal.Id = 5;
                finishVal.DateTimeValue = DateTime.Now;
                finishVal.Description = "Finish 4 value description";

                taskFinishAttributeDefinition.ValueList.Add(finishVal);

                project.ExtendedAttributes.Add(taskFinishAttributeDefinition);

                var numberAttributeDefinition = ExtendedAttributeDefinition.CreateLookupTaskDefinition(ExtendedAttributeTask.Number20, "New number attribute");

                var val1 = new Value();
                val1.Id = 6;
                val1.Val = "1";
                val1.Description = "Number 1 value";
                var val2 = new Value();
                val2.Id = 7;
                val2.Val = "2";
                val2.Description = "Number 2 value";
                var val3 = new Value();
                val2.Id = 8;
                val3.Val = "3";
                val3.Description = "Number 3 value";

                numberAttributeDefinition.AddLookupValue(val1);
                numberAttributeDefinition.AddLookupValue(val2);
                numberAttributeDefinition.AddLookupValue(val3);

                project.ExtendedAttributes.Add(numberAttributeDefinition);

                var rscStartAttributeDefinition = ExtendedAttributeDefinition.CreateLookupResourceDefinition(ExtendedAttributeResource.Start5, "New start5 attribute");

                var startVal2 = new Value();
                startVal2.Id = 9;
                startVal2.DateTimeValue = DateTime.Now;
                startVal2.Description = "this is start5 value descr";

                rscStartAttributeDefinition.AddLookupValue(startVal2);

                project.ExtendedAttributes.Add(rscStartAttributeDefinition);

                // Define a duration attribute without lookup.
                var taskDurationAttributeDefinition = ExtendedAttributeDefinition.CreateTaskDefinition(ExtendedAttributeTask.Duration1, "New Duration");
                project.ExtendedAttributes.Add(taskDurationAttributeDefinition);

                // Add new task and assign duration value to the previously defined duration attribute.
                var timeTask = project.RootTask.Children.Add("New task");

                var durationExtendedAttribute = taskDurationAttributeDefinition.CreateExtendedAttribute();

                durationExtendedAttribute.DurationValue = project.GetDuration(3.0, TimeUnitType.Hour);
                timeTask.ExtendedAttributes.Add(durationExtendedAttribute);

                var mppSaveOptions = new MPPSaveOptions();
                mppSaveOptions.WriteViewData = true;

                project.Save(OutDir + "WriteUpdatedExtendedAttributeDefinitions_out.mpp", mppSaveOptions);
                //ExEnd:WriteUpdatedExtendedAttributeDefinitions
            }
            catch (NotSupportedException ex)
            {
                Console.Write(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void AddTaskExtendedAttributes()
        {
            try
            {
                //ExStart:AddTaskExtendedAttributes
                //ExFor: ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType,ExtendedAttributeTask,String)
                //ExSummary: Shows how to create task's extended attributes.
                var project = new Project(DataDir + "Blank2010.mpp");

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

                project.Save(OutDir + "PlainTextExtendedAttribute_out.mpp", SaveFileFormat.MPP);

                var project4 = new Project(DataDir + "Blank2010.mpp");

                //Create an Extended Attribute Definition of Text2 type
                var taskExtendedAttributeText2Definition = ExtendedAttributeDefinition.CreateLookupTaskDefinition(CustomFieldType.Text, ExtendedAttributeTask.Text2, "Task Towns Name");

                //Add lookup values for the extended attribute definition
                taskExtendedAttributeText2Definition.AddLookupValue(new Value { Id = 1, StringValue = "Town1", Description = "This is Town1" });
                taskExtendedAttributeText2Definition.AddLookupValue(new Value { Id = 2, StringValue = "Town2", Description = "This is Town2" });

                //Add it to the project's Extended Attributes collection
                project4.ExtendedAttributes.Add(taskExtendedAttributeText2Definition);

                //Add a task to the project
                var task2 = project4.RootTask.Children.Add("Task 2");

                //Crate an Extended Attribute from the Text2 Lookup Definition for Id 1
                var taskExtendedAttributeText2 = taskExtendedAttributeText2Definition.CreateExtendedAttribute(taskExtendedAttributeText2Definition.ValueList[1]);

                //Add the Extended Attribute to task
                task2.ExtendedAttributes.Add(taskExtendedAttributeText2);

                project4.Save(OutDir + "TextExtendedAttributeWithLookup_out.mpp", SaveFileFormat.MPP);

                var project2 = new Project(DataDir + "Blank2010.mpp");

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

                project2.Save(OutDir + "DurationExtendedAttributeWithLookup_out.mpp", SaveFileFormat.MPP);

                var project3 = new Project(DataDir + "Blank2010.mpp");

                //Create an Extended Attribute Definition of Finish2 Type
                var taskExtendedAttributeFinish2Definition = ExtendedAttributeDefinition.CreateLookupTaskDefinition(CustomFieldType.Finish, ExtendedAttributeTask.Finish2, "Some finish");

                //Add lookup values for extended attribute definition
                taskExtendedAttributeFinish2Definition.AddLookupValue(new Value { Id = 2, DateTimeValue = new DateTime(1984, 01, 01, 00, 00, 01), Description = "This is Value2" });
                taskExtendedAttributeFinish2Definition.AddLookupValue(new Value { Id = 3, DateTimeValue = new DateTime(1994, 01, 01, 00, 01, 01), Description = "This is Value3" });
                taskExtendedAttributeFinish2Definition.AddLookupValue(new Value { Id = 4, DateTimeValue = new DateTime(2009, 12, 31, 00, 00, 00), Description = "This is Value4" });
                taskExtendedAttributeFinish2Definition.AddLookupValue(new Value { Id = 7, DateTimeValue = DateTime.Now, Description = "This is Value6" });

                //Add the definition to the project's Extended Attributes collection
                project3.ExtendedAttributes.Add(taskExtendedAttributeFinish2Definition);

                //Add a task to the project
                var task4 = project3.RootTask.Children.Add("Task 4");

                //Create an Extended Attribute from the Finish2 Lookup Definition for Id 3
                var taskExtendedAttributeFinish2 = taskExtendedAttributeFinish2Definition.CreateExtendedAttribute(taskExtendedAttributeFinish2Definition.ValueList[3]);

                //Add the Extended Attribute to task
                task4.ExtendedAttributes.Add(taskExtendedAttributeFinish2);

                project3.Save(OutDir + "FinishExtendedAttributeWithLookup_out.mpp", SaveFileFormat.MPP);
                //ExEnd:AddTaskExtendedAttributes
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
        
        [Test]
        public void ReadTaskExtendedAttributes()
        {
            //ExStart:ReadTaskExtendedAttributes
            //ExFor: ExtendedAttributeDefinition.CfType
            //ExSummary: Shows how to work with CfType of custom extended attributes.
            var project = new Project(DataDir + "ReadTaskExtendedAttributes.mpp");

            // Read extended attributes for tasks
            foreach (var task in project.RootTask.Children)
            {
                foreach (var attribute in task.ExtendedAttributes)
                {
                    Console.WriteLine(attribute.FieldId);
                    Console.WriteLine(attribute.ValueGuid);

                    switch (attribute.AttributeDefinition.CfType)
                    {
                        case CustomFieldType.Date:
                        case CustomFieldType.Start:
                        case CustomFieldType.Finish:
                            Console.WriteLine(attribute.DateValue);
                            break;
                        case CustomFieldType.Text:
                            Console.WriteLine(attribute.TextValue);
                            break;
                        case CustomFieldType.Duration:
                            Console.WriteLine(attribute.DurationValue.ToString());
                            break;
                        case CustomFieldType.Cost:
                        case CustomFieldType.Number:
                            Console.WriteLine(attribute.NumericValue);
                            break;
                        case CustomFieldType.Flag:
                            Console.WriteLine(attribute.FlagValue);
                            break;
                        case CustomFieldType.Null:
                        case CustomFieldType.RBS:
                        case CustomFieldType.OutlineCode:
                            return;
                        default:
                            return;
                    }
                }
            }
            //ExEnd:ReadTaskExtendedAttributes
        }
    }
}