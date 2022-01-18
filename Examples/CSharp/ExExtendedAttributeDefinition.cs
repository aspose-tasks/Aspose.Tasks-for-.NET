namespace Aspose.Tasks.Examples.CSharp
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using NUnit.Framework;
    using Saving;

    [TestFixture]
    [SuppressMessage("ReSharper", "StyleCop.SA1600", Justification = "Reviewed. Suppression is OK here.")]
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global", Justification = "Reviewed. Suppression is OK here.")]
    public class ExExtendedAttributeDefinition : ApiExampleBase
    {
        [Test]
        public void CalculateGeneralFunctions()
        {
            EvaluateChoose();
            EvaluateIsNumeric();
            EvaluateSwitch();
        }

        // ExStart:CalculateGeneralFunctions
        // ExFor: ExtendedAttributeDefinition
        // ExFor: ExtendedAttributeDefinition.Formula
        // ExSummary: Shows how to use common math functions with extended attributes.
        public static void EvaluateChoose()
        {
            var project = CreateTestProjectWithCustomField();

            // Set Formula
            project.ExtendedAttributes[0].Formula = "Choose(3, \"This is a\", \"right\", \"choice\")";

            // Print extended attribute value
            var task = project.RootTask.Children.GetById(1);
            Console.WriteLine(task.ExtendedAttributes[0].TextValue);
        }

        public static void EvaluateIsNumeric()
        {
            string[] numericFormulas =
                {
                    "IsNumeric('AAA')", @"IsNUmeric(1)", "IsNumeric(1<0)", "IsNumeric(\"1.1\")", "IsNumeric(Choose((2 + Sgn(2^-3)), 123, \"one two three\"))"
                };

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

        public static void EvaluateSwitch()
        {
            var project = CreateTestProjectWithCustomField();

            // Set Formula
            project.ExtendedAttributes[0].Formula = "Switch( 0 < 1, \"0 is lesser than 1\", 0 > 1, \"0 is greater than 1\")";

            // Print extended attribute value
            var task = project.RootTask.Children.GetById(1);
            Console.WriteLine(task.ExtendedAttributes[0].TextValue);
        }

        public static Project CreateTestProjectWithCustomField()
        {
            var project = new Project();
            var definition = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Text, ExtendedAttributeTask.Text1, "Custom Field");
            project.ExtendedAttributes.Add(definition);

            var task = project.RootTask.Children.Add("Task");

            var attribute = definition.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(attribute);
            return project;
        }

        // ExEnd:CalculateGeneralFunctions

        // ExStart:CalculateMathExpressions
        // ExFor: ExtendedAttributeDefinition.Formula
        // ExSummary: Shows how to use transcendent math functions with extended attributes.
        [Test] // ExSkip
        public void CalculateMathExpressions()
        {
            var project = CreateTestProjectWithCustomField2();

            // Set formula Sin(pi/2)
            project.ExtendedAttributes[0].Formula = "Sin(3.1415926/2)";

            // Print Calculated value
            var task = project.RootTask.Children.GetById(1);
            Console.WriteLine("Sin(pi/2): {0}", task.ExtendedAttributes[0].NumericValue);
        }

        public static Project CreateTestProjectWithCustomField2()
        {
            var project = new Project();
            var attr = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Number, ExtendedAttributeTask.Number1, "Sine");
            project.ExtendedAttributes.Add(attr);

            var task = project.RootTask.Children.Add("Task");

            var attribute = attr.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(attribute);
            return project;
        }

        // ExEnd:CalculateMathExpressions
        [Test]
        public void CalculateTextFunctions()
        {
            EvaluateStrConv();
            EvaluateStringFunction();
        }

        // ExStart:CalculateTextFunctions
        // ExFor: ExtendedAttributeDefinition.Formula
        // ExSummary: Shows how to use text functions with extended attributes.
        public static void EvaluateStrConv()
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

        public static void EvaluateStringFunction()
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

        public static Project CreateTestProjectWithCustomField3()
        {
            var project = new Project();
            var attr = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Text, ExtendedAttributeTask.Text1, "Custom Field");
            project.ExtendedAttributes.Add(attr);

            var task = project.RootTask.Children.Add("Task");

            var attribute = attr.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(attribute);
            return project;
        }

        // ExEnd:CalculateTextFunctions
        [Test]
        public void FormulaWithBooleanValues()
        {
            // ExStart:FormulaWithBooleanValues
            // ExFor: ExtendedAttributeDefinition.Formula
            // ExSummary: Shows how to use boolean functions with extended attributes.
            var project = CreateTestProjectWithCustomField4();

            // Set formula for extended attribute
            project.ExtendedAttributes[0].Formula = "[Critical]-[Marked]+4+[Active]-Not [Active]";

            // Print value of extended attribute
            var task = project.RootTask.Children.GetById(1);
            Console.WriteLine("Formula with boolean values: " + task.ExtendedAttributes[0].TextValue);

            // ExEnd:FormulaWithBooleanValues
        }

        public static Project CreateTestProjectWithCustomField4()
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

        // ExStart:FormulaWithProjectFields
        // ExFor: ExtendedAttributeDefinition.Formula
        // ExSummary: Shows how to use extended attribute functions by using project fields.
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

        public static Project CreateTestProjectWithCustomFieldWithoutResource()
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

        // ExEnd:FormulaWithProjectFields
        [Test]
        public void UsingArithmeticExpression()
        {
            // ExStart:UsingArithmeticExpression 
            // ExFor: ExtendedAttributeDefinition.Formula
            // ExSummary: Shows how to use arithmetic functions with extended attributes.
            var project = CreateTestProjectWithCustomField5();

            // Set arithmetic formula for extended attribute
            var attr = project.ExtendedAttributes[0];
            attr.Alias = "Arithmetic Expression";
            attr.Formula = "(1+3*(2+ -5)+8/2)^3";

            // Display extended attribute value
            var task = project.RootTask.Children.GetById(1);
            Console.WriteLine(task.ExtendedAttributes[0].NumericValue);
        }

        public static Project CreateTestProjectWithCustomField5()
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

        // ExEnd:UsingArithmeticExpression
        [Test]
        public void UsingTaskNumberFields()
        {
            // ExStart:UsingTaskNumberFields
            // ExFor: ExtendedAttributeDefinition.Formula
            // ExSummary: Shows how to use extended attribute functions by using task number fields.
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

            // ExEnd:UsingTaskNumberFields
        }

        public static Project CreateTestProjectWithCustomField6()
        {
            var project = new Project();
            project.Set(Prj.StartDate, new DateTime(2020, 4, 27, 8, 0, 0));
            var attr = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Number, ExtendedAttributeTask.Number1, "Custom");
            project.ExtendedAttributes.Add(attr);

            var task = project.RootTask.Children.Add("Task");
            var extendedAttribute = attr.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(extendedAttribute);
            return project;
        }

        // ExStart:UsingTasksAndResourceFieldsInFormulaCalculations
        // ExFor: ExtendedAttributeDefinition.Formula
        // ExSummary: Shows how to use extended attribute functions by using task's and/or resource's fields.
        [Test] // ExSkip
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
                project.Save(OutDir + "UsingTasksAndResourceFields_out.mpp", SaveFileFormat.Mpp);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }

        // Helper method to create project
        public static Project CreateTestProjectWithCustomField7()
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

        // ExEnd:UsingTasksAndResourceFieldsInFormulaCalculations
        [Test]
        public void WriteFormulasInExtendedAttributesToMpp()
        {
            try
            {
                // ExStart:WriteFormulasInExtendedAttributesToMpp
                // ExFor: ExtendedAttributeDefinition.Formula
                // ExSummary: Shows how to use extended attribute formulas with aliases.
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

                project.Save(OutDir + "WriteFormulasInExtendedAttributesToMPP_out.mpp", SaveFileFormat.Mpp);

                // ExEnd:WriteFormulasInExtendedAttributesToMpp
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }

        [Test]
        public void AddExtendedAttributesToRAWithLookUp()
        {
            // ExStart:AddExtendedAttributesToRAWithLookUp
            // ExFor: ExtendedAttributeDefinition.AddLookupValue(Value)
            // ExFor: ExtendedAttributeDefinition.CreateLookupResourceDefinition(CustomFieldType,ExtendedAttributeResource,String)
            // ExFor: ExtendedAttributeDefinition.CreateLookupTaskDefinition(CustomFieldType,ExtendedAttributeTask,String)
            // ExFor: ExtendedAttributeDefinition.RemoveLookupValue(Value)
            // ExFor: ExtendedAttributeTask
            // ExSummary: Shows how to add extended attributes with lookups for assignments.
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
            var taskCostAttr = ExtendedAttributeDefinition.CreateLookupTaskDefinition(CustomFieldType.Cost, ExtendedAttributeTask.Cost4, "My lookup task cost");
            project.ExtendedAttributes.Add(taskCostAttr);
            var taskFirstValue = new Value { NumericValue = 18, Description = "Task val 1", Id = 3, Val = "18" };
            var resSecondValue = new Value { NumericValue = 30, Description = "Task val 2", Id = 4 };
            var taskWrongValue = new Value { NumericValue = 99, Description = "Task val Wrong", Id = 5, Val = "18" };

            taskCostAttr.AddLookupValue(taskFirstValue);
            resExtendedAttributeDefinition.AddLookupValue(resSecondValue);

            // This value can be seen in "Task usage" view of MS Project.
            assignment.ExtendedAttributes.Add(taskCostAttr.CreateExtendedAttribute(taskFirstValue));

            // a wrong values can be removed later
            taskCostAttr.RemoveLookupValue(taskWrongValue);

            // working with project... 
            // ExEnd:AddExtendedAttributesToRAWithLookUp
        }

        [Test]
        public void AddExtendedAttributesToResourceAssignment()
        {
            try
            {
                // ExStart: AddExtendedAttributesToResourceAssignment
                // ExFor: ExtendedAttributeDefinition.CreateResourceDefinition(CustomFieldType,ExtendedAttributeResource,String)
                // ExSummary: Shows how to add extended attribute to a resource assignment.
                var project = new Project(DataDir + "Blank2010.mpp");

                // Add new task and resource
                var task = project.RootTask.Children.Add("Task");
                var resource = project.Resources.Add("Rsc");
                var assignment = project.ResourceAssignments.Add(task, resource);
                {
                    // Custom attributes which is visible in "Resource Usage" view can be created with ExtendedAttributeDefinition.CreateResourceDefinition method.
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

                {
                    // Custom attributes which is visible in "Task Usage" view can be created with ExtendedAttributeDefinition.CreateTaskDefinition method
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

                project.Save(OutDir + "AddExtendedAttributesToResourceAssignment_out.mpp", SaveFileFormat.Mpp);

                // ExEnd:AddExtendedAttributesToResourceAssignment
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }

        [Test]
        public void CreateExtendedAttributes()
        {
            try
            {
                // ExStart:CreateExtendedAttributes
                // ExFor: ExtendedAttributeDefinition.CreateExtendedAttribute
                // ExSummary: Shows how to create extended attributes.
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

                project.Save(OutDir + "CreateExtendedAttributes_out.mpp", SaveFileFormat.Mpp);

                // ExEnd:CreateExtendedAttributes
            }
            catch (NotSupportedException ex)
            {
                Console.Write(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }

        [Test]
        public void WriteUpdatedExtendedAttributeDefinitions()
        {
            try
            {
                // ExStart:WriteUpdatedExtendedAttributeDefinitions
                // ExFor: ExtendedAttributeDefinition.CreateLookupTaskDefinition(ExtendedAttributeTask,String)
                // ExFor: ExtendedAttributeDefinition.CreateLookupResourceDefinition(ExtendedAttributeResource,String)
                // ExFor: ElementType
                // ExSummary: Shows how to write updated extended attribute definitions.
                var project = new Project(DataDir + "WriteUpdatedExtendedAttributeDefinitions.mpp");

                // Add new text3 extended attribute with lookup and one lookup value
                var definition = ExtendedAttributeDefinition.CreateLookupTaskDefinition(ExtendedAttributeTask.Text3, "New text3 attribute");
                definition.ElementType = ElementType.Task;
                project.ExtendedAttributes.Add(definition);

                var textVal = new Value
                {
                    Id = 1,
                    Description = "Text value descr",
                    Val = "Text value1"
                };

                definition.AddLookupValue(textVal);

                // Add new cost1 extended attribute with lookup and two cost values
                var taskCostAttributeDefinition = ExtendedAttributeDefinition.CreateLookupTaskDefinition(ExtendedAttributeTask.Cost1, "New cost1 attribute");
                project.ExtendedAttributes.Add(taskCostAttributeDefinition);

                var costVal1 = new Value
                {
                    Id = 2,
                    Description = "Cost value 1 descr",
                    Val = "99900"
                };

                var costVal2 = new Value
                {
                    Id = 3,
                    Description = "Cost value 2 descr",
                    Val = "11100"
                };

                taskCostAttributeDefinition.AddLookupValue(costVal1);
                taskCostAttributeDefinition.AddLookupValue(costVal2);

                // Add new task and assign attribute lookup value.
                var task = project.RootTask.Children.Add("New task");

                var taskAttr = taskCostAttributeDefinition.CreateExtendedAttribute(costVal1);
                task.ExtendedAttributes.Add(taskAttr);

                var taskStartAttributeDefinition = ExtendedAttributeDefinition.CreateLookupTaskDefinition(ExtendedAttributeTask.Start7, "New start 7 attribute");

                var startVal = new Value
                {
                    Id = 4,
                    DateTimeValue = DateTime.Now,
                    Description = "Start 7 value description"
                };

                taskStartAttributeDefinition.AddLookupValue(startVal);

                project.ExtendedAttributes.Add(taskStartAttributeDefinition);

                var taskFinishAttributeDefinition = ExtendedAttributeDefinition.CreateLookupTaskDefinition(ExtendedAttributeTask.Finish4, "New finish 4 attribute");

                var finishVal = new Value
                {
                    Id = 5,
                    DateTimeValue = DateTime.Now,
                    Description = "Finish 4 value description"
                };

                taskFinishAttributeDefinition.ValueList.Add(finishVal);

                project.ExtendedAttributes.Add(taskFinishAttributeDefinition);

                var numberAttributeDefinition = ExtendedAttributeDefinition.CreateLookupTaskDefinition(ExtendedAttributeTask.Number20, "New number attribute");

                var val1 = new Value
                {
                    Id = 6,
                    Val = "1",
                    Description = "Number 1 value"
                };
                var val2 = new Value
                {
                    Id = 7,
                    Val = "2",
                    Description = "Number 2 value"
                };
                var val3 = new Value();
                val2.Id = 8;
                val3.Val = "3";
                val3.Description = "Number 3 value";

                numberAttributeDefinition.AddLookupValue(val1);
                numberAttributeDefinition.AddLookupValue(val2);
                numberAttributeDefinition.AddLookupValue(val3);

                project.ExtendedAttributes.Add(numberAttributeDefinition);

                var rscStartAttributeDefinition = ExtendedAttributeDefinition.CreateLookupResourceDefinition(ExtendedAttributeResource.Start5, "New start5 attribute");

                var value = new Value
                {
                    Id = 9,
                    DateTimeValue = DateTime.Now,
                    Description = "this is start5 value descr"
                };

                rscStartAttributeDefinition.AddLookupValue(value);

                project.ExtendedAttributes.Add(rscStartAttributeDefinition);

                // Define a duration attribute without lookup.
                var taskDurationAttributeDefinition = ExtendedAttributeDefinition.CreateTaskDefinition(ExtendedAttributeTask.Duration1, "New Duration");
                project.ExtendedAttributes.Add(taskDurationAttributeDefinition);

                // Add new task and assign duration value to the previously defined duration attribute.
                var timeTask = project.RootTask.Children.Add("New task");

                var durationExtendedAttribute = taskDurationAttributeDefinition.CreateExtendedAttribute();

                durationExtendedAttribute.DurationValue = project.GetDuration(3.0, TimeUnitType.Hour);
                timeTask.ExtendedAttributes.Add(durationExtendedAttribute);

                var options = new MPPSaveOptions
                {
                    WriteViewData = true
                };

                project.Save(OutDir + "WriteUpdatedExtendedAttributeDefinitions_out.mpp", options);

                // ExEnd:WriteUpdatedExtendedAttributeDefinitions
            }
            catch (NotSupportedException ex)
            {
                Console.Write(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }

        [Test]
        public void AddTaskExtendedAttributes()
        {
            try
            {
                // ExStart:AddTaskExtendedAttributes
                // ExFor: ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType,ExtendedAttributeTask,String)
                // ExSummary: Shows how to create task's extended attributes.
                var project = new Project(DataDir + "Blank2010.mpp");

                // Create an Extended Attribute Definition of Text1 type
                var taskExtendedAttributeText1Definition =
                    ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Text, ExtendedAttributeTask.Text1, "Task City Name");

                // Add it to the project's Extended Attributes collection
                project.ExtendedAttributes.Add(taskExtendedAttributeText1Definition);

                // Add a task to the project
                var task = project.RootTask.Children.Add("Task 1");

                // Create an Extended Attribute from the Attribute Definition
                var taskExtendedAttributeText1 = taskExtendedAttributeText1Definition.CreateExtendedAttribute();

                // Assign a value to the generated Extended Attribute. The type of the attribute is "Text", the "TextValue" property should be used.
                taskExtendedAttributeText1.TextValue = "London";

                // Add the Extended Attribute to task
                task.ExtendedAttributes.Add(taskExtendedAttributeText1);

                project.Save(OutDir + "PlainTextExtendedAttribute_out.mpp", SaveFileFormat.Mpp);

                var project4 = new Project(DataDir + "Blank2010.mpp");

                // Create an Extended Attribute Definition of Text2 type
                var taskExtendedAttributeText2Definition = ExtendedAttributeDefinition.CreateLookupTaskDefinition(
                    CustomFieldType.Text,
                    ExtendedAttributeTask.Text2,
                    "Task Towns Name");

                // Add lookup values for the extended attribute definition
                taskExtendedAttributeText2Definition.AddLookupValue(new Value { Id = 1, StringValue = "Town1", Description = "This is Town1" });
                taskExtendedAttributeText2Definition.AddLookupValue(new Value { Id = 2, StringValue = "Town2", Description = "This is Town2" });

                // Add it to the project's Extended Attributes collection
                project4.ExtendedAttributes.Add(taskExtendedAttributeText2Definition);

                // Add a task to the project
                var task2 = project4.RootTask.Children.Add("Task 2");

                // Crate an Extended Attribute from the Text2 Lookup Definition for Id 1
                var taskExtendedAttributeText2 = taskExtendedAttributeText2Definition.CreateExtendedAttribute(taskExtendedAttributeText2Definition.ValueList[1]);

                // Add the Extended Attribute to task
                task2.ExtendedAttributes.Add(taskExtendedAttributeText2);

                project4.Save(OutDir + "TextExtendedAttributeWithLookup_out.mpp", SaveFileFormat.Mpp);

                var project2 = new Project(DataDir + "Blank2010.mpp");

                // Create an Extended Attribute Definition of Duration2 type
                var taskExtendedAttributeDuration2Definition = ExtendedAttributeDefinition.CreateLookupTaskDefinition(
                    CustomFieldType.Duration,
                    ExtendedAttributeTask.Duration2,
                    "Some duration");

                // Add lookup values for extended attribute definition
                taskExtendedAttributeDuration2Definition.AddLookupValue(
                    new Value { Id = 2, Duration = project2.GetDuration(4, TimeUnitType.Hour), Description = "4 hours" });
                taskExtendedAttributeDuration2Definition.AddLookupValue(
                    new Value { Id = 3, Duration = project2.GetDuration(1, TimeUnitType.Day), Description = "1 day" });
                taskExtendedAttributeDuration2Definition.AddLookupValue(
                    new Value { Id = 4, Duration = project2.GetDuration(1, TimeUnitType.Hour), Description = "1 hour" });
                taskExtendedAttributeDuration2Definition.AddLookupValue(
                    new Value { Id = 7, Duration = project2.GetDuration(10, TimeUnitType.Day), Description = "10 days" });

                // Add the definition to the project's Extended Attributes collection
                project2.ExtendedAttributes.Add(taskExtendedAttributeDuration2Definition);

                // Add a task to the project
                var task3 = project2.RootTask.Children.Add("Task 3");

                // Create an Extended Attribute from the Duration2 Lookup Definition for Id 3
                var taskExtendedAttributeDuration2 =
                    taskExtendedAttributeDuration2Definition.CreateExtendedAttribute(taskExtendedAttributeDuration2Definition.ValueList[3]);

                // Add the Extended Attribute to task
                task3.ExtendedAttributes.Add(taskExtendedAttributeDuration2);

                project2.Save(OutDir + "DurationExtendedAttributeWithLookup_out.mpp", SaveFileFormat.Mpp);

                var project3 = new Project(DataDir + "Blank2010.mpp");

                // Create an Extended Attribute Definition of Finish2 Type
                var taskExtendedAttributeFinish2Definition = ExtendedAttributeDefinition.CreateLookupTaskDefinition(
                    CustomFieldType.Finish,
                    ExtendedAttributeTask.Finish2,
                    "Some finish");

                // Add lookup values for extended attribute definition
                taskExtendedAttributeFinish2Definition.AddLookupValue(
                    new Value { Id = 2, DateTimeValue = new DateTime(1984, 01, 01, 00, 00, 01), Description = "This is Value2" });
                taskExtendedAttributeFinish2Definition.AddLookupValue(
                    new Value { Id = 3, DateTimeValue = new DateTime(1994, 01, 01, 00, 01, 01), Description = "This is Value3" });
                taskExtendedAttributeFinish2Definition.AddLookupValue(
                    new Value { Id = 4, DateTimeValue = new DateTime(2009, 12, 31, 00, 00, 00), Description = "This is Value4" });
                taskExtendedAttributeFinish2Definition.AddLookupValue(new Value { Id = 7, DateTimeValue = DateTime.Now, Description = "This is Value6" });

                // Add the definition to the project's Extended Attributes collection
                project3.ExtendedAttributes.Add(taskExtendedAttributeFinish2Definition);

                // Add a task to the project
                var task4 = project3.RootTask.Children.Add("Task 4");

                // Create an Extended Attribute from the Finish2 Lookup Definition for Id 3
                var taskExtendedAttributeFinish2 = taskExtendedAttributeFinish2Definition.CreateExtendedAttribute(taskExtendedAttributeFinish2Definition.ValueList[3]);

                // Add the Extended Attribute to task
                task4.ExtendedAttributes.Add(taskExtendedAttributeFinish2);

                project3.Save(OutDir + "FinishExtendedAttributeWithLookup_out.mpp", SaveFileFormat.Mpp);

                // ExEnd:AddTaskExtendedAttributes
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(
                    ex.Message
                    + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }

        [Test]
        public void ReadTaskExtendedAttributes()
        {
            // ExStart:ReadTaskExtendedAttributes
            // ExFor: ExtendedAttributeDefinition.CfType
            // ExSummary: Shows how to work with CfType of custom extended attributes.
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

            // ExEnd:ReadTaskExtendedAttributes
        }

        [Test]
        public void WorkWithAppendNewValues()
        {
            // ExStart
            // ExFor: ExtendedAttributeDefinition.Guid
            // ExFor: ExtendedAttributeDefinition.SecondaryGuid
            // ExFor: ExtendedAttributeDefinition.SecondaryPid
            // ExFor: ExtendedAttributeDefinition.Alias
            // ExFor: ExtendedAttributeDefinition.PhoneticsAlias
            // ExFor: ExtendedAttributeDefinition.FieldId
            // ExFor: ExtendedAttributeDefinition.AppendNewValues
            // ExFor: ExtendedAttributeDefinition.AutoRollDown
            // ExFor: ExtendedAttributeDefinition.CalculationType
            // ExFor: ExtendedAttributeDefinition.DefaultGuid
            // ExFor: ExtendedAttributeDefinition.ElementType
            // ExFor: ExtendedAttributeDefinition.FieldName
            // ExFor: ExtendedAttributeDefinition.LookupUid
            // ExFor: ExtendedAttributeDefinition.RestrictValues
            // ExFor: ExtendedAttributeDefinition.MaxMultiValues
            // ExFor: ExtendedAttributeDefinition.ValuelistSortOrder
            // ExFor: ExtendedAttributeDefinition.UserDef
            // ExFor: ExtendedAttributeDefinition.Default
            // ExFor: ExtendedAttributeDefinition.RollupType
            // ExFor: ExtendedAttributeDefinition.ParentProject
            // ExFor: ExtendedAttributeDefinition.ValueList
            // ExFor: RollupType
            // ExSummary: Shows how to read extended attribute definition common information.
            var project = new Project(DataDir + "MultipleOutlineValues2016.mpp");

            // read extended attribute definition information
            foreach (var definition in project.ExtendedAttributes)
            {
                Console.WriteLine("Guid:" + definition.Guid);
                Console.WriteLine("Secondary Guid:" + definition.SecondaryGuid);
                Console.WriteLine("Secondary Pid:" + definition.SecondaryPid);
                Console.WriteLine("Alias:" + definition.Alias);
                Console.WriteLine("Phonetics Alias:" + definition.PhoneticsAlias);
                Console.WriteLine("Field Id:" + definition.FieldId);
                Console.WriteLine("Project Name:" + definition.ParentProject.Get(Prj.Name));

                Console.WriteLine("Append New Values:" + definition.AppendNewValues);
                Console.WriteLine("Auto RollDown:" + definition.AutoRollDown);
                Console.WriteLine("Calculation Type:" + definition.CalculationType);
                Console.WriteLine("Field Name" + definition.FieldName);
                Console.WriteLine("Is User Defined Custom Field:" + definition.UserDef);
                Console.WriteLine("Rollup Type:" + definition.RollupType);

                if (definition.CalculationType == CalculationType.Lookup)
                {
                    Console.WriteLine("  Next properties are used only for lookups:");
                    Console.WriteLine("  Default Guid:" + definition.DefaultGuid);
                    Console.WriteLine("  Element Type:" + definition.ElementType);
                    Console.WriteLine("  Lookup Uid:" + definition.LookupUid);
                    Console.WriteLine("  Restrict Values:" + definition.RestrictValues);
                    Console.WriteLine("  Max Multi Values:" + definition.MaxMultiValues);
                    Console.WriteLine("  Valuelist Sort Order:" + definition.ValuelistSortOrder);
                    Console.WriteLine("  Default Value:" + definition.Default);
                    Console.WriteLine("  Print values from value list:");
                    foreach (var value in definition.ValueList)
                    {
                        Console.WriteLine("    Description: " + value.Description);
                        Console.WriteLine("    Value: " + value.Val);
                    }
                }

                Console.WriteLine();
            }

            // ExEnd
        }

        [Test]
        public void ExtendedAttributeDefinitionEquals()
        {
            // ExStart
            // ExFor: ExtendedAttributeDefinition.Equals(Object)
            // ExSummary: Shows how to check extended attribute definition equality.
            var project = new Project(DataDir + "MultipleOutlineValues2016.mpp");

            var attributeDefinition1 = project.ExtendedAttributes.GetById((int)ExtendedAttributeTask.Start3);
            var attributeDefinition2 = project.ExtendedAttributes.GetById((int)ExtendedAttributeTask.Duration2);

            // the equality of calendars is checked against to attribute definition field ids.
            Console.WriteLine("ExtendedAttribute 1 Field Id: " + attributeDefinition1.FieldId);
            Console.WriteLine("ExtendedAttribute 2 Field Id: " + attributeDefinition2.FieldId);
            Console.WriteLine("Are extended attributes equal: " + attributeDefinition1.Equals(attributeDefinition2));

            // ExEnd
        }

        [Test]
        public void GetExtendedAttributeDefinitionHashCode()
        {
            // ExStart
            // ExFor: ExtendedAttributeDefinition.GetHashCode
            // ExSummary: Shows how to get a hash code of a extended attribute definition.
            var project = new Project(DataDir + "MultipleOutlineValues2016.mpp");

            var attributeDefinition1 = project.ExtendedAttributes.GetById((int)ExtendedAttributeTask.Start3);
            var attributeDefinition2 = project.ExtendedAttributes.GetById((int)ExtendedAttributeTask.Duration2);

            // the hash code of a extended attribute definition is equal to a field id.
            Console.WriteLine("Extended Attribute Field Id: {0} Hash Code: {1}", attributeDefinition1.FieldId, attributeDefinition1.GetHashCode());
            Console.WriteLine("Extended Attribute Field Id: {0} Hash Code: {1}", attributeDefinition2.FieldId, attributeDefinition2.GetHashCode());

            // ExEnd
        }

        [Test]
        public void WorkWithCreateExtendedAttributeDuration()
        {
            // ExStart
            // ExFor: ExtendedAttributeDefinition.CreateExtendedAttribute(Duration)
            // ExSummary: Shows how to create extended attribute definition and set a duration while its constructing.
            var project = new Project(DataDir + "Project2.mpp");
            var task = project.RootTask.Children.Add("Test");
            task.Set(Tsk.Start, new DateTime(2020, 4, 22, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(1, TimeUnitType.Day));

            var definition = ExtendedAttributeDefinition.CreateTaskDefinition(ExtendedAttributeTask.Duration1, "Custom Duration");
            project.ExtendedAttributes.Add(definition);

            // extended attribute Duration1 = 2 days
            var extendedAttribute = definition.CreateExtendedAttribute(project.GetDuration(2, TimeUnitType.Day));

            // add extended attribute to the task
            task.ExtendedAttributes.Add(extendedAttribute);

            // ExEnd
        }

        [Test]
        public void WorkWithCreateExtendedAttributeValue()
        {
            // ExStart
            // ExFor: ExtendedAttributeDefinition.CreateExtendedAttribute(Value)
            // ExSummary: Shows how to create extended attribute definition and set a value while its constructing.
            var project = new Project(DataDir + "Project2.mpp");

            // Create a custom field definition based on the lookup table, which was declared above.
            var customFieldDefinition = ExtendedAttributeDefinition.CreateLookupTaskDefinition(CustomFieldType.Number, ExtendedAttributeTask.Number10, "Status");

            var value1 = new Value { Id = 1, Val = "25", Description = "Active" };
            var value2 = new Value { Id = 2, Val = "12", Description = "Inactive" };
            customFieldDefinition.AddLookupValue(value1);
            customFieldDefinition.AddLookupValue(value2);
            project.ExtendedAttributes.Add(customFieldDefinition);

            var task = project.RootTask.Children.Add("Task");

            // create extended attribute for a value 
            var extendedAttribute = customFieldDefinition.CreateExtendedAttribute(value2);

            // add extended attribute to the task
            task.ExtendedAttributes.Add(extendedAttribute);

            // ExEnd
        }

        [Test]
        public void WorkWithCreateExtendedAttributeFlag()
        {
            // ExStart
            // ExFor: ExtendedAttributeDefinition.CreateExtendedAttribute(Boolean)
            // ExFor: ExtendedAttributeDefinition.CreateResourceDefinition(ExtendedAttributeResource,String)
            // ExFor: ExtendedAttributeResource
            // ExSummary: Shows how to create extended attribute definition and set a value of a flag while its constructing.
            var project = new Project(DataDir + "Project2.mpp");

            var resource = project.Resources.Add("Resource 1");
            resource.Set(Rsc.Type, ResourceType.Cost);

            // create a definition for a boolean custom field
            var definition = ExtendedAttributeDefinition.CreateResourceDefinition(ExtendedAttributeResource.Flag7, "My Custom Flag");

            // create an attribute and set the initial value to 'true'
            var attribute = definition.CreateExtendedAttribute(true);
            resource.ExtendedAttributes.Add(attribute);

            // ExEnd
        }

        [Test]
        public void WorkWithCreateExtendedAttributeDateTime()
        {
            // ExStart
            // ExFor: ExtendedAttributeDefinition.CreateExtendedAttribute(DateTime)
            // ExSummary: Shows how to create extended attribute definition and set a datetime value of the attribute while its constructing.
            var project = new Project(DataDir + "Project2.mpp");

            var definitionWithDate = ExtendedAttributeDefinition.CreateTaskDefinition(ExtendedAttributeTask.Date1, "My Date");
            project.ExtendedAttributes.Add(definitionWithDate);

            var task = project.RootTask.Children.Add("Task");
            task.Set(Tsk.Start, new DateTime(2020, 4, 22, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(1, TimeUnitType.Day));

            // create extended attribute with a value equals to DateTime.Now 
            var extendedAttribute = definitionWithDate.CreateExtendedAttribute(DateTime.Now);

            // add extended attribute
            task.ExtendedAttributes.Add(extendedAttribute);

            // ExEnd
        }

        [Test]
        public void WorkWithCreateExtendedAttributeDecimal()
        {
            // ExStart
            // ExFor: ExtendedAttributeDefinition.CreateExtendedAttribute(Decimal)
            // ExSummary: Shows how to create extended attribute definition and set a decimal value of the attribute while its constructing.
            var project = new Project(DataDir + "Project2.mpp");

            var definition = ExtendedAttributeDefinition.CreateTaskDefinition(ExtendedAttributeTask.Cost1, "My Cost");
            project.ExtendedAttributes.Add(definition);

            var task = project.RootTask.Children.Add("Task");
            task.Set(Tsk.Start, new DateTime(2020, 4, 22, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(1, TimeUnitType.Day));

            // create extended attribute with a value equals to 999m 
            var extendedAttribute = definition.CreateExtendedAttribute(999m);

            // add extended attribute initialized by value 999m
            task.ExtendedAttributes.Add(extendedAttribute);

            // ExEnd
        }

        [Test]
        public void WorkWithCreateExtendedAttributeText()
        {
            // ExStart
            // ExFor: ExtendedAttributeDefinition.CreateExtendedAttribute(String)
            // ExFor: ExtendedAttributeDefinition.CreateTaskDefinition(ExtendedAttributeTask,String)
            // ExSummary: Shows how to create extended attribute definition and set a string value of the attribute while its constructing.
            var project = new Project(DataDir + "Project2.mpp");

            var definition = ExtendedAttributeDefinition.CreateTaskDefinition(ExtendedAttributeTask.Text1, "My Text");
            project.ExtendedAttributes.Add(definition);

            var task = project.RootTask.Children.Add("Task");
            task.Set(Tsk.Start, new DateTime(2020, 4, 22, 8, 0, 0));
            task.Set(Tsk.Duration, project.GetDuration(1, TimeUnitType.Day));

            // create extended attribute with a value equals to the 'Common Info'
            var extendedAttribute = definition.CreateExtendedAttribute("Common Info");

            // add extended attribute initialized by value the 'Common Info'
            task.ExtendedAttributes.Add(extendedAttribute);

            // ExEnd
        }
    }
}