using System;
using Aspose.Tasks.Saving;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.ModifyingCreatedProject
{
    public class UsingTasksAndResourceFieldsInFormulaCalculations
    {
        public static void Run()
        {
            // ExStart:UsingTasksAndResourceFieldsInFormulaCalculations
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingCreatedProject();
            Project project = new Project();
            project.Set(Prj.StartDate, new DateTime(2015, 3, 6, 8, 0, 0));
            ExtendedAttributeDefinition extendedAttributeDefinition = new ExtendedAttributeDefinition();
            project.ExtendedAttributes.Add(extendedAttributeDefinition);
            extendedAttributeDefinition.FieldId = ExtendedAttributeTask.Text1.ToString("D");
            Task task = project.RootTask.Children.Add("Task");
            ExtendedAttribute extendedAttribute = extendedAttributeDefinition.CreateExtendedAttribute();
            task.ExtendedAttributes.Add(extendedAttribute);
            Resource rsc = project.Resources.Add("Rsc");
            ResourceAssignment assn = project.ResourceAssignments.Add(task, rsc);
            ExtendedAttributeDefinition extendedAttributeDefinition1 = project.ExtendedAttributes[0];
            extendedAttributeDefinition1.Alias = "Days from finish to deadline";
            extendedAttributeDefinition1.Formula = "[Deadline] - [Finish]";
            Task task1 = project.RootTask.Children.GetById(1);
            task.Set(Tsk.Deadline, new DateTime(2015, 3, 20, 17, 0, 0));
            project.Save(dataDir + "UsingTasksAndResourceFieldsInFormulaCalculations_out.mpp", SaveFileFormat.MPP);
            // ExEnd:UsingTasksAndResourceFieldsInFormulaCalculations            
        }
    }
}