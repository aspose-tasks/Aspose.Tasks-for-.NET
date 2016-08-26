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
    public class FormulaWithProjectFields
    {
        public static void Run()
        {
            // ExStart:FormulaWithProjectFields
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingCreatedProject();
            Project project = CreateTestProjectWithCustomFieldWithoutResource();
            project.ExtendedAttributes[0].Formula = "\"Total tasks: \" & [Task Count] & \" Total resources: \" & [Resource Count]";
            Task task = project.RootTask.Children.GetById(1);
            // ExEnd:FormulaWithProjectFields
        }

        static Project CreateTestProjectWithCustomFieldWithoutResource()
        {
            Project project = new Project();
            project.Set(Prj.StartDate, new DateTime(2015, 3, 6, 8, 0, 0));
            ExtendedAttributeDefinition attr = new ExtendedAttributeDefinition();
            project.ExtendedAttributes.Add(attr);
            attr.FieldId = ExtendedAttributeTask.Text1.ToString("D");
            Task task = project.RootTask.Children.Add("Task");
            ExtendedAttribute a = attr.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(a);
            return project;
        }
    }
}