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
    public class WriteFormulasInExtendedAttributesToMPPFileFormats
    {
        public static void Run()
        {
            // ExStart:WriteFormulasInExtendedAttributesToMPPFileFormats
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PrintingAndExporting();
            Project project = new Project(dataDir + "Project1.mpp");
            project.Set(Prj.NewTasksAreManual, false);
            // Create new custom field (Task Text1) with formula which will double task cost
            ExtendedAttributeDefinition attr = new ExtendedAttributeDefinition();
            project.ExtendedAttributes.Add(attr);
            attr.FieldId = ExtendedAttributeTask.Text1.ToString("D");
            attr.Alias = "Double Costs";
            attr.Formula = "[Cost]*2";
            // Add a task to see the result in MSP
            Task task = project.RootTask.Children.Add("Task");
            // Set task cost            
            task.Set(Tsk.Cost, 100);
            // See the result in the attached screenshot (result.jpg)
            project.Save(dataDir + "WriteFormulasInExtendedAttributesToMPPFileFormats_out.mpp", SaveFileFormat.MPP);            
            // ExEnd:WriteFormulasInExtendedAttributesToMPPFileFormats
        }
    }
}