using System;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.ModifyingCreatedProject
{
    public class UsingArithmeticExpression
    {
        public static void Run()
        {
            // ExStart:UsingArithmeticExpression
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingCreatedProject();

            Project project = CreateTestProjectWithCustomField();
            ExtendedAttributeDefinition attr = project.ExtendedAttributes[0];
            attr.Alias = "Arithmetic Expression";
            attr.Formula = "(1+3*(2+ -5)+8/2)^3";
            Task task = project.RootTask.Children.GetById(1);
            Console.WriteLine(task.ExtendedAttributes[0].Value);
            // ExEnd:UsingArithmeticExpression
        }

        private static Project CreateTestProjectWithCustomField()
        {
            Project project = new Project();
            project.Set(Prj.StartDate, new DateTime(2015, 3, 6, 8, 0, 0));
            ExtendedAttributeDefinition attr = new ExtendedAttributeDefinition();
            project.ExtendedAttributes.Add(attr);
            attr.FieldId = ExtendedAttributeTask.Text1.ToString("D");
            Task task = project.RootTask.Children.Add("Task");
            ExtendedAttribute extendedAttribute = attr.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(extendedAttribute);
            Resource rsc = project.Resources.Add("Rsc");
            ResourceAssignment resourceAssignment = project.ResourceAssignments.Add(task, rsc);
            return project;
        }
    }
}