using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithFormulas
{
    class CalculateDateTimeFunctions
    {
        public static void Run()
        {
            // ExStart:CalculateDateTimeFunctions
            Project project = CreateTestProjectWithCustomField();
            Task task = project.RootTask.Children.GetById(1);

            // Set ProjDateDiff formula and print entended attribute value
            project.ExtendedAttributes[0].Formula = "ProjDateDiff(\"03/23/2015\",\"03/18/2015\")";
            Console.WriteLine(task.ExtendedAttributes[0].Value);
            project.ExtendedAttributes[0].Formula = "ProjDateDiff(\"03/23/2015\",\"03/25/2015\")";
            Console.WriteLine(task.ExtendedAttributes[0].Value);

            // Set ProjDateSub formula and print entended attribute value
            project.ExtendedAttributes[0].Formula = "ProjDateSub(\"3/19/2015\", \"1d\")";
            Console.WriteLine(task.ExtendedAttributes[0].Value);

            // Set ProjDurConv formula and print entended attribute value
            project.ExtendedAttributes[0].Formula = "ProjDurConv([Duration], pjHours)";
            Console.WriteLine(task.ExtendedAttributes[0].Value);
            project.ExtendedAttributes[0].Formula = "ProjDurConv([Duration], pjWeeks)";
            Console.WriteLine(task.ExtendedAttributes[0].Value);

            // Set Second formula and print entended attribute value
            project.ExtendedAttributes[0].Formula = "Second(\"4/21/2015 2:53:41 AM\")";
            Console.WriteLine(task.ExtendedAttributes[0].Value);

            // Set Weekday formula and print entended attribute value
            project.ExtendedAttributes[0].Formula = "Weekday(\"24/3/2015\", 1)";
            Console.WriteLine(task.ExtendedAttributes[0].Value);
            project.ExtendedAttributes[0].Formula = "Weekday(\"24/3/2015\", 2)";
            Console.WriteLine(task.ExtendedAttributes[0].Value);
            project.ExtendedAttributes[0].Formula = "Weekday(\"24/3/2015\", 3)";
            Console.WriteLine(task.ExtendedAttributes[0].Value);
            // ExEnd:CalculateDateTimeFunctions
        }

        public static Project CreateTestProjectWithCustomField()
        {
            Project project = new Project();
            ExtendedAttributeDefinition attr = ExtendedAttributeDefinition.CreateTaskDefinition(CustomFieldType.Text, ExtendedAttributeTask.Text1, "Custom Field");
            
            project.ExtendedAttributes.Add(attr);

            Task task = project.RootTask.Children.Add("Task");

            ExtendedAttribute a = attr.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(a);
            return project;
        } 
    }
}
